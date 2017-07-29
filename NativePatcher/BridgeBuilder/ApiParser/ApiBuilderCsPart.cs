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
                case WellKnownTypeName.Void:
                    stbuilder.Append("void");
                    break;
                case WellKnownTypeName.Bool:
                    stbuilder.Append("bool");
                    break;
                default:



                    break;
            }
        }
        void WriteMethodParameterType(StringBuilder stbuilder, TypeSymbol retTypeSymbol)
        {
            TypeBridgeInfo retTypeBridge = retTypeSymbol.BridgeInfo;
            switch (retTypeBridge.WellKnownTypeName)
            {
                case WellKnownTypeName.Void:
                    stbuilder.Append("void");
                    break;
                case WellKnownTypeName.Bool:
                    stbuilder.Append("bool");
                    break;
                case WellKnownTypeName.RefOfCString:
                    stbuilder.Append("string");
                    break;
                default:



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
        public void GenCsMethod(MethodTxInfo metTx, StringBuilder codeDeclTypeBuilder)
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
            if (argCount > 5)
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
