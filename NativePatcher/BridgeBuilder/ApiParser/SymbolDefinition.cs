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
        Pointer,
        ByRef,

        /// <summary>
        /// Cpp scoped_ptr
        /// </summary>
        scoped_ptr,

        /// <summary>
        /// CEF 'smart pointer'
        /// </summary>
        CefRefPtr, //
        CefRawPtr,

    }
    abstract class TypeSymbol : Symbol
    {
#if DEBUG
        public readonly int dbugId = dbugTotalId++;
        static int dbugTotalId;
        public TypeSymbol()
        {

        }
#endif
        public abstract string FullName { get; }
        public abstract TypeSymbolKind TypeSymbolKind { get; }
        public TypeBridgeInfo BridgeInfo { get; set; }
    }

    class SimpleTypeSymbol : TypeSymbol
    {
        CodeTypeDeclaration _codeTypeDecl;
        public SimpleTypeSymbol(string name)
        {
            this.Name = name;
        }
        public SimpleTypeSymbol(CodeTypeDeclaration codeTypeDecl)
        {
            this._codeTypeDecl = codeTypeDecl;
            this.Name = codeTypeDecl.FullName;
        }
        public bool IsEnum
        {
            get
            {
                if (_codeTypeDecl != null)
                {
                    return _codeTypeDecl.Kind == TypeKind.Enum;
                }
                return false;
            }
        }
        public override TypeSymbolKind TypeSymbolKind { get { return TypeSymbolKind.Simple; } }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
        public List<TypeSymbol> NestedTypeSymbols { get; set; }
        public CodeTypeDeclaration CreatedByTypeDeclaration
        {
            get
            {
                return _codeTypeDecl;
            }
        }

        public PrimitiveTypeKind PrimitiveTypeKind { get; set; }
        public TypeSymbol BaseType { get; set; }
        internal bool IsGlobalCompilationUnitTypeDefinition
        {
            get
            {
                if (CreatedByTypeDeclaration != null)
                {
                    return CreatedByTypeDeclaration.IsGlobalCompilationUnitType;
                }
                return false;
            }
        }
        //
        public override string FullName
        {
            get
            {
                if (_codeTypeDecl != null)
                {
                    return _codeTypeDecl.FullName;
                }
                else
                {
                    return this.Name;
                }
            }
        }

        internal CefTypeTxPlan CefTxPlan { get; set; }
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
        NaitveInt,
        String,
        CefString,
        //
        size_t,

    }


    class CTypeDefTypeSymbol : TypeSymbol
    {
        TypeSymbol _referToTypeSymbol;
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
        public TypeSymbol ReferToTypeSymbol
        {
            get { return _referToTypeSymbol; }
            set
            {
                if (value == null)
                {

                }
                _referToTypeSymbol = value;
            }
        }
        public override string FullName
        {
            get
            {
                return this.Name;
            }
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
            return "std::vector<" + ElementType + ">";
        }
        public override string FullName
        {
            get
            {
                return "std::vector<" + ElementType.FullName + ">";
            }
               
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
                case ContainerTypeKind.Pointer: return ElementType.ToString() + "*";
                case ContainerTypeKind.ByRef: return ElementType.ToString() + "&";
                case ContainerTypeKind.scoped_ptr: return "scoped_ptr<" + ElementType.ToString() + ">";
                case ContainerTypeKind.CefRefPtr: return "CefRefPtr<" + ElementType.ToString() + ">";
                case ContainerTypeKind.CefRawPtr: return "CefRawPtr<" + ElementType.ToString() + ">";
                default:
                    throw new NotSupportedException();
            }
        }

        public override string FullName
        {
            get
            {
                switch (Kind)
                {
                    default:
                        throw new NotSupportedException();
                    case ContainerTypeKind.ByRef:
                        return this.ElementType.FullName + "&";
                    case ContainerTypeKind.CefRawPtr:
                        return "CefRawPtr<" + this.ElementType.FullName + ">";
                    case ContainerTypeKind.CefRefPtr:
                        return "CefRefPtr<" + this.ElementType.FullName + ">";
                    case ContainerTypeKind.Pointer:
                        return this.ElementType.FullName + "*";

                }
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
        public override string FullName
        {
            get { return this.ToString(); }
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
        public override string FullName
        {
            get { return this.ToString(); }
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
        public override string FullName
        {
            get { return this.ToString(); }
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

        public override string FullName
        {
            get { return templatePar.ParameterName; }
        }
    }
}