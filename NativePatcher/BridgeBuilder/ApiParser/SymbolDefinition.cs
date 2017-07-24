//MIT, 2016-2017 ,WinterDev
using System; 
namespace BridgeBuilder
{
    abstract class Symbol
    {

    }
    enum TypeSymbolKind
    {
        Simple,
        ReferenceOrPointer,
        Vec
    }

    enum ContainerTypeKind
    {

        ScopePtr,
        CefRefPtr,
        Pointer,
        ByRef,
    }
    abstract class TypeSymbol : Symbol
    {
        public abstract TypeSymbolKind TypeSymbolKind { get; }
        public CodeTypeDeclaration CreatedByTypeDeclaration { get; set; }

    }
    class SimpleType : TypeSymbol
    {
        public SimpleType(string name)
        {
            this.Name = name;
        }
        public override TypeSymbolKind TypeSymbolKind { get { return TypeSymbolKind.Simple; } }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }




    class VecTypeSymbol : TypeSymbol
    {
        public VecTypeSymbol(TypeSymbol elementType)
        {
            this.ElementType = elementType;
        }
        public override TypeSymbolKind TypeSymbolKind { get { return TypeSymbolKind.Vec; } }
        public TypeSymbol ElementType { get; set; }
        public override string ToString()
        {
            return "vec<" + ElementType + ">";
        }
    }
    class ReferenceOrPointerTypeSymbol : TypeSymbol
    {
        public ReferenceOrPointerTypeSymbol(TypeSymbol elementType, ContainerTypeKind kind)
        {
            this.ElementType = elementType;
            this.Kind = kind;
        }
        public ContainerTypeKind Kind
        {
            get;
            set;
        }
        public TypeSymbol ElementType { get; set; }
        public override TypeSymbolKind TypeSymbolKind { get { return TypeSymbolKind.ReferenceOrPointer; } }
        public override string ToString()
        {
            switch (Kind)
            {

                case ContainerTypeKind.ScopePtr: return "scoped_ptr<" + ElementType.ToString() + ">";
                case ContainerTypeKind.CefRefPtr: return "refptr<" + ElementType.ToString() + ">";
                case ContainerTypeKind.Pointer: return ElementType.ToString() + "*";
                case ContainerTypeKind.ByRef: return ElementType.ToString() + "&";
                default:
                    throw new NotSupportedException();
            }
        }
    }


}