//2016, MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;

namespace BridgeBuilder
{
    abstract class Symbol
    {

    }

    class TypeSymbol : Symbol
    {

        public TypeSymbol(string name)
        {
            this.Name = name;
        }
        public string Name { get; set; }
        public CodeTypeDeclaration CreatedByTypeDeclaration { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }

    class ByRefTypeSymbol : TypeSymbol
    {
        public ByRefTypeSymbol(TypeSymbol elementType)
            : base(elementType.Name + "&")
        {
#if DEBUG
            if (this == elementType)
            {
                throw new Exception("cyclic-ref!");
            }
#endif
            this.ElementType = elementType;
        }
        public TypeSymbol ElementType { get; set; }
        public override string ToString()
        {
            return ElementType.ToString() + "&";
        }
    }
    class PointerTypeSymbol : TypeSymbol
    {
        public PointerTypeSymbol(TypeSymbol elementType)
            : base(elementType.Name + "*")
        {
#if DEBUG
            if (this == elementType)
            {
                throw new Exception("cyclic-ref!");
            }
#endif
            this.ElementType = elementType;
        }
        public TypeSymbol ElementType { get; set; }
        public override string ToString()
        {
            return ElementType.ToString() + "*";
        }
    }

}