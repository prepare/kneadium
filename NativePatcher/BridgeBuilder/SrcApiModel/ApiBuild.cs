//2016, MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
        public void Build(string[] apiFolders, string[] exludeFileNames)
        {
            List<string> onlyHeaders = new List<string>();
            foreach (var folderName in apiFolders)
            {
                string[] files = Directory.GetFiles(folderName);
                foreach (var filename in files)
                {
                    if (filename.EndsWith(".h"))
                    {
                        if (IsExcludeFile(Path.GetFileName(filename), exludeFileNames))
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

            TypeTranformPlanner typeTxPlanner = new TypeTranformPlanner(cefTypeCollection);

            StringBuilder stbuilder = new StringBuilder();
            CodeTypeDeclaration found;
            if (cefTypeCollection.TryGetTypeDeclaration("CefBrowser", out found))
            {
                //1. make transform plan
                TypeTxInfo txInfo = typeTxPlanner.MakeTransformPlan(found);
                //2. generate
                GenerateCsPart(txInfo, stbuilder);
            }
            File.WriteAllText("d:\\WImageTest\\cs_output.cs", stbuilder.ToString());
            //---------------
            //build c/c++ side
            //---------------
            //build managed side
        }


        void GenerateCsPart(TypeTxInfo typeTxInfo, StringBuilder stbuilder)
        {

            CodeTypeDeclaration typedecl = typeTxInfo.TypeDecl;
            stbuilder.Append("class ");
            stbuilder.Append(typedecl.Name);
            stbuilder.Append("{\r\n");
            stbuilder.Append("   IntPtr nativePtr;\r\n");

            foreach (MethodTxInfo met in typeTxInfo.methods)
            {
                GenMethod(met, stbuilder);
                stbuilder.Append("\r\n");
            }
 
            stbuilder.Append("}");
        }

        bool IsPrimitiveType(TypeSymbol t)
        {
            var ss = t as SimpleType;
            if (ss != null)
            {
                switch (ss.Name)
                {
                    case "void":
                    case "int":
                    case "bool":
                    case "int64":
                        return true;
                }
            }
            return false;
        }

       
        void GenMethod(MethodTxInfo metTx, StringBuilder codeDeclTypeBuilder)
        {
            StringBuilder stbuilder = new StringBuilder();
            //1. return type
            MethodReturnParameterTxInfo retType = metTx.ReturnPlan;
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

            //body
            if (!retType.IsVoid)
            {
                stbuilder.Append("   return ");
            }
            else
            {
                stbuilder.Append("   ");
            }

            //native method name
            stbuilder.Append("cef_call(1,1,this.nativePtr");
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
