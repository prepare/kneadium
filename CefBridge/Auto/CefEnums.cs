//MIT, 2017, WinterDev
//AUTOGEN CONTENT
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge.Auto
{

    /// <summary>
    /// Log severity levels.
    /// </summary>
    public enum cef_log_severity_t
    {
        /// <summary>
        /// Default logging (currently INFO logging).
        /// </summary>
        LOGSEVERITY_DEFAULT,
        /// <summary>
        /// Verbose logging.
        /// </summary>
        LOGSEVERITY_VERBOSE,
        /// <summary>
        /// INFO logging.
        /// </summary>
        LOGSEVERITY_INFO,
        /// <summary>
        /// WARNING logging.
        /// </summary>
        LOGSEVERITY_WARNING,
        /// <summary>
        /// ERROR logging.
        /// </summary>
        LOGSEVERITY_ERROR,
        /// <summary>
        /// Completely disable logging.
        /// </summary>
        LOGSEVERITY_DISABLE = 99
    }
    /// <summary>
    /// Represents the state of a setting.
    /// </summary>
    public enum cef_state_t
    {
        /// <summary>
        /// Use the default state for the setting.
        /// </summary>
        STATE_DEFAULT = 0,
        /// <summary>
        /// Enable or allow the setting.
        /// </summary>
        STATE_ENABLED,
        /// <summary>
        /// Disable or disallow the setting.
        /// </summary>
        STATE_DISABLED
    }
    /// <summary>
    /// Return value types.
    /// </summary>
    public enum cef_return_value_t
    {
        /// <summary>
        /// Cancel immediately.
        /// </summary>
        RV_CANCEL = 0,
        /// <summary>
        /// Continue immediately.
        /// </summary>
        RV_CONTINUE,
        /// <summary>
        /// Continue asynchronously (usually via a callback).
        /// </summary>
        RV_CONTINUE_ASYNC
    }
    /// <summary>
    /// Process termination status values.
    /// </summary>
    public enum cef_termination_status_t
    {
        /// <summary>
        /// Non-zero exit status.
        /// </summary>
        TS_ABNORMAL_TERMINATION,
        /// <summary>
        /// SIGKILL or task manager kill.
        /// </summary>
        TS_PROCESS_WAS_KILLED,
        /// <summary>
        /// Segmentation fault.
        /// </summary>
        TS_PROCESS_CRASHED
    }
    /// <summary>
    /// Path key values.
    /// </summary>
    public enum cef_path_key_t
    {
        /// <summary>
        /// Current directory.
        /// </summary>
        PK_DIR_CURRENT,
        /// <summary>
        /// Directory containing PK_FILE_EXE.
        /// </summary>
        PK_DIR_EXE,
        /// <summary>
        /// Directory containing PK_FILE_MODULE.
        /// </summary>
        PK_DIR_MODULE,
        /// <summary>
        /// Temporary directory.
        /// </summary>
        PK_DIR_TEMP,
        /// <summary>
        /// Path and filename of the current executable.
        /// </summary>
        PK_FILE_EXE,
        /// <summary>
        /// Path and filename of the module containing the CEF code (usually the libcef
        /// module).
        /// </summary>
        PK_FILE_MODULE,
        /// <summary>
        /// "Local Settings\Application Data" directory under the user profile
        /// directory on Windows.
        /// </summary>
        PK_LOCAL_APP_DATA,
        /// <summary>
        /// "Application Data" directory under the user profile directory on Windows
        /// and "~/Library/Application Support" directory on Mac OS X.
        /// </summary>
        PK_USER_DATA
    }
    /// <summary>
    /// Storage types.
    /// </summary>
    public enum cef_storage_type_t
    {
        ST_LOCALSTORAGE = 0,
        ST_SESSIONSTORAGE
    }
    /// <summary>
    /// Supported error code values. See net\base\net_error_list.h for complete
    /// descriptions of the error codes.
    /// </summary>
    public enum cef_errorcode_t
    {
        ERR_NONE = 0,
        ERR_FAILED = -2,
        ERR_ABORTED = -3,
        ERR_INVALID_ARGUMENT = -4,
        ERR_INVALID_HANDLE = -5,
        ERR_FILE_NOT_FOUND = -6,
        ERR_TIMED_OUT = -7,
        ERR_FILE_TOO_BIG = -8,
        ERR_UNEXPECTED = -9,
        ERR_ACCESS_DENIED = -10,
        ERR_NOT_IMPLEMENTED = -11,
        ERR_CONNECTION_CLOSED = -100,
        ERR_CONNECTION_RESET = -101,
        ERR_CONNECTION_REFUSED = -102,
        ERR_CONNECTION_ABORTED = -103,
        ERR_CONNECTION_FAILED = -104,
        ERR_NAME_NOT_RESOLVED = -105,
        ERR_INTERNET_DISCONNECTED = -106,
        ERR_SSL_PROTOCOL_ERROR = -107,
        ERR_ADDRESS_INVALID = -108,
        ERR_ADDRESS_UNREACHABLE = -109,
        ERR_SSL_CLIENT_AUTH_CERT_NEEDED = -110,
        ERR_TUNNEL_CONNECTION_FAILED = -111,
        ERR_NO_SSL_VERSIONS_ENABLED = -112,
        ERR_SSL_VERSION_OR_CIPHER_MISMATCH = -113,
        ERR_SSL_RENEGOTIATION_REQUESTED = -114,
        ERR_CERT_COMMON_NAME_INVALID = -200,
        ERR_CERT_BEGIN = ERR_CERT_COMMON_NAME_INVALID,
        ERR_CERT_DATE_INVALID = -201,
        ERR_CERT_AUTHORITY_INVALID = -202,
        ERR_CERT_CONTAINS_ERRORS = -203,
        ERR_CERT_NO_REVOCATION_MECHANISM = -204,
        ERR_CERT_UNABLE_TO_CHECK_REVOCATION = -205,
        ERR_CERT_REVOKED = -206,
        ERR_CERT_INVALID = -207,
        ERR_CERT_WEAK_SIGNATURE_ALGORITHM = -208,
        /// <summary>
        /// -209 is available: was ERR_CERT_NOT_IN_DNS.
        /// </summary>
        ERR_CERT_NON_UNIQUE_NAME = -210,
        ERR_CERT_WEAK_KEY = -211,
        ERR_CERT_NAME_CONSTRAINT_VIOLATION = -212,
        ERR_CERT_VALIDITY_TOO_LONG = -213,
        ERR_CERT_END = ERR_CERT_VALIDITY_TOO_LONG,
        ERR_INVALID_URL = -300,
        ERR_DISALLOWED_URL_SCHEME = -301,
        ERR_UNKNOWN_URL_SCHEME = -302,
        ERR_TOO_MANY_REDIRECTS = -310,
        ERR_UNSAFE_REDIRECT = -311,
        ERR_UNSAFE_PORT = -312,
        ERR_INVALID_RESPONSE = -320,
        ERR_INVALID_CHUNKED_ENCODING = -321,
        ERR_METHOD_NOT_SUPPORTED = -322,
        ERR_UNEXPECTED_PROXY_AUTH = -323,
        ERR_EMPTY_RESPONSE = -324,
        ERR_RESPONSE_HEADERS_TOO_BIG = -325,
        ERR_CACHE_MISS = -400,
        ERR_INSECURE_RESPONSE = -501
    }
    /// <summary>
    /// Supported certificate status code values. See net\cert\cert_status_flags.h
    /// for more information. CERT_STATUS_NONE is new in CEF because we use an
    /// enum while cert_status_flags.h uses a typedef and static const variables.
    /// </summary>
    public enum cef_cert_status_t
    {
        CERT_STATUS_NONE = 0,
        CERT_STATUS_COMMON_NAME_INVALID = 1 << 0,
        CERT_STATUS_DATE_INVALID = 1 << 1,
        CERT_STATUS_AUTHORITY_INVALID = 1 << 2,
        /// <summary>
        /// 1 << 3 is reserved for ERR_CERT_CONTAINS_ERRORS (not useful with WinHTTP).
        /// </summary>
        CERT_STATUS_NO_REVOCATION_MECHANISM = 1 << 4,
        CERT_STATUS_UNABLE_TO_CHECK_REVOCATION = 1 << 5,
        CERT_STATUS_REVOKED = 1 << 6,
        CERT_STATUS_INVALID = 1 << 7,
        CERT_STATUS_WEAK_SIGNATURE_ALGORITHM = 1 << 8,
        /// <summary>
        /// 1 << 9 was used for CERT_STATUS_NOT_IN_DNS
        /// </summary>
        CERT_STATUS_NON_UNIQUE_NAME = 1 << 10,
        CERT_STATUS_WEAK_KEY = 1 << 11,
        /// <summary>
        /// 1 << 12 was used for CERT_STATUS_WEAK_DH_KEY
        /// </summary>
        CERT_STATUS_PINNED_KEY_MISSING = 1 << 13,
        CERT_STATUS_NAME_CONSTRAINT_VIOLATION = 1 << 14,
        CERT_STATUS_VALIDITY_TOO_LONG = 1 << 15,
        /// <summary>
        /// Bits 16 to 31 are for non-error statuses.
        /// </summary>
        CERT_STATUS_IS_EV = 1 << 16,
        CERT_STATUS_REV_CHECKING_ENABLED = 1 << 17,
        /// <summary>
        /// Bit 18 was CERT_STATUS_IS_DNSSEC
        /// </summary>
        CERT_STATUS_SHA1_SIGNATURE_PRESENT = 1 << 19,
        CERT_STATUS_CT_COMPLIANCE_FAILED = 1 << 20
    }
    /// <summary>
    /// The manner in which a link click should be opened. These constants match
    /// their equivalents in Chromium's window_open_disposition.h and should not be
    /// renumbered.
    /// </summary>
    public enum cef_window_open_disposition_t
    {
        WOD_UNKNOWN,
        WOD_CURRENT_TAB,
        WOD_SINGLETON_TAB,
        WOD_NEW_FOREGROUND_TAB,
        WOD_NEW_BACKGROUND_TAB,
        WOD_NEW_POPUP,
        WOD_NEW_WINDOW,
        WOD_SAVE_TO_DISK,
        WOD_OFF_THE_RECORD
    }
    /// <summary>
    /// "Verb" of a drag-and-drop operation as negotiated between the source and
    /// destination. These constants match their equivalents in WebCore's
    /// DragActions.h and should not be renumbered.
    /// </summary>
    public enum cef_drag_operations_mask_t : uint
    {
        DRAG_OPERATION_NONE = 0,
        DRAG_OPERATION_COPY = 1,
        DRAG_OPERATION_LINK = 2,
        DRAG_OPERATION_GENERIC = 4,
        DRAG_OPERATION_PRIVATE = 8,
        DRAG_OPERATION_MOVE = 16,
        DRAG_OPERATION_DELETE = 32,
        DRAG_OPERATION_EVERY = uint.MaxValue
    }
    /// <summary>
    /// V8 access control values.
    /// </summary>
    public enum cef_v8_accesscontrol_t
    {
        V8_ACCESS_CONTROL_DEFAULT = 0,
        V8_ACCESS_CONTROL_ALL_CAN_READ = 1,
        V8_ACCESS_CONTROL_ALL_CAN_WRITE = 1 << 1,
        V8_ACCESS_CONTROL_PROHIBITS_OVERWRITING = 1 << 2
    }
    /// <summary>
    /// V8 property attribute values.
    /// </summary>
    public enum cef_v8_propertyattribute_t
    {
        V8_PROPERTY_ATTRIBUTE_NONE = 0,
        /// <summary>
        /// Writeable, Enumerable,
        ///   Configurable
        /// </summary>
        V8_PROPERTY_ATTRIBUTE_READONLY = 1 << 0,
        /// <summary>
        /// Not writeable
        /// </summary>
        V8_PROPERTY_ATTRIBUTE_DONTENUM = 1 << 1,
        /// <summary>
        /// Not enumerable
        /// </summary>
        V8_PROPERTY_ATTRIBUTE_DONTDELETE = 1 << 2
    }
    /// <summary>
    /// Post data elements may represent either bytes or files.
    /// </summary>
    public enum cef_postdataelement_type_t
    {
        PDE_TYPE_EMPTY = 0,
        PDE_TYPE_BYTES,
        PDE_TYPE_FILE
    }
    /// <summary>
    /// Resource type for a request.
    /// </summary>
    public enum cef_resource_type_t
    {
        /// <summary>
        /// Top level page.
        /// </summary>
        RT_MAIN_FRAME = 0,
        /// <summary>
        /// Frame or iframe.
        /// </summary>
        RT_SUB_FRAME,
        /// <summary>
        /// CSS stylesheet.
        /// </summary>
        RT_STYLESHEET,
        /// <summary>
        /// External script.
        /// </summary>
        RT_SCRIPT,
        /// <summary>
        /// Image (jpg/gif/png/etc).
        /// </summary>
        RT_IMAGE,
        /// <summary>
        /// Font.
        /// </summary>
        RT_FONT_RESOURCE,
        /// <summary>
        /// Some other subresource. This is the default type if the actual type is
        /// unknown.
        /// </summary>
        RT_SUB_RESOURCE,
        /// <summary>
        /// Object (or embed) tag for a plugin, or a resource that a plugin requested.
        /// </summary>
        RT_OBJECT,
        /// <summary>
        /// Media resource.
        /// </summary>
        RT_MEDIA,
        /// <summary>
        /// Main resource of a dedicated worker.
        /// </summary>
        RT_WORKER,
        /// <summary>
        /// Main resource of a shared worker.
        /// </summary>
        RT_SHARED_WORKER,
        /// <summary>
        /// Explicitly requested prefetch.
        /// </summary>
        RT_PREFETCH,
        /// <summary>
        /// Favicon.
        /// </summary>
        RT_FAVICON,
        /// <summary>
        /// XMLHttpRequest.
        /// </summary>
        RT_XHR,
        /// <summary>
        /// A request for a <ping>
        /// </summary>
        RT_PING,
        /// <summary>
        /// Main resource of a service worker.
        /// </summary>
        RT_SERVICE_WORKER,
        /// <summary>
        /// A report of Content Security Policy violations.
        /// </summary>
        RT_CSP_REPORT,
        /// <summary>
        /// A resource that a plugin requested.
        /// </summary>
        RT_PLUGIN_RESOURCE
    }
    /// <summary>
    /// Transition type for a request. Made up of one source value and 0 or more
    /// qualifiers.
    /// </summary>
    public enum cef_transition_type_t : uint
    {
        /// <summary>
        /// Source is a link click or the JavaScript window.open function. This is
        /// also the default value for requests like sub-resource loads that are not
        /// navigations.
        /// </summary>
        TT_LINK = 0,
        /// <summary>
        /// Source is some other "explicit" navigation action such as creating a new
        /// browser or using the LoadURL function. This is also the default value
        /// for navigations where the actual type is unknown.
        /// </summary>
        TT_EXPLICIT = 1,
        /// <summary>
        /// Source is a subframe navigation. This is any content that is automatically
        /// loaded in a non-toplevel frame. For example, if a page consists of several
        /// frames containing ads, those ad URLs will have this transition type.
        /// The user may not even realize the content in these pages is a separate
        /// frame, so may not care about the URL.
        /// </summary>
        TT_AUTO_SUBFRAME = 3,
        /// <summary>
        /// Source is a subframe navigation explicitly requested by the user that will
        /// generate new navigation entries in the back/forward list. These are
        /// probably more important than frames that were automatically loaded in
        /// the background because the user probably cares about the fact that this
        /// link was loaded.
        /// </summary>
        TT_MANUAL_SUBFRAME = 4,
        /// <summary>
        /// Source is a form submission by the user. NOTE: In some situations
        /// submitting a form does not result in this transition type. This can happen
        /// if the form uses a script to submit the contents.
        /// </summary>
        TT_FORM_SUBMIT = 7,
        /// <summary>
        /// Source is a "reload" of the page via the Reload function or by re-visiting
        /// the same URL. NOTE: This is distinct from the concept of whether a
        /// particular load uses "reload semantics" (i.e. bypasses cached data).
        /// </summary>
        TT_RELOAD = 8,
        /// <summary>
        /// General mask defining the bits used for the source values.
        /// </summary>
        TT_SOURCE_MASK = 0xFF,
        /// <summary>
        /// Qualifiers.
        /// Any of the core values above can be augmented by one or more qualifiers.
        /// These qualifiers further define the transition.
        /// Attempted to visit a URL but was blocked.
        /// </summary>
        TT_BLOCKED_FLAG = 0x00800000,
        /// <summary>
        /// Used the Forward or Back function to navigate among browsing history.
        /// </summary>
        TT_FORWARD_BACK_FLAG = 0x01000000,
        /// <summary>
        /// The beginning of a navigation chain.
        /// </summary>
        TT_CHAIN_START_FLAG = 0x10000000,
        /// <summary>
        /// The last transition in a redirect chain.
        /// </summary>
        TT_CHAIN_END_FLAG = 0x20000000,
        /// <summary>
        /// Redirects caused by JavaScript or a meta refresh tag on the page.
        /// </summary>
        TT_CLIENT_REDIRECT_FLAG = 0x40000000,
        /// <summary>
        /// Redirects sent from the server by HTTP headers.
        /// </summary>
        TT_SERVER_REDIRECT_FLAG = 0x80000000,
        /// <summary>
        /// Used to test whether a transition involves a redirect.
        /// </summary>
        TT_IS_REDIRECT_MASK = 0xC0000000,
        /// <summary>
        /// General mask defining the bits used for the qualifiers.
        /// </summary>
        TT_QUALIFIER_MASK = 0xFFFFFF00
    }
    /// <summary>
    /// Flags used to customize the behavior of CefURLRequest.
    /// </summary>
    [Flags]
    public enum cef_urlrequest_flags_t
    {
        /// <summary>
        /// Default behavior.
        /// </summary>
        UR_FLAG_NONE = 0,
        /// <summary>
        /// If set the cache will be skipped when handling the request.
        /// </summary>
        UR_FLAG_SKIP_CACHE = 1 << 0,
        /// <summary>
        /// If set user name, password, and cookies may be sent with the request, and
        /// cookies may be saved from the response.
        /// </summary>
        UR_FLAG_ALLOW_CACHED_CREDENTIALS = 1 << 1,
        /// <summary>
        /// If set upload progress events will be generated when a request has a body.
        /// </summary>
        UR_FLAG_REPORT_UPLOAD_PROGRESS = 1 << 3,
        /// <summary>
        /// If set the CefURLRequestClient::OnDownloadData method will not be called.
        /// </summary>
        UR_FLAG_NO_DOWNLOAD_DATA = 1 << 6,
        /// <summary>
        /// If set 5XX redirect errors will be propagated to the observer instead of
        /// automatically re-tried. This currently only applies for requests
        /// originated in the browser process.
        /// </summary>
        UR_FLAG_NO_RETRY_ON_5XX = 1 << 7
    }
    /// <summary>
    /// Flags that represent CefURLRequest status.
    /// </summary>
    public enum cef_urlrequest_status_t
    {
        /// <summary>
        /// Unknown status.
        /// </summary>
        UR_UNKNOWN = 0,
        /// <summary>
        /// Request succeeded.
        /// </summary>
        UR_SUCCESS,
        /// <summary>
        /// An IO request is pending, and the caller will be informed when it is
        /// completed.
        /// </summary>
        UR_IO_PENDING,
        /// <summary>
        /// Request was canceled programatically.
        /// </summary>
        UR_CANCELED,
        /// <summary>
        /// Request failed for some reason.
        /// </summary>
        UR_FAILED
    }
    /// <summary>
    /// Existing process IDs.
    /// </summary>
    public enum cef_process_id_t
    {
        /// <summary>
        /// Browser process.
        /// </summary>
        PID_BROWSER,
        /// <summary>
        /// Renderer process.
        /// </summary>
        PID_RENDERER
    }
    /// <summary>
    /// Existing thread IDs.
    /// </summary>
    public enum cef_thread_id_t
    {
        /// <summary>
        /// BROWSER PROCESS THREADS -- Only available in the browser process.
        /// The main thread in the browser. This will be the same as the main
        /// application thread if CefInitialize() is called with a
        /// CefSettings.multi_threaded_message_loop value of false.
        /// </summary>
        TID_UI,
        /// <summary>
        /// Used to interact with the database.
        /// </summary>
        TID_DB,
        /// <summary>
        /// Used to interact with the file system.
        /// </summary>
        TID_FILE,
        /// <summary>
        /// Used for file system operations that block user interactions.
        /// Responsiveness of this thread affects users.
        /// </summary>
        TID_FILE_USER_BLOCKING,
        /// <summary>
        /// Used to launch and terminate browser processes.
        /// </summary>
        TID_PROCESS_LAUNCHER,
        /// <summary>
        /// Used to handle slow HTTP cache operations.
        /// </summary>
        TID_CACHE,
        /// <summary>
        /// Used to process IPC and network messages.
        /// </summary>
        TID_IO,
        /// <summary>
        /// RENDER PROCESS THREADS -- Only available in the render process.
        /// The main thread in the renderer. Used for all WebKit and V8 interaction.
        /// </summary>
        TID_RENDERER
    }
    /// <summary>
    /// Thread priority values listed in increasing order of importance.
    /// </summary>
    public enum cef_thread_priority_t
    {
        /// <summary>
        /// Suitable for threads that shouldn't disrupt high priority work.
        /// </summary>
        TP_BACKGROUND,
        /// <summary>
        /// Default priority level.
        /// </summary>
        TP_NORMAL,
        /// <summary>
        /// Suitable for threads which generate data for the display (at ~60Hz).
        /// </summary>
        TP_DISPLAY,
        /// <summary>
        /// Suitable for low-latency, glitch-resistant audio.
        /// </summary>
        TP_REALTIME_AUDIO
    }
    /// <summary>
    /// Message loop types. Indicates the set of asynchronous events that a message
    /// loop can process.
    /// </summary>
    public enum cef_message_loop_type_t
    {
        /// <summary>
        /// Supports tasks and timers.
        /// </summary>
        ML_TYPE_DEFAULT,
        /// <summary>
        /// Supports tasks, timers and native UI events (e.g. Windows messages).
        /// </summary>
        ML_TYPE_UI,
        /// <summary>
        /// Supports tasks, timers and asynchronous IO events.
        /// </summary>
        ML_TYPE_IO
    }
    /// <summary>
    /// Windows COM initialization mode. Specifies how COM will be initialized for a
    /// new thread.
    /// </summary>
    public enum cef_com_init_mode_t
    {
        /// <summary>
        /// No COM initialization.
        /// </summary>
        COM_INIT_MODE_NONE,
        /// <summary>
        /// Initialize COM using single-threaded apartments.
        /// </summary>
        COM_INIT_MODE_STA,
        /// <summary>
        /// Initialize COM using multi-threaded apartments.
        /// </summary>
        COM_INIT_MODE_MTA
    }
    /// <summary>
    /// Supported value types.
    /// </summary>
    public enum cef_value_type_t
    {
        VTYPE_INVALID = 0,
        VTYPE_NULL,
        VTYPE_BOOL,
        VTYPE_INT,
        VTYPE_DOUBLE,
        VTYPE_STRING,
        VTYPE_BINARY,
        VTYPE_DICTIONARY,
        VTYPE_LIST
    }
    /// <summary>
    /// Supported JavaScript dialog types.
    /// </summary>
    public enum cef_jsdialog_type_t
    {
        JSDIALOGTYPE_ALERT = 0,
        JSDIALOGTYPE_CONFIRM,
        JSDIALOGTYPE_PROMPT
    }
    /// <summary>
    /// Supported menu IDs. Non-English translations can be provided for the
    /// IDS_MENU_* strings in CefResourceBundleHandler::GetLocalizedString().
    /// </summary>
    public enum cef_menu_id_t
    {
        /// <summary>
        /// Navigation.
        /// </summary>
        MENU_ID_BACK = 100,
        MENU_ID_FORWARD = 101,
        MENU_ID_RELOAD = 102,
        MENU_ID_RELOAD_NOCACHE = 103,
        MENU_ID_STOPLOAD = 104,
        /// <summary>
        /// Editing.
        /// </summary>
        MENU_ID_UNDO = 110,
        MENU_ID_REDO = 111,
        MENU_ID_CUT = 112,
        MENU_ID_COPY = 113,
        MENU_ID_PASTE = 114,
        MENU_ID_DELETE = 115,
        MENU_ID_SELECT_ALL = 116,
        /// <summary>
        /// Miscellaneous.
        /// </summary>
        MENU_ID_FIND = 130,
        MENU_ID_PRINT = 131,
        MENU_ID_VIEW_SOURCE = 132,
        /// <summary>
        /// Spell checking word correction suggestions.
        /// </summary>
        MENU_ID_SPELLCHECK_SUGGESTION_0 = 200,
        MENU_ID_SPELLCHECK_SUGGESTION_1 = 201,
        MENU_ID_SPELLCHECK_SUGGESTION_2 = 202,
        MENU_ID_SPELLCHECK_SUGGESTION_3 = 203,
        MENU_ID_SPELLCHECK_SUGGESTION_4 = 204,
        MENU_ID_SPELLCHECK_SUGGESTION_LAST = 204,
        MENU_ID_NO_SPELLING_SUGGESTIONS = 205,
        MENU_ID_ADD_TO_DICTIONARY = 206,
        /// <summary>
        /// Custom menu items originating from the renderer process. For example,
        /// plugin placeholder menu items or Flash menu items.
        /// </summary>
        MENU_ID_CUSTOM_FIRST = 220,
        MENU_ID_CUSTOM_LAST = 250,
        /// <summary>
        /// All user-defined menu IDs should come between MENU_ID_USER_FIRST and
        /// MENU_ID_USER_LAST to avoid overlapping the Chromium and CEF ID ranges
        /// defined in the tools/gritsettings/resource_ids file.
        /// </summary>
        MENU_ID_USER_FIRST = 26500,
        MENU_ID_USER_LAST = 28500
    }
    /// <summary>
    /// Mouse button types.
    /// </summary>
    public enum cef_mouse_button_type_t
    {
        MBT_LEFT = 0,
        MBT_MIDDLE,
        MBT_RIGHT
    }
    /// <summary>
    /// Paint element types.
    /// </summary>
    public enum cef_paint_element_type_t
    {
        PET_VIEW = 0,
        PET_POPUP
    }
    /// <summary>
    /// Supported event bit flags.
    /// </summary>
    [Flags]
    public enum cef_event_flags_t
    {
        EVENTFLAG_NONE = 0,
        EVENTFLAG_CAPS_LOCK_ON = 1 << 0,
        EVENTFLAG_SHIFT_DOWN = 1 << 1,
        EVENTFLAG_CONTROL_DOWN = 1 << 2,
        EVENTFLAG_ALT_DOWN = 1 << 3,
        EVENTFLAG_LEFT_MOUSE_BUTTON = 1 << 4,
        EVENTFLAG_MIDDLE_MOUSE_BUTTON = 1 << 5,
        EVENTFLAG_RIGHT_MOUSE_BUTTON = 1 << 6,
        /// <summary>
        /// Mac OS-X command key.
        /// </summary>
        EVENTFLAG_COMMAND_DOWN = 1 << 7,
        EVENTFLAG_NUM_LOCK_ON = 1 << 8,
        EVENTFLAG_IS_KEY_PAD = 1 << 9,
        EVENTFLAG_IS_LEFT = 1 << 10,
        EVENTFLAG_IS_RIGHT = 1 << 11
    }
    /// <summary>
    /// Supported menu item types.
    /// </summary>
    public enum cef_menu_item_type_t
    {
        MENUITEMTYPE_NONE,
        MENUITEMTYPE_COMMAND,
        MENUITEMTYPE_CHECK,
        MENUITEMTYPE_RADIO,
        MENUITEMTYPE_SEPARATOR,
        MENUITEMTYPE_SUBMENU
    }
    /// <summary>
    /// Supported context menu type flags.
    /// </summary>
    [Flags]
    public enum cef_context_menu_type_flags_t
    {
        /// <summary>
        /// No node is selected.
        /// </summary>
        CM_TYPEFLAG_NONE = 0,
        /// <summary>
        /// The top page is selected.
        /// </summary>
        CM_TYPEFLAG_PAGE = 1 << 0,
        /// <summary>
        /// A subframe page is selected.
        /// </summary>
        CM_TYPEFLAG_FRAME = 1 << 1,
        /// <summary>
        /// A link is selected.
        /// </summary>
        CM_TYPEFLAG_LINK = 1 << 2,
        /// <summary>
        /// A media node is selected.
        /// </summary>
        CM_TYPEFLAG_MEDIA = 1 << 3,
        /// <summary>
        /// There is a textual or mixed selection that is selected.
        /// </summary>
        CM_TYPEFLAG_SELECTION = 1 << 4,
        /// <summary>
        /// An editable element is selected.
        /// </summary>
        CM_TYPEFLAG_EDITABLE = 1 << 5
    }
    /// <summary>
    /// Supported context menu media types.
    /// </summary>
    public enum cef_context_menu_media_type_t
    {
        /// <summary>
        /// No special node is in context.
        /// </summary>
        CM_MEDIATYPE_NONE,
        /// <summary>
        /// An image node is selected.
        /// </summary>
        CM_MEDIATYPE_IMAGE,
        /// <summary>
        /// A video node is selected.
        /// </summary>
        CM_MEDIATYPE_VIDEO,
        /// <summary>
        /// An audio node is selected.
        /// </summary>
        CM_MEDIATYPE_AUDIO,
        /// <summary>
        /// A file node is selected.
        /// </summary>
        CM_MEDIATYPE_FILE,
        /// <summary>
        /// A plugin node is selected.
        /// </summary>
        CM_MEDIATYPE_PLUGIN
    }
    /// <summary>
    /// Supported context menu media state bit flags.
    /// </summary>
    [Flags]
    public enum cef_context_menu_media_state_flags_t
    {
        CM_MEDIAFLAG_NONE = 0,
        CM_MEDIAFLAG_ERROR = 1 << 0,
        CM_MEDIAFLAG_PAUSED = 1 << 1,
        CM_MEDIAFLAG_MUTED = 1 << 2,
        CM_MEDIAFLAG_LOOP = 1 << 3,
        CM_MEDIAFLAG_CAN_SAVE = 1 << 4,
        CM_MEDIAFLAG_HAS_AUDIO = 1 << 5,
        CM_MEDIAFLAG_HAS_VIDEO = 1 << 6,
        CM_MEDIAFLAG_CONTROL_ROOT_ELEMENT = 1 << 7,
        CM_MEDIAFLAG_CAN_PRINT = 1 << 8,
        CM_MEDIAFLAG_CAN_ROTATE = 1 << 9
    }
    /// <summary>
    /// Supported context menu edit state bit flags.
    /// </summary>
    [Flags]
    public enum cef_context_menu_edit_state_flags_t
    {
        CM_EDITFLAG_NONE = 0,
        CM_EDITFLAG_CAN_UNDO = 1 << 0,
        CM_EDITFLAG_CAN_REDO = 1 << 1,
        CM_EDITFLAG_CAN_CUT = 1 << 2,
        CM_EDITFLAG_CAN_COPY = 1 << 3,
        CM_EDITFLAG_CAN_PASTE = 1 << 4,
        CM_EDITFLAG_CAN_DELETE = 1 << 5,
        CM_EDITFLAG_CAN_SELECT_ALL = 1 << 6,
        CM_EDITFLAG_CAN_TRANSLATE = 1 << 7
    }
    /// <summary>
    /// Key event types.
    /// </summary>
    public enum cef_key_event_type_t
    {
        /// <summary>
        /// Notification that a key transitioned from "up" to "down".
        /// </summary>
        KEYEVENT_RAWKEYDOWN = 0,
        /// <summary>
        /// Notification that a key was pressed. This does not necessarily correspond
        /// to a character depending on the key and language. Use KEYEVENT_CHAR for
        /// character input.
        /// </summary>
        KEYEVENT_KEYDOWN,
        /// <summary>
        /// Notification that a key was released.
        /// </summary>
        KEYEVENT_KEYUP
    }
    /// <summary>
    /// Focus sources.
    /// </summary>
    public enum cef_focus_source_t
    {
        /// <summary>
        /// The source is explicit navigation via the API (LoadURL(), etc).
        /// </summary>
        FOCUS_SOURCE_NAVIGATION = 0,
        /// <summary>
        /// The source is a system-generated focus event.
        /// </summary>
        FOCUS_SOURCE_SYSTEM
    }
    /// <summary>
    /// Navigation types.
    /// </summary>
    public enum cef_navigation_type_t
    {
        NAVIGATION_LINK_CLICKED = 0,
        NAVIGATION_FORM_SUBMITTED,
        NAVIGATION_BACK_FORWARD,
        NAVIGATION_RELOAD,
        NAVIGATION_FORM_RESUBMITTED,
        NAVIGATION_OTHER
    }
    /// <summary>
    /// Supported XML encoding types. The parser supports ASCII, ISO-8859-1, and
    /// UTF16 (LE and BE) by default. All other types must be translated to UTF8
    /// before being passed to the parser. If a BOM is detected and the correct
    /// decoder is available then that decoder will be used automatically.
    /// </summary>
    public enum cef_xml_encoding_type_t
    {
        XML_ENCODING_NONE = 0,
        XML_ENCODING_UTF8,
        XML_ENCODING_UTF16LE,
        XML_ENCODING_UTF16BE,
        XML_ENCODING_ASCII
    }
    /// <summary>
    /// XML node types.
    /// </summary>
    public enum cef_xml_node_type_t
    {
        XML_NODE_UNSUPPORTED = 0,
        XML_NODE_PROCESSING_INSTRUCTION,
        XML_NODE_DOCUMENT_TYPE,
        XML_NODE_ELEMENT_START,
        XML_NODE_ELEMENT_END,
        XML_NODE_ATTRIBUTE,
        XML_NODE_TEXT,
        XML_NODE_CDATA,
        XML_NODE_ENTITY_REFERENCE,
        XML_NODE_WHITESPACE,
        XML_NODE_COMMENT
    }
    /// <summary>
    /// DOM document types.
    /// </summary>
    public enum cef_dom_document_type_t
    {
        DOM_DOCUMENT_TYPE_UNKNOWN = 0,
        DOM_DOCUMENT_TYPE_HTML,
        DOM_DOCUMENT_TYPE_XHTML,
        DOM_DOCUMENT_TYPE_PLUGIN
    }
    /// <summary>
    /// DOM event category flags.
    /// </summary>
    public enum cef_dom_event_category_t
    {
        DOM_EVENT_CATEGORY_UNKNOWN = 0x0,
        DOM_EVENT_CATEGORY_UI = 0x1,
        DOM_EVENT_CATEGORY_MOUSE = 0x2,
        DOM_EVENT_CATEGORY_MUTATION = 0x4,
        DOM_EVENT_CATEGORY_KEYBOARD = 0x8,
        DOM_EVENT_CATEGORY_TEXT = 0x10,
        DOM_EVENT_CATEGORY_COMPOSITION = 0x20,
        DOM_EVENT_CATEGORY_DRAG = 0x40,
        DOM_EVENT_CATEGORY_CLIPBOARD = 0x80,
        DOM_EVENT_CATEGORY_MESSAGE = 0x100,
        DOM_EVENT_CATEGORY_WHEEL = 0x200,
        DOM_EVENT_CATEGORY_BEFORE_TEXT_INSERTED = 0x400,
        DOM_EVENT_CATEGORY_OVERFLOW = 0x800,
        DOM_EVENT_CATEGORY_PAGE_TRANSITION = 0x1000,
        DOM_EVENT_CATEGORY_POPSTATE = 0x2000,
        DOM_EVENT_CATEGORY_PROGRESS = 0x4000,
        DOM_EVENT_CATEGORY_XMLHTTPREQUEST_PROGRESS = 0x8000
    }
    /// <summary>
    /// DOM event processing phases.
    /// </summary>
    public enum cef_dom_event_phase_t
    {
        DOM_EVENT_PHASE_UNKNOWN = 0,
        DOM_EVENT_PHASE_CAPTURING,
        DOM_EVENT_PHASE_AT_TARGET,
        DOM_EVENT_PHASE_BUBBLING
    }
    /// <summary>
    /// DOM node types.
    /// </summary>
    public enum cef_dom_node_type_t
    {
        DOM_NODE_TYPE_UNSUPPORTED = 0,
        DOM_NODE_TYPE_ELEMENT,
        DOM_NODE_TYPE_ATTRIBUTE,
        DOM_NODE_TYPE_TEXT,
        DOM_NODE_TYPE_CDATA_SECTION,
        DOM_NODE_TYPE_PROCESSING_INSTRUCTIONS,
        DOM_NODE_TYPE_COMMENT,
        DOM_NODE_TYPE_DOCUMENT,
        DOM_NODE_TYPE_DOCUMENT_TYPE,
        DOM_NODE_TYPE_DOCUMENT_FRAGMENT
    }
    /// <summary>
    /// Supported file dialog modes.
    /// </summary>
    public enum cef_file_dialog_mode_t
    {
        /// <summary>
        /// Requires that the file exists before allowing the user to pick it.
        /// </summary>
        FILE_DIALOG_OPEN = 0,
        /// <summary>
        /// Like Open, but allows picking multiple files to open.
        /// </summary>
        FILE_DIALOG_OPEN_MULTIPLE,
        /// <summary>
        /// Like Open, but selects a folder to open.
        /// </summary>
        FILE_DIALOG_OPEN_FOLDER,
        /// <summary>
        /// Allows picking a nonexistent file, and prompts to overwrite if the file
        /// already exists.
        /// </summary>
        FILE_DIALOG_SAVE,
        /// <summary>
        /// General mask defining the bits used for the type values.
        /// </summary>
        FILE_DIALOG_TYPE_MASK = 0xFF,
        /// <summary>
        /// Qualifiers.
        /// Any of the type values above can be augmented by one or more qualifiers.
        /// These qualifiers further define the dialog behavior.
        /// Prompt to overwrite if the user selects an existing file with the Save
        /// dialog.
        /// </summary>
        FILE_DIALOG_OVERWRITEPROMPT_FLAG = 0x01000000,
        /// <summary>
        /// Do not display read-only files.
        /// </summary>
        FILE_DIALOG_HIDEREADONLY_FLAG = 0x02000000
    }
    /// <summary>
    /// Geoposition error codes.
    /// </summary>
    public enum cef_geoposition_error_code_t
    {
        GEOPOSITON_ERROR_NONE = 0,
        GEOPOSITON_ERROR_PERMISSION_DENIED,
        GEOPOSITON_ERROR_POSITION_UNAVAILABLE,
        GEOPOSITON_ERROR_TIMEOUT
    }
    /// <summary>
    /// Print job color mode values.
    /// </summary>
    public enum cef_color_model_t
    {
        COLOR_MODEL_UNKNOWN,
        COLOR_MODEL_GRAY,
        COLOR_MODEL_COLOR,
        COLOR_MODEL_CMYK,
        COLOR_MODEL_CMY,
        COLOR_MODEL_KCMY,
        COLOR_MODEL_CMY_K,
        /// <summary>
        /// CMY_K represents CMY+K.
        /// </summary>
        COLOR_MODEL_BLACK,
        COLOR_MODEL_GRAYSCALE,
        COLOR_MODEL_RGB,
        COLOR_MODEL_RGB16,
        COLOR_MODEL_RGBA,
        COLOR_MODEL_COLORMODE_COLOR,
        /// <summary>
        /// Used in samsung printer ppds.
        /// </summary>
        COLOR_MODEL_COLORMODE_MONOCHROME,
        /// <summary>
        /// Used in samsung printer ppds.
        /// </summary>
        COLOR_MODEL_HP_COLOR_COLOR,
        /// <summary>
        /// Used in HP color printer ppds.
        /// </summary>
        COLOR_MODEL_HP_COLOR_BLACK,
        /// <summary>
        /// Used in HP color printer ppds.
        /// </summary>
        COLOR_MODEL_PRINTOUTMODE_NORMAL,
        /// <summary>
        /// Used in foomatic ppds.
        /// </summary>
        COLOR_MODEL_PRINTOUTMODE_NORMAL_GRAY,
        /// <summary>
        /// Used in foomatic ppds.
        /// </summary>
        COLOR_MODEL_PROCESSCOLORMODEL_CMYK,
        /// <summary>
        /// Used in canon printer ppds.
        /// </summary>
        COLOR_MODEL_PROCESSCOLORMODEL_GREYSCALE,
        /// <summary>
        /// Used in canon printer ppds.
        /// </summary>
        COLOR_MODEL_PROCESSCOLORMODEL_RGB
    }
    /// <summary>
    /// Print job duplex mode values.
    /// </summary>
    public enum cef_duplex_mode_t
    {
        DUPLEX_MODE_UNKNOWN = -1,
        DUPLEX_MODE_SIMPLEX,
        DUPLEX_MODE_LONG_EDGE,
        DUPLEX_MODE_SHORT_EDGE
    }
    /// <summary>
    /// Cursor type values.
    /// </summary>
    public enum cef_cursor_type_t
    {
        CT_POINTER = 0,
        CT_CROSS,
        CT_HAND,
        CT_IBEAM,
        CT_WAIT,
        CT_HELP,
        CT_EASTRESIZE,
        CT_NORTHRESIZE,
        CT_NORTHEASTRESIZE,
        CT_NORTHWESTRESIZE,
        CT_SOUTHRESIZE,
        CT_SOUTHEASTRESIZE,
        CT_SOUTHWESTRESIZE,
        CT_WESTRESIZE,
        CT_NORTHSOUTHRESIZE,
        CT_EASTWESTRESIZE,
        CT_NORTHEASTSOUTHWESTRESIZE,
        CT_NORTHWESTSOUTHEASTRESIZE,
        CT_COLUMNRESIZE,
        CT_ROWRESIZE,
        CT_MIDDLEPANNING,
        CT_EASTPANNING,
        CT_NORTHPANNING,
        CT_NORTHEASTPANNING,
        CT_NORTHWESTPANNING,
        CT_SOUTHPANNING,
        CT_SOUTHEASTPANNING,
        CT_SOUTHWESTPANNING,
        CT_WESTPANNING,
        CT_MOVE,
        CT_VERTICALTEXT,
        CT_CELL,
        CT_CONTEXTMENU,
        CT_ALIAS,
        CT_PROGRESS,
        CT_NODROP,
        CT_COPY,
        CT_NONE,
        CT_NOTALLOWED,
        CT_ZOOMIN,
        CT_ZOOMOUT,
        CT_GRAB,
        CT_GRABBING,
        CT_CUSTOM
    }
    /// <summary>
    /// URI unescape rules passed to CefURIDecode().
    /// </summary>
    public enum cef_uri_unescape_rule_t
    {
        /// <summary>
        /// Don't unescape anything at all.
        /// </summary>
        UU_NONE = 0,
        /// <summary>
        /// Don't unescape anything special, but all normal unescaping will happen.
        /// This is a placeholder and can't be combined with other flags (since it's
        /// just the absence of them). All other unescape rules imply "normal" in
        /// addition to their special meaning. Things like escaped letters, digits,
        /// and most symbols will get unescaped with this mode.
        /// </summary>
        UU_NORMAL = 1 << 0,
        /// <summary>
        /// Convert %20 to spaces. In some places where we're showing URLs, we may
        /// want this. In places where the URL may be copied and pasted out, then
        /// you wouldn't want this since it might not be interpreted in one piece
        /// by other applications.
        /// </summary>
        UU_SPACES = 1 << 1,
        /// <summary>
        /// Unescapes '/' and '\\'. If these characters were unescaped, the resulting
        /// URL won't be the same as the source one. Moreover, they are dangerous to
        /// unescape in strings that will be used as file paths or names. This value
        /// should only be used when slashes don't have special meaning, like data
        /// URLs.
        /// </summary>
        UU_PATH_SEPARATORS = 1 << 2,
        /// <summary>
        /// Unescapes various characters that will change the meaning of URLs,
        /// including '%', '+', '&', '#'. Does not unescape path separators.
        /// If these characters were unescaped, the resulting URL won't be the same
        /// as the source one. This flag is used when generating final output like
        /// filenames for URLs where we won't be interpreting as a URL and want to do
        /// as much unescaping as possible.
        /// </summary>
        UU_URL_SPECIAL_CHARS_EXCEPT_PATH_SEPARATORS = 1 << 3,
        /// <summary>
        /// Unescapes characters that can be used in spoofing attempts (such as LOCK)
        /// and control characters (such as BiDi control characters and %01).  This
        /// INCLUDES NULLs.  This is used for rare cases such as data: URL decoding
        /// where the result is binary data.
        ///
        /// DO NOT use UU_SPOOFING_AND_CONTROL_CHARS if the URL is going to be
        /// displayed in the UI for security reasons.
        /// </summary>
        UU_SPOOFING_AND_CONTROL_CHARS = 1 << 4,
        /// <summary>
        /// URL queries use "+" for space. This flag controls that replacement.
        /// </summary>
        UU_REPLACE_PLUS_WITH_SPACE = 1 << 5
    }
    /// <summary>
    /// Options that can be passed to CefParseJSON.
    /// </summary>
    public enum cef_json_parser_options_t
    {
        /// <summary>
        /// Parses the input strictly according to RFC 4627. See comments in Chromium's
        /// base/json/json_reader.h file for known limitations/deviations from the RFC.
        /// </summary>
        JSON_PARSER_RFC = 0,
        /// <summary>
        /// Allows commas to exist after the last element in structures.
        /// </summary>
        JSON_PARSER_ALLOW_TRAILING_COMMAS = 1 << 0
    }
    /// <summary>
    /// Error codes that can be returned from CefParseJSONAndReturnError.
    /// </summary>
    public enum cef_json_parser_error_t
    {
        JSON_NO_ERROR = 0,
        JSON_INVALID_ESCAPE,
        JSON_SYNTAX_ERROR,
        JSON_UNEXPECTED_TOKEN,
        JSON_TRAILING_COMMA,
        JSON_TOO_MUCH_NESTING,
        JSON_UNEXPECTED_DATA_AFTER_ROOT,
        JSON_UNSUPPORTED_ENCODING,
        JSON_UNQUOTED_DICTIONARY_KEY
    }
    /// <summary>
    /// Options that can be passed to CefWriteJSON.
    /// </summary>
    public enum cef_json_writer_options_t
    {
        /// <summary>
        /// Default behavior.
        /// </summary>
        JSON_WRITER_DEFAULT = 0,
        /// <summary>
        /// This option instructs the writer that if a Binary value is encountered,
        /// the value (and key if within a dictionary) will be omitted from the
        /// output, and success will be returned. Otherwise, if a binary value is
        /// encountered, failure will be returned.
        /// </summary>
        JSON_WRITER_OMIT_BINARY_VALUES = 1 << 0,
        /// <summary>
        /// This option instructs the writer to write doubles that have no fractional
        /// part as a normal integer (i.e., without using exponential notation
        /// or appending a '.0') as long as the value is within the range of a
        /// 64-bit int.
        /// </summary>
        JSON_WRITER_OMIT_DOUBLE_TYPE_PRESERVATION = 1 << 1,
        /// <summary>
        /// Return a slightly nicer formatted json string (pads with whitespace to
        /// help with readability).
        /// </summary>
        JSON_WRITER_PRETTY_PRINT = 1 << 2
    }
    /// <summary>
    /// Margin type for PDF printing.
    /// </summary>
    public enum cef_pdf_print_margin_type_t
    {
        /// <summary>
        /// Default margins.
        /// </summary>
        PDF_PRINT_MARGIN_DEFAULT,
        /// <summary>
        /// No margins.
        /// </summary>
        PDF_PRINT_MARGIN_NONE,
        /// <summary>
        /// Minimum margins.
        /// </summary>
        PDF_PRINT_MARGIN_MINIMUM,
        /// <summary>
        /// Custom margins using the |margin_*| values from cef_pdf_print_settings_t.
        /// </summary>
        PDF_PRINT_MARGIN_CUSTOM
    }
    /// <summary>
    /// Supported UI scale factors for the platform. SCALE_FACTOR_NONE is used for
    /// density independent resources such as string, html/js files or an image that
    /// can be used for any scale factors (such as wallpapers).
    /// </summary>
    public enum cef_scale_factor_t
    {
        SCALE_FACTOR_NONE = 0,
        SCALE_FACTOR_100P,
        SCALE_FACTOR_125P,
        SCALE_FACTOR_133P,
        SCALE_FACTOR_140P,
        SCALE_FACTOR_150P,
        SCALE_FACTOR_180P,
        SCALE_FACTOR_200P,
        SCALE_FACTOR_250P,
        SCALE_FACTOR_300P
    }
    /// <summary>
    /// Plugin policies supported by CefRequestContextHandler::OnBeforePluginLoad.
    /// </summary>
    public enum cef_plugin_policy_t
    {
        /// <summary>
        /// Allow the content.
        /// </summary>
        PLUGIN_POLICY_ALLOW,
        /// <summary>
        /// Allow important content and block unimportant content based on heuristics.
        /// The user can manually load blocked content.
        /// </summary>
        PLUGIN_POLICY_DETECT_IMPORTANT,
        /// <summary>
        /// Block the content. The user can manually load blocked content.
        /// </summary>
        PLUGIN_POLICY_BLOCK,
        /// <summary>
        /// Disable the content. The user cannot load disabled content.
        /// </summary>
        PLUGIN_POLICY_DISABLE
    }
    /// <summary>
    /// Policy for how the Referrer HTTP header value will be sent during navigation.
    /// If the `--no-referrers` command-line flag is specified then the policy value
    /// will be ignored and the Referrer value will never be sent.
    /// </summary>
    public enum cef_referrer_policy_t
    {
        /// <summary>
        /// Always send the complete Referrer value.
        /// </summary>
        REFERRER_POLICY_ALWAYS,
        /// <summary>
        /// Use the default policy. This is REFERRER_POLICY_ORIGIN_WHEN_CROSS_ORIGIN
        /// when the `--reduced-referrer-granularity` command-line flag is specified
        /// and REFERRER_POLICY_NO_REFERRER_WHEN_DOWNGRADE otherwise.
        ///
        /// </summary>
        REFERRER_POLICY_DEFAULT,
        /// <summary>
        /// When navigating from HTTPS to HTTP do not send the Referrer value.
        /// Otherwise, send the complete Referrer value.
        /// </summary>
        REFERRER_POLICY_NO_REFERRER_WHEN_DOWNGRADE,
        /// <summary>
        /// Never send the Referrer value.
        /// </summary>
        REFERRER_POLICY_NEVER,
        /// <summary>
        /// Only send the origin component of the Referrer value.
        /// </summary>
        REFERRER_POLICY_ORIGIN,
        /// <summary>
        /// When navigating cross-origin only send the origin component of the Referrer
        /// value. Otherwise, send the complete Referrer value.
        /// </summary>
        REFERRER_POLICY_ORIGIN_WHEN_CROSS_ORIGIN
    }
    /// <summary>
    /// Return values for CefResponseFilter::Filter().
    /// </summary>
    public enum cef_response_filter_status_t
    {
        /// <summary>
        /// Some or all of the pre-filter data was read successfully but more data is
        /// needed in order to continue filtering (filtered output is pending).
        /// </summary>
        RESPONSE_FILTER_NEED_MORE_DATA,
        /// <summary>
        /// Some or all of the pre-filter data was read successfully and all available
        /// filtered output has been written.
        /// </summary>
        RESPONSE_FILTER_DONE
    }
    /// <summary>
    /// Describes how to interpret the components of a pixel.
    /// </summary>
    public enum cef_color_type_t
    {
        /// <summary>
        /// RGBA with 8 bits per pixel (32bits total).
        /// </summary>
        CEF_COLOR_TYPE_RGBA_8888,
        /// <summary>
        /// BGRA with 8 bits per pixel (32bits total).
        /// </summary>
        CEF_COLOR_TYPE_BGRA_8888
    }
    /// <summary>
    /// Describes how to interpret the alpha component of a pixel.
    /// </summary>
    public enum cef_alpha_type_t
    {
        /// <summary>
        /// No transparency. The alpha component is ignored.
        /// </summary>
        CEF_ALPHA_TYPE_OPAQUE,
        /// <summary>
        /// Transparency with pre-multiplied alpha component.
        /// </summary>
        CEF_ALPHA_TYPE_PREMULTIPLIED,
        /// <summary>
        /// Transparency with post-multiplied alpha component.
        /// </summary>
        CEF_ALPHA_TYPE_POSTMULTIPLIED
    }
    /// <summary>
    /// Text style types. Should be kepy in sync with gfx::TextStyle.
    /// </summary>
    public enum cef_text_style_t
    {
        CEF_TEXT_STYLE_BOLD,
        CEF_TEXT_STYLE_ITALIC,
        CEF_TEXT_STYLE_STRIKE,
        CEF_TEXT_STYLE_DIAGONAL_STRIKE,
        CEF_TEXT_STYLE_UNDERLINE
    }
    /// <summary>
    /// Specifies where along the main axis the CefBoxLayout child views should be
    /// laid out.
    /// </summary>
    public enum cef_main_axis_alignment_t
    {
        /// <summary>
        /// Child views will be left-aligned.
        /// </summary>
        CEF_MAIN_AXIS_ALIGNMENT_START,
        /// <summary>
        /// Child views will be center-aligned.
        /// </summary>
        CEF_MAIN_AXIS_ALIGNMENT_CENTER,
        /// <summary>
        /// Child views will be right-aligned.
        /// </summary>
        CEF_MAIN_AXIS_ALIGNMENT_END
    }
    /// <summary>
    /// Specifies where along the cross axis the CefBoxLayout child views should be
    /// laid out.
    /// </summary>
    public enum cef_cross_axis_alignment_t
    {
        /// <summary>
        /// Child views will be stretched to fit.
        /// </summary>
        CEF_CROSS_AXIS_ALIGNMENT_STRETCH,
        /// <summary>
        /// Child views will be left-aligned.
        /// </summary>
        CEF_CROSS_AXIS_ALIGNMENT_START,
        /// <summary>
        /// Child views will be center-aligned.
        /// </summary>
        CEF_CROSS_AXIS_ALIGNMENT_CENTER,
        /// <summary>
        /// Child views will be right-aligned.
        /// </summary>
        CEF_CROSS_AXIS_ALIGNMENT_END
    }
    /// <summary>
    /// Specifies the button display state.
    /// </summary>
    public enum cef_button_state_t
    {
        CEF_BUTTON_STATE_NORMAL,
        CEF_BUTTON_STATE_HOVERED,
        CEF_BUTTON_STATE_PRESSED,
        CEF_BUTTON_STATE_DISABLED
    }
    /// <summary>
    /// Specifies the horizontal text alignment mode.
    /// </summary>
    public enum cef_horizontal_alignment_t
    {
        /// <summary>
        /// Align the text's left edge with that of its display area.
        /// </summary>
        CEF_HORIZONTAL_ALIGNMENT_LEFT,
        /// <summary>
        /// Align the text's center with that of its display area.
        /// </summary>
        CEF_HORIZONTAL_ALIGNMENT_CENTER,
        /// <summary>
        /// Align the text's right edge with that of its display area.
        /// </summary>
        CEF_HORIZONTAL_ALIGNMENT_RIGHT
    }
    /// <summary>
    /// Specifies how a menu will be anchored for non-RTL languages. The opposite
    /// position will be used for RTL languages.
    /// </summary>
    public enum cef_menu_anchor_position_t
    {
        CEF_MENU_ANCHOR_TOPLEFT,
        CEF_MENU_ANCHOR_TOPRIGHT,
        CEF_MENU_ANCHOR_BOTTOMCENTER
    }
    /// <summary>
    /// Supported color types for menu items.
    /// </summary>
    public enum cef_menu_color_type_t
    {
        CEF_MENU_COLOR_TEXT,
        CEF_MENU_COLOR_TEXT_HOVERED,
        CEF_MENU_COLOR_TEXT_ACCELERATOR,
        CEF_MENU_COLOR_TEXT_ACCELERATOR_HOVERED,
        CEF_MENU_COLOR_BACKGROUND,
        CEF_MENU_COLOR_BACKGROUND_HOVERED,
        CEF_MENU_COLOR_COUNT
    }
    /// <summary>
    /// Supported SSL version values. See net/ssl/ssl_connection_status_flags.h
    /// for more information.
    /// </summary>
    public enum cef_ssl_version_t
    {
        SSL_CONNECTION_VERSION_UNKNOWN = 0,
        /// <summary>
        /// Unknown SSL version.
        /// </summary>
        SSL_CONNECTION_VERSION_SSL2 = 1,
        SSL_CONNECTION_VERSION_SSL3 = 2,
        SSL_CONNECTION_VERSION_TLS1 = 3,
        SSL_CONNECTION_VERSION_TLS1_1 = 4,
        SSL_CONNECTION_VERSION_TLS1_2 = 5,
        /// <summary>
        /// Reserve 6 for TLS 1.3.
        /// </summary>
        SSL_CONNECTION_VERSION_QUIC = 7
    }
    /// <summary>
    /// Supported SSL content status flags. See content/public/common/ssl_status.h
    /// for more information.
    /// </summary>
    public enum cef_ssl_content_status_t
    {
        SSL_CONTENT_NORMAL_CONTENT = 0,
        SSL_CONTENT_DISPLAYED_INSECURE_CONTENT = 1 << 0,
        SSL_CONTENT_RAN_INSECURE_CONTENT = 1 << 1
    }
    /// <summary>
    /// Error codes for CDM registration. See cef_web_plugin.h for details.
    /// </summary>
    public enum cef_cdm_registration_error_t
    {
        /// <summary>
        /// No error. Registration completed successfully.
        /// </summary>
        CEF_CDM_REGISTRATION_ERROR_NONE,
        /// <summary>
        /// Required files or manifest contents are missing.
        /// </summary>
        CEF_CDM_REGISTRATION_ERROR_INCORRECT_CONTENTS,
        /// <summary>
        /// The CDM is incompatible with the current Chromium version.
        /// </summary>
        CEF_CDM_REGISTRATION_ERROR_INCOMPATIBLE,
        /// <summary>
        /// CDM registration is not supported at this time.
        /// </summary>
        CEF_CDM_REGISTRATION_ERROR_NOT_SUPPORTED
    }
}