//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeBuilder
{


    /// <summary>
    /// other utils
    /// </summary>
    static class CodeGenUtils
    {
        public static void AddComment(Token[] lineTokens, CodeStringBuilder builder)
        {
            if (lineTokens == null)
            {
                return;
            }
            //
            StringBuilder stbuilder = new StringBuilder();
            int j = lineTokens.Length;
            int lastLine = j - 1;

            stbuilder.Append("/// <summary>\r\n");
            for (int i = 0; i < j; ++i)
            {
                //for cef, special care for first and last line 
                string lineContent = lineTokens[i].Content;
                if (i == 0 || i == lastLine)
                {
                    if (lineContent.StartsWith("///"))
                    {
                        if (lineContent.Substring(3).Trim() == "")
                        {
                            continue; //skip this first and last line comment
                        }
                        else
                        {
                            stbuilder.AppendLine(lineContent);
                        }
                    }
                    else
                    {
                        stbuilder.AppendLine("/" + lineContent);
                    }
                }
                else
                {

                    if (!lineContent.StartsWith("///"))
                    {
                        if (lineContent.StartsWith("//"))
                        {
                            //append one /
                            stbuilder.AppendLine("/" + lineTokens[i].Content);
                            continue;
                        }
                    }
                }
            }
            stbuilder.Append("/// </summary>\r\n");

            builder.Append(stbuilder.ToString());
        }
        public static void AddComments(CodeTypeDeclaration orgDecl, CodeTypeDeclaration implTypeDecl)
        {

            //copy comment from orgDecl to implTypeDecl 
            List<CodeMethodDeclaration> results = new List<CodeMethodDeclaration>();
            foreach (CodeMethodDeclaration orgMet in orgDecl.GetMethodIter())
            {
                Token[] lineComments = orgMet.LineComments;

                if (lineComments != null)
                {
                    results.Clear();
                    implTypeDecl.FindMethod(orgMet.Name, results);
                    switch (results.Count)
                    {
                        case 0://not found
                            break;
                        case 1:
                            //found 1
                            {
                                CodeMethodDeclaration implMethodDecl = results[0];
                                if (implMethodDecl.LineComments == null)
                                {
                                    implMethodDecl.LineComments = lineComments;
                                }
                                else
                                {
                                }

                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
    abstract class CppCodeGen
    {

    }
    

    abstract class CsCodeGen
    {

    }

    class CefCodeGenOutput
    {
        internal CodeStringBuilder _cppHeaderExportFuncAuto = new CodeStringBuilder();
        internal CodeStringBuilder _cppHeaderInternalForExportFuncAuto = new CodeStringBuilder();
        internal CodeStringBuilder _cppCode = new CodeStringBuilder();
        internal CodeStringBuilder _csCode = new CodeStringBuilder();

    }
}