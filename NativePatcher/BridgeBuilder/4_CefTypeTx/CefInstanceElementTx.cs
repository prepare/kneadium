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
        static List<MethodPlan> FindStaticMethods(TypePlan typeplan)
        {
            List<MethodPlan> allStaticCreateMethods = new List<MethodPlan>();

            List<MethodPlan> plans = typeplan.methods;
            int j = plans.Count;
            for (int i = 0; i < j; ++i)
            {
                MethodPlan m = plans[i];
                if (m.metDecl.IsStatic)
                {
                    allStaticCreateMethods.Add(m);
                }
            }

            if (allStaticCreateMethods.Count == 0) { return null; }
            return allStaticCreateMethods;
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
            TypePlan typeTxInfo = implTypeDecl.Name.Contains("CppToC") ? orgDecl.TypePlan : implTypeDecl.TypePlan;
            //
            List<MethodPlan> staticMethods = FindStaticMethods(orgDecl.TypePlan);
            // 
            CppHandleCsMethodRequestCodeGen cppHandlerReqCodeGen = new CppHandleCsMethodRequestCodeGen();
            cppHandlerReqCodeGen.GenerateCppCode(this, orgDecl, implTypeDecl, this.UnderlyingCType, stbuilder);

            string namespaceName = orgDecl.Name + "Ext";
            int j = cppHandlerReqCodeGen.callToDotNetMets.Count;
            if (j > 0)
            {

                CodeStringBuilder const_methodNames = new CodeStringBuilder();
                //check if method has duplicate name or not
                Dictionary<string, MethodPlan> uniqueNames = new Dictionary<string, MethodPlan>();
                for (int i = 0; i < j; ++i)
                {
                    MethodPlan met = cppHandlerReqCodeGen.callToDotNetMets[i];
                    MethodPlan existingPlan;
                    if (uniqueNames.TryGetValue(met.Name, out existingPlan))
                    {
                        //has some duplicate name 
                        //TODO: review here again*** 
                        met.NewOverloadName = met.Name + i;
                        met.HasDuplicatedMethodName = true;
                        const_methodNames.AppendLine("const int " + namespaceName + "_" + met.NewOverloadName + "_" + (i + 1) + "=" + (i + 1) + ";");
                    }
                    else
                    {
                        uniqueNames.Add(met.Name, met);
                        const_methodNames.AppendLine("const int " + namespaceName + "_" + met.Name + "_" + (i + 1) + "=" + (i + 1) + ";");
                    }
                }

                //--------------
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
                cppArgClassStBuilder.AppendLine("namespace " + namespaceName + "{");

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
                CodeStringBuilder internalHeader = _output._cppHeaderInternalForExportFuncAuto;
                internalHeader.AppendLine("namespace " + namespaceName);
                internalHeader.AppendLine("{");
                internalHeader.AppendLine("const int _typeName=" + "CefTypeName_" + orgDecl.Name + ";");
                internalHeader.AppendLine(const_methodNames.ToString());
                internalHeader.AppendLine("}");
                //----------------------------------------------   
            }
            if (staticMethods != null)
            {
                //create static method for cpp type
                //in this version we don't create an custom impl of the class
                //-----------------------------------------------------------
                CppToCsMethodArgsClassGen cppMetArgClassGen = new CppToCsMethodArgsClassGen();
                //
                CodeStringBuilder cppArgClassStBuilder = new CodeStringBuilder();
                cppArgClassStBuilder.AppendLine("namespace " + namespaceName + "{");

                j = staticMethods.Count;
                for (int i = 0; i < j; ++i)
                {
                    MethodPlan met = staticMethods[i];
                    cppMetArgClassGen.GenerateCppMethodArgsClass(met, cppArgClassStBuilder);
                }
                cppArgClassStBuilder.AppendLine("}");
                //----------------------------------------------
                //generate cpp class

            }
            else
            {

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