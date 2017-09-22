//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BridgeBuilder
{

    class CodeMethodBodyCodePart
    {
        public MethodBodyCodePartKind PartKind { get; set; }
        public int beginAtLine;
        public string ParamName { get; set; }
        public string ParamType { get; set; }
        public string ReplacedParExpression { get; set; }

        internal bool IsList { get; set; }
        //
        public string ReturnType { get; set; }
        public List<string> PartLines = new List<string>();

        public string GetStringBlock()
        {
            StringBuilder stbuilder = new StringBuilder();
            int j = PartLines.Count;
            for (int i = 0; i < j; ++i)
            {
                stbuilder.AppendLine(PartLines[i]);
            }
            return stbuilder.ToString();
        }
        public override string ToString()
        {
            return this.GetStringBlock();
        }
    }
    enum MethodBodyCodePartKind
    {
        Other,
        TranslateParam,
        RestoreParam,
        VerifyParam,
        Execute,
        Return
    }

    class MultiPartCodeMethodBody
    {
        List<CodeMethodBodyCodePart> codeParts;
        Dictionary<string, CodeMethodBodyCodePart> translateParts;
        List<CodeMethodBodyCodePart> restoreParts;

        static void GetCppVarTypeAndName(string line, out string varType, out string varName)
        {
            //cef -specific
            string[] splits = line.Split(' ');
            varName = splits[1].Trim();
            if (varName.EndsWith(";"))
            {
                varName = varName.Substring(0, varName.Length - 1);
            }
            else if (varName.EndsWith("("))
            {
                varName = varName.Substring(0, varName.Length - 1);
            }
            //----
            varType = splits[0].Trim();
        }
        public MultiPartCodeMethodBody(List<CodeMethodBodyCodePart> codeParts)
        {
            this.codeParts = codeParts;
            //analyze detail
            int j = codeParts.Count;
            for (int i = 0; i < j; ++i)
            {
                CodeMethodBodyCodePart p = codeParts[i];
                switch (p.PartKind)
                {
                    case MethodBodyCodePartKind.TranslateParam:
                        {
                            if (translateParts == null) translateParts = new Dictionary<string, CodeMethodBodyCodePart>();
                            //
                            translateParts.Add(p.ParamName, p);
                            //analyze new name
                            switch (p.ParamType)
                            {
                                default:
                                    throw new NotSupportedException();
                                case "refptr_same_byref": //refptr_same_byref
                                    {

                                        string v_name, v_type;
                                        GetCppVarTypeAndName(p.PartLines[1], out v_type, out v_name);
                                        //cef-specific
                                        //get exact var name                                         
                                        p.ReplacedParExpression = "&" + v_name;
                                    }
                                    break;
                                case "simple_byref":
                                case "simple_byref_const":
                                    p.ReplacedParExpression = "&" + p.ParamName + "Val";
                                    break;
                                case "string_byref":
                                    p.ReplacedParExpression = "&" + p.ParamName + "Str";
                                    break;
                                case "simple_vec_byref_const":
                                case "string_vec_byref_const":
                                case "refptr_vec_diff_byref_const":
                                    //cef-specific
                                    p.IsList = true;
                                    p.ReplacedParExpression = "&" + p.ParamName + "List";
                                    break;
                                case "bool_byref":
                                case "bool_byaddr":
                                    p.ReplacedParExpression = "&" + p.ParamName + "Bool";
                                    break;
                                case "struct_byref":
                                case "struct_byref_const":
                                    p.ReplacedParExpression = "&" + p.ParamName + "Obj";
                                    break;
                                case "rawptr_diff":
                                    {
                                        string v_name, v_type;
                                        GetCppVarTypeAndName(p.PartLines[1], out v_type, out v_name);
                                        if (v_name == "registrarPtr")
                                        {
                                            //cef-specific
                                            //TODO: check the type instead of var name
                                            p.ReplacedParExpression = v_name + ".get()";
                                        }
                                        else
                                        {
                                            p.ReplacedParExpression = "&" + p.ParamName + "Ptr";
                                        }

                                    }
                                    break;
                                case "refptr_diff_byref":
                                    p.ReplacedParExpression = "&" + p.ParamName + "Ptr";
                                    break;
                            }

                        }
                        break;
                    case MethodBodyCodePartKind.RestoreParam:
                        {
                            if (restoreParts == null)
                            {
                                restoreParts = new List<CodeMethodBodyCodePart>();
                            }

                            restoreParts.Add(p);
                        }
                        break;
                }

            }
        }
        public bool TryGetTranslateParameter(string parName, out CodeMethodBodyCodePart found)
        {
            if (translateParts != null)
            {
                return translateParts.TryGetValue(parName, out found);
            }
            found = null;
            return false;
        }


        public List<CodeMethodBodyCodePart> GetRestoreParts()
        {
            return this.restoreParts;
        }
    }

    class CppToCsImplCodeGen
    {
        CodeCompilationUnit cu;
        List<CodeMethodDeclaration> methods;
        List<string> simpleLineList = new List<string>();
        int firstNamespaceStartAt;
        public CppToCsImplCodeGen()
        {
        }
        static void AddPartParameterDetail(CodeMethodBodyCodePart part, string line)
        {
            int indexOfParam = line.IndexOf("param:");
            if (indexOfParam > -1)
            {
                int indexOfType = line.IndexOf("type:", indexOfParam);
                string paramName = line.Substring(indexOfParam + 6 /*"param:"*/,
                    indexOfType - (indexOfParam + 6)).Trim();
                paramName = paramName.Substring(0, paramName.Length - 1);
                //-------------------------------------------------------------
                string typeName = line.Substring(indexOfType + 5/*"type:"*/).Trim();
                part.ParamName = paramName;
                part.ParamType = typeName;
            }
        }
        static void AddPartReturnDetail(CodeMethodBodyCodePart part, string line)
        {
            int indexOfType = line.IndexOf("type:");
            if (indexOfType > -1)
            {
                part.ReturnType = line.Substring(indexOfType + 5/*"type:"*/).Trim();
            }
        }
        MultiPartCodeMethodBody ParseCppMethodBody(CodeMethodDeclaration metDecl)
        {
            List<CodeMethodBodyCodePart> codeParts = new List<CodeMethodBodyCodePart>();
            int endAt = metDecl.EndAtLine;
            CodeMethodBodyCodePart currentPart = null;

            for (int lineNo = metDecl.StartAtLine + 1; lineNo <= endAt; ++lineNo)
            {
                string line = simpleLineList[lineNo].Trim();
                //parse special mx parameter
                if (line.StartsWith("// Translate param:"))
                {
                    //begin new
                    currentPart = new CodeMethodBodyCodePart() { PartKind = MethodBodyCodePartKind.TranslateParam, beginAtLine = lineNo };
                    AddPartParameterDetail(currentPart, line);
                    currentPart.PartLines.Add(line);
                    codeParts.Add(currentPart);
                }
                else if (line.StartsWith("// Restore param:"))
                {
                    //begin new
                    currentPart = new CodeMethodBodyCodePart() { PartKind = MethodBodyCodePartKind.RestoreParam, beginAtLine = lineNo };
                    AddPartParameterDetail(currentPart, line);
                    currentPart.PartLines.Add(line);
                    codeParts.Add(currentPart);
                }
                else if (line.StartsWith("// Verify param:"))
                {
                    //begin new
                    currentPart = new CodeMethodBodyCodePart() { PartKind = MethodBodyCodePartKind.VerifyParam, beginAtLine = lineNo };
                    AddPartParameterDetail(currentPart, line);
                    currentPart.PartLines.Add(line);
                    codeParts.Add(currentPart);
                }
                else if (line.StartsWith("// Return type:"))
                {
                    //begin new
                    currentPart = new CodeMethodBodyCodePart() { PartKind = MethodBodyCodePartKind.Return, beginAtLine = lineNo };
                    AddPartReturnDetail(currentPart, line);
                    currentPart.PartLines.Add(line);
                    codeParts.Add(currentPart);
                }
                else if (line.StartsWith("// Execute"))
                {
                    //begin new
                    currentPart = new CodeMethodBodyCodePart() { PartKind = MethodBodyCodePartKind.Execute, beginAtLine = lineNo };
                    currentPart.PartLines.Add(line);
                    codeParts.Add(currentPart);
                }
                else if (line.StartsWith("//"))
                {
                    //other block
                    currentPart = new CodeMethodBodyCodePart() { PartKind = MethodBodyCodePartKind.Other, beginAtLine = lineNo };
                    currentPart.PartLines.Add(line);
                    codeParts.Add(currentPart);
                }
                else
                {
                    //other 
                    if (currentPart == null)
                    {
                        currentPart = new CodeMethodBodyCodePart() { PartKind = MethodBodyCodePartKind.Other, beginAtLine = lineNo };
                        codeParts.Add(currentPart);
                    }
                    currentPart.PartLines.Add(line);
                }
            }

            return new MultiPartCodeMethodBody(codeParts);
        }
        public void PatchCppMethod(CodeCompilationUnit cu, string writeNewCodeToFile, string backupFolder)
        {

            //cef specific code
            firstNamespaceStartAt = 0;
            this.cu = cu;
            methods = new List<CodeMethodDeclaration>();
            CollectImplMethods();

            string onlyFileName = Path.GetFileName(cu.Filename);

            simpleLineList.Clear();
            simpleLineList.AddRange(File.ReadAllLines(cu.Filename));
            //
            //check if this file is patched or not
            if (CheckIfThisFileIsPatched(simpleLineList))
            {
                throw new NotSupportedException();
            }

            int classCutAt = onlyFileName.IndexOf("_cpptoc.");
            string c_className = onlyFileName.Substring(0, classCutAt);
            int c_classNameLen = c_className.Length;
            string cppClassName = "Cef" + ConvertToCppName(c_className);
            string cppExtNamespaceName = cppClassName + "Ext";


            for (int i = methods.Count - 1; i >= 0; --i) //backward, since we are going to insert a new line to the line list
            {
                CodeMethodDeclaration metDecl = methods[i];
                MultiPartCodeMethodBody metBody = ParseCppMethodBody(metDecl);
                //


                StringBuilder newCodeStBuilder = new StringBuilder();
                int methodCutAt = c_classNameLen + 1;
                string c_methodName = metDecl.Name.Substring(methodCutAt);
                string cppMethodName = ConvertToCppName(c_methodName);

                //eg.
                //(CefDisplayHandlerExt::_typeName << 16) | CefDisplayHandlerExt::CefDisplayHandlerExt_OnAddressChange_1, &args1.arg);
                string metNameConst = "(" + cppExtNamespaceName + "::_typeName << 16) | " + cppExtNamespaceName + "::" + cppExtNamespaceName + "_" + cppMethodName + "_" + (i + 1);


                newCodeStBuilder.AppendLine("//---kneadium-ext-begin");
                newCodeStBuilder.AppendLine("#if ENABLE_KNEADIUM_EXT");
                //some method parameters may need special preparation.
                newCodeStBuilder.AppendLine("auto me = " + cppClassName + "CppToC::Get(self);");
                newCodeStBuilder.AppendLine("const int CALLER_CODE=" + metNameConst + ";");
                newCodeStBuilder.AppendLine("auto m_callback= me->GetManagedCallBack(CALLER_CODE);");
                newCodeStBuilder.AppendLine("if(m_callback){"); //TODO: + method filter                  

                int parCount = metDecl.Parameters.Count;
                List<string> argCodeList = new List<string>();

                for (int a = 1; a < parCount; ++a)
                {
                    //start at 1
                    CodeMethodParameter par = metDecl.Parameters[a];
                    string parType = par.ParameterType.ToString();
                    //check if we need parameter translation
                    switch (parType)
                    {
                        default:
                            {
                                CodeMethodBodyCodePart found;
                                if (metBody.TryGetTranslateParameter(par.ParameterName, out found))
                                {
                                    if (found.IsList)
                                    {
                                        //cef-specific
                                        //note the prev var
                                        CodeMethodParameter prev_par = metDecl.Parameters[a - 1];
                                        prev_par.SkipCodeGen = true;
                                    }
                                    argCodeList.Add(found.ReplacedParExpression);
                                }
                                else
                                {
                                    argCodeList.Add(par.ParameterName);
                                }
                                //-----------------




                                //-----------------
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
                if (parCount < 2)
                {
                    newCodeStBuilder.AppendLine(cppExtNamespaceName + "::" + cppMethodName + "Args args1;");
                }
                else
                {
                    newCodeStBuilder.Append(cppExtNamespaceName + "::" + cppMethodName + "Args args1(");
                    for (int a = 1; a < parCount; ++a)
                    {
                        CodeMethodParameter par = metDecl.Parameters[a];
                        if (par.SkipCodeGen) { continue; }
                        //
                        if (a > 1)
                        {
                            newCodeStBuilder.Append(',');
                        }
                        //start at 1
                        newCodeStBuilder.Append(argCodeList[a - 1]);
                    }
                    newCodeStBuilder.AppendLine(");");
                }
                //
                //invoke managed del
                //cef-specific

                newCodeStBuilder.Append("m_callback(CALLER_CODE, &args1.arg);");
                newCodeStBuilder.AppendLine();
                //----------------------------------------------------------------------------
                newCodeStBuilder.AppendLine(" if (((args1.arg.myext_flags >> 21) & 1) == 1){");
                string retType = metDecl.ReturnType.ToString();
                if (retType != "void")
                {
 
                    //the event is handled by user code
                    //before return we must check some restore parts

                    List<CodeMethodBodyCodePart> restoreParts = metBody.GetRestoreParts();
                    if (restoreParts != null)
                    {
                        int rcount = restoreParts.Count;
                        for (int r = 0; r < rcount; ++r)
                        {
                            newCodeStBuilder.AppendLine(restoreParts[r].GetStringBlock());
                        }
                    }


                    //check some special value
                    if (retType.EndsWith("_t*"))
                    {
                        //
                        string cppNm = ConvertToCppName(retType.Substring(0, retType.Length - 3));

                        //temp fix, TODO: review here again
                        //CefCookieManager 
                        if (cppNm == "CefCookieManager")
                        {
                            newCodeStBuilder.AppendLine(" return " + cppNm + "CToCpp::Unwrap(args1.arg.myext_ret_value);");
                        }
                        else
                        {
                            newCodeStBuilder.AppendLine(" return " + cppNm + "CppToC::Wrap(args1.arg.myext_ret_value);");
                        }

                    }
                    else
                    {
                        newCodeStBuilder.AppendLine(" return args1.arg.myext_ret_value;");
                    }

                }
                else
                {
                    newCodeStBuilder.AppendLine("return;");
                }
                newCodeStBuilder.AppendLine("}");

 


                //method return value may need special preparation.
                newCodeStBuilder.AppendLine("}"); //TODO: + method filter
                newCodeStBuilder.AppendLine("#endif");//#if ENABLE_KNEADIUM_EXT");
                newCodeStBuilder.AppendLine("//---kneadium-ext-end");
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

            //insert header
            simpleLineList.Insert(firstNamespaceStartAt,
                "//---kneadium-ext-begin\r\n" +
                "#include \"../myext/ExportFuncAuto.h\"\r\n" +
                "#include \"../myext/InternalHeaderForExportFunc.h\"\r\n" +
                "//---kneadium-ext-end\r\n");

            simpleLineList.Insert(0, "//---THIS-FILE-WAS-PATCHED , org=" + cu.Filename);

            ////save the modified file
            if (writeNewCodeToFile != null)
            {
                //target must exist
                if (!File.Exists(writeNewCodeToFile))
                {
                    throw new NotSupportedException();
                }
                //backup org file
                File.Copy(writeNewCodeToFile, backupFolder + "\\" + onlyFileName + ".backup.txt", true);
                //then write the new one
                using (FileStream fs = new FileStream(writeNewCodeToFile, FileMode.Create))
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
        static bool CheckIfThisFileIsPatched(List<string> lines)
        {
            //---THIS-FILE-WAS-PATCHED
            int count = lines.Count;
            for (int i = 0; i < count; ++i)
            {
                string firstNotEmptyLine = lines[i].Trim();
                if (!string.IsNullOrEmpty(firstNotEmptyLine))
                {
                    return firstNotEmptyLine.StartsWith("//---THIS-FILE-WAS-PATCHED");
                }
            }
            return false;
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
            else if (cefName.StartsWith("Dom"))
            {
                if (cefName.Length > 3)
                {
                    cefName = "DOM" + MakeFirstLetterUpperCase(cefName.Substring(3));
                }
            }
            else if (cefName.StartsWith("Js"))
            {
                if (cefName.Length > 2)
                {
                    cefName = "JS" + MakeFirstLetterUpperCase(cefName.Substring(2));
                }
            }
            else if (cefName.StartsWith("V8"))
            {
                if (cefName.Length > 2)
                {
                    cefName = "V8" + MakeFirstLetterUpperCase(cefName.Substring(2));
                }
            }
        }
        static string MakeFirstLetterUpperCase(string name)
        {
            switch (name.Length)
            {
                case 0: return "";
                case 1: return char.ToUpper(name[0]).ToString();
                default: return char.ToUpper(name[0]) + name.Substring(1);
            }
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
                                if (firstNamespaceStartAt == 0)
                                {
                                    firstNamespaceStartAt = typedecl.StartAtLine;
                                }
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