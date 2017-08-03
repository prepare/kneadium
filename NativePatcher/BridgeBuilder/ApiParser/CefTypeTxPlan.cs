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
            dbugIncLineCount();
#endif
            stbuilder.AppendLine(text);
        }
        public void AppendLine()
        {
#if DEBUG
            dbugIncLineCount();
#endif
            stbuilder.AppendLine();
        }
#if DEBUG
        void dbugIncLineCount()
        {

            _dbugLineCount++;
            if (_dbugEnableLineNote)
            {
                stbuilder.Append("/*" + _dbugLineCount + "*/");
            }
            if (_dbugLineCount >= 142)
            {

            }
        }
#endif

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

        static string GetRawPtrMet(ImplWrapDirection wrapDirection)
        {

            //c-to-cpp
            //            template <class ClassName, class BaseName, class StructName>
            //CefRefPtr<BaseName> CefCToCppRefCounted<ClassName, BaseName, StructName>::Wrap(
            //    StructName* s)
            //        {
            //            if (!s)
            //                return NULL;


            //            template <class ClassName, class BaseName, class StructName>
            //StructName* CefCToCppRefCounted<ClassName, BaseName, StructName>::Unwrap(
            //    CefRefPtr<BaseName> c)
            //        {
            //            if (!c.get())
            //                return NULL;

            //------------------------------------
            //cpp-to-c
            //            // Wrap a C++ class with a C structure.  This is used when the class
            //            // implementation exists on this side of the DLL boundary but will have methods
            //            // called from the other side of the DLL boundary.
            //            template <class ClassName, class BaseName, class StructName>
            //class CefCppToCRefCounted : public CefBaseRefCounted {
            // public:
            //  // Create a new wrapper instance and associated structure reference for
            //  // passing an object instance the other side.
            //  static StructName* Wrap(CefRefPtr<BaseName> c)
            //        {
            //            if (!c.get())
            //                return NULL;

            //            // Wrap our object with the CefCppToCRefCounted class.
            //            ClassName* wrapper = new ClassName();
            //            wrapper->wrapper_struct_.object_ = c.get();
            //            // Add a reference to our wrapper object that will be released once our
            //            // structure arrives on the other side.
            //            wrapper->AddRef();
            //            // Return the structure pointer that can now be passed to the other side.
            //            return wrapper->GetStruct();
            //        }

            //        // Retrieve the underlying object instance for a structure reference passed
            //        // back from the other side.
            //        static CefRefPtr<BaseName> Unwrap(StructName* s)
            //        {
            //            if (!s)
            //                return NULL;

            //            // Cast our structure to the wrapper structure type.
            //            WrapperStruct* wrapperStruct = GetWrapperStruct(s);

            //            // If the type does not match this object then we need to unwrap as the
            //            // derived type.
            //            if (wrapperStruct->type_ != kWrapperType)
            //                return UnwrapDerived(wrapperStruct->type_, s);

            //            // Add the underlying object instance to a smart pointer.
            //            CefRefPtr<BaseName> objectPtr(wrapperStruct->object_);
            //            // Release the reference to our wrapper object that was added before the
            //            // structure was passed back to us.
            //            wrapperStruct->wrapper_->Release();
            //            // Return the underlying object instance.
            //            return objectPtr;
            //        }


            switch (wrapDirection)
            {
                default:
                    throw new NotSupportedException();
                case ImplWrapDirection.CppToC:
                    return "Wrap";
                case ImplWrapDirection.CToCpp:
                    return "Unwrap";
                    break;
            }
        }
        static string GetSmartPointerMet(ImplWrapDirection wrapDirection)
        {
            switch (wrapDirection)
            {
                default:
                    throw new NotSupportedException();
                case ImplWrapDirection.CppToC:
                    return "Unwrap";
                case ImplWrapDirection.CToCpp:
                    return "Wrap";
            }

        }

        public override void GenerateCppCode(CodeStringBuilder stbuilder)
        {
            //
            //create switch table for C#-interop
            //
            CodeTypeDeclaration orgDecl = this.OriginalDecl;
            CodeTypeDeclaration implTypeDecl = this.ImplTypeDecl;

            _typeTxInfo = implTypeDecl.TypeTxInfo;
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
            }
            else if (implTypeDecl.Name.Contains("CppToC"))
            {
                implWrapDirection = ImplWrapDirection.CppToC;
            }
            else
            {
                implWrapDirection = ImplWrapDirection.None;
            }

            totalTypeMethod.AppendLine("auto me=" + implTypeDecl.Name + "::" + GetSmartPointerMet(implWrapDirection) + "(me1);");
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

            totalTypeMethod.AppendLine(implTypeDecl.Name + "::" + GetRawPtrMet(implWrapDirection) + "(me1);");

            totalTypeMethod.AppendLine("}");
        }


        static void GenGetCefSmartPtr(StringBuilder arglistBuilder, string argName, TypeBridgeInfo bridge, ReferenceOrPointerTypeSymbol refOrPtr)
        {
            switch (refOrPtr.Kind)
            {
                default:

                    break;
                case ContainerTypeKind.ByRef:
                    {
                        //by ref or what

                        //cast data from ptr
                        string elemTypeName = refOrPtr.ElementType.ToString();
                        switch (elemTypeName)
                        {
                            default:
                                {
                                    arglistBuilder.Append("(" + elemTypeName + "*)");
                                    arglistBuilder.Append(argName);
                                }
                                break;
                            case "CefString":
                                {
                                    arglistBuilder.Append("GetStringHolder(" + argName + ")->value");
                                }
                                break;
                        }
                    }
                    break;
                case ContainerTypeKind.CefRefPtr:
                    {
                        TypeBridgeInfo bridgeInfo = refOrPtr.BridgeInfo;
                        TypeSymbol elemtType = refOrPtr.ElementType;
                        if (elemtType is SimpleTypeSymbol)
                        {
                            CefTypeTxPlan txplan = ((SimpleTypeSymbol)elemtType).CefTxPlan;
                            CodeTypeDeclaration implTypeDecl = txplan.ImplTypeDecl;
                            ImplWrapDirection implWrapDirection = ImplWrapDirection.None;
                            if (implTypeDecl.Name.Contains("CToCpp"))
                            {
                                implWrapDirection = ImplWrapDirection.CToCpp;
                                string met = GetSmartPointerMet(implWrapDirection);
                                string slotName = bridge.CefCppSlotName.ToString();


                                arglistBuilder.Append(implTypeDecl.Name + "::" + met + "(" + "(" + txplan.UnderlyingCType + "*)" + (argName + "->" + slotName) + ")");
                            }
                            else if (implTypeDecl.Name.Contains("CppToC"))
                            {
                                implWrapDirection = ImplWrapDirection.CppToC;
                                string met = GetSmartPointerMet(implWrapDirection);
                                arglistBuilder.Append(implTypeDecl.Name + "::" + met + "(" + argName + ")");
                            }
                            else
                            {
                                implWrapDirection = ImplWrapDirection.None;
                                string met = GetSmartPointerMet(implWrapDirection);
                                arglistBuilder.Append(implTypeDecl.Name + "::" + met + "(" + argName + ")");
                            }
                        }
                        else
                        {

                        }
                        //cpp object of cef 'smart' pointer (ref-count) 

                        //string elemTypeName = refOrPtr.ElementType.ToString();
                        //ImplWrapDirection implWrapDirection = ImplWrapDirection.None;
                        //if (implTypeDecl.Name.Contains("CToCpp"))
                        //{
                        //    implWrapDirection = ImplWrapDirection.CToCpp;
                        //}
                        //else if (implTypeDecl.Name.Contains("CppToC"))
                        //{
                        //    implWrapDirection = ImplWrapDirection.CppToC;
                        //}
                        //else
                        //{
                        //    implWrapDirection = ImplWrapDirection.None;
                        //}

                        //arglistBuilder.Append("(" + elemTypeName + "*)");
                        //arglistBuilder.Append("v" + (i + 1));
                        //arglistBuilder.AppendLine("->" + bridge.CefCppSlotName);
                    }
                    break;
                case ContainerTypeKind.Pointer:
                    {
                        //string elemTypeName = refOrPtr.ElementType.ToString();
                        //arglistBuilder.Append("(" + elemTypeName + "*)");
                        //arglistBuilder.Append("v" + (i + 1));
                        //arglistBuilder.AppendLine("->" + bridge.CefCppSlotName);
                    }
                    break;
                case ContainerTypeKind.scoped_ptr:

                    break;
            }
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
                    arglistBuilder.AppendLine(",");
                }
                //
                MethodParameterTxInfo par = pars[i];
                TypeSymbol typeSymbol = par.TypeSymbol;
                TypeBridgeInfo bridge = typeSymbol.BridgeInfo;
                //get actual data from C# data
                //some data need wrap/unwrap
                //-------

                string argName = "v" + (i + 1);

                switch (typeSymbol.TypeSymbolKind)
                {
                    case TypeSymbolKind.ReferenceOrPointer:
                        {
                            GenGetCefSmartPtr(arglistBuilder, argName, bridge, (ReferenceOrPointerTypeSymbol)typeSymbol);
                        }
                        break;
                    case TypeSymbolKind.Simple:
                        {
                            SimpleTypeSymbol simpleType = (SimpleTypeSymbol)typeSymbol;
                            if (simpleType.IsEnum)
                            {
                                //treated as int32
                                arglistBuilder.Append(argName + "->" + bridge.CefCppSlotName);
                            }
                            else
                            {
                                switch (simpleType.PrimitiveTypeKind)
                                {
                                    default:
                                        break;
                                    case PrimitiveTypeKind.Bool:
                                        arglistBuilder.Append(argName + "->" + bridge.CefCppSlotName);
                                        arglistBuilder.Append(" != 0");
                                        break;
                                    case PrimitiveTypeKind.NotPrimitiveType:
                                        arglistBuilder.Append("(" + simpleType.ToString() + "*)");
                                        arglistBuilder.Append(argName + "->" + bridge.CefCppSlotName);
                                        break;
                                    case PrimitiveTypeKind.NaitveInt:
                                    case PrimitiveTypeKind.Int32:
                                    case PrimitiveTypeKind.Int64:
                                    case PrimitiveTypeKind.UInt32:
                                    case PrimitiveTypeKind.Float:
                                    case PrimitiveTypeKind.Double:
                                        arglistBuilder.Append(argName + "->" + bridge.CefCppSlotName);
                                        break;
                                }
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
                                case ContainerTypeKind.scoped_ptr:
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