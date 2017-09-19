//MIT, 2016-2017 ,WinterDev
using System;
namespace BridgeBuilder
{
    /// <summary>
    /// cef enum type transofmrer
    /// </summary>
    class CefEnumTx : CefTypeTx
    {
        string enum_base = "";
        public CefEnumTx(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {

        }
        public override void GenerateCode(CefCodeGenOutput output)
        {
            //only CS 
            //check each field for proper enum base type 
            foreach (CodeFieldDeclaration field in this.OriginalDecl.GetFieldIter())
            {
                if (field.InitExpression != null)
                {
                    //cef specific
                    //some init expression need special treatment
                    string initExprString = field.InitExpression.ToString();

                    if (initExprString == "UINT_MAX")
                    {
                        enum_base = ":uint";
                        break;
                    }
                    else
                    {
                        initExprString = initExprString.ToLower();
                        if (initExprString.StartsWith("0x"))
                        {
                            uint uint1 = Convert.ToUInt32(initExprString.Substring(2), 16);
                            if (uint1 >= int.MaxValue)
                            {
                                enum_base = ":uint";
                                break;
                            }
                        }
                    }
                }
            }

            GenerateCsCode(output._csCode);
        }
        void GenerateCsCode(CodeStringBuilder stbuilder)
        {

            CodeStringBuilder codeBuilder = new CodeStringBuilder();
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            TypePlan _typeTxInfo = orgDecl.TypePlan;

            //
            AddComment(orgDecl.LineComments, codeBuilder);

            //for cef, if enum class end with flags_t 
            //we add FlagsAttribute to this enum type

            if (orgDecl.Name.EndsWith("flags_t"))
            {
                codeBuilder.AppendLine("[Flags]");
            }

            codeBuilder.AppendLine("public enum " + orgDecl.Name + enum_base + "{");
            //transform enum
            int i = 0;
            foreach (FieldPlan fieldTx in _typeTxInfo.fields)
            {

                if (i > 0)
                {
                    codeBuilder.AppendLine(",");
                }
                i++;
                CodeFieldDeclaration codeFieldDecl = fieldTx.fieldDecl;
                //
                AddComment(codeFieldDecl.LineComments, codeBuilder);
                //
                if (codeFieldDecl.InitExpression != null)
                {
                    string initExpr = codeFieldDecl.InitExpression.ToString();
                    //cef specific
                    if (initExpr == "UINT_MAX")
                    {
                        codeBuilder.Append(codeFieldDecl.Name + "=uint.MaxValue");
                    }
                    else
                    {
                        codeBuilder.Append(codeFieldDecl.Name + "=" + codeFieldDecl.InitExpression.ToString());
                    }
                }
                else
                {
                    codeBuilder.Append(codeFieldDecl.Name);
                }
            }
            codeBuilder.AppendLine("}");
            //
            stbuilder.Append(codeBuilder.ToString());
        }
    }


}