//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeBuilder
{

    class ApiBuilderCppPart
    {
        CodeTypeDeclaration _currentCodeTypeDecl;
        public void GenerateCppPart(TypeTxInfo typeTxInfo, StringBuilder stbuilder)
        {
            _currentCodeTypeDecl = typeTxInfo.TypeDecl;

            //
            //check this type wrap/unwrap method name
            //
            Dictionary<MethodTxInfo, StringBuilder> results = new Dictionary<MethodTxInfo, StringBuilder>();
            foreach (MethodTxInfo met in typeTxInfo.methods)
            {
                StringBuilder metStBuilder = new StringBuilder();
                GenerateCppMethod(met, metStBuilder);
                results.Add(met, metStBuilder);
            }

            //build switch table

            int caseNum = 0;

            int count = results.Count;
            stbuilder.AppendLine("switch(methodName){");
            foreach (var kp in results)
            {

                stbuilder.AppendLine("case " + caseNum + ":{");
                stbuilder.AppendLine(kp.Value.ToString());
                stbuilder.AppendLine("} break;");
                caseNum++;
            }
            stbuilder.AppendLine("}");

        }
        void GenerateCppMethod(MethodTxInfo met, StringBuilder stbuilder)
        {
            //----
            //extract managed args and then call native c++ method
            //----
            MethodParameterTxInfo ret = met.ReturnPlan;
            //----
            List<MethodParameterTxInfo> pars = met.pars;
            int parCount = pars.Count;
            if (parCount > 7)
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
                arglistBuilder.Append("v" + (i + 1));
                arglistBuilder.Append("->");



                //if (par.DotnetResolvedType is DotNetResolvedSimpleType)
                //{
                //    DotNetResolvedSimpleType simpleType = (DotNetResolvedSimpleType)par.DotnetResolvedType;
                //    if (simpleType.IsPrimitiveType)
                //    {
                //        arglistBuilder.Append("v" + (i + 1));
                //        switch (simpleType.Name)
                //        {
                //            case "bool":
                //                arglistBuilder.AppendLine("->i32");
                //                break;
                //            case "int":
                //                arglistBuilder.AppendLine("->i32");
                //                break;
                //            case "int64":
                //                arglistBuilder.AppendLine("->i64");
                //                break;
                //            default:
                //                throw new NotSupportedException();
                //        }
                //    }
                //    else
                //    {
                //        if (simpleType.Name == "CefString")
                //        {
                //            //get data inside MyCefStringHolder*
                //            arglistBuilder.Append("((MyCefStringHolder*)");
                //            arglistBuilder.Append("v" + (i + 1) + "->ptr");
                //            arglistBuilder.AppendLine(")->value");
                //        }
                //        else
                //        {
                //            //eg. cefFrame1->GetSource(CefStringVisitorCppToC::Unwrap((cef_string_visitor_t*)v1->ptr));

                //            arglistBuilder.Append(simpleType.Name + "CppToC::Unwrap((cef_string_visitor_t*)");
                //            arglistBuilder.Append("v" + (i + 1));
                //            arglistBuilder.AppendLine("->ptr)");
                //        }

                //    }
                //}
                //else if (par.DotnetResolvedType is DotNetList)
                //{
                //    //std::vector
                //    DotNetList simpleType = (DotNetList)par.DotnetResolvedType;
                //    arglistBuilder.Append("(std::vector<" + ((DotNetResolvedSimpleType)simpleType.ElementType).Name + ">)");
                //    arglistBuilder.Append("v" + (i + 1));
                //    arglistBuilder.AppendLine("->ptr");
                //}
                //else
                //{

                //}

            }

            //----
            if (ret.IsVoid)
            {
                //call, no return result
                stbuilder.Append("bw->" + met.Name + "(");
                stbuilder.Append(arglistBuilder.ToString());
                stbuilder.Append(");\r\n");
                stbuilder.Append("ret->type = JSVALUE_TYPE_EMPTY;");

            }
            else
            {
                stbuilder.Append("auto ret_result=");
                stbuilder.Append("bw->" + met.Name + "(");
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
                                    stbuilder.Append("MyCefSetVoidPtr(ret,ret_result);\r\n");
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

    }

}
