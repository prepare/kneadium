using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge.Auto
{

    /// <summary>
    /// Log severity levels.
    /// </summary>
    /*158*/
    public enum cef_log_severity_t
    {
        /// <summary>
        /// Default logging (currently INFO logging).
        /// </summary>
        LOGSEVERITY_DEFAULT/*159*/
    ,
        /// <summary>
        /// Verbose logging.
        /// </summary>
        LOGSEVERITY_VERBOSE/*160*/
    ,
        /// <summary>
        /// INFO logging.
        /// </summary>
        LOGSEVERITY_INFO/*161*/
    ,
        /// <summary>
        /// WARNING logging.
        /// </summary>
        LOGSEVERITY_WARNING/*162*/
    ,
        /// <summary>
        /// ERROR logging.
        /// </summary>
        LOGSEVERITY_ERROR/*163*/
    ,
        /// <summary>
        /// Completely disable logging.
        /// </summary>
        LOGSEVERITY_DISABLE = 99/*164*/
    }
    /// <summary>
    /// Represents the state of a setting.
    /// </summary>
    /*165*/
    public enum cef_state_t
    {
        /// <summary>
        /// Use the default state for the setting.
        /// </summary>
        STATE_DEFAULT = 0/*166*/
    ,
        /// <summary>
        /// Enable or allow the setting.
        /// </summary>
        STATE_ENABLED/*167*/
    ,
        /// <summary>
        /// Disable or disallow the setting.
        /// </summary>
        STATE_DISABLED/*168*/
    }
    /// <summary>
    /// Return value types.
    /// </summary>
    /*169*/
    public enum cef_return_value_t
    {
        /// <summary>
        /// Cancel immediately.
        /// </summary>
        RV_CANCEL = 0/*170*/
    ,
        /// <summary>
        /// Continue immediately.
        /// </summary>
        RV_CONTINUE/*171*/
    ,
        /// <summary>
        /// Continue asynchronously (usually via a callback).
        /// </summary>
        RV_CONTINUE_ASYNC/*172*/
    }
    /// <summary>
    /// Process termination status values.
    /// </summary>
    /*173*/
    public enum cef_termination_status_t
    {
        /// <summary>
        /// Non-zero exit status.
        /// </summary>
        TS_ABNORMAL_TERMINATION/*174*/
    ,
        /// <summary>
        /// SIGKILL or task manager kill.
        /// </summary>
        TS_PROCESS_WAS_KILLED/*175*/
    ,
        /// <summary>
        /// Segmentation fault.
        /// </summary>
        TS_PROCESS_CRASHED/*176*/
    }
    /// <summary>
    /// Path key values.
    /// </summary>
    /*177*/
    public enum cef_path_key_t
    {
        /// <summary>
        /// Current directory.
        /// </summary>
        PK_DIR_CURRENT/*178*/
    ,
        /// <summary>
        /// Directory containing PK_FILE_EXE.
        /// </summary>
        PK_DIR_EXE/*179*/
    ,
        /// <summary>
        /// Directory containing PK_FILE_MODULE.
        /// </summary>
        PK_DIR_MODULE/*180*/
    ,
        /// <summary>
        /// Temporary directory.
        /// </summary>
        PK_DIR_TEMP/*181*/
    ,
        /// <summary>
        /// Path and filename of the current executable.
        /// </summary>
        PK_FILE_EXE/*182*/
    ,
        /// <summary>
        /// Path and filename of the module containing the CEF code (usually the libcef
        /// module).
        /// </summary>
        PK_FILE_MODULE/*183*/
    ,
        /// <summary>
        /// "Local Settings\Application Data" directory under the user profile
        /// directory on Windows.
        /// </summary>
        PK_LOCAL_APP_DATA/*184*/
    ,
        /// <summary>
        /// "Application Data" directory under the user profile directory on Windows
        /// and "~/Library/Application Support" directory on Mac OS X.
        /// </summary>
        PK_USER_DATA/*185*/
    }
    /// <summary>
    /// Storage types.
    /// </summary>
    /*186*/
    public enum cef_storage_type_t
    {
        ST_LOCALSTORAGE = 0/*187*/
    ,
        ST_SESSIONSTORAGE/*188*/
    }
    /// <summary>
    /// Supported error code values. See net\base\net_error_list.h for complete
    /// descriptions of the error codes.
    /// </summary>
    /*189*/
    public enum cef_errorcode_t
    {
        ERR_NONE = 0/*190*/
    ,
        ERR_FAILED = -2/*191*/
    ,
        ERR_ABORTED = -3/*192*/
    ,
        ERR_INVALID_ARGUMENT = -4/*193*/
    ,
        ERR_INVALID_HANDLE = -5/*194*/
    ,
        ERR_FILE_NOT_FOUND = -6/*195*/
    ,
        ERR_TIMED_OUT = -7/*196*/
    ,
        ERR_FILE_TOO_BIG = -8/*197*/
    ,
        ERR_UNEXPECTED = -9/*198*/
    ,
        ERR_ACCESS_DENIED = -10/*199*/
    ,
        ERR_NOT_IMPLEMENTED = -11/*200*/
    ,
        ERR_CONNECTION_CLOSED = -100/*201*/
    ,
        ERR_CONNECTION_RESET = -101/*202*/
    ,
        ERR_CONNECTION_REFUSED = -102/*203*/
    ,
        ERR_CONNECTION_ABORTED = -103/*204*/
    ,
        ERR_CONNECTION_FAILED = -104/*205*/
    ,
        ERR_NAME_NOT_RESOLVED = -105/*206*/
    ,
        ERR_INTERNET_DISCONNECTED = -106/*207*/
    ,
        ERR_SSL_PROTOCOL_ERROR = -107/*208*/
    ,
        ERR_ADDRESS_INVALID = -108/*209*/
    ,
        ERR_ADDRESS_UNREACHABLE = -109/*210*/
    ,
        ERR_SSL_CLIENT_AUTH_CERT_NEEDED = -110/*211*/
    ,
        ERR_TUNNEL_CONNECTION_FAILED = -111/*212*/
    ,
        ERR_NO_SSL_VERSIONS_ENABLED = -112/*213*/
    ,
        ERR_SSL_VERSION_OR_CIPHER_MISMATCH = -113/*214*/
    ,
        ERR_SSL_RENEGOTIATION_REQUESTED = -114/*215*/
    ,
        ERR_CERT_COMMON_NAME_INVALID = -200/*216*/
    ,
        ERR_CERT_BEGIN = ERR_CERT_COMMON_NAME_INVALID/*217*/
    ,
        ERR_CERT_DATE_INVALID = -201/*218*/
    ,
        ERR_CERT_AUTHORITY_INVALID = -202/*219*/
    ,
        ERR_CERT_CONTAINS_ERRORS = -203/*220*/
    ,
        ERR_CERT_NO_REVOCATION_MECHANISM = -204/*221*/
    ,
        ERR_CERT_UNABLE_TO_CHECK_REVOCATION = -205/*222*/
    ,
        ERR_CERT_REVOKED = -206/*223*/
    ,
        ERR_CERT_INVALID = -207/*224*/
    ,
        ERR_CERT_WEAK_SIGNATURE_ALGORITHM = -208/*225*/
    ,
        /// <summary>
        /// -209 is available: was ERR_CERT_NOT_IN_DNS.
        /// </summary>
        ERR_CERT_NON_UNIQUE_NAME = -210/*226*/
    ,
        ERR_CERT_WEAK_KEY = -211/*227*/
    ,
        ERR_CERT_NAME_CONSTRAINT_VIOLATION = -212/*228*/
    ,
        ERR_CERT_VALIDITY_TOO_LONG = -213/*229*/
    ,
        ERR_CERT_END = ERR_CERT_VALIDITY_TOO_LONG/*230*/
    ,
        ERR_INVALID_URL = -300/*231*/
    ,
        ERR_DISALLOWED_URL_SCHEME = -301/*232*/
    ,
        ERR_UNKNOWN_URL_SCHEME = -302/*233*/
    ,
        ERR_TOO_MANY_REDIRECTS = -310/*234*/
    ,
        ERR_UNSAFE_REDIRECT = -311/*235*/
    ,
        ERR_UNSAFE_PORT = -312/*236*/
    ,
        ERR_INVALID_RESPONSE = -320/*237*/
    ,
        ERR_INVALID_CHUNKED_ENCODING = -321/*238*/
    ,
        ERR_METHOD_NOT_SUPPORTED = -322/*239*/
    ,
        ERR_UNEXPECTED_PROXY_AUTH = -323/*240*/
    ,
        ERR_EMPTY_RESPONSE = -324/*241*/
    ,
        ERR_RESPONSE_HEADERS_TOO_BIG = -325/*242*/
    ,
        ERR_CACHE_MISS = -400/*243*/
    ,
        ERR_INSECURE_RESPONSE = -501/*244*/
    }
    /// <summary>
    /// Supported certificate status code values. See net\cert\cert_status_flags.h
    /// for more information. CERT_STATUS_NONE is new in CEF because we use an
    /// enum while cert_status_flags.h uses a typedef and static const variables.
    /// </summary>
    /*245*/
    public enum cef_cert_status_t
    {
        CERT_STATUS_NONE = 0/*246*/
    ,
        CERT_STATUS_COMMON_NAME_INVALID = 1 << 0/*247*/
    ,
        CERT_STATUS_DATE_INVALID = 1 << 1/*248*/
    ,
        CERT_STATUS_AUTHORITY_INVALID = 1 << 2/*249*/
    ,
        /// <summary>
        /// 1 << 3 is reserved for ERR_CERT_CONTAINS_ERRORS (not useful with WinHTTP).
        /// </summary>
        CERT_STATUS_NO_REVOCATION_MECHANISM = 1 << 4/*250*/
    ,
        CERT_STATUS_UNABLE_TO_CHECK_REVOCATION = 1 << 5/*251*/
    ,
        CERT_STATUS_REVOKED = 1 << 6/*252*/
    ,
        CERT_STATUS_INVALID = 1 << 7/*253*/
    ,
        CERT_STATUS_WEAK_SIGNATURE_ALGORITHM = 1 << 8/*254*/
    ,
        /// <summary>
        /// 1 << 9 was used for CERT_STATUS_NOT_IN_DNS
        /// </summary>
        CERT_STATUS_NON_UNIQUE_NAME = 1 << 10/*255*/
    ,
        CERT_STATUS_WEAK_KEY = 1 << 11/*256*/
    ,
        /// <summary>
        /// 1 << 12 was used for CERT_STATUS_WEAK_DH_KEY
        /// </summary>
        CERT_STATUS_PINNED_KEY_MISSING = 1 << 13/*257*/
    ,
        CERT_STATUS_NAME_CONSTRAINT_VIOLATION = 1 << 14/*258*/
    ,
        CERT_STATUS_VALIDITY_TOO_LONG = 1 << 15/*259*/
    ,
        /// <summary>
        /// Bits 16 to 31 are for non-error statuses.
        /// </summary>
        CERT_STATUS_IS_EV = 1 << 16/*260*/
    ,
        CERT_STATUS_REV_CHECKING_ENABLED = 1 << 17/*261*/
    ,
        /// <summary>
        /// Bit 18 was CERT_STATUS_IS_DNSSEC
        /// </summary>
        CERT_STATUS_SHA1_SIGNATURE_PRESENT = 1 << 19/*262*/
    ,
        CERT_STATUS_CT_COMPLIANCE_FAILED = 1 << 20/*263*/
    }
    /// <summary>
    /// The manner in which a link click should be opened. These constants match
    /// their equivalents in Chromium's window_open_disposition.h and should not be
    /// renumbered.
    /// </summary>
    /*264*/
    public enum cef_window_open_disposition_t
    {
        WOD_UNKNOWN/*265*/
    ,
        WOD_CURRENT_TAB/*266*/
    ,
        WOD_SINGLETON_TAB/*267*/
    ,
        WOD_NEW_FOREGROUND_TAB/*268*/
    ,
        WOD_NEW_BACKGROUND_TAB/*269*/
    ,
        WOD_NEW_POPUP/*270*/
    ,
        WOD_NEW_WINDOW/*271*/
    ,
        WOD_SAVE_TO_DISK/*272*/
    ,
        WOD_OFF_THE_RECORD/*273*/
    }
    /// <summary>
    /// "Verb" of a drag-and-drop operation as negotiated between the source and
    /// destination. These constants match their equivalents in WebCore's
    /// DragActions.h and should not be renumbered.
    /// </summary>
    /*274*/
    public enum cef_drag_operations_mask_t : uint
    {
        DRAG_OPERATION_NONE = 0/*275*/
    ,
        DRAG_OPERATION_COPY = 1/*276*/
    ,
        DRAG_OPERATION_LINK = 2/*277*/
    ,
        DRAG_OPERATION_GENERIC = 4/*278*/
    ,
        DRAG_OPERATION_PRIVATE = 8/*279*/
    ,
        DRAG_OPERATION_MOVE = 16/*280*/
    ,
        DRAG_OPERATION_DELETE = 32/*281*/
    ,
        DRAG_OPERATION_EVERY = uint.MaxValue/*282*/
    }
    /// <summary>
    /// V8 access control values.
    /// </summary>
    /*283*/
    public enum cef_v8_accesscontrol_t
    {
        V8_ACCESS_CONTROL_DEFAULT = 0/*284*/
    ,
        V8_ACCESS_CONTROL_ALL_CAN_READ = 1/*285*/
    ,
        V8_ACCESS_CONTROL_ALL_CAN_WRITE = 1 << 1/*286*/
    ,
        V8_ACCESS_CONTROL_PROHIBITS_OVERWRITING = 1 << 2/*287*/
    }
    /// <summary>
    /// V8 property attribute values.
    /// </summary>
    /*288*/
    public enum cef_v8_propertyattribute_t
    {
        V8_PROPERTY_ATTRIBUTE_NONE = 0/*289*/
    ,
        /// <summary>
        /// Writeable, Enumerable,
        ///   Configurable
        /// </summary>
        V8_PROPERTY_ATTRIBUTE_READONLY = 1 << 0/*290*/
    ,
        /// <summary>
        /// Not writeable
        /// </summary>
        V8_PROPERTY_ATTRIBUTE_DONTENUM = 1 << 1/*291*/
    ,
        /// <summary>
        /// Not enumerable
        /// </summary>
        V8_PROPERTY_ATTRIBUTE_DONTDELETE = 1 << 2/*292*/
    }
    /// <summary>
    /// Post data elements may represent either bytes or files.
    /// </summary>
    /*293*/
    public enum cef_postdataelement_type_t
    {
        PDE_TYPE_EMPTY = 0/*294*/
    ,
        PDE_TYPE_BYTES/*295*/
    ,
        PDE_TYPE_FILE/*296*/
    }
    /// <summary>
    /// Resource type for a request.
    /// </summary>
    /*297*/
    public enum cef_resource_type_t
    {
        /// <summary>
        /// Top level page.
        /// </summary>
        RT_MAIN_FRAME = 0/*298*/
    ,
        /// <summary>
        /// Frame or iframe.
        /// </summary>
        RT_SUB_FRAME/*299*/
    ,
        /// <summary>
        /// CSS stylesheet.
        /// </summary>
        RT_STYLESHEET/*300*/
    ,
        /// <summary>
        /// External script.
        /// </summary>
        RT_SCRIPT/*301*/
    ,
        /// <summary>
        /// Image (jpg/gif/png/etc).
        /// </summary>
        RT_IMAGE/*302*/
    ,
        /// <summary>
        /// Font.
        /// </summary>
        RT_FONT_RESOURCE/*303*/
    ,
        /// <summary>
        /// Some other subresource. This is the default type if the actual type is
        /// unknown.
        /// </summary>
        RT_SUB_RESOURCE/*304*/
    ,
        /// <summary>
        /// Object (or embed) tag for a plugin, or a resource that a plugin requested.
        /// </summary>
        RT_OBJECT/*305*/
    ,
        /// <summary>
        /// Media resource.
        /// </summary>
        RT_MEDIA/*306*/
    ,
        /// <summary>
        /// Main resource of a dedicated worker.
        /// </summary>
        RT_WORKER/*307*/
    ,
        /// <summary>
        /// Main resource of a shared worker.
        /// </summary>
        RT_SHARED_WORKER/*308*/
    ,
        /// <summary>
        /// Explicitly requested prefetch.
        /// </summary>
        RT_PREFETCH/*309*/
    ,
        /// <summary>
        /// Favicon.
        /// </summary>
        RT_FAVICON/*310*/
    ,
        /// <summary>
        /// XMLHttpRequest.
        /// </summary>
        RT_XHR/*311*/
    ,
        /// <summary>
        /// A request for a <ping>
        /// </summary>
        RT_PING/*312*/
    ,
        /// <summary>
        /// Main resource of a service worker.
        /// </summary>
        RT_SERVICE_WORKER/*313*/
    ,
        /// <summary>
        /// A report of Content Security Policy violations.
        /// </summary>
        RT_CSP_REPORT/*314*/
    ,
        /// <summary>
        /// A resource that a plugin requested.
        /// </summary>
        RT_PLUGIN_RESOURCE/*315*/
    }
    /// <summary>
    /// Transition type for a request. Made up of one source value and 0 or more
    /// qualifiers.
    /// </summary>
    /*316*/
    public enum cef_transition_type_t
    {
        /// <summary>
        /// Source is a link click or the JavaScript window.open function. This is
        /// also the default value for requests like sub-resource loads that are not
        /// navigations.
        /// </summary>
        TT_LINK = 0/*317*/
    ,
        /// <summary>
        /// Source is some other "explicit" navigation action such as creating a new
        /// browser or using the LoadURL function. This is also the default value
        /// for navigations where the actual type is unknown.
        /// </summary>
        TT_EXPLICIT = 1/*318*/
    ,
        /// <summary>
        /// Source is a subframe navigation. This is any content that is automatically
        /// loaded in a non-toplevel frame. For example, if a page consists of several
        /// frames containing ads, those ad URLs will have this transition type.
        /// The user may not even realize the content in these pages is a separate
        /// frame, so may not care about the URL.
        /// </summary>
        TT_AUTO_SUBFRAME = 3/*319*/
    ,
        /// <summary>
        /// Source is a subframe navigation explicitly requested by the user that will
        /// generate new navigation entries in the back/forward list. These are
        /// probably more important than frames that were automatically loaded in
        /// the background because the user probably cares about the fact that this
        /// link was loaded.
        /// </summary>
        TT_MANUAL_SUBFRAME = 4/*320*/
    ,
        /// <summary>
        /// Source is a form submission by the user. NOTE: In some situations
        /// submitting a form does not result in this transition type. This can happen
        /// if the form uses a script to submit the contents.
        /// </summary>
        TT_FORM_SUBMIT = 7/*321*/
    ,
        /// <summary>
        /// Source is a "reload" of the page via the Reload function or by re-visiting
        /// the same URL. NOTE: This is distinct from the concept of whether a
        /// particular load uses "reload semantics" (i.e. bypasses cached data).
        /// </summary>
        TT_RELOAD = 8/*322*/
    ,
        /// <summary>
        /// General mask defining the bits used for the source values.
        /// </summary>
        TT_SOURCE_MASK = 0/*323*/
    ,
        xFF/*324*/
    ,
        /// <summary>
        /// Qualifiers.
        /// Any of the core values above can be augmented by one or more qualifiers.
        /// These qualifiers further define the transition.
        /// Attempted to visit a URL but was blocked.
        /// </summary>
        TT_BLOCKED_FLAG = 0/*325*/
    ,
        x00800000/*326*/
    ,
        /// <summary>
        /// Used the Forward or Back function to navigate among browsing history.
        /// </summary>
        TT_FORWARD_BACK_FLAG = 0/*327*/
    ,
        x01000000/*328*/
    ,
        /// <summary>
        /// The beginning of a navigation chain.
        /// </summary>
        TT_CHAIN_START_FLAG = 0/*329*/
    ,
        x10000000/*330*/
    ,
        /// <summary>
        /// The last transition in a redirect chain.
        /// </summary>
        TT_CHAIN_END_FLAG = 0/*331*/
    ,
        x20000000/*332*/
    ,
        /// <summary>
        /// Redirects caused by JavaScript or a meta refresh tag on the page.
        /// </summary>
        TT_CLIENT_REDIRECT_FLAG = 0/*333*/
    ,
        x40000000/*334*/
    ,
        /// <summary>
        /// Redirects sent from the server by HTTP headers.
        /// </summary>
        TT_SERVER_REDIRECT_FLAG = 0/*335*/
    ,
        x80000000/*336*/
    ,
        /// <summary>
        /// Used to test whether a transition involves a redirect.
        /// </summary>
        TT_IS_REDIRECT_MASK = 0/*337*/
    ,
        xC0000000/*338*/
    ,
        /// <summary>
        /// General mask defining the bits used for the qualifiers.
        /// </summary>
        TT_QUALIFIER_MASK = 0/*339*/
    ,
        xFFFFFF00/*340*/
    }
    /// <summary>
    /// Flags used to customize the behavior of CefURLRequest.
    /// </summary>
    /*341*/
    public enum cef_urlrequest_flags_t
    {
        /// <summary>
        /// Default behavior.
        /// </summary>
        UR_FLAG_NONE = 0/*342*/
    ,
        /// <summary>
        /// If set the cache will be skipped when handling the request.
        /// </summary>
        UR_FLAG_SKIP_CACHE = 1 << 0/*343*/
    ,
        /// <summary>
        /// If set user name, password, and cookies may be sent with the request, and
        /// cookies may be saved from the response.
        /// </summary>
        UR_FLAG_ALLOW_CACHED_CREDENTIALS = 1 << 1/*344*/
    ,
        /// <summary>
        /// If set upload progress events will be generated when a request has a body.
        /// </summary>
        UR_FLAG_REPORT_UPLOAD_PROGRESS = 1 << 3/*345*/
    ,
        /// <summary>
        /// If set the CefURLRequestClient::OnDownloadData method will not be called.
        /// </summary>
        UR_FLAG_NO_DOWNLOAD_DATA = 1 << 6/*346*/
    ,
        /// <summary>
        /// If set 5XX redirect errors will be propagated to the observer instead of
        /// automatically re-tried. This currently only applies for requests
        /// originated in the browser process.
        /// </summary>
        UR_FLAG_NO_RETRY_ON_5XX = 1 << 7/*347*/
    }
    /// <summary>
    /// Flags that represent CefURLRequest status.
    /// </summary>
    /*348*/
    public enum cef_urlrequest_status_t
    {
        /// <summary>
        /// Unknown status.
        /// </summary>
        UR_UNKNOWN = 0/*349*/
    ,
        /// <summary>
        /// Request succeeded.
        /// </summary>
        UR_SUCCESS/*350*/
    ,
        /// <summary>
        /// An IO request is pending, and the caller will be informed when it is
        /// completed.
        /// </summary>
        UR_IO_PENDING/*351*/
    ,
        /// <summary>
        /// Request was canceled programatically.
        /// </summary>
        UR_CANCELED/*352*/
    ,
        /// <summary>
        /// Request failed for some reason.
        /// </summary>
        UR_FAILED/*353*/
    }
    /// <summary>
    /// Existing process IDs.
    /// </summary>
    /*354*/
    public enum cef_process_id_t
    {
        /// <summary>
        /// Browser process.
        /// </summary>
        PID_BROWSER/*355*/
    ,
        /// <summary>
        /// Renderer process.
        /// </summary>
        PID_RENDERER/*356*/
    }
    /// <summary>
    /// Existing thread IDs.
    /// </summary>
    /*357*/
    public enum cef_thread_id_t
    {
        /// <summary>
        /// BROWSER PROCESS THREADS -- Only available in the browser process.
        /// The main thread in the browser. This will be the same as the main
        /// application thread if CefInitialize() is called with a
        /// CefSettings.multi_threaded_message_loop value of false.
        /// </summary>
        TID_UI/*358*/
    ,
        /// <summary>
        /// Used to interact with the database.
        /// </summary>
        TID_DB/*359*/
    ,
        /// <summary>
        /// Used to interact with the file system.
        /// </summary>
        TID_FILE/*360*/
    ,
        /// <summary>
        /// Used for file system operations that block user interactions.
        /// Responsiveness of this thread affects users.
        /// </summary>
        TID_FILE_USER_BLOCKING/*361*/
    ,
        /// <summary>
        /// Used to launch and terminate browser processes.
        /// </summary>
        TID_PROCESS_LAUNCHER/*362*/
    ,
        /// <summary>
        /// Used to handle slow HTTP cache operations.
        /// </summary>
        TID_CACHE/*363*/
    ,
        /// <summary>
        /// Used to process IPC and network messages.
        /// </summary>
        TID_IO/*364*/
    ,
        /// <summary>
        /// RENDER PROCESS THREADS -- Only available in the render process.
        /// The main thread in the renderer. Used for all WebKit and V8 interaction.
        /// </summary>
        TID_RENDERER/*365*/
    }
    /// <summary>
    /// Thread priority values listed in increasing order of importance.
    /// </summary>
    /*366*/
    public enum cef_thread_priority_t
    {
        /// <summary>
        /// Suitable for threads that shouldn't disrupt high priority work.
        /// </summary>
        TP_BACKGROUND/*367*/
    ,
        /// <summary>
        /// Default priority level.
        /// </summary>
        TP_NORMAL/*368*/
    ,
        /// <summary>
        /// Suitable for threads which generate data for the display (at ~60Hz).
        /// </summary>
        TP_DISPLAY/*369*/
    ,
        /// <summary>
        /// Suitable for low-latency, glitch-resistant audio.
        /// </summary>
        TP_REALTIME_AUDIO/*370*/
    }
    /// <summary>
    /// Message loop types. Indicates the set of asynchronous events that a message
    /// loop can process.
    /// </summary>
    /*371*/
    public enum cef_message_loop_type_t
    {
        /// <summary>
        /// Supports tasks and timers.
        /// </summary>
        ML_TYPE_DEFAULT/*372*/
    ,
        /// <summary>
        /// Supports tasks, timers and native UI events (e.g. Windows messages).
        /// </summary>
        ML_TYPE_UI/*373*/
    ,
        /// <summary>
        /// Supports tasks, timers and asynchronous IO events.
        /// </summary>
        ML_TYPE_IO/*374*/
    }
    /// <summary>
    /// Windows COM initialization mode. Specifies how COM will be initialized for a
    /// new thread.
    /// </summary>
    /*375*/
    public enum cef_com_init_mode_t
    {
        /// <summary>
        /// No COM initialization.
        /// </summary>
        COM_INIT_MODE_NONE/*376*/
    ,
        /// <summary>
        /// Initialize COM using single-threaded apartments.
        /// </summary>
        COM_INIT_MODE_STA/*377*/
    ,
        /// <summary>
        /// Initialize COM using multi-threaded apartments.
        /// </summary>
        COM_INIT_MODE_MTA/*378*/
    }
    /// <summary>
    /// Supported value types.
    /// </summary>
    /*379*/
    public enum cef_value_type_t
    {
        VTYPE_INVALID = 0/*380*/
    ,
        VTYPE_NULL/*381*/
    ,
        VTYPE_BOOL/*382*/
    ,
        VTYPE_INT/*383*/
    ,
        VTYPE_DOUBLE/*384*/
    ,
        VTYPE_STRING/*385*/
    ,
        VTYPE_BINARY/*386*/
    ,
        VTYPE_DICTIONARY/*387*/
    ,
        VTYPE_LIST/*388*/
    }
    /// <summary>
    /// Supported JavaScript dialog types.
    /// </summary>
    /*389*/
    public enum cef_jsdialog_type_t
    {
        JSDIALOGTYPE_ALERT = 0/*390*/
    ,
        JSDIALOGTYPE_CONFIRM/*391*/
    ,
        JSDIALOGTYPE_PROMPT/*392*/
    }
    /// <summary>
    /// Supported menu IDs. Non-English translations can be provided for the
    /// IDS_MENU_* strings in CefResourceBundleHandler::GetLocalizedString().
    /// </summary>
    /*393*/
    public enum cef_menu_id_t
    {
        /// <summary>
        /// Navigation.
        /// </summary>
        MENU_ID_BACK = 100/*394*/
    ,
        MENU_ID_FORWARD = 101/*395*/
    ,
        MENU_ID_RELOAD = 102/*396*/
    ,
        MENU_ID_RELOAD_NOCACHE = 103/*397*/
    ,
        MENU_ID_STOPLOAD = 104/*398*/
    ,
        /// <summary>
        /// Editing.
        /// </summary>
        MENU_ID_UNDO = 110/*399*/
    ,
        MENU_ID_REDO = 111/*400*/
    ,
        MENU_ID_CUT = 112/*401*/
    ,
        MENU_ID_COPY = 113/*402*/
    ,
        MENU_ID_PASTE = 114/*403*/
    ,
        MENU_ID_DELETE = 115/*404*/
    ,
        MENU_ID_SELECT_ALL = 116/*405*/
    ,
        /// <summary>
        /// Miscellaneous.
        /// </summary>
        MENU_ID_FIND = 130/*406*/
    ,
        MENU_ID_PRINT = 131/*407*/
    ,
        MENU_ID_VIEW_SOURCE = 132/*408*/
    ,
        /// <summary>
        /// Spell checking word correction suggestions.
        /// </summary>
        MENU_ID_SPELLCHECK_SUGGESTION_0 = 200/*409*/
    ,
        MENU_ID_SPELLCHECK_SUGGESTION_1 = 201/*410*/
    ,
        MENU_ID_SPELLCHECK_SUGGESTION_2 = 202/*411*/
    ,
        MENU_ID_SPELLCHECK_SUGGESTION_3 = 203/*412*/
    ,
        MENU_ID_SPELLCHECK_SUGGESTION_4 = 204/*413*/
    ,
        MENU_ID_SPELLCHECK_SUGGESTION_LAST = 204/*414*/
    ,
        MENU_ID_NO_SPELLING_SUGGESTIONS = 205/*415*/
    ,
        MENU_ID_ADD_TO_DICTIONARY = 206/*416*/
    ,
        /// <summary>
        /// Custom menu items originating from the renderer process. For example,
        /// plugin placeholder menu items or Flash menu items.
        /// </summary>
        MENU_ID_CUSTOM_FIRST = 220/*417*/
    ,
        MENU_ID_CUSTOM_LAST = 250/*418*/
    ,
        /// <summary>
        /// All user-defined menu IDs should come between MENU_ID_USER_FIRST and
        /// MENU_ID_USER_LAST to avoid overlapping the Chromium and CEF ID ranges
        /// defined in the tools/gritsettings/resource_ids file.
        /// </summary>
        MENU_ID_USER_FIRST = 26500/*419*/
    ,
        MENU_ID_USER_LAST = 28500/*420*/
    }
    /// <summary>
    /// Mouse button types.
    /// </summary>
    /*421*/
    public enum cef_mouse_button_type_t
    {
        MBT_LEFT = 0/*422*/
    ,
        MBT_MIDDLE/*423*/
    ,
        MBT_RIGHT/*424*/
    }
    /// <summary>
    /// Paint element types.
    /// </summary>
    /*425*/
    public enum cef_paint_element_type_t
    {
        PET_VIEW = 0/*426*/
    ,
        PET_POPUP/*427*/
    }
    /// <summary>
    /// Supported event bit flags.
    /// </summary>
    /*428*/
    public enum cef_event_flags_t
    {
        EVENTFLAG_NONE = 0/*429*/
    ,
        EVENTFLAG_CAPS_LOCK_ON = 1 << 0/*430*/
    ,
        EVENTFLAG_SHIFT_DOWN = 1 << 1/*431*/
    ,
        EVENTFLAG_CONTROL_DOWN = 1 << 2/*432*/
    ,
        EVENTFLAG_ALT_DOWN = 1 << 3/*433*/
    ,
        EVENTFLAG_LEFT_MOUSE_BUTTON = 1 << 4/*434*/
    ,
        EVENTFLAG_MIDDLE_MOUSE_BUTTON = 1 << 5/*435*/
    ,
        EVENTFLAG_RIGHT_MOUSE_BUTTON = 1 << 6/*436*/
    ,
        /// <summary>
        /// Mac OS-X command key.
        /// </summary>
        EVENTFLAG_COMMAND_DOWN = 1 << 7/*437*/
    ,
        EVENTFLAG_NUM_LOCK_ON = 1 << 8/*438*/
    ,
        EVENTFLAG_IS_KEY_PAD = 1 << 9/*439*/
    ,
        EVENTFLAG_IS_LEFT = 1 << 10/*440*/
    ,
        EVENTFLAG_IS_RIGHT = 1 << 11/*441*/
    }
    /// <summary>
    /// Supported menu item types.
    /// </summary>
    /*442*/
    public enum cef_menu_item_type_t
    {
        MENUITEMTYPE_NONE/*443*/
    ,
        MENUITEMTYPE_COMMAND/*444*/
    ,
        MENUITEMTYPE_CHECK/*445*/
    ,
        MENUITEMTYPE_RADIO/*446*/
    ,
        MENUITEMTYPE_SEPARATOR/*447*/
    ,
        MENUITEMTYPE_SUBMENU/*448*/
    }
    /// <summary>
    /// Supported context menu type flags.
    /// </summary>
    /*449*/
    public enum cef_context_menu_type_flags_t
    {
        /// <summary>
        /// No node is selected.
        /// </summary>
        CM_TYPEFLAG_NONE = 0/*450*/
    ,
        /// <summary>
        /// The top page is selected.
        /// </summary>
        CM_TYPEFLAG_PAGE = 1 << 0/*451*/
    ,
        /// <summary>
        /// A subframe page is selected.
        /// </summary>
        CM_TYPEFLAG_FRAME = 1 << 1/*452*/
    ,
        /// <summary>
        /// A link is selected.
        /// </summary>
        CM_TYPEFLAG_LINK = 1 << 2/*453*/
    ,
        /// <summary>
        /// A media node is selected.
        /// </summary>
        CM_TYPEFLAG_MEDIA = 1 << 3/*454*/
    ,
        /// <summary>
        /// There is a textual or mixed selection that is selected.
        /// </summary>
        CM_TYPEFLAG_SELECTION = 1 << 4/*455*/
    ,
        /// <summary>
        /// An editable element is selected.
        /// </summary>
        CM_TYPEFLAG_EDITABLE = 1 << 5/*456*/
    }
    /// <summary>
    /// Supported context menu media types.
    /// </summary>
    /*457*/
    public enum cef_context_menu_media_type_t
    {
        /// <summary>
        /// No special node is in context.
        /// </summary>
        CM_MEDIATYPE_NONE/*458*/
    ,
        /// <summary>
        /// An image node is selected.
        /// </summary>
        CM_MEDIATYPE_IMAGE/*459*/
    ,
        /// <summary>
        /// A video node is selected.
        /// </summary>
        CM_MEDIATYPE_VIDEO/*460*/
    ,
        /// <summary>
        /// An audio node is selected.
        /// </summary>
        CM_MEDIATYPE_AUDIO/*461*/
    ,
        /// <summary>
        /// A file node is selected.
        /// </summary>
        CM_MEDIATYPE_FILE/*462*/
    ,
        /// <summary>
        /// A plugin node is selected.
        /// </summary>
        CM_MEDIATYPE_PLUGIN/*463*/
    }
    /// <summary>
    /// Supported context menu media state bit flags.
    /// </summary>
    /*464*/
    public enum cef_context_menu_media_state_flags_t
    {
        CM_MEDIAFLAG_NONE = 0/*465*/
    ,
        CM_MEDIAFLAG_ERROR = 1 << 0/*466*/
    ,
        CM_MEDIAFLAG_PAUSED = 1 << 1/*467*/
    ,
        CM_MEDIAFLAG_MUTED = 1 << 2/*468*/
    ,
        CM_MEDIAFLAG_LOOP = 1 << 3/*469*/
    ,
        CM_MEDIAFLAG_CAN_SAVE = 1 << 4/*470*/
    ,
        CM_MEDIAFLAG_HAS_AUDIO = 1 << 5/*471*/
    ,
        CM_MEDIAFLAG_HAS_VIDEO = 1 << 6/*472*/
    ,
        CM_MEDIAFLAG_CONTROL_ROOT_ELEMENT = 1 << 7/*473*/
    ,
        CM_MEDIAFLAG_CAN_PRINT = 1 << 8/*474*/
    ,
        CM_MEDIAFLAG_CAN_ROTATE = 1 << 9/*475*/
    }
    /// <summary>
    /// Supported context menu edit state bit flags.
    /// </summary>
    /*476*/
    public enum cef_context_menu_edit_state_flags_t
    {
        CM_EDITFLAG_NONE = 0/*477*/
    ,
        CM_EDITFLAG_CAN_UNDO = 1 << 0/*478*/
    ,
        CM_EDITFLAG_CAN_REDO = 1 << 1/*479*/
    ,
        CM_EDITFLAG_CAN_CUT = 1 << 2/*480*/
    ,
        CM_EDITFLAG_CAN_COPY = 1 << 3/*481*/
    ,
        CM_EDITFLAG_CAN_PASTE = 1 << 4/*482*/
    ,
        CM_EDITFLAG_CAN_DELETE = 1 << 5/*483*/
    ,
        CM_EDITFLAG_CAN_SELECT_ALL = 1 << 6/*484*/
    ,
        CM_EDITFLAG_CAN_TRANSLATE = 1 << 7/*485*/
    }
    /// <summary>
    /// Key event types.
    /// </summary>
    /*486*/
    public enum cef_key_event_type_t
    {
        /// <summary>
        /// Notification that a key transitioned from "up" to "down".
        /// </summary>
        KEYEVENT_RAWKEYDOWN = 0/*487*/
    ,
        /// <summary>
        /// Notification that a key was pressed. This does not necessarily correspond
        /// to a character depending on the key and language. Use KEYEVENT_CHAR for
        /// character input.
        /// </summary>
        KEYEVENT_KEYDOWN/*488*/
    ,
        /// <summary>
        /// Notification that a key was released.
        /// </summary>
        KEYEVENT_KEYUP/*489*/
    }
    /// <summary>
    /// Focus sources.
    /// </summary>
    /*490*/
    public enum cef_focus_source_t
    {
        /// <summary>
        /// The source is explicit navigation via the API (LoadURL(), etc).
        /// </summary>
        FOCUS_SOURCE_NAVIGATION = 0/*491*/
    ,
        /// <summary>
        /// The source is a system-generated focus event.
        /// </summary>
        FOCUS_SOURCE_SYSTEM/*492*/
    }
    /// <summary>
    /// Navigation types.
    /// </summary>
    /*493*/
    public enum cef_navigation_type_t
    {
        NAVIGATION_LINK_CLICKED = 0/*494*/
    ,
        NAVIGATION_FORM_SUBMITTED/*495*/
    ,
        NAVIGATION_BACK_FORWARD/*496*/
    ,
        NAVIGATION_RELOAD/*497*/
    ,
        NAVIGATION_FORM_RESUBMITTED/*498*/
    ,
        NAVIGATION_OTHER/*499*/
    }
    /// <summary>
    /// Supported XML encoding types. The parser supports ASCII, ISO-8859-1, and
    /// UTF16 (LE and BE) by default. All other types must be translated to UTF8
    /// before being passed to the parser. If a BOM is detected and the correct
    /// decoder is available then that decoder will be used automatically.
    /// </summary>
    /*500*/
    public enum cef_xml_encoding_type_t
    {
        XML_ENCODING_NONE = 0/*501*/
    ,
        XML_ENCODING_UTF8/*502*/
    ,
        XML_ENCODING_UTF16LE/*503*/
    ,
        XML_ENCODING_UTF16BE/*504*/
    ,
        XML_ENCODING_ASCII/*505*/
    }
    /// <summary>
    /// XML node types.
    /// </summary>
    /*506*/
    public enum cef_xml_node_type_t
    {
        XML_NODE_UNSUPPORTED = 0/*507*/
    ,
        XML_NODE_PROCESSING_INSTRUCTION/*508*/
    ,
        XML_NODE_DOCUMENT_TYPE/*509*/
    ,
        XML_NODE_ELEMENT_START/*510*/
    ,
        XML_NODE_ELEMENT_END/*511*/
    ,
        XML_NODE_ATTRIBUTE/*512*/
    ,
        XML_NODE_TEXT/*513*/
    ,
        XML_NODE_CDATA/*514*/
    ,
        XML_NODE_ENTITY_REFERENCE/*515*/
    ,
        XML_NODE_WHITESPACE/*516*/
    ,
        XML_NODE_COMMENT/*517*/
    }
    /// <summary>
    /// DOM document types.
    /// </summary>
    /*518*/
    public enum cef_dom_document_type_t
    {
        DOM_DOCUMENT_TYPE_UNKNOWN = 0/*519*/
    ,
        DOM_DOCUMENT_TYPE_HTML/*520*/
    ,
        DOM_DOCUMENT_TYPE_XHTML/*521*/
    ,
        DOM_DOCUMENT_TYPE_PLUGIN/*522*/
    }
    /// <summary>
    /// DOM event category flags.
    /// </summary>
    /*523*/
    public enum cef_dom_event_category_t
    {
        DOM_EVENT_CATEGORY_UNKNOWN = 0/*524*/
    ,
        x0/*525*/
    ,
        DOM_EVENT_CATEGORY_UI = 0/*526*/
    ,
        x1/*527*/
    ,
        DOM_EVENT_CATEGORY_MOUSE = 0/*528*/
    ,
        x2/*529*/
    ,
        DOM_EVENT_CATEGORY_MUTATION = 0/*530*/
    ,
        x4/*531*/
    ,
        DOM_EVENT_CATEGORY_KEYBOARD = 0/*532*/
    ,
        x8/*533*/
    ,
        DOM_EVENT_CATEGORY_TEXT = 0/*534*/
    ,
        x10/*535*/
    ,
        DOM_EVENT_CATEGORY_COMPOSITION = 0/*536*/
    ,
        x20/*537*/
    ,
        DOM_EVENT_CATEGORY_DRAG = 0/*538*/
    ,
        x40/*539*/
    ,
        DOM_EVENT_CATEGORY_CLIPBOARD = 0/*540*/
    ,
        x80/*541*/
    ,
        DOM_EVENT_CATEGORY_MESSAGE = 0/*542*/
    ,
        x100/*543*/
    ,
        DOM_EVENT_CATEGORY_WHEEL = 0/*544*/
    ,
        x200/*545*/
    ,
        DOM_EVENT_CATEGORY_BEFORE_TEXT_INSERTED = 0/*546*/
    ,
        x400/*547*/
    ,
        DOM_EVENT_CATEGORY_OVERFLOW = 0/*548*/
    ,
        x800/*549*/
    ,
        DOM_EVENT_CATEGORY_PAGE_TRANSITION = 0/*550*/
    ,
        x1000/*551*/
    ,
        DOM_EVENT_CATEGORY_POPSTATE = 0/*552*/
    ,
        x2000/*553*/
    ,
        DOM_EVENT_CATEGORY_PROGRESS = 0/*554*/
    ,
        x4000/*555*/
    ,
        DOM_EVENT_CATEGORY_XMLHTTPREQUEST_PROGRESS = 0/*556*/
    ,
        x8000/*557*/
    }
    /// <summary>
    /// DOM event processing phases.
    /// </summary>
    /*558*/
    public enum cef_dom_event_phase_t
    {
        DOM_EVENT_PHASE_UNKNOWN = 0/*559*/
    ,
        DOM_EVENT_PHASE_CAPTURING/*560*/
    ,
        DOM_EVENT_PHASE_AT_TARGET/*561*/
    ,
        DOM_EVENT_PHASE_BUBBLING/*562*/
    }
    /// <summary>
    /// DOM node types.
    /// </summary>
    /*563*/
    public enum cef_dom_node_type_t
    {
        DOM_NODE_TYPE_UNSUPPORTED = 0/*564*/
    ,
        DOM_NODE_TYPE_ELEMENT/*565*/
    ,
        DOM_NODE_TYPE_ATTRIBUTE/*566*/
    ,
        DOM_NODE_TYPE_TEXT/*567*/
    ,
        DOM_NODE_TYPE_CDATA_SECTION/*568*/
    ,
        DOM_NODE_TYPE_PROCESSING_INSTRUCTIONS/*569*/
    ,
        DOM_NODE_TYPE_COMMENT/*570*/
    ,
        DOM_NODE_TYPE_DOCUMENT/*571*/
    ,
        DOM_NODE_TYPE_DOCUMENT_TYPE/*572*/
    ,
        DOM_NODE_TYPE_DOCUMENT_FRAGMENT/*573*/
    }
    /// <summary>
    /// Supported file dialog modes.
    /// </summary>
    /*574*/
    public enum cef_file_dialog_mode_t
    {
        /// <summary>
        /// Requires that the file exists before allowing the user to pick it.
        /// </summary>
        FILE_DIALOG_OPEN = 0/*575*/
    ,
        /// <summary>
        /// Like Open, but allows picking multiple files to open.
        /// </summary>
        FILE_DIALOG_OPEN_MULTIPLE/*576*/
    ,
        /// <summary>
        /// Like Open, but selects a folder to open.
        /// </summary>
        FILE_DIALOG_OPEN_FOLDER/*577*/
    ,
        /// <summary>
        /// Allows picking a nonexistent file, and prompts to overwrite if the file
        /// already exists.
        /// </summary>
        FILE_DIALOG_SAVE/*578*/
    ,
        /// <summary>
        /// General mask defining the bits used for the type values.
        /// </summary>
        FILE_DIALOG_TYPE_MASK = 0/*579*/
    ,
        xFF/*580*/
    ,
        /// <summary>
        /// Qualifiers.
        /// Any of the type values above can be augmented by one or more qualifiers.
        /// These qualifiers further define the dialog behavior.
        /// Prompt to overwrite if the user selects an existing file with the Save
        /// dialog.
        /// </summary>
        FILE_DIALOG_OVERWRITEPROMPT_FLAG = 0/*581*/
    ,
        x01000000/*582*/
    ,
        /// <summary>
        /// Do not display read-only files.
        /// </summary>
        FILE_DIALOG_HIDEREADONLY_FLAG = 0/*583*/
    ,
        x02000000/*584*/
    }
    /// <summary>
    /// Geoposition error codes.
    /// </summary>
    /*585*/
    public enum cef_geoposition_error_code_t
    {
        GEOPOSITON_ERROR_NONE = 0/*586*/
    ,
        GEOPOSITON_ERROR_PERMISSION_DENIED/*587*/
    ,
        GEOPOSITON_ERROR_POSITION_UNAVAILABLE/*588*/
    ,
        GEOPOSITON_ERROR_TIMEOUT/*589*/
    }
    /// <summary>
    /// Print job color mode values.
    /// </summary>
    /*590*/
    public enum cef_color_model_t
    {
        COLOR_MODEL_UNKNOWN/*591*/
    ,
        COLOR_MODEL_GRAY/*592*/
    ,
        COLOR_MODEL_COLOR/*593*/
    ,
        COLOR_MODEL_CMYK/*594*/
    ,
        COLOR_MODEL_CMY/*595*/
    ,
        COLOR_MODEL_KCMY/*596*/
    ,
        COLOR_MODEL_CMY_K/*597*/
    ,
        /// <summary>
        /// CMY_K represents CMY+K.
        /// </summary>
        COLOR_MODEL_BLACK/*598*/
    ,
        COLOR_MODEL_GRAYSCALE/*599*/
    ,
        COLOR_MODEL_RGB/*600*/
    ,
        COLOR_MODEL_RGB16/*601*/
    ,
        COLOR_MODEL_RGBA/*602*/
    ,
        COLOR_MODEL_COLORMODE_COLOR/*603*/
    ,
        /// <summary>
        /// Used in samsung printer ppds.
        /// </summary>
        COLOR_MODEL_COLORMODE_MONOCHROME/*604*/
    ,
        /// <summary>
        /// Used in samsung printer ppds.
        /// </summary>
        COLOR_MODEL_HP_COLOR_COLOR/*605*/
    ,
        /// <summary>
        /// Used in HP color printer ppds.
        /// </summary>
        COLOR_MODEL_HP_COLOR_BLACK/*606*/
    ,
        /// <summary>
        /// Used in HP color printer ppds.
        /// </summary>
        COLOR_MODEL_PRINTOUTMODE_NORMAL/*607*/
    ,
        /// <summary>
        /// Used in foomatic ppds.
        /// </summary>
        COLOR_MODEL_PRINTOUTMODE_NORMAL_GRAY/*608*/
    ,
        /// <summary>
        /// Used in foomatic ppds.
        /// </summary>
        COLOR_MODEL_PROCESSCOLORMODEL_CMYK/*609*/
    ,
        /// <summary>
        /// Used in canon printer ppds.
        /// </summary>
        COLOR_MODEL_PROCESSCOLORMODEL_GREYSCALE/*610*/
    ,
        /// <summary>
        /// Used in canon printer ppds.
        /// </summary>
        COLOR_MODEL_PROCESSCOLORMODEL_RGB/*611*/
    }
    /// <summary>
    /// Print job duplex mode values.
    /// </summary>
    /*612*/
    public enum cef_duplex_mode_t
    {
        DUPLEX_MODE_UNKNOWN = -1/*613*/
    ,
        DUPLEX_MODE_SIMPLEX/*614*/
    ,
        DUPLEX_MODE_LONG_EDGE/*615*/
    ,
        DUPLEX_MODE_SHORT_EDGE/*616*/
    }
    /// <summary>
    /// Cursor type values.
    /// </summary>
    /*617*/
    public enum cef_cursor_type_t
    {
        CT_POINTER = 0/*618*/
    ,
        CT_CROSS/*619*/
    ,
        CT_HAND/*620*/
    ,
        CT_IBEAM/*621*/
    ,
        CT_WAIT/*622*/
    ,
        CT_HELP/*623*/
    ,
        CT_EASTRESIZE/*624*/
    ,
        CT_NORTHRESIZE/*625*/
    ,
        CT_NORTHEASTRESIZE/*626*/
    ,
        CT_NORTHWESTRESIZE/*627*/
    ,
        CT_SOUTHRESIZE/*628*/
    ,
        CT_SOUTHEASTRESIZE/*629*/
    ,
        CT_SOUTHWESTRESIZE/*630*/
    ,
        CT_WESTRESIZE/*631*/
    ,
        CT_NORTHSOUTHRESIZE/*632*/
    ,
        CT_EASTWESTRESIZE/*633*/
    ,
        CT_NORTHEASTSOUTHWESTRESIZE/*634*/
    ,
        CT_NORTHWESTSOUTHEASTRESIZE/*635*/
    ,
        CT_COLUMNRESIZE/*636*/
    ,
        CT_ROWRESIZE/*637*/
    ,
        CT_MIDDLEPANNING/*638*/
    ,
        CT_EASTPANNING/*639*/
    ,
        CT_NORTHPANNING/*640*/
    ,
        CT_NORTHEASTPANNING/*641*/
    ,
        CT_NORTHWESTPANNING/*642*/
    ,
        CT_SOUTHPANNING/*643*/
    ,
        CT_SOUTHEASTPANNING/*644*/
    ,
        CT_SOUTHWESTPANNING/*645*/
    ,
        CT_WESTPANNING/*646*/
    ,
        CT_MOVE/*647*/
    ,
        CT_VERTICALTEXT/*648*/
    ,
        CT_CELL/*649*/
    ,
        CT_CONTEXTMENU/*650*/
    ,
        CT_ALIAS/*651*/
    ,
        CT_PROGRESS/*652*/
    ,
        CT_NODROP/*653*/
    ,
        CT_COPY/*654*/
    ,
        CT_NONE/*655*/
    ,
        CT_NOTALLOWED/*656*/
    ,
        CT_ZOOMIN/*657*/
    ,
        CT_ZOOMOUT/*658*/
    ,
        CT_GRAB/*659*/
    ,
        CT_GRABBING/*660*/
    ,
        CT_CUSTOM/*661*/
    }
    /// <summary>
    /// URI unescape rules passed to CefURIDecode().
    /// </summary>
    /*662*/
    public enum cef_uri_unescape_rule_t
    {
        /// <summary>
        /// Don't unescape anything at all.
        /// </summary>
        UU_NONE = 0/*663*/
    ,
        /// <summary>
        /// Don't unescape anything special, but all normal unescaping will happen.
        /// This is a placeholder and can't be combined with other flags (since it's
        /// just the absence of them). All other unescape rules imply "normal" in
        /// addition to their special meaning. Things like escaped letters, digits,
        /// and most symbols will get unescaped with this mode.
        /// </summary>
        UU_NORMAL = 1 << 0/*664*/
    ,
        /// <summary>
        /// Convert %20 to spaces. In some places where we're showing URLs, we may
        /// want this. In places where the URL may be copied and pasted out, then
        /// you wouldn't want this since it might not be interpreted in one piece
        /// by other applications.
        /// </summary>
        UU_SPACES = 1 << 1/*665*/
    ,
        /// <summary>
        /// Unescapes '/' and '\\'. If these characters were unescaped, the resulting
        /// URL won't be the same as the source one. Moreover, they are dangerous to
        /// unescape in strings that will be used as file paths or names. This value
        /// should only be used when slashes don't have special meaning, like data
        /// URLs.
        /// </summary>
        UU_PATH_SEPARATORS = 1 << 2/*666*/
    ,
        /// <summary>
        /// Unescapes various characters that will change the meaning of URLs,
        /// including '%', '+', '&', '#'. Does not unescape path separators.
        /// If these characters were unescaped, the resulting URL won't be the same
        /// as the source one. This flag is used when generating final output like
        /// filenames for URLs where we won't be interpreting as a URL and want to do
        /// as much unescaping as possible.
        /// </summary>
        UU_URL_SPECIAL_CHARS_EXCEPT_PATH_SEPARATORS = 1 << 3/*667*/
    ,
        /// <summary>
        /// Unescapes characters that can be used in spoofing attempts (such as LOCK)
        /// and control characters (such as BiDi control characters and %01).  This
        /// INCLUDES NULLs.  This is used for rare cases such as data: URL decoding
        /// where the result is binary data.
        ///
        /// DO NOT use UU_SPOOFING_AND_CONTROL_CHARS if the URL is going to be
        /// displayed in the UI for security reasons.
        /// </summary>
        UU_SPOOFING_AND_CONTROL_CHARS = 1 << 4/*668*/
    ,
        /// <summary>
        /// URL queries use "+" for space. This flag controls that replacement.
        /// </summary>
        UU_REPLACE_PLUS_WITH_SPACE = 1 << 5/*669*/
    }
    /// <summary>
    /// Options that can be passed to CefParseJSON.
    /// </summary>
    /*670*/
    public enum cef_json_parser_options_t
    {
        /// <summary>
        /// Parses the input strictly according to RFC 4627. See comments in Chromium's
        /// base/json/json_reader.h file for known limitations/deviations from the RFC.
        /// </summary>
        JSON_PARSER_RFC = 0/*671*/
    ,
        /// <summary>
        /// Allows commas to exist after the last element in structures.
        /// </summary>
        JSON_PARSER_ALLOW_TRAILING_COMMAS = 1 << 0/*672*/
    }
    /// <summary>
    /// Error codes that can be returned from CefParseJSONAndReturnError.
    /// </summary>
    /*673*/
    public enum cef_json_parser_error_t
    {
        JSON_NO_ERROR = 0/*674*/
    ,
        JSON_INVALID_ESCAPE/*675*/
    ,
        JSON_SYNTAX_ERROR/*676*/
    ,
        JSON_UNEXPECTED_TOKEN/*677*/
    ,
        JSON_TRAILING_COMMA/*678*/
    ,
        JSON_TOO_MUCH_NESTING/*679*/
    ,
        JSON_UNEXPECTED_DATA_AFTER_ROOT/*680*/
    ,
        JSON_UNSUPPORTED_ENCODING/*681*/
    ,
        JSON_UNQUOTED_DICTIONARY_KEY/*682*/
    }
    /// <summary>
    /// Options that can be passed to CefWriteJSON.
    /// </summary>
    /*683*/
    public enum cef_json_writer_options_t
    {
        /// <summary>
        /// Default behavior.
        /// </summary>
        JSON_WRITER_DEFAULT = 0/*684*/
    ,
        /// <summary>
        /// This option instructs the writer that if a Binary value is encountered,
        /// the value (and key if within a dictionary) will be omitted from the
        /// output, and success will be returned. Otherwise, if a binary value is
        /// encountered, failure will be returned.
        /// </summary>
        JSON_WRITER_OMIT_BINARY_VALUES = 1 << 0/*685*/
    ,
        /// <summary>
        /// This option instructs the writer to write doubles that have no fractional
        /// part as a normal integer (i.e., without using exponential notation
        /// or appending a '.0') as long as the value is within the range of a
        /// 64-bit int.
        /// </summary>
        JSON_WRITER_OMIT_DOUBLE_TYPE_PRESERVATION = 1 << 1/*686*/
    ,
        /// <summary>
        /// Return a slightly nicer formatted json string (pads with whitespace to
        /// help with readability).
        /// </summary>
        JSON_WRITER_PRETTY_PRINT = 1 << 2/*687*/
    }
    /// <summary>
    /// Margin type for PDF printing.
    /// </summary>
    /*688*/
    public enum cef_pdf_print_margin_type_t
    {
        /// <summary>
        /// Default margins.
        /// </summary>
        PDF_PRINT_MARGIN_DEFAULT/*689*/
    ,
        /// <summary>
        /// No margins.
        /// </summary>
        PDF_PRINT_MARGIN_NONE/*690*/
    ,
        /// <summary>
        /// Minimum margins.
        /// </summary>
        PDF_PRINT_MARGIN_MINIMUM/*691*/
    ,
        /// <summary>
        /// Custom margins using the |margin_*| values from cef_pdf_print_settings_t.
        /// </summary>
        PDF_PRINT_MARGIN_CUSTOM/*692*/
    }
    /// <summary>
    /// Supported UI scale factors for the platform. SCALE_FACTOR_NONE is used for
    /// density independent resources such as string, html/js files or an image that
    /// can be used for any scale factors (such as wallpapers).
    /// </summary>
    /*693*/
    public enum cef_scale_factor_t
    {
        SCALE_FACTOR_NONE = 0/*694*/
    ,
        SCALE_FACTOR_100P/*695*/
    ,
        SCALE_FACTOR_125P/*696*/
    ,
        SCALE_FACTOR_133P/*697*/
    ,
        SCALE_FACTOR_140P/*698*/
    ,
        SCALE_FACTOR_150P/*699*/
    ,
        SCALE_FACTOR_180P/*700*/
    ,
        SCALE_FACTOR_200P/*701*/
    ,
        SCALE_FACTOR_250P/*702*/
    ,
        SCALE_FACTOR_300P/*703*/
    }
    /// <summary>
    /// Plugin policies supported by CefRequestContextHandler::OnBeforePluginLoad.
    /// </summary>
    /*704*/
    public enum cef_plugin_policy_t
    {
        /// <summary>
        /// Allow the content.
        /// </summary>
        PLUGIN_POLICY_ALLOW/*705*/
    ,
        /// <summary>
        /// Allow important content and block unimportant content based on heuristics.
        /// The user can manually load blocked content.
        /// </summary>
        PLUGIN_POLICY_DETECT_IMPORTANT/*706*/
    ,
        /// <summary>
        /// Block the content. The user can manually load blocked content.
        /// </summary>
        PLUGIN_POLICY_BLOCK/*707*/
    ,
        /// <summary>
        /// Disable the content. The user cannot load disabled content.
        /// </summary>
        PLUGIN_POLICY_DISABLE/*708*/
    }
    /// <summary>
    /// Policy for how the Referrer HTTP header value will be sent during navigation.
    /// If the `--no-referrers` command-line flag is specified then the policy value
    /// will be ignored and the Referrer value will never be sent.
    /// </summary>
    /*709*/
    public enum cef_referrer_policy_t
    {
        /// <summary>
        /// Always send the complete Referrer value.
        /// </summary>
        REFERRER_POLICY_ALWAYS/*710*/
    ,
        /// <summary>
        /// Use the default policy. This is REFERRER_POLICY_ORIGIN_WHEN_CROSS_ORIGIN
        /// when the `--reduced-referrer-granularity` command-line flag is specified
        /// and REFERRER_POLICY_NO_REFERRER_WHEN_DOWNGRADE otherwise.
        ///
        /// </summary>
        REFERRER_POLICY_DEFAULT/*711*/
    ,
        /// <summary>
        /// When navigating from HTTPS to HTTP do not send the Referrer value.
        /// Otherwise, send the complete Referrer value.
        /// </summary>
        REFERRER_POLICY_NO_REFERRER_WHEN_DOWNGRADE/*712*/
    ,
        /// <summary>
        /// Never send the Referrer value.
        /// </summary>
        REFERRER_POLICY_NEVER/*713*/
    ,
        /// <summary>
        /// Only send the origin component of the Referrer value.
        /// </summary>
        REFERRER_POLICY_ORIGIN/*714*/
    ,
        /// <summary>
        /// When navigating cross-origin only send the origin component of the Referrer
        /// value. Otherwise, send the complete Referrer value.
        /// </summary>
        REFERRER_POLICY_ORIGIN_WHEN_CROSS_ORIGIN/*715*/
    }
    /// <summary>
    /// Return values for CefResponseFilter::Filter().
    /// </summary>
    /*716*/
    public enum cef_response_filter_status_t
    {
        /// <summary>
        /// Some or all of the pre-filter data was read successfully but more data is
        /// needed in order to continue filtering (filtered output is pending).
        /// </summary>
        RESPONSE_FILTER_NEED_MORE_DATA/*717*/
    ,
        /// <summary>
        /// Some or all of the pre-filter data was read successfully and all available
        /// filtered output has been written.
        /// </summary>
        RESPONSE_FILTER_DONE/*718*/
    }
    /// <summary>
    /// Describes how to interpret the components of a pixel.
    /// </summary>
    /*719*/
    public enum cef_color_type_t
    {
        /// <summary>
        /// RGBA with 8 bits per pixel (32bits total).
        /// </summary>
        CEF_COLOR_TYPE_RGBA_8888/*720*/
    ,
        /// <summary>
        /// BGRA with 8 bits per pixel (32bits total).
        /// </summary>
        CEF_COLOR_TYPE_BGRA_8888/*721*/
    }
    /// <summary>
    /// Describes how to interpret the alpha component of a pixel.
    /// </summary>
    /*722*/
    public enum cef_alpha_type_t
    {
        /// <summary>
        /// No transparency. The alpha component is ignored.
        /// </summary>
        CEF_ALPHA_TYPE_OPAQUE/*723*/
    ,
        /// <summary>
        /// Transparency with pre-multiplied alpha component.
        /// </summary>
        CEF_ALPHA_TYPE_PREMULTIPLIED/*724*/
    ,
        /// <summary>
        /// Transparency with post-multiplied alpha component.
        /// </summary>
        CEF_ALPHA_TYPE_POSTMULTIPLIED/*725*/
    }
    /// <summary>
    /// Text style types. Should be kepy in sync with gfx::TextStyle.
    /// </summary>
    /*726*/
    public enum cef_text_style_t
    {
        CEF_TEXT_STYLE_BOLD/*727*/
    ,
        CEF_TEXT_STYLE_ITALIC/*728*/
    ,
        CEF_TEXT_STYLE_STRIKE/*729*/
    ,
        CEF_TEXT_STYLE_DIAGONAL_STRIKE/*730*/
    ,
        CEF_TEXT_STYLE_UNDERLINE/*731*/
    }
    /// <summary>
    /// Specifies where along the main axis the CefBoxLayout child views should be
    /// laid out.
    /// </summary>
    /*732*/
    public enum cef_main_axis_alignment_t
    {
        /// <summary>
        /// Child views will be left-aligned.
        /// </summary>
        CEF_MAIN_AXIS_ALIGNMENT_START/*733*/
    ,
        /// <summary>
        /// Child views will be center-aligned.
        /// </summary>
        CEF_MAIN_AXIS_ALIGNMENT_CENTER/*734*/
    ,
        /// <summary>
        /// Child views will be right-aligned.
        /// </summary>
        CEF_MAIN_AXIS_ALIGNMENT_END/*735*/
    }
    /// <summary>
    /// Specifies where along the cross axis the CefBoxLayout child views should be
    /// laid out.
    /// </summary>
    /*736*/
    public enum cef_cross_axis_alignment_t
    {
        /// <summary>
        /// Child views will be stretched to fit.
        /// </summary>
        CEF_CROSS_AXIS_ALIGNMENT_STRETCH/*737*/
    ,
        /// <summary>
        /// Child views will be left-aligned.
        /// </summary>
        CEF_CROSS_AXIS_ALIGNMENT_START/*738*/
    ,
        /// <summary>
        /// Child views will be center-aligned.
        /// </summary>
        CEF_CROSS_AXIS_ALIGNMENT_CENTER/*739*/
    ,
        /// <summary>
        /// Child views will be right-aligned.
        /// </summary>
        CEF_CROSS_AXIS_ALIGNMENT_END/*740*/
    }
    /// <summary>
    /// Specifies the button display state.
    /// </summary>
    /*741*/
    public enum cef_button_state_t
    {
        CEF_BUTTON_STATE_NORMAL/*742*/
    ,
        CEF_BUTTON_STATE_HOVERED/*743*/
    ,
        CEF_BUTTON_STATE_PRESSED/*744*/
    ,
        CEF_BUTTON_STATE_DISABLED/*745*/
    }
    /// <summary>
    /// Specifies the horizontal text alignment mode.
    /// </summary>
    /*746*/
    public enum cef_horizontal_alignment_t
    {
        /// <summary>
        /// Align the text's left edge with that of its display area.
        /// </summary>
        CEF_HORIZONTAL_ALIGNMENT_LEFT/*747*/
    ,
        /// <summary>
        /// Align the text's center with that of its display area.
        /// </summary>
        CEF_HORIZONTAL_ALIGNMENT_CENTER/*748*/
    ,
        /// <summary>
        /// Align the text's right edge with that of its display area.
        /// </summary>
        CEF_HORIZONTAL_ALIGNMENT_RIGHT/*749*/
    }
    /// <summary>
    /// Specifies how a menu will be anchored for non-RTL languages. The opposite
    /// position will be used for RTL languages.
    /// </summary>
    /*750*/
    public enum cef_menu_anchor_position_t
    {
        CEF_MENU_ANCHOR_TOPLEFT/*751*/
    ,
        CEF_MENU_ANCHOR_TOPRIGHT/*752*/
    ,
        CEF_MENU_ANCHOR_BOTTOMCENTER/*753*/
    }
    /// <summary>
    /// Supported color types for menu items.
    /// </summary>
    /*754*/
    public enum cef_menu_color_type_t
    {
        CEF_MENU_COLOR_TEXT/*755*/
    ,
        CEF_MENU_COLOR_TEXT_HOVERED/*756*/
    ,
        CEF_MENU_COLOR_TEXT_ACCELERATOR/*757*/
    ,
        CEF_MENU_COLOR_TEXT_ACCELERATOR_HOVERED/*758*/
    ,
        CEF_MENU_COLOR_BACKGROUND/*759*/
    ,
        CEF_MENU_COLOR_BACKGROUND_HOVERED/*760*/
    ,
        CEF_MENU_COLOR_COUNT/*761*/
    }
    /// <summary>
    /// Supported SSL version values. See net/ssl/ssl_connection_status_flags.h
    /// for more information.
    /// </summary>
    /*762*/
    public enum cef_ssl_version_t
    {
        SSL_CONNECTION_VERSION_UNKNOWN = 0/*763*/
    ,
        /// <summary>
        /// Unknown SSL version.
        /// </summary>
        SSL_CONNECTION_VERSION_SSL2 = 1/*764*/
    ,
        SSL_CONNECTION_VERSION_SSL3 = 2/*765*/
    ,
        SSL_CONNECTION_VERSION_TLS1 = 3/*766*/
    ,
        SSL_CONNECTION_VERSION_TLS1_1 = 4/*767*/
    ,
        SSL_CONNECTION_VERSION_TLS1_2 = 5/*768*/
    ,
        /// <summary>
        /// Reserve 6 for TLS 1.3.
        /// </summary>
        SSL_CONNECTION_VERSION_QUIC = 7/*769*/
    }
    /// <summary>
    /// Supported SSL content status flags. See content/public/common/ssl_status.h
    /// for more information.
    /// </summary>
    /*770*/
    public enum cef_ssl_content_status_t
    {
        SSL_CONTENT_NORMAL_CONTENT = 0/*771*/
    ,
        SSL_CONTENT_DISPLAYED_INSECURE_CONTENT = 1 << 0/*772*/
    ,
        SSL_CONTENT_RAN_INSECURE_CONTENT = 1 << 1/*773*/
    }
    /// <summary>
    /// Error codes for CDM registration. See cef_web_plugin.h for details.
    /// </summary>
    /*774*/
    public enum cef_cdm_registration_error_t
    {
        /// <summary>
        /// No error. Registration completed successfully.
        /// </summary>
        CEF_CDM_REGISTRATION_ERROR_NONE/*775*/
    ,
        /// <summary>
        /// Required files or manifest contents are missing.
        /// </summary>
        CEF_CDM_REGISTRATION_ERROR_INCORRECT_CONTENTS/*776*/
    ,
        /// <summary>
        /// The CDM is incompatible with the current Chromium version.
        /// </summary>
        CEF_CDM_REGISTRATION_ERROR_INCOMPATIBLE/*777*/
    ,
        /// <summary>
        /// CDM registration is not supported at this time.
        /// </summary>
        CEF_CDM_REGISTRATION_ERROR_NOT_SUPPORTED/*778*/
    }

    // [virtual] class CefApp
    /// <summary>
    /// Implement this interface to provide handler implementations. Methods will be
    /// called by the process and/or thread indicated.
    /// /*cef(source=client,no_debugct_check)*/
    /// </summary>
    /*787*/
    public struct CefApp
    {
        /*788*/
        const int _typeNAME = 1;
        /*789*/
        const int CefApp_Release_0 = (_typeNAME << 16) | 0;
        /*790*/
        internal readonly IntPtr nativePtr;
        /*791*/
        internal CefApp(IntPtr nativePtr)
        {
            /*792*/
            this.nativePtr = nativePtr;
            /*793*/
        }
        /*794*/
        public void Release()
        {
            /*795*/
            JsValue ret;
            /*796*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefApp_Release_0, out ret);
            /*797*/
        }
        /*798*/
    }


    // [virtual] class CefBrowser
    /// <summary>
    /// Class used to represent a browser window. When used in the browser process
    /// the methods of this class may be called on any thread unless otherwise
    /// indicated in the comments. When used in the render process the methods of
    /// this class may only be called on the main thread.
    /// /*(source=library)*/
    /// </summary>
    /*912*/
    public struct CefBrowser
    {
        /*913*/
        const int _typeNAME = 2;
        /*914*/
        const int CefBrowser_Release_0 = (_typeNAME << 16) | 0;
        /*915*/
        const int CefBrowser_GetHost_1 = (_typeNAME << 16) | 1;
        /*916*/
        const int CefBrowser_CanGoBack_2 = (_typeNAME << 16) | 2;
        /*917*/
        const int CefBrowser_GoBack_3 = (_typeNAME << 16) | 3;
        /*918*/
        const int CefBrowser_CanGoForward_4 = (_typeNAME << 16) | 4;
        /*919*/
        const int CefBrowser_GoForward_5 = (_typeNAME << 16) | 5;
        /*920*/
        const int CefBrowser_IsLoading_6 = (_typeNAME << 16) | 6;
        /*921*/
        const int CefBrowser_Reload_7 = (_typeNAME << 16) | 7;
        /*922*/
        const int CefBrowser_ReloadIgnoreCache_8 = (_typeNAME << 16) | 8;
        /*923*/
        const int CefBrowser_StopLoad_9 = (_typeNAME << 16) | 9;
        /*924*/
        const int CefBrowser_GetIdentifier_10 = (_typeNAME << 16) | 10;
        /*925*/
        const int CefBrowser_IsSame_11 = (_typeNAME << 16) | 11;
        /*926*/
        const int CefBrowser_IsPopup_12 = (_typeNAME << 16) | 12;
        /*927*/
        const int CefBrowser_HasDocument_13 = (_typeNAME << 16) | 13;
        /*928*/
        const int CefBrowser_GetMainFrame_14 = (_typeNAME << 16) | 14;
        /*929*/
        const int CefBrowser_GetFocusedFrame_15 = (_typeNAME << 16) | 15;
        /*930*/
        const int CefBrowser_GetFrame_16 = (_typeNAME << 16) | 16;
        /*931*/
        const int CefBrowser_GetFrame_17 = (_typeNAME << 16) | 17;
        /*932*/
        const int CefBrowser_GetFrameCount_18 = (_typeNAME << 16) | 18;
        /*933*/
        const int CefBrowser_GetFrameIdentifiers_19 = (_typeNAME << 16) | 19;
        /*934*/
        const int CefBrowser_GetFrameNames_20 = (_typeNAME << 16) | 20;
        /*935*/
        const int CefBrowser_SendProcessMessage_21 = (_typeNAME << 16) | 21;
        /*936*/
        internal readonly IntPtr nativePtr;
        /*937*/
        internal CefBrowser(IntPtr nativePtr)
        {
            /*938*/
            this.nativePtr = nativePtr;
            /*939*/
        }
        /*940*/
        public void Release()
        {
            /*941*/
            JsValue ret;
            /*942*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_Release_0, out ret);
            /*943*/
        }

        // gen! CefRefPtr<CefBrowserHost> GetHost()
        /// <summary>
        /// CefBrowser methods.
        /// </summary>
        /*944*/

        public CefBrowserHost GetHost()/*945*/
        {
            JsValue ret;
            /*946*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetHost_1, out ret);
            /*947*/
            var ret_result = new CefBrowserHost(ret.Ptr);
            /*948*/
            return ret_result;
            /*949*/
        }

        // gen! bool CanGoBack()
        /// <summary>
        /// Returns true if the browser can navigate backwards.
        /// /*cef()*/
        /// </summary>
        /*950*/

        public bool CanGoBack()/*951*/
        {
            JsValue ret;
            /*952*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_CanGoBack_2, out ret);
            /*953*/
            var ret_result = ret.I32 != 0;
            /*954*/
            return ret_result;
            /*955*/
        }

        // gen! void GoBack()
        /// <summary>
        /// Navigate backwards.
        /// /*cef()*/
        /// </summary>
        /*956*/

        public void GoBack()/*957*/
        {
            JsValue ret;
            /*958*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GoBack_3, out ret);
            /*959*/

            /*960*/
        }

        // gen! bool CanGoForward()
        /// <summary>
        /// Returns true if the browser can navigate forwards.
        /// /*cef()*/
        /// </summary>
        /*961*/

        public bool CanGoForward()/*962*/
        {
            JsValue ret;
            /*963*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_CanGoForward_4, out ret);
            /*964*/
            var ret_result = ret.I32 != 0;
            /*965*/
            return ret_result;
            /*966*/
        }

        // gen! void GoForward()
        /// <summary>
        /// Navigate forwards.
        /// /*cef()*/
        /// </summary>
        /*967*/

        public void GoForward()/*968*/
        {
            JsValue ret;
            /*969*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GoForward_5, out ret);
            /*970*/

            /*971*/
        }

        // gen! bool IsLoading()
        /// <summary>
        /// Returns true if the browser is currently loading.
        /// /*cef()*/
        /// </summary>
        /*972*/

        public bool IsLoading()/*973*/
        {
            JsValue ret;
            /*974*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_IsLoading_6, out ret);
            /*975*/
            var ret_result = ret.I32 != 0;
            /*976*/
            return ret_result;
            /*977*/
        }

        // gen! void Reload()
        /// <summary>
        /// Reload the current page.
        /// /*cef()*/
        /// </summary>
        /*978*/

        public void Reload()/*979*/
        {
            JsValue ret;
            /*980*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_Reload_7, out ret);
            /*981*/

            /*982*/
        }

        // gen! void ReloadIgnoreCache()
        /// <summary>
        /// Reload the current page ignoring any cached data.
        /// /*cef()*/
        /// </summary>
        /*983*/

        public void ReloadIgnoreCache()/*984*/
        {
            JsValue ret;
            /*985*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_ReloadIgnoreCache_8, out ret);
            /*986*/

            /*987*/
        }

        // gen! void StopLoad()
        /// <summary>
        /// Stop loading the page.
        /// /*cef()*/
        /// </summary>
        /*988*/

        public void StopLoad()/*989*/
        {
            JsValue ret;
            /*990*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_StopLoad_9, out ret);
            /*991*/

            /*992*/
        }

        // gen! int GetIdentifier()
        /// <summary>
        /// Returns the globally unique identifier for this browser.
        /// /*cef()*/
        /// </summary>
        /*993*/

        public int GetIdentifier()/*994*/
        {
            JsValue ret;
            /*995*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetIdentifier_10, out ret);
            /*996*/
            var ret_result = ret.I32;
            /*997*/
            return ret_result;
            /*998*/
        }

        // gen! bool IsSame(CefRefPtr<CefBrowser> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>
        /*999*/

        public bool IsSame(CefBrowser /*1000*/
        that
        )/*1001*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1002*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_IsSame_11, out ret, ref v1);
            /*1003*/
            var ret_result = ret.I32 != 0;
            /*1004*/
            return ret_result;
            /*1005*/
        }

        // gen! bool IsPopup()
        /// <summary>
        /// Returns true if the window is a popup window.
        /// /*cef()*/
        /// </summary>
        /*1006*/

        public bool IsPopup()/*1007*/
        {
            JsValue ret;
            /*1008*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_IsPopup_12, out ret);
            /*1009*/
            var ret_result = ret.I32 != 0;
            /*1010*/
            return ret_result;
            /*1011*/
        }

        // gen! bool HasDocument()
        /// <summary>
        /// Returns true if a document has been loaded in the browser.
        /// /*cef()*/
        /// </summary>
        /*1012*/

        public bool HasDocument()/*1013*/
        {
            JsValue ret;
            /*1014*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_HasDocument_13, out ret);
            /*1015*/
            var ret_result = ret.I32 != 0;
            /*1016*/
            return ret_result;
            /*1017*/
        }

        // gen! CefRefPtr<CefFrame> GetMainFrame()
        /// <summary>
        /// Returns the main (top-level) frame for the browser window.
        /// /*cef()*/
        /// </summary>
        /*1018*/

        public CefFrame GetMainFrame()/*1019*/
        {
            JsValue ret;
            /*1020*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetMainFrame_14, out ret);
            /*1021*/
            var ret_result = new CefFrame(ret.Ptr);
            /*1022*/
            return ret_result;
            /*1023*/
        }

        // gen! CefRefPtr<CefFrame> GetFocusedFrame()
        /// <summary>
        /// Returns the focused frame for the browser window.
        /// /*cef()*/
        /// </summary>
        /*1024*/

        public CefFrame GetFocusedFrame()/*1025*/
        {
            JsValue ret;
            /*1026*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetFocusedFrame_15, out ret);
            /*1027*/
            var ret_result = new CefFrame(ret.Ptr);
            /*1028*/
            return ret_result;
            /*1029*/
        }

        // gen! CefRefPtr<CefFrame> GetFrame(int64 identifier)
        /*1030*/

        public CefFrame GetFrame(long /*1031*/
        identifier
        )/*1032*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1033*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrame_16, out ret, ref v1);
            /*1034*/
            var ret_result = new CefFrame(ret.Ptr);
            /*1035*/
            return ret_result;
            /*1036*/
        }

        // gen! CefRefPtr<CefFrame> GetFrame(const CefString& name)
        /*1037*/

        public CefFrame GetFrame(string /*1038*/
        name
        )/*1039*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*1040*/
            ;
            /*1041*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrame_17, out ret, ref v1);
            /*1042*/
            var ret_result = new CefFrame(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1043*/
            ;
            /*1044*/
            return ret_result;
            /*1045*/
        }

        // gen! size_t GetFrameCount()
        /// <summary>
        /// Returns the number of frames that currently exist.
        /// /*cef()*/
        /// </summary>
        /*1046*/

        public uint GetFrameCount()/*1047*/
        {
            JsValue ret;
            /*1048*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetFrameCount_18, out ret);
            /*1049*/
            var ret_result = (uint)ret.I32;
            /*1050*/
            return ret_result;
            /*1051*/
        }

        // gen! void GetFrameIdentifiers(std::vector<int64>& identifiers)
        /// <summary>
        /// Returns the identifiers of all existing frames.
        /// /*cef(count_func=identifiers:GetFrameCount)*/
        /// </summary>
        /*1052*/

        public void GetFrameIdentifiers(List<long> /*1053*/
        identifiers
        )/*1054*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1055*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrameIdentifiers_19, out ret, ref v1);
            /*1056*/

            /*1057*/
        }

        // gen! void GetFrameNames(std::vector<CefString>& names)
        /// <summary>
        /// Returns the names of all existing frames.
        /// /*cef()*/
        /// </summary>
        /*1058*/

        public void GetFrameNames(List<string> /*1059*/
        names
        )/*1060*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1061*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrameNames_20, out ret, ref v1);
            /*1062*/

            /*1063*/
        }

        // gen! bool SendProcessMessage(CefProcessId target_process,CefRefPtr<CefProcessMessage> message)
        /// <summary>
        /// Send a message to the specified |target_process|. Returns true if the
        /// message was sent successfully.
        /// /*cef()*/
        /// </summary>
        /*1064*/

        public bool SendProcessMessage(cef_process_id_t /*1065*/
        target_process
        , CefProcessMessage /*1066*/
        message
        )/*1067*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*1068*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowser_SendProcessMessage_21, out ret, ref v1, ref v2);
            /*1069*/
            var ret_result = ret.I32 != 0;
            /*1070*/
            return ret_result;
            /*1071*/
        }
        /*1072*/
    }


    // [virtual] class CefNavigationEntryVisitor
    /// <summary>
    /// Callback interface for CefBrowserHost::GetNavigationEntries. The methods of
    /// this class will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    /*1081*/
    public struct CefNavigationEntryVisitor
    {
        /*1082*/
        const int _typeNAME = 3;
        /*1083*/
        const int CefNavigationEntryVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*1084*/
        internal readonly IntPtr nativePtr;
        /*1085*/
        internal CefNavigationEntryVisitor(IntPtr nativePtr)
        {
            /*1086*/
            this.nativePtr = nativePtr;
            /*1087*/
        }
        /*1088*/
        public void Release()
        {
            /*1089*/
            JsValue ret;
            /*1090*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntryVisitor_Release_0, out ret);
            /*1091*/
        }
        /*1092*/
    }


    // [virtual] class CefBrowserHost
    /// <summary>
    /// Class used to represent the browser process aspects of a browser window. The
    /// methods of this class can only be called in the browser process. They may be
    /// called on any thread in that process unless otherwise indicated in the
    /// comments.
    /// /*(source=library)*/
    /// </summary>
    /*1361*/
    public struct CefBrowserHost
    {
        /*1362*/
        const int _typeNAME = 4;
        /*1363*/
        const int CefBrowserHost_Release_0 = (_typeNAME << 16) | 0;
        /*1364*/
        const int CefBrowserHost_GetBrowser_1 = (_typeNAME << 16) | 1;
        /*1365*/
        const int CefBrowserHost_CloseBrowser_2 = (_typeNAME << 16) | 2;
        /*1366*/
        const int CefBrowserHost_TryCloseBrowser_3 = (_typeNAME << 16) | 3;
        /*1367*/
        const int CefBrowserHost_SetFocus_4 = (_typeNAME << 16) | 4;
        /*1368*/
        const int CefBrowserHost_GetWindowHandle_5 = (_typeNAME << 16) | 5;
        /*1369*/
        const int CefBrowserHost_GetOpenerWindowHandle_6 = (_typeNAME << 16) | 6;
        /*1370*/
        const int CefBrowserHost_HasView_7 = (_typeNAME << 16) | 7;
        /*1371*/
        const int CefBrowserHost_GetClient_8 = (_typeNAME << 16) | 8;
        /*1372*/
        const int CefBrowserHost_GetRequestContext_9 = (_typeNAME << 16) | 9;
        /*1373*/
        const int CefBrowserHost_GetZoomLevel_10 = (_typeNAME << 16) | 10;
        /*1374*/
        const int CefBrowserHost_SetZoomLevel_11 = (_typeNAME << 16) | 11;
        /*1375*/
        const int CefBrowserHost_RunFileDialog_12 = (_typeNAME << 16) | 12;
        /*1376*/
        const int CefBrowserHost_StartDownload_13 = (_typeNAME << 16) | 13;
        /*1377*/
        const int CefBrowserHost_DownloadImage_14 = (_typeNAME << 16) | 14;
        /*1378*/
        const int CefBrowserHost_Print_15 = (_typeNAME << 16) | 15;
        /*1379*/
        const int CefBrowserHost_PrintToPDF_16 = (_typeNAME << 16) | 16;
        /*1380*/
        const int CefBrowserHost_Find_17 = (_typeNAME << 16) | 17;
        /*1381*/
        const int CefBrowserHost_StopFinding_18 = (_typeNAME << 16) | 18;
        /*1382*/
        const int CefBrowserHost_ShowDevTools_19 = (_typeNAME << 16) | 19;
        /*1383*/
        const int CefBrowserHost_CloseDevTools_20 = (_typeNAME << 16) | 20;
        /*1384*/
        const int CefBrowserHost_HasDevTools_21 = (_typeNAME << 16) | 21;
        /*1385*/
        const int CefBrowserHost_GetNavigationEntries_22 = (_typeNAME << 16) | 22;
        /*1386*/
        const int CefBrowserHost_SetMouseCursorChangeDisabled_23 = (_typeNAME << 16) | 23;
        /*1387*/
        const int CefBrowserHost_IsMouseCursorChangeDisabled_24 = (_typeNAME << 16) | 24;
        /*1388*/
        const int CefBrowserHost_ReplaceMisspelling_25 = (_typeNAME << 16) | 25;
        /*1389*/
        const int CefBrowserHost_AddWordToDictionary_26 = (_typeNAME << 16) | 26;
        /*1390*/
        const int CefBrowserHost_IsWindowRenderingDisabled_27 = (_typeNAME << 16) | 27;
        /*1391*/
        const int CefBrowserHost_WasResized_28 = (_typeNAME << 16) | 28;
        /*1392*/
        const int CefBrowserHost_WasHidden_29 = (_typeNAME << 16) | 29;
        /*1393*/
        const int CefBrowserHost_NotifyScreenInfoChanged_30 = (_typeNAME << 16) | 30;
        /*1394*/
        const int CefBrowserHost_Invalidate_31 = (_typeNAME << 16) | 31;
        /*1395*/
        const int CefBrowserHost_SendKeyEvent_32 = (_typeNAME << 16) | 32;
        /*1396*/
        const int CefBrowserHost_SendMouseClickEvent_33 = (_typeNAME << 16) | 33;
        /*1397*/
        const int CefBrowserHost_SendMouseMoveEvent_34 = (_typeNAME << 16) | 34;
        /*1398*/
        const int CefBrowserHost_SendMouseWheelEvent_35 = (_typeNAME << 16) | 35;
        /*1399*/
        const int CefBrowserHost_SendFocusEvent_36 = (_typeNAME << 16) | 36;
        /*1400*/
        const int CefBrowserHost_SendCaptureLostEvent_37 = (_typeNAME << 16) | 37;
        /*1401*/
        const int CefBrowserHost_NotifyMoveOrResizeStarted_38 = (_typeNAME << 16) | 38;
        /*1402*/
        const int CefBrowserHost_GetWindowlessFrameRate_39 = (_typeNAME << 16) | 39;
        /*1403*/
        const int CefBrowserHost_SetWindowlessFrameRate_40 = (_typeNAME << 16) | 40;
        /*1404*/
        const int CefBrowserHost_ImeSetComposition_41 = (_typeNAME << 16) | 41;
        /*1405*/
        const int CefBrowserHost_ImeCommitText_42 = (_typeNAME << 16) | 42;
        /*1406*/
        const int CefBrowserHost_ImeFinishComposingText_43 = (_typeNAME << 16) | 43;
        /*1407*/
        const int CefBrowserHost_ImeCancelComposition_44 = (_typeNAME << 16) | 44;
        /*1408*/
        const int CefBrowserHost_DragTargetDragEnter_45 = (_typeNAME << 16) | 45;
        /*1409*/
        const int CefBrowserHost_DragTargetDragOver_46 = (_typeNAME << 16) | 46;
        /*1410*/
        const int CefBrowserHost_DragTargetDragLeave_47 = (_typeNAME << 16) | 47;
        /*1411*/
        const int CefBrowserHost_DragTargetDrop_48 = (_typeNAME << 16) | 48;
        /*1412*/
        const int CefBrowserHost_DragSourceEndedAt_49 = (_typeNAME << 16) | 49;
        /*1413*/
        const int CefBrowserHost_DragSourceSystemDragEnded_50 = (_typeNAME << 16) | 50;
        /*1414*/
        const int CefBrowserHost_GetVisibleNavigationEntry_51 = (_typeNAME << 16) | 51;
        /*1415*/
        const int CefBrowserHost_SetAccessibilityState_52 = (_typeNAME << 16) | 52;
        /*1416*/
        internal readonly IntPtr nativePtr;
        /*1417*/
        internal CefBrowserHost(IntPtr nativePtr)
        {
            /*1418*/
            this.nativePtr = nativePtr;
            /*1419*/
        }
        /*1420*/
        public void Release()
        {
            /*1421*/
            JsValue ret;
            /*1422*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_Release_0, out ret);
            /*1423*/
        }

        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /// <summary>
        /// CefBrowserHost methods.
        /// </summary>
        /*1424*/

        public CefBrowser GetBrowser()/*1425*/
        {
            JsValue ret;
            /*1426*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetBrowser_1, out ret);
            /*1427*/
            var ret_result = new CefBrowser(ret.Ptr);
            /*1428*/
            return ret_result;
            /*1429*/
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
        /*1430*/

        public void CloseBrowser(bool /*1431*/
        force_close
        )/*1432*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1433*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_CloseBrowser_2, out ret, ref v1);
            /*1434*/

            /*1435*/
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
        /*1436*/

        public bool TryCloseBrowser()/*1437*/
        {
            JsValue ret;
            /*1438*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_TryCloseBrowser_3, out ret);
            /*1439*/
            var ret_result = ret.I32 != 0;
            /*1440*/
            return ret_result;
            /*1441*/
        }

        // gen! void SetFocus(bool focus)
        /// <summary>
        /// Set whether the browser is focused.
        /// /*cef()*/
        /// </summary>
        /*1442*/

        public void SetFocus(bool /*1443*/
        focus
        )/*1444*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1445*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetFocus_4, out ret, ref v1);
            /*1446*/

            /*1447*/
        }

        // gen! CefWindowHandle GetWindowHandle()
        /// <summary>
        /// Retrieve the window handle for this browser. If this browser is wrapped in
        /// a CefBrowserView this method should be called on the browser process UI
        /// thread and it will return the handle for the top-level native window.
        /// /*cef()*/
        /// </summary>
        /*1448*/

        public IntPtr GetWindowHandle()/*1449*/
        {
            JsValue ret;
            /*1450*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetWindowHandle_5, out ret);
            /*1451*/
            IntPtr ret_result = ret.Ptr;
            /*1452*/
            return ret_result;
            /*1453*/
        }

        // gen! CefWindowHandle GetOpenerWindowHandle()
        /// <summary>
        /// Retrieve the window handle of the browser that opened this browser. Will
        /// return NULL for non-popup windows or if this browser is wrapped in a
        /// CefBrowserView. This method can be used in combination with custom handling
        /// of modal windows.
        /// /*cef()*/
        /// </summary>
        /*1454*/

        public IntPtr GetOpenerWindowHandle()/*1455*/
        {
            JsValue ret;
            /*1456*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetOpenerWindowHandle_6, out ret);
            /*1457*/
            IntPtr ret_result = ret.Ptr;
            /*1458*/
            return ret_result;
            /*1459*/
        }

        // gen! bool HasView()
        /// <summary>
        /// Returns true if this browser is wrapped in a CefBrowserView.
        /// /*cef()*/
        /// </summary>
        /*1460*/

        public bool HasView()/*1461*/
        {
            JsValue ret;
            /*1462*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_HasView_7, out ret);
            /*1463*/
            var ret_result = ret.I32 != 0;
            /*1464*/
            return ret_result;
            /*1465*/
        }

        // gen! CefRefPtr<CefClient> GetClient()
        /// <summary>
        /// Returns the client for this browser.
        /// /*cef()*/
        /// </summary>
        /*1466*/

        public CefClient GetClient()/*1467*/
        {
            JsValue ret;
            /*1468*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetClient_8, out ret);
            /*1469*/
            var ret_result = new CefClient(ret.Ptr);
            /*1470*/
            return ret_result;
            /*1471*/
        }

        // gen! CefRefPtr<CefRequestContext> GetRequestContext()
        /// <summary>
        /// Returns the request context for this browser.
        /// /*cef()*/
        /// </summary>
        /*1472*/

        public CefRequestContext GetRequestContext()/*1473*/
        {
            JsValue ret;
            /*1474*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetRequestContext_9, out ret);
            /*1475*/
            var ret_result = new CefRequestContext(ret.Ptr);
            /*1476*/
            return ret_result;
            /*1477*/
        }

        // gen! double GetZoomLevel()
        /// <summary>
        /// Get the current zoom level. The default zoom level is 0.0. This method can
        /// only be called on the UI thread.
        /// /*cef()*/
        /// </summary>
        /*1478*/

        public double GetZoomLevel()/*1479*/
        {
            JsValue ret;
            /*1480*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetZoomLevel_10, out ret);
            /*1481*/
            var ret_result = ret.Num;
            /*1482*/
            return ret_result;
            /*1483*/
        }

        // gen! void SetZoomLevel(double zoomLevel)
        /// <summary>
        /// Change the zoom level to the specified value. Specify 0.0 to reset the
        /// zoom level. If called on the UI thread the change will be applied
        /// immediately. Otherwise, the change will be applied asynchronously on the
        /// UI thread.
        /// /*cef()*/
        /// </summary>
        /*1484*/

        public void SetZoomLevel(double /*1485*/
        zoomLevel
        )/*1486*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1487*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetZoomLevel_11, out ret, ref v1);
            /*1488*/

            /*1489*/
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
        /*1490*/

        public void RunFileDialog(cef_file_dialog_mode_t /*1491*/
        mode
        , string /*1492*/
        title
        , string /*1493*/
        default_file_path
        , List<string> /*1494*/
        accept_filters
        , int /*1495*/
        selected_accept_filter
        , CefRunFileDialogCallback /*1496*/
        callback
        )/*1497*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue v6 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(title);
            /*1498*/
            ;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(default_file_path);
            /*1499*/
            ;
            /*1500*/

            Cef3Binder.MyCefMet_Call6(this.nativePtr, CefBrowserHost_RunFileDialog_12, out ret, ref v1, ref v2, ref v3, ref v4, ref v5, ref v6);
            /*1501*/

            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*1502*/
            ;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*1503*/
            ;
            /*1504*/
        }

        // gen! void StartDownload(const CefString& url)
        /// <summary>
        /// Download the file at |url| using CefDownloadHandler.
        /// /*cef()*/
        /// </summary>
        /*1505*/

        public void StartDownload(string /*1506*/
        url
        )/*1507*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*1508*/
            ;
            /*1509*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_StartDownload_13, out ret, ref v1);
            /*1510*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1511*/
            ;
            /*1512*/
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
        /*1513*/

        public void DownloadImage(string /*1514*/
        image_url
        , bool /*1515*/
        is_favicon
        , uint /*1516*/
        max_image_size
        , bool /*1517*/
        bypass_cache
        , CefDownloadImageCallback /*1518*/
        callback
        )/*1519*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(image_url);
            /*1520*/
            ;
            /*1521*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefBrowserHost_DownloadImage_14, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*1522*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1523*/
            ;
            /*1524*/
        }

        // gen! void Print()
        /// <summary>
        /// Print the current browser contents.
        /// /*cef()*/
        /// </summary>
        /*1525*/

        public void Print()/*1526*/
        {
            JsValue ret;
            /*1527*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_Print_15, out ret);
            /*1528*/

            /*1529*/
        }

        // gen! void PrintToPDF(const CefString& path,const CefPdfPrintSettings& settings,CefRefPtr<CefPdfPrintCallback> callback)
        /// <summary>
        /// Print the current browser contents to the PDF file specified by |path| and
        /// execute |callback| on completion. The caller is responsible for deleting
        /// |path| when done. For PDF printing to work on Linux you must implement the
        /// CefPrintHandler::GetPdfPaperSize method.
        /// /*cef(optional_param=callback)*/
        /// </summary>
        /*1530*/

        public void PrintToPDF(string /*1531*/
        path
        , CefPdfPrintSettings /*1532*/
        settings
        , CefPdfPrintCallback /*1533*/
        callback
        )/*1534*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(path);
            /*1535*/
            ;
            /*1536*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_PrintToPDF_16, out ret, ref v1, ref v2, ref v3);
            /*1537*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1538*/
            ;
            /*1539*/
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
        /*1540*/

        public void Find(int /*1541*/
        identifier
        , string /*1542*/
        searchText
        , bool /*1543*/
        forward
        , bool /*1544*/
        matchCase
        , bool /*1545*/
        findNext
        )/*1546*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(searchText);
            /*1547*/
            ;
            /*1548*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefBrowserHost_Find_17, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*1549*/

            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*1550*/
            ;
            /*1551*/
        }

        // gen! void StopFinding(bool clearSelection)
        /// <summary>
        /// Cancel all searches that are currently going on.
        /// /*cef()*/
        /// </summary>
        /*1552*/

        public void StopFinding(bool /*1553*/
        clearSelection
        )/*1554*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1555*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_StopFinding_18, out ret, ref v1);
            /*1556*/

            /*1557*/
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
        /*1558*/

        public void ShowDevTools(CefWindowInfo /*1559*/
        windowInfo
        , CefClient /*1560*/
        client
        , CefBrowserSettings /*1561*/
        settings
        , CefPoint /*1562*/
        inspect_element_at
        )/*1563*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            /*1564*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_ShowDevTools_19, out ret, ref v1, ref v2, ref v3, ref v4);
            /*1565*/

            /*1566*/
        }

        // gen! void CloseDevTools()
        /// <summary>
        /// Explicitly close the associated DevTools browser, if any.
        /// /*cef()*/
        /// </summary>
        /*1567*/

        public void CloseDevTools()/*1568*/
        {
            JsValue ret;
            /*1569*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_CloseDevTools_20, out ret);
            /*1570*/

            /*1571*/
        }

        // gen! bool HasDevTools()
        /// <summary>
        /// Returns true if this browser currently has an associated DevTools browser.
        /// Must be called on the browser process UI thread.
        /// /*cef()*/
        /// </summary>
        /*1572*/

        public bool HasDevTools()/*1573*/
        {
            JsValue ret;
            /*1574*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_HasDevTools_21, out ret);
            /*1575*/
            var ret_result = ret.I32 != 0;
            /*1576*/
            return ret_result;
            /*1577*/
        }

        // gen! void GetNavigationEntries(CefRefPtr<CefNavigationEntryVisitor> visitor,bool current_only)
        /// <summary>
        /// Retrieve a snapshot of current navigation entries as values sent to the
        /// specified visitor. If |current_only| is true only the current navigation
        /// entry will be sent, otherwise all navigation entries will be sent.
        /// /*cef()*/
        /// </summary>
        /*1578*/

        public void GetNavigationEntries(CefNavigationEntryVisitor /*1579*/
        visitor
        , bool /*1580*/
        current_only
        )/*1581*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*1582*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_GetNavigationEntries_22, out ret, ref v1, ref v2);
            /*1583*/

            /*1584*/
        }

        // gen! void SetMouseCursorChangeDisabled(bool disabled)
        /// <summary>
        /// Set whether mouse cursor change is disabled.
        /// /*cef()*/
        /// </summary>
        /*1585*/

        public void SetMouseCursorChangeDisabled(bool /*1586*/
        disabled
        )/*1587*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1588*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetMouseCursorChangeDisabled_23, out ret, ref v1);
            /*1589*/

            /*1590*/
        }

        // gen! bool IsMouseCursorChangeDisabled()
        /// <summary>
        /// Returns true if mouse cursor change is disabled.
        /// /*cef()*/
        /// </summary>
        /*1591*/

        public bool IsMouseCursorChangeDisabled()/*1592*/
        {
            JsValue ret;
            /*1593*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_IsMouseCursorChangeDisabled_24, out ret);
            /*1594*/
            var ret_result = ret.I32 != 0;
            /*1595*/
            return ret_result;
            /*1596*/
        }

        // gen! void ReplaceMisspelling(const CefString& word)
        /// <summary>
        /// If a misspelled word is currently selected in an editable node calling
        /// this method will replace it with the specified |word|.
        /// /*cef()*/
        /// </summary>
        /*1597*/

        public void ReplaceMisspelling(string /*1598*/
        word
        )/*1599*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(word);
            /*1600*/
            ;
            /*1601*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_ReplaceMisspelling_25, out ret, ref v1);
            /*1602*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1603*/
            ;
            /*1604*/
        }

        // gen! void AddWordToDictionary(const CefString& word)
        /// <summary>
        /// Add the specified |word| to the spelling dictionary.
        /// /*cef()*/
        /// </summary>
        /*1605*/

        public void AddWordToDictionary(string /*1606*/
        word
        )/*1607*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(word);
            /*1608*/
            ;
            /*1609*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_AddWordToDictionary_26, out ret, ref v1);
            /*1610*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1611*/
            ;
            /*1612*/
        }

        // gen! bool IsWindowRenderingDisabled()
        /// <summary>
        /// Returns true if window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1613*/

        public bool IsWindowRenderingDisabled()/*1614*/
        {
            JsValue ret;
            /*1615*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_IsWindowRenderingDisabled_27, out ret);
            /*1616*/
            var ret_result = ret.I32 != 0;
            /*1617*/
            return ret_result;
            /*1618*/
        }

        // gen! void WasResized()
        /// <summary>
        /// Notify the browser that the widget has been resized. The browser will first
        /// call CefRenderHandler::GetViewRect to get the new size and then call
        /// CefRenderHandler::OnPaint asynchronously with the updated regions. This
        /// method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1619*/

        public void WasResized()/*1620*/
        {
            JsValue ret;
            /*1621*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_WasResized_28, out ret);
            /*1622*/

            /*1623*/
        }

        // gen! void WasHidden(bool hidden)
        /// <summary>
        /// Notify the browser that it has been hidden or shown. Layouting and
        /// CefRenderHandler::OnPaint notification will stop when the browser is
        /// hidden. This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1624*/

        public void WasHidden(bool /*1625*/
        hidden
        )/*1626*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1627*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_WasHidden_29, out ret, ref v1);
            /*1628*/

            /*1629*/
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
        /*1630*/

        public void NotifyScreenInfoChanged()/*1631*/
        {
            JsValue ret;
            /*1632*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_NotifyScreenInfoChanged_30, out ret);
            /*1633*/

            /*1634*/
        }

        // gen! void Invalidate(PaintElementType type)
        /// <summary>
        /// Invalidate the view. The browser will call CefRenderHandler::OnPaint
        /// asynchronously. This method is only used when window rendering is
        /// disabled.
        /// /*cef()*/
        /// </summary>
        /*1635*/

        public void Invalidate(cef_paint_element_type_t /*1636*/
        type
        )/*1637*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1638*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_Invalidate_31, out ret, ref v1);
            /*1639*/

            /*1640*/
        }

        // gen! void SendKeyEvent(const CefKeyEvent& event)
        /// <summary>
        /// Send a key event to the browser.
        /// /*cef()*/
        /// </summary>
        /*1641*/

        public void SendKeyEvent(CefKeyEvent /*1642*/
        _event
        )/*1643*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1644*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SendKeyEvent_32, out ret, ref v1);
            /*1645*/

            /*1646*/
        }

        // gen! void SendMouseClickEvent(const CefMouseEvent& event,MouseButtonType type,bool mouseUp,int clickCount)
        /// <summary>
        /// Send a mouse click event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view.
        /// /*cef()*/
        /// </summary>
        /*1647*/

        public void SendMouseClickEvent(CefMouseEvent /*1648*/
        _event
        , cef_mouse_button_type_t /*1649*/
        type
        , bool /*1650*/
        mouseUp
        , int /*1651*/
        clickCount
        )/*1652*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            /*1653*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_SendMouseClickEvent_33, out ret, ref v1, ref v2, ref v3, ref v4);
            /*1654*/

            /*1655*/
        }

        // gen! void SendMouseMoveEvent(const CefMouseEvent& event,bool mouseLeave)
        /// <summary>
        /// Send a mouse move event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view.
        /// /*cef()*/
        /// </summary>
        /*1656*/

        public void SendMouseMoveEvent(CefMouseEvent /*1657*/
        _event
        , bool /*1658*/
        mouseLeave
        )/*1659*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*1660*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_SendMouseMoveEvent_34, out ret, ref v1, ref v2);
            /*1661*/

            /*1662*/
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
        /*1663*/

        public void SendMouseWheelEvent(CefMouseEvent /*1664*/
        _event
        , int /*1665*/
        deltaX
        , int /*1666*/
        deltaY
        )/*1667*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*1668*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_SendMouseWheelEvent_35, out ret, ref v1, ref v2, ref v3);
            /*1669*/

            /*1670*/
        }

        // gen! void SendFocusEvent(bool setFocus)
        /// <summary>
        /// Send a focus event to the browser.
        /// /*cef()*/
        /// </summary>
        /*1671*/

        public void SendFocusEvent(bool /*1672*/
        setFocus
        )/*1673*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1674*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SendFocusEvent_36, out ret, ref v1);
            /*1675*/

            /*1676*/
        }

        // gen! void SendCaptureLostEvent()
        /// <summary>
        /// Send a capture lost event to the browser.
        /// /*cef()*/
        /// </summary>
        /*1677*/

        public void SendCaptureLostEvent()/*1678*/
        {
            JsValue ret;
            /*1679*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_SendCaptureLostEvent_37, out ret);
            /*1680*/

            /*1681*/
        }

        // gen! void NotifyMoveOrResizeStarted()
        /// <summary>
        /// Notify the browser that the window hosting it is about to be moved or
        /// resized. This method is only used on Windows and Linux.
        /// /*cef()*/
        /// </summary>
        /*1682*/

        public void NotifyMoveOrResizeStarted()/*1683*/
        {
            JsValue ret;
            /*1684*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_NotifyMoveOrResizeStarted_38, out ret);
            /*1685*/

            /*1686*/
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
        /*1687*/

        public int GetWindowlessFrameRate()/*1688*/
        {
            JsValue ret;
            /*1689*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetWindowlessFrameRate_39, out ret);
            /*1690*/
            var ret_result = ret.I32;
            /*1691*/
            return ret_result;
            /*1692*/
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
        /*1693*/

        public void SetWindowlessFrameRate(int /*1694*/
        frame_rate
        )/*1695*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1696*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetWindowlessFrameRate_40, out ret, ref v1);
            /*1697*/

            /*1698*/
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
        /*1699*/

        public void ImeSetComposition(string /*1700*/
        text
        , List<CefCompositionUnderline> /*1701*/
        underlines
        , CefRange /*1702*/
        replacement_range
        , CefRange /*1703*/
        selection_range
        )/*1704*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(text);
            /*1705*/
            ;
            /*1706*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_ImeSetComposition_41, out ret, ref v1, ref v2, ref v3, ref v4);
            /*1707*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1708*/
            ;
            /*1709*/
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
        /*1710*/

        public void ImeCommitText(string /*1711*/
        text
        , CefRange /*1712*/
        replacement_range
        , int /*1713*/
        relative_cursor_pos
        )/*1714*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(text);
            /*1715*/
            ;
            /*1716*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_ImeCommitText_42, out ret, ref v1, ref v2, ref v3);
            /*1717*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1718*/
            ;
            /*1719*/
        }

        // gen! void ImeFinishComposingText(bool keep_selection)
        /// <summary>
        /// Completes the existing composition by applying the current composition node
        /// contents. If |keep_selection| is false the current selection, if any, will
        /// be discarded. See comments on ImeSetComposition for usage.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1720*/

        public void ImeFinishComposingText(bool /*1721*/
        keep_selection
        )/*1722*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1723*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_ImeFinishComposingText_43, out ret, ref v1);
            /*1724*/

            /*1725*/
        }

        // gen! void ImeCancelComposition()
        /// <summary>
        /// Cancels the existing composition and discards the composition node
        /// contents without applying them. See comments on ImeSetComposition for
        /// usage.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1726*/

        public void ImeCancelComposition()/*1727*/
        {
            JsValue ret;
            /*1728*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_ImeCancelComposition_44, out ret);
            /*1729*/

            /*1730*/
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
        /*1731*/

        public void DragTargetDragEnter(CefDragData /*1732*/
        drag_data
        , CefMouseEvent /*1733*/
        _event
        , cef_drag_operations_mask_t /*1734*/
        allowed_ops
        )/*1735*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*1736*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_DragTargetDragEnter_45, out ret, ref v1, ref v2, ref v3);
            /*1737*/

            /*1738*/
        }

        // gen! void DragTargetDragOver(const CefMouseEvent& event,DragOperationsMask allowed_ops)
        /// <summary>
        /// Call this method each time the mouse is moved across the web view during
        /// a drag operation (after calling DragTargetDragEnter and before calling
        /// DragTargetDragLeave/DragTargetDrop).
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1739*/

        public void DragTargetDragOver(CefMouseEvent /*1740*/
        _event
        , cef_drag_operations_mask_t /*1741*/
        allowed_ops
        )/*1742*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*1743*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_DragTargetDragOver_46, out ret, ref v1, ref v2);
            /*1744*/

            /*1745*/
        }

        // gen! void DragTargetDragLeave()
        /// <summary>
        /// Call this method when the user drags the mouse out of the web view (after
        /// calling DragTargetDragEnter).
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1746*/

        public void DragTargetDragLeave()/*1747*/
        {
            JsValue ret;
            /*1748*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_DragTargetDragLeave_47, out ret);
            /*1749*/

            /*1750*/
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
        /*1751*/

        public void DragTargetDrop(CefMouseEvent /*1752*/
        _event
        )/*1753*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1754*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_DragTargetDrop_48, out ret, ref v1);
            /*1755*/

            /*1756*/
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
        /*1757*/

        public void DragSourceEndedAt(int /*1758*/
        x
        , int /*1759*/
        y
        , cef_drag_operations_mask_t /*1760*/
        op
        )/*1761*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*1762*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_DragSourceEndedAt_49, out ret, ref v1, ref v2, ref v3);
            /*1763*/

            /*1764*/
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
        /*1765*/

        public void DragSourceSystemDragEnded()/*1766*/
        {
            JsValue ret;
            /*1767*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_DragSourceSystemDragEnded_50, out ret);
            /*1768*/

            /*1769*/
        }

        // gen! CefRefPtr<CefNavigationEntry> GetVisibleNavigationEntry()
        /// <summary>
        /// Returns the current visible navigation entry for this browser. This method
        /// can only be called on the UI thread.
        /// /*cef()*/
        /// </summary>
        /*1770*/

        public CefNavigationEntry GetVisibleNavigationEntry()/*1771*/
        {
            JsValue ret;
            /*1772*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetVisibleNavigationEntry_51, out ret);
            /*1773*/
            var ret_result = new CefNavigationEntry(ret.Ptr);
            /*1774*/
            return ret_result;
            /*1775*/
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
        /*1776*/

        public void SetAccessibilityState(cef_state_t /*1777*/
        accessibility_state
        )/*1778*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1779*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetAccessibilityState_52, out ret, ref v1);
            /*1780*/

            /*1781*/
        }
        /*1782*/
    }


    // [virtual] class CefClient
    /// <summary>
    /// Implement this interface to provide handler implementations.
    /// /*(source=client,no_debugct_check)*/
    /// </summary>
    /*1791*/
    public struct CefClient
    {
        /*1792*/
        const int _typeNAME = 5;
        /*1793*/
        const int CefClient_Release_0 = (_typeNAME << 16) | 0;
        /*1794*/
        internal readonly IntPtr nativePtr;
        /*1795*/
        internal CefClient(IntPtr nativePtr)
        {
            /*1796*/
            this.nativePtr = nativePtr;
            /*1797*/
        }
        /*1798*/
        public void Release()
        {
            /*1799*/
            JsValue ret;
            /*1800*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefClient_Release_0, out ret);
            /*1801*/
        }
        /*1802*/
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
    /*1911*/
    public struct CefCommandLine
    {
        /*1912*/
        const int _typeNAME = 6;
        /*1913*/
        const int CefCommandLine_Release_0 = (_typeNAME << 16) | 0;
        /*1914*/
        const int CefCommandLine_IsValid_1 = (_typeNAME << 16) | 1;
        /*1915*/
        const int CefCommandLine_IsReadOnly_2 = (_typeNAME << 16) | 2;
        /*1916*/
        const int CefCommandLine_Copy_3 = (_typeNAME << 16) | 3;
        /*1917*/
        const int CefCommandLine_InitFromArgv_4 = (_typeNAME << 16) | 4;
        /*1918*/
        const int CefCommandLine_InitFromString_5 = (_typeNAME << 16) | 5;
        /*1919*/
        const int CefCommandLine_Reset_6 = (_typeNAME << 16) | 6;
        /*1920*/
        const int CefCommandLine_GetArgv_7 = (_typeNAME << 16) | 7;
        /*1921*/
        const int CefCommandLine_GetCommandLineString_8 = (_typeNAME << 16) | 8;
        /*1922*/
        const int CefCommandLine_GetProgram_9 = (_typeNAME << 16) | 9;
        /*1923*/
        const int CefCommandLine_SetProgram_10 = (_typeNAME << 16) | 10;
        /*1924*/
        const int CefCommandLine_HasSwitches_11 = (_typeNAME << 16) | 11;
        /*1925*/
        const int CefCommandLine_HasSwitch_12 = (_typeNAME << 16) | 12;
        /*1926*/
        const int CefCommandLine_GetSwitchValue_13 = (_typeNAME << 16) | 13;
        /*1927*/
        const int CefCommandLine_GetSwitches_14 = (_typeNAME << 16) | 14;
        /*1928*/
        const int CefCommandLine_AppendSwitch_15 = (_typeNAME << 16) | 15;
        /*1929*/
        const int CefCommandLine_AppendSwitchWithValue_16 = (_typeNAME << 16) | 16;
        /*1930*/
        const int CefCommandLine_HasArguments_17 = (_typeNAME << 16) | 17;
        /*1931*/
        const int CefCommandLine_GetArguments_18 = (_typeNAME << 16) | 18;
        /*1932*/
        const int CefCommandLine_AppendArgument_19 = (_typeNAME << 16) | 19;
        /*1933*/
        const int CefCommandLine_PrependWrapper_20 = (_typeNAME << 16) | 20;
        /*1934*/
        internal readonly IntPtr nativePtr;
        /*1935*/
        internal CefCommandLine(IntPtr nativePtr)
        {
            /*1936*/
            this.nativePtr = nativePtr;
            /*1937*/
        }
        /*1938*/
        public void Release()
        {
            /*1939*/
            JsValue ret;
            /*1940*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Release_0, out ret);
            /*1941*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefCommandLine methods.
        /// </summary>
        /*1942*/

        public bool IsValid()/*1943*/
        {
            JsValue ret;
            /*1944*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_IsValid_1, out ret);
            /*1945*/
            var ret_result = ret.I32 != 0;
            /*1946*/
            return ret_result;
            /*1947*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*1948*/

        public bool IsReadOnly()/*1949*/
        {
            JsValue ret;
            /*1950*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_IsReadOnly_2, out ret);
            /*1951*/
            var ret_result = ret.I32 != 0;
            /*1952*/
            return ret_result;
            /*1953*/
        }

        // gen! CefRefPtr<CefCommandLine> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>
        /*1954*/

        public CefCommandLine Copy()/*1955*/
        {
            JsValue ret;
            /*1956*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Copy_3, out ret);
            /*1957*/
            var ret_result = new CefCommandLine(ret.Ptr);
            /*1958*/
            return ret_result;
            /*1959*/
        }

        // gen! void InitFromArgv(int argc,const char* const* argv)
        /// <summary>
        /// Initialize the command line with the specified |argc| and |argv| values.
        /// The first argument must be the name of the program. This method is only
        /// supported on non-Windows platforms.
        /// /*cef()*/
        /// </summary>
        /*1960*/

        public void InitFromArgv(int /*1961*/
        argc
        , IntPtr /*1962*/
        argv
        )/*1963*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*1964*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCommandLine_InitFromArgv_4, out ret, ref v1, ref v2);
            /*1965*/

            /*1966*/
        }

        // gen! void InitFromString(const CefString& command_line)
        /// <summary>
        /// Initialize the command line with the string returned by calling
        /// GetCommandLineW(). This method is only supported on Windows.
        /// /*cef()*/
        /// </summary>
        /*1967*/

        public void InitFromString(string /*1968*/
        command_line
        )/*1969*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(command_line);
            /*1970*/
            ;
            /*1971*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_InitFromString_5, out ret, ref v1);
            /*1972*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1973*/
            ;
            /*1974*/
        }

        // gen! void Reset()
        /// <summary>
        /// Reset the command-line switches and arguments but leave the program
        /// component unchanged.
        /// /*cef()*/
        /// </summary>
        /*1975*/

        public void Reset()/*1976*/
        {
            JsValue ret;
            /*1977*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Reset_6, out ret);
            /*1978*/

            /*1979*/
        }

        // gen! void GetArgv(std::vector<CefString>& argv)
        /// <summary>
        /// Retrieve the original command line string as a vector of strings.
        /// The argv array: { program, [(--|-|/)switch[=value]]*, [--], [argument]* }
        /// /*cef()*/
        /// </summary>
        /*1980*/

        public void GetArgv(List<string> /*1981*/
        argv
        )/*1982*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1983*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetArgv_7, out ret, ref v1);
            /*1984*/

            /*1985*/
        }

        // gen! CefString GetCommandLineString()
        /// <summary>
        /// Constructs and returns the represented command line string. Use this method
        /// cautiously because quoting behavior is unclear.
        /// /*cef()*/
        /// </summary>
        /*1986*/

        public string GetCommandLineString()/*1987*/
        {
            JsValue ret;
            /*1988*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_GetCommandLineString_8, out ret);
            /*1989*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*1990*/
            return ret_result;
            /*1991*/
        }

        // gen! CefString GetProgram()
        /// <summary>
        /// Get the program part of the command line string (the first item).
        /// /*cef()*/
        /// </summary>
        /*1992*/

        public string GetProgram()/*1993*/
        {
            JsValue ret;
            /*1994*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_GetProgram_9, out ret);
            /*1995*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*1996*/
            return ret_result;
            /*1997*/
        }

        // gen! void SetProgram(const CefString& program)
        /// <summary>
        /// Set the program part of the command line string (the first item).
        /// /*cef()*/
        /// </summary>
        /*1998*/

        public void SetProgram(string /*1999*/
        program
        )/*2000*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(program);
            /*2001*/
            ;
            /*2002*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_SetProgram_10, out ret, ref v1);
            /*2003*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2004*/
            ;
            /*2005*/
        }

        // gen! bool HasSwitches()
        /// <summary>
        /// Returns true if the command line has switches.
        /// /*cef()*/
        /// </summary>
        /*2006*/

        public bool HasSwitches()/*2007*/
        {
            JsValue ret;
            /*2008*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_HasSwitches_11, out ret);
            /*2009*/
            var ret_result = ret.I32 != 0;
            /*2010*/
            return ret_result;
            /*2011*/
        }

        // gen! bool HasSwitch(const CefString& name)
        /// <summary>
        /// Returns true if the command line contains the given switch.
        /// /*cef()*/
        /// </summary>
        /*2012*/

        public bool HasSwitch(string /*2013*/
        name
        )/*2014*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*2015*/
            ;
            /*2016*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_HasSwitch_12, out ret, ref v1);
            /*2017*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2018*/
            ;
            /*2019*/
            return ret_result;
            /*2020*/
        }

        // gen! CefString GetSwitchValue(const CefString& name)
        /// <summary>
        /// Returns the value associated with the given switch. If the switch has no
        /// value or isn't present this method returns the empty string.
        /// /*cef()*/
        /// </summary>
        /*2021*/

        public string GetSwitchValue(string /*2022*/
        name
        )/*2023*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*2024*/
            ;
            /*2025*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetSwitchValue_13, out ret, ref v1);
            /*2026*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2027*/
            ;
            /*2028*/
            return ret_result;
            /*2029*/
        }

        // gen! void GetSwitches(SwitchMap& switches)
        /// <summary>
        /// Returns the map of switch names and values. If a switch has no value an
        /// empty string is returned.
        /// /*cef()*/
        /// </summary>
        /*2030*/

        public void GetSwitches(SwitchMap /*2031*/
        switches
        )/*2032*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*2033*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetSwitches_14, out ret, ref v1);
            /*2034*/

            /*2035*/
        }

        // gen! void AppendSwitch(const CefString& name)
        /// <summary>
        /// Add a switch to the end of the command line. If the switch has no value
        /// pass an empty value string.
        /// /*cef()*/
        /// </summary>
        /*2036*/

        public void AppendSwitch(string /*2037*/
        name
        )/*2038*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*2039*/
            ;
            /*2040*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_AppendSwitch_15, out ret, ref v1);
            /*2041*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2042*/
            ;
            /*2043*/
        }

        // gen! void AppendSwitchWithValue(const CefString& name,const CefString& value)
        /// <summary>
        /// Add a switch with the specified value to the end of the command line.
        /// /*cef()*/
        /// </summary>
        /*2044*/

        public void AppendSwitchWithValue(string /*2045*/
        name
        , string /*2046*/
        value
        )/*2047*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*2048*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*2049*/
            ;
            /*2050*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCommandLine_AppendSwitchWithValue_16, out ret, ref v1, ref v2);
            /*2051*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2052*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*2053*/
            ;
            /*2054*/
        }

        // gen! bool HasArguments()
        /// <summary>
        /// True if there are remaining command line arguments.
        /// /*cef()*/
        /// </summary>
        /*2055*/

        public bool HasArguments()/*2056*/
        {
            JsValue ret;
            /*2057*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_HasArguments_17, out ret);
            /*2058*/
            var ret_result = ret.I32 != 0;
            /*2059*/
            return ret_result;
            /*2060*/
        }

        // gen! void GetArguments(ArgumentList& arguments)
        /// <summary>
        /// Get the remaining command line arguments.
        /// /*cef()*/
        /// </summary>
        /*2061*/

        public void GetArguments(ArgumentList /*2062*/
        arguments
        )/*2063*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*2064*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetArguments_18, out ret, ref v1);
            /*2065*/

            /*2066*/
        }

        // gen! void AppendArgument(const CefString& argument)
        /// <summary>
        /// Add an argument to the end of the command line.
        /// /*cef()*/
        /// </summary>
        /*2067*/

        public void AppendArgument(string /*2068*/
        argument
        )/*2069*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(argument);
            /*2070*/
            ;
            /*2071*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_AppendArgument_19, out ret, ref v1);
            /*2072*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2073*/
            ;
            /*2074*/
        }

        // gen! void PrependWrapper(const CefString& wrapper)
        /// <summary>
        /// Insert a command before the current command.
        /// Common for debuggers, like "valgrind" or "gdb --args".
        /// /*cef()*/
        /// </summary>
        /*2075*/

        public void PrependWrapper(string /*2076*/
        wrapper
        )/*2077*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(wrapper);
            /*2078*/
            ;
            /*2079*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_PrependWrapper_20, out ret, ref v1);
            /*2080*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2081*/
            ;
            /*2082*/
        }
        /*2083*/
    }


    // [virtual] class CefContextMenuParams
    /// <summary>
    /// Provides information about the context menu state. The ethods of this class
    /// can only be accessed on browser process the UI thread.
    /// /*(source=library)*/
    /// </summary>
    /*2197*/
    public struct CefContextMenuParams
    {
        /*2198*/
        const int _typeNAME = 7;
        /*2199*/
        const int CefContextMenuParams_Release_0 = (_typeNAME << 16) | 0;
        /*2200*/
        const int CefContextMenuParams_GetXCoord_1 = (_typeNAME << 16) | 1;
        /*2201*/
        const int CefContextMenuParams_GetYCoord_2 = (_typeNAME << 16) | 2;
        /*2202*/
        const int CefContextMenuParams_GetTypeFlags_3 = (_typeNAME << 16) | 3;
        /*2203*/
        const int CefContextMenuParams_GetLinkUrl_4 = (_typeNAME << 16) | 4;
        /*2204*/
        const int CefContextMenuParams_GetUnfilteredLinkUrl_5 = (_typeNAME << 16) | 5;
        /*2205*/
        const int CefContextMenuParams_GetSourceUrl_6 = (_typeNAME << 16) | 6;
        /*2206*/
        const int CefContextMenuParams_HasImageContents_7 = (_typeNAME << 16) | 7;
        /*2207*/
        const int CefContextMenuParams_GetTitleText_8 = (_typeNAME << 16) | 8;
        /*2208*/
        const int CefContextMenuParams_GetPageUrl_9 = (_typeNAME << 16) | 9;
        /*2209*/
        const int CefContextMenuParams_GetFrameUrl_10 = (_typeNAME << 16) | 10;
        /*2210*/
        const int CefContextMenuParams_GetFrameCharset_11 = (_typeNAME << 16) | 11;
        /*2211*/
        const int CefContextMenuParams_GetMediaType_12 = (_typeNAME << 16) | 12;
        /*2212*/
        const int CefContextMenuParams_GetMediaStateFlags_13 = (_typeNAME << 16) | 13;
        /*2213*/
        const int CefContextMenuParams_GetSelectionText_14 = (_typeNAME << 16) | 14;
        /*2214*/
        const int CefContextMenuParams_GetMisspelledWord_15 = (_typeNAME << 16) | 15;
        /*2215*/
        const int CefContextMenuParams_GetDictionarySuggestions_16 = (_typeNAME << 16) | 16;
        /*2216*/
        const int CefContextMenuParams_IsEditable_17 = (_typeNAME << 16) | 17;
        /*2217*/
        const int CefContextMenuParams_IsSpellCheckEnabled_18 = (_typeNAME << 16) | 18;
        /*2218*/
        const int CefContextMenuParams_GetEditStateFlags_19 = (_typeNAME << 16) | 19;
        /*2219*/
        const int CefContextMenuParams_IsCustomMenu_20 = (_typeNAME << 16) | 20;
        /*2220*/
        const int CefContextMenuParams_IsPepperMenu_21 = (_typeNAME << 16) | 21;
        /*2221*/
        internal readonly IntPtr nativePtr;
        /*2222*/
        internal CefContextMenuParams(IntPtr nativePtr)
        {
            /*2223*/
            this.nativePtr = nativePtr;
            /*2224*/
        }
        /*2225*/
        public void Release()
        {
            /*2226*/
            JsValue ret;
            /*2227*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_Release_0, out ret);
            /*2228*/
        }

        // gen! int GetXCoord()
        /// <summary>
        /// CefContextMenuParams methods.
        /// </summary>
        /*2229*/

        public int GetXCoord()/*2230*/
        {
            JsValue ret;
            /*2231*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetXCoord_1, out ret);
            /*2232*/
            var ret_result = ret.I32;
            /*2233*/
            return ret_result;
            /*2234*/
        }

        // gen! int GetYCoord()
        /// <summary>
        /// Returns the Y coordinate of the mouse where the context menu was invoked.
        /// Coords are relative to the associated RenderView's origin.
        /// /*cef()*/
        /// </summary>
        /*2235*/

        public int GetYCoord()/*2236*/
        {
            JsValue ret;
            /*2237*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetYCoord_2, out ret);
            /*2238*/
            var ret_result = ret.I32;
            /*2239*/
            return ret_result;
            /*2240*/
        }

        // gen! TypeFlags GetTypeFlags()
        /// <summary>
        /// Returns flags representing the type of node that the context menu was
        /// invoked on.
        /// /*cef(default_retval=CM_TYPEFLAG_NONE)*/
        /// </summary>
        /*2241*/

        public cef_context_menu_type_flags_t GetTypeFlags()/*2242*/
        {
            JsValue ret;
            /*2243*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetTypeFlags_3, out ret);
            /*2244*/
            var ret_result = (cef_context_menu_type_flags_t)ret.I32;

            /*2245*/
            return ret_result;
            /*2246*/
        }

        // gen! CefString GetLinkUrl()
        /// <summary>
        /// Returns the URL of the link, if any, that encloses the node that the
        /// context menu was invoked on.
        /// /*cef()*/
        /// </summary>
        /*2247*/

        public string GetLinkUrl()/*2248*/
        {
            JsValue ret;
            /*2249*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetLinkUrl_4, out ret);
            /*2250*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2251*/
            return ret_result;
            /*2252*/
        }

        // gen! CefString GetUnfilteredLinkUrl()
        /// <summary>
        /// Returns the link URL, if any, to be used ONLY for "copy link address". We
        /// don't validate this field in the frontend process.
        /// /*cef()*/
        /// </summary>
        /*2253*/

        public string GetUnfilteredLinkUrl()/*2254*/
        {
            JsValue ret;
            /*2255*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetUnfilteredLinkUrl_5, out ret);
            /*2256*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2257*/
            return ret_result;
            /*2258*/
        }

        // gen! CefString GetSourceUrl()
        /// <summary>
        /// Returns the source URL, if any, for the element that the context menu was
        /// invoked on. Example of elements with source URLs are img, audio, and video.
        /// /*cef()*/
        /// </summary>
        /*2259*/

        public string GetSourceUrl()/*2260*/
        {
            JsValue ret;
            /*2261*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetSourceUrl_6, out ret);
            /*2262*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2263*/
            return ret_result;
            /*2264*/
        }

        // gen! bool HasImageContents()
        /// <summary>
        /// Returns true if the context menu was invoked on an image which has
        /// non-empty contents.
        /// /*cef()*/
        /// </summary>
        /*2265*/

        public bool HasImageContents()/*2266*/
        {
            JsValue ret;
            /*2267*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_HasImageContents_7, out ret);
            /*2268*/
            var ret_result = ret.I32 != 0;
            /*2269*/
            return ret_result;
            /*2270*/
        }

        // gen! CefString GetTitleText()
        /// <summary>
        /// Returns the title text or the alt text if the context menu was invoked on
        /// an image.
        /// /*cef()*/
        /// </summary>
        /*2271*/

        public string GetTitleText()/*2272*/
        {
            JsValue ret;
            /*2273*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetTitleText_8, out ret);
            /*2274*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2275*/
            return ret_result;
            /*2276*/
        }

        // gen! CefString GetPageUrl()
        /// <summary>
        /// Returns the URL of the top level page that the context menu was invoked on.
        /// /*cef()*/
        /// </summary>
        /*2277*/

        public string GetPageUrl()/*2278*/
        {
            JsValue ret;
            /*2279*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetPageUrl_9, out ret);
            /*2280*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2281*/
            return ret_result;
            /*2282*/
        }

        // gen! CefString GetFrameUrl()
        /// <summary>
        /// Returns the URL of the subframe that the context menu was invoked on.
        /// /*cef()*/
        /// </summary>
        /*2283*/

        public string GetFrameUrl()/*2284*/
        {
            JsValue ret;
            /*2285*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetFrameUrl_10, out ret);
            /*2286*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2287*/
            return ret_result;
            /*2288*/
        }

        // gen! CefString GetFrameCharset()
        /// <summary>
        /// Returns the character encoding of the subframe that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>
        /*2289*/

        public string GetFrameCharset()/*2290*/
        {
            JsValue ret;
            /*2291*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetFrameCharset_11, out ret);
            /*2292*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2293*/
            return ret_result;
            /*2294*/
        }

        // gen! MediaType GetMediaType()
        /// <summary>
        /// Returns the type of context node that the context menu was invoked on.
        /// /*cef(default_retval=CM_MEDIATYPE_NONE)*/
        /// </summary>
        /*2295*/

        public cef_context_menu_media_type_t GetMediaType()/*2296*/
        {
            JsValue ret;
            /*2297*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMediaType_12, out ret);
            /*2298*/
            var ret_result = (cef_context_menu_media_type_t)ret.I32;

            /*2299*/
            return ret_result;
            /*2300*/
        }

        // gen! MediaStateFlags GetMediaStateFlags()
        /// <summary>
        /// Returns flags representing the actions supported by the media element, if
        /// any, that the context menu was invoked on.
        /// /*cef(default_retval=CM_MEDIAFLAG_NONE)*/
        /// </summary>
        /*2301*/

        public cef_context_menu_media_state_flags_t GetMediaStateFlags()/*2302*/
        {
            JsValue ret;
            /*2303*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMediaStateFlags_13, out ret);
            /*2304*/
            var ret_result = (cef_context_menu_media_state_flags_t)ret.I32;

            /*2305*/
            return ret_result;
            /*2306*/
        }

        // gen! CefString GetSelectionText()
        /// <summary>
        /// Returns the text of the selection, if any, that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>
        /*2307*/

        public string GetSelectionText()/*2308*/
        {
            JsValue ret;
            /*2309*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetSelectionText_14, out ret);
            /*2310*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2311*/
            return ret_result;
            /*2312*/
        }

        // gen! CefString GetMisspelledWord()
        /// <summary>
        /// Returns the text of the misspelled word, if any, that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>
        /*2313*/

        public string GetMisspelledWord()/*2314*/
        {
            JsValue ret;
            /*2315*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMisspelledWord_15, out ret);
            /*2316*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2317*/
            return ret_result;
            /*2318*/
        }

        // gen! bool GetDictionarySuggestions(std::vector<CefString>& suggestions)
        /// <summary>
        /// Returns true if suggestions exist, false otherwise. Fills in |suggestions|
        /// from the spell check service for the misspelled word if there is one.
        /// /*cef()*/
        /// </summary>
        /*2319*/

        public bool GetDictionarySuggestions(List<string> /*2320*/
        suggestions
        )/*2321*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*2322*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefContextMenuParams_GetDictionarySuggestions_16, out ret, ref v1);
            /*2323*/
            var ret_result = ret.I32 != 0;
            /*2324*/
            return ret_result;
            /*2325*/
        }

        // gen! bool IsEditable()
        /// <summary>
        /// Returns true if the context menu was invoked on an editable node.
        /// /*cef()*/
        /// </summary>
        /*2326*/

        public bool IsEditable()/*2327*/
        {
            JsValue ret;
            /*2328*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsEditable_17, out ret);
            /*2329*/
            var ret_result = ret.I32 != 0;
            /*2330*/
            return ret_result;
            /*2331*/
        }

        // gen! bool IsSpellCheckEnabled()
        /// <summary>
        /// Returns true if the context menu was invoked on an editable node where
        /// spell-check is enabled.
        /// /*cef()*/
        /// </summary>
        /*2332*/

        public bool IsSpellCheckEnabled()/*2333*/
        {
            JsValue ret;
            /*2334*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsSpellCheckEnabled_18, out ret);
            /*2335*/
            var ret_result = ret.I32 != 0;
            /*2336*/
            return ret_result;
            /*2337*/
        }

        // gen! EditStateFlags GetEditStateFlags()
        /// <summary>
        /// Returns flags representing the actions supported by the editable node, if
        /// any, that the context menu was invoked on.
        /// /*cef(default_retval=CM_EDITFLAG_NONE)*/
        /// </summary>
        /*2338*/

        public cef_context_menu_edit_state_flags_t GetEditStateFlags()/*2339*/
        {
            JsValue ret;
            /*2340*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetEditStateFlags_19, out ret);
            /*2341*/
            var ret_result = (cef_context_menu_edit_state_flags_t)ret.I32;

            /*2342*/
            return ret_result;
            /*2343*/
        }

        // gen! bool IsCustomMenu()
        /// <summary>
        /// Returns true if the context menu contains items specified by the renderer
        /// process (for example, plugin placeholder or pepper plugin menu items).
        /// /*cef()*/
        /// </summary>
        /*2344*/

        public bool IsCustomMenu()/*2345*/
        {
            JsValue ret;
            /*2346*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsCustomMenu_20, out ret);
            /*2347*/
            var ret_result = ret.I32 != 0;
            /*2348*/
            return ret_result;
            /*2349*/
        }

        // gen! bool IsPepperMenu()
        /// <summary>
        /// Returns true if the context menu was invoked from a pepper plugin.
        /// /*cef()*/
        /// </summary>
        /*2350*/

        public bool IsPepperMenu()/*2351*/
        {
            JsValue ret;
            /*2352*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsPepperMenu_21, out ret);
            /*2353*/
            var ret_result = ret.I32 != 0;
            /*2354*/
            return ret_result;
            /*2355*/
        }
        /*2356*/
    }


    // [virtual] class CefCookieManager
    /// <summary>
    /// Class used for managing cookies. The methods of this class may be called on
    /// any thread unless otherwise indicated.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*2400*/
    public struct CefCookieManager
    {
        /*2401*/
        const int _typeNAME = 8;
        /*2402*/
        const int CefCookieManager_Release_0 = (_typeNAME << 16) | 0;
        /*2403*/
        const int CefCookieManager_SetSupportedSchemes_1 = (_typeNAME << 16) | 1;
        /*2404*/
        const int CefCookieManager_VisitAllCookies_2 = (_typeNAME << 16) | 2;
        /*2405*/
        const int CefCookieManager_VisitUrlCookies_3 = (_typeNAME << 16) | 3;
        /*2406*/
        const int CefCookieManager_SetCookie_4 = (_typeNAME << 16) | 4;
        /*2407*/
        const int CefCookieManager_DeleteCookies_5 = (_typeNAME << 16) | 5;
        /*2408*/
        const int CefCookieManager_SetStoragePath_6 = (_typeNAME << 16) | 6;
        /*2409*/
        const int CefCookieManager_FlushStore_7 = (_typeNAME << 16) | 7;
        /*2410*/
        internal readonly IntPtr nativePtr;
        /*2411*/
        internal CefCookieManager(IntPtr nativePtr)
        {
            /*2412*/
            this.nativePtr = nativePtr;
            /*2413*/
        }
        /*2414*/
        public void Release()
        {
            /*2415*/
            JsValue ret;
            /*2416*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCookieManager_Release_0, out ret);
            /*2417*/
        }

        // gen! void SetSupportedSchemes(const std::vector<CefString>& schemes,CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// CefCookieManager methods.
        /// </summary>
        /*2418*/

        public void SetSupportedSchemes(List<string> /*2419*/
        schemes
        , CefCompletionCallback /*2420*/
        callback
        )/*2421*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*2422*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCookieManager_SetSupportedSchemes_1, out ret, ref v1, ref v2);
            /*2423*/

            /*2424*/
        }

        // gen! bool VisitAllCookies(CefRefPtr<CefCookieVisitor> visitor)
        /// <summary>
        /// Visit all cookies on the IO thread. The returned cookies are ordered by
        /// longest path, then by earliest creation date. Returns false if cookies
        /// cannot be accessed.
        /// /*cef()*/
        /// </summary>
        /*2425*/

        public bool VisitAllCookies(CefCookieVisitor /*2426*/
        visitor
        )/*2427*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*2428*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCookieManager_VisitAllCookies_2, out ret, ref v1);
            /*2429*/
            var ret_result = ret.I32 != 0;
            /*2430*/
            return ret_result;
            /*2431*/
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
        /*2432*/

        public bool VisitUrlCookies(string /*2433*/
        url
        , bool /*2434*/
        includeHttpOnly
        , CefCookieVisitor /*2435*/
        visitor
        )/*2436*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*2437*/
            ;
            /*2438*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_VisitUrlCookies_3, out ret, ref v1, ref v2, ref v3);
            /*2439*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2440*/
            ;
            /*2441*/
            return ret_result;
            /*2442*/
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
        /*2443*/

        public bool SetCookie(string /*2444*/
        url
        , CefCookie /*2445*/
        cookie
        , CefSetCookieCallback /*2446*/
        callback
        )/*2447*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*2448*/
            ;
            /*2449*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_SetCookie_4, out ret, ref v1, ref v2, ref v3);
            /*2450*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2451*/
            ;
            /*2452*/
            return ret_result;
            /*2453*/
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
        /*2454*/

        public bool DeleteCookies(string /*2455*/
        url
        , string /*2456*/
        cookie_name
        , CefDeleteCookiesCallback /*2457*/
        callback
        )/*2458*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*2459*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(cookie_name);
            /*2460*/
            ;
            /*2461*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_DeleteCookies_5, out ret, ref v1, ref v2, ref v3);
            /*2462*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2463*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*2464*/
            ;
            /*2465*/
            return ret_result;
            /*2466*/
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
        /*2467*/

        public bool SetStoragePath(string /*2468*/
        path
        , bool /*2469*/
        persist_session_cookies
        , CefCompletionCallback /*2470*/
        callback
        )/*2471*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(path);
            /*2472*/
            ;
            /*2473*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_SetStoragePath_6, out ret, ref v1, ref v2, ref v3);
            /*2474*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2475*/
            ;
            /*2476*/
            return ret_result;
            /*2477*/
        }

        // gen! bool FlushStore(CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Flush the backing store (if any) to disk. If |callback| is non-NULL it will
        /// be executed asnychronously on the IO thread after the flush is complete.
        /// Returns false if cookies cannot be accessed.
        /// /*cef(optional_param=callback)*/
        /// </summary>
        /*2478*/

        public bool FlushStore(CefCompletionCallback /*2479*/
        callback
        )/*2480*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*2481*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCookieManager_FlushStore_7, out ret, ref v1);
            /*2482*/
            var ret_result = ret.I32 != 0;
            /*2483*/
            return ret_result;
            /*2484*/
        }
        /*2485*/
    }


    // [virtual] class CefCookieVisitor
    /// <summary>
    /// Interface to implement for visiting cookie values. The methods of this class
    /// will always be called on the IO thread.
    /// /*(source=client)*/
    /// </summary>
    /*2494*/
    public struct CefCookieVisitor
    {
        /*2495*/
        const int _typeNAME = 9;
        /*2496*/
        const int CefCookieVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*2497*/
        internal readonly IntPtr nativePtr;
        /*2498*/
        internal CefCookieVisitor(IntPtr nativePtr)
        {
            /*2499*/
            this.nativePtr = nativePtr;
            /*2500*/
        }
        /*2501*/
        public void Release()
        {
            /*2502*/
            JsValue ret;
            /*2503*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCookieVisitor_Release_0, out ret);
            /*2504*/
        }
        /*2505*/
    }


    // [virtual] class CefDOMVisitor
    /// <summary>
    /// Interface to implement for visiting the DOM. The methods of this class will
    /// be called on the render process main thread.
    /// /*(source=client)*/
    /// </summary>
    /*2514*/
    public struct CefDOMVisitor
    {
        /*2515*/
        const int _typeNAME = 10;
        /*2516*/
        const int CefDOMVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*2517*/
        internal readonly IntPtr nativePtr;
        /*2518*/
        internal CefDOMVisitor(IntPtr nativePtr)
        {
            /*2519*/
            this.nativePtr = nativePtr;
            /*2520*/
        }
        /*2521*/
        public void Release()
        {
            /*2522*/
            JsValue ret;
            /*2523*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMVisitor_Release_0, out ret);
            /*2524*/
        }
        /*2525*/
    }


    // [virtual] class CefDOMDocument
    /// <summary>
    /// Class used to represent a DOM document. The methods of this class should only
    /// be called on the render process main thread thread.
    /// /*(source=library)*/
    /// </summary>
    /*2604*/
    public struct CefDOMDocument
    {
        /*2605*/
        const int _typeNAME = 11;
        /*2606*/
        const int CefDOMDocument_Release_0 = (_typeNAME << 16) | 0;
        /*2607*/
        const int CefDOMDocument_GetType_1 = (_typeNAME << 16) | 1;
        /*2608*/
        const int CefDOMDocument_GetDocument_2 = (_typeNAME << 16) | 2;
        /*2609*/
        const int CefDOMDocument_GetBody_3 = (_typeNAME << 16) | 3;
        /*2610*/
        const int CefDOMDocument_GetHead_4 = (_typeNAME << 16) | 4;
        /*2611*/
        const int CefDOMDocument_GetTitle_5 = (_typeNAME << 16) | 5;
        /*2612*/
        const int CefDOMDocument_GetElementById_6 = (_typeNAME << 16) | 6;
        /*2613*/
        const int CefDOMDocument_GetFocusedNode_7 = (_typeNAME << 16) | 7;
        /*2614*/
        const int CefDOMDocument_HasSelection_8 = (_typeNAME << 16) | 8;
        /*2615*/
        const int CefDOMDocument_GetSelectionStartOffset_9 = (_typeNAME << 16) | 9;
        /*2616*/
        const int CefDOMDocument_GetSelectionEndOffset_10 = (_typeNAME << 16) | 10;
        /*2617*/
        const int CefDOMDocument_GetSelectionAsMarkup_11 = (_typeNAME << 16) | 11;
        /*2618*/
        const int CefDOMDocument_GetSelectionAsText_12 = (_typeNAME << 16) | 12;
        /*2619*/
        const int CefDOMDocument_GetBaseURL_13 = (_typeNAME << 16) | 13;
        /*2620*/
        const int CefDOMDocument_GetCompleteURL_14 = (_typeNAME << 16) | 14;
        /*2621*/
        internal readonly IntPtr nativePtr;
        /*2622*/
        internal CefDOMDocument(IntPtr nativePtr)
        {
            /*2623*/
            this.nativePtr = nativePtr;
            /*2624*/
        }
        /*2625*/
        public void Release()
        {
            /*2626*/
            JsValue ret;
            /*2627*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_Release_0, out ret);
            /*2628*/
        }

        // gen! Type GetType()
        /// <summary>
        /// CefDOMDocument methods.
        /// </summary>
        /*2629*/

        public cef_dom_document_type_t _GetType()/*2630*/
        {
            JsValue ret;
            /*2631*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetType_1, out ret);
            /*2632*/
            var ret_result = (cef_dom_document_type_t)ret.I32;

            /*2633*/
            return ret_result;
            /*2634*/
        }

        // gen! CefRefPtr<CefDOMNode> GetDocument()
        /// <summary>
        /// Returns the root document node.
        /// /*cef()*/
        /// </summary>
        /*2635*/

        public CefDOMNode GetDocument()/*2636*/
        {
            JsValue ret;
            /*2637*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetDocument_2, out ret);
            /*2638*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2639*/
            return ret_result;
            /*2640*/
        }

        // gen! CefRefPtr<CefDOMNode> GetBody()
        /// <summary>
        /// Returns the BODY node of an HTML document.
        /// /*cef()*/
        /// </summary>
        /*2641*/

        public CefDOMNode GetBody()/*2642*/
        {
            JsValue ret;
            /*2643*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetBody_3, out ret);
            /*2644*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2645*/
            return ret_result;
            /*2646*/
        }

        // gen! CefRefPtr<CefDOMNode> GetHead()
        /// <summary>
        /// Returns the HEAD node of an HTML document.
        /// /*cef()*/
        /// </summary>
        /*2647*/

        public CefDOMNode GetHead()/*2648*/
        {
            JsValue ret;
            /*2649*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetHead_4, out ret);
            /*2650*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2651*/
            return ret_result;
            /*2652*/
        }

        // gen! CefString GetTitle()
        /// <summary>
        /// Returns the title of an HTML document.
        /// /*cef()*/
        /// </summary>
        /*2653*/

        public string GetTitle()/*2654*/
        {
            JsValue ret;
            /*2655*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetTitle_5, out ret);
            /*2656*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2657*/
            return ret_result;
            /*2658*/
        }

        // gen! CefRefPtr<CefDOMNode> GetElementById(const CefString& id)
        /// <summary>
        /// Returns the document element with the specified ID value.
        /// /*cef()*/
        /// </summary>
        /*2659*/

        public CefDOMNode GetElementById(string /*2660*/
        id
        )/*2661*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(id);
            /*2662*/
            ;
            /*2663*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMDocument_GetElementById_6, out ret, ref v1);
            /*2664*/
            var ret_result = new CefDOMNode(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2665*/
            ;
            /*2666*/
            return ret_result;
            /*2667*/
        }

        // gen! CefRefPtr<CefDOMNode> GetFocusedNode()
        /// <summary>
        /// Returns the node that currently has keyboard focus.
        /// /*cef()*/
        /// </summary>
        /*2668*/

        public CefDOMNode GetFocusedNode()/*2669*/
        {
            JsValue ret;
            /*2670*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetFocusedNode_7, out ret);
            /*2671*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2672*/
            return ret_result;
            /*2673*/
        }

        // gen! bool HasSelection()
        /// <summary>
        /// Returns true if a portion of the document is selected.
        /// /*cef()*/
        /// </summary>
        /*2674*/

        public bool HasSelection()/*2675*/
        {
            JsValue ret;
            /*2676*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_HasSelection_8, out ret);
            /*2677*/
            var ret_result = ret.I32 != 0;
            /*2678*/
            return ret_result;
            /*2679*/
        }

        // gen! int GetSelectionStartOffset()
        /// <summary>
        /// Returns the selection offset within the start node.
        /// /*cef()*/
        /// </summary>
        /*2680*/

        public int GetSelectionStartOffset()/*2681*/
        {
            JsValue ret;
            /*2682*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionStartOffset_9, out ret);
            /*2683*/
            var ret_result = ret.I32;
            /*2684*/
            return ret_result;
            /*2685*/
        }

        // gen! int GetSelectionEndOffset()
        /// <summary>
        /// Returns the selection offset within the end node.
        /// /*cef()*/
        /// </summary>
        /*2686*/

        public int GetSelectionEndOffset()/*2687*/
        {
            JsValue ret;
            /*2688*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionEndOffset_10, out ret);
            /*2689*/
            var ret_result = ret.I32;
            /*2690*/
            return ret_result;
            /*2691*/
        }

        // gen! CefString GetSelectionAsMarkup()
        /// <summary>
        /// Returns the contents of this selection as markup.
        /// /*cef()*/
        /// </summary>
        /*2692*/

        public string GetSelectionAsMarkup()/*2693*/
        {
            JsValue ret;
            /*2694*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionAsMarkup_11, out ret);
            /*2695*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2696*/
            return ret_result;
            /*2697*/
        }

        // gen! CefString GetSelectionAsText()
        /// <summary>
        /// Returns the contents of this selection as text.
        /// /*cef()*/
        /// </summary>
        /*2698*/

        public string GetSelectionAsText()/*2699*/
        {
            JsValue ret;
            /*2700*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionAsText_12, out ret);
            /*2701*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2702*/
            return ret_result;
            /*2703*/
        }

        // gen! CefString GetBaseURL()
        /// <summary>
        /// Returns the base URL for the document.
        /// /*cef()*/
        /// </summary>
        /*2704*/

        public string GetBaseURL()/*2705*/
        {
            JsValue ret;
            /*2706*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetBaseURL_13, out ret);
            /*2707*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2708*/
            return ret_result;
            /*2709*/
        }

        // gen! CefString GetCompleteURL(const CefString& partialURL)
        /// <summary>
        /// Returns a complete URL based on the document base URL and the specified
        /// partial URL.
        /// /*cef()*/
        /// </summary>
        /*2710*/

        public string GetCompleteURL(string /*2711*/
        partialURL
        )/*2712*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(partialURL);
            /*2713*/
            ;
            /*2714*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMDocument_GetCompleteURL_14, out ret, ref v1);
            /*2715*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2716*/
            ;
            /*2717*/
            return ret_result;
            /*2718*/
        }
        /*2719*/
    }


    // [virtual] class CefDOMNode
    /// <summary>
    /// Class used to represent a DOM node. The methods of this class should only be
    /// called on the render process main thread.
    /// /*(source=library)*/
    /// </summary>
    /*2858*/
    public struct CefDOMNode
    {
        /*2859*/
        const int _typeNAME = 12;
        /*2860*/
        const int CefDOMNode_Release_0 = (_typeNAME << 16) | 0;
        /*2861*/
        const int CefDOMNode_GetType_1 = (_typeNAME << 16) | 1;
        /*2862*/
        const int CefDOMNode_IsText_2 = (_typeNAME << 16) | 2;
        /*2863*/
        const int CefDOMNode_IsElement_3 = (_typeNAME << 16) | 3;
        /*2864*/
        const int CefDOMNode_IsEditable_4 = (_typeNAME << 16) | 4;
        /*2865*/
        const int CefDOMNode_IsFormControlElement_5 = (_typeNAME << 16) | 5;
        /*2866*/
        const int CefDOMNode_GetFormControlElementType_6 = (_typeNAME << 16) | 6;
        /*2867*/
        const int CefDOMNode_IsSame_7 = (_typeNAME << 16) | 7;
        /*2868*/
        const int CefDOMNode_GetName_8 = (_typeNAME << 16) | 8;
        /*2869*/
        const int CefDOMNode_GetValue_9 = (_typeNAME << 16) | 9;
        /*2870*/
        const int CefDOMNode_SetValue_10 = (_typeNAME << 16) | 10;
        /*2871*/
        const int CefDOMNode_GetAsMarkup_11 = (_typeNAME << 16) | 11;
        /*2872*/
        const int CefDOMNode_GetDocument_12 = (_typeNAME << 16) | 12;
        /*2873*/
        const int CefDOMNode_GetParent_13 = (_typeNAME << 16) | 13;
        /*2874*/
        const int CefDOMNode_GetPreviousSibling_14 = (_typeNAME << 16) | 14;
        /*2875*/
        const int CefDOMNode_GetNextSibling_15 = (_typeNAME << 16) | 15;
        /*2876*/
        const int CefDOMNode_HasChildren_16 = (_typeNAME << 16) | 16;
        /*2877*/
        const int CefDOMNode_GetFirstChild_17 = (_typeNAME << 16) | 17;
        /*2878*/
        const int CefDOMNode_GetLastChild_18 = (_typeNAME << 16) | 18;
        /*2879*/
        const int CefDOMNode_GetElementTagName_19 = (_typeNAME << 16) | 19;
        /*2880*/
        const int CefDOMNode_HasElementAttributes_20 = (_typeNAME << 16) | 20;
        /*2881*/
        const int CefDOMNode_HasElementAttribute_21 = (_typeNAME << 16) | 21;
        /*2882*/
        const int CefDOMNode_GetElementAttribute_22 = (_typeNAME << 16) | 22;
        /*2883*/
        const int CefDOMNode_GetElementAttributes_23 = (_typeNAME << 16) | 23;
        /*2884*/
        const int CefDOMNode_SetElementAttribute_24 = (_typeNAME << 16) | 24;
        /*2885*/
        const int CefDOMNode_GetElementInnerText_25 = (_typeNAME << 16) | 25;
        /*2886*/
        const int CefDOMNode_GetElementBounds_26 = (_typeNAME << 16) | 26;
        /*2887*/
        internal readonly IntPtr nativePtr;
        /*2888*/
        internal CefDOMNode(IntPtr nativePtr)
        {
            /*2889*/
            this.nativePtr = nativePtr;
            /*2890*/
        }
        /*2891*/
        public void Release()
        {
            /*2892*/
            JsValue ret;
            /*2893*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_Release_0, out ret);
            /*2894*/
        }

        // gen! Type GetType()
        /// <summary>
        /// CefDOMNode methods.
        /// </summary>
        /*2895*/

        public cef_dom_node_type_t _GetType()/*2896*/
        {
            JsValue ret;
            /*2897*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetType_1, out ret);
            /*2898*/
            var ret_result = (cef_dom_node_type_t)ret.I32;

            /*2899*/
            return ret_result;
            /*2900*/
        }

        // gen! bool IsText()
        /// <summary>
        /// Returns true if this is a text node.
        /// /*cef()*/
        /// </summary>
        /*2901*/

        public bool IsText()/*2902*/
        {
            JsValue ret;
            /*2903*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsText_2, out ret);
            /*2904*/
            var ret_result = ret.I32 != 0;
            /*2905*/
            return ret_result;
            /*2906*/
        }

        // gen! bool IsElement()
        /// <summary>
        /// Returns true if this is an element node.
        /// /*cef()*/
        /// </summary>
        /*2907*/

        public bool IsElement()/*2908*/
        {
            JsValue ret;
            /*2909*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsElement_3, out ret);
            /*2910*/
            var ret_result = ret.I32 != 0;
            /*2911*/
            return ret_result;
            /*2912*/
        }

        // gen! bool IsEditable()
        /// <summary>
        /// Returns true if this is an editable node.
        /// /*cef()*/
        /// </summary>
        /*2913*/

        public bool IsEditable()/*2914*/
        {
            JsValue ret;
            /*2915*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsEditable_4, out ret);
            /*2916*/
            var ret_result = ret.I32 != 0;
            /*2917*/
            return ret_result;
            /*2918*/
        }

        // gen! bool IsFormControlElement()
        /// <summary>
        /// Returns true if this is a form control element node.
        /// /*cef()*/
        /// </summary>
        /*2919*/

        public bool IsFormControlElement()/*2920*/
        {
            JsValue ret;
            /*2921*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsFormControlElement_5, out ret);
            /*2922*/
            var ret_result = ret.I32 != 0;
            /*2923*/
            return ret_result;
            /*2924*/
        }

        // gen! CefString GetFormControlElementType()
        /// <summary>
        /// Returns the type of this form control element node.
        /// /*cef()*/
        /// </summary>
        /*2925*/

        public string GetFormControlElementType()/*2926*/
        {
            JsValue ret;
            /*2927*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetFormControlElementType_6, out ret);
            /*2928*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2929*/
            return ret_result;
            /*2930*/
        }

        // gen! bool IsSame(CefRefPtr<CefDOMNode> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>
        /*2931*/

        public bool IsSame(CefDOMNode /*2932*/
        that
        )/*2933*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*2934*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_IsSame_7, out ret, ref v1);
            /*2935*/
            var ret_result = ret.I32 != 0;
            /*2936*/
            return ret_result;
            /*2937*/
        }

        // gen! CefString GetName()
        /// <summary>
        /// Returns the name of this node.
        /// /*cef()*/
        /// </summary>
        /*2938*/

        public string GetName()/*2939*/
        {
            JsValue ret;
            /*2940*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetName_8, out ret);
            /*2941*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2942*/
            return ret_result;
            /*2943*/
        }

        // gen! CefString GetValue()
        /// <summary>
        /// Returns the value of this node.
        /// /*cef()*/
        /// </summary>
        /*2944*/

        public string GetValue()/*2945*/
        {
            JsValue ret;
            /*2946*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetValue_9, out ret);
            /*2947*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2948*/
            return ret_result;
            /*2949*/
        }

        // gen! bool SetValue(const CefString& value)
        /// <summary>
        /// Set the value of this node. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*2950*/

        public bool SetValue(string /*2951*/
        value
        )/*2952*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*2953*/
            ;
            /*2954*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_SetValue_10, out ret, ref v1);
            /*2955*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2956*/
            ;
            /*2957*/
            return ret_result;
            /*2958*/
        }

        // gen! CefString GetAsMarkup()
        /// <summary>
        /// Returns the contents of this node as markup.
        /// /*cef()*/
        /// </summary>
        /*2959*/

        public string GetAsMarkup()/*2960*/
        {
            JsValue ret;
            /*2961*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetAsMarkup_11, out ret);
            /*2962*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2963*/
            return ret_result;
            /*2964*/
        }

        // gen! CefRefPtr<CefDOMDocument> GetDocument()
        /// <summary>
        /// Returns the document associated with this node.
        /// /*cef()*/
        /// </summary>
        /*2965*/

        public CefDOMDocument GetDocument()/*2966*/
        {
            JsValue ret;
            /*2967*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetDocument_12, out ret);
            /*2968*/
            var ret_result = new CefDOMDocument(ret.Ptr);
            /*2969*/
            return ret_result;
            /*2970*/
        }

        // gen! CefRefPtr<CefDOMNode> GetParent()
        /// <summary>
        /// Returns the parent node.
        /// /*cef()*/
        /// </summary>
        /*2971*/

        public CefDOMNode GetParent()/*2972*/
        {
            JsValue ret;
            /*2973*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetParent_13, out ret);
            /*2974*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2975*/
            return ret_result;
            /*2976*/
        }

        // gen! CefRefPtr<CefDOMNode> GetPreviousSibling()
        /// <summary>
        /// Returns the previous sibling node.
        /// /*cef()*/
        /// </summary>
        /*2977*/

        public CefDOMNode GetPreviousSibling()/*2978*/
        {
            JsValue ret;
            /*2979*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetPreviousSibling_14, out ret);
            /*2980*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2981*/
            return ret_result;
            /*2982*/
        }

        // gen! CefRefPtr<CefDOMNode> GetNextSibling()
        /// <summary>
        /// Returns the next sibling node.
        /// /*cef()*/
        /// </summary>
        /*2983*/

        public CefDOMNode GetNextSibling()/*2984*/
        {
            JsValue ret;
            /*2985*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetNextSibling_15, out ret);
            /*2986*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2987*/
            return ret_result;
            /*2988*/
        }

        // gen! bool HasChildren()
        /// <summary>
        /// Returns true if this node has child nodes.
        /// /*cef()*/
        /// </summary>
        /*2989*/

        public bool HasChildren()/*2990*/
        {
            JsValue ret;
            /*2991*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_HasChildren_16, out ret);
            /*2992*/
            var ret_result = ret.I32 != 0;
            /*2993*/
            return ret_result;
            /*2994*/
        }

        // gen! CefRefPtr<CefDOMNode> GetFirstChild()
        /// <summary>
        /// Return the first child node.
        /// /*cef()*/
        /// </summary>
        /*2995*/

        public CefDOMNode GetFirstChild()/*2996*/
        {
            JsValue ret;
            /*2997*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetFirstChild_17, out ret);
            /*2998*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2999*/
            return ret_result;
            /*3000*/
        }

        // gen! CefRefPtr<CefDOMNode> GetLastChild()
        /// <summary>
        /// Returns the last child node.
        /// /*cef()*/
        /// </summary>
        /*3001*/

        public CefDOMNode GetLastChild()/*3002*/
        {
            JsValue ret;
            /*3003*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetLastChild_18, out ret);
            /*3004*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*3005*/
            return ret_result;
            /*3006*/
        }

        // gen! CefString GetElementTagName()
        /// <summary>
        /// The following methods are valid only for element nodes.
        /// Returns the tag name of this element.
        /// /*cef()*/
        /// </summary>
        /*3007*/

        public string GetElementTagName()/*3008*/
        {
            JsValue ret;
            /*3009*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementTagName_19, out ret);
            /*3010*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3011*/
            return ret_result;
            /*3012*/
        }

        // gen! bool HasElementAttributes()
        /// <summary>
        /// Returns true if this element has attributes.
        /// /*cef()*/
        /// </summary>
        /*3013*/

        public bool HasElementAttributes()/*3014*/
        {
            JsValue ret;
            /*3015*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_HasElementAttributes_20, out ret);
            /*3016*/
            var ret_result = ret.I32 != 0;
            /*3017*/
            return ret_result;
            /*3018*/
        }

        // gen! bool HasElementAttribute(const CefString& attrName)
        /// <summary>
        /// Returns true if this element has an attribute named |attrName|.
        /// /*cef()*/
        /// </summary>
        /*3019*/

        public bool HasElementAttribute(string /*3020*/
        attrName
        )/*3021*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(attrName);
            /*3022*/
            ;
            /*3023*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_HasElementAttribute_21, out ret, ref v1);
            /*3024*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3025*/
            ;
            /*3026*/
            return ret_result;
            /*3027*/
        }

        // gen! CefString GetElementAttribute(const CefString& attrName)
        /// <summary>
        /// Returns the element attribute named |attrName|.
        /// /*cef()*/
        /// </summary>
        /*3028*/

        public string GetElementAttribute(string /*3029*/
        attrName
        )/*3030*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(attrName);
            /*3031*/
            ;
            /*3032*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_GetElementAttribute_22, out ret, ref v1);
            /*3033*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3034*/
            ;
            /*3035*/
            return ret_result;
            /*3036*/
        }

        // gen! void GetElementAttributes(AttributeMap& attrMap)
        /// <summary>
        /// Returns a map of all element attributes.
        /// /*cef()*/
        /// </summary>
        /*3037*/

        public void GetElementAttributes(AttributeMap /*3038*/
        attrMap
        )/*3039*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*3040*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_GetElementAttributes_23, out ret, ref v1);
            /*3041*/

            /*3042*/
        }

        // gen! bool SetElementAttribute(const CefString& attrName,const CefString& value)
        /// <summary>
        /// Set the value for the element attribute named |attrName|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*3043*/

        public bool SetElementAttribute(string /*3044*/
        attrName
        , string /*3045*/
        value
        )/*3046*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(attrName);
            /*3047*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*3048*/
            ;
            /*3049*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDOMNode_SetElementAttribute_24, out ret, ref v1, ref v2);
            /*3050*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3051*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*3052*/
            ;
            /*3053*/
            return ret_result;
            /*3054*/
        }

        // gen! CefString GetElementInnerText()
        /// <summary>
        /// Returns the inner text of the element.
        /// /*cef()*/
        /// </summary>
        /*3055*/

        public string GetElementInnerText()/*3056*/
        {
            JsValue ret;
            /*3057*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementInnerText_25, out ret);
            /*3058*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3059*/
            return ret_result;
            /*3060*/
        }

        // gen! CefRect GetElementBounds()
        /// <summary>
        /// Returns the bounds of the element.
        /// /*cef()*/
        /// </summary>
        /*3061*/

        public CefRect GetElementBounds()/*3062*/
        {
            JsValue ret;
            /*3063*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementBounds_26, out ret);
            /*3064*/
            var ret_result = new CefRect(ret.Ptr);

            /*3065*/
            return ret_result;
            /*3066*/
        }
        /*3067*/
    }


    // [virtual] class CefDownloadItem
    /// <summary>
    /// Class used to represent a download item.
    /// /*(source=library)*/
    /// </summary>
    /*3161*/
    public struct CefDownloadItem
    {
        /*3162*/
        const int _typeNAME = 13;
        /*3163*/
        const int CefDownloadItem_Release_0 = (_typeNAME << 16) | 0;
        /*3164*/
        const int CefDownloadItem_IsValid_1 = (_typeNAME << 16) | 1;
        /*3165*/
        const int CefDownloadItem_IsInProgress_2 = (_typeNAME << 16) | 2;
        /*3166*/
        const int CefDownloadItem_IsComplete_3 = (_typeNAME << 16) | 3;
        /*3167*/
        const int CefDownloadItem_IsCanceled_4 = (_typeNAME << 16) | 4;
        /*3168*/
        const int CefDownloadItem_GetCurrentSpeed_5 = (_typeNAME << 16) | 5;
        /*3169*/
        const int CefDownloadItem_GetPercentComplete_6 = (_typeNAME << 16) | 6;
        /*3170*/
        const int CefDownloadItem_GetTotalBytes_7 = (_typeNAME << 16) | 7;
        /*3171*/
        const int CefDownloadItem_GetReceivedBytes_8 = (_typeNAME << 16) | 8;
        /*3172*/
        const int CefDownloadItem_GetStartTime_9 = (_typeNAME << 16) | 9;
        /*3173*/
        const int CefDownloadItem_GetEndTime_10 = (_typeNAME << 16) | 10;
        /*3174*/
        const int CefDownloadItem_GetFullPath_11 = (_typeNAME << 16) | 11;
        /*3175*/
        const int CefDownloadItem_GetId_12 = (_typeNAME << 16) | 12;
        /*3176*/
        const int CefDownloadItem_GetURL_13 = (_typeNAME << 16) | 13;
        /*3177*/
        const int CefDownloadItem_GetOriginalUrl_14 = (_typeNAME << 16) | 14;
        /*3178*/
        const int CefDownloadItem_GetSuggestedFileName_15 = (_typeNAME << 16) | 15;
        /*3179*/
        const int CefDownloadItem_GetContentDisposition_16 = (_typeNAME << 16) | 16;
        /*3180*/
        const int CefDownloadItem_GetMimeType_17 = (_typeNAME << 16) | 17;
        /*3181*/
        internal readonly IntPtr nativePtr;
        /*3182*/
        internal CefDownloadItem(IntPtr nativePtr)
        {
            /*3183*/
            this.nativePtr = nativePtr;
            /*3184*/
        }
        /*3185*/
        public void Release()
        {
            /*3186*/
            JsValue ret;
            /*3187*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_Release_0, out ret);
            /*3188*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefDownloadItem methods.
        /// </summary>
        /*3189*/

        public bool IsValid()/*3190*/
        {
            JsValue ret;
            /*3191*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsValid_1, out ret);
            /*3192*/
            var ret_result = ret.I32 != 0;
            /*3193*/
            return ret_result;
            /*3194*/
        }

        // gen! bool IsInProgress()
        /// <summary>
        /// Returns true if the download is in progress.
        /// /*cef()*/
        /// </summary>
        /*3195*/

        public bool IsInProgress()/*3196*/
        {
            JsValue ret;
            /*3197*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsInProgress_2, out ret);
            /*3198*/
            var ret_result = ret.I32 != 0;
            /*3199*/
            return ret_result;
            /*3200*/
        }

        // gen! bool IsComplete()
        /// <summary>
        /// Returns true if the download is complete.
        /// /*cef()*/
        /// </summary>
        /*3201*/

        public bool IsComplete()/*3202*/
        {
            JsValue ret;
            /*3203*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsComplete_3, out ret);
            /*3204*/
            var ret_result = ret.I32 != 0;
            /*3205*/
            return ret_result;
            /*3206*/
        }

        // gen! bool IsCanceled()
        /// <summary>
        /// Returns true if the download has been canceled or interrupted.
        /// /*cef()*/
        /// </summary>
        /*3207*/

        public bool IsCanceled()/*3208*/
        {
            JsValue ret;
            /*3209*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsCanceled_4, out ret);
            /*3210*/
            var ret_result = ret.I32 != 0;
            /*3211*/
            return ret_result;
            /*3212*/
        }

        // gen! int64 GetCurrentSpeed()
        /// <summary>
        /// Returns a simple speed estimate in bytes/s.
        /// /*cef()*/
        /// </summary>
        /*3213*/

        public long GetCurrentSpeed()/*3214*/
        {
            JsValue ret;
            /*3215*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetCurrentSpeed_5, out ret);
            /*3216*/
            var ret_result = ret.I64;
            /*3217*/
            return ret_result;
            /*3218*/
        }

        // gen! int GetPercentComplete()
        /// <summary>
        /// Returns the rough percent complete or -1 if the receive total size is
        /// unknown.
        /// /*cef()*/
        /// </summary>
        /*3219*/

        public int GetPercentComplete()/*3220*/
        {
            JsValue ret;
            /*3221*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetPercentComplete_6, out ret);
            /*3222*/
            var ret_result = ret.I32;
            /*3223*/
            return ret_result;
            /*3224*/
        }

        // gen! int64 GetTotalBytes()
        /// <summary>
        /// Returns the total number of bytes.
        /// /*cef()*/
        /// </summary>
        /*3225*/

        public long GetTotalBytes()/*3226*/
        {
            JsValue ret;
            /*3227*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetTotalBytes_7, out ret);
            /*3228*/
            var ret_result = ret.I64;
            /*3229*/
            return ret_result;
            /*3230*/
        }

        // gen! int64 GetReceivedBytes()
        /// <summary>
        /// Returns the number of received bytes.
        /// /*cef()*/
        /// </summary>
        /*3231*/

        public long GetReceivedBytes()/*3232*/
        {
            JsValue ret;
            /*3233*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetReceivedBytes_8, out ret);
            /*3234*/
            var ret_result = ret.I64;
            /*3235*/
            return ret_result;
            /*3236*/
        }

        // gen! CefTime GetStartTime()
        /// <summary>
        /// Returns the time that the download started.
        /// /*cef()*/
        /// </summary>
        /*3237*/

        public CefTime GetStartTime()/*3238*/
        {
            JsValue ret;
            /*3239*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetStartTime_9, out ret);
            /*3240*/
            var ret_result = new CefTime(ret.Ptr);

            /*3241*/
            return ret_result;
            /*3242*/
        }

        // gen! CefTime GetEndTime()
        /// <summary>
        /// Returns the time that the download ended.
        /// /*cef()*/
        /// </summary>
        /*3243*/

        public CefTime GetEndTime()/*3244*/
        {
            JsValue ret;
            /*3245*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetEndTime_10, out ret);
            /*3246*/
            var ret_result = new CefTime(ret.Ptr);

            /*3247*/
            return ret_result;
            /*3248*/
        }

        // gen! CefString GetFullPath()
        /// <summary>
        /// Returns the full path to the downloaded or downloading file.
        /// /*cef()*/
        /// </summary>
        /*3249*/

        public string GetFullPath()/*3250*/
        {
            JsValue ret;
            /*3251*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetFullPath_11, out ret);
            /*3252*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3253*/
            return ret_result;
            /*3254*/
        }

        // gen! uint32 GetId()
        /// <summary>
        /// Returns the unique identifier for this download.
        /// /*cef()*/
        /// </summary>
        /*3255*/

        public uint GetId()/*3256*/
        {
            JsValue ret;
            /*3257*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetId_12, out ret);
            /*3258*/
            var ret_result = (uint)ret.I32;
            /*3259*/
            return ret_result;
            /*3260*/
        }

        // gen! CefString GetURL()
        /// <summary>
        /// Returns the URL.
        /// /*cef()*/
        /// </summary>
        /*3261*/

        public string GetURL()/*3262*/
        {
            JsValue ret;
            /*3263*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetURL_13, out ret);
            /*3264*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3265*/
            return ret_result;
            /*3266*/
        }

        // gen! CefString GetOriginalUrl()
        /// <summary>
        /// Returns the original URL before any redirections.
        /// /*cef()*/
        /// </summary>
        /*3267*/

        public string GetOriginalUrl()/*3268*/
        {
            JsValue ret;
            /*3269*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetOriginalUrl_14, out ret);
            /*3270*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3271*/
            return ret_result;
            /*3272*/
        }

        // gen! CefString GetSuggestedFileName()
        /// <summary>
        /// Returns the suggested file name.
        /// /*cef()*/
        /// </summary>
        /*3273*/

        public string GetSuggestedFileName()/*3274*/
        {
            JsValue ret;
            /*3275*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetSuggestedFileName_15, out ret);
            /*3276*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3277*/
            return ret_result;
            /*3278*/
        }

        // gen! CefString GetContentDisposition()
        /// <summary>
        /// Returns the content disposition.
        /// /*cef()*/
        /// </summary>
        /*3279*/

        public string GetContentDisposition()/*3280*/
        {
            JsValue ret;
            /*3281*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetContentDisposition_16, out ret);
            /*3282*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3283*/
            return ret_result;
            /*3284*/
        }

        // gen! CefString GetMimeType()
        /// <summary>
        /// Returns the mime type.
        /// /*cef()*/
        /// </summary>
        /*3285*/

        public string GetMimeType()/*3286*/
        {
            JsValue ret;
            /*3287*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetMimeType_17, out ret);
            /*3288*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3289*/
            return ret_result;
            /*3290*/
        }
        /*3291*/
    }


    // [virtual] class CefDragData
    /// <summary>
    /// Class used to represent drag data. The methods of this class may be called
    /// on any thread.
    /// /*(source=library)*/
    /// </summary>
    /*3425*/
    public struct CefDragData
    {
        /*3426*/
        const int _typeNAME = 14;
        /*3427*/
        const int CefDragData_Release_0 = (_typeNAME << 16) | 0;
        /*3428*/
        const int CefDragData_Clone_1 = (_typeNAME << 16) | 1;
        /*3429*/
        const int CefDragData_IsReadOnly_2 = (_typeNAME << 16) | 2;
        /*3430*/
        const int CefDragData_IsLink_3 = (_typeNAME << 16) | 3;
        /*3431*/
        const int CefDragData_IsFragment_4 = (_typeNAME << 16) | 4;
        /*3432*/
        const int CefDragData_IsFile_5 = (_typeNAME << 16) | 5;
        /*3433*/
        const int CefDragData_GetLinkURL_6 = (_typeNAME << 16) | 6;
        /*3434*/
        const int CefDragData_GetLinkTitle_7 = (_typeNAME << 16) | 7;
        /*3435*/
        const int CefDragData_GetLinkMetadata_8 = (_typeNAME << 16) | 8;
        /*3436*/
        const int CefDragData_GetFragmentText_9 = (_typeNAME << 16) | 9;
        /*3437*/
        const int CefDragData_GetFragmentHtml_10 = (_typeNAME << 16) | 10;
        /*3438*/
        const int CefDragData_GetFragmentBaseURL_11 = (_typeNAME << 16) | 11;
        /*3439*/
        const int CefDragData_GetFileName_12 = (_typeNAME << 16) | 12;
        /*3440*/
        const int CefDragData_GetFileContents_13 = (_typeNAME << 16) | 13;
        /*3441*/
        const int CefDragData_GetFileNames_14 = (_typeNAME << 16) | 14;
        /*3442*/
        const int CefDragData_SetLinkURL_15 = (_typeNAME << 16) | 15;
        /*3443*/
        const int CefDragData_SetLinkTitle_16 = (_typeNAME << 16) | 16;
        /*3444*/
        const int CefDragData_SetLinkMetadata_17 = (_typeNAME << 16) | 17;
        /*3445*/
        const int CefDragData_SetFragmentText_18 = (_typeNAME << 16) | 18;
        /*3446*/
        const int CefDragData_SetFragmentHtml_19 = (_typeNAME << 16) | 19;
        /*3447*/
        const int CefDragData_SetFragmentBaseURL_20 = (_typeNAME << 16) | 20;
        /*3448*/
        const int CefDragData_ResetFileContents_21 = (_typeNAME << 16) | 21;
        /*3449*/
        const int CefDragData_AddFile_22 = (_typeNAME << 16) | 22;
        /*3450*/
        const int CefDragData_GetImage_23 = (_typeNAME << 16) | 23;
        /*3451*/
        const int CefDragData_GetImageHotspot_24 = (_typeNAME << 16) | 24;
        /*3452*/
        const int CefDragData_HasImage_25 = (_typeNAME << 16) | 25;
        /*3453*/
        internal readonly IntPtr nativePtr;
        /*3454*/
        internal CefDragData(IntPtr nativePtr)
        {
            /*3455*/
            this.nativePtr = nativePtr;
            /*3456*/
        }
        /*3457*/
        public void Release()
        {
            /*3458*/
            JsValue ret;
            /*3459*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_Release_0, out ret);
            /*3460*/
        }

        // gen! CefRefPtr<CefDragData> Clone()
        /// <summary>
        /// CefDragData methods.
        /// </summary>
        /*3461*/

        public CefDragData Clone()/*3462*/
        {
            JsValue ret;
            /*3463*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_Clone_1, out ret);
            /*3464*/
            var ret_result = new CefDragData(ret.Ptr);
            /*3465*/
            return ret_result;
            /*3466*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if this object is read-only.
        /// /*cef()*/
        /// </summary>
        /*3467*/

        public bool IsReadOnly()/*3468*/
        {
            JsValue ret;
            /*3469*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsReadOnly_2, out ret);
            /*3470*/
            var ret_result = ret.I32 != 0;
            /*3471*/
            return ret_result;
            /*3472*/
        }

        // gen! bool IsLink()
        /// <summary>
        /// Returns true if the drag data is a link.
        /// /*cef()*/
        /// </summary>
        /*3473*/

        public bool IsLink()/*3474*/
        {
            JsValue ret;
            /*3475*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsLink_3, out ret);
            /*3476*/
            var ret_result = ret.I32 != 0;
            /*3477*/
            return ret_result;
            /*3478*/
        }

        // gen! bool IsFragment()
        /// <summary>
        /// Returns true if the drag data is a text or html fragment.
        /// /*cef()*/
        /// </summary>
        /*3479*/

        public bool IsFragment()/*3480*/
        {
            JsValue ret;
            /*3481*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsFragment_4, out ret);
            /*3482*/
            var ret_result = ret.I32 != 0;
            /*3483*/
            return ret_result;
            /*3484*/
        }

        // gen! bool IsFile()
        /// <summary>
        /// Returns true if the drag data is a file.
        /// /*cef()*/
        /// </summary>
        /*3485*/

        public bool IsFile()/*3486*/
        {
            JsValue ret;
            /*3487*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsFile_5, out ret);
            /*3488*/
            var ret_result = ret.I32 != 0;
            /*3489*/
            return ret_result;
            /*3490*/
        }

        // gen! CefString GetLinkURL()
        /// <summary>
        /// Return the link URL that is being dragged.
        /// /*cef()*/
        /// </summary>
        /*3491*/

        public string GetLinkURL()/*3492*/
        {
            JsValue ret;
            /*3493*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkURL_6, out ret);
            /*3494*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3495*/
            return ret_result;
            /*3496*/
        }

        // gen! CefString GetLinkTitle()
        /// <summary>
        /// Return the title associated with the link being dragged.
        /// /*cef()*/
        /// </summary>
        /*3497*/

        public string GetLinkTitle()/*3498*/
        {
            JsValue ret;
            /*3499*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkTitle_7, out ret);
            /*3500*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3501*/
            return ret_result;
            /*3502*/
        }

        // gen! CefString GetLinkMetadata()
        /// <summary>
        /// Return the metadata, if any, associated with the link being dragged.
        /// /*cef()*/
        /// </summary>
        /*3503*/

        public string GetLinkMetadata()/*3504*/
        {
            JsValue ret;
            /*3505*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkMetadata_8, out ret);
            /*3506*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3507*/
            return ret_result;
            /*3508*/
        }

        // gen! CefString GetFragmentText()
        /// <summary>
        /// Return the plain text fragment that is being dragged.
        /// /*cef()*/
        /// </summary>
        /*3509*/

        public string GetFragmentText()/*3510*/
        {
            JsValue ret;
            /*3511*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentText_9, out ret);
            /*3512*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3513*/
            return ret_result;
            /*3514*/
        }

        // gen! CefString GetFragmentHtml()
        /// <summary>
        /// Return the text/html fragment that is being dragged.
        /// /*cef()*/
        /// </summary>
        /*3515*/

        public string GetFragmentHtml()/*3516*/
        {
            JsValue ret;
            /*3517*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentHtml_10, out ret);
            /*3518*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3519*/
            return ret_result;
            /*3520*/
        }

        // gen! CefString GetFragmentBaseURL()
        /// <summary>
        /// Return the base URL that the fragment came from. This value is used for
        /// resolving relative URLs and may be empty.
        /// /*cef()*/
        /// </summary>
        /*3521*/

        public string GetFragmentBaseURL()/*3522*/
        {
            JsValue ret;
            /*3523*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentBaseURL_11, out ret);
            /*3524*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3525*/
            return ret_result;
            /*3526*/
        }

        // gen! CefString GetFileName()
        /// <summary>
        /// Return the name of the file being dragged out of the browser window.
        /// /*cef()*/
        /// </summary>
        /*3527*/

        public string GetFileName()/*3528*/
        {
            JsValue ret;
            /*3529*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFileName_12, out ret);
            /*3530*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3531*/
            return ret_result;
            /*3532*/
        }

        // gen! size_t GetFileContents(CefRefPtr<CefStreamWriter> writer)
        /// <summary>
        /// Write the contents of the file being dragged out of the web view into
        /// |writer|. Returns the number of bytes sent to |writer|. If |writer| is
        /// NULL this method will return the size of the file contents in bytes.
        /// Call GetFileName() to get a suggested name for the file.
        /// /*cef(optional_param=writer)*/
        /// </summary>
        /*3533*/

        public uint GetFileContents(CefStreamWriter /*3534*/
        writer
        )/*3535*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*3536*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_GetFileContents_13, out ret, ref v1);
            /*3537*/
            var ret_result = (uint)ret.I32;
            /*3538*/
            return ret_result;
            /*3539*/
        }

        // gen! bool GetFileNames(std::vector<CefString>& names)
        /// <summary>
        /// Retrieve the list of file names that are being dragged into the browser
        /// window.
        /// /*cef()*/
        /// </summary>
        /*3540*/

        public bool GetFileNames(List<string> /*3541*/
        names
        )/*3542*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*3543*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_GetFileNames_14, out ret, ref v1);
            /*3544*/
            var ret_result = ret.I32 != 0;
            /*3545*/
            return ret_result;
            /*3546*/
        }

        // gen! void SetLinkURL(const CefString& url)
        /// <summary>
        /// Set the link URL that is being dragged.
        /// /*cef(optional_param=url)*/
        /// </summary>
        /*3547*/

        public void SetLinkURL(string /*3548*/
        url
        )/*3549*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*3550*/
            ;
            /*3551*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkURL_15, out ret, ref v1);
            /*3552*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3553*/
            ;
            /*3554*/
        }

        // gen! void SetLinkTitle(const CefString& title)
        /// <summary>
        /// Set the title associated with the link being dragged.
        /// /*cef(optional_param=title)*/
        /// </summary>
        /*3555*/

        public void SetLinkTitle(string /*3556*/
        title
        )/*3557*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(title);
            /*3558*/
            ;
            /*3559*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkTitle_16, out ret, ref v1);
            /*3560*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3561*/
            ;
            /*3562*/
        }

        // gen! void SetLinkMetadata(const CefString& data)
        /// <summary>
        /// Set the metadata associated with the link being dragged.
        /// /*cef(optional_param=data)*/
        /// </summary>
        /*3563*/

        public void SetLinkMetadata(string /*3564*/
        data
        )/*3565*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(data);
            /*3566*/
            ;
            /*3567*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkMetadata_17, out ret, ref v1);
            /*3568*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3569*/
            ;
            /*3570*/
        }

        // gen! void SetFragmentText(const CefString& text)
        /// <summary>
        /// Set the plain text fragment that is being dragged.
        /// /*cef(optional_param=text)*/
        /// </summary>
        /*3571*/

        public void SetFragmentText(string /*3572*/
        text
        )/*3573*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(text);
            /*3574*/
            ;
            /*3575*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentText_18, out ret, ref v1);
            /*3576*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3577*/
            ;
            /*3578*/
        }

        // gen! void SetFragmentHtml(const CefString& html)
        /// <summary>
        /// Set the text/html fragment that is being dragged.
        /// /*cef(optional_param=html)*/
        /// </summary>
        /*3579*/

        public void SetFragmentHtml(string /*3580*/
        html
        )/*3581*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(html);
            /*3582*/
            ;
            /*3583*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentHtml_19, out ret, ref v1);
            /*3584*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3585*/
            ;
            /*3586*/
        }

        // gen! void SetFragmentBaseURL(const CefString& base_url)
        /// <summary>
        /// Set the base URL that the fragment came from.
        /// /*cef(optional_param=base_url)*/
        /// </summary>
        /*3587*/

        public void SetFragmentBaseURL(string /*3588*/
        base_url
        )/*3589*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(base_url);
            /*3590*/
            ;
            /*3591*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentBaseURL_20, out ret, ref v1);
            /*3592*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3593*/
            ;
            /*3594*/
        }

        // gen! void ResetFileContents()
        /// <summary>
        /// Reset the file contents. You should do this before calling
        /// CefBrowserHost::DragTargetDragEnter as the web view does not allow us to
        /// drag in this kind of data.
        /// /*cef()*/
        /// </summary>
        /*3595*/

        public void ResetFileContents()/*3596*/
        {
            JsValue ret;
            /*3597*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_ResetFileContents_21, out ret);
            /*3598*/

            /*3599*/
        }

        // gen! void AddFile(const CefString& path,const CefString& display_name)
        /// <summary>
        /// Add a file that is being dragged into the webview.
        /// /*cef(optional_param=display_name)*/
        /// </summary>
        /*3600*/

        public void AddFile(string /*3601*/
        path
        , string /*3602*/
        display_name
        )/*3603*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(path);
            /*3604*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(display_name);
            /*3605*/
            ;
            /*3606*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDragData_AddFile_22, out ret, ref v1, ref v2);
            /*3607*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3608*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*3609*/
            ;
            /*3610*/
        }

        // gen! CefRefPtr<CefImage> GetImage()
        /// <summary>
        /// Get the image representation of drag data. May return NULL if no image
        /// representation is available.
        /// /*cef()*/
        /// </summary>
        /*3611*/

        public CefImage GetImage()/*3612*/
        {
            JsValue ret;
            /*3613*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetImage_23, out ret);
            /*3614*/
            var ret_result = new CefImage(ret.Ptr);
            /*3615*/
            return ret_result;
            /*3616*/
        }

        // gen! CefPoint GetImageHotspot()
        /// <summary>
        /// Get the image hotspot (drag start location relative to image dimensions).
        /// /*cef()*/
        /// </summary>
        /*3617*/

        public CefPoint GetImageHotspot()/*3618*/
        {
            JsValue ret;
            /*3619*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetImageHotspot_24, out ret);
            /*3620*/
            var ret_result = new CefPoint(ret.Ptr);

            /*3621*/
            return ret_result;
            /*3622*/
        }

        // gen! bool HasImage()
        /// <summary>
        /// Returns true if an image representation of drag data is available.
        /// /*cef()*/
        /// </summary>
        /*3623*/

        public bool HasImage()/*3624*/
        {
            JsValue ret;
            /*3625*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_HasImage_25, out ret);
            /*3626*/
            var ret_result = ret.I32 != 0;
            /*3627*/
            return ret_result;
            /*3628*/
        }
        /*3629*/
    }


    // [virtual] class CefFrame
    /// <summary>
    /// Class used to represent a frame in the browser window. When used in the
    /// browser process the methods of this class may be called on any thread unless
    /// otherwise indicated in the comments. When used in the render process the
    /// methods of this class may only be called on the main thread.
    /// /*(source=library)*/
    /// </summary>
    /*3758*/
    public struct CefFrame
    {
        /*3759*/
        const int _typeNAME = 15;
        /*3760*/
        const int CefFrame_Release_0 = (_typeNAME << 16) | 0;
        /*3761*/
        const int CefFrame_IsValid_1 = (_typeNAME << 16) | 1;
        /*3762*/
        const int CefFrame_Undo_2 = (_typeNAME << 16) | 2;
        /*3763*/
        const int CefFrame_Redo_3 = (_typeNAME << 16) | 3;
        /*3764*/
        const int CefFrame_Cut_4 = (_typeNAME << 16) | 4;
        /*3765*/
        const int CefFrame_Copy_5 = (_typeNAME << 16) | 5;
        /*3766*/
        const int CefFrame_Paste_6 = (_typeNAME << 16) | 6;
        /*3767*/
        const int CefFrame_Delete_7 = (_typeNAME << 16) | 7;
        /*3768*/
        const int CefFrame_SelectAll_8 = (_typeNAME << 16) | 8;
        /*3769*/
        const int CefFrame_ViewSource_9 = (_typeNAME << 16) | 9;
        /*3770*/
        const int CefFrame_GetSource_10 = (_typeNAME << 16) | 10;
        /*3771*/
        const int CefFrame_GetText_11 = (_typeNAME << 16) | 11;
        /*3772*/
        const int CefFrame_LoadRequest_12 = (_typeNAME << 16) | 12;
        /*3773*/
        const int CefFrame_LoadURL_13 = (_typeNAME << 16) | 13;
        /*3774*/
        const int CefFrame_LoadString_14 = (_typeNAME << 16) | 14;
        /*3775*/
        const int CefFrame_ExecuteJavaScript_15 = (_typeNAME << 16) | 15;
        /*3776*/
        const int CefFrame_IsMain_16 = (_typeNAME << 16) | 16;
        /*3777*/
        const int CefFrame_IsFocused_17 = (_typeNAME << 16) | 17;
        /*3778*/
        const int CefFrame_GetName_18 = (_typeNAME << 16) | 18;
        /*3779*/
        const int CefFrame_GetIdentifier_19 = (_typeNAME << 16) | 19;
        /*3780*/
        const int CefFrame_GetParent_20 = (_typeNAME << 16) | 20;
        /*3781*/
        const int CefFrame_GetURL_21 = (_typeNAME << 16) | 21;
        /*3782*/
        const int CefFrame_GetBrowser_22 = (_typeNAME << 16) | 22;
        /*3783*/
        const int CefFrame_GetV8Context_23 = (_typeNAME << 16) | 23;
        /*3784*/
        const int CefFrame_VisitDOM_24 = (_typeNAME << 16) | 24;
        /*3785*/
        internal readonly IntPtr nativePtr;
        /*3786*/
        internal CefFrame(IntPtr nativePtr)
        {
            /*3787*/
            this.nativePtr = nativePtr;
            /*3788*/
        }
        /*3789*/
        public void Release()
        {
            /*3790*/
            JsValue ret;
            /*3791*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Release_0, out ret);
            /*3792*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefFrame methods.
        /// </summary>
        /*3793*/

        public bool IsValid()/*3794*/
        {
            JsValue ret;
            /*3795*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsValid_1, out ret);
            /*3796*/
            var ret_result = ret.I32 != 0;
            /*3797*/
            return ret_result;
            /*3798*/
        }

        // gen! void Undo()
        /// <summary>
        /// Execute undo in this frame.
        /// /*cef()*/
        /// </summary>
        /*3799*/

        public void Undo()/*3800*/
        {
            JsValue ret;
            /*3801*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Undo_2, out ret);
            /*3802*/

            /*3803*/
        }

        // gen! void Redo()
        /// <summary>
        /// Execute redo in this frame.
        /// /*cef()*/
        /// </summary>
        /*3804*/

        public void Redo()/*3805*/
        {
            JsValue ret;
            /*3806*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Redo_3, out ret);
            /*3807*/

            /*3808*/
        }

        // gen! void Cut()
        /// <summary>
        /// Execute cut in this frame.
        /// /*cef()*/
        /// </summary>
        /*3809*/

        public void Cut()/*3810*/
        {
            JsValue ret;
            /*3811*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Cut_4, out ret);
            /*3812*/

            /*3813*/
        }

        // gen! void Copy()
        /// <summary>
        /// Execute copy in this frame.
        /// /*cef()*/
        /// </summary>
        /*3814*/

        public void Copy()/*3815*/
        {
            JsValue ret;
            /*3816*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Copy_5, out ret);
            /*3817*/

            /*3818*/
        }

        // gen! void Paste()
        /// <summary>
        /// Execute paste in this frame.
        /// /*cef()*/
        /// </summary>
        /*3819*/

        public void Paste()/*3820*/
        {
            JsValue ret;
            /*3821*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Paste_6, out ret);
            /*3822*/

            /*3823*/
        }

        // gen! void Delete()
        /// <summary>
        /// Execute delete in this frame.
        /// /*cef(capi_name=del)*/
        /// </summary>
        /*3824*/

        public void Delete()/*3825*/
        {
            JsValue ret;
            /*3826*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Delete_7, out ret);
            /*3827*/

            /*3828*/
        }

        // gen! void SelectAll()
        /// <summary>
        /// Execute select all in this frame.
        /// /*cef()*/
        /// </summary>
        /*3829*/

        public void SelectAll()/*3830*/
        {
            JsValue ret;
            /*3831*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_SelectAll_8, out ret);
            /*3832*/

            /*3833*/
        }

        // gen! void ViewSource()
        /// <summary>
        /// Save this frame's HTML source to a temporary file and open it in the
        /// default text viewing application. This method can only be called from the
        /// browser process.
        /// /*cef()*/
        /// </summary>
        /*3834*/

        public void ViewSource()/*3835*/
        {
            JsValue ret;
            /*3836*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_ViewSource_9, out ret);
            /*3837*/

            /*3838*/
        }

        // gen! void GetSource(CefRefPtr<CefStringVisitor> visitor)
        /// <summary>
        /// Retrieve this frame's HTML source as a string sent to the specified
        /// visitor.
        /// /*cef()*/
        /// </summary>
        /*3839*/

        public void GetSource(CefStringVisitor /*3840*/
        visitor
        )/*3841*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*3842*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_GetSource_10, out ret, ref v1);
            /*3843*/

            /*3844*/
        }

        // gen! void GetText(CefRefPtr<CefStringVisitor> visitor)
        /// <summary>
        /// Retrieve this frame's display text as a string sent to the specified
        /// visitor.
        /// /*cef()*/
        /// </summary>
        /*3845*/

        public void GetText(CefStringVisitor /*3846*/
        visitor
        )/*3847*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*3848*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_GetText_11, out ret, ref v1);
            /*3849*/

            /*3850*/
        }

        // gen! void LoadRequest(CefRefPtr<CefRequest> request)
        /// <summary>
        /// Load the request represented by the |request| object.
        /// /*cef()*/
        /// </summary>
        /*3851*/

        public void LoadRequest(CefRequest /*3852*/
        request
        )/*3853*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*3854*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_LoadRequest_12, out ret, ref v1);
            /*3855*/

            /*3856*/
        }

        // gen! void LoadURL(const CefString& url)
        /// <summary>
        /// Load the specified |url|.
        /// /*cef()*/
        /// </summary>
        /*3857*/

        public void LoadURL(string /*3858*/
        url
        )/*3859*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*3860*/
            ;
            /*3861*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_LoadURL_13, out ret, ref v1);
            /*3862*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3863*/
            ;
            /*3864*/
        }

        // gen! void LoadString(const CefString& string_val,const CefString& url)
        /// <summary>
        /// Load the contents of |string_val| with the specified dummy |url|. |url|
        /// should have a standard scheme (for example, http scheme) or behaviors like
        /// link clicks and web security restrictions may not behave as expected.
        /// /*cef()*/
        /// </summary>
        /*3865*/

        public void LoadString(string /*3866*/
        string_val
        , string /*3867*/
        url
        )/*3868*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(string_val);
            /*3869*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*3870*/
            ;
            /*3871*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefFrame_LoadString_14, out ret, ref v1, ref v2);
            /*3872*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3873*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*3874*/
            ;
            /*3875*/
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
        /*3876*/

        public void ExecuteJavaScript(string /*3877*/
        code
        , string /*3878*/
        script_url
        , int /*3879*/
        start_line
        )/*3880*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(code);
            /*3881*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(script_url);
            /*3882*/
            ;
            /*3883*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefFrame_ExecuteJavaScript_15, out ret, ref v1, ref v2, ref v3);
            /*3884*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3885*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*3886*/
            ;
            /*3887*/
        }

        // gen! bool IsMain()
        /// <summary>
        /// Returns true if this is the main (top-level) frame.
        /// /*cef()*/
        /// </summary>
        /*3888*/

        public bool IsMain()/*3889*/
        {
            JsValue ret;
            /*3890*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsMain_16, out ret);
            /*3891*/
            var ret_result = ret.I32 != 0;
            /*3892*/
            return ret_result;
            /*3893*/
        }

        // gen! bool IsFocused()
        /// <summary>
        /// Returns true if this is the focused frame.
        /// /*cef()*/
        /// </summary>
        /*3894*/

        public bool IsFocused()/*3895*/
        {
            JsValue ret;
            /*3896*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsFocused_17, out ret);
            /*3897*/
            var ret_result = ret.I32 != 0;
            /*3898*/
            return ret_result;
            /*3899*/
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
        /*3900*/

        public string GetName()/*3901*/
        {
            JsValue ret;
            /*3902*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetName_18, out ret);
            /*3903*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3904*/
            return ret_result;
            /*3905*/
        }

        // gen! int64 GetIdentifier()
        /// <summary>
        /// Returns the globally unique identifier for this frame or < 0 if the
        /// underlying frame does not yet exist.
        /// /*cef()*/
        /// </summary>
        /*3906*/

        public long GetIdentifier()/*3907*/
        {
            JsValue ret;
            /*3908*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetIdentifier_19, out ret);
            /*3909*/
            var ret_result = ret.I64;
            /*3910*/
            return ret_result;
            /*3911*/
        }

        // gen! CefRefPtr<CefFrame> GetParent()
        /// <summary>
        /// Returns the parent of this frame or NULL if this is the main (top-level)
        /// frame.
        /// /*cef()*/
        /// </summary>
        /*3912*/

        public CefFrame GetParent()/*3913*/
        {
            JsValue ret;
            /*3914*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetParent_20, out ret);
            /*3915*/
            var ret_result = new CefFrame(ret.Ptr);
            /*3916*/
            return ret_result;
            /*3917*/
        }

        // gen! CefString GetURL()
        /// <summary>
        /// Returns the URL currently loaded in this frame.
        /// /*cef()*/
        /// </summary>
        /*3918*/

        public string GetURL()/*3919*/
        {
            JsValue ret;
            /*3920*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetURL_21, out ret);
            /*3921*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3922*/
            return ret_result;
            /*3923*/
        }

        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /// <summary>
        /// Returns the browser that this frame belongs to.
        /// /*cef()*/
        /// </summary>
        /*3924*/

        public CefBrowser GetBrowser()/*3925*/
        {
            JsValue ret;
            /*3926*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetBrowser_22, out ret);
            /*3927*/
            var ret_result = new CefBrowser(ret.Ptr);
            /*3928*/
            return ret_result;
            /*3929*/
        }

        // gen! CefRefPtr<CefV8Context> GetV8Context()
        /// <summary>
        /// Get the V8 context associated with the frame. This method can only be
        /// called from the render process.
        /// /*cef()*/
        /// </summary>
        /*3930*/

        public CefV8Context GetV8Context()/*3931*/
        {
            JsValue ret;
            /*3932*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetV8Context_23, out ret);
            /*3933*/
            var ret_result = new CefV8Context(ret.Ptr);
            /*3934*/
            return ret_result;
            /*3935*/
        }

        // gen! void VisitDOM(CefRefPtr<CefDOMVisitor> visitor)
        /// <summary>
        /// Visit the DOM document. This method can only be called from the render
        /// process.
        /// /*cef()*/
        /// </summary>
        /*3936*/

        public void VisitDOM(CefDOMVisitor /*3937*/
        visitor
        )/*3938*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*3939*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_VisitDOM_24, out ret, ref v1);
            /*3940*/

            /*3941*/
        }
        /*3942*/
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
    /*4016*/
    public struct CefImage
    {
        /*4017*/
        const int _typeNAME = 16;
        /*4018*/
        const int CefImage_Release_0 = (_typeNAME << 16) | 0;
        /*4019*/
        const int CefImage_IsEmpty_1 = (_typeNAME << 16) | 1;
        /*4020*/
        const int CefImage_IsSame_2 = (_typeNAME << 16) | 2;
        /*4021*/
        const int CefImage_AddBitmap_3 = (_typeNAME << 16) | 3;
        /*4022*/
        const int CefImage_AddPNG_4 = (_typeNAME << 16) | 4;
        /*4023*/
        const int CefImage_AddJPEG_5 = (_typeNAME << 16) | 5;
        /*4024*/
        const int CefImage_GetWidth_6 = (_typeNAME << 16) | 6;
        /*4025*/
        const int CefImage_GetHeight_7 = (_typeNAME << 16) | 7;
        /*4026*/
        const int CefImage_HasRepresentation_8 = (_typeNAME << 16) | 8;
        /*4027*/
        const int CefImage_RemoveRepresentation_9 = (_typeNAME << 16) | 9;
        /*4028*/
        const int CefImage_GetRepresentationInfo_10 = (_typeNAME << 16) | 10;
        /*4029*/
        const int CefImage_GetAsBitmap_11 = (_typeNAME << 16) | 11;
        /*4030*/
        const int CefImage_GetAsPNG_12 = (_typeNAME << 16) | 12;
        /*4031*/
        const int CefImage_GetAsJPEG_13 = (_typeNAME << 16) | 13;
        /*4032*/
        internal readonly IntPtr nativePtr;
        /*4033*/
        internal CefImage(IntPtr nativePtr)
        {
            /*4034*/
            this.nativePtr = nativePtr;
            /*4035*/
        }
        /*4036*/
        public void Release()
        {
            /*4037*/
            JsValue ret;
            /*4038*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_Release_0, out ret);
            /*4039*/
        }

        // gen! bool IsEmpty()
        /// <summary>
        /// CefImage methods.
        /// </summary>
        /*4040*/

        public bool IsEmpty()/*4041*/
        {
            JsValue ret;
            /*4042*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_IsEmpty_1, out ret);
            /*4043*/
            var ret_result = ret.I32 != 0;
            /*4044*/
            return ret_result;
            /*4045*/
        }

        // gen! bool IsSame(CefRefPtr<CefImage> that)
        /// <summary>
        /// Returns true if this Image and |that| Image share the same underlying
        /// storage. Will also return true if both images are empty.
        /// /*cef()*/
        /// </summary>
        /*4046*/

        public bool IsSame(CefImage /*4047*/
        that
        )/*4048*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4049*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_IsSame_2, out ret, ref v1);
            /*4050*/
            var ret_result = ret.I32 != 0;
            /*4051*/
            return ret_result;
            /*4052*/
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
        /*4053*/

        public bool AddBitmap(float /*4054*/
        scale_factor
        , int /*4055*/
        pixel_width
        , int /*4056*/
        pixel_height
        , cef_color_type_t /*4057*/
        color_type
        , cef_alpha_type_t /*4058*/
        alpha_type
        , IntPtr /*4059*/
        pixel_data
        , uint /*4060*/
        pixel_data_size
        )/*4061*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue v6 = new JsValue();
            JsValue v7 = new JsValue();
            JsValue ret;
            /*4062*/

            Cef3Binder.MyCefMet_Call7(this.nativePtr, CefImage_AddBitmap_3, out ret, ref v1, ref v2, ref v3, ref v4, ref v5, ref v6, ref v7);
            /*4063*/
            var ret_result = ret.I32 != 0;
            /*4064*/
            return ret_result;
            /*4065*/
        }

        // gen! bool AddPNG(float scale_factor,const void* png_data,size_t png_data_size)
        /// <summary>
        /// Add a PNG image representation for |scale_factor|. |png_data| is the image
        /// data of size |png_data_size|. Any alpha transparency in the PNG data will
        /// be maintained.
        /// /*cef()*/
        /// </summary>
        /*4066*/

        public bool AddPNG(float /*4067*/
        scale_factor
        , IntPtr /*4068*/
        png_data
        , uint /*4069*/
        png_data_size
        )/*4070*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*4071*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefImage_AddPNG_4, out ret, ref v1, ref v2, ref v3);
            /*4072*/
            var ret_result = ret.I32 != 0;
            /*4073*/
            return ret_result;
            /*4074*/
        }

        // gen! bool AddJPEG(float scale_factor,const void* jpeg_data,size_t jpeg_data_size)
        /// <summary>
        /// Create a JPEG image representation for |scale_factor|. |jpeg_data| is the
        /// image data of size |jpeg_data_size|. The JPEG format does not support
        /// transparency so the alpha byte will be set to 0xFF for all pixels.
        /// /*cef()*/
        /// </summary>
        /*4075*/

        public bool AddJPEG(float /*4076*/
        scale_factor
        , IntPtr /*4077*/
        jpeg_data
        , uint /*4078*/
        jpeg_data_size
        )/*4079*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*4080*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefImage_AddJPEG_5, out ret, ref v1, ref v2, ref v3);
            /*4081*/
            var ret_result = ret.I32 != 0;
            /*4082*/
            return ret_result;
            /*4083*/
        }

        // gen! size_t GetWidth()
        /// <summary>
        /// Returns the image width in density independent pixel (DIP) units.
        /// /*cef()*/
        /// </summary>
        /*4084*/

        public uint GetWidth()/*4085*/
        {
            JsValue ret;
            /*4086*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_GetWidth_6, out ret);
            /*4087*/
            var ret_result = (uint)ret.I32;
            /*4088*/
            return ret_result;
            /*4089*/
        }

        // gen! size_t GetHeight()
        /// <summary>
        /// Returns the image height in density independent pixel (DIP) units.
        /// /*cef()*/
        /// </summary>
        /*4090*/

        public uint GetHeight()/*4091*/
        {
            JsValue ret;
            /*4092*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_GetHeight_7, out ret);
            /*4093*/
            var ret_result = (uint)ret.I32;
            /*4094*/
            return ret_result;
            /*4095*/
        }

        // gen! bool HasRepresentation(float scale_factor)
        /// <summary>
        /// Returns true if this image contains a representation for |scale_factor|.
        /// /*cef()*/
        /// </summary>
        /*4096*/

        public bool HasRepresentation(float /*4097*/
        scale_factor
        )/*4098*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4099*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_HasRepresentation_8, out ret, ref v1);
            /*4100*/
            var ret_result = ret.I32 != 0;
            /*4101*/
            return ret_result;
            /*4102*/
        }

        // gen! bool RemoveRepresentation(float scale_factor)
        /// <summary>
        /// Removes the representation for |scale_factor|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4103*/

        public bool RemoveRepresentation(float /*4104*/
        scale_factor
        )/*4105*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4106*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_RemoveRepresentation_9, out ret, ref v1);
            /*4107*/
            var ret_result = ret.I32 != 0;
            /*4108*/
            return ret_result;
            /*4109*/
        }

        // gen! bool GetRepresentationInfo(float scale_factor,float& actual_scale_factor,int& pixel_width,int& pixel_height)
        /// <summary>
        /// Returns information for the representation that most closely matches
        /// |scale_factor|. |actual_scale_factor| is the actual scale factor for the
        /// representation. |pixel_width| and |pixel_height| are the representation
        /// size in pixel coordinates. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4110*/

        public bool GetRepresentationInfo(float /*4111*/
        scale_factor
        , ref float /*4112*/
        actual_scale_factor
        , ref int /*4113*/
        pixel_width
        , ref int /*4114*/
        pixel_height
        )/*4115*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            /*4116*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetRepresentationInfo_10, out ret, ref v1, ref v2, ref v3, ref v4);
            /*4117*/
            var ret_result = ret.I32 != 0;
            actual_scale_factor = (float)v2.Num;/*4118*/
            ;
            pixel_width = (int)v3.I32;/*4119*/
            ;
            pixel_height = (int)v4.I32;/*4120*/
            ;
            /*4121*/
            return ret_result;
            /*4122*/
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
        /*4123*/

        public CefBinaryValue GetAsBitmap(float /*4124*/
        scale_factor
        , cef_color_type_t /*4125*/
        color_type
        , cef_alpha_type_t /*4126*/
        alpha_type
        , ref int /*4127*/
        pixel_width
        , ref int /*4128*/
        pixel_height
        )/*4129*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            /*4130*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefImage_GetAsBitmap_11, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*4131*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            pixel_width = (int)v4.I32;/*4132*/
            ;
            pixel_height = (int)v5.I32;/*4133*/
            ;
            /*4134*/
            return ret_result;
            /*4135*/
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
        /*4136*/

        public CefBinaryValue GetAsPNG(float /*4137*/
        scale_factor
        , bool /*4138*/
        with_transparency
        , ref int /*4139*/
        pixel_width
        , ref int /*4140*/
        pixel_height
        )/*4141*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            /*4142*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetAsPNG_12, out ret, ref v1, ref v2, ref v3, ref v4);
            /*4143*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            pixel_width = (int)v3.I32;/*4144*/
            ;
            pixel_height = (int)v4.I32;/*4145*/
            ;
            /*4146*/
            return ret_result;
            /*4147*/
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
        /*4148*/

        public CefBinaryValue GetAsJPEG(float /*4149*/
        scale_factor
        , int /*4150*/
        quality
        , ref int /*4151*/
        pixel_width
        , ref int /*4152*/
        pixel_height
        )/*4153*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            /*4154*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetAsJPEG_13, out ret, ref v1, ref v2, ref v3, ref v4);
            /*4155*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            pixel_width = (int)v3.I32;/*4156*/
            ;
            pixel_height = (int)v4.I32;/*4157*/
            ;
            /*4158*/
            return ret_result;
            /*4159*/
        }
        /*4160*/
    }


    // [virtual] class CefMenuModel
    /// <summary>
    /// Supports creation and modification of menus. See cef_menu_id_t for the
    /// command ids that have default implementations. All user-defined command ids
    /// should be between MENU_ID_USER_FIRST and MENU_ID_USER_LAST. The methods of
    /// this class can only be accessed on the browser process the UI thread.
    /// /*(source=library)*/
    /// </summary>
    /*4449*/
    public struct CefMenuModel
    {
        /*4450*/
        const int _typeNAME = 17;
        /*4451*/
        const int CefMenuModel_Release_0 = (_typeNAME << 16) | 0;
        /*4452*/
        const int CefMenuModel_IsSubMenu_1 = (_typeNAME << 16) | 1;
        /*4453*/
        const int CefMenuModel_Clear_2 = (_typeNAME << 16) | 2;
        /*4454*/
        const int CefMenuModel_GetCount_3 = (_typeNAME << 16) | 3;
        /*4455*/
        const int CefMenuModel_AddSeparator_4 = (_typeNAME << 16) | 4;
        /*4456*/
        const int CefMenuModel_AddItem_5 = (_typeNAME << 16) | 5;
        /*4457*/
        const int CefMenuModel_AddCheckItem_6 = (_typeNAME << 16) | 6;
        /*4458*/
        const int CefMenuModel_AddRadioItem_7 = (_typeNAME << 16) | 7;
        /*4459*/
        const int CefMenuModel_AddSubMenu_8 = (_typeNAME << 16) | 8;
        /*4460*/
        const int CefMenuModel_InsertSeparatorAt_9 = (_typeNAME << 16) | 9;
        /*4461*/
        const int CefMenuModel_InsertItemAt_10 = (_typeNAME << 16) | 10;
        /*4462*/
        const int CefMenuModel_InsertCheckItemAt_11 = (_typeNAME << 16) | 11;
        /*4463*/
        const int CefMenuModel_InsertRadioItemAt_12 = (_typeNAME << 16) | 12;
        /*4464*/
        const int CefMenuModel_InsertSubMenuAt_13 = (_typeNAME << 16) | 13;
        /*4465*/
        const int CefMenuModel_Remove_14 = (_typeNAME << 16) | 14;
        /*4466*/
        const int CefMenuModel_RemoveAt_15 = (_typeNAME << 16) | 15;
        /*4467*/
        const int CefMenuModel_GetIndexOf_16 = (_typeNAME << 16) | 16;
        /*4468*/
        const int CefMenuModel_GetCommandIdAt_17 = (_typeNAME << 16) | 17;
        /*4469*/
        const int CefMenuModel_SetCommandIdAt_18 = (_typeNAME << 16) | 18;
        /*4470*/
        const int CefMenuModel_GetLabel_19 = (_typeNAME << 16) | 19;
        /*4471*/
        const int CefMenuModel_GetLabelAt_20 = (_typeNAME << 16) | 20;
        /*4472*/
        const int CefMenuModel_SetLabel_21 = (_typeNAME << 16) | 21;
        /*4473*/
        const int CefMenuModel_SetLabelAt_22 = (_typeNAME << 16) | 22;
        /*4474*/
        const int CefMenuModel_GetType_23 = (_typeNAME << 16) | 23;
        /*4475*/
        const int CefMenuModel_GetTypeAt_24 = (_typeNAME << 16) | 24;
        /*4476*/
        const int CefMenuModel_GetGroupId_25 = (_typeNAME << 16) | 25;
        /*4477*/
        const int CefMenuModel_GetGroupIdAt_26 = (_typeNAME << 16) | 26;
        /*4478*/
        const int CefMenuModel_SetGroupId_27 = (_typeNAME << 16) | 27;
        /*4479*/
        const int CefMenuModel_SetGroupIdAt_28 = (_typeNAME << 16) | 28;
        /*4480*/
        const int CefMenuModel_GetSubMenu_29 = (_typeNAME << 16) | 29;
        /*4481*/
        const int CefMenuModel_GetSubMenuAt_30 = (_typeNAME << 16) | 30;
        /*4482*/
        const int CefMenuModel_IsVisible_31 = (_typeNAME << 16) | 31;
        /*4483*/
        const int CefMenuModel_IsVisibleAt_32 = (_typeNAME << 16) | 32;
        /*4484*/
        const int CefMenuModel_SetVisible_33 = (_typeNAME << 16) | 33;
        /*4485*/
        const int CefMenuModel_SetVisibleAt_34 = (_typeNAME << 16) | 34;
        /*4486*/
        const int CefMenuModel_IsEnabled_35 = (_typeNAME << 16) | 35;
        /*4487*/
        const int CefMenuModel_IsEnabledAt_36 = (_typeNAME << 16) | 36;
        /*4488*/
        const int CefMenuModel_SetEnabled_37 = (_typeNAME << 16) | 37;
        /*4489*/
        const int CefMenuModel_SetEnabledAt_38 = (_typeNAME << 16) | 38;
        /*4490*/
        const int CefMenuModel_IsChecked_39 = (_typeNAME << 16) | 39;
        /*4491*/
        const int CefMenuModel_IsCheckedAt_40 = (_typeNAME << 16) | 40;
        /*4492*/
        const int CefMenuModel_SetChecked_41 = (_typeNAME << 16) | 41;
        /*4493*/
        const int CefMenuModel_SetCheckedAt_42 = (_typeNAME << 16) | 42;
        /*4494*/
        const int CefMenuModel_HasAccelerator_43 = (_typeNAME << 16) | 43;
        /*4495*/
        const int CefMenuModel_HasAcceleratorAt_44 = (_typeNAME << 16) | 44;
        /*4496*/
        const int CefMenuModel_SetAccelerator_45 = (_typeNAME << 16) | 45;
        /*4497*/
        const int CefMenuModel_SetAcceleratorAt_46 = (_typeNAME << 16) | 46;
        /*4498*/
        const int CefMenuModel_RemoveAccelerator_47 = (_typeNAME << 16) | 47;
        /*4499*/
        const int CefMenuModel_RemoveAcceleratorAt_48 = (_typeNAME << 16) | 48;
        /*4500*/
        const int CefMenuModel_GetAccelerator_49 = (_typeNAME << 16) | 49;
        /*4501*/
        const int CefMenuModel_GetAcceleratorAt_50 = (_typeNAME << 16) | 50;
        /*4502*/
        const int CefMenuModel_SetColor_51 = (_typeNAME << 16) | 51;
        /*4503*/
        const int CefMenuModel_SetColorAt_52 = (_typeNAME << 16) | 52;
        /*4504*/
        const int CefMenuModel_GetColor_53 = (_typeNAME << 16) | 53;
        /*4505*/
        const int CefMenuModel_GetColorAt_54 = (_typeNAME << 16) | 54;
        /*4506*/
        const int CefMenuModel_SetFontList_55 = (_typeNAME << 16) | 55;
        /*4507*/
        const int CefMenuModel_SetFontListAt_56 = (_typeNAME << 16) | 56;
        /*4508*/
        internal readonly IntPtr nativePtr;
        /*4509*/
        internal CefMenuModel(IntPtr nativePtr)
        {
            /*4510*/
            this.nativePtr = nativePtr;
            /*4511*/
        }
        /*4512*/
        public void Release()
        {
            /*4513*/
            JsValue ret;
            /*4514*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_Release_0, out ret);
            /*4515*/
        }

        // gen! bool IsSubMenu()
        /// <summary>
        /// CefMenuModel methods.
        /// </summary>
        /*4516*/

        public bool IsSubMenu()/*4517*/
        {
            JsValue ret;
            /*4518*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_IsSubMenu_1, out ret);
            /*4519*/
            var ret_result = ret.I32 != 0;
            /*4520*/
            return ret_result;
            /*4521*/
        }

        // gen! bool Clear()
        /// <summary>
        /// Clears the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4522*/

        public bool Clear()/*4523*/
        {
            JsValue ret;
            /*4524*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_Clear_2, out ret);
            /*4525*/
            var ret_result = ret.I32 != 0;
            /*4526*/
            return ret_result;
            /*4527*/
        }

        // gen! int GetCount()
        /// <summary>
        /// Returns the number of items in this menu.
        /// /*cef()*/
        /// </summary>
        /*4528*/

        public int GetCount()/*4529*/
        {
            JsValue ret;
            /*4530*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_GetCount_3, out ret);
            /*4531*/
            var ret_result = ret.I32;
            /*4532*/
            return ret_result;
            /*4533*/
        }

        // gen! bool AddSeparator()
        /// <summary>
        /// Add a separator to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4534*/

        public bool AddSeparator()/*4535*/
        {
            JsValue ret;
            /*4536*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_AddSeparator_4, out ret);
            /*4537*/
            var ret_result = ret.I32 != 0;
            /*4538*/
            return ret_result;
            /*4539*/
        }

        // gen! bool AddItem(int command_id,const CefString& label)
        /// <summary>
        /// Add an item to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4540*/

        public bool AddItem(int /*4541*/
        command_id
        , string /*4542*/
        label
        )/*4543*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4544*/
            ;
            /*4545*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddItem_5, out ret, ref v1, ref v2);
            /*4546*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4547*/
            ;
            /*4548*/
            return ret_result;
            /*4549*/
        }

        // gen! bool AddCheckItem(int command_id,const CefString& label)
        /// <summary>
        /// Add a check item to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4550*/

        public bool AddCheckItem(int /*4551*/
        command_id
        , string /*4552*/
        label
        )/*4553*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4554*/
            ;
            /*4555*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddCheckItem_6, out ret, ref v1, ref v2);
            /*4556*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4557*/
            ;
            /*4558*/
            return ret_result;
            /*4559*/
        }

        // gen! bool AddRadioItem(int command_id,const CefString& label,int group_id)
        /// <summary>
        /// Add a radio item to the menu. Only a single item with the specified
        /// |group_id| can be checked at a time. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4560*/

        public bool AddRadioItem(int /*4561*/
        command_id
        , string /*4562*/
        label
        , int /*4563*/
        group_id
        )/*4564*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4565*/
            ;
            /*4566*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_AddRadioItem_7, out ret, ref v1, ref v2, ref v3);
            /*4567*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4568*/
            ;
            /*4569*/
            return ret_result;
            /*4570*/
        }

        // gen! CefRefPtr<CefMenuModel> AddSubMenu(int command_id,const CefString& label)
        /// <summary>
        /// Add a sub-menu to the menu. The new sub-menu is returned.
        /// /*cef()*/
        /// </summary>
        /*4571*/

        public CefMenuModel AddSubMenu(int /*4572*/
        command_id
        , string /*4573*/
        label
        )/*4574*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4575*/
            ;
            /*4576*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddSubMenu_8, out ret, ref v1, ref v2);
            /*4577*/
            var ret_result = new CefMenuModel(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4578*/
            ;
            /*4579*/
            return ret_result;
            /*4580*/
        }

        // gen! bool InsertSeparatorAt(int index)
        /// <summary>
        /// Insert a separator in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4581*/

        public bool InsertSeparatorAt(int /*4582*/
        index
        )/*4583*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4584*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_InsertSeparatorAt_9, out ret, ref v1);
            /*4585*/
            var ret_result = ret.I32 != 0;
            /*4586*/
            return ret_result;
            /*4587*/
        }

        // gen! bool InsertItemAt(int index,int command_id,const CefString& label)
        /// <summary>
        /// Insert an item in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4588*/

        public bool InsertItemAt(int /*4589*/
        index
        , int /*4590*/
        command_id
        , string /*4591*/
        label
        )/*4592*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4593*/
            ;
            /*4594*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertItemAt_10, out ret, ref v1, ref v2, ref v3);
            /*4595*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*4596*/
            ;
            /*4597*/
            return ret_result;
            /*4598*/
        }

        // gen! bool InsertCheckItemAt(int index,int command_id,const CefString& label)
        /// <summary>
        /// Insert a check item in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4599*/

        public bool InsertCheckItemAt(int /*4600*/
        index
        , int /*4601*/
        command_id
        , string /*4602*/
        label
        )/*4603*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4604*/
            ;
            /*4605*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertCheckItemAt_11, out ret, ref v1, ref v2, ref v3);
            /*4606*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*4607*/
            ;
            /*4608*/
            return ret_result;
            /*4609*/
        }

        // gen! bool InsertRadioItemAt(int index,int command_id,const CefString& label,int group_id)
        /// <summary>
        /// Insert a radio item in the menu at the specified |index|. Only a single
        /// item with the specified |group_id| can be checked at a time. Returns true
        /// on success.
        /// /*cef()*/
        /// </summary>
        /*4610*/

        public bool InsertRadioItemAt(int /*4611*/
        index
        , int /*4612*/
        command_id
        , string /*4613*/
        label
        , int /*4614*/
        group_id
        )/*4615*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4616*/
            ;
            /*4617*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefMenuModel_InsertRadioItemAt_12, out ret, ref v1, ref v2, ref v3, ref v4);
            /*4618*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*4619*/
            ;
            /*4620*/
            return ret_result;
            /*4621*/
        }

        // gen! CefRefPtr<CefMenuModel> InsertSubMenuAt(int index,int command_id,const CefString& label)
        /// <summary>
        /// Insert a sub-menu in the menu at the specified |index|. The new sub-menu
        /// is returned.
        /// /*cef()*/
        /// </summary>
        /*4622*/

        public CefMenuModel InsertSubMenuAt(int /*4623*/
        index
        , int /*4624*/
        command_id
        , string /*4625*/
        label
        )/*4626*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4627*/
            ;
            /*4628*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertSubMenuAt_13, out ret, ref v1, ref v2, ref v3);
            /*4629*/
            var ret_result = new CefMenuModel(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*4630*/
            ;
            /*4631*/
            return ret_result;
            /*4632*/
        }

        // gen! bool Remove(int command_id)
        /// <summary>
        /// Removes the item with the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4633*/

        public bool Remove(int /*4634*/
        command_id
        )/*4635*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4636*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_Remove_14, out ret, ref v1);
            /*4637*/
            var ret_result = ret.I32 != 0;
            /*4638*/
            return ret_result;
            /*4639*/
        }

        // gen! bool RemoveAt(int index)
        /// <summary>
        /// Removes the item at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4640*/

        public bool RemoveAt(int /*4641*/
        index
        )/*4642*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4643*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAt_15, out ret, ref v1);
            /*4644*/
            var ret_result = ret.I32 != 0;
            /*4645*/
            return ret_result;
            /*4646*/
        }

        // gen! int GetIndexOf(int command_id)
        /// <summary>
        /// Returns the index associated with the specified |command_id| or -1 if not
        /// found due to the command id not existing in the menu.
        /// /*cef()*/
        /// </summary>
        /*4647*/

        public int GetIndexOf(int /*4648*/
        command_id
        )/*4649*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4650*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetIndexOf_16, out ret, ref v1);
            /*4651*/
            var ret_result = ret.I32;
            /*4652*/
            return ret_result;
            /*4653*/
        }

        // gen! int GetCommandIdAt(int index)
        /// <summary>
        /// Returns the command id at the specified |index| or -1 if not found due to
        /// invalid range or the index being a separator.
        /// /*cef()*/
        /// </summary>
        /*4654*/

        public int GetCommandIdAt(int /*4655*/
        index
        )/*4656*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4657*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetCommandIdAt_17, out ret, ref v1);
            /*4658*/
            var ret_result = ret.I32;
            /*4659*/
            return ret_result;
            /*4660*/
        }

        // gen! bool SetCommandIdAt(int index,int command_id)
        /// <summary>
        /// Sets the command id at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4661*/

        public bool SetCommandIdAt(int /*4662*/
        index
        , int /*4663*/
        command_id
        )/*4664*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*4665*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetCommandIdAt_18, out ret, ref v1, ref v2);
            /*4666*/
            var ret_result = ret.I32 != 0;
            /*4667*/
            return ret_result;
            /*4668*/
        }

        // gen! CefString GetLabel(int command_id)
        /// <summary>
        /// Returns the label for the specified |command_id| or empty if not found.
        /// /*cef()*/
        /// </summary>
        /*4669*/

        public string GetLabel(int /*4670*/
        command_id
        )/*4671*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4672*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetLabel_19, out ret, ref v1);
            /*4673*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*4674*/
            return ret_result;
            /*4675*/
        }

        // gen! CefString GetLabelAt(int index)
        /// <summary>
        /// Returns the label at the specified |index| or empty if not found due to
        /// invalid range or the index being a separator.
        /// /*cef()*/
        /// </summary>
        /*4676*/

        public string GetLabelAt(int /*4677*/
        index
        )/*4678*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4679*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetLabelAt_20, out ret, ref v1);
            /*4680*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*4681*/
            return ret_result;
            /*4682*/
        }

        // gen! bool SetLabel(int command_id,const CefString& label)
        /// <summary>
        /// Sets the label for the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4683*/

        public bool SetLabel(int /*4684*/
        command_id
        , string /*4685*/
        label
        )/*4686*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4687*/
            ;
            /*4688*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetLabel_21, out ret, ref v1, ref v2);
            /*4689*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4690*/
            ;
            /*4691*/
            return ret_result;
            /*4692*/
        }

        // gen! bool SetLabelAt(int index,const CefString& label)
        /// <summary>
        /// Set the label at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4693*/

        public bool SetLabelAt(int /*4694*/
        index
        , string /*4695*/
        label
        )/*4696*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4697*/
            ;
            /*4698*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetLabelAt_22, out ret, ref v1, ref v2);
            /*4699*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4700*/
            ;
            /*4701*/
            return ret_result;
            /*4702*/
        }

        // gen! MenuItemType GetType(int command_id)
        /// <summary>
        /// Returns the item type for the specified |command_id|.
        /// /*cef(default_retval=MENUITEMTYPE_NONE)*/
        /// </summary>
        /*4703*/

        public cef_menu_item_type_t _GetType(int /*4704*/
        command_id
        )/*4705*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4706*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetType_23, out ret, ref v1);
            /*4707*/
            var ret_result = (cef_menu_item_type_t)ret.I32;

            /*4708*/
            return ret_result;
            /*4709*/
        }

        // gen! MenuItemType GetTypeAt(int index)
        /// <summary>
        /// Returns the item type at the specified |index|.
        /// /*cef(default_retval=MENUITEMTYPE_NONE)*/
        /// </summary>
        /*4710*/

        public cef_menu_item_type_t GetTypeAt(int /*4711*/
        index
        )/*4712*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4713*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetTypeAt_24, out ret, ref v1);
            /*4714*/
            var ret_result = (cef_menu_item_type_t)ret.I32;

            /*4715*/
            return ret_result;
            /*4716*/
        }

        // gen! int GetGroupId(int command_id)
        /// <summary>
        /// Returns the group id for the specified |command_id| or -1 if invalid.
        /// /*cef()*/
        /// </summary>
        /*4717*/

        public int GetGroupId(int /*4718*/
        command_id
        )/*4719*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4720*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetGroupId_25, out ret, ref v1);
            /*4721*/
            var ret_result = ret.I32;
            /*4722*/
            return ret_result;
            /*4723*/
        }

        // gen! int GetGroupIdAt(int index)
        /// <summary>
        /// Returns the group id at the specified |index| or -1 if invalid.
        /// /*cef()*/
        /// </summary>
        /*4724*/

        public int GetGroupIdAt(int /*4725*/
        index
        )/*4726*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4727*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetGroupIdAt_26, out ret, ref v1);
            /*4728*/
            var ret_result = ret.I32;
            /*4729*/
            return ret_result;
            /*4730*/
        }

        // gen! bool SetGroupId(int command_id,int group_id)
        /// <summary>
        /// Sets the group id for the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4731*/

        public bool SetGroupId(int /*4732*/
        command_id
        , int /*4733*/
        group_id
        )/*4734*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*4735*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetGroupId_27, out ret, ref v1, ref v2);
            /*4736*/
            var ret_result = ret.I32 != 0;
            /*4737*/
            return ret_result;
            /*4738*/
        }

        // gen! bool SetGroupIdAt(int index,int group_id)
        /// <summary>
        /// Sets the group id at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4739*/

        public bool SetGroupIdAt(int /*4740*/
        index
        , int /*4741*/
        group_id
        )/*4742*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*4743*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetGroupIdAt_28, out ret, ref v1, ref v2);
            /*4744*/
            var ret_result = ret.I32 != 0;
            /*4745*/
            return ret_result;
            /*4746*/
        }

        // gen! CefRefPtr<CefMenuModel> GetSubMenu(int command_id)
        /// <summary>
        /// Returns the submenu for the specified |command_id| or empty if invalid.
        /// /*cef()*/
        /// </summary>
        /*4747*/

        public CefMenuModel GetSubMenu(int /*4748*/
        command_id
        )/*4749*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4750*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetSubMenu_29, out ret, ref v1);
            /*4751*/
            var ret_result = new CefMenuModel(ret.Ptr);
            /*4752*/
            return ret_result;
            /*4753*/
        }

        // gen! CefRefPtr<CefMenuModel> GetSubMenuAt(int index)
        /// <summary>
        /// Returns the submenu at the specified |index| or empty if invalid.
        /// /*cef()*/
        /// </summary>
        /*4754*/

        public CefMenuModel GetSubMenuAt(int /*4755*/
        index
        )/*4756*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4757*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetSubMenuAt_30, out ret, ref v1);
            /*4758*/
            var ret_result = new CefMenuModel(ret.Ptr);
            /*4759*/
            return ret_result;
            /*4760*/
        }

        // gen! bool IsVisible(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| is visible.
        /// /*cef()*/
        /// </summary>
        /*4761*/

        public bool IsVisible(int /*4762*/
        command_id
        )/*4763*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4764*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsVisible_31, out ret, ref v1);
            /*4765*/
            var ret_result = ret.I32 != 0;
            /*4766*/
            return ret_result;
            /*4767*/
        }

        // gen! bool IsVisibleAt(int index)
        /// <summary>
        /// Returns true if the specified |index| is visible.
        /// /*cef()*/
        /// </summary>
        /*4768*/

        public bool IsVisibleAt(int /*4769*/
        index
        )/*4770*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4771*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsVisibleAt_32, out ret, ref v1);
            /*4772*/
            var ret_result = ret.I32 != 0;
            /*4773*/
            return ret_result;
            /*4774*/
        }

        // gen! bool SetVisible(int command_id,bool visible)
        /// <summary>
        /// Change the visibility of the specified |command_id|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4775*/

        public bool SetVisible(int /*4776*/
        command_id
        , bool /*4777*/
        visible
        )/*4778*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*4779*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetVisible_33, out ret, ref v1, ref v2);
            /*4780*/
            var ret_result = ret.I32 != 0;
            /*4781*/
            return ret_result;
            /*4782*/
        }

        // gen! bool SetVisibleAt(int index,bool visible)
        /// <summary>
        /// Change the visibility at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4783*/

        public bool SetVisibleAt(int /*4784*/
        index
        , bool /*4785*/
        visible
        )/*4786*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*4787*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetVisibleAt_34, out ret, ref v1, ref v2);
            /*4788*/
            var ret_result = ret.I32 != 0;
            /*4789*/
            return ret_result;
            /*4790*/
        }

        // gen! bool IsEnabled(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| is enabled.
        /// /*cef()*/
        /// </summary>
        /*4791*/

        public bool IsEnabled(int /*4792*/
        command_id
        )/*4793*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4794*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsEnabled_35, out ret, ref v1);
            /*4795*/
            var ret_result = ret.I32 != 0;
            /*4796*/
            return ret_result;
            /*4797*/
        }

        // gen! bool IsEnabledAt(int index)
        /// <summary>
        /// Returns true if the specified |index| is enabled.
        /// /*cef()*/
        /// </summary>
        /*4798*/

        public bool IsEnabledAt(int /*4799*/
        index
        )/*4800*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4801*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsEnabledAt_36, out ret, ref v1);
            /*4802*/
            var ret_result = ret.I32 != 0;
            /*4803*/
            return ret_result;
            /*4804*/
        }

        // gen! bool SetEnabled(int command_id,bool enabled)
        /// <summary>
        /// Change the enabled status of the specified |command_id|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4805*/

        public bool SetEnabled(int /*4806*/
        command_id
        , bool /*4807*/
        enabled
        )/*4808*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*4809*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetEnabled_37, out ret, ref v1, ref v2);
            /*4810*/
            var ret_result = ret.I32 != 0;
            /*4811*/
            return ret_result;
            /*4812*/
        }

        // gen! bool SetEnabledAt(int index,bool enabled)
        /// <summary>
        /// Change the enabled status at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4813*/

        public bool SetEnabledAt(int /*4814*/
        index
        , bool /*4815*/
        enabled
        )/*4816*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*4817*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetEnabledAt_38, out ret, ref v1, ref v2);
            /*4818*/
            var ret_result = ret.I32 != 0;
            /*4819*/
            return ret_result;
            /*4820*/
        }

        // gen! bool IsChecked(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| is checked. Only applies to
        /// check and radio items.
        /// /*cef()*/
        /// </summary>
        /*4821*/

        public bool IsChecked(int /*4822*/
        command_id
        )/*4823*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4824*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsChecked_39, out ret, ref v1);
            /*4825*/
            var ret_result = ret.I32 != 0;
            /*4826*/
            return ret_result;
            /*4827*/
        }

        // gen! bool IsCheckedAt(int index)
        /// <summary>
        /// Returns true if the specified |index| is checked. Only applies to check
        /// and radio items.
        /// /*cef()*/
        /// </summary>
        /*4828*/

        public bool IsCheckedAt(int /*4829*/
        index
        )/*4830*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4831*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsCheckedAt_40, out ret, ref v1);
            /*4832*/
            var ret_result = ret.I32 != 0;
            /*4833*/
            return ret_result;
            /*4834*/
        }

        // gen! bool SetChecked(int command_id,bool checked)
        /// <summary>
        /// Check the specified |command_id|. Only applies to check and radio items.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4835*/

        public bool SetChecked(int /*4836*/
        command_id
        , bool /*4837*/
        _checked
        )/*4838*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*4839*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetChecked_41, out ret, ref v1, ref v2);
            /*4840*/
            var ret_result = ret.I32 != 0;
            /*4841*/
            return ret_result;
            /*4842*/
        }

        // gen! bool SetCheckedAt(int index,bool checked)
        /// <summary>
        /// Check the specified |index|. Only applies to check and radio items. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>
        /*4843*/

        public bool SetCheckedAt(int /*4844*/
        index
        , bool /*4845*/
        _checked
        )/*4846*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*4847*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetCheckedAt_42, out ret, ref v1, ref v2);
            /*4848*/
            var ret_result = ret.I32 != 0;
            /*4849*/
            return ret_result;
            /*4850*/
        }

        // gen! bool HasAccelerator(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| has a keyboard accelerator
        /// assigned.
        /// /*cef()*/
        /// </summary>
        /*4851*/

        public bool HasAccelerator(int /*4852*/
        command_id
        )/*4853*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4854*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_HasAccelerator_43, out ret, ref v1);
            /*4855*/
            var ret_result = ret.I32 != 0;
            /*4856*/
            return ret_result;
            /*4857*/
        }

        // gen! bool HasAcceleratorAt(int index)
        /// <summary>
        /// Returns true if the specified |index| has a keyboard accelerator assigned.
        /// /*cef()*/
        /// </summary>
        /*4858*/

        public bool HasAcceleratorAt(int /*4859*/
        index
        )/*4860*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4861*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_HasAcceleratorAt_44, out ret, ref v1);
            /*4862*/
            var ret_result = ret.I32 != 0;
            /*4863*/
            return ret_result;
            /*4864*/
        }

        // gen! bool SetAccelerator(int command_id,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
        /// <summary>
        /// Set the keyboard accelerator for the specified |command_id|. |key_code| can
        /// be any virtual key or character value. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4865*/

        public bool SetAccelerator(int /*4866*/
        command_id
        , int /*4867*/
        key_code
        , bool /*4868*/
        shift_pressed
        , bool /*4869*/
        ctrl_pressed
        , bool /*4870*/
        alt_pressed
        )/*4871*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            /*4872*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_SetAccelerator_45, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*4873*/
            var ret_result = ret.I32 != 0;
            /*4874*/
            return ret_result;
            /*4875*/
        }

        // gen! bool SetAcceleratorAt(int index,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
        /// <summary>
        /// Set the keyboard accelerator at the specified |index|. |key_code| can be
        /// any virtual key or character value. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4876*/

        public bool SetAcceleratorAt(int /*4877*/
        index
        , int /*4878*/
        key_code
        , bool /*4879*/
        shift_pressed
        , bool /*4880*/
        ctrl_pressed
        , bool /*4881*/
        alt_pressed
        )/*4882*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            /*4883*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_SetAcceleratorAt_46, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*4884*/
            var ret_result = ret.I32 != 0;
            /*4885*/
            return ret_result;
            /*4886*/
        }

        // gen! bool RemoveAccelerator(int command_id)
        /// <summary>
        /// Remove the keyboard accelerator for the specified |command_id|. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>
        /*4887*/

        public bool RemoveAccelerator(int /*4888*/
        command_id
        )/*4889*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4890*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAccelerator_47, out ret, ref v1);
            /*4891*/
            var ret_result = ret.I32 != 0;
            /*4892*/
            return ret_result;
            /*4893*/
        }

        // gen! bool RemoveAcceleratorAt(int index)
        /// <summary>
        /// Remove the keyboard accelerator at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4894*/

        public bool RemoveAcceleratorAt(int /*4895*/
        index
        )/*4896*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4897*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAcceleratorAt_48, out ret, ref v1);
            /*4898*/
            var ret_result = ret.I32 != 0;
            /*4899*/
            return ret_result;
            /*4900*/
        }

        // gen! bool GetAccelerator(int command_id,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
        /// <summary>
        /// Retrieves the keyboard accelerator for the specified |command_id|. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>
        /*4901*/

        public bool GetAccelerator(int /*4902*/
        command_id
        , ref int /*4903*/
        key_code
        , ref bool /*4904*/
        shift_pressed
        , ref bool /*4905*/
        ctrl_pressed
        , ref bool /*4906*/
        alt_pressed
        )/*4907*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            /*4908*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_GetAccelerator_49, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*4909*/
            var ret_result = ret.I32 != 0;
            key_code = (int)v2.I32;/*4910*/
            ;
            shift_pressed = v3.I32 != 0;/*4911*/
            ;
            ctrl_pressed = v4.I32 != 0;/*4912*/
            ;
            alt_pressed = v5.I32 != 0;/*4913*/
            ;
            /*4914*/
            return ret_result;
            /*4915*/
        }

        // gen! bool GetAcceleratorAt(int index,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
        /// <summary>
        /// Retrieves the keyboard accelerator for the specified |index|. Returns true
        /// on success.
        /// /*cef()*/
        /// </summary>
        /*4916*/

        public bool GetAcceleratorAt(int /*4917*/
        index
        , ref int /*4918*/
        key_code
        , ref bool /*4919*/
        shift_pressed
        , ref bool /*4920*/
        ctrl_pressed
        , ref bool /*4921*/
        alt_pressed
        )/*4922*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            /*4923*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_GetAcceleratorAt_50, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*4924*/
            var ret_result = ret.I32 != 0;
            key_code = (int)v2.I32;/*4925*/
            ;
            shift_pressed = v3.I32 != 0;/*4926*/
            ;
            ctrl_pressed = v4.I32 != 0;/*4927*/
            ;
            alt_pressed = v5.I32 != 0;/*4928*/
            ;
            /*4929*/
            return ret_result;
            /*4930*/
        }

        // gen! bool SetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t color)
        /// <summary>
        /// Set the explicit color for |command_id| and |color_type| to |color|.
        /// Specify a |color| value of 0 to remove the explicit color. If no explicit
        /// color or default color is set for |color_type| then the system color will
        /// be used. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4931*/

        public bool SetColor(int /*4932*/
        command_id
        , cef_menu_color_type_t /*4933*/
        color_type
        , IntPtr /*4934*/
        color
        )/*4935*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*4936*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_SetColor_51, out ret, ref v1, ref v2, ref v3);
            /*4937*/
            var ret_result = ret.I32 != 0;
            /*4938*/
            return ret_result;
            /*4939*/
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
        /*4940*/

        public bool SetColorAt(int /*4941*/
        index
        , cef_menu_color_type_t /*4942*/
        color_type
        , IntPtr /*4943*/
        color
        )/*4944*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*4945*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_SetColorAt_52, out ret, ref v1, ref v2, ref v3);
            /*4946*/
            var ret_result = ret.I32 != 0;
            /*4947*/
            return ret_result;
            /*4948*/
        }

        // gen! bool GetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t& color)
        /// <summary>
        /// Returns in |color| the color that was explicitly set for |command_id| and
        /// |color_type|. If a color was not set then 0 will be returned in |color|.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4949*/

        public bool GetColor(int /*4950*/
        command_id
        , cef_menu_color_type_t /*4951*/
        color_type
        , cef_color_t /*4952*/
        color
        )/*4953*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*4954*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_GetColor_53, out ret, ref v1, ref v2, ref v3);
            /*4955*/
            var ret_result = ret.I32 != 0;
            /*4956*/
            return ret_result;
            /*4957*/
        }

        // gen! bool GetColorAt(int index,cef_menu_color_type_t color_type,cef_color_t& color)
        /// <summary>
        /// Returns in |color| the color that was explicitly set for |command_id| and
        /// |color_type|. Specify an |index| value of -1 to return the default color
        /// in |color|. If a color was not set then 0 will be returned in |color|.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4958*/

        public bool GetColorAt(int /*4959*/
        index
        , cef_menu_color_type_t /*4960*/
        color_type
        , cef_color_t /*4961*/
        color
        )/*4962*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*4963*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_GetColorAt_54, out ret, ref v1, ref v2, ref v3);
            /*4964*/
            var ret_result = ret.I32 != 0;
            /*4965*/
            return ret_result;
            /*4966*/
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
        /*4967*/

        public bool SetFontList(int /*4968*/
        command_id
        , string /*4969*/
        font_list
        )/*4970*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(font_list);
            /*4971*/
            ;
            /*4972*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetFontList_55, out ret, ref v1, ref v2);
            /*4973*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4974*/
            ;
            /*4975*/
            return ret_result;
            /*4976*/
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
        /*4977*/

        public bool SetFontListAt(int /*4978*/
        index
        , string /*4979*/
        font_list
        )/*4980*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(font_list);
            /*4981*/
            ;
            /*4982*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetFontListAt_56, out ret, ref v1, ref v2);
            /*4983*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4984*/
            ;
            /*4985*/
            return ret_result;
            /*4986*/
        }
        /*4987*/
    }


    // [virtual] class CefMenuModelDelegate
    /// <summary>
    /// Implement this interface to handle menu model events. The methods of this
    /// class will be called on the browser process UI thread unless otherwise
    /// indicated.
    /// /*(source=client)*/
    /// </summary>
    /*4996*/
    public struct CefMenuModelDelegate
    {
        /*4997*/
        const int _typeNAME = 18;
        /*4998*/
        const int CefMenuModelDelegate_Release_0 = (_typeNAME << 16) | 0;
        /*4999*/
        internal readonly IntPtr nativePtr;
        /*5000*/
        internal CefMenuModelDelegate(IntPtr nativePtr)
        {
            /*5001*/
            this.nativePtr = nativePtr;
            /*5002*/
        }
        /*5003*/
        public void Release()
        {
            /*5004*/
            JsValue ret;
            /*5005*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModelDelegate_Release_0, out ret);
            /*5006*/
        }
        /*5007*/
    }


    // [virtual] class CefNavigationEntry
    /// <summary>
    /// Class used to represent an entry in navigation history.
    /// /*(source=library)*/
    /// </summary>
    /*5066*/
    public struct CefNavigationEntry
    {
        /*5067*/
        const int _typeNAME = 19;
        /*5068*/
        const int CefNavigationEntry_Release_0 = (_typeNAME << 16) | 0;
        /*5069*/
        const int CefNavigationEntry_IsValid_1 = (_typeNAME << 16) | 1;
        /*5070*/
        const int CefNavigationEntry_GetURL_2 = (_typeNAME << 16) | 2;
        /*5071*/
        const int CefNavigationEntry_GetDisplayURL_3 = (_typeNAME << 16) | 3;
        /*5072*/
        const int CefNavigationEntry_GetOriginalURL_4 = (_typeNAME << 16) | 4;
        /*5073*/
        const int CefNavigationEntry_GetTitle_5 = (_typeNAME << 16) | 5;
        /*5074*/
        const int CefNavigationEntry_GetTransitionType_6 = (_typeNAME << 16) | 6;
        /*5075*/
        const int CefNavigationEntry_HasPostData_7 = (_typeNAME << 16) | 7;
        /*5076*/
        const int CefNavigationEntry_GetCompletionTime_8 = (_typeNAME << 16) | 8;
        /*5077*/
        const int CefNavigationEntry_GetHttpStatusCode_9 = (_typeNAME << 16) | 9;
        /*5078*/
        const int CefNavigationEntry_GetSSLStatus_10 = (_typeNAME << 16) | 10;
        /*5079*/
        internal readonly IntPtr nativePtr;
        /*5080*/
        internal CefNavigationEntry(IntPtr nativePtr)
        {
            /*5081*/
            this.nativePtr = nativePtr;
            /*5082*/
        }
        /*5083*/
        public void Release()
        {
            /*5084*/
            JsValue ret;
            /*5085*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_Release_0, out ret);
            /*5086*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefNavigationEntry methods.
        /// </summary>
        /*5087*/

        public bool IsValid()/*5088*/
        {
            JsValue ret;
            /*5089*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_IsValid_1, out ret);
            /*5090*/
            var ret_result = ret.I32 != 0;
            /*5091*/
            return ret_result;
            /*5092*/
        }

        // gen! CefString GetURL()
        /// <summary>
        /// Returns the actual URL of the page. For some pages this may be data: URL or
        /// similar. Use GetDisplayURL() to return a display-friendly version.
        /// /*cef()*/
        /// </summary>
        /*5093*/

        public string GetURL()/*5094*/
        {
            JsValue ret;
            /*5095*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetURL_2, out ret);
            /*5096*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5097*/
            return ret_result;
            /*5098*/
        }

        // gen! CefString GetDisplayURL()
        /// <summary>
        /// Returns a display-friendly version of the URL.
        /// /*cef()*/
        /// </summary>
        /*5099*/

        public string GetDisplayURL()/*5100*/
        {
            JsValue ret;
            /*5101*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetDisplayURL_3, out ret);
            /*5102*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5103*/
            return ret_result;
            /*5104*/
        }

        // gen! CefString GetOriginalURL()
        /// <summary>
        /// Returns the original URL that was entered by the user before any redirects.
        /// /*cef()*/
        /// </summary>
        /*5105*/

        public string GetOriginalURL()/*5106*/
        {
            JsValue ret;
            /*5107*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetOriginalURL_4, out ret);
            /*5108*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5109*/
            return ret_result;
            /*5110*/
        }

        // gen! CefString GetTitle()
        /// <summary>
        /// Returns the title set by the page. This value may be empty.
        /// /*cef()*/
        /// </summary>
        /*5111*/

        public string GetTitle()/*5112*/
        {
            JsValue ret;
            /*5113*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetTitle_5, out ret);
            /*5114*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5115*/
            return ret_result;
            /*5116*/
        }

        // gen! TransitionType GetTransitionType()
        /// <summary>
        /// Returns the transition type which indicates what the user did to move to
        /// this page from the previous page.
        /// /*cef(default_retval=TT_EXPLICIT)*/
        /// </summary>
        /*5117*/

        public cef_transition_type_t GetTransitionType()/*5118*/
        {
            JsValue ret;
            /*5119*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetTransitionType_6, out ret);
            /*5120*/
            var ret_result = (cef_transition_type_t)ret.I32;

            /*5121*/
            return ret_result;
            /*5122*/
        }

        // gen! bool HasPostData()
        /// <summary>
        /// Returns true if this navigation includes post data.
        /// /*cef()*/
        /// </summary>
        /*5123*/

        public bool HasPostData()/*5124*/
        {
            JsValue ret;
            /*5125*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_HasPostData_7, out ret);
            /*5126*/
            var ret_result = ret.I32 != 0;
            /*5127*/
            return ret_result;
            /*5128*/
        }

        // gen! CefTime GetCompletionTime()
        /// <summary>
        /// Returns the time for the last known successful navigation completion. A
        /// navigation may be completed more than once if the page is reloaded. May be
        /// 0 if the navigation has not yet completed.
        /// /*cef()*/
        /// </summary>
        /*5129*/

        public CefTime GetCompletionTime()/*5130*/
        {
            JsValue ret;
            /*5131*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetCompletionTime_8, out ret);
            /*5132*/
            var ret_result = new CefTime(ret.Ptr);

            /*5133*/
            return ret_result;
            /*5134*/
        }

        // gen! int GetHttpStatusCode()
        /// <summary>
        /// Returns the HTTP status code for the last known successful navigation
        /// response. May be 0 if the response has not yet been received or if the
        /// navigation has not yet completed.
        /// /*cef()*/
        /// </summary>
        /*5135*/

        public int GetHttpStatusCode()/*5136*/
        {
            JsValue ret;
            /*5137*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetHttpStatusCode_9, out ret);
            /*5138*/
            var ret_result = ret.I32;
            /*5139*/
            return ret_result;
            /*5140*/
        }

        // gen! CefRefPtr<CefSSLStatus> GetSSLStatus()
        /// <summary>
        /// Returns the SSL information for this navigation entry.
        /// /*cef()*/
        /// </summary>
        /*5141*/

        public CefSSLStatus GetSSLStatus()/*5142*/
        {
            JsValue ret;
            /*5143*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetSSLStatus_10, out ret);
            /*5144*/
            var ret_result = new CefSSLStatus(ret.Ptr);
            /*5145*/
            return ret_result;
            /*5146*/
        }
        /*5147*/
    }


    // [virtual] class CefPrintSettings
    /// <summary>
    /// Class representing print settings.
    /// /*(source=library)*/
    /// </summary>
    /*5271*/
    public struct CefPrintSettings
    {
        /*5272*/
        const int _typeNAME = 20;
        /*5273*/
        const int CefPrintSettings_Release_0 = (_typeNAME << 16) | 0;
        /*5274*/
        const int CefPrintSettings_IsValid_1 = (_typeNAME << 16) | 1;
        /*5275*/
        const int CefPrintSettings_IsReadOnly_2 = (_typeNAME << 16) | 2;
        /*5276*/
        const int CefPrintSettings_Copy_3 = (_typeNAME << 16) | 3;
        /*5277*/
        const int CefPrintSettings_SetOrientation_4 = (_typeNAME << 16) | 4;
        /*5278*/
        const int CefPrintSettings_IsLandscape_5 = (_typeNAME << 16) | 5;
        /*5279*/
        const int CefPrintSettings_SetPrinterPrintableArea_6 = (_typeNAME << 16) | 6;
        /*5280*/
        const int CefPrintSettings_SetDeviceName_7 = (_typeNAME << 16) | 7;
        /*5281*/
        const int CefPrintSettings_GetDeviceName_8 = (_typeNAME << 16) | 8;
        /*5282*/
        const int CefPrintSettings_SetDPI_9 = (_typeNAME << 16) | 9;
        /*5283*/
        const int CefPrintSettings_GetDPI_10 = (_typeNAME << 16) | 10;
        /*5284*/
        const int CefPrintSettings_SetPageRanges_11 = (_typeNAME << 16) | 11;
        /*5285*/
        const int CefPrintSettings_GetPageRangesCount_12 = (_typeNAME << 16) | 12;
        /*5286*/
        const int CefPrintSettings_GetPageRanges_13 = (_typeNAME << 16) | 13;
        /*5287*/
        const int CefPrintSettings_SetSelectionOnly_14 = (_typeNAME << 16) | 14;
        /*5288*/
        const int CefPrintSettings_IsSelectionOnly_15 = (_typeNAME << 16) | 15;
        /*5289*/
        const int CefPrintSettings_SetCollate_16 = (_typeNAME << 16) | 16;
        /*5290*/
        const int CefPrintSettings_WillCollate_17 = (_typeNAME << 16) | 17;
        /*5291*/
        const int CefPrintSettings_SetColorModel_18 = (_typeNAME << 16) | 18;
        /*5292*/
        const int CefPrintSettings_GetColorModel_19 = (_typeNAME << 16) | 19;
        /*5293*/
        const int CefPrintSettings_SetCopies_20 = (_typeNAME << 16) | 20;
        /*5294*/
        const int CefPrintSettings_GetCopies_21 = (_typeNAME << 16) | 21;
        /*5295*/
        const int CefPrintSettings_SetDuplexMode_22 = (_typeNAME << 16) | 22;
        /*5296*/
        const int CefPrintSettings_GetDuplexMode_23 = (_typeNAME << 16) | 23;
        /*5297*/
        internal readonly IntPtr nativePtr;
        /*5298*/
        internal CefPrintSettings(IntPtr nativePtr)
        {
            /*5299*/
            this.nativePtr = nativePtr;
            /*5300*/
        }
        /*5301*/
        public void Release()
        {
            /*5302*/
            JsValue ret;
            /*5303*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_Release_0, out ret);
            /*5304*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefPrintSettings methods.
        /// </summary>
        /*5305*/

        public bool IsValid()/*5306*/
        {
            JsValue ret;
            /*5307*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsValid_1, out ret);
            /*5308*/
            var ret_result = ret.I32 != 0;
            /*5309*/
            return ret_result;
            /*5310*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*5311*/

        public bool IsReadOnly()/*5312*/
        {
            JsValue ret;
            /*5313*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsReadOnly_2, out ret);
            /*5314*/
            var ret_result = ret.I32 != 0;
            /*5315*/
            return ret_result;
            /*5316*/
        }

        // gen! CefRefPtr<CefPrintSettings> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>
        /*5317*/

        public CefPrintSettings Copy()/*5318*/
        {
            JsValue ret;
            /*5319*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_Copy_3, out ret);
            /*5320*/
            var ret_result = new CefPrintSettings(ret.Ptr);
            /*5321*/
            return ret_result;
            /*5322*/
        }

        // gen! void SetOrientation(bool landscape)
        /// <summary>
        /// Set the page orientation.
        /// /*cef()*/
        /// </summary>
        /*5323*/

        public void SetOrientation(bool /*5324*/
        landscape
        )/*5325*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5326*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetOrientation_4, out ret, ref v1);
            /*5327*/

            /*5328*/
        }

        // gen! bool IsLandscape()
        /// <summary>
        /// Returns true if the orientation is landscape.
        /// /*cef()*/
        /// </summary>
        /*5329*/

        public bool IsLandscape()/*5330*/
        {
            JsValue ret;
            /*5331*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsLandscape_5, out ret);
            /*5332*/
            var ret_result = ret.I32 != 0;
            /*5333*/
            return ret_result;
            /*5334*/
        }

        // gen! void SetPrinterPrintableArea(const CefSize& physical_size_device_units,const CefRect& printable_area_device_units,bool landscape_needs_flip)
        /// <summary>
        /// Set the printer printable area in device units.
        /// Some platforms already provide flipped area. Set |landscape_needs_flip|
        /// to false on those platforms to avoid double flipping.
        /// /*cef()*/
        /// </summary>
        /*5335*/

        public void SetPrinterPrintableArea(CefSize /*5336*/
        physical_size_device_units
        , CefRect /*5337*/
        printable_area_device_units
        , bool /*5338*/
        landscape_needs_flip
        )/*5339*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*5340*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefPrintSettings_SetPrinterPrintableArea_6, out ret, ref v1, ref v2, ref v3);
            /*5341*/

            /*5342*/
        }

        // gen! void SetDeviceName(const CefString& name)
        /// <summary>
        /// Set the device name.
        /// /*cef(optional_param=name)*/
        /// </summary>
        /*5343*/

        public void SetDeviceName(string /*5344*/
        name
        )/*5345*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*5346*/
            ;
            /*5347*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDeviceName_7, out ret, ref v1);
            /*5348*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*5349*/
            ;
            /*5350*/
        }

        // gen! CefString GetDeviceName()
        /// <summary>
        /// Get the device name.
        /// /*cef()*/
        /// </summary>
        /*5351*/

        public string GetDeviceName()/*5352*/
        {
            JsValue ret;
            /*5353*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDeviceName_8, out ret);
            /*5354*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5355*/
            return ret_result;
            /*5356*/
        }

        // gen! void SetDPI(int dpi)
        /// <summary>
        /// Set the DPI (dots per inch).
        /// /*cef()*/
        /// </summary>
        /*5357*/

        public void SetDPI(int /*5358*/
        dpi
        )/*5359*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5360*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDPI_9, out ret, ref v1);
            /*5361*/

            /*5362*/
        }

        // gen! int GetDPI()
        /// <summary>
        /// Get the DPI (dots per inch).
        /// /*cef()*/
        /// </summary>
        /*5363*/

        public int GetDPI()/*5364*/
        {
            JsValue ret;
            /*5365*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDPI_10, out ret);
            /*5366*/
            var ret_result = ret.I32;
            /*5367*/
            return ret_result;
            /*5368*/
        }

        // gen! void SetPageRanges(const PageRangeList& ranges)
        /// <summary>
        /// Set the page ranges.
        /// /*cef()*/
        /// </summary>
        /*5369*/

        public void SetPageRanges(PageRangeList /*5370*/
        ranges
        )/*5371*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5372*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetPageRanges_11, out ret, ref v1);
            /*5373*/

            /*5374*/
        }

        // gen! size_t GetPageRangesCount()
        /// <summary>
        /// Returns the number of page ranges that currently exist.
        /// /*cef()*/
        /// </summary>
        /*5375*/

        public uint GetPageRangesCount()/*5376*/
        {
            JsValue ret;
            /*5377*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetPageRangesCount_12, out ret);
            /*5378*/
            var ret_result = (uint)ret.I32;
            /*5379*/
            return ret_result;
            /*5380*/
        }

        // gen! void GetPageRanges(PageRangeList& ranges)
        /// <summary>
        /// Retrieve the page ranges.
        /// /*cef(count_func=ranges:GetPageRangesCount)*/
        /// </summary>
        /*5381*/

        public void GetPageRanges(PageRangeList /*5382*/
        ranges
        )/*5383*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5384*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_GetPageRanges_13, out ret, ref v1);
            /*5385*/

            /*5386*/
        }

        // gen! void SetSelectionOnly(bool selection_only)
        /// <summary>
        /// Set whether only the selection will be printed.
        /// /*cef()*/
        /// </summary>
        /*5387*/

        public void SetSelectionOnly(bool /*5388*/
        selection_only
        )/*5389*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5390*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetSelectionOnly_14, out ret, ref v1);
            /*5391*/

            /*5392*/
        }

        // gen! bool IsSelectionOnly()
        /// <summary>
        /// Returns true if only the selection will be printed.
        /// /*cef()*/
        /// </summary>
        /*5393*/

        public bool IsSelectionOnly()/*5394*/
        {
            JsValue ret;
            /*5395*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsSelectionOnly_15, out ret);
            /*5396*/
            var ret_result = ret.I32 != 0;
            /*5397*/
            return ret_result;
            /*5398*/
        }

        // gen! void SetCollate(bool collate)
        /// <summary>
        /// Set whether pages will be collated.
        /// /*cef()*/
        /// </summary>
        /*5399*/

        public void SetCollate(bool /*5400*/
        collate
        )/*5401*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5402*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetCollate_16, out ret, ref v1);
            /*5403*/

            /*5404*/
        }

        // gen! bool WillCollate()
        /// <summary>
        /// Returns true if pages will be collated.
        /// /*cef()*/
        /// </summary>
        /*5405*/

        public bool WillCollate()/*5406*/
        {
            JsValue ret;
            /*5407*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_WillCollate_17, out ret);
            /*5408*/
            var ret_result = ret.I32 != 0;
            /*5409*/
            return ret_result;
            /*5410*/
        }

        // gen! void SetColorModel(ColorModel model)
        /// <summary>
        /// Set the color model.
        /// /*cef()*/
        /// </summary>
        /*5411*/

        public void SetColorModel(cef_color_model_t /*5412*/
        model
        )/*5413*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5414*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetColorModel_18, out ret, ref v1);
            /*5415*/

            /*5416*/
        }

        // gen! ColorModel GetColorModel()
        /// <summary>
        /// Get the color model.
        /// /*cef(default_retval=COLOR_MODEL_UNKNOWN)*/
        /// </summary>
        /*5417*/

        public cef_color_model_t GetColorModel()/*5418*/
        {
            JsValue ret;
            /*5419*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetColorModel_19, out ret);
            /*5420*/
            var ret_result = (cef_color_model_t)ret.I32;

            /*5421*/
            return ret_result;
            /*5422*/
        }

        // gen! void SetCopies(int copies)
        /// <summary>
        /// Set the number of copies.
        /// /*cef()*/
        /// </summary>
        /*5423*/

        public void SetCopies(int /*5424*/
        copies
        )/*5425*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5426*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetCopies_20, out ret, ref v1);
            /*5427*/

            /*5428*/
        }

        // gen! int GetCopies()
        /// <summary>
        /// Get the number of copies.
        /// /*cef()*/
        /// </summary>
        /*5429*/

        public int GetCopies()/*5430*/
        {
            JsValue ret;
            /*5431*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetCopies_21, out ret);
            /*5432*/
            var ret_result = ret.I32;
            /*5433*/
            return ret_result;
            /*5434*/
        }

        // gen! void SetDuplexMode(DuplexMode mode)
        /// <summary>
        /// Set the duplex mode.
        /// /*cef()*/
        /// </summary>
        /*5435*/

        public void SetDuplexMode(cef_duplex_mode_t /*5436*/
        mode
        )/*5437*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5438*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDuplexMode_22, out ret, ref v1);
            /*5439*/

            /*5440*/
        }

        // gen! DuplexMode GetDuplexMode()
        /// <summary>
        /// Get the duplex mode.
        /// /*cef(default_retval=DUPLEX_MODE_UNKNOWN)*/
        /// </summary>
        /*5441*/

        public cef_duplex_mode_t GetDuplexMode()/*5442*/
        {
            JsValue ret;
            /*5443*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDuplexMode_23, out ret);
            /*5444*/
            var ret_result = (cef_duplex_mode_t)ret.I32;

            /*5445*/
            return ret_result;
            /*5446*/
        }
        /*5447*/
    }


    // [virtual] class CefProcessMessage
    /// <summary>
    /// Class representing a message. Can be used on any process and thread.
    /// /*cef(source=library)*/
    /// </summary>
    /*5481*/
    public struct CefProcessMessage
    {
        /*5482*/
        const int _typeNAME = 21;
        /*5483*/
        const int CefProcessMessage_Release_0 = (_typeNAME << 16) | 0;
        /*5484*/
        const int CefProcessMessage_IsValid_1 = (_typeNAME << 16) | 1;
        /*5485*/
        const int CefProcessMessage_IsReadOnly_2 = (_typeNAME << 16) | 2;
        /*5486*/
        const int CefProcessMessage_Copy_3 = (_typeNAME << 16) | 3;
        /*5487*/
        const int CefProcessMessage_GetName_4 = (_typeNAME << 16) | 4;
        /*5488*/
        const int CefProcessMessage_GetArgumentList_5 = (_typeNAME << 16) | 5;
        /*5489*/
        internal readonly IntPtr nativePtr;
        /*5490*/
        internal CefProcessMessage(IntPtr nativePtr)
        {
            /*5491*/
            this.nativePtr = nativePtr;
            /*5492*/
        }
        /*5493*/
        public void Release()
        {
            /*5494*/
            JsValue ret;
            /*5495*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_Release_0, out ret);
            /*5496*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefProcessMessage methods.
        /// </summary>
        /*5497*/

        public bool IsValid()/*5498*/
        {
            JsValue ret;
            /*5499*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_IsValid_1, out ret);
            /*5500*/
            var ret_result = ret.I32 != 0;
            /*5501*/
            return ret_result;
            /*5502*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*5503*/

        public bool IsReadOnly()/*5504*/
        {
            JsValue ret;
            /*5505*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_IsReadOnly_2, out ret);
            /*5506*/
            var ret_result = ret.I32 != 0;
            /*5507*/
            return ret_result;
            /*5508*/
        }

        // gen! CefRefPtr<CefProcessMessage> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>
        /*5509*/

        public CefProcessMessage Copy()/*5510*/
        {
            JsValue ret;
            /*5511*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_Copy_3, out ret);
            /*5512*/
            var ret_result = new CefProcessMessage(ret.Ptr);
            /*5513*/
            return ret_result;
            /*5514*/
        }

        // gen! CefString GetName()
        /// <summary>
        /// Returns the message name.
        /// /*cef()*/
        /// </summary>
        /*5515*/

        public string GetName()/*5516*/
        {
            JsValue ret;
            /*5517*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_GetName_4, out ret);
            /*5518*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5519*/
            return ret_result;
            /*5520*/
        }

        // gen! CefRefPtr<CefListValue> GetArgumentList()
        /// <summary>
        /// Returns the list of arguments.
        /// /*cef()*/
        /// </summary>
        /*5521*/

        public CefListValue GetArgumentList()/*5522*/
        {
            JsValue ret;
            /*5523*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_GetArgumentList_5, out ret);
            /*5524*/
            var ret_result = new CefListValue(ret.Ptr);
            /*5525*/
            return ret_result;
            /*5526*/
        }
        /*5527*/
    }


    // [virtual] class CefRequest
    /// <summary>
    /// Class used to represent a web request. The methods of this class may be
    /// called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*5636*/
    public struct CefRequest
    {
        /*5637*/
        const int _typeNAME = 22;
        /*5638*/
        const int CefRequest_Release_0 = (_typeNAME << 16) | 0;
        /*5639*/
        const int CefRequest_IsReadOnly_1 = (_typeNAME << 16) | 1;
        /*5640*/
        const int CefRequest_GetURL_2 = (_typeNAME << 16) | 2;
        /*5641*/
        const int CefRequest_SetURL_3 = (_typeNAME << 16) | 3;
        /*5642*/
        const int CefRequest_GetMethod_4 = (_typeNAME << 16) | 4;
        /*5643*/
        const int CefRequest_SetMethod_5 = (_typeNAME << 16) | 5;
        /*5644*/
        const int CefRequest_SetReferrer_6 = (_typeNAME << 16) | 6;
        /*5645*/
        const int CefRequest_GetReferrerURL_7 = (_typeNAME << 16) | 7;
        /*5646*/
        const int CefRequest_GetReferrerPolicy_8 = (_typeNAME << 16) | 8;
        /*5647*/
        const int CefRequest_GetPostData_9 = (_typeNAME << 16) | 9;
        /*5648*/
        const int CefRequest_SetPostData_10 = (_typeNAME << 16) | 10;
        /*5649*/
        const int CefRequest_GetHeaderMap_11 = (_typeNAME << 16) | 11;
        /*5650*/
        const int CefRequest_SetHeaderMap_12 = (_typeNAME << 16) | 12;
        /*5651*/
        const int CefRequest_Set_13 = (_typeNAME << 16) | 13;
        /*5652*/
        const int CefRequest_GetFlags_14 = (_typeNAME << 16) | 14;
        /*5653*/
        const int CefRequest_SetFlags_15 = (_typeNAME << 16) | 15;
        /*5654*/
        const int CefRequest_GetFirstPartyForCookies_16 = (_typeNAME << 16) | 16;
        /*5655*/
        const int CefRequest_SetFirstPartyForCookies_17 = (_typeNAME << 16) | 17;
        /*5656*/
        const int CefRequest_GetResourceType_18 = (_typeNAME << 16) | 18;
        /*5657*/
        const int CefRequest_GetTransitionType_19 = (_typeNAME << 16) | 19;
        /*5658*/
        const int CefRequest_GetIdentifier_20 = (_typeNAME << 16) | 20;
        /*5659*/
        internal readonly IntPtr nativePtr;
        /*5660*/
        internal CefRequest(IntPtr nativePtr)
        {
            /*5661*/
            this.nativePtr = nativePtr;
            /*5662*/
        }
        /*5663*/
        public void Release()
        {
            /*5664*/
            JsValue ret;
            /*5665*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_Release_0, out ret);
            /*5666*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefRequest methods.
        /// </summary>
        /*5667*/

        public bool IsReadOnly()/*5668*/
        {
            JsValue ret;
            /*5669*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_IsReadOnly_1, out ret);
            /*5670*/
            var ret_result = ret.I32 != 0;
            /*5671*/
            return ret_result;
            /*5672*/
        }

        // gen! CefString GetURL()
        /// <summary>
        /// Get the fully qualified URL.
        /// /*cef()*/
        /// </summary>
        /*5673*/

        public string GetURL()/*5674*/
        {
            JsValue ret;
            /*5675*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetURL_2, out ret);
            /*5676*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5677*/
            return ret_result;
            /*5678*/
        }

        // gen! void SetURL(const CefString& url)
        /// <summary>
        /// Set the fully qualified URL.
        /// /*cef()*/
        /// </summary>
        /*5679*/

        public void SetURL(string /*5680*/
        url
        )/*5681*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*5682*/
            ;
            /*5683*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetURL_3, out ret, ref v1);
            /*5684*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*5685*/
            ;
            /*5686*/
        }

        // gen! CefString GetMethod()
        /// <summary>
        /// Get the request method type. The value will default to POST if post data
        /// is provided and GET otherwise.
        /// /*cef()*/
        /// </summary>
        /*5687*/

        public string GetMethod()/*5688*/
        {
            JsValue ret;
            /*5689*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetMethod_4, out ret);
            /*5690*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5691*/
            return ret_result;
            /*5692*/
        }

        // gen! void SetMethod(const CefString& method)
        /// <summary>
        /// Set the request method type.
        /// /*cef()*/
        /// </summary>
        /*5693*/

        public void SetMethod(string /*5694*/
        method
        )/*5695*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(method);
            /*5696*/
            ;
            /*5697*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetMethod_5, out ret, ref v1);
            /*5698*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*5699*/
            ;
            /*5700*/
        }

        // gen! void SetReferrer(const CefString& referrer_url,ReferrerPolicy policy)
        /// <summary>
        /// Set the referrer URL and policy. If non-empty the referrer URL must be
        /// fully qualified with an HTTP or HTTPS scheme component. Any username,
        /// password or ref component will be removed.
        /// /*cef()*/
        /// </summary>
        /*5701*/

        public void SetReferrer(string /*5702*/
        referrer_url
        , cef_referrer_policy_t /*5703*/
        policy
        )/*5704*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(referrer_url);
            /*5705*/
            ;
            /*5706*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequest_SetReferrer_6, out ret, ref v1, ref v2);
            /*5707*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*5708*/
            ;
            /*5709*/
        }

        // gen! CefString GetReferrerURL()
        /// <summary>
        /// Get the referrer URL.
        /// /*cef()*/
        /// </summary>
        /*5710*/

        public string GetReferrerURL()/*5711*/
        {
            JsValue ret;
            /*5712*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetReferrerURL_7, out ret);
            /*5713*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5714*/
            return ret_result;
            /*5715*/
        }

        // gen! ReferrerPolicy GetReferrerPolicy()
        /// <summary>
        /// Get the referrer policy.
        /// /*cef(default_retval=REFERRER_POLICY_DEFAULT)*/
        /// </summary>
        /*5716*/

        public cef_referrer_policy_t GetReferrerPolicy()/*5717*/
        {
            JsValue ret;
            /*5718*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetReferrerPolicy_8, out ret);
            /*5719*/
            var ret_result = (cef_referrer_policy_t)ret.I32;

            /*5720*/
            return ret_result;
            /*5721*/
        }

        // gen! CefRefPtr<CefPostData> GetPostData()
        /// <summary>
        /// Get the post data.
        /// /*cef()*/
        /// </summary>
        /*5722*/

        public CefPostData GetPostData()/*5723*/
        {
            JsValue ret;
            /*5724*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetPostData_9, out ret);
            /*5725*/
            var ret_result = new CefPostData(ret.Ptr);
            /*5726*/
            return ret_result;
            /*5727*/
        }

        // gen! void SetPostData(CefRefPtr<CefPostData> postData)
        /// <summary>
        /// Set the post data.
        /// /*cef()*/
        /// </summary>
        /*5728*/

        public void SetPostData(CefPostData /*5729*/
        postData
        )/*5730*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5731*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetPostData_10, out ret, ref v1);
            /*5732*/

            /*5733*/
        }

        // gen! void GetHeaderMap(HeaderMap& headerMap)
        /// <summary>
        /// Get the header values. Will not include the Referer value if any.
        /// /*cef()*/
        /// </summary>
        /*5734*/

        public void GetHeaderMap(HeaderMap /*5735*/
        headerMap
        )/*5736*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5737*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_GetHeaderMap_11, out ret, ref v1);
            /*5738*/

            /*5739*/
        }

        // gen! void SetHeaderMap(const HeaderMap& headerMap)
        /// <summary>
        /// Set the header values. If a Referer value exists in the header map it will
        /// be removed and ignored.
        /// /*cef()*/
        /// </summary>
        /*5740*/

        public void SetHeaderMap(HeaderMap /*5741*/
        headerMap
        )/*5742*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5743*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetHeaderMap_12, out ret, ref v1);
            /*5744*/

            /*5745*/
        }

        // gen! void Set(const CefString& url,const CefString& method,CefRefPtr<CefPostData> postData,const HeaderMap& headerMap)
        /// <summary>
        /// Set all values at one time.
        /// /*cef(optional_param=postData)*/
        /// </summary>
        /*5746*/

        public void Set(string /*5747*/
        url
        , string /*5748*/
        method
        , CefPostData /*5749*/
        postData
        , HeaderMap /*5750*/
        headerMap
        )/*5751*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*5752*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(method);
            /*5753*/
            ;
            /*5754*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefRequest_Set_13, out ret, ref v1, ref v2, ref v3, ref v4);
            /*5755*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*5756*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*5757*/
            ;
            /*5758*/
        }

        // gen! int GetFlags()
        /// <summary>
        /// Get the flags used in combination with CefURLRequest. See
        /// cef_urlrequest_flags_t for supported values.
        /// /*cef(default_retval=UR_FLAG_NONE)*/
        /// </summary>
        /*5759*/

        public int GetFlags()/*5760*/
        {
            JsValue ret;
            /*5761*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetFlags_14, out ret);
            /*5762*/
            var ret_result = ret.I32;
            /*5763*/
            return ret_result;
            /*5764*/
        }

        // gen! void SetFlags(int flags)
        /// <summary>
        /// Set the flags used in combination with CefURLRequest.  See
        /// cef_urlrequest_flags_t for supported values.
        /// /*cef()*/
        /// </summary>
        /*5765*/

        public void SetFlags(int /*5766*/
        flags
        )/*5767*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5768*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetFlags_15, out ret, ref v1);
            /*5769*/

            /*5770*/
        }

        // gen! CefString GetFirstPartyForCookies()
        /// <summary>
        /// Set the URL to the first party for cookies used in combination with
        /// CefURLRequest.
        /// /*cef()*/
        /// </summary>
        /*5771*/

        public string GetFirstPartyForCookies()/*5772*/
        {
            JsValue ret;
            /*5773*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetFirstPartyForCookies_16, out ret);
            /*5774*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5775*/
            return ret_result;
            /*5776*/
        }

        // gen! void SetFirstPartyForCookies(const CefString& url)
        /// <summary>
        /// Get the URL to the first party for cookies used in combination with
        /// CefURLRequest.
        /// /*cef()*/
        /// </summary>
        /*5777*/

        public void SetFirstPartyForCookies(string /*5778*/
        url
        )/*5779*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*5780*/
            ;
            /*5781*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetFirstPartyForCookies_17, out ret, ref v1);
            /*5782*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*5783*/
            ;
            /*5784*/
        }

        // gen! ResourceType GetResourceType()
        /// <summary>
        /// Get the resource type for this request. Only available in the browser
        /// process.
        /// /*cef(default_retval=RT_SUB_RESOURCE)*/
        /// </summary>
        /*5785*/

        public cef_resource_type_t GetResourceType()/*5786*/
        {
            JsValue ret;
            /*5787*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetResourceType_18, out ret);
            /*5788*/
            var ret_result = (cef_resource_type_t)ret.I32;

            /*5789*/
            return ret_result;
            /*5790*/
        }

        // gen! TransitionType GetTransitionType()
        /// <summary>
        /// Get the transition type for this request. Only available in the browser
        /// process and only applies to requests that represent a main frame or
        /// sub-frame navigation.
        /// /*cef(default_retval=TT_EXPLICIT)*/
        /// </summary>
        /*5791*/

        public cef_transition_type_t GetTransitionType()/*5792*/
        {
            JsValue ret;
            /*5793*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetTransitionType_19, out ret);
            /*5794*/
            var ret_result = (cef_transition_type_t)ret.I32;

            /*5795*/
            return ret_result;
            /*5796*/
        }

        // gen! uint64 GetIdentifier()
        /// <summary>
        /// Returns the globally unique identifier for this request or 0 if not
        /// specified. Can be used by CefRequestHandler implementations in the browser
        /// process to track a single request across multiple callbacks.
        /// /*cef()*/
        /// </summary>
        /*5797*/

        public ulong GetIdentifier()/*5798*/
        {
            JsValue ret;
            /*5799*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetIdentifier_20, out ret);
            /*5800*/
            var ret_result = (ulong)ret.I64;
            /*5801*/
            return ret_result;
            /*5802*/
        }
        /*5803*/
    }


    // [virtual] class CefPostData
    /// <summary>
    /// Class used to represent post data for a web request. The methods of this
    /// class may be called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*5847*/
    public struct CefPostData
    {
        /*5848*/
        const int _typeNAME = 23;
        /*5849*/
        const int CefPostData_Release_0 = (_typeNAME << 16) | 0;
        /*5850*/
        const int CefPostData_IsReadOnly_1 = (_typeNAME << 16) | 1;
        /*5851*/
        const int CefPostData_HasExcludedElements_2 = (_typeNAME << 16) | 2;
        /*5852*/
        const int CefPostData_GetElementCount_3 = (_typeNAME << 16) | 3;
        /*5853*/
        const int CefPostData_GetElements_4 = (_typeNAME << 16) | 4;
        /*5854*/
        const int CefPostData_RemoveElement_5 = (_typeNAME << 16) | 5;
        /*5855*/
        const int CefPostData_AddElement_6 = (_typeNAME << 16) | 6;
        /*5856*/
        const int CefPostData_RemoveElements_7 = (_typeNAME << 16) | 7;
        /*5857*/
        internal readonly IntPtr nativePtr;
        /*5858*/
        internal CefPostData(IntPtr nativePtr)
        {
            /*5859*/
            this.nativePtr = nativePtr;
            /*5860*/
        }
        /*5861*/
        public void Release()
        {
            /*5862*/
            JsValue ret;
            /*5863*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_Release_0, out ret);
            /*5864*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefPostData methods.
        /// </summary>
        /*5865*/

        public bool IsReadOnly()/*5866*/
        {
            JsValue ret;
            /*5867*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_IsReadOnly_1, out ret);
            /*5868*/
            var ret_result = ret.I32 != 0;
            /*5869*/
            return ret_result;
            /*5870*/
        }

        // gen! bool HasExcludedElements()
        /// <summary>
        /// Returns true if the underlying POST data includes elements that are not
        /// represented by this CefPostData object (for example, multi-part file upload
        /// data). Modifying CefPostData objects with excluded elements may result in
        /// the request failing.
        /// /*cef()*/
        /// </summary>
        /*5871*/

        public bool HasExcludedElements()/*5872*/
        {
            JsValue ret;
            /*5873*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_HasExcludedElements_2, out ret);
            /*5874*/
            var ret_result = ret.I32 != 0;
            /*5875*/
            return ret_result;
            /*5876*/
        }

        // gen! size_t GetElementCount()
        /// <summary>
        /// Returns the number of existing post data elements.
        /// /*cef()*/
        /// </summary>
        /*5877*/

        public uint GetElementCount()/*5878*/
        {
            JsValue ret;
            /*5879*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_GetElementCount_3, out ret);
            /*5880*/
            var ret_result = (uint)ret.I32;
            /*5881*/
            return ret_result;
            /*5882*/
        }

        // gen! void GetElements(ElementVector& elements)
        /// <summary>
        /// Retrieve the post data elements.
        /// /*cef(count_func=elements:GetElementCount)*/
        /// </summary>
        /*5883*/

        public void GetElements(ElementVector /*5884*/
        elements
        )/*5885*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5886*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_GetElements_4, out ret, ref v1);
            /*5887*/

            /*5888*/
        }

        // gen! bool RemoveElement(CefRefPtr<CefPostDataElement> element)
        /// <summary>
        /// Remove the specified post data element.  Returns true if the removal
        /// succeeds.
        /// /*cef()*/
        /// </summary>
        /*5889*/

        public bool RemoveElement(CefPostDataElement /*5890*/
        element
        )/*5891*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5892*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_RemoveElement_5, out ret, ref v1);
            /*5893*/
            var ret_result = ret.I32 != 0;
            /*5894*/
            return ret_result;
            /*5895*/
        }

        // gen! bool AddElement(CefRefPtr<CefPostDataElement> element)
        /// <summary>
        /// Add the specified post data element.  Returns true if the add succeeds.
        /// /*cef()*/
        /// </summary>
        /*5896*/

        public bool AddElement(CefPostDataElement /*5897*/
        element
        )/*5898*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5899*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_AddElement_6, out ret, ref v1);
            /*5900*/
            var ret_result = ret.I32 != 0;
            /*5901*/
            return ret_result;
            /*5902*/
        }

        // gen! void RemoveElements()
        /// <summary>
        /// Remove all existing post data elements.
        /// /*cef()*/
        /// </summary>
        /*5903*/

        public void RemoveElements()/*5904*/
        {
            JsValue ret;
            /*5905*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_RemoveElements_7, out ret);
            /*5906*/

            /*5907*/
        }
        /*5908*/
    }


    // [virtual] class CefPostDataElement
    /// <summary>
    /// Class used to represent a single element in the request post data. The
    /// methods of this class may be called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*5957*/
    public struct CefPostDataElement
    {
        /*5958*/
        const int _typeNAME = 24;
        /*5959*/
        const int CefPostDataElement_Release_0 = (_typeNAME << 16) | 0;
        /*5960*/
        const int CefPostDataElement_IsReadOnly_1 = (_typeNAME << 16) | 1;
        /*5961*/
        const int CefPostDataElement_SetToEmpty_2 = (_typeNAME << 16) | 2;
        /*5962*/
        const int CefPostDataElement_SetToFile_3 = (_typeNAME << 16) | 3;
        /*5963*/
        const int CefPostDataElement_SetToBytes_4 = (_typeNAME << 16) | 4;
        /*5964*/
        const int CefPostDataElement_GetType_5 = (_typeNAME << 16) | 5;
        /*5965*/
        const int CefPostDataElement_GetFile_6 = (_typeNAME << 16) | 6;
        /*5966*/
        const int CefPostDataElement_GetBytesCount_7 = (_typeNAME << 16) | 7;
        /*5967*/
        const int CefPostDataElement_GetBytes_8 = (_typeNAME << 16) | 8;
        /*5968*/
        internal readonly IntPtr nativePtr;
        /*5969*/
        internal CefPostDataElement(IntPtr nativePtr)
        {
            /*5970*/
            this.nativePtr = nativePtr;
            /*5971*/
        }
        /*5972*/
        public void Release()
        {
            /*5973*/
            JsValue ret;
            /*5974*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_Release_0, out ret);
            /*5975*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefPostDataElement methods.
        /// </summary>
        /*5976*/

        public bool IsReadOnly()/*5977*/
        {
            JsValue ret;
            /*5978*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_IsReadOnly_1, out ret);
            /*5979*/
            var ret_result = ret.I32 != 0;
            /*5980*/
            return ret_result;
            /*5981*/
        }

        // gen! void SetToEmpty()
        /// <summary>
        /// Remove all contents from the post data element.
        /// /*cef()*/
        /// </summary>
        /*5982*/

        public void SetToEmpty()/*5983*/
        {
            JsValue ret;
            /*5984*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_SetToEmpty_2, out ret);
            /*5985*/

            /*5986*/
        }

        // gen! void SetToFile(const CefString& fileName)
        /// <summary>
        /// The post data element will represent a file.
        /// /*cef()*/
        /// </summary>
        /*5987*/

        public void SetToFile(string /*5988*/
        fileName
        )/*5989*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(fileName);
            /*5990*/
            ;
            /*5991*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostDataElement_SetToFile_3, out ret, ref v1);
            /*5992*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*5993*/
            ;
            /*5994*/
        }

        // gen! void SetToBytes(size_t size,const void* bytes)
        /// <summary>
        /// The post data element will represent bytes.  The bytes passed
        /// in will be copied.
        /// /*cef()*/
        /// </summary>
        /*5995*/

        public void SetToBytes(uint /*5996*/
        size
        , IntPtr /*5997*/
        bytes
        )/*5998*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*5999*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefPostDataElement_SetToBytes_4, out ret, ref v1, ref v2);
            /*6000*/

            /*6001*/
        }

        // gen! Type GetType()
        /// <summary>
        /// Return the type of this post data element.
        /// /*cef(default_retval=PDE_TYPE_EMPTY)*/
        /// </summary>
        /*6002*/

        public cef_postdataelement_type_t _GetType()/*6003*/
        {
            JsValue ret;
            /*6004*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetType_5, out ret);
            /*6005*/
            var ret_result = (cef_postdataelement_type_t)ret.I32;

            /*6006*/
            return ret_result;
            /*6007*/
        }

        // gen! CefString GetFile()
        /// <summary>
        /// Return the file name.
        /// /*cef()*/
        /// </summary>
        /*6008*/

        public string GetFile()/*6009*/
        {
            JsValue ret;
            /*6010*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetFile_6, out ret);
            /*6011*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6012*/
            return ret_result;
            /*6013*/
        }

        // gen! size_t GetBytesCount()
        /// <summary>
        /// Return the number of bytes.
        /// /*cef()*/
        /// </summary>
        /*6014*/

        public uint GetBytesCount()/*6015*/
        {
            JsValue ret;
            /*6016*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetBytesCount_7, out ret);
            /*6017*/
            var ret_result = (uint)ret.I32;
            /*6018*/
            return ret_result;
            /*6019*/
        }

        // gen! size_t GetBytes(size_t size,void* bytes)
        /// <summary>
        /// Read up to |size| bytes into |bytes| and return the number of bytes
        /// actually read.
        /// /*cef()*/
        /// </summary>
        /*6020*/

        public uint GetBytes(uint /*6021*/
        size
        , IntPtr /*6022*/
        bytes
        )/*6023*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*6024*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefPostDataElement_GetBytes_8, out ret, ref v1, ref v2);
            /*6025*/
            var ret_result = (uint)ret.I32;
            /*6026*/
            return ret_result;
            /*6027*/
        }
        /*6028*/
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
    /*6127*/
    public struct CefRequestContext
    {
        /*6128*/
        const int _typeNAME = 25;
        /*6129*/
        const int CefRequestContext_Release_0 = (_typeNAME << 16) | 0;
        /*6130*/
        const int CefRequestContext_IsSame_1 = (_typeNAME << 16) | 1;
        /*6131*/
        const int CefRequestContext_IsSharingWith_2 = (_typeNAME << 16) | 2;
        /*6132*/
        const int CefRequestContext_IsGlobal_3 = (_typeNAME << 16) | 3;
        /*6133*/
        const int CefRequestContext_GetHandler_4 = (_typeNAME << 16) | 4;
        /*6134*/
        const int CefRequestContext_GetCachePath_5 = (_typeNAME << 16) | 5;
        /*6135*/
        const int CefRequestContext_GetDefaultCookieManager_6 = (_typeNAME << 16) | 6;
        /*6136*/
        const int CefRequestContext_RegisterSchemeHandlerFactory_7 = (_typeNAME << 16) | 7;
        /*6137*/
        const int CefRequestContext_ClearSchemeHandlerFactories_8 = (_typeNAME << 16) | 8;
        /*6138*/
        const int CefRequestContext_PurgePluginListCache_9 = (_typeNAME << 16) | 9;
        /*6139*/
        const int CefRequestContext_HasPreference_10 = (_typeNAME << 16) | 10;
        /*6140*/
        const int CefRequestContext_GetPreference_11 = (_typeNAME << 16) | 11;
        /*6141*/
        const int CefRequestContext_GetAllPreferences_12 = (_typeNAME << 16) | 12;
        /*6142*/
        const int CefRequestContext_CanSetPreference_13 = (_typeNAME << 16) | 13;
        /*6143*/
        const int CefRequestContext_SetPreference_14 = (_typeNAME << 16) | 14;
        /*6144*/
        const int CefRequestContext_ClearCertificateExceptions_15 = (_typeNAME << 16) | 15;
        /*6145*/
        const int CefRequestContext_CloseAllConnections_16 = (_typeNAME << 16) | 16;
        /*6146*/
        const int CefRequestContext_ResolveHost_17 = (_typeNAME << 16) | 17;
        /*6147*/
        const int CefRequestContext_ResolveHostCached_18 = (_typeNAME << 16) | 18;
        /*6148*/
        internal readonly IntPtr nativePtr;
        /*6149*/
        internal CefRequestContext(IntPtr nativePtr)
        {
            /*6150*/
            this.nativePtr = nativePtr;
            /*6151*/
        }
        /*6152*/
        public void Release()
        {
            /*6153*/
            JsValue ret;
            /*6154*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_Release_0, out ret);
            /*6155*/
        }

        // gen! bool IsSame(CefRefPtr<CefRequestContext> other)
        /// <summary>
        /// CefRequestContext methods.
        /// </summary>
        /*6156*/

        public bool IsSame(CefRequestContext /*6157*/
        other
        )/*6158*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6159*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_IsSame_1, out ret, ref v1);
            /*6160*/
            var ret_result = ret.I32 != 0;
            /*6161*/
            return ret_result;
            /*6162*/
        }

        // gen! bool IsSharingWith(CefRefPtr<CefRequestContext> other)
        /// <summary>
        /// Returns true if this object is sharing the same storage as |that| object.
        /// /*cef()*/
        /// </summary>
        /*6163*/

        public bool IsSharingWith(CefRequestContext /*6164*/
        other
        )/*6165*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6166*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_IsSharingWith_2, out ret, ref v1);
            /*6167*/
            var ret_result = ret.I32 != 0;
            /*6168*/
            return ret_result;
            /*6169*/
        }

        // gen! bool IsGlobal()
        /// <summary>
        /// Returns true if this object is the global context. The global context is
        /// used by default when creating a browser or URL request with a NULL context
        /// argument.
        /// /*cef()*/
        /// </summary>
        /*6170*/

        public bool IsGlobal()/*6171*/
        {
            JsValue ret;
            /*6172*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_IsGlobal_3, out ret);
            /*6173*/
            var ret_result = ret.I32 != 0;
            /*6174*/
            return ret_result;
            /*6175*/
        }

        // gen! CefRefPtr<CefRequestContextHandler> GetHandler()
        /// <summary>
        /// Returns the handler for this context if any.
        /// /*cef()*/
        /// </summary>
        /*6176*/

        public CefRequestContextHandler GetHandler()/*6177*/
        {
            JsValue ret;
            /*6178*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_GetHandler_4, out ret);
            /*6179*/
            var ret_result = new CefRequestContextHandler(ret.Ptr);
            /*6180*/
            return ret_result;
            /*6181*/
        }

        // gen! CefString GetCachePath()
        /// <summary>
        /// Returns the cache path for this object. If empty an "incognito mode"
        /// in-memory cache is being used.
        /// /*cef()*/
        /// </summary>
        /*6182*/

        public string GetCachePath()/*6183*/
        {
            JsValue ret;
            /*6184*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_GetCachePath_5, out ret);
            /*6185*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6186*/
            return ret_result;
            /*6187*/
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
        /*6188*/

        public CefCookieManager GetDefaultCookieManager(CefCompletionCallback /*6189*/
        callback
        )/*6190*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6191*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetDefaultCookieManager_6, out ret, ref v1);
            /*6192*/
            var ret_result = new CefCookieManager(ret.Ptr);
            /*6193*/
            return ret_result;
            /*6194*/
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
        /*6195*/

        public bool RegisterSchemeHandlerFactory(string /*6196*/
        scheme_name
        , string /*6197*/
        domain_name
        , CefSchemeHandlerFactory /*6198*/
        factory
        )/*6199*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(scheme_name);
            /*6200*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(domain_name);
            /*6201*/
            ;
            /*6202*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefRequestContext_RegisterSchemeHandlerFactory_7, out ret, ref v1, ref v2, ref v3);
            /*6203*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6204*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*6205*/
            ;
            /*6206*/
            return ret_result;
            /*6207*/
        }

        // gen! bool ClearSchemeHandlerFactories()
        /// <summary>
        /// Clear all registered scheme handler factories. Returns false on error. This
        /// function may be called on any thread in the browser process.
        /// /*cef()*/
        /// </summary>
        /*6208*/

        public bool ClearSchemeHandlerFactories()/*6209*/
        {
            JsValue ret;
            /*6210*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_ClearSchemeHandlerFactories_8, out ret);
            /*6211*/
            var ret_result = ret.I32 != 0;
            /*6212*/
            return ret_result;
            /*6213*/
        }

        // gen! void PurgePluginListCache(bool reload_pages)
        /// <summary>
        /// Tells all renderer processes associated with this context to throw away
        /// their plugin list cache. If |reload_pages| is true they will also reload
        /// all pages with plugins. CefRequestContextHandler::OnBeforePluginLoad may
        /// be called to rebuild the plugin list cache.
        /// /*cef()*/
        /// </summary>
        /*6214*/

        public void PurgePluginListCache(bool /*6215*/
        reload_pages
        )/*6216*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6217*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_PurgePluginListCache_9, out ret, ref v1);
            /*6218*/

            /*6219*/
        }

        // gen! bool HasPreference(const CefString& name)
        /// <summary>
        /// Returns true if a preference with the specified |name| exists. This method
        /// must be called on the browser process UI thread.
        /// /*cef()*/
        /// </summary>
        /*6220*/

        public bool HasPreference(string /*6221*/
        name
        )/*6222*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6223*/
            ;
            /*6224*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_HasPreference_10, out ret, ref v1);
            /*6225*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6226*/
            ;
            /*6227*/
            return ret_result;
            /*6228*/
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
        /*6229*/

        public CefValue GetPreference(string /*6230*/
        name
        )/*6231*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6232*/
            ;
            /*6233*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetPreference_11, out ret, ref v1);
            /*6234*/
            var ret_result = new CefValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6235*/
            ;
            /*6236*/
            return ret_result;
            /*6237*/
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
        /*6238*/

        public CefDictionaryValue GetAllPreferences(bool /*6239*/
        include_defaults
        )/*6240*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6241*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetAllPreferences_12, out ret, ref v1);
            /*6242*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            /*6243*/
            return ret_result;
            /*6244*/
        }

        // gen! bool CanSetPreference(const CefString& name)
        /// <summary>
        /// Returns true if the preference with the specified |name| can be modified
        /// using SetPreference. As one example preferences set via the command-line
        /// usually cannot be modified. This method must be called on the browser
        /// process UI thread.
        /// /*cef()*/
        /// </summary>
        /*6245*/

        public bool CanSetPreference(string /*6246*/
        name
        )/*6247*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6248*/
            ;
            /*6249*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_CanSetPreference_13, out ret, ref v1);
            /*6250*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6251*/
            ;
            /*6252*/
            return ret_result;
            /*6253*/
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
        /*6254*/

        public bool SetPreference(string /*6255*/
        name
        , CefValue /*6256*/
        value
        , string /*6257*/
        error
        )/*6258*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6259*/
            ;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(error);
            /*6260*/
            ;
            /*6261*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefRequestContext_SetPreference_14, out ret, ref v1, ref v2, ref v3);
            /*6262*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6263*/
            ;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*6264*/
            ;
            /*6265*/
            return ret_result;
            /*6266*/
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
        /*6267*/

        public void ClearCertificateExceptions(CefCompletionCallback /*6268*/
        callback
        )/*6269*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6270*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_ClearCertificateExceptions_15, out ret, ref v1);
            /*6271*/

            /*6272*/
        }

        // gen! void CloseAllConnections(CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Clears all active and idle connections that Chromium currently has.
        /// This is only recommended if you have released all other CEF objects but
        /// don't yet want to call CefShutdown(). If |callback| is non-NULL it will be
        /// executed on the UI thread after completion.
        /// /*cef(optional_param=callback)*/
        /// </summary>
        /*6273*/

        public void CloseAllConnections(CefCompletionCallback /*6274*/
        callback
        )/*6275*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6276*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_CloseAllConnections_16, out ret, ref v1);
            /*6277*/

            /*6278*/
        }

        // gen! void ResolveHost(const CefString& origin,CefRefPtr<CefResolveCallback> callback)
        /// <summary>
        /// Attempts to resolve |origin| to a list of associated IP addresses.
        /// |callback| will be executed on the UI thread after completion.
        /// /*cef()*/
        /// </summary>
        /*6279*/

        public void ResolveHost(string /*6280*/
        origin
        , CefResolveCallback /*6281*/
        callback
        )/*6282*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(origin);
            /*6283*/
            ;
            /*6284*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequestContext_ResolveHost_17, out ret, ref v1, ref v2);
            /*6285*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6286*/
            ;
            /*6287*/
        }

        // gen! cef_errorcode_t ResolveHostCached(const CefString& origin,std::vector<CefString>& resolved_ips)
        /// <summary>
        /// Attempts to resolve |origin| to a list of associated IP addresses using
        /// cached data. |resolved_ips| will be populated with the list of resolved IP
        /// addresses or empty if no cached data is available. Returns ERR_NONE on
        /// success. This method must be called on the browser process IO thread.
        /// /*cef(default_retval=ERR_FAILED)*/
        /// </summary>
        /*6288*/

        public cef_errorcode_t ResolveHostCached(string /*6289*/
        origin
        , List<string> /*6290*/
        resolved_ips
        )/*6291*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(origin);
            /*6292*/
            ;
            /*6293*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequestContext_ResolveHostCached_18, out ret, ref v1, ref v2);
            /*6294*/
            var ret_result = (cef_errorcode_t)ret.I32;

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6295*/
            ;
            /*6296*/
            return ret_result;
            /*6297*/
        }
        /*6298*/
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
    /*6322*/
    public struct CefResourceBundle
    {
        /*6323*/
        const int _typeNAME = 26;
        /*6324*/
        const int CefResourceBundle_Release_0 = (_typeNAME << 16) | 0;
        /*6325*/
        const int CefResourceBundle_GetLocalizedString_1 = (_typeNAME << 16) | 1;
        /*6326*/
        const int CefResourceBundle_GetDataResource_2 = (_typeNAME << 16) | 2;
        /*6327*/
        const int CefResourceBundle_GetDataResourceForScale_3 = (_typeNAME << 16) | 3;
        /*6328*/
        internal readonly IntPtr nativePtr;
        /*6329*/
        internal CefResourceBundle(IntPtr nativePtr)
        {
            /*6330*/
            this.nativePtr = nativePtr;
            /*6331*/
        }
        /*6332*/
        public void Release()
        {
            /*6333*/
            JsValue ret;
            /*6334*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResourceBundle_Release_0, out ret);
            /*6335*/
        }

        // gen! CefString GetLocalizedString(int string_id)
        /// <summary>
        /// CefResourceBundle methods.
        /// </summary>
        /*6336*/

        public string GetLocalizedString(int /*6337*/
        string_id
        )/*6338*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6339*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResourceBundle_GetLocalizedString_1, out ret, ref v1);
            /*6340*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6341*/
            return ret_result;
            /*6342*/
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
        /*6343*/

        public bool GetDataResource(int /*6344*/
        resource_id
        , IntPtr /*6345*/
        data
        , ref uint /*6346*/
        data_size
        )/*6347*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*6348*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefResourceBundle_GetDataResource_2, out ret, ref v1, ref v2, ref v3);
            /*6349*/
            var ret_result = ret.I32 != 0;
            data = v2.Ptr;/*6350*/
            ;
            data_size = (uint)v3.I32;/*6351*/
            ;
            /*6352*/
            return ret_result;
            /*6353*/
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
        /*6354*/

        public bool GetDataResourceForScale(int /*6355*/
        resource_id
        , cef_scale_factor_t /*6356*/
        scale_factor
        , IntPtr /*6357*/
        data
        , ref uint /*6358*/
        data_size
        )/*6359*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            /*6360*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefResourceBundle_GetDataResourceForScale_3, out ret, ref v1, ref v2, ref v3, ref v4);
            /*6361*/
            var ret_result = ret.I32 != 0;
            data = v3.Ptr;/*6362*/
            ;
            data_size = (uint)v4.I32;/*6363*/
            ;
            /*6364*/
            return ret_result;
            /*6365*/
        }
        /*6366*/
    }


    // [virtual] class CefResponse
    /// <summary>
    /// Class used to represent a web response. The methods of this class may be
    /// called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*6435*/
    public struct CefResponse
    {
        /*6436*/
        const int _typeNAME = 27;
        /*6437*/
        const int CefResponse_Release_0 = (_typeNAME << 16) | 0;
        /*6438*/
        const int CefResponse_IsReadOnly_1 = (_typeNAME << 16) | 1;
        /*6439*/
        const int CefResponse_GetError_2 = (_typeNAME << 16) | 2;
        /*6440*/
        const int CefResponse_SetError_3 = (_typeNAME << 16) | 3;
        /*6441*/
        const int CefResponse_GetStatus_4 = (_typeNAME << 16) | 4;
        /*6442*/
        const int CefResponse_SetStatus_5 = (_typeNAME << 16) | 5;
        /*6443*/
        const int CefResponse_GetStatusText_6 = (_typeNAME << 16) | 6;
        /*6444*/
        const int CefResponse_SetStatusText_7 = (_typeNAME << 16) | 7;
        /*6445*/
        const int CefResponse_GetMimeType_8 = (_typeNAME << 16) | 8;
        /*6446*/
        const int CefResponse_SetMimeType_9 = (_typeNAME << 16) | 9;
        /*6447*/
        const int CefResponse_GetHeader_10 = (_typeNAME << 16) | 10;
        /*6448*/
        const int CefResponse_GetHeaderMap_11 = (_typeNAME << 16) | 11;
        /*6449*/
        const int CefResponse_SetHeaderMap_12 = (_typeNAME << 16) | 12;
        /*6450*/
        internal readonly IntPtr nativePtr;
        /*6451*/
        internal CefResponse(IntPtr nativePtr)
        {
            /*6452*/
            this.nativePtr = nativePtr;
            /*6453*/
        }
        /*6454*/
        public void Release()
        {
            /*6455*/
            JsValue ret;
            /*6456*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_Release_0, out ret);
            /*6457*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefResponse methods.
        /// </summary>
        /*6458*/

        public bool IsReadOnly()/*6459*/
        {
            JsValue ret;
            /*6460*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_IsReadOnly_1, out ret);
            /*6461*/
            var ret_result = ret.I32 != 0;
            /*6462*/
            return ret_result;
            /*6463*/
        }

        // gen! cef_errorcode_t GetError()
        /// <summary>
        /// Get the response error code. Returns ERR_NONE if there was no error.
        /// /*cef(default_retval=ERR_NONE)*/
        /// </summary>
        /*6464*/

        public cef_errorcode_t GetError()/*6465*/
        {
            JsValue ret;
            /*6466*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetError_2, out ret);
            /*6467*/
            var ret_result = (cef_errorcode_t)ret.I32;

            /*6468*/
            return ret_result;
            /*6469*/
        }

        // gen! void SetError(cef_errorcode_t error)
        /// <summary>
        /// Set the response error code. This can be used by custom scheme handlers
        /// to return errors during initial request processing.
        /// /*cef()*/
        /// </summary>
        /*6470*/

        public void SetError(cef_errorcode_t /*6471*/
        error
        )/*6472*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6473*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetError_3, out ret, ref v1);
            /*6474*/

            /*6475*/
        }

        // gen! int GetStatus()
        /// <summary>
        /// Get the response status code.
        /// /*cef()*/
        /// </summary>
        /*6476*/

        public int GetStatus()/*6477*/
        {
            JsValue ret;
            /*6478*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetStatus_4, out ret);
            /*6479*/
            var ret_result = ret.I32;
            /*6480*/
            return ret_result;
            /*6481*/
        }

        // gen! void SetStatus(int status)
        /// <summary>
        /// Set the response status code.
        /// /*cef()*/
        /// </summary>
        /*6482*/

        public void SetStatus(int /*6483*/
        status
        )/*6484*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6485*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetStatus_5, out ret, ref v1);
            /*6486*/

            /*6487*/
        }

        // gen! CefString GetStatusText()
        /// <summary>
        /// Get the response status text.
        /// /*cef()*/
        /// </summary>
        /*6488*/

        public string GetStatusText()/*6489*/
        {
            JsValue ret;
            /*6490*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetStatusText_6, out ret);
            /*6491*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6492*/
            return ret_result;
            /*6493*/
        }

        // gen! void SetStatusText(const CefString& statusText)
        /// <summary>
        /// Set the response status text.
        /// /*cef()*/
        /// </summary>
        /*6494*/

        public void SetStatusText(string /*6495*/
        statusText
        )/*6496*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(statusText);
            /*6497*/
            ;
            /*6498*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetStatusText_7, out ret, ref v1);
            /*6499*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6500*/
            ;
            /*6501*/
        }

        // gen! CefString GetMimeType()
        /// <summary>
        /// Get the response mime type.
        /// /*cef()*/
        /// </summary>
        /*6502*/

        public string GetMimeType()/*6503*/
        {
            JsValue ret;
            /*6504*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetMimeType_8, out ret);
            /*6505*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6506*/
            return ret_result;
            /*6507*/
        }

        // gen! void SetMimeType(const CefString& mimeType)
        /// <summary>
        /// Set the response mime type.
        /// /*cef()*/
        /// </summary>
        /*6508*/

        public void SetMimeType(string /*6509*/
        mimeType
        )/*6510*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(mimeType);
            /*6511*/
            ;
            /*6512*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetMimeType_9, out ret, ref v1);
            /*6513*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6514*/
            ;
            /*6515*/
        }

        // gen! CefString GetHeader(const CefString& name)
        /// <summary>
        /// Get the value for the specified response header field.
        /// /*cef()*/
        /// </summary>
        /*6516*/

        public string GetHeader(string /*6517*/
        name
        )/*6518*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6519*/
            ;
            /*6520*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_GetHeader_10, out ret, ref v1);
            /*6521*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6522*/
            ;
            /*6523*/
            return ret_result;
            /*6524*/
        }

        // gen! void GetHeaderMap(HeaderMap& headerMap)
        /// <summary>
        /// Get all response header fields.
        /// /*cef()*/
        /// </summary>
        /*6525*/

        public void GetHeaderMap(HeaderMap /*6526*/
        headerMap
        )/*6527*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6528*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_GetHeaderMap_11, out ret, ref v1);
            /*6529*/

            /*6530*/
        }

        // gen! void SetHeaderMap(const HeaderMap& headerMap)
        /// <summary>
        /// Set all response header fields.
        /// /*cef()*/
        /// </summary>
        /*6531*/

        public void SetHeaderMap(HeaderMap /*6532*/
        headerMap
        )/*6533*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6534*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetHeaderMap_12, out ret, ref v1);
            /*6535*/

            /*6536*/
        }
        /*6537*/
    }


    // [virtual] class CefResponseFilter
    /// <summary>
    /// Implement this interface to filter resource response content. The methods of
    /// this class will be called on the browser process IO thread.
    /// /*(source=client)*/
    /// </summary>
    /*6546*/
    public struct CefResponseFilter
    {
        /*6547*/
        const int _typeNAME = 28;
        /*6548*/
        const int CefResponseFilter_Release_0 = (_typeNAME << 16) | 0;
        /*6549*/
        internal readonly IntPtr nativePtr;
        /*6550*/
        internal CefResponseFilter(IntPtr nativePtr)
        {
            /*6551*/
            this.nativePtr = nativePtr;
            /*6552*/
        }
        /*6553*/
        public void Release()
        {
            /*6554*/
            JsValue ret;
            /*6555*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponseFilter_Release_0, out ret);
            /*6556*/
        }
        /*6557*/
    }


    // [virtual] class CefSchemeHandlerFactory
    /// <summary>
    /// Class that creates CefResourceHandler instances for handling scheme requests.
    /// The methods of this class will always be called on the IO thread.
    /// /*(source=client)*/
    /// </summary>
    /*6566*/
    public struct CefSchemeHandlerFactory
    {
        /*6567*/
        const int _typeNAME = 29;
        /*6568*/
        const int CefSchemeHandlerFactory_Release_0 = (_typeNAME << 16) | 0;
        /*6569*/
        internal readonly IntPtr nativePtr;
        /*6570*/
        internal CefSchemeHandlerFactory(IntPtr nativePtr)
        {
            /*6571*/
            this.nativePtr = nativePtr;
            /*6572*/
        }
        /*6573*/
        public void Release()
        {
            /*6574*/
            JsValue ret;
            /*6575*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSchemeHandlerFactory_Release_0, out ret);
            /*6576*/
        }
        /*6577*/
    }


    // [virtual] class CefSSLInfo
    /// <summary>
    /// Class representing SSL information.
    /// /*(source=library)*/
    /// </summary>
    /*6596*/
    public struct CefSSLInfo
    {
        /*6597*/
        const int _typeNAME = 30;
        /*6598*/
        const int CefSSLInfo_Release_0 = (_typeNAME << 16) | 0;
        /*6599*/
        const int CefSSLInfo_GetCertStatus_1 = (_typeNAME << 16) | 1;
        /*6600*/
        const int CefSSLInfo_GetX509Certificate_2 = (_typeNAME << 16) | 2;
        /*6601*/
        internal readonly IntPtr nativePtr;
        /*6602*/
        internal CefSSLInfo(IntPtr nativePtr)
        {
            /*6603*/
            this.nativePtr = nativePtr;
            /*6604*/
        }
        /*6605*/
        public void Release()
        {
            /*6606*/
            JsValue ret;
            /*6607*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_Release_0, out ret);
            /*6608*/
        }

        // gen! cef_cert_status_t GetCertStatus()
        /// <summary>
        /// CefSSLInfo methods.
        /// </summary>
        /*6609*/

        public cef_cert_status_t GetCertStatus()/*6610*/
        {
            JsValue ret;
            /*6611*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_GetCertStatus_1, out ret);
            /*6612*/
            var ret_result = (cef_cert_status_t)ret.I32;

            /*6613*/
            return ret_result;
            /*6614*/
        }

        // gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
        /// <summary>
        /// Returns the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*6615*/

        public CefX509Certificate GetX509Certificate()/*6616*/
        {
            JsValue ret;
            /*6617*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_GetX509Certificate_2, out ret);
            /*6618*/
            var ret_result = new CefX509Certificate(ret.Ptr);
            /*6619*/
            return ret_result;
            /*6620*/
        }
        /*6621*/
    }


    // [virtual] class CefSSLStatus
    /// <summary>
    /// Class representing the SSL information for a navigation entry.
    /// /*(source=library)*/
    /// </summary>
    /*6655*/
    public struct CefSSLStatus
    {
        /*6656*/
        const int _typeNAME = 31;
        /*6657*/
        const int CefSSLStatus_Release_0 = (_typeNAME << 16) | 0;
        /*6658*/
        const int CefSSLStatus_IsSecureConnection_1 = (_typeNAME << 16) | 1;
        /*6659*/
        const int CefSSLStatus_GetCertStatus_2 = (_typeNAME << 16) | 2;
        /*6660*/
        const int CefSSLStatus_GetSSLVersion_3 = (_typeNAME << 16) | 3;
        /*6661*/
        const int CefSSLStatus_GetContentStatus_4 = (_typeNAME << 16) | 4;
        /*6662*/
        const int CefSSLStatus_GetX509Certificate_5 = (_typeNAME << 16) | 5;
        /*6663*/
        internal readonly IntPtr nativePtr;
        /*6664*/
        internal CefSSLStatus(IntPtr nativePtr)
        {
            /*6665*/
            this.nativePtr = nativePtr;
            /*6666*/
        }
        /*6667*/
        public void Release()
        {
            /*6668*/
            JsValue ret;
            /*6669*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_Release_0, out ret);
            /*6670*/
        }

        // gen! bool IsSecureConnection()
        /// <summary>
        /// CefSSLStatus methods.
        /// </summary>
        /*6671*/

        public bool IsSecureConnection()/*6672*/
        {
            JsValue ret;
            /*6673*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_IsSecureConnection_1, out ret);
            /*6674*/
            var ret_result = ret.I32 != 0;
            /*6675*/
            return ret_result;
            /*6676*/
        }

        // gen! cef_cert_status_t GetCertStatus()
        /// <summary>
        /// Returns a bitmask containing any and all problems verifying the server
        /// certificate.
        /// /*cef(default_retval=CERT_STATUS_NONE)*/
        /// </summary>
        /*6677*/

        public cef_cert_status_t GetCertStatus()/*6678*/
        {
            JsValue ret;
            /*6679*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetCertStatus_2, out ret);
            /*6680*/
            var ret_result = (cef_cert_status_t)ret.I32;

            /*6681*/
            return ret_result;
            /*6682*/
        }

        // gen! cef_ssl_version_t GetSSLVersion()
        /// <summary>
        /// Returns the SSL version used for the SSL connection.
        /// /*cef(default_retval=SSL_CONNECTION_VERSION_UNKNOWN)*/
        /// </summary>
        /*6683*/

        public cef_ssl_version_t GetSSLVersion()/*6684*/
        {
            JsValue ret;
            /*6685*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetSSLVersion_3, out ret);
            /*6686*/
            var ret_result = (cef_ssl_version_t)ret.I32;

            /*6687*/
            return ret_result;
            /*6688*/
        }

        // gen! cef_ssl_content_status_t GetContentStatus()
        /// <summary>
        /// Returns a bitmask containing the page security content status.
        /// /*cef(default_retval=SSL_CONTENT_NORMAL_CONTENT)*/
        /// </summary>
        /*6689*/

        public cef_ssl_content_status_t GetContentStatus()/*6690*/
        {
            JsValue ret;
            /*6691*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetContentStatus_4, out ret);
            /*6692*/
            var ret_result = (cef_ssl_content_status_t)ret.I32;

            /*6693*/
            return ret_result;
            /*6694*/
        }

        // gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
        /// <summary>
        /// Returns the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*6695*/

        public CefX509Certificate GetX509Certificate()/*6696*/
        {
            JsValue ret;
            /*6697*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetX509Certificate_5, out ret);
            /*6698*/
            var ret_result = new CefX509Certificate(ret.Ptr);
            /*6699*/
            return ret_result;
            /*6700*/
        }
        /*6701*/
    }


    // [virtual] class CefStreamReader
    /// <summary>
    /// Class used to read data from a stream. The methods of this class may be
    /// called on any thread.
    /// /*(source=library)*/
    /// </summary>
    /*6735*/
    public struct CefStreamReader
    {
        /*6736*/
        const int _typeNAME = 32;
        /*6737*/
        const int CefStreamReader_Release_0 = (_typeNAME << 16) | 0;
        /*6738*/
        const int CefStreamReader_Read_1 = (_typeNAME << 16) | 1;
        /*6739*/
        const int CefStreamReader_Seek_2 = (_typeNAME << 16) | 2;
        /*6740*/
        const int CefStreamReader_Tell_3 = (_typeNAME << 16) | 3;
        /*6741*/
        const int CefStreamReader_Eof_4 = (_typeNAME << 16) | 4;
        /*6742*/
        const int CefStreamReader_MayBlock_5 = (_typeNAME << 16) | 5;
        /*6743*/
        internal readonly IntPtr nativePtr;
        /*6744*/
        internal CefStreamReader(IntPtr nativePtr)
        {
            /*6745*/
            this.nativePtr = nativePtr;
            /*6746*/
        }
        /*6747*/
        public void Release()
        {
            /*6748*/
            JsValue ret;
            /*6749*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Release_0, out ret);
            /*6750*/
        }

        // gen! size_t Read(void* ptr,size_t size,size_t n)
        /// <summary>
        /// CefStreamReader methods.
        /// </summary>
        /*6751*/

        public uint Read(IntPtr /*6752*/
        ptr
        , uint /*6753*/
        size
        , uint /*6754*/
        n
        )/*6755*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*6756*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefStreamReader_Read_1, out ret, ref v1, ref v2, ref v3);
            /*6757*/
            var ret_result = (uint)ret.I32;
            /*6758*/
            return ret_result;
            /*6759*/
        }

        // gen! int Seek(int64 offset,int whence)
        /// <summary>
        /// Seek to the specified offset position. |whence| may be any one of
        /// SEEK_CUR, SEEK_END or SEEK_SET. Returns zero on success and non-zero on
        /// failure.
        /// /*cef()*/
        /// </summary>
        /*6760*/

        public int Seek(long /*6761*/
        offset
        , int /*6762*/
        whence
        )/*6763*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*6764*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefStreamReader_Seek_2, out ret, ref v1, ref v2);
            /*6765*/
            var ret_result = ret.I32;
            /*6766*/
            return ret_result;
            /*6767*/
        }

        // gen! int64 Tell()
        /// <summary>
        /// Return the current offset position.
        /// /*cef()*/
        /// </summary>
        /*6768*/

        public long Tell()/*6769*/
        {
            JsValue ret;
            /*6770*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Tell_3, out ret);
            /*6771*/
            var ret_result = ret.I64;
            /*6772*/
            return ret_result;
            /*6773*/
        }

        // gen! int Eof()
        /// <summary>
        /// Return non-zero if at end of file.
        /// /*cef()*/
        /// </summary>
        /*6774*/

        public int Eof()/*6775*/
        {
            JsValue ret;
            /*6776*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Eof_4, out ret);
            /*6777*/
            var ret_result = ret.I32;
            /*6778*/
            return ret_result;
            /*6779*/
        }

        // gen! bool MayBlock()
        /// <summary>
        /// Returns true if this reader performs work like accessing the file system
        /// which may block. Used as a hint for determining the thread to access the
        /// reader from.
        /// /*cef()*/
        /// </summary>
        /*6780*/

        public bool MayBlock()/*6781*/
        {
            JsValue ret;
            /*6782*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_MayBlock_5, out ret);
            /*6783*/
            var ret_result = ret.I32 != 0;
            /*6784*/
            return ret_result;
            /*6785*/
        }
        /*6786*/
    }


    // [virtual] class CefStreamWriter
    /// <summary>
    /// Class used to write data to a stream. The methods of this class may be called
    /// on any thread.
    /// /*(source=library)*/
    /// </summary>
    /*6820*/
    public struct CefStreamWriter
    {
        /*6821*/
        const int _typeNAME = 33;
        /*6822*/
        const int CefStreamWriter_Release_0 = (_typeNAME << 16) | 0;
        /*6823*/
        const int CefStreamWriter_Write_1 = (_typeNAME << 16) | 1;
        /*6824*/
        const int CefStreamWriter_Seek_2 = (_typeNAME << 16) | 2;
        /*6825*/
        const int CefStreamWriter_Tell_3 = (_typeNAME << 16) | 3;
        /*6826*/
        const int CefStreamWriter_Flush_4 = (_typeNAME << 16) | 4;
        /*6827*/
        const int CefStreamWriter_MayBlock_5 = (_typeNAME << 16) | 5;
        /*6828*/
        internal readonly IntPtr nativePtr;
        /*6829*/
        internal CefStreamWriter(IntPtr nativePtr)
        {
            /*6830*/
            this.nativePtr = nativePtr;
            /*6831*/
        }
        /*6832*/
        public void Release()
        {
            /*6833*/
            JsValue ret;
            /*6834*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Release_0, out ret);
            /*6835*/
        }

        // gen! size_t Write(const void* ptr,size_t size,size_t n)
        /// <summary>
        /// CefStreamWriter methods.
        /// </summary>
        /*6836*/

        public uint Write(IntPtr /*6837*/
        ptr
        , uint /*6838*/
        size
        , uint /*6839*/
        n
        )/*6840*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*6841*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefStreamWriter_Write_1, out ret, ref v1, ref v2, ref v3);
            /*6842*/
            var ret_result = (uint)ret.I32;
            /*6843*/
            return ret_result;
            /*6844*/
        }

        // gen! int Seek(int64 offset,int whence)
        /// <summary>
        /// Seek to the specified offset position. |whence| may be any one of
        /// SEEK_CUR, SEEK_END or SEEK_SET. Returns zero on success and non-zero on
        /// failure.
        /// /*cef()*/
        /// </summary>
        /*6845*/

        public int Seek(long /*6846*/
        offset
        , int /*6847*/
        whence
        )/*6848*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*6849*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefStreamWriter_Seek_2, out ret, ref v1, ref v2);
            /*6850*/
            var ret_result = ret.I32;
            /*6851*/
            return ret_result;
            /*6852*/
        }

        // gen! int64 Tell()
        /// <summary>
        /// Return the current offset position.
        /// /*cef()*/
        /// </summary>
        /*6853*/

        public long Tell()/*6854*/
        {
            JsValue ret;
            /*6855*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Tell_3, out ret);
            /*6856*/
            var ret_result = ret.I64;
            /*6857*/
            return ret_result;
            /*6858*/
        }

        // gen! int Flush()
        /// <summary>
        /// Flush the stream.
        /// /*cef()*/
        /// </summary>
        /*6859*/

        public int Flush()/*6860*/
        {
            JsValue ret;
            /*6861*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Flush_4, out ret);
            /*6862*/
            var ret_result = ret.I32;
            /*6863*/
            return ret_result;
            /*6864*/
        }

        // gen! bool MayBlock()
        /// <summary>
        /// Returns true if this writer performs work like accessing the file system
        /// which may block. Used as a hint for determining the thread to access the
        /// writer from.
        /// /*cef()*/
        /// </summary>
        /*6865*/

        public bool MayBlock()/*6866*/
        {
            JsValue ret;
            /*6867*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_MayBlock_5, out ret);
            /*6868*/
            var ret_result = ret.I32 != 0;
            /*6869*/
            return ret_result;
            /*6870*/
        }
        /*6871*/
    }


    // [virtual] class CefStringVisitor
    /// <summary>
    /// Implement this interface to receive string values asynchronously.
    /// /*(source=client)*/
    /// </summary>
    /*6880*/
    public struct CefStringVisitor
    {
        /*6881*/
        const int _typeNAME = 34;
        /*6882*/
        const int CefStringVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*6883*/
        internal readonly IntPtr nativePtr;
        /*6884*/
        internal CefStringVisitor(IntPtr nativePtr)
        {
            /*6885*/
            this.nativePtr = nativePtr;
            /*6886*/
        }
        /*6887*/
        public void Release()
        {
            /*6888*/
            JsValue ret;
            /*6889*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStringVisitor_Release_0, out ret);
            /*6890*/
        }
        /*6891*/
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
    /*6900*/
    public struct CefTask
    {
        /*6901*/
        const int _typeNAME = 35;
        /*6902*/
        const int CefTask_Release_0 = (_typeNAME << 16) | 0;
        /*6903*/
        internal readonly IntPtr nativePtr;
        /*6904*/
        internal CefTask(IntPtr nativePtr)
        {
            /*6905*/
            this.nativePtr = nativePtr;
            /*6906*/
        }
        /*6907*/
        public void Release()
        {
            /*6908*/
            JsValue ret;
            /*6909*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTask_Release_0, out ret);
            /*6910*/
        }
        /*6911*/
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
    /*6945*/
    public struct CefTaskRunner
    {
        /*6946*/
        const int _typeNAME = 36;
        /*6947*/
        const int CefTaskRunner_Release_0 = (_typeNAME << 16) | 0;
        /*6948*/
        const int CefTaskRunner_IsSame_1 = (_typeNAME << 16) | 1;
        /*6949*/
        const int CefTaskRunner_BelongsToCurrentThread_2 = (_typeNAME << 16) | 2;
        /*6950*/
        const int CefTaskRunner_BelongsToThread_3 = (_typeNAME << 16) | 3;
        /*6951*/
        const int CefTaskRunner_PostTask_4 = (_typeNAME << 16) | 4;
        /*6952*/
        const int CefTaskRunner_PostDelayedTask_5 = (_typeNAME << 16) | 5;
        /*6953*/
        internal readonly IntPtr nativePtr;
        /*6954*/
        internal CefTaskRunner(IntPtr nativePtr)
        {
            /*6955*/
            this.nativePtr = nativePtr;
            /*6956*/
        }
        /*6957*/
        public void Release()
        {
            /*6958*/
            JsValue ret;
            /*6959*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTaskRunner_Release_0, out ret);
            /*6960*/
        }

        // gen! bool IsSame(CefRefPtr<CefTaskRunner> that)
        /// <summary>
        /// CefTaskRunner methods.
        /// </summary>
        /*6961*/

        public bool IsSame(CefTaskRunner /*6962*/
        that
        )/*6963*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6964*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_IsSame_1, out ret, ref v1);
            /*6965*/
            var ret_result = ret.I32 != 0;
            /*6966*/
            return ret_result;
            /*6967*/
        }

        // gen! bool BelongsToCurrentThread()
        /// <summary>
        /// Returns true if this task runner belongs to the current thread.
        /// /*cef()*/
        /// </summary>
        /*6968*/

        public bool BelongsToCurrentThread()/*6969*/
        {
            JsValue ret;
            /*6970*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTaskRunner_BelongsToCurrentThread_2, out ret);
            /*6971*/
            var ret_result = ret.I32 != 0;
            /*6972*/
            return ret_result;
            /*6973*/
        }

        // gen! bool BelongsToThread(CefThreadId threadId)
        /// <summary>
        /// Returns true if this task runner is for the specified CEF thread.
        /// /*cef()*/
        /// </summary>
        /*6974*/

        public bool BelongsToThread(cef_thread_id_t /*6975*/
        threadId
        )/*6976*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6977*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_BelongsToThread_3, out ret, ref v1);
            /*6978*/
            var ret_result = ret.I32 != 0;
            /*6979*/
            return ret_result;
            /*6980*/
        }

        // gen! bool PostTask(CefRefPtr<CefTask> task)
        /// <summary>
        /// Post a task for execution on the thread associated with this task runner.
        /// Execution will occur asynchronously.
        /// /*cef()*/
        /// </summary>
        /*6981*/

        public bool PostTask(CefTask /*6982*/
        task
        )/*6983*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6984*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_PostTask_4, out ret, ref v1);
            /*6985*/
            var ret_result = ret.I32 != 0;
            /*6986*/
            return ret_result;
            /*6987*/
        }

        // gen! bool PostDelayedTask(CefRefPtr<CefTask> task,int64 delay_ms)
        /// <summary>
        /// Post a task for delayed execution on the thread associated with this task
        /// runner. Execution will occur asynchronously. Delayed tasks are not
        /// supported on V8 WebWorker threads and will be executed without the
        /// specified delay.
        /// /*cef()*/
        /// </summary>
        /*6988*/

        public bool PostDelayedTask(CefTask /*6989*/
        task
        , long /*6990*/
        delay_ms
        )/*6991*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*6992*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefTaskRunner_PostDelayedTask_5, out ret, ref v1, ref v2);
            /*6993*/
            var ret_result = ret.I32 != 0;
            /*6994*/
            return ret_result;
            /*6995*/
        }
        /*6996*/
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
    /*7035*/
    public struct CefURLRequest
    {
        /*7036*/
        const int _typeNAME = 37;
        /*7037*/
        const int CefURLRequest_Release_0 = (_typeNAME << 16) | 0;
        /*7038*/
        const int CefURLRequest_GetRequest_1 = (_typeNAME << 16) | 1;
        /*7039*/
        const int CefURLRequest_GetClient_2 = (_typeNAME << 16) | 2;
        /*7040*/
        const int CefURLRequest_GetRequestStatus_3 = (_typeNAME << 16) | 3;
        /*7041*/
        const int CefURLRequest_GetRequestError_4 = (_typeNAME << 16) | 4;
        /*7042*/
        const int CefURLRequest_GetResponse_5 = (_typeNAME << 16) | 5;
        /*7043*/
        const int CefURLRequest_Cancel_6 = (_typeNAME << 16) | 6;
        /*7044*/
        internal readonly IntPtr nativePtr;
        /*7045*/
        internal CefURLRequest(IntPtr nativePtr)
        {
            /*7046*/
            this.nativePtr = nativePtr;
            /*7047*/
        }
        /*7048*/
        public void Release()
        {
            /*7049*/
            JsValue ret;
            /*7050*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_Release_0, out ret);
            /*7051*/
        }

        // gen! CefRefPtr<CefRequest> GetRequest()
        /// <summary>
        /// CefURLRequest methods.
        /// </summary>
        /*7052*/

        public CefRequest GetRequest()/*7053*/
        {
            JsValue ret;
            /*7054*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequest_1, out ret);
            /*7055*/
            var ret_result = new CefRequest(ret.Ptr);
            /*7056*/
            return ret_result;
            /*7057*/
        }

        // gen! CefRefPtr<CefURLRequestClient> GetClient()
        /// <summary>
        /// Returns the client.
        /// /*cef()*/
        /// </summary>
        /*7058*/

        public CefURLRequestClient GetClient()/*7059*/
        {
            JsValue ret;
            /*7060*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetClient_2, out ret);
            /*7061*/
            var ret_result = new CefURLRequestClient(ret.Ptr);
            /*7062*/
            return ret_result;
            /*7063*/
        }

        // gen! Status GetRequestStatus()
        /// <summary>
        /// Returns the request status.
        /// /*cef(default_retval=UR_UNKNOWN)*/
        /// </summary>
        /*7064*/

        public cef_urlrequest_status_t GetRequestStatus()/*7065*/
        {
            JsValue ret;
            /*7066*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequestStatus_3, out ret);
            /*7067*/
            var ret_result = (cef_urlrequest_status_t)ret.I32;

            /*7068*/
            return ret_result;
            /*7069*/
        }

        // gen! ErrorCode GetRequestError()
        /// <summary>
        /// Returns the request error if status is UR_CANCELED or UR_FAILED, or 0
        /// otherwise.
        /// /*cef(default_retval=ERR_NONE)*/
        /// </summary>
        /*7070*/

        public cef_errorcode_t GetRequestError()/*7071*/
        {
            JsValue ret;
            /*7072*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequestError_4, out ret);
            /*7073*/
            var ret_result = (cef_errorcode_t)ret.I32;

            /*7074*/
            return ret_result;
            /*7075*/
        }

        // gen! CefRefPtr<CefResponse> GetResponse()
        /// <summary>
        /// Returns the response, or NULL if no response information is available.
        /// Response information will only be available after the upload has completed.
        /// The returned object is read-only and should not be modified.
        /// /*cef()*/
        /// </summary>
        /*7076*/

        public CefResponse GetResponse()/*7077*/
        {
            JsValue ret;
            /*7078*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetResponse_5, out ret);
            /*7079*/
            var ret_result = new CefResponse(ret.Ptr);
            /*7080*/
            return ret_result;
            /*7081*/
        }

        // gen! void Cancel()
        /// <summary>
        /// Cancel the request.
        /// /*cef()*/
        /// </summary>
        /*7082*/

        public void Cancel()/*7083*/
        {
            JsValue ret;
            /*7084*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_Cancel_6, out ret);
            /*7085*/

            /*7086*/
        }
        /*7087*/
    }


    // [virtual] class CefURLRequestClient
    /// <summary>
    /// Interface that should be implemented by the CefURLRequest client. The
    /// methods of this class will be called on the same thread that created the
    /// request unless otherwise documented.
    /// /*(source=client)*/
    /// </summary>
    /*7096*/
    public struct CefURLRequestClient
    {
        /*7097*/
        const int _typeNAME = 38;
        /*7098*/
        const int CefURLRequestClient_Release_0 = (_typeNAME << 16) | 0;
        /*7099*/
        internal readonly IntPtr nativePtr;
        /*7100*/
        internal CefURLRequestClient(IntPtr nativePtr)
        {
            /*7101*/
            this.nativePtr = nativePtr;
            /*7102*/
        }
        /*7103*/
        public void Release()
        {
            /*7104*/
            JsValue ret;
            /*7105*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequestClient_Release_0, out ret);
            /*7106*/
        }
        /*7107*/
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
    /*7161*/
    public struct CefV8Context
    {
        /*7162*/
        const int _typeNAME = 39;
        /*7163*/
        const int CefV8Context_Release_0 = (_typeNAME << 16) | 0;
        /*7164*/
        const int CefV8Context_GetTaskRunner_1 = (_typeNAME << 16) | 1;
        /*7165*/
        const int CefV8Context_IsValid_2 = (_typeNAME << 16) | 2;
        /*7166*/
        const int CefV8Context_GetBrowser_3 = (_typeNAME << 16) | 3;
        /*7167*/
        const int CefV8Context_GetFrame_4 = (_typeNAME << 16) | 4;
        /*7168*/
        const int CefV8Context_GetGlobal_5 = (_typeNAME << 16) | 5;
        /*7169*/
        const int CefV8Context_Enter_6 = (_typeNAME << 16) | 6;
        /*7170*/
        const int CefV8Context_Exit_7 = (_typeNAME << 16) | 7;
        /*7171*/
        const int CefV8Context_IsSame_8 = (_typeNAME << 16) | 8;
        /*7172*/
        const int CefV8Context_Eval_9 = (_typeNAME << 16) | 9;
        /*7173*/
        internal readonly IntPtr nativePtr;
        /*7174*/
        internal CefV8Context(IntPtr nativePtr)
        {
            /*7175*/
            this.nativePtr = nativePtr;
            /*7176*/
        }
        /*7177*/
        public void Release()
        {
            /*7178*/
            JsValue ret;
            /*7179*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Release_0, out ret);
            /*7180*/
        }

        // gen! CefRefPtr<CefTaskRunner> GetTaskRunner()
        /// <summary>
        /// CefV8Context methods.
        /// </summary>
        /*7181*/

        public CefTaskRunner GetTaskRunner()/*7182*/
        {
            JsValue ret;
            /*7183*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetTaskRunner_1, out ret);
            /*7184*/
            var ret_result = new CefTaskRunner(ret.Ptr);
            /*7185*/
            return ret_result;
            /*7186*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// Returns true if the underlying handle is valid and it can be accessed on
        /// the current thread. Do not call any other methods if this method returns
        /// false.
        /// /*cef()*/
        /// </summary>
        /*7187*/

        public bool IsValid()/*7188*/
        {
            JsValue ret;
            /*7189*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_IsValid_2, out ret);
            /*7190*/
            var ret_result = ret.I32 != 0;
            /*7191*/
            return ret_result;
            /*7192*/
        }

        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /// <summary>
        /// Returns the browser for this context. This method will return an empty
        /// reference for WebWorker contexts.
        /// /*cef()*/
        /// </summary>
        /*7193*/

        public CefBrowser GetBrowser()/*7194*/
        {
            JsValue ret;
            /*7195*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetBrowser_3, out ret);
            /*7196*/
            var ret_result = new CefBrowser(ret.Ptr);
            /*7197*/
            return ret_result;
            /*7198*/
        }

        // gen! CefRefPtr<CefFrame> GetFrame()
        /// <summary>
        /// Returns the frame for this context. This method will return an empty
        /// reference for WebWorker contexts.
        /// /*cef()*/
        /// </summary>
        /*7199*/

        public CefFrame GetFrame()/*7200*/
        {
            JsValue ret;
            /*7201*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetFrame_4, out ret);
            /*7202*/
            var ret_result = new CefFrame(ret.Ptr);
            /*7203*/
            return ret_result;
            /*7204*/
        }

        // gen! CefRefPtr<CefV8Value> GetGlobal()
        /// <summary>
        /// Returns the global object for this context. The context must be entered
        /// before calling this method.
        /// /*cef()*/
        /// </summary>
        /*7205*/

        public CefV8Value GetGlobal()/*7206*/
        {
            JsValue ret;
            /*7207*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetGlobal_5, out ret);
            /*7208*/
            var ret_result = new CefV8Value(ret.Ptr);
            /*7209*/
            return ret_result;
            /*7210*/
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
        /*7211*/

        public bool Enter()/*7212*/
        {
            JsValue ret;
            /*7213*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Enter_6, out ret);
            /*7214*/
            var ret_result = ret.I32 != 0;
            /*7215*/
            return ret_result;
            /*7216*/
        }

        // gen! bool Exit()
        /// <summary>
        /// Exit this context. Call this method only after calling Enter(). Returns
        /// true if the scope was exited successfully.
        /// /*cef()*/
        /// </summary>
        /*7217*/

        public bool Exit()/*7218*/
        {
            JsValue ret;
            /*7219*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Exit_7, out ret);
            /*7220*/
            var ret_result = ret.I32 != 0;
            /*7221*/
            return ret_result;
            /*7222*/
        }

        // gen! bool IsSame(CefRefPtr<CefV8Context> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>
        /*7223*/

        public bool IsSame(CefV8Context /*7224*/
        that
        )/*7225*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*7226*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Context_IsSame_8, out ret, ref v1);
            /*7227*/
            var ret_result = ret.I32 != 0;
            /*7228*/
            return ret_result;
            /*7229*/
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
        /*7230*/

        public bool Eval(string /*7231*/
        code
        , string /*7232*/
        script_url
        , int /*7233*/
        start_line
        , IntPtr /*7234*/
        retval
        , IntPtr /*7235*/
        exception
        )/*7236*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(code);
            /*7237*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(script_url);
            /*7238*/
            ;
            /*7239*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefV8Context_Eval_9, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*7240*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*7241*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*7242*/
            ;
            retval = v4.Ptr;/*7243*/
            ;
            exception = v5.Ptr;/*7244*/
            ;
            /*7245*/
            return ret_result;
            /*7246*/
        }
        /*7247*/
    }


    // [virtual] class CefV8Accessor
    /// <summary>
    /// Interface that should be implemented to handle V8 accessor calls. Accessor
    /// identifiers are registered by calling CefV8Value::SetValue(). The methods
    /// of this class will be called on the thread associated with the V8 accessor.
    /// /*(source=client)*/
    /// </summary>
    /*7256*/
    public struct CefV8Accessor
    {
        /*7257*/
        const int _typeNAME = 40;
        /*7258*/
        const int CefV8Accessor_Release_0 = (_typeNAME << 16) | 0;
        /*7259*/
        internal readonly IntPtr nativePtr;
        /*7260*/
        internal CefV8Accessor(IntPtr nativePtr)
        {
            /*7261*/
            this.nativePtr = nativePtr;
            /*7262*/
        }
        /*7263*/
        public void Release()
        {
            /*7264*/
            JsValue ret;
            /*7265*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Accessor_Release_0, out ret);
            /*7266*/
        }
        /*7267*/
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
    /*7276*/
    public struct CefV8Interceptor
    {
        /*7277*/
        const int _typeNAME = 41;
        /*7278*/
        const int CefV8Interceptor_Release_0 = (_typeNAME << 16) | 0;
        /*7279*/
        internal readonly IntPtr nativePtr;
        /*7280*/
        internal CefV8Interceptor(IntPtr nativePtr)
        {
            /*7281*/
            this.nativePtr = nativePtr;
            /*7282*/
        }
        /*7283*/
        public void Release()
        {
            /*7284*/
            JsValue ret;
            /*7285*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Interceptor_Release_0, out ret);
            /*7286*/
        }
        /*7287*/
    }


    // [virtual] class CefV8Exception
    /// <summary>
    /// Class representing a V8 exception. The methods of this class may be called on
    /// any render process thread.
    /// /*(source=library)*/
    /// </summary>
    /*7336*/
    public struct CefV8Exception
    {
        /*7337*/
        const int _typeNAME = 42;
        /*7338*/
        const int CefV8Exception_Release_0 = (_typeNAME << 16) | 0;
        /*7339*/
        const int CefV8Exception_GetMessage_1 = (_typeNAME << 16) | 1;
        /*7340*/
        const int CefV8Exception_GetSourceLine_2 = (_typeNAME << 16) | 2;
        /*7341*/
        const int CefV8Exception_GetScriptResourceName_3 = (_typeNAME << 16) | 3;
        /*7342*/
        const int CefV8Exception_GetLineNumber_4 = (_typeNAME << 16) | 4;
        /*7343*/
        const int CefV8Exception_GetStartPosition_5 = (_typeNAME << 16) | 5;
        /*7344*/
        const int CefV8Exception_GetEndPosition_6 = (_typeNAME << 16) | 6;
        /*7345*/
        const int CefV8Exception_GetStartColumn_7 = (_typeNAME << 16) | 7;
        /*7346*/
        const int CefV8Exception_GetEndColumn_8 = (_typeNAME << 16) | 8;
        /*7347*/
        internal readonly IntPtr nativePtr;
        /*7348*/
        internal CefV8Exception(IntPtr nativePtr)
        {
            /*7349*/
            this.nativePtr = nativePtr;
            /*7350*/
        }
        /*7351*/
        public void Release()
        {
            /*7352*/
            JsValue ret;
            /*7353*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_Release_0, out ret);
            /*7354*/
        }

        // gen! CefString GetMessage()
        /// <summary>
        /// CefV8Exception methods.
        /// </summary>
        /*7355*/

        public string GetMessage()/*7356*/
        {
            JsValue ret;
            /*7357*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetMessage_1, out ret);
            /*7358*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*7359*/
            return ret_result;
            /*7360*/
        }

        // gen! CefString GetSourceLine()
        /// <summary>
        /// Returns the line of source code that the exception occurred within.
        /// /*cef()*/
        /// </summary>
        /*7361*/

        public string GetSourceLine()/*7362*/
        {
            JsValue ret;
            /*7363*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetSourceLine_2, out ret);
            /*7364*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*7365*/
            return ret_result;
            /*7366*/
        }

        // gen! CefString GetScriptResourceName()
        /// <summary>
        /// Returns the resource name for the script from where the function causing
        /// the error originates.
        /// /*cef()*/
        /// </summary>
        /*7367*/

        public string GetScriptResourceName()/*7368*/
        {
            JsValue ret;
            /*7369*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetScriptResourceName_3, out ret);
            /*7370*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*7371*/
            return ret_result;
            /*7372*/
        }

        // gen! int GetLineNumber()
        /// <summary>
        /// Returns the 1-based number of the line where the error occurred or 0 if the
        /// line number is unknown.
        /// /*cef()*/
        /// </summary>
        /*7373*/

        public int GetLineNumber()/*7374*/
        {
            JsValue ret;
            /*7375*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetLineNumber_4, out ret);
            /*7376*/
            var ret_result = ret.I32;
            /*7377*/
            return ret_result;
            /*7378*/
        }

        // gen! int GetStartPosition()
        /// <summary>
        /// Returns the index within the script of the first character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>
        /*7379*/

        public int GetStartPosition()/*7380*/
        {
            JsValue ret;
            /*7381*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetStartPosition_5, out ret);
            /*7382*/
            var ret_result = ret.I32;
            /*7383*/
            return ret_result;
            /*7384*/
        }

        // gen! int GetEndPosition()
        /// <summary>
        /// Returns the index within the script of the last character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>
        /*7385*/

        public int GetEndPosition()/*7386*/
        {
            JsValue ret;
            /*7387*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetEndPosition_6, out ret);
            /*7388*/
            var ret_result = ret.I32;
            /*7389*/
            return ret_result;
            /*7390*/
        }

        // gen! int GetStartColumn()
        /// <summary>
        /// Returns the index within the line of the first character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>
        /*7391*/

        public int GetStartColumn()/*7392*/
        {
            JsValue ret;
            /*7393*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetStartColumn_7, out ret);
            /*7394*/
            var ret_result = ret.I32;
            /*7395*/
            return ret_result;
            /*7396*/
        }

        // gen! int GetEndColumn()
        /// <summary>
        /// Returns the index within the line of the last character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>
        /*7397*/

        public int GetEndColumn()/*7398*/
        {
            JsValue ret;
            /*7399*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetEndColumn_8, out ret);
            /*7400*/
            var ret_result = ret.I32;
            /*7401*/
            return ret_result;
            /*7402*/
        }
        /*7403*/
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
    /*7632*/
    public struct CefV8Value
    {
        /*7633*/
        const int _typeNAME = 43;
        /*7634*/
        const int CefV8Value_Release_0 = (_typeNAME << 16) | 0;
        /*7635*/
        const int CefV8Value_IsValid_1 = (_typeNAME << 16) | 1;
        /*7636*/
        const int CefV8Value_IsUndefined_2 = (_typeNAME << 16) | 2;
        /*7637*/
        const int CefV8Value_IsNull_3 = (_typeNAME << 16) | 3;
        /*7638*/
        const int CefV8Value_IsBool_4 = (_typeNAME << 16) | 4;
        /*7639*/
        const int CefV8Value_IsInt_5 = (_typeNAME << 16) | 5;
        /*7640*/
        const int CefV8Value_IsUInt_6 = (_typeNAME << 16) | 6;
        /*7641*/
        const int CefV8Value_IsDouble_7 = (_typeNAME << 16) | 7;
        /*7642*/
        const int CefV8Value_IsDate_8 = (_typeNAME << 16) | 8;
        /*7643*/
        const int CefV8Value_IsString_9 = (_typeNAME << 16) | 9;
        /*7644*/
        const int CefV8Value_IsObject_10 = (_typeNAME << 16) | 10;
        /*7645*/
        const int CefV8Value_IsArray_11 = (_typeNAME << 16) | 11;
        /*7646*/
        const int CefV8Value_IsFunction_12 = (_typeNAME << 16) | 12;
        /*7647*/
        const int CefV8Value_IsSame_13 = (_typeNAME << 16) | 13;
        /*7648*/
        const int CefV8Value_GetBoolValue_14 = (_typeNAME << 16) | 14;
        /*7649*/
        const int CefV8Value_GetIntValue_15 = (_typeNAME << 16) | 15;
        /*7650*/
        const int CefV8Value_GetUIntValue_16 = (_typeNAME << 16) | 16;
        /*7651*/
        const int CefV8Value_GetDoubleValue_17 = (_typeNAME << 16) | 17;
        /*7652*/
        const int CefV8Value_GetDateValue_18 = (_typeNAME << 16) | 18;
        /*7653*/
        const int CefV8Value_GetStringValue_19 = (_typeNAME << 16) | 19;
        /*7654*/
        const int CefV8Value_IsUserCreated_20 = (_typeNAME << 16) | 20;
        /*7655*/
        const int CefV8Value_HasException_21 = (_typeNAME << 16) | 21;
        /*7656*/
        const int CefV8Value_GetException_22 = (_typeNAME << 16) | 22;
        /*7657*/
        const int CefV8Value_ClearException_23 = (_typeNAME << 16) | 23;
        /*7658*/
        const int CefV8Value_WillRethrowExceptions_24 = (_typeNAME << 16) | 24;
        /*7659*/
        const int CefV8Value_SetRethrowExceptions_25 = (_typeNAME << 16) | 25;
        /*7660*/
        const int CefV8Value_HasValue_26 = (_typeNAME << 16) | 26;
        /*7661*/
        const int CefV8Value_HasValue_27 = (_typeNAME << 16) | 27;
        /*7662*/
        const int CefV8Value_DeleteValue_28 = (_typeNAME << 16) | 28;
        /*7663*/
        const int CefV8Value_DeleteValue_29 = (_typeNAME << 16) | 29;
        /*7664*/
        const int CefV8Value_GetValue_30 = (_typeNAME << 16) | 30;
        /*7665*/
        const int CefV8Value_GetValue_31 = (_typeNAME << 16) | 31;
        /*7666*/
        const int CefV8Value_SetValue_32 = (_typeNAME << 16) | 32;
        /*7667*/
        const int CefV8Value_SetValue_33 = (_typeNAME << 16) | 33;
        /*7668*/
        const int CefV8Value_SetValue_34 = (_typeNAME << 16) | 34;
        /*7669*/
        const int CefV8Value_GetKeys_35 = (_typeNAME << 16) | 35;
        /*7670*/
        const int CefV8Value_SetUserData_36 = (_typeNAME << 16) | 36;
        /*7671*/
        const int CefV8Value_GetUserData_37 = (_typeNAME << 16) | 37;
        /*7672*/
        const int CefV8Value_GetExternallyAllocatedMemory_38 = (_typeNAME << 16) | 38;
        /*7673*/
        const int CefV8Value_AdjustExternallyAllocatedMemory_39 = (_typeNAME << 16) | 39;
        /*7674*/
        const int CefV8Value_GetArrayLength_40 = (_typeNAME << 16) | 40;
        /*7675*/
        const int CefV8Value_GetFunctionName_41 = (_typeNAME << 16) | 41;
        /*7676*/
        const int CefV8Value_GetFunctionHandler_42 = (_typeNAME << 16) | 42;
        /*7677*/
        const int CefV8Value_ExecuteFunction_43 = (_typeNAME << 16) | 43;
        /*7678*/
        const int CefV8Value_ExecuteFunctionWithContext_44 = (_typeNAME << 16) | 44;
        /*7679*/
        internal readonly IntPtr nativePtr;
        /*7680*/
        internal CefV8Value(IntPtr nativePtr)
        {
            /*7681*/
            this.nativePtr = nativePtr;
            /*7682*/
        }
        /*7683*/
        public void Release()
        {
            /*7684*/
            JsValue ret;
            /*7685*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_Release_0, out ret);
            /*7686*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefV8Value methods.
        /// </summary>
        /*7687*/

        public bool IsValid()/*7688*/
        {
            JsValue ret;
            /*7689*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsValid_1, out ret);
            /*7690*/
            var ret_result = ret.I32 != 0;
            /*7691*/
            return ret_result;
            /*7692*/
        }

        // gen! bool IsUndefined()
        /// <summary>
        /// True if the value type is undefined.
        /// /*cef()*/
        /// </summary>
        /*7693*/

        public bool IsUndefined()/*7694*/
        {
            JsValue ret;
            /*7695*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUndefined_2, out ret);
            /*7696*/
            var ret_result = ret.I32 != 0;
            /*7697*/
            return ret_result;
            /*7698*/
        }

        // gen! bool IsNull()
        /// <summary>
        /// True if the value type is null.
        /// /*cef()*/
        /// </summary>
        /*7699*/

        public bool IsNull()/*7700*/
        {
            JsValue ret;
            /*7701*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsNull_3, out ret);
            /*7702*/
            var ret_result = ret.I32 != 0;
            /*7703*/
            return ret_result;
            /*7704*/
        }

        // gen! bool IsBool()
        /// <summary>
        /// True if the value type is bool.
        /// /*cef()*/
        /// </summary>
        /*7705*/

        public bool IsBool()/*7706*/
        {
            JsValue ret;
            /*7707*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsBool_4, out ret);
            /*7708*/
            var ret_result = ret.I32 != 0;
            /*7709*/
            return ret_result;
            /*7710*/
        }

        // gen! bool IsInt()
        /// <summary>
        /// True if the value type is int.
        /// /*cef()*/
        /// </summary>
        /*7711*/

        public bool IsInt()/*7712*/
        {
            JsValue ret;
            /*7713*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsInt_5, out ret);
            /*7714*/
            var ret_result = ret.I32 != 0;
            /*7715*/
            return ret_result;
            /*7716*/
        }

        // gen! bool IsUInt()
        /// <summary>
        /// True if the value type is unsigned int.
        /// /*cef()*/
        /// </summary>
        /*7717*/

        public bool IsUInt()/*7718*/
        {
            JsValue ret;
            /*7719*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUInt_6, out ret);
            /*7720*/
            var ret_result = ret.I32 != 0;
            /*7721*/
            return ret_result;
            /*7722*/
        }

        // gen! bool IsDouble()
        /// <summary>
        /// True if the value type is double.
        /// /*cef()*/
        /// </summary>
        /*7723*/

        public bool IsDouble()/*7724*/
        {
            JsValue ret;
            /*7725*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsDouble_7, out ret);
            /*7726*/
            var ret_result = ret.I32 != 0;
            /*7727*/
            return ret_result;
            /*7728*/
        }

        // gen! bool IsDate()
        /// <summary>
        /// True if the value type is Date.
        /// /*cef()*/
        /// </summary>
        /*7729*/

        public bool IsDate()/*7730*/
        {
            JsValue ret;
            /*7731*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsDate_8, out ret);
            /*7732*/
            var ret_result = ret.I32 != 0;
            /*7733*/
            return ret_result;
            /*7734*/
        }

        // gen! bool IsString()
        /// <summary>
        /// True if the value type is string.
        /// /*cef()*/
        /// </summary>
        /*7735*/

        public bool IsString()/*7736*/
        {
            JsValue ret;
            /*7737*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsString_9, out ret);
            /*7738*/
            var ret_result = ret.I32 != 0;
            /*7739*/
            return ret_result;
            /*7740*/
        }

        // gen! bool IsObject()
        /// <summary>
        /// True if the value type is object.
        /// /*cef()*/
        /// </summary>
        /*7741*/

        public bool IsObject()/*7742*/
        {
            JsValue ret;
            /*7743*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsObject_10, out ret);
            /*7744*/
            var ret_result = ret.I32 != 0;
            /*7745*/
            return ret_result;
            /*7746*/
        }

        // gen! bool IsArray()
        /// <summary>
        /// True if the value type is array.
        /// /*cef()*/
        /// </summary>
        /*7747*/

        public bool IsArray()/*7748*/
        {
            JsValue ret;
            /*7749*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsArray_11, out ret);
            /*7750*/
            var ret_result = ret.I32 != 0;
            /*7751*/
            return ret_result;
            /*7752*/
        }

        // gen! bool IsFunction()
        /// <summary>
        /// True if the value type is function.
        /// /*cef()*/
        /// </summary>
        /*7753*/

        public bool IsFunction()/*7754*/
        {
            JsValue ret;
            /*7755*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsFunction_12, out ret);
            /*7756*/
            var ret_result = ret.I32 != 0;
            /*7757*/
            return ret_result;
            /*7758*/
        }

        // gen! bool IsSame(CefRefPtr<CefV8Value> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>
        /*7759*/

        public bool IsSame(CefV8Value /*7760*/
        that
        )/*7761*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*7762*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_IsSame_13, out ret, ref v1);
            /*7763*/
            var ret_result = ret.I32 != 0;
            /*7764*/
            return ret_result;
            /*7765*/
        }

        // gen! bool GetBoolValue()
        /// <summary>
        /// Return a bool value.
        /// /*cef()*/
        /// </summary>
        /*7766*/

        public bool GetBoolValue()/*7767*/
        {
            JsValue ret;
            /*7768*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetBoolValue_14, out ret);
            /*7769*/
            var ret_result = ret.I32 != 0;
            /*7770*/
            return ret_result;
            /*7771*/
        }

        // gen! int32 GetIntValue()
        /// <summary>
        /// Return an int value.
        /// /*cef()*/
        /// </summary>
        /*7772*/

        public int GetIntValue()/*7773*/
        {
            JsValue ret;
            /*7774*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetIntValue_15, out ret);
            /*7775*/
            var ret_result = ret.I32;
            /*7776*/
            return ret_result;
            /*7777*/
        }

        // gen! uint32 GetUIntValue()
        /// <summary>
        /// Return an unsigned int value.
        /// /*cef()*/
        /// </summary>
        /*7778*/

        public uint GetUIntValue()/*7779*/
        {
            JsValue ret;
            /*7780*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetUIntValue_16, out ret);
            /*7781*/
            var ret_result = (uint)ret.I32;
            /*7782*/
            return ret_result;
            /*7783*/
        }

        // gen! double GetDoubleValue()
        /// <summary>
        /// Return a double value.
        /// /*cef()*/
        /// </summary>
        /*7784*/

        public double GetDoubleValue()/*7785*/
        {
            JsValue ret;
            /*7786*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetDoubleValue_17, out ret);
            /*7787*/
            var ret_result = ret.Num;
            /*7788*/
            return ret_result;
            /*7789*/
        }

        // gen! CefTime GetDateValue()
        /// <summary>
        /// Return a Date value.
        /// /*cef()*/
        /// </summary>
        /*7790*/

        public CefTime GetDateValue()/*7791*/
        {
            JsValue ret;
            /*7792*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetDateValue_18, out ret);
            /*7793*/
            var ret_result = new CefTime(ret.Ptr);

            /*7794*/
            return ret_result;
            /*7795*/
        }

        // gen! CefString GetStringValue()
        /// <summary>
        /// Return a string value.
        /// /*cef()*/
        /// </summary>
        /*7796*/

        public string GetStringValue()/*7797*/
        {
            JsValue ret;
            /*7798*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetStringValue_19, out ret);
            /*7799*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*7800*/
            return ret_result;
            /*7801*/
        }

        // gen! bool IsUserCreated()
        /// <summary>
        /// OBJECT METHODS - These methods are only available on objects. Arrays and
        /// functions are also objects. String- and integer-based keys can be used
        /// interchangably with the framework converting between them as necessary.
        /// Returns true if this is a user created object.
        /// /*cef()*/
        /// </summary>
        /*7802*/

        public bool IsUserCreated()/*7803*/
        {
            JsValue ret;
            /*7804*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUserCreated_20, out ret);
            /*7805*/
            var ret_result = ret.I32 != 0;
            /*7806*/
            return ret_result;
            /*7807*/
        }

        // gen! bool HasException()
        /// <summary>
        /// Returns true if the last method call resulted in an exception. This
        /// attribute exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>
        /*7808*/

        public bool HasException()/*7809*/
        {
            JsValue ret;
            /*7810*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_HasException_21, out ret);
            /*7811*/
            var ret_result = ret.I32 != 0;
            /*7812*/
            return ret_result;
            /*7813*/
        }

        // gen! CefRefPtr<CefV8Exception> GetException()
        /// <summary>
        /// Returns the exception resulting from the last method call. This attribute
        /// exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>
        /*7814*/

        public CefV8Exception GetException()/*7815*/
        {
            JsValue ret;
            /*7816*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetException_22, out ret);
            /*7817*/
            var ret_result = new CefV8Exception(ret.Ptr);
            /*7818*/
            return ret_result;
            /*7819*/
        }

        // gen! bool ClearException()
        /// <summary>
        /// Clears the last exception and returns true on success.
        /// /*cef()*/
        /// </summary>
        /*7820*/

        public bool ClearException()/*7821*/
        {
            JsValue ret;
            /*7822*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_ClearException_23, out ret);
            /*7823*/
            var ret_result = ret.I32 != 0;
            /*7824*/
            return ret_result;
            /*7825*/
        }

        // gen! bool WillRethrowExceptions()
        /// <summary>
        /// Returns true if this object will re-throw future exceptions. This attribute
        /// exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>
        /*7826*/

        public bool WillRethrowExceptions()/*7827*/
        {
            JsValue ret;
            /*7828*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_WillRethrowExceptions_24, out ret);
            /*7829*/
            var ret_result = ret.I32 != 0;
            /*7830*/
            return ret_result;
            /*7831*/
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
        /*7832*/

        public bool SetRethrowExceptions(bool /*7833*/
        rethrow
        )/*7834*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*7835*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_SetRethrowExceptions_25, out ret, ref v1);
            /*7836*/
            var ret_result = ret.I32 != 0;
            /*7837*/
            return ret_result;
            /*7838*/
        }

        // gen! bool HasValue(const CefString& key)
        /*7839*/

        public bool HasValue(string /*7840*/
        key
        )/*7841*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*7842*/
            ;
            /*7843*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_HasValue_26, out ret, ref v1);
            /*7844*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*7845*/
            ;
            /*7846*/
            return ret_result;
            /*7847*/
        }

        // gen! bool HasValue(int index)
        /*7848*/

        public bool HasValue(int /*7849*/
        index
        )/*7850*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*7851*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_HasValue_27, out ret, ref v1);
            /*7852*/
            var ret_result = ret.I32 != 0;
            /*7853*/
            return ret_result;
            /*7854*/
        }

        // gen! bool DeleteValue(const CefString& key)
        /*7855*/

        public bool DeleteValue(string /*7856*/
        key
        )/*7857*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*7858*/
            ;
            /*7859*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_DeleteValue_28, out ret, ref v1);
            /*7860*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*7861*/
            ;
            /*7862*/
            return ret_result;
            /*7863*/
        }

        // gen! bool DeleteValue(int index)
        /*7864*/

        public bool DeleteValue(int /*7865*/
        index
        )/*7866*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*7867*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_DeleteValue_29, out ret, ref v1);
            /*7868*/
            var ret_result = ret.I32 != 0;
            /*7869*/
            return ret_result;
            /*7870*/
        }

        // gen! CefRefPtr<CefV8Value> GetValue(const CefString& key)
        /*7871*/

        public CefV8Value GetValue(string /*7872*/
        key
        )/*7873*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*7874*/
            ;
            /*7875*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetValue_30, out ret, ref v1);
            /*7876*/
            var ret_result = new CefV8Value(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*7877*/
            ;
            /*7878*/
            return ret_result;
            /*7879*/
        }

        // gen! CefRefPtr<CefV8Value> GetValue(int index)
        /*7880*/

        public CefV8Value GetValue(int /*7881*/
        index
        )/*7882*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*7883*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetValue_31, out ret, ref v1);
            /*7884*/
            var ret_result = new CefV8Value(ret.Ptr);
            /*7885*/
            return ret_result;
            /*7886*/
        }

        // gen! bool SetValue(const CefString& key,CefRefPtr<CefV8Value> value,PropertyAttribute attribute)
        /*7887*/

        public bool SetValue(string /*7888*/
        key
        , CefV8Value /*7889*/
        value
        , cef_v8_propertyattribute_t /*7890*/
        attribute
        )/*7891*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*7892*/
            ;
            /*7893*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_SetValue_32, out ret, ref v1, ref v2, ref v3);
            /*7894*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*7895*/
            ;
            /*7896*/
            return ret_result;
            /*7897*/
        }

        // gen! bool SetValue(int index,CefRefPtr<CefV8Value> value)
        /*7898*/

        public bool SetValue(int /*7899*/
        index
        , CefV8Value /*7900*/
        value
        )/*7901*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*7902*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefV8Value_SetValue_33, out ret, ref v1, ref v2);
            /*7903*/
            var ret_result = ret.I32 != 0;
            /*7904*/
            return ret_result;
            /*7905*/
        }

        // gen! bool SetValue(const CefString& key,AccessControl settings,PropertyAttribute attribute)
        /*7906*/

        public bool SetValue(string /*7907*/
        key
        , cef_v8_accesscontrol_t /*7908*/
        settings
        , cef_v8_propertyattribute_t /*7909*/
        attribute
        )/*7910*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*7911*/
            ;
            /*7912*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_SetValue_34, out ret, ref v1, ref v2, ref v3);
            /*7913*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*7914*/
            ;
            /*7915*/
            return ret_result;
            /*7916*/
        }

        // gen! bool GetKeys(std::vector<CefString>& keys)
        /// <summary>
        /// Read the keys for the object's values into the specified vector. Integer-
        /// based keys will also be returned as strings.
        /// /*cef()*/
        /// </summary>
        /*7917*/

        public bool GetKeys(List<string> /*7918*/
        keys
        )/*7919*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*7920*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetKeys_35, out ret, ref v1);
            /*7921*/
            var ret_result = ret.I32 != 0;
            /*7922*/
            return ret_result;
            /*7923*/
        }

        // gen! bool SetUserData(CefRefPtr<CefBaseRefCounted> user_data)
        /// <summary>
        /// Sets the user data for this object and returns true on success. Returns
        /// false if this method is called incorrectly. This method can only be called
        /// on user created objects.
        /// /*cef(optional_param=user_data)*/
        /// </summary>
        /*7924*/

        public bool SetUserData(CefBaseRefCounted /*7925*/
        user_data
        )/*7926*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*7927*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_SetUserData_36, out ret, ref v1);
            /*7928*/
            var ret_result = ret.I32 != 0;
            /*7929*/
            return ret_result;
            /*7930*/
        }

        // gen! CefRefPtr<CefBaseRefCounted> GetUserData()
        /// <summary>
        /// Returns the user data, if any, assigned to this object.
        /// /*cef()*/
        /// </summary>
        /*7931*/

        public CefBaseRefCounted GetUserData()/*7932*/
        {
            JsValue ret;
            /*7933*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetUserData_37, out ret);
            /*7934*/
            var ret_result = new CefBaseRefCounted(ret.Ptr);
            /*7935*/
            return ret_result;
            /*7936*/
        }

        // gen! int GetExternallyAllocatedMemory()
        /// <summary>
        /// Returns the amount of externally allocated memory registered for the
        /// object.
        /// /*cef()*/
        /// </summary>
        /*7937*/

        public int GetExternallyAllocatedMemory()/*7938*/
        {
            JsValue ret;
            /*7939*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetExternallyAllocatedMemory_38, out ret);
            /*7940*/
            var ret_result = ret.I32;
            /*7941*/
            return ret_result;
            /*7942*/
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
        /*7943*/

        public int AdjustExternallyAllocatedMemory(int /*7944*/
        change_in_bytes
        )/*7945*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*7946*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_AdjustExternallyAllocatedMemory_39, out ret, ref v1);
            /*7947*/
            var ret_result = ret.I32;
            /*7948*/
            return ret_result;
            /*7949*/
        }

        // gen! int GetArrayLength()
        /// <summary>
        /// ARRAY METHODS - These methods are only available on arrays.
        /// Returns the number of elements in the array.
        /// /*cef()*/
        /// </summary>
        /*7950*/

        public int GetArrayLength()/*7951*/
        {
            JsValue ret;
            /*7952*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetArrayLength_40, out ret);
            /*7953*/
            var ret_result = ret.I32;
            /*7954*/
            return ret_result;
            /*7955*/
        }

        // gen! CefString GetFunctionName()
        /// <summary>
        /// FUNCTION METHODS - These methods are only available on functions.
        /// Returns the function name.
        /// /*cef()*/
        /// </summary>
        /*7956*/

        public string GetFunctionName()/*7957*/
        {
            JsValue ret;
            /*7958*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetFunctionName_41, out ret);
            /*7959*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*7960*/
            return ret_result;
            /*7961*/
        }

        // gen! CefRefPtr<CefV8Handler> GetFunctionHandler()
        /// <summary>
        /// Returns the function handler or NULL if not a CEF-created function.
        /// /*cef()*/
        /// </summary>
        /*7962*/

        public CefV8Handler GetFunctionHandler()/*7963*/
        {
            JsValue ret;
            /*7964*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetFunctionHandler_42, out ret);
            /*7965*/
            var ret_result = new CefV8Handler(ret.Ptr);
            /*7966*/
            return ret_result;
            /*7967*/
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
        /*7968*/

        public CefV8Value ExecuteFunction(CefV8Value /*7969*/
        _object
        , CefV8ValueList /*7970*/
        arguments
        )/*7971*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*7972*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefV8Value_ExecuteFunction_43, out ret, ref v1, ref v2);
            /*7973*/
            var ret_result = new CefV8Value(ret.Ptr);
            /*7974*/
            return ret_result;
            /*7975*/
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
        /*7976*/

        public CefV8Value ExecuteFunctionWithContext(CefV8Context /*7977*/
        context
        , CefV8Value /*7978*/
        _object
        , CefV8ValueList /*7979*/
        arguments
        )/*7980*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*7981*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_ExecuteFunctionWithContext_44, out ret, ref v1, ref v2, ref v3);
            /*7982*/
            var ret_result = new CefV8Value(ret.Ptr);
            /*7983*/
            return ret_result;
            /*7984*/
        }
        /*7985*/
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
    /*8009*/
    public struct CefV8StackTrace
    {
        /*8010*/
        const int _typeNAME = 44;
        /*8011*/
        const int CefV8StackTrace_Release_0 = (_typeNAME << 16) | 0;
        /*8012*/
        const int CefV8StackTrace_IsValid_1 = (_typeNAME << 16) | 1;
        /*8013*/
        const int CefV8StackTrace_GetFrameCount_2 = (_typeNAME << 16) | 2;
        /*8014*/
        const int CefV8StackTrace_GetFrame_3 = (_typeNAME << 16) | 3;
        /*8015*/
        internal readonly IntPtr nativePtr;
        /*8016*/
        internal CefV8StackTrace(IntPtr nativePtr)
        {
            /*8017*/
            this.nativePtr = nativePtr;
            /*8018*/
        }
        /*8019*/
        public void Release()
        {
            /*8020*/
            JsValue ret;
            /*8021*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_Release_0, out ret);
            /*8022*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefV8StackTrace methods.
        /// </summary>
        /*8023*/

        public bool IsValid()/*8024*/
        {
            JsValue ret;
            /*8025*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_IsValid_1, out ret);
            /*8026*/
            var ret_result = ret.I32 != 0;
            /*8027*/
            return ret_result;
            /*8028*/
        }

        // gen! int GetFrameCount()
        /// <summary>
        /// Returns the number of stack frames.
        /// /*cef()*/
        /// </summary>
        /*8029*/

        public int GetFrameCount()/*8030*/
        {
            JsValue ret;
            /*8031*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_GetFrameCount_2, out ret);
            /*8032*/
            var ret_result = ret.I32;
            /*8033*/
            return ret_result;
            /*8034*/
        }

        // gen! CefRefPtr<CefV8StackFrame> GetFrame(int index)
        /// <summary>
        /// Returns the stack frame at the specified 0-based index.
        /// /*cef()*/
        /// </summary>
        /*8035*/

        public CefV8StackFrame GetFrame(int /*8036*/
        index
        )/*8037*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8038*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8StackTrace_GetFrame_3, out ret, ref v1);
            /*8039*/
            var ret_result = new CefV8StackFrame(ret.Ptr);
            /*8040*/
            return ret_result;
            /*8041*/
        }
        /*8042*/
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
    /*8091*/
    public struct CefV8StackFrame
    {
        /*8092*/
        const int _typeNAME = 45;
        /*8093*/
        const int CefV8StackFrame_Release_0 = (_typeNAME << 16) | 0;
        /*8094*/
        const int CefV8StackFrame_IsValid_1 = (_typeNAME << 16) | 1;
        /*8095*/
        const int CefV8StackFrame_GetScriptName_2 = (_typeNAME << 16) | 2;
        /*8096*/
        const int CefV8StackFrame_GetScriptNameOrSourceURL_3 = (_typeNAME << 16) | 3;
        /*8097*/
        const int CefV8StackFrame_GetFunctionName_4 = (_typeNAME << 16) | 4;
        /*8098*/
        const int CefV8StackFrame_GetLineNumber_5 = (_typeNAME << 16) | 5;
        /*8099*/
        const int CefV8StackFrame_GetColumn_6 = (_typeNAME << 16) | 6;
        /*8100*/
        const int CefV8StackFrame_IsEval_7 = (_typeNAME << 16) | 7;
        /*8101*/
        const int CefV8StackFrame_IsConstructor_8 = (_typeNAME << 16) | 8;
        /*8102*/
        internal readonly IntPtr nativePtr;
        /*8103*/
        internal CefV8StackFrame(IntPtr nativePtr)
        {
            /*8104*/
            this.nativePtr = nativePtr;
            /*8105*/
        }
        /*8106*/
        public void Release()
        {
            /*8107*/
            JsValue ret;
            /*8108*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_Release_0, out ret);
            /*8109*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefV8StackFrame methods.
        /// </summary>
        /*8110*/

        public bool IsValid()/*8111*/
        {
            JsValue ret;
            /*8112*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsValid_1, out ret);
            /*8113*/
            var ret_result = ret.I32 != 0;
            /*8114*/
            return ret_result;
            /*8115*/
        }

        // gen! CefString GetScriptName()
        /// <summary>
        /// Returns the name of the resource script that contains the function.
        /// /*cef()*/
        /// </summary>
        /*8116*/

        public string GetScriptName()/*8117*/
        {
            JsValue ret;
            /*8118*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetScriptName_2, out ret);
            /*8119*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8120*/
            return ret_result;
            /*8121*/
        }

        // gen! CefString GetScriptNameOrSourceURL()
        /// <summary>
        /// Returns the name of the resource script that contains the function or the
        /// sourceURL value if the script name is undefined and its source ends with
        /// a "//@ sourceURL=..." string.
        /// /*cef()*/
        /// </summary>
        /*8122*/

        public string GetScriptNameOrSourceURL()/*8123*/
        {
            JsValue ret;
            /*8124*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetScriptNameOrSourceURL_3, out ret);
            /*8125*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8126*/
            return ret_result;
            /*8127*/
        }

        // gen! CefString GetFunctionName()
        /// <summary>
        /// Returns the name of the function.
        /// /*cef()*/
        /// </summary>
        /*8128*/

        public string GetFunctionName()/*8129*/
        {
            JsValue ret;
            /*8130*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetFunctionName_4, out ret);
            /*8131*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8132*/
            return ret_result;
            /*8133*/
        }

        // gen! int GetLineNumber()
        /// <summary>
        /// Returns the 1-based line number for the function call or 0 if unknown.
        /// /*cef()*/
        /// </summary>
        /*8134*/

        public int GetLineNumber()/*8135*/
        {
            JsValue ret;
            /*8136*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetLineNumber_5, out ret);
            /*8137*/
            var ret_result = ret.I32;
            /*8138*/
            return ret_result;
            /*8139*/
        }

        // gen! int GetColumn()
        /// <summary>
        /// Returns the 1-based column offset on the line for the function call or 0 if
        /// unknown.
        /// /*cef()*/
        /// </summary>
        /*8140*/

        public int GetColumn()/*8141*/
        {
            JsValue ret;
            /*8142*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetColumn_6, out ret);
            /*8143*/
            var ret_result = ret.I32;
            /*8144*/
            return ret_result;
            /*8145*/
        }

        // gen! bool IsEval()
        /// <summary>
        /// Returns true if the function was compiled using eval().
        /// /*cef()*/
        /// </summary>
        /*8146*/

        public bool IsEval()/*8147*/
        {
            JsValue ret;
            /*8148*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsEval_7, out ret);
            /*8149*/
            var ret_result = ret.I32 != 0;
            /*8150*/
            return ret_result;
            /*8151*/
        }

        // gen! bool IsConstructor()
        /// <summary>
        /// Returns true if the function was called as a constructor via "new".
        /// /*cef()*/
        /// </summary>
        /*8152*/

        public bool IsConstructor()/*8153*/
        {
            JsValue ret;
            /*8154*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsConstructor_8, out ret);
            /*8155*/
            var ret_result = ret.I32 != 0;
            /*8156*/
            return ret_result;
            /*8157*/
        }
        /*8158*/
    }


    // [virtual] class CefValue
    /// <summary>
    /// Class that wraps other data value types. Complex types (binary, dictionary
    /// and list) will be referenced but not owned by this object. Can be used on any
    /// process and thread.
    /// /*cef(source=library)*/
    /// </summary>
    /*8277*/
    public struct CefValue
    {
        /*8278*/
        const int _typeNAME = 46;
        /*8279*/
        const int CefValue_Release_0 = (_typeNAME << 16) | 0;
        /*8280*/
        const int CefValue_IsValid_1 = (_typeNAME << 16) | 1;
        /*8281*/
        const int CefValue_IsOwned_2 = (_typeNAME << 16) | 2;
        /*8282*/
        const int CefValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        /*8283*/
        const int CefValue_IsSame_4 = (_typeNAME << 16) | 4;
        /*8284*/
        const int CefValue_IsEqual_5 = (_typeNAME << 16) | 5;
        /*8285*/
        const int CefValue_Copy_6 = (_typeNAME << 16) | 6;
        /*8286*/
        const int CefValue_GetType_7 = (_typeNAME << 16) | 7;
        /*8287*/
        const int CefValue_GetBool_8 = (_typeNAME << 16) | 8;
        /*8288*/
        const int CefValue_GetInt_9 = (_typeNAME << 16) | 9;
        /*8289*/
        const int CefValue_GetDouble_10 = (_typeNAME << 16) | 10;
        /*8290*/
        const int CefValue_GetString_11 = (_typeNAME << 16) | 11;
        /*8291*/
        const int CefValue_GetBinary_12 = (_typeNAME << 16) | 12;
        /*8292*/
        const int CefValue_GetDictionary_13 = (_typeNAME << 16) | 13;
        /*8293*/
        const int CefValue_GetList_14 = (_typeNAME << 16) | 14;
        /*8294*/
        const int CefValue_SetNull_15 = (_typeNAME << 16) | 15;
        /*8295*/
        const int CefValue_SetBool_16 = (_typeNAME << 16) | 16;
        /*8296*/
        const int CefValue_SetInt_17 = (_typeNAME << 16) | 17;
        /*8297*/
        const int CefValue_SetDouble_18 = (_typeNAME << 16) | 18;
        /*8298*/
        const int CefValue_SetString_19 = (_typeNAME << 16) | 19;
        /*8299*/
        const int CefValue_SetBinary_20 = (_typeNAME << 16) | 20;
        /*8300*/
        const int CefValue_SetDictionary_21 = (_typeNAME << 16) | 21;
        /*8301*/
        const int CefValue_SetList_22 = (_typeNAME << 16) | 22;
        /*8302*/
        internal readonly IntPtr nativePtr;
        /*8303*/
        internal CefValue(IntPtr nativePtr)
        {
            /*8304*/
            this.nativePtr = nativePtr;
            /*8305*/
        }
        /*8306*/
        public void Release()
        {
            /*8307*/
            JsValue ret;
            /*8308*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_Release_0, out ret);
            /*8309*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefValue methods.
        /// </summary>
        /*8310*/

        public bool IsValid()/*8311*/
        {
            JsValue ret;
            /*8312*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsValid_1, out ret);
            /*8313*/
            var ret_result = ret.I32 != 0;
            /*8314*/
            return ret_result;
            /*8315*/
        }

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if the underlying data is owned by another object.
        /// /*cef()*/
        /// </summary>
        /*8316*/

        public bool IsOwned()/*8317*/
        {
            JsValue ret;
            /*8318*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsOwned_2, out ret);
            /*8319*/
            var ret_result = ret.I32 != 0;
            /*8320*/
            return ret_result;
            /*8321*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the underlying data is read-only. Some APIs may expose
        /// read-only objects.
        /// /*cef()*/
        /// </summary>
        /*8322*/

        public bool IsReadOnly()/*8323*/
        {
            JsValue ret;
            /*8324*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsReadOnly_3, out ret);
            /*8325*/
            var ret_result = ret.I32 != 0;
            /*8326*/
            return ret_result;
            /*8327*/
        }

        // gen! bool IsSame(CefRefPtr<CefValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>
        /*8328*/

        public bool IsSame(CefValue /*8329*/
        that
        )/*8330*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8331*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_IsSame_4, out ret, ref v1);
            /*8332*/
            var ret_result = ret.I32 != 0;
            /*8333*/
            return ret_result;
            /*8334*/
        }

        // gen! bool IsEqual(CefRefPtr<CefValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>
        /*8335*/

        public bool IsEqual(CefValue /*8336*/
        that
        )/*8337*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8338*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_IsEqual_5, out ret, ref v1);
            /*8339*/
            var ret_result = ret.I32 != 0;
            /*8340*/
            return ret_result;
            /*8341*/
        }

        // gen! CefRefPtr<CefValue> Copy()
        /// <summary>
        /// Returns a copy of this object. The underlying data will also be copied.
        /// /*cef()*/
        /// </summary>
        /*8342*/

        public CefValue Copy()/*8343*/
        {
            JsValue ret;
            /*8344*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_Copy_6, out ret);
            /*8345*/
            var ret_result = new CefValue(ret.Ptr);
            /*8346*/
            return ret_result;
            /*8347*/
        }

        // gen! CefValueType GetType()
        /// <summary>
        /// Returns the underlying value type.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>
        /*8348*/

        public cef_value_type_t _GetType()/*8349*/
        {
            JsValue ret;
            /*8350*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetType_7, out ret);
            /*8351*/
            var ret_result = (cef_value_type_t)ret.I32;

            /*8352*/
            return ret_result;
            /*8353*/
        }

        // gen! bool GetBool()
        /// <summary>
        /// Returns the underlying value as type bool.
        /// /*cef()*/
        /// </summary>
        /*8354*/

        public bool GetBool()/*8355*/
        {
            JsValue ret;
            /*8356*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetBool_8, out ret);
            /*8357*/
            var ret_result = ret.I32 != 0;
            /*8358*/
            return ret_result;
            /*8359*/
        }

        // gen! int GetInt()
        /// <summary>
        /// Returns the underlying value as type int.
        /// /*cef()*/
        /// </summary>
        /*8360*/

        public int GetInt()/*8361*/
        {
            JsValue ret;
            /*8362*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetInt_9, out ret);
            /*8363*/
            var ret_result = ret.I32;
            /*8364*/
            return ret_result;
            /*8365*/
        }

        // gen! double GetDouble()
        /// <summary>
        /// Returns the underlying value as type double.
        /// /*cef()*/
        /// </summary>
        /*8366*/

        public double GetDouble()/*8367*/
        {
            JsValue ret;
            /*8368*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetDouble_10, out ret);
            /*8369*/
            var ret_result = ret.Num;
            /*8370*/
            return ret_result;
            /*8371*/
        }

        // gen! CefString GetString()
        /// <summary>
        /// Returns the underlying value as type string.
        /// /*cef()*/
        /// </summary>
        /*8372*/

        public string GetString()/*8373*/
        {
            JsValue ret;
            /*8374*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetString_11, out ret);
            /*8375*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8376*/
            return ret_result;
            /*8377*/
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
        /*8378*/

        public CefBinaryValue GetBinary()/*8379*/
        {
            JsValue ret;
            /*8380*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetBinary_12, out ret);
            /*8381*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*8382*/
            return ret_result;
            /*8383*/
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
        /*8384*/

        public CefDictionaryValue GetDictionary()/*8385*/
        {
            JsValue ret;
            /*8386*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetDictionary_13, out ret);
            /*8387*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            /*8388*/
            return ret_result;
            /*8389*/
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
        /*8390*/

        public CefListValue GetList()/*8391*/
        {
            JsValue ret;
            /*8392*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetList_14, out ret);
            /*8393*/
            var ret_result = new CefListValue(ret.Ptr);
            /*8394*/
            return ret_result;
            /*8395*/
        }

        // gen! bool SetNull()
        /// <summary>
        /// Sets the underlying value as type null. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>
        /*8396*/

        public bool SetNull()/*8397*/
        {
            JsValue ret;
            /*8398*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_SetNull_15, out ret);
            /*8399*/
            var ret_result = ret.I32 != 0;
            /*8400*/
            return ret_result;
            /*8401*/
        }

        // gen! bool SetBool(bool value)
        /// <summary>
        /// Sets the underlying value as type bool. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>
        /*8402*/

        public bool SetBool(bool /*8403*/
        value
        )/*8404*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8405*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetBool_16, out ret, ref v1);
            /*8406*/
            var ret_result = ret.I32 != 0;
            /*8407*/
            return ret_result;
            /*8408*/
        }

        // gen! bool SetInt(int value)
        /// <summary>
        /// Sets the underlying value as type int. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>
        /*8409*/

        public bool SetInt(int /*8410*/
        value
        )/*8411*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8412*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetInt_17, out ret, ref v1);
            /*8413*/
            var ret_result = ret.I32 != 0;
            /*8414*/
            return ret_result;
            /*8415*/
        }

        // gen! bool SetDouble(double value)
        /// <summary>
        /// Sets the underlying value as type double. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>
        /*8416*/

        public bool SetDouble(double /*8417*/
        value
        )/*8418*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8419*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetDouble_18, out ret, ref v1);
            /*8420*/
            var ret_result = ret.I32 != 0;
            /*8421*/
            return ret_result;
            /*8422*/
        }

        // gen! bool SetString(const CefString& value)
        /// <summary>
        /// Sets the underlying value as type string. Returns true if the value was set
        /// successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>
        /*8423*/

        public bool SetString(string /*8424*/
        value
        )/*8425*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*8426*/
            ;
            /*8427*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetString_19, out ret, ref v1);
            /*8428*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8429*/
            ;
            /*8430*/
            return ret_result;
            /*8431*/
        }

        // gen! bool SetBinary(CefRefPtr<CefBinaryValue> value)
        /// <summary>
        /// Sets the underlying value as type binary. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>
        /*8432*/

        public bool SetBinary(CefBinaryValue /*8433*/
        value
        )/*8434*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8435*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetBinary_20, out ret, ref v1);
            /*8436*/
            var ret_result = ret.I32 != 0;
            /*8437*/
            return ret_result;
            /*8438*/
        }

        // gen! bool SetDictionary(CefRefPtr<CefDictionaryValue> value)
        /// <summary>
        /// Sets the underlying value as type dict. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>
        /*8439*/

        public bool SetDictionary(CefDictionaryValue /*8440*/
        value
        )/*8441*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8442*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetDictionary_21, out ret, ref v1);
            /*8443*/
            var ret_result = ret.I32 != 0;
            /*8444*/
            return ret_result;
            /*8445*/
        }

        // gen! bool SetList(CefRefPtr<CefListValue> value)
        /// <summary>
        /// Sets the underlying value as type list. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>
        /*8446*/

        public bool SetList(CefListValue /*8447*/
        value
        )/*8448*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8449*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetList_22, out ret, ref v1);
            /*8450*/
            var ret_result = ret.I32 != 0;
            /*8451*/
            return ret_result;
            /*8452*/
        }
        /*8453*/
    }


    // [virtual] class CefBinaryValue
    /// <summary>
    /// Class representing a binary value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    /*8497*/
    public struct CefBinaryValue
    {
        /*8498*/
        const int _typeNAME = 47;
        /*8499*/
        const int CefBinaryValue_Release_0 = (_typeNAME << 16) | 0;
        /*8500*/
        const int CefBinaryValue_IsValid_1 = (_typeNAME << 16) | 1;
        /*8501*/
        const int CefBinaryValue_IsOwned_2 = (_typeNAME << 16) | 2;
        /*8502*/
        const int CefBinaryValue_IsSame_3 = (_typeNAME << 16) | 3;
        /*8503*/
        const int CefBinaryValue_IsEqual_4 = (_typeNAME << 16) | 4;
        /*8504*/
        const int CefBinaryValue_Copy_5 = (_typeNAME << 16) | 5;
        /*8505*/
        const int CefBinaryValue_GetSize_6 = (_typeNAME << 16) | 6;
        /*8506*/
        const int CefBinaryValue_GetData_7 = (_typeNAME << 16) | 7;
        /*8507*/
        internal readonly IntPtr nativePtr;
        /*8508*/
        internal CefBinaryValue(IntPtr nativePtr)
        {
            /*8509*/
            this.nativePtr = nativePtr;
            /*8510*/
        }
        /*8511*/
        public void Release()
        {
            /*8512*/
            JsValue ret;
            /*8513*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_Release_0, out ret);
            /*8514*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefBinaryValue methods.
        /// </summary>
        /*8515*/

        public bool IsValid()/*8516*/
        {
            JsValue ret;
            /*8517*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_IsValid_1, out ret);
            /*8518*/
            var ret_result = ret.I32 != 0;
            /*8519*/
            return ret_result;
            /*8520*/
        }

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>
        /*8521*/

        public bool IsOwned()/*8522*/
        {
            JsValue ret;
            /*8523*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_IsOwned_2, out ret);
            /*8524*/
            var ret_result = ret.I32 != 0;
            /*8525*/
            return ret_result;
            /*8526*/
        }

        // gen! bool IsSame(CefRefPtr<CefBinaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data.
        /// /*cef()*/
        /// </summary>
        /*8527*/

        public bool IsSame(CefBinaryValue /*8528*/
        that
        )/*8529*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8530*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBinaryValue_IsSame_3, out ret, ref v1);
            /*8531*/
            var ret_result = ret.I32 != 0;
            /*8532*/
            return ret_result;
            /*8533*/
        }

        // gen! bool IsEqual(CefRefPtr<CefBinaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>
        /*8534*/

        public bool IsEqual(CefBinaryValue /*8535*/
        that
        )/*8536*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8537*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBinaryValue_IsEqual_4, out ret, ref v1);
            /*8538*/
            var ret_result = ret.I32 != 0;
            /*8539*/
            return ret_result;
            /*8540*/
        }

        // gen! CefRefPtr<CefBinaryValue> Copy()
        /// <summary>
        /// Returns a copy of this object. The data in this object will also be copied.
        /// /*cef()*/
        /// </summary>
        /*8541*/

        public CefBinaryValue Copy()/*8542*/
        {
            JsValue ret;
            /*8543*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_Copy_5, out ret);
            /*8544*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*8545*/
            return ret_result;
            /*8546*/
        }

        // gen! size_t GetSize()
        /// <summary>
        /// Returns the data size.
        /// /*cef()*/
        /// </summary>
        /*8547*/

        public uint GetSize()/*8548*/
        {
            JsValue ret;
            /*8549*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_GetSize_6, out ret);
            /*8550*/
            var ret_result = (uint)ret.I32;
            /*8551*/
            return ret_result;
            /*8552*/
        }

        // gen! size_t GetData(void* buffer,size_t buffer_size,size_t data_offset)
        /// <summary>
        /// Read up to |buffer_size| number of bytes into |buffer|. Reading begins at
        /// the specified byte |data_offset|. Returns the number of bytes read.
        /// /*cef()*/
        /// </summary>
        /*8553*/

        public uint GetData(IntPtr /*8554*/
        buffer
        , uint /*8555*/
        buffer_size
        , uint /*8556*/
        data_offset
        )/*8557*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*8558*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBinaryValue_GetData_7, out ret, ref v1, ref v2, ref v3);
            /*8559*/
            var ret_result = (uint)ret.I32;
            /*8560*/
            return ret_result;
            /*8561*/
        }
        /*8562*/
    }


    // [virtual] class CefDictionaryValue
    /// <summary>
    /// Class representing a dictionary value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    /*8716*/
    public struct CefDictionaryValue
    {
        /*8717*/
        const int _typeNAME = 48;
        /*8718*/
        const int CefDictionaryValue_Release_0 = (_typeNAME << 16) | 0;
        /*8719*/
        const int CefDictionaryValue_IsValid_1 = (_typeNAME << 16) | 1;
        /*8720*/
        const int CefDictionaryValue_IsOwned_2 = (_typeNAME << 16) | 2;
        /*8721*/
        const int CefDictionaryValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        /*8722*/
        const int CefDictionaryValue_IsSame_4 = (_typeNAME << 16) | 4;
        /*8723*/
        const int CefDictionaryValue_IsEqual_5 = (_typeNAME << 16) | 5;
        /*8724*/
        const int CefDictionaryValue_Copy_6 = (_typeNAME << 16) | 6;
        /*8725*/
        const int CefDictionaryValue_GetSize_7 = (_typeNAME << 16) | 7;
        /*8726*/
        const int CefDictionaryValue_Clear_8 = (_typeNAME << 16) | 8;
        /*8727*/
        const int CefDictionaryValue_HasKey_9 = (_typeNAME << 16) | 9;
        /*8728*/
        const int CefDictionaryValue_GetKeys_10 = (_typeNAME << 16) | 10;
        /*8729*/
        const int CefDictionaryValue_Remove_11 = (_typeNAME << 16) | 11;
        /*8730*/
        const int CefDictionaryValue_GetType_12 = (_typeNAME << 16) | 12;
        /*8731*/
        const int CefDictionaryValue_GetValue_13 = (_typeNAME << 16) | 13;
        /*8732*/
        const int CefDictionaryValue_GetBool_14 = (_typeNAME << 16) | 14;
        /*8733*/
        const int CefDictionaryValue_GetInt_15 = (_typeNAME << 16) | 15;
        /*8734*/
        const int CefDictionaryValue_GetDouble_16 = (_typeNAME << 16) | 16;
        /*8735*/
        const int CefDictionaryValue_GetString_17 = (_typeNAME << 16) | 17;
        /*8736*/
        const int CefDictionaryValue_GetBinary_18 = (_typeNAME << 16) | 18;
        /*8737*/
        const int CefDictionaryValue_GetDictionary_19 = (_typeNAME << 16) | 19;
        /*8738*/
        const int CefDictionaryValue_GetList_20 = (_typeNAME << 16) | 20;
        /*8739*/
        const int CefDictionaryValue_SetValue_21 = (_typeNAME << 16) | 21;
        /*8740*/
        const int CefDictionaryValue_SetNull_22 = (_typeNAME << 16) | 22;
        /*8741*/
        const int CefDictionaryValue_SetBool_23 = (_typeNAME << 16) | 23;
        /*8742*/
        const int CefDictionaryValue_SetInt_24 = (_typeNAME << 16) | 24;
        /*8743*/
        const int CefDictionaryValue_SetDouble_25 = (_typeNAME << 16) | 25;
        /*8744*/
        const int CefDictionaryValue_SetString_26 = (_typeNAME << 16) | 26;
        /*8745*/
        const int CefDictionaryValue_SetBinary_27 = (_typeNAME << 16) | 27;
        /*8746*/
        const int CefDictionaryValue_SetDictionary_28 = (_typeNAME << 16) | 28;
        /*8747*/
        const int CefDictionaryValue_SetList_29 = (_typeNAME << 16) | 29;
        /*8748*/
        internal readonly IntPtr nativePtr;
        /*8749*/
        internal CefDictionaryValue(IntPtr nativePtr)
        {
            /*8750*/
            this.nativePtr = nativePtr;
            /*8751*/
        }
        /*8752*/
        public void Release()
        {
            /*8753*/
            JsValue ret;
            /*8754*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_Release_0, out ret);
            /*8755*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefDictionaryValue methods.
        /// </summary>
        /*8756*/

        public bool IsValid()/*8757*/
        {
            JsValue ret;
            /*8758*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsValid_1, out ret);
            /*8759*/
            var ret_result = ret.I32 != 0;
            /*8760*/
            return ret_result;
            /*8761*/
        }

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>
        /*8762*/

        public bool IsOwned()/*8763*/
        {
            JsValue ret;
            /*8764*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsOwned_2, out ret);
            /*8765*/
            var ret_result = ret.I32 != 0;
            /*8766*/
            return ret_result;
            /*8767*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*8768*/

        public bool IsReadOnly()/*8769*/
        {
            JsValue ret;
            /*8770*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsReadOnly_3, out ret);
            /*8771*/
            var ret_result = ret.I32 != 0;
            /*8772*/
            return ret_result;
            /*8773*/
        }

        // gen! bool IsSame(CefRefPtr<CefDictionaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>
        /*8774*/

        public bool IsSame(CefDictionaryValue /*8775*/
        that
        )/*8776*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8777*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_IsSame_4, out ret, ref v1);
            /*8778*/
            var ret_result = ret.I32 != 0;
            /*8779*/
            return ret_result;
            /*8780*/
        }

        // gen! bool IsEqual(CefRefPtr<CefDictionaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>
        /*8781*/

        public bool IsEqual(CefDictionaryValue /*8782*/
        that
        )/*8783*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8784*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_IsEqual_5, out ret, ref v1);
            /*8785*/
            var ret_result = ret.I32 != 0;
            /*8786*/
            return ret_result;
            /*8787*/
        }

        // gen! CefRefPtr<CefDictionaryValue> Copy(bool exclude_empty_children)
        /// <summary>
        /// Returns a writable copy of this object. If |exclude_empty_children| is true
        /// any empty dictionaries or lists will be excluded from the copy.
        /// /*cef()*/
        /// </summary>
        /*8788*/

        public CefDictionaryValue Copy(bool /*8789*/
        exclude_empty_children
        )/*8790*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8791*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_Copy_6, out ret, ref v1);
            /*8792*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            /*8793*/
            return ret_result;
            /*8794*/
        }

        // gen! size_t GetSize()
        /// <summary>
        /// Returns the number of values.
        /// /*cef()*/
        /// </summary>
        /*8795*/

        public uint GetSize()/*8796*/
        {
            JsValue ret;
            /*8797*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_GetSize_7, out ret);
            /*8798*/
            var ret_result = (uint)ret.I32;
            /*8799*/
            return ret_result;
            /*8800*/
        }

        // gen! bool Clear()
        /// <summary>
        /// Removes all values. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*8801*/

        public bool Clear()/*8802*/
        {
            JsValue ret;
            /*8803*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_Clear_8, out ret);
            /*8804*/
            var ret_result = ret.I32 != 0;
            /*8805*/
            return ret_result;
            /*8806*/
        }

        // gen! bool HasKey(const CefString& key)
        /// <summary>
        /// Returns true if the current dictionary has a value for the given key.
        /// /*cef()*/
        /// </summary>
        /*8807*/

        public bool HasKey(string /*8808*/
        key
        )/*8809*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8810*/
            ;
            /*8811*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_HasKey_9, out ret, ref v1);
            /*8812*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8813*/
            ;
            /*8814*/
            return ret_result;
            /*8815*/
        }

        // gen! bool GetKeys(KeyList& keys)
        /// <summary>
        /// Reads all keys for this dictionary into the specified vector.
        /// /*cef()*/
        /// </summary>
        /*8816*/

        public bool GetKeys(KeyList /*8817*/
        keys
        )/*8818*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8819*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetKeys_10, out ret, ref v1);
            /*8820*/
            var ret_result = ret.I32 != 0;
            /*8821*/
            return ret_result;
            /*8822*/
        }

        // gen! bool Remove(const CefString& key)
        /// <summary>
        /// Removes the value at the specified key. Returns true is the value was
        /// removed successfully.
        /// /*cef()*/
        /// </summary>
        /*8823*/

        public bool Remove(string /*8824*/
        key
        )/*8825*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8826*/
            ;
            /*8827*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_Remove_11, out ret, ref v1);
            /*8828*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8829*/
            ;
            /*8830*/
            return ret_result;
            /*8831*/
        }

        // gen! CefValueType GetType(const CefString& key)
        /// <summary>
        /// Returns the value type for the specified key.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>
        /*8832*/

        public cef_value_type_t _GetType(string /*8833*/
        key
        )/*8834*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8835*/
            ;
            /*8836*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetType_12, out ret, ref v1);
            /*8837*/
            var ret_result = (cef_value_type_t)ret.I32;

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8838*/
            ;
            /*8839*/
            return ret_result;
            /*8840*/
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
        /*8841*/

        public CefValue GetValue(string /*8842*/
        key
        )/*8843*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8844*/
            ;
            /*8845*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetValue_13, out ret, ref v1);
            /*8846*/
            var ret_result = new CefValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8847*/
            ;
            /*8848*/
            return ret_result;
            /*8849*/
        }

        // gen! bool GetBool(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type bool.
        /// /*cef()*/
        /// </summary>
        /*8850*/

        public bool GetBool(string /*8851*/
        key
        )/*8852*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8853*/
            ;
            /*8854*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetBool_14, out ret, ref v1);
            /*8855*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8856*/
            ;
            /*8857*/
            return ret_result;
            /*8858*/
        }

        // gen! int GetInt(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type int.
        /// /*cef()*/
        /// </summary>
        /*8859*/

        public int GetInt(string /*8860*/
        key
        )/*8861*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8862*/
            ;
            /*8863*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetInt_15, out ret, ref v1);
            /*8864*/
            var ret_result = ret.I32;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8865*/
            ;
            /*8866*/
            return ret_result;
            /*8867*/
        }

        // gen! double GetDouble(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type double.
        /// /*cef()*/
        /// </summary>
        /*8868*/

        public double GetDouble(string /*8869*/
        key
        )/*8870*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8871*/
            ;
            /*8872*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetDouble_16, out ret, ref v1);
            /*8873*/
            var ret_result = ret.Num;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8874*/
            ;
            /*8875*/
            return ret_result;
            /*8876*/
        }

        // gen! CefString GetString(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type string.
        /// /*cef()*/
        /// </summary>
        /*8877*/

        public string GetString(string /*8878*/
        key
        )/*8879*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8880*/
            ;
            /*8881*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetString_17, out ret, ref v1);
            /*8882*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8883*/
            ;
            /*8884*/
            return ret_result;
            /*8885*/
        }

        // gen! CefRefPtr<CefBinaryValue> GetBinary(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type binary. The returned
        /// value will reference existing data.
        /// /*cef()*/
        /// </summary>
        /*8886*/

        public CefBinaryValue GetBinary(string /*8887*/
        key
        )/*8888*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8889*/
            ;
            /*8890*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetBinary_18, out ret, ref v1);
            /*8891*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8892*/
            ;
            /*8893*/
            return ret_result;
            /*8894*/
        }

        // gen! CefRefPtr<CefDictionaryValue> GetDictionary(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type dictionary. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>
        /*8895*/

        public CefDictionaryValue GetDictionary(string /*8896*/
        key
        )/*8897*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8898*/
            ;
            /*8899*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetDictionary_19, out ret, ref v1);
            /*8900*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8901*/
            ;
            /*8902*/
            return ret_result;
            /*8903*/
        }

        // gen! CefRefPtr<CefListValue> GetList(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type list. The returned value
        /// will reference existing data and modifications to the value will modify
        /// this object.
        /// /*cef()*/
        /// </summary>
        /*8904*/

        public CefListValue GetList(string /*8905*/
        key
        )/*8906*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8907*/
            ;
            /*8908*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetList_20, out ret, ref v1);
            /*8909*/
            var ret_result = new CefListValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8910*/
            ;
            /*8911*/
            return ret_result;
            /*8912*/
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
        /*8913*/

        public bool SetValue(string /*8914*/
        key
        , CefValue /*8915*/
        value
        )/*8916*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8917*/
            ;
            /*8918*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetValue_21, out ret, ref v1, ref v2);
            /*8919*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8920*/
            ;
            /*8921*/
            return ret_result;
            /*8922*/
        }

        // gen! bool SetNull(const CefString& key)
        /// <summary>
        /// Sets the value at the specified key as type null. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*8923*/

        public bool SetNull(string /*8924*/
        key
        )/*8925*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8926*/
            ;
            /*8927*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_SetNull_22, out ret, ref v1);
            /*8928*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8929*/
            ;
            /*8930*/
            return ret_result;
            /*8931*/
        }

        // gen! bool SetBool(const CefString& key,bool value)
        /// <summary>
        /// Sets the value at the specified key as type bool. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*8932*/

        public bool SetBool(string /*8933*/
        key
        , bool /*8934*/
        value
        )/*8935*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8936*/
            ;
            /*8937*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetBool_23, out ret, ref v1, ref v2);
            /*8938*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8939*/
            ;
            /*8940*/
            return ret_result;
            /*8941*/
        }

        // gen! bool SetInt(const CefString& key,int value)
        /// <summary>
        /// Sets the value at the specified key as type int. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*8942*/

        public bool SetInt(string /*8943*/
        key
        , int /*8944*/
        value
        )/*8945*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8946*/
            ;
            /*8947*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetInt_24, out ret, ref v1, ref v2);
            /*8948*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8949*/
            ;
            /*8950*/
            return ret_result;
            /*8951*/
        }

        // gen! bool SetDouble(const CefString& key,double value)
        /// <summary>
        /// Sets the value at the specified key as type double. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*8952*/

        public bool SetDouble(string /*8953*/
        key
        , double /*8954*/
        value
        )/*8955*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8956*/
            ;
            /*8957*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetDouble_25, out ret, ref v1, ref v2);
            /*8958*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8959*/
            ;
            /*8960*/
            return ret_result;
            /*8961*/
        }

        // gen! bool SetString(const CefString& key,const CefString& value)
        /// <summary>
        /// Sets the value at the specified key as type string. Returns true if the
        /// value was set successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>
        /*8962*/

        public bool SetString(string /*8963*/
        key
        , string /*8964*/
        value
        )/*8965*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8966*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*8967*/
            ;
            /*8968*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetString_26, out ret, ref v1, ref v2);
            /*8969*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8970*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*8971*/
            ;
            /*8972*/
            return ret_result;
            /*8973*/
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
        /*8974*/

        public bool SetBinary(string /*8975*/
        key
        , CefBinaryValue /*8976*/
        value
        )/*8977*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8978*/
            ;
            /*8979*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetBinary_27, out ret, ref v1, ref v2);
            /*8980*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8981*/
            ;
            /*8982*/
            return ret_result;
            /*8983*/
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
        /*8984*/

        public bool SetDictionary(string /*8985*/
        key
        , CefDictionaryValue /*8986*/
        value
        )/*8987*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8988*/
            ;
            /*8989*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetDictionary_28, out ret, ref v1, ref v2);
            /*8990*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8991*/
            ;
            /*8992*/
            return ret_result;
            /*8993*/
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
        /*8994*/

        public bool SetList(string /*8995*/
        key
        , CefListValue /*8996*/
        value
        )/*8997*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8998*/
            ;
            /*8999*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetList_29, out ret, ref v1, ref v2);
            /*9000*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9001*/
            ;
            /*9002*/
            return ret_result;
            /*9003*/
        }
        /*9004*/
    }


    // [virtual] class CefListValue
    /// <summary>
    /// Class representing a list value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    /*9153*/
    public struct CefListValue
    {
        /*9154*/
        const int _typeNAME = 49;
        /*9155*/
        const int CefListValue_Release_0 = (_typeNAME << 16) | 0;
        /*9156*/
        const int CefListValue_IsValid_1 = (_typeNAME << 16) | 1;
        /*9157*/
        const int CefListValue_IsOwned_2 = (_typeNAME << 16) | 2;
        /*9158*/
        const int CefListValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        /*9159*/
        const int CefListValue_IsSame_4 = (_typeNAME << 16) | 4;
        /*9160*/
        const int CefListValue_IsEqual_5 = (_typeNAME << 16) | 5;
        /*9161*/
        const int CefListValue_Copy_6 = (_typeNAME << 16) | 6;
        /*9162*/
        const int CefListValue_SetSize_7 = (_typeNAME << 16) | 7;
        /*9163*/
        const int CefListValue_GetSize_8 = (_typeNAME << 16) | 8;
        /*9164*/
        const int CefListValue_Clear_9 = (_typeNAME << 16) | 9;
        /*9165*/
        const int CefListValue_Remove_10 = (_typeNAME << 16) | 10;
        /*9166*/
        const int CefListValue_GetType_11 = (_typeNAME << 16) | 11;
        /*9167*/
        const int CefListValue_GetValue_12 = (_typeNAME << 16) | 12;
        /*9168*/
        const int CefListValue_GetBool_13 = (_typeNAME << 16) | 13;
        /*9169*/
        const int CefListValue_GetInt_14 = (_typeNAME << 16) | 14;
        /*9170*/
        const int CefListValue_GetDouble_15 = (_typeNAME << 16) | 15;
        /*9171*/
        const int CefListValue_GetString_16 = (_typeNAME << 16) | 16;
        /*9172*/
        const int CefListValue_GetBinary_17 = (_typeNAME << 16) | 17;
        /*9173*/
        const int CefListValue_GetDictionary_18 = (_typeNAME << 16) | 18;
        /*9174*/
        const int CefListValue_GetList_19 = (_typeNAME << 16) | 19;
        /*9175*/
        const int CefListValue_SetValue_20 = (_typeNAME << 16) | 20;
        /*9176*/
        const int CefListValue_SetNull_21 = (_typeNAME << 16) | 21;
        /*9177*/
        const int CefListValue_SetBool_22 = (_typeNAME << 16) | 22;
        /*9178*/
        const int CefListValue_SetInt_23 = (_typeNAME << 16) | 23;
        /*9179*/
        const int CefListValue_SetDouble_24 = (_typeNAME << 16) | 24;
        /*9180*/
        const int CefListValue_SetString_25 = (_typeNAME << 16) | 25;
        /*9181*/
        const int CefListValue_SetBinary_26 = (_typeNAME << 16) | 26;
        /*9182*/
        const int CefListValue_SetDictionary_27 = (_typeNAME << 16) | 27;
        /*9183*/
        const int CefListValue_SetList_28 = (_typeNAME << 16) | 28;
        /*9184*/
        internal readonly IntPtr nativePtr;
        /*9185*/
        internal CefListValue(IntPtr nativePtr)
        {
            /*9186*/
            this.nativePtr = nativePtr;
            /*9187*/
        }
        /*9188*/
        public void Release()
        {
            /*9189*/
            JsValue ret;
            /*9190*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Release_0, out ret);
            /*9191*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefListValue methods.
        /// </summary>
        /*9192*/

        public bool IsValid()/*9193*/
        {
            JsValue ret;
            /*9194*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsValid_1, out ret);
            /*9195*/
            var ret_result = ret.I32 != 0;
            /*9196*/
            return ret_result;
            /*9197*/
        }

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>
        /*9198*/

        public bool IsOwned()/*9199*/
        {
            JsValue ret;
            /*9200*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsOwned_2, out ret);
            /*9201*/
            var ret_result = ret.I32 != 0;
            /*9202*/
            return ret_result;
            /*9203*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*9204*/

        public bool IsReadOnly()/*9205*/
        {
            JsValue ret;
            /*9206*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsReadOnly_3, out ret);
            /*9207*/
            var ret_result = ret.I32 != 0;
            /*9208*/
            return ret_result;
            /*9209*/
        }

        // gen! bool IsSame(CefRefPtr<CefListValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>
        /*9210*/

        public bool IsSame(CefListValue /*9211*/
        that
        )/*9212*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9213*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_IsSame_4, out ret, ref v1);
            /*9214*/
            var ret_result = ret.I32 != 0;
            /*9215*/
            return ret_result;
            /*9216*/
        }

        // gen! bool IsEqual(CefRefPtr<CefListValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>
        /*9217*/

        public bool IsEqual(CefListValue /*9218*/
        that
        )/*9219*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9220*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_IsEqual_5, out ret, ref v1);
            /*9221*/
            var ret_result = ret.I32 != 0;
            /*9222*/
            return ret_result;
            /*9223*/
        }

        // gen! CefRefPtr<CefListValue> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>
        /*9224*/

        public CefListValue Copy()/*9225*/
        {
            JsValue ret;
            /*9226*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Copy_6, out ret);
            /*9227*/
            var ret_result = new CefListValue(ret.Ptr);
            /*9228*/
            return ret_result;
            /*9229*/
        }

        // gen! bool SetSize(size_t size)
        /// <summary>
        /// Sets the number of values. If the number of values is expanded all
        /// new value slots will default to type null. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*9230*/

        public bool SetSize(uint /*9231*/
        size
        )/*9232*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9233*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_SetSize_7, out ret, ref v1);
            /*9234*/
            var ret_result = ret.I32 != 0;
            /*9235*/
            return ret_result;
            /*9236*/
        }

        // gen! size_t GetSize()
        /// <summary>
        /// Returns the number of values.
        /// /*cef()*/
        /// </summary>
        /*9237*/

        public uint GetSize()/*9238*/
        {
            JsValue ret;
            /*9239*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_GetSize_8, out ret);
            /*9240*/
            var ret_result = (uint)ret.I32;
            /*9241*/
            return ret_result;
            /*9242*/
        }

        // gen! bool Clear()
        /// <summary>
        /// Removes all values. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*9243*/

        public bool Clear()/*9244*/
        {
            JsValue ret;
            /*9245*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Clear_9, out ret);
            /*9246*/
            var ret_result = ret.I32 != 0;
            /*9247*/
            return ret_result;
            /*9248*/
        }

        // gen! bool Remove(size_t index)
        /// <summary>
        /// Removes the value at the specified index.
        /// /*cef()*/
        /// </summary>
        /*9249*/

        public bool Remove(uint /*9250*/
        index
        )/*9251*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9252*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_Remove_10, out ret, ref v1);
            /*9253*/
            var ret_result = ret.I32 != 0;
            /*9254*/
            return ret_result;
            /*9255*/
        }

        // gen! CefValueType GetType(size_t index)
        /// <summary>
        /// Returns the value type at the specified index.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>
        /*9256*/

        public cef_value_type_t _GetType(uint /*9257*/
        index
        )/*9258*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9259*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetType_11, out ret, ref v1);
            /*9260*/
            var ret_result = (cef_value_type_t)ret.I32;

            /*9261*/
            return ret_result;
            /*9262*/
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
        /*9263*/

        public CefValue GetValue(uint /*9264*/
        index
        )/*9265*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9266*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetValue_12, out ret, ref v1);
            /*9267*/
            var ret_result = new CefValue(ret.Ptr);
            /*9268*/
            return ret_result;
            /*9269*/
        }

        // gen! bool GetBool(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type bool.
        /// /*cef()*/
        /// </summary>
        /*9270*/

        public bool GetBool(uint /*9271*/
        index
        )/*9272*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9273*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetBool_13, out ret, ref v1);
            /*9274*/
            var ret_result = ret.I32 != 0;
            /*9275*/
            return ret_result;
            /*9276*/
        }

        // gen! int GetInt(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type int.
        /// /*cef()*/
        /// </summary>
        /*9277*/

        public int GetInt(uint /*9278*/
        index
        )/*9279*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9280*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetInt_14, out ret, ref v1);
            /*9281*/
            var ret_result = ret.I32;
            /*9282*/
            return ret_result;
            /*9283*/
        }

        // gen! double GetDouble(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type double.
        /// /*cef()*/
        /// </summary>
        /*9284*/

        public double GetDouble(uint /*9285*/
        index
        )/*9286*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9287*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetDouble_15, out ret, ref v1);
            /*9288*/
            var ret_result = ret.Num;
            /*9289*/
            return ret_result;
            /*9290*/
        }

        // gen! CefString GetString(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type string.
        /// /*cef()*/
        /// </summary>
        /*9291*/

        public string GetString(uint /*9292*/
        index
        )/*9293*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9294*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetString_16, out ret, ref v1);
            /*9295*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9296*/
            return ret_result;
            /*9297*/
        }

        // gen! CefRefPtr<CefBinaryValue> GetBinary(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type binary. The returned
        /// value will reference existing data.
        /// /*cef()*/
        /// </summary>
        /*9298*/

        public CefBinaryValue GetBinary(uint /*9299*/
        index
        )/*9300*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9301*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetBinary_17, out ret, ref v1);
            /*9302*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*9303*/
            return ret_result;
            /*9304*/
        }

        // gen! CefRefPtr<CefDictionaryValue> GetDictionary(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type dictionary. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>
        /*9305*/

        public CefDictionaryValue GetDictionary(uint /*9306*/
        index
        )/*9307*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9308*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetDictionary_18, out ret, ref v1);
            /*9309*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            /*9310*/
            return ret_result;
            /*9311*/
        }

        // gen! CefRefPtr<CefListValue> GetList(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type list. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>
        /*9312*/

        public CefListValue GetList(uint /*9313*/
        index
        )/*9314*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9315*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetList_19, out ret, ref v1);
            /*9316*/
            var ret_result = new CefListValue(ret.Ptr);
            /*9317*/
            return ret_result;
            /*9318*/
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
        /*9319*/

        public bool SetValue(uint /*9320*/
        index
        , CefValue /*9321*/
        value
        )/*9322*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*9323*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetValue_20, out ret, ref v1, ref v2);
            /*9324*/
            var ret_result = ret.I32 != 0;
            /*9325*/
            return ret_result;
            /*9326*/
        }

        // gen! bool SetNull(size_t index)
        /// <summary>
        /// Sets the value at the specified index as type null. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9327*/

        public bool SetNull(uint /*9328*/
        index
        )/*9329*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9330*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_SetNull_21, out ret, ref v1);
            /*9331*/
            var ret_result = ret.I32 != 0;
            /*9332*/
            return ret_result;
            /*9333*/
        }

        // gen! bool SetBool(size_t index,bool value)
        /// <summary>
        /// Sets the value at the specified index as type bool. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9334*/

        public bool SetBool(uint /*9335*/
        index
        , bool /*9336*/
        value
        )/*9337*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*9338*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetBool_22, out ret, ref v1, ref v2);
            /*9339*/
            var ret_result = ret.I32 != 0;
            /*9340*/
            return ret_result;
            /*9341*/
        }

        // gen! bool SetInt(size_t index,int value)
        /// <summary>
        /// Sets the value at the specified index as type int. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9342*/

        public bool SetInt(uint /*9343*/
        index
        , int /*9344*/
        value
        )/*9345*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*9346*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetInt_23, out ret, ref v1, ref v2);
            /*9347*/
            var ret_result = ret.I32 != 0;
            /*9348*/
            return ret_result;
            /*9349*/
        }

        // gen! bool SetDouble(size_t index,double value)
        /// <summary>
        /// Sets the value at the specified index as type double. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9350*/

        public bool SetDouble(uint /*9351*/
        index
        , double /*9352*/
        value
        )/*9353*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*9354*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetDouble_24, out ret, ref v1, ref v2);
            /*9355*/
            var ret_result = ret.I32 != 0;
            /*9356*/
            return ret_result;
            /*9357*/
        }

        // gen! bool SetString(size_t index,const CefString& value)
        /// <summary>
        /// Sets the value at the specified index as type string. Returns true if the
        /// value was set successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>
        /*9358*/

        public bool SetString(uint /*9359*/
        index
        , string /*9360*/
        value
        )/*9361*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*9362*/
            ;
            /*9363*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetString_25, out ret, ref v1, ref v2);
            /*9364*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*9365*/
            ;
            /*9366*/
            return ret_result;
            /*9367*/
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
        /*9368*/

        public bool SetBinary(uint /*9369*/
        index
        , CefBinaryValue /*9370*/
        value
        )/*9371*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*9372*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetBinary_26, out ret, ref v1, ref v2);
            /*9373*/
            var ret_result = ret.I32 != 0;
            /*9374*/
            return ret_result;
            /*9375*/
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
        /*9376*/

        public bool SetDictionary(uint /*9377*/
        index
        , CefDictionaryValue /*9378*/
        value
        )/*9379*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*9380*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetDictionary_27, out ret, ref v1, ref v2);
            /*9381*/
            var ret_result = ret.I32 != 0;
            /*9382*/
            return ret_result;
            /*9383*/
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
        /*9384*/

        public bool SetList(uint /*9385*/
        index
        , CefListValue /*9386*/
        value
        )/*9387*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*9388*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetList_28, out ret, ref v1, ref v2);
            /*9389*/
            var ret_result = ret.I32 != 0;
            /*9390*/
            return ret_result;
            /*9391*/
        }
        /*9392*/
    }


    // [virtual] class CefWebPluginInfo
    /// <summary>
    /// Information about a specific web plugin.
    /// /*(source=library)*/
    /// </summary>
    /*9421*/
    public struct CefWebPluginInfo
    {
        /*9422*/
        const int _typeNAME = 50;
        /*9423*/
        const int CefWebPluginInfo_Release_0 = (_typeNAME << 16) | 0;
        /*9424*/
        const int CefWebPluginInfo_GetName_1 = (_typeNAME << 16) | 1;
        /*9425*/
        const int CefWebPluginInfo_GetPath_2 = (_typeNAME << 16) | 2;
        /*9426*/
        const int CefWebPluginInfo_GetVersion_3 = (_typeNAME << 16) | 3;
        /*9427*/
        const int CefWebPluginInfo_GetDescription_4 = (_typeNAME << 16) | 4;
        /*9428*/
        internal readonly IntPtr nativePtr;
        /*9429*/
        internal CefWebPluginInfo(IntPtr nativePtr)
        {
            /*9430*/
            this.nativePtr = nativePtr;
            /*9431*/
        }
        /*9432*/
        public void Release()
        {
            /*9433*/
            JsValue ret;
            /*9434*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_Release_0, out ret);
            /*9435*/
        }

        // gen! CefString GetName()
        /// <summary>
        /// CefWebPluginInfo methods.
        /// </summary>
        /*9436*/

        public string GetName()/*9437*/
        {
            JsValue ret;
            /*9438*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetName_1, out ret);
            /*9439*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9440*/
            return ret_result;
            /*9441*/
        }

        // gen! CefString GetPath()
        /// <summary>
        /// Returns the plugin file path (DLL/bundle/library).
        /// /*cef()*/
        /// </summary>
        /*9442*/

        public string GetPath()/*9443*/
        {
            JsValue ret;
            /*9444*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetPath_2, out ret);
            /*9445*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9446*/
            return ret_result;
            /*9447*/
        }

        // gen! CefString GetVersion()
        /// <summary>
        /// Returns the version of the plugin (may be OS-specific).
        /// /*cef()*/
        /// </summary>
        /*9448*/

        public string GetVersion()/*9449*/
        {
            JsValue ret;
            /*9450*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetVersion_3, out ret);
            /*9451*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9452*/
            return ret_result;
            /*9453*/
        }

        // gen! CefString GetDescription()
        /// <summary>
        /// Returns a description of the plugin from the version information.
        /// /*cef()*/
        /// </summary>
        /*9454*/

        public string GetDescription()/*9455*/
        {
            JsValue ret;
            /*9456*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetDescription_4, out ret);
            /*9457*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9458*/
            return ret_result;
            /*9459*/
        }
        /*9460*/
    }


    // [virtual] class CefWebPluginInfoVisitor
    /// <summary>
    /// Interface to implement for visiting web plugin information. The methods of
    /// this class will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    /*9469*/
    public struct CefWebPluginInfoVisitor
    {
        /*9470*/
        const int _typeNAME = 51;
        /*9471*/
        const int CefWebPluginInfoVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*9472*/
        internal readonly IntPtr nativePtr;
        /*9473*/
        internal CefWebPluginInfoVisitor(IntPtr nativePtr)
        {
            /*9474*/
            this.nativePtr = nativePtr;
            /*9475*/
        }
        /*9476*/
        public void Release()
        {
            /*9477*/
            JsValue ret;
            /*9478*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfoVisitor_Release_0, out ret);
            /*9479*/
        }
        /*9480*/
    }


    // [virtual] class CefX509CertPrincipal
    /// <summary>
    /// Class representing the issuer or subject field of an X.509 certificate.
    /// /*(source=library)*/
    /// </summary>
    /*9534*/
    public struct CefX509CertPrincipal
    {
        /*9535*/
        const int _typeNAME = 52;
        /*9536*/
        const int CefX509CertPrincipal_Release_0 = (_typeNAME << 16) | 0;
        /*9537*/
        const int CefX509CertPrincipal_GetDisplayName_1 = (_typeNAME << 16) | 1;
        /*9538*/
        const int CefX509CertPrincipal_GetCommonName_2 = (_typeNAME << 16) | 2;
        /*9539*/
        const int CefX509CertPrincipal_GetLocalityName_3 = (_typeNAME << 16) | 3;
        /*9540*/
        const int CefX509CertPrincipal_GetStateOrProvinceName_4 = (_typeNAME << 16) | 4;
        /*9541*/
        const int CefX509CertPrincipal_GetCountryName_5 = (_typeNAME << 16) | 5;
        /*9542*/
        const int CefX509CertPrincipal_GetStreetAddresses_6 = (_typeNAME << 16) | 6;
        /*9543*/
        const int CefX509CertPrincipal_GetOrganizationNames_7 = (_typeNAME << 16) | 7;
        /*9544*/
        const int CefX509CertPrincipal_GetOrganizationUnitNames_8 = (_typeNAME << 16) | 8;
        /*9545*/
        const int CefX509CertPrincipal_GetDomainComponents_9 = (_typeNAME << 16) | 9;
        /*9546*/
        internal readonly IntPtr nativePtr;
        /*9547*/
        internal CefX509CertPrincipal(IntPtr nativePtr)
        {
            /*9548*/
            this.nativePtr = nativePtr;
            /*9549*/
        }
        /*9550*/
        public void Release()
        {
            /*9551*/
            JsValue ret;
            /*9552*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_Release_0, out ret);
            /*9553*/
        }

        // gen! CefString GetDisplayName()
        /// <summary>
        /// CefX509CertPrincipal methods.
        /// </summary>
        /*9554*/

        public string GetDisplayName()/*9555*/
        {
            JsValue ret;
            /*9556*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetDisplayName_1, out ret);
            /*9557*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9558*/
            return ret_result;
            /*9559*/
        }

        // gen! CefString GetCommonName()
        /// <summary>
        /// Returns the common name.
        /// /*cef()*/
        /// </summary>
        /*9560*/

        public string GetCommonName()/*9561*/
        {
            JsValue ret;
            /*9562*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetCommonName_2, out ret);
            /*9563*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9564*/
            return ret_result;
            /*9565*/
        }

        // gen! CefString GetLocalityName()
        /// <summary>
        /// Returns the locality name.
        /// /*cef()*/
        /// </summary>
        /*9566*/

        public string GetLocalityName()/*9567*/
        {
            JsValue ret;
            /*9568*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetLocalityName_3, out ret);
            /*9569*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9570*/
            return ret_result;
            /*9571*/
        }

        // gen! CefString GetStateOrProvinceName()
        /// <summary>
        /// Returns the state or province name.
        /// /*cef()*/
        /// </summary>
        /*9572*/

        public string GetStateOrProvinceName()/*9573*/
        {
            JsValue ret;
            /*9574*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetStateOrProvinceName_4, out ret);
            /*9575*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9576*/
            return ret_result;
            /*9577*/
        }

        // gen! CefString GetCountryName()
        /// <summary>
        /// Returns the country name.
        /// /*cef()*/
        /// </summary>
        /*9578*/

        public string GetCountryName()/*9579*/
        {
            JsValue ret;
            /*9580*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetCountryName_5, out ret);
            /*9581*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9582*/
            return ret_result;
            /*9583*/
        }

        // gen! void GetStreetAddresses(std::vector<CefString>& addresses)
        /// <summary>
        /// Retrieve the list of street addresses.
        /// /*cef()*/
        /// </summary>
        /*9584*/

        public void GetStreetAddresses(List<string> /*9585*/
        addresses
        )/*9586*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9587*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetStreetAddresses_6, out ret, ref v1);
            /*9588*/

            /*9589*/
        }

        // gen! void GetOrganizationNames(std::vector<CefString>& names)
        /// <summary>
        /// Retrieve the list of organization names.
        /// /*cef()*/
        /// </summary>
        /*9590*/

        public void GetOrganizationNames(List<string> /*9591*/
        names
        )/*9592*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9593*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetOrganizationNames_7, out ret, ref v1);
            /*9594*/

            /*9595*/
        }

        // gen! void GetOrganizationUnitNames(std::vector<CefString>& names)
        /// <summary>
        /// Retrieve the list of organization unit names.
        /// /*cef()*/
        /// </summary>
        /*9596*/

        public void GetOrganizationUnitNames(List<string> /*9597*/
        names
        )/*9598*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9599*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetOrganizationUnitNames_8, out ret, ref v1);
            /*9600*/

            /*9601*/
        }

        // gen! void GetDomainComponents(std::vector<CefString>& components)
        /// <summary>
        /// Retrieve the list of domain components.
        /// /*cef()*/
        /// </summary>
        /*9602*/

        public void GetDomainComponents(List<string> /*9603*/
        components
        )/*9604*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9605*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetDomainComponents_9, out ret, ref v1);
            /*9606*/

            /*9607*/
        }
        /*9608*/
    }


    // [virtual] class CefX509Certificate
    /// <summary>
    /// Class representing a X.509 certificate.
    /// /*(source=library)*/
    /// </summary>
    /*9667*/
    public struct CefX509Certificate
    {
        /*9668*/
        const int _typeNAME = 53;
        /*9669*/
        const int CefX509Certificate_Release_0 = (_typeNAME << 16) | 0;
        /*9670*/
        const int CefX509Certificate_GetSubject_1 = (_typeNAME << 16) | 1;
        /*9671*/
        const int CefX509Certificate_GetIssuer_2 = (_typeNAME << 16) | 2;
        /*9672*/
        const int CefX509Certificate_GetSerialNumber_3 = (_typeNAME << 16) | 3;
        /*9673*/
        const int CefX509Certificate_GetValidStart_4 = (_typeNAME << 16) | 4;
        /*9674*/
        const int CefX509Certificate_GetValidExpiry_5 = (_typeNAME << 16) | 5;
        /*9675*/
        const int CefX509Certificate_GetDEREncoded_6 = (_typeNAME << 16) | 6;
        /*9676*/
        const int CefX509Certificate_GetPEMEncoded_7 = (_typeNAME << 16) | 7;
        /*9677*/
        const int CefX509Certificate_GetIssuerChainSize_8 = (_typeNAME << 16) | 8;
        /*9678*/
        const int CefX509Certificate_GetDEREncodedIssuerChain_9 = (_typeNAME << 16) | 9;
        /*9679*/
        const int CefX509Certificate_GetPEMEncodedIssuerChain_10 = (_typeNAME << 16) | 10;
        /*9680*/
        internal readonly IntPtr nativePtr;
        /*9681*/
        internal CefX509Certificate(IntPtr nativePtr)
        {
            /*9682*/
            this.nativePtr = nativePtr;
            /*9683*/
        }
        /*9684*/
        public void Release()
        {
            /*9685*/
            JsValue ret;
            /*9686*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_Release_0, out ret);
            /*9687*/
        }

        // gen! CefRefPtr<CefX509CertPrincipal> GetSubject()
        /// <summary>
        /// CefX509Certificate methods.
        /// </summary>
        /*9688*/

        public CefX509CertPrincipal GetSubject()/*9689*/
        {
            JsValue ret;
            /*9690*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetSubject_1, out ret);
            /*9691*/
            var ret_result = new CefX509CertPrincipal(ret.Ptr);
            /*9692*/
            return ret_result;
            /*9693*/
        }

        // gen! CefRefPtr<CefX509CertPrincipal> GetIssuer()
        /// <summary>
        /// Returns the issuer of the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*9694*/

        public CefX509CertPrincipal GetIssuer()/*9695*/
        {
            JsValue ret;
            /*9696*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetIssuer_2, out ret);
            /*9697*/
            var ret_result = new CefX509CertPrincipal(ret.Ptr);
            /*9698*/
            return ret_result;
            /*9699*/
        }

        // gen! CefRefPtr<CefBinaryValue> GetSerialNumber()
        /// <summary>
        /// Returns the DER encoded serial number for the X.509 certificate. The value
        /// possibly includes a leading 00 byte.
        /// /*cef()*/
        /// </summary>
        /*9700*/

        public CefBinaryValue GetSerialNumber()/*9701*/
        {
            JsValue ret;
            /*9702*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetSerialNumber_3, out ret);
            /*9703*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*9704*/
            return ret_result;
            /*9705*/
        }

        // gen! CefTime GetValidStart()
        /// <summary>
        /// Returns the date before which the X.509 certificate is invalid.
        /// CefTime.GetTimeT() will return 0 if no date was specified.
        /// /*cef()*/
        /// </summary>
        /*9706*/

        public CefTime GetValidStart()/*9707*/
        {
            JsValue ret;
            /*9708*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetValidStart_4, out ret);
            /*9709*/
            var ret_result = new CefTime(ret.Ptr);

            /*9710*/
            return ret_result;
            /*9711*/
        }

        // gen! CefTime GetValidExpiry()
        /// <summary>
        /// Returns the date after which the X.509 certificate is invalid.
        /// CefTime.GetTimeT() will return 0 if no date was specified.
        /// /*cef()*/
        /// </summary>
        /*9712*/

        public CefTime GetValidExpiry()/*9713*/
        {
            JsValue ret;
            /*9714*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetValidExpiry_5, out ret);
            /*9715*/
            var ret_result = new CefTime(ret.Ptr);

            /*9716*/
            return ret_result;
            /*9717*/
        }

        // gen! CefRefPtr<CefBinaryValue> GetDEREncoded()
        /// <summary>
        /// Returns the DER encoded data for the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*9718*/

        public CefBinaryValue GetDEREncoded()/*9719*/
        {
            JsValue ret;
            /*9720*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetDEREncoded_6, out ret);
            /*9721*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*9722*/
            return ret_result;
            /*9723*/
        }

        // gen! CefRefPtr<CefBinaryValue> GetPEMEncoded()
        /// <summary>
        /// Returns the PEM encoded data for the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*9724*/

        public CefBinaryValue GetPEMEncoded()/*9725*/
        {
            JsValue ret;
            /*9726*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetPEMEncoded_7, out ret);
            /*9727*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*9728*/
            return ret_result;
            /*9729*/
        }

        // gen! size_t GetIssuerChainSize()
        /// <summary>
        /// Returns the number of certificates in the issuer chain.
        /// If 0, the certificate is self-signed.
        /// /*cef()*/
        /// </summary>
        /*9730*/

        public uint GetIssuerChainSize()/*9731*/
        {
            JsValue ret;
            /*9732*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetIssuerChainSize_8, out ret);
            /*9733*/
            var ret_result = (uint)ret.I32;
            /*9734*/
            return ret_result;
            /*9735*/
        }

        // gen! void GetDEREncodedIssuerChain(IssuerChainBinaryList& chain)
        /// <summary>
        /// Returns the DER encoded data for the certificate issuer chain.
        /// If we failed to encode a certificate in the chain it is still
        /// present in the array but is an empty string.
        /// /*cef(count_func=chain:GetIssuerChainSize)*/
        /// </summary>
        /*9736*/

        public void GetDEREncodedIssuerChain(IssuerChainBinaryList /*9737*/
        chain
        )/*9738*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9739*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509Certificate_GetDEREncodedIssuerChain_9, out ret, ref v1);
            /*9740*/

            /*9741*/
        }

        // gen! void GetPEMEncodedIssuerChain(IssuerChainBinaryList& chain)
        /// <summary>
        /// Returns the PEM encoded data for the certificate issuer chain.
        /// If we failed to encode a certificate in the chain it is still
        /// present in the array but is an empty string.
        /// /*cef(count_func=chain:GetIssuerChainSize)*/
        /// </summary>
        /*9742*/

        public void GetPEMEncodedIssuerChain(IssuerChainBinaryList /*9743*/
        chain
        )/*9744*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9745*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509Certificate_GetPEMEncodedIssuerChain_10, out ret, ref v1);
            /*9746*/

            /*9747*/
        }
        /*9748*/
    }


    // [virtual] class CefXmlReader
    /// <summary>
    /// Class that supports the reading of XML data via the libxml streaming API.
    /// The methods of this class should only be called on the thread that creates
    /// the object.
    /// /*(source=library)*/
    /// </summary>
    /*9902*/
    public struct CefXmlReader
    {
        /*9903*/
        const int _typeNAME = 54;
        /*9904*/
        const int CefXmlReader_Release_0 = (_typeNAME << 16) | 0;
        /*9905*/
        const int CefXmlReader_MoveToNextNode_1 = (_typeNAME << 16) | 1;
        /*9906*/
        const int CefXmlReader_Close_2 = (_typeNAME << 16) | 2;
        /*9907*/
        const int CefXmlReader_HasError_3 = (_typeNAME << 16) | 3;
        /*9908*/
        const int CefXmlReader_GetError_4 = (_typeNAME << 16) | 4;
        /*9909*/
        const int CefXmlReader_GetType_5 = (_typeNAME << 16) | 5;
        /*9910*/
        const int CefXmlReader_GetDepth_6 = (_typeNAME << 16) | 6;
        /*9911*/
        const int CefXmlReader_GetLocalName_7 = (_typeNAME << 16) | 7;
        /*9912*/
        const int CefXmlReader_GetPrefix_8 = (_typeNAME << 16) | 8;
        /*9913*/
        const int CefXmlReader_GetQualifiedName_9 = (_typeNAME << 16) | 9;
        /*9914*/
        const int CefXmlReader_GetNamespaceURI_10 = (_typeNAME << 16) | 10;
        /*9915*/
        const int CefXmlReader_GetBaseURI_11 = (_typeNAME << 16) | 11;
        /*9916*/
        const int CefXmlReader_GetXmlLang_12 = (_typeNAME << 16) | 12;
        /*9917*/
        const int CefXmlReader_IsEmptyElement_13 = (_typeNAME << 16) | 13;
        /*9918*/
        const int CefXmlReader_HasValue_14 = (_typeNAME << 16) | 14;
        /*9919*/
        const int CefXmlReader_GetValue_15 = (_typeNAME << 16) | 15;
        /*9920*/
        const int CefXmlReader_HasAttributes_16 = (_typeNAME << 16) | 16;
        /*9921*/
        const int CefXmlReader_GetAttributeCount_17 = (_typeNAME << 16) | 17;
        /*9922*/
        const int CefXmlReader_GetAttribute_18 = (_typeNAME << 16) | 18;
        /*9923*/
        const int CefXmlReader_GetAttribute_19 = (_typeNAME << 16) | 19;
        /*9924*/
        const int CefXmlReader_GetAttribute_20 = (_typeNAME << 16) | 20;
        /*9925*/
        const int CefXmlReader_GetInnerXml_21 = (_typeNAME << 16) | 21;
        /*9926*/
        const int CefXmlReader_GetOuterXml_22 = (_typeNAME << 16) | 22;
        /*9927*/
        const int CefXmlReader_GetLineNumber_23 = (_typeNAME << 16) | 23;
        /*9928*/
        const int CefXmlReader_MoveToAttribute_24 = (_typeNAME << 16) | 24;
        /*9929*/
        const int CefXmlReader_MoveToAttribute_25 = (_typeNAME << 16) | 25;
        /*9930*/
        const int CefXmlReader_MoveToAttribute_26 = (_typeNAME << 16) | 26;
        /*9931*/
        const int CefXmlReader_MoveToFirstAttribute_27 = (_typeNAME << 16) | 27;
        /*9932*/
        const int CefXmlReader_MoveToNextAttribute_28 = (_typeNAME << 16) | 28;
        /*9933*/
        const int CefXmlReader_MoveToCarryingElement_29 = (_typeNAME << 16) | 29;
        /*9934*/
        internal readonly IntPtr nativePtr;
        /*9935*/
        internal CefXmlReader(IntPtr nativePtr)
        {
            /*9936*/
            this.nativePtr = nativePtr;
            /*9937*/
        }
        /*9938*/
        public void Release()
        {
            /*9939*/
            JsValue ret;
            /*9940*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_Release_0, out ret);
            /*9941*/
        }

        // gen! bool MoveToNextNode()
        /// <summary>
        /// CefXmlReader methods.
        /// </summary>
        /*9942*/

        public bool MoveToNextNode()/*9943*/
        {
            JsValue ret;
            /*9944*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToNextNode_1, out ret);
            /*9945*/
            var ret_result = ret.I32 != 0;
            /*9946*/
            return ret_result;
            /*9947*/
        }

        // gen! bool Close()
        /// <summary>
        /// Close the document. This should be called directly to ensure that cleanup
        /// occurs on the correct thread.
        /// /*cef()*/
        /// </summary>
        /*9948*/

        public bool Close()/*9949*/
        {
            JsValue ret;
            /*9950*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_Close_2, out ret);
            /*9951*/
            var ret_result = ret.I32 != 0;
            /*9952*/
            return ret_result;
            /*9953*/
        }

        // gen! bool HasError()
        /// <summary>
        /// Returns true if an error has been reported by the XML parser.
        /// /*cef()*/
        /// </summary>
        /*9954*/

        public bool HasError()/*9955*/
        {
            JsValue ret;
            /*9956*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasError_3, out ret);
            /*9957*/
            var ret_result = ret.I32 != 0;
            /*9958*/
            return ret_result;
            /*9959*/
        }

        // gen! CefString GetError()
        /// <summary>
        /// Returns the error string.
        /// /*cef()*/
        /// </summary>
        /*9960*/

        public string GetError()/*9961*/
        {
            JsValue ret;
            /*9962*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetError_4, out ret);
            /*9963*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9964*/
            return ret_result;
            /*9965*/
        }

        // gen! NodeType GetType()
        /// <summary>
        /// The below methods retrieve data for the node at the current cursor
        /// position.
        /// Returns the node type.
        /// /*cef(default_retval=XML_NODE_UNSUPPORTED)*/
        /// </summary>
        /*9966*/

        public cef_xml_node_type_t _GetType()/*9967*/
        {
            JsValue ret;
            /*9968*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetType_5, out ret);
            /*9969*/
            var ret_result = (cef_xml_node_type_t)ret.I32;

            /*9970*/
            return ret_result;
            /*9971*/
        }

        // gen! int GetDepth()
        /// <summary>
        /// Returns the node depth. Depth starts at 0 for the root node.
        /// /*cef()*/
        /// </summary>
        /*9972*/

        public int GetDepth()/*9973*/
        {
            JsValue ret;
            /*9974*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetDepth_6, out ret);
            /*9975*/
            var ret_result = ret.I32;
            /*9976*/
            return ret_result;
            /*9977*/
        }

        // gen! CefString GetLocalName()
        /// <summary>
        /// Returns the local name. See
        /// http://www.w3.org/TR/REC-xml-names/#NT-LocalPart for additional details.
        /// /*cef()*/
        /// </summary>
        /*9978*/

        public string GetLocalName()/*9979*/
        {
            JsValue ret;
            /*9980*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetLocalName_7, out ret);
            /*9981*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9982*/
            return ret_result;
            /*9983*/
        }

        // gen! CefString GetPrefix()
        /// <summary>
        /// Returns the namespace prefix. See http://www.w3.org/TR/REC-xml-names/ for
        /// additional details.
        /// /*cef()*/
        /// </summary>
        /*9984*/

        public string GetPrefix()/*9985*/
        {
            JsValue ret;
            /*9986*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetPrefix_8, out ret);
            /*9987*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9988*/
            return ret_result;
            /*9989*/
        }

        // gen! CefString GetQualifiedName()
        /// <summary>
        /// Returns the qualified name, equal to (Prefix:)LocalName. See
        /// http://www.w3.org/TR/REC-xml-names/#ns-qualnames for additional details.
        /// /*cef()*/
        /// </summary>
        /*9990*/

        public string GetQualifiedName()/*9991*/
        {
            JsValue ret;
            /*9992*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetQualifiedName_9, out ret);
            /*9993*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9994*/
            return ret_result;
            /*9995*/
        }

        // gen! CefString GetNamespaceURI()
        /// <summary>
        /// Returns the URI defining the namespace associated with the node. See
        /// http://www.w3.org/TR/REC-xml-names/ for additional details.
        /// /*cef()*/
        /// </summary>
        /*9996*/

        public string GetNamespaceURI()/*9997*/
        {
            JsValue ret;
            /*9998*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetNamespaceURI_10, out ret);
            /*9999*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10000*/
            return ret_result;
            /*10001*/
        }

        // gen! CefString GetBaseURI()
        /// <summary>
        /// Returns the base URI of the node. See http://www.w3.org/TR/xmlbase/ for
        /// additional details.
        /// /*cef()*/
        /// </summary>
        /*10002*/

        public string GetBaseURI()/*10003*/
        {
            JsValue ret;
            /*10004*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetBaseURI_11, out ret);
            /*10005*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10006*/
            return ret_result;
            /*10007*/
        }

        // gen! CefString GetXmlLang()
        /// <summary>
        /// Returns the xml:lang scope within which the node resides. See
        /// http://www.w3.org/TR/REC-xml/#sec-lang-tag for additional details.
        /// /*cef()*/
        /// </summary>
        /*10008*/

        public string GetXmlLang()/*10009*/
        {
            JsValue ret;
            /*10010*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetXmlLang_12, out ret);
            /*10011*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10012*/
            return ret_result;
            /*10013*/
        }

        // gen! bool IsEmptyElement()
        /// <summary>
        /// Returns true if the node represents an empty element. <a/> is considered
        /// empty but <a></a> is not.
        /// /*cef()*/
        /// </summary>
        /*10014*/

        public bool IsEmptyElement()/*10015*/
        {
            JsValue ret;
            /*10016*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_IsEmptyElement_13, out ret);
            /*10017*/
            var ret_result = ret.I32 != 0;
            /*10018*/
            return ret_result;
            /*10019*/
        }

        // gen! bool HasValue()
        /// <summary>
        /// Returns true if the node has a text value.
        /// /*cef()*/
        /// </summary>
        /*10020*/

        public bool HasValue()/*10021*/
        {
            JsValue ret;
            /*10022*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasValue_14, out ret);
            /*10023*/
            var ret_result = ret.I32 != 0;
            /*10024*/
            return ret_result;
            /*10025*/
        }

        // gen! CefString GetValue()
        /// <summary>
        /// Returns the text value.
        /// /*cef()*/
        /// </summary>
        /*10026*/

        public string GetValue()/*10027*/
        {
            JsValue ret;
            /*10028*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetValue_15, out ret);
            /*10029*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10030*/
            return ret_result;
            /*10031*/
        }

        // gen! bool HasAttributes()
        /// <summary>
        /// Returns true if the node has attributes.
        /// /*cef()*/
        /// </summary>
        /*10032*/

        public bool HasAttributes()/*10033*/
        {
            JsValue ret;
            /*10034*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasAttributes_16, out ret);
            /*10035*/
            var ret_result = ret.I32 != 0;
            /*10036*/
            return ret_result;
            /*10037*/
        }

        // gen! size_t GetAttributeCount()
        /// <summary>
        /// Returns the number of attributes.
        /// /*cef()*/
        /// </summary>
        /*10038*/

        public uint GetAttributeCount()/*10039*/
        {
            JsValue ret;
            /*10040*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetAttributeCount_17, out ret);
            /*10041*/
            var ret_result = (uint)ret.I32;
            /*10042*/
            return ret_result;
            /*10043*/
        }

        // gen! CefString GetAttribute(int index)
        /*10044*/

        public string GetAttribute(int /*10045*/
        index
        )/*10046*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*10047*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_GetAttribute_18, out ret, ref v1);
            /*10048*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10049*/
            return ret_result;
            /*10050*/
        }

        // gen! CefString GetAttribute(const CefString& qualifiedName)
        /*10051*/

        public string GetAttribute(string /*10052*/
        qualifiedName
        )/*10053*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(qualifiedName);
            /*10054*/
            ;
            /*10055*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_GetAttribute_19, out ret, ref v1);
            /*10056*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10057*/
            ;
            /*10058*/
            return ret_result;
            /*10059*/
        }

        // gen! CefString GetAttribute(const CefString& localName,const CefString& namespaceURI)
        /*10060*/

        public string GetAttribute(string /*10061*/
        localName
        , string /*10062*/
        namespaceURI
        )/*10063*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(localName);
            /*10064*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(namespaceURI);
            /*10065*/
            ;
            /*10066*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefXmlReader_GetAttribute_20, out ret, ref v1, ref v2);
            /*10067*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10068*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*10069*/
            ;
            /*10070*/
            return ret_result;
            /*10071*/
        }

        // gen! CefString GetInnerXml()
        /// <summary>
        /// Returns an XML representation of the current node's children.
        /// /*cef()*/
        /// </summary>
        /*10072*/

        public string GetInnerXml()/*10073*/
        {
            JsValue ret;
            /*10074*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetInnerXml_21, out ret);
            /*10075*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10076*/
            return ret_result;
            /*10077*/
        }

        // gen! CefString GetOuterXml()
        /// <summary>
        /// Returns an XML representation of the current node including its children.
        /// /*cef()*/
        /// </summary>
        /*10078*/

        public string GetOuterXml()/*10079*/
        {
            JsValue ret;
            /*10080*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetOuterXml_22, out ret);
            /*10081*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10082*/
            return ret_result;
            /*10083*/
        }

        // gen! int GetLineNumber()
        /// <summary>
        /// Returns the line number for the current node.
        /// /*cef()*/
        /// </summary>
        /*10084*/

        public int GetLineNumber()/*10085*/
        {
            JsValue ret;
            /*10086*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetLineNumber_23, out ret);
            /*10087*/
            var ret_result = ret.I32;
            /*10088*/
            return ret_result;
            /*10089*/
        }

        // gen! bool MoveToAttribute(int index)
        /*10090*/

        public bool MoveToAttribute(int /*10091*/
        index
        )/*10092*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*10093*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_MoveToAttribute_24, out ret, ref v1);
            /*10094*/
            var ret_result = ret.I32 != 0;
            /*10095*/
            return ret_result;
            /*10096*/
        }

        // gen! bool MoveToAttribute(const CefString& qualifiedName)
        /*10097*/

        public bool MoveToAttribute(string /*10098*/
        qualifiedName
        )/*10099*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(qualifiedName);
            /*10100*/
            ;
            /*10101*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_MoveToAttribute_25, out ret, ref v1);
            /*10102*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10103*/
            ;
            /*10104*/
            return ret_result;
            /*10105*/
        }

        // gen! bool MoveToAttribute(const CefString& localName,const CefString& namespaceURI)
        /*10106*/

        public bool MoveToAttribute(string /*10107*/
        localName
        , string /*10108*/
        namespaceURI
        )/*10109*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(localName);
            /*10110*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(namespaceURI);
            /*10111*/
            ;
            /*10112*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefXmlReader_MoveToAttribute_26, out ret, ref v1, ref v2);
            /*10113*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10114*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*10115*/
            ;
            /*10116*/
            return ret_result;
            /*10117*/
        }

        // gen! bool MoveToFirstAttribute()
        /// <summary>
        /// Moves the cursor to the first attribute in the current element. Returns
        /// true if the cursor position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10118*/

        public bool MoveToFirstAttribute()/*10119*/
        {
            JsValue ret;
            /*10120*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToFirstAttribute_27, out ret);
            /*10121*/
            var ret_result = ret.I32 != 0;
            /*10122*/
            return ret_result;
            /*10123*/
        }

        // gen! bool MoveToNextAttribute()
        /// <summary>
        /// Moves the cursor to the next attribute in the current element. Returns
        /// true if the cursor position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10124*/

        public bool MoveToNextAttribute()/*10125*/
        {
            JsValue ret;
            /*10126*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToNextAttribute_28, out ret);
            /*10127*/
            var ret_result = ret.I32 != 0;
            /*10128*/
            return ret_result;
            /*10129*/
        }

        // gen! bool MoveToCarryingElement()
        /// <summary>
        /// Moves the cursor back to the carrying element. Returns true if the cursor
        /// position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10130*/

        public bool MoveToCarryingElement()/*10131*/
        {
            JsValue ret;
            /*10132*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToCarryingElement_29, out ret);
            /*10133*/
            var ret_result = ret.I32 != 0;
            /*10134*/
            return ret_result;
            /*10135*/
        }
        /*10136*/
    }


    // [virtual] class CefZipReader
    /// <summary>
    /// Class that supports the reading of zip archives via the zlib unzip API.
    /// The methods of this class should only be called on the thread that creates
    /// the object.
    /// /*(source=library)*/
    /// </summary>
    /*10205*/
    public struct CefZipReader
    {
        /*10206*/
        const int _typeNAME = 55;
        /*10207*/
        const int CefZipReader_Release_0 = (_typeNAME << 16) | 0;
        /*10208*/
        const int CefZipReader_MoveToFirstFile_1 = (_typeNAME << 16) | 1;
        /*10209*/
        const int CefZipReader_MoveToNextFile_2 = (_typeNAME << 16) | 2;
        /*10210*/
        const int CefZipReader_MoveToFile_3 = (_typeNAME << 16) | 3;
        /*10211*/
        const int CefZipReader_Close_4 = (_typeNAME << 16) | 4;
        /*10212*/
        const int CefZipReader_GetFileName_5 = (_typeNAME << 16) | 5;
        /*10213*/
        const int CefZipReader_GetFileSize_6 = (_typeNAME << 16) | 6;
        /*10214*/
        const int CefZipReader_GetFileLastModified_7 = (_typeNAME << 16) | 7;
        /*10215*/
        const int CefZipReader_OpenFile_8 = (_typeNAME << 16) | 8;
        /*10216*/
        const int CefZipReader_CloseFile_9 = (_typeNAME << 16) | 9;
        /*10217*/
        const int CefZipReader_ReadFile_10 = (_typeNAME << 16) | 10;
        /*10218*/
        const int CefZipReader_Tell_11 = (_typeNAME << 16) | 11;
        /*10219*/
        const int CefZipReader_Eof_12 = (_typeNAME << 16) | 12;
        /*10220*/
        internal readonly IntPtr nativePtr;
        /*10221*/
        internal CefZipReader(IntPtr nativePtr)
        {
            /*10222*/
            this.nativePtr = nativePtr;
            /*10223*/
        }
        /*10224*/
        public void Release()
        {
            /*10225*/
            JsValue ret;
            /*10226*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Release_0, out ret);
            /*10227*/
        }

        // gen! bool MoveToFirstFile()
        /// <summary>
        /// CefZipReader methods.
        /// </summary>
        /*10228*/

        public bool MoveToFirstFile()/*10229*/
        {
            JsValue ret;
            /*10230*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_MoveToFirstFile_1, out ret);
            /*10231*/
            var ret_result = ret.I32 != 0;
            /*10232*/
            return ret_result;
            /*10233*/
        }

        // gen! bool MoveToNextFile()
        /// <summary>
        /// Moves the cursor to the next file in the archive. Returns true if the
        /// cursor position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10234*/

        public bool MoveToNextFile()/*10235*/
        {
            JsValue ret;
            /*10236*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_MoveToNextFile_2, out ret);
            /*10237*/
            var ret_result = ret.I32 != 0;
            /*10238*/
            return ret_result;
            /*10239*/
        }

        // gen! bool MoveToFile(const CefString& fileName,bool caseSensitive)
        /// <summary>
        /// Moves the cursor to the specified file in the archive. If |caseSensitive|
        /// is true then the search will be case sensitive. Returns true if the cursor
        /// position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10240*/

        public bool MoveToFile(string /*10241*/
        fileName
        , bool /*10242*/
        caseSensitive
        )/*10243*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(fileName);
            /*10244*/
            ;
            /*10245*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefZipReader_MoveToFile_3, out ret, ref v1, ref v2);
            /*10246*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10247*/
            ;
            /*10248*/
            return ret_result;
            /*10249*/
        }

        // gen! bool Close()
        /// <summary>
        /// Closes the archive. This should be called directly to ensure that cleanup
        /// occurs on the correct thread.
        /// /*cef()*/
        /// </summary>
        /*10250*/

        public bool Close()/*10251*/
        {
            JsValue ret;
            /*10252*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Close_4, out ret);
            /*10253*/
            var ret_result = ret.I32 != 0;
            /*10254*/
            return ret_result;
            /*10255*/
        }

        // gen! CefString GetFileName()
        /// <summary>
        /// The below methods act on the file at the current cursor position.
        /// Returns the name of the file.
        /// /*cef()*/
        /// </summary>
        /*10256*/

        public string GetFileName()/*10257*/
        {
            JsValue ret;
            /*10258*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileName_5, out ret);
            /*10259*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10260*/
            return ret_result;
            /*10261*/
        }

        // gen! int64 GetFileSize()
        /// <summary>
        /// Returns the uncompressed size of the file.
        /// /*cef()*/
        /// </summary>
        /*10262*/

        public long GetFileSize()/*10263*/
        {
            JsValue ret;
            /*10264*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileSize_6, out ret);
            /*10265*/
            var ret_result = ret.I64;
            /*10266*/
            return ret_result;
            /*10267*/
        }

        // gen! CefTime GetFileLastModified()
        /// <summary>
        /// Returns the last modified timestamp for the file.
        /// /*cef()*/
        /// </summary>
        /*10268*/

        public CefTime GetFileLastModified()/*10269*/
        {
            JsValue ret;
            /*10270*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileLastModified_7, out ret);
            /*10271*/
            var ret_result = new CefTime(ret.Ptr);

            /*10272*/
            return ret_result;
            /*10273*/
        }

        // gen! bool OpenFile(const CefString& password)
        /// <summary>
        /// Opens the file for reading of uncompressed data. A read password may
        /// optionally be specified.
        /// /*cef(optional_param=password)*/
        /// </summary>
        /*10274*/

        public bool OpenFile(string /*10275*/
        password
        )/*10276*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(password);
            /*10277*/
            ;
            /*10278*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefZipReader_OpenFile_8, out ret, ref v1);
            /*10279*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10280*/
            ;
            /*10281*/
            return ret_result;
            /*10282*/
        }

        // gen! bool CloseFile()
        /// <summary>
        /// Closes the file.
        /// /*cef()*/
        /// </summary>
        /*10283*/

        public bool CloseFile()/*10284*/
        {
            JsValue ret;
            /*10285*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_CloseFile_9, out ret);
            /*10286*/
            var ret_result = ret.I32 != 0;
            /*10287*/
            return ret_result;
            /*10288*/
        }

        // gen! int ReadFile(void* buffer,size_t bufferSize)
        /// <summary>
        /// Read uncompressed file contents into the specified buffer. Returns < 0 if
        /// an error occurred, 0 if at the end of file, or the number of bytes read.
        /// /*cef()*/
        /// </summary>
        /*10289*/

        public int ReadFile(IntPtr /*10290*/
        buffer
        , uint /*10291*/
        bufferSize
        )/*10292*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*10293*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefZipReader_ReadFile_10, out ret, ref v1, ref v2);
            /*10294*/
            var ret_result = ret.I32;
            /*10295*/
            return ret_result;
            /*10296*/
        }

        // gen! int64 Tell()
        /// <summary>
        /// Returns the current offset in the uncompressed file contents.
        /// /*cef()*/
        /// </summary>
        /*10297*/

        public long Tell()/*10298*/
        {
            JsValue ret;
            /*10299*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Tell_11, out ret);
            /*10300*/
            var ret_result = ret.I64;
            /*10301*/
            return ret_result;
            /*10302*/
        }

        // gen! bool Eof()
        /// <summary>
        /// Returns true if at end of the file contents.
        /// /*cef()*/
        /// </summary>
        /*10303*/

        public bool Eof()/*10304*/
        {
            JsValue ret;
            /*10305*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Eof_12, out ret);
            /*10306*/
            var ret_result = ret.I32 != 0;
            /*10307*/
            return ret_result;
            /*10308*/
        }
        /*10309*/
    }

}
