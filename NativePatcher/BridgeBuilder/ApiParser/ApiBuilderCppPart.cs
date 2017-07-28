//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeBuilder
{

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
                arglistBuilder.Append("v" + (i + 1));
                arglistBuilder.Append("->");



                //if (par.DotnetResolvedType is DotNetResolvedSimpleType)
                //{
                //    DotNetResolvedSimpleType simpleType = (DotNetResolvedSimpleType)par.DotnetResolvedType;
                //    if (simpleType.IsPrimitiveType)
                //    {
                //        arglistBuilder.Append("v" + (i + 1));
                //        switch (simpleType.Name)
                //        {
                //            case "bool":
                //                arglistBuilder.AppendLine("->i32");
                //                break;
                //            case "int":
                //                arglistBuilder.AppendLine("->i32");
                //                break;
                //            case "int64":
                //                arglistBuilder.AppendLine("->i64");
                //                break;
                //            default:
                //                throw new NotSupportedException();
                //        }
                //    }
                //    else
                //    {
                //        if (simpleType.Name == "CefString")
                //        {
                //            //get data inside MyCefStringHolder*
                //            arglistBuilder.Append("((MyCefStringHolder*)");
                //            arglistBuilder.Append("v" + (i + 1) + "->ptr");
                //            arglistBuilder.AppendLine(")->value");
                //        }
                //        else
                //        {
                //            //eg. cefFrame1->GetSource(CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)v1->ptr));

                //            arglistBuilder.Append(simpleType.Name + "CppToC::Unwrap((cef_string_visitor_t*)");
                //            arglistBuilder.Append("v" + (i + 1));
                //            arglistBuilder.AppendLine("->ptr)");
                //        }

                //    }
                //}
                //else if (par.DotnetResolvedType is DotNetList)
                //{
                //    //std::vector
                //    DotNetList simpleType = (DotNetList)par.DotnetResolvedType;
                //    arglistBuilder.Append("(std::vector<" + ((DotNetResolvedSimpleType)simpleType.ElementType).Name + ">)");
                //    arglistBuilder.Append("v" + (i + 1));
                //    arglistBuilder.AppendLine("->ptr");
                //}
                //else
                //{

                //}

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
                //DotNetResolvedTypeBase retType = ret.DotnetResolvedType;
                //if (retType is DotNetResolvedSimpleType)
                //{
                //    DotNetResolvedSimpleType simpleType = (DotNetResolvedSimpleType)retType;
                //    if (simpleType.IsPrimitiveType)
                //    {
                //        //---------------------------------
                //        //native object
                //        stbuilder.Append("auto ret_result=");
                //        stbuilder.Append("bw->" + met.Name + "(");
                //        stbuilder.Append(arglistBuilder.ToString());
                //        stbuilder.Append(");\r\n");
                //        //---------------------------------

                //        switch (simpleType.Name)
                //        {
                //            case "bool":
                //                stbuilder.AppendLine("ret->type = JSVALUE_TYPE_BOOLEAN;");
                //                stbuilder.AppendLine("ret->i32 = ret_result?1:0;");
                //                break;
                //            case "int64":
                //            case "int":
                //                stbuilder.AppendLine("ret->type = JSVALUE_TYPE_INTEGER64;");
                //                stbuilder.AppendLine("ret->i64 = ret_result;");
                //                break;

                //            default:
                //                throw new NotSupportedException();
                //        }
                //    }
                //    else
                //    {
                //        //---------------------------------
                //        //native object
                //        stbuilder.Append("auto ret_result=");
                //        stbuilder.Append("bw->" + met.Name + "(");
                //        stbuilder.Append(arglistBuilder.ToString());
                //        stbuilder.Append(");\r\n");
                //        //---------------------------------

                //        if (simpleType.Name == "CefString")
                //        {
                //            //create string holder
                //            stbuilder.AppendLine("MyCefStringHolder* str = new MyCefStringHolder();");
                //            stbuilder.AppendLine("str->value=ret_result;");
                //            //
                //            stbuilder.AppendLine("ret->i32=ret_result.length();");
                //            stbuilder.AppendLine("ret->ptr=str;");
                //            stbuilder.AppendLine("ret->type=JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING;");

                //        }
                //        else
                //        {
                //            //native object
                //            //select and unwrapp or wrap the result

                //            //
                //            stbuilder.AppendLine("ret->type = JSVALUE_TYPE_WRAPPED;");
                //            stbuilder.AppendLine("ret->ptr =" + simpleType + "CToCpp::Unwrap(ret_result);");
                //        }
                //    }
                //    stbuilder.AppendLine("CefFrameCToCpp::Unwrap(" + "bw" + ");");
                //}
                //else
                //{

                //}
            }
        }

    }

}
