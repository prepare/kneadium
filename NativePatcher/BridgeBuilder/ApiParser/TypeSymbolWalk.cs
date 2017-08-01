//MIT, 2016-2017 ,WinterDev
using System;

namespace BridgeBuilder
{
    class TypeSymbolWalk
    {

        public void Walk(TypeSymbol typeSymbol)
        {

            switch (typeSymbol.TypeSymbolKind)
            {
                default:
                    throw new NotSupportedException();
                case TypeSymbolKind.Simple:
                    PreviewVisitSimpleType((SimpleTypeSymbol)typeSymbol);
                    break;
                case TypeSymbolKind.Template:
                    PreviewVisitTypeTemplate((TemplateTypeSymbol)typeSymbol);
                    break;
                case TypeSymbolKind.TemplateParameter:
                    throw new NotSupportedException();
                case TypeSymbolKind.TypeDef:
                    PreviewVisitTypeDef((CTypeDefTypeSymbol)typeSymbol);
                    break;
                case TypeSymbolKind.Vec:
                    VisitVectorType((VecTypeSymbol)typeSymbol);
                    break;
                case TypeSymbolKind.ReferenceOrPointer:
                    PreviewVisitReferenceOrPointer((ReferenceOrPointerTypeSymbol)typeSymbol);
                    break;
            }
        }
        protected virtual void PreviewVisitReferenceOrPointer(ReferenceOrPointerTypeSymbol t)
        {
            switch (t.Kind)
            {
                default: throw new NotSupportedException();
                case ContainerTypeKind.ByRef: 
                    VisitByRef(t);
                    break;
                case ContainerTypeKind.CefRefPtr: 
                    VisitByCefRefPtr(t);
                    break;
                case ContainerTypeKind.Pointer: 
                    VisitByPointer(t);
                    break;
                case ContainerTypeKind.ScopePtr: 
                    VisitByScopePtr(t);
                    break;
            }
        }
        protected virtual void VisitByRef(ReferenceOrPointerTypeSymbol t)
        {

        }
        protected virtual void VisitByPointer(ReferenceOrPointerTypeSymbol t)
        {

        }
        protected virtual void VisitByCefRefPtr(ReferenceOrPointerTypeSymbol t)
        {

        }
        protected virtual void VisitByScopePtr(ReferenceOrPointerTypeSymbol t)
        {

        }
        protected virtual void PreviewVisitTypeTemplate(TemplateTypeSymbol t)
        {
            switch (t.ItemCount)
            {
                default: throw new NotSupportedException();
                case 1:
                    VisitTypeTemplate1((TemplateTypeSymbol1)t);
                    break;
                case 2:
                    VisitTypeTemplate2((TemplateTypeSymbol2)t);
                    break;
                case 3:
                    VisitTypeTemplate3((TemplateTypeSymbol3)t);
                    break;
            }
        }
        protected virtual void VisitVectorType(VecTypeSymbol t)
        {
        }
        protected virtual void VisitTypeTemplate1(TemplateTypeSymbol1 t1)
        {

        }
        protected virtual void VisitTypeTemplate2(TemplateTypeSymbol2 t2)
        {

        }
        protected virtual void VisitTypeTemplate3(TemplateTypeSymbol3 t3)
        {

        }
        protected virtual void PreviewVisitTypeDef(CTypeDefTypeSymbol t)
        {


        }
        protected virtual void PreviewVisitSimpleType(SimpleTypeSymbol t)
        {
            switch (t.PrimitiveTypeKind)
            {
                default:
                    throw new NotSupportedException();
                case PrimitiveTypeKind.NotPrimitiveType:
                    PreviewVisitSimpleTypeNonPrimitive(t);
                    break;
                case PrimitiveTypeKind.Void:
                    VisitVoid(t);
                    break;
                case PrimitiveTypeKind.Int32:
                    VisitInt32(t);
                    break;
                case PrimitiveTypeKind.UInt32:
                    VisitUInt32(t);
                    break;
                case PrimitiveTypeKind.UInt64:
                    VisitUInt64(t);
                    break;
                case PrimitiveTypeKind.Int64:
                    VisitInt64(t);
                    break;
                case PrimitiveTypeKind.NaitveInt:
                    VisitNativeInt(t);
                    break;
                case PrimitiveTypeKind.IntPtr:
                    VisitIntPtr(t);
                    break;
                case PrimitiveTypeKind.Double:
                    VisitDouble(t);
                    break;
                case PrimitiveTypeKind.Float:
                    VisitFloat(t);
                    break;
                case PrimitiveTypeKind.Char:
                    VisitChar(t);
                    break;
                case PrimitiveTypeKind.Bool:
                    VisitBool(t);
                    break;
                case PrimitiveTypeKind.String:
                    VisitString(t);
                    break;
                case PrimitiveTypeKind.CefString:
                    VisitCefString(t);
                    break;
                case PrimitiveTypeKind.size_t:
                    Visit_size_t(t);
                    break;
            }
        }
        protected virtual void VisitVoid(SimpleTypeSymbol t)
        {
        }
        protected virtual void VisitBool(SimpleTypeSymbol t)
        {
        }
        protected virtual void VisitChar(SimpleTypeSymbol t)
        {
        }
        protected virtual void VisitInt32(SimpleTypeSymbol t)
        {
        }
        protected virtual void VisitUInt32(SimpleTypeSymbol t)
        {
        }
        protected virtual void VisitInt64(SimpleTypeSymbol t)
        {
        }
        protected virtual void VisitUInt64(SimpleTypeSymbol t)
        {
        }
        protected virtual void VisitNativeInt(SimpleTypeSymbol t)
        {
        }
        protected virtual void VisitIntPtr(SimpleTypeSymbol t)
        {
        }
        protected virtual void Visit_size_t(SimpleTypeSymbol t)
        {
        }
        protected virtual void VisitDouble(SimpleTypeSymbol t)
        {
        }
        protected virtual void VisitFloat(SimpleTypeSymbol t)
        {
        }

