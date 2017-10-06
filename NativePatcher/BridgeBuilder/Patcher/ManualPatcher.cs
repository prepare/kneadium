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

        public void Do_CefClient_CMake_txt()
        {
            //for 3_2704+

            var patch = new PatchFile(RootDir + "\\cefclient\\" + "CMakeLists.txt");

            patch.NewTask("# Source files.")
                .Append(@"set(CEFCLIENT_MYCEF_MYCEF_SRCS 
  myext/ExportFuncs.cpp
  myext/ExportFuncs.h
  myext/mycef.cc
  myext/mycef.h
  myext/MyCefJs.cpp
  myext/MyCefJs.h
  myext/mycef_msg_const.h 
  myext/mycef_buildconfig.h
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

        public void Do_LibCefDll_CMake_txt(string cmakeSrc)
        {

            var patch = new PatchFile(cmakeSrc);

            patch.NewTask("set(CEF_TARGET libcef_dll_wrapper)")
                .FindNext("source_group(libcef_dll FILES ${LIBCEF_SRCS})")
                .Append(@"set(LIBCEF_MYEXT_SRCS
  myext/myext.cpp
  myext/myext.h
  myext/ExportFuncAuto.cpp
  myext/ExportFuncAuto.h
  myext/InternalHeaderForExportFunc.h
  )
 source_group(libcef_dll\\\\myext FILES ${LIBCEF_MYEXT_SRCS})
 ");

            //===================
            patch.NewTask("add_library(${CEF_TARGET}")
                .FindNext("${LIBCEF_WRAPPER_SRCS}")
                .Append("${LIBCEF_MYEXT_SRCS}");
            //===================
            patch.NewTask("# Mac OS X configuration.")
             .FindNext("if(OS_MACOSX)")
             .FindNext("${LIBCEF_WRAPPER_SRCS}")
             .Append("${LIBCEF_MYEXT_SRCS}");
            //===================
            patch.NewTask("# Linux configuration.")
             .FindNext("if(OS_MACOSX)")
             .FindNext("${LIBCEF_WRAPPER_SRCS}")
             .Append("${LIBCEF_MYEXT_SRCS}");

            patch.PatchContent();
        }

    }
}