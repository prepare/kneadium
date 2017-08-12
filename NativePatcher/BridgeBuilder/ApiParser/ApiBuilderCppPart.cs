//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeBuilder
{

    class ApiBuilderCppPart
    {
        CodeTypeDeclaration _currentCodeTypeDecl;
        TypeTxInfo _typeTxInfo;
        public void GenerateCppPart(TypeTxInfo typeTxInfo, StringBuilder stbuilder)
        {
            _typeTxInfo = typeTxInfo;
            _currentCodeTypeDecl = typeTxInfo.TypeDecl;
            //--------------------
            switch (typeTxInfo.CefTypeModel)
            {
                case CefTypeModel.CefCppToCRefCounted:
                case CefTypeModel.CefCppToCScoped:
                    break;
                case CefTypeModel.CefCToCppRefCounted:
                case CefTypeModel.CefCToCppScoped:
                    break;
            }
            

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
            if (count > 0)
            {
                //-----

                //-----
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

        }
        void GenerateCppMethod(MethodTxInfo met, StringBuilder stbuilder)
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
                                    {
                                        //cpp object of cef 'smart' pointer (ref-count) 
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
                                case ContainerTypeKind.scoped_ptr:
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
            stbuilder.AppendLine("// autogen! " + met.ToString());
            //----
            string instThis = "me";
            if (ret.IsVoid)
            {
                //call, no return result
                stbuilder.Append(instThis + "->" + met.Name + "(");
                stbuilder.Append(arglistBuilder.ToString());
                stbuilder.Append(");\r\n");
                stbuilder.Append("ret->type = JSVALUE_TYPE_EMPTY;");
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
                                    stbuilder.Append("MyCefSetInt32(ret, (int32_t)ret_result);\r\n");
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
            //---------
            switch (_typeTxInfo.CefTypeModel)
            {
                default:
                    break;
                case CefTypeModel.CefBaseScoped:
                    break;
                case CefTypeModel.CefBaseRefCounted:
                    break;
                case CefTypeModel.CefStructBase:
                    break;
                case CefTypeModel.Unknown:
                    break;
                case CefTypeModel.CefCToCppRefCounted:

                    break;
                case CefTypeModel.CefCToCppScoped:
                    stbuilder.AppendLine();
                    stbuilder.AppendLine(this._currentCodeTypeDecl.Name + "::Unwrap(" + instThis + ");");
                    break;
            }

        }

    }

}
