//MIT, 2017, WinterDev//AUTOGEN CONTENT
using System;
using System.Collections.Generic;
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

    // [virtual] class CefApp
    /// <summary>
    /// Implement this interface to provide handler implementations. Methods will be
    /// called by the process and/or thread indicated.
    /// /*cef(source=client,no_debugct_check)*/
    /// </summary>
    public struct CefApp
    {
        const int _typeNAME = 1;
        const int CefApp_Release_0 = (_typeNAME << 16) | 0;
        internal readonly IntPtr nativePtr;
        internal CefApp(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefApp_Release_0, out ret);
        }
    }


    // [virtual] class CefBrowser
    /// <summary>
    /// Class used to represent a browser window. When used in the browser process
    /// the methods of this class may be called on any thread unless otherwise
    /// indicated in the comments. When used in the render process the methods of
    /// this class may only be called on the main thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefBrowser
    {
        const int _typeNAME = 2;
        const int CefBrowser_Release_0 = (_typeNAME << 16) | 0;
        const int CefBrowser_GetHost_1 = (_typeNAME << 16) | 1;
        const int CefBrowser_CanGoBack_2 = (_typeNAME << 16) | 2;
        const int CefBrowser_GoBack_3 = (_typeNAME << 16) | 3;
        const int CefBrowser_CanGoForward_4 = (_typeNAME << 16) | 4;
        const int CefBrowser_GoForward_5 = (_typeNAME << 16) | 5;
        const int CefBrowser_IsLoading_6 = (_typeNAME << 16) | 6;
        const int CefBrowser_Reload_7 = (_typeNAME << 16) | 7;
        const int CefBrowser_ReloadIgnoreCache_8 = (_typeNAME << 16) | 8;
        const int CefBrowser_StopLoad_9 = (_typeNAME << 16) | 9;
        const int CefBrowser_GetIdentifier_10 = (_typeNAME << 16) | 10;
        const int CefBrowser_IsSame_11 = (_typeNAME << 16) | 11;
        const int CefBrowser_IsPopup_12 = (_typeNAME << 16) | 12;
        const int CefBrowser_HasDocument_13 = (_typeNAME << 16) | 13;
        const int CefBrowser_GetMainFrame_14 = (_typeNAME << 16) | 14;
        const int CefBrowser_GetFocusedFrame_15 = (_typeNAME << 16) | 15;
        const int CefBrowser_GetFrame_16 = (_typeNAME << 16) | 16;
        const int CefBrowser_GetFrame_17 = (_typeNAME << 16) | 17;
        const int CefBrowser_GetFrameCount_18 = (_typeNAME << 16) | 18;
        const int CefBrowser_GetFrameIdentifiers_19 = (_typeNAME << 16) | 19;
        const int CefBrowser_GetFrameNames_20 = (_typeNAME << 16) | 20;
        const int CefBrowser_SendProcessMessage_21 = (_typeNAME << 16) | 21;
        internal readonly IntPtr nativePtr;
        internal CefBrowser(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_Release_0, out ret);
        }

        // gen! CefRefPtr<CefBrowserHost> GetHost()
        /// <summary>
        /// CefBrowser methods.
        /// </summary>

        public CefBrowserHost GetHost()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetHost_1, out ret);
            var ret_result = new CefBrowserHost(ret.Ptr);
            return ret_result;
        }

        // gen! bool CanGoBack()
        /// <summary>
        /// Returns true if the browser can navigate backwards.
        /// /*cef()*/
        /// </summary>

        public bool CanGoBack()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_CanGoBack_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void GoBack()
        /// <summary>
        /// Navigate backwards.
        /// /*cef()*/
        /// </summary>

        public void GoBack()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GoBack_3, out ret);

        }

        // gen! bool CanGoForward()
        /// <summary>
        /// Returns true if the browser can navigate forwards.
        /// /*cef()*/
        /// </summary>

        public bool CanGoForward()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_CanGoForward_4, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void GoForward()
        /// <summary>
        /// Navigate forwards.
        /// /*cef()*/
        /// </summary>

        public void GoForward()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GoForward_5, out ret);

        }

        // gen! bool IsLoading()
        /// <summary>
        /// Returns true if the browser is currently loading.
        /// /*cef()*/
        /// </summary>

        public bool IsLoading()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_IsLoading_6, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void Reload()
        /// <summary>
        /// Reload the current page.
        /// /*cef()*/
        /// </summary>

        public void Reload()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_Reload_7, out ret);

        }

        // gen! void ReloadIgnoreCache()
        /// <summary>
        /// Reload the current page ignoring any cached data.
        /// /*cef()*/
        /// </summary>

        public void ReloadIgnoreCache()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_ReloadIgnoreCache_8, out ret);

        }

        // gen! void StopLoad()
        /// <summary>
        /// Stop loading the page.
        /// /*cef()*/
        /// </summary>

        public void StopLoad()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_StopLoad_9, out ret);

        }

        // gen! int GetIdentifier()
        /// <summary>
        /// Returns the globally unique identifier for this browser.
        /// /*cef()*/
        /// </summary>

        public int GetIdentifier()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetIdentifier_10, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! bool IsSame(CefRefPtr<CefBrowser> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefBrowser that
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_IsSame_11, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsPopup()
        /// <summary>
        /// Returns true if the window is a popup window.
        /// /*cef()*/
        /// </summary>

        public bool IsPopup()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_IsPopup_12, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool HasDocument()
        /// <summary>
        /// Returns true if a document has been loaded in the browser.
        /// /*cef()*/
        /// </summary>

        public bool HasDocument()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_HasDocument_13, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefFrame> GetMainFrame()
        /// <summary>
        /// Returns the main (top-level) frame for the browser window.
        /// /*cef()*/
        /// </summary>

        public CefFrame GetMainFrame()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetMainFrame_14, out ret);
            var ret_result = new CefFrame(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefFrame> GetFocusedFrame()
        /// <summary>
        /// Returns the focused frame for the browser window.
        /// /*cef()*/
        /// </summary>

        public CefFrame GetFocusedFrame()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetFocusedFrame_15, out ret);
            var ret_result = new CefFrame(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefFrame> GetFrame(int64 identifier)

        public CefFrame GetFrame(long identifier
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I64 = identifier;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrame_16, out ret, ref v1);
            var ret_result = new CefFrame(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefFrame> GetFrame(const CefString& name)

        public CefFrame GetFrame(string name
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrame_17, out ret, ref v1);
            var ret_result = new CefFrame(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! size_t GetFrameCount()
        /// <summary>
        /// Returns the number of frames that currently exist.
        /// /*cef()*/
        /// </summary>

        public uint GetFrameCount()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetFrameCount_18, out ret);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! void GetFrameIdentifiers(std::vector<int64>& identifiers)
        /// <summary>
        /// Returns the identifiers of all existing frames.
        /// /*cef(count_func=identifiers:GetFrameCount)*/
        /// </summary>

        public void GetFrameIdentifiers(List<long> identifiers
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(1);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrameIdentifiers_19, out ret, ref v1);

            Cef3Binder.CopyStdInt64ListAndDestroyNativeSide(v1.Ptr, identifiers);
        }

        // gen! void GetFrameNames(std::vector<CefString>& names)
        /// <summary>
        /// Returns the names of all existing frames.
        /// /*cef()*/
        /// </summary>

        public void GetFrameNames(List<string> names
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrameNames_20, out ret, ref v1);

            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, names);
        }

        // gen! bool SendProcessMessage(CefProcessId target_process,CefRefPtr<CefProcessMessage> message)
        /// <summary>
        /// Send a message to the specified |target_process|. Returns true if the
        /// message was sent successfully.
        /// /*cef()*/
        /// </summary>

        public bool SendProcessMessage(cef_process_id_t target_process
        , CefProcessMessage message
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)target_process;
            v2.Ptr = message.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowser_SendProcessMessage_21, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }
    }


    // [virtual] class CefNavigationEntryVisitor
    /// <summary>
    /// Callback interface for CefBrowserHost::GetNavigationEntries. The methods of
    /// this class will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefNavigationEntryVisitor
    {
        const int _typeNAME = 3;
        const int CefNavigationEntryVisitor_Release_0 = (_typeNAME << 16) | 0;
        internal readonly IntPtr nativePtr;
        internal CefNavigationEntryVisitor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntryVisitor_Release_0, out ret);
        }
    }


    // [virtual] class CefBrowserHost
    /// <summary>
    /// Class used to represent the browser process aspects of a browser window. The
    /// methods of this class can only be called in the browser process. They may be
    /// called on any thread in that process unless otherwise indicated in the
    /// comments.
    /// /*(source=library)*/
    /// </summary>
    public struct CefBrowserHost
    {
        const int _typeNAME = 4;
        const int CefBrowserHost_Release_0 = (_typeNAME << 16) | 0;
        const int CefBrowserHost_GetBrowser_1 = (_typeNAME << 16) | 1;
        const int CefBrowserHost_CloseBrowser_2 = (_typeNAME << 16) | 2;
        const int CefBrowserHost_TryCloseBrowser_3 = (_typeNAME << 16) | 3;
        const int CefBrowserHost_SetFocus_4 = (_typeNAME << 16) | 4;
        const int CefBrowserHost_GetWindowHandle_5 = (_typeNAME << 16) | 5;
        const int CefBrowserHost_GetOpenerWindowHandle_6 = (_typeNAME << 16) | 6;
        const int CefBrowserHost_HasView_7 = (_typeNAME << 16) | 7;
        const int CefBrowserHost_GetClient_8 = (_typeNAME << 16) | 8;
        const int CefBrowserHost_GetRequestContext_9 = (_typeNAME << 16) | 9;
        const int CefBrowserHost_GetZoomLevel_10 = (_typeNAME << 16) | 10;
        const int CefBrowserHost_SetZoomLevel_11 = (_typeNAME << 16) | 11;
        const int CefBrowserHost_RunFileDialog_12 = (_typeNAME << 16) | 12;
        const int CefBrowserHost_StartDownload_13 = (_typeNAME << 16) | 13;
        const int CefBrowserHost_DownloadImage_14 = (_typeNAME << 16) | 14;
        const int CefBrowserHost_Print_15 = (_typeNAME << 16) | 15;
        const int CefBrowserHost_PrintToPDF_16 = (_typeNAME << 16) | 16;
        const int CefBrowserHost_Find_17 = (_typeNAME << 16) | 17;
        const int CefBrowserHost_StopFinding_18 = (_typeNAME << 16) | 18;
        const int CefBrowserHost_ShowDevTools_19 = (_typeNAME << 16) | 19;
        const int CefBrowserHost_CloseDevTools_20 = (_typeNAME << 16) | 20;
        const int CefBrowserHost_HasDevTools_21 = (_typeNAME << 16) | 21;
        const int CefBrowserHost_GetNavigationEntries_22 = (_typeNAME << 16) | 22;
        const int CefBrowserHost_SetMouseCursorChangeDisabled_23 = (_typeNAME << 16) | 23;
        const int CefBrowserHost_IsMouseCursorChangeDisabled_24 = (_typeNAME << 16) | 24;
        const int CefBrowserHost_ReplaceMisspelling_25 = (_typeNAME << 16) | 25;
        const int CefBrowserHost_AddWordToDictionary_26 = (_typeNAME << 16) | 26;
        const int CefBrowserHost_IsWindowRenderingDisabled_27 = (_typeNAME << 16) | 27;
        const int CefBrowserHost_WasResized_28 = (_typeNAME << 16) | 28;
        const int CefBrowserHost_WasHidden_29 = (_typeNAME << 16) | 29;
        const int CefBrowserHost_NotifyScreenInfoChanged_30 = (_typeNAME << 16) | 30;
        const int CefBrowserHost_Invalidate_31 = (_typeNAME << 16) | 31;
        const int CefBrowserHost_SendKeyEvent_32 = (_typeNAME << 16) | 32;
        const int CefBrowserHost_SendMouseClickEvent_33 = (_typeNAME << 16) | 33;
        const int CefBrowserHost_SendMouseMoveEvent_34 = (_typeNAME << 16) | 34;
        const int CefBrowserHost_SendMouseWheelEvent_35 = (_typeNAME << 16) | 35;
        const int CefBrowserHost_SendFocusEvent_36 = (_typeNAME << 16) | 36;
        const int CefBrowserHost_SendCaptureLostEvent_37 = (_typeNAME << 16) | 37;
        const int CefBrowserHost_NotifyMoveOrResizeStarted_38 = (_typeNAME << 16) | 38;
        const int CefBrowserHost_GetWindowlessFrameRate_39 = (_typeNAME << 16) | 39;
        const int CefBrowserHost_SetWindowlessFrameRate_40 = (_typeNAME << 16) | 40;
        const int CefBrowserHost_ImeSetComposition_41 = (_typeNAME << 16) | 41;
        const int CefBrowserHost_ImeCommitText_42 = (_typeNAME << 16) | 42;
        const int CefBrowserHost_ImeFinishComposingText_43 = (_typeNAME << 16) | 43;
        const int CefBrowserHost_ImeCancelComposition_44 = (_typeNAME << 16) | 44;
        const int CefBrowserHost_DragTargetDragEnter_45 = (_typeNAME << 16) | 45;
        const int CefBrowserHost_DragTargetDragOver_46 = (_typeNAME << 16) | 46;
        const int CefBrowserHost_DragTargetDragLeave_47 = (_typeNAME << 16) | 47;
        const int CefBrowserHost_DragTargetDrop_48 = (_typeNAME << 16) | 48;
        const int CefBrowserHost_DragSourceEndedAt_49 = (_typeNAME << 16) | 49;
        const int CefBrowserHost_DragSourceSystemDragEnded_50 = (_typeNAME << 16) | 50;
        const int CefBrowserHost_GetVisibleNavigationEntry_51 = (_typeNAME << 16) | 51;
        const int CefBrowserHost_SetAccessibilityState_52 = (_typeNAME << 16) | 52;
        internal readonly IntPtr nativePtr;
        internal CefBrowserHost(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_Release_0, out ret);
        }

        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /// <summary>
        /// CefBrowserHost methods.
        /// </summary>

        public CefBrowser GetBrowser()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetBrowser_1, out ret);
            var ret_result = new CefBrowser(ret.Ptr);
            return ret_result;
        }

        // gen! void CloseBrowser(bool force_close)
        /// <summary>
        /// Request that the browser close. The JavaScript 'onbeforeunload' event will
        /// be fired. If |force_close| is false the event handler, if any, will be
        /// allowed to prompt the user and the user can optionally cancel the close.
        /// If |force_close| is true the prompt will not be displayed and the close
        /// will proceed. Results in a call to CefLifeSpanHandler::DoClose() if the
        /// event handler allows the close or if |force_close| is true. See
        /// CefLifeSpanHandler::DoClose() documentation for additional usage
        /// information.
        /// /*cef()*/
        /// </summary>

        public void CloseBrowser(bool force_close
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = force_close ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_CloseBrowser_2, out ret, ref v1);

        }

        // gen! bool TryCloseBrowser()
        /// <summary>
        /// Helper for closing a browser. Call this method from the top-level window
        /// close handler. Internally this calls CloseBrowser(false) if the close has
        /// not yet been initiated. This method returns false while the close is
        /// pending and true after the close has completed. See CloseBrowser() and
        /// CefLifeSpanHandler::DoClose() documentation for additional usage
        /// information. This method must be called on the browser process UI thread.
        /// /*cef()*/
        /// </summary>

        public bool TryCloseBrowser()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_TryCloseBrowser_3, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void SetFocus(bool focus)
        /// <summary>
        /// Set whether the browser is focused.
        /// /*cef()*/
        /// </summary>

        public void SetFocus(bool focus
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = focus ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetFocus_4, out ret, ref v1);

        }

        // gen! CefWindowHandle GetWindowHandle()
        /// <summary>
        /// Retrieve the window handle for this browser. If this browser is wrapped in
        /// a CefBrowserView this method should be called on the browser process UI
        /// thread and it will return the handle for the top-level native window.
        /// /*cef()*/
        /// </summary>

        public IntPtr GetWindowHandle()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetWindowHandle_5, out ret);
            IntPtr ret_result = ret.Ptr;
            return ret_result;
        }

        // gen! CefWindowHandle GetOpenerWindowHandle()
        /// <summary>
        /// Retrieve the window handle of the browser that opened this browser. Will
        /// return NULL for non-popup windows or if this browser is wrapped in a
        /// CefBrowserView. This method can be used in combination with custom handling
        /// of modal windows.
        /// /*cef()*/
        /// </summary>

        public IntPtr GetOpenerWindowHandle()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetOpenerWindowHandle_6, out ret);
            IntPtr ret_result = ret.Ptr;
            return ret_result;
        }

        // gen! bool HasView()
        /// <summary>
        /// Returns true if this browser is wrapped in a CefBrowserView.
        /// /*cef()*/
        /// </summary>

        public bool HasView()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_HasView_7, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefClient> GetClient()
        /// <summary>
        /// Returns the client for this browser.
        /// /*cef()*/
        /// </summary>

        public CefClient GetClient()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetClient_8, out ret);
            var ret_result = new CefClient(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefRequestContext> GetRequestContext()
        /// <summary>
        /// Returns the request context for this browser.
        /// /*cef()*/
        /// </summary>

        public CefRequestContext GetRequestContext()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetRequestContext_9, out ret);
            var ret_result = new CefRequestContext(ret.Ptr);
            return ret_result;
        }

        // gen! double GetZoomLevel()
        /// <summary>
        /// Get the current zoom level. The default zoom level is 0.0. This method can
        /// only be called on the UI thread.
        /// /*cef()*/
        /// </summary>

        public double GetZoomLevel()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetZoomLevel_10, out ret);
            var ret_result = ret.Num;
            return ret_result;
        }

        // gen! void SetZoomLevel(double zoomLevel)
        /// <summary>
        /// Change the zoom level to the specified value. Specify 0.0 to reset the
        /// zoom level. If called on the UI thread the change will be applied
        /// immediately. Otherwise, the change will be applied asynchronously on the
        /// UI thread.
        /// /*cef()*/
        /// </summary>

        public void SetZoomLevel(double zoomLevel
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Num = zoomLevel;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetZoomLevel_11, out ret, ref v1);

        }

        // gen! void RunFileDialog(FileDialogMode mode,const CefString& title,const CefString& default_file_path,const std::vector<CefString>& accept_filters,int selected_accept_filter,CefRefPtr<CefRunFileDialogCallback> callback)
        /// <summary>
        /// Call to run a file chooser dialog. Only a single file chooser dialog may be
        /// pending at any given time. |mode| represents the type of dialog to display.
        /// |title| to the title to be used for the dialog and may be empty to show the
        /// default title ("Open" or "Save" depending on the mode). |default_file_path|
        /// is the path with optional directory and/or file name component that will be
        /// initially selected in the dialog. |accept_filters| are used to restrict the
        /// selectable file types and may any combination of (a) valid lower-cased MIME
        /// types (e.g. "text/*" or "image/*"), (b) individual file extensions (e.g.
        /// ".txt" or ".png"), or (c) combined description and file extension delimited
        /// using "|" and ";" (e.g. "Image Types|.png;.gif;.jpg").
        /// |selected_accept_filter| is the 0-based index of the filter that will be
        /// selected by default. |callback| will be executed after the dialog is
        /// dismissed or immediately if another dialog is already pending. The dialog
        /// will be initiated asynchronously on the UI thread.
        /// /*cef(optional_param=title,optional_param=default_file_path,optional_param=accept_filters,index_param=selected_accept_filter)*/
        /// </summary>

        public void RunFileDialog(cef_file_dialog_mode_t mode
        , string title
        , string default_file_path
        , List<string> accept_filters
        , int selected_accept_filter
        , CefRunFileDialogCallback callback
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue v6 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(title);
            ;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(default_file_path);
            ;
            v1.I32 = (int)mode;
            v4.Ptr = Cef3Binder.CreateStdList(2);
            v5.I32 = (int)selected_accept_filter;
            v6.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call6(this.nativePtr, CefBrowserHost_RunFileDialog_12, out ret, ref v1, ref v2, ref v3, ref v4, ref v5, ref v6);

            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            Cef3Binder.MyCefDeletePtr(v3.Ptr); ;
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v4.Ptr, accept_filters);
        }

        // gen! void StartDownload(const CefString& url)
        /// <summary>
        /// Download the file at |url| using CefDownloadHandler.
        /// /*cef()*/
        /// </summary>

        public void StartDownload(string url
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_StartDownload_13, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void DownloadImage(const CefString& image_url,bool is_favicon,uint32 max_image_size,bool bypass_cache,CefRefPtr<CefDownloadImageCallback> callback)
        /// <summary>
        /// Download |image_url| and execute |callback| on completion with the images
        /// received from the renderer. If |is_favicon| is true then cookies are not
        /// sent and not accepted during download. Images with density independent
        /// pixel (DIP) sizes larger than |max_image_size| are filtered out from the
        /// image results. Versions of the image at different scale factors may be
        /// downloaded up to the maximum scale factor supported by the system. If there
        /// are no image results <= |max_image_size| then the smallest image is resized
        /// to |max_image_size| and is the only result. A |max_image_size| of 0 means
        /// unlimited. If |bypass_cache| is true then |image_url| is requested from the
        /// server even if it is present in the browser cache.
        /// /*cef()*/
        /// </summary>

        public void DownloadImage(string image_url
        , bool is_favicon
        , uint max_image_size
        , bool bypass_cache
        , CefDownloadImageCallback callback
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(image_url);
            ;
            v2.I32 = is_favicon ? 1 : 0;
            v3.I32 = (int)max_image_size;
            v4.I32 = bypass_cache ? 1 : 0;
            v5.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefBrowserHost_DownloadImage_14, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void Print()
        /// <summary>
        /// Print the current browser contents.
        /// /*cef()*/
        /// </summary>

        public void Print()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_Print_15, out ret);

        }

        // gen! void PrintToPDF(const CefString& path,const CefPdfPrintSettings& settings,CefRefPtr<CefPdfPrintCallback> callback)
        /// <summary>
        /// Print the current browser contents to the PDF file specified by |path| and
        /// execute |callback| on completion. The caller is responsible for deleting
        /// |path| when done. For PDF printing to work on Linux you must implement the
        /// CefPrintHandler::GetPdfPaperSize method.
        /// /*cef(optional_param=callback)*/
        /// </summary>

        public void PrintToPDF(string path
        , CefPdfPrintSettings settings
        , CefPdfPrintCallback callback
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(path);
            ;
            v2.Ptr = settings.nativePtr;
            v3.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_PrintToPDF_16, out ret, ref v1, ref v2, ref v3);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void Find(int identifier,const CefString& searchText,bool forward,bool matchCase,bool findNext)
        /// <summary>
        /// Search for |searchText|. |identifier| must be a unique ID and these IDs
        /// must strictly increase so that newer requests always have greater IDs than
        /// older requests. If |identifier| is zero or less than the previous ID value
        /// then it will be automatically assigned a new valid ID. |forward| indicates
        /// whether to search forward or backward within the page. |matchCase|
        /// indicates whether the search should be case-sensitive. |findNext| indicates
        /// whether this is the first request or a follow-up. The CefFindHandler
        /// instance, if any, returned via CefClient::GetFindHandler will be called to
        /// report find results.
        /// /*cef()*/
        /// </summary>

        public void Find(int identifier
        , string searchText
        , bool forward
        , bool matchCase
        , bool findNext
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(searchText);
            ;
            v1.I32 = (int)identifier;
            v3.I32 = forward ? 1 : 0;
            v4.I32 = matchCase ? 1 : 0;
            v5.I32 = findNext ? 1 : 0;

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefBrowserHost_Find_17, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);

            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
        }

        // gen! void StopFinding(bool clearSelection)
        /// <summary>
        /// Cancel all searches that are currently going on.
        /// /*cef()*/
        /// </summary>

        public void StopFinding(bool clearSelection
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = clearSelection ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_StopFinding_18, out ret, ref v1);

        }

        // gen! void ShowDevTools(const CefWindowInfo& windowInfo,CefRefPtr<CefClient> client,const CefBrowserSettings& settings,const CefPoint& inspect_element_at)
        /// <summary>
        /// Open developer tools (DevTools) in its own browser. The DevTools browser
        /// will remain associated with this browser. If the DevTools browser is
        /// already open then it will be focused, in which case the |windowInfo|,
        /// |client| and |settings| parameters will be ignored. If |inspect_element_at|
        /// is non-empty then the element at the specified (x,y) location will be
        /// inspected. The |windowInfo| parameter will be ignored if this browser is
        /// wrapped in a CefBrowserView.
        /// /*cef(optional_param=windowInfo,optional_param=client,optional_param=settings,optional_param=inspect_element_at)*/
        /// </summary>

        public void ShowDevTools(CefWindowInfo windowInfo
        , CefClient client
        , CefBrowserSettings settings
        , CefPoint inspect_element_at
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = windowInfo.nativePtr;
            v2.Ptr = client.nativePtr;
            v3.Ptr = settings.nativePtr;
            v4.Ptr = inspect_element_at.nativePtr;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_ShowDevTools_19, out ret, ref v1, ref v2, ref v3, ref v4);

        }

        // gen! void CloseDevTools()
        /// <summary>
        /// Explicitly close the associated DevTools browser, if any.
        /// /*cef()*/
        /// </summary>

        public void CloseDevTools()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_CloseDevTools_20, out ret);

        }

        // gen! bool HasDevTools()
        /// <summary>
        /// Returns true if this browser currently has an associated DevTools browser.
        /// Must be called on the browser process UI thread.
        /// /*cef()*/
        /// </summary>

        public bool HasDevTools()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_HasDevTools_21, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void GetNavigationEntries(CefRefPtr<CefNavigationEntryVisitor> visitor,bool current_only)
        /// <summary>
        /// Retrieve a snapshot of current navigation entries as values sent to the
        /// specified visitor. If |current_only| is true only the current navigation
        /// entry will be sent, otherwise all navigation entries will be sent.
        /// /*cef()*/
        /// </summary>

        public void GetNavigationEntries(CefNavigationEntryVisitor visitor
        , bool current_only
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr;
            v2.I32 = current_only ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_GetNavigationEntries_22, out ret, ref v1, ref v2);

        }

        // gen! void SetMouseCursorChangeDisabled(bool disabled)
        /// <summary>
        /// Set whether mouse cursor change is disabled.
        /// /*cef()*/
        /// </summary>

        public void SetMouseCursorChangeDisabled(bool disabled
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = disabled ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetMouseCursorChangeDisabled_23, out ret, ref v1);

        }

        // gen! bool IsMouseCursorChangeDisabled()
        /// <summary>
        /// Returns true if mouse cursor change is disabled.
        /// /*cef()*/
        /// </summary>

        public bool IsMouseCursorChangeDisabled()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_IsMouseCursorChangeDisabled_24, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void ReplaceMisspelling(const CefString& word)
        /// <summary>
        /// If a misspelled word is currently selected in an editable node calling
        /// this method will replace it with the specified |word|.
        /// /*cef()*/
        /// </summary>

        public void ReplaceMisspelling(string word
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(word);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_ReplaceMisspelling_25, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void AddWordToDictionary(const CefString& word)
        /// <summary>
        /// Add the specified |word| to the spelling dictionary.
        /// /*cef()*/
        /// </summary>

        public void AddWordToDictionary(string word
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(word);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_AddWordToDictionary_26, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! bool IsWindowRenderingDisabled()
        /// <summary>
        /// Returns true if window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public bool IsWindowRenderingDisabled()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_IsWindowRenderingDisabled_27, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void WasResized()
        /// <summary>
        /// Notify the browser that the widget has been resized. The browser will first
        /// call CefRenderHandler::GetViewRect to get the new size and then call
        /// CefRenderHandler::OnPaint asynchronously with the updated regions. This
        /// method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void WasResized()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_WasResized_28, out ret);

        }

        // gen! void WasHidden(bool hidden)
        /// <summary>
        /// Notify the browser that it has been hidden or shown. Layouting and
        /// CefRenderHandler::OnPaint notification will stop when the browser is
        /// hidden. This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void WasHidden(bool hidden
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = hidden ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_WasHidden_29, out ret, ref v1);

        }

        // gen! void NotifyScreenInfoChanged()
        /// <summary>
        /// Send a notification to the browser that the screen info has changed. The
        /// browser will then call CefRenderHandler::GetScreenInfo to update the
        /// screen information with the new values. This simulates moving the webview
        /// window from one display to another, or changing the properties of the
        /// current display. This method is only used when window rendering is
        /// disabled.
        /// /*cef()*/
        /// </summary>

        public void NotifyScreenInfoChanged()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_NotifyScreenInfoChanged_30, out ret);

        }

        // gen! void Invalidate(PaintElementType type)
        /// <summary>
        /// Invalidate the view. The browser will call CefRenderHandler::OnPaint
        /// asynchronously. This method is only used when window rendering is
        /// disabled.
        /// /*cef()*/
        /// </summary>

        public void Invalidate(cef_paint_element_type_t type
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)type;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_Invalidate_31, out ret, ref v1);

        }

        // gen! void SendKeyEvent(const CefKeyEvent& event)
        /// <summary>
        /// Send a key event to the browser.
        /// /*cef()*/
        /// </summary>

        public void SendKeyEvent(CefKeyEvent _event
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SendKeyEvent_32, out ret, ref v1);

        }

        // gen! void SendMouseClickEvent(const CefMouseEvent& event,MouseButtonType type,bool mouseUp,int clickCount)
        /// <summary>
        /// Send a mouse click event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view.
        /// /*cef()*/
        /// </summary>

        public void SendMouseClickEvent(CefMouseEvent _event
        , cef_mouse_button_type_t type
        , bool mouseUp
        , int clickCount
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr;
            v2.I32 = (int)type;
            v3.I32 = mouseUp ? 1 : 0;
            v4.I32 = (int)clickCount;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_SendMouseClickEvent_33, out ret, ref v1, ref v2, ref v3, ref v4);

        }

        // gen! void SendMouseMoveEvent(const CefMouseEvent& event,bool mouseLeave)
        /// <summary>
        /// Send a mouse move event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view.
        /// /*cef()*/
        /// </summary>

        public void SendMouseMoveEvent(CefMouseEvent _event
        , bool mouseLeave
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr;
            v2.I32 = mouseLeave ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_SendMouseMoveEvent_34, out ret, ref v1, ref v2);

        }

        // gen! void SendMouseWheelEvent(const CefMouseEvent& event,int deltaX,int deltaY)
        /// <summary>
        /// Send a mouse wheel event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view. The |deltaX| and |deltaY|
        /// values represent the movement delta in the X and Y directions respectively.
        /// In order to scroll inside select popups with window rendering disabled
        /// CefRenderHandler::GetScreenPoint should be implemented properly.
        /// /*cef()*/
        /// </summary>

        public void SendMouseWheelEvent(CefMouseEvent _event
        , int deltaX
        , int deltaY
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr;
            v2.I32 = (int)deltaX;
            v3.I32 = (int)deltaY;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_SendMouseWheelEvent_35, out ret, ref v1, ref v2, ref v3);

        }

        // gen! void SendFocusEvent(bool setFocus)
        /// <summary>
        /// Send a focus event to the browser.
        /// /*cef()*/
        /// </summary>

        public void SendFocusEvent(bool setFocus
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = setFocus ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SendFocusEvent_36, out ret, ref v1);

        }

        // gen! void SendCaptureLostEvent()
        /// <summary>
        /// Send a capture lost event to the browser.
        /// /*cef()*/
        /// </summary>

        public void SendCaptureLostEvent()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_SendCaptureLostEvent_37, out ret);

        }

        // gen! void NotifyMoveOrResizeStarted()
        /// <summary>
        /// Notify the browser that the window hosting it is about to be moved or
        /// resized. This method is only used on Windows and Linux.
        /// /*cef()*/
        /// </summary>

        public void NotifyMoveOrResizeStarted()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_NotifyMoveOrResizeStarted_38, out ret);

        }

        // gen! int GetWindowlessFrameRate()
        /// <summary>
        /// Returns the maximum rate in frames per second (fps) that CefRenderHandler::
        /// OnPaint will be called for a windowless browser. The actual fps may be
        /// lower if the browser cannot generate frames at the requested rate. The
        /// minimum value is 1 and the maximum value is 60 (default 30). This method
        /// can only be called on the UI thread.
        /// /*cef()*/
        /// </summary>

        public int GetWindowlessFrameRate()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetWindowlessFrameRate_39, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! void SetWindowlessFrameRate(int frame_rate)
        /// <summary>
        /// Set the maximum rate in frames per second (fps) that CefRenderHandler::
        /// OnPaint will be called for a windowless browser. The actual fps may be
        /// lower if the browser cannot generate frames at the requested rate. The
        /// minimum value is 1 and the maximum value is 60 (default 30). Can also be
        /// set at browser creation via CefBrowserSettings.windowless_frame_rate.
        /// /*cef()*/
        /// </summary>

        public void SetWindowlessFrameRate(int frame_rate
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)frame_rate;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetWindowlessFrameRate_40, out ret, ref v1);

        }

        // gen! void ImeSetComposition(const CefString& text,const std::vector<CefCompositionUnderline>& underlines,const CefRange& replacement_range,const CefRange& selection_range)
        /// <summary>
        /// Begins a new composition or updates the existing composition. Blink has a
        /// special node (a composition node) that allows the input method to change
        /// text without affecting other DOM nodes. |text| is the optional text that
        /// will be inserted into the composition node. |underlines| is an optional set
        /// of ranges that will be underlined in the resulting text.
        /// |replacement_range| is an optional range of the existing text that will be
        /// replaced. |selection_range| is an optional range of the resulting text that
        /// will be selected after insertion or replacement. The |replacement_range|
        /// value is only used on OS X.
        ///
        /// This method may be called multiple times as the composition changes. When
        /// the client is done making changes the composition should either be canceled
        /// or completed. To cancel the composition call ImeCancelComposition. To
        /// complete the composition call either ImeCommitText or
        /// ImeFinishComposingText. Completion is usually signaled when:
        ///   A. The client receives a WM_IME_COMPOSITION message with a GCS_RESULTSTR
        ///      flag (on Windows), or;
        ///   B. The client receives a "commit" signal of GtkIMContext (on Linux), or;
        ///   C. insertText of NSTextInput is called (on Mac).
        ///
        /// This method is only used when window rendering is disabled.
        /// /*cef(optional_param=text,optional_param=underlines)*/
        /// </summary>

        public void ImeSetComposition(string text
        , List<CefCompositionUnderline> underlines
        , CefRange replacement_range
        , CefRange selection_range
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(text);
            ;
            v2.Ptr = Cef3Binder.CreateStdList(3);
            v3.Ptr = replacement_range.nativePtr;
            v4.Ptr = selection_range.nativePtr;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_ImeSetComposition_41, out ret, ref v1, ref v2, ref v3, ref v4);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void ImeCommitText(const CefString& text,const CefRange& replacement_range,int relative_cursor_pos)
        /// <summary>
        /// Completes the existing composition by optionally inserting the specified
        /// |text| into the composition node. |replacement_range| is an optional range
        /// of the existing text that will be replaced. |relative_cursor_pos| is where
        /// the cursor will be positioned relative to the current cursor position. See
        /// comments on ImeSetComposition for usage. The |replacement_range| and
        /// |relative_cursor_pos| values are only used on OS X.
        /// This method is only used when window rendering is disabled.
        /// /*cef(optional_param=text)*/
        /// </summary>

        public void ImeCommitText(string text
        , CefRange replacement_range
        , int relative_cursor_pos
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(text);
            ;
            v2.Ptr = replacement_range.nativePtr;
            v3.I32 = (int)relative_cursor_pos;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_ImeCommitText_42, out ret, ref v1, ref v2, ref v3);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void ImeFinishComposingText(bool keep_selection)
        /// <summary>
        /// Completes the existing composition by applying the current composition node
        /// contents. If |keep_selection| is false the current selection, if any, will
        /// be discarded. See comments on ImeSetComposition for usage.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void ImeFinishComposingText(bool keep_selection
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = keep_selection ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_ImeFinishComposingText_43, out ret, ref v1);

        }

        // gen! void ImeCancelComposition()
        /// <summary>
        /// Cancels the existing composition and discards the composition node
        /// contents without applying them. See comments on ImeSetComposition for
        /// usage.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void ImeCancelComposition()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_ImeCancelComposition_44, out ret);

        }

        // gen! void DragTargetDragEnter(CefRefPtr<CefDragData> drag_data,const CefMouseEvent& event,DragOperationsMask allowed_ops)
        /// <summary>
        /// Call this method when the user drags the mouse into the web view (before
        /// calling DragTargetDragOver/DragTargetLeave/DragTargetDrop).
        /// |drag_data| should not contain file contents as this type of data is not
        /// allowed to be dragged into the web view. File contents can be removed using
        /// CefDragData::ResetFileContents (for example, if |drag_data| comes from
        /// CefRenderHandler::StartDragging).
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void DragTargetDragEnter(CefDragData drag_data
        , CefMouseEvent _event
        , cef_drag_operations_mask_t allowed_ops
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = drag_data.nativePtr;
            v2.Ptr = _event.nativePtr;
            v3.I32 = (int)allowed_ops;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_DragTargetDragEnter_45, out ret, ref v1, ref v2, ref v3);

        }

        // gen! void DragTargetDragOver(const CefMouseEvent& event,DragOperationsMask allowed_ops)
        /// <summary>
        /// Call this method each time the mouse is moved across the web view during
        /// a drag operation (after calling DragTargetDragEnter and before calling
        /// DragTargetDragLeave/DragTargetDrop).
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void DragTargetDragOver(CefMouseEvent _event
        , cef_drag_operations_mask_t allowed_ops
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr;
            v2.I32 = (int)allowed_ops;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_DragTargetDragOver_46, out ret, ref v1, ref v2);

        }

        // gen! void DragTargetDragLeave()
        /// <summary>
        /// Call this method when the user drags the mouse out of the web view (after
        /// calling DragTargetDragEnter).
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void DragTargetDragLeave()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_DragTargetDragLeave_47, out ret);

        }

        // gen! void DragTargetDrop(const CefMouseEvent& event)
        /// <summary>
        /// Call this method when the user completes the drag operation by dropping
        /// the object onto the web view (after calling DragTargetDragEnter).
        /// The object being dropped is |drag_data|, given as an argument to
        /// the previous DragTargetDragEnter call.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void DragTargetDrop(CefMouseEvent _event
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_DragTargetDrop_48, out ret, ref v1);

        }

        // gen! void DragSourceEndedAt(int x,int y,DragOperationsMask op)
        /// <summary>
        /// Call this method when the drag operation started by a
        /// CefRenderHandler::StartDragging call has ended either in a drop or
        /// by being cancelled. |x| and |y| are mouse coordinates relative to the
        /// upper-left corner of the view. If the web view is both the drag source
        /// and the drag target then all DragTarget* methods should be called before
        /// DragSource* mthods.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void DragSourceEndedAt(int x
        , int y
        , cef_drag_operations_mask_t op
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)x;
            v2.I32 = (int)y;
            v3.I32 = (int)op;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_DragSourceEndedAt_49, out ret, ref v1, ref v2, ref v3);

        }

        // gen! void DragSourceSystemDragEnded()
        /// <summary>
        /// Call this method when the drag operation started by a
        /// CefRenderHandler::StartDragging call has completed. This method may be
        /// called immediately without first calling DragSourceEndedAt to cancel a
        /// drag operation. If the web view is both the drag source and the drag
        /// target then all DragTarget* methods should be called before DragSource*
        /// mthods.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>

        public void DragSourceSystemDragEnded()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_DragSourceSystemDragEnded_50, out ret);

        }

        // gen! CefRefPtr<CefNavigationEntry> GetVisibleNavigationEntry()
        /// <summary>
        /// Returns the current visible navigation entry for this browser. This method
        /// can only be called on the UI thread.
        /// /*cef()*/
        /// </summary>

        public CefNavigationEntry GetVisibleNavigationEntry()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetVisibleNavigationEntry_51, out ret);
            var ret_result = new CefNavigationEntry(ret.Ptr);
            return ret_result;
        }

        // gen! void SetAccessibilityState(cef_state_t accessibility_state)
        /// <summary>
        /// Set accessibility state for all frames. |accessibility_state| may be
        /// default, enabled or disabled. If |accessibility_state| is STATE_DEFAULT
        /// then accessibility will be disabled by default and the state may be further
        /// controlled with the "force-renderer-accessibility" and
        /// "disable-renderer-accessibility" command-line switches. If
        /// |accessibility_state| is STATE_ENABLED then accessibility will be enabled.
        /// If |accessibility_state| is STATE_DISABLED then accessibility will be
        /// completely disabled.
        ///
        /// For windowed browsers accessibility will be enabled in Complete mode (which
        /// corresponds to kAccessibilityModeComplete in Chromium). In this mode all
        /// platform accessibility objects will be created and managed by Chromium's
        /// internal implementation. The client needs only to detect the screen reader
        /// and call this method appropriately. For example, on macOS the client can
        /// handle the @"AXEnhancedUserInterface" accessibility attribute to detect
        /// VoiceOver state changes and on Windows the client can handle WM_GETOBJECT
        /// with OBJID_CLIENT to detect accessibility readers.
        ///
        /// For windowless browsers accessibility will be enabled in TreeOnly mode
        /// (which corresponds to kAccessibilityModeWebContentsOnly in Chromium). In
        /// this mode renderer accessibility is enabled, the full tree is computed, and
        /// events are passed to CefAccessibiltyHandler, but platform accessibility
        /// objects are not created. The client may implement platform accessibility
        /// objects using CefAccessibiltyHandler callbacks if desired.
        /// /*cef()*/
        /// </summary>

        public void SetAccessibilityState(cef_state_t accessibility_state
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)accessibility_state;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetAccessibilityState_52, out ret, ref v1);

        }
    }


    // [virtual] class CefClient
    /// <summary>
    /// Implement this interface to provide handler implementations.
    /// /*(source=client,no_debugct_check)*/
    /// </summary>
    public struct CefClient
    {
        const int _typeNAME = 5;
        const int CefClient_Release_0 = (_typeNAME << 16) | 0;
        internal readonly IntPtr nativePtr;
        internal CefClient(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefClient_Release_0, out ret);
        }
    }


    // [virtual] class CefCommandLine
    /// <summary>
    /// Class used to create and/or parse command line arguments. Arguments with
    /// '--', '-' and, on Windows, '/' prefixes are considered switches. Switches
    /// will always precede any arguments without switch prefixes. Switches can
    /// optionally have a value specified using the '=' delimiter (e.g.
    /// "-switch=value"). An argument of "--" will terminate switch parsing with all
    /// subsequent tokens, regardless of prefix, being interpreted as non-switch
    /// arguments. Switch names are considered case-insensitive. This class can be
    /// used before CefInitialize() is called.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefCommandLine
    {
        const int _typeNAME = 6;
        const int CefCommandLine_Release_0 = (_typeNAME << 16) | 0;
        const int CefCommandLine_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefCommandLine_IsReadOnly_2 = (_typeNAME << 16) | 2;
        const int CefCommandLine_Copy_3 = (_typeNAME << 16) | 3;
        const int CefCommandLine_InitFromArgv_4 = (_typeNAME << 16) | 4;
        const int CefCommandLine_InitFromString_5 = (_typeNAME << 16) | 5;
        const int CefCommandLine_Reset_6 = (_typeNAME << 16) | 6;
        const int CefCommandLine_GetArgv_7 = (_typeNAME << 16) | 7;
        const int CefCommandLine_GetCommandLineString_8 = (_typeNAME << 16) | 8;
        const int CefCommandLine_GetProgram_9 = (_typeNAME << 16) | 9;
        const int CefCommandLine_SetProgram_10 = (_typeNAME << 16) | 10;
        const int CefCommandLine_HasSwitches_11 = (_typeNAME << 16) | 11;
        const int CefCommandLine_HasSwitch_12 = (_typeNAME << 16) | 12;
        const int CefCommandLine_GetSwitchValue_13 = (_typeNAME << 16) | 13;
        const int CefCommandLine_GetSwitches_14 = (_typeNAME << 16) | 14;
        const int CefCommandLine_AppendSwitch_15 = (_typeNAME << 16) | 15;
        const int CefCommandLine_AppendSwitchWithValue_16 = (_typeNAME << 16) | 16;
        const int CefCommandLine_HasArguments_17 = (_typeNAME << 16) | 17;
        const int CefCommandLine_GetArguments_18 = (_typeNAME << 16) | 18;
        const int CefCommandLine_AppendArgument_19 = (_typeNAME << 16) | 19;
        const int CefCommandLine_PrependWrapper_20 = (_typeNAME << 16) | 20;
        internal readonly IntPtr nativePtr;
        internal CefCommandLine(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Release_0, out ret);
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefCommandLine methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_IsValid_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_IsReadOnly_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefCommandLine> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>

        public CefCommandLine Copy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Copy_3, out ret);
            var ret_result = new CefCommandLine(ret.Ptr);
            return ret_result;
        }

        // gen! void InitFromArgv(int argc,const char* const* argv)
        /// <summary>
        /// Initialize the command line with the specified |argc| and |argv| values.
        /// The first argument must be the name of the program. This method is only
        /// supported on non-Windows platforms.
        /// /*cef()*/
        /// </summary>

        public void InitFromArgv(int argc
        , IntPtr argv
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)argc;
            v2.Ptr = argv;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCommandLine_InitFromArgv_4, out ret, ref v1, ref v2);

        }

        // gen! void InitFromString(const CefString& command_line)
        /// <summary>
        /// Initialize the command line with the string returned by calling
        /// GetCommandLineW(). This method is only supported on Windows.
        /// /*cef()*/
        /// </summary>

        public void InitFromString(string command_line
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(command_line);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_InitFromString_5, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void Reset()
        /// <summary>
        /// Reset the command-line switches and arguments but leave the program
        /// component unchanged.
        /// /*cef()*/
        /// </summary>

        public void Reset()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Reset_6, out ret);

        }

        // gen! void GetArgv(std::vector<CefString>& argv)
        /// <summary>
        /// Retrieve the original command line string as a vector of strings.
        /// The argv array: { program, [(--|-|/)switch[=value]]*, [--], [argument]* }
        /// /*cef()*/
        /// </summary>

        public void GetArgv(List<string> argv
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetArgv_7, out ret, ref v1);

            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, argv);
        }

        // gen! CefString GetCommandLineString()
        /// <summary>
        /// Constructs and returns the represented command line string. Use this method
        /// cautiously because quoting behavior is unclear.
        /// /*cef()*/
        /// </summary>

        public string GetCommandLineString()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_GetCommandLineString_8, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetProgram()
        /// <summary>
        /// Get the program part of the command line string (the first item).
        /// /*cef()*/
        /// </summary>

        public string GetProgram()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_GetProgram_9, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! void SetProgram(const CefString& program)
        /// <summary>
        /// Set the program part of the command line string (the first item).
        /// /*cef()*/
        /// </summary>

        public void SetProgram(string program
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(program);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_SetProgram_10, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! bool HasSwitches()
        /// <summary>
        /// Returns true if the command line has switches.
        /// /*cef()*/
        /// </summary>

        public bool HasSwitches()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_HasSwitches_11, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool HasSwitch(const CefString& name)
        /// <summary>
        /// Returns true if the command line contains the given switch.
        /// /*cef()*/
        /// </summary>

        public bool HasSwitch(string name
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_HasSwitch_12, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! CefString GetSwitchValue(const CefString& name)
        /// <summary>
        /// Returns the value associated with the given switch. If the switch has no
        /// value or isn't present this method returns the empty string.
        /// /*cef()*/
        /// </summary>

        public string GetSwitchValue(string name
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetSwitchValue_13, out ret, ref v1);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! void GetSwitches(SwitchMap& switches)
        /// <summary>
        /// Returns the map of switch names and values. If a switch has no value an
        /// empty string is returned.
        /// /*cef()*/
        /// </summary>

        public void GetSwitches(SwitchMap switches
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = switches.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetSwitches_14, out ret, ref v1);

        }

        // gen! void AppendSwitch(const CefString& name)
        /// <summary>
        /// Add a switch to the end of the command line. If the switch has no value
        /// pass an empty value string.
        /// /*cef()*/
        /// </summary>

        public void AppendSwitch(string name
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_AppendSwitch_15, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void AppendSwitchWithValue(const CefString& name,const CefString& value)
        /// <summary>
        /// Add a switch with the specified value to the end of the command line.
        /// /*cef()*/
        /// </summary>

        public void AppendSwitchWithValue(string name
        , string value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            ;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCommandLine_AppendSwitchWithValue_16, out ret, ref v1, ref v2);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
        }

        // gen! bool HasArguments()
        /// <summary>
        /// True if there are remaining command line arguments.
        /// /*cef()*/
        /// </summary>

        public bool HasArguments()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_HasArguments_17, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void GetArguments(ArgumentList& arguments)
        /// <summary>
        /// Get the remaining command line arguments.
        /// /*cef()*/
        /// </summary>

        public void GetArguments(ArgumentList arguments
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = arguments.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetArguments_18, out ret, ref v1);

        }

        // gen! void AppendArgument(const CefString& argument)
        /// <summary>
        /// Add an argument to the end of the command line.
        /// /*cef()*/
        /// </summary>

        public void AppendArgument(string argument
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(argument);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_AppendArgument_19, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void PrependWrapper(const CefString& wrapper)
        /// <summary>
        /// Insert a command before the current command.
        /// Common for debuggers, like "valgrind" or "gdb --args".
        /// /*cef()*/
        /// </summary>

        public void PrependWrapper(string wrapper
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(wrapper);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_PrependWrapper_20, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }
    }


    // [virtual] class CefContextMenuParams
    /// <summary>
    /// Provides information about the context menu state. The ethods of this class
    /// can only be accessed on browser process the UI thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefContextMenuParams
    {
        const int _typeNAME = 7;
        const int CefContextMenuParams_Release_0 = (_typeNAME << 16) | 0;
        const int CefContextMenuParams_GetXCoord_1 = (_typeNAME << 16) | 1;
        const int CefContextMenuParams_GetYCoord_2 = (_typeNAME << 16) | 2;
        const int CefContextMenuParams_GetTypeFlags_3 = (_typeNAME << 16) | 3;
        const int CefContextMenuParams_GetLinkUrl_4 = (_typeNAME << 16) | 4;
        const int CefContextMenuParams_GetUnfilteredLinkUrl_5 = (_typeNAME << 16) | 5;
        const int CefContextMenuParams_GetSourceUrl_6 = (_typeNAME << 16) | 6;
        const int CefContextMenuParams_HasImageContents_7 = (_typeNAME << 16) | 7;
        const int CefContextMenuParams_GetTitleText_8 = (_typeNAME << 16) | 8;
        const int CefContextMenuParams_GetPageUrl_9 = (_typeNAME << 16) | 9;
        const int CefContextMenuParams_GetFrameUrl_10 = (_typeNAME << 16) | 10;
        const int CefContextMenuParams_GetFrameCharset_11 = (_typeNAME << 16) | 11;
        const int CefContextMenuParams_GetMediaType_12 = (_typeNAME << 16) | 12;
        const int CefContextMenuParams_GetMediaStateFlags_13 = (_typeNAME << 16) | 13;
        const int CefContextMenuParams_GetSelectionText_14 = (_typeNAME << 16) | 14;
        const int CefContextMenuParams_GetMisspelledWord_15 = (_typeNAME << 16) | 15;
        const int CefContextMenuParams_GetDictionarySuggestions_16 = (_typeNAME << 16) | 16;
        const int CefContextMenuParams_IsEditable_17 = (_typeNAME << 16) | 17;
        const int CefContextMenuParams_IsSpellCheckEnabled_18 = (_typeNAME << 16) | 18;
        const int CefContextMenuParams_GetEditStateFlags_19 = (_typeNAME << 16) | 19;
        const int CefContextMenuParams_IsCustomMenu_20 = (_typeNAME << 16) | 20;
        const int CefContextMenuParams_IsPepperMenu_21 = (_typeNAME << 16) | 21;
        internal readonly IntPtr nativePtr;
        internal CefContextMenuParams(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_Release_0, out ret);
        }

        // gen! int GetXCoord()
        /// <summary>
        /// CefContextMenuParams methods.
        /// </summary>

        public int GetXCoord()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetXCoord_1, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int GetYCoord()
        /// <summary>
        /// Returns the Y coordinate of the mouse where the context menu was invoked.
        /// Coords are relative to the associated RenderView's origin.
        /// /*cef()*/
        /// </summary>

        public int GetYCoord()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetYCoord_2, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! TypeFlags GetTypeFlags()
        /// <summary>
        /// Returns flags representing the type of node that the context menu was
        /// invoked on.
        /// /*cef(default_retval=CM_TYPEFLAG_NONE)*/
        /// </summary>

        public cef_context_menu_type_flags_t GetTypeFlags()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetTypeFlags_3, out ret);
            var ret_result = (cef_context_menu_type_flags_t)ret.I32;

            return ret_result;
        }

        // gen! CefString GetLinkUrl()
        /// <summary>
        /// Returns the URL of the link, if any, that encloses the node that the
        /// context menu was invoked on.
        /// /*cef()*/
        /// </summary>

        public string GetLinkUrl()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetLinkUrl_4, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetUnfilteredLinkUrl()
        /// <summary>
        /// Returns the link URL, if any, to be used ONLY for "copy link address". We
        /// don't validate this field in the frontend process.
        /// /*cef()*/
        /// </summary>

        public string GetUnfilteredLinkUrl()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetUnfilteredLinkUrl_5, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetSourceUrl()
        /// <summary>
        /// Returns the source URL, if any, for the element that the context menu was
        /// invoked on. Example of elements with source URLs are img, audio, and video.
        /// /*cef()*/
        /// </summary>

        public string GetSourceUrl()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetSourceUrl_6, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! bool HasImageContents()
        /// <summary>
        /// Returns true if the context menu was invoked on an image which has
        /// non-empty contents.
        /// /*cef()*/
        /// </summary>

        public bool HasImageContents()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_HasImageContents_7, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefString GetTitleText()
        /// <summary>
        /// Returns the title text or the alt text if the context menu was invoked on
        /// an image.
        /// /*cef()*/
        /// </summary>

        public string GetTitleText()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetTitleText_8, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetPageUrl()
        /// <summary>
        /// Returns the URL of the top level page that the context menu was invoked on.
        /// /*cef()*/
        /// </summary>

        public string GetPageUrl()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetPageUrl_9, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetFrameUrl()
        /// <summary>
        /// Returns the URL of the subframe that the context menu was invoked on.
        /// /*cef()*/
        /// </summary>

        public string GetFrameUrl()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetFrameUrl_10, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetFrameCharset()
        /// <summary>
        /// Returns the character encoding of the subframe that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>

        public string GetFrameCharset()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetFrameCharset_11, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! MediaType GetMediaType()
        /// <summary>
        /// Returns the type of context node that the context menu was invoked on.
        /// /*cef(default_retval=CM_MEDIATYPE_NONE)*/
        /// </summary>

        public cef_context_menu_media_type_t GetMediaType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMediaType_12, out ret);
            var ret_result = (cef_context_menu_media_type_t)ret.I32;

            return ret_result;
        }

        // gen! MediaStateFlags GetMediaStateFlags()
        /// <summary>
        /// Returns flags representing the actions supported by the media element, if
        /// any, that the context menu was invoked on.
        /// /*cef(default_retval=CM_MEDIAFLAG_NONE)*/
        /// </summary>

        public cef_context_menu_media_state_flags_t GetMediaStateFlags()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMediaStateFlags_13, out ret);
            var ret_result = (cef_context_menu_media_state_flags_t)ret.I32;

            return ret_result;
        }

        // gen! CefString GetSelectionText()
        /// <summary>
        /// Returns the text of the selection, if any, that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>

        public string GetSelectionText()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetSelectionText_14, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetMisspelledWord()
        /// <summary>
        /// Returns the text of the misspelled word, if any, that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>

        public string GetMisspelledWord()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMisspelledWord_15, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! bool GetDictionarySuggestions(std::vector<CefString>& suggestions)
        /// <summary>
        /// Returns true if suggestions exist, false otherwise. Fills in |suggestions|
        /// from the spell check service for the misspelled word if there is one.
        /// /*cef()*/
        /// </summary>

        public bool GetDictionarySuggestions(List<string> suggestions
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefContextMenuParams_GetDictionarySuggestions_16, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, suggestions);
            return ret_result;
        }

        // gen! bool IsEditable()
        /// <summary>
        /// Returns true if the context menu was invoked on an editable node.
        /// /*cef()*/
        /// </summary>

        public bool IsEditable()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsEditable_17, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsSpellCheckEnabled()
        /// <summary>
        /// Returns true if the context menu was invoked on an editable node where
        /// spell-check is enabled.
        /// /*cef()*/
        /// </summary>

        public bool IsSpellCheckEnabled()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsSpellCheckEnabled_18, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! EditStateFlags GetEditStateFlags()
        /// <summary>
        /// Returns flags representing the actions supported by the editable node, if
        /// any, that the context menu was invoked on.
        /// /*cef(default_retval=CM_EDITFLAG_NONE)*/
        /// </summary>

        public cef_context_menu_edit_state_flags_t GetEditStateFlags()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetEditStateFlags_19, out ret);
            var ret_result = (cef_context_menu_edit_state_flags_t)ret.I32;

            return ret_result;
        }

        // gen! bool IsCustomMenu()
        /// <summary>
        /// Returns true if the context menu contains items specified by the renderer
        /// process (for example, plugin placeholder or pepper plugin menu items).
        /// /*cef()*/
        /// </summary>

        public bool IsCustomMenu()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsCustomMenu_20, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsPepperMenu()
        /// <summary>
        /// Returns true if the context menu was invoked from a pepper plugin.
        /// /*cef()*/
        /// </summary>

        public bool IsPepperMenu()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsPepperMenu_21, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }
    }


    // [virtual] class CefCookieManager
    /// <summary>
    /// Class used for managing cookies. The methods of this class may be called on
    /// any thread unless otherwise indicated.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefCookieManager
    {
        const int _typeNAME = 8;
        const int CefCookieManager_Release_0 = (_typeNAME << 16) | 0;
        const int CefCookieManager_SetSupportedSchemes_1 = (_typeNAME << 16) | 1;
        const int CefCookieManager_VisitAllCookies_2 = (_typeNAME << 16) | 2;
        const int CefCookieManager_VisitUrlCookies_3 = (_typeNAME << 16) | 3;
        const int CefCookieManager_SetCookie_4 = (_typeNAME << 16) | 4;
        const int CefCookieManager_DeleteCookies_5 = (_typeNAME << 16) | 5;
        const int CefCookieManager_SetStoragePath_6 = (_typeNAME << 16) | 6;
        const int CefCookieManager_FlushStore_7 = (_typeNAME << 16) | 7;
        internal readonly IntPtr nativePtr;
        internal CefCookieManager(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCookieManager_Release_0, out ret);
        }

        // gen! void SetSupportedSchemes(const std::vector<CefString>& schemes,CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// CefCookieManager methods.
        /// </summary>

        public void SetSupportedSchemes(List<string> schemes
        , CefCompletionCallback callback
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);
            v2.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCookieManager_SetSupportedSchemes_1, out ret, ref v1, ref v2);

            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, schemes);
        }

        // gen! bool VisitAllCookies(CefRefPtr<CefCookieVisitor> visitor)
        /// <summary>
        /// Visit all cookies on the IO thread. The returned cookies are ordered by
        /// longest path, then by earliest creation date. Returns false if cookies
        /// cannot be accessed.
        /// /*cef()*/
        /// </summary>

        public bool VisitAllCookies(CefCookieVisitor visitor
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCookieManager_VisitAllCookies_2, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool VisitUrlCookies(const CefString& url,bool includeHttpOnly,CefRefPtr<CefCookieVisitor> visitor)
        /// <summary>
        /// Visit a subset of cookies on the IO thread. The results are filtered by the
        /// given url scheme, host, domain and path. If |includeHttpOnly| is true
        /// HTTP-only cookies will also be included in the results. The returned
        /// cookies are ordered by longest path, then by earliest creation date.
        /// Returns false if cookies cannot be accessed.
        /// /*cef()*/
        /// </summary>

        public bool VisitUrlCookies(string url
        , bool includeHttpOnly
        , CefCookieVisitor visitor
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            ;
            v2.I32 = includeHttpOnly ? 1 : 0;
            v3.Ptr = visitor.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_VisitUrlCookies_3, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool SetCookie(const CefString& url,const CefCookie& cookie,CefRefPtr<CefSetCookieCallback> callback)
        /// <summary>
        /// Sets a cookie given a valid URL and explicit user-provided cookie
        /// attributes. This function expects each attribute to be well-formed. It will
        /// check for disallowed characters (e.g. the ';' character is disallowed
        /// within the cookie value attribute) and fail without setting the cookie if
        /// such characters are found. If |callback| is non-NULL it will be executed
        /// asnychronously on the IO thread after the cookie has been set. Returns
        /// false if an invalid URL is specified or if cookies cannot be accessed.
        /// /*cef(optional_param=callback)*/
        /// </summary>

        public bool SetCookie(string url
        , CefCookie cookie
        , CefSetCookieCallback callback
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            ;
            v2.Ptr = cookie.nativePtr;
            v3.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_SetCookie_4, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool DeleteCookies(const CefString& url,const CefString& cookie_name,CefRefPtr<CefDeleteCookiesCallback> callback)
        /// <summary>
        /// Delete all cookies that match the specified parameters. If both |url| and
        /// |cookie_name| values are specified all host and domain cookies matching
        /// both will be deleted. If only |url| is specified all host cookies (but not
        /// domain cookies) irrespective of path will be deleted. If |url| is empty all
        /// cookies for all hosts and domains will be deleted. If |callback| is
        /// non-NULL it will be executed asnychronously on the IO thread after the
        /// cookies have been deleted. Returns false if a non-empty invalid URL is
        /// specified or if cookies cannot be accessed. Cookies can alternately be
        /// deleted using the Visit*Cookies() methods.
        /// /*cef(optional_param=url,optional_param=cookie_name,optional_param=callback)*/
        /// </summary>

        public bool DeleteCookies(string url
        , string cookie_name
        , CefDeleteCookiesCallback callback
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(cookie_name);
            ;
            v3.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_DeleteCookies_5, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }

        // gen! bool SetStoragePath(const CefString& path,bool persist_session_cookies,CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Sets the directory path that will be used for storing cookie data. If
        /// |path| is empty data will be stored in memory only. Otherwise, data will be
        /// stored at the specified |path|. To persist session cookies (cookies without
        /// an expiry date or validity interval) set |persist_session_cookies| to true.
        /// Session cookies are generally intended to be transient and most Web
        /// browsers do not persist them. If |callback| is non-NULL it will be executed
        /// asnychronously on the IO thread after the manager's storage has been
        /// initialized. Returns false if cookies cannot be accessed.
        /// /*cef(optional_param=path,optional_param=callback)*/
        /// </summary>

        public bool SetStoragePath(string path
        , bool persist_session_cookies
        , CefCompletionCallback callback
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(path);
            ;
            v2.I32 = persist_session_cookies ? 1 : 0;
            v3.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_SetStoragePath_6, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool FlushStore(CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Flush the backing store (if any) to disk. If |callback| is non-NULL it will
        /// be executed asnychronously on the IO thread after the flush is complete.
        /// Returns false if cookies cannot be accessed.
        /// /*cef(optional_param=callback)*/
        /// </summary>

        public bool FlushStore(CefCompletionCallback callback
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCookieManager_FlushStore_7, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }
    }


    // [virtual] class CefCookieVisitor
    /// <summary>
    /// Interface to implement for visiting cookie values. The methods of this class
    /// will always be called on the IO thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefCookieVisitor
    {
        const int _typeNAME = 9;
        const int CefCookieVisitor_Release_0 = (_typeNAME << 16) | 0;
        internal readonly IntPtr nativePtr;
        internal CefCookieVisitor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCookieVisitor_Release_0, out ret);
        }
    }


    // [virtual] class CefDOMVisitor
    /// <summary>
    /// Interface to implement for visiting the DOM. The methods of this class will
    /// be called on the render process main thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefDOMVisitor
    {
        const int _typeNAME = 10;
        const int CefDOMVisitor_Release_0 = (_typeNAME << 16) | 0;
        internal readonly IntPtr nativePtr;
        internal CefDOMVisitor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMVisitor_Release_0, out ret);
        }
    }


    // [virtual] class CefDOMDocument
    /// <summary>
    /// Class used to represent a DOM document. The methods of this class should only
    /// be called on the render process main thread thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefDOMDocument
    {
        const int _typeNAME = 11;
        const int CefDOMDocument_Release_0 = (_typeNAME << 16) | 0;
        const int CefDOMDocument_GetType_1 = (_typeNAME << 16) | 1;
        const int CefDOMDocument_GetDocument_2 = (_typeNAME << 16) | 2;
        const int CefDOMDocument_GetBody_3 = (_typeNAME << 16) | 3;
        const int CefDOMDocument_GetHead_4 = (_typeNAME << 16) | 4;
        const int CefDOMDocument_GetTitle_5 = (_typeNAME << 16) | 5;
        const int CefDOMDocument_GetElementById_6 = (_typeNAME << 16) | 6;
        const int CefDOMDocument_GetFocusedNode_7 = (_typeNAME << 16) | 7;
        const int CefDOMDocument_HasSelection_8 = (_typeNAME << 16) | 8;
        const int CefDOMDocument_GetSelectionStartOffset_9 = (_typeNAME << 16) | 9;
        const int CefDOMDocument_GetSelectionEndOffset_10 = (_typeNAME << 16) | 10;
        const int CefDOMDocument_GetSelectionAsMarkup_11 = (_typeNAME << 16) | 11;
        const int CefDOMDocument_GetSelectionAsText_12 = (_typeNAME << 16) | 12;
        const int CefDOMDocument_GetBaseURL_13 = (_typeNAME << 16) | 13;
        const int CefDOMDocument_GetCompleteURL_14 = (_typeNAME << 16) | 14;
        internal readonly IntPtr nativePtr;
        internal CefDOMDocument(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_Release_0, out ret);
        }

        // gen! Type GetType()
        /// <summary>
        /// CefDOMDocument methods.
        /// </summary>

        public cef_dom_document_type_t _GetType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetType_1, out ret);
            var ret_result = (cef_dom_document_type_t)ret.I32;

            return ret_result;
        }

        // gen! CefRefPtr<CefDOMNode> GetDocument()
        /// <summary>
        /// Returns the root document node.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetDocument()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetDocument_2, out ret);
            var ret_result = new CefDOMNode(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefDOMNode> GetBody()
        /// <summary>
        /// Returns the BODY node of an HTML document.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetBody()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetBody_3, out ret);
            var ret_result = new CefDOMNode(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefDOMNode> GetHead()
        /// <summary>
        /// Returns the HEAD node of an HTML document.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetHead()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetHead_4, out ret);
            var ret_result = new CefDOMNode(ret.Ptr);
            return ret_result;
        }

        // gen! CefString GetTitle()
        /// <summary>
        /// Returns the title of an HTML document.
        /// /*cef()*/
        /// </summary>

        public string GetTitle()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetTitle_5, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefRefPtr<CefDOMNode> GetElementById(const CefString& id)
        /// <summary>
        /// Returns the document element with the specified ID value.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetElementById(string id
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(id);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMDocument_GetElementById_6, out ret, ref v1);
            var ret_result = new CefDOMNode(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! CefRefPtr<CefDOMNode> GetFocusedNode()
        /// <summary>
        /// Returns the node that currently has keyboard focus.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetFocusedNode()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetFocusedNode_7, out ret);
            var ret_result = new CefDOMNode(ret.Ptr);
            return ret_result;
        }

        // gen! bool HasSelection()
        /// <summary>
        /// Returns true if a portion of the document is selected.
        /// /*cef()*/
        /// </summary>

        public bool HasSelection()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_HasSelection_8, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! int GetSelectionStartOffset()
        /// <summary>
        /// Returns the selection offset within the start node.
        /// /*cef()*/
        /// </summary>

        public int GetSelectionStartOffset()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionStartOffset_9, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int GetSelectionEndOffset()
        /// <summary>
        /// Returns the selection offset within the end node.
        /// /*cef()*/
        /// </summary>

        public int GetSelectionEndOffset()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionEndOffset_10, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! CefString GetSelectionAsMarkup()
        /// <summary>
        /// Returns the contents of this selection as markup.
        /// /*cef()*/
        /// </summary>

        public string GetSelectionAsMarkup()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionAsMarkup_11, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetSelectionAsText()
        /// <summary>
        /// Returns the contents of this selection as text.
        /// /*cef()*/
        /// </summary>

        public string GetSelectionAsText()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionAsText_12, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetBaseURL()
        /// <summary>
        /// Returns the base URL for the document.
        /// /*cef()*/
        /// </summary>

        public string GetBaseURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetBaseURL_13, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetCompleteURL(const CefString& partialURL)
        /// <summary>
        /// Returns a complete URL based on the document base URL and the specified
        /// partial URL.
        /// /*cef()*/
        /// </summary>

        public string GetCompleteURL(string partialURL
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(partialURL);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMDocument_GetCompleteURL_14, out ret, ref v1);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }
    }


    // [virtual] class CefDOMNode
    /// <summary>
    /// Class used to represent a DOM node. The methods of this class should only be
    /// called on the render process main thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefDOMNode
    {
        const int _typeNAME = 12;
        const int CefDOMNode_Release_0 = (_typeNAME << 16) | 0;
        const int CefDOMNode_GetType_1 = (_typeNAME << 16) | 1;
        const int CefDOMNode_IsText_2 = (_typeNAME << 16) | 2;
        const int CefDOMNode_IsElement_3 = (_typeNAME << 16) | 3;
        const int CefDOMNode_IsEditable_4 = (_typeNAME << 16) | 4;
        const int CefDOMNode_IsFormControlElement_5 = (_typeNAME << 16) | 5;
        const int CefDOMNode_GetFormControlElementType_6 = (_typeNAME << 16) | 6;
        const int CefDOMNode_IsSame_7 = (_typeNAME << 16) | 7;
        const int CefDOMNode_GetName_8 = (_typeNAME << 16) | 8;
        const int CefDOMNode_GetValue_9 = (_typeNAME << 16) | 9;
        const int CefDOMNode_SetValue_10 = (_typeNAME << 16) | 10;
        const int CefDOMNode_GetAsMarkup_11 = (_typeNAME << 16) | 11;
        const int CefDOMNode_GetDocument_12 = (_typeNAME << 16) | 12;
        const int CefDOMNode_GetParent_13 = (_typeNAME << 16) | 13;
        const int CefDOMNode_GetPreviousSibling_14 = (_typeNAME << 16) | 14;
        const int CefDOMNode_GetNextSibling_15 = (_typeNAME << 16) | 15;
        const int CefDOMNode_HasChildren_16 = (_typeNAME << 16) | 16;
        const int CefDOMNode_GetFirstChild_17 = (_typeNAME << 16) | 17;
        const int CefDOMNode_GetLastChild_18 = (_typeNAME << 16) | 18;
        const int CefDOMNode_GetElementTagName_19 = (_typeNAME << 16) | 19;
        const int CefDOMNode_HasElementAttributes_20 = (_typeNAME << 16) | 20;
        const int CefDOMNode_HasElementAttribute_21 = (_typeNAME << 16) | 21;
        const int CefDOMNode_GetElementAttribute_22 = (_typeNAME << 16) | 22;
        const int CefDOMNode_GetElementAttributes_23 = (_typeNAME << 16) | 23;
        const int CefDOMNode_SetElementAttribute_24 = (_typeNAME << 16) | 24;
        const int CefDOMNode_GetElementInnerText_25 = (_typeNAME << 16) | 25;
        const int CefDOMNode_GetElementBounds_26 = (_typeNAME << 16) | 26;
        internal readonly IntPtr nativePtr;
        internal CefDOMNode(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_Release_0, out ret);
        }

        // gen! Type GetType()
        /// <summary>
        /// CefDOMNode methods.
        /// </summary>

        public cef_dom_node_type_t _GetType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetType_1, out ret);
            var ret_result = (cef_dom_node_type_t)ret.I32;

            return ret_result;
        }

        // gen! bool IsText()
        /// <summary>
        /// Returns true if this is a text node.
        /// /*cef()*/
        /// </summary>

        public bool IsText()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsText_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsElement()
        /// <summary>
        /// Returns true if this is an element node.
        /// /*cef()*/
        /// </summary>

        public bool IsElement()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsElement_3, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsEditable()
        /// <summary>
        /// Returns true if this is an editable node.
        /// /*cef()*/
        /// </summary>

        public bool IsEditable()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsEditable_4, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsFormControlElement()
        /// <summary>
        /// Returns true if this is a form control element node.
        /// /*cef()*/
        /// </summary>

        public bool IsFormControlElement()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsFormControlElement_5, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefString GetFormControlElementType()
        /// <summary>
        /// Returns the type of this form control element node.
        /// /*cef()*/
        /// </summary>

        public string GetFormControlElementType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetFormControlElementType_6, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! bool IsSame(CefRefPtr<CefDOMNode> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefDOMNode that
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_IsSame_7, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefString GetName()
        /// <summary>
        /// Returns the name of this node.
        /// /*cef()*/
        /// </summary>

        public string GetName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetName_8, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetValue()
        /// <summary>
        /// Returns the value of this node.
        /// /*cef()*/
        /// </summary>

        public string GetValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetValue_9, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! bool SetValue(const CefString& value)
        /// <summary>
        /// Set the value of this node. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetValue(string value
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(value);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_SetValue_10, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! CefString GetAsMarkup()
        /// <summary>
        /// Returns the contents of this node as markup.
        /// /*cef()*/
        /// </summary>

        public string GetAsMarkup()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetAsMarkup_11, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefRefPtr<CefDOMDocument> GetDocument()
        /// <summary>
        /// Returns the document associated with this node.
        /// /*cef()*/
        /// </summary>

        public CefDOMDocument GetDocument()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetDocument_12, out ret);
            var ret_result = new CefDOMDocument(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefDOMNode> GetParent()
        /// <summary>
        /// Returns the parent node.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetParent()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetParent_13, out ret);
            var ret_result = new CefDOMNode(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefDOMNode> GetPreviousSibling()
        /// <summary>
        /// Returns the previous sibling node.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetPreviousSibling()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetPreviousSibling_14, out ret);
            var ret_result = new CefDOMNode(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefDOMNode> GetNextSibling()
        /// <summary>
        /// Returns the next sibling node.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetNextSibling()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetNextSibling_15, out ret);
            var ret_result = new CefDOMNode(ret.Ptr);
            return ret_result;
        }

        // gen! bool HasChildren()
        /// <summary>
        /// Returns true if this node has child nodes.
        /// /*cef()*/
        /// </summary>

        public bool HasChildren()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_HasChildren_16, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefDOMNode> GetFirstChild()
        /// <summary>
        /// Return the first child node.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetFirstChild()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetFirstChild_17, out ret);
            var ret_result = new CefDOMNode(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefDOMNode> GetLastChild()
        /// <summary>
        /// Returns the last child node.
        /// /*cef()*/
        /// </summary>

        public CefDOMNode GetLastChild()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetLastChild_18, out ret);
            var ret_result = new CefDOMNode(ret.Ptr);
            return ret_result;
        }

        // gen! CefString GetElementTagName()
        /// <summary>
        /// The following methods are valid only for element nodes.
        /// Returns the tag name of this element.
        /// /*cef()*/
        /// </summary>

        public string GetElementTagName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementTagName_19, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! bool HasElementAttributes()
        /// <summary>
        /// Returns true if this element has attributes.
        /// /*cef()*/
        /// </summary>

        public bool HasElementAttributes()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_HasElementAttributes_20, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool HasElementAttribute(const CefString& attrName)
        /// <summary>
        /// Returns true if this element has an attribute named |attrName|.
        /// /*cef()*/
        /// </summary>

        public bool HasElementAttribute(string attrName
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(attrName);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_HasElementAttribute_21, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! CefString GetElementAttribute(const CefString& attrName)
        /// <summary>
        /// Returns the element attribute named |attrName|.
        /// /*cef()*/
        /// </summary>

        public string GetElementAttribute(string attrName
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(attrName);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_GetElementAttribute_22, out ret, ref v1);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! void GetElementAttributes(AttributeMap& attrMap)
        /// <summary>
        /// Returns a map of all element attributes.
        /// /*cef()*/
        /// </summary>

        public void GetElementAttributes(AttributeMap attrMap
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = attrMap.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_GetElementAttributes_23, out ret, ref v1);

        }

        // gen! bool SetElementAttribute(const CefString& attrName,const CefString& value)
        /// <summary>
        /// Set the value for the element attribute named |attrName|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool SetElementAttribute(string attrName
        , string value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(attrName);
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            ;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDOMNode_SetElementAttribute_24, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }

        // gen! CefString GetElementInnerText()
        /// <summary>
        /// Returns the inner text of the element.
        /// /*cef()*/
        /// </summary>

        public string GetElementInnerText()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementInnerText_25, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefRect GetElementBounds()
        /// <summary>
        /// Returns the bounds of the element.
        /// /*cef()*/
        /// </summary>

        public CefRect GetElementBounds()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementBounds_26, out ret);
            var ret_result = new CefRect(ret.Ptr);

            return ret_result;
        }
    }


    // [virtual] class CefDownloadItem
    /// <summary>
    /// Class used to represent a download item.
    /// /*(source=library)*/
    /// </summary>
    public struct CefDownloadItem
    {
        const int _typeNAME = 13;
        const int CefDownloadItem_Release_0 = (_typeNAME << 16) | 0;
        const int CefDownloadItem_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefDownloadItem_IsInProgress_2 = (_typeNAME << 16) | 2;
        const int CefDownloadItem_IsComplete_3 = (_typeNAME << 16) | 3;
        const int CefDownloadItem_IsCanceled_4 = (_typeNAME << 16) | 4;
        const int CefDownloadItem_GetCurrentSpeed_5 = (_typeNAME << 16) | 5;
        const int CefDownloadItem_GetPercentComplete_6 = (_typeNAME << 16) | 6;
        const int CefDownloadItem_GetTotalBytes_7 = (_typeNAME << 16) | 7;
        const int CefDownloadItem_GetReceivedBytes_8 = (_typeNAME << 16) | 8;
        const int CefDownloadItem_GetStartTime_9 = (_typeNAME << 16) | 9;
        const int CefDownloadItem_GetEndTime_10 = (_typeNAME << 16) | 10;
        const int CefDownloadItem_GetFullPath_11 = (_typeNAME << 16) | 11;
        const int CefDownloadItem_GetId_12 = (_typeNAME << 16) | 12;
        const int CefDownloadItem_GetURL_13 = (_typeNAME << 16) | 13;
        const int CefDownloadItem_GetOriginalUrl_14 = (_typeNAME << 16) | 14;
        const int CefDownloadItem_GetSuggestedFileName_15 = (_typeNAME << 16) | 15;
        const int CefDownloadItem_GetContentDisposition_16 = (_typeNAME << 16) | 16;
        const int CefDownloadItem_GetMimeType_17 = (_typeNAME << 16) | 17;
        internal readonly IntPtr nativePtr;
        internal CefDownloadItem(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_Release_0, out ret);
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefDownloadItem methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsValid_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsInProgress()
        /// <summary>
        /// Returns true if the download is in progress.
        /// /*cef()*/
        /// </summary>

        public bool IsInProgress()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsInProgress_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsComplete()
        /// <summary>
        /// Returns true if the download is complete.
        /// /*cef()*/
        /// </summary>

        public bool IsComplete()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsComplete_3, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsCanceled()
        /// <summary>
        /// Returns true if the download has been canceled or interrupted.
        /// /*cef()*/
        /// </summary>

        public bool IsCanceled()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsCanceled_4, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! int64 GetCurrentSpeed()
        /// <summary>
        /// Returns a simple speed estimate in bytes/s.
        /// /*cef()*/
        /// </summary>

        public long GetCurrentSpeed()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetCurrentSpeed_5, out ret);
            var ret_result = ret.I64;
            return ret_result;
        }

        // gen! int GetPercentComplete()
        /// <summary>
        /// Returns the rough percent complete or -1 if the receive total size is
        /// unknown.
        /// /*cef()*/
        /// </summary>

        public int GetPercentComplete()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetPercentComplete_6, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int64 GetTotalBytes()
        /// <summary>
        /// Returns the total number of bytes.
        /// /*cef()*/
        /// </summary>

        public long GetTotalBytes()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetTotalBytes_7, out ret);
            var ret_result = ret.I64;
            return ret_result;
        }

        // gen! int64 GetReceivedBytes()
        /// <summary>
        /// Returns the number of received bytes.
        /// /*cef()*/
        /// </summary>

        public long GetReceivedBytes()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetReceivedBytes_8, out ret);
            var ret_result = ret.I64;
            return ret_result;
        }

        // gen! CefTime GetStartTime()
        /// <summary>
        /// Returns the time that the download started.
        /// /*cef()*/
        /// </summary>

        public CefTime GetStartTime()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetStartTime_9, out ret);
            var ret_result = new CefTime(ret.Ptr);

            return ret_result;
        }

        // gen! CefTime GetEndTime()
        /// <summary>
        /// Returns the time that the download ended.
        /// /*cef()*/
        /// </summary>

        public CefTime GetEndTime()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetEndTime_10, out ret);
            var ret_result = new CefTime(ret.Ptr);

            return ret_result;
        }

        // gen! CefString GetFullPath()
        /// <summary>
        /// Returns the full path to the downloaded or downloading file.
        /// /*cef()*/
        /// </summary>

        public string GetFullPath()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetFullPath_11, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! uint32 GetId()
        /// <summary>
        /// Returns the unique identifier for this download.
        /// /*cef()*/
        /// </summary>

        public uint GetId()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetId_12, out ret);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! CefString GetURL()
        /// <summary>
        /// Returns the URL.
        /// /*cef()*/
        /// </summary>

        public string GetURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetURL_13, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetOriginalUrl()
        /// <summary>
        /// Returns the original URL before any redirections.
        /// /*cef()*/
        /// </summary>

        public string GetOriginalUrl()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetOriginalUrl_14, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetSuggestedFileName()
        /// <summary>
        /// Returns the suggested file name.
        /// /*cef()*/
        /// </summary>

        public string GetSuggestedFileName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetSuggestedFileName_15, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetContentDisposition()
        /// <summary>
        /// Returns the content disposition.
        /// /*cef()*/
        /// </summary>

        public string GetContentDisposition()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetContentDisposition_16, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetMimeType()
        /// <summary>
        /// Returns the mime type.
        /// /*cef()*/
        /// </summary>

        public string GetMimeType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetMimeType_17, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }
    }


    // [virtual] class CefDragData
    /// <summary>
    /// Class used to represent drag data. The methods of this class may be called
    /// on any thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefDragData
    {
        const int _typeNAME = 14;
        const int CefDragData_Release_0 = (_typeNAME << 16) | 0;
        const int CefDragData_Clone_1 = (_typeNAME << 16) | 1;
        const int CefDragData_IsReadOnly_2 = (_typeNAME << 16) | 2;
        const int CefDragData_IsLink_3 = (_typeNAME << 16) | 3;
        const int CefDragData_IsFragment_4 = (_typeNAME << 16) | 4;
        const int CefDragData_IsFile_5 = (_typeNAME << 16) | 5;
        const int CefDragData_GetLinkURL_6 = (_typeNAME << 16) | 6;
        const int CefDragData_GetLinkTitle_7 = (_typeNAME << 16) | 7;
        const int CefDragData_GetLinkMetadata_8 = (_typeNAME << 16) | 8;
        const int CefDragData_GetFragmentText_9 = (_typeNAME << 16) | 9;
        const int CefDragData_GetFragmentHtml_10 = (_typeNAME << 16) | 10;
        const int CefDragData_GetFragmentBaseURL_11 = (_typeNAME << 16) | 11;
        const int CefDragData_GetFileName_12 = (_typeNAME << 16) | 12;
        const int CefDragData_GetFileContents_13 = (_typeNAME << 16) | 13;
        const int CefDragData_GetFileNames_14 = (_typeNAME << 16) | 14;
        const int CefDragData_SetLinkURL_15 = (_typeNAME << 16) | 15;
        const int CefDragData_SetLinkTitle_16 = (_typeNAME << 16) | 16;
        const int CefDragData_SetLinkMetadata_17 = (_typeNAME << 16) | 17;
        const int CefDragData_SetFragmentText_18 = (_typeNAME << 16) | 18;
        const int CefDragData_SetFragmentHtml_19 = (_typeNAME << 16) | 19;
        const int CefDragData_SetFragmentBaseURL_20 = (_typeNAME << 16) | 20;
        const int CefDragData_ResetFileContents_21 = (_typeNAME << 16) | 21;
        const int CefDragData_AddFile_22 = (_typeNAME << 16) | 22;
        const int CefDragData_GetImage_23 = (_typeNAME << 16) | 23;
        const int CefDragData_GetImageHotspot_24 = (_typeNAME << 16) | 24;
        const int CefDragData_HasImage_25 = (_typeNAME << 16) | 25;
        internal readonly IntPtr nativePtr;
        internal CefDragData(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_Release_0, out ret);
        }

        // gen! CefRefPtr<CefDragData> Clone()
        /// <summary>
        /// CefDragData methods.
        /// </summary>

        public CefDragData Clone()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_Clone_1, out ret);
            var ret_result = new CefDragData(ret.Ptr);
            return ret_result;
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if this object is read-only.
        /// /*cef()*/
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsReadOnly_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsLink()
        /// <summary>
        /// Returns true if the drag data is a link.
        /// /*cef()*/
        /// </summary>

        public bool IsLink()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsLink_3, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsFragment()
        /// <summary>
        /// Returns true if the drag data is a text or html fragment.
        /// /*cef()*/
        /// </summary>

        public bool IsFragment()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsFragment_4, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsFile()
        /// <summary>
        /// Returns true if the drag data is a file.
        /// /*cef()*/
        /// </summary>

        public bool IsFile()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsFile_5, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefString GetLinkURL()
        /// <summary>
        /// Return the link URL that is being dragged.
        /// /*cef()*/
        /// </summary>

        public string GetLinkURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkURL_6, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetLinkTitle()
        /// <summary>
        /// Return the title associated with the link being dragged.
        /// /*cef()*/
        /// </summary>

        public string GetLinkTitle()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkTitle_7, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetLinkMetadata()
        /// <summary>
        /// Return the metadata, if any, associated with the link being dragged.
        /// /*cef()*/
        /// </summary>

        public string GetLinkMetadata()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkMetadata_8, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetFragmentText()
        /// <summary>
        /// Return the plain text fragment that is being dragged.
        /// /*cef()*/
        /// </summary>

        public string GetFragmentText()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentText_9, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetFragmentHtml()
        /// <summary>
        /// Return the text/html fragment that is being dragged.
        /// /*cef()*/
        /// </summary>

        public string GetFragmentHtml()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentHtml_10, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetFragmentBaseURL()
        /// <summary>
        /// Return the base URL that the fragment came from. This value is used for
        /// resolving relative URLs and may be empty.
        /// /*cef()*/
        /// </summary>

        public string GetFragmentBaseURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentBaseURL_11, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetFileName()
        /// <summary>
        /// Return the name of the file being dragged out of the browser window.
        /// /*cef()*/
        /// </summary>

        public string GetFileName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFileName_12, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! size_t GetFileContents(CefRefPtr<CefStreamWriter> writer)
        /// <summary>
        /// Write the contents of the file being dragged out of the web view into
        /// |writer|. Returns the number of bytes sent to |writer|. If |writer| is
        /// NULL this method will return the size of the file contents in bytes.
        /// Call GetFileName() to get a suggested name for the file.
        /// /*cef(optional_param=writer)*/
        /// </summary>

        public uint GetFileContents(CefStreamWriter writer
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = writer.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_GetFileContents_13, out ret, ref v1);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! bool GetFileNames(std::vector<CefString>& names)
        /// <summary>
        /// Retrieve the list of file names that are being dragged into the browser
        /// window.
        /// /*cef()*/
        /// </summary>

        public bool GetFileNames(List<string> names
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_GetFileNames_14, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, names);
            return ret_result;
        }

        // gen! void SetLinkURL(const CefString& url)
        /// <summary>
        /// Set the link URL that is being dragged.
        /// /*cef(optional_param=url)*/
        /// </summary>

        public void SetLinkURL(string url
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkURL_15, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void SetLinkTitle(const CefString& title)
        /// <summary>
        /// Set the title associated with the link being dragged.
        /// /*cef(optional_param=title)*/
        /// </summary>

        public void SetLinkTitle(string title
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(title);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkTitle_16, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void SetLinkMetadata(const CefString& data)
        /// <summary>
        /// Set the metadata associated with the link being dragged.
        /// /*cef(optional_param=data)*/
        /// </summary>

        public void SetLinkMetadata(string data
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(data);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkMetadata_17, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void SetFragmentText(const CefString& text)
        /// <summary>
        /// Set the plain text fragment that is being dragged.
        /// /*cef(optional_param=text)*/
        /// </summary>

        public void SetFragmentText(string text
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(text);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentText_18, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void SetFragmentHtml(const CefString& html)
        /// <summary>
        /// Set the text/html fragment that is being dragged.
        /// /*cef(optional_param=html)*/
        /// </summary>

        public void SetFragmentHtml(string html
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(html);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentHtml_19, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void SetFragmentBaseURL(const CefString& base_url)
        /// <summary>
        /// Set the base URL that the fragment came from.
        /// /*cef(optional_param=base_url)*/
        /// </summary>

        public void SetFragmentBaseURL(string base_url
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(base_url);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentBaseURL_20, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void ResetFileContents()
        /// <summary>
        /// Reset the file contents. You should do this before calling
        /// CefBrowserHost::DragTargetDragEnter as the web view does not allow us to
        /// drag in this kind of data.
        /// /*cef()*/
        /// </summary>

        public void ResetFileContents()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_ResetFileContents_21, out ret);

        }

        // gen! void AddFile(const CefString& path,const CefString& display_name)
        /// <summary>
        /// Add a file that is being dragged into the webview.
        /// /*cef(optional_param=display_name)*/
        /// </summary>

        public void AddFile(string path
        , string display_name
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(path);
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(display_name);
            ;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDragData_AddFile_22, out ret, ref v1, ref v2);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
        }

        // gen! CefRefPtr<CefImage> GetImage()
        /// <summary>
        /// Get the image representation of drag data. May return NULL if no image
        /// representation is available.
        /// /*cef()*/
        /// </summary>

        public CefImage GetImage()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetImage_23, out ret);
            var ret_result = new CefImage(ret.Ptr);
            return ret_result;
        }

        // gen! CefPoint GetImageHotspot()
        /// <summary>
        /// Get the image hotspot (drag start location relative to image dimensions).
        /// /*cef()*/
        /// </summary>

        public CefPoint GetImageHotspot()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetImageHotspot_24, out ret);
            var ret_result = new CefPoint(ret.Ptr);

            return ret_result;
        }

        // gen! bool HasImage()
        /// <summary>
        /// Returns true if an image representation of drag data is available.
        /// /*cef()*/
        /// </summary>

        public bool HasImage()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_HasImage_25, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }
    }


    // [virtual] class CefFrame
    /// <summary>
    /// Class used to represent a frame in the browser window. When used in the
    /// browser process the methods of this class may be called on any thread unless
    /// otherwise indicated in the comments. When used in the render process the
    /// methods of this class may only be called on the main thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefFrame
    {
        const int _typeNAME = 15;
        const int CefFrame_Release_0 = (_typeNAME << 16) | 0;
        const int CefFrame_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefFrame_Undo_2 = (_typeNAME << 16) | 2;
        const int CefFrame_Redo_3 = (_typeNAME << 16) | 3;
        const int CefFrame_Cut_4 = (_typeNAME << 16) | 4;
        const int CefFrame_Copy_5 = (_typeNAME << 16) | 5;
        const int CefFrame_Paste_6 = (_typeNAME << 16) | 6;
        const int CefFrame_Delete_7 = (_typeNAME << 16) | 7;
        const int CefFrame_SelectAll_8 = (_typeNAME << 16) | 8;
        const int CefFrame_ViewSource_9 = (_typeNAME << 16) | 9;
        const int CefFrame_GetSource_10 = (_typeNAME << 16) | 10;
        const int CefFrame_GetText_11 = (_typeNAME << 16) | 11;
        const int CefFrame_LoadRequest_12 = (_typeNAME << 16) | 12;
        const int CefFrame_LoadURL_13 = (_typeNAME << 16) | 13;
        const int CefFrame_LoadString_14 = (_typeNAME << 16) | 14;
        const int CefFrame_ExecuteJavaScript_15 = (_typeNAME << 16) | 15;
        const int CefFrame_IsMain_16 = (_typeNAME << 16) | 16;
        const int CefFrame_IsFocused_17 = (_typeNAME << 16) | 17;
        const int CefFrame_GetName_18 = (_typeNAME << 16) | 18;
        const int CefFrame_GetIdentifier_19 = (_typeNAME << 16) | 19;
        const int CefFrame_GetParent_20 = (_typeNAME << 16) | 20;
        const int CefFrame_GetURL_21 = (_typeNAME << 16) | 21;
        const int CefFrame_GetBrowser_22 = (_typeNAME << 16) | 22;
        const int CefFrame_GetV8Context_23 = (_typeNAME << 16) | 23;
        const int CefFrame_VisitDOM_24 = (_typeNAME << 16) | 24;
        internal readonly IntPtr nativePtr;
        internal CefFrame(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Release_0, out ret);
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefFrame methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsValid_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void Undo()
        /// <summary>
        /// Execute undo in this frame.
        /// /*cef()*/
        /// </summary>

        public void Undo()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Undo_2, out ret);

        }

        // gen! void Redo()
        /// <summary>
        /// Execute redo in this frame.
        /// /*cef()*/
        /// </summary>

        public void Redo()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Redo_3, out ret);

        }

        // gen! void Cut()
        /// <summary>
        /// Execute cut in this frame.
        /// /*cef()*/
        /// </summary>

        public void Cut()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Cut_4, out ret);

        }

        // gen! void Copy()
        /// <summary>
        /// Execute copy in this frame.
        /// /*cef()*/
        /// </summary>

        public void Copy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Copy_5, out ret);

        }

        // gen! void Paste()
        /// <summary>
        /// Execute paste in this frame.
        /// /*cef()*/
        /// </summary>

        public void Paste()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Paste_6, out ret);

        }

        // gen! void Delete()
        /// <summary>
        /// Execute delete in this frame.
        /// /*cef(capi_name=del)*/
        /// </summary>

        public void Delete()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Delete_7, out ret);

        }

        // gen! void SelectAll()
        /// <summary>
        /// Execute select all in this frame.
        /// /*cef()*/
        /// </summary>

        public void SelectAll()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_SelectAll_8, out ret);

        }

        // gen! void ViewSource()
        /// <summary>
        /// Save this frame's HTML source to a temporary file and open it in the
        /// default text viewing application. This method can only be called from the
        /// browser process.
        /// /*cef()*/
        /// </summary>

        public void ViewSource()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_ViewSource_9, out ret);

        }

        // gen! void GetSource(CefRefPtr<CefStringVisitor> visitor)
        /// <summary>
        /// Retrieve this frame's HTML source as a string sent to the specified
        /// visitor.
        /// /*cef()*/
        /// </summary>

        public void GetSource(CefStringVisitor visitor
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_GetSource_10, out ret, ref v1);

        }

        // gen! void GetText(CefRefPtr<CefStringVisitor> visitor)
        /// <summary>
        /// Retrieve this frame's display text as a string sent to the specified
        /// visitor.
        /// /*cef()*/
        /// </summary>

        public void GetText(CefStringVisitor visitor
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_GetText_11, out ret, ref v1);

        }

        // gen! void LoadRequest(CefRefPtr<CefRequest> request)
        /// <summary>
        /// Load the request represented by the |request| object.
        /// /*cef()*/
        /// </summary>

        public void LoadRequest(CefRequest request
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = request.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_LoadRequest_12, out ret, ref v1);

        }

        // gen! void LoadURL(const CefString& url)
        /// <summary>
        /// Load the specified |url|.
        /// /*cef()*/
        /// </summary>

        public void LoadURL(string url
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_LoadURL_13, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void LoadString(const CefString& string_val,const CefString& url)
        /// <summary>
        /// Load the contents of |string_val| with the specified dummy |url|. |url|
        /// should have a standard scheme (for example, http scheme) or behaviors like
        /// link clicks and web security restrictions may not behave as expected.
        /// /*cef()*/
        /// </summary>

        public void LoadString(string string_val
        , string url
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(string_val);
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(url);
            ;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefFrame_LoadString_14, out ret, ref v1, ref v2);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
        }

        // gen! void ExecuteJavaScript(const CefString& code,const CefString& script_url,int start_line)
        /// <summary>
        /// Execute a string of JavaScript code in this frame. The |script_url|
        /// parameter is the URL where the script in question can be found, if any.
        /// The renderer may request this URL to show the developer the source of the
        /// error.  The |start_line| parameter is the base line number to use for error
        /// reporting.
        /// /*cef(optional_param=script_url)*/
        /// </summary>

        public void ExecuteJavaScript(string code
        , string script_url
        , int start_line
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(code);
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(script_url);
            ;
            v3.I32 = (int)start_line;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefFrame_ExecuteJavaScript_15, out ret, ref v1, ref v2, ref v3);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
        }

        // gen! bool IsMain()
        /// <summary>
        /// Returns true if this is the main (top-level) frame.
        /// /*cef()*/
        /// </summary>

        public bool IsMain()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsMain_16, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsFocused()
        /// <summary>
        /// Returns true if this is the focused frame.
        /// /*cef()*/
        /// </summary>

        public bool IsFocused()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsFocused_17, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefString GetName()
        /// <summary>
        /// Returns the name for this frame. If the frame has an assigned name (for
        /// example, set via the iframe "name" attribute) then that value will be
        /// returned. Otherwise a unique name will be constructed based on the frame
        /// parent hierarchy. The main (top-level) frame will always have an empty name
        /// value.
        /// /*cef()*/
        /// </summary>

        public string GetName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetName_18, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! int64 GetIdentifier()
        /// <summary>
        /// Returns the globally unique identifier for this frame or < 0 if the
        /// underlying frame does not yet exist.
        /// /*cef()*/
        /// </summary>

        public long GetIdentifier()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetIdentifier_19, out ret);
            var ret_result = ret.I64;
            return ret_result;
        }

        // gen! CefRefPtr<CefFrame> GetParent()
        /// <summary>
        /// Returns the parent of this frame or NULL if this is the main (top-level)
        /// frame.
        /// /*cef()*/
        /// </summary>

        public CefFrame GetParent()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetParent_20, out ret);
            var ret_result = new CefFrame(ret.Ptr);
            return ret_result;
        }

        // gen! CefString GetURL()
        /// <summary>
        /// Returns the URL currently loaded in this frame.
        /// /*cef()*/
        /// </summary>

        public string GetURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetURL_21, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /// <summary>
        /// Returns the browser that this frame belongs to.
        /// /*cef()*/
        /// </summary>

        public CefBrowser GetBrowser()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetBrowser_22, out ret);
            var ret_result = new CefBrowser(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefV8Context> GetV8Context()
        /// <summary>
        /// Get the V8 context associated with the frame. This method can only be
        /// called from the render process.
        /// /*cef()*/
        /// </summary>

        public CefV8Context GetV8Context()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetV8Context_23, out ret);
            var ret_result = new CefV8Context(ret.Ptr);
            return ret_result;
        }

        // gen! void VisitDOM(CefRefPtr<CefDOMVisitor> visitor)
        /// <summary>
        /// Visit the DOM document. This method can only be called from the render
        /// process.
        /// /*cef()*/
        /// </summary>

        public void VisitDOM(CefDOMVisitor visitor
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_VisitDOM_24, out ret, ref v1);

        }
    }


    // [virtual] class CefImage
    /// <summary>
    /// Container for a single image represented at different scale factors. All
    /// image representations should be the same size in density independent pixel
    /// (DIP) units. For example, if the image at scale factor 1.0 is 100x100 pixels
    /// then the image at scale factor 2.0 should be 200x200 pixels -- both images
    /// will display with a DIP size of 100x100 units. The methods of this class must
    /// be called on the browser process UI thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefImage
    {
        const int _typeNAME = 16;
        const int CefImage_Release_0 = (_typeNAME << 16) | 0;
        const int CefImage_IsEmpty_1 = (_typeNAME << 16) | 1;
        const int CefImage_IsSame_2 = (_typeNAME << 16) | 2;
        const int CefImage_AddBitmap_3 = (_typeNAME << 16) | 3;
        const int CefImage_AddPNG_4 = (_typeNAME << 16) | 4;
        const int CefImage_AddJPEG_5 = (_typeNAME << 16) | 5;
        const int CefImage_GetWidth_6 = (_typeNAME << 16) | 6;
        const int CefImage_GetHeight_7 = (_typeNAME << 16) | 7;
        const int CefImage_HasRepresentation_8 = (_typeNAME << 16) | 8;
        const int CefImage_RemoveRepresentation_9 = (_typeNAME << 16) | 9;
        const int CefImage_GetRepresentationInfo_10 = (_typeNAME << 16) | 10;
        const int CefImage_GetAsBitmap_11 = (_typeNAME << 16) | 11;
        const int CefImage_GetAsPNG_12 = (_typeNAME << 16) | 12;
        const int CefImage_GetAsJPEG_13 = (_typeNAME << 16) | 13;
        internal readonly IntPtr nativePtr;
        internal CefImage(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_Release_0, out ret);
        }

        // gen! bool IsEmpty()
        /// <summary>
        /// CefImage methods.
        /// </summary>

        public bool IsEmpty()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_IsEmpty_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsSame(CefRefPtr<CefImage> that)
        /// <summary>
        /// Returns true if this Image and |that| Image share the same underlying
        /// storage. Will also return true if both images are empty.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefImage that
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_IsSame_2, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool AddBitmap(float scale_factor,int pixel_width,int pixel_height,cef_color_type_t color_type,cef_alpha_type_t alpha_type,const void* pixel_data,size_t pixel_data_size)
        /// <summary>
        /// Add a bitmap image representation for |scale_factor|. Only 32-bit RGBA/BGRA
        /// formats are supported. |pixel_width| and |pixel_height| are the bitmap
        /// representation size in pixel coordinates. |pixel_data| is the array of
        /// pixel data and should be |pixel_width| x |pixel_height| x 4 bytes in size.
        /// |color_type| and |alpha_type| values specify the pixel format.
        /// /*cef()*/
        /// </summary>

        public bool AddBitmap(float scale_factor
        , int pixel_width
        , int pixel_height
        , cef_color_type_t color_type
        , cef_alpha_type_t alpha_type
        , IntPtr pixel_data
        , uint pixel_data_size
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue v6 = new JsValue();
            JsValue v7 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;
            v2.I32 = (int)pixel_width;
            v3.I32 = (int)pixel_height;
            v4.I32 = (int)color_type;
            v5.I32 = (int)alpha_type;
            v6.Ptr = pixel_data;
            v7.I32 = (int)pixel_data_size;

            Cef3Binder.MyCefMet_Call7(this.nativePtr, CefImage_AddBitmap_3, out ret, ref v1, ref v2, ref v3, ref v4, ref v5, ref v6, ref v7);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool AddPNG(float scale_factor,const void* png_data,size_t png_data_size)
        /// <summary>
        /// Add a PNG image representation for |scale_factor|. |png_data| is the image
        /// data of size |png_data_size|. Any alpha transparency in the PNG data will
        /// be maintained.
        /// /*cef()*/
        /// </summary>

        public bool AddPNG(float scale_factor
        , IntPtr png_data
        , uint png_data_size
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;
            v2.Ptr = png_data;
            v3.I32 = (int)png_data_size;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefImage_AddPNG_4, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool AddJPEG(float scale_factor,const void* jpeg_data,size_t jpeg_data_size)
        /// <summary>
        /// Create a JPEG image representation for |scale_factor|. |jpeg_data| is the
        /// image data of size |jpeg_data_size|. The JPEG format does not support
        /// transparency so the alpha byte will be set to 0xFF for all pixels.
        /// /*cef()*/
        /// </summary>

        public bool AddJPEG(float scale_factor
        , IntPtr jpeg_data
        , uint jpeg_data_size
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;
            v2.Ptr = jpeg_data;
            v3.I32 = (int)jpeg_data_size;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefImage_AddJPEG_5, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! size_t GetWidth()
        /// <summary>
        /// Returns the image width in density independent pixel (DIP) units.
        /// /*cef()*/
        /// </summary>

        public uint GetWidth()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_GetWidth_6, out ret);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! size_t GetHeight()
        /// <summary>
        /// Returns the image height in density independent pixel (DIP) units.
        /// /*cef()*/
        /// </summary>

        public uint GetHeight()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_GetHeight_7, out ret);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! bool HasRepresentation(float scale_factor)
        /// <summary>
        /// Returns true if this image contains a representation for |scale_factor|.
        /// /*cef()*/
        /// </summary>

        public bool HasRepresentation(float scale_factor
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_HasRepresentation_8, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool RemoveRepresentation(float scale_factor)
        /// <summary>
        /// Removes the representation for |scale_factor|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool RemoveRepresentation(float scale_factor
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_RemoveRepresentation_9, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool GetRepresentationInfo(float scale_factor,float& actual_scale_factor,int& pixel_width,int& pixel_height)
        /// <summary>
        /// Returns information for the representation that most closely matches
        /// |scale_factor|. |actual_scale_factor| is the actual scale factor for the
        /// representation. |pixel_width| and |pixel_height| are the representation
        /// size in pixel coordinates. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool GetRepresentationInfo(float scale_factor
        , ref float actual_scale_factor
        , ref int pixel_width
        , ref int pixel_height
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;
            v2.Num = actual_scale_factor;
            v3.I32 = pixel_width;
            v4.I32 = pixel_height;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetRepresentationInfo_10, out ret, ref v1, ref v2, ref v3, ref v4);
            var ret_result = ret.I32 != 0;
            actual_scale_factor = (float)v2.Num; ;
            pixel_width = (int)v3.I32; ;
            pixel_height = (int)v4.I32; ;
            return ret_result;
        }

        // gen! CefRefPtr<CefBinaryValue> GetAsBitmap(float scale_factor,cef_color_type_t color_type,cef_alpha_type_t alpha_type,int& pixel_width,int& pixel_height)
        /// <summary>
        /// Returns the bitmap representation that most closely matches |scale_factor|.
        /// Only 32-bit RGBA/BGRA formats are supported. |color_type| and |alpha_type|
        /// values specify the desired output pixel format. |pixel_width| and
        /// |pixel_height| are the output representation size in pixel coordinates.
        /// Returns a CefBinaryValue containing the pixel data on success or NULL on
        /// failure.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetAsBitmap(float scale_factor
        , cef_color_type_t color_type
        , cef_alpha_type_t alpha_type
        , ref int pixel_width
        , ref int pixel_height
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;
            v2.I32 = (int)color_type;
            v3.I32 = (int)alpha_type;
            v4.I32 = pixel_width;
            v5.I32 = pixel_height;

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefImage_GetAsBitmap_11, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            var ret_result = new CefBinaryValue(ret.Ptr);
            pixel_width = (int)v4.I32; ;
            pixel_height = (int)v5.I32; ;
            return ret_result;
        }

        // gen! CefRefPtr<CefBinaryValue> GetAsPNG(float scale_factor,bool with_transparency,int& pixel_width,int& pixel_height)
        /// <summary>
        /// Returns the PNG representation that most closely matches |scale_factor|. If
        /// |with_transparency| is true any alpha transparency in the image will be
        /// represented in the resulting PNG data. |pixel_width| and |pixel_height| are
        /// the output representation size in pixel coordinates. Returns a
        /// CefBinaryValue containing the PNG image data on success or NULL on failure.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetAsPNG(float scale_factor
        , bool with_transparency
        , ref int pixel_width
        , ref int pixel_height
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;
            v2.I32 = with_transparency ? 1 : 0;
            v3.I32 = pixel_width;
            v4.I32 = pixel_height;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetAsPNG_12, out ret, ref v1, ref v2, ref v3, ref v4);
            var ret_result = new CefBinaryValue(ret.Ptr);
            pixel_width = (int)v3.I32; ;
            pixel_height = (int)v4.I32; ;
            return ret_result;
        }

        // gen! CefRefPtr<CefBinaryValue> GetAsJPEG(float scale_factor,int quality,int& pixel_width,int& pixel_height)
        /// <summary>
        /// Returns the JPEG representation that most closely matches |scale_factor|.
        /// |quality| determines the compression level with 0 == lowest and 100 ==
        /// highest. The JPEG format does not support alpha transparency and the alpha
        /// channel, if any, will be discarded. |pixel_width| and |pixel_height| are
        /// the output representation size in pixel coordinates. Returns a
        /// CefBinaryValue containing the JPEG image data on success or NULL on
        /// failure.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetAsJPEG(float scale_factor
        , int quality
        , ref int pixel_width
        , ref int pixel_height
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor;
            v2.I32 = (int)quality;
            v3.I32 = pixel_width;
            v4.I32 = pixel_height;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetAsJPEG_13, out ret, ref v1, ref v2, ref v3, ref v4);
            var ret_result = new CefBinaryValue(ret.Ptr);
            pixel_width = (int)v3.I32; ;
            pixel_height = (int)v4.I32; ;
            return ret_result;
        }
    }


    // [virtual] class CefMenuModel
    /// <summary>
    /// Supports creation and modification of menus. See cef_menu_id_t for the
    /// command ids that have default implementations. All user-defined command ids
    /// should be between MENU_ID_USER_FIRST and MENU_ID_USER_LAST. The methods of
    /// this class can only be accessed on the browser process the UI thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefMenuModel
    {
        const int _typeNAME = 17;
        const int CefMenuModel_Release_0 = (_typeNAME << 16) | 0;
        const int CefMenuModel_IsSubMenu_1 = (_typeNAME << 16) | 1;
        const int CefMenuModel_Clear_2 = (_typeNAME << 16) | 2;
        const int CefMenuModel_GetCount_3 = (_typeNAME << 16) | 3;
        const int CefMenuModel_AddSeparator_4 = (_typeNAME << 16) | 4;
        const int CefMenuModel_AddItem_5 = (_typeNAME << 16) | 5;
        const int CefMenuModel_AddCheckItem_6 = (_typeNAME << 16) | 6;
        const int CefMenuModel_AddRadioItem_7 = (_typeNAME << 16) | 7;
        const int CefMenuModel_AddSubMenu_8 = (_typeNAME << 16) | 8;
        const int CefMenuModel_InsertSeparatorAt_9 = (_typeNAME << 16) | 9;
        const int CefMenuModel_InsertItemAt_10 = (_typeNAME << 16) | 10;
        const int CefMenuModel_InsertCheckItemAt_11 = (_typeNAME << 16) | 11;
        const int CefMenuModel_InsertRadioItemAt_12 = (_typeNAME << 16) | 12;
        const int CefMenuModel_InsertSubMenuAt_13 = (_typeNAME << 16) | 13;
        const int CefMenuModel_Remove_14 = (_typeNAME << 16) | 14;
        const int CefMenuModel_RemoveAt_15 = (_typeNAME << 16) | 15;
        const int CefMenuModel_GetIndexOf_16 = (_typeNAME << 16) | 16;
        const int CefMenuModel_GetCommandIdAt_17 = (_typeNAME << 16) | 17;
        const int CefMenuModel_SetCommandIdAt_18 = (_typeNAME << 16) | 18;
        const int CefMenuModel_GetLabel_19 = (_typeNAME << 16) | 19;
        const int CefMenuModel_GetLabelAt_20 = (_typeNAME << 16) | 20;
        const int CefMenuModel_SetLabel_21 = (_typeNAME << 16) | 21;
        const int CefMenuModel_SetLabelAt_22 = (_typeNAME << 16) | 22;
        const int CefMenuModel_GetType_23 = (_typeNAME << 16) | 23;
        const int CefMenuModel_GetTypeAt_24 = (_typeNAME << 16) | 24;
        const int CefMenuModel_GetGroupId_25 = (_typeNAME << 16) | 25;
        const int CefMenuModel_GetGroupIdAt_26 = (_typeNAME << 16) | 26;
        const int CefMenuModel_SetGroupId_27 = (_typeNAME << 16) | 27;
        const int CefMenuModel_SetGroupIdAt_28 = (_typeNAME << 16) | 28;
        const int CefMenuModel_GetSubMenu_29 = (_typeNAME << 16) | 29;
        const int CefMenuModel_GetSubMenuAt_30 = (_typeNAME << 16) | 30;
        const int CefMenuModel_IsVisible_31 = (_typeNAME << 16) | 31;
        const int CefMenuModel_IsVisibleAt_32 = (_typeNAME << 16) | 32;
        const int CefMenuModel_SetVisible_33 = (_typeNAME << 16) | 33;
        const int CefMenuModel_SetVisibleAt_34 = (_typeNAME << 16) | 34;
        const int CefMenuModel_IsEnabled_35 = (_typeNAME << 16) | 35;
        const int CefMenuModel_IsEnabledAt_36 = (_typeNAME << 16) | 36;
        const int CefMenuModel_SetEnabled_37 = (_typeNAME << 16) | 37;
        const int CefMenuModel_SetEnabledAt_38 = (_typeNAME << 16) | 38;
        const int CefMenuModel_IsChecked_39 = (_typeNAME << 16) | 39;
        const int CefMenuModel_IsCheckedAt_40 = (_typeNAME << 16) | 40;
        const int CefMenuModel_SetChecked_41 = (_typeNAME << 16) | 41;
        const int CefMenuModel_SetCheckedAt_42 = (_typeNAME << 16) | 42;
        const int CefMenuModel_HasAccelerator_43 = (_typeNAME << 16) | 43;
        const int CefMenuModel_HasAcceleratorAt_44 = (_typeNAME << 16) | 44;
        const int CefMenuModel_SetAccelerator_45 = (_typeNAME << 16) | 45;
        const int CefMenuModel_SetAcceleratorAt_46 = (_typeNAME << 16) | 46;
        const int CefMenuModel_RemoveAccelerator_47 = (_typeNAME << 16) | 47;
        const int CefMenuModel_RemoveAcceleratorAt_48 = (_typeNAME << 16) | 48;
        const int CefMenuModel_GetAccelerator_49 = (_typeNAME << 16) | 49;
        const int CefMenuModel_GetAcceleratorAt_50 = (_typeNAME << 16) | 50;
        const int CefMenuModel_SetColor_51 = (_typeNAME << 16) | 51;
        const int CefMenuModel_SetColorAt_52 = (_typeNAME << 16) | 52;
        const int CefMenuModel_GetColor_53 = (_typeNAME << 16) | 53;
        const int CefMenuModel_GetColorAt_54 = (_typeNAME << 16) | 54;
        const int CefMenuModel_SetFontList_55 = (_typeNAME << 16) | 55;
        const int CefMenuModel_SetFontListAt_56 = (_typeNAME << 16) | 56;
        internal readonly IntPtr nativePtr;
        internal CefMenuModel(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_Release_0, out ret);
        }

        // gen! bool IsSubMenu()
        /// <summary>
        /// CefMenuModel methods.
        /// </summary>

        public bool IsSubMenu()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_IsSubMenu_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool Clear()
        /// <summary>
        /// Clears the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool Clear()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_Clear_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! int GetCount()
        /// <summary>
        /// Returns the number of items in this menu.
        /// /*cef()*/
        /// </summary>

        public int GetCount()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_GetCount_3, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! bool AddSeparator()
        /// <summary>
        /// Add a separator to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool AddSeparator()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_AddSeparator_4, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool AddItem(int command_id,const CefString& label)
        /// <summary>
        /// Add an item to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool AddItem(int command_id
        , string label
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            ;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddItem_5, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }

        // gen! bool AddCheckItem(int command_id,const CefString& label)
        /// <summary>
        /// Add a check item to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool AddCheckItem(int command_id
        , string label
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            ;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddCheckItem_6, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }

        // gen! bool AddRadioItem(int command_id,const CefString& label,int group_id)
        /// <summary>
        /// Add a radio item to the menu. Only a single item with the specified
        /// |group_id| can be checked at a time. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool AddRadioItem(int command_id
        , string label
        , int group_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            ;
            v1.I32 = (int)command_id;
            v3.I32 = (int)group_id;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_AddRadioItem_7, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }

        // gen! CefRefPtr<CefMenuModel> AddSubMenu(int command_id,const CefString& label)
        /// <summary>
        /// Add a sub-menu to the menu. The new sub-menu is returned.
        /// /*cef()*/
        /// </summary>

        public CefMenuModel AddSubMenu(int command_id
        , string label
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            ;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddSubMenu_8, out ret, ref v1, ref v2);
            var ret_result = new CefMenuModel(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }

        // gen! bool InsertSeparatorAt(int index)
        /// <summary>
        /// Insert a separator in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool InsertSeparatorAt(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_InsertSeparatorAt_9, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool InsertItemAt(int index,int command_id,const CefString& label)
        /// <summary>
        /// Insert an item in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool InsertItemAt(int index
        , int command_id
        , string label
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            ;
            v1.I32 = (int)index;
            v2.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertItemAt_10, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v3.Ptr); ;
            return ret_result;
        }

        // gen! bool InsertCheckItemAt(int index,int command_id,const CefString& label)
        /// <summary>
        /// Insert a check item in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool InsertCheckItemAt(int index
        , int command_id
        , string label
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            ;
            v1.I32 = (int)index;
            v2.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertCheckItemAt_11, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v3.Ptr); ;
            return ret_result;
        }

        // gen! bool InsertRadioItemAt(int index,int command_id,const CefString& label,int group_id)
        /// <summary>
        /// Insert a radio item in the menu at the specified |index|. Only a single
        /// item with the specified |group_id| can be checked at a time. Returns true
        /// on success.
        /// /*cef()*/
        /// </summary>

        public bool InsertRadioItemAt(int index
        , int command_id
        , string label
        , int group_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            ;
            v1.I32 = (int)index;
            v2.I32 = (int)command_id;
            v4.I32 = (int)group_id;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefMenuModel_InsertRadioItemAt_12, out ret, ref v1, ref v2, ref v3, ref v4);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v3.Ptr); ;
            return ret_result;
        }

        // gen! CefRefPtr<CefMenuModel> InsertSubMenuAt(int index,int command_id,const CefString& label)
        /// <summary>
        /// Insert a sub-menu in the menu at the specified |index|. The new sub-menu
        /// is returned.
        /// /*cef()*/
        /// </summary>

        public CefMenuModel InsertSubMenuAt(int index
        , int command_id
        , string label
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            ;
            v1.I32 = (int)index;
            v2.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertSubMenuAt_13, out ret, ref v1, ref v2, ref v3);
            var ret_result = new CefMenuModel(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v3.Ptr); ;
            return ret_result;
        }

        // gen! bool Remove(int command_id)
        /// <summary>
        /// Removes the item with the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool Remove(int command_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_Remove_14, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool RemoveAt(int index)
        /// <summary>
        /// Removes the item at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool RemoveAt(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAt_15, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! int GetIndexOf(int command_id)
        /// <summary>
        /// Returns the index associated with the specified |command_id| or -1 if not
        /// found due to the command id not existing in the menu.
        /// /*cef()*/
        /// </summary>

        public int GetIndexOf(int command_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetIndexOf_16, out ret, ref v1);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int GetCommandIdAt(int index)
        /// <summary>
        /// Returns the command id at the specified |index| or -1 if not found due to
        /// invalid range or the index being a separator.
        /// /*cef()*/
        /// </summary>

        public int GetCommandIdAt(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetCommandIdAt_17, out ret, ref v1);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! bool SetCommandIdAt(int index,int command_id)
        /// <summary>
        /// Sets the command id at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetCommandIdAt(int index
        , int command_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetCommandIdAt_18, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefString GetLabel(int command_id)
        /// <summary>
        /// Returns the label for the specified |command_id| or empty if not found.
        /// /*cef()*/
        /// </summary>

        public string GetLabel(int command_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetLabel_19, out ret, ref v1);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetLabelAt(int index)
        /// <summary>
        /// Returns the label at the specified |index| or empty if not found due to
        /// invalid range or the index being a separator.
        /// /*cef()*/
        /// </summary>

        public string GetLabelAt(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetLabelAt_20, out ret, ref v1);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! bool SetLabel(int command_id,const CefString& label)
        /// <summary>
        /// Sets the label for the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetLabel(int command_id
        , string label
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            ;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetLabel_21, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }

        // gen! bool SetLabelAt(int index,const CefString& label)
        /// <summary>
        /// Set the label at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetLabelAt(int index
        , string label
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            ;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetLabelAt_22, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }

        // gen! MenuItemType GetType(int command_id)
        /// <summary>
        /// Returns the item type for the specified |command_id|.
        /// /*cef(default_retval=MENUITEMTYPE_NONE)*/
        /// </summary>

        public cef_menu_item_type_t _GetType(int command_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetType_23, out ret, ref v1);
            var ret_result = (cef_menu_item_type_t)ret.I32;

            return ret_result;
        }

        // gen! MenuItemType GetTypeAt(int index)
        /// <summary>
        /// Returns the item type at the specified |index|.
        /// /*cef(default_retval=MENUITEMTYPE_NONE)*/
        /// </summary>

        public cef_menu_item_type_t GetTypeAt(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetTypeAt_24, out ret, ref v1);
            var ret_result = (cef_menu_item_type_t)ret.I32;

            return ret_result;
        }

        // gen! int GetGroupId(int command_id)
        /// <summary>
        /// Returns the group id for the specified |command_id| or -1 if invalid.
        /// /*cef()*/
        /// </summary>

        public int GetGroupId(int command_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetGroupId_25, out ret, ref v1);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int GetGroupIdAt(int index)
        /// <summary>
        /// Returns the group id at the specified |index| or -1 if invalid.
        /// /*cef()*/
        /// </summary>

        public int GetGroupIdAt(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetGroupIdAt_26, out ret, ref v1);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! bool SetGroupId(int command_id,int group_id)
        /// <summary>
        /// Sets the group id for the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetGroupId(int command_id
        , int group_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = (int)group_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetGroupId_27, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetGroupIdAt(int index,int group_id)
        /// <summary>
        /// Sets the group id at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetGroupIdAt(int index
        , int group_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = (int)group_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetGroupIdAt_28, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefMenuModel> GetSubMenu(int command_id)
        /// <summary>
        /// Returns the submenu for the specified |command_id| or empty if invalid.
        /// /*cef()*/
        /// </summary>

        public CefMenuModel GetSubMenu(int command_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetSubMenu_29, out ret, ref v1);
            var ret_result = new CefMenuModel(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefMenuModel> GetSubMenuAt(int index)
        /// <summary>
        /// Returns the submenu at the specified |index| or empty if invalid.
        /// /*cef()*/
        /// </summary>

        public CefMenuModel GetSubMenuAt(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetSubMenuAt_30, out ret, ref v1);
            var ret_result = new CefMenuModel(ret.Ptr);
            return ret_result;
        }

        // gen! bool IsVisible(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| is visible.
        /// /*cef()*/
        /// </summary>

        public bool IsVisible(int command_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsVisible_31, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsVisibleAt(int index)
        /// <summary>
        /// Returns true if the specified |index| is visible.
        /// /*cef()*/
        /// </summary>

        public bool IsVisibleAt(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsVisibleAt_32, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetVisible(int command_id,bool visible)
        /// <summary>
        /// Change the visibility of the specified |command_id|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool SetVisible(int command_id
        , bool visible
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = visible ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetVisible_33, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetVisibleAt(int index,bool visible)
        /// <summary>
        /// Change the visibility at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetVisibleAt(int index
        , bool visible
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = visible ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetVisibleAt_34, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsEnabled(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| is enabled.
        /// /*cef()*/
        /// </summary>

        public bool IsEnabled(int command_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsEnabled_35, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsEnabledAt(int index)
        /// <summary>
        /// Returns true if the specified |index| is enabled.
        /// /*cef()*/
        /// </summary>

        public bool IsEnabledAt(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsEnabledAt_36, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetEnabled(int command_id,bool enabled)
        /// <summary>
        /// Change the enabled status of the specified |command_id|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool SetEnabled(int command_id
        , bool enabled
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = enabled ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetEnabled_37, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetEnabledAt(int index,bool enabled)
        /// <summary>
        /// Change the enabled status at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool SetEnabledAt(int index
        , bool enabled
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = enabled ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetEnabledAt_38, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsChecked(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| is checked. Only applies to
        /// check and radio items.
        /// /*cef()*/
        /// </summary>

        public bool IsChecked(int command_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsChecked_39, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsCheckedAt(int index)
        /// <summary>
        /// Returns true if the specified |index| is checked. Only applies to check
        /// and radio items.
        /// /*cef()*/
        /// </summary>

        public bool IsCheckedAt(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsCheckedAt_40, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetChecked(int command_id,bool checked)
        /// <summary>
        /// Check the specified |command_id|. Only applies to check and radio items.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetChecked(int command_id
        , bool _checked
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = _checked ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetChecked_41, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetCheckedAt(int index,bool checked)
        /// <summary>
        /// Check the specified |index|. Only applies to check and radio items. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetCheckedAt(int index
        , bool _checked
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = _checked ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetCheckedAt_42, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool HasAccelerator(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| has a keyboard accelerator
        /// assigned.
        /// /*cef()*/
        /// </summary>

        public bool HasAccelerator(int command_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_HasAccelerator_43, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool HasAcceleratorAt(int index)
        /// <summary>
        /// Returns true if the specified |index| has a keyboard accelerator assigned.
        /// /*cef()*/
        /// </summary>

        public bool HasAcceleratorAt(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_HasAcceleratorAt_44, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetAccelerator(int command_id,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
        /// <summary>
        /// Set the keyboard accelerator for the specified |command_id|. |key_code| can
        /// be any virtual key or character value. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetAccelerator(int command_id
        , int key_code
        , bool shift_pressed
        , bool ctrl_pressed
        , bool alt_pressed
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = (int)key_code;
            v3.I32 = shift_pressed ? 1 : 0;
            v4.I32 = ctrl_pressed ? 1 : 0;
            v5.I32 = alt_pressed ? 1 : 0;

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_SetAccelerator_45, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetAcceleratorAt(int index,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
        /// <summary>
        /// Set the keyboard accelerator at the specified |index|. |key_code| can be
        /// any virtual key or character value. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetAcceleratorAt(int index
        , int key_code
        , bool shift_pressed
        , bool ctrl_pressed
        , bool alt_pressed
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = (int)key_code;
            v3.I32 = shift_pressed ? 1 : 0;
            v4.I32 = ctrl_pressed ? 1 : 0;
            v5.I32 = alt_pressed ? 1 : 0;

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_SetAcceleratorAt_46, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool RemoveAccelerator(int command_id)
        /// <summary>
        /// Remove the keyboard accelerator for the specified |command_id|. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>

        public bool RemoveAccelerator(int command_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAccelerator_47, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool RemoveAcceleratorAt(int index)
        /// <summary>
        /// Remove the keyboard accelerator at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>

        public bool RemoveAcceleratorAt(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAcceleratorAt_48, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool GetAccelerator(int command_id,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
        /// <summary>
        /// Retrieves the keyboard accelerator for the specified |command_id|. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>

        public bool GetAccelerator(int command_id
        , ref int key_code
        , ref bool shift_pressed
        , ref bool ctrl_pressed
        , ref bool alt_pressed
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = key_code;
            v3.I32 = (shift_pressed ? 1 : 0);
            v4.I32 = (ctrl_pressed ? 1 : 0);
            v5.I32 = (alt_pressed ? 1 : 0);

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_GetAccelerator_49, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            var ret_result = ret.I32 != 0;
            key_code = (int)v2.I32; ;
            shift_pressed = v3.I32 != 0; ;
            ctrl_pressed = v4.I32 != 0; ;
            alt_pressed = v5.I32 != 0; ;
            return ret_result;
        }

        // gen! bool GetAcceleratorAt(int index,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
        /// <summary>
        /// Retrieves the keyboard accelerator for the specified |index|. Returns true
        /// on success.
        /// /*cef()*/
        /// </summary>

        public bool GetAcceleratorAt(int index
        , ref int key_code
        , ref bool shift_pressed
        , ref bool ctrl_pressed
        , ref bool alt_pressed
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = key_code;
            v3.I32 = (shift_pressed ? 1 : 0);
            v4.I32 = (ctrl_pressed ? 1 : 0);
            v5.I32 = (alt_pressed ? 1 : 0);

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_GetAcceleratorAt_50, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            var ret_result = ret.I32 != 0;
            key_code = (int)v2.I32; ;
            shift_pressed = v3.I32 != 0; ;
            ctrl_pressed = v4.I32 != 0; ;
            alt_pressed = v5.I32 != 0; ;
            return ret_result;
        }

        // gen! bool SetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t color)
        /// <summary>
        /// Set the explicit color for |command_id| and |color_type| to |color|.
        /// Specify a |color| value of 0 to remove the explicit color. If no explicit
        /// color or default color is set for |color_type| then the system color will
        /// be used. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetColor(int command_id
        , cef_menu_color_type_t color_type
        , IntPtr color
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = (int)color_type;
            v3.I32 = (int)color;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_SetColor_51, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetColorAt(int index,cef_menu_color_type_t color_type,cef_color_t color)
        /// <summary>
        /// Set the explicit color for |command_id| and |index| to |color|. Specify a
        /// |color| value of 0 to remove the explicit color. Specify an |index| value
        /// of -1 to set the default color for items that do not have an explicit
        /// color set. If no explicit color or default color is set for |color_type|
        /// then the system color will be used. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetColorAt(int index
        , cef_menu_color_type_t color_type
        , IntPtr color
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = (int)color_type;
            v3.I32 = (int)color;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_SetColorAt_52, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool GetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t& color)
        /// <summary>
        /// Returns in |color| the color that was explicitly set for |command_id| and
        /// |color_type|. If a color was not set then 0 will be returned in |color|.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool GetColor(int command_id
        , cef_menu_color_type_t color_type
        , cef_color_t color
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id;
            v2.I32 = (int)color_type;
            v3.Ptr = color.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_GetColor_53, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool GetColorAt(int index,cef_menu_color_type_t color_type,cef_color_t& color)
        /// <summary>
        /// Returns in |color| the color that was explicitly set for |command_id| and
        /// |color_type|. Specify an |index| value of -1 to return the default color
        /// in |color|. If a color was not set then 0 will be returned in |color|.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool GetColorAt(int index
        , cef_menu_color_type_t color_type
        , cef_color_t color
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = (int)color_type;
            v3.Ptr = color.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_GetColorAt_54, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetFontList(int command_id,const CefString& font_list)
        /// <summary>
        /// Sets the font list for the specified |command_id|. If |font_list| is empty
        /// the system font will be used. Returns true on success. The format is
        /// "<FONT_FAMILY_LIST>,[STYLES] <SIZE>", where:
        /// - FONT_FAMILY_LIST is a comma-separated list of font family names,
        /// - STYLES is an optional space-separated list of style names (case-sensitive
        ///   "Bold" and "Italic" are supported), and
        /// - SIZE is an integer font size in pixels with the suffix "px".
        ///
        /// Here are examples of valid font description strings:
        /// - "Arial, Helvetica, Bold Italic 14px"
        /// - "Arial, 14px"
        /// /*cef(optional_param=font_list)*/
        /// </summary>

        public bool SetFontList(int command_id
        , string font_list
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(font_list);
            ;
            v1.I32 = (int)command_id;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetFontList_55, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }

        // gen! bool SetFontListAt(int index,const CefString& font_list)
        /// <summary>
        /// Sets the font list for the specified |index|. Specify an |index| value of
        /// -1 to set the default font. If |font_list| is empty the system font will
        /// be used. Returns true on success. The format is
        /// "<FONT_FAMILY_LIST>,[STYLES] <SIZE>", where:
        /// - FONT_FAMILY_LIST is a comma-separated list of font family names,
        /// - STYLES is an optional space-separated list of style names (case-sensitive
        ///   "Bold" and "Italic" are supported), and
        /// - SIZE is an integer font size in pixels with the suffix "px".
        ///
        /// Here are examples of valid font description strings:
        /// - "Arial, Helvetica, Bold Italic 14px"
        /// - "Arial, 14px"
        /// /*cef(optional_param=font_list)*/
        /// </summary>

        public bool SetFontListAt(int index
        , string font_list
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(font_list);
            ;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetFontListAt_56, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }
    }


    // [virtual] class CefMenuModelDelegate
    /// <summary>
    /// Implement this interface to handle menu model events. The methods of this
    /// class will be called on the browser process UI thread unless otherwise
    /// indicated.
    /// /*(source=client)*/
    /// </summary>
    public struct CefMenuModelDelegate
    {
        const int _typeNAME = 18;
        const int CefMenuModelDelegate_Release_0 = (_typeNAME << 16) | 0;
        internal readonly IntPtr nativePtr;
        internal CefMenuModelDelegate(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModelDelegate_Release_0, out ret);
        }
    }


    // [virtual] class CefNavigationEntry
    /// <summary>
    /// Class used to represent an entry in navigation history.
    /// /*(source=library)*/
    /// </summary>
    public struct CefNavigationEntry
    {
        const int _typeNAME = 19;
        const int CefNavigationEntry_Release_0 = (_typeNAME << 16) | 0;
        const int CefNavigationEntry_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefNavigationEntry_GetURL_2 = (_typeNAME << 16) | 2;
        const int CefNavigationEntry_GetDisplayURL_3 = (_typeNAME << 16) | 3;
        const int CefNavigationEntry_GetOriginalURL_4 = (_typeNAME << 16) | 4;
        const int CefNavigationEntry_GetTitle_5 = (_typeNAME << 16) | 5;
        const int CefNavigationEntry_GetTransitionType_6 = (_typeNAME << 16) | 6;
        const int CefNavigationEntry_HasPostData_7 = (_typeNAME << 16) | 7;
        const int CefNavigationEntry_GetCompletionTime_8 = (_typeNAME << 16) | 8;
        const int CefNavigationEntry_GetHttpStatusCode_9 = (_typeNAME << 16) | 9;
        const int CefNavigationEntry_GetSSLStatus_10 = (_typeNAME << 16) | 10;
        internal readonly IntPtr nativePtr;
        internal CefNavigationEntry(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_Release_0, out ret);
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefNavigationEntry methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_IsValid_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefString GetURL()
        /// <summary>
        /// Returns the actual URL of the page. For some pages this may be data: URL or
        /// similar. Use GetDisplayURL() to return a display-friendly version.
        /// /*cef()*/
        /// </summary>

        public string GetURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetURL_2, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetDisplayURL()
        /// <summary>
        /// Returns a display-friendly version of the URL.
        /// /*cef()*/
        /// </summary>

        public string GetDisplayURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetDisplayURL_3, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetOriginalURL()
        /// <summary>
        /// Returns the original URL that was entered by the user before any redirects.
        /// /*cef()*/
        /// </summary>

        public string GetOriginalURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetOriginalURL_4, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetTitle()
        /// <summary>
        /// Returns the title set by the page. This value may be empty.
        /// /*cef()*/
        /// </summary>

        public string GetTitle()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetTitle_5, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! TransitionType GetTransitionType()
        /// <summary>
        /// Returns the transition type which indicates what the user did to move to
        /// this page from the previous page.
        /// /*cef(default_retval=TT_EXPLICIT)*/
        /// </summary>

        public cef_transition_type_t GetTransitionType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetTransitionType_6, out ret);
            var ret_result = (cef_transition_type_t)ret.I32;

            return ret_result;
        }

        // gen! bool HasPostData()
        /// <summary>
        /// Returns true if this navigation includes post data.
        /// /*cef()*/
        /// </summary>

        public bool HasPostData()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_HasPostData_7, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefTime GetCompletionTime()
        /// <summary>
        /// Returns the time for the last known successful navigation completion. A
        /// navigation may be completed more than once if the page is reloaded. May be
        /// 0 if the navigation has not yet completed.
        /// /*cef()*/
        /// </summary>

        public CefTime GetCompletionTime()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetCompletionTime_8, out ret);
            var ret_result = new CefTime(ret.Ptr);

            return ret_result;
        }

        // gen! int GetHttpStatusCode()
        /// <summary>
        /// Returns the HTTP status code for the last known successful navigation
        /// response. May be 0 if the response has not yet been received or if the
        /// navigation has not yet completed.
        /// /*cef()*/
        /// </summary>

        public int GetHttpStatusCode()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetHttpStatusCode_9, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! CefRefPtr<CefSSLStatus> GetSSLStatus()
        /// <summary>
        /// Returns the SSL information for this navigation entry.
        /// /*cef()*/
        /// </summary>

        public CefSSLStatus GetSSLStatus()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetSSLStatus_10, out ret);
            var ret_result = new CefSSLStatus(ret.Ptr);
            return ret_result;
        }
    }


    // [virtual] class CefPrintSettings
    /// <summary>
    /// Class representing print settings.
    /// /*(source=library)*/
    /// </summary>
    public struct CefPrintSettings
    {
        const int _typeNAME = 20;
        const int CefPrintSettings_Release_0 = (_typeNAME << 16) | 0;
        const int CefPrintSettings_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefPrintSettings_IsReadOnly_2 = (_typeNAME << 16) | 2;
        const int CefPrintSettings_Copy_3 = (_typeNAME << 16) | 3;
        const int CefPrintSettings_SetOrientation_4 = (_typeNAME << 16) | 4;
        const int CefPrintSettings_IsLandscape_5 = (_typeNAME << 16) | 5;
        const int CefPrintSettings_SetPrinterPrintableArea_6 = (_typeNAME << 16) | 6;
        const int CefPrintSettings_SetDeviceName_7 = (_typeNAME << 16) | 7;
        const int CefPrintSettings_GetDeviceName_8 = (_typeNAME << 16) | 8;
        const int CefPrintSettings_SetDPI_9 = (_typeNAME << 16) | 9;
        const int CefPrintSettings_GetDPI_10 = (_typeNAME << 16) | 10;
        const int CefPrintSettings_SetPageRanges_11 = (_typeNAME << 16) | 11;
        const int CefPrintSettings_GetPageRangesCount_12 = (_typeNAME << 16) | 12;
        const int CefPrintSettings_GetPageRanges_13 = (_typeNAME << 16) | 13;
        const int CefPrintSettings_SetSelectionOnly_14 = (_typeNAME << 16) | 14;
        const int CefPrintSettings_IsSelectionOnly_15 = (_typeNAME << 16) | 15;
        const int CefPrintSettings_SetCollate_16 = (_typeNAME << 16) | 16;
        const int CefPrintSettings_WillCollate_17 = (_typeNAME << 16) | 17;
        const int CefPrintSettings_SetColorModel_18 = (_typeNAME << 16) | 18;
        const int CefPrintSettings_GetColorModel_19 = (_typeNAME << 16) | 19;
        const int CefPrintSettings_SetCopies_20 = (_typeNAME << 16) | 20;
        const int CefPrintSettings_GetCopies_21 = (_typeNAME << 16) | 21;
        const int CefPrintSettings_SetDuplexMode_22 = (_typeNAME << 16) | 22;
        const int CefPrintSettings_GetDuplexMode_23 = (_typeNAME << 16) | 23;
        internal readonly IntPtr nativePtr;
        internal CefPrintSettings(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_Release_0, out ret);
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefPrintSettings methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsValid_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsReadOnly_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefPrintSettings> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>

        public CefPrintSettings Copy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_Copy_3, out ret);
            var ret_result = new CefPrintSettings(ret.Ptr);
            return ret_result;
        }

        // gen! void SetOrientation(bool landscape)
        /// <summary>
        /// Set the page orientation.
        /// /*cef()*/
        /// </summary>

        public void SetOrientation(bool landscape
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = landscape ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetOrientation_4, out ret, ref v1);

        }

        // gen! bool IsLandscape()
        /// <summary>
        /// Returns true if the orientation is landscape.
        /// /*cef()*/
        /// </summary>

        public bool IsLandscape()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsLandscape_5, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void SetPrinterPrintableArea(const CefSize& physical_size_device_units,const CefRect& printable_area_device_units,bool landscape_needs_flip)
        /// <summary>
        /// Set the printer printable area in device units.
        /// Some platforms already provide flipped area. Set |landscape_needs_flip|
        /// to false on those platforms to avoid double flipping.
        /// /*cef()*/
        /// </summary>

        public void SetPrinterPrintableArea(CefSize physical_size_device_units
        , CefRect printable_area_device_units
        , bool landscape_needs_flip
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = physical_size_device_units.nativePtr;
            v2.Ptr = printable_area_device_units.nativePtr;
            v3.I32 = landscape_needs_flip ? 1 : 0;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefPrintSettings_SetPrinterPrintableArea_6, out ret, ref v1, ref v2, ref v3);

        }

        // gen! void SetDeviceName(const CefString& name)
        /// <summary>
        /// Set the device name.
        /// /*cef(optional_param=name)*/
        /// </summary>

        public void SetDeviceName(string name
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDeviceName_7, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! CefString GetDeviceName()
        /// <summary>
        /// Get the device name.
        /// /*cef()*/
        /// </summary>

        public string GetDeviceName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDeviceName_8, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! void SetDPI(int dpi)
        /// <summary>
        /// Set the DPI (dots per inch).
        /// /*cef()*/
        /// </summary>

        public void SetDPI(int dpi
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)dpi;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDPI_9, out ret, ref v1);

        }

        // gen! int GetDPI()
        /// <summary>
        /// Get the DPI (dots per inch).
        /// /*cef()*/
        /// </summary>

        public int GetDPI()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDPI_10, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! void SetPageRanges(const PageRangeList& ranges)
        /// <summary>
        /// Set the page ranges.
        /// /*cef()*/
        /// </summary>

        public void SetPageRanges(PageRangeList ranges
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = ranges.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetPageRanges_11, out ret, ref v1);

        }

        // gen! size_t GetPageRangesCount()
        /// <summary>
        /// Returns the number of page ranges that currently exist.
        /// /*cef()*/
        /// </summary>

        public uint GetPageRangesCount()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetPageRangesCount_12, out ret);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! void GetPageRanges(PageRangeList& ranges)
        /// <summary>
        /// Retrieve the page ranges.
        /// /*cef(count_func=ranges:GetPageRangesCount)*/
        /// </summary>

        public void GetPageRanges(PageRangeList ranges
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = ranges.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_GetPageRanges_13, out ret, ref v1);

        }

        // gen! void SetSelectionOnly(bool selection_only)
        /// <summary>
        /// Set whether only the selection will be printed.
        /// /*cef()*/
        /// </summary>

        public void SetSelectionOnly(bool selection_only
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = selection_only ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetSelectionOnly_14, out ret, ref v1);

        }

        // gen! bool IsSelectionOnly()
        /// <summary>
        /// Returns true if only the selection will be printed.
        /// /*cef()*/
        /// </summary>

        public bool IsSelectionOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsSelectionOnly_15, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void SetCollate(bool collate)
        /// <summary>
        /// Set whether pages will be collated.
        /// /*cef()*/
        /// </summary>

        public void SetCollate(bool collate
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = collate ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetCollate_16, out ret, ref v1);

        }

        // gen! bool WillCollate()
        /// <summary>
        /// Returns true if pages will be collated.
        /// /*cef()*/
        /// </summary>

        public bool WillCollate()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_WillCollate_17, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void SetColorModel(ColorModel model)
        /// <summary>
        /// Set the color model.
        /// /*cef()*/
        /// </summary>

        public void SetColorModel(cef_color_model_t model
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)model;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetColorModel_18, out ret, ref v1);

        }

        // gen! ColorModel GetColorModel()
        /// <summary>
        /// Get the color model.
        /// /*cef(default_retval=COLOR_MODEL_UNKNOWN)*/
        /// </summary>

        public cef_color_model_t GetColorModel()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetColorModel_19, out ret);
            var ret_result = (cef_color_model_t)ret.I32;

            return ret_result;
        }

        // gen! void SetCopies(int copies)
        /// <summary>
        /// Set the number of copies.
        /// /*cef()*/
        /// </summary>

        public void SetCopies(int copies
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)copies;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetCopies_20, out ret, ref v1);

        }

        // gen! int GetCopies()
        /// <summary>
        /// Get the number of copies.
        /// /*cef()*/
        /// </summary>

        public int GetCopies()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetCopies_21, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! void SetDuplexMode(DuplexMode mode)
        /// <summary>
        /// Set the duplex mode.
        /// /*cef()*/
        /// </summary>

        public void SetDuplexMode(cef_duplex_mode_t mode
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)mode;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDuplexMode_22, out ret, ref v1);

        }

        // gen! DuplexMode GetDuplexMode()
        /// <summary>
        /// Get the duplex mode.
        /// /*cef(default_retval=DUPLEX_MODE_UNKNOWN)*/
        /// </summary>

        public cef_duplex_mode_t GetDuplexMode()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDuplexMode_23, out ret);
            var ret_result = (cef_duplex_mode_t)ret.I32;

            return ret_result;
        }
    }


    // [virtual] class CefProcessMessage
    /// <summary>
    /// Class representing a message. Can be used on any process and thread.
    /// /*cef(source=library)*/
    /// </summary>
    public struct CefProcessMessage
    {
        const int _typeNAME = 21;
        const int CefProcessMessage_Release_0 = (_typeNAME << 16) | 0;
        const int CefProcessMessage_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefProcessMessage_IsReadOnly_2 = (_typeNAME << 16) | 2;
        const int CefProcessMessage_Copy_3 = (_typeNAME << 16) | 3;
        const int CefProcessMessage_GetName_4 = (_typeNAME << 16) | 4;
        const int CefProcessMessage_GetArgumentList_5 = (_typeNAME << 16) | 5;
        internal readonly IntPtr nativePtr;
        internal CefProcessMessage(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_Release_0, out ret);
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefProcessMessage methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_IsValid_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_IsReadOnly_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefProcessMessage> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>

        public CefProcessMessage Copy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_Copy_3, out ret);
            var ret_result = new CefProcessMessage(ret.Ptr);
            return ret_result;
        }

        // gen! CefString GetName()
        /// <summary>
        /// Returns the message name.
        /// /*cef()*/
        /// </summary>

        public string GetName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_GetName_4, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefRefPtr<CefListValue> GetArgumentList()
        /// <summary>
        /// Returns the list of arguments.
        /// /*cef()*/
        /// </summary>

        public CefListValue GetArgumentList()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_GetArgumentList_5, out ret);
            var ret_result = new CefListValue(ret.Ptr);
            return ret_result;
        }
    }


    // [virtual] class CefRequest
    /// <summary>
    /// Class used to represent a web request. The methods of this class may be
    /// called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefRequest
    {
        const int _typeNAME = 22;
        const int CefRequest_Release_0 = (_typeNAME << 16) | 0;
        const int CefRequest_IsReadOnly_1 = (_typeNAME << 16) | 1;
        const int CefRequest_GetURL_2 = (_typeNAME << 16) | 2;
        const int CefRequest_SetURL_3 = (_typeNAME << 16) | 3;
        const int CefRequest_GetMethod_4 = (_typeNAME << 16) | 4;
        const int CefRequest_SetMethod_5 = (_typeNAME << 16) | 5;
        const int CefRequest_SetReferrer_6 = (_typeNAME << 16) | 6;
        const int CefRequest_GetReferrerURL_7 = (_typeNAME << 16) | 7;
        const int CefRequest_GetReferrerPolicy_8 = (_typeNAME << 16) | 8;
        const int CefRequest_GetPostData_9 = (_typeNAME << 16) | 9;
        const int CefRequest_SetPostData_10 = (_typeNAME << 16) | 10;
        const int CefRequest_GetHeaderMap_11 = (_typeNAME << 16) | 11;
        const int CefRequest_SetHeaderMap_12 = (_typeNAME << 16) | 12;
        const int CefRequest_Set_13 = (_typeNAME << 16) | 13;
        const int CefRequest_GetFlags_14 = (_typeNAME << 16) | 14;
        const int CefRequest_SetFlags_15 = (_typeNAME << 16) | 15;
        const int CefRequest_GetFirstPartyForCookies_16 = (_typeNAME << 16) | 16;
        const int CefRequest_SetFirstPartyForCookies_17 = (_typeNAME << 16) | 17;
        const int CefRequest_GetResourceType_18 = (_typeNAME << 16) | 18;
        const int CefRequest_GetTransitionType_19 = (_typeNAME << 16) | 19;
        const int CefRequest_GetIdentifier_20 = (_typeNAME << 16) | 20;
        internal readonly IntPtr nativePtr;
        internal CefRequest(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_Release_0, out ret);
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefRequest methods.
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_IsReadOnly_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefString GetURL()
        /// <summary>
        /// Get the fully qualified URL.
        /// /*cef()*/
        /// </summary>

        public string GetURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetURL_2, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! void SetURL(const CefString& url)
        /// <summary>
        /// Set the fully qualified URL.
        /// /*cef()*/
        /// </summary>

        public void SetURL(string url
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetURL_3, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! CefString GetMethod()
        /// <summary>
        /// Get the request method type. The value will default to POST if post data
        /// is provided and GET otherwise.
        /// /*cef()*/
        /// </summary>

        public string GetMethod()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetMethod_4, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! void SetMethod(const CefString& method)
        /// <summary>
        /// Set the request method type.
        /// /*cef()*/
        /// </summary>

        public void SetMethod(string method
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(method);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetMethod_5, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void SetReferrer(const CefString& referrer_url,ReferrerPolicy policy)
        /// <summary>
        /// Set the referrer URL and policy. If non-empty the referrer URL must be
        /// fully qualified with an HTTP or HTTPS scheme component. Any username,
        /// password or ref component will be removed.
        /// /*cef()*/
        /// </summary>

        public void SetReferrer(string referrer_url
        , cef_referrer_policy_t policy
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(referrer_url);
            ;
            v2.I32 = (int)policy;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequest_SetReferrer_6, out ret, ref v1, ref v2);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! CefString GetReferrerURL()
        /// <summary>
        /// Get the referrer URL.
        /// /*cef()*/
        /// </summary>

        public string GetReferrerURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetReferrerURL_7, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! ReferrerPolicy GetReferrerPolicy()
        /// <summary>
        /// Get the referrer policy.
        /// /*cef(default_retval=REFERRER_POLICY_DEFAULT)*/
        /// </summary>

        public cef_referrer_policy_t GetReferrerPolicy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetReferrerPolicy_8, out ret);
            var ret_result = (cef_referrer_policy_t)ret.I32;

            return ret_result;
        }

        // gen! CefRefPtr<CefPostData> GetPostData()
        /// <summary>
        /// Get the post data.
        /// /*cef()*/
        /// </summary>

        public CefPostData GetPostData()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetPostData_9, out ret);
            var ret_result = new CefPostData(ret.Ptr);
            return ret_result;
        }

        // gen! void SetPostData(CefRefPtr<CefPostData> postData)
        /// <summary>
        /// Set the post data.
        /// /*cef()*/
        /// </summary>

        public void SetPostData(CefPostData postData
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = postData.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetPostData_10, out ret, ref v1);

        }

        // gen! void GetHeaderMap(HeaderMap& headerMap)
        /// <summary>
        /// Get the header values. Will not include the Referer value if any.
        /// /*cef()*/
        /// </summary>

        public void GetHeaderMap(HeaderMap headerMap
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = headerMap.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_GetHeaderMap_11, out ret, ref v1);

        }

        // gen! void SetHeaderMap(const HeaderMap& headerMap)
        /// <summary>
        /// Set the header values. If a Referer value exists in the header map it will
        /// be removed and ignored.
        /// /*cef()*/
        /// </summary>

        public void SetHeaderMap(HeaderMap headerMap
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = headerMap.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetHeaderMap_12, out ret, ref v1);

        }

        // gen! void Set(const CefString& url,const CefString& method,CefRefPtr<CefPostData> postData,const HeaderMap& headerMap)
        /// <summary>
        /// Set all values at one time.
        /// /*cef(optional_param=postData)*/
        /// </summary>

        public void Set(string url
        , string method
        , CefPostData postData
        , HeaderMap headerMap
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(method);
            ;
            v3.Ptr = postData.nativePtr;
            v4.Ptr = headerMap.nativePtr;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefRequest_Set_13, out ret, ref v1, ref v2, ref v3, ref v4);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
        }

        // gen! int GetFlags()
        /// <summary>
        /// Get the flags used in combination with CefURLRequest. See
        /// cef_urlrequest_flags_t for supported values.
        /// /*cef(default_retval=UR_FLAG_NONE)*/
        /// </summary>

        public int GetFlags()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetFlags_14, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! void SetFlags(int flags)
        /// <summary>
        /// Set the flags used in combination with CefURLRequest.  See
        /// cef_urlrequest_flags_t for supported values.
        /// /*cef()*/
        /// </summary>

        public void SetFlags(int flags
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)flags;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetFlags_15, out ret, ref v1);

        }

        // gen! CefString GetFirstPartyForCookies()
        /// <summary>
        /// Set the URL to the first party for cookies used in combination with
        /// CefURLRequest.
        /// /*cef()*/
        /// </summary>

        public string GetFirstPartyForCookies()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetFirstPartyForCookies_16, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! void SetFirstPartyForCookies(const CefString& url)
        /// <summary>
        /// Get the URL to the first party for cookies used in combination with
        /// CefURLRequest.
        /// /*cef()*/
        /// </summary>

        public void SetFirstPartyForCookies(string url
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetFirstPartyForCookies_17, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! ResourceType GetResourceType()
        /// <summary>
        /// Get the resource type for this request. Only available in the browser
        /// process.
        /// /*cef(default_retval=RT_SUB_RESOURCE)*/
        /// </summary>

        public cef_resource_type_t GetResourceType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetResourceType_18, out ret);
            var ret_result = (cef_resource_type_t)ret.I32;

            return ret_result;
        }

        // gen! TransitionType GetTransitionType()
        /// <summary>
        /// Get the transition type for this request. Only available in the browser
        /// process and only applies to requests that represent a main frame or
        /// sub-frame navigation.
        /// /*cef(default_retval=TT_EXPLICIT)*/
        /// </summary>

        public cef_transition_type_t GetTransitionType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetTransitionType_19, out ret);
            var ret_result = (cef_transition_type_t)ret.I32;

            return ret_result;
        }

        // gen! uint64 GetIdentifier()
        /// <summary>
        /// Returns the globally unique identifier for this request or 0 if not
        /// specified. Can be used by CefRequestHandler implementations in the browser
        /// process to track a single request across multiple callbacks.
        /// /*cef()*/
        /// </summary>

        public ulong GetIdentifier()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetIdentifier_20, out ret);
            var ret_result = (ulong)ret.I64;
            return ret_result;
        }
    }


    // [virtual] class CefPostData
    /// <summary>
    /// Class used to represent post data for a web request. The methods of this
    /// class may be called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefPostData
    {
        const int _typeNAME = 23;
        const int CefPostData_Release_0 = (_typeNAME << 16) | 0;
        const int CefPostData_IsReadOnly_1 = (_typeNAME << 16) | 1;
        const int CefPostData_HasExcludedElements_2 = (_typeNAME << 16) | 2;
        const int CefPostData_GetElementCount_3 = (_typeNAME << 16) | 3;
        const int CefPostData_GetElements_4 = (_typeNAME << 16) | 4;
        const int CefPostData_RemoveElement_5 = (_typeNAME << 16) | 5;
        const int CefPostData_AddElement_6 = (_typeNAME << 16) | 6;
        const int CefPostData_RemoveElements_7 = (_typeNAME << 16) | 7;
        internal readonly IntPtr nativePtr;
        internal CefPostData(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_Release_0, out ret);
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefPostData methods.
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_IsReadOnly_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool HasExcludedElements()
        /// <summary>
        /// Returns true if the underlying POST data includes elements that are not
        /// represented by this CefPostData object (for example, multi-part file upload
        /// data). Modifying CefPostData objects with excluded elements may result in
        /// the request failing.
        /// /*cef()*/
        /// </summary>

        public bool HasExcludedElements()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_HasExcludedElements_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! size_t GetElementCount()
        /// <summary>
        /// Returns the number of existing post data elements.
        /// /*cef()*/
        /// </summary>

        public uint GetElementCount()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_GetElementCount_3, out ret);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! void GetElements(ElementVector& elements)
        /// <summary>
        /// Retrieve the post data elements.
        /// /*cef(count_func=elements:GetElementCount)*/
        /// </summary>

        public void GetElements(ElementVector elements
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = elements.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_GetElements_4, out ret, ref v1);

        }

        // gen! bool RemoveElement(CefRefPtr<CefPostDataElement> element)
        /// <summary>
        /// Remove the specified post data element.  Returns true if the removal
        /// succeeds.
        /// /*cef()*/
        /// </summary>

        public bool RemoveElement(CefPostDataElement element
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = element.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_RemoveElement_5, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool AddElement(CefRefPtr<CefPostDataElement> element)
        /// <summary>
        /// Add the specified post data element.  Returns true if the add succeeds.
        /// /*cef()*/
        /// </summary>

        public bool AddElement(CefPostDataElement element
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = element.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_AddElement_6, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void RemoveElements()
        /// <summary>
        /// Remove all existing post data elements.
        /// /*cef()*/
        /// </summary>

        public void RemoveElements()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_RemoveElements_7, out ret);

        }
    }


    // [virtual] class CefPostDataElement
    /// <summary>
    /// Class used to represent a single element in the request post data. The
    /// methods of this class may be called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefPostDataElement
    {
        const int _typeNAME = 24;
        const int CefPostDataElement_Release_0 = (_typeNAME << 16) | 0;
        const int CefPostDataElement_IsReadOnly_1 = (_typeNAME << 16) | 1;
        const int CefPostDataElement_SetToEmpty_2 = (_typeNAME << 16) | 2;
        const int CefPostDataElement_SetToFile_3 = (_typeNAME << 16) | 3;
        const int CefPostDataElement_SetToBytes_4 = (_typeNAME << 16) | 4;
        const int CefPostDataElement_GetType_5 = (_typeNAME << 16) | 5;
        const int CefPostDataElement_GetFile_6 = (_typeNAME << 16) | 6;
        const int CefPostDataElement_GetBytesCount_7 = (_typeNAME << 16) | 7;
        const int CefPostDataElement_GetBytes_8 = (_typeNAME << 16) | 8;
        internal readonly IntPtr nativePtr;
        internal CefPostDataElement(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_Release_0, out ret);
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefPostDataElement methods.
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_IsReadOnly_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void SetToEmpty()
        /// <summary>
        /// Remove all contents from the post data element.
        /// /*cef()*/
        /// </summary>

        public void SetToEmpty()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_SetToEmpty_2, out ret);

        }

        // gen! void SetToFile(const CefString& fileName)
        /// <summary>
        /// The post data element will represent a file.
        /// /*cef()*/
        /// </summary>

        public void SetToFile(string fileName
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(fileName);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostDataElement_SetToFile_3, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! void SetToBytes(size_t size,const void* bytes)
        /// <summary>
        /// The post data element will represent bytes.  The bytes passed
        /// in will be copied.
        /// /*cef()*/
        /// </summary>

        public void SetToBytes(uint size
        , IntPtr bytes
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)size;
            v2.Ptr = bytes;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefPostDataElement_SetToBytes_4, out ret, ref v1, ref v2);

        }

        // gen! Type GetType()
        /// <summary>
        /// Return the type of this post data element.
        /// /*cef(default_retval=PDE_TYPE_EMPTY)*/
        /// </summary>

        public cef_postdataelement_type_t _GetType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetType_5, out ret);
            var ret_result = (cef_postdataelement_type_t)ret.I32;

            return ret_result;
        }

        // gen! CefString GetFile()
        /// <summary>
        /// Return the file name.
        /// /*cef()*/
        /// </summary>

        public string GetFile()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetFile_6, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! size_t GetBytesCount()
        /// <summary>
        /// Return the number of bytes.
        /// /*cef()*/
        /// </summary>

        public uint GetBytesCount()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetBytesCount_7, out ret);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! size_t GetBytes(size_t size,void* bytes)
        /// <summary>
        /// Read up to |size| bytes into |bytes| and return the number of bytes
        /// actually read.
        /// /*cef()*/
        /// </summary>

        public uint GetBytes(uint size
        , IntPtr bytes
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)size;
            v2.Ptr = bytes;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefPostDataElement_GetBytes_8, out ret, ref v1, ref v2);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }
    }


    // [virtual] class CefRequestContext
    /// <summary>
    /// A request context provides request handling for a set of related browser
    /// or URL request objects. A request context can be specified when creating a
    /// new browser via the CefBrowserHost static factory methods or when creating a
    /// new URL request via the CefURLRequest static factory methods. Browser objects
    /// with different request contexts will never be hosted in the same render
    /// process. Browser objects with the same request context may or may not be
    /// hosted in the same render process depending on the process model. Browser
    /// objects created indirectly via the JavaScript window.open function or
    /// targeted links will share the same render process and the same request
    /// context as the source browser. When running in single-process mode there is
    /// only a single render process (the main process) and so all browsers created
    /// in single-process mode will share the same request context. This will be the
    /// first request context passed into a CefBrowserHost static factory method and
    /// all other request context objects will be ignored.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefRequestContext
    {
        const int _typeNAME = 25;
        const int CefRequestContext_Release_0 = (_typeNAME << 16) | 0;
        const int CefRequestContext_IsSame_1 = (_typeNAME << 16) | 1;
        const int CefRequestContext_IsSharingWith_2 = (_typeNAME << 16) | 2;
        const int CefRequestContext_IsGlobal_3 = (_typeNAME << 16) | 3;
        const int CefRequestContext_GetHandler_4 = (_typeNAME << 16) | 4;
        const int CefRequestContext_GetCachePath_5 = (_typeNAME << 16) | 5;
        const int CefRequestContext_GetDefaultCookieManager_6 = (_typeNAME << 16) | 6;
        const int CefRequestContext_RegisterSchemeHandlerFactory_7 = (_typeNAME << 16) | 7;
        const int CefRequestContext_ClearSchemeHandlerFactories_8 = (_typeNAME << 16) | 8;
        const int CefRequestContext_PurgePluginListCache_9 = (_typeNAME << 16) | 9;
        const int CefRequestContext_HasPreference_10 = (_typeNAME << 16) | 10;
        const int CefRequestContext_GetPreference_11 = (_typeNAME << 16) | 11;
        const int CefRequestContext_GetAllPreferences_12 = (_typeNAME << 16) | 12;
        const int CefRequestContext_CanSetPreference_13 = (_typeNAME << 16) | 13;
        const int CefRequestContext_SetPreference_14 = (_typeNAME << 16) | 14;
        const int CefRequestContext_ClearCertificateExceptions_15 = (_typeNAME << 16) | 15;
        const int CefRequestContext_CloseAllConnections_16 = (_typeNAME << 16) | 16;
        const int CefRequestContext_ResolveHost_17 = (_typeNAME << 16) | 17;
        const int CefRequestContext_ResolveHostCached_18 = (_typeNAME << 16) | 18;
        internal readonly IntPtr nativePtr;
        internal CefRequestContext(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_Release_0, out ret);
        }

        // gen! bool IsSame(CefRefPtr<CefRequestContext> other)
        /// <summary>
        /// CefRequestContext methods.
        /// </summary>

        public bool IsSame(CefRequestContext other
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = other.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_IsSame_1, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsSharingWith(CefRefPtr<CefRequestContext> other)
        /// <summary>
        /// Returns true if this object is sharing the same storage as |that| object.
        /// /*cef()*/
        /// </summary>

        public bool IsSharingWith(CefRequestContext other
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = other.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_IsSharingWith_2, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsGlobal()
        /// <summary>
        /// Returns true if this object is the global context. The global context is
        /// used by default when creating a browser or URL request with a NULL context
        /// argument.
        /// /*cef()*/
        /// </summary>

        public bool IsGlobal()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_IsGlobal_3, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefRequestContextHandler> GetHandler()
        /// <summary>
        /// Returns the handler for this context if any.
        /// /*cef()*/
        /// </summary>

        public CefRequestContextHandler GetHandler()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_GetHandler_4, out ret);
            var ret_result = new CefRequestContextHandler(ret.Ptr);
            return ret_result;
        }

        // gen! CefString GetCachePath()
        /// <summary>
        /// Returns the cache path for this object. If empty an "incognito mode"
        /// in-memory cache is being used.
        /// /*cef()*/
        /// </summary>

        public string GetCachePath()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_GetCachePath_5, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefRefPtr<CefCookieManager> GetDefaultCookieManager(CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Returns the default cookie manager for this object. This will be the global
        /// cookie manager if this object is the global request context. Otherwise,
        /// this will be the default cookie manager used when this request context does
        /// not receive a value via CefRequestContextHandler::GetCookieManager(). If
        /// |callback| is non-NULL it will be executed asnychronously on the IO thread
        /// after the manager's storage has been initialized.
        /// /*cef(optional_param=callback)*/
        /// </summary>

        public CefCookieManager GetDefaultCookieManager(CefCompletionCallback callback
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetDefaultCookieManager_6, out ret, ref v1);
            var ret_result = new CefCookieManager(ret.Ptr);
            return ret_result;
        }

        // gen! bool RegisterSchemeHandlerFactory(const CefString& scheme_name,const CefString& domain_name,CefRefPtr<CefSchemeHandlerFactory> factory)
        /// <summary>
        /// Register a scheme handler factory for the specified |scheme_name| and
        /// optional |domain_name|. An empty |domain_name| value for a standard scheme
        /// will cause the factory to match all domain names. The |domain_name| value
        /// will be ignored for non-standard schemes. If |scheme_name| is a built-in
        /// scheme and no handler is returned by |factory| then the built-in scheme
        /// handler factory will be called. If |scheme_name| is a custom scheme then
        /// you must also implement the CefApp::OnRegisterCustomSchemes() method in all
        /// processes. This function may be called multiple times to change or remove
        /// the factory that matches the specified |scheme_name| and optional
        /// |domain_name|. Returns false if an error occurs. This function may be
        /// called on any thread in the browser process.
        /// /*cef(optional_param=domain_name,optional_param=factory)*/
        /// </summary>

        public bool RegisterSchemeHandlerFactory(string scheme_name
        , string domain_name
        , CefSchemeHandlerFactory factory
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(scheme_name);
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(domain_name);
            ;
            v3.Ptr = factory.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefRequestContext_RegisterSchemeHandlerFactory_7, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }

        // gen! bool ClearSchemeHandlerFactories()
        /// <summary>
        /// Clear all registered scheme handler factories. Returns false on error. This
        /// function may be called on any thread in the browser process.
        /// /*cef()*/
        /// </summary>

        public bool ClearSchemeHandlerFactories()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_ClearSchemeHandlerFactories_8, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! void PurgePluginListCache(bool reload_pages)
        /// <summary>
        /// Tells all renderer processes associated with this context to throw away
        /// their plugin list cache. If |reload_pages| is true they will also reload
        /// all pages with plugins. CefRequestContextHandler::OnBeforePluginLoad may
        /// be called to rebuild the plugin list cache.
        /// /*cef()*/
        /// </summary>

        public void PurgePluginListCache(bool reload_pages
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = reload_pages ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_PurgePluginListCache_9, out ret, ref v1);

        }

        // gen! bool HasPreference(const CefString& name)
        /// <summary>
        /// Returns true if a preference with the specified |name| exists. This method
        /// must be called on the browser process UI thread.
        /// /*cef()*/
        /// </summary>

        public bool HasPreference(string name
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_HasPreference_10, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! CefRefPtr<CefValue> GetPreference(const CefString& name)
        /// <summary>
        /// Returns the value for the preference with the specified |name|. Returns
        /// NULL if the preference does not exist. The returned object contains a copy
        /// of the underlying preference value and modifications to the returned object
        /// will not modify the underlying preference value. This method must be called
        /// on the browser process UI thread.
        /// /*cef()*/
        /// </summary>

        public CefValue GetPreference(string name
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetPreference_11, out ret, ref v1);
            var ret_result = new CefValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! CefRefPtr<CefDictionaryValue> GetAllPreferences(bool include_defaults)
        /// <summary>
        /// Returns all preferences as a dictionary. If |include_defaults| is true then
        /// preferences currently at their default value will be included. The returned
        /// object contains a copy of the underlying preference values and
        /// modifications to the returned object will not modify the underlying
        /// preference values. This method must be called on the browser process UI
        /// thread.
        /// /*cef()*/
        /// </summary>

        public CefDictionaryValue GetAllPreferences(bool include_defaults
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = include_defaults ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetAllPreferences_12, out ret, ref v1);
            var ret_result = new CefDictionaryValue(ret.Ptr);
            return ret_result;
        }

        // gen! bool CanSetPreference(const CefString& name)
        /// <summary>
        /// Returns true if the preference with the specified |name| can be modified
        /// using SetPreference. As one example preferences set via the command-line
        /// usually cannot be modified. This method must be called on the browser
        /// process UI thread.
        /// /*cef()*/
        /// </summary>

        public bool CanSetPreference(string name
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_CanSetPreference_13, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool SetPreference(const CefString& name,CefRefPtr<CefValue> value,CefString& error)
        /// <summary>
        /// Set the |value| associated with preference |name|. Returns true if the
        /// value is set successfully and false otherwise. If |value| is NULL the
        /// preference will be restored to its default value. If setting the preference
        /// fails then |error| will be populated with a detailed description of the
        /// problem. This method must be called on the browser process UI thread.
        /// /*cef(optional_param=value)*/
        /// </summary>

        public bool SetPreference(string name
        , CefValue value
        , string error
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            ;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(error);
            ;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefRequestContext_SetPreference_14, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            Cef3Binder.MyCefDeletePtr(v3.Ptr); ;
            return ret_result;
        }

        // gen! void ClearCertificateExceptions(CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Clears all certificate exceptions that were added as part of handling
        /// CefRequestHandler::OnCertificateError(). If you call this it is
        /// recommended that you also call CloseAllConnections() or you risk not
        /// being prompted again for server certificates if you reconnect quickly.
        /// If |callback| is non-NULL it will be executed on the UI thread after
        /// completion.
        /// /*cef(optional_param=callback)*/
        /// </summary>

        public void ClearCertificateExceptions(CefCompletionCallback callback
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_ClearCertificateExceptions_15, out ret, ref v1);

        }

        // gen! void CloseAllConnections(CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Clears all active and idle connections that Chromium currently has.
        /// This is only recommended if you have released all other CEF objects but
        /// don't yet want to call CefShutdown(). If |callback| is non-NULL it will be
        /// executed on the UI thread after completion.
        /// /*cef(optional_param=callback)*/
        /// </summary>

        public void CloseAllConnections(CefCompletionCallback callback
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_CloseAllConnections_16, out ret, ref v1);

        }

        // gen! void ResolveHost(const CefString& origin,CefRefPtr<CefResolveCallback> callback)
        /// <summary>
        /// Attempts to resolve |origin| to a list of associated IP addresses.
        /// |callback| will be executed on the UI thread after completion.
        /// /*cef()*/
        /// </summary>

        public void ResolveHost(string origin
        , CefResolveCallback callback
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(origin);
            ;
            v2.Ptr = callback.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequestContext_ResolveHost_17, out ret, ref v1, ref v2);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! cef_errorcode_t ResolveHostCached(const CefString& origin,std::vector<CefString>& resolved_ips)
        /// <summary>
        /// Attempts to resolve |origin| to a list of associated IP addresses using
        /// cached data. |resolved_ips| will be populated with the list of resolved IP
        /// addresses or empty if no cached data is available. Returns ERR_NONE on
        /// success. This method must be called on the browser process IO thread.
        /// /*cef(default_retval=ERR_FAILED)*/
        /// </summary>

        public cef_errorcode_t ResolveHostCached(string origin
        , List<string> resolved_ips
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(origin);
            ;
            v2.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequestContext_ResolveHostCached_18, out ret, ref v1, ref v2);
            var ret_result = (cef_errorcode_t)ret.I32;

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v2.Ptr, resolved_ips);
            return ret_result;
        }
    }


    // [virtual] class CefResourceBundle
    /// <summary>
    /// Class used for retrieving resources from the resource bundle (*.pak) files
    /// loaded by CEF during startup or via the CefResourceBundleHandler returned
    /// from CefApp::GetResourceBundleHandler. See CefSettings for additional options
    /// related to resource bundle loading. The methods of this class may be called
    /// on any thread unless otherwise indicated.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefResourceBundle
    {
        const int _typeNAME = 26;
        const int CefResourceBundle_Release_0 = (_typeNAME << 16) | 0;
        const int CefResourceBundle_GetLocalizedString_1 = (_typeNAME << 16) | 1;
        const int CefResourceBundle_GetDataResource_2 = (_typeNAME << 16) | 2;
        const int CefResourceBundle_GetDataResourceForScale_3 = (_typeNAME << 16) | 3;
        internal readonly IntPtr nativePtr;
        internal CefResourceBundle(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResourceBundle_Release_0, out ret);
        }

        // gen! CefString GetLocalizedString(int string_id)
        /// <summary>
        /// CefResourceBundle methods.
        /// </summary>

        public string GetLocalizedString(int string_id
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)string_id;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResourceBundle_GetLocalizedString_1, out ret, ref v1);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! bool GetDataResource(int resource_id,void*& data,size_t& data_size)
        /// <summary>
        /// Retrieves the contents of the specified scale independent |resource_id|.
        /// If the value is found then |data| and |data_size| will be populated and
        /// this method will return true. If the value is not found then this method
        /// will return false. The returned |data| pointer will remain resident in
        /// memory and should not be freed. Include cef_pack_resources.h for a listing
        /// of valid resource ID values.
        /// /*cef()*/
        /// </summary>

        public bool GetDataResource(int resource_id
        , IntPtr data
        , ref uint data_size
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)resource_id;
            v2.Ptr = data;
            v3.I32 = (int)data_size;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefResourceBundle_GetDataResource_2, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            data = v2.Ptr; ;
            data_size = (uint)v3.I32; ;
            return ret_result;
        }

        // gen! bool GetDataResourceForScale(int resource_id,ScaleFactor scale_factor,void*& data,size_t& data_size)
        /// <summary>
        /// Retrieves the contents of the specified |resource_id| nearest the scale
        /// factor |scale_factor|. Use a |scale_factor| value of SCALE_FACTOR_NONE for
        /// scale independent resources or call GetDataResource instead. If the value
        /// is found then |data| and |data_size| will be populated and this method will
        /// return true. If the value is not found then this method will return false.
        /// The returned |data| pointer will remain resident in memory and should not
        /// be freed. Include cef_pack_resources.h for a listing of valid resource ID
        /// values.
        /// /*cef()*/
        /// </summary>

        public bool GetDataResourceForScale(int resource_id
        , cef_scale_factor_t scale_factor
        , IntPtr data
        , ref uint data_size
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.I32 = (int)resource_id;
            v2.I32 = (int)scale_factor;
            v3.Ptr = data;
            v4.I32 = (int)data_size;

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefResourceBundle_GetDataResourceForScale_3, out ret, ref v1, ref v2, ref v3, ref v4);
            var ret_result = ret.I32 != 0;
            data = v3.Ptr; ;
            data_size = (uint)v4.I32; ;
            return ret_result;
        }
    }


    // [virtual] class CefResponse
    /// <summary>
    /// Class used to represent a web response. The methods of this class may be
    /// called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    public struct CefResponse
    {
        const int _typeNAME = 27;
        const int CefResponse_Release_0 = (_typeNAME << 16) | 0;
        const int CefResponse_IsReadOnly_1 = (_typeNAME << 16) | 1;
        const int CefResponse_GetError_2 = (_typeNAME << 16) | 2;
        const int CefResponse_SetError_3 = (_typeNAME << 16) | 3;
        const int CefResponse_GetStatus_4 = (_typeNAME << 16) | 4;
        const int CefResponse_SetStatus_5 = (_typeNAME << 16) | 5;
        const int CefResponse_GetStatusText_6 = (_typeNAME << 16) | 6;
        const int CefResponse_SetStatusText_7 = (_typeNAME << 16) | 7;
        const int CefResponse_GetMimeType_8 = (_typeNAME << 16) | 8;
        const int CefResponse_SetMimeType_9 = (_typeNAME << 16) | 9;
        const int CefResponse_GetHeader_10 = (_typeNAME << 16) | 10;
        const int CefResponse_GetHeaderMap_11 = (_typeNAME << 16) | 11;
        const int CefResponse_SetHeaderMap_12 = (_typeNAME << 16) | 12;
        internal readonly IntPtr nativePtr;
        internal CefResponse(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_Release_0, out ret);
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefResponse methods.
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_IsReadOnly_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! cef_errorcode_t GetError()
        /// <summary>
        /// Get the response error code. Returns ERR_NONE if there was no error.
        /// /*cef(default_retval=ERR_NONE)*/
        /// </summary>

        public cef_errorcode_t GetError()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetError_2, out ret);
            var ret_result = (cef_errorcode_t)ret.I32;

            return ret_result;
        }

        // gen! void SetError(cef_errorcode_t error)
        /// <summary>
        /// Set the response error code. This can be used by custom scheme handlers
        /// to return errors during initial request processing.
        /// /*cef()*/
        /// </summary>

        public void SetError(cef_errorcode_t error
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)error;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetError_3, out ret, ref v1);

        }

        // gen! int GetStatus()
        /// <summary>
        /// Get the response status code.
        /// /*cef()*/
        /// </summary>

        public int GetStatus()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetStatus_4, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! void SetStatus(int status)
        /// <summary>
        /// Set the response status code.
        /// /*cef()*/
        /// </summary>

        public void SetStatus(int status
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)status;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetStatus_5, out ret, ref v1);

        }

        // gen! CefString GetStatusText()
        /// <summary>
        /// Get the response status text.
        /// /*cef()*/
        /// </summary>

        public string GetStatusText()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetStatusText_6, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! void SetStatusText(const CefString& statusText)
        /// <summary>
        /// Set the response status text.
        /// /*cef()*/
        /// </summary>

        public void SetStatusText(string statusText
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(statusText);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetStatusText_7, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! CefString GetMimeType()
        /// <summary>
        /// Get the response mime type.
        /// /*cef()*/
        /// </summary>

        public string GetMimeType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetMimeType_8, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! void SetMimeType(const CefString& mimeType)
        /// <summary>
        /// Set the response mime type.
        /// /*cef()*/
        /// </summary>

        public void SetMimeType(string mimeType
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(mimeType);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetMimeType_9, out ret, ref v1);

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
        }

        // gen! CefString GetHeader(const CefString& name)
        /// <summary>
        /// Get the value for the specified response header field.
        /// /*cef()*/
        /// </summary>

        public string GetHeader(string name
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_GetHeader_10, out ret, ref v1);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! void GetHeaderMap(HeaderMap& headerMap)
        /// <summary>
        /// Get all response header fields.
        /// /*cef()*/
        /// </summary>

        public void GetHeaderMap(HeaderMap headerMap
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = headerMap.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_GetHeaderMap_11, out ret, ref v1);

        }

        // gen! void SetHeaderMap(const HeaderMap& headerMap)
        /// <summary>
        /// Set all response header fields.
        /// /*cef()*/
        /// </summary>

        public void SetHeaderMap(HeaderMap headerMap
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = headerMap.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetHeaderMap_12, out ret, ref v1);

        }
    }


    // [virtual] class CefResponseFilter
    /// <summary>
    /// Implement this interface to filter resource response content. The methods of
    /// this class will be called on the browser process IO thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefResponseFilter
    {
        const int _typeNAME = 28;
        const int CefResponseFilter_Release_0 = (_typeNAME << 16) | 0;
        internal readonly IntPtr nativePtr;
        internal CefResponseFilter(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponseFilter_Release_0, out ret);
        }
    }


    // [virtual] class CefSchemeHandlerFactory
    /// <summary>
    /// Class that creates CefResourceHandler instances for handling scheme requests.
    /// The methods of this class will always be called on the IO thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefSchemeHandlerFactory
    {
        const int _typeNAME = 29;
        const int CefSchemeHandlerFactory_Release_0 = (_typeNAME << 16) | 0;
        internal readonly IntPtr nativePtr;
        internal CefSchemeHandlerFactory(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSchemeHandlerFactory_Release_0, out ret);
        }
    }


    // [virtual] class CefSSLInfo
    /// <summary>
    /// Class representing SSL information.
    /// /*(source=library)*/
    /// </summary>
    public struct CefSSLInfo
    {
        const int _typeNAME = 30;
        const int CefSSLInfo_Release_0 = (_typeNAME << 16) | 0;
        const int CefSSLInfo_GetCertStatus_1 = (_typeNAME << 16) | 1;
        const int CefSSLInfo_GetX509Certificate_2 = (_typeNAME << 16) | 2;
        internal readonly IntPtr nativePtr;
        internal CefSSLInfo(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_Release_0, out ret);
        }

        // gen! cef_cert_status_t GetCertStatus()
        /// <summary>
        /// CefSSLInfo methods.
        /// </summary>

        public cef_cert_status_t GetCertStatus()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_GetCertStatus_1, out ret);
            var ret_result = (cef_cert_status_t)ret.I32;

            return ret_result;
        }

        // gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
        /// <summary>
        /// Returns the X.509 certificate.
        /// /*cef()*/
        /// </summary>

        public CefX509Certificate GetX509Certificate()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_GetX509Certificate_2, out ret);
            var ret_result = new CefX509Certificate(ret.Ptr);
            return ret_result;
        }
    }


    // [virtual] class CefSSLStatus
    /// <summary>
    /// Class representing the SSL information for a navigation entry.
    /// /*(source=library)*/
    /// </summary>
    public struct CefSSLStatus
    {
        const int _typeNAME = 31;
        const int CefSSLStatus_Release_0 = (_typeNAME << 16) | 0;
        const int CefSSLStatus_IsSecureConnection_1 = (_typeNAME << 16) | 1;
        const int CefSSLStatus_GetCertStatus_2 = (_typeNAME << 16) | 2;
        const int CefSSLStatus_GetSSLVersion_3 = (_typeNAME << 16) | 3;
        const int CefSSLStatus_GetContentStatus_4 = (_typeNAME << 16) | 4;
        const int CefSSLStatus_GetX509Certificate_5 = (_typeNAME << 16) | 5;
        internal readonly IntPtr nativePtr;
        internal CefSSLStatus(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_Release_0, out ret);
        }

        // gen! bool IsSecureConnection()
        /// <summary>
        /// CefSSLStatus methods.
        /// </summary>

        public bool IsSecureConnection()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_IsSecureConnection_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! cef_cert_status_t GetCertStatus()
        /// <summary>
        /// Returns a bitmask containing any and all problems verifying the server
        /// certificate.
        /// /*cef(default_retval=CERT_STATUS_NONE)*/
        /// </summary>

        public cef_cert_status_t GetCertStatus()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetCertStatus_2, out ret);
            var ret_result = (cef_cert_status_t)ret.I32;

            return ret_result;
        }

        // gen! cef_ssl_version_t GetSSLVersion()
        /// <summary>
        /// Returns the SSL version used for the SSL connection.
        /// /*cef(default_retval=SSL_CONNECTION_VERSION_UNKNOWN)*/
        /// </summary>

        public cef_ssl_version_t GetSSLVersion()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetSSLVersion_3, out ret);
            var ret_result = (cef_ssl_version_t)ret.I32;

            return ret_result;
        }

        // gen! cef_ssl_content_status_t GetContentStatus()
        /// <summary>
        /// Returns a bitmask containing the page security content status.
        /// /*cef(default_retval=SSL_CONTENT_NORMAL_CONTENT)*/
        /// </summary>

        public cef_ssl_content_status_t GetContentStatus()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetContentStatus_4, out ret);
            var ret_result = (cef_ssl_content_status_t)ret.I32;

            return ret_result;
        }

        // gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
        /// <summary>
        /// Returns the X.509 certificate.
        /// /*cef()*/
        /// </summary>

        public CefX509Certificate GetX509Certificate()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetX509Certificate_5, out ret);
            var ret_result = new CefX509Certificate(ret.Ptr);
            return ret_result;
        }
    }


    // [virtual] class CefStreamReader
    /// <summary>
    /// Class used to read data from a stream. The methods of this class may be
    /// called on any thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefStreamReader
    {
        const int _typeNAME = 32;
        const int CefStreamReader_Release_0 = (_typeNAME << 16) | 0;
        const int CefStreamReader_Read_1 = (_typeNAME << 16) | 1;
        const int CefStreamReader_Seek_2 = (_typeNAME << 16) | 2;
        const int CefStreamReader_Tell_3 = (_typeNAME << 16) | 3;
        const int CefStreamReader_Eof_4 = (_typeNAME << 16) | 4;
        const int CefStreamReader_MayBlock_5 = (_typeNAME << 16) | 5;
        internal readonly IntPtr nativePtr;
        internal CefStreamReader(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Release_0, out ret);
        }

        // gen! size_t Read(void* ptr,size_t size,size_t n)
        /// <summary>
        /// CefStreamReader methods.
        /// </summary>

        public uint Read(IntPtr ptr
        , uint size
        , uint n
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = ptr;
            v2.I32 = (int)size;
            v3.I32 = (int)n;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefStreamReader_Read_1, out ret, ref v1, ref v2, ref v3);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! int Seek(int64 offset,int whence)
        /// <summary>
        /// Seek to the specified offset position. |whence| may be any one of
        /// SEEK_CUR, SEEK_END or SEEK_SET. Returns zero on success and non-zero on
        /// failure.
        /// /*cef()*/
        /// </summary>

        public int Seek(long offset
        , int whence
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I64 = offset;
            v2.I32 = (int)whence;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefStreamReader_Seek_2, out ret, ref v1, ref v2);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int64 Tell()
        /// <summary>
        /// Return the current offset position.
        /// /*cef()*/
        /// </summary>

        public long Tell()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Tell_3, out ret);
            var ret_result = ret.I64;
            return ret_result;
        }

        // gen! int Eof()
        /// <summary>
        /// Return non-zero if at end of file.
        /// /*cef()*/
        /// </summary>

        public int Eof()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Eof_4, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! bool MayBlock()
        /// <summary>
        /// Returns true if this reader performs work like accessing the file system
        /// which may block. Used as a hint for determining the thread to access the
        /// reader from.
        /// /*cef()*/
        /// </summary>

        public bool MayBlock()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_MayBlock_5, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }
    }


    // [virtual] class CefStreamWriter
    /// <summary>
    /// Class used to write data to a stream. The methods of this class may be called
    /// on any thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefStreamWriter
    {
        const int _typeNAME = 33;
        const int CefStreamWriter_Release_0 = (_typeNAME << 16) | 0;
        const int CefStreamWriter_Write_1 = (_typeNAME << 16) | 1;
        const int CefStreamWriter_Seek_2 = (_typeNAME << 16) | 2;
        const int CefStreamWriter_Tell_3 = (_typeNAME << 16) | 3;
        const int CefStreamWriter_Flush_4 = (_typeNAME << 16) | 4;
        const int CefStreamWriter_MayBlock_5 = (_typeNAME << 16) | 5;
        internal readonly IntPtr nativePtr;
        internal CefStreamWriter(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Release_0, out ret);
        }

        // gen! size_t Write(const void* ptr,size_t size,size_t n)
        /// <summary>
        /// CefStreamWriter methods.
        /// </summary>

        public uint Write(IntPtr ptr
        , uint size
        , uint n
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = ptr;
            v2.I32 = (int)size;
            v3.I32 = (int)n;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefStreamWriter_Write_1, out ret, ref v1, ref v2, ref v3);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! int Seek(int64 offset,int whence)
        /// <summary>
        /// Seek to the specified offset position. |whence| may be any one of
        /// SEEK_CUR, SEEK_END or SEEK_SET. Returns zero on success and non-zero on
        /// failure.
        /// /*cef()*/
        /// </summary>

        public int Seek(long offset
        , int whence
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I64 = offset;
            v2.I32 = (int)whence;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefStreamWriter_Seek_2, out ret, ref v1, ref v2);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int64 Tell()
        /// <summary>
        /// Return the current offset position.
        /// /*cef()*/
        /// </summary>

        public long Tell()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Tell_3, out ret);
            var ret_result = ret.I64;
            return ret_result;
        }

        // gen! int Flush()
        /// <summary>
        /// Flush the stream.
        /// /*cef()*/
        /// </summary>

        public int Flush()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Flush_4, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! bool MayBlock()
        /// <summary>
        /// Returns true if this writer performs work like accessing the file system
        /// which may block. Used as a hint for determining the thread to access the
        /// writer from.
        /// /*cef()*/
        /// </summary>

        public bool MayBlock()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_MayBlock_5, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }
    }


    // [virtual] class CefStringVisitor
    /// <summary>
    /// Implement this interface to receive string values asynchronously.
    /// /*(source=client)*/
    /// </summary>
    public struct CefStringVisitor
    {
        const int _typeNAME = 34;
        const int CefStringVisitor_Release_0 = (_typeNAME << 16) | 0;
        internal readonly IntPtr nativePtr;
        internal CefStringVisitor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStringVisitor_Release_0, out ret);
        }
    }


    // [virtual] class CefTask
    /// <summary>
    /// Implement this interface for asynchronous task execution. If the task is
    /// posted successfully and if the associated message loop is still running then
    /// the Execute() method will be called on the target thread. If the task fails
    /// to post then the task object may be destroyed on the source thread instead of
    /// the target thread. For this reason be cautious when performing work in the
    /// task object destructor.
    /// /*cef(source=client)*/
    /// </summary>
    public struct CefTask
    {
        const int _typeNAME = 35;
        const int CefTask_Release_0 = (_typeNAME << 16) | 0;
        internal readonly IntPtr nativePtr;
        internal CefTask(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTask_Release_0, out ret);
        }
    }


    // [virtual] class CefTaskRunner
    /// <summary>
    /// Class that asynchronously executes tasks on the associated thread. It is safe
    /// to call the methods of this class on any thread.
    ///
    /// CEF maintains multiple internal threads that are used for handling different
    /// types of tasks in different processes. The cef_thread_id_t definitions in
    /// cef_types.h list the common CEF threads. Task runners are also available for
    /// other CEF threads as appropriate (for example, V8 WebWorker threads).
    /// /*(source=library)*/
    /// </summary>
    public struct CefTaskRunner
    {
        const int _typeNAME = 36;
        const int CefTaskRunner_Release_0 = (_typeNAME << 16) | 0;
        const int CefTaskRunner_IsSame_1 = (_typeNAME << 16) | 1;
        const int CefTaskRunner_BelongsToCurrentThread_2 = (_typeNAME << 16) | 2;
        const int CefTaskRunner_BelongsToThread_3 = (_typeNAME << 16) | 3;
        const int CefTaskRunner_PostTask_4 = (_typeNAME << 16) | 4;
        const int CefTaskRunner_PostDelayedTask_5 = (_typeNAME << 16) | 5;
        internal readonly IntPtr nativePtr;
        internal CefTaskRunner(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTaskRunner_Release_0, out ret);
        }

        // gen! bool IsSame(CefRefPtr<CefTaskRunner> that)
        /// <summary>
        /// CefTaskRunner methods.
        /// </summary>

        public bool IsSame(CefTaskRunner that
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_IsSame_1, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool BelongsToCurrentThread()
        /// <summary>
        /// Returns true if this task runner belongs to the current thread.
        /// /*cef()*/
        /// </summary>

        public bool BelongsToCurrentThread()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTaskRunner_BelongsToCurrentThread_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool BelongsToThread(CefThreadId threadId)
        /// <summary>
        /// Returns true if this task runner is for the specified CEF thread.
        /// /*cef()*/
        /// </summary>

        public bool BelongsToThread(cef_thread_id_t threadId
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)threadId;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_BelongsToThread_3, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool PostTask(CefRefPtr<CefTask> task)
        /// <summary>
        /// Post a task for execution on the thread associated with this task runner.
        /// Execution will occur asynchronously.
        /// /*cef()*/
        /// </summary>

        public bool PostTask(CefTask task
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = task.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_PostTask_4, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool PostDelayedTask(CefRefPtr<CefTask> task,int64 delay_ms)
        /// <summary>
        /// Post a task for delayed execution on the thread associated with this task
        /// runner. Execution will occur asynchronously. Delayed tasks are not
        /// supported on V8 WebWorker threads and will be executed without the
        /// specified delay.
        /// /*cef()*/
        /// </summary>

        public bool PostDelayedTask(CefTask task
        , long delay_ms
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = task.nativePtr;
            v2.I64 = delay_ms;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefTaskRunner_PostDelayedTask_5, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }
    }


    // [virtual] class CefURLRequest
    /// <summary>
    /// Class used to make a URL request. URL requests are not associated with a
    /// browser instance so no CefClient callbacks will be executed. URL requests
    /// can be created on any valid CEF thread in either the browser or render
    /// process. Once created the methods of the URL request object must be accessed
    /// on the same thread that created it.
    /// /*(source=library)*/
    /// </summary>
    public struct CefURLRequest
    {
        const int _typeNAME = 37;
        const int CefURLRequest_Release_0 = (_typeNAME << 16) | 0;
        const int CefURLRequest_GetRequest_1 = (_typeNAME << 16) | 1;
        const int CefURLRequest_GetClient_2 = (_typeNAME << 16) | 2;
        const int CefURLRequest_GetRequestStatus_3 = (_typeNAME << 16) | 3;
        const int CefURLRequest_GetRequestError_4 = (_typeNAME << 16) | 4;
        const int CefURLRequest_GetResponse_5 = (_typeNAME << 16) | 5;
        const int CefURLRequest_Cancel_6 = (_typeNAME << 16) | 6;
        internal readonly IntPtr nativePtr;
        internal CefURLRequest(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_Release_0, out ret);
        }

        // gen! CefRefPtr<CefRequest> GetRequest()
        /// <summary>
        /// CefURLRequest methods.
        /// </summary>

        public CefRequest GetRequest()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequest_1, out ret);
            var ret_result = new CefRequest(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefURLRequestClient> GetClient()
        /// <summary>
        /// Returns the client.
        /// /*cef()*/
        /// </summary>

        public CefURLRequestClient GetClient()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetClient_2, out ret);
            var ret_result = new CefURLRequestClient(ret.Ptr);
            return ret_result;
        }

        // gen! Status GetRequestStatus()
        /// <summary>
        /// Returns the request status.
        /// /*cef(default_retval=UR_UNKNOWN)*/
        /// </summary>

        public cef_urlrequest_status_t GetRequestStatus()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequestStatus_3, out ret);
            var ret_result = (cef_urlrequest_status_t)ret.I32;

            return ret_result;
        }

        // gen! ErrorCode GetRequestError()
        /// <summary>
        /// Returns the request error if status is UR_CANCELED or UR_FAILED, or 0
        /// otherwise.
        /// /*cef(default_retval=ERR_NONE)*/
        /// </summary>

        public cef_errorcode_t GetRequestError()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequestError_4, out ret);
            var ret_result = (cef_errorcode_t)ret.I32;

            return ret_result;
        }

        // gen! CefRefPtr<CefResponse> GetResponse()
        /// <summary>
        /// Returns the response, or NULL if no response information is available.
        /// Response information will only be available after the upload has completed.
        /// The returned object is read-only and should not be modified.
        /// /*cef()*/
        /// </summary>

        public CefResponse GetResponse()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetResponse_5, out ret);
            var ret_result = new CefResponse(ret.Ptr);
            return ret_result;
        }

        // gen! void Cancel()
        /// <summary>
        /// Cancel the request.
        /// /*cef()*/
        /// </summary>

        public void Cancel()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_Cancel_6, out ret);

        }
    }


    // [virtual] class CefURLRequestClient
    /// <summary>
    /// Interface that should be implemented by the CefURLRequest client. The
    /// methods of this class will be called on the same thread that created the
    /// request unless otherwise documented.
    /// /*(source=client)*/
    /// </summary>
    public struct CefURLRequestClient
    {
        const int _typeNAME = 38;
        const int CefURLRequestClient_Release_0 = (_typeNAME << 16) | 0;
        internal readonly IntPtr nativePtr;
        internal CefURLRequestClient(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequestClient_Release_0, out ret);
        }
    }


    // [virtual] class CefV8Context
    /// <summary>
    /// Class representing a V8 context handle. V8 handles can only be accessed from
    /// the thread on which they are created. Valid threads for creating a V8 handle
    /// include the render process main thread (TID_RENDERER) and WebWorker threads.
    /// A task runner for posting tasks on the associated thread can be retrieved via
    /// the CefV8Context::GetTaskRunner() method.
    /// /*cef(source=library)*/
    /// </summary>
    public struct CefV8Context
    {
        const int _typeNAME = 39;
        const int CefV8Context_Release_0 = (_typeNAME << 16) | 0;
        const int CefV8Context_GetTaskRunner_1 = (_typeNAME << 16) | 1;
        const int CefV8Context_IsValid_2 = (_typeNAME << 16) | 2;
        const int CefV8Context_GetBrowser_3 = (_typeNAME << 16) | 3;
        const int CefV8Context_GetFrame_4 = (_typeNAME << 16) | 4;
        const int CefV8Context_GetGlobal_5 = (_typeNAME << 16) | 5;
        const int CefV8Context_Enter_6 = (_typeNAME << 16) | 6;
        const int CefV8Context_Exit_7 = (_typeNAME << 16) | 7;
        const int CefV8Context_IsSame_8 = (_typeNAME << 16) | 8;
        const int CefV8Context_Eval_9 = (_typeNAME << 16) | 9;
        internal readonly IntPtr nativePtr;
        internal CefV8Context(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Release_0, out ret);
        }

        // gen! CefRefPtr<CefTaskRunner> GetTaskRunner()
        /// <summary>
        /// CefV8Context methods.
        /// </summary>

        public CefTaskRunner GetTaskRunner()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetTaskRunner_1, out ret);
            var ret_result = new CefTaskRunner(ret.Ptr);
            return ret_result;
        }

        // gen! bool IsValid()
        /// <summary>
        /// Returns true if the underlying handle is valid and it can be accessed on
        /// the current thread. Do not call any other methods if this method returns
        /// false.
        /// /*cef()*/
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_IsValid_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /// <summary>
        /// Returns the browser for this context. This method will return an empty
        /// reference for WebWorker contexts.
        /// /*cef()*/
        /// </summary>

        public CefBrowser GetBrowser()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetBrowser_3, out ret);
            var ret_result = new CefBrowser(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefFrame> GetFrame()
        /// <summary>
        /// Returns the frame for this context. This method will return an empty
        /// reference for WebWorker contexts.
        /// /*cef()*/
        /// </summary>

        public CefFrame GetFrame()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetFrame_4, out ret);
            var ret_result = new CefFrame(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefV8Value> GetGlobal()
        /// <summary>
        /// Returns the global object for this context. The context must be entered
        /// before calling this method.
        /// /*cef()*/
        /// </summary>

        public CefV8Value GetGlobal()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetGlobal_5, out ret);
            var ret_result = new CefV8Value(ret.Ptr);
            return ret_result;
        }

        // gen! bool Enter()
        /// <summary>
        /// Enter this context. A context must be explicitly entered before creating a
        /// V8 Object, Array, Function or Date asynchronously. Exit() must be called
        /// the same number of times as Enter() before releasing this context. V8
        /// objects belong to the context in which they are created. Returns true if
        /// the scope was entered successfully.
        /// /*cef()*/
        /// </summary>

        public bool Enter()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Enter_6, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool Exit()
        /// <summary>
        /// Exit this context. Call this method only after calling Enter(). Returns
        /// true if the scope was exited successfully.
        /// /*cef()*/
        /// </summary>

        public bool Exit()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Exit_7, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsSame(CefRefPtr<CefV8Context> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefV8Context that
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Context_IsSame_8, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool Eval(const CefString& code,const CefString& script_url,int start_line,CefRefPtr<CefV8Value>& retval,CefRefPtr<CefV8Exception>& exception)
        /// <summary>
        /// Execute a string of JavaScript code in this V8 context. The |script_url|
        /// parameter is the URL where the script in question can be found, if any.
        /// The |start_line| parameter is the base line number to use for error
        /// reporting. On success |retval| will be set to the return value, if any, and
        /// the function will return true. On failure |exception| will be set to the
        /// exception, if any, and the function will return false.
        /// /*cef(optional_param=script_url)*/
        /// </summary>

        public bool Eval(string code
        , string script_url
        , int start_line
        , IntPtr retval
        , IntPtr exception
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(code);
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(script_url);
            ;
            v3.I32 = (int)start_line;
            v4.Ptr = retval;
            v5.Ptr = exception;

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefV8Context_Eval_9, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            retval = v4.Ptr; ;
            exception = v5.Ptr; ;
            return ret_result;
        }
    }


    // [virtual] class CefV8Accessor
    /// <summary>
    /// Interface that should be implemented to handle V8 accessor calls. Accessor
    /// identifiers are registered by calling CefV8Value::SetValue(). The methods
    /// of this class will be called on the thread associated with the V8 accessor.
    /// /*(source=client)*/
    /// </summary>
    public struct CefV8Accessor
    {
        const int _typeNAME = 40;
        const int CefV8Accessor_Release_0 = (_typeNAME << 16) | 0;
        internal readonly IntPtr nativePtr;
        internal CefV8Accessor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Accessor_Release_0, out ret);
        }
    }


    // [virtual] class CefV8Interceptor
    /// <summary>
    /// Interface that should be implemented to handle V8 interceptor calls. The
    /// methods of this class will be called on the thread associated with the V8
    /// interceptor. Interceptor's named property handlers (with first argument of
    /// type CefString) are called when object is indexed by string. Indexed property
    /// handlers (with first argument of type int) are called when object is indexed
    /// by integer.
    /// /*(source=client)*/
    /// </summary>
    public struct CefV8Interceptor
    {
        const int _typeNAME = 41;
        const int CefV8Interceptor_Release_0 = (_typeNAME << 16) | 0;
        internal readonly IntPtr nativePtr;
        internal CefV8Interceptor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Interceptor_Release_0, out ret);
        }
    }


    // [virtual] class CefV8Exception
    /// <summary>
    /// Class representing a V8 exception. The methods of this class may be called on
    /// any render process thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefV8Exception
    {
        const int _typeNAME = 42;
        const int CefV8Exception_Release_0 = (_typeNAME << 16) | 0;
        const int CefV8Exception_GetMessage_1 = (_typeNAME << 16) | 1;
        const int CefV8Exception_GetSourceLine_2 = (_typeNAME << 16) | 2;
        const int CefV8Exception_GetScriptResourceName_3 = (_typeNAME << 16) | 3;
        const int CefV8Exception_GetLineNumber_4 = (_typeNAME << 16) | 4;
        const int CefV8Exception_GetStartPosition_5 = (_typeNAME << 16) | 5;
        const int CefV8Exception_GetEndPosition_6 = (_typeNAME << 16) | 6;
        const int CefV8Exception_GetStartColumn_7 = (_typeNAME << 16) | 7;
        const int CefV8Exception_GetEndColumn_8 = (_typeNAME << 16) | 8;
        internal readonly IntPtr nativePtr;
        internal CefV8Exception(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_Release_0, out ret);
        }

        // gen! CefString GetMessage()
        /// <summary>
        /// CefV8Exception methods.
        /// </summary>

        public string GetMessage()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetMessage_1, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetSourceLine()
        /// <summary>
        /// Returns the line of source code that the exception occurred within.
        /// /*cef()*/
        /// </summary>

        public string GetSourceLine()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetSourceLine_2, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetScriptResourceName()
        /// <summary>
        /// Returns the resource name for the script from where the function causing
        /// the error originates.
        /// /*cef()*/
        /// </summary>

        public string GetScriptResourceName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetScriptResourceName_3, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! int GetLineNumber()
        /// <summary>
        /// Returns the 1-based number of the line where the error occurred or 0 if the
        /// line number is unknown.
        /// /*cef()*/
        /// </summary>

        public int GetLineNumber()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetLineNumber_4, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int GetStartPosition()
        /// <summary>
        /// Returns the index within the script of the first character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>

        public int GetStartPosition()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetStartPosition_5, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int GetEndPosition()
        /// <summary>
        /// Returns the index within the script of the last character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>

        public int GetEndPosition()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetEndPosition_6, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int GetStartColumn()
        /// <summary>
        /// Returns the index within the line of the first character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>

        public int GetStartColumn()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetStartColumn_7, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int GetEndColumn()
        /// <summary>
        /// Returns the index within the line of the last character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>

        public int GetEndColumn()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetEndColumn_8, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }
    }


    // [virtual] class CefV8Value
    /// <summary>
    /// Class representing a V8 value handle. V8 handles can only be accessed from
    /// the thread on which they are created. Valid threads for creating a V8 handle
    /// include the render process main thread (TID_RENDERER) and WebWorker threads.
    /// A task runner for posting tasks on the associated thread can be retrieved via
    /// the CefV8Context::GetTaskRunner() method.
    /// /*(source=library)*/
    /// </summary>
    public struct CefV8Value
    {
        const int _typeNAME = 43;
        const int CefV8Value_Release_0 = (_typeNAME << 16) | 0;
        const int CefV8Value_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefV8Value_IsUndefined_2 = (_typeNAME << 16) | 2;
        const int CefV8Value_IsNull_3 = (_typeNAME << 16) | 3;
        const int CefV8Value_IsBool_4 = (_typeNAME << 16) | 4;
        const int CefV8Value_IsInt_5 = (_typeNAME << 16) | 5;
        const int CefV8Value_IsUInt_6 = (_typeNAME << 16) | 6;
        const int CefV8Value_IsDouble_7 = (_typeNAME << 16) | 7;
        const int CefV8Value_IsDate_8 = (_typeNAME << 16) | 8;
        const int CefV8Value_IsString_9 = (_typeNAME << 16) | 9;
        const int CefV8Value_IsObject_10 = (_typeNAME << 16) | 10;
        const int CefV8Value_IsArray_11 = (_typeNAME << 16) | 11;
        const int CefV8Value_IsFunction_12 = (_typeNAME << 16) | 12;
        const int CefV8Value_IsSame_13 = (_typeNAME << 16) | 13;
        const int CefV8Value_GetBoolValue_14 = (_typeNAME << 16) | 14;
        const int CefV8Value_GetIntValue_15 = (_typeNAME << 16) | 15;
        const int CefV8Value_GetUIntValue_16 = (_typeNAME << 16) | 16;
        const int CefV8Value_GetDoubleValue_17 = (_typeNAME << 16) | 17;
        const int CefV8Value_GetDateValue_18 = (_typeNAME << 16) | 18;
        const int CefV8Value_GetStringValue_19 = (_typeNAME << 16) | 19;
        const int CefV8Value_IsUserCreated_20 = (_typeNAME << 16) | 20;
        const int CefV8Value_HasException_21 = (_typeNAME << 16) | 21;
        const int CefV8Value_GetException_22 = (_typeNAME << 16) | 22;
        const int CefV8Value_ClearException_23 = (_typeNAME << 16) | 23;
        const int CefV8Value_WillRethrowExceptions_24 = (_typeNAME << 16) | 24;
        const int CefV8Value_SetRethrowExceptions_25 = (_typeNAME << 16) | 25;
        const int CefV8Value_HasValue_26 = (_typeNAME << 16) | 26;
        const int CefV8Value_HasValue_27 = (_typeNAME << 16) | 27;
        const int CefV8Value_DeleteValue_28 = (_typeNAME << 16) | 28;
        const int CefV8Value_DeleteValue_29 = (_typeNAME << 16) | 29;
        const int CefV8Value_GetValue_30 = (_typeNAME << 16) | 30;
        const int CefV8Value_GetValue_31 = (_typeNAME << 16) | 31;
        const int CefV8Value_SetValue_32 = (_typeNAME << 16) | 32;
        const int CefV8Value_SetValue_33 = (_typeNAME << 16) | 33;
        const int CefV8Value_SetValue_34 = (_typeNAME << 16) | 34;
        const int CefV8Value_GetKeys_35 = (_typeNAME << 16) | 35;
        const int CefV8Value_SetUserData_36 = (_typeNAME << 16) | 36;
        const int CefV8Value_GetUserData_37 = (_typeNAME << 16) | 37;
        const int CefV8Value_GetExternallyAllocatedMemory_38 = (_typeNAME << 16) | 38;
        const int CefV8Value_AdjustExternallyAllocatedMemory_39 = (_typeNAME << 16) | 39;
        const int CefV8Value_GetArrayLength_40 = (_typeNAME << 16) | 40;
        const int CefV8Value_GetFunctionName_41 = (_typeNAME << 16) | 41;
        const int CefV8Value_GetFunctionHandler_42 = (_typeNAME << 16) | 42;
        const int CefV8Value_ExecuteFunction_43 = (_typeNAME << 16) | 43;
        const int CefV8Value_ExecuteFunctionWithContext_44 = (_typeNAME << 16) | 44;
        internal readonly IntPtr nativePtr;
        internal CefV8Value(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_Release_0, out ret);
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefV8Value methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsValid_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsUndefined()
        /// <summary>
        /// True if the value type is undefined.
        /// /*cef()*/
        /// </summary>

        public bool IsUndefined()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUndefined_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsNull()
        /// <summary>
        /// True if the value type is null.
        /// /*cef()*/
        /// </summary>

        public bool IsNull()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsNull_3, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsBool()
        /// <summary>
        /// True if the value type is bool.
        /// /*cef()*/
        /// </summary>

        public bool IsBool()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsBool_4, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsInt()
        /// <summary>
        /// True if the value type is int.
        /// /*cef()*/
        /// </summary>

        public bool IsInt()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsInt_5, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsUInt()
        /// <summary>
        /// True if the value type is unsigned int.
        /// /*cef()*/
        /// </summary>

        public bool IsUInt()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUInt_6, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsDouble()
        /// <summary>
        /// True if the value type is double.
        /// /*cef()*/
        /// </summary>

        public bool IsDouble()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsDouble_7, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsDate()
        /// <summary>
        /// True if the value type is Date.
        /// /*cef()*/
        /// </summary>

        public bool IsDate()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsDate_8, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsString()
        /// <summary>
        /// True if the value type is string.
        /// /*cef()*/
        /// </summary>

        public bool IsString()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsString_9, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsObject()
        /// <summary>
        /// True if the value type is object.
        /// /*cef()*/
        /// </summary>

        public bool IsObject()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsObject_10, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsArray()
        /// <summary>
        /// True if the value type is array.
        /// /*cef()*/
        /// </summary>

        public bool IsArray()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsArray_11, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsFunction()
        /// <summary>
        /// True if the value type is function.
        /// /*cef()*/
        /// </summary>

        public bool IsFunction()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsFunction_12, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsSame(CefRefPtr<CefV8Value> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefV8Value that
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_IsSame_13, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool GetBoolValue()
        /// <summary>
        /// Return a bool value.
        /// /*cef()*/
        /// </summary>

        public bool GetBoolValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetBoolValue_14, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! int32 GetIntValue()
        /// <summary>
        /// Return an int value.
        /// /*cef()*/
        /// </summary>

        public int GetIntValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetIntValue_15, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! uint32 GetUIntValue()
        /// <summary>
        /// Return an unsigned int value.
        /// /*cef()*/
        /// </summary>

        public uint GetUIntValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetUIntValue_16, out ret);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! double GetDoubleValue()
        /// <summary>
        /// Return a double value.
        /// /*cef()*/
        /// </summary>

        public double GetDoubleValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetDoubleValue_17, out ret);
            var ret_result = ret.Num;
            return ret_result;
        }

        // gen! CefTime GetDateValue()
        /// <summary>
        /// Return a Date value.
        /// /*cef()*/
        /// </summary>

        public CefTime GetDateValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetDateValue_18, out ret);
            var ret_result = new CefTime(ret.Ptr);

            return ret_result;
        }

        // gen! CefString GetStringValue()
        /// <summary>
        /// Return a string value.
        /// /*cef()*/
        /// </summary>

        public string GetStringValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetStringValue_19, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! bool IsUserCreated()
        /// <summary>
        /// OBJECT METHODS - These methods are only available on objects. Arrays and
        /// functions are also objects. String- and integer-based keys can be used
        /// interchangably with the framework converting between them as necessary.
        /// Returns true if this is a user created object.
        /// /*cef()*/
        /// </summary>

        public bool IsUserCreated()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUserCreated_20, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool HasException()
        /// <summary>
        /// Returns true if the last method call resulted in an exception. This
        /// attribute exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>

        public bool HasException()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_HasException_21, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefV8Exception> GetException()
        /// <summary>
        /// Returns the exception resulting from the last method call. This attribute
        /// exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>

        public CefV8Exception GetException()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetException_22, out ret);
            var ret_result = new CefV8Exception(ret.Ptr);
            return ret_result;
        }

        // gen! bool ClearException()
        /// <summary>
        /// Clears the last exception and returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool ClearException()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_ClearException_23, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool WillRethrowExceptions()
        /// <summary>
        /// Returns true if this object will re-throw future exceptions. This attribute
        /// exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>

        public bool WillRethrowExceptions()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_WillRethrowExceptions_24, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetRethrowExceptions(bool rethrow)
        /// <summary>
        /// Set whether this object will re-throw future exceptions. By default
        /// exceptions are not re-thrown. If a exception is re-thrown the current
        /// context should not be accessed again until after the exception has been
        /// caught and not re-thrown. Returns true on success. This attribute exists
        /// only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>

        public bool SetRethrowExceptions(bool rethrow
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = rethrow ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_SetRethrowExceptions_25, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool HasValue(const CefString& key)

        public bool HasValue(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_HasValue_26, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool HasValue(int index)

        public bool HasValue(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_HasValue_27, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool DeleteValue(const CefString& key)

        public bool DeleteValue(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_DeleteValue_28, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool DeleteValue(int index)

        public bool DeleteValue(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_DeleteValue_29, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefV8Value> GetValue(const CefString& key)

        public CefV8Value GetValue(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetValue_30, out ret, ref v1);
            var ret_result = new CefV8Value(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! CefRefPtr<CefV8Value> GetValue(int index)

        public CefV8Value GetValue(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetValue_31, out ret, ref v1);
            var ret_result = new CefV8Value(ret.Ptr);
            return ret_result;
        }

        // gen! bool SetValue(const CefString& key,CefRefPtr<CefV8Value> value,PropertyAttribute attribute)

        public bool SetValue(string key
        , CefV8Value value
        , cef_v8_propertyattribute_t attribute
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;
            v2.Ptr = value.nativePtr;
            v3.I32 = (int)attribute;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_SetValue_32, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool SetValue(int index,CefRefPtr<CefV8Value> value)

        public bool SetValue(int index
        , CefV8Value value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefV8Value_SetValue_33, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetValue(const CefString& key,AccessControl settings,PropertyAttribute attribute)

        public bool SetValue(string key
        , cef_v8_accesscontrol_t settings
        , cef_v8_propertyattribute_t attribute
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;
            v2.I32 = (int)settings;
            v3.I32 = (int)attribute;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_SetValue_34, out ret, ref v1, ref v2, ref v3);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool GetKeys(std::vector<CefString>& keys)
        /// <summary>
        /// Read the keys for the object's values into the specified vector. Integer-
        /// based keys will also be returned as strings.
        /// /*cef()*/
        /// </summary>

        public bool GetKeys(List<string> keys
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetKeys_35, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, keys);
            return ret_result;
        }

        // gen! bool SetUserData(CefRefPtr<CefBaseRefCounted> user_data)
        /// <summary>
        /// Sets the user data for this object and returns true on success. Returns
        /// false if this method is called incorrectly. This method can only be called
        /// on user created objects.
        /// /*cef(optional_param=user_data)*/
        /// </summary>

        public bool SetUserData(CefBaseRefCounted user_data
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            //v1.Ptr = user_data;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_SetUserData_36, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefBaseRefCounted> GetUserData()
        /// <summary>
        /// Returns the user data, if any, assigned to this object.
        /// /*cef()*/
        /// </summary>

        public CefBaseRefCounted GetUserData()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetUserData_37, out ret);
            var ret_result = new CefBaseRefCounted(ret.Ptr);
            return ret_result;
        }

        // gen! int GetExternallyAllocatedMemory()
        /// <summary>
        /// Returns the amount of externally allocated memory registered for the
        /// object.
        /// /*cef()*/
        /// </summary>

        public int GetExternallyAllocatedMemory()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetExternallyAllocatedMemory_38, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int AdjustExternallyAllocatedMemory(int change_in_bytes)
        /// <summary>
        /// Adjusts the amount of registered external memory for the object. Used to
        /// give V8 an indication of the amount of externally allocated memory that is
        /// kept alive by JavaScript objects. V8 uses this information to decide when
        /// to perform global garbage collection. Each CefV8Value tracks the amount of
        /// external memory associated with it and automatically decreases the global
        /// total by the appropriate amount on its destruction. |change_in_bytes|
        /// specifies the number of bytes to adjust by. This method returns the number
        /// of bytes associated with the object after the adjustment. This method can
        /// only be called on user created objects.
        /// /*cef()*/
        /// </summary>

        public int AdjustExternallyAllocatedMemory(int change_in_bytes
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)change_in_bytes;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_AdjustExternallyAllocatedMemory_39, out ret, ref v1);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int GetArrayLength()
        /// <summary>
        /// ARRAY METHODS - These methods are only available on arrays.
        /// Returns the number of elements in the array.
        /// /*cef()*/
        /// </summary>

        public int GetArrayLength()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetArrayLength_40, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! CefString GetFunctionName()
        /// <summary>
        /// FUNCTION METHODS - These methods are only available on functions.
        /// Returns the function name.
        /// /*cef()*/
        /// </summary>

        public string GetFunctionName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetFunctionName_41, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefRefPtr<CefV8Handler> GetFunctionHandler()
        /// <summary>
        /// Returns the function handler or NULL if not a CEF-created function.
        /// /*cef()*/
        /// </summary>

        public CefV8Handler GetFunctionHandler()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetFunctionHandler_42, out ret);
            var ret_result = new CefV8Handler(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefV8Value> ExecuteFunction(CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments)
        /// <summary>
        /// Execute the function using the current V8 context. This method should only
        /// be called from within the scope of a CefV8Handler or CefV8Accessor
        /// callback, or in combination with calling Enter() and Exit() on a stored
        /// CefV8Context reference. |object| is the receiver ('this' object) of the
        /// function. If |object| is empty the current context's global object will be
        /// used. |arguments| is the list of arguments that will be passed to the
        /// function. Returns the function return value on success. Returns NULL if
        /// this method is called incorrectly or an exception is thrown.
        /// /*cef(optional_param=object)*/
        /// </summary>

        public CefV8Value ExecuteFunction(CefV8Value _object
        , CefV8ValueList arguments
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = _object.nativePtr;
            v2.Ptr = arguments.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefV8Value_ExecuteFunction_43, out ret, ref v1, ref v2);
            var ret_result = new CefV8Value(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefV8Value> ExecuteFunctionWithContext(CefRefPtr<CefV8Context> context,CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments)
        /// <summary>
        /// Execute the function using the specified V8 context. |object| is the
        /// receiver ('this' object) of the function. If |object| is empty the
        /// specified context's global object will be used. |arguments| is the list of
        /// arguments that will be passed to the function. Returns the function return
        /// value on success. Returns NULL if this method is called incorrectly or an
        /// exception is thrown.
        /// /*cef(optional_param=object)*/
        /// </summary>

        public CefV8Value ExecuteFunctionWithContext(CefV8Context context
        , CefV8Value _object
        , CefV8ValueList arguments
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = context.nativePtr;
            v2.Ptr = _object.nativePtr;
            v3.Ptr = arguments.nativePtr;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_ExecuteFunctionWithContext_44, out ret, ref v1, ref v2, ref v3);
            var ret_result = new CefV8Value(ret.Ptr);
            return ret_result;
        }
    }


    // [virtual] class CefV8StackTrace
    /// <summary>
    /// Class representing a V8 stack trace handle. V8 handles can only be accessed
    /// from the thread on which they are created. Valid threads for creating a V8
    /// handle include the render process main thread (TID_RENDERER) and WebWorker
    /// threads. A task runner for posting tasks on the associated thread can be
    /// retrieved via the CefV8Context::GetTaskRunner() method.
    /// /*(source=library)*/
    /// </summary>
    public struct CefV8StackTrace
    {
        const int _typeNAME = 44;
        const int CefV8StackTrace_Release_0 = (_typeNAME << 16) | 0;
        const int CefV8StackTrace_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefV8StackTrace_GetFrameCount_2 = (_typeNAME << 16) | 2;
        const int CefV8StackTrace_GetFrame_3 = (_typeNAME << 16) | 3;
        internal readonly IntPtr nativePtr;
        internal CefV8StackTrace(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_Release_0, out ret);
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefV8StackTrace methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_IsValid_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! int GetFrameCount()
        /// <summary>
        /// Returns the number of stack frames.
        /// /*cef()*/
        /// </summary>

        public int GetFrameCount()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_GetFrameCount_2, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! CefRefPtr<CefV8StackFrame> GetFrame(int index)
        /// <summary>
        /// Returns the stack frame at the specified 0-based index.
        /// /*cef()*/
        /// </summary>

        public CefV8StackFrame GetFrame(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8StackTrace_GetFrame_3, out ret, ref v1);
            var ret_result = new CefV8StackFrame(ret.Ptr);
            return ret_result;
        }
    }


    // [virtual] class CefV8StackFrame
    /// <summary>
    /// Class representing a V8 stack frame handle. V8 handles can only be accessed
    /// from the thread on which they are created. Valid threads for creating a V8
    /// handle include the render process main thread (TID_RENDERER) and WebWorker
    /// threads. A task runner for posting tasks on the associated thread can be
    /// retrieved via the CefV8Context::GetTaskRunner() method.
    /// /*(source=library)*/
    /// </summary>
    public struct CefV8StackFrame
    {
        const int _typeNAME = 45;
        const int CefV8StackFrame_Release_0 = (_typeNAME << 16) | 0;
        const int CefV8StackFrame_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefV8StackFrame_GetScriptName_2 = (_typeNAME << 16) | 2;
        const int CefV8StackFrame_GetScriptNameOrSourceURL_3 = (_typeNAME << 16) | 3;
        const int CefV8StackFrame_GetFunctionName_4 = (_typeNAME << 16) | 4;
        const int CefV8StackFrame_GetLineNumber_5 = (_typeNAME << 16) | 5;
        const int CefV8StackFrame_GetColumn_6 = (_typeNAME << 16) | 6;
        const int CefV8StackFrame_IsEval_7 = (_typeNAME << 16) | 7;
        const int CefV8StackFrame_IsConstructor_8 = (_typeNAME << 16) | 8;
        internal readonly IntPtr nativePtr;
        internal CefV8StackFrame(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_Release_0, out ret);
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefV8StackFrame methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsValid_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefString GetScriptName()
        /// <summary>
        /// Returns the name of the resource script that contains the function.
        /// /*cef()*/
        /// </summary>

        public string GetScriptName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetScriptName_2, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetScriptNameOrSourceURL()
        /// <summary>
        /// Returns the name of the resource script that contains the function or the
        /// sourceURL value if the script name is undefined and its source ends with
        /// a "//@ sourceURL=..." string.
        /// /*cef()*/
        /// </summary>

        public string GetScriptNameOrSourceURL()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetScriptNameOrSourceURL_3, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetFunctionName()
        /// <summary>
        /// Returns the name of the function.
        /// /*cef()*/
        /// </summary>

        public string GetFunctionName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetFunctionName_4, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! int GetLineNumber()
        /// <summary>
        /// Returns the 1-based line number for the function call or 0 if unknown.
        /// /*cef()*/
        /// </summary>

        public int GetLineNumber()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetLineNumber_5, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int GetColumn()
        /// <summary>
        /// Returns the 1-based column offset on the line for the function call or 0 if
        /// unknown.
        /// /*cef()*/
        /// </summary>

        public int GetColumn()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetColumn_6, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! bool IsEval()
        /// <summary>
        /// Returns true if the function was compiled using eval().
        /// /*cef()*/
        /// </summary>

        public bool IsEval()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsEval_7, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsConstructor()
        /// <summary>
        /// Returns true if the function was called as a constructor via "new".
        /// /*cef()*/
        /// </summary>

        public bool IsConstructor()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsConstructor_8, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }
    }


    // [virtual] class CefValue
    /// <summary>
    /// Class that wraps other data value types. Complex types (binary, dictionary
    /// and list) will be referenced but not owned by this object. Can be used on any
    /// process and thread.
    /// /*cef(source=library)*/
    /// </summary>
    public struct CefValue
    {
        const int _typeNAME = 46;
        const int CefValue_Release_0 = (_typeNAME << 16) | 0;
        const int CefValue_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefValue_IsOwned_2 = (_typeNAME << 16) | 2;
        const int CefValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        const int CefValue_IsSame_4 = (_typeNAME << 16) | 4;
        const int CefValue_IsEqual_5 = (_typeNAME << 16) | 5;
        const int CefValue_Copy_6 = (_typeNAME << 16) | 6;
        const int CefValue_GetType_7 = (_typeNAME << 16) | 7;
        const int CefValue_GetBool_8 = (_typeNAME << 16) | 8;
        const int CefValue_GetInt_9 = (_typeNAME << 16) | 9;
        const int CefValue_GetDouble_10 = (_typeNAME << 16) | 10;
        const int CefValue_GetString_11 = (_typeNAME << 16) | 11;
        const int CefValue_GetBinary_12 = (_typeNAME << 16) | 12;
        const int CefValue_GetDictionary_13 = (_typeNAME << 16) | 13;
        const int CefValue_GetList_14 = (_typeNAME << 16) | 14;
        const int CefValue_SetNull_15 = (_typeNAME << 16) | 15;
        const int CefValue_SetBool_16 = (_typeNAME << 16) | 16;
        const int CefValue_SetInt_17 = (_typeNAME << 16) | 17;
        const int CefValue_SetDouble_18 = (_typeNAME << 16) | 18;
        const int CefValue_SetString_19 = (_typeNAME << 16) | 19;
        const int CefValue_SetBinary_20 = (_typeNAME << 16) | 20;
        const int CefValue_SetDictionary_21 = (_typeNAME << 16) | 21;
        const int CefValue_SetList_22 = (_typeNAME << 16) | 22;
        internal readonly IntPtr nativePtr;
        internal CefValue(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_Release_0, out ret);
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefValue methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsValid_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if the underlying data is owned by another object.
        /// /*cef()*/
        /// </summary>

        public bool IsOwned()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsOwned_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the underlying data is read-only. Some APIs may expose
        /// read-only objects.
        /// /*cef()*/
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsReadOnly_3, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsSame(CefRefPtr<CefValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefValue that
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_IsSame_4, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsEqual(CefRefPtr<CefValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>

        public bool IsEqual(CefValue that
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_IsEqual_5, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefValue> Copy()
        /// <summary>
        /// Returns a copy of this object. The underlying data will also be copied.
        /// /*cef()*/
        /// </summary>

        public CefValue Copy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_Copy_6, out ret);
            var ret_result = new CefValue(ret.Ptr);
            return ret_result;
        }

        // gen! CefValueType GetType()
        /// <summary>
        /// Returns the underlying value type.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>

        public cef_value_type_t _GetType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetType_7, out ret);
            var ret_result = (cef_value_type_t)ret.I32;

            return ret_result;
        }

        // gen! bool GetBool()
        /// <summary>
        /// Returns the underlying value as type bool.
        /// /*cef()*/
        /// </summary>

        public bool GetBool()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetBool_8, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! int GetInt()
        /// <summary>
        /// Returns the underlying value as type int.
        /// /*cef()*/
        /// </summary>

        public int GetInt()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetInt_9, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! double GetDouble()
        /// <summary>
        /// Returns the underlying value as type double.
        /// /*cef()*/
        /// </summary>

        public double GetDouble()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetDouble_10, out ret);
            var ret_result = ret.Num;
            return ret_result;
        }

        // gen! CefString GetString()
        /// <summary>
        /// Returns the underlying value as type string.
        /// /*cef()*/
        /// </summary>

        public string GetString()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetString_11, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefRefPtr<CefBinaryValue> GetBinary()
        /// <summary>
        /// Returns the underlying value as type binary. The returned reference may
        /// become invalid if the value is owned by another object or if ownership is
        /// transferred to another object in the future. To maintain a reference to
        /// the value after assigning ownership to a dictionary or list pass this
        /// object to the SetValue() method instead of passing the returned reference
        /// to SetBinary().
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetBinary()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetBinary_12, out ret);
            var ret_result = new CefBinaryValue(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefDictionaryValue> GetDictionary()
        /// <summary>
        /// Returns the underlying value as type dictionary. The returned reference may
        /// become invalid if the value is owned by another object or if ownership is
        /// transferred to another object in the future. To maintain a reference to
        /// the value after assigning ownership to a dictionary or list pass this
        /// object to the SetValue() method instead of passing the returned reference
        /// to SetDictionary().
        /// /*cef()*/
        /// </summary>

        public CefDictionaryValue GetDictionary()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetDictionary_13, out ret);
            var ret_result = new CefDictionaryValue(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefListValue> GetList()
        /// <summary>
        /// Returns the underlying value as type list. The returned reference may
        /// become invalid if the value is owned by another object or if ownership is
        /// transferred to another object in the future. To maintain a reference to
        /// the value after assigning ownership to a dictionary or list pass this
        /// object to the SetValue() method instead of passing the returned reference
        /// to SetList().
        /// /*cef()*/
        /// </summary>

        public CefListValue GetList()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetList_14, out ret);
            var ret_result = new CefListValue(ret.Ptr);
            return ret_result;
        }

        // gen! bool SetNull()
        /// <summary>
        /// Sets the underlying value as type null. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetNull()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_SetNull_15, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetBool(bool value)
        /// <summary>
        /// Sets the underlying value as type bool. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetBool(bool value
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = value ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetBool_16, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetInt(int value)
        /// <summary>
        /// Sets the underlying value as type int. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetInt(int value
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)value;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetInt_17, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetDouble(double value)
        /// <summary>
        /// Sets the underlying value as type double. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetDouble(double value
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Num = value;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetDouble_18, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetString(const CefString& value)
        /// <summary>
        /// Sets the underlying value as type string. Returns true if the value was set
        /// successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>

        public bool SetString(string value
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(value);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetString_19, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool SetBinary(CefRefPtr<CefBinaryValue> value)
        /// <summary>
        /// Sets the underlying value as type binary. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>

        public bool SetBinary(CefBinaryValue value
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetBinary_20, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetDictionary(CefRefPtr<CefDictionaryValue> value)
        /// <summary>
        /// Sets the underlying value as type dict. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>

        public bool SetDictionary(CefDictionaryValue value
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetDictionary_21, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetList(CefRefPtr<CefListValue> value)
        /// <summary>
        /// Sets the underlying value as type list. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>

        public bool SetList(CefListValue value
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetList_22, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }
    }


    // [virtual] class CefBinaryValue
    /// <summary>
    /// Class representing a binary value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefBinaryValue
    {
        const int _typeNAME = 47;
        const int CefBinaryValue_Release_0 = (_typeNAME << 16) | 0;
        const int CefBinaryValue_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefBinaryValue_IsOwned_2 = (_typeNAME << 16) | 2;
        const int CefBinaryValue_IsSame_3 = (_typeNAME << 16) | 3;
        const int CefBinaryValue_IsEqual_4 = (_typeNAME << 16) | 4;
        const int CefBinaryValue_Copy_5 = (_typeNAME << 16) | 5;
        const int CefBinaryValue_GetSize_6 = (_typeNAME << 16) | 6;
        const int CefBinaryValue_GetData_7 = (_typeNAME << 16) | 7;
        internal readonly IntPtr nativePtr;
        internal CefBinaryValue(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_Release_0, out ret);
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefBinaryValue methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_IsValid_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>

        public bool IsOwned()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_IsOwned_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsSame(CefRefPtr<CefBinaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefBinaryValue that
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBinaryValue_IsSame_3, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsEqual(CefRefPtr<CefBinaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>

        public bool IsEqual(CefBinaryValue that
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBinaryValue_IsEqual_4, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefBinaryValue> Copy()
        /// <summary>
        /// Returns a copy of this object. The data in this object will also be copied.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue Copy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_Copy_5, out ret);
            var ret_result = new CefBinaryValue(ret.Ptr);
            return ret_result;
        }

        // gen! size_t GetSize()
        /// <summary>
        /// Returns the data size.
        /// /*cef()*/
        /// </summary>

        public uint GetSize()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_GetSize_6, out ret);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! size_t GetData(void* buffer,size_t buffer_size,size_t data_offset)
        /// <summary>
        /// Read up to |buffer_size| number of bytes into |buffer|. Reading begins at
        /// the specified byte |data_offset|. Returns the number of bytes read.
        /// /*cef()*/
        /// </summary>

        public uint GetData(IntPtr buffer
        , uint buffer_size
        , uint data_offset
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = buffer;
            v2.I32 = (int)buffer_size;
            v3.I32 = (int)data_offset;

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBinaryValue_GetData_7, out ret, ref v1, ref v2, ref v3);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }
    }


    // [virtual] class CefDictionaryValue
    /// <summary>
    /// Class representing a dictionary value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefDictionaryValue
    {
        const int _typeNAME = 48;
        const int CefDictionaryValue_Release_0 = (_typeNAME << 16) | 0;
        const int CefDictionaryValue_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefDictionaryValue_IsOwned_2 = (_typeNAME << 16) | 2;
        const int CefDictionaryValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        const int CefDictionaryValue_IsSame_4 = (_typeNAME << 16) | 4;
        const int CefDictionaryValue_IsEqual_5 = (_typeNAME << 16) | 5;
        const int CefDictionaryValue_Copy_6 = (_typeNAME << 16) | 6;
        const int CefDictionaryValue_GetSize_7 = (_typeNAME << 16) | 7;
        const int CefDictionaryValue_Clear_8 = (_typeNAME << 16) | 8;
        const int CefDictionaryValue_HasKey_9 = (_typeNAME << 16) | 9;
        const int CefDictionaryValue_GetKeys_10 = (_typeNAME << 16) | 10;
        const int CefDictionaryValue_Remove_11 = (_typeNAME << 16) | 11;
        const int CefDictionaryValue_GetType_12 = (_typeNAME << 16) | 12;
        const int CefDictionaryValue_GetValue_13 = (_typeNAME << 16) | 13;
        const int CefDictionaryValue_GetBool_14 = (_typeNAME << 16) | 14;
        const int CefDictionaryValue_GetInt_15 = (_typeNAME << 16) | 15;
        const int CefDictionaryValue_GetDouble_16 = (_typeNAME << 16) | 16;
        const int CefDictionaryValue_GetString_17 = (_typeNAME << 16) | 17;
        const int CefDictionaryValue_GetBinary_18 = (_typeNAME << 16) | 18;
        const int CefDictionaryValue_GetDictionary_19 = (_typeNAME << 16) | 19;
        const int CefDictionaryValue_GetList_20 = (_typeNAME << 16) | 20;
        const int CefDictionaryValue_SetValue_21 = (_typeNAME << 16) | 21;
        const int CefDictionaryValue_SetNull_22 = (_typeNAME << 16) | 22;
        const int CefDictionaryValue_SetBool_23 = (_typeNAME << 16) | 23;
        const int CefDictionaryValue_SetInt_24 = (_typeNAME << 16) | 24;
        const int CefDictionaryValue_SetDouble_25 = (_typeNAME << 16) | 25;
        const int CefDictionaryValue_SetString_26 = (_typeNAME << 16) | 26;
        const int CefDictionaryValue_SetBinary_27 = (_typeNAME << 16) | 27;
        const int CefDictionaryValue_SetDictionary_28 = (_typeNAME << 16) | 28;
        const int CefDictionaryValue_SetList_29 = (_typeNAME << 16) | 29;
        internal readonly IntPtr nativePtr;
        internal CefDictionaryValue(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_Release_0, out ret);
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefDictionaryValue methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsValid_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>

        public bool IsOwned()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsOwned_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsReadOnly_3, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsSame(CefRefPtr<CefDictionaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefDictionaryValue that
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_IsSame_4, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsEqual(CefRefPtr<CefDictionaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>

        public bool IsEqual(CefDictionaryValue that
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_IsEqual_5, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefDictionaryValue> Copy(bool exclude_empty_children)
        /// <summary>
        /// Returns a writable copy of this object. If |exclude_empty_children| is true
        /// any empty dictionaries or lists will be excluded from the copy.
        /// /*cef()*/
        /// </summary>

        public CefDictionaryValue Copy(bool exclude_empty_children
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = exclude_empty_children ? 1 : 0;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_Copy_6, out ret, ref v1);
            var ret_result = new CefDictionaryValue(ret.Ptr);
            return ret_result;
        }

        // gen! size_t GetSize()
        /// <summary>
        /// Returns the number of values.
        /// /*cef()*/
        /// </summary>

        public uint GetSize()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_GetSize_7, out ret);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! bool Clear()
        /// <summary>
        /// Removes all values. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool Clear()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_Clear_8, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool HasKey(const CefString& key)
        /// <summary>
        /// Returns true if the current dictionary has a value for the given key.
        /// /*cef()*/
        /// </summary>

        public bool HasKey(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_HasKey_9, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool GetKeys(KeyList& keys)
        /// <summary>
        /// Reads all keys for this dictionary into the specified vector.
        /// /*cef()*/
        /// </summary>

        public bool GetKeys(KeyList keys
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = keys.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetKeys_10, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool Remove(const CefString& key)
        /// <summary>
        /// Removes the value at the specified key. Returns true is the value was
        /// removed successfully.
        /// /*cef()*/
        /// </summary>

        public bool Remove(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_Remove_11, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! CefValueType GetType(const CefString& key)
        /// <summary>
        /// Returns the value type for the specified key.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>

        public cef_value_type_t _GetType(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetType_12, out ret, ref v1);
            var ret_result = (cef_value_type_t)ret.I32;

            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! CefRefPtr<CefValue> GetValue(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key. For simple types the returned
        /// value will copy existing data and modifications to the value will not
        /// modify this object. For complex types (binary, dictionary and list) the
        /// returned value will reference existing data and modifications to the value
        /// will modify this object.
        /// /*cef()*/
        /// </summary>

        public CefValue GetValue(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetValue_13, out ret, ref v1);
            var ret_result = new CefValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool GetBool(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type bool.
        /// /*cef()*/
        /// </summary>

        public bool GetBool(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetBool_14, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! int GetInt(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type int.
        /// /*cef()*/
        /// </summary>

        public int GetInt(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetInt_15, out ret, ref v1);
            var ret_result = ret.I32;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! double GetDouble(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type double.
        /// /*cef()*/
        /// </summary>

        public double GetDouble(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetDouble_16, out ret, ref v1);
            var ret_result = ret.Num;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! CefString GetString(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type string.
        /// /*cef()*/
        /// </summary>

        public string GetString(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetString_17, out ret, ref v1);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! CefRefPtr<CefBinaryValue> GetBinary(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type binary. The returned
        /// value will reference existing data.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetBinary(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetBinary_18, out ret, ref v1);
            var ret_result = new CefBinaryValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! CefRefPtr<CefDictionaryValue> GetDictionary(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type dictionary. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>

        public CefDictionaryValue GetDictionary(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetDictionary_19, out ret, ref v1);
            var ret_result = new CefDictionaryValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! CefRefPtr<CefListValue> GetList(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type list. The returned value
        /// will reference existing data and modifications to the value will modify
        /// this object.
        /// /*cef()*/
        /// </summary>

        public CefListValue GetList(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetList_20, out ret, ref v1);
            var ret_result = new CefListValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool SetValue(const CefString& key,CefRefPtr<CefValue> value)
        /// <summary>
        /// Sets the value at the specified key. Returns true if the value was set
        /// successfully. If |value| represents simple data then the underlying data
        /// will be copied and modifications to |value| will not modify this object. If
        /// |value| represents complex data (binary, dictionary or list) then the
        /// underlying data will be referenced and modifications to |value| will modify
        /// this object.
        /// /*cef()*/
        /// </summary>

        public bool SetValue(string key
        , CefValue value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetValue_21, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool SetNull(const CefString& key)
        /// <summary>
        /// Sets the value at the specified key as type null. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetNull(string key
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_SetNull_22, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool SetBool(const CefString& key,bool value)
        /// <summary>
        /// Sets the value at the specified key as type bool. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetBool(string key
        , bool value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;
            v2.I32 = value ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetBool_23, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool SetInt(const CefString& key,int value)
        /// <summary>
        /// Sets the value at the specified key as type int. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetInt(string key
        , int value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;
            v2.I32 = (int)value;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetInt_24, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool SetDouble(const CefString& key,double value)
        /// <summary>
        /// Sets the value at the specified key as type double. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetDouble(string key
        , double value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;
            v2.Num = value;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetDouble_25, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool SetString(const CefString& key,const CefString& value)
        /// <summary>
        /// Sets the value at the specified key as type string. Returns true if the
        /// value was set successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>

        public bool SetString(string key
        , string value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            ;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetString_26, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }

        // gen! bool SetBinary(const CefString& key,CefRefPtr<CefBinaryValue> value)
        /// <summary>
        /// Sets the value at the specified key as type binary. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>

        public bool SetBinary(string key
        , CefBinaryValue value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetBinary_27, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool SetDictionary(const CefString& key,CefRefPtr<CefDictionaryValue> value)
        /// <summary>
        /// Sets the value at the specified key as type dict. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>

        public bool SetDictionary(string key
        , CefDictionaryValue value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetDictionary_28, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool SetList(const CefString& key,CefRefPtr<CefListValue> value)
        /// <summary>
        /// Sets the value at the specified key as type list. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>

        public bool SetList(string key
        , CefListValue value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            ;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetList_29, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }
    }


    // [virtual] class CefListValue
    /// <summary>
    /// Class representing a list value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    public struct CefListValue
    {
        const int _typeNAME = 49;
        const int CefListValue_Release_0 = (_typeNAME << 16) | 0;
        const int CefListValue_IsValid_1 = (_typeNAME << 16) | 1;
        const int CefListValue_IsOwned_2 = (_typeNAME << 16) | 2;
        const int CefListValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        const int CefListValue_IsSame_4 = (_typeNAME << 16) | 4;
        const int CefListValue_IsEqual_5 = (_typeNAME << 16) | 5;
        const int CefListValue_Copy_6 = (_typeNAME << 16) | 6;
        const int CefListValue_SetSize_7 = (_typeNAME << 16) | 7;
        const int CefListValue_GetSize_8 = (_typeNAME << 16) | 8;
        const int CefListValue_Clear_9 = (_typeNAME << 16) | 9;
        const int CefListValue_Remove_10 = (_typeNAME << 16) | 10;
        const int CefListValue_GetType_11 = (_typeNAME << 16) | 11;
        const int CefListValue_GetValue_12 = (_typeNAME << 16) | 12;
        const int CefListValue_GetBool_13 = (_typeNAME << 16) | 13;
        const int CefListValue_GetInt_14 = (_typeNAME << 16) | 14;
        const int CefListValue_GetDouble_15 = (_typeNAME << 16) | 15;
        const int CefListValue_GetString_16 = (_typeNAME << 16) | 16;
        const int CefListValue_GetBinary_17 = (_typeNAME << 16) | 17;
        const int CefListValue_GetDictionary_18 = (_typeNAME << 16) | 18;
        const int CefListValue_GetList_19 = (_typeNAME << 16) | 19;
        const int CefListValue_SetValue_20 = (_typeNAME << 16) | 20;
        const int CefListValue_SetNull_21 = (_typeNAME << 16) | 21;
        const int CefListValue_SetBool_22 = (_typeNAME << 16) | 22;
        const int CefListValue_SetInt_23 = (_typeNAME << 16) | 23;
        const int CefListValue_SetDouble_24 = (_typeNAME << 16) | 24;
        const int CefListValue_SetString_25 = (_typeNAME << 16) | 25;
        const int CefListValue_SetBinary_26 = (_typeNAME << 16) | 26;
        const int CefListValue_SetDictionary_27 = (_typeNAME << 16) | 27;
        const int CefListValue_SetList_28 = (_typeNAME << 16) | 28;
        internal readonly IntPtr nativePtr;
        internal CefListValue(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Release_0, out ret);
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefListValue methods.
        /// </summary>

        public bool IsValid()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsValid_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>

        public bool IsOwned()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsOwned_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>

        public bool IsReadOnly()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsReadOnly_3, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsSame(CefRefPtr<CefListValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>

        public bool IsSame(CefListValue that
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_IsSame_4, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool IsEqual(CefRefPtr<CefListValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>

        public bool IsEqual(CefListValue that
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_IsEqual_5, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefRefPtr<CefListValue> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>

        public CefListValue Copy()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Copy_6, out ret);
            var ret_result = new CefListValue(ret.Ptr);
            return ret_result;
        }

        // gen! bool SetSize(size_t size)
        /// <summary>
        /// Sets the number of values. If the number of values is expanded all
        /// new value slots will default to type null. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool SetSize(uint size
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)size;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_SetSize_7, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! size_t GetSize()
        /// <summary>
        /// Returns the number of values.
        /// /*cef()*/
        /// </summary>

        public uint GetSize()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_GetSize_8, out ret);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! bool Clear()
        /// <summary>
        /// Removes all values. Returns true on success.
        /// /*cef()*/
        /// </summary>

        public bool Clear()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Clear_9, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool Remove(size_t index)
        /// <summary>
        /// Removes the value at the specified index.
        /// /*cef()*/
        /// </summary>

        public bool Remove(uint index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_Remove_10, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefValueType GetType(size_t index)
        /// <summary>
        /// Returns the value type at the specified index.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>

        public cef_value_type_t _GetType(uint index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetType_11, out ret, ref v1);
            var ret_result = (cef_value_type_t)ret.I32;

            return ret_result;
        }

        // gen! CefRefPtr<CefValue> GetValue(size_t index)
        /// <summary>
        /// Returns the value at the specified index. For simple types the returned
        /// value will copy existing data and modifications to the value will not
        /// modify this object. For complex types (binary, dictionary and list) the
        /// returned value will reference existing data and modifications to the value
        /// will modify this object.
        /// /*cef()*/
        /// </summary>

        public CefValue GetValue(uint index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetValue_12, out ret, ref v1);
            var ret_result = new CefValue(ret.Ptr);
            return ret_result;
        }

        // gen! bool GetBool(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type bool.
        /// /*cef()*/
        /// </summary>

        public bool GetBool(uint index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetBool_13, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! int GetInt(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type int.
        /// /*cef()*/
        /// </summary>

        public int GetInt(uint index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetInt_14, out ret, ref v1);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! double GetDouble(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type double.
        /// /*cef()*/
        /// </summary>

        public double GetDouble(uint index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetDouble_15, out ret, ref v1);
            var ret_result = ret.Num;
            return ret_result;
        }

        // gen! CefString GetString(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type string.
        /// /*cef()*/
        /// </summary>

        public string GetString(uint index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetString_16, out ret, ref v1);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefRefPtr<CefBinaryValue> GetBinary(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type binary. The returned
        /// value will reference existing data.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetBinary(uint index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetBinary_17, out ret, ref v1);
            var ret_result = new CefBinaryValue(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefDictionaryValue> GetDictionary(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type dictionary. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>

        public CefDictionaryValue GetDictionary(uint index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetDictionary_18, out ret, ref v1);
            var ret_result = new CefDictionaryValue(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefListValue> GetList(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type list. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>

        public CefListValue GetList(uint index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetList_19, out ret, ref v1);
            var ret_result = new CefListValue(ret.Ptr);
            return ret_result;
        }

        // gen! bool SetValue(size_t index,CefRefPtr<CefValue> value)
        /// <summary>
        /// Sets the value at the specified index. Returns true if the value was set
        /// successfully. If |value| represents simple data then the underlying data
        /// will be copied and modifications to |value| will not modify this object. If
        /// |value| represents complex data (binary, dictionary or list) then the
        /// underlying data will be referenced and modifications to |value| will modify
        /// this object.
        /// /*cef()*/
        /// </summary>

        public bool SetValue(uint index
        , CefValue value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetValue_20, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetNull(size_t index)
        /// <summary>
        /// Sets the value at the specified index as type null. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetNull(uint index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_SetNull_21, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetBool(size_t index,bool value)
        /// <summary>
        /// Sets the value at the specified index as type bool. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetBool(uint index
        , bool value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = value ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetBool_22, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetInt(size_t index,int value)
        /// <summary>
        /// Sets the value at the specified index as type int. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetInt(uint index
        , int value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.I32 = (int)value;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetInt_23, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetDouble(size_t index,double value)
        /// <summary>
        /// Sets the value at the specified index as type double. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool SetDouble(uint index
        , double value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.Num = value;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetDouble_24, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetString(size_t index,const CefString& value)
        /// <summary>
        /// Sets the value at the specified index as type string. Returns true if the
        /// value was set successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>

        public bool SetString(uint index
        , string value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            ;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetString_25, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }

        // gen! bool SetBinary(size_t index,CefRefPtr<CefBinaryValue> value)
        /// <summary>
        /// Sets the value at the specified index as type binary. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>

        public bool SetBinary(uint index
        , CefBinaryValue value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetBinary_26, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetDictionary(size_t index,CefRefPtr<CefDictionaryValue> value)
        /// <summary>
        /// Sets the value at the specified index as type dict. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>

        public bool SetDictionary(uint index
        , CefDictionaryValue value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetDictionary_27, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool SetList(size_t index,CefRefPtr<CefListValue> value)
        /// <summary>
        /// Sets the value at the specified index as type list. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>

        public bool SetList(uint index
        , CefListValue value
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;
            v2.Ptr = value.nativePtr;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetList_28, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }
    }


    // [virtual] class CefWebPluginInfo
    /// <summary>
    /// Information about a specific web plugin.
    /// /*(source=library)*/
    /// </summary>
    public struct CefWebPluginInfo
    {
        const int _typeNAME = 50;
        const int CefWebPluginInfo_Release_0 = (_typeNAME << 16) | 0;
        const int CefWebPluginInfo_GetName_1 = (_typeNAME << 16) | 1;
        const int CefWebPluginInfo_GetPath_2 = (_typeNAME << 16) | 2;
        const int CefWebPluginInfo_GetVersion_3 = (_typeNAME << 16) | 3;
        const int CefWebPluginInfo_GetDescription_4 = (_typeNAME << 16) | 4;
        internal readonly IntPtr nativePtr;
        internal CefWebPluginInfo(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_Release_0, out ret);
        }

        // gen! CefString GetName()
        /// <summary>
        /// CefWebPluginInfo methods.
        /// </summary>

        public string GetName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetName_1, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetPath()
        /// <summary>
        /// Returns the plugin file path (DLL/bundle/library).
        /// /*cef()*/
        /// </summary>

        public string GetPath()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetPath_2, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetVersion()
        /// <summary>
        /// Returns the version of the plugin (may be OS-specific).
        /// /*cef()*/
        /// </summary>

        public string GetVersion()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetVersion_3, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetDescription()
        /// <summary>
        /// Returns a description of the plugin from the version information.
        /// /*cef()*/
        /// </summary>

        public string GetDescription()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetDescription_4, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }
    }


    // [virtual] class CefWebPluginInfoVisitor
    /// <summary>
    /// Interface to implement for visiting web plugin information. The methods of
    /// this class will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    public struct CefWebPluginInfoVisitor
    {
        const int _typeNAME = 51;
        const int CefWebPluginInfoVisitor_Release_0 = (_typeNAME << 16) | 0;
        internal readonly IntPtr nativePtr;
        internal CefWebPluginInfoVisitor(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfoVisitor_Release_0, out ret);
        }
    }


    // [virtual] class CefX509CertPrincipal
    /// <summary>
    /// Class representing the issuer or subject field of an X.509 certificate.
    /// /*(source=library)*/
    /// </summary>
    public struct CefX509CertPrincipal
    {
        const int _typeNAME = 52;
        const int CefX509CertPrincipal_Release_0 = (_typeNAME << 16) | 0;
        const int CefX509CertPrincipal_GetDisplayName_1 = (_typeNAME << 16) | 1;
        const int CefX509CertPrincipal_GetCommonName_2 = (_typeNAME << 16) | 2;
        const int CefX509CertPrincipal_GetLocalityName_3 = (_typeNAME << 16) | 3;
        const int CefX509CertPrincipal_GetStateOrProvinceName_4 = (_typeNAME << 16) | 4;
        const int CefX509CertPrincipal_GetCountryName_5 = (_typeNAME << 16) | 5;
        const int CefX509CertPrincipal_GetStreetAddresses_6 = (_typeNAME << 16) | 6;
        const int CefX509CertPrincipal_GetOrganizationNames_7 = (_typeNAME << 16) | 7;
        const int CefX509CertPrincipal_GetOrganizationUnitNames_8 = (_typeNAME << 16) | 8;
        const int CefX509CertPrincipal_GetDomainComponents_9 = (_typeNAME << 16) | 9;
        internal readonly IntPtr nativePtr;
        internal CefX509CertPrincipal(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_Release_0, out ret);
        }

        // gen! CefString GetDisplayName()
        /// <summary>
        /// CefX509CertPrincipal methods.
        /// </summary>

        public string GetDisplayName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetDisplayName_1, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetCommonName()
        /// <summary>
        /// Returns the common name.
        /// /*cef()*/
        /// </summary>

        public string GetCommonName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetCommonName_2, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetLocalityName()
        /// <summary>
        /// Returns the locality name.
        /// /*cef()*/
        /// </summary>

        public string GetLocalityName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetLocalityName_3, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetStateOrProvinceName()
        /// <summary>
        /// Returns the state or province name.
        /// /*cef()*/
        /// </summary>

        public string GetStateOrProvinceName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetStateOrProvinceName_4, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetCountryName()
        /// <summary>
        /// Returns the country name.
        /// /*cef()*/
        /// </summary>

        public string GetCountryName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetCountryName_5, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! void GetStreetAddresses(std::vector<CefString>& addresses)
        /// <summary>
        /// Retrieve the list of street addresses.
        /// /*cef()*/
        /// </summary>

        public void GetStreetAddresses(List<string> addresses
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetStreetAddresses_6, out ret, ref v1);

            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, addresses);
        }

        // gen! void GetOrganizationNames(std::vector<CefString>& names)
        /// <summary>
        /// Retrieve the list of organization names.
        /// /*cef()*/
        /// </summary>

        public void GetOrganizationNames(List<string> names
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetOrganizationNames_7, out ret, ref v1);

            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, names);
        }

        // gen! void GetOrganizationUnitNames(std::vector<CefString>& names)
        /// <summary>
        /// Retrieve the list of organization unit names.
        /// /*cef()*/
        /// </summary>

        public void GetOrganizationUnitNames(List<string> names
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetOrganizationUnitNames_8, out ret, ref v1);

            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, names);
        }

        // gen! void GetDomainComponents(std::vector<CefString>& components)
        /// <summary>
        /// Retrieve the list of domain components.
        /// /*cef()*/
        /// </summary>

        public void GetDomainComponents(List<string> components
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2);

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetDomainComponents_9, out ret, ref v1);

            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, components);
        }
    }


    // [virtual] class CefX509Certificate
    /// <summary>
    /// Class representing a X.509 certificate.
    /// /*(source=library)*/
    /// </summary>
    public struct CefX509Certificate
    {
        const int _typeNAME = 53;
        const int CefX509Certificate_Release_0 = (_typeNAME << 16) | 0;
        const int CefX509Certificate_GetSubject_1 = (_typeNAME << 16) | 1;
        const int CefX509Certificate_GetIssuer_2 = (_typeNAME << 16) | 2;
        const int CefX509Certificate_GetSerialNumber_3 = (_typeNAME << 16) | 3;
        const int CefX509Certificate_GetValidStart_4 = (_typeNAME << 16) | 4;
        const int CefX509Certificate_GetValidExpiry_5 = (_typeNAME << 16) | 5;
        const int CefX509Certificate_GetDEREncoded_6 = (_typeNAME << 16) | 6;
        const int CefX509Certificate_GetPEMEncoded_7 = (_typeNAME << 16) | 7;
        const int CefX509Certificate_GetIssuerChainSize_8 = (_typeNAME << 16) | 8;
        const int CefX509Certificate_GetDEREncodedIssuerChain_9 = (_typeNAME << 16) | 9;
        const int CefX509Certificate_GetPEMEncodedIssuerChain_10 = (_typeNAME << 16) | 10;
        internal readonly IntPtr nativePtr;
        internal CefX509Certificate(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_Release_0, out ret);
        }

        // gen! CefRefPtr<CefX509CertPrincipal> GetSubject()
        /// <summary>
        /// CefX509Certificate methods.
        /// </summary>

        public CefX509CertPrincipal GetSubject()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetSubject_1, out ret);
            var ret_result = new CefX509CertPrincipal(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefX509CertPrincipal> GetIssuer()
        /// <summary>
        /// Returns the issuer of the X.509 certificate.
        /// /*cef()*/
        /// </summary>

        public CefX509CertPrincipal GetIssuer()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetIssuer_2, out ret);
            var ret_result = new CefX509CertPrincipal(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefBinaryValue> GetSerialNumber()
        /// <summary>
        /// Returns the DER encoded serial number for the X.509 certificate. The value
        /// possibly includes a leading 00 byte.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetSerialNumber()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetSerialNumber_3, out ret);
            var ret_result = new CefBinaryValue(ret.Ptr);
            return ret_result;
        }

        // gen! CefTime GetValidStart()
        /// <summary>
        /// Returns the date before which the X.509 certificate is invalid.
        /// CefTime.GetTimeT() will return 0 if no date was specified.
        /// /*cef()*/
        /// </summary>

        public CefTime GetValidStart()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetValidStart_4, out ret);
            var ret_result = new CefTime(ret.Ptr);

            return ret_result;
        }

        // gen! CefTime GetValidExpiry()
        /// <summary>
        /// Returns the date after which the X.509 certificate is invalid.
        /// CefTime.GetTimeT() will return 0 if no date was specified.
        /// /*cef()*/
        /// </summary>

        public CefTime GetValidExpiry()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetValidExpiry_5, out ret);
            var ret_result = new CefTime(ret.Ptr);

            return ret_result;
        }

        // gen! CefRefPtr<CefBinaryValue> GetDEREncoded()
        /// <summary>
        /// Returns the DER encoded data for the X.509 certificate.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetDEREncoded()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetDEREncoded_6, out ret);
            var ret_result = new CefBinaryValue(ret.Ptr);
            return ret_result;
        }

        // gen! CefRefPtr<CefBinaryValue> GetPEMEncoded()
        /// <summary>
        /// Returns the PEM encoded data for the X.509 certificate.
        /// /*cef()*/
        /// </summary>

        public CefBinaryValue GetPEMEncoded()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetPEMEncoded_7, out ret);
            var ret_result = new CefBinaryValue(ret.Ptr);
            return ret_result;
        }

        // gen! size_t GetIssuerChainSize()
        /// <summary>
        /// Returns the number of certificates in the issuer chain.
        /// If 0, the certificate is self-signed.
        /// /*cef()*/
        /// </summary>

        public uint GetIssuerChainSize()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetIssuerChainSize_8, out ret);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! void GetDEREncodedIssuerChain(IssuerChainBinaryList& chain)
        /// <summary>
        /// Returns the DER encoded data for the certificate issuer chain.
        /// If we failed to encode a certificate in the chain it is still
        /// present in the array but is an empty string.
        /// /*cef(count_func=chain:GetIssuerChainSize)*/
        /// </summary>

        public void GetDEREncodedIssuerChain(IssuerChainBinaryList chain
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = chain.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509Certificate_GetDEREncodedIssuerChain_9, out ret, ref v1);

        }

        // gen! void GetPEMEncodedIssuerChain(IssuerChainBinaryList& chain)
        /// <summary>
        /// Returns the PEM encoded data for the certificate issuer chain.
        /// If we failed to encode a certificate in the chain it is still
        /// present in the array but is an empty string.
        /// /*cef(count_func=chain:GetIssuerChainSize)*/
        /// </summary>

        public void GetPEMEncodedIssuerChain(IssuerChainBinaryList chain
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = chain.nativePtr;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509Certificate_GetPEMEncodedIssuerChain_10, out ret, ref v1);

        }
    }


    // [virtual] class CefXmlReader
    /// <summary>
    /// Class that supports the reading of XML data via the libxml streaming API.
    /// The methods of this class should only be called on the thread that creates
    /// the object.
    /// /*(source=library)*/
    /// </summary>
    public struct CefXmlReader
    {
        const int _typeNAME = 54;
        const int CefXmlReader_Release_0 = (_typeNAME << 16) | 0;
        const int CefXmlReader_MoveToNextNode_1 = (_typeNAME << 16) | 1;
        const int CefXmlReader_Close_2 = (_typeNAME << 16) | 2;
        const int CefXmlReader_HasError_3 = (_typeNAME << 16) | 3;
        const int CefXmlReader_GetError_4 = (_typeNAME << 16) | 4;
        const int CefXmlReader_GetType_5 = (_typeNAME << 16) | 5;
        const int CefXmlReader_GetDepth_6 = (_typeNAME << 16) | 6;
        const int CefXmlReader_GetLocalName_7 = (_typeNAME << 16) | 7;
        const int CefXmlReader_GetPrefix_8 = (_typeNAME << 16) | 8;
        const int CefXmlReader_GetQualifiedName_9 = (_typeNAME << 16) | 9;
        const int CefXmlReader_GetNamespaceURI_10 = (_typeNAME << 16) | 10;
        const int CefXmlReader_GetBaseURI_11 = (_typeNAME << 16) | 11;
        const int CefXmlReader_GetXmlLang_12 = (_typeNAME << 16) | 12;
        const int CefXmlReader_IsEmptyElement_13 = (_typeNAME << 16) | 13;
        const int CefXmlReader_HasValue_14 = (_typeNAME << 16) | 14;
        const int CefXmlReader_GetValue_15 = (_typeNAME << 16) | 15;
        const int CefXmlReader_HasAttributes_16 = (_typeNAME << 16) | 16;
        const int CefXmlReader_GetAttributeCount_17 = (_typeNAME << 16) | 17;
        const int CefXmlReader_GetAttribute_18 = (_typeNAME << 16) | 18;
        const int CefXmlReader_GetAttribute_19 = (_typeNAME << 16) | 19;
        const int CefXmlReader_GetAttribute_20 = (_typeNAME << 16) | 20;
        const int CefXmlReader_GetInnerXml_21 = (_typeNAME << 16) | 21;
        const int CefXmlReader_GetOuterXml_22 = (_typeNAME << 16) | 22;
        const int CefXmlReader_GetLineNumber_23 = (_typeNAME << 16) | 23;
        const int CefXmlReader_MoveToAttribute_24 = (_typeNAME << 16) | 24;
        const int CefXmlReader_MoveToAttribute_25 = (_typeNAME << 16) | 25;
        const int CefXmlReader_MoveToAttribute_26 = (_typeNAME << 16) | 26;
        const int CefXmlReader_MoveToFirstAttribute_27 = (_typeNAME << 16) | 27;
        const int CefXmlReader_MoveToNextAttribute_28 = (_typeNAME << 16) | 28;
        const int CefXmlReader_MoveToCarryingElement_29 = (_typeNAME << 16) | 29;
        internal readonly IntPtr nativePtr;
        internal CefXmlReader(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_Release_0, out ret);
        }

        // gen! bool MoveToNextNode()
        /// <summary>
        /// CefXmlReader methods.
        /// </summary>

        public bool MoveToNextNode()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToNextNode_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool Close()
        /// <summary>
        /// Close the document. This should be called directly to ensure that cleanup
        /// occurs on the correct thread.
        /// /*cef()*/
        /// </summary>

        public bool Close()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_Close_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool HasError()
        /// <summary>
        /// Returns true if an error has been reported by the XML parser.
        /// /*cef()*/
        /// </summary>

        public bool HasError()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasError_3, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefString GetError()
        /// <summary>
        /// Returns the error string.
        /// /*cef()*/
        /// </summary>

        public string GetError()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetError_4, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! NodeType GetType()
        /// <summary>
        /// The below methods retrieve data for the node at the current cursor
        /// position.
        /// Returns the node type.
        /// /*cef(default_retval=XML_NODE_UNSUPPORTED)*/
        /// </summary>

        public cef_xml_node_type_t _GetType()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetType_5, out ret);
            var ret_result = (cef_xml_node_type_t)ret.I32;

            return ret_result;
        }

        // gen! int GetDepth()
        /// <summary>
        /// Returns the node depth. Depth starts at 0 for the root node.
        /// /*cef()*/
        /// </summary>

        public int GetDepth()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetDepth_6, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! CefString GetLocalName()
        /// <summary>
        /// Returns the local name. See
        /// http://www.w3.org/TR/REC-xml-names/#NT-LocalPart for additional details.
        /// /*cef()*/
        /// </summary>

        public string GetLocalName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetLocalName_7, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetPrefix()
        /// <summary>
        /// Returns the namespace prefix. See http://www.w3.org/TR/REC-xml-names/ for
        /// additional details.
        /// /*cef()*/
        /// </summary>

        public string GetPrefix()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetPrefix_8, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetQualifiedName()
        /// <summary>
        /// Returns the qualified name, equal to (Prefix:)LocalName. See
        /// http://www.w3.org/TR/REC-xml-names/#ns-qualnames for additional details.
        /// /*cef()*/
        /// </summary>

        public string GetQualifiedName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetQualifiedName_9, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetNamespaceURI()
        /// <summary>
        /// Returns the URI defining the namespace associated with the node. See
        /// http://www.w3.org/TR/REC-xml-names/ for additional details.
        /// /*cef()*/
        /// </summary>

        public string GetNamespaceURI()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetNamespaceURI_10, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetBaseURI()
        /// <summary>
        /// Returns the base URI of the node. See http://www.w3.org/TR/xmlbase/ for
        /// additional details.
        /// /*cef()*/
        /// </summary>

        public string GetBaseURI()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetBaseURI_11, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetXmlLang()
        /// <summary>
        /// Returns the xml:lang scope within which the node resides. See
        /// http://www.w3.org/TR/REC-xml/#sec-lang-tag for additional details.
        /// /*cef()*/
        /// </summary>

        public string GetXmlLang()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetXmlLang_12, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! bool IsEmptyElement()
        /// <summary>
        /// Returns true if the node represents an empty element. <a/> is considered
        /// empty but <a></a> is not.
        /// /*cef()*/
        /// </summary>

        public bool IsEmptyElement()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_IsEmptyElement_13, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool HasValue()
        /// <summary>
        /// Returns true if the node has a text value.
        /// /*cef()*/
        /// </summary>

        public bool HasValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasValue_14, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefString GetValue()
        /// <summary>
        /// Returns the text value.
        /// /*cef()*/
        /// </summary>

        public string GetValue()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetValue_15, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! bool HasAttributes()
        /// <summary>
        /// Returns true if the node has attributes.
        /// /*cef()*/
        /// </summary>

        public bool HasAttributes()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasAttributes_16, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! size_t GetAttributeCount()
        /// <summary>
        /// Returns the number of attributes.
        /// /*cef()*/
        /// </summary>

        public uint GetAttributeCount()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetAttributeCount_17, out ret);
            var ret_result = (uint)ret.I32;
            return ret_result;
        }

        // gen! CefString GetAttribute(int index)

        public string GetAttribute(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_GetAttribute_18, out ret, ref v1);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetAttribute(const CefString& qualifiedName)

        public string GetAttribute(string qualifiedName
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(qualifiedName);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_GetAttribute_19, out ret, ref v1);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! CefString GetAttribute(const CefString& localName,const CefString& namespaceURI)

        public string GetAttribute(string localName
        , string namespaceURI
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(localName);
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(namespaceURI);
            ;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefXmlReader_GetAttribute_20, out ret, ref v1, ref v2);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }

        // gen! CefString GetInnerXml()
        /// <summary>
        /// Returns an XML representation of the current node's children.
        /// /*cef()*/
        /// </summary>

        public string GetInnerXml()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetInnerXml_21, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! CefString GetOuterXml()
        /// <summary>
        /// Returns an XML representation of the current node including its children.
        /// /*cef()*/
        /// </summary>

        public string GetOuterXml()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetOuterXml_22, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! int GetLineNumber()
        /// <summary>
        /// Returns the line number for the current node.
        /// /*cef()*/
        /// </summary>

        public int GetLineNumber()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetLineNumber_23, out ret);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! bool MoveToAttribute(int index)

        public bool MoveToAttribute(int index
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_MoveToAttribute_24, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool MoveToAttribute(const CefString& qualifiedName)

        public bool MoveToAttribute(string qualifiedName
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(qualifiedName);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_MoveToAttribute_25, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool MoveToAttribute(const CefString& localName,const CefString& namespaceURI)

        public bool MoveToAttribute(string localName
        , string namespaceURI
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(localName);
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(namespaceURI);
            ;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefXmlReader_MoveToAttribute_26, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr); ;
            return ret_result;
        }

        // gen! bool MoveToFirstAttribute()
        /// <summary>
        /// Moves the cursor to the first attribute in the current element. Returns
        /// true if the cursor position was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool MoveToFirstAttribute()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToFirstAttribute_27, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool MoveToNextAttribute()
        /// <summary>
        /// Moves the cursor to the next attribute in the current element. Returns
        /// true if the cursor position was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool MoveToNextAttribute()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToNextAttribute_28, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool MoveToCarryingElement()
        /// <summary>
        /// Moves the cursor back to the carrying element. Returns true if the cursor
        /// position was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool MoveToCarryingElement()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToCarryingElement_29, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }
    }


    // [virtual] class CefZipReader
    /// <summary>
    /// Class that supports the reading of zip archives via the zlib unzip API.
    /// The methods of this class should only be called on the thread that creates
    /// the object.
    /// /*(source=library)*/
    /// </summary>
    public struct CefZipReader
    {
        const int _typeNAME = 55;
        const int CefZipReader_Release_0 = (_typeNAME << 16) | 0;
        const int CefZipReader_MoveToFirstFile_1 = (_typeNAME << 16) | 1;
        const int CefZipReader_MoveToNextFile_2 = (_typeNAME << 16) | 2;
        const int CefZipReader_MoveToFile_3 = (_typeNAME << 16) | 3;
        const int CefZipReader_Close_4 = (_typeNAME << 16) | 4;
        const int CefZipReader_GetFileName_5 = (_typeNAME << 16) | 5;
        const int CefZipReader_GetFileSize_6 = (_typeNAME << 16) | 6;
        const int CefZipReader_GetFileLastModified_7 = (_typeNAME << 16) | 7;
        const int CefZipReader_OpenFile_8 = (_typeNAME << 16) | 8;
        const int CefZipReader_CloseFile_9 = (_typeNAME << 16) | 9;
        const int CefZipReader_ReadFile_10 = (_typeNAME << 16) | 10;
        const int CefZipReader_Tell_11 = (_typeNAME << 16) | 11;
        const int CefZipReader_Eof_12 = (_typeNAME << 16) | 12;
        internal readonly IntPtr nativePtr;
        internal CefZipReader(IntPtr nativePtr)
        {
            this.nativePtr = nativePtr;
        }
        public void Release()
        {
            JsValue ret;
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Release_0, out ret);
        }

        // gen! bool MoveToFirstFile()
        /// <summary>
        /// CefZipReader methods.
        /// </summary>

        public bool MoveToFirstFile()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_MoveToFirstFile_1, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool MoveToNextFile()
        /// <summary>
        /// Moves the cursor to the next file in the archive. Returns true if the
        /// cursor position was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool MoveToNextFile()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_MoveToNextFile_2, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! bool MoveToFile(const CefString& fileName,bool caseSensitive)
        /// <summary>
        /// Moves the cursor to the specified file in the archive. If |caseSensitive|
        /// is true then the search will be case sensitive. Returns true if the cursor
        /// position was set successfully.
        /// /*cef()*/
        /// </summary>

        public bool MoveToFile(string fileName
        , bool caseSensitive
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(fileName);
            ;
            v2.I32 = caseSensitive ? 1 : 0;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefZipReader_MoveToFile_3, out ret, ref v1, ref v2);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool Close()
        /// <summary>
        /// Closes the archive. This should be called directly to ensure that cleanup
        /// occurs on the correct thread.
        /// /*cef()*/
        /// </summary>

        public bool Close()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Close_4, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! CefString GetFileName()
        /// <summary>
        /// The below methods act on the file at the current cursor position.
        /// Returns the name of the file.
        /// /*cef()*/
        /// </summary>

        public string GetFileName()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileName_5, out ret);
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            return ret_result;
        }

        // gen! int64 GetFileSize()
        /// <summary>
        /// Returns the uncompressed size of the file.
        /// /*cef()*/
        /// </summary>

        public long GetFileSize()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileSize_6, out ret);
            var ret_result = ret.I64;
            return ret_result;
        }

        // gen! CefTime GetFileLastModified()
        /// <summary>
        /// Returns the last modified timestamp for the file.
        /// /*cef()*/
        /// </summary>

        public CefTime GetFileLastModified()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileLastModified_7, out ret);
            var ret_result = new CefTime(ret.Ptr);

            return ret_result;
        }

        // gen! bool OpenFile(const CefString& password)
        /// <summary>
        /// Opens the file for reading of uncompressed data. A read password may
        /// optionally be specified.
        /// /*cef(optional_param=password)*/
        /// </summary>

        public bool OpenFile(string password
        )
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(password);
            ;

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefZipReader_OpenFile_8, out ret, ref v1);
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr); ;
            return ret_result;
        }

        // gen! bool CloseFile()
        /// <summary>
        /// Closes the file.
        /// /*cef()*/
        /// </summary>

        public bool CloseFile()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_CloseFile_9, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }

        // gen! int ReadFile(void* buffer,size_t bufferSize)
        /// <summary>
        /// Read uncompressed file contents into the specified buffer. Returns < 0 if
        /// an error occurred, 0 if at the end of file, or the number of bytes read.
        /// /*cef()*/
        /// </summary>

        public int ReadFile(IntPtr buffer
        , uint bufferSize
        )
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = buffer;
            v2.I32 = (int)bufferSize;

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefZipReader_ReadFile_10, out ret, ref v1, ref v2);
            var ret_result = ret.I32;
            return ret_result;
        }

        // gen! int64 Tell()
        /// <summary>
        /// Returns the current offset in the uncompressed file contents.
        /// /*cef()*/
        /// </summary>

        public long Tell()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Tell_11, out ret);
            var ret_result = ret.I64;
            return ret_result;
        }

        // gen! bool Eof()
        /// <summary>
        /// Returns true if at end of the file contents.
        /// /*cef()*/
        /// </summary>

        public bool Eof()
        {
            JsValue ret;

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Eof_12, out ret);
            var ret_result = ret.I32 != 0;
            return ret_result;
        }
    }

}
