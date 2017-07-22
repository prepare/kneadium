//MIT, 2016-2017 ,WinterDev

using System;
using System.Text;
using System.Collections.Generic;
using System.IO;


namespace BridgeBuilder.CefApiBuilder
{

    class CefHeaderParser
    {
        Cef3HeaderFileParser parser1 = new Cef3HeaderFileParser();
        public CefHeaderParser()
        {
            //very simple line base parser for Cef
        }
        public void Parse(string filename)
        {
            parser1.Parse(filename);

            //SimpleLineTokenizer simpleLineTokenizer = new SimpleLineTokenizer();

            //int lineCount = sourceFile.LineCount;
            //for (int i = 0; i < lineCount; ++i)
            //{
            //    string line = sourceFile.GetLine(i).Trim();
            //    if (line == "" || line.StartsWith("//") || line.StartsWith("/*"))
            //    {
            //        continue;
            //    }
            //    else if (line.StartsWith("#"))
            //    {
            //        //directive
            //    }
            //    else
            //    {
            //        simpleLineTokenizer.TokenizeLine(line);

            //    }
            //}
        }

    }
    
}