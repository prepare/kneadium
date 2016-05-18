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

            CefTypeCollection cefTypeCollection = new CefTypeCollection();
            cefTypeCollection.CollectAllTypeDefinitions(compilationUnits);


            StringBuilder stbuilder = new StringBuilder();
            CodeTypeDeclaration found;
            if (cefTypeCollection.TryGetTypeDeclaration("CefBrowser", out found))
            {
                GenerateCsPart(found, stbuilder);
            }

            //---------------
            //build c/c++ side
            //---------------
            //build managed side
        }

        void GenerateCsPart(CodeTypeDeclaration typedecl, StringBuilder stbuilder)
        {
            stbuilder.Append("class ");
            stbuilder.Append(typedecl.Name);
            stbuilder.Append("{");

            foreach (CodeMemberDeclaration mb in typedecl.Members)
            {
                if (mb.MemberKind == CodeMemberKind.Method)
                {
                    CodeMethodDeclaration metDecl = (CodeMethodDeclaration)mb;
                    if (metDecl.MethodKind == MethodKind.Normal)
                    {

                        stbuilder.Append(metDecl.ReturnType);
                        stbuilder.Append(' ');
                        stbuilder.Append(metDecl.Name);
                        int j = metDecl.Parameters.Count;
                        stbuilder.Append('(');
                        for (int i = 0; i < j; ++i)
                        {
                            if (i > 0)
                            {
                                stbuilder.Append(',');
                            }
                            stbuilder.Append(metDecl.Parameters[i]);
                        }
                        stbuilder.Append(')');
                        stbuilder.Append('{');
                        //body of C# side
                        //just call api ***
                        stbuilder.Append('}');
                    }

                }
                else
                {
                }
            }

            stbuilder.Append("}");
        }


    }
}