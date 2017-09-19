//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
namespace BridgeBuilder
{

    /// <summary>
    /// tx for instance element
    /// </summary>
    class CefInstanceElementTx : CefTypeTx
    {

        public CefInstanceElementTx(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {

        }
        CefCodeGenOutput _output;
        public override void GenerateCode(CefCodeGenOutput output)
        {
            _output = output;

            GenerateCppCode(output._cppCode);
            GenerateCsCode(output._csCode);
        }
        void GenerateCppCode(CodeStringBuilder stbuilder)
        {

#if DEBUG
            _dbug_cpp_count++;
#endif
            //
            //create switch table for C#-interop
            //
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;
            TypePlan typeTxInfo;
            if (implTypeDecl.Name.Contains("CppToC"))
            {
                typeTxInfo = orgDecl.TypePlan;
            }
            else
            {
                typeTxInfo = implTypeDecl.TypePlan;
            }


            CppHandleCsMethodRequestCodeGen cppHandlerReqCodeGen = new CppHandleCsMethodRequestCodeGen();
            cppHandlerReqCodeGen.GenerateCppCode(this, orgDecl, implTypeDecl, this.UnderlyingCType, stbuilder);
            //
            if (cppHandlerReqCodeGen.callToDotNetMets.Count > 0)
            {
                int j = cppHandlerReqCodeGen.callToDotNetMets.Count;
                //check if method has duplicate name or not
                Dictionary<string, MethodPlan> uniqueNames = new Dictionary<string, MethodPlan>();
                for (int i = 0; i < j; ++i)
                {
                    MethodPlan met = cppHandlerReqCodeGen.callToDotNetMets[i];
                    
                    MethodPlan existingPlan;
                    if (uniqueNames.TryGetValue(met.Name, out existingPlan))
                    {
                        //has some duplicate name 
                        met.NewOverloadName = met.Name + i;
                        met.HasDuplicatedMethodName = true;                        
                    }
                    else
                    {
                        uniqueNames.Add(met.Name, met);
                    }
                }

                CppInstanceImplCodeGen instanceImplCodeGen = new CppInstanceImplCodeGen();
                instanceImplCodeGen.GenerateCppImplClass(this,
                    typeTxInfo,
                    cppHandlerReqCodeGen.callToDotNetMets,
                    orgDecl,
                    stbuilder);


                //-----------------------------------------------------------
                CppToCsMethodArgsClassGen cppMetArgClassGen = new CppToCsMethodArgsClassGen();
                //
                CodeStringBuilder cppArgClassStBuilder = new CodeStringBuilder();
                cppArgClassStBuilder.AppendLine("namespace " + orgDecl.Name + "Ext{");

                for (int i = 0; i < j; ++i)
                {
                    MethodPlan met = cppHandlerReqCodeGen.callToDotNetMets[i];
                    cppMetArgClassGen.GenerateCppMethodArgsClass(met, cppArgClassStBuilder);
                }
                cppArgClassStBuilder.AppendLine("}");

                //----------------------------------------------
                _output._cppHeaderExportFuncAuto.Append(cppArgClassStBuilder.ToString());

                //----------------------------------------------
                //InternalHeaderForExportFunc.h
                string namespaceName = orgDecl.Name + "Ext";
                CodeStringBuilder internalHeader = _output._cppHeaderInternalForExportFuncAuto;
                internalHeader.AppendLine("namespace " + namespaceName);
                internalHeader.AppendLine("{");
                internalHeader.AppendLine("const int _typeName=" + "CefTypeName_" + orgDecl.Name + ";");
                internalHeader.AppendLine("}");
                //----------------------------------------------   
            }

        }
        void GenerateCsCode(CodeStringBuilder stbuilder)
        {
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;

            CodeGenUtils.AddComments(orgDecl, implTypeDecl);
            CsCallToNativeCodeGen callToNativeCs = new CsCallToNativeCodeGen();
            callToNativeCs.GenerateCsCode(this, orgDecl, implTypeDecl, true, stbuilder);
        }
    }

}