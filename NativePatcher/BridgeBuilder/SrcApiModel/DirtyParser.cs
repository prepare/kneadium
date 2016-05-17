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
        LiteralNumber,
        LiteralString,
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
                                LexNumber(charBuffer, j, ref i);
                            }
                            else if (char.IsWhiteSpace(c))
                            {
                                //whitespace
                                //skip
                            }
                            else if (c == '"')
                            {
                                //string literal
                                LexStrignLiteral(charBuffer, j, ref i);
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
        void LexNumber(char[] charBuffer, int charCount, ref int currentIndex)
        {
            StringBuilder stbuilder = new StringBuilder();
            char c = charBuffer[currentIndex];
            stbuilder.Append(c);
            for (int i = currentIndex + 1; i < charCount; ++i)
            {
                c = charBuffer[i];
                if (char.IsNumber(c))
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
                tklist.Add(new Token() { Content = stbuilder.ToString(), TokenKind = TokenKind.LiteralNumber });
            }
        }
        void LexStrignLiteral(char[] charBuffer, int charCount, ref int currentIndex)
        {
            StringBuilder stbuilder = new StringBuilder();
            char c = charBuffer[currentIndex];
            stbuilder.Append(c);
            for (int i = currentIndex + 1; i < charCount; ++i)
            {
                c = charBuffer[i];
                if (c == '"')
                {
                    currentIndex = i;
                    stbuilder.Append(c);
                    break;
                }
                else if (c == '\\')
                {
                    //escape
                    throw new NotSupportedException();
                }
                else
                {
                    stbuilder.Append(c);
                }
            }

            if (stbuilder.Length > 0)
            {
                tklist.Add(new Token() { Content = stbuilder.ToString(), TokenKind = TokenKind.LiteralString });
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

    /// <summary>
    /// for cef-3 api only
    /// </summary>
    class Cef3HeaderFileParser
    {
        List<string> allLines = new List<string>();
        List<Token> tokenList = new List<Token>();
        int lineNo = -1;
        int currentTokenIndex;
        List<CodeTypeDeclaration> typeList;
        CodeCompilationUnit cu = new CodeCompilationUnit();
#if DEBUG
        string dbugCurrentFilename = null;
#endif
        public Cef3HeaderFileParser()
        {
            typeList = cu.Members;

        }
        public CodeCompilationUnit Result
        {
            get { return this.cu; }
        }
        public void Parse(string filename)
        {
#if DEBUG
            this.dbugCurrentFilename = Path.GetFileName(filename);
#endif
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

        void ReadUntilEscapeFromBlock()
        {
            int openBraceCount = 0;
            int tkcount = tokenList.Count;
            for (int n = currentTokenIndex + 1; n < tkcount; ++n)
            {
                Token nextTk = tokenList[n];
                if (nextTk.TokenKind == TokenKind.Punc)
                {
                    if (nextTk.Content == "}")
                    {
                        //found , just stop here
                        if (openBraceCount == 0)
                        {
                            currentTokenIndex = n;
                            break;
                        }

                    }
                    else if (nextTk.Content == "{")
                    {
                        openBraceCount++;
                        continue;
                    }

                }
                else
                {
                    continue;
                }
            }

        }
        void ReadUntilEscapeFromInlineComment()
        {
            int tkcount = tokenList.Count;
            for (int n = currentTokenIndex + 1; n < tkcount; ++n)
            {
                Token nextTk = tokenList[n];
                if (nextTk.TokenKind == TokenKind.Comment)
                {
                    //found , just stop here
                    currentTokenIndex = n;
                    break;
                }
                else
                {
                    continue;
                }
            }
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
#if DEBUG
            //if (dbugCurrentFilename == "cef_browser.h")
            //{
            //}
#endif
            CodeTypeDeclaration globalTypeDecl = new CodeTypeDeclaration();
            globalTypeDecl.IsGlobalCompilationUnitType = true;
            this.typeList.Add(globalTypeDecl);

            for (currentTokenIndex = 0; currentTokenIndex < tkcount; ++currentTokenIndex)
            {
                Token tk = tokenList[currentTokenIndex];
                switch (tk.TokenKind)
                {
                    case TokenKind.LineComment:
                    case TokenKind.Whitespace:
                    case TokenKind.PreprocessingDirective://this version we just skip preprocessing directive                        
                        continue;
                    case TokenKind.Comment:
                        //skip until find next comment
                        //TODO: review here 
                        //not correct
                        currentTokenIndex++;
                        ReadUntilEscapeFromInlineComment();
                        continue;//go read next again                         
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
                                case "typedef":
                                    {
                                        //parse typedef 
                                        ParseCTypeDef(globalTypeDecl);
                                    } break;
                                case "template":
                                    {
                                    } break;
                                case "extern":
                                    {
                                        if (ExpectLiteralString("\"C\""))
                                        {
                                            if (ExpectPunc("{"))
                                            {
                                                ReadUntilEscapeFromBlock();
                                            }
                                            else
                                            {
                                                throw new NotSupportedException();
                                            }
                                        }

                                    } break;
                                default:
                                    {
                                        //may be global func
                                        //should be method
                                        this.currentTokenIndex--;
                                        ParseClassMember(globalTypeDecl);
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

            }
            //-------------------------------------------------------
        }
        string ExpectId()
        {
            //read next and 
            int i = currentTokenIndex + 1;
            Token tk = tokenList[i];
            switch (tk.TokenKind)
            {
                case TokenKind.LineComment:
                case TokenKind.PreprocessingDirective:
                    currentTokenIndex++;
                    return ExpectId();
                case TokenKind.Comment:
                    currentTokenIndex++;
                    ReadUntilEscapeFromInlineComment();
                    return ExpectId();
                case TokenKind.Id:
                    currentTokenIndex = i;
                    return tk.Content;
                default:
                    return null;
            }
        }

        bool ExpectToken(TokenKind k, string value)
        {
            int i = currentTokenIndex + 1;
            Token tk = tokenList[i];
            switch (tk.TokenKind)
            {
                case TokenKind.LineComment:
                case TokenKind.PreprocessingDirective:
                    currentTokenIndex++;
                    return ExpectToken(k, value);
                case TokenKind.Id:
                    if (tk.Content == value)
                    {
                        currentTokenIndex++;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case TokenKind.Comment:
                    //found open comment
                    currentTokenIndex++;
                    ReadUntilEscapeFromInlineComment();
                    return ExpectToken(k, value);
                default:
                    if (tk.TokenKind == k && tk.Content == value)
                    {
                        currentTokenIndex++;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
            }
        }
        bool ExpectId(string id)
        {
            return ExpectToken(TokenKind.Id, id);
        }
        bool ExpectLiteralString(string id)
        {
            return ExpectToken(TokenKind.LiteralString, id);
        }
        bool ExpectLiternalNumber(string value)
        {
            //read next and 
            return ExpectToken(TokenKind.LiteralNumber, value);
        }
        bool ExpectPunc(string expectedPunc)
        {
            //read next and 
            int i = currentTokenIndex + 1;
            if (i >= tokenList.Count)
            {
                return false;
            }

            Token tk = tokenList[i];
            switch (tk.TokenKind)
            {
                case TokenKind.LineComment:
                case TokenKind.PreprocessingDirective:
                    currentTokenIndex++;
                    return ExpectPunc(expectedPunc);
                case TokenKind.Comment:
                    currentTokenIndex++;
                    ReadUntilEscapeFromInlineComment();
                    return ExpectPunc(expectedPunc);
                case TokenKind.Punc:
                    if (tk.Content == expectedPunc)
                    {
                        currentTokenIndex = i;
                        return true;
                    }
                    return false;
            }
            return false;

        }

        bool ExpectPuncSeq(string p1, string p2, string p3)
        {
            return ExpectPunc(p1) && ExpectPunc(p2) && ExpectPunc(p3);
        }
        bool ExpectPuncSeq(string p1, string p2)
        {
            return ExpectPunc(p1) && ExpectPunc(p2);
        }
        CodeTypeDeclaration ParseClassDeclaration()
        {
            //class name
            var codeTypeDecl = new CodeTypeDeclaration();
            codeTypeDecl.Name = ExpectId();
            if (ExpectPunc(";"))
            {
                //forward decl
                codeTypeDecl.IsForwardDecl = true;
                return codeTypeDecl;
            }

            if (ExpectPunc(":"))
            {
                //expected base class list
                //base modifier
                codeTypeDecl.BaseIsPublic = ExpectId("public");
                codeTypeDecl.BaseIsVirtual = ExpectId("virtual");
                codeTypeDecl.BaseTypes.Add(ExpectType());
            }
            //-----------------------------------------------------
            if (ExpectPunc("{"))
            {

                while (ParseClassMember(codeTypeDecl)) ;
            }
            else
            {
                throw new NotSupportedException();
            }
            return codeTypeDecl;
        }
        bool ParseCTypeDef(CodeTypeDeclaration codeTypeDecl)
        {
            var from = ExpectType();
            string to = ExpectId();
            if (!ExpectPunc(";"))
            {
                throw new NotSupportedException();
            }
            codeTypeDecl.Members.Add(new CodeCTypeDef(from, to));
            return !ExpectPunc("}");
        }
#if DEBUG
        static int dbugCount = 0;
#endif
        bool ParseClassMember(CodeTypeDeclaration codeTypeDecl)
        {
#if DEBUG
            dbugCount++;
#endif

            //member modifiers
            //this version must be public 
            //parse each member 
            if (ExpectId("public") && ExpectPunc(":"))
            {
            }
            else if (ExpectId("private") && ExpectPunc(":"))
            {
            }
            else if (ExpectId("protected") && ExpectPunc(":"))
            {
            }
            //---------------------------
            if (ExpectId("typedef"))
            {
                //type def
                return ParseCTypeDef(codeTypeDecl);
            }

            //---------------------------
            bool isDestructor = ExpectPunc("~");
            //modifier
            bool isStatic = ExpectId("static");
            bool isVirtual = ExpectId("virtual");
            CodeTypeReference retType = ExpectType();
            string name = ExpectId();


            //-----------------------------------
            if (ExpectPunc("("))
            {
                //this is method

                CodeMethodDeclaration met = new CodeMethodDeclaration();
                codeTypeDecl.Members.Add(met);
                met.IsStatic = isStatic;
                met.IsVirtual = isVirtual;

                if (retType.ToString() == codeTypeDecl.Name &&
                    name == null)
                {
                    //this is ctor or dtor
                    met.ReturnType = null;
                    met.Name = codeTypeDecl.Name;
                    met.MethodKind = (isDestructor) ? MethodKind.Dtor : MethodKind.Ctor;
                }
                else
                {
                    met.Name = name;
                    met.ReturnType = retType;
                }
                //-----------------------------------------------------


                //parse func parameters    
                while (ParseParameter(met)) ;

                met.IsOverrided = ExpectId("OVERRIDE");
                met.IsConst = ExpectId("const");

                if (ExpectPunc(";"))
                {
                    //end this 
                    //start new member  
                    return !ExpectPunc("}");
                }

                if (ExpectPunc("{"))
                {
                    //this version we not parse method body
                    ReadUntilEscapeFromBlock();
                    return !ExpectPunc("}");
                }
                else if (ExpectPunc("="))
                {

                    if (!ExpectLiternalNumber("0"))
                    {
                        throw new NotSupportedException();
                    }
                    // no method body
                    if (!ExpectPunc(";"))
                    {
                        throw new NotSupportedException();
                    }
                    return !ExpectPunc("}");
                }
                else
                {
                    return !ExpectPunc("}");
                }
            }
            else if (ExpectPunc(";"))
            {
                //this is code field decl
                CodeFieldDeclaration field = new CodeFieldDeclaration();
                codeTypeDecl.Members.Add(field);
                field.Name = name;
                field.IsStatic = isStatic;
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
            if (ExpectId("struct"))
            {


            }
            metPar.ParameterType = ExpectType();

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