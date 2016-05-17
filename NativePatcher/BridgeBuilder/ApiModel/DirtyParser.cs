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


    enum TokenKind : byte
    {
        Id,
        Operator,
        Punc,
        Keyword,
        Comment,
        LineComment,
        Whitespace,
        PreprocessingDirective,
        NewLine
    }
    enum TokenKeyWord : byte
    {

    }
    class LineLexer
    {
        public List<Token> tklist = new List<Token>();
        public void Lex(string line)
        {
            tklist.Clear();
            char[] charBuffer = line.ToCharArray();
            int j = charBuffer.Length;
            int state = 0;
            for (int i = 0; i < j; ++i)
            {
                char c = charBuffer[i];
                switch (state)
                {
                    case 0:
                        {
                            if (char.IsLetter(c) || c == '_')
                            {
                                LexIden(charBuffer, j, ref i);
                            }
                            else if (char.IsNumber(c))
                            {
                            }
                            else if (char.IsWhiteSpace(c))
                            {
                                //whitespace
                                //skip
                            }
                            else
                            {
                                //one or multiple 
                                LexPunc(charBuffer, j, ref i);
                            }
                        } break;
                }
            }
        }
        void LexPunc(char[] charBuffer, int charCount, ref int currentIndex)
        {

            StringBuilder stbuilder = new StringBuilder();
            char c = charBuffer[currentIndex];
            switch (c)
            {
                case ':':
                    // :, ::
                    if (currentIndex + 1 < charCount)
                    {
                        //read next
                        char c1 = charBuffer[currentIndex + 1];
                        if (c1 == ':') // ::
                        {
                            currentIndex += 1;
                            tklist.Add(
                                new Token() { Content = (c.ToString() + c1.ToString()), TokenKind = TokenKind.Punc });
                        }
                        else
                        {
                            //just single token
                            tklist.Add(
                               new Token() { Content = c.ToString(), TokenKind = TokenKind.Punc });
                        }
                    }
                    else
                    {
                        //just single token
                        tklist.Add(
                              new Token() { Content = c.ToString(), TokenKind = TokenKind.Punc });
                    }
                    break;
                case '+':  //++, += 
                case '-':
                    {
                        if (currentIndex + 1 < charCount)
                        {
                            //read next
                            char c1 = charBuffer[currentIndex + 1];
                            if (c1 == '=' || //+=, -=
                                (c == '+' && c1 == '+') || //++
                                (c == '-' && c1 == '-')) //--
                            {
                                currentIndex += 1;
                                tklist.Add(
                                    new Token() { Content = (c.ToString() + c1.ToString()), TokenKind = TokenKind.Punc });
                            }
                            else
                            {
                                //just single token
                                tklist.Add(
                                   new Token() { Content = c.ToString(), TokenKind = TokenKind.Punc });
                            }
                        }
                        else
                        {
                            //just single token
                            tklist.Add(
                                  new Token() { Content = c.ToString(), TokenKind = TokenKind.Punc });
                        }
                    } break;
                case '=':// ==,  
                case '!'://!=  
                case '%':
                case '^':
                case '~':
                    if (currentIndex + 1 < charCount)
                    {
                        //read next
                        char c1 = charBuffer[currentIndex + 1];
                        if (c1 == '=')
                        {
                            currentIndex += 1;
                            tklist.Add(
                                new Token() { Content = (c.ToString() + c1.ToString()), TokenKind = TokenKind.Punc });
                        }
                        else
                        {
                            //just single token
                            tklist.Add(
                               new Token() { Content = c.ToString(), TokenKind = TokenKind.Punc });
                        }
                    }
                    else
                    {
                        //just single token
                        tklist.Add(
                              new Token() { Content = c.ToString(), TokenKind = TokenKind.Punc });
                    }
                    break;
                case '*':
                    {


                        //may be *=, */
                        if (currentIndex + 1 < charCount)
                        {
                            //read next
                            char c1 = charBuffer[currentIndex + 1];
                            switch (c1)
                            {
                                case '=':
                                    tklist.Add(
                                        new Token() { Content = (c.ToString() + c1.ToString()), TokenKind = TokenKind.Punc });
                                    currentIndex += 1;
                                    break;
                                case '/':
                                    //line comment
                                    tklist.Add(
                                         new Token() { Content = (c.ToString() + c1.ToString()), TokenKind = TokenKind.Comment });
                                    currentIndex += 1;
                                    break;
                                default:
                                    tklist.Add(new Token() { Content = c.ToString(), TokenKind = TokenKind.Punc });
                                    break;
                            }
                        }
                        else
                        {
                            //just single token
                            tklist.Add(
                                  new Token() { Content = c.ToString(), TokenKind = TokenKind.Punc });
                        }



                    } break;
                case '/':

                    //may be /=, // , /*
                    if (currentIndex + 1 < charCount)
                    {
                        //read next
                        char c1 = charBuffer[currentIndex + 1];
                        switch (c1)
                        {
                            case '=':
                                tklist.Add(
                                    new Token() { Content = (c.ToString() + c1.ToString()), TokenKind = TokenKind.Punc });
                                currentIndex += 1;
                                break;
                            case '*':
                                // /*
                                tklist.Add(
                                    new Token() { Content = (c.ToString() + c1.ToString()), TokenKind = TokenKind.Comment });
                                currentIndex += 1;
                                break;
                            case '/':
                                //line comment
                                tklist.Add(
                                    new Token() { Content = new string(charBuffer, currentIndex, charCount - currentIndex), TokenKind = TokenKind.LineComment });
                                currentIndex = charCount; //comsume to end of file
                                break;
                            default:
                                tklist.Add(new Token() { Content = c.ToString(), TokenKind = TokenKind.Punc });
                                break;
                        }
                    }
                    else
                    {
                        //just single token
                        tklist.Add(
                              new Token() { Content = c.ToString(), TokenKind = TokenKind.Punc });
                    }

                    break;
                default:
                    //single token
                    tklist.Add(
                              new Token() { Content = c.ToString(), TokenKind = TokenKind.Punc });
                    break;
            }

        }
        void LexIden(char[] charBuffer, int charCount, ref int currentIndex)
        {
            //lex iden
            StringBuilder stbuilder = new StringBuilder();
            char c = charBuffer[currentIndex];
            stbuilder.Append(c);
            //read next char
            for (int i = currentIndex + 1; i < charCount; ++i)
            {
                c = charBuffer[i];
                if (char.IsLetter(c) || c == '_' || char.IsNumber(c))
                {
                    stbuilder.Append(c);
                    currentIndex = i;
                }
                else
                {
                    //stop
                    //here
                    break;
                }
            }

            if (stbuilder.Length > 0)
            {
                tklist.Add(new Token() { Content = stbuilder.ToString(), TokenKind = TokenKind.Id });
            }
        }

    }
    class Token
    {
        public string Content;
        public TokenKind TokenKind;
        public override string ToString()
        {
            return Content;
        }
    }

    class HeaderFileParser
    {
        List<string> allLines = new List<string>();
        List<Token> tokenList = new List<Token>();
        int lineNo = -1;
        int currentTokenIndex;
        List<CodeTypeDeclaration> typeList;
        CodeCompilationUnit cu = new CodeCompilationUnit();
        public HeaderFileParser()
        {
            typeList = cu.Members;

        }
        public CodeCompilationUnit Result
        {
            get { return this.cu; }
        }
        public void Parse(string filename)
        {
            cu.Filename = filename;
            using (FileStream fs = new FileStream(filename, FileMode.Open))
            using (StreamReader r = new StreamReader(fs))
            {
                string line = r.ReadLine();
                while (line != null)
                {
                    allLines.Add(line);
                    line = r.ReadLine();
                }
            }
            //------------
            //start parse line by line
            //------------
            ParseFileContent();
        }

        void ParseFileContent()
        {
            LineLexer lineLexer = new LineLexer();
            tokenList.Clear();
            //lex
            int lim = allLines.Count - 1;
            lineNo = 0;
            while (lineNo < lim)
            {
                string line = allLines[lineNo];
                line = line.TrimStart();
                if (line.Length > 0)
                {

                    if (line.StartsWith("//"))
                    {
                        //comment
                        tokenList.Add(new Token() { Content = line, TokenKind = TokenKind.LineComment });
                    }
                    else if (line.StartsWith("#"))
                    {
                        tokenList.Add(new Token() { Content = line, TokenKind = TokenKind.PreprocessingDirective });
                    }
                    else
                    {
                        //lex the content of this line
                        lineLexer.Lex(line);
                        //parse content of this line 
                        tokenList.AddRange(lineLexer.tklist);
                    }
                }


                lineNo++;
            }
            //-------------------------------------------------------
            int tkcount = tokenList.Count;

            //-------------------------------------------------------

            for (currentTokenIndex = 0; currentTokenIndex < tkcount; ++currentTokenIndex)
            {
                Token tk = tokenList[currentTokenIndex];
                switch (tk.TokenKind)
                {
                    case TokenKind.LineComment:
                    case TokenKind.Whitespace:
                    case TokenKind.PreprocessingDirective://this version we just skip preprocessing directive                        
                        continue;
                }
                switch (tk.TokenKind)
                {
                    case TokenKind.Id:
                        {
                            //may be keyword or iden
                            switch (tk.Content)
                            {
                                case "class":
                                    {
                                        //parse class
                                        CodeTypeDeclaration typeDecl = ParseClassDeclaration();
                                        if (typeDecl != null)
                                        {
                                            typeList.Add(typeDecl);
                                        }
                                        else
                                        {
                                            throw new NotSupportedException();
                                        }
                                    } break;
                                default:
                                    {
                                        throw new NotSupportedException();
                                    } break;
                            }

                        } break;
                    case TokenKind.LineComment:
                        {
                        } break;
                    default:
                        {

                        } break;
                }
                break;
            }
            //-------------------------------------------------------
        }
        string ExpectId()
        {
            //read next and 
            int i = currentTokenIndex + 1;
            Token tk = tokenList[i];

            if (tk.TokenKind == TokenKind.LineComment || tk.TokenKind == TokenKind.PreprocessingDirective)
            {
                currentTokenIndex++;
                return ExpectId();
            }
            if (tk.TokenKind == TokenKind.Id)
            {
                currentTokenIndex = i;
                return tk.Content;
            }
            return null;
        }
        bool ExpectId(string id)
        {
            //read next and 
            int i = currentTokenIndex + 1;
            Token tk = tokenList[i];
            if (tk.TokenKind == TokenKind.LineComment || tk.TokenKind == TokenKind.PreprocessingDirective)
            {
                currentTokenIndex++;
                return ExpectId(id);
            }
            if (tk.TokenKind == TokenKind.Id && tk.Content == id)
            {
                currentTokenIndex++;
                return true;
            }
            return false;
        }
        bool ExpectPunc(string expectedPunc)
        {
            //read next and 
            int i = currentTokenIndex + 1;
            Token tk = tokenList[i];
            if (tk.TokenKind == TokenKind.LineComment || tk.TokenKind == TokenKind.PreprocessingDirective)
            {
                currentTokenIndex++;
                return ExpectPunc(expectedPunc);
            }

            if (tk.TokenKind == TokenKind.Punc)
            {
                if (tk.Content == expectedPunc)
                {
                    currentTokenIndex = i;
                    return true;
                }

                return false;
            }
            else
            {
                return false;
            }
        }
        bool ExpectPuncSet(string p1, string p2)
        {
            return ExpectPunc(p1) && ExpectPunc(p2);

        }
        bool ExpectPuncSeq(string p1, string p2, string p3)
        {
            return ExpectPunc(p1) && ExpectPunc(p2) && ExpectPunc(p3);
        }

        CodeTypeDeclaration ParseClassDeclaration()
        {
            //class name
            var codeTypeDecl = new CodeTypeDeclaration();
            codeTypeDecl.Name = ExpectId();
            if (ExpectPunc(":"))
            {
                //expected base class list
                //base modifier
                bool publicBase = ExpectId("public");

                codeTypeDecl.BaseTypes.Add(ExpectType());
                //-----------------------------------------------------
                if (ExpectPunc("{"))
                {

                    if (!ExpectId("public"))
                    {
                        throw new NotSupportedException();
                        //should be public
                    }
                    if (!(ExpectPunc(":")))
                    {
                        throw new NotSupportedException();
                    }
                    //-----------------------------------------------------
                    //ctor
                    string ctorFuncName = ExpectId(); ExpectPuncSeq("(", ")", ";");
                    //-----------------------------------------------------
                    while (ParseClassMember(codeTypeDecl)) ;

                }
                else
                {
                    throw new NotSupportedException();
                }

            }
            else
            {
                throw new NotSupportedException();
            }
            return codeTypeDecl;
        }

        bool ParseClassMember(CodeTypeDeclaration codeTypeDecl)
        {
            //member modifiers
            //this version must be public 
            //parse each member
            CodeMethodDeclaration met = new CodeMethodDeclaration();
            codeTypeDecl.Members.Add(met);
            met.ReturnType = ExpectType();
            met.Name = ExpectId();

            if (ExpectPunc("("))
            {
                //parse func parameters    

                //if (met.dbugId == 437)
                //{

                //}
                while (ParseParameter(met)) ;

                if (ExpectId("OVERRIDE"))
                {
                    met.IsOverrided = true;
                }

                if (ExpectPunc(";"))
                {
                    //end this 
                    //start new member         
                    return !ExpectPunc("}");
                }
            }
            else
            {
                throw new NotSupportedException();
            }
            return false;
        }
        string ExpectModifier(string mod)
        {
            Token tk = tokenList[currentTokenIndex + 1];
            switch (tk.TokenKind)
            {
                case TokenKind.LineComment:
                    return ExpectModifier(mod);
                case TokenKind.Id:
                    if (tk.Content == mod)
                    {
                        currentTokenIndex++;
                        return tk.Content;
                    }
                    break;
            }
            return null;
        }
        CodeTypeReference ExpectType()
        {
            string typeName = ExpectId();
            if (typeName != null)
            {
                CodeTypeReference type1 = null;
                //check next token is <
                if (ExpectPunc("<"))
                {
                    CodeTypeTemplateType typeTemplate = new CodeTypeTemplateType(typeName);
                    type1 = typeTemplate;
                //parse each item 
                AGAIN:
                    var typeParameter = ExpectType();
                    if (typeParameter != null)
                    {
                        typeTemplate.AddTemplateItem(typeParameter);
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                    //------------------
                    if (ExpectPunc(","))
                    {
                        goto AGAIN;
                    }
                    else if (ExpectPunc(">"))
                    {
                        //end
                    }
                    else
                    {
                        throw new NotSupportedException();
                    }
                }
                else if (ExpectPunc("::"))
                {
                    CodeTypeReference rightPart = ExpectType();
                    return new CodeQualifiedType(typeName, rightPart);
                }
                else
                {
                    type1 = new CodeTypeReference(typeName);
                }
            //------------------

            CHECK_AGAIN:
                if (ExpectPunc("*"))
                {
                    type1 = new CodePointerTypeReference(type1);
                    goto CHECK_AGAIN;
                }
                else if (ExpectPunc("&"))
                {
                    type1 = new CodeByRefTypeReference(type1);
                    goto CHECK_AGAIN;
                }

                //------------------
                return type1;

            }
            else
            {
                throw new NotSupportedException();
            }

        }
        bool ParseParameter(CodeMethodDeclaration codeMethod)
        {
            if (ExpectPunc(")"))
            {
                return false;
            }

            var metPar = new CodeMethodParameter();
            metPar.IsConstParType = ExpectModifier("const") != null;
            metPar.ParameterType = ExpectType();
            //modifier
            if (ExpectId("const"))
            {
                metPar.IsConstParVariable = true;
                if (ExpectPunc("*"))
                {
                    metPar.IsConstParPointer = true;
                }
            }
            metPar.ParameterName = ExpectId();
            codeMethod.Parameters.Add(metPar);
            //after parameter
            if (ExpectPunc(","))
            {
                return true;
            }
            else if (ExpectPunc(")"))
            {
                return false;
            }
            else
            {
                throw new NotSupportedException();
            }
        }

    }
   
}