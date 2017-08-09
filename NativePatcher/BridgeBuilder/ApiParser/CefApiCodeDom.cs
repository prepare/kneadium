//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgeBuilder
{

    //this version is designed for cef3 only

    class CodeCTypeDef : CodeMemberDeclaration
    {
        public CodeCTypeDef(CodeTypeReference from, string name)
        {
            this.From = from;
            this.Name = name;
        }
        public CodeTypeReference From { get; set; }
        public override CodeMemberKind MemberKind { get { return CodeMemberKind.TypeDef; } }
        public override string ToString()
        {
            return "typedef " + From + " " + this.Name + ";";
        }

    }
    enum TypeKind
    {
        Class,
        Struct,
        Enum
    }

    class CodeTypeTemplateNotation
    {
        //this version support 1 parameter         
        public List<CodeTemplateParameter> templatePars = new List<CodeTemplateParameter>();
        public void AddTemplateParameter(CodeTemplateParameter par)
        {
            templatePars.Add(par);
        }
        public override string ToString()
        {
            int j = templatePars.Count;

            StringBuilder stbuilder = new StringBuilder();
            stbuilder.Append("template<");
            for (int i = 0; i < j; ++i)
            {
                if (i > 0)
                {
                    stbuilder.Append(',');
                }
                stbuilder.Append(templatePars[i].ToString());
            }
            stbuilder.Append(">");
            return stbuilder.ToString();
        }
        public bool TryGetTemplateParByParameterName(string searchName, out CodeTemplateParameter found)
        {
            return (found = GetTemplateParByParameterName(searchName)) != null;
        }
        public CodeTemplateParameter GetTemplateParByParameterName(string searchName)
        {
            int j = templatePars.Count;
            for (int i = 0; i < j; ++i)
            {
                CodeTemplateParameter tp = templatePars[i];
                if (tp.ParameterName == searchName)
                {
                    return tp; //found
                }
            }
            //not found
            return null;
        }
        public bool TryGetTemplateParByReAssignToName(string searchName, out CodeTemplateParameter found)
        {
            return (found = GetTemplateParByReAssignToName(searchName)) != null;
        }
        public CodeTemplateParameter GetTemplateParByReAssignToName(string searchName)
        {
            int j = templatePars.Count;
            for (int i = 0; i < j; ++i)
            {
                CodeTemplateParameter tp = templatePars[i];
                if (tp.ReAssignToTypeName == searchName)
                {
                    return tp; //found
                }
            }
            //not found
            return null;
        }
    }
    class CodeTemplateParameter
    {
        public string ParameterName { get; set; }
        public string ParameterKind { get; set; }

        public override string ToString()
        {
            return ParameterKind + " " + ParameterName;
        }

        public CodeTypeReference TemplateDetailFrom { get; set; }
        public string ReAssignToTypeName { get; set; }
    }

    enum CodeExpressionKind
    {
        //boolean literal
        StringLiteral,
        NumberLiteral,
        BinaryOpExpression
    }

    abstract class CodeExpression
    {
#if DEBUG
        public readonly int dbugId = dbugTotal++;
        static int dbugTotal;
#endif
        public abstract CodeExpressionKind Kind { get; }
    }

    class CodeStringLiteralExpression : CodeExpression
    {
        public string Content { get; set; }
        public override CodeExpressionKind Kind
        {
            get { return CodeExpressionKind.StringLiteral; }
        }
        public override string ToString()
        {
            return Content;
        }
    }
    class CodeNumberLiteralExpression : CodeExpression
    {
        public string Content { get; set; }
        public override CodeExpressionKind Kind
        {
            get { return CodeExpressionKind.NumberLiteral; }
        }
        public override string ToString()
        {
            return Content;
        }
    }
    class CodeBinaryOperatorExpression : CodeExpression
    {
        public CodeExpression LeftExpression { get; set; }
        public CodeExpression RightExpression { get; set; }
        public string Operator { get; set; }
        public override CodeExpressionKind Kind
        {
            get { return CodeExpressionKind.BinaryOpExpression; }
        }
        public override string ToString()
        {
            return LeftExpression + " " + Operator + " " + RightExpression;
        }
    }

    class CodeTemplateTypeParameter
    {
        public CodeTemplateTypeParameter(string name) { Name = name; }
        public string Name { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    class CodeTypeDeclaration : CodeMemberDeclaration
    {
        List<CodeMemberDeclaration> _specialImplMacroMembers;
        List<CodeMemberDeclaration> _members;

        List<CodeMemberDeclaration> _subTypeDecls;
        List<CodeTemplateTypeParameter> _typeParameters;
        public CodeTypeDeclaration()
        {
            this.BaseTypes = new List<CodeTypeReference>();
            _members = new List<CodeMemberDeclaration>();
        }
        public TypeKind Kind { get; set; }

        public bool BaseIsPublic { get; set; }
        /// <summary>
        /// cpp 
        /// </summary>
        public bool BaseIsVirtual { get; set; }
        public bool IsGlobalCompilationUnitType { get; set; }
        public CodeTypeTemplateNotation TemplateNotation { get; set; }
        public List<CodeTypeReference> BaseTypes { get; set; }
        public List<CodeTemplateTypeParameter> TypeParameters
        {
            get { return _typeParameters; }
        }
        public void AddTypeParameter(CodeTemplateTypeParameter tpar)
        {
            if (_typeParameters == null)
            {
                _typeParameters = new List<CodeTemplateTypeParameter>();
            }
            _typeParameters.Add(tpar);
        }
        public void AddMember(CodeMemberDeclaration mb)
        {

            _members.Add(mb);
            mb.OwnerTypeDecl = new CodeSimpleTypeReference(this.Name);
            //
            mb.OriginalCompilationUnit = this.OriginalCompilationUnit;
            //
            switch (mb.MemberKind)
            {
                case CodeMemberKind.Type:
                case CodeMemberKind.TypeDef:
                    {
                        if (_subTypeDecls == null)
                        {
                            _subTypeDecls = new List<CodeMemberDeclaration>();
                        }
                        _subTypeDecls.Add(mb);
                    }
                    break;
            }
        }
        public int MemberCount
        {
            get
            {
                return _members.Count;
            }
        }


        public IEnumerable<CodeMemberDeclaration> GetSubTypeIter()
        {
            int j = _members.Count;
            for (int i = 0; i < j; ++i)
            {
                CodeMemberDeclaration mb = _members[i];
                switch (mb.MemberKind)
                {
                    case CodeMemberKind.Type:
                    case CodeMemberKind.TypeDef:
                        yield return mb;
                        break;
                }
            }
        }
        public IEnumerable<CodeMemberDeclaration> GetMemberIter()
        {
            int j = _members.Count;
            for (int i = 0; i < j; ++i)
            {
                yield return _members[i];
            }
        }
        public IEnumerable<CodeMethodDeclaration> GetMethodIter()
        {
            int j = _members.Count;
            for (int i = 0; i < j; ++i)
            {
                CodeMemberDeclaration mb = _members[i];
                switch (mb.MemberKind)
                {
                    case CodeMemberKind.Method:
                        yield return (CodeMethodDeclaration)mb;
                        break;
                }
            }
        }
        public IEnumerable<CodeFieldDeclaration> GetFieldIter()
        {
            int j = _members.Count;
            for (int i = 0; i < j; ++i)
            {
                CodeMemberDeclaration mb = _members[i];
                switch (mb.MemberKind)
                {
                    case CodeMemberKind.Field:
                        yield return (CodeFieldDeclaration)mb;
                        break;
                }
            }
        }

        public override CodeMemberKind MemberKind { get { return CodeMemberKind.Type; } }
        public bool IsForwardDecl { get; set; }
        public override string ToString()
        {
            if (IsGlobalCompilationUnitType)
            {
                return "!global";
            }

            StringBuilder stbuilder = new StringBuilder();

            if (TemplateNotation != null)
            {
                //template class
                stbuilder.Append(TemplateNotation.ToString());
            }

            if (BaseIsVirtual)
            {
                stbuilder.Append("[virtual] ");
            }
            switch (this.Kind)
            {
                case TypeKind.Class:
                    stbuilder.Append("class ");
                    break;
                case TypeKind.Struct:
                    stbuilder.Append("struct ");
                    break;
                case TypeKind.Enum:
                    stbuilder.Append("enum ");
                    break;
                default:
                    throw new NotSupportedException();
            }
            stbuilder.Append(Name);

            if (_typeParameters != null)
            {
                int j = _typeParameters.Count;
                stbuilder.Append("<");
                for (int i = 0; i < j; ++i)
                {

                    if (i > 0)
                    {
                        stbuilder.Append(',');
                    }
                    stbuilder.Append(_typeParameters[i].ToString());
                }
                stbuilder.Append(">");
            }

            if (this.IsForwardDecl)
            {
                stbuilder.Append(';');
            }
            return stbuilder.ToString();
        }
        public void AddMacro(CodeMemberDeclaration macroDecl)
        {
            if (_specialImplMacroMembers == null)
            {
                _specialImplMacroMembers = new List<CodeMemberDeclaration>();
            }
            _specialImplMacroMembers.Add(macroDecl);
        }

        public bool HasSubType
        {
            get { return _subTypeDecls != null; }
        }

        public string FullName
        {
            get
            {
                if (OwnerTypeDecl != null && !OwnerTypeDecl.Name.StartsWith("global!"))
                {
                    return OwnerTypeDecl.ToString() + "::" + this.Name;
                }
                else
                {
                    return this.Name;
                }
            }

        }
        //-------------
        //semantic 
        public TypeSymbol ResolvedType { get; set; }
        public bool IsTemplateTypeDefinition
        {
            get
            {
                return TemplateNotation != null;
            }
        }
        public int FindSubType(string name, List<CodeMemberDeclaration> results)
        {
            int foundCount = 0;
            if (_subTypeDecls == null) return 0;
            //
            int j = _subTypeDecls.Count;
            for (int i = 0; i < j; ++i)
            {
                CodeMemberDeclaration mb = _subTypeDecls[i];
                if (mb.Name == name)
                {
                    foundCount++;
                    results.Add(mb);
                }
            }
            return foundCount;
        }

        //
        //transformation 
        internal TypeTxInfo TypeTxInfo { get; set; }

    }

    class IncludeFileDirective
    {
        public IncludeFileDirective(string includeFile)
        {
            IncludeFile = includeFile;
            //check first char of include file
            // #include "filename" or
            // #include <filename>

            char firstChar = includeFile[0];
            if (firstChar == '<')
            {
                SystemFolder = true;
            }
            else if (firstChar == '"')
            {
                SystemFolder = false;
            }
            else
            {
                throw new NotSupportedException();
            }
        }
        public bool SystemFolder { get; set; }
        public string IncludeFile { get; private set; }
        public string ResolvedAbsoluteFilePath { get; set; }
        public override string ToString()
        {
            return "#include " + IncludeFile;
        }
    }
    class CodeCompilationUnit
    {
        List<CodeTypeDeclaration> _members;
        CodeTypeDeclaration _globalTypeDecl;
        internal List<IncludeFileDirective> _includeFiles = new List<IncludeFileDirective>();

        public CodeCompilationUnit(string cuName)
        {
            _members = new List<CodeTypeDeclaration>();
            _globalTypeDecl = new CodeTypeDeclaration() { IsGlobalCompilationUnitType = true };
            _globalTypeDecl.OriginalCompilationUnit = this;
            _globalTypeDecl.Name = "global!" + cuName;
            this.CuName = cuName;
        }

        public string Filename { get; set; }
        public string CuName { get; set; }
        public void AddTypeDeclaration(CodeTypeDeclaration typedecl)
        {
            typedecl.OriginalCompilationUnit = this;
            _members.Add(typedecl);

        }
        public CodeTypeDeclaration GlobalTypeDecl
        {
            get { return _globalTypeDecl; }
        }
        public int TypeCount
        {
            get { return _members.Count; }
        }
        public CodeTypeDeclaration GetTypeDeclaration(int index)
        {
            return _members[index];
        }
        public void AddIncludeFile(string includeFile)
        {
            _includeFiles.Add(new IncludeFileDirective(includeFile));
        }
        public override string ToString()
        {
            return this.CuName;
        }

    }

    enum CodeTypeReferenceKind
    {
        Simple,
        FuncPointer,
        QualifiedName,
        TypeTemplate,
        Pointer,
        ByRef,

    }
    abstract class CodeTypeReference
    {
#if DEBUG
        public readonly int dbugId = dbugTotalId++;
        static int dbugTotalId;
#endif
        TypeSymbol resolvedType;
        public CodeTypeReference()
        {
#if DEBUG
            dbugCheckId();
#endif
        }
        public CodeTypeReference(string typename)
        {
#if DEBUG
            dbugCheckId();
#endif
            this.Name = typename;
        }
#if DEBUG
        void dbugCheckId()
        {

        }
#endif
        public string Name
        {
            get;
            set;
        }
        public override string ToString()
        {
            return this.Name;
        }
        public abstract CodeTypeReferenceKind Kind { get; }
        //-------------
        //semantic 
        public TypeSymbol ResolvedType
        {
            get
            {
                return resolvedType;
            }
            set
            {
                resolvedType = value;
            }
        }
    }
    class CodeSimpleTypeReference : CodeTypeReference
    {
        public CodeSimpleTypeReference(string typename)
            : base(typename)
        {
        }
        public override CodeTypeReferenceKind Kind { get { return CodeTypeReferenceKind.Simple; } }
    }

    class CodeFunctionPointerTypeRefernce : CodeTypeReference
    {
        public CodeFunctionPointerTypeRefernce()
        {
            this.Parameters = new List<CodeMethodParameter>();
        }
        public CodeTypeReference ReturnType { get; set; }
        public List<CodeMethodParameter> Parameters { get; set; }
        public override CodeTypeReferenceKind Kind { get { return CodeTypeReferenceKind.FuncPointer; } }
        public override string ToString()
        {

            var stbuilder = new StringBuilder();
            stbuilder.Append(ReturnType.ToString());
            int j = Parameters.Count;
            stbuilder.Append('(');
            for (int i = 0; i < j; ++i)
            {
                if (i > 0)
                {
                    stbuilder.Append(',');
                }
                stbuilder.Append(Parameters[i]);
            }
            stbuilder.Append(')');

            return stbuilder.ToString();
        }
    }
    class CodeQualifiedNameType : CodeTypeReference
    {

        public CodeQualifiedNameType(CodeTypeReference leftPartName, CodeTypeReference rightPart)
            : base(rightPart.ToString())
        {
            this.LeftPart = leftPartName;
            this.RightPart = rightPart;
        }
        public CodeTypeReference LeftPart { get; set; }
        public CodeTypeReference RightPart { get; set; }
        public override CodeTypeReferenceKind Kind { get { return CodeTypeReferenceKind.QualifiedName; } }
        public override string ToString()
        {
            return LeftPart + "::" + RightPart.ToString();
        }
    }
    class CodeTypeTemplateTypeReference : CodeTypeReference
    {
        //similar to C# generic
        List<CodeTypeReference> templateItems = new List<CodeTypeReference>();
        public CodeTypeTemplateTypeReference(string typename)
            : base(typename)
        {

        }
        public List<CodeTypeReference> Items { get { return templateItems; } }
        public void AddTemplateItem(CodeTypeReference item)
        {
            templateItems.Add(item);
        }
        public override CodeTypeReferenceKind Kind { get { return CodeTypeReferenceKind.TypeTemplate; } }
        public override string ToString()
        {
            StringBuilder stbuilder = new StringBuilder();
            stbuilder.Append(base.Name);
            stbuilder.Append('<');
            int j = templateItems.Count;
            for (int i = 0; i < j; ++i)
            {
                if (i > 0)
                {
                    stbuilder.Append(',');
                }
                stbuilder.Append(templateItems[i].ToString());
            }
            stbuilder.Append('>');
            return stbuilder.ToString();
        }

    }
    class CodePointerTypeReference : CodeTypeReference
    {
        CodeTypeReference elementType;
        public CodePointerTypeReference(CodeTypeReference elementType)
        {
            this.elementType = elementType;
        }
        public CodeTypeReference ElementType { get { return this.elementType; } }
        public override CodeTypeReferenceKind Kind { get { return CodeTypeReferenceKind.Pointer; } }
        public override string ToString()
        {
            return elementType.ToString() + "*";
        }
    }
    class CodeByRefTypeReference : CodeTypeReference
    {
        CodeTypeReference elementType;
        public CodeByRefTypeReference(CodeTypeReference elementType)
        {
            this.elementType = elementType;
        }
        public CodeTypeReference ElementType { get { return this.elementType; } }
        public override CodeTypeReferenceKind Kind { get { return CodeTypeReferenceKind.ByRef; } }
        public override string ToString()
        {
            return elementType.ToString() + "&";
        }
    }

    enum MemberAccessibility
    {
        Public,
        Protected,
        Private
    }

    abstract class CodeMemberDeclaration
    {
        Token[] _lineComments;
#if DEBUG
        static int dbugTotalId;
        public readonly int dbugId = dbugTotalId++;
        public CodeMemberDeclaration()
        {

        }
#endif
        public string Name { get; set; }
        public abstract CodeMemberKind MemberKind { get; }
        public MemberAccessibility MemberAccessibility { get; set; }
        public CodeCompilationUnit OriginalCompilationUnit { get; set; }
        public Token[] LineComments
        {
            get { return _lineComments; }
            set
            {
                //if (this.Name == "CefBrowser")
                //{

                //}
                //if (_lineComments != null)
                //{

                //}

                _lineComments = value;
            }
        }
        public CodeTypeReference OwnerTypeDecl { get; set; }

    }

    enum CodeMemberKind
    {
        Unknown,
        Type,
        TypeDef,
        Field,
        Method
    }
    enum MethodKind
    {
        Normal,
        Ctor,
        Dtor
    }
    class CodeFieldDeclaration : CodeMemberDeclaration
    {
        public CodeFieldDeclaration()
        {
        }

        public bool IsStatic { get; set; }
        public bool IsConst { get; set; }
        public override CodeMemberKind MemberKind { get { return CodeMemberKind.Field; } }
        public CodeTypeReference FieldType { get; set; }
        public override string ToString()
        {
            if (FieldType == null)
            {
                //enum field ?
                if (InitExpression != null)
                {
                    return Name + "=" + InitExpression;
                }
                else
                {
                    return Name;
                }

            }
            else
            {
                if (InitExpression != null)
                {
                    return FieldType.ToString() + " " + Name + "=" + InitExpression;
                }
                else
                {
                    return FieldType.ToString() + " " + Name;
                }
            }

        }
        public CodeExpression InitExpression { get; set; }
    }


    class CodeCtorInitilizer
    {
        public List<CodeCtorInitField> initFields = new List<CodeCtorInitField>();
    }

    class CodeCtorInitField
    {
        public string FieldName;
        public CodeExpression InitValue;
    }


    class CodeMethodDeclaration : CodeMemberDeclaration
    {
        public CodeMethodDeclaration()
        {
            this.Parameters = new List<CodeMethodParameter>();
        }

        public List<CodeMethodParameter> Parameters { get; set; }
        public CodeTypeReference ReturnType { get; set; }
        public bool IsOverrided { get; set; }
        public bool IsVirtual { get; set; }
        public bool IsStatic { get; set; }
        public bool IsConst { get; set; }
        public bool IsAbstract { get; set; }
        public MethodKind MethodKind { get; set; }
        public override CodeMemberKind MemberKind { get { return CodeMemberKind.Method; } }

        //
        public CodeCtorInitilizer CtorInit { get; set; }
        public bool IsOperatorMethod { get; set; }
        public bool IsInline { get; set; }

        //
        public override string ToString()
        {
            StringBuilder stbuilder = new StringBuilder();

            if (CppExplicitOwnerType != null)
            {
                stbuilder.Append(CppExplicitOwnerType.ToString() + "::");
            }

            switch (MethodKind)
            {
                case BridgeBuilder.MethodKind.Ctor:
                    //do nothing
                    break;
                case BridgeBuilder.MethodKind.Dtor:
                    stbuilder.Append('~');
                    break;
                default:
                    stbuilder.Append(ReturnType.ToString());
                    stbuilder.Append(' ');
                    break;
            }

            stbuilder.Append(Name);
            stbuilder.Append('(');

            int parCount = Parameters.Count;
            for (int i = 0; i < parCount; ++i)
            {
                if (i > 0)
                {
                    stbuilder.Append(',');
                }
                stbuilder.Append(Parameters[i].ToString());
            }

            stbuilder.Append(')');
            return stbuilder.ToString();
        }

        ////
        //public CodeCtorInitilizer CtorInit { get; set; }
        //public bool IsOperatorMethod { get; set; }
        //public bool IsInline { get; set; }

        //transformation 

        internal MethodTxInfo methodTxInfo { get; set; }


        public CodeTypeReference CppExplicitOwnerType
        {
            get;
            set;
        }
    }

    class CodeMethodParameter
    {
        public string ParameterName
        {
            get;
            set;
        }
        public CodeTypeReference ParameterType
        {
            get;
            set;
        }
        /// <summary>
        /// const modifier
        /// </summary>
        public bool IsConstPar
        {
            get;
            set;
        }
        public bool IsConstParName
        {
            get;
            set;
        }
        public bool IsConstPointerParName
        {
            get;
            set;
        }
        public override string ToString()
        {
            StringBuilder stbuild = new StringBuilder();
            if (IsConstPar)
            {
                stbuild.Append("const ");
            }
            stbuild.Append(this.ParameterType.ToString());
            if (this.IsConstParName)
            {
                stbuild.Append(" const");
                if (IsConstPointerParName)
                {
                    stbuild.Append("*");
                }
            }
            if (ParameterName != null)
            {
                stbuild.Append(" ");
                stbuild.Append(this.ParameterName);
            }
            return stbuild.ToString();
        }

        //transformation phase
        internal MethodParameterTxInfo ParameterTxInfo { get; set; }
    }

}