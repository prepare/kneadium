//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
namespace BridgeBuilder
{
    class ApiBuilder
    {
        CefTypeCollection cefTypeCollection = new CefTypeCollection();
        static bool IsExcludeFile(string thisfileName, string[] excludeFileNames)
        {
            for (int i = excludeFileNames.Length - 1; i >= 0; --i)
            {
                if (excludeFileNames[i] == thisfileName)
                {
                    return true;
                }
            }
            return false;
        }
        public void Build(string[] apiFolders, string[] excludeFileNames)
        {
            List<string> onlyHeaders = new List<string>();
            foreach (var folderName in apiFolders)
            {
                string[] files = Directory.GetFiles(folderName);
                foreach (var filename in files)
                {
                    if (filename.EndsWith(".h"))
                    {
                        if (IsExcludeFile(Path.GetFileName(filename), excludeFileNames))
                        {
                            //skip this
                            continue;
                        }
                        onlyHeaders.Add(filename);
                    }
                }
            }

            List<CodeCompilationUnit> compilationUnits = new List<CodeCompilationUnit>();
            foreach (var filename in onlyHeaders)
            {
                var headerParser = new Cef3HeaderFileParser();
#if DEBUG

#endif
                headerParser.Parse(filename);
                compilationUnits.Add(headerParser.Result);
            }


            cefTypeCollection.CollectAllTypeDefinitions(compilationUnits);

            TypeTranformPlanner typeTxPlanner = new TypeTranformPlanner();

            StringBuilder stbuilder = new StringBuilder();
            CodeTypeDeclaration found;
            if (cefTypeCollection.TryGetTypeDeclaration("CefBrowser", out found))
            {
                //1. make transform plan
                TypeTxInfo txInfo = typeTxPlanner.MakeTransformPlan(found);
                //2. generate
                GenerateCsType(txInfo, stbuilder);
            }
            File.WriteAllText("d:\\WImageTest\\cs_output.cs", stbuilder.ToString());
            //---------------
            //build c/c++ side
            //---------------
            //build managed side
        }


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
                        arglistBuilder.Append("(" + simpleType.Name + "*)");
                        arglistBuilder.Append("v" + (i + 1));
                        arglistBuilder.AppendLine("->ptr");
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
                        //native object
                        stbuilder.Append("auto ret_result=");
                        stbuilder.Append("bw->" + met.Name + "(");
                        stbuilder.Append(arglistBuilder.ToString());
                        stbuilder.Append(");\r\n");
                        //
                        stbuilder.AppendLine("ret->type = JSVALUE_TYPE_WRAPPED;");
                        stbuilder.AppendLine("ret->ptr = ret_result;");
                    }
                }
                else
                {

                }
            }
        }

        //bool IsPrimitiveType(TypeSymbol t)
        //{
        //    var ss = t as SimpleType;
        //    if (ss != null)
        //    {
        //        switch (ss.Name)
        //        {
        //            case "void":
        //            case "int":
        //            case "bool":
        //            case "int64":
        //                return true;
        //        }
        //    }
        //    return false;
        //}

        //#define JSVALUE_TYPE_UNKNOWN_ERROR  -1
        //#define JSVALUE_TYPE_EMPTY			 0
        //#define JSVALUE_TYPE_NULL            1
        //#define JSVALUE_TYPE_BOOLEAN         2
        //#define JSVALUE_TYPE_INTEGER         3
        //#define JSVALUE_TYPE_NUMBER          4
        //#define JSVALUE_TYPE_STRING          5 //unicode string
        //#define JSVALUE_TYPE_DATE            6
        //#define JSVALUE_TYPE_INDEX           7
        //#define JSVALUE_TYPE_ARRAY          10
        //#define JSVALUE_TYPE_STRING_ERROR   11
        //#define JSVALUE_TYPE_MANAGED        12
        //#define JSVALUE_TYPE_MANAGED_ERROR  13
        //#define JSVALUE_TYPE_WRAPPED        14
        //#define JSVALUE_TYPE_DICT           15
        //#define JSVALUE_TYPE_ERROR          16
        //#define JSVALUE_TYPE_FUNCTION       17

        //#define JSVALUE_TYPE_JSTYPEDEF      18 //my extension
        //#define JSVALUE_TYPE_INTEGER64      19 //my extension
        //#define JSVALUE_TYPE_BUFFER         20 //my extension

        //#define JSVALUE_TYPE_NATIVE_CEFSTRING 30  //my extension
        //#define JSVALUE_TYPE_NATIVE_CEFHOLDER_STRING 31//my extension
        //#define JSVALUE_TYPE_MANAGED_CB 32
        //#define JSVALUE_TYPE_MEM_ERROR      50 //my extension



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
}
