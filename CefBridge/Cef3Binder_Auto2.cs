//MIT, 2015-2017, WinterDev

using System;
using System.Runtime.InteropServices;

namespace LayoutFarm.CefBridge.Auto
{

    static class MyCefArgsHelper
    {
        public static int FINISH_FLAGS = 1 << 21;

        public static bool IsDone(int flags)
        {
            //TODO: inline method
            return ((flags >> 21) & 1) == 1;
        }
    }
    class CefNotImplementedException : NotImplementedException
    {

    }


    [StructLayout(LayoutKind.Sequential)]
    struct _cef_string_utf16_t
    {
        //[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
        //struct _cef_string_utf16_t
        //{
        //    char16* str;
        //    size_t length;
        //    void (* dtor) (char16* str);
        //}

        public IntPtr str; // char16* str, intptr to char*
        public int length; //length;
        public IntPtr dtor;//pointer to dtor, void (* dtor) (char16* str);
    }

    [StructLayout(LayoutKind.Sequential)]
    struct cef_time_t
    {
        public int year;          // Four or five digit year "2007" (1601 to 30827 on
                                  //   Windows, 1970 to 2038 on 32-bit POSIX)
        public int month;         // 1-based month (values 1 = January, etc.)
        public int day_of_week;   // 0-based day of week (0 = Sunday, etc.)
        public int day_of_month;  // 1-based day of month (1-31)
        public int hour;          // Hour within the current day (0-23)
        public int minute;        // Minute within the current hour (0-59)
        public int second;        // Second within the current minute (0-59 plus leap
                                  //   seconds which may take it up to 60).
        public int millisecond;   // Milliseconds within the current second (0-999)
    }


    ///
    /// Structure representing a rectangle.
    ///
    [StructLayout(LayoutKind.Sequential)]
    struct cef_rect_t
    {
        public int x;
        public int y;
        public int width;
        public int height;
    }


    ///
    /// Structure representing a size.
    ///
    [StructLayout(LayoutKind.Sequential)]
    struct cef_size_t
    {
        public int width;
        public int height;
    }


    ///
    // Structure representing a range.
    ///
    [StructLayout(LayoutKind.Sequential)]
    struct cef_range_t
    {
        public int from;
        public int to;
    }

    ///
    /// Structure representing insets.
    ///
    [StructLayout(LayoutKind.Sequential)]
    struct cef_insets_t
    {
        int top;
        int left;
        int bottom;
        int right;
    }
    ///
    /// Structure representing a point.
    ///
    [StructLayout(LayoutKind.Sequential)]
    struct cef_point_t
    {
        public int x;
        public int y;
    }


    static class MarshalHelper
    {
        public static T CopyToManaged<T>(IntPtr nativePtr)
        {
            return (T)Marshal.PtrToStructure(nativePtr, typeof(T));
        }
    }

    /// <summary>
    ///  Class representing cursor information.
    /// </summary>
    public struct CefCursorInfo
    {
        internal IntPtr nativePtr;
        public CefCursorInfo(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        internal _cef_cursor_info_t CopyToManagedStruct()
        {
            return MarshalHelper.CopyToManaged<_cef_cursor_info_t>(this.nativePtr);
        }

    }

    /// <summary>
    ///  Class representing popup window features.
    /// </summary>
    public struct CefPopupFeatures
    {
        internal IntPtr nativePtr;
        public CefPopupFeatures(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        internal _cef_popup_features_t CopyToManagedStruct()
        {
            return MarshalHelper.CopyToManaged<_cef_popup_features_t>(this.nativePtr);
        }
    }

    public struct CefScreenInfo
    {
        internal IntPtr nativePtr;
        public CefScreenInfo(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        internal _cef_screen_info_t CopyToManagedStruct()
        {
            return MarshalHelper.CopyToManaged<_cef_screen_info_t>(this.nativePtr);
        }

    }
    public struct CefPoint
    {
        internal IntPtr nativePtr; //native handle to cef_point
        public CefPoint(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        internal cef_point_t CopyToManagedStruct()
        {
            return MarshalHelper.CopyToManaged<cef_point_t>(this.nativePtr);
        }

    }
    public struct CefRect
    {
        internal IntPtr nativePtr;
        public CefRect(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        internal cef_rect_t CopyToManagedStruct()
        {
            return MarshalHelper.CopyToManaged<cef_rect_t>(this.nativePtr);
        }

    }
    public struct CefRectList
    {
        internal IntPtr nativePtr;
        public CefRectList(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }

    }
    public struct CefSize
    {
        internal IntPtr nativePtr;
        public CefSize(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        internal cef_size_t CopyToManagedStruct()
        {
            return MarshalHelper.CopyToManaged<cef_size_t>(this.nativePtr);
        }

    }
    public struct CefPdfPrintSettings
    {
        internal IntPtr nativePtr;
        public CefPdfPrintSettings(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        internal _cef_pdf_print_settings_t CopyToManagedStruct()
        {
            return MarshalHelper.CopyToManaged<_cef_pdf_print_settings_t>(this.nativePtr);
        }
        internal void CopyToNative(_cef_pdf_print_settings_t data)
        {
            Marshal.StructureToPtr(data, this.nativePtr, false);
        }
    }

    public struct CefWindowInfo
    {
        internal IntPtr nativePtr;
        public CefWindowInfo(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefBrowserSettings
    {
        internal IntPtr nativePtr;
        public CefBrowserSettings(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        internal _cef_browser_settings_t CopyToManagedStruct()
        {
            return MarshalHelper.CopyToManaged<_cef_browser_settings_t>(this.nativePtr);
        }
        internal void CopyToNative(_cef_browser_settings_t data)
        {
            Marshal.StructureToPtr(data, this.nativePtr, false);
        }
    }
    public struct CefKeyEvent
    {
        internal IntPtr nativePtr;
        public CefKeyEvent(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        internal _cef_key_event_t CopyToManagedStruct()
        {
            return MarshalHelper.CopyToManaged<_cef_key_event_t>(this.nativePtr);
        }
    }
    public struct CefMouseEvent
    {
        internal IntPtr nativePtr;
        public CefMouseEvent(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        internal _cef_mouse_event_t CopyToManagedStruct()
        {
            return MarshalHelper.CopyToManaged<_cef_mouse_event_t>(this.nativePtr);
        }
    }
    public struct CefCompositionUnderline
    {
        internal IntPtr nativePtr;
        public CefCompositionUnderline(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        internal _cef_composition_underline_t CopyToManagedStruct()
        {
            return MarshalHelper.CopyToManaged<_cef_composition_underline_t>(this.nativePtr);
        }
    }
    public struct CefDraggableRegion
    {
        internal IntPtr nativePtr;
        public CefDraggableRegion(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefDraggableRegionList
    {
        internal IntPtr nativePtr;
        public CefDraggableRegionList(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }

    public struct CefRange
    {
        internal IntPtr nativePtr;
        public CefRange(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        internal _cef_range_t CopyToManagedStruct()
        {
            return MarshalHelper.CopyToManaged<_cef_range_t>(this.nativePtr);
        }
    }
    public struct SwitchMap
    {
        //typedef std::map<CefString, CefString> SwitchMap;
        internal IntPtr nativePtr;
        public SwitchMap(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct ArgumentList
    {
        //std::vector<CefString> ArgumentList;
        internal IntPtr nativePtr;
    }
    public struct AttributeMap
    {
        //  typedef std::map<CefString, CefString> AttributeMap;
        internal IntPtr nativePtr;
    }
    public struct CefTime
    {
        IntPtr nativePtr;
        public CefTime(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        internal cef_time_t CopyToManagedStruct()
        {
            return MarshalHelper.CopyToManaged<cef_time_t>(this.nativePtr);
        }
    }
    /// <summary>
    /// Class representing a cookie.
    /// </summary>
    public struct CefCookie
    {
        //struct CefCookieTraits
        //{
        //    typedef cef_cookie_t struct_type;
        //----------- 
        //typedef CefStructBase<CefCookieTraits> CefCookie; 

        internal IntPtr nativePtr;
        public CefCookie(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        internal _cef_cookie_t CopyToManagedStruct()
        {
            return MarshalHelper.CopyToManaged<_cef_cookie_t>(this.nativePtr);
        }
    }

    public struct HeaderMap
    {
        //class CefRequest : public virtual CefBaseRefCounted {
        //public:
        // typedef std::multimap<CefString, CefString> HeaderMap;
        internal IntPtr nativePtr;

    }
    public struct CefBaseRefCounted
    {
        internal IntPtr nativePtr;
        public CefBaseRefCounted(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct KeyList
    {
        ///*--cef(source=library)--*/
        //class CefDictionaryValue : public virtual CefBaseRefCounted {
        //public:
        // typedef std::vector<CefString> KeyList;
        internal IntPtr nativePtr;
    }

    public struct IssuerChainBinaryList
    {
        //class CefX509Certificate : public virtual CefBaseRefCounted {
        //public:
        // typedef std::vector<CefRefPtr<CefBinaryValue>> IssuerChainBinaryList;
        internal IntPtr nativePtr;
    }
    public struct ElementVector
    {
        //implemented by...
        //CefPostData's
        //typedef std::vector<CefRefPtr<CefPostDataElement>> ElementVector;
        internal IntPtr nativePtr;
    }
    public struct PageRangeList
    {
        //implemented by ...
        ////CefPrintSettings 's 
        //typedef std::vector<CefRange> PageRangeList;

        internal IntPtr nativePtr;
    }
    public struct cef_color_t
    {

        //should be int
        internal IntPtr nativePtr;
    }
    public struct CefX509CertificateList
    {
        internal IntPtr nativePtr;
        public CefX509CertificateList(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefV8ValueList
    {
        //implemented by ...
        //typedef std::vector<CefRefPtr<CefV8Value>> CefV8ValueList; 
        internal IntPtr nativePtr;
        public CefV8ValueList(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public static CefV8ValueList NewList()
        {
            return new CefV8ValueList(Cef3Binder.CreateStdList(4));
        }
        public void AddElement(CefV8Value value)
        {
            JsValue jsvalue = new JsValue();
            jsvalue.Ptr = value.nativePtr;
            Cef3Binder.AddListElement(4, nativePtr, ref jsvalue);
        }
        public CefV8Value GetElement(int index)
        {
            JsValue jsvalue = new JsValue();


            Cef3Binder.GetListElement(4, nativePtr, index, ref jsvalue);
            return new CefV8Value(jsvalue.Ptr);
        }
        public int GetListCount()
        {
            int result = 0;
            Cef3Binder.GetListCount(4, nativePtr, out result);
            return result;
        }
    }
    public struct CefRequestContextSettings
    {
        internal IntPtr nativePtr;
        public CefRequestContextSettings(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefSchemeRegistrar
    {
        internal IntPtr nativePtr;
        public CefSchemeRegistrar(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }

}