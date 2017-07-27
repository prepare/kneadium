//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;

namespace BridgeBuilder
{
    abstract class Symbol
    {
        /// <summary>
        /// general purpose note
        /// </summary>
        public string CompilerNote { get; set; }
    }
    enum TypeSymbolKind
    {
        Simple,
        ReferenceOrPointer,
        Vec,
        Template,
        TemplateParameter,
        TypeDef,
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
#if DEBUG
        public readonly int dbugId = dbugTotalId++;
        static int dbugTotalId;
        public TypeSymbol()
        {
            if (dbugId == 768)
            {

            }
        }
#endif
        public abstract TypeSymbolKind TypeSymbolKind { get; }
    }
    class SimpleTypeSymbol : TypeSymbol
    {
        public SimpleTypeSymbol(string name)
        {   
            this.Name = name;
        }
        public override TypeSymbolKind TypeSymbolKind { get { return TypeSymbolKind.Simple; } }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public List<TypeSymbol> NestedTypeSymbols { get; set; }
        public CodeTypeDeclaration CreatedByTypeDeclaration { get; set; }

        public PrimitiveTypeKind PrimitiveTypeKind { get; set; }
    }
    public enum PrimitiveTypeKind
    {
        NotPrimitiveType,
        Void,
        Int32,
        Int64,
        UInt32,
        UInt64,
        Double,
        Float,
        Char,
        Bool,
        IntPtr, //native pointer
        String,
        CefString,
        //
        size_t,

    }


    class CTypeDefTypeSymbol : TypeSymbol
    {
        public CTypeDefTypeSymbol(string name, CodeTypeReference originalTypeDecl)
        {
            this.Name = name;
            this.OriginalTypeDecl = originalTypeDecl;
        }
        public string Name { get; set; }
        public CodeTypeReference OriginalTypeDecl { get; set; }
        public CodeCTypeDef CreatedTypeCTypeDef { get; set; }
        public override TypeSymbolKind TypeSymbolKind { get { return TypeSymbolKind.TypeDef; } }
        public override string ToString()
        {
            return Name;
        }
        public SimpleTypeSymbol ParentType
        {
            get;
            set;
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



    abstract class TemplateTypeSymbol : TypeSymbol
    {
        public TemplateTypeSymbol(string name)
        {
            this.Name = name;
        }
        public override TypeSymbolKind TypeSymbolKind { get { return TypeSymbolKind.Template; } }
        public string Name { get; set; }
        public abstract int ItemCount { get; }
    }

    class TemplateTypeSymbol1 : TemplateTypeSymbol
    {
        public TemplateTypeSymbol1(string name)
            : base(name)
        {
            this.Name = name;
        }
        public override int ItemCount
        {
            get { return 1; }
        }
        public TypeSymbol Item0 { get; set; }
        public override string ToString()
        {
            return Name + "<" + Item0 + ">";
        }
    }
    class TemplateTypeSymbol2 : TemplateTypeSymbol
    {
        public TemplateTypeSymbol2(string name)
            : base(name)
        {
            this.Name = name;
        }
        public override int ItemCount
        {
            get { return 2; }
        }
        public TypeSymbol Item0 { get; set; }
        public TypeSymbol Item1 { get; set; }
        public override string ToString()
        {
            return Name + "<" + Item0 + "," + Item1 + ">";
        }
    }
    class TemplateTypeSymbol3 : TemplateTypeSymbol
    {
        public TemplateTypeSymbol3(string name)
            : base(name)
        {
            this.Name = name;
        }
        public override int ItemCount
        {
            get { return 3; }
        }
        public TypeSymbol Item0 { get; set; }
        public TypeSymbol Item1 { get; set; }
        public TypeSymbol Item2 { get; set; }
        public override string ToString()
        {
            return Name + "<TODO!Imp," + Item1 + "," + Item2 + ">";
        }
    }

    class TemplateParameterTypeSymbol : TypeSymbol
    {
        CodeTemplateParameter templatePar;
        public TemplateParameterTypeSymbol(CodeTemplateParameter templatePar)
        {
            this.templatePar = templatePar;
            this.TemplateParameterName = templatePar.ParameterName;
            this.NewName = templatePar.ParameterKind;
        }
        public override TypeSymbolKind TypeSymbolKind { get { return TypeSymbolKind.TemplateParameter; } }
        public string NewName { get; set; }
        public string TemplateParameterName { get; set; }
    }
}