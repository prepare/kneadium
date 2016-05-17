//2016, MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;
namespace BridgeBuilder
{
    //still very dirty parser!
    //this version is designed for cef3 only

    class CodeTypeDeclaration
    {
        public CodeTypeDeclaration()
        {
            this.BaseTypes = new List<CodeTypeReference>();
            this.Members = new List<CodeMemberDeclaration>();
        }
        public string Name { get; set; }
        public string BaseModifer { get; set; }
        public List<CodeTypeReference> BaseTypes { get; set; }
        public List<CodeMemberDeclaration> Members { get; set; }

        public override string ToString()
        {
            return this.Name;
        }
    }
    class CodeCompilationUnit
    {
        public CodeCompilationUnit()
        {
            this.Members = new List<CodeTypeDeclaration>();
        }
        public string Filename { get; set; }
        public List<CodeTypeDeclaration> Members { get; set; }
    }
    class CodeTypeReference
    {
        public CodeTypeReference(string typename)
        {
            this.Name = typename;
        }
        protected CodeTypeReference()
        {
        }
        public string Name
        {
            get;
            set;
        }
        public override string ToString()
        {
            return this.Name;
        }
    }
    class CodeQualifiedType : CodeTypeReference
    {

        public CodeQualifiedType(string leftPartName, CodeTypeReference rightPart)
            : base(leftPartName)
        {
            this.RightPart = rightPart;
        }
        public CodeTypeReference RightPart { get; set; }
        public override string ToString()
        {
            return base.Name + "::" + RightPart.ToString();
        }
    }
    class CodeTypeTemplateType : CodeTypeReference
    {
        //similar to C# generic
        List<CodeTypeReference> templateItems = new List<CodeTypeReference>();
        public CodeTypeTemplateType(string typename)
            : base(typename)
        {

        }
        public void AddTemplateItem(CodeTypeReference item)
        {
            templateItems.Add(item);
        }
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
        public override string ToString()
        {
            return elementType.ToString() + "&";
        }
    }
    abstract class CodeMemberDeclaration
    {

    }



    class CodeMethodDeclaration : CodeMemberDeclaration
    {

#if DEBUG
        static int dbugTotalId;
        public readonly int dbugId = dbugTotalId++;
#endif
        public CodeMethodDeclaration()
        {
#if DEBUG

#endif
            this.Parameters = new List<CodeMethodParameter>();
        }
        public string Name { get; set; }
        public List<CodeMethodParameter> Parameters { get; set; }
        public CodeTypeReference ReturnType { get; set; }
        public bool IsOverrided { get; set; }
        public bool IsVirtual { get; set; }
        public override string ToString()
        {
            StringBuilder stbuilder = new StringBuilder();
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
        public bool IsConstParType
        {
            get;
            set;
        }
        public bool IsConstParVariable
        {
            get;
            set;
        }
        public bool IsConstParPointer
        {
            get;
            set;
        }
        public override string ToString()
        {
            StringBuilder stbuild = new StringBuilder();
            if (IsConstParType)
            {
                stbuild.Append("const ");
            }
            stbuild.Append(this.ParameterType.ToString());
            if (this.IsConstParVariable)
            {
                stbuild.Append(" const");
                if (IsConstParPointer)
                {
                    stbuild.Append("*");
                }
            }
            stbuild.Append(" ");
            stbuild.Append(this.ParameterName);
            return stbuild.ToString();

        }
    }

}