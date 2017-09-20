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
        public void Analyze(CodeCompilationUnit cu)
        {

            //cef specific code

            this.cu = cu;
            methods = new List<CodeMethodDeclaration>();
            CollectImplMethods();

            string onlyFileName = Path.GetFileName(cu.Filename);
            if (onlyFileName == "display_handler_cpptoc.cc")
            {
                int classCutAt = onlyFileName.IndexOf("_cpptoc.");
                string c_className = onlyFileName.Substring(0, classCutAt);
                int c_classNameLen = c_className.Length;
                string cppClassName = "Cef" + ConvertToCppName(c_className);
                string cppExtNamespaceName = cppClassName + "Ext";

                int j = methods.Count;
                for (int i = 0; i < j; ++i)
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
                        if (parType == "cef_string_t*")
                        {
                            string newArgName = "tmp_arg" + a;
                            newCodeStBuilder.AppendLine("CefString " + newArgName + " (" + par.ParameterName + ");");
                            argCodeList.Add(newArgName);
                        }
                        else
                        {
                            argCodeList.Add(par.ParameterName);
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
                }
            }
        }

        static string ConvertToCppName(string c_className)
        {
            string[] splits = c_className.Split('_');
            StringBuilder stbuilder = new StringBuilder();
            int j = splits.Length;
            for (int i = 0; i < j; ++i)
            {
                stbuilder.Append(MakeFirstLetterUpperCase(splits[i]));
            }
            return stbuilder.ToString();
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