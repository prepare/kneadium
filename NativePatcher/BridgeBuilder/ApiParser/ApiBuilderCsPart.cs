//MIT, 2016-2017 ,WinterDev
using System;
using System.Text;
namespace BridgeBuilder
{
    class ApiBuilderCsPart
    {
        CefTypeCollection cefTypeCollection = new CefTypeCollection();
        CodeTypeDeclaration typedecl;
        public void GenerateCsType(TypeTxInfo typeTxInfo, StringBuilder stbuilder)
        {

            this.typedecl = typeTxInfo.TypeDecl;
            if (typedecl.Kind == TypeKind.Enum)
            {
                //enum 
                stbuilder.Append("public enum ");
                stbuilder.Append(typedecl.Name);
                stbuilder.AppendLine("{");
                //
                int fieldCount = 0;
                foreach (FieldTxInfo field in typeTxInfo.fields)
                {
                    if (fieldCount > 0)
                    {
                        stbuilder.AppendLine(",");
                    }
                    GenCsEnumField(field, stbuilder);
                    fieldCount++;
                }
                //
                stbuilder.AppendLine("}");
            }
            else
            {
                stbuilder.Append("public partial struct ");
                stbuilder.Append(typedecl.Name);
                stbuilder.Append("{\r\n");
                stbuilder.Append(" public  IntPtr nativePtr;\r\n");
                //-----
                //ctor
                stbuilder.AppendLine("internal " + typedecl.Name + "(IntPtr nativePtr){");
                stbuilder.Append("this.nativePtr= nativePtr;");
                stbuilder.AppendLine("}");
                //-----
                foreach (MethodTxInfo met in typeTxInfo.methods)
                {
                    GenCsMethod(met, stbuilder);
                    stbuilder.Append("\r\n");
                }
                stbuilder.AppendLine("}");
            }
        }
        void WriteMethodReturnType(StringBuilder stbuilder, MethodParameterTxInfo par, TypeSymbol retTypeSymbol)
        {
            TypeBridgeInfo retTypeBridge = retTypeSymbol.BridgeInfo;
            switch (retTypeBridge.WellKnownTypeName)
            {
                default:

                    break;
                case WellKnownTypeName.OtherCppClass:
                    {
                        if (retTypeSymbol.ToString() == "time_t")
                        {
                            stbuilder.Append("long");
                        }
                        else
                        {
                        }
                    }
                    break;
                case WellKnownTypeName.UInt64:
                    stbuilder.Append("ulong");
                    break;
                case WellKnownTypeName.Int32:
                    stbuilder.Append("int");
                    break;
                case WellKnownTypeName.UInt32:
                    stbuilder.Append("uint");
                    break;
                case WellKnownTypeName.Int64:
                    stbuilder.Append("long");
                    break;
                case WellKnownTypeName.Void:
                    stbuilder.Append("void");
                    break;
                case WellKnownTypeName.Bool:
                    stbuilder.Append("bool");
                    break;
                case WellKnownTypeName.Double:
                    stbuilder.Append("double");
                    break;
                case WellKnownTypeName.NativeInt:
                    stbuilder.Append("long");
                    break;
                case WellKnownTypeName.size_t:
                    //this version size_t is CAST down to int32
                    stbuilder.Append("int");
                    break;
                case WellKnownTypeName.RefPtrOf:
                    {
                        ReferenceOrPointerTypeSymbol refOrPointer = (ReferenceOrPointerTypeSymbol)retTypeSymbol;
                        TypeSymbol elemType = refOrPointer.ElementType;
                        switch (elemType.TypeSymbolKind)
                        {
                            default:
                                //of what 
                                stbuilder.Append("IntPtr");
                                break;
                            case TypeSymbolKind.Simple:
                                {
                                    SimpleTypeSymbol simpleElem = (SimpleTypeSymbol)elemType;
                                    if (simpleElem.PrimitiveTypeKind == PrimitiveTypeKind.NotPrimitiveType)
                                    {
                                        stbuilder.Append(simpleElem.ToString());
                                    }
                                    else
                                    {
                                        //other is primitive

                                    }
                                }
                                break;
                        }
                    }

                    break;
                case WellKnownTypeName.CefCNative:
                    stbuilder.Append(retTypeSymbol.ToString());
                    break;
                case WellKnownTypeName.CefString:
                    stbuilder.Append("string");
                    break;
                case WellKnownTypeName.TypeDefToAnother:
                    {
                        CTypeDefTypeSymbol ctypedefSymbol = (CTypeDefTypeSymbol)retTypeSymbol;
                        TypeSymbol referToType = ctypedefSymbol.ReferToTypeSymbol;
                        TypeBridgeInfo referToTypeBridge = referToType.BridgeInfo;
                        switch (referToTypeBridge.WellKnownTypeName)
                        {
                            case WellKnownTypeName.CefCNative:
                                {
                                    string typename = retTypeSymbol.ToString();
                                    stbuilder.Append(typename);
                                }
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case WellKnownTypeName.CefCpp:
                    {
                        string typename = retTypeSymbol.ToString();
                        stbuilder.Append(typename);
                    }
                    break;

            }
        }
        void WriteMethodParameterType(StringBuilder stbuilder, MethodParameterTxInfo par, TypeSymbol parType)
        {
            TypeBridgeInfo parTypeBridge = parType.BridgeInfo;
            if (parTypeBridge.CsMethodParType == null)
            {

            }
            else
            {
                stbuilder.Append(parTypeBridge.CsMethodParType);
            }
        }
        void WriteArgSetValue(StringBuilder stbuilder, string argName, MethodParameterTxInfo par)
        {
            TypeSymbol parType = par.TypeSymbol;
            TypeBridgeInfo bridgeInfo = par.TypeSymbol.BridgeInfo;
            if (bridgeInfo.CsAssignMethodName == null)
            {
                throw new NotSupportedException();
            }
            if (bridgeInfo.CsAssignMethodName == "Set_NativePtr")
            {
                stbuilder.AppendLine(bridgeInfo.CsAssignMethodName + "(ref " + argName + "," + par.Name + ".nativePtr);");
            }
            else if (bridgeInfo.CsAssignMethodName.StartsWith("Set_ListOf_"))
            {
                //need spcial method of create a list for native side
                //and copy content of that list back from cpp side to .net side
                stbuilder.AppendLine(bridgeInfo.CsAssignMethodName + "(ref " + argName + "," + par.Name + ".nativePtr);");
            }
            else
            {
                stbuilder.AppendLine(bridgeInfo.CsAssignMethodName + "(ref " + argName + "," + par.Name + ");");
            }
        }

        void WriteReturnGetValue(StringBuilder stbuilder, string ret_result, string retVarName, MethodParameterTxInfo par)
        {

            TypeSymbol parType = par.TypeSymbol;
            TypeBridgeInfo bridgeInfo = par.TypeSymbol.BridgeInfo;
            if (bridgeInfo.CsAssignMethodName == null)
            {
                throw new NotSupportedException();
            }
            if (bridgeInfo.CsGetValueMethodName == "Get_NativePtr")
            {
                stbuilder.AppendLine("var " + ret_result + "= new " + ((SimpleTypeSymbol)parType).Name + "(" + bridgeInfo.CsGetValueMethodName + "(ref " + retVarName + "));");
            }
            else if (bridgeInfo.CsGetValueMethodName == "Get_IntPtr")
            {
                if (parType is SimpleTypeSymbol)
                {
                    stbuilder.AppendLine("var " + ret_result + "= new " + ((SimpleTypeSymbol)parType).Name + "(" + bridgeInfo.CsGetValueMethodName + "(ref " + retVarName + "));");
                }
                else if (parType is ReferenceOrPointerTypeSymbol)
                {
                    ReferenceOrPointerTypeSymbol refOrPointer = (ReferenceOrPointerTypeSymbol)parType;
                    stbuilder.AppendLine("var " + ret_result + "= new " + (refOrPointer.ElementType) + "(" + bridgeInfo.CsGetValueMethodName + "(ref " + retVarName + "));");
                }
                else if (parType is CTypeDefTypeSymbol)
                {
                    CTypeDefTypeSymbol typdefSymbol = (CTypeDefTypeSymbol)parType;
                    stbuilder.AppendLine("var " + ret_result + "= new " + (typdefSymbol.Name) + "(" + bridgeInfo.CsGetValueMethodName + "(ref " + retVarName + "));");
                }
                else
                {

                }


            }
            else if (bridgeInfo.CsGetValueMethodName.StartsWith("Get_ListOf_"))
            {
                //need spcial method of create a list for native side
                //and copy content of that list back from cpp side to .net side
                stbuilder.AppendLine("var " + ret_result + "=" + bridgeInfo.CsGetValueMethodName + "(ref " + retVarName + ");");
            }
            else
            {
                stbuilder.AppendLine("var " + ret_result + "=" + bridgeInfo.CsGetValueMethodName + "(ref " + retVarName + ");");
            }
        }
        void WriteArgCleanUpCode(StringBuilder stbuilder, string argName, MethodParameterTxInfo par)
        {

            TypeSymbol parType = par.TypeSymbol;
            if (parType.BridgeInfo.WellKnownTypeName == WellKnownTypeName.RefOfCefString)
            {
                stbuilder.AppendLine("MyCefDeleteCefStringHolder(ref " + argName + ");");
            }
        }
        void GenCsEnumField(FieldTxInfo fieldTx, StringBuilder codeTypeDeclBuilder)
        {
            CodeFieldDeclaration fielddecl = fieldTx.fieldDecl;
            codeTypeDeclBuilder.Append(fielddecl.Name);
            if (fielddecl.InitExpression != null)
            {
                codeTypeDeclBuilder.Append('=');
                codeTypeDeclBuilder.Append(fielddecl.InitExpression.ToString());
            }

        }
        void GenCsMethod(MethodTxInfo metTx, StringBuilder codeTypeDeclBuilder)
        {
            StringBuilder stbuilder = new StringBuilder();
            stbuilder.Append("public ");
            //1. return type 

            MethodParameterTxInfo retTypeTx = metTx.ReturnPlan;
            WriteMethodReturnType(stbuilder, retTypeTx, retTypeTx.TypeSymbol);

            stbuilder.Append(' ');
            //2. name
            stbuilder.Append(metTx.Name);
            //3.
            int argCount = metTx.pars.Count;
            stbuilder.Append('(');
            if (argCount > 7)
            {
                throw new NotSupportedException();
            }
            for (int i = 0; i < argCount; ++i)
            {
                if (i > 0)
                {
                    stbuilder.Append(',');
                }

                MethodParameterTxInfo par = metTx.pars[i];
                WriteMethodParameterType(stbuilder, par, par.TypeSymbol);
                stbuilder.Append(' ');
                stbuilder.Append(par.Name);
            }
            stbuilder.Append("){\r\n");
            stbuilder.AppendLine();
            stbuilder.AppendLine("// autogen! " + metTx.ToString());
            stbuilder.AppendLine();
            //prepare user data from method args
            //before send it to native side 

            for (int i = 0; i < argCount; ++i)
            {
                string assignTo = "a" + (i + 1);
                stbuilder.AppendLine("JsValue " + assignTo + "= new JsValue();");
                MethodParameterTxInfo par = metTx.pars[i];
                WriteArgSetValue(stbuilder, assignTo, par);
            }
            stbuilder.AppendLine("JsValue ret;");
            //assign parameter value 
            stbuilder.Append("Cef3Binder.MyCefMet_" + argCount + "(");
            stbuilder.Append("this.nativePtr,\r\n" +
                "    CefNativeType." + this.typedecl.Name + ",\r\n" +
                "    (int)CefNativeType_" + this.typedecl.Name + "." + metTx.Name + ",\r\n" +
                "    out ret");
            for (int i = 0; i < argCount; ++i)
            {
                stbuilder.Append(",ref " + "a" + (i + 1));
            }
            stbuilder.AppendLine(");");
            string ret_result = "ret_result";
            if (!retTypeTx.IsVoid)
            {
                //get data and store to local 
                WriteReturnGetValue(stbuilder, ret_result, "ret", retTypeTx);
            }

            //-------
            //some clean up code before exit 
            for (int i = 0; i < argCount; ++i)
            {
                string assignTo = "a" + (i + 1);
                MethodParameterTxInfo par = metTx.pars[i];
                WriteArgCleanUpCode(stbuilder, assignTo, par);
            }
            if (!retTypeTx.IsVoid)
            {
                stbuilder.AppendLine("return " + ret_result + ";");
            }
            //-------
            stbuilder.AppendLine("}\r\n");

            codeTypeDeclBuilder.Append(stbuilder.ToString());
        }

    }


}
