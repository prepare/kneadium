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


            StringBuilder stbuilder = new StringBuilder();
            CodeTypeDeclaration found;
            if (cefTypeCollection.TryGetTypeDeclaration("CefBrowser", out found))
            {
                GenerateCsPart(found, stbuilder);
            }
            File.WriteAllText("d:\\WImageTest\\cs_output.cs", stbuilder.ToString());
            //---------------
            //build c/c++ side
            //---------------
            //build managed side
        }

        void GenerateCsPart(CodeTypeDeclaration typedecl, StringBuilder stbuilder)
        {
            stbuilder.Append("class ");
            stbuilder.Append(typedecl.Name);
            stbuilder.Append("{\r\n");
            stbuilder.Append("   IntPtr nativePtr;\r\n");

            foreach (CodeMemberDeclaration mb in typedecl.Members)
            {
                if (mb.MemberKind == CodeMemberKind.Method)
                {
                    CodeMethodDeclaration metDecl = (CodeMethodDeclaration)mb;
                    if (metDecl.MethodKind == MethodKind.Normal)
                    {
                        GenMethod(metDecl, stbuilder);
                        stbuilder.Append("\r\n");
                    }
                }
                else
                {

                }
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

        string GetCsPartTypeName(TypeSymbol t)
        {

            switch (t.TypeSymbolKind)
            {
                case TypeSymbolKind.Simple:
                    {
                        return ((SimpleType)t).Name;
                    }
                case TypeSymbolKind.ReferenceOrPointer:
                    {
                        var containerTypeSymbol = (ReferenceOrPointerTypeSymbol)t;
                        switch (containerTypeSymbol.Kind)
                        {
                            default:
                                throw new NotSupportedException();
                            case ContainerTypeKind.ByRef:
                                TypeSymbol content = containerTypeSymbol.ElementType;
                                if (!IsPrimitiveType(content))
                                {
                                    return GetCsPartTypeName(containerTypeSymbol.ElementType);
                                }
                                else
                                {
                                }
                                break;
                                throw new NotSupportedException();
                            case ContainerTypeKind.CefRefPtr:

                                if (!IsPrimitiveType(containerTypeSymbol.ElementType))
                                {
                                    return GetCsPartTypeName(containerTypeSymbol.ElementType);
                                }
                                else
                                {
                                }
                                break;
                                throw new NotSupportedException();
                            case ContainerTypeKind.Pointer:
                                throw new NotSupportedException();
                                if (!IsPrimitiveType(containerTypeSymbol.ElementType))
                                {

                                }
                                else
                                {
                                }
                                break;
                            case ContainerTypeKind.ScopePtr:
                                throw new NotSupportedException();
                                if (!IsPrimitiveType(containerTypeSymbol.ElementType))
                                {

                                }
                                else
                                {
                                }
                                break;

                        }

                    }
                    break;
                default: throw new NotSupportedException();
            }
            throw new NotSupportedException();
        }
        void GenMethodParameter(CodeMemberDeclaration metDecl, CodeMethodParameter par, StringBuilder stbuilder)
        {
            if (par.IsConstPar)
            {

            }
            stbuilder.Append(GetCsPartTypeName(par.ParameterType.ResolvedType));
        }
        void GenMethod(CodeMethodDeclaration metDecl, StringBuilder codeDeclTypeBuilder)
        {
            StringBuilder stbuilder = new StringBuilder();

            stbuilder.Append(GetCsPartTypeName(metDecl.ReturnType.ResolvedType));

            stbuilder.Append(' ');

#if DEBUG
            if (metDecl.Name == "GetFrame")
            {

            }
#endif


            stbuilder.Append(metDecl.Name);

            int j = metDecl.Parameters.Count;
            stbuilder.Append('(');
            for (int i = 0; i < j; ++i)
            {
                if (i > 0)
                {
                    stbuilder.Append(',');
                }

                var par = metDecl.Parameters[i];
                GenMethodParameter(metDecl, par, stbuilder);

                stbuilder.Append(' ');
                stbuilder.Append(par.ParameterName);
            }
            stbuilder.Append(')');
            stbuilder.Append('{');
            stbuilder.Append("\r\n");
            //body of C# side
            //just call api ***
            if (j > 1)
            {

            }

            string nativeMethodName = null;
            bool isVoid = false;
            TypeSymbol retType = metDecl.ReturnType.ResolvedType;
            switch (retType.TypeSymbolKind)
            {
                default:
                    throw new NotSupportedException();
                case TypeSymbolKind.Vec:

                    throw new NotFiniteNumberException();
                case TypeSymbolKind.ReferenceOrPointer:
                    {
                        var containerTypeSymbol = (ReferenceOrPointerTypeSymbol)retType;
                        switch (containerTypeSymbol.Kind)
                        {
                            case ContainerTypeKind.ByRef:
                                break;
                            case ContainerTypeKind.CefRefPtr:

                                break;
                            case ContainerTypeKind.Pointer:
                                break;
                            case ContainerTypeKind.ScopePtr:
                                break;
                        }
                        nativeMethodName = "mycef_ref";
                    }
                    break;
                case TypeSymbolKind.Simple:

                    var retSimpleType = (SimpleType)retType;
                    switch (retSimpleType.Name)
                    {
                        case "bool":
                            {
                                nativeMethodName = "mycef_bool";
                            } break;
                        case "int":
                            {
                                nativeMethodName = "mycef_int";
                            } break;
                        case "void":
                            {
                                //no return type
                                isVoid = true;
                                nativeMethodName = "mycef_void";
                            } break;
                        case "size_t":
                            {
                                nativeMethodName = "mycef_sizet";//platform specific
                            } break;
                        default:
                            {

                            } break;
                    }
                    break;
            }

            if (!isVoid)
            {
                stbuilder.Append("    return ");
            }
            else
            {
                stbuilder.Append("    ");
            }

            if (nativeMethodName == null)
            {
                throw new NotSupportedException();
            }


            stbuilder.Append(nativeMethodName + "(11,11,this.nativePtr");


            for (int i = 0; i < j; ++i)
            {
                stbuilder.Append(',');
                //prepare parameter for native side

                CodeMethodParameter pp = metDecl.Parameters[i];
                stbuilder.Append(pp.ParameterName);

            }
            stbuilder.Append(");\r\n");

            //---------------------------
            stbuilder.Append('}');
            codeDeclTypeBuilder.Append(stbuilder.ToString());
        }

    }
}
