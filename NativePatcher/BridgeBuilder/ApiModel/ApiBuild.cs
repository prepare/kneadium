//2016, MIT, WinterDev
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Text;
namespace BridgeBuilder
{
    class ApiBuilder
    {

        public void Build(string apiFolder)
        {
            List<string> onlyHeaders = new List<string>();
            string[] files = Directory.GetFiles(apiFolder);
            foreach (var filename in files)
            {
                if (filename.EndsWith(".h"))
                {
                    if (Path.GetFileName(filename) == "ctocpp.h")
                    {
                        //skip this
                        continue;
                    }
                    onlyHeaders.Add(filename);
                }
            }

            List<CodeCompilationUnit> compilationUnits = new List<CodeCompilationUnit>();
            foreach (var filename in onlyHeaders)
            {
                var headerParser = new HeaderFileParser();
                headerParser.Parse(filename);
                compilationUnits.Add(headerParser.Result);
            }


            //---------------
            //build c/c++ side

            //---------------
            //build managed side
        }
    }
}