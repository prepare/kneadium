﻿//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace BridgeBuilder
{
    class ApiBuilderCsPart
    {
        CefTypeCollection cefTypeCollection = new CefTypeCollection();
          
        public void GenerateCsType(TypeTxInfo typeTxInfo, StringBuilder stbuilder)
        {

            CodeTypeDeclaration typedecl = typeTxInfo.TypeDecl;
            stbuilder.Append("public partial class ");
            stbuilder.Append(typedecl.Name);
            stbuilder.Append("{\r\n");
            stbuilder.Append(" public  IntPtr nativePtr;\r\n");
            //-----
            //ctor
            stbuilder.AppendLine("internal " + typedecl.Name + "(IntPtr nativePtr){");
            stbuilder.Append("this.nativePtr= nativePtr;");
            stbuilder.AppendLine("}");
            //-----
            foreach (MethodTxInfo met in typeTxInfo.methods)
            {
                GenCsMethod(met, stbuilder);
                stbuilder.Append("\r\n");
            }

            stbuilder.Append("}");
        }
      

        string GetTypeName(MethodParameterTxInfo methodParInfo)
        {
            string typeName = methodParInfo.ToString();
            switch (typeName)
            {
                case "CefString":
                    {
                        return "string";
                    }
                case "int64":
                    {
                        return "long";
                    }
                default:
                    return typeName;
            }
        }
        public void GenCsMethod(MethodTxInfo metTx, StringBuilder codeDeclTypeBuilder)
        {
            StringBuilder stbuilder = new StringBuilder();
            stbuilder.Append("public ");
            //1. return type 
            MethodParameterTxInfo retType = metTx.ReturnPlan;
            stbuilder.Append(GetTypeName(retType));
            //
            stbuilder.Append(' ');
            //2. name
            stbuilder.Append(metTx.Name);
            //3.
            int argCount = metTx.pars.Count;
            stbuilder.Append('(');
            if (argCount > 5)
            {
                throw new NotSupportedException();
            }
            for (int i = 0; i < argCount; ++i)
            {
                if (i > 0)
                {
                    stbuilder.Append(',');
                }

                MethodParameterTxInfo par = metTx.pars[i];
                stbuilder.Append(GetTypeName(par));
                stbuilder.Append(' ');
                stbuilder.Append(par.Name);
            }
            stbuilder.Append("){\r\n");
            stbuilder.AppendLine();
            stbuilder.AppendLine("//autogen!");

            //body
            //prepare calling parameters
            stbuilder.AppendLine(@"
            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;");

            for (int i = 0; i < argCount; ++i)
            {
                string assignTo = "a" + (i + 1);


                MethodParameterTxInfo par = metTx.pars[i];
                string parResolvedType = par.DotnetResolvedType.ToString();
                switch (parResolvedType)
                {
                    default:
                        {
                            if (parResolvedType.StartsWith("Cef"))
                            {
                                //native reference type
                                stbuilder.AppendLine(assignTo + ".Type=JsValueType.Wrapped;");
                                stbuilder.AppendLine(assignTo + ".Ptr=" + par.Name + ".nativePtr;");
                            }
                            else
                            {
                                throw new NotSupportedException();
                            }

                        }
                        break;
                    case "int":
                        {
                            //use as int32 
                            stbuilder.AppendLine(assignTo + ".Type=JsValueType.Integer;");
                            stbuilder.AppendLine(assignTo + ".I32=" + par.Name + ";");
                        }
                        break;
                    case "CefString":
                        {
                            //eg. Cef3Binder.MyCefCreateNativeStringHolder(ref a1, strValue);
                            stbuilder.AppendLine("Cef3Binder.MyCefCreateNativeStringHolder(ref " +
                                assignTo + "," + par.Name + ");");
                        }
                        break;
                }

            }


            //assign parameter value
            stbuilder.Append("Cef3Binder.MyCefFrameCall2(");
            stbuilder.Append("this.nativePtr,\r\n" +
                "(int)CefFrameCallMsg.CefFrame_" + metTx.Name
                + ",out ret,ref a1,ref a2");
            stbuilder.AppendLine(");");
            //
            if (!retType.IsVoid)
            {
                //if not void
                DotNetResolvedSimpleType simpleType = retType.DotnetResolvedType as DotNetResolvedSimpleType;
                if (simpleType != null)
                {
                    //this is simple type
                    string retName = simpleType.SimpleType.Name;
                    switch (retName)
                    {
                        default:
                            {
                                if (retName.StartsWith("Cef"))
                                {
                                    stbuilder.AppendLine("return new " + retName + "(ret.Ptr);");
                                }
                                else
                                {

                                }
                            }
                            break;
                        case "int64":
                            {
                                stbuilder.AppendLine("return ret.I64;");
                            }
                            break;
                        case "CefString":
                            {
                                //return cef string
                                stbuilder.AppendLine("return Cef3Binder.MyCefJsReadString(ref ret);");
                            }
                            break;
                        case "bool":
                            {
                                stbuilder.AppendLine("return ret.I32 !=0;");
                            }
                            break;
                    }
                }
                else
                {
                    throw new NotSupportedException();
                }

            }
            stbuilder.Append("}\r\n");

            codeDeclTypeBuilder.Append(stbuilder.ToString());
        }

    }
    class ApiBuilderCppPart
    {
        public void GenerateCppPart(TypeTxInfo typeTxInfo, StringBuilder stbuilder)
        {

            Dictionary<MethodTxInfo, StringBuilder> results = new Dictionary<MethodTxInfo, StringBuilder>();

            foreach (MethodTxInfo met in typeTxInfo.methods)
            {
                StringBuilder metStBuilder = new StringBuilder();
                GenerateCppPart(met, metStBuilder);
                results.Add(met, metStBuilder);
            }

            //build switch table

            int caseNum = 0;

            int count = results.Count;
            stbuilder.AppendLine("switch(methodName){");
            foreach (var kp in results)
            {

                stbuilder.AppendLine("case " + caseNum + ":{");
                stbuilder.AppendLine(kp.Value.ToString());
                stbuilder.AppendLine("} break;");
                caseNum++;
            }
            stbuilder.AppendLine("}");

        }
        public void GenerateCppPart(MethodTxInfo met, StringBuilder stbuilder)
        {


            MethodParameterTxInfo ret = met.ReturnPlan;
            //----
            List<MethodParameterTxInfo> pars = met.pars;
            int parCount = pars.Count;
            if (parCount > 2)
            {
                //throw new NotSupportedException();
                return;
            }
            StringBuilder arglistBuilder = new StringBuilder();
            for (int i = 0; i < parCount; ++i)
            {
                //get pars from parameter
                if (i > 0)
                {
                    arglistBuilder.Append(',');
                }

                MethodParameterTxInfo par = pars[i];

                if (par.DotnetResolvedType is DotNetResolvedSimpleType)
                {
                    DotNetResolvedSimpleType simpleType = (DotNetResolvedSimpleType)par.DotnetResolvedType;
                    if (simpleType.IsPrimitiveType)
                    {
                        arglistBuilder.Append("v" + (i + 1));
                        switch (simpleType.Name)
                        {
                            case "bool":
                                arglistBuilder.AppendLine("->i32");
                                break;
                            case "int":
                                arglistBuilder.AppendLine("->i32");
                                break;
                            case "int64":
                                arglistBuilder.AppendLine("->i64");
                                break;
                            default:
                                throw new NotSupportedException();
                        }
                    }
                    else
                    {
                        if (simpleType.Name == "CefString")
                        {
                            //get data inside MyCefStringHolder*
                            arglistBuilder.Append("((MyCefStringHolder*)");
                            arglistBuilder.Append("v" + (i + 1) + "->ptr");
                            arglistBuilder.AppendLine(")->value");
                        }
                        else
                        {
                            //eg. cefFrame1->GetSource(CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)v1->ptr));

                            arglistBuilder.Append(simpleType.Name + "CppToC::Unwrap((cef_string_visitor_t*)");
                            arglistBuilder.Append("v" + (i + 1));
                            arglistBuilder.AppendLine("->ptr)");
                        }

                    }
                }
                else if (par.DotnetResolvedType is DotNetList)
                {
                    //std::vector
                    DotNetList simpleType = (DotNetList)par.DotnetResolvedType;
                    arglistBuilder.Append("(std::vector<" + ((DotNetResolvedSimpleType)simpleType.ElementType).Name + ">)");
                    arglistBuilder.Append("v" + (i + 1));
                    arglistBuilder.AppendLine("->ptr");
                }
                else
                {

                }

            }

            //----
            if (ret.IsVoid)
            {
                //call ba
                stbuilder.Append("bw->" + met.Name + "(");
                stbuilder.Append(arglistBuilder.ToString());
                stbuilder.Append(");\r\n");
                stbuilder.Append("ret->type = JSVALUE_TYPE_EMPTY;");

            }
            else
            {
                //has some ret type
                DotNetResolvedTypeBase retType = ret.DotnetResolvedType;
                if (retType is DotNetResolvedSimpleType)
                {
                    DotNetResolvedSimpleType simpleType = (DotNetResolvedSimpleType)retType;
                    if (simpleType.IsPrimitiveType)
                    {
                        //---------------------------------
                        //native object
                        stbuilder.Append("auto ret_result=");
                        stbuilder.Append("bw->" + met.Name + "(");
                        stbuilder.Append(arglistBuilder.ToString());
                        stbuilder.Append(");\r\n");
                        //---------------------------------

                        switch (simpleType.Name)
                        {
                            case "bool":
                                stbuilder.AppendLine("ret->type = JSVALUE_TYPE_BOOLEAN;");
                                stbuilder.AppendLine("ret->i32 = ret_result?1:0;");
                                break;
                            case "int64":
                            case "int":
                                stbuilder.AppendLine("ret->type = JSVALUE_TYPE_INTEGER64;");
                                stbuilder.AppendLine("ret->i64 = ret_result;");
                                break;

                            default:
                                throw new NotSupportedException();
                        }
                    }
                    else
                    {
                        //---------------------------------
                        //native object
                        stbuilder.Append("auto ret_result=");
                        stbuilder.Append("bw->" + met.Name + "(");
                        stbuilder.Append(arglistBuilder.ToString());
                        stbuilder.Append(");\r\n");
                        //---------------------------------

                        if (simpleType.Name == "CefString")
                        {
                            //create string holder
                            stbuilder.AppendLine("MyCefStringHolder* str = new MyCefStringHolder();");
                            stbuilder.AppendLine("str->value=ret_result;");
                            //
                            stbuilder.AppendLine("ret->i32=ret_result.length();");
                            stbuilder.AppendLine("ret->ptr=str;");
                            stbuilder.AppendLine("ret->type=JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING;");

                        }
                        else
                        {
                            //native object
                            //select and unwrapp or wrap the result

                            //
                            stbuilder.AppendLine("ret->type = JSVALUE_TYPE_WRAPPED;");
                            stbuilder.AppendLine("ret->ptr =" + simpleType + "CToCpp::Unwrap(ret_result);");
                        }
                    }
                    stbuilder.AppendLine("CefFrameCToCpp::Unwrap(" + "bw" + ");");
                }
                else
                {

                }
            }
        }

    }
}
