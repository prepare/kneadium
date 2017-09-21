//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BridgeBuilder
{



    class CppToCsImplCodeGen
    {
        CodeCompilationUnit cu;
        List<CodeMethodDeclaration> methods;
        List<string> simpleLineList = new List<string>();

        public CppToCsImplCodeGen()
        {

        }
        public void Analyze(CodeCompilationUnit cu)
        {

            //cef specific code

            this.cu = cu;
            methods = new List<CodeMethodDeclaration>();
            CollectImplMethods();

            string onlyFileName = Path.GetFileName(cu.Filename);
            if (onlyFileName == "display_handler_cpptoc.cc")
            {
                simpleLineList.Clear();
                simpleLineList.AddRange(File.ReadAllLines(cu.Filename));
                //

                int classCutAt = onlyFileName.IndexOf("_cpptoc.");
                string c_className = onlyFileName.Substring(0, classCutAt);
                int c_classNameLen = c_className.Length;
                string cppClassName = "Cef" + ConvertToCppName(c_className);
                string cppExtNamespaceName = cppClassName + "Ext";


                for (int i = methods.Count - 1; i >= 0; --i) //backward, since we are going to insert a new line to the line list
                {
                    StringBuilder newCodeStBuilder = new StringBuilder();

                    CodeMethodDeclaration metDecl = methods[i];
                    int methodCutAt = c_classNameLen + 1;
                    string c_methodName = metDecl.Name.Substring(methodCutAt);
                    string cppMethodName = ConvertToCppName(c_methodName);

                    newCodeStBuilder.AppendLine("//-----");
                    //some method parameters may need special preparation.
                    newCodeStBuilder.AppendLine("auto me = " + cppClassName + "CppToC::Get(self);");
                    newCodeStBuilder.AppendLine("auto m_callback= me->GetManagedCallBack();");
                    newCodeStBuilder.AppendLine("if(m_callback){"); //TODO: + method filter                  

                    int parCount = metDecl.Parameters.Count;
                    List<string> argCodeList = new List<string>();

                    for (int a = 1; a < parCount; ++a)
                    {
                        //start at 1
                        CodeMethodParameter par = metDecl.Parameters[a];
                        string parType = par.ParameterType.ToString();
                        switch (parType)
                        {
                            default:
                                {
                                    argCodeList.Add(par.ParameterName);
                                }
                                break;
                            case "cef_string_list_t":
                                {
                                    //cef-specific
                                    //new var name
                                    argCodeList.Add("&" + par.ParameterName + "List");
                                }
                                break;
                            case "cef_string_t*":
                                {
                                    string newArgName = "tmp_arg" + a;
                                    newCodeStBuilder.AppendLine("CefString " + newArgName + " (" + par.ParameterName + ");");
                                    argCodeList.Add(newArgName);
                                }
                                break;
                        }

                    }

                    //prepare cpp' method args
                    //convention                     
                    newCodeStBuilder.Append(cppExtNamespaceName + "::" + cppMethodName + "Args args1(");
                    for (int a = 1; a < parCount; ++a)
                    {
                        if (a > 1)
                        {
                            newCodeStBuilder.Append(',');
                        }
                        //start at 1
                        CodeMethodParameter par = metDecl.Parameters[a];
                        newCodeStBuilder.Append(argCodeList[a - 1]);
                    }
                    newCodeStBuilder.AppendLine(");");
                    //
                    //invoke managed del
                    //cef-specific
                    //m_callback((CefDisplayHandlerExt::_typeName << 16) | CefDisplayHandlerExt::CefDisplayHandlerExt_OnAddressChange_1, &args1.arg);
                    newCodeStBuilder.Append("m_callback((" + cppExtNamespaceName + "::_typeName <<16) | " + cppExtNamespaceName + "::" + cppExtNamespaceName + "_" + cppMethodName + "_" + (i + 1));
                    newCodeStBuilder.Append(", &args1.arg);");
                    newCodeStBuilder.AppendLine();
                    //

                    //method return value may need special preparation.
                    newCodeStBuilder.AppendLine("}"); //TODO: + method filter
                    newCodeStBuilder.AppendLine("//-----");
                    //-----
                    //find insert point
                    if (!metDecl.HasMethodBody)
                    {
                        throw new NotSupportedException();
                    }

                    int insertAtLine = FindProperInsertPoint(simpleLineList, metDecl.StartAtLine, metDecl.EndAtLine);
                    if (insertAtLine > 0)
                    {
                        //just replace
                        simpleLineList.Insert(insertAtLine, newCodeStBuilder.ToString());
                    }
                    //-----
                }


                //save the modified file
                using (FileStream fs = new FileStream("d:\\WImageTest\\test001_01.cpp", FileMode.Create))
                using (StreamWriter w = new StreamWriter(fs))
                {
                    int j = simpleLineList.Count;
                    for (int i = 0; i < j; ++i)
                    {
                        w.WriteLine(simpleLineList[i]);
                    }
                    w.Close();
                }

            }


        }
        static int FindProperInsertPoint(List<string> lines, int begin, int end)
        {
            for (int i = begin; i <= end; ++i)
            {
                //easy, we insert before //EXECUTION comment
                string line = lines[i].Trim();
                if (line.StartsWith("// Execute"))
                {
                    return i;
                }
            }

            return -1; //not found
        }
        static string ConvertToCppName(string c_className)
        {
            string[] splits = c_className.Split('_');
            StringBuilder stbuilder = new StringBuilder();
            int j = splits.Length;
            for (int i = 0; i < j; ++i)
            {

                string split = MakeFirstLetterUpperCase(splits[i]);
                //cef-specific
                ModifySomeCefSpecificName(ref split);
                stbuilder.Append(split);
            }
            return stbuilder.ToString();
        }

        static void ModifySomeCefSpecificName(ref string cefName)
        {
            if (cefName.StartsWith("Url"))
            {
                if (cefName.Length > 3)
                {
                    cefName = "URL" + MakeFirstLetterUpperCase(cefName.Substring(3));
                }
            }
        }
        static string MakeFirstLetterUpperCase(string name)
        {
            return char.ToUpper(name[0]) + name.Substring(1);
        }
        void CollectImplMethods()
        {
            int typeCount = cu.TypeCount;
            if (typeCount > 0)
            {

            }
            //
            CodeTypeDeclaration globalTypeDecl = cu.GlobalTypeDecl;
            if (globalTypeDecl == null)
            {
                return;
            }
            foreach (CodeMemberDeclaration mb in globalTypeDecl.GetMemberIter())
            {
                switch (mb.MemberKind)
                {
                    case CodeMemberKind.Type:
                        {
                            CodeTypeDeclaration typedecl = (CodeTypeDeclaration)mb;
                            if (typedecl.Kind == TypeKind.Namespace)
                            {
                                foreach (CodeMemberDeclaration mb_1 in typedecl.GetMemberIter())
                                {
                                    //check 
                                    switch (mb_1.MemberKind)
                                    {
                                        case CodeMemberKind.Method:
                                            {
                                                methods.Add((CodeMethodDeclaration)mb_1);
                                            }
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                throw new NotSupportedException();
                            }
                        }
                        break;
                }
            }
        }
    }
}