//MIT, 2016-2017 ,WinterDev 
using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace BridgeBuilder
{

    class ManualPatcher
    {

        public ManualPatcher(string rootdir)
        {
            this.RootDir = rootdir;
        }
        public string RootDir
        {
            get;
            set;
        }
        PatchFile CreatePathFile(string filename)
        {
            return new PatchFile(RootDir + "\\" + filename);
        }


        public void Do_CMake_txt()
        {
            //for 3_2704+

            var patch = new PatchFile(RootDir + "\\cefclient\\" + "CMakeLists.txt");

            patch.NewTask("# Source files.")
                .Append(@"set(CEFCLIENT_MYCEF_MYCEF_SRCS
  myext/dll_init.cpp
  myext/dll_init.h
  myext/ExportFuncs.cpp
  myext/ExportFuncs.h
  myext/mycef.cc
  myext/mycef.h
  myext/MyCefJs.cpp
  myext/MyCefJs.h
  myext/mycef_msg_const.h
  myext/MyCef_Win.cpp
  myext/mycef_buildconfig.h
  myext/ExportFuncAuto.h
  myext/ExportFuncAuto.cpp
  )
source_group(cefclient\\\\myext FILES ${CEFCLIENT_MYCEF_MYCEF_SRCS})
set(CEFCLIENT_MYCEF_SRCS
  ${CEFCLIENT_MYCEF_MYCEF_SRCS}
  )");

            //===================
            patch.NewTask("# Windows configuration.")
                .FindNext("if(OS_WINDOWS)")
                .FindNext("set(CEFCLIENT_SRCS")
                .Append("${CEFCLIENT_MYCEF_MYCEF_SRCS}");
            //===================
            patch.NewTask("# Mac OS X configuration.")
             .FindNext("if(OS_MACOSX)")
             .FindNext("set(CEFCLIENT_SRCS")
             .Append("${CEFCLIENT_MYCEF_MYCEF_SRCS}");
            //===================
            patch.NewTask("# Linux configuration.")
             .FindNext("if(OS_MACOSX)")
             .FindNext("set(CEFCLIENT_SRCS")
             .Append("${CEFCLIENT_MYCEF_MYCEF_SRCS}");

            patch.PatchContent();


        }

        public void CopyExtensionSources(string extensionTargetDir)
        {


            string extensionSourceDir = @"..\..\Patcher_ExtCode\myext";

            if (extensionSourceDir == extensionTargetDir)
            {
                throw new NotSupportedException("not copy to the same dir");
            }


            //check extension source dir
            if (!Directory.Exists(extensionSourceDir))
            {
                throw new NotSupportedException("no extension src dir");
            }
            if (Directory.Exists(extensionTargetDir))
            {
                throw new NotSupportedException("target dir already exists");
            }
            //-------------------------------------------------------------
            //create ext dir
            Directory.CreateDirectory(extensionTargetDir);
            //copy 
            string[] files = Directory.GetFiles(extensionSourceDir);
            for (int i = files.Length - 1; i >= 0; --i)
            {
                File.Copy(files[i],
                    extensionTargetDir + "\\" + Path.GetFileName(files[i]));
            }
            //------------------------------------------------------------- 
        }

    }
}