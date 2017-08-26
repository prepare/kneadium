//MIT, 2016-2017 ,WinterDev
using System;
using System.Collections.Generic;
using System.Text;
namespace BridgeBuilder
{
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
                                LexNumber(charBuffer, '\0', j, ref i);
                            }
                            else if (c == '-')
                            {
                                //read next
                                if (i < j - 1)
                                {
                                    char next_char = charBuffer[i + 1];
                                    if (char.IsNumber(next_char))
                                    {
                                        //consume 
                                        i++;
                                        LexNumber(charBuffer, '-', j, ref i);
                                    }
                                }
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
                        }
                        break;
                }
            }
        }
        public void AssignLineNumber(int lineNum)
        {
            //we lex line-by-line,
            //so all token in the list have the same lineNum
            for (int i = tklist.Count - 1; i >= 0; --i)
            {
                tklist[i].LineNo = lineNum;
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
                    }
                    break;
                case '<':
                    {
                        if (currentIndex + 1 < charCount)
                        {
                            //read next
                            char c1 = charBuffer[currentIndex + 1];
                            if (c1 == '<') //<<
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
                    }
                    break;
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



                    }
                    break;
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
        void LexNumber(char[] charBuffer, char signChar, int charCount, ref int currentIndex)
        {
            StringBuilder stbuilder = new StringBuilder();
            char c = charBuffer[currentIndex];
            //
            if (signChar == '-')
            {
                stbuilder.Append('-');
            }
            //
            stbuilder.Append(c);

            bool isHexNum = false;
            for (int i = currentIndex + 1; i < charCount; ++i)
            {
                c = charBuffer[i];
                if (char.IsNumber(c))
                {
                    stbuilder.Append(c);
                    currentIndex = i;
                }
                else if (c == 'x' || c == 'X')
                {
                    //may be hex number
                    //look next
                    if (isHexNum)
                    {
                        throw new NotSupportedException();
                    }
                    stbuilder.Append(c);
                    currentIndex = i;
                    isHexNum = true;

                }
                else
                {
                    //stop
                    //here
                    if (isHexNum)
                    {
                        char c1 = c.ToString().ToLower()[0];
                        if (c1 >= 'a' && c1 <= 'f')
                        {
                            //also hex 
                            stbuilder.Append(c);
                            currentIndex = i;
                        }
                        else
                        {
                            break;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }

            if (stbuilder.Length > 0)
            {
                tklist.Add(new Token()
                {
                    Content = stbuilder.ToString(),
                    TokenKind = TokenKind.LiteralNumber,
                    NumberInHexFormat = isHexNum
                });
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
}