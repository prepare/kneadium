//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeBuilder
{
    class ApiBuilderCsPart
    {
        CefTypeCollection cefTypeCollection = new CefTypeCollection();

        public void GenerateCsType(TypeTxInfo typeTxInfo, StringBuilder stbuilder)
        {

            CodeTypeDeclaration typedecl = typeTxInfo.TypeDecl;
            stbuilder.Append("public partial class ");
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
            stbuilder.Append("}");
        }
        void WriteMethodReturnType(StringBuilder stbuilder, TypeSymbol retTypeSymbol)
        {
            TypeBridgeInfo retTypeBridge = retTypeSymbol.BridgeInfo;
            switch (retTypeBridge.WellKnownTypeName)
            {
                default:

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
                                        stbuilder.Append("IntPtr");
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
        void WriteMethodParameterType(StringBuilder stbuilder, TypeSymbol retTypeSymbol)
        {
            TypeBridgeInfo retTypeBridge = retTypeSymbol.BridgeInfo;
            switch (retTypeBridge.WellKnownTypeName)
            {
                default:

                    break;
                case WellKnownTypeName.RefOfPrimitive:
                    {
                        //what is that primitive
                        ReferenceOrPointerTypeSymbol refOrPointer = (ReferenceOrPointerTypeSymbol)retTypeSymbol;
                        stbuilder.Append("ref ");
                        WriteMethodParameterType(stbuilder, refOrPointer.ElementType);
                    }
                    break;
                case WellKnownTypeName.Void:
                    stbuilder.Append("void");
                    break;
                case WellKnownTypeName.Bool:
                    stbuilder.Append("bool");
                    break;
                case WellKnownTypeName.Float:
                    stbuilder.Append("float");
                    break;
                case WellKnownTypeName.Double:
                    stbuilder.Append("double");
                    break;
                case WellKnownTypeName.RefOfCString:
                    stbuilder.Append("string");
                    break;
                case WellKnownTypeName.UInt32:
                    stbuilder.Append("uint");
                    break;
                case WellKnownTypeName.RefPtrOf:
                    {
                        string name = ((ReferenceOrPointerTypeSymbol)retTypeSymbol).ElementType.ToString();
                        switch (name)
                        {
                            case "CefBinaryValue":
                                break;
                            default:
                                if (name.EndsWith("Callback"))
                                {

                                }
                                else if (name.StartsWith("Cef"))
                                {
                                }
                                else
                                {

                                }
                                break;
                        }
                    }
                    stbuilder.Append("IntPtr");
                    break;
                case WellKnownTypeName.RefOf:
                    {
                        string name = ((ReferenceOrPointerTypeSymbol)retTypeSymbol).ElementType.ToString();
                        switch (name)
                        {
                            case "CefBinaryValue":
                                break;
                            default:
                                if (name.EndsWith("Callback"))
                                {

                                }
                                else
                                {

                                }
                                break;
                        }
                    }
                    break;
                case WellKnownTypeName.PtrOf:
                    stbuilder.Append("IntPtr");
                    break;
                case WellKnownTypeName.size_t:
                    stbuilder.Append("int");
                    break;
                case WellKnownTypeName.NativeInt:
                    stbuilder.Append("long");//TODO: review here
                    break;
                case WellKnownTypeName.Int64:
                    stbuilder.Append("long");
                    break;
                case WellKnownTypeName.RefOfVec:
                    {

                        VecTypeSymbol elem = (VecTypeSymbol)((ReferenceOrPointerTypeSymbol)retTypeSymbol).ElementType;
                        string vectorElementTypeName = elem.ElementType.ToString();
                        switch (vectorElementTypeName)
                        {
                            case "int64":
                                stbuilder.Append("List<long>");
                                break;
                            default:
                                break;
                        }
                    }
                    break;
                case WellKnownTypeName.CefCNative:
                    {
                        string typename = retTypeSymbol.ToString();
                        switch (typename)
                        {
                            default:
                                break;
                            case "CefProcessId":
                                stbuilder.Append("long");
                                break;
                        }

                    }
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
            }
        }
        void WriteArgExtractionCodeStmts(StringBuilder stbuilder, string argName, MethodParameterTxInfo par)
        {
            TypeBridgeInfo bridgeInfo = par.TypeSymbol.BridgeInfo;

            //string parResolvedType = par.TypeSymbol.ToString(); 
            //switch (parResolvedType)
            //{
            //    default:
            //        {
            //            if (parResolvedType.StartsWith("Cef"))
            //            {
            //                //native reference type
            //                stbuilder.AppendLine(assignTo + ".Type=JsValueType.Wrapped;");
            //                stbuilder.AppendLine(assignTo + ".Ptr=" + par.Name + ".nativePtr;");
            //            }
            //            else
            //            {
            //                //throw new NotSupportedException();
            //            }

            //        }
            //        break;
            //    case "int":
            //        {
            //            //use as int32 
            //            stbuilder.AppendLine(assignTo + ".Type=JsValueType.Integer;");
            //            stbuilder.AppendLine(assignTo + ".I32=" + par.Name + ";");
            //        }
            //        break;
            //    case "CefString":
            //        {
            //            //eg. Cef3Binder.MyCefCreateNativeStringHolder(ref a1, strValue);
            //            stbuilder.AppendLine("Cef3Binder.MyCefCreateNativeStringHolder(ref " +
            //                assignTo + "," + par.Name + ");");
            //        }
            //        break;
            //}



        }
        void GenCsMethod(MethodTxInfo metTx, StringBuilder codeDeclTypeBuilder)
        {
            StringBuilder stbuilder = new StringBuilder();
            stbuilder.Append("public ");
            //1. return type 
            MethodParameterTxInfo retType = metTx.ReturnPlan;
            WriteMethodReturnType(stbuilder, retType.TypeSymbol);

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
                WriteMethodParameterType(stbuilder, par.TypeSymbol);
                stbuilder.Append(' ');
                stbuilder.Append(par.Name);
            }
            stbuilder.Append("){\r\n");
            stbuilder.AppendLine();
            stbuilder.AppendLine("//autogen!");

            //body
            //prepare calling parameters
            stbuilder.AppendLine(@"
            JsValue a1 = new JsValue();
            JsValue a2 = new JsValue();
            JsValue ret;");

            for (int i = 0; i < argCount; ++i)
            {
                string assignTo = "a" + (i + 1);
                MethodParameterTxInfo par = metTx.pars[i];
                WriteArgExtractionCodeStmts(stbuilder, assignTo, par);
            }
            //assign parameter value
            stbuilder.Append("Cef3Binder.MyCefFrameCall2(");
            stbuilder.Append("this.nativePtr,\r\n" +
                "(int)CefFrameCallMsg.CefFrame_" + metTx.Name
                + ",out ret,ref a1,ref a2");
            stbuilder.AppendLine(");");
            //
            if (!retType.IsVoid)
            {
                //if not void
                //DotNetResolvedSimpleType simpleType = retType.DotnetResolvedType as DotNetResolvedSimpleType;
                //if (simpleType != null)
                //{
                //    //this is simple type
                //    string retName = simpleType.SimpleType.Name;
                //    switch (retName)
                //    {
                //        default:
                //            {
                //                if (retName.StartsWith("Cef"))
                //                {
                //                    stbuilder.AppendLine("return new " + retName + "(ret.Ptr);");
                //                }
                //                else
                //                {

                //                }
                //            }
                //            break;
                //        case "int64":
                //            {
                //                stbuilder.AppendLine("return ret.I64;");
                //            }
                //            break;
                //        case "CefString":
                //            {
                //                //return cef string
                //                stbuilder.AppendLine("return Cef3Binder.MyCefJsReadString(ref ret);");
                //            }
                //            break;
                //        case "bool":
                //            {
                //                stbuilder.AppendLine("return ret.I32 !=0;");
                //            }
                //            break;
                //    }
                //}
                //else
                //{
                //    throw new NotSupportedException();
                //}

            }
            stbuilder.Append("}\r\n");

            codeDeclTypeBuilder.Append(stbuilder.ToString());
        }

    }


}
