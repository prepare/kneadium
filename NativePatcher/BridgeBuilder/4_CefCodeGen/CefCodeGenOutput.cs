//MIT, 2016-2017 ,WinterDev

namespace BridgeBuilder
{
    class CefCodeGenOutput
    {
        internal CodeStringBuilder _cppHeaderExportFuncAuto = new CodeStringBuilder();//ExportFuncAuto.h
        internal CodeStringBuilder _cppHeaderInternalForExportFuncAuto = new CodeStringBuilder(); //InternalHeaderForExportFunc.h
        internal CodeStringBuilder _cppCode = new CodeStringBuilder(); //ExportFuncAuto.cpp
        internal CodeStringBuilder _csCode = new CodeStringBuilder(); //

    }
}