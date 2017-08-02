//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeBuilder
{
    //cef -specfic 
    class CodeStringBuilder
    {
        StringBuilder stbuilder = new StringBuilder();
#if DEBUG
        static int _dbugLineCount;
        bool _dbugEnableLineNote = true;
#endif
        public void EnterIndentLevel()
        {

        }
        public void ExitIndentLevel()
        {

        }
        public void AppendLine(string text)
        {
#if DEBUG
            _dbugLineCount++;
            if (_dbugEnableLineNote)
            {
                stbuilder.Append("/*" + _dbugLineCount + "*/");
            }
#endif
            stbuilder.AppendLine(text);
        }
        public void AppendLine()
        {
#if DEBUG
            _dbugLineCount++;
            if (_dbugEnableLineNote)
            {
                stbuilder.Append("/*" + _dbugLineCount + "*/");
            }
#endif
            stbuilder.AppendLine();
        }
        public void Append(string text)
        {
            stbuilder.Append(text);
        }
        public override string ToString()
        {
            return stbuilder.ToString();
        }
    }


    abstract class CefTypeTxPlan : TypeTxPlan
    {
        CodeTypeDeclaration _implDecl;
        public CefTypeTxPlan(CodeTypeDeclaration originalDecl)
        {
            this.OriginalDecl = originalDecl;
        }
        public SimpleTypeSymbol UnderlyingCType { get; set; }
        public CodeTypeDeclaration OriginalDecl { get; private set; }
        public CodeTypeDeclaration ImplTypeDecl
        {
            get { return _implDecl; }
            set
            {
                _implDecl = value;

            }
        }
        public override string ToString()
        {
            if (_implDecl != null)
            {
                return OriginalDecl.ToString() + " impl_by " + _implDecl.ToString();
            }
            else
            {
                return OriginalDecl.ToString();
            }
        }


        public virtual void GenerateCppCode(CodeStringBuilder stbuilder)
        {

        }
        public virtual void GenerateCsCode(CodeStringBuilder stbuilder)
        {

        }
    }

    /// <summary>
    /// tx plan for callback class
    /// </summary>
    class CefCallbackTxPlan : CefTypeTxPlan
    {
        public CefCallbackTxPlan(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {
            //this is call back
        }
        public override void GenerateCppCode(CodeStringBuilder stbuilder)
        {
            base.GenerateCppCode(stbuilder);
        }
        public override void GenerateCsCode(CodeStringBuilder stbuilder)
        {

            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;
            if (implTypeDecl == null)
            {
                throw new NotSupportedException();
            }

            if (implTypeDecl.Name.Contains("CToCPP"))
            {

            }
            else if (implTypeDecl.Name.Contains("CppToC"))
            {

            }
            else
            {

            }
        }

    }

    /// <summary>
    /// tx plan for handler class
    /// </summary>
    class CefHandlerTxPlan : CefTypeTxPlan
    {
        public CefHandlerTxPlan(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {

        }
        public override void GenerateCppCode(CodeStringBuilder stbuilder)
        {
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;
            if (implTypeDecl == null)
            {
                throw new NotSupportedException();
            }

            if (implTypeDecl.Name.Contains("CToCPP"))
            {

            }
            else if (implTypeDecl.Name.Contains("CppToC"))
            {

            }
            else
            {

            }
        }
        public override void GenerateCsCode(CodeStringBuilder stbuilder)
        {
            base.GenerateCsCode(stbuilder);
        }
    }


    enum ImplWrapDirection
    {
        None,
        CppToC,
        CToCpp,
    }

    /// <summary>
    /// tx plan for instance element
    /// </summary>
    class CefInstanceElementTxPlan : CefTypeTxPlan
    {
        TypeTxInfo _typeTxInfo;
        CodeTypeDeclaration _currentCodeTypeDecl;

        public CefInstanceElementTxPlan(CodeTypeDeclaration typedecl)
            : base(typedecl)
        {

        }
        public override void GenerateCppCode(CodeStringBuilder stbuilder)
        {
            //
            //create switch table for C#-interop
            //
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;

            _typeTxInfo = implTypeDecl.TxInfo;
            _currentCodeTypeDecl = implTypeDecl;

            CodeStringBuilder totalTypeMethod = new CodeStringBuilder();
            //1. generate method decl
            totalTypeMethod.AppendLine("void MyCefMet_" + orgDecl.Name + "(" +
                this.UnderlyingCType.Name + "* me1,int metName,jsvalue* ret,jsvalue* v1,jsvalue* v2,jsvalue* v3){");
            //2. generate method header
            //3. generate switch table


            if (implTypeDecl == null)
            {
                throw new NotSupportedException();
            }


            totalTypeMethod.AppendLine("ret->type = JSVALUE_TYPE_EMPTY;");
            ImplWrapDirection implWrapDirection = ImplWrapDirection.None;
            if (implTypeDecl.Name.Contains("CToCpp"))
            {
                implWrapDirection = ImplWrapDirection.CToCpp;
                //CefBrowserCToCpp::

                totalTypeMethod.AppendLine("auto me=" + implTypeDecl.Name + "::Wrap(me1);");
            }
            else if (implTypeDecl.Name.Contains("CppToC"))
            {
                implWrapDirection = ImplWrapDirection.CppToC;
                totalTypeMethod.AppendLine("auto me=" + implTypeDecl.Name + "::Wrap(me1);");
            }
            else
            {
                implWrapDirection = ImplWrapDirection.None;
            }


            //swicth table is a way that this instance'smethod is called
            //through the bridge




            int j = _typeTxInfo.methods.Count;
            totalTypeMethod.AppendLine("switch(metName){");
            totalTypeMethod.AppendLine("case MET_Release:return; //yes, just return");


            for (int i = 0; i < j; ++i)
            {
                CodeStringBuilder met_stbuilder = new CodeStringBuilder();
                //create each method,
                //in our convention we dont generate 
                MethodTxInfo metTx = _typeTxInfo.methods[i];
                met_stbuilder.AppendLine("case " + orgDecl.Name + "_" + metTx.Name + ":{");

                GenerateCppMethod(_typeTxInfo.methods[i], met_stbuilder);

                met_stbuilder.AppendLine("} break;");

                totalTypeMethod.Append(met_stbuilder.ToString());
            }

            totalTypeMethod.AppendLine("}"); //end switch table
            //
            switch (implWrapDirection)
            {
                default: throw new NotSupportedException();
                case ImplWrapDirection.CppToC:
                    //unwrap me
                    totalTypeMethod.AppendLine(implTypeDecl.Name + "::Unwrap(me1);");
                    break;
                case ImplWrapDirection.CToCpp:
                    //unwrap me
                    totalTypeMethod.AppendLine(implTypeDecl.Name + "::Unwrap(me1);");
                    break;
            }


            totalTypeMethod.AppendLine("}");
        }
        void GenerateCppMethod(MethodTxInfo met, CodeStringBuilder stbuilder)
        {
            if (met.CsLeftMethodBodyBlank) return;  //temp here
            //---------------------------------------

            //extract managed args and then call native c++ method
            //----
            MethodParameterTxInfo ret = met.ReturnPlan;
            //----
            List<MethodParameterTxInfo> pars = met.pars;
            int parCount = pars.Count;
            if (parCount > 15)
            {
                throw new NotSupportedException();
            }
            StringBuilder arglistBuilder = new StringBuilder();
            for (int i = 0; i < parCount; ++i)
            {
                //get pars from parameter
                if (i > 0)
                {
                    arglistBuilder.Append(',');
                }
                MethodParameterTxInfo par = pars[i];
                TypeSymbol typeSymbol = par.TypeSymbol;
                TypeBridgeInfo bridge = typeSymbol.BridgeInfo;

                //get actual data from C# data
                //some data need wrap/unwrap
                //-------
                switch (typeSymbol.TypeSymbolKind)
                {
                    case TypeSymbolKind.ReferenceOrPointer:
                        {
                            ReferenceOrPointerTypeSymbol refOrPtr = (ReferenceOrPointerTypeSymbol)typeSymbol;
                            switch (refOrPtr.Kind)
                            {
                                default:
                                    break;
                                case ContainerTypeKind.ByRef:
                                    {
                                        //cast data from ptr
                                        string elemTypeName = refOrPtr.ElementType.ToString();
                                        arglistBuilder.Append("(" + elemTypeName + "*)");
                                        arglistBuilder.Append("v" + (i + 1));
                                        arglistBuilder.AppendLine("->" + bridge.CefCppSlotName);
                                    }
                                    break;
                                case ContainerTypeKind.CefRefPtr:
                                    //cpp object of cef 'smart' pointer (ref-count) 
                                    {
                                        string elemTypeName = refOrPtr.ElementType.ToString();
                                        arglistBuilder.Append("(" + elemTypeName + "*)");
                                        arglistBuilder.Append("v" + (i + 1));
                                        arglistBuilder.AppendLine("->" + bridge.CefCppSlotName);
                                    }
                                    break;
                                case ContainerTypeKind.Pointer:
                                    {
                                        string elemTypeName = refOrPtr.ElementType.ToString();
                                        arglistBuilder.Append("(" + elemTypeName + "*)");
                                        arglistBuilder.Append("v" + (i + 1));
                                        arglistBuilder.AppendLine("->" + bridge.CefCppSlotName);
                                    }
                                    break;
                                case ContainerTypeKind.ScopePtr:
                                    break;
                            }
                        }
                        break;
                    case TypeSymbolKind.Simple:
                        {
                            SimpleTypeSymbol simpleType = (SimpleTypeSymbol)typeSymbol;
                            switch (simpleType.PrimitiveTypeKind)
                            {
                                default:
                                    break;
                                case PrimitiveTypeKind.NotPrimitiveType:
                                    {
                                        //
                                        arglistBuilder.Append("(" + simpleType.ToString() + "*)");
                                        arglistBuilder.Append("v" + (i + 1));
                                        arglistBuilder.AppendLine("->" + bridge.CefCppSlotName);
                                    }
                                    break;
                                case PrimitiveTypeKind.NaitveInt:
                                    arglistBuilder.Append("v" + (i + 1));
                                    arglistBuilder.AppendLine("->" + bridge.CefCppSlotName);
                                    break;
                                case PrimitiveTypeKind.Int32:
                                    arglistBuilder.Append("v" + (i + 1));
                                    arglistBuilder.AppendLine("->" + bridge.CefCppSlotName);
                                    break;
                                case PrimitiveTypeKind.Float:
                                    arglistBuilder.Append("v" + (i + 1));
                                    arglistBuilder.AppendLine("->" + bridge.CefCppSlotName);
                                    break;
                                case PrimitiveTypeKind.Double:
                                    arglistBuilder.Append("v" + (i + 1));
                                    arglistBuilder.AppendLine("->" + bridge.CefCppSlotName);
                                    break;
                            }
                        }
                        break;
                }

            }
            //----
            stbuilder.AppendLine();
            stbuilder.AppendLine("// gen! " + met.ToString());
            stbuilder.AppendLine();
            //----
            string instThis = "me";
            if (ret.IsVoid)
            {
                //call, no return result
                stbuilder.Append(instThis + "->" + met.Name + "(");
                stbuilder.Append(arglistBuilder.ToString());
                stbuilder.Append(");\r\n");

            }
            else
            {
                stbuilder.Append("auto ret_result=");
                stbuilder.Append(instThis + "->" + met.Name + "(");
                stbuilder.Append(arglistBuilder.ToString());
                stbuilder.Append(");\r\n");
                switch (ret.TypeSymbol.TypeSymbolKind)
                {
                    default:
                        break;
                    case TypeSymbolKind.ReferenceOrPointer:
                        {
                            ReferenceOrPointerTypeSymbol refOrPtr = (ReferenceOrPointerTypeSymbol)ret.TypeSymbol;
                            switch (refOrPtr.Kind)
                            {
                                default:
                                    {

                                    }
                                    break;
                                case ContainerTypeKind.ByRef:
                                    break;
                                case ContainerTypeKind.CefRefPtr:
                                    //return CefRefPtr => this need unwrap method for raw pointer before send this to client
                                    {
                                        TypeSymbol elemType = refOrPtr.ElementType;
                                        //what type that implement this elem
                                        if (elemType.TypeSymbolKind == TypeSymbolKind.Simple)
                                        {
                                            SimpleTypeSymbol simpleElem = (SimpleTypeSymbol)elemType;
                                            if (simpleElem.PrimitiveTypeKind == PrimitiveTypeKind.NotPrimitiveType)
                                            {
                                                CefTypeTxPlan txPlan = simpleElem.CefTxPlan;
                                                if (txPlan == null)
                                                {

                                                }
                                                //find what type that implement wrap/unwrap
                                                CodeTypeDeclaration implBy = txPlan.ImplTypeDecl;

                                                //c-to-cpp => from 'raw' pointer to 'smart' pointer
                                                //cpp-to-c => from 'smart' pointer to 'raw' pointer

                                                if (implBy.Name.Contains("CToCpp"))
                                                {
                                                    //so if you want to send this to client lib
                                                    //you need to GET raw pointer , so =>
                                                    stbuilder.Append("MyCefSetVoidPtr(ret," + implBy.Name + "::Unwrap" + "(ret_result));\r\n");
                                                }
                                                else if (implBy.Name.Contains("CppToC"))
                                                {
                                                    stbuilder.Append("MyCefSetVoidPtr(ret," + implBy.Name + "::Wrap" + "(ret_result));\r\n");
                                                }
                                                else
                                                {

                                                }

                                            }
                                            else
                                            {

                                            }
                                        }
                                        else
                                        {
                                            stbuilder.Append("MyCefSetVoidPtr(ret,ret_result);\r\n");
                                        }
                                    }
                                    break;
                                case ContainerTypeKind.Pointer:
                                    {
                                        if (refOrPtr.ElementType.BridgeInfo.WellKnownTypeName == WellKnownTypeName.Void)
                                        {
                                            //void*
                                            stbuilder.Append("MyCefSetVoidPtr(ret,ret_result);\r\n");

                                        }
                                        else
                                        {

                                        }

                                    }
                                    break;
                                case ContainerTypeKind.ScopePtr:
                                    break;
                            }
                        }
                        break;
                    case TypeSymbolKind.Simple:
                        {
                            SimpleTypeSymbol simpleType = (SimpleTypeSymbol)ret.TypeSymbol;
                            switch (simpleType.PrimitiveTypeKind)
                            {
                                default:
                                    break;
                                case PrimitiveTypeKind.NotPrimitiveType:
                                    {
                                        SimpleTypeSymbol ss = (SimpleTypeSymbol)simpleType;
                                        if (ss.IsEnum)
                                        {
                                            //enum class
                                            stbuilder.AppendLine("MyCefSetInt32(ret,(int32_t)ret_result);\r\n");
                                        }
                                        else
                                        {
                                            switch (ss.Name)
                                            {
                                                default:
                                                    {

                                                    }
                                                    break;
                                                case "CefTime":
                                                case "CefRect":
                                                case "CefPoint":
                                                    {
                                                        //original code return the "value" type
                                                        //we have 2 choices
                                                        //1. copy-by-value
                                                        //2. copy-by-reference

                                                        //---test with copy by reference
                                                        //
                                                        stbuilder.AppendLine(ss.Name + "* tmp_d1= new " + ss.Name + "();");//new on heap
                                                        stbuilder.AppendLine("tmp_d1 = ret_result");//copy value type to free heap
                                                        stbuilder.AppendLine("MyCefSetVoidPtr(ret,tmp_d1);\r\n");

                                                    }
                                                    break;
                                            }
                                        }

                                    }
                                    break;
                                case PrimitiveTypeKind.CefString:
                                    stbuilder.Append("SetCefStringToJsValue(ret,ret_result);\r\n");
                                    break;
                                case PrimitiveTypeKind.NaitveInt:
                                    stbuilder.Append("MyCefSetInt64(ret,ret_result);\r\n");
                                    break;
                                case PrimitiveTypeKind.size_t:
                                    stbuilder.Append("MyCefSetInt32(ret, (int32_t)ret_result);\r\n");
                                    break;
                                case PrimitiveTypeKind.Int64:
                                    stbuilder.Append("MyCefSetInt64(ret,ret_result);\r\n");
                                    break;
                                case PrimitiveTypeKind.UInt64:
                                    stbuilder.Append("MyCefSetUInt64(ret,ret_result);\r\n");
                                    break;
                                case PrimitiveTypeKind.Double:
                                    stbuilder.Append("MyCefSetDouble(ret,ret_result);\r\n");
                                    break;
                                case PrimitiveTypeKind.Float:
                                    stbuilder.Append("MyCefSetFloat(ret,ret_result);\r\n");
                                    break;
                                case PrimitiveTypeKind.Bool:
                                    stbuilder.Append("MyCefSetBool(ret,ret_result);\r\n");
                                    break;
                                case PrimitiveTypeKind.UInt32:
                                    stbuilder.Append("MyCefSetUInt32(ret,ret_result);\r\n");
                                    break;
                                case PrimitiveTypeKind.Int32:
                                    stbuilder.Append("MyCefSetInt32(ret,ret_result);\r\n");
                                    break;
                            }
                        }
                        break;
                }
            }


        }
        public override void GenerateCsCode(CodeStringBuilder stbuilder)
        {
            //create C# code that call the cefbridge interop method
            base.GenerateCsCode(stbuilder);
        }
    }


}