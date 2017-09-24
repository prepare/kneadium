//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
namespace BridgeBuilder
{

    /// <summary>
    /// tx for callback class
    /// </summary>
    class CefCallbackTx : CefTypeTx
    {
        TypePlan _typePlan;

        public CefCallbackTx(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {
        }
        public override void GenerateCode(CefCodeGenOutput output)
        {


            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;

            GenerateCppCode(output._cppCode);
            GenerateCsCode(output._csCode);

            //-----------------------------------------------------------
            string namespaceName = orgDecl.Name + "Ext";
            CodeStringBuilder const_methodNames = new CodeStringBuilder();
            CppToCsMethodArgsClassGen cppMetArgClassGen = new CppToCsMethodArgsClassGen();
            //
            CodeStringBuilder cppArgClassStBuilder = new CodeStringBuilder();
            cppArgClassStBuilder.AppendLine("namespace " + orgDecl.Name + "Ext{");
            int j = _typePlan.methods.Count;
            for (int i = 0; i < j; ++i)
            {
                MethodPlan met = _typePlan.methods[i];
                cppMetArgClassGen.GenerateCppMethodArgsClass(met, cppArgClassStBuilder);
                const_methodNames.AppendLine("const int " + namespaceName + "_" + met.Name + "_" + (i + 1) + "=" + (i + 1) + ";");
            }
            cppArgClassStBuilder.AppendLine("}");

            //----------------------------------------------
            output._cppHeaderExportFuncAuto.Append(cppArgClassStBuilder.ToString());

            //----------------------------------------------
            //InternalHeaderForExportFunc.h

            CodeStringBuilder internalHeader = output._cppHeaderInternalForExportFuncAuto;
            internalHeader.AppendLine("namespace " + namespaceName);
            internalHeader.AppendLine("{");
            internalHeader.AppendLine("const int _typeName=" + "CefTypeName_" + orgDecl.Name + ";");
            internalHeader.AppendLine(const_methodNames.ToString());
            internalHeader.AppendLine("}");
            //----------------------------------------------  
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
            _typePlan = orgDecl.TypePlan;
            //-----------------------------------------------------------------------
            List<MethodPlan> onEventMethods = new List<MethodPlan>();

            int j = _typePlan.methods.Count;
            int maxPar = 0;
            for (int i = 0; i < j; ++i)
            {
                MethodPlan metTx = _typePlan.methods[i];
                if (metTx.metDecl.IsVirtual)
                {
                    //this method need a callback to .net side (.net-side event listener)
                    if (metTx.metDecl.Name.StartsWith("On"))
                    {
                        onEventMethods.Add(metTx);
                    }
                }
                metTx.CppMethodSwitchCaseName = orgDecl.Name + "_" + metTx.Name + "_" + (i + 1);
                if (metTx.pars.Count > maxPar)
                {
                    maxPar = metTx.pars.Count;
                }
            }

            MaxMethodParCount = maxPar;
            //----------
            CppHandleCsMethodRequestCodeGen cppHandleCsMetCodeGen2 = new CppHandleCsMethodRequestCodeGen();
            cppHandleCsMetCodeGen2.GenerateCppCode(
                this,
                orgDecl,
                ImplTypeDecl,
                this.UnderlyingCType,
                stbuilder
                );

            //----------
            if (onEventMethods.Count > 0)
            {
                //the callback need some method to call to C# side
                var eventListenerCodeGen = new CppEventListenerInstanceImplCodeGen();
                eventListenerCodeGen.GenerateCppImplClass(
                    this,
                    _typePlan,
                    orgDecl,
                    onEventMethods,
                    stbuilder);
            }

        }
        void GenerateCsCode(CodeStringBuilder stbuilder)
        {

            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;

            CsCallToNativeCodeGen csCallToNativeCodeGen = new CsCallToNativeCodeGen();
            csCallToNativeCodeGen.GenerateCsCode(this, orgDecl, implTypeDecl, false, null, stbuilder);
        }

    }

}