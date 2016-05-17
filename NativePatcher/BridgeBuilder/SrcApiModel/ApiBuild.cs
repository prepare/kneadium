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

        static bool IsExcludeFile(string thisfileName, string[] excludeFileNames)
        {
            for (int i = excludeFileNames.Length - 1; i >= 0; --i)
            {
                if (excludeFileNames[i] == thisfileName)
                {
                    return true;
                }
            }
            return false;
        }
        public void Build(string[] apiFolders, string[] exludeFileNames)
        {
            List<string> onlyHeaders = new List<string>();
            foreach (var folderName in apiFolders)
            {
                string[] files = Directory.GetFiles(folderName);
                foreach (var filename in files)
                {
                    if (filename.EndsWith(".h"))
                    {
                        if (IsExcludeFile(Path.GetFileName(filename), exludeFileNames))
                        {
                            //skip this
                            continue;
                        }
                        onlyHeaders.Add(filename);
                    }
                }
            }

            List<CodeCompilationUnit> compilationUnits = new List<CodeCompilationUnit>();
            foreach (var filename in onlyHeaders)
            {
                var headerParser = new Cef3HeaderFileParser();
#if DEBUG
                 
#endif
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