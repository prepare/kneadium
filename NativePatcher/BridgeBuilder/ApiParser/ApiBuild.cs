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
            stbuilder.Append("class ");
            stbuilder.Append(typedecl.Name);
            stbuilder.Append("{\r\n");
            stbuilder.Append("   IntPtr nativePtr;\r\n");

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


        public void GenCsMethod(MethodTxInfo metTx, StringBuilder codeDeclTypeBuilder)
        {
            StringBuilder stbuilder = new StringBuilder();
            //1. return type
            MethodParameterTxInfo retType = metTx.ReturnPlan;
            stbuilder.Append(retType.ToString());
            stbuilder.Append(' ');
            //2. name
            stbuilder.Append(metTx.Name);
            //3.
            int j = metTx.pars.Count;
            stbuilder.Append('(');
            for (int i = 0; i < j; ++i)
            {
                if (i > 0)
                {
                    stbuilder.Append(',');
                }

                MethodParameterTxInfo par = metTx.pars[i];
                stbuilder.Append(par.DotnetResolvedType.ToString());
                stbuilder.Append(' ');
                stbuilder.Append(par.Name);
            }
            stbuilder.Append("){\r\n");

            //-------



            //-------
            //body
            if (!retType.IsVoid)
            {
                stbuilder.Append("   return ");
            }
            else
            {
                stbuilder.Append("   ");
            }

            //select proper native cef method    
            string nativeMethodName = null;
            if (retType.DotnetResolvedType.IsPrimitiveType)
            {
                var dnSimpleType = (DotNetResolvedSimpleType)retType.DotnetResolvedType;
                nativeMethodName = "cefcall_" + dnSimpleType.Name;
            }
            else
            {
                nativeMethodName = "cefcall_ptr";
            }
            if (nativeMethodName == null)
            {
                throw new NotSupportedException();
            }
            //native method name
            stbuilder.Append(nativeMethodName + "(1,1,this.nativePtr");
            for (int i = 0; i < j; ++i)
            {
                stbuilder.Append(',');
                //prepare parameter for native side 
                MethodParameterTxInfo par = metTx.pars[i];
                stbuilder.Append(par.Name);
            }
            stbuilder.Append(");\r\n");


            stbuilder.Append("}\r\n");

            codeDeclTypeBuilder.Append(stbuilder.ToString());
        }

    }
}