        protected virtual void VisitString(SimpleTypeSymbol t)
        {
        }
        protected virtual void VisitCefString(SimpleTypeSymbol t)
        {
        }

        //
        protected virtual void PreviewVisitSimpleTypeNonPrimitive(SimpleTypeSymbol t)
        {
            //check its base
            TypeSymbol baseType = t.BaseType;
            if (baseType == null)
            {
                VisitSimpleTypeNoBaseType(t);
            }
            else
            {
                switch (baseType.TypeSymbolKind)
                {
                    default:
                        VisitSimpleTypeOtherBase(t);
                        break;
                    case TypeSymbolKind.Template:
                        {
                            TemplateTypeSymbol tt = (TemplateTypeSymbol)baseType;
                            switch (tt.ItemCount)
                            {
                                default:
                                    throw new NotSupportedException();
                                case 1:
                                    VisitSimpleTypeBase1(t, (TemplateTypeSymbol1)tt);
                                    break;
                                case 2:
                                    VisitSimpleTypeBase2(t, (TemplateTypeSymbol2)tt);
                                    break;
                                case 3:
                                    VisitSimpleTypeBase3(t, (TemplateTypeSymbol3)tt);
                                    break;
                            }
                        }
                        break;
                }
            }
        }
        protected virtual void VisitSimpleTypeNoBaseType(SimpleTypeSymbol t)
        {
        }
        protected virtual void VisitSimpleTypeOtherBase(SimpleTypeSymbol t)
        {

        }
        protected virtual void VisitSimpleTypeBase1(SimpleTypeSymbol t, TemplateTypeSymbol1 baseT1)
        {
        }
        protected virtual void VisitSimpleTypeBase2(SimpleTypeSymbol t, TemplateTypeSymbol2 baseT2)
        {
        }
        protected virtual void VisitSimpleTypeBase3(SimpleTypeSymbol t, TemplateTypeSymbol3 baseT3)
        {

        }
    }


}
