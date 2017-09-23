//MIT, 2016-2017 ,WinterDev
using System;
namespace BridgeBuilder
{

    class CefCStructTx : CefTypeTx
    {
        public CefCStructTx(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {
        }
        public override void GenerateCode(CefCodeGenOutput output)
        {
            GenerateCsCode(output);
        }
        void GenerateCsCode(CefCodeGenOutput output)
        {
            CodeStringBuilder csCode = new CodeStringBuilder();
            CodeTypeDeclaration typedecl = this.OriginalDecl;
            //-------
            csCode.AppendLine("[StructLayout(LayoutKind.Sequential)]");
            csCode.AppendLine("struct " + typedecl.Name + "{");

            int i = 0;
            foreach (CodeMemberDeclaration mb in typedecl.GetMemberIter())
            {
                if (mb.MemberKind == CodeMemberKind.Field)
                {

                    CodeFieldDeclaration fieldDecl = (CodeFieldDeclaration)mb;
                    //
                    AddComment(fieldDecl.LineComments, csCode);
                    //

                    string fieldTypeName = fieldDecl.FieldType.ToString();
                    //field type
                    switch (fieldTypeName)
                    {
                        default:
                            {
                                if (fieldTypeName.EndsWith("_t"))
                                {
                                    csCode.Append("public " + fieldTypeName);
                                }
                                else
                                {
                                    throw new NotSupportedException();
                                }
                            }
                            break;
                        case "void*":
                            csCode.Append("public IntPtr");
                            break;
                        case "int":
                        case "float":
                        case "double":
                            csCode.Append("public " + fieldTypeName);
                            break;
                        case "cef_string_t":
                            csCode.Append("public _cef_string_utf16_t");
                            break;
                        case "size_t":
                            csCode.Append("public int");
                            break;
                        case "uint32":
                            csCode.Append("public uint");
                            break;
                        case "char16":
                            csCode.Append("public char");
                            break;
                    }
                    csCode.AppendLine(" " + fieldDecl.Name + ";");
                }
                i++;
            }
            csCode.AppendLine("}");
            //
            output._csCode.Append(csCode.ToString());
        }
    }
}