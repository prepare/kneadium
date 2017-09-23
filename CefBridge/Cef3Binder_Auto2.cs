//MIT, 2015-2017, WinterDev

using System;
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

    //[System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    //struct _cef_string_utf16_t
    //{
    //    char16* str;
    //    size_t length;
    //    void (* dtor) (char16* str);
    //}
    [System.Runtime.InteropServices.StructLayout(System.Runtime.InteropServices.LayoutKind.Sequential)]
    struct _cef_string_utf16_t
    {
        public IntPtr str; // char16* str, intptr to char*
        public int length; //length;
        public IntPtr dtor;//pointer to dtor, void (* dtor) (char16* str);
    }
    public struct CefCursorInfo
    {
        internal IntPtr nativePtr;
        public CefCursorInfo(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }

    public struct CefPopupFeatures
    {
        internal IntPtr nativePtr;
        public CefPopupFeatures(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }




    public struct CefScreenInfo
    {
        internal IntPtr nativePtr;
        public CefScreenInfo(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefPoint
    {
        internal IntPtr nativePtr;
        public CefPoint(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefRect
    {
        internal IntPtr nativePtr;
        public CefRect(IntPtr nativePtr)
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
    }
    public struct CefPdfPrintSettings
    {
        /////
        //// Structure representing PDF print settings.
        /////
        //typedef struct _cef_pdf_print_settings_t
        //{
        //    ///
        //    // Page title to display in the header. Only used if |header_footer_enabled|
        //    // is set to true (1).
        //    ///
        //    cef_string_t header_footer_title;

        //    ///
        //    // URL to display in the footer. Only used if |header_footer_enabled| is set
        //    // to true (1).
        //    ///
        //    cef_string_t header_footer_url;

        //    ///
        //    // Output page size in microns. If either of these values is less than or
        //    // equal to zero then the default paper size (A4) will be used.
        //    ///
        //    int page_width;
        //    int page_height;

        //    ///
        //    // The percentage to scale the PDF by before printing (e.g. 50 is 50%).
        //    // If this value is less than or equal to zero the default value of 100
        //    // will be used.
        //    ///
        //    int scale_factor;

        //    ///
        //    // Margins in millimeters. Only used if |margin_type| is set to
        //    // PDF_PRINT_MARGIN_CUSTOM.
        //    ///
        //    double margin_top;
        //    double margin_right;
        //    double margin_bottom;
        //    double margin_left;

        //    ///
        //    // Margin type.
        //    ///
        //    cef_pdf_print_margin_type_t margin_type;

        //    ///
        //    // Set to true (1) to print headers and footers or false (0) to not print
        //    // headers and footers.
        //    ///
        //    int header_footer_enabled;

        //    ///
        //    // Set to true (1) to print the selection only or false (0) to print all.
        //    ///
        //    int selection_only;

        //    ///
        //    // Set to true (1) for landscape mode or false (0) for portrait mode.
        //    ///
        //    int landscape;

        //    ///
        //    // Set to true (1) to print background graphics or false (0) to not print
        //    // background graphics.
        //    ///
        //    int backgrounds_enabled;

        //}
        //cef_pdf_print_settings_t;
        //struct CefPdfPrintSettingsTraits
        //{
        //    typedef cef_pdf_print_settings_t struct_type;
        /////
        //// Class representing PDF print settings
        /////
        //typedef CefStructBase<CefPdfPrintSettingsTraits> CefPdfPrintSettings;

        internal IntPtr nativePtr;
        public CefPdfPrintSettings(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }

    public struct CefWindowInfo
    {
        /////
        //// Structure representing window information.
        /////
        //typedef struct _cef_window_info_t
        //{
        //    // Standard parameters required by CreateWindowEx()
        //    DWORD ex_style;
        //    cef_string_t window_name;
        //    DWORD style;
        //    int x;
        //    int y;
        //    int width;
        //    int height;
        //    cef_window_handle_t parent_window;
        //    HMENU menu;

        //    ///
        //    // Set to true (1) to create the browser using windowless (off-screen)
        //    // rendering. No window will be created for the browser and all rendering will
        //    // occur via the CefRenderHandler interface. The |parent_window| value will be
        //    // used to identify monitor info and to act as the parent window for dialogs,
        //    // context menus, etc. If |parent_window| is not provided then the main screen
        //    // monitor will be used and some functionality that requires a parent window
        //    // may not function correctly. In order to create windowless browsers the
        //    // CefSettings.windowless_rendering_enabled value must be set to true.
        //    // Transparent painting is enabled by default but can be disabled by setting
        //    // CefBrowserSettings.background_color to an opaque value.
        //    ///
        //    int windowless_rendering_enabled;

        //    ///
        //    // Handle for the new browser window. Only used with windowed rendering.
        //    ///
        //    cef_window_handle_t window;
        //}
        //cef_window_info_t;
        //struct CefWindowInfoTraits
        //{
        //    typedef cef_window_info_t struct_type;

        //       ///
        //       // Class representing window information.
        //       ///
        //       class CefWindowInfo : public CefStructBase<CefWindowInfoTraits> {
        //public:
        // typedef CefStructBase<CefWindowInfoTraits> parent;
        internal IntPtr nativePtr;
        public CefWindowInfo(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefBrowserSettings
    {
        /////
        //// Represents the state of a setting.
        /////
        //typedef enum {
        //    ///
        //    // Use the default state for the setting.
        //    ///
        //    STATE_DEFAULT = 0,

        //    ///
        //    // Enable or allow the setting.
        //    ///
        //    STATE_ENABLED,

        //    ///
        //    // Disable or disallow the setting.
        //    ///
        //    STATE_DISABLED,
        //}
        //cef_state_t;
        //// Browser initialization settings. Specify NULL or 0 to get the recommended
        //// default values. The consequences of using custom values may not be well
        //// tested. Many of these and other settings can also configured using command-
        //// line switches.
        /////
        //typedef struct _cef_browser_settings_t
        //{
        //    ///
        //    // Size of this structure.
        //    ///
        //    size_t size;

        //    ///
        //    // The maximum rate in frames per second (fps) that CefRenderHandler::OnPaint
        //    // will be called for a windowless browser. The actual fps may be lower if
        //    // the browser cannot generate frames at the requested rate. The minimum
        //    // value is 1 and the maximum value is 60 (default 30). This value can also be
        //    // changed dynamically via CefBrowserHost::SetWindowlessFrameRate.
        //    ///
        //    int windowless_frame_rate;

        //    // The below values map to WebPreferences settings.

        //    ///
        //    // Font settings.
        //    ///
        //    cef_string_t standard_font_family;
        //    cef_string_t fixed_font_family;
        //    cef_string_t serif_font_family;
        //    cef_string_t sans_serif_font_family;
        //    cef_string_t cursive_font_family;
        //    cef_string_t fantasy_font_family;
        //    int default_font_size;
        //    int default_fixed_font_size;
        //    int minimum_font_size;
        //    int minimum_logical_font_size;

        //    ///
        //    // Default encoding for Web content. If empty "ISO-8859-1" will be used. Also
        //    // configurable using the "default-encoding" command-line switch.
        //    ///
        //    cef_string_t default_encoding;

        //    ///
        //    // Controls the loading of fonts from remote sources. Also configurable using
        //    // the "disable-remote-fonts" command-line switch.
        //    ///
        //    cef_state_t remote_fonts;

        //    ///
        //    // Controls whether JavaScript can be executed. Also configurable using the
        //    // "disable-javascript" command-line switch.
        //    ///
        //    cef_state_t javascript;

        //    ///
        //    // Controls whether JavaScript can be used for opening windows. Also
        //    // configurable using the "disable-javascript-open-windows" command-line
        //    // switch.
        //    ///
        //    cef_state_t javascript_open_windows;

        //    ///
        //    // Controls whether JavaScript can be used to close windows that were not
        //    // opened via JavaScript. JavaScript can still be used to close windows that
        //    // were opened via JavaScript or that have no back/forward history. Also
        //    // configurable using the "disable-javascript-close-windows" command-line
        //    // switch.
        //    ///
        //    cef_state_t javascript_close_windows;

        //    ///
        //    // Controls whether JavaScript can access the clipboard. Also configurable
        //    // using the "disable-javascript-access-clipboard" command-line switch.
        //    ///
        //    cef_state_t javascript_access_clipboard;

        //    ///
        //    // Controls whether DOM pasting is supported in the editor via
        //    // execCommand("paste"). The |javascript_access_clipboard| setting must also
        //    // be enabled. Also configurable using the "disable-javascript-dom-paste"
        //    // command-line switch.
        //    ///
        //    cef_state_t javascript_dom_paste;

        //    ///
        //    // Controls whether any plugins will be loaded. Also configurable using the
        //    // "disable-plugins" command-line switch.
        //    ///
        //    cef_state_t plugins;

        //    ///
        //    // Controls whether file URLs will have access to all URLs. Also configurable
        //    // using the "allow-universal-access-from-files" command-line switch.
        //    ///
        //    cef_state_t universal_access_from_file_urls;

        //    ///
        //    // Controls whether file URLs will have access to other file URLs. Also
        //    // configurable using the "allow-access-from-files" command-line switch.
        //    ///
        //    cef_state_t file_access_from_file_urls;

        //    ///
        //    // Controls whether web security restrictions (same-origin policy) will be
        //    // enforced. Disabling this setting is not recommend as it will allow risky
        //    // security behavior such as cross-site scripting (XSS). Also configurable
        //    // using the "disable-web-security" command-line switch.
        //    ///
        //    cef_state_t web_security;

        //    ///
        //    // Controls whether image URLs will be loaded from the network. A cached image
        //    // will still be rendered if requested. Also configurable using the
        //    // "disable-image-loading" command-line switch.
        //    ///
        //    cef_state_t image_loading;

        //    ///
        //    // Controls whether standalone images will be shrunk to fit the page. Also
        //    // configurable using the "image-shrink-standalone-to-fit" command-line
        //    // switch.
        //    ///
        //    cef_state_t image_shrink_standalone_to_fit;

        //    ///
        //    // Controls whether text areas can be resized. Also configurable using the
        //    // "disable-text-area-resize" command-line switch.
        //    ///
        //    cef_state_t text_area_resize;

        //    ///
        //    // Controls whether the tab key can advance focus to links. Also configurable
        //    // using the "disable-tab-to-links" command-line switch.
        //    ///
        //    cef_state_t tab_to_links;

        //    ///
        //    // Controls whether local storage can be used. Also configurable using the
        //    // "disable-local-storage" command-line switch.
        //    ///
        //    cef_state_t local_storage;

        //    ///
        //    // Controls whether databases can be used. Also configurable using the
        //    // "disable-databases" command-line switch.
        //    ///
        //    cef_state_t databases;

        //    ///
        //    // Controls whether the application cache can be used. Also configurable using
        //    // the "disable-application-cache" command-line switch.
        //    ///
        //    cef_state_t application_cache;

        //    ///
        //    // Controls whether WebGL can be used. Note that WebGL requires hardware
        //    // support and may not work on all systems even when enabled. Also
        //    // configurable using the "disable-webgl" command-line switch.
        //    ///
        //    cef_state_t webgl;

        //    ///
        //    // Background color used for the browser before a document is loaded and when
        //    // no document color is specified. The alpha component must be either fully
        //    // opaque (0xFF) or fully transparent (0x00). If the alpha component is fully
        //    // opaque then the RGB components will be used as the background color. If the
        //    // alpha component is fully transparent for a windowed browser then the
        //    // CefSettings.background_color value will be used. If the alpha component is
        //    // fully transparent for a windowless (off-screen) browser then transparent
        //    // painting will be enabled.
        //    ///
        //    cef_color_t background_color;

        //    ///
        //    // Comma delimited ordered list of language codes without any whitespace that
        //    // will be used in the "Accept-Language" HTTP header. May be set globally
        //    // using the CefBrowserSettings.accept_language_list value. If both values are
        //    // empty then "en-US,en" will be used.
        //    ///
        //    cef_string_t accept_language_list;
        //}
        //cef_browser_settings_t;
        //struct CefBrowserSettingsTraits
        //{
        //    typedef cef_browser_settings_t struct_type;
        //---
        /////
        //// Class representing browser initialization settings.
        /////
        //typedef CefStructBase<CefBrowserSettingsTraits> CefBrowserSettings;

        internal IntPtr nativePtr;
        public CefBrowserSettings(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefKeyEvent
    {
        /////
        //// Structure representing keyboard event information.
        /////
        //typedef struct _cef_key_event_t
        //{
        //    ///
        //    // The type of keyboard event.
        //    ///
        //    cef_key_event_type_t type;

        //    ///
        //    // Bit flags describing any pressed modifier keys. See
        //    // cef_event_flags_t for values.
        //    ///
        //    uint32 modifiers;

        //    ///
        //    // The Windows key code for the key event. This value is used by the DOM
        //    // specification. Sometimes it comes directly from the event (i.e. on
        //    // Windows) and sometimes it's determined using a mapping function. See
        //    // WebCore/platform/chromium/KeyboardCodes.h for the list of values.
        //    ///
        //    int windows_key_code;

        //    ///
        //    // The actual key code genenerated by the platform.
        //    ///
        //    int native_key_code;

        //    ///
        //    // Indicates whether the event is considered a "system key" event (see
        //    // http://msdn.microsoft.com/en-us/library/ms646286(VS.85).aspx for details).
        //    // This value will always be false on non-Windows platforms.
        //    ///
        //    int is_system_key;

        //    ///
        //    // The character generated by the keystroke.
        //    ///
        //    char16 character;

        //    ///
        //    // Same as |character| but unmodified by any concurrently-held modifiers
        //    // (except shift). This is useful for working out shortcut keys.
        //    ///
        //    char16 unmodified_character;

        //    ///
        //    // True if the focus is currently on an editable field on the page. This is
        //    // useful for determining if standard key events should be intercepted.
        //    ///
        //    int focus_on_editable_field;
        //}ifoif
        //cef_key_event_t;

        //struct CefKeyEventTraits
        //{
        //    typedef cef_key_event_t struct_type;
        //-----
        /////
        //// Class representing a a keyboard event.
        /////
        //typedef CefStructBase<CefKeyEventTraits> CefKeyEvent;

        internal IntPtr nativePtr;
        public CefKeyEvent(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefMouseEvent
    {
        /////
        //// Structure representing mouse event information.
        /////
        //typedef struct _cef_mouse_event_t
        //{
        //    ///
        //    // X coordinate relative to the left side of the view.
        //    ///
        //    int x;

        //    ///
        //    // Y coordinate relative to the top side of the view.
        //    ///
        //    int y;

        //    ///
        //    // Bit flags describing any pressed modifier keys. See
        //    // cef_event_flags_t for values.
        //    ///
        //    uint32 modifiers;
        //}
        //cef_mouse_event_t;

        //struct CefMouseEventTraits
        //{
        //    typedef cef_mouse_event_t struct_type;

        /////
        //// Class representing a mouse event.
        /////
        //typedef CefStructBase<CefMouseEventTraits> CefMouseEvent;

        internal IntPtr nativePtr;
        public CefMouseEvent(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefCompositionUnderline
    {
        /////
        //// Structure representing IME composition underline information. This is a thin
        //// wrapper around Blink's WebCompositionUnderline class and should be kept in
        //// sync with that.
        /////
        //typedef struct _cef_composition_underline_t
        //{
        //    ///
        //    // Underline character range.
        //    ///
        //    cef_range_t range;

        //    ///
        //    // Text color.
        //    ///
        //    cef_color_t color;

        //    ///
        //    // Background color.
        //    ///
        //    cef_color_t background_color;

        //    ///
        //    // Set to true (1) for thick underline.
        //    ///
        //    int thick;
        //}
        //cef_composition_underline_t;

        //struct CefCompositionUnderlineTraits
        //{
        //    typedef cef_composition_underline_t struct_type;
        //-------------
        /////
        //// Class representing IME composition underline.
        /////
        //typedef CefStructBase<CefCompositionUnderlineTraits> CefCompositionUnderline;

        internal IntPtr nativePtr;
        public CefCompositionUnderline(IntPtr nativePtr)
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
        /////
        //// Time information. Values should always be in UTC.
        /////
        //typedef struct _cef_time_t
        //{
        //    int year;          // Four or five digit year "2007" (1601 to 30827 on
        //                       //   Windows, 1970 to 2038 on 32-bit POSIX)
        //    int month;         // 1-based month (values 1 = January, etc.)
        //    int day_of_week;   // 0-based day of week (0 = Sunday, etc.)
        //    int day_of_month;  // 1-based day of month (1-31)
        //    int hour;          // Hour within the current day (0-23)
        //    int minute;        // Minute within the current hour (0-59)
        //    int second;        // Second within the current minute (0-59 plus leap
        //                       //   seconds which may take it up to 60).
        //    int millisecond;   // Milliseconds within the current second (0-999)
        //}
        //cef_time_t;

        //struct CefTimeTraits
        //{
        //    typedef cef_time_t struct_type;
        //class CefTime : public CefStructBase<CefTimeTraits> {
        //public:

        IntPtr nativePtr;
        public CefTime(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }
    public struct CefCookie
    {
        //struct CefCookieTraits
        //{
        //    typedef cef_cookie_t struct_type;
        //-----------
        /////
        //// Class representing a cookie.
        /////
        //typedef CefStructBase<CefCookieTraits> CefCookie;


        internal IntPtr nativePtr;
        public CefCookie(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
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

    public struct CefV8ValueList
    {
        //implemented by ...
        //typedef std::vector<CefRefPtr<CefV8Value>> CefV8ValueList;

        internal IntPtr nativePtr;
        public CefV8ValueList(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
    }


}