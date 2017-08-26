//MIT, 2016-2017 ,WinterDev
using System;
using System.Text;
namespace BridgeBuilder
{
    //cef -specfic 
    class CodeStringBuilder
    {
        StringBuilder stbuilder = new StringBuilder();
#if DEBUG
        static int _dbugLineCount;
        bool _dbugEnableLineNote = true;
#endif
        public void EnterIndentLevel()
        {

        }
        public void ExitIndentLevel()
        {

        }
        public void AppendLine(string text)
        {
#if DEBUG
            dbugIncLineCount();
#endif
            stbuilder.AppendLine(text);
        }
        public void AppendLine()
        {
#if DEBUG
            dbugIncLineCount();
#endif
            stbuilder.AppendLine();
        }
#if DEBUG
        void dbugIncLineCount()
        {

            _dbugLineCount++;
            if (_dbugEnableLineNote)
            {
                // stbuilder.AppendLine("/*" + _dbugLineCount + "*/");
                //if (_dbugLineCount >= 14863)
                //{

                //}
            }

        }
#endif

        public void Append(string text)
        {
            stbuilder.Append(text);
        }
        public override string ToString()
        {
            return stbuilder.ToString();
        }
    }


}