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
        /// <summary>
        /// CefBrowser methods.
        /// </summary>
        /*944*/


        // gen! CefRefPtr<CefBrowserHost> GetHost()
        /*945*/

        public CefBrowserHost GetHost()/*946*/
        {
            JsValue ret;
            /*947*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetHost_1, out ret);
            /*948*/
            var ret_result = new CefBrowserHost(ret.Ptr);
            /*949*/
            return ret_result;
            /*950*/
        }
        /// <summary>
        /// Returns true if the browser can navigate backwards.
        /// /*cef()*/
        /// </summary>
        /*951*/


        // gen! bool CanGoBack()
        /*952*/

        public bool CanGoBack()/*953*/
        {
            JsValue ret;
            /*954*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_CanGoBack_2, out ret);
            /*955*/
            var ret_result = ret.I32 != 0;
            /*956*/
            return ret_result;
            /*957*/
        }
        /// <summary>
        /// Navigate backwards.
        /// /*cef()*/
        /// </summary>
        /*958*/


        // gen! void GoBack()
        /*959*/

        public void GoBack()/*960*/
        {
            JsValue ret;
            /*961*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GoBack_3, out ret);
            /*962*/

            /*963*/
        }
        /// <summary>
        /// Returns true if the browser can navigate forwards.
        /// /*cef()*/
        /// </summary>
        /*964*/


        // gen! bool CanGoForward()
        /*965*/

        public bool CanGoForward()/*966*/
        {
            JsValue ret;
            /*967*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_CanGoForward_4, out ret);
            /*968*/
            var ret_result = ret.I32 != 0;
            /*969*/
            return ret_result;
            /*970*/
        }
        /// <summary>
        /// Navigate forwards.
        /// /*cef()*/
        /// </summary>
        /*971*/


        // gen! void GoForward()
        /*972*/

        public void GoForward()/*973*/
        {
            JsValue ret;
            /*974*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GoForward_5, out ret);
            /*975*/

            /*976*/
        }
        /// <summary>
        /// Returns true if the browser is currently loading.
        /// /*cef()*/
        /// </summary>
        /*977*/


        // gen! bool IsLoading()
        /*978*/

        public bool IsLoading()/*979*/
        {
            JsValue ret;
            /*980*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_IsLoading_6, out ret);
            /*981*/
            var ret_result = ret.I32 != 0;
            /*982*/
            return ret_result;
            /*983*/
        }
        /// <summary>
        /// Reload the current page.
        /// /*cef()*/
        /// </summary>
        /*984*/


        // gen! void Reload()
        /*985*/

        public void Reload()/*986*/
        {
            JsValue ret;
            /*987*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_Reload_7, out ret);
            /*988*/

            /*989*/
        }
        /// <summary>
        /// Reload the current page ignoring any cached data.
        /// /*cef()*/
        /// </summary>
        /*990*/


        // gen! void ReloadIgnoreCache()
        /*991*/

        public void ReloadIgnoreCache()/*992*/
        {
            JsValue ret;
            /*993*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_ReloadIgnoreCache_8, out ret);
            /*994*/

            /*995*/
        }
        /// <summary>
        /// Stop loading the page.
        /// /*cef()*/
        /// </summary>
        /*996*/


        // gen! void StopLoad()
        /*997*/

        public void StopLoad()/*998*/
        {
            JsValue ret;
            /*999*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_StopLoad_9, out ret);
            /*1000*/

            /*1001*/
        }
        /// <summary>
        /// Returns the globally unique identifier for this browser.
        /// /*cef()*/
        /// </summary>
        /*1002*/


        // gen! int GetIdentifier()
        /*1003*/

        public int GetIdentifier()/*1004*/
        {
            JsValue ret;
            /*1005*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetIdentifier_10, out ret);
            /*1006*/
            var ret_result = ret.I32;
            /*1007*/
            return ret_result;
            /*1008*/
        }
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>
        /*1009*/


        // gen! bool IsSame(CefRefPtr<CefBrowser> that)
        /*1010*/

        public bool IsSame(CefBrowser /*1011*/
        that
        )/*1012*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1013*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_IsSame_11, out ret, ref v1);
            /*1014*/
            var ret_result = ret.I32 != 0;
            /*1015*/
            return ret_result;
            /*1016*/
        }
        /// <summary>
        /// Returns true if the window is a popup window.
        /// /*cef()*/
        /// </summary>
        /*1017*/


        // gen! bool IsPopup()
        /*1018*/

        public bool IsPopup()/*1019*/
        {
            JsValue ret;
            /*1020*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_IsPopup_12, out ret);
            /*1021*/
            var ret_result = ret.I32 != 0;
            /*1022*/
            return ret_result;
            /*1023*/
        }
        /// <summary>
        /// Returns true if a document has been loaded in the browser.
        /// /*cef()*/
        /// </summary>
        /*1024*/


        // gen! bool HasDocument()
        /*1025*/

        public bool HasDocument()/*1026*/
        {
            JsValue ret;
            /*1027*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_HasDocument_13, out ret);
            /*1028*/
            var ret_result = ret.I32 != 0;
            /*1029*/
            return ret_result;
            /*1030*/
        }
        /// <summary>
        /// Returns the main (top-level) frame for the browser window.
        /// /*cef()*/
        /// </summary>
        /*1031*/


        // gen! CefRefPtr<CefFrame> GetMainFrame()
        /*1032*/

        public CefFrame GetMainFrame()/*1033*/
        {
            JsValue ret;
            /*1034*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetMainFrame_14, out ret);
            /*1035*/
            var ret_result = new CefFrame(ret.Ptr);
            /*1036*/
            return ret_result;
            /*1037*/
        }
        /// <summary>
        /// Returns the focused frame for the browser window.
        /// /*cef()*/
        /// </summary>
        /*1038*/


        // gen! CefRefPtr<CefFrame> GetFocusedFrame()
        /*1039*/

        public CefFrame GetFocusedFrame()/*1040*/
        {
            JsValue ret;
            /*1041*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetFocusedFrame_15, out ret);
            /*1042*/
            var ret_result = new CefFrame(ret.Ptr);
            /*1043*/
            return ret_result;
            /*1044*/
        }
        /*1045*/


        // gen! CefRefPtr<CefFrame> GetFrame(int64 identifier)
        /*1046*/

        public CefFrame GetFrame(long /*1047*/
        identifier
        )/*1048*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1049*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrame_16, out ret, ref v1);
            /*1050*/
            var ret_result = new CefFrame(ret.Ptr);
            /*1051*/
            return ret_result;
            /*1052*/
        }
        /*1053*/


        // gen! CefRefPtr<CefFrame> GetFrame(const CefString& name)
        /*1054*/

        public CefFrame GetFrame(string /*1055*/
        name
        )/*1056*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*1057*/
            ;
            /*1058*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrame_17, out ret, ref v1);
            /*1059*/
            var ret_result = new CefFrame(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1060*/
            ;
            /*1061*/
            return ret_result;
            /*1062*/
        }
        /// <summary>
        /// Returns the number of frames that currently exist.
        /// /*cef()*/
        /// </summary>
        /*1063*/


        // gen! size_t GetFrameCount()
        /*1064*/

        public uint GetFrameCount()/*1065*/
        {
            JsValue ret;
            /*1066*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetFrameCount_18, out ret);
            /*1067*/
            var ret_result = (uint)ret.I32;
            /*1068*/
            return ret_result;
            /*1069*/
        }
        /// <summary>
        /// Returns the identifiers of all existing frames.
        /// /*cef(count_func=identifiers:GetFrameCount)*/
        /// </summary>
        /*1070*/


        // gen! void GetFrameIdentifiers(std::vector<int64>& identifiers)
        /*1071*/

        public void GetFrameIdentifiers(List<long> /*1072*/
        identifiers
        )/*1073*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1074*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrameIdentifiers_19, out ret, ref v1);
            /*1075*/

            /*1076*/
        }
        /// <summary>
        /// Returns the names of all existing frames.
        /// /*cef()*/
        /// </summary>
        /*1077*/


        // gen! void GetFrameNames(std::vector<CefString>& names)
        /*1078*/

        public void GetFrameNames(List<string> /*1079*/
        names
        )/*1080*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1081*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrameNames_20, out ret, ref v1);
            /*1082*/

            /*1083*/
        }
        /// <summary>
        /// Send a message to the specified |target_process|. Returns true if the
        /// message was sent successfully.
        /// /*cef()*/
        /// </summary>
        /*1084*/


        // gen! bool SendProcessMessage(CefProcessId target_process,CefRefPtr<CefProcessMessage> message)
        /*1085*/

        public bool SendProcessMessage(cef_process_id_t /*1086*/
        target_process
        , CefProcessMessage /*1087*/
        message
        )/*1088*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*1089*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowser_SendProcessMessage_21, out ret, ref v1, ref v2);
            /*1090*/
            var ret_result = ret.I32 != 0;
            /*1091*/
            return ret_result;
            /*1092*/
        }
        /*1093*/
    }


    // [virtual] class CefNavigationEntryVisitor
    /// <summary>
    /// Callback interface for CefBrowserHost::GetNavigationEntries. The methods of
    /// this class will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    /*1102*/
    public struct CefNavigationEntryVisitor
    {
        /*1103*/
        const int _typeNAME = 3;
        /*1104*/
        const int CefNavigationEntryVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*1105*/
        internal readonly IntPtr nativePtr;
        /*1106*/
        internal CefNavigationEntryVisitor(IntPtr nativePtr)
        {
            /*1107*/
            this.nativePtr = nativePtr;
            /*1108*/
        }
        /*1109*/
        public void Release()
        {
            /*1110*/
            JsValue ret;
            /*1111*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntryVisitor_Release_0, out ret);
            /*1112*/
        }
        /*1113*/
    }


    // [virtual] class CefBrowserHost
    /// <summary>
    /// Class used to represent the browser process aspects of a browser window. The
    /// methods of this class can only be called in the browser process. They may be
    /// called on any thread in that process unless otherwise indicated in the
    /// comments.
    /// /*(source=library)*/
    /// </summary>
    /*1382*/
    public struct CefBrowserHost
    {
        /*1383*/
        const int _typeNAME = 4;
        /*1384*/
        const int CefBrowserHost_Release_0 = (_typeNAME << 16) | 0;
        /*1385*/
        const int CefBrowserHost_GetBrowser_1 = (_typeNAME << 16) | 1;
        /*1386*/
        const int CefBrowserHost_CloseBrowser_2 = (_typeNAME << 16) | 2;
        /*1387*/
        const int CefBrowserHost_TryCloseBrowser_3 = (_typeNAME << 16) | 3;
        /*1388*/
        const int CefBrowserHost_SetFocus_4 = (_typeNAME << 16) | 4;
        /*1389*/
        const int CefBrowserHost_GetWindowHandle_5 = (_typeNAME << 16) | 5;
        /*1390*/
        const int CefBrowserHost_GetOpenerWindowHandle_6 = (_typeNAME << 16) | 6;
        /*1391*/
        const int CefBrowserHost_HasView_7 = (_typeNAME << 16) | 7;
        /*1392*/
        const int CefBrowserHost_GetClient_8 = (_typeNAME << 16) | 8;
        /*1393*/
        const int CefBrowserHost_GetRequestContext_9 = (_typeNAME << 16) | 9;
        /*1394*/
        const int CefBrowserHost_GetZoomLevel_10 = (_typeNAME << 16) | 10;
        /*1395*/
        const int CefBrowserHost_SetZoomLevel_11 = (_typeNAME << 16) | 11;
        /*1396*/
        const int CefBrowserHost_RunFileDialog_12 = (_typeNAME << 16) | 12;
        /*1397*/
        const int CefBrowserHost_StartDownload_13 = (_typeNAME << 16) | 13;
        /*1398*/
        const int CefBrowserHost_DownloadImage_14 = (_typeNAME << 16) | 14;
        /*1399*/
        const int CefBrowserHost_Print_15 = (_typeNAME << 16) | 15;
        /*1400*/
        const int CefBrowserHost_PrintToPDF_16 = (_typeNAME << 16) | 16;
        /*1401*/
        const int CefBrowserHost_Find_17 = (_typeNAME << 16) | 17;
        /*1402*/
        const int CefBrowserHost_StopFinding_18 = (_typeNAME << 16) | 18;
        /*1403*/
        const int CefBrowserHost_ShowDevTools_19 = (_typeNAME << 16) | 19;
        /*1404*/
        const int CefBrowserHost_CloseDevTools_20 = (_typeNAME << 16) | 20;
        /*1405*/
        const int CefBrowserHost_HasDevTools_21 = (_typeNAME << 16) | 21;
        /*1406*/
        const int CefBrowserHost_GetNavigationEntries_22 = (_typeNAME << 16) | 22;
        /*1407*/
        const int CefBrowserHost_SetMouseCursorChangeDisabled_23 = (_typeNAME << 16) | 23;
        /*1408*/
        const int CefBrowserHost_IsMouseCursorChangeDisabled_24 = (_typeNAME << 16) | 24;
        /*1409*/
        const int CefBrowserHost_ReplaceMisspelling_25 = (_typeNAME << 16) | 25;
        /*1410*/
        const int CefBrowserHost_AddWordToDictionary_26 = (_typeNAME << 16) | 26;
        /*1411*/
        const int CefBrowserHost_IsWindowRenderingDisabled_27 = (_typeNAME << 16) | 27;
        /*1412*/
        const int CefBrowserHost_WasResized_28 = (_typeNAME << 16) | 28;
        /*1413*/
        const int CefBrowserHost_WasHidden_29 = (_typeNAME << 16) | 29;
        /*1414*/
        const int CefBrowserHost_NotifyScreenInfoChanged_30 = (_typeNAME << 16) | 30;
        /*1415*/
        const int CefBrowserHost_Invalidate_31 = (_typeNAME << 16) | 31;
        /*1416*/
        const int CefBrowserHost_SendKeyEvent_32 = (_typeNAME << 16) | 32;
        /*1417*/
        const int CefBrowserHost_SendMouseClickEvent_33 = (_typeNAME << 16) | 33;
        /*1418*/
        const int CefBrowserHost_SendMouseMoveEvent_34 = (_typeNAME << 16) | 34;
        /*1419*/
        const int CefBrowserHost_SendMouseWheelEvent_35 = (_typeNAME << 16) | 35;
        /*1420*/
        const int CefBrowserHost_SendFocusEvent_36 = (_typeNAME << 16) | 36;
        /*1421*/
        const int CefBrowserHost_SendCaptureLostEvent_37 = (_typeNAME << 16) | 37;
        /*1422*/
        const int CefBrowserHost_NotifyMoveOrResizeStarted_38 = (_typeNAME << 16) | 38;
        /*1423*/
        const int CefBrowserHost_GetWindowlessFrameRate_39 = (_typeNAME << 16) | 39;
        /*1424*/
        const int CefBrowserHost_SetWindowlessFrameRate_40 = (_typeNAME << 16) | 40;
        /*1425*/
        const int CefBrowserHost_ImeSetComposition_41 = (_typeNAME << 16) | 41;
        /*1426*/
        const int CefBrowserHost_ImeCommitText_42 = (_typeNAME << 16) | 42;
        /*1427*/
        const int CefBrowserHost_ImeFinishComposingText_43 = (_typeNAME << 16) | 43;
        /*1428*/
        const int CefBrowserHost_ImeCancelComposition_44 = (_typeNAME << 16) | 44;
        /*1429*/
        const int CefBrowserHost_DragTargetDragEnter_45 = (_typeNAME << 16) | 45;
        /*1430*/
        const int CefBrowserHost_DragTargetDragOver_46 = (_typeNAME << 16) | 46;
        /*1431*/
        const int CefBrowserHost_DragTargetDragLeave_47 = (_typeNAME << 16) | 47;
        /*1432*/
        const int CefBrowserHost_DragTargetDrop_48 = (_typeNAME << 16) | 48;
        /*1433*/
        const int CefBrowserHost_DragSourceEndedAt_49 = (_typeNAME << 16) | 49;
        /*1434*/
        const int CefBrowserHost_DragSourceSystemDragEnded_50 = (_typeNAME << 16) | 50;
        /*1435*/
        const int CefBrowserHost_GetVisibleNavigationEntry_51 = (_typeNAME << 16) | 51;
        /*1436*/
        const int CefBrowserHost_SetAccessibilityState_52 = (_typeNAME << 16) | 52;
        /*1437*/
        internal readonly IntPtr nativePtr;
        /*1438*/
        internal CefBrowserHost(IntPtr nativePtr)
        {
            /*1439*/
            this.nativePtr = nativePtr;
            /*1440*/
        }
        /*1441*/
        public void Release()
        {
            /*1442*/
            JsValue ret;
            /*1443*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_Release_0, out ret);
            /*1444*/
        }
        /// <summary>
        /// CefBrowserHost methods.
        /// </summary>
        /*1445*/


        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /*1446*/

        public CefBrowser GetBrowser()/*1447*/
        {
            JsValue ret;
            /*1448*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetBrowser_1, out ret);
            /*1449*/
            var ret_result = new CefBrowser(ret.Ptr);
            /*1450*/
            return ret_result;
            /*1451*/
        }
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
        /*1452*/


        // gen! void CloseBrowser(bool force_close)
        /*1453*/

        public void CloseBrowser(bool /*1454*/
        force_close
        )/*1455*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1456*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_CloseBrowser_2, out ret, ref v1);
            /*1457*/

            /*1458*/
        }
        /// <summary>
        /// Helper for closing a browser. Call this method from the top-level window
        /// close handler. Internally this calls CloseBrowser(false) if the close has
        /// not yet been initiated. This method returns false while the close is
        /// pending and true after the close has completed. See CloseBrowser() and
        /// CefLifeSpanHandler::DoClose() documentation for additional usage
        /// information. This method must be called on the browser process UI thread.
        /// /*cef()*/
        /// </summary>
        /*1459*/


        // gen! bool TryCloseBrowser()
        /*1460*/

        public bool TryCloseBrowser()/*1461*/
        {
            JsValue ret;
            /*1462*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_TryCloseBrowser_3, out ret);
            /*1463*/
            var ret_result = ret.I32 != 0;
            /*1464*/
            return ret_result;
            /*1465*/
        }
        /// <summary>
        /// Set whether the browser is focused.
        /// /*cef()*/
        /// </summary>
        /*1466*/


        // gen! void SetFocus(bool focus)
        /*1467*/

        public void SetFocus(bool /*1468*/
        focus
        )/*1469*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1470*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetFocus_4, out ret, ref v1);
            /*1471*/

            /*1472*/
        }
        /// <summary>
        /// Retrieve the window handle for this browser. If this browser is wrapped in
        /// a CefBrowserView this method should be called on the browser process UI
        /// thread and it will return the handle for the top-level native window.
        /// /*cef()*/
        /// </summary>
        /*1473*/


        // gen! CefWindowHandle GetWindowHandle()
        /*1474*/

        public IntPtr GetWindowHandle()/*1475*/
        {
            JsValue ret;
            /*1476*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetWindowHandle_5, out ret);
            /*1477*/
            IntPtr ret_result = ret.Ptr;
            /*1478*/
            return ret_result;
            /*1479*/
        }
        /// <summary>
        /// Retrieve the window handle of the browser that opened this browser. Will
        /// return NULL for non-popup windows or if this browser is wrapped in a
        /// CefBrowserView. This method can be used in combination with custom handling
        /// of modal windows.
        /// /*cef()*/
        /// </summary>
        /*1480*/


        // gen! CefWindowHandle GetOpenerWindowHandle()
        /*1481*/

        public IntPtr GetOpenerWindowHandle()/*1482*/
        {
            JsValue ret;
            /*1483*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetOpenerWindowHandle_6, out ret);
            /*1484*/
            IntPtr ret_result = ret.Ptr;
            /*1485*/
            return ret_result;
            /*1486*/
        }
        /// <summary>
        /// Returns true if this browser is wrapped in a CefBrowserView.
        /// /*cef()*/
        /// </summary>
        /*1487*/


        // gen! bool HasView()
        /*1488*/

        public bool HasView()/*1489*/
        {
            JsValue ret;
            /*1490*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_HasView_7, out ret);
            /*1491*/
            var ret_result = ret.I32 != 0;
            /*1492*/
            return ret_result;
            /*1493*/
        }
        /// <summary>
        /// Returns the client for this browser.
        /// /*cef()*/
        /// </summary>
        /*1494*/


        // gen! CefRefPtr<CefClient> GetClient()
        /*1495*/

        public CefClient GetClient()/*1496*/
        {
            JsValue ret;
            /*1497*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetClient_8, out ret);
            /*1498*/
            var ret_result = new CefClient(ret.Ptr);
            /*1499*/
            return ret_result;
            /*1500*/
        }
        /// <summary>
        /// Returns the request context for this browser.
        /// /*cef()*/
        /// </summary>
        /*1501*/


        // gen! CefRefPtr<CefRequestContext> GetRequestContext()
        /*1502*/

        public CefRequestContext GetRequestContext()/*1503*/
        {
            JsValue ret;
            /*1504*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetRequestContext_9, out ret);
            /*1505*/
            var ret_result = new CefRequestContext(ret.Ptr);
            /*1506*/
            return ret_result;
            /*1507*/
        }
        /// <summary>
        /// Get the current zoom level. The default zoom level is 0.0. This method can
        /// only be called on the UI thread.
        /// /*cef()*/
        /// </summary>
        /*1508*/


        // gen! double GetZoomLevel()
        /*1509*/

        public double GetZoomLevel()/*1510*/
        {
            JsValue ret;
            /*1511*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetZoomLevel_10, out ret);
            /*1512*/
            var ret_result = ret.Num;
            /*1513*/
            return ret_result;
            /*1514*/
        }
        /// <summary>
        /// Change the zoom level to the specified value. Specify 0.0 to reset the
        /// zoom level. If called on the UI thread the change will be applied
        /// immediately. Otherwise, the change will be applied asynchronously on the
        /// UI thread.
        /// /*cef()*/
        /// </summary>
        /*1515*/


        // gen! void SetZoomLevel(double zoomLevel)
        /*1516*/

        public void SetZoomLevel(double /*1517*/
        zoomLevel
        )/*1518*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1519*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetZoomLevel_11, out ret, ref v1);
            /*1520*/

            /*1521*/
        }
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
        /*1522*/


        // gen! void RunFileDialog(FileDialogMode mode,const CefString& title,const CefString& default_file_path,const std::vector<CefString>& accept_filters,int selected_accept_filter,CefRefPtr<CefRunFileDialogCallback> callback)
        /*1523*/

        public void RunFileDialog(cef_file_dialog_mode_t /*1524*/
        mode
        , string /*1525*/
        title
        , string /*1526*/
        default_file_path
        , List<string> /*1527*/
        accept_filters
        , int /*1528*/
        selected_accept_filter
        , CefRunFileDialogCallback /*1529*/
        callback
        )/*1530*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue v6 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(title);
            /*1531*/
            ;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(default_file_path);
            /*1532*/
            ;
            /*1533*/

            Cef3Binder.MyCefMet_Call6(this.nativePtr, CefBrowserHost_RunFileDialog_12, out ret, ref v1, ref v2, ref v3, ref v4, ref v5, ref v6);
            /*1534*/

            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*1535*/
            ;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*1536*/
            ;
            /*1537*/
        }
        /// <summary>
        /// Download the file at |url| using CefDownloadHandler.
        /// /*cef()*/
        /// </summary>
        /*1538*/


        // gen! void StartDownload(const CefString& url)
        /*1539*/

        public void StartDownload(string /*1540*/
        url
        )/*1541*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*1542*/
            ;
            /*1543*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_StartDownload_13, out ret, ref v1);
            /*1544*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1545*/
            ;
            /*1546*/
        }
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
        /*1547*/


        // gen! void DownloadImage(const CefString& image_url,bool is_favicon,uint32 max_image_size,bool bypass_cache,CefRefPtr<CefDownloadImageCallback> callback)
        /*1548*/

        public void DownloadImage(string /*1549*/
        image_url
        , bool /*1550*/
        is_favicon
        , uint /*1551*/
        max_image_size
        , bool /*1552*/
        bypass_cache
        , CefDownloadImageCallback /*1553*/
        callback
        )/*1554*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(image_url);
            /*1555*/
            ;
            /*1556*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefBrowserHost_DownloadImage_14, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*1557*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1558*/
            ;
            /*1559*/
        }
        /// <summary>
        /// Print the current browser contents.
        /// /*cef()*/
        /// </summary>
        /*1560*/


        // gen! void Print()
        /*1561*/

        public void Print()/*1562*/
        {
            JsValue ret;
            /*1563*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_Print_15, out ret);
            /*1564*/

            /*1565*/
        }
        /// <summary>
        /// Print the current browser contents to the PDF file specified by |path| and
        /// execute |callback| on completion. The caller is responsible for deleting
        /// |path| when done. For PDF printing to work on Linux you must implement the
        /// CefPrintHandler::GetPdfPaperSize method.
        /// /*cef(optional_param=callback)*/
        /// </summary>
        /*1566*/


        // gen! void PrintToPDF(const CefString& path,const CefPdfPrintSettings& settings,CefRefPtr<CefPdfPrintCallback> callback)
        /*1567*/

        public void PrintToPDF(string /*1568*/
        path
        , CefPdfPrintSettings /*1569*/
        settings
        , CefPdfPrintCallback /*1570*/
        callback
        )/*1571*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(path);
            /*1572*/
            ;
            /*1573*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_PrintToPDF_16, out ret, ref v1, ref v2, ref v3);
            /*1574*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1575*/
            ;
            /*1576*/
        }
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
        /*1577*/


        // gen! void Find(int identifier,const CefString& searchText,bool forward,bool matchCase,bool findNext)
        /*1578*/

        public void Find(int /*1579*/
        identifier
        , string /*1580*/
        searchText
        , bool /*1581*/
        forward
        , bool /*1582*/
        matchCase
        , bool /*1583*/
        findNext
        )/*1584*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(searchText);
            /*1585*/
            ;
            /*1586*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefBrowserHost_Find_17, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*1587*/

            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*1588*/
            ;
            /*1589*/
        }
        /// <summary>
        /// Cancel all searches that are currently going on.
        /// /*cef()*/
        /// </summary>
        /*1590*/


        // gen! void StopFinding(bool clearSelection)
        /*1591*/

        public void StopFinding(bool /*1592*/
        clearSelection
        )/*1593*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1594*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_StopFinding_18, out ret, ref v1);
            /*1595*/

            /*1596*/
        }
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
        /*1597*/


        // gen! void ShowDevTools(const CefWindowInfo& windowInfo,CefRefPtr<CefClient> client,const CefBrowserSettings& settings,const CefPoint& inspect_element_at)
        /*1598*/

        public void ShowDevTools(CefWindowInfo /*1599*/
        windowInfo
        , CefClient /*1600*/
        client
        , CefBrowserSettings /*1601*/
        settings
        , CefPoint /*1602*/
        inspect_element_at
        )/*1603*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            /*1604*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_ShowDevTools_19, out ret, ref v1, ref v2, ref v3, ref v4);
            /*1605*/

            /*1606*/
        }
        /// <summary>
        /// Explicitly close the associated DevTools browser, if any.
        /// /*cef()*/
        /// </summary>
        /*1607*/


        // gen! void CloseDevTools()
        /*1608*/

        public void CloseDevTools()/*1609*/
        {
            JsValue ret;
            /*1610*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_CloseDevTools_20, out ret);
            /*1611*/

            /*1612*/
        }
        /// <summary>
        /// Returns true if this browser currently has an associated DevTools browser.
        /// Must be called on the browser process UI thread.
        /// /*cef()*/
        /// </summary>
        /*1613*/


        // gen! bool HasDevTools()
        /*1614*/

        public bool HasDevTools()/*1615*/
        {
            JsValue ret;
            /*1616*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_HasDevTools_21, out ret);
            /*1617*/
            var ret_result = ret.I32 != 0;
            /*1618*/
            return ret_result;
            /*1619*/
        }
        /// <summary>
        /// Retrieve a snapshot of current navigation entries as values sent to the
        /// specified visitor. If |current_only| is true only the current navigation
        /// entry will be sent, otherwise all navigation entries will be sent.
        /// /*cef()*/
        /// </summary>
        /*1620*/


        // gen! void GetNavigationEntries(CefRefPtr<CefNavigationEntryVisitor> visitor,bool current_only)
        /*1621*/

        public void GetNavigationEntries(CefNavigationEntryVisitor /*1622*/
        visitor
        , bool /*1623*/
        current_only
        )/*1624*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*1625*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_GetNavigationEntries_22, out ret, ref v1, ref v2);
            /*1626*/

            /*1627*/
        }
        /// <summary>
        /// Set whether mouse cursor change is disabled.
        /// /*cef()*/
        /// </summary>
        /*1628*/


        // gen! void SetMouseCursorChangeDisabled(bool disabled)
        /*1629*/

        public void SetMouseCursorChangeDisabled(bool /*1630*/
        disabled
        )/*1631*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1632*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetMouseCursorChangeDisabled_23, out ret, ref v1);
            /*1633*/

            /*1634*/
        }
        /// <summary>
        /// Returns true if mouse cursor change is disabled.
        /// /*cef()*/
        /// </summary>
        /*1635*/


        // gen! bool IsMouseCursorChangeDisabled()
        /*1636*/

        public bool IsMouseCursorChangeDisabled()/*1637*/
        {
            JsValue ret;
            /*1638*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_IsMouseCursorChangeDisabled_24, out ret);
            /*1639*/
            var ret_result = ret.I32 != 0;
            /*1640*/
            return ret_result;
            /*1641*/
        }
        /// <summary>
        /// If a misspelled word is currently selected in an editable node calling
        /// this method will replace it with the specified |word|.
        /// /*cef()*/
        /// </summary>
        /*1642*/


        // gen! void ReplaceMisspelling(const CefString& word)
        /*1643*/

        public void ReplaceMisspelling(string /*1644*/
        word
        )/*1645*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(word);
            /*1646*/
            ;
            /*1647*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_ReplaceMisspelling_25, out ret, ref v1);
            /*1648*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1649*/
            ;
            /*1650*/
        }
        /// <summary>
        /// Add the specified |word| to the spelling dictionary.
        /// /*cef()*/
        /// </summary>
        /*1651*/


        // gen! void AddWordToDictionary(const CefString& word)
        /*1652*/

        public void AddWordToDictionary(string /*1653*/
        word
        )/*1654*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(word);
            /*1655*/
            ;
            /*1656*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_AddWordToDictionary_26, out ret, ref v1);
            /*1657*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1658*/
            ;
            /*1659*/
        }
        /// <summary>
        /// Returns true if window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1660*/


        // gen! bool IsWindowRenderingDisabled()
        /*1661*/

        public bool IsWindowRenderingDisabled()/*1662*/
        {
            JsValue ret;
            /*1663*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_IsWindowRenderingDisabled_27, out ret);
            /*1664*/
            var ret_result = ret.I32 != 0;
            /*1665*/
            return ret_result;
            /*1666*/
        }
        /// <summary>
        /// Notify the browser that the widget has been resized. The browser will first
        /// call CefRenderHandler::GetViewRect to get the new size and then call
        /// CefRenderHandler::OnPaint asynchronously with the updated regions. This
        /// method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1667*/


        // gen! void WasResized()
        /*1668*/

        public void WasResized()/*1669*/
        {
            JsValue ret;
            /*1670*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_WasResized_28, out ret);
            /*1671*/

            /*1672*/
        }
        /// <summary>
        /// Notify the browser that it has been hidden or shown. Layouting and
        /// CefRenderHandler::OnPaint notification will stop when the browser is
        /// hidden. This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1673*/


        // gen! void WasHidden(bool hidden)
        /*1674*/

        public void WasHidden(bool /*1675*/
        hidden
        )/*1676*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1677*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_WasHidden_29, out ret, ref v1);
            /*1678*/

            /*1679*/
        }
        /// <summary>
        /// Send a notification to the browser that the screen info has changed. The
        /// browser will then call CefRenderHandler::GetScreenInfo to update the
        /// screen information with the new values. This simulates moving the webview
        /// window from one display to another, or changing the properties of the
        /// current display. This method is only used when window rendering is
        /// disabled.
        /// /*cef()*/
        /// </summary>
        /*1680*/


        // gen! void NotifyScreenInfoChanged()
        /*1681*/

        public void NotifyScreenInfoChanged()/*1682*/
        {
            JsValue ret;
            /*1683*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_NotifyScreenInfoChanged_30, out ret);
            /*1684*/

            /*1685*/
        }
        /// <summary>
        /// Invalidate the view. The browser will call CefRenderHandler::OnPaint
        /// asynchronously. This method is only used when window rendering is
        /// disabled.
        /// /*cef()*/
        /// </summary>
        /*1686*/


        // gen! void Invalidate(PaintElementType type)
        /*1687*/

        public void Invalidate(cef_paint_element_type_t /*1688*/
        type
        )/*1689*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1690*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_Invalidate_31, out ret, ref v1);
            /*1691*/

            /*1692*/
        }
        /// <summary>
        /// Send a key event to the browser.
        /// /*cef()*/
        /// </summary>
        /*1693*/


        // gen! void SendKeyEvent(const CefKeyEvent& event)
        /*1694*/

        public void SendKeyEvent(CefKeyEvent /*1695*/
        _event
        )/*1696*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1697*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SendKeyEvent_32, out ret, ref v1);
            /*1698*/

            /*1699*/
        }
        /// <summary>
        /// Send a mouse click event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view.
        /// /*cef()*/
        /// </summary>
        /*1700*/


        // gen! void SendMouseClickEvent(const CefMouseEvent& event,MouseButtonType type,bool mouseUp,int clickCount)
        /*1701*/

        public void SendMouseClickEvent(CefMouseEvent /*1702*/
        _event
        , cef_mouse_button_type_t /*1703*/
        type
        , bool /*1704*/
        mouseUp
        , int /*1705*/
        clickCount
        )/*1706*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            /*1707*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_SendMouseClickEvent_33, out ret, ref v1, ref v2, ref v3, ref v4);
            /*1708*/

            /*1709*/
        }
        /// <summary>
        /// Send a mouse move event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view.
        /// /*cef()*/
        /// </summary>
        /*1710*/


        // gen! void SendMouseMoveEvent(const CefMouseEvent& event,bool mouseLeave)
        /*1711*/

        public void SendMouseMoveEvent(CefMouseEvent /*1712*/
        _event
        , bool /*1713*/
        mouseLeave
        )/*1714*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*1715*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_SendMouseMoveEvent_34, out ret, ref v1, ref v2);
            /*1716*/

            /*1717*/
        }
        /// <summary>
        /// Send a mouse wheel event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view. The |deltaX| and |deltaY|
        /// values represent the movement delta in the X and Y directions respectively.
        /// In order to scroll inside select popups with window rendering disabled
        /// CefRenderHandler::GetScreenPoint should be implemented properly.
        /// /*cef()*/
        /// </summary>
        /*1718*/


        // gen! void SendMouseWheelEvent(const CefMouseEvent& event,int deltaX,int deltaY)
        /*1719*/

        public void SendMouseWheelEvent(CefMouseEvent /*1720*/
        _event
        , int /*1721*/
        deltaX
        , int /*1722*/
        deltaY
        )/*1723*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*1724*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_SendMouseWheelEvent_35, out ret, ref v1, ref v2, ref v3);
            /*1725*/

            /*1726*/
        }
        /// <summary>
        /// Send a focus event to the browser.
        /// /*cef()*/
        /// </summary>
        /*1727*/


        // gen! void SendFocusEvent(bool setFocus)
        /*1728*/

        public void SendFocusEvent(bool /*1729*/
        setFocus
        )/*1730*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1731*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SendFocusEvent_36, out ret, ref v1);
            /*1732*/

            /*1733*/
        }
        /// <summary>
        /// Send a capture lost event to the browser.
        /// /*cef()*/
        /// </summary>
        /*1734*/


        // gen! void SendCaptureLostEvent()
        /*1735*/

        public void SendCaptureLostEvent()/*1736*/
        {
            JsValue ret;
            /*1737*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_SendCaptureLostEvent_37, out ret);
            /*1738*/

            /*1739*/
        }
        /// <summary>
        /// Notify the browser that the window hosting it is about to be moved or
        /// resized. This method is only used on Windows and Linux.
        /// /*cef()*/
        /// </summary>
        /*1740*/


        // gen! void NotifyMoveOrResizeStarted()
        /*1741*/

        public void NotifyMoveOrResizeStarted()/*1742*/
        {
            JsValue ret;
            /*1743*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_NotifyMoveOrResizeStarted_38, out ret);
            /*1744*/

            /*1745*/
        }
        /// <summary>
        /// Returns the maximum rate in frames per second (fps) that CefRenderHandler::
        /// OnPaint will be called for a windowless browser. The actual fps may be
        /// lower if the browser cannot generate frames at the requested rate. The
        /// minimum value is 1 and the maximum value is 60 (default 30). This method
        /// can only be called on the UI thread.
        /// /*cef()*/
        /// </summary>
        /*1746*/


        // gen! int GetWindowlessFrameRate()
        /*1747*/

        public int GetWindowlessFrameRate()/*1748*/
        {
            JsValue ret;
            /*1749*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetWindowlessFrameRate_39, out ret);
            /*1750*/
            var ret_result = ret.I32;
            /*1751*/
            return ret_result;
            /*1752*/
        }
        /// <summary>
        /// Set the maximum rate in frames per second (fps) that CefRenderHandler::
        /// OnPaint will be called for a windowless browser. The actual fps may be
        /// lower if the browser cannot generate frames at the requested rate. The
        /// minimum value is 1 and the maximum value is 60 (default 30). Can also be
        /// set at browser creation via CefBrowserSettings.windowless_frame_rate.
        /// /*cef()*/
        /// </summary>
        /*1753*/


        // gen! void SetWindowlessFrameRate(int frame_rate)
        /*1754*/

        public void SetWindowlessFrameRate(int /*1755*/
        frame_rate
        )/*1756*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1757*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetWindowlessFrameRate_40, out ret, ref v1);
            /*1758*/

            /*1759*/
        }
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
        /*1760*/


        // gen! void ImeSetComposition(const CefString& text,const std::vector<CefCompositionUnderline>& underlines,const CefRange& replacement_range,const CefRange& selection_range)
        /*1761*/

        public void ImeSetComposition(string /*1762*/
        text
        , List<CefCompositionUnderline> /*1763*/
        underlines
        , CefRange /*1764*/
        replacement_range
        , CefRange /*1765*/
        selection_range
        )/*1766*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(text);
            /*1767*/
            ;
            /*1768*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_ImeSetComposition_41, out ret, ref v1, ref v2, ref v3, ref v4);
            /*1769*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1770*/
            ;
            /*1771*/
        }
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
        /*1772*/


        // gen! void ImeCommitText(const CefString& text,const CefRange& replacement_range,int relative_cursor_pos)
        /*1773*/

        public void ImeCommitText(string /*1774*/
        text
        , CefRange /*1775*/
        replacement_range
        , int /*1776*/
        relative_cursor_pos
        )/*1777*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(text);
            /*1778*/
            ;
            /*1779*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_ImeCommitText_42, out ret, ref v1, ref v2, ref v3);
            /*1780*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1781*/
            ;
            /*1782*/
        }
        /// <summary>
        /// Completes the existing composition by applying the current composition node
        /// contents. If |keep_selection| is false the current selection, if any, will
        /// be discarded. See comments on ImeSetComposition for usage.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1783*/


        // gen! void ImeFinishComposingText(bool keep_selection)
        /*1784*/

        public void ImeFinishComposingText(bool /*1785*/
        keep_selection
        )/*1786*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1787*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_ImeFinishComposingText_43, out ret, ref v1);
            /*1788*/

            /*1789*/
        }
        /// <summary>
        /// Cancels the existing composition and discards the composition node
        /// contents without applying them. See comments on ImeSetComposition for
        /// usage.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1790*/


        // gen! void ImeCancelComposition()
        /*1791*/

        public void ImeCancelComposition()/*1792*/
        {
            JsValue ret;
            /*1793*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_ImeCancelComposition_44, out ret);
            /*1794*/

            /*1795*/
        }
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
        /*1796*/


        // gen! void DragTargetDragEnter(CefRefPtr<CefDragData> drag_data,const CefMouseEvent& event,DragOperationsMask allowed_ops)
        /*1797*/

        public void DragTargetDragEnter(CefDragData /*1798*/
        drag_data
        , CefMouseEvent /*1799*/
        _event
        , cef_drag_operations_mask_t /*1800*/
        allowed_ops
        )/*1801*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*1802*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_DragTargetDragEnter_45, out ret, ref v1, ref v2, ref v3);
            /*1803*/

            /*1804*/
        }
        /// <summary>
        /// Call this method each time the mouse is moved across the web view during
        /// a drag operation (after calling DragTargetDragEnter and before calling
        /// DragTargetDragLeave/DragTargetDrop).
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1805*/


        // gen! void DragTargetDragOver(const CefMouseEvent& event,DragOperationsMask allowed_ops)
        /*1806*/

        public void DragTargetDragOver(CefMouseEvent /*1807*/
        _event
        , cef_drag_operations_mask_t /*1808*/
        allowed_ops
        )/*1809*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*1810*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_DragTargetDragOver_46, out ret, ref v1, ref v2);
            /*1811*/

            /*1812*/
        }
        /// <summary>
        /// Call this method when the user drags the mouse out of the web view (after
        /// calling DragTargetDragEnter).
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1813*/


        // gen! void DragTargetDragLeave()
        /*1814*/

        public void DragTargetDragLeave()/*1815*/
        {
            JsValue ret;
            /*1816*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_DragTargetDragLeave_47, out ret);
            /*1817*/

            /*1818*/
        }
        /// <summary>
        /// Call this method when the user completes the drag operation by dropping
        /// the object onto the web view (after calling DragTargetDragEnter).
        /// The object being dropped is |drag_data|, given as an argument to
        /// the previous DragTargetDragEnter call.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1819*/


        // gen! void DragTargetDrop(const CefMouseEvent& event)
        /*1820*/

        public void DragTargetDrop(CefMouseEvent /*1821*/
        _event
        )/*1822*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1823*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_DragTargetDrop_48, out ret, ref v1);
            /*1824*/

            /*1825*/
        }
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
        /*1826*/


        // gen! void DragSourceEndedAt(int x,int y,DragOperationsMask op)
        /*1827*/

        public void DragSourceEndedAt(int /*1828*/
        x
        , int /*1829*/
        y
        , cef_drag_operations_mask_t /*1830*/
        op
        )/*1831*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*1832*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_DragSourceEndedAt_49, out ret, ref v1, ref v2, ref v3);
            /*1833*/

            /*1834*/
        }
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
        /*1835*/


        // gen! void DragSourceSystemDragEnded()
        /*1836*/

        public void DragSourceSystemDragEnded()/*1837*/
        {
            JsValue ret;
            /*1838*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_DragSourceSystemDragEnded_50, out ret);
            /*1839*/

            /*1840*/
        }
        /// <summary>
        /// Returns the current visible navigation entry for this browser. This method
        /// can only be called on the UI thread.
        /// /*cef()*/
        /// </summary>
        /*1841*/


        // gen! CefRefPtr<CefNavigationEntry> GetVisibleNavigationEntry()
        /*1842*/

        public CefNavigationEntry GetVisibleNavigationEntry()/*1843*/
        {
            JsValue ret;
            /*1844*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetVisibleNavigationEntry_51, out ret);
            /*1845*/
            var ret_result = new CefNavigationEntry(ret.Ptr);
            /*1846*/
            return ret_result;
            /*1847*/
        }
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
        /*1848*/


        // gen! void SetAccessibilityState(cef_state_t accessibility_state)
        /*1849*/

        public void SetAccessibilityState(cef_state_t /*1850*/
        accessibility_state
        )/*1851*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*1852*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetAccessibilityState_52, out ret, ref v1);
            /*1853*/

            /*1854*/
        }
        /*1855*/
    }


    // [virtual] class CefClient
    /// <summary>
    /// Implement this interface to provide handler implementations.
    /// /*(source=client,no_debugct_check)*/
    /// </summary>
    /*1864*/
    public struct CefClient
    {
        /*1865*/
        const int _typeNAME = 5;
        /*1866*/
        const int CefClient_Release_0 = (_typeNAME << 16) | 0;
        /*1867*/
        internal readonly IntPtr nativePtr;
        /*1868*/
        internal CefClient(IntPtr nativePtr)
        {
            /*1869*/
            this.nativePtr = nativePtr;
            /*1870*/
        }
        /*1871*/
        public void Release()
        {
            /*1872*/
            JsValue ret;
            /*1873*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefClient_Release_0, out ret);
            /*1874*/
        }
        /*1875*/
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
    /*1984*/
    public struct CefCommandLine
    {
        /*1985*/
        const int _typeNAME = 6;
        /*1986*/
        const int CefCommandLine_Release_0 = (_typeNAME << 16) | 0;
        /*1987*/
        const int CefCommandLine_IsValid_1 = (_typeNAME << 16) | 1;
        /*1988*/
        const int CefCommandLine_IsReadOnly_2 = (_typeNAME << 16) | 2;
        /*1989*/
        const int CefCommandLine_Copy_3 = (_typeNAME << 16) | 3;
        /*1990*/
        const int CefCommandLine_InitFromArgv_4 = (_typeNAME << 16) | 4;
        /*1991*/
        const int CefCommandLine_InitFromString_5 = (_typeNAME << 16) | 5;
        /*1992*/
        const int CefCommandLine_Reset_6 = (_typeNAME << 16) | 6;
        /*1993*/
        const int CefCommandLine_GetArgv_7 = (_typeNAME << 16) | 7;
        /*1994*/
        const int CefCommandLine_GetCommandLineString_8 = (_typeNAME << 16) | 8;
        /*1995*/
        const int CefCommandLine_GetProgram_9 = (_typeNAME << 16) | 9;
        /*1996*/
        const int CefCommandLine_SetProgram_10 = (_typeNAME << 16) | 10;
        /*1997*/
        const int CefCommandLine_HasSwitches_11 = (_typeNAME << 16) | 11;
        /*1998*/
        const int CefCommandLine_HasSwitch_12 = (_typeNAME << 16) | 12;
        /*1999*/
        const int CefCommandLine_GetSwitchValue_13 = (_typeNAME << 16) | 13;
        /*2000*/
        const int CefCommandLine_GetSwitches_14 = (_typeNAME << 16) | 14;
        /*2001*/
        const int CefCommandLine_AppendSwitch_15 = (_typeNAME << 16) | 15;
        /*2002*/
        const int CefCommandLine_AppendSwitchWithValue_16 = (_typeNAME << 16) | 16;
        /*2003*/
        const int CefCommandLine_HasArguments_17 = (_typeNAME << 16) | 17;
        /*2004*/
        const int CefCommandLine_GetArguments_18 = (_typeNAME << 16) | 18;
        /*2005*/
        const int CefCommandLine_AppendArgument_19 = (_typeNAME << 16) | 19;
        /*2006*/
        const int CefCommandLine_PrependWrapper_20 = (_typeNAME << 16) | 20;
        /*2007*/
        internal readonly IntPtr nativePtr;
        /*2008*/
        internal CefCommandLine(IntPtr nativePtr)
        {
            /*2009*/
            this.nativePtr = nativePtr;
            /*2010*/
        }
        /*2011*/
        public void Release()
        {
            /*2012*/
            JsValue ret;
            /*2013*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Release_0, out ret);
            /*2014*/
        }
        /// <summary>
        /// CefCommandLine methods.
        /// </summary>
        /*2015*/


        // gen! bool IsValid()
        /*2016*/

        public bool IsValid()/*2017*/
        {
            JsValue ret;
            /*2018*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_IsValid_1, out ret);
            /*2019*/
            var ret_result = ret.I32 != 0;
            /*2020*/
            return ret_result;
            /*2021*/
        }
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*2022*/


        // gen! bool IsReadOnly()
        /*2023*/

        public bool IsReadOnly()/*2024*/
        {
            JsValue ret;
            /*2025*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_IsReadOnly_2, out ret);
            /*2026*/
            var ret_result = ret.I32 != 0;
            /*2027*/
            return ret_result;
            /*2028*/
        }
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>
        /*2029*/


        // gen! CefRefPtr<CefCommandLine> Copy()
        /*2030*/

        public CefCommandLine Copy()/*2031*/
        {
            JsValue ret;
            /*2032*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Copy_3, out ret);
            /*2033*/
            var ret_result = new CefCommandLine(ret.Ptr);
            /*2034*/
            return ret_result;
            /*2035*/
        }
        /// <summary>
        /// Initialize the command line with the specified |argc| and |argv| values.
        /// The first argument must be the name of the program. This method is only
        /// supported on non-Windows platforms.
        /// /*cef()*/
        /// </summary>
        /*2036*/


        // gen! void InitFromArgv(int argc,const char* const* argv)
        /*2037*/

        public void InitFromArgv(int /*2038*/
        argc
        , IntPtr /*2039*/
        argv
        )/*2040*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*2041*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCommandLine_InitFromArgv_4, out ret, ref v1, ref v2);
            /*2042*/

            /*2043*/
        }
        /// <summary>
        /// Initialize the command line with the string returned by calling
        /// GetCommandLineW(). This method is only supported on Windows.
        /// /*cef()*/
        /// </summary>
        /*2044*/


        // gen! void InitFromString(const CefString& command_line)
        /*2045*/

        public void InitFromString(string /*2046*/
        command_line
        )/*2047*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(command_line);
            /*2048*/
            ;
            /*2049*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_InitFromString_5, out ret, ref v1);
            /*2050*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2051*/
            ;
            /*2052*/
        }
        /// <summary>
        /// Reset the command-line switches and arguments but leave the program
        /// component unchanged.
        /// /*cef()*/
        /// </summary>
        /*2053*/


        // gen! void Reset()
        /*2054*/

        public void Reset()/*2055*/
        {
            JsValue ret;
            /*2056*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Reset_6, out ret);
            /*2057*/

            /*2058*/
        }
        /// <summary>
        /// Retrieve the original command line string as a vector of strings.
        /// The argv array: { program, [(--|-|/)switch[=value]]*, [--], [argument]* }
        /// /*cef()*/
        /// </summary>
        /*2059*/


        // gen! void GetArgv(std::vector<CefString>& argv)
        /*2060*/

        public void GetArgv(List<string> /*2061*/
        argv
        )/*2062*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*2063*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetArgv_7, out ret, ref v1);
            /*2064*/

            /*2065*/
        }
        /// <summary>
        /// Constructs and returns the represented command line string. Use this method
        /// cautiously because quoting behavior is unclear.
        /// /*cef()*/
        /// </summary>
        /*2066*/


        // gen! CefString GetCommandLineString()
        /*2067*/

        public string GetCommandLineString()/*2068*/
        {
            JsValue ret;
            /*2069*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_GetCommandLineString_8, out ret);
            /*2070*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2071*/
            return ret_result;
            /*2072*/
        }
        /// <summary>
        /// Get the program part of the command line string (the first item).
        /// /*cef()*/
        /// </summary>
        /*2073*/


        // gen! CefString GetProgram()
        /*2074*/

        public string GetProgram()/*2075*/
        {
            JsValue ret;
            /*2076*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_GetProgram_9, out ret);
            /*2077*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2078*/
            return ret_result;
            /*2079*/
        }
        /// <summary>
        /// Set the program part of the command line string (the first item).
        /// /*cef()*/
        /// </summary>
        /*2080*/


        // gen! void SetProgram(const CefString& program)
        /*2081*/

        public void SetProgram(string /*2082*/
        program
        )/*2083*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(program);
            /*2084*/
            ;
            /*2085*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_SetProgram_10, out ret, ref v1);
            /*2086*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2087*/
            ;
            /*2088*/
        }
        /// <summary>
        /// Returns true if the command line has switches.
        /// /*cef()*/
        /// </summary>
        /*2089*/


        // gen! bool HasSwitches()
        /*2090*/

        public bool HasSwitches()/*2091*/
        {
            JsValue ret;
            /*2092*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_HasSwitches_11, out ret);
            /*2093*/
            var ret_result = ret.I32 != 0;
            /*2094*/
            return ret_result;
            /*2095*/
        }
        /// <summary>
        /// Returns true if the command line contains the given switch.
        /// /*cef()*/
        /// </summary>
        /*2096*/


        // gen! bool HasSwitch(const CefString& name)
        /*2097*/

        public bool HasSwitch(string /*2098*/
        name
        )/*2099*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*2100*/
            ;
            /*2101*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_HasSwitch_12, out ret, ref v1);
            /*2102*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2103*/
            ;
            /*2104*/
            return ret_result;
            /*2105*/
        }
        /// <summary>
        /// Returns the value associated with the given switch. If the switch has no
        /// value or isn't present this method returns the empty string.
        /// /*cef()*/
        /// </summary>
        /*2106*/


        // gen! CefString GetSwitchValue(const CefString& name)
        /*2107*/

        public string GetSwitchValue(string /*2108*/
        name
        )/*2109*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*2110*/
            ;
            /*2111*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetSwitchValue_13, out ret, ref v1);
            /*2112*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2113*/
            ;
            /*2114*/
            return ret_result;
            /*2115*/
        }
        /// <summary>
        /// Returns the map of switch names and values. If a switch has no value an
        /// empty string is returned.
        /// /*cef()*/
        /// </summary>
        /*2116*/


        // gen! void GetSwitches(SwitchMap& switches)
        /*2117*/

        public void GetSwitches(SwitchMap /*2118*/
        switches
        )/*2119*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*2120*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetSwitches_14, out ret, ref v1);
            /*2121*/

            /*2122*/
        }
        /// <summary>
        /// Add a switch to the end of the command line. If the switch has no value
        /// pass an empty value string.
        /// /*cef()*/
        /// </summary>
        /*2123*/


        // gen! void AppendSwitch(const CefString& name)
        /*2124*/

        public void AppendSwitch(string /*2125*/
        name
        )/*2126*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*2127*/
            ;
            /*2128*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_AppendSwitch_15, out ret, ref v1);
            /*2129*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2130*/
            ;
            /*2131*/
        }
        /// <summary>
        /// Add a switch with the specified value to the end of the command line.
        /// /*cef()*/
        /// </summary>
        /*2132*/


        // gen! void AppendSwitchWithValue(const CefString& name,const CefString& value)
        /*2133*/

        public void AppendSwitchWithValue(string /*2134*/
        name
        , string /*2135*/
        value
        )/*2136*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*2137*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*2138*/
            ;
            /*2139*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCommandLine_AppendSwitchWithValue_16, out ret, ref v1, ref v2);
            /*2140*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2141*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*2142*/
            ;
            /*2143*/
        }
        /// <summary>
        /// True if there are remaining command line arguments.
        /// /*cef()*/
        /// </summary>
        /*2144*/


        // gen! bool HasArguments()
        /*2145*/

        public bool HasArguments()/*2146*/
        {
            JsValue ret;
            /*2147*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_HasArguments_17, out ret);
            /*2148*/
            var ret_result = ret.I32 != 0;
            /*2149*/
            return ret_result;
            /*2150*/
        }
        /// <summary>
        /// Get the remaining command line arguments.
        /// /*cef()*/
        /// </summary>
        /*2151*/


        // gen! void GetArguments(ArgumentList& arguments)
        /*2152*/

        public void GetArguments(ArgumentList /*2153*/
        arguments
        )/*2154*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*2155*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetArguments_18, out ret, ref v1);
            /*2156*/

            /*2157*/
        }
        /// <summary>
        /// Add an argument to the end of the command line.
        /// /*cef()*/
        /// </summary>
        /*2158*/


        // gen! void AppendArgument(const CefString& argument)
        /*2159*/

        public void AppendArgument(string /*2160*/
        argument
        )/*2161*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(argument);
            /*2162*/
            ;
            /*2163*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_AppendArgument_19, out ret, ref v1);
            /*2164*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2165*/
            ;
            /*2166*/
        }
        /// <summary>
        /// Insert a command before the current command.
        /// Common for debuggers, like "valgrind" or "gdb --args".
        /// /*cef()*/
        /// </summary>
        /*2167*/


        // gen! void PrependWrapper(const CefString& wrapper)
        /*2168*/

        public void PrependWrapper(string /*2169*/
        wrapper
        )/*2170*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(wrapper);
            /*2171*/
            ;
            /*2172*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_PrependWrapper_20, out ret, ref v1);
            /*2173*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2174*/
            ;
            /*2175*/
        }
        /*2176*/
    }


    // [virtual] class CefContextMenuParams
    /// <summary>
    /// Provides information about the context menu state. The ethods of this class
    /// can only be accessed on browser process the UI thread.
    /// /*(source=library)*/
    /// </summary>
    /*2290*/
    public struct CefContextMenuParams
    {
        /*2291*/
        const int _typeNAME = 7;
        /*2292*/
        const int CefContextMenuParams_Release_0 = (_typeNAME << 16) | 0;
        /*2293*/
        const int CefContextMenuParams_GetXCoord_1 = (_typeNAME << 16) | 1;
        /*2294*/
        const int CefContextMenuParams_GetYCoord_2 = (_typeNAME << 16) | 2;
        /*2295*/
        const int CefContextMenuParams_GetTypeFlags_3 = (_typeNAME << 16) | 3;
        /*2296*/
        const int CefContextMenuParams_GetLinkUrl_4 = (_typeNAME << 16) | 4;
        /*2297*/
        const int CefContextMenuParams_GetUnfilteredLinkUrl_5 = (_typeNAME << 16) | 5;
        /*2298*/
        const int CefContextMenuParams_GetSourceUrl_6 = (_typeNAME << 16) | 6;
        /*2299*/
        const int CefContextMenuParams_HasImageContents_7 = (_typeNAME << 16) | 7;
        /*2300*/
        const int CefContextMenuParams_GetTitleText_8 = (_typeNAME << 16) | 8;
        /*2301*/
        const int CefContextMenuParams_GetPageUrl_9 = (_typeNAME << 16) | 9;
        /*2302*/
        const int CefContextMenuParams_GetFrameUrl_10 = (_typeNAME << 16) | 10;
        /*2303*/
        const int CefContextMenuParams_GetFrameCharset_11 = (_typeNAME << 16) | 11;
        /*2304*/
        const int CefContextMenuParams_GetMediaType_12 = (_typeNAME << 16) | 12;
        /*2305*/
        const int CefContextMenuParams_GetMediaStateFlags_13 = (_typeNAME << 16) | 13;
        /*2306*/
        const int CefContextMenuParams_GetSelectionText_14 = (_typeNAME << 16) | 14;
        /*2307*/
        const int CefContextMenuParams_GetMisspelledWord_15 = (_typeNAME << 16) | 15;
        /*2308*/
        const int CefContextMenuParams_GetDictionarySuggestions_16 = (_typeNAME << 16) | 16;
        /*2309*/
        const int CefContextMenuParams_IsEditable_17 = (_typeNAME << 16) | 17;
        /*2310*/
        const int CefContextMenuParams_IsSpellCheckEnabled_18 = (_typeNAME << 16) | 18;
        /*2311*/
        const int CefContextMenuParams_GetEditStateFlags_19 = (_typeNAME << 16) | 19;
        /*2312*/
        const int CefContextMenuParams_IsCustomMenu_20 = (_typeNAME << 16) | 20;
        /*2313*/
        const int CefContextMenuParams_IsPepperMenu_21 = (_typeNAME << 16) | 21;
        /*2314*/
        internal readonly IntPtr nativePtr;
        /*2315*/
        internal CefContextMenuParams(IntPtr nativePtr)
        {
            /*2316*/
            this.nativePtr = nativePtr;
            /*2317*/
        }
        /*2318*/
        public void Release()
        {
            /*2319*/
            JsValue ret;
            /*2320*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_Release_0, out ret);
            /*2321*/
        }
        /// <summary>
        /// CefContextMenuParams methods.
        /// </summary>
        /*2322*/


        // gen! int GetXCoord()
        /*2323*/

        public int GetXCoord()/*2324*/
        {
            JsValue ret;
            /*2325*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetXCoord_1, out ret);
            /*2326*/
            var ret_result = ret.I32;
            /*2327*/
            return ret_result;
            /*2328*/
        }
        /// <summary>
        /// Returns the Y coordinate of the mouse where the context menu was invoked.
        /// Coords are relative to the associated RenderView's origin.
        /// /*cef()*/
        /// </summary>
        /*2329*/


        // gen! int GetYCoord()
        /*2330*/

        public int GetYCoord()/*2331*/
        {
            JsValue ret;
            /*2332*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetYCoord_2, out ret);
            /*2333*/
            var ret_result = ret.I32;
            /*2334*/
            return ret_result;
            /*2335*/
        }
        /// <summary>
        /// Returns flags representing the type of node that the context menu was
        /// invoked on.
        /// /*cef(default_retval=CM_TYPEFLAG_NONE)*/
        /// </summary>
        /*2336*/


        // gen! TypeFlags GetTypeFlags()
        /*2337*/

        public cef_context_menu_type_flags_t GetTypeFlags()/*2338*/
        {
            JsValue ret;
            /*2339*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetTypeFlags_3, out ret);
            /*2340*/
            var ret_result = (cef_context_menu_type_flags_t)ret.I32;

            /*2341*/
            return ret_result;
            /*2342*/
        }
        /// <summary>
        /// Returns the URL of the link, if any, that encloses the node that the
        /// context menu was invoked on.
        /// /*cef()*/
        /// </summary>
        /*2343*/


        // gen! CefString GetLinkUrl()
        /*2344*/

        public string GetLinkUrl()/*2345*/
        {
            JsValue ret;
            /*2346*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetLinkUrl_4, out ret);
            /*2347*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2348*/
            return ret_result;
            /*2349*/
        }
        /// <summary>
        /// Returns the link URL, if any, to be used ONLY for "copy link address". We
        /// don't validate this field in the frontend process.
        /// /*cef()*/
        /// </summary>
        /*2350*/


        // gen! CefString GetUnfilteredLinkUrl()
        /*2351*/

        public string GetUnfilteredLinkUrl()/*2352*/
        {
            JsValue ret;
            /*2353*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetUnfilteredLinkUrl_5, out ret);
            /*2354*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2355*/
            return ret_result;
            /*2356*/
        }
        /// <summary>
        /// Returns the source URL, if any, for the element that the context menu was
        /// invoked on. Example of elements with source URLs are img, audio, and video.
        /// /*cef()*/
        /// </summary>
        /*2357*/


        // gen! CefString GetSourceUrl()
        /*2358*/

        public string GetSourceUrl()/*2359*/
        {
            JsValue ret;
            /*2360*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetSourceUrl_6, out ret);
            /*2361*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2362*/
            return ret_result;
            /*2363*/
        }
        /// <summary>
        /// Returns true if the context menu was invoked on an image which has
        /// non-empty contents.
        /// /*cef()*/
        /// </summary>
        /*2364*/


        // gen! bool HasImageContents()
        /*2365*/

        public bool HasImageContents()/*2366*/
        {
            JsValue ret;
            /*2367*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_HasImageContents_7, out ret);
            /*2368*/
            var ret_result = ret.I32 != 0;
            /*2369*/
            return ret_result;
            /*2370*/
        }
        /// <summary>
        /// Returns the title text or the alt text if the context menu was invoked on
        /// an image.
        /// /*cef()*/
        /// </summary>
        /*2371*/


        // gen! CefString GetTitleText()
        /*2372*/

        public string GetTitleText()/*2373*/
        {
            JsValue ret;
            /*2374*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetTitleText_8, out ret);
            /*2375*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2376*/
            return ret_result;
            /*2377*/
        }
        /// <summary>
        /// Returns the URL of the top level page that the context menu was invoked on.
        /// /*cef()*/
        /// </summary>
        /*2378*/


        // gen! CefString GetPageUrl()
        /*2379*/

        public string GetPageUrl()/*2380*/
        {
            JsValue ret;
            /*2381*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetPageUrl_9, out ret);
            /*2382*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2383*/
            return ret_result;
            /*2384*/
        }
        /// <summary>
        /// Returns the URL of the subframe that the context menu was invoked on.
        /// /*cef()*/
        /// </summary>
        /*2385*/


        // gen! CefString GetFrameUrl()
        /*2386*/

        public string GetFrameUrl()/*2387*/
        {
            JsValue ret;
            /*2388*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetFrameUrl_10, out ret);
            /*2389*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2390*/
            return ret_result;
            /*2391*/
        }
        /// <summary>
        /// Returns the character encoding of the subframe that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>
        /*2392*/


        // gen! CefString GetFrameCharset()
        /*2393*/

        public string GetFrameCharset()/*2394*/
        {
            JsValue ret;
            /*2395*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetFrameCharset_11, out ret);
            /*2396*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2397*/
            return ret_result;
            /*2398*/
        }
        /// <summary>
        /// Returns the type of context node that the context menu was invoked on.
        /// /*cef(default_retval=CM_MEDIATYPE_NONE)*/
        /// </summary>
        /*2399*/


        // gen! MediaType GetMediaType()
        /*2400*/

        public cef_context_menu_media_type_t GetMediaType()/*2401*/
        {
            JsValue ret;
            /*2402*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMediaType_12, out ret);
            /*2403*/
            var ret_result = (cef_context_menu_media_type_t)ret.I32;

            /*2404*/
            return ret_result;
            /*2405*/
        }
        /// <summary>
        /// Returns flags representing the actions supported by the media element, if
        /// any, that the context menu was invoked on.
        /// /*cef(default_retval=CM_MEDIAFLAG_NONE)*/
        /// </summary>
        /*2406*/


        // gen! MediaStateFlags GetMediaStateFlags()
        /*2407*/

        public cef_context_menu_media_state_flags_t GetMediaStateFlags()/*2408*/
        {
            JsValue ret;
            /*2409*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMediaStateFlags_13, out ret);
            /*2410*/
            var ret_result = (cef_context_menu_media_state_flags_t)ret.I32;

            /*2411*/
            return ret_result;
            /*2412*/
        }
        /// <summary>
        /// Returns the text of the selection, if any, that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>
        /*2413*/


        // gen! CefString GetSelectionText()
        /*2414*/

        public string GetSelectionText()/*2415*/
        {
            JsValue ret;
            /*2416*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetSelectionText_14, out ret);
            /*2417*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2418*/
            return ret_result;
            /*2419*/
        }
        /// <summary>
        /// Returns the text of the misspelled word, if any, that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>
        /*2420*/


        // gen! CefString GetMisspelledWord()
        /*2421*/

        public string GetMisspelledWord()/*2422*/
        {
            JsValue ret;
            /*2423*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMisspelledWord_15, out ret);
            /*2424*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2425*/
            return ret_result;
            /*2426*/
        }
        /// <summary>
        /// Returns true if suggestions exist, false otherwise. Fills in |suggestions|
        /// from the spell check service for the misspelled word if there is one.
        /// /*cef()*/
        /// </summary>
        /*2427*/


        // gen! bool GetDictionarySuggestions(std::vector<CefString>& suggestions)
        /*2428*/

        public bool GetDictionarySuggestions(List<string> /*2429*/
        suggestions
        )/*2430*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*2431*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefContextMenuParams_GetDictionarySuggestions_16, out ret, ref v1);
            /*2432*/
            var ret_result = ret.I32 != 0;
            /*2433*/
            return ret_result;
            /*2434*/
        }
        /// <summary>
        /// Returns true if the context menu was invoked on an editable node.
        /// /*cef()*/
        /// </summary>
        /*2435*/


        // gen! bool IsEditable()
        /*2436*/

        public bool IsEditable()/*2437*/
        {
            JsValue ret;
            /*2438*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsEditable_17, out ret);
            /*2439*/
            var ret_result = ret.I32 != 0;
            /*2440*/
            return ret_result;
            /*2441*/
        }
        /// <summary>
        /// Returns true if the context menu was invoked on an editable node where
        /// spell-check is enabled.
        /// /*cef()*/
        /// </summary>
        /*2442*/


        // gen! bool IsSpellCheckEnabled()
        /*2443*/

        public bool IsSpellCheckEnabled()/*2444*/
        {
            JsValue ret;
            /*2445*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsSpellCheckEnabled_18, out ret);
            /*2446*/
            var ret_result = ret.I32 != 0;
            /*2447*/
            return ret_result;
            /*2448*/
        }
        /// <summary>
        /// Returns flags representing the actions supported by the editable node, if
        /// any, that the context menu was invoked on.
        /// /*cef(default_retval=CM_EDITFLAG_NONE)*/
        /// </summary>
        /*2449*/


        // gen! EditStateFlags GetEditStateFlags()
        /*2450*/

        public cef_context_menu_edit_state_flags_t GetEditStateFlags()/*2451*/
        {
            JsValue ret;
            /*2452*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetEditStateFlags_19, out ret);
            /*2453*/
            var ret_result = (cef_context_menu_edit_state_flags_t)ret.I32;

            /*2454*/
            return ret_result;
            /*2455*/
        }
        /// <summary>
        /// Returns true if the context menu contains items specified by the renderer
        /// process (for example, plugin placeholder or pepper plugin menu items).
        /// /*cef()*/
        /// </summary>
        /*2456*/


        // gen! bool IsCustomMenu()
        /*2457*/

        public bool IsCustomMenu()/*2458*/
        {
            JsValue ret;
            /*2459*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsCustomMenu_20, out ret);
            /*2460*/
            var ret_result = ret.I32 != 0;
            /*2461*/
            return ret_result;
            /*2462*/
        }
        /// <summary>
        /// Returns true if the context menu was invoked from a pepper plugin.
        /// /*cef()*/
        /// </summary>
        /*2463*/


        // gen! bool IsPepperMenu()
        /*2464*/

        public bool IsPepperMenu()/*2465*/
        {
            JsValue ret;
            /*2466*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsPepperMenu_21, out ret);
            /*2467*/
            var ret_result = ret.I32 != 0;
            /*2468*/
            return ret_result;
            /*2469*/
        }
        /*2470*/
    }


    // [virtual] class CefCookieManager
    /// <summary>
    /// Class used for managing cookies. The methods of this class may be called on
    /// any thread unless otherwise indicated.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*2514*/
    public struct CefCookieManager
    {
        /*2515*/
        const int _typeNAME = 8;
        /*2516*/
        const int CefCookieManager_Release_0 = (_typeNAME << 16) | 0;
        /*2517*/
        const int CefCookieManager_SetSupportedSchemes_1 = (_typeNAME << 16) | 1;
        /*2518*/
        const int CefCookieManager_VisitAllCookies_2 = (_typeNAME << 16) | 2;
        /*2519*/
        const int CefCookieManager_VisitUrlCookies_3 = (_typeNAME << 16) | 3;
        /*2520*/
        const int CefCookieManager_SetCookie_4 = (_typeNAME << 16) | 4;
        /*2521*/
        const int CefCookieManager_DeleteCookies_5 = (_typeNAME << 16) | 5;
        /*2522*/
        const int CefCookieManager_SetStoragePath_6 = (_typeNAME << 16) | 6;
        /*2523*/
        const int CefCookieManager_FlushStore_7 = (_typeNAME << 16) | 7;
        /*2524*/
        internal readonly IntPtr nativePtr;
        /*2525*/
        internal CefCookieManager(IntPtr nativePtr)
        {
            /*2526*/
            this.nativePtr = nativePtr;
            /*2527*/
        }
        /*2528*/
        public void Release()
        {
            /*2529*/
            JsValue ret;
            /*2530*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCookieManager_Release_0, out ret);
            /*2531*/
        }
        /// <summary>
        /// CefCookieManager methods.
        /// </summary>
        /*2532*/


        // gen! void SetSupportedSchemes(const std::vector<CefString>& schemes,CefRefPtr<CefCompletionCallback> callback)
        /*2533*/

        public void SetSupportedSchemes(List<string> /*2534*/
        schemes
        , CefCompletionCallback /*2535*/
        callback
        )/*2536*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*2537*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCookieManager_SetSupportedSchemes_1, out ret, ref v1, ref v2);
            /*2538*/

            /*2539*/
        }
        /// <summary>
        /// Visit all cookies on the IO thread. The returned cookies are ordered by
        /// longest path, then by earliest creation date. Returns false if cookies
        /// cannot be accessed.
        /// /*cef()*/
        /// </summary>
        /*2540*/


        // gen! bool VisitAllCookies(CefRefPtr<CefCookieVisitor> visitor)
        /*2541*/

        public bool VisitAllCookies(CefCookieVisitor /*2542*/
        visitor
        )/*2543*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*2544*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCookieManager_VisitAllCookies_2, out ret, ref v1);
            /*2545*/
            var ret_result = ret.I32 != 0;
            /*2546*/
            return ret_result;
            /*2547*/
        }
        /// <summary>
        /// Visit a subset of cookies on the IO thread. The results are filtered by the
        /// given url scheme, host, domain and path. If |includeHttpOnly| is true
        /// HTTP-only cookies will also be included in the results. The returned
        /// cookies are ordered by longest path, then by earliest creation date.
        /// Returns false if cookies cannot be accessed.
        /// /*cef()*/
        /// </summary>
        /*2548*/


        // gen! bool VisitUrlCookies(const CefString& url,bool includeHttpOnly,CefRefPtr<CefCookieVisitor> visitor)
        /*2549*/

        public bool VisitUrlCookies(string /*2550*/
        url
        , bool /*2551*/
        includeHttpOnly
        , CefCookieVisitor /*2552*/
        visitor
        )/*2553*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*2554*/
            ;
            /*2555*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_VisitUrlCookies_3, out ret, ref v1, ref v2, ref v3);
            /*2556*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2557*/
            ;
            /*2558*/
            return ret_result;
            /*2559*/
        }
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
        /*2560*/


        // gen! bool SetCookie(const CefString& url,const CefCookie& cookie,CefRefPtr<CefSetCookieCallback> callback)
        /*2561*/

        public bool SetCookie(string /*2562*/
        url
        , CefCookie /*2563*/
        cookie
        , CefSetCookieCallback /*2564*/
        callback
        )/*2565*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*2566*/
            ;
            /*2567*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_SetCookie_4, out ret, ref v1, ref v2, ref v3);
            /*2568*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2569*/
            ;
            /*2570*/
            return ret_result;
            /*2571*/
        }
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
        /*2572*/


        // gen! bool DeleteCookies(const CefString& url,const CefString& cookie_name,CefRefPtr<CefDeleteCookiesCallback> callback)
        /*2573*/

        public bool DeleteCookies(string /*2574*/
        url
        , string /*2575*/
        cookie_name
        , CefDeleteCookiesCallback /*2576*/
        callback
        )/*2577*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*2578*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(cookie_name);
            /*2579*/
            ;
            /*2580*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_DeleteCookies_5, out ret, ref v1, ref v2, ref v3);
            /*2581*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2582*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*2583*/
            ;
            /*2584*/
            return ret_result;
            /*2585*/
        }
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
        /*2586*/


        // gen! bool SetStoragePath(const CefString& path,bool persist_session_cookies,CefRefPtr<CefCompletionCallback> callback)
        /*2587*/

        public bool SetStoragePath(string /*2588*/
        path
        , bool /*2589*/
        persist_session_cookies
        , CefCompletionCallback /*2590*/
        callback
        )/*2591*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(path);
            /*2592*/
            ;
            /*2593*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_SetStoragePath_6, out ret, ref v1, ref v2, ref v3);
            /*2594*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2595*/
            ;
            /*2596*/
            return ret_result;
            /*2597*/
        }
        /// <summary>
        /// Flush the backing store (if any) to disk. If |callback| is non-NULL it will
        /// be executed asnychronously on the IO thread after the flush is complete.
        /// Returns false if cookies cannot be accessed.
        /// /*cef(optional_param=callback)*/
        /// </summary>
        /*2598*/


        // gen! bool FlushStore(CefRefPtr<CefCompletionCallback> callback)
        /*2599*/

        public bool FlushStore(CefCompletionCallback /*2600*/
        callback
        )/*2601*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*2602*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCookieManager_FlushStore_7, out ret, ref v1);
            /*2603*/
            var ret_result = ret.I32 != 0;
            /*2604*/
            return ret_result;
            /*2605*/
        }
        /*2606*/
    }


    // [virtual] class CefCookieVisitor
    /// <summary>
    /// Interface to implement for visiting cookie values. The methods of this class
    /// will always be called on the IO thread.
    /// /*(source=client)*/
    /// </summary>
    /*2615*/
    public struct CefCookieVisitor
    {
        /*2616*/
        const int _typeNAME = 9;
        /*2617*/
        const int CefCookieVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*2618*/
        internal readonly IntPtr nativePtr;
        /*2619*/
        internal CefCookieVisitor(IntPtr nativePtr)
        {
            /*2620*/
            this.nativePtr = nativePtr;
            /*2621*/
        }
        /*2622*/
        public void Release()
        {
            /*2623*/
            JsValue ret;
            /*2624*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCookieVisitor_Release_0, out ret);
            /*2625*/
        }
        /*2626*/
    }


    // [virtual] class CefDOMVisitor
    /// <summary>
    /// Interface to implement for visiting the DOM. The methods of this class will
    /// be called on the render process main thread.
    /// /*(source=client)*/
    /// </summary>
    /*2635*/
    public struct CefDOMVisitor
    {
        /*2636*/
        const int _typeNAME = 10;
        /*2637*/
        const int CefDOMVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*2638*/
        internal readonly IntPtr nativePtr;
        /*2639*/
        internal CefDOMVisitor(IntPtr nativePtr)
        {
            /*2640*/
            this.nativePtr = nativePtr;
            /*2641*/
        }
        /*2642*/
        public void Release()
        {
            /*2643*/
            JsValue ret;
            /*2644*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMVisitor_Release_0, out ret);
            /*2645*/
        }
        /*2646*/
    }


    // [virtual] class CefDOMDocument
    /// <summary>
    /// Class used to represent a DOM document. The methods of this class should only
    /// be called on the render process main thread thread.
    /// /*(source=library)*/
    /// </summary>
    /*2725*/
    public struct CefDOMDocument
    {
        /*2726*/
        const int _typeNAME = 11;
        /*2727*/
        const int CefDOMDocument_Release_0 = (_typeNAME << 16) | 0;
        /*2728*/
        const int CefDOMDocument_GetType_1 = (_typeNAME << 16) | 1;
        /*2729*/
        const int CefDOMDocument_GetDocument_2 = (_typeNAME << 16) | 2;
        /*2730*/
        const int CefDOMDocument_GetBody_3 = (_typeNAME << 16) | 3;
        /*2731*/
        const int CefDOMDocument_GetHead_4 = (_typeNAME << 16) | 4;
        /*2732*/
        const int CefDOMDocument_GetTitle_5 = (_typeNAME << 16) | 5;
        /*2733*/
        const int CefDOMDocument_GetElementById_6 = (_typeNAME << 16) | 6;
        /*2734*/
        const int CefDOMDocument_GetFocusedNode_7 = (_typeNAME << 16) | 7;
        /*2735*/
        const int CefDOMDocument_HasSelection_8 = (_typeNAME << 16) | 8;
        /*2736*/
        const int CefDOMDocument_GetSelectionStartOffset_9 = (_typeNAME << 16) | 9;
        /*2737*/
        const int CefDOMDocument_GetSelectionEndOffset_10 = (_typeNAME << 16) | 10;
        /*2738*/
        const int CefDOMDocument_GetSelectionAsMarkup_11 = (_typeNAME << 16) | 11;
        /*2739*/
        const int CefDOMDocument_GetSelectionAsText_12 = (_typeNAME << 16) | 12;
        /*2740*/
        const int CefDOMDocument_GetBaseURL_13 = (_typeNAME << 16) | 13;
        /*2741*/
        const int CefDOMDocument_GetCompleteURL_14 = (_typeNAME << 16) | 14;
        /*2742*/
        internal readonly IntPtr nativePtr;
        /*2743*/
        internal CefDOMDocument(IntPtr nativePtr)
        {
            /*2744*/
            this.nativePtr = nativePtr;
            /*2745*/
        }
        /*2746*/
        public void Release()
        {
            /*2747*/
            JsValue ret;
            /*2748*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_Release_0, out ret);
            /*2749*/
        }
        /// <summary>
        /// CefDOMDocument methods.
        /// </summary>
        /*2750*/


        // gen! Type GetType()
        /*2751*/

        public cef_dom_document_type_t _GetType()/*2752*/
        {
            JsValue ret;
            /*2753*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetType_1, out ret);
            /*2754*/
            var ret_result = (cef_dom_document_type_t)ret.I32;

            /*2755*/
            return ret_result;
            /*2756*/
        }
        /// <summary>
        /// Returns the root document node.
        /// /*cef()*/
        /// </summary>
        /*2757*/


        // gen! CefRefPtr<CefDOMNode> GetDocument()
        /*2758*/

        public CefDOMNode GetDocument()/*2759*/
        {
            JsValue ret;
            /*2760*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetDocument_2, out ret);
            /*2761*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2762*/
            return ret_result;
            /*2763*/
        }
        /// <summary>
        /// Returns the BODY node of an HTML document.
        /// /*cef()*/
        /// </summary>
        /*2764*/


        // gen! CefRefPtr<CefDOMNode> GetBody()
        /*2765*/

        public CefDOMNode GetBody()/*2766*/
        {
            JsValue ret;
            /*2767*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetBody_3, out ret);
            /*2768*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2769*/
            return ret_result;
            /*2770*/
        }
        /// <summary>
        /// Returns the HEAD node of an HTML document.
        /// /*cef()*/
        /// </summary>
        /*2771*/


        // gen! CefRefPtr<CefDOMNode> GetHead()
        /*2772*/

        public CefDOMNode GetHead()/*2773*/
        {
            JsValue ret;
            /*2774*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetHead_4, out ret);
            /*2775*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2776*/
            return ret_result;
            /*2777*/
        }
        /// <summary>
        /// Returns the title of an HTML document.
        /// /*cef()*/
        /// </summary>
        /*2778*/


        // gen! CefString GetTitle()
        /*2779*/

        public string GetTitle()/*2780*/
        {
            JsValue ret;
            /*2781*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetTitle_5, out ret);
            /*2782*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2783*/
            return ret_result;
            /*2784*/
        }
        /// <summary>
        /// Returns the document element with the specified ID value.
        /// /*cef()*/
        /// </summary>
        /*2785*/


        // gen! CefRefPtr<CefDOMNode> GetElementById(const CefString& id)
        /*2786*/

        public CefDOMNode GetElementById(string /*2787*/
        id
        )/*2788*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(id);
            /*2789*/
            ;
            /*2790*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMDocument_GetElementById_6, out ret, ref v1);
            /*2791*/
            var ret_result = new CefDOMNode(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2792*/
            ;
            /*2793*/
            return ret_result;
            /*2794*/
        }
        /// <summary>
        /// Returns the node that currently has keyboard focus.
        /// /*cef()*/
        /// </summary>
        /*2795*/


        // gen! CefRefPtr<CefDOMNode> GetFocusedNode()
        /*2796*/

        public CefDOMNode GetFocusedNode()/*2797*/
        {
            JsValue ret;
            /*2798*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetFocusedNode_7, out ret);
            /*2799*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2800*/
            return ret_result;
            /*2801*/
        }
        /// <summary>
        /// Returns true if a portion of the document is selected.
        /// /*cef()*/
        /// </summary>
        /*2802*/


        // gen! bool HasSelection()
        /*2803*/

        public bool HasSelection()/*2804*/
        {
            JsValue ret;
            /*2805*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_HasSelection_8, out ret);
            /*2806*/
            var ret_result = ret.I32 != 0;
            /*2807*/
            return ret_result;
            /*2808*/
        }
        /// <summary>
        /// Returns the selection offset within the start node.
        /// /*cef()*/
        /// </summary>
        /*2809*/


        // gen! int GetSelectionStartOffset()
        /*2810*/

        public int GetSelectionStartOffset()/*2811*/
        {
            JsValue ret;
            /*2812*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionStartOffset_9, out ret);
            /*2813*/
            var ret_result = ret.I32;
            /*2814*/
            return ret_result;
            /*2815*/
        }
        /// <summary>
        /// Returns the selection offset within the end node.
        /// /*cef()*/
        /// </summary>
        /*2816*/


        // gen! int GetSelectionEndOffset()
        /*2817*/

        public int GetSelectionEndOffset()/*2818*/
        {
            JsValue ret;
            /*2819*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionEndOffset_10, out ret);
            /*2820*/
            var ret_result = ret.I32;
            /*2821*/
            return ret_result;
            /*2822*/
        }
        /// <summary>
        /// Returns the contents of this selection as markup.
        /// /*cef()*/
        /// </summary>
        /*2823*/


        // gen! CefString GetSelectionAsMarkup()
        /*2824*/

        public string GetSelectionAsMarkup()/*2825*/
        {
            JsValue ret;
            /*2826*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionAsMarkup_11, out ret);
            /*2827*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2828*/
            return ret_result;
            /*2829*/
        }
        /// <summary>
        /// Returns the contents of this selection as text.
        /// /*cef()*/
        /// </summary>
        /*2830*/


        // gen! CefString GetSelectionAsText()
        /*2831*/

        public string GetSelectionAsText()/*2832*/
        {
            JsValue ret;
            /*2833*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionAsText_12, out ret);
            /*2834*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2835*/
            return ret_result;
            /*2836*/
        }
        /// <summary>
        /// Returns the base URL for the document.
        /// /*cef()*/
        /// </summary>
        /*2837*/


        // gen! CefString GetBaseURL()
        /*2838*/

        public string GetBaseURL()/*2839*/
        {
            JsValue ret;
            /*2840*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetBaseURL_13, out ret);
            /*2841*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2842*/
            return ret_result;
            /*2843*/
        }
        /// <summary>
        /// Returns a complete URL based on the document base URL and the specified
        /// partial URL.
        /// /*cef()*/
        /// </summary>
        /*2844*/


        // gen! CefString GetCompleteURL(const CefString& partialURL)
        /*2845*/

        public string GetCompleteURL(string /*2846*/
        partialURL
        )/*2847*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(partialURL);
            /*2848*/
            ;
            /*2849*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMDocument_GetCompleteURL_14, out ret, ref v1);
            /*2850*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2851*/
            ;
            /*2852*/
            return ret_result;
            /*2853*/
        }
        /*2854*/
    }


    // [virtual] class CefDOMNode
    /// <summary>
    /// Class used to represent a DOM node. The methods of this class should only be
    /// called on the render process main thread.
    /// /*(source=library)*/
    /// </summary>
    /*2993*/
    public struct CefDOMNode
    {
        /*2994*/
        const int _typeNAME = 12;
        /*2995*/
        const int CefDOMNode_Release_0 = (_typeNAME << 16) | 0;
        /*2996*/
        const int CefDOMNode_GetType_1 = (_typeNAME << 16) | 1;
        /*2997*/
        const int CefDOMNode_IsText_2 = (_typeNAME << 16) | 2;
        /*2998*/
        const int CefDOMNode_IsElement_3 = (_typeNAME << 16) | 3;
        /*2999*/
        const int CefDOMNode_IsEditable_4 = (_typeNAME << 16) | 4;
        /*3000*/
        const int CefDOMNode_IsFormControlElement_5 = (_typeNAME << 16) | 5;
        /*3001*/
        const int CefDOMNode_GetFormControlElementType_6 = (_typeNAME << 16) | 6;
        /*3002*/
        const int CefDOMNode_IsSame_7 = (_typeNAME << 16) | 7;
        /*3003*/
        const int CefDOMNode_GetName_8 = (_typeNAME << 16) | 8;
        /*3004*/
        const int CefDOMNode_GetValue_9 = (_typeNAME << 16) | 9;
        /*3005*/
        const int CefDOMNode_SetValue_10 = (_typeNAME << 16) | 10;
        /*3006*/
        const int CefDOMNode_GetAsMarkup_11 = (_typeNAME << 16) | 11;
        /*3007*/
        const int CefDOMNode_GetDocument_12 = (_typeNAME << 16) | 12;
        /*3008*/
        const int CefDOMNode_GetParent_13 = (_typeNAME << 16) | 13;
        /*3009*/
        const int CefDOMNode_GetPreviousSibling_14 = (_typeNAME << 16) | 14;
        /*3010*/
        const int CefDOMNode_GetNextSibling_15 = (_typeNAME << 16) | 15;
        /*3011*/
        const int CefDOMNode_HasChildren_16 = (_typeNAME << 16) | 16;
        /*3012*/
        const int CefDOMNode_GetFirstChild_17 = (_typeNAME << 16) | 17;
        /*3013*/
        const int CefDOMNode_GetLastChild_18 = (_typeNAME << 16) | 18;
        /*3014*/
        const int CefDOMNode_GetElementTagName_19 = (_typeNAME << 16) | 19;
        /*3015*/
        const int CefDOMNode_HasElementAttributes_20 = (_typeNAME << 16) | 20;
        /*3016*/
        const int CefDOMNode_HasElementAttribute_21 = (_typeNAME << 16) | 21;
        /*3017*/
        const int CefDOMNode_GetElementAttribute_22 = (_typeNAME << 16) | 22;
        /*3018*/
        const int CefDOMNode_GetElementAttributes_23 = (_typeNAME << 16) | 23;
        /*3019*/
        const int CefDOMNode_SetElementAttribute_24 = (_typeNAME << 16) | 24;
        /*3020*/
        const int CefDOMNode_GetElementInnerText_25 = (_typeNAME << 16) | 25;
        /*3021*/
        const int CefDOMNode_GetElementBounds_26 = (_typeNAME << 16) | 26;
        /*3022*/
        internal readonly IntPtr nativePtr;
        /*3023*/
        internal CefDOMNode(IntPtr nativePtr)
        {
            /*3024*/
            this.nativePtr = nativePtr;
            /*3025*/
        }
        /*3026*/
        public void Release()
        {
            /*3027*/
            JsValue ret;
            /*3028*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_Release_0, out ret);
            /*3029*/
        }
        /// <summary>
        /// CefDOMNode methods.
        /// </summary>
        /*3030*/


        // gen! Type GetType()
        /*3031*/

        public cef_dom_node_type_t _GetType()/*3032*/
        {
            JsValue ret;
            /*3033*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetType_1, out ret);
            /*3034*/
            var ret_result = (cef_dom_node_type_t)ret.I32;

            /*3035*/
            return ret_result;
            /*3036*/
        }
        /// <summary>
        /// Returns true if this is a text node.
        /// /*cef()*/
        /// </summary>
        /*3037*/


        // gen! bool IsText()
        /*3038*/

        public bool IsText()/*3039*/
        {
            JsValue ret;
            /*3040*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsText_2, out ret);
            /*3041*/
            var ret_result = ret.I32 != 0;
            /*3042*/
            return ret_result;
            /*3043*/
        }
        /// <summary>
        /// Returns true if this is an element node.
        /// /*cef()*/
        /// </summary>
        /*3044*/


        // gen! bool IsElement()
        /*3045*/

        public bool IsElement()/*3046*/
        {
            JsValue ret;
            /*3047*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsElement_3, out ret);
            /*3048*/
            var ret_result = ret.I32 != 0;
            /*3049*/
            return ret_result;
            /*3050*/
        }
        /// <summary>
        /// Returns true if this is an editable node.
        /// /*cef()*/
        /// </summary>
        /*3051*/


        // gen! bool IsEditable()
        /*3052*/

        public bool IsEditable()/*3053*/
        {
            JsValue ret;
            /*3054*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsEditable_4, out ret);
            /*3055*/
            var ret_result = ret.I32 != 0;
            /*3056*/
            return ret_result;
            /*3057*/
        }
        /// <summary>
        /// Returns true if this is a form control element node.
        /// /*cef()*/
        /// </summary>
        /*3058*/


        // gen! bool IsFormControlElement()
        /*3059*/

        public bool IsFormControlElement()/*3060*/
        {
            JsValue ret;
            /*3061*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsFormControlElement_5, out ret);
            /*3062*/
            var ret_result = ret.I32 != 0;
            /*3063*/
            return ret_result;
            /*3064*/
        }
        /// <summary>
        /// Returns the type of this form control element node.
        /// /*cef()*/
        /// </summary>
        /*3065*/


        // gen! CefString GetFormControlElementType()
        /*3066*/

        public string GetFormControlElementType()/*3067*/
        {
            JsValue ret;
            /*3068*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetFormControlElementType_6, out ret);
            /*3069*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3070*/
            return ret_result;
            /*3071*/
        }
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>
        /*3072*/


        // gen! bool IsSame(CefRefPtr<CefDOMNode> that)
        /*3073*/

        public bool IsSame(CefDOMNode /*3074*/
        that
        )/*3075*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*3076*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_IsSame_7, out ret, ref v1);
            /*3077*/
            var ret_result = ret.I32 != 0;
            /*3078*/
            return ret_result;
            /*3079*/
        }
        /// <summary>
        /// Returns the name of this node.
        /// /*cef()*/
        /// </summary>
        /*3080*/


        // gen! CefString GetName()
        /*3081*/

        public string GetName()/*3082*/
        {
            JsValue ret;
            /*3083*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetName_8, out ret);
            /*3084*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3085*/
            return ret_result;
            /*3086*/
        }
        /// <summary>
        /// Returns the value of this node.
        /// /*cef()*/
        /// </summary>
        /*3087*/


        // gen! CefString GetValue()
        /*3088*/

        public string GetValue()/*3089*/
        {
            JsValue ret;
            /*3090*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetValue_9, out ret);
            /*3091*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3092*/
            return ret_result;
            /*3093*/
        }
        /// <summary>
        /// Set the value of this node. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*3094*/


        // gen! bool SetValue(const CefString& value)
        /*3095*/

        public bool SetValue(string /*3096*/
        value
        )/*3097*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*3098*/
            ;
            /*3099*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_SetValue_10, out ret, ref v1);
            /*3100*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3101*/
            ;
            /*3102*/
            return ret_result;
            /*3103*/
        }
        /// <summary>
        /// Returns the contents of this node as markup.
        /// /*cef()*/
        /// </summary>
        /*3104*/


        // gen! CefString GetAsMarkup()
        /*3105*/

        public string GetAsMarkup()/*3106*/
        {
            JsValue ret;
            /*3107*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetAsMarkup_11, out ret);
            /*3108*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3109*/
            return ret_result;
            /*3110*/
        }
        /// <summary>
        /// Returns the document associated with this node.
        /// /*cef()*/
        /// </summary>
        /*3111*/


        // gen! CefRefPtr<CefDOMDocument> GetDocument()
        /*3112*/

        public CefDOMDocument GetDocument()/*3113*/
        {
            JsValue ret;
            /*3114*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetDocument_12, out ret);
            /*3115*/
            var ret_result = new CefDOMDocument(ret.Ptr);
            /*3116*/
            return ret_result;
            /*3117*/
        }
        /// <summary>
        /// Returns the parent node.
        /// /*cef()*/
        /// </summary>
        /*3118*/


        // gen! CefRefPtr<CefDOMNode> GetParent()
        /*3119*/

        public CefDOMNode GetParent()/*3120*/
        {
            JsValue ret;
            /*3121*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetParent_13, out ret);
            /*3122*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*3123*/
            return ret_result;
            /*3124*/
        }
        /// <summary>
        /// Returns the previous sibling node.
        /// /*cef()*/
        /// </summary>
        /*3125*/


        // gen! CefRefPtr<CefDOMNode> GetPreviousSibling()
        /*3126*/

        public CefDOMNode GetPreviousSibling()/*3127*/
        {
            JsValue ret;
            /*3128*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetPreviousSibling_14, out ret);
            /*3129*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*3130*/
            return ret_result;
            /*3131*/
        }
        /// <summary>
        /// Returns the next sibling node.
        /// /*cef()*/
        /// </summary>
        /*3132*/


        // gen! CefRefPtr<CefDOMNode> GetNextSibling()
        /*3133*/

        public CefDOMNode GetNextSibling()/*3134*/
        {
            JsValue ret;
            /*3135*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetNextSibling_15, out ret);
            /*3136*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*3137*/
            return ret_result;
            /*3138*/
        }
        /// <summary>
        /// Returns true if this node has child nodes.
        /// /*cef()*/
        /// </summary>
        /*3139*/


        // gen! bool HasChildren()
        /*3140*/

        public bool HasChildren()/*3141*/
        {
            JsValue ret;
            /*3142*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_HasChildren_16, out ret);
            /*3143*/
            var ret_result = ret.I32 != 0;
            /*3144*/
            return ret_result;
            /*3145*/
        }
        /// <summary>
        /// Return the first child node.
        /// /*cef()*/
        /// </summary>
        /*3146*/


        // gen! CefRefPtr<CefDOMNode> GetFirstChild()
        /*3147*/

        public CefDOMNode GetFirstChild()/*3148*/
        {
            JsValue ret;
            /*3149*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetFirstChild_17, out ret);
            /*3150*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*3151*/
            return ret_result;
            /*3152*/
        }
        /// <summary>
        /// Returns the last child node.
        /// /*cef()*/
        /// </summary>
        /*3153*/


        // gen! CefRefPtr<CefDOMNode> GetLastChild()
        /*3154*/

        public CefDOMNode GetLastChild()/*3155*/
        {
            JsValue ret;
            /*3156*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetLastChild_18, out ret);
            /*3157*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*3158*/
            return ret_result;
            /*3159*/
        }
        /// <summary>
        /// The following methods are valid only for element nodes.
        /// Returns the tag name of this element.
        /// /*cef()*/
        /// </summary>
        /*3160*/


        // gen! CefString GetElementTagName()
        /*3161*/

        public string GetElementTagName()/*3162*/
        {
            JsValue ret;
            /*3163*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementTagName_19, out ret);
            /*3164*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3165*/
            return ret_result;
            /*3166*/
        }
        /// <summary>
        /// Returns true if this element has attributes.
        /// /*cef()*/
        /// </summary>
        /*3167*/


        // gen! bool HasElementAttributes()
        /*3168*/

        public bool HasElementAttributes()/*3169*/
        {
            JsValue ret;
            /*3170*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_HasElementAttributes_20, out ret);
            /*3171*/
            var ret_result = ret.I32 != 0;
            /*3172*/
            return ret_result;
            /*3173*/
        }
        /// <summary>
        /// Returns true if this element has an attribute named |attrName|.
        /// /*cef()*/
        /// </summary>
        /*3174*/


        // gen! bool HasElementAttribute(const CefString& attrName)
        /*3175*/

        public bool HasElementAttribute(string /*3176*/
        attrName
        )/*3177*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(attrName);
            /*3178*/
            ;
            /*3179*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_HasElementAttribute_21, out ret, ref v1);
            /*3180*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3181*/
            ;
            /*3182*/
            return ret_result;
            /*3183*/
        }
        /// <summary>
        /// Returns the element attribute named |attrName|.
        /// /*cef()*/
        /// </summary>
        /*3184*/


        // gen! CefString GetElementAttribute(const CefString& attrName)
        /*3185*/

        public string GetElementAttribute(string /*3186*/
        attrName
        )/*3187*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(attrName);
            /*3188*/
            ;
            /*3189*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_GetElementAttribute_22, out ret, ref v1);
            /*3190*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3191*/
            ;
            /*3192*/
            return ret_result;
            /*3193*/
        }
        /// <summary>
        /// Returns a map of all element attributes.
        /// /*cef()*/
        /// </summary>
        /*3194*/


        // gen! void GetElementAttributes(AttributeMap& attrMap)
        /*3195*/

        public void GetElementAttributes(AttributeMap /*3196*/
        attrMap
        )/*3197*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*3198*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_GetElementAttributes_23, out ret, ref v1);
            /*3199*/

            /*3200*/
        }
        /// <summary>
        /// Set the value for the element attribute named |attrName|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*3201*/


        // gen! bool SetElementAttribute(const CefString& attrName,const CefString& value)
        /*3202*/

        public bool SetElementAttribute(string /*3203*/
        attrName
        , string /*3204*/
        value
        )/*3205*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(attrName);
            /*3206*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*3207*/
            ;
            /*3208*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDOMNode_SetElementAttribute_24, out ret, ref v1, ref v2);
            /*3209*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3210*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*3211*/
            ;
            /*3212*/
            return ret_result;
            /*3213*/
        }
        /// <summary>
        /// Returns the inner text of the element.
        /// /*cef()*/
        /// </summary>
        /*3214*/


        // gen! CefString GetElementInnerText()
        /*3215*/

        public string GetElementInnerText()/*3216*/
        {
            JsValue ret;
            /*3217*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementInnerText_25, out ret);
            /*3218*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3219*/
            return ret_result;
            /*3220*/
        }
        /// <summary>
        /// Returns the bounds of the element.
        /// /*cef()*/
        /// </summary>
        /*3221*/


        // gen! CefRect GetElementBounds()
        /*3222*/

        public CefRect GetElementBounds()/*3223*/
        {
            JsValue ret;
            /*3224*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementBounds_26, out ret);
            /*3225*/
            var ret_result = new CefRect(ret.Ptr);

            /*3226*/
            return ret_result;
            /*3227*/
        }
        /*3228*/
    }


    // [virtual] class CefDownloadItem
    /// <summary>
    /// Class used to represent a download item.
    /// /*(source=library)*/
    /// </summary>
    /*3322*/
    public struct CefDownloadItem
    {
        /*3323*/
        const int _typeNAME = 13;
        /*3324*/
        const int CefDownloadItem_Release_0 = (_typeNAME << 16) | 0;
        /*3325*/
        const int CefDownloadItem_IsValid_1 = (_typeNAME << 16) | 1;
        /*3326*/
        const int CefDownloadItem_IsInProgress_2 = (_typeNAME << 16) | 2;
        /*3327*/
        const int CefDownloadItem_IsComplete_3 = (_typeNAME << 16) | 3;
        /*3328*/
        const int CefDownloadItem_IsCanceled_4 = (_typeNAME << 16) | 4;
        /*3329*/
        const int CefDownloadItem_GetCurrentSpeed_5 = (_typeNAME << 16) | 5;
        /*3330*/
        const int CefDownloadItem_GetPercentComplete_6 = (_typeNAME << 16) | 6;
        /*3331*/
        const int CefDownloadItem_GetTotalBytes_7 = (_typeNAME << 16) | 7;
        /*3332*/
        const int CefDownloadItem_GetReceivedBytes_8 = (_typeNAME << 16) | 8;
        /*3333*/
        const int CefDownloadItem_GetStartTime_9 = (_typeNAME << 16) | 9;
        /*3334*/
        const int CefDownloadItem_GetEndTime_10 = (_typeNAME << 16) | 10;
        /*3335*/
        const int CefDownloadItem_GetFullPath_11 = (_typeNAME << 16) | 11;
        /*3336*/
        const int CefDownloadItem_GetId_12 = (_typeNAME << 16) | 12;
        /*3337*/
        const int CefDownloadItem_GetURL_13 = (_typeNAME << 16) | 13;
        /*3338*/
        const int CefDownloadItem_GetOriginalUrl_14 = (_typeNAME << 16) | 14;
        /*3339*/
        const int CefDownloadItem_GetSuggestedFileName_15 = (_typeNAME << 16) | 15;
        /*3340*/
        const int CefDownloadItem_GetContentDisposition_16 = (_typeNAME << 16) | 16;
        /*3341*/
        const int CefDownloadItem_GetMimeType_17 = (_typeNAME << 16) | 17;
        /*3342*/
        internal readonly IntPtr nativePtr;
        /*3343*/
        internal CefDownloadItem(IntPtr nativePtr)
        {
            /*3344*/
            this.nativePtr = nativePtr;
            /*3345*/
        }
        /*3346*/
        public void Release()
        {
            /*3347*/
            JsValue ret;
            /*3348*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_Release_0, out ret);
            /*3349*/
        }
        /// <summary>
        /// CefDownloadItem methods.
        /// </summary>
        /*3350*/


        // gen! bool IsValid()
        /*3351*/

        public bool IsValid()/*3352*/
        {
            JsValue ret;
            /*3353*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsValid_1, out ret);
            /*3354*/
            var ret_result = ret.I32 != 0;
            /*3355*/
            return ret_result;
            /*3356*/
        }
        /// <summary>
        /// Returns true if the download is in progress.
        /// /*cef()*/
        /// </summary>
        /*3357*/


        // gen! bool IsInProgress()
        /*3358*/

        public bool IsInProgress()/*3359*/
        {
            JsValue ret;
            /*3360*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsInProgress_2, out ret);
            /*3361*/
            var ret_result = ret.I32 != 0;
            /*3362*/
            return ret_result;
            /*3363*/
        }
        /// <summary>
        /// Returns true if the download is complete.
        /// /*cef()*/
        /// </summary>
        /*3364*/


        // gen! bool IsComplete()
        /*3365*/

        public bool IsComplete()/*3366*/
        {
            JsValue ret;
            /*3367*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsComplete_3, out ret);
            /*3368*/
            var ret_result = ret.I32 != 0;
            /*3369*/
            return ret_result;
            /*3370*/
        }
        /// <summary>
        /// Returns true if the download has been canceled or interrupted.
        /// /*cef()*/
        /// </summary>
        /*3371*/


        // gen! bool IsCanceled()
        /*3372*/

        public bool IsCanceled()/*3373*/
        {
            JsValue ret;
            /*3374*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsCanceled_4, out ret);
            /*3375*/
            var ret_result = ret.I32 != 0;
            /*3376*/
            return ret_result;
            /*3377*/
        }
        /// <summary>
        /// Returns a simple speed estimate in bytes/s.
        /// /*cef()*/
        /// </summary>
        /*3378*/


        // gen! int64 GetCurrentSpeed()
        /*3379*/

        public long GetCurrentSpeed()/*3380*/
        {
            JsValue ret;
            /*3381*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetCurrentSpeed_5, out ret);
            /*3382*/
            var ret_result = ret.I64;
            /*3383*/
            return ret_result;
            /*3384*/
        }
        /// <summary>
        /// Returns the rough percent complete or -1 if the receive total size is
        /// unknown.
        /// /*cef()*/
        /// </summary>
        /*3385*/


        // gen! int GetPercentComplete()
        /*3386*/

        public int GetPercentComplete()/*3387*/
        {
            JsValue ret;
            /*3388*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetPercentComplete_6, out ret);
            /*3389*/
            var ret_result = ret.I32;
            /*3390*/
            return ret_result;
            /*3391*/
        }
        /// <summary>
        /// Returns the total number of bytes.
        /// /*cef()*/
        /// </summary>
        /*3392*/


        // gen! int64 GetTotalBytes()
        /*3393*/

        public long GetTotalBytes()/*3394*/
        {
            JsValue ret;
            /*3395*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetTotalBytes_7, out ret);
            /*3396*/
            var ret_result = ret.I64;
            /*3397*/
            return ret_result;
            /*3398*/
        }
        /// <summary>
        /// Returns the number of received bytes.
        /// /*cef()*/
        /// </summary>
        /*3399*/


        // gen! int64 GetReceivedBytes()
        /*3400*/

        public long GetReceivedBytes()/*3401*/
        {
            JsValue ret;
            /*3402*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetReceivedBytes_8, out ret);
            /*3403*/
            var ret_result = ret.I64;
            /*3404*/
            return ret_result;
            /*3405*/
        }
        /// <summary>
        /// Returns the time that the download started.
        /// /*cef()*/
        /// </summary>
        /*3406*/


        // gen! CefTime GetStartTime()
        /*3407*/

        public CefTime GetStartTime()/*3408*/
        {
            JsValue ret;
            /*3409*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetStartTime_9, out ret);
            /*3410*/
            var ret_result = new CefTime(ret.Ptr);

            /*3411*/
            return ret_result;
            /*3412*/
        }
        /// <summary>
        /// Returns the time that the download ended.
        /// /*cef()*/
        /// </summary>
        /*3413*/


        // gen! CefTime GetEndTime()
        /*3414*/

        public CefTime GetEndTime()/*3415*/
        {
            JsValue ret;
            /*3416*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetEndTime_10, out ret);
            /*3417*/
            var ret_result = new CefTime(ret.Ptr);

            /*3418*/
            return ret_result;
            /*3419*/
        }
        /// <summary>
        /// Returns the full path to the downloaded or downloading file.
        /// /*cef()*/
        /// </summary>
        /*3420*/


        // gen! CefString GetFullPath()
        /*3421*/

        public string GetFullPath()/*3422*/
        {
            JsValue ret;
            /*3423*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetFullPath_11, out ret);
            /*3424*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3425*/
            return ret_result;
            /*3426*/
        }
        /// <summary>
        /// Returns the unique identifier for this download.
        /// /*cef()*/
        /// </summary>
        /*3427*/


        // gen! uint32 GetId()
        /*3428*/

        public uint GetId()/*3429*/
        {
            JsValue ret;
            /*3430*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetId_12, out ret);
            /*3431*/
            var ret_result = (uint)ret.I32;
            /*3432*/
            return ret_result;
            /*3433*/
        }
        /// <summary>
        /// Returns the URL.
        /// /*cef()*/
        /// </summary>
        /*3434*/


        // gen! CefString GetURL()
        /*3435*/

        public string GetURL()/*3436*/
        {
            JsValue ret;
            /*3437*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetURL_13, out ret);
            /*3438*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3439*/
            return ret_result;
            /*3440*/
        }
        /// <summary>
        /// Returns the original URL before any redirections.
        /// /*cef()*/
        /// </summary>
        /*3441*/


        // gen! CefString GetOriginalUrl()
        /*3442*/

        public string GetOriginalUrl()/*3443*/
        {
            JsValue ret;
            /*3444*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetOriginalUrl_14, out ret);
            /*3445*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3446*/
            return ret_result;
            /*3447*/
        }
        /// <summary>
        /// Returns the suggested file name.
        /// /*cef()*/
        /// </summary>
        /*3448*/


        // gen! CefString GetSuggestedFileName()
        /*3449*/

        public string GetSuggestedFileName()/*3450*/
        {
            JsValue ret;
            /*3451*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetSuggestedFileName_15, out ret);
            /*3452*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3453*/
            return ret_result;
            /*3454*/
        }
        /// <summary>
        /// Returns the content disposition.
        /// /*cef()*/
        /// </summary>
        /*3455*/


        // gen! CefString GetContentDisposition()
        /*3456*/

        public string GetContentDisposition()/*3457*/
        {
            JsValue ret;
            /*3458*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetContentDisposition_16, out ret);
            /*3459*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3460*/
            return ret_result;
            /*3461*/
        }
        /// <summary>
        /// Returns the mime type.
        /// /*cef()*/
        /// </summary>
        /*3462*/


        // gen! CefString GetMimeType()
        /*3463*/

        public string GetMimeType()/*3464*/
        {
            JsValue ret;
            /*3465*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetMimeType_17, out ret);
            /*3466*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3467*/
            return ret_result;
            /*3468*/
        }
        /*3469*/
    }


    // [virtual] class CefDragData
    /// <summary>
    /// Class used to represent drag data. The methods of this class may be called
    /// on any thread.
    /// /*(source=library)*/
    /// </summary>
    /*3603*/
    public struct CefDragData
    {
        /*3604*/
        const int _typeNAME = 14;
        /*3605*/
        const int CefDragData_Release_0 = (_typeNAME << 16) | 0;
        /*3606*/
        const int CefDragData_Clone_1 = (_typeNAME << 16) | 1;
        /*3607*/
        const int CefDragData_IsReadOnly_2 = (_typeNAME << 16) | 2;
        /*3608*/
        const int CefDragData_IsLink_3 = (_typeNAME << 16) | 3;
        /*3609*/
        const int CefDragData_IsFragment_4 = (_typeNAME << 16) | 4;
        /*3610*/
        const int CefDragData_IsFile_5 = (_typeNAME << 16) | 5;
        /*3611*/
        const int CefDragData_GetLinkURL_6 = (_typeNAME << 16) | 6;
        /*3612*/
        const int CefDragData_GetLinkTitle_7 = (_typeNAME << 16) | 7;
        /*3613*/
        const int CefDragData_GetLinkMetadata_8 = (_typeNAME << 16) | 8;
        /*3614*/
        const int CefDragData_GetFragmentText_9 = (_typeNAME << 16) | 9;
        /*3615*/
        const int CefDragData_GetFragmentHtml_10 = (_typeNAME << 16) | 10;
        /*3616*/
        const int CefDragData_GetFragmentBaseURL_11 = (_typeNAME << 16) | 11;
        /*3617*/
        const int CefDragData_GetFileName_12 = (_typeNAME << 16) | 12;
        /*3618*/
        const int CefDragData_GetFileContents_13 = (_typeNAME << 16) | 13;
        /*3619*/
        const int CefDragData_GetFileNames_14 = (_typeNAME << 16) | 14;
        /*3620*/
        const int CefDragData_SetLinkURL_15 = (_typeNAME << 16) | 15;
        /*3621*/
        const int CefDragData_SetLinkTitle_16 = (_typeNAME << 16) | 16;
        /*3622*/
        const int CefDragData_SetLinkMetadata_17 = (_typeNAME << 16) | 17;
        /*3623*/
        const int CefDragData_SetFragmentText_18 = (_typeNAME << 16) | 18;
        /*3624*/
        const int CefDragData_SetFragmentHtml_19 = (_typeNAME << 16) | 19;
        /*3625*/
        const int CefDragData_SetFragmentBaseURL_20 = (_typeNAME << 16) | 20;
        /*3626*/
        const int CefDragData_ResetFileContents_21 = (_typeNAME << 16) | 21;
        /*3627*/
        const int CefDragData_AddFile_22 = (_typeNAME << 16) | 22;
        /*3628*/
        const int CefDragData_GetImage_23 = (_typeNAME << 16) | 23;
        /*3629*/
        const int CefDragData_GetImageHotspot_24 = (_typeNAME << 16) | 24;
        /*3630*/
        const int CefDragData_HasImage_25 = (_typeNAME << 16) | 25;
        /*3631*/
        internal readonly IntPtr nativePtr;
        /*3632*/
        internal CefDragData(IntPtr nativePtr)
        {
            /*3633*/
            this.nativePtr = nativePtr;
            /*3634*/
        }
        /*3635*/
        public void Release()
        {
            /*3636*/
            JsValue ret;
            /*3637*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_Release_0, out ret);
            /*3638*/
        }
        /// <summary>
        /// CefDragData methods.
        /// </summary>
        /*3639*/


        // gen! CefRefPtr<CefDragData> Clone()
        /*3640*/

        public CefDragData Clone()/*3641*/
        {
            JsValue ret;
            /*3642*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_Clone_1, out ret);
            /*3643*/
            var ret_result = new CefDragData(ret.Ptr);
            /*3644*/
            return ret_result;
            /*3645*/
        }
        /// <summary>
        /// Returns true if this object is read-only.
        /// /*cef()*/
        /// </summary>
        /*3646*/


        // gen! bool IsReadOnly()
        /*3647*/

        public bool IsReadOnly()/*3648*/
        {
            JsValue ret;
            /*3649*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsReadOnly_2, out ret);
            /*3650*/
            var ret_result = ret.I32 != 0;
            /*3651*/
            return ret_result;
            /*3652*/
        }
        /// <summary>
        /// Returns true if the drag data is a link.
        /// /*cef()*/
        /// </summary>
        /*3653*/


        // gen! bool IsLink()
        /*3654*/

        public bool IsLink()/*3655*/
        {
            JsValue ret;
            /*3656*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsLink_3, out ret);
            /*3657*/
            var ret_result = ret.I32 != 0;
            /*3658*/
            return ret_result;
            /*3659*/
        }
        /// <summary>
        /// Returns true if the drag data is a text or html fragment.
        /// /*cef()*/
        /// </summary>
        /*3660*/


        // gen! bool IsFragment()
        /*3661*/

        public bool IsFragment()/*3662*/
        {
            JsValue ret;
            /*3663*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsFragment_4, out ret);
            /*3664*/
            var ret_result = ret.I32 != 0;
            /*3665*/
            return ret_result;
            /*3666*/
        }
        /// <summary>
        /// Returns true if the drag data is a file.
        /// /*cef()*/
        /// </summary>
        /*3667*/


        // gen! bool IsFile()
        /*3668*/

        public bool IsFile()/*3669*/
        {
            JsValue ret;
            /*3670*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsFile_5, out ret);
            /*3671*/
            var ret_result = ret.I32 != 0;
            /*3672*/
            return ret_result;
            /*3673*/
        }
        /// <summary>
        /// Return the link URL that is being dragged.
        /// /*cef()*/
        /// </summary>
        /*3674*/


        // gen! CefString GetLinkURL()
        /*3675*/

        public string GetLinkURL()/*3676*/
        {
            JsValue ret;
            /*3677*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkURL_6, out ret);
            /*3678*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3679*/
            return ret_result;
            /*3680*/
        }
        /// <summary>
        /// Return the title associated with the link being dragged.
        /// /*cef()*/
        /// </summary>
        /*3681*/


        // gen! CefString GetLinkTitle()
        /*3682*/

        public string GetLinkTitle()/*3683*/
        {
            JsValue ret;
            /*3684*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkTitle_7, out ret);
            /*3685*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3686*/
            return ret_result;
            /*3687*/
        }
        /// <summary>
        /// Return the metadata, if any, associated with the link being dragged.
        /// /*cef()*/
        /// </summary>
        /*3688*/


        // gen! CefString GetLinkMetadata()
        /*3689*/

        public string GetLinkMetadata()/*3690*/
        {
            JsValue ret;
            /*3691*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkMetadata_8, out ret);
            /*3692*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3693*/
            return ret_result;
            /*3694*/
        }
        /// <summary>
        /// Return the plain text fragment that is being dragged.
        /// /*cef()*/
        /// </summary>
        /*3695*/


        // gen! CefString GetFragmentText()
        /*3696*/

        public string GetFragmentText()/*3697*/
        {
            JsValue ret;
            /*3698*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentText_9, out ret);
            /*3699*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3700*/
            return ret_result;
            /*3701*/
        }
        /// <summary>
        /// Return the text/html fragment that is being dragged.
        /// /*cef()*/
        /// </summary>
        /*3702*/


        // gen! CefString GetFragmentHtml()
        /*3703*/

        public string GetFragmentHtml()/*3704*/
        {
            JsValue ret;
            /*3705*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentHtml_10, out ret);
            /*3706*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3707*/
            return ret_result;
            /*3708*/
        }
        /// <summary>
        /// Return the base URL that the fragment came from. This value is used for
        /// resolving relative URLs and may be empty.
        /// /*cef()*/
        /// </summary>
        /*3709*/


        // gen! CefString GetFragmentBaseURL()
        /*3710*/

        public string GetFragmentBaseURL()/*3711*/
        {
            JsValue ret;
            /*3712*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentBaseURL_11, out ret);
            /*3713*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3714*/
            return ret_result;
            /*3715*/
        }
        /// <summary>
        /// Return the name of the file being dragged out of the browser window.
        /// /*cef()*/
        /// </summary>
        /*3716*/


        // gen! CefString GetFileName()
        /*3717*/

        public string GetFileName()/*3718*/
        {
            JsValue ret;
            /*3719*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFileName_12, out ret);
            /*3720*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3721*/
            return ret_result;
            /*3722*/
        }
        /// <summary>
        /// Write the contents of the file being dragged out of the web view into
        /// |writer|. Returns the number of bytes sent to |writer|. If |writer| is
        /// NULL this method will return the size of the file contents in bytes.
        /// Call GetFileName() to get a suggested name for the file.
        /// /*cef(optional_param=writer)*/
        /// </summary>
        /*3723*/


        // gen! size_t GetFileContents(CefRefPtr<CefStreamWriter> writer)
        /*3724*/

        public uint GetFileContents(CefStreamWriter /*3725*/
        writer
        )/*3726*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*3727*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_GetFileContents_13, out ret, ref v1);
            /*3728*/
            var ret_result = (uint)ret.I32;
            /*3729*/
            return ret_result;
            /*3730*/
        }
        /// <summary>
        /// Retrieve the list of file names that are being dragged into the browser
        /// window.
        /// /*cef()*/
        /// </summary>
        /*3731*/


        // gen! bool GetFileNames(std::vector<CefString>& names)
        /*3732*/

        public bool GetFileNames(List<string> /*3733*/
        names
        )/*3734*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*3735*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_GetFileNames_14, out ret, ref v1);
            /*3736*/
            var ret_result = ret.I32 != 0;
            /*3737*/
            return ret_result;
            /*3738*/
        }
        /// <summary>
        /// Set the link URL that is being dragged.
        /// /*cef(optional_param=url)*/
        /// </summary>
        /*3739*/


        // gen! void SetLinkURL(const CefString& url)
        /*3740*/

        public void SetLinkURL(string /*3741*/
        url
        )/*3742*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*3743*/
            ;
            /*3744*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkURL_15, out ret, ref v1);
            /*3745*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3746*/
            ;
            /*3747*/
        }
        /// <summary>
        /// Set the title associated with the link being dragged.
        /// /*cef(optional_param=title)*/
        /// </summary>
        /*3748*/


        // gen! void SetLinkTitle(const CefString& title)
        /*3749*/

        public void SetLinkTitle(string /*3750*/
        title
        )/*3751*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(title);
            /*3752*/
            ;
            /*3753*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkTitle_16, out ret, ref v1);
            /*3754*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3755*/
            ;
            /*3756*/
        }
        /// <summary>
        /// Set the metadata associated with the link being dragged.
        /// /*cef(optional_param=data)*/
        /// </summary>
        /*3757*/


        // gen! void SetLinkMetadata(const CefString& data)
        /*3758*/

        public void SetLinkMetadata(string /*3759*/
        data
        )/*3760*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(data);
            /*3761*/
            ;
            /*3762*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkMetadata_17, out ret, ref v1);
            /*3763*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3764*/
            ;
            /*3765*/
        }
        /// <summary>
        /// Set the plain text fragment that is being dragged.
        /// /*cef(optional_param=text)*/
        /// </summary>
        /*3766*/


        // gen! void SetFragmentText(const CefString& text)
        /*3767*/

        public void SetFragmentText(string /*3768*/
        text
        )/*3769*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(text);
            /*3770*/
            ;
            /*3771*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentText_18, out ret, ref v1);
            /*3772*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3773*/
            ;
            /*3774*/
        }
        /// <summary>
        /// Set the text/html fragment that is being dragged.
        /// /*cef(optional_param=html)*/
        /// </summary>
        /*3775*/


        // gen! void SetFragmentHtml(const CefString& html)
        /*3776*/

        public void SetFragmentHtml(string /*3777*/
        html
        )/*3778*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(html);
            /*3779*/
            ;
            /*3780*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentHtml_19, out ret, ref v1);
            /*3781*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3782*/
            ;
            /*3783*/
        }
        /// <summary>
        /// Set the base URL that the fragment came from.
        /// /*cef(optional_param=base_url)*/
        /// </summary>
        /*3784*/


        // gen! void SetFragmentBaseURL(const CefString& base_url)
        /*3785*/

        public void SetFragmentBaseURL(string /*3786*/
        base_url
        )/*3787*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(base_url);
            /*3788*/
            ;
            /*3789*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentBaseURL_20, out ret, ref v1);
            /*3790*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3791*/
            ;
            /*3792*/
        }
        /// <summary>
        /// Reset the file contents. You should do this before calling
        /// CefBrowserHost::DragTargetDragEnter as the web view does not allow us to
        /// drag in this kind of data.
        /// /*cef()*/
        /// </summary>
        /*3793*/


        // gen! void ResetFileContents()
        /*3794*/

        public void ResetFileContents()/*3795*/
        {
            JsValue ret;
            /*3796*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_ResetFileContents_21, out ret);
            /*3797*/

            /*3798*/
        }
        /// <summary>
        /// Add a file that is being dragged into the webview.
        /// /*cef(optional_param=display_name)*/
        /// </summary>
        /*3799*/


        // gen! void AddFile(const CefString& path,const CefString& display_name)
        /*3800*/

        public void AddFile(string /*3801*/
        path
        , string /*3802*/
        display_name
        )/*3803*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(path);
            /*3804*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(display_name);
            /*3805*/
            ;
            /*3806*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDragData_AddFile_22, out ret, ref v1, ref v2);
            /*3807*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3808*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*3809*/
            ;
            /*3810*/
        }
        /// <summary>
        /// Get the image representation of drag data. May return NULL if no image
        /// representation is available.
        /// /*cef()*/
        /// </summary>
        /*3811*/


        // gen! CefRefPtr<CefImage> GetImage()
        /*3812*/

        public CefImage GetImage()/*3813*/
        {
            JsValue ret;
            /*3814*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetImage_23, out ret);
            /*3815*/
            var ret_result = new CefImage(ret.Ptr);
            /*3816*/
            return ret_result;
            /*3817*/
        }
        /// <summary>
        /// Get the image hotspot (drag start location relative to image dimensions).
        /// /*cef()*/
        /// </summary>
        /*3818*/


        // gen! CefPoint GetImageHotspot()
        /*3819*/

        public CefPoint GetImageHotspot()/*3820*/
        {
            JsValue ret;
            /*3821*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetImageHotspot_24, out ret);
            /*3822*/
            var ret_result = new CefPoint(ret.Ptr);

            /*3823*/
            return ret_result;
            /*3824*/
        }
        /// <summary>
        /// Returns true if an image representation of drag data is available.
        /// /*cef()*/
        /// </summary>
        /*3825*/


        // gen! bool HasImage()
        /*3826*/

        public bool HasImage()/*3827*/
        {
            JsValue ret;
            /*3828*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_HasImage_25, out ret);
            /*3829*/
            var ret_result = ret.I32 != 0;
            /*3830*/
            return ret_result;
            /*3831*/
        }
        /*3832*/
    }


    // [virtual] class CefFrame
    /// <summary>
    /// Class used to represent a frame in the browser window. When used in the
    /// browser process the methods of this class may be called on any thread unless
    /// otherwise indicated in the comments. When used in the render process the
    /// methods of this class may only be called on the main thread.
    /// /*(source=library)*/
    /// </summary>
    /*3961*/
    public struct CefFrame
    {
        /*3962*/
        const int _typeNAME = 15;
        /*3963*/
        const int CefFrame_Release_0 = (_typeNAME << 16) | 0;
        /*3964*/
        const int CefFrame_IsValid_1 = (_typeNAME << 16) | 1;
        /*3965*/
        const int CefFrame_Undo_2 = (_typeNAME << 16) | 2;
        /*3966*/
        const int CefFrame_Redo_3 = (_typeNAME << 16) | 3;
        /*3967*/
        const int CefFrame_Cut_4 = (_typeNAME << 16) | 4;
        /*3968*/
        const int CefFrame_Copy_5 = (_typeNAME << 16) | 5;
        /*3969*/
        const int CefFrame_Paste_6 = (_typeNAME << 16) | 6;
        /*3970*/
        const int CefFrame_Delete_7 = (_typeNAME << 16) | 7;
        /*3971*/
        const int CefFrame_SelectAll_8 = (_typeNAME << 16) | 8;
        /*3972*/
        const int CefFrame_ViewSource_9 = (_typeNAME << 16) | 9;
        /*3973*/
        const int CefFrame_GetSource_10 = (_typeNAME << 16) | 10;
        /*3974*/
        const int CefFrame_GetText_11 = (_typeNAME << 16) | 11;
        /*3975*/
        const int CefFrame_LoadRequest_12 = (_typeNAME << 16) | 12;
        /*3976*/
        const int CefFrame_LoadURL_13 = (_typeNAME << 16) | 13;
        /*3977*/
        const int CefFrame_LoadString_14 = (_typeNAME << 16) | 14;
        /*3978*/
        const int CefFrame_ExecuteJavaScript_15 = (_typeNAME << 16) | 15;
        /*3979*/
        const int CefFrame_IsMain_16 = (_typeNAME << 16) | 16;
        /*3980*/
        const int CefFrame_IsFocused_17 = (_typeNAME << 16) | 17;
        /*3981*/
        const int CefFrame_GetName_18 = (_typeNAME << 16) | 18;
        /*3982*/
        const int CefFrame_GetIdentifier_19 = (_typeNAME << 16) | 19;
        /*3983*/
        const int CefFrame_GetParent_20 = (_typeNAME << 16) | 20;
        /*3984*/
        const int CefFrame_GetURL_21 = (_typeNAME << 16) | 21;
        /*3985*/
        const int CefFrame_GetBrowser_22 = (_typeNAME << 16) | 22;
        /*3986*/
        const int CefFrame_GetV8Context_23 = (_typeNAME << 16) | 23;
        /*3987*/
        const int CefFrame_VisitDOM_24 = (_typeNAME << 16) | 24;
        /*3988*/
        internal readonly IntPtr nativePtr;
        /*3989*/
        internal CefFrame(IntPtr nativePtr)
        {
            /*3990*/
            this.nativePtr = nativePtr;
            /*3991*/
        }
        /*3992*/
        public void Release()
        {
            /*3993*/
            JsValue ret;
            /*3994*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Release_0, out ret);
            /*3995*/
        }
        /// <summary>
        /// CefFrame methods.
        /// </summary>
        /*3996*/


        // gen! bool IsValid()
        /*3997*/

        public bool IsValid()/*3998*/
        {
            JsValue ret;
            /*3999*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsValid_1, out ret);
            /*4000*/
            var ret_result = ret.I32 != 0;
            /*4001*/
            return ret_result;
            /*4002*/
        }
        /// <summary>
        /// Execute undo in this frame.
        /// /*cef()*/
        /// </summary>
        /*4003*/


        // gen! void Undo()
        /*4004*/

        public void Undo()/*4005*/
        {
            JsValue ret;
            /*4006*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Undo_2, out ret);
            /*4007*/

            /*4008*/
        }
        /// <summary>
        /// Execute redo in this frame.
        /// /*cef()*/
        /// </summary>
        /*4009*/


        // gen! void Redo()
        /*4010*/

        public void Redo()/*4011*/
        {
            JsValue ret;
            /*4012*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Redo_3, out ret);
            /*4013*/

            /*4014*/
        }
        /// <summary>
        /// Execute cut in this frame.
        /// /*cef()*/
        /// </summary>
        /*4015*/


        // gen! void Cut()
        /*4016*/

        public void Cut()/*4017*/
        {
            JsValue ret;
            /*4018*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Cut_4, out ret);
            /*4019*/

            /*4020*/
        }
        /// <summary>
        /// Execute copy in this frame.
        /// /*cef()*/
        /// </summary>
        /*4021*/


        // gen! void Copy()
        /*4022*/

        public void Copy()/*4023*/
        {
            JsValue ret;
            /*4024*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Copy_5, out ret);
            /*4025*/

            /*4026*/
        }
        /// <summary>
        /// Execute paste in this frame.
        /// /*cef()*/
        /// </summary>
        /*4027*/


        // gen! void Paste()
        /*4028*/

        public void Paste()/*4029*/
        {
            JsValue ret;
            /*4030*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Paste_6, out ret);
            /*4031*/

            /*4032*/
        }
        /// <summary>
        /// Execute delete in this frame.
        /// /*cef(capi_name=del)*/
        /// </summary>
        /*4033*/


        // gen! void Delete()
        /*4034*/

        public void Delete()/*4035*/
        {
            JsValue ret;
            /*4036*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Delete_7, out ret);
            /*4037*/

            /*4038*/
        }
        /// <summary>
        /// Execute select all in this frame.
        /// /*cef()*/
        /// </summary>
        /*4039*/


        // gen! void SelectAll()
        /*4040*/

        public void SelectAll()/*4041*/
        {
            JsValue ret;
            /*4042*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_SelectAll_8, out ret);
            /*4043*/

            /*4044*/
        }
        /// <summary>
        /// Save this frame's HTML source to a temporary file and open it in the
        /// default text viewing application. This method can only be called from the
        /// browser process.
        /// /*cef()*/
        /// </summary>
        /*4045*/


        // gen! void ViewSource()
        /*4046*/

        public void ViewSource()/*4047*/
        {
            JsValue ret;
            /*4048*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_ViewSource_9, out ret);
            /*4049*/

            /*4050*/
        }
        /// <summary>
        /// Retrieve this frame's HTML source as a string sent to the specified
        /// visitor.
        /// /*cef()*/
        /// </summary>
        /*4051*/


        // gen! void GetSource(CefRefPtr<CefStringVisitor> visitor)
        /*4052*/

        public void GetSource(CefStringVisitor /*4053*/
        visitor
        )/*4054*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4055*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_GetSource_10, out ret, ref v1);
            /*4056*/

            /*4057*/
        }
        /// <summary>
        /// Retrieve this frame's display text as a string sent to the specified
        /// visitor.
        /// /*cef()*/
        /// </summary>
        /*4058*/


        // gen! void GetText(CefRefPtr<CefStringVisitor> visitor)
        /*4059*/

        public void GetText(CefStringVisitor /*4060*/
        visitor
        )/*4061*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4062*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_GetText_11, out ret, ref v1);
            /*4063*/

            /*4064*/
        }
        /// <summary>
        /// Load the request represented by the |request| object.
        /// /*cef()*/
        /// </summary>
        /*4065*/


        // gen! void LoadRequest(CefRefPtr<CefRequest> request)
        /*4066*/

        public void LoadRequest(CefRequest /*4067*/
        request
        )/*4068*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4069*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_LoadRequest_12, out ret, ref v1);
            /*4070*/

            /*4071*/
        }
        /// <summary>
        /// Load the specified |url|.
        /// /*cef()*/
        /// </summary>
        /*4072*/


        // gen! void LoadURL(const CefString& url)
        /*4073*/

        public void LoadURL(string /*4074*/
        url
        )/*4075*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*4076*/
            ;
            /*4077*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_LoadURL_13, out ret, ref v1);
            /*4078*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*4079*/
            ;
            /*4080*/
        }
        /// <summary>
        /// Load the contents of |string_val| with the specified dummy |url|. |url|
        /// should have a standard scheme (for example, http scheme) or behaviors like
        /// link clicks and web security restrictions may not behave as expected.
        /// /*cef()*/
        /// </summary>
        /*4081*/


        // gen! void LoadString(const CefString& string_val,const CefString& url)
        /*4082*/

        public void LoadString(string /*4083*/
        string_val
        , string /*4084*/
        url
        )/*4085*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(string_val);
            /*4086*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*4087*/
            ;
            /*4088*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefFrame_LoadString_14, out ret, ref v1, ref v2);
            /*4089*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*4090*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4091*/
            ;
            /*4092*/
        }
        /// <summary>
        /// Execute a string of JavaScript code in this frame. The |script_url|
        /// parameter is the URL where the script in question can be found, if any.
        /// The renderer may request this URL to show the developer the source of the
        /// error.  The |start_line| parameter is the base line number to use for error
        /// reporting.
        /// /*cef(optional_param=script_url)*/
        /// </summary>
        /*4093*/


        // gen! void ExecuteJavaScript(const CefString& code,const CefString& script_url,int start_line)
        /*4094*/

        public void ExecuteJavaScript(string /*4095*/
        code
        , string /*4096*/
        script_url
        , int /*4097*/
        start_line
        )/*4098*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(code);
            /*4099*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(script_url);
            /*4100*/
            ;
            /*4101*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefFrame_ExecuteJavaScript_15, out ret, ref v1, ref v2, ref v3);
            /*4102*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*4103*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4104*/
            ;
            /*4105*/
        }
        /// <summary>
        /// Returns true if this is the main (top-level) frame.
        /// /*cef()*/
        /// </summary>
        /*4106*/


        // gen! bool IsMain()
        /*4107*/

        public bool IsMain()/*4108*/
        {
            JsValue ret;
            /*4109*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsMain_16, out ret);
            /*4110*/
            var ret_result = ret.I32 != 0;
            /*4111*/
            return ret_result;
            /*4112*/
        }
        /// <summary>
        /// Returns true if this is the focused frame.
        /// /*cef()*/
        /// </summary>
        /*4113*/


        // gen! bool IsFocused()
        /*4114*/

        public bool IsFocused()/*4115*/
        {
            JsValue ret;
            /*4116*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsFocused_17, out ret);
            /*4117*/
            var ret_result = ret.I32 != 0;
            /*4118*/
            return ret_result;
            /*4119*/
        }
        /// <summary>
        /// Returns the name for this frame. If the frame has an assigned name (for
        /// example, set via the iframe "name" attribute) then that value will be
        /// returned. Otherwise a unique name will be constructed based on the frame
        /// parent hierarchy. The main (top-level) frame will always have an empty name
        /// value.
        /// /*cef()*/
        /// </summary>
        /*4120*/


        // gen! CefString GetName()
        /*4121*/

        public string GetName()/*4122*/
        {
            JsValue ret;
            /*4123*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetName_18, out ret);
            /*4124*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*4125*/
            return ret_result;
            /*4126*/
        }
        /// <summary>
        /// Returns the globally unique identifier for this frame or < 0 if the
        /// underlying frame does not yet exist.
        /// /*cef()*/
        /// </summary>
        /*4127*/


        // gen! int64 GetIdentifier()
        /*4128*/

        public long GetIdentifier()/*4129*/
        {
            JsValue ret;
            /*4130*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetIdentifier_19, out ret);
            /*4131*/
            var ret_result = ret.I64;
            /*4132*/
            return ret_result;
            /*4133*/
        }
        /// <summary>
        /// Returns the parent of this frame or NULL if this is the main (top-level)
        /// frame.
        /// /*cef()*/
        /// </summary>
        /*4134*/


        // gen! CefRefPtr<CefFrame> GetParent()
        /*4135*/

        public CefFrame GetParent()/*4136*/
        {
            JsValue ret;
            /*4137*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetParent_20, out ret);
            /*4138*/
            var ret_result = new CefFrame(ret.Ptr);
            /*4139*/
            return ret_result;
            /*4140*/
        }
        /// <summary>
        /// Returns the URL currently loaded in this frame.
        /// /*cef()*/
        /// </summary>
        /*4141*/


        // gen! CefString GetURL()
        /*4142*/

        public string GetURL()/*4143*/
        {
            JsValue ret;
            /*4144*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetURL_21, out ret);
            /*4145*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*4146*/
            return ret_result;
            /*4147*/
        }
        /// <summary>
        /// Returns the browser that this frame belongs to.
        /// /*cef()*/
        /// </summary>
        /*4148*/


        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /*4149*/

        public CefBrowser GetBrowser()/*4150*/
        {
            JsValue ret;
            /*4151*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetBrowser_22, out ret);
            /*4152*/
            var ret_result = new CefBrowser(ret.Ptr);
            /*4153*/
            return ret_result;
            /*4154*/
        }
        /// <summary>
        /// Get the V8 context associated with the frame. This method can only be
        /// called from the render process.
        /// /*cef()*/
        /// </summary>
        /*4155*/


        // gen! CefRefPtr<CefV8Context> GetV8Context()
        /*4156*/

        public CefV8Context GetV8Context()/*4157*/
        {
            JsValue ret;
            /*4158*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetV8Context_23, out ret);
            /*4159*/
            var ret_result = new CefV8Context(ret.Ptr);
            /*4160*/
            return ret_result;
            /*4161*/
        }
        /// <summary>
        /// Visit the DOM document. This method can only be called from the render
        /// process.
        /// /*cef()*/
        /// </summary>
        /*4162*/


        // gen! void VisitDOM(CefRefPtr<CefDOMVisitor> visitor)
        /*4163*/

        public void VisitDOM(CefDOMVisitor /*4164*/
        visitor
        )/*4165*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4166*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_VisitDOM_24, out ret, ref v1);
            /*4167*/

            /*4168*/
        }
        /*4169*/
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
    /*4243*/
    public struct CefImage
    {
        /*4244*/
        const int _typeNAME = 16;
        /*4245*/
        const int CefImage_Release_0 = (_typeNAME << 16) | 0;
        /*4246*/
        const int CefImage_IsEmpty_1 = (_typeNAME << 16) | 1;
        /*4247*/
        const int CefImage_IsSame_2 = (_typeNAME << 16) | 2;
        /*4248*/
        const int CefImage_AddBitmap_3 = (_typeNAME << 16) | 3;
        /*4249*/
        const int CefImage_AddPNG_4 = (_typeNAME << 16) | 4;
        /*4250*/
        const int CefImage_AddJPEG_5 = (_typeNAME << 16) | 5;
        /*4251*/
        const int CefImage_GetWidth_6 = (_typeNAME << 16) | 6;
        /*4252*/
        const int CefImage_GetHeight_7 = (_typeNAME << 16) | 7;
        /*4253*/
        const int CefImage_HasRepresentation_8 = (_typeNAME << 16) | 8;
        /*4254*/
        const int CefImage_RemoveRepresentation_9 = (_typeNAME << 16) | 9;
        /*4255*/
        const int CefImage_GetRepresentationInfo_10 = (_typeNAME << 16) | 10;
        /*4256*/
        const int CefImage_GetAsBitmap_11 = (_typeNAME << 16) | 11;
        /*4257*/
        const int CefImage_GetAsPNG_12 = (_typeNAME << 16) | 12;
        /*4258*/
        const int CefImage_GetAsJPEG_13 = (_typeNAME << 16) | 13;
        /*4259*/
        internal readonly IntPtr nativePtr;
        /*4260*/
        internal CefImage(IntPtr nativePtr)
        {
            /*4261*/
            this.nativePtr = nativePtr;
            /*4262*/
        }
        /*4263*/
        public void Release()
        {
            /*4264*/
            JsValue ret;
            /*4265*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_Release_0, out ret);
            /*4266*/
        }
        /// <summary>
        /// CefImage methods.
        /// </summary>
        /*4267*/


        // gen! bool IsEmpty()
        /*4268*/

        public bool IsEmpty()/*4269*/
        {
            JsValue ret;
            /*4270*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_IsEmpty_1, out ret);
            /*4271*/
            var ret_result = ret.I32 != 0;
            /*4272*/
            return ret_result;
            /*4273*/
        }
        /// <summary>
        /// Returns true if this Image and |that| Image share the same underlying
        /// storage. Will also return true if both images are empty.
        /// /*cef()*/
        /// </summary>
        /*4274*/


        // gen! bool IsSame(CefRefPtr<CefImage> that)
        /*4275*/

        public bool IsSame(CefImage /*4276*/
        that
        )/*4277*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4278*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_IsSame_2, out ret, ref v1);
            /*4279*/
            var ret_result = ret.I32 != 0;
            /*4280*/
            return ret_result;
            /*4281*/
        }
        /// <summary>
        /// Add a bitmap image representation for |scale_factor|. Only 32-bit RGBA/BGRA
        /// formats are supported. |pixel_width| and |pixel_height| are the bitmap
        /// representation size in pixel coordinates. |pixel_data| is the array of
        /// pixel data and should be |pixel_width| x |pixel_height| x 4 bytes in size.
        /// |color_type| and |alpha_type| values specify the pixel format.
        /// /*cef()*/
        /// </summary>
        /*4282*/


        // gen! bool AddBitmap(float scale_factor,int pixel_width,int pixel_height,cef_color_type_t color_type,cef_alpha_type_t alpha_type,const void* pixel_data,size_t pixel_data_size)
        /*4283*/

        public bool AddBitmap(float /*4284*/
        scale_factor
        , int /*4285*/
        pixel_width
        , int /*4286*/
        pixel_height
        , cef_color_type_t /*4287*/
        color_type
        , cef_alpha_type_t /*4288*/
        alpha_type
        , IntPtr /*4289*/
        pixel_data
        , uint /*4290*/
        pixel_data_size
        )/*4291*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue v6 = new JsValue();
            JsValue v7 = new JsValue();
            JsValue ret;
            /*4292*/

            Cef3Binder.MyCefMet_Call7(this.nativePtr, CefImage_AddBitmap_3, out ret, ref v1, ref v2, ref v3, ref v4, ref v5, ref v6, ref v7);
            /*4293*/
            var ret_result = ret.I32 != 0;
            /*4294*/
            return ret_result;
            /*4295*/
        }
        /// <summary>
        /// Add a PNG image representation for |scale_factor|. |png_data| is the image
        /// data of size |png_data_size|. Any alpha transparency in the PNG data will
        /// be maintained.
        /// /*cef()*/
        /// </summary>
        /*4296*/


        // gen! bool AddPNG(float scale_factor,const void* png_data,size_t png_data_size)
        /*4297*/

        public bool AddPNG(float /*4298*/
        scale_factor
        , IntPtr /*4299*/
        png_data
        , uint /*4300*/
        png_data_size
        )/*4301*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*4302*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefImage_AddPNG_4, out ret, ref v1, ref v2, ref v3);
            /*4303*/
            var ret_result = ret.I32 != 0;
            /*4304*/
            return ret_result;
            /*4305*/
        }
        /// <summary>
        /// Create a JPEG image representation for |scale_factor|. |jpeg_data| is the
        /// image data of size |jpeg_data_size|. The JPEG format does not support
        /// transparency so the alpha byte will be set to 0xFF for all pixels.
        /// /*cef()*/
        /// </summary>
        /*4306*/


        // gen! bool AddJPEG(float scale_factor,const void* jpeg_data,size_t jpeg_data_size)
        /*4307*/

        public bool AddJPEG(float /*4308*/
        scale_factor
        , IntPtr /*4309*/
        jpeg_data
        , uint /*4310*/
        jpeg_data_size
        )/*4311*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*4312*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefImage_AddJPEG_5, out ret, ref v1, ref v2, ref v3);
            /*4313*/
            var ret_result = ret.I32 != 0;
            /*4314*/
            return ret_result;
            /*4315*/
        }
        /// <summary>
        /// Returns the image width in density independent pixel (DIP) units.
        /// /*cef()*/
        /// </summary>
        /*4316*/


        // gen! size_t GetWidth()
        /*4317*/

        public uint GetWidth()/*4318*/
        {
            JsValue ret;
            /*4319*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_GetWidth_6, out ret);
            /*4320*/
            var ret_result = (uint)ret.I32;
            /*4321*/
            return ret_result;
            /*4322*/
        }
        /// <summary>
        /// Returns the image height in density independent pixel (DIP) units.
        /// /*cef()*/
        /// </summary>
        /*4323*/


        // gen! size_t GetHeight()
        /*4324*/

        public uint GetHeight()/*4325*/
        {
            JsValue ret;
            /*4326*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_GetHeight_7, out ret);
            /*4327*/
            var ret_result = (uint)ret.I32;
            /*4328*/
            return ret_result;
            /*4329*/
        }
        /// <summary>
        /// Returns true if this image contains a representation for |scale_factor|.
        /// /*cef()*/
        /// </summary>
        /*4330*/


        // gen! bool HasRepresentation(float scale_factor)
        /*4331*/

        public bool HasRepresentation(float /*4332*/
        scale_factor
        )/*4333*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4334*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_HasRepresentation_8, out ret, ref v1);
            /*4335*/
            var ret_result = ret.I32 != 0;
            /*4336*/
            return ret_result;
            /*4337*/
        }
        /// <summary>
        /// Removes the representation for |scale_factor|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4338*/


        // gen! bool RemoveRepresentation(float scale_factor)
        /*4339*/

        public bool RemoveRepresentation(float /*4340*/
        scale_factor
        )/*4341*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4342*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_RemoveRepresentation_9, out ret, ref v1);
            /*4343*/
            var ret_result = ret.I32 != 0;
            /*4344*/
            return ret_result;
            /*4345*/
        }
        /// <summary>
        /// Returns information for the representation that most closely matches
        /// |scale_factor|. |actual_scale_factor| is the actual scale factor for the
        /// representation. |pixel_width| and |pixel_height| are the representation
        /// size in pixel coordinates. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4346*/


        // gen! bool GetRepresentationInfo(float scale_factor,float& actual_scale_factor,int& pixel_width,int& pixel_height)
        /*4347*/

        public bool GetRepresentationInfo(float /*4348*/
        scale_factor
        , ref float /*4349*/
        actual_scale_factor
        , ref int /*4350*/
        pixel_width
        , ref int /*4351*/
        pixel_height
        )/*4352*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            /*4353*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetRepresentationInfo_10, out ret, ref v1, ref v2, ref v3, ref v4);
            /*4354*/
            var ret_result = ret.I32 != 0;
            actual_scale_factor = (float)v2.Num;/*4355*/
            ;
            pixel_width = (int)v3.I32;/*4356*/
            ;
            pixel_height = (int)v4.I32;/*4357*/
            ;
            /*4358*/
            return ret_result;
            /*4359*/
        }
        /// <summary>
        /// Returns the bitmap representation that most closely matches |scale_factor|.
        /// Only 32-bit RGBA/BGRA formats are supported. |color_type| and |alpha_type|
        /// values specify the desired output pixel format. |pixel_width| and
        /// |pixel_height| are the output representation size in pixel coordinates.
        /// Returns a CefBinaryValue containing the pixel data on success or NULL on
        /// failure.
        /// /*cef()*/
        /// </summary>
        /*4360*/


        // gen! CefRefPtr<CefBinaryValue> GetAsBitmap(float scale_factor,cef_color_type_t color_type,cef_alpha_type_t alpha_type,int& pixel_width,int& pixel_height)
        /*4361*/

        public CefBinaryValue GetAsBitmap(float /*4362*/
        scale_factor
        , cef_color_type_t /*4363*/
        color_type
        , cef_alpha_type_t /*4364*/
        alpha_type
        , ref int /*4365*/
        pixel_width
        , ref int /*4366*/
        pixel_height
        )/*4367*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            /*4368*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefImage_GetAsBitmap_11, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*4369*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            pixel_width = (int)v4.I32;/*4370*/
            ;
            pixel_height = (int)v5.I32;/*4371*/
            ;
            /*4372*/
            return ret_result;
            /*4373*/
        }
        /// <summary>
        /// Returns the PNG representation that most closely matches |scale_factor|. If
        /// |with_transparency| is true any alpha transparency in the image will be
        /// represented in the resulting PNG data. |pixel_width| and |pixel_height| are
        /// the output representation size in pixel coordinates. Returns a
        /// CefBinaryValue containing the PNG image data on success or NULL on failure.
        /// /*cef()*/
        /// </summary>
        /*4374*/


        // gen! CefRefPtr<CefBinaryValue> GetAsPNG(float scale_factor,bool with_transparency,int& pixel_width,int& pixel_height)
        /*4375*/

        public CefBinaryValue GetAsPNG(float /*4376*/
        scale_factor
        , bool /*4377*/
        with_transparency
        , ref int /*4378*/
        pixel_width
        , ref int /*4379*/
        pixel_height
        )/*4380*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            /*4381*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetAsPNG_12, out ret, ref v1, ref v2, ref v3, ref v4);
            /*4382*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            pixel_width = (int)v3.I32;/*4383*/
            ;
            pixel_height = (int)v4.I32;/*4384*/
            ;
            /*4385*/
            return ret_result;
            /*4386*/
        }
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
        /*4387*/


        // gen! CefRefPtr<CefBinaryValue> GetAsJPEG(float scale_factor,int quality,int& pixel_width,int& pixel_height)
        /*4388*/

        public CefBinaryValue GetAsJPEG(float /*4389*/
        scale_factor
        , int /*4390*/
        quality
        , ref int /*4391*/
        pixel_width
        , ref int /*4392*/
        pixel_height
        )/*4393*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            /*4394*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetAsJPEG_13, out ret, ref v1, ref v2, ref v3, ref v4);
            /*4395*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            pixel_width = (int)v3.I32;/*4396*/
            ;
            pixel_height = (int)v4.I32;/*4397*/
            ;
            /*4398*/
            return ret_result;
            /*4399*/
        }
        /*4400*/
    }


    // [virtual] class CefMenuModel
    /// <summary>
    /// Supports creation and modification of menus. See cef_menu_id_t for the
    /// command ids that have default implementations. All user-defined command ids
    /// should be between MENU_ID_USER_FIRST and MENU_ID_USER_LAST. The methods of
    /// this class can only be accessed on the browser process the UI thread.
    /// /*(source=library)*/
    /// </summary>
    /*4689*/
    public struct CefMenuModel
    {
        /*4690*/
        const int _typeNAME = 17;
        /*4691*/
        const int CefMenuModel_Release_0 = (_typeNAME << 16) | 0;
        /*4692*/
        const int CefMenuModel_IsSubMenu_1 = (_typeNAME << 16) | 1;
        /*4693*/
        const int CefMenuModel_Clear_2 = (_typeNAME << 16) | 2;
        /*4694*/
        const int CefMenuModel_GetCount_3 = (_typeNAME << 16) | 3;
        /*4695*/
        const int CefMenuModel_AddSeparator_4 = (_typeNAME << 16) | 4;
        /*4696*/
        const int CefMenuModel_AddItem_5 = (_typeNAME << 16) | 5;
        /*4697*/
        const int CefMenuModel_AddCheckItem_6 = (_typeNAME << 16) | 6;
        /*4698*/
        const int CefMenuModel_AddRadioItem_7 = (_typeNAME << 16) | 7;
        /*4699*/
        const int CefMenuModel_AddSubMenu_8 = (_typeNAME << 16) | 8;
        /*4700*/
        const int CefMenuModel_InsertSeparatorAt_9 = (_typeNAME << 16) | 9;
        /*4701*/
        const int CefMenuModel_InsertItemAt_10 = (_typeNAME << 16) | 10;
        /*4702*/
        const int CefMenuModel_InsertCheckItemAt_11 = (_typeNAME << 16) | 11;
        /*4703*/
        const int CefMenuModel_InsertRadioItemAt_12 = (_typeNAME << 16) | 12;
        /*4704*/
        const int CefMenuModel_InsertSubMenuAt_13 = (_typeNAME << 16) | 13;
        /*4705*/
        const int CefMenuModel_Remove_14 = (_typeNAME << 16) | 14;
        /*4706*/
        const int CefMenuModel_RemoveAt_15 = (_typeNAME << 16) | 15;
        /*4707*/
        const int CefMenuModel_GetIndexOf_16 = (_typeNAME << 16) | 16;
        /*4708*/
        const int CefMenuModel_GetCommandIdAt_17 = (_typeNAME << 16) | 17;
        /*4709*/
        const int CefMenuModel_SetCommandIdAt_18 = (_typeNAME << 16) | 18;
        /*4710*/
        const int CefMenuModel_GetLabel_19 = (_typeNAME << 16) | 19;
        /*4711*/
        const int CefMenuModel_GetLabelAt_20 = (_typeNAME << 16) | 20;
        /*4712*/
        const int CefMenuModel_SetLabel_21 = (_typeNAME << 16) | 21;
        /*4713*/
        const int CefMenuModel_SetLabelAt_22 = (_typeNAME << 16) | 22;
        /*4714*/
        const int CefMenuModel_GetType_23 = (_typeNAME << 16) | 23;
        /*4715*/
        const int CefMenuModel_GetTypeAt_24 = (_typeNAME << 16) | 24;
        /*4716*/
        const int CefMenuModel_GetGroupId_25 = (_typeNAME << 16) | 25;
        /*4717*/
        const int CefMenuModel_GetGroupIdAt_26 = (_typeNAME << 16) | 26;
        /*4718*/
        const int CefMenuModel_SetGroupId_27 = (_typeNAME << 16) | 27;
        /*4719*/
        const int CefMenuModel_SetGroupIdAt_28 = (_typeNAME << 16) | 28;
        /*4720*/
        const int CefMenuModel_GetSubMenu_29 = (_typeNAME << 16) | 29;
        /*4721*/
        const int CefMenuModel_GetSubMenuAt_30 = (_typeNAME << 16) | 30;
        /*4722*/
        const int CefMenuModel_IsVisible_31 = (_typeNAME << 16) | 31;
        /*4723*/
        const int CefMenuModel_IsVisibleAt_32 = (_typeNAME << 16) | 32;
        /*4724*/
        const int CefMenuModel_SetVisible_33 = (_typeNAME << 16) | 33;
        /*4725*/
        const int CefMenuModel_SetVisibleAt_34 = (_typeNAME << 16) | 34;
        /*4726*/
        const int CefMenuModel_IsEnabled_35 = (_typeNAME << 16) | 35;
        /*4727*/
        const int CefMenuModel_IsEnabledAt_36 = (_typeNAME << 16) | 36;
        /*4728*/
        const int CefMenuModel_SetEnabled_37 = (_typeNAME << 16) | 37;
        /*4729*/
        const int CefMenuModel_SetEnabledAt_38 = (_typeNAME << 16) | 38;
        /*4730*/
        const int CefMenuModel_IsChecked_39 = (_typeNAME << 16) | 39;
        /*4731*/
        const int CefMenuModel_IsCheckedAt_40 = (_typeNAME << 16) | 40;
        /*4732*/
        const int CefMenuModel_SetChecked_41 = (_typeNAME << 16) | 41;
        /*4733*/
        const int CefMenuModel_SetCheckedAt_42 = (_typeNAME << 16) | 42;
        /*4734*/
        const int CefMenuModel_HasAccelerator_43 = (_typeNAME << 16) | 43;
        /*4735*/
        const int CefMenuModel_HasAcceleratorAt_44 = (_typeNAME << 16) | 44;
        /*4736*/
        const int CefMenuModel_SetAccelerator_45 = (_typeNAME << 16) | 45;
        /*4737*/
        const int CefMenuModel_SetAcceleratorAt_46 = (_typeNAME << 16) | 46;
        /*4738*/
        const int CefMenuModel_RemoveAccelerator_47 = (_typeNAME << 16) | 47;
        /*4739*/
        const int CefMenuModel_RemoveAcceleratorAt_48 = (_typeNAME << 16) | 48;
        /*4740*/
        const int CefMenuModel_GetAccelerator_49 = (_typeNAME << 16) | 49;
        /*4741*/
        const int CefMenuModel_GetAcceleratorAt_50 = (_typeNAME << 16) | 50;
        /*4742*/
        const int CefMenuModel_SetColor_51 = (_typeNAME << 16) | 51;
        /*4743*/
        const int CefMenuModel_SetColorAt_52 = (_typeNAME << 16) | 52;
        /*4744*/
        const int CefMenuModel_GetColor_53 = (_typeNAME << 16) | 53;
        /*4745*/
        const int CefMenuModel_GetColorAt_54 = (_typeNAME << 16) | 54;
        /*4746*/
        const int CefMenuModel_SetFontList_55 = (_typeNAME << 16) | 55;
        /*4747*/
        const int CefMenuModel_SetFontListAt_56 = (_typeNAME << 16) | 56;
        /*4748*/
        internal readonly IntPtr nativePtr;
        /*4749*/
        internal CefMenuModel(IntPtr nativePtr)
        {
            /*4750*/
            this.nativePtr = nativePtr;
            /*4751*/
        }
        /*4752*/
        public void Release()
        {
            /*4753*/
            JsValue ret;
            /*4754*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_Release_0, out ret);
            /*4755*/
        }
        /// <summary>
        /// CefMenuModel methods.
        /// </summary>
        /*4756*/


        // gen! bool IsSubMenu()
        /*4757*/

        public bool IsSubMenu()/*4758*/
        {
            JsValue ret;
            /*4759*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_IsSubMenu_1, out ret);
            /*4760*/
            var ret_result = ret.I32 != 0;
            /*4761*/
            return ret_result;
            /*4762*/
        }
        /// <summary>
        /// Clears the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4763*/


        // gen! bool Clear()
        /*4764*/

        public bool Clear()/*4765*/
        {
            JsValue ret;
            /*4766*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_Clear_2, out ret);
            /*4767*/
            var ret_result = ret.I32 != 0;
            /*4768*/
            return ret_result;
            /*4769*/
        }
        /// <summary>
        /// Returns the number of items in this menu.
        /// /*cef()*/
        /// </summary>
        /*4770*/


        // gen! int GetCount()
        /*4771*/

        public int GetCount()/*4772*/
        {
            JsValue ret;
            /*4773*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_GetCount_3, out ret);
            /*4774*/
            var ret_result = ret.I32;
            /*4775*/
            return ret_result;
            /*4776*/
        }
        /// <summary>
        /// Add a separator to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4777*/


        // gen! bool AddSeparator()
        /*4778*/

        public bool AddSeparator()/*4779*/
        {
            JsValue ret;
            /*4780*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_AddSeparator_4, out ret);
            /*4781*/
            var ret_result = ret.I32 != 0;
            /*4782*/
            return ret_result;
            /*4783*/
        }
        /// <summary>
        /// Add an item to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4784*/


        // gen! bool AddItem(int command_id,const CefString& label)
        /*4785*/

        public bool AddItem(int /*4786*/
        command_id
        , string /*4787*/
        label
        )/*4788*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4789*/
            ;
            /*4790*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddItem_5, out ret, ref v1, ref v2);
            /*4791*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4792*/
            ;
            /*4793*/
            return ret_result;
            /*4794*/
        }
        /// <summary>
        /// Add a check item to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4795*/


        // gen! bool AddCheckItem(int command_id,const CefString& label)
        /*4796*/

        public bool AddCheckItem(int /*4797*/
        command_id
        , string /*4798*/
        label
        )/*4799*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4800*/
            ;
            /*4801*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddCheckItem_6, out ret, ref v1, ref v2);
            /*4802*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4803*/
            ;
            /*4804*/
            return ret_result;
            /*4805*/
        }
        /// <summary>
        /// Add a radio item to the menu. Only a single item with the specified
        /// |group_id| can be checked at a time. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4806*/


        // gen! bool AddRadioItem(int command_id,const CefString& label,int group_id)
        /*4807*/

        public bool AddRadioItem(int /*4808*/
        command_id
        , string /*4809*/
        label
        , int /*4810*/
        group_id
        )/*4811*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4812*/
            ;
            /*4813*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_AddRadioItem_7, out ret, ref v1, ref v2, ref v3);
            /*4814*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4815*/
            ;
            /*4816*/
            return ret_result;
            /*4817*/
        }
        /// <summary>
        /// Add a sub-menu to the menu. The new sub-menu is returned.
        /// /*cef()*/
        /// </summary>
        /*4818*/


        // gen! CefRefPtr<CefMenuModel> AddSubMenu(int command_id,const CefString& label)
        /*4819*/

        public CefMenuModel AddSubMenu(int /*4820*/
        command_id
        , string /*4821*/
        label
        )/*4822*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4823*/
            ;
            /*4824*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddSubMenu_8, out ret, ref v1, ref v2);
            /*4825*/
            var ret_result = new CefMenuModel(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4826*/
            ;
            /*4827*/
            return ret_result;
            /*4828*/
        }
        /// <summary>
        /// Insert a separator in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4829*/


        // gen! bool InsertSeparatorAt(int index)
        /*4830*/

        public bool InsertSeparatorAt(int /*4831*/
        index
        )/*4832*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4833*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_InsertSeparatorAt_9, out ret, ref v1);
            /*4834*/
            var ret_result = ret.I32 != 0;
            /*4835*/
            return ret_result;
            /*4836*/
        }
        /// <summary>
        /// Insert an item in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4837*/


        // gen! bool InsertItemAt(int index,int command_id,const CefString& label)
        /*4838*/

        public bool InsertItemAt(int /*4839*/
        index
        , int /*4840*/
        command_id
        , string /*4841*/
        label
        )/*4842*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4843*/
            ;
            /*4844*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertItemAt_10, out ret, ref v1, ref v2, ref v3);
            /*4845*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*4846*/
            ;
            /*4847*/
            return ret_result;
            /*4848*/
        }
        /// <summary>
        /// Insert a check item in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4849*/


        // gen! bool InsertCheckItemAt(int index,int command_id,const CefString& label)
        /*4850*/

        public bool InsertCheckItemAt(int /*4851*/
        index
        , int /*4852*/
        command_id
        , string /*4853*/
        label
        )/*4854*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4855*/
            ;
            /*4856*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertCheckItemAt_11, out ret, ref v1, ref v2, ref v3);
            /*4857*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*4858*/
            ;
            /*4859*/
            return ret_result;
            /*4860*/
        }
        /// <summary>
        /// Insert a radio item in the menu at the specified |index|. Only a single
        /// item with the specified |group_id| can be checked at a time. Returns true
        /// on success.
        /// /*cef()*/
        /// </summary>
        /*4861*/


        // gen! bool InsertRadioItemAt(int index,int command_id,const CefString& label,int group_id)
        /*4862*/

        public bool InsertRadioItemAt(int /*4863*/
        index
        , int /*4864*/
        command_id
        , string /*4865*/
        label
        , int /*4866*/
        group_id
        )/*4867*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4868*/
            ;
            /*4869*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefMenuModel_InsertRadioItemAt_12, out ret, ref v1, ref v2, ref v3, ref v4);
            /*4870*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*4871*/
            ;
            /*4872*/
            return ret_result;
            /*4873*/
        }
        /// <summary>
        /// Insert a sub-menu in the menu at the specified |index|. The new sub-menu
        /// is returned.
        /// /*cef()*/
        /// </summary>
        /*4874*/


        // gen! CefRefPtr<CefMenuModel> InsertSubMenuAt(int index,int command_id,const CefString& label)
        /*4875*/

        public CefMenuModel InsertSubMenuAt(int /*4876*/
        index
        , int /*4877*/
        command_id
        , string /*4878*/
        label
        )/*4879*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4880*/
            ;
            /*4881*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertSubMenuAt_13, out ret, ref v1, ref v2, ref v3);
            /*4882*/
            var ret_result = new CefMenuModel(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*4883*/
            ;
            /*4884*/
            return ret_result;
            /*4885*/
        }
        /// <summary>
        /// Removes the item with the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4886*/


        // gen! bool Remove(int command_id)
        /*4887*/

        public bool Remove(int /*4888*/
        command_id
        )/*4889*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4890*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_Remove_14, out ret, ref v1);
            /*4891*/
            var ret_result = ret.I32 != 0;
            /*4892*/
            return ret_result;
            /*4893*/
        }
        /// <summary>
        /// Removes the item at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4894*/


        // gen! bool RemoveAt(int index)
        /*4895*/

        public bool RemoveAt(int /*4896*/
        index
        )/*4897*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4898*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAt_15, out ret, ref v1);
            /*4899*/
            var ret_result = ret.I32 != 0;
            /*4900*/
            return ret_result;
            /*4901*/
        }
        /// <summary>
        /// Returns the index associated with the specified |command_id| or -1 if not
        /// found due to the command id not existing in the menu.
        /// /*cef()*/
        /// </summary>
        /*4902*/


        // gen! int GetIndexOf(int command_id)
        /*4903*/

        public int GetIndexOf(int /*4904*/
        command_id
        )/*4905*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4906*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetIndexOf_16, out ret, ref v1);
            /*4907*/
            var ret_result = ret.I32;
            /*4908*/
            return ret_result;
            /*4909*/
        }
        /// <summary>
        /// Returns the command id at the specified |index| or -1 if not found due to
        /// invalid range or the index being a separator.
        /// /*cef()*/
        /// </summary>
        /*4910*/


        // gen! int GetCommandIdAt(int index)
        /*4911*/

        public int GetCommandIdAt(int /*4912*/
        index
        )/*4913*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4914*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetCommandIdAt_17, out ret, ref v1);
            /*4915*/
            var ret_result = ret.I32;
            /*4916*/
            return ret_result;
            /*4917*/
        }
        /// <summary>
        /// Sets the command id at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4918*/


        // gen! bool SetCommandIdAt(int index,int command_id)
        /*4919*/

        public bool SetCommandIdAt(int /*4920*/
        index
        , int /*4921*/
        command_id
        )/*4922*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*4923*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetCommandIdAt_18, out ret, ref v1, ref v2);
            /*4924*/
            var ret_result = ret.I32 != 0;
            /*4925*/
            return ret_result;
            /*4926*/
        }
        /// <summary>
        /// Returns the label for the specified |command_id| or empty if not found.
        /// /*cef()*/
        /// </summary>
        /*4927*/


        // gen! CefString GetLabel(int command_id)
        /*4928*/

        public string GetLabel(int /*4929*/
        command_id
        )/*4930*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4931*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetLabel_19, out ret, ref v1);
            /*4932*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*4933*/
            return ret_result;
            /*4934*/
        }
        /// <summary>
        /// Returns the label at the specified |index| or empty if not found due to
        /// invalid range or the index being a separator.
        /// /*cef()*/
        /// </summary>
        /*4935*/


        // gen! CefString GetLabelAt(int index)
        /*4936*/

        public string GetLabelAt(int /*4937*/
        index
        )/*4938*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4939*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetLabelAt_20, out ret, ref v1);
            /*4940*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*4941*/
            return ret_result;
            /*4942*/
        }
        /// <summary>
        /// Sets the label for the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4943*/


        // gen! bool SetLabel(int command_id,const CefString& label)
        /*4944*/

        public bool SetLabel(int /*4945*/
        command_id
        , string /*4946*/
        label
        )/*4947*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4948*/
            ;
            /*4949*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetLabel_21, out ret, ref v1, ref v2);
            /*4950*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4951*/
            ;
            /*4952*/
            return ret_result;
            /*4953*/
        }
        /// <summary>
        /// Set the label at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4954*/


        // gen! bool SetLabelAt(int index,const CefString& label)
        /*4955*/

        public bool SetLabelAt(int /*4956*/
        index
        , string /*4957*/
        label
        )/*4958*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4959*/
            ;
            /*4960*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetLabelAt_22, out ret, ref v1, ref v2);
            /*4961*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4962*/
            ;
            /*4963*/
            return ret_result;
            /*4964*/
        }
        /// <summary>
        /// Returns the item type for the specified |command_id|.
        /// /*cef(default_retval=MENUITEMTYPE_NONE)*/
        /// </summary>
        /*4965*/


        // gen! MenuItemType GetType(int command_id)
        /*4966*/

        public cef_menu_item_type_t _GetType(int /*4967*/
        command_id
        )/*4968*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4969*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetType_23, out ret, ref v1);
            /*4970*/
            var ret_result = (cef_menu_item_type_t)ret.I32;

            /*4971*/
            return ret_result;
            /*4972*/
        }
        /// <summary>
        /// Returns the item type at the specified |index|.
        /// /*cef(default_retval=MENUITEMTYPE_NONE)*/
        /// </summary>
        /*4973*/


        // gen! MenuItemType GetTypeAt(int index)
        /*4974*/

        public cef_menu_item_type_t GetTypeAt(int /*4975*/
        index
        )/*4976*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4977*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetTypeAt_24, out ret, ref v1);
            /*4978*/
            var ret_result = (cef_menu_item_type_t)ret.I32;

            /*4979*/
            return ret_result;
            /*4980*/
        }
        /// <summary>
        /// Returns the group id for the specified |command_id| or -1 if invalid.
        /// /*cef()*/
        /// </summary>
        /*4981*/


        // gen! int GetGroupId(int command_id)
        /*4982*/

        public int GetGroupId(int /*4983*/
        command_id
        )/*4984*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4985*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetGroupId_25, out ret, ref v1);
            /*4986*/
            var ret_result = ret.I32;
            /*4987*/
            return ret_result;
            /*4988*/
        }
        /// <summary>
        /// Returns the group id at the specified |index| or -1 if invalid.
        /// /*cef()*/
        /// </summary>
        /*4989*/


        // gen! int GetGroupIdAt(int index)
        /*4990*/

        public int GetGroupIdAt(int /*4991*/
        index
        )/*4992*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*4993*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetGroupIdAt_26, out ret, ref v1);
            /*4994*/
            var ret_result = ret.I32;
            /*4995*/
            return ret_result;
            /*4996*/
        }
        /// <summary>
        /// Sets the group id for the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4997*/


        // gen! bool SetGroupId(int command_id,int group_id)
        /*4998*/

        public bool SetGroupId(int /*4999*/
        command_id
        , int /*5000*/
        group_id
        )/*5001*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*5002*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetGroupId_27, out ret, ref v1, ref v2);
            /*5003*/
            var ret_result = ret.I32 != 0;
            /*5004*/
            return ret_result;
            /*5005*/
        }
        /// <summary>
        /// Sets the group id at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5006*/


        // gen! bool SetGroupIdAt(int index,int group_id)
        /*5007*/

        public bool SetGroupIdAt(int /*5008*/
        index
        , int /*5009*/
        group_id
        )/*5010*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*5011*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetGroupIdAt_28, out ret, ref v1, ref v2);
            /*5012*/
            var ret_result = ret.I32 != 0;
            /*5013*/
            return ret_result;
            /*5014*/
        }
        /// <summary>
        /// Returns the submenu for the specified |command_id| or empty if invalid.
        /// /*cef()*/
        /// </summary>
        /*5015*/


        // gen! CefRefPtr<CefMenuModel> GetSubMenu(int command_id)
        /*5016*/

        public CefMenuModel GetSubMenu(int /*5017*/
        command_id
        )/*5018*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5019*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetSubMenu_29, out ret, ref v1);
            /*5020*/
            var ret_result = new CefMenuModel(ret.Ptr);
            /*5021*/
            return ret_result;
            /*5022*/
        }
        /// <summary>
        /// Returns the submenu at the specified |index| or empty if invalid.
        /// /*cef()*/
        /// </summary>
        /*5023*/


        // gen! CefRefPtr<CefMenuModel> GetSubMenuAt(int index)
        /*5024*/

        public CefMenuModel GetSubMenuAt(int /*5025*/
        index
        )/*5026*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5027*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetSubMenuAt_30, out ret, ref v1);
            /*5028*/
            var ret_result = new CefMenuModel(ret.Ptr);
            /*5029*/
            return ret_result;
            /*5030*/
        }
        /// <summary>
        /// Returns true if the specified |command_id| is visible.
        /// /*cef()*/
        /// </summary>
        /*5031*/


        // gen! bool IsVisible(int command_id)
        /*5032*/

        public bool IsVisible(int /*5033*/
        command_id
        )/*5034*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5035*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsVisible_31, out ret, ref v1);
            /*5036*/
            var ret_result = ret.I32 != 0;
            /*5037*/
            return ret_result;
            /*5038*/
        }
        /// <summary>
        /// Returns true if the specified |index| is visible.
        /// /*cef()*/
        /// </summary>
        /*5039*/


        // gen! bool IsVisibleAt(int index)
        /*5040*/

        public bool IsVisibleAt(int /*5041*/
        index
        )/*5042*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5043*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsVisibleAt_32, out ret, ref v1);
            /*5044*/
            var ret_result = ret.I32 != 0;
            /*5045*/
            return ret_result;
            /*5046*/
        }
        /// <summary>
        /// Change the visibility of the specified |command_id|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*5047*/


        // gen! bool SetVisible(int command_id,bool visible)
        /*5048*/

        public bool SetVisible(int /*5049*/
        command_id
        , bool /*5050*/
        visible
        )/*5051*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*5052*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetVisible_33, out ret, ref v1, ref v2);
            /*5053*/
            var ret_result = ret.I32 != 0;
            /*5054*/
            return ret_result;
            /*5055*/
        }
        /// <summary>
        /// Change the visibility at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5056*/


        // gen! bool SetVisibleAt(int index,bool visible)
        /*5057*/

        public bool SetVisibleAt(int /*5058*/
        index
        , bool /*5059*/
        visible
        )/*5060*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*5061*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetVisibleAt_34, out ret, ref v1, ref v2);
            /*5062*/
            var ret_result = ret.I32 != 0;
            /*5063*/
            return ret_result;
            /*5064*/
        }
        /// <summary>
        /// Returns true if the specified |command_id| is enabled.
        /// /*cef()*/
        /// </summary>
        /*5065*/


        // gen! bool IsEnabled(int command_id)
        /*5066*/

        public bool IsEnabled(int /*5067*/
        command_id
        )/*5068*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5069*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsEnabled_35, out ret, ref v1);
            /*5070*/
            var ret_result = ret.I32 != 0;
            /*5071*/
            return ret_result;
            /*5072*/
        }
        /// <summary>
        /// Returns true if the specified |index| is enabled.
        /// /*cef()*/
        /// </summary>
        /*5073*/


        // gen! bool IsEnabledAt(int index)
        /*5074*/

        public bool IsEnabledAt(int /*5075*/
        index
        )/*5076*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5077*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsEnabledAt_36, out ret, ref v1);
            /*5078*/
            var ret_result = ret.I32 != 0;
            /*5079*/
            return ret_result;
            /*5080*/
        }
        /// <summary>
        /// Change the enabled status of the specified |command_id|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*5081*/


        // gen! bool SetEnabled(int command_id,bool enabled)
        /*5082*/

        public bool SetEnabled(int /*5083*/
        command_id
        , bool /*5084*/
        enabled
        )/*5085*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*5086*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetEnabled_37, out ret, ref v1, ref v2);
            /*5087*/
            var ret_result = ret.I32 != 0;
            /*5088*/
            return ret_result;
            /*5089*/
        }
        /// <summary>
        /// Change the enabled status at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*5090*/


        // gen! bool SetEnabledAt(int index,bool enabled)
        /*5091*/

        public bool SetEnabledAt(int /*5092*/
        index
        , bool /*5093*/
        enabled
        )/*5094*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*5095*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetEnabledAt_38, out ret, ref v1, ref v2);
            /*5096*/
            var ret_result = ret.I32 != 0;
            /*5097*/
            return ret_result;
            /*5098*/
        }
        /// <summary>
        /// Returns true if the specified |command_id| is checked. Only applies to
        /// check and radio items.
        /// /*cef()*/
        /// </summary>
        /*5099*/


        // gen! bool IsChecked(int command_id)
        /*5100*/

        public bool IsChecked(int /*5101*/
        command_id
        )/*5102*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5103*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsChecked_39, out ret, ref v1);
            /*5104*/
            var ret_result = ret.I32 != 0;
            /*5105*/
            return ret_result;
            /*5106*/
        }
        /// <summary>
        /// Returns true if the specified |index| is checked. Only applies to check
        /// and radio items.
        /// /*cef()*/
        /// </summary>
        /*5107*/


        // gen! bool IsCheckedAt(int index)
        /*5108*/

        public bool IsCheckedAt(int /*5109*/
        index
        )/*5110*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5111*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsCheckedAt_40, out ret, ref v1);
            /*5112*/
            var ret_result = ret.I32 != 0;
            /*5113*/
            return ret_result;
            /*5114*/
        }
        /// <summary>
        /// Check the specified |command_id|. Only applies to check and radio items.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5115*/


        // gen! bool SetChecked(int command_id,bool checked)
        /*5116*/

        public bool SetChecked(int /*5117*/
        command_id
        , bool /*5118*/
        _checked
        )/*5119*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*5120*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetChecked_41, out ret, ref v1, ref v2);
            /*5121*/
            var ret_result = ret.I32 != 0;
            /*5122*/
            return ret_result;
            /*5123*/
        }
        /// <summary>
        /// Check the specified |index|. Only applies to check and radio items. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>
        /*5124*/


        // gen! bool SetCheckedAt(int index,bool checked)
        /*5125*/

        public bool SetCheckedAt(int /*5126*/
        index
        , bool /*5127*/
        _checked
        )/*5128*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*5129*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetCheckedAt_42, out ret, ref v1, ref v2);
            /*5130*/
            var ret_result = ret.I32 != 0;
            /*5131*/
            return ret_result;
            /*5132*/
        }
        /// <summary>
        /// Returns true if the specified |command_id| has a keyboard accelerator
        /// assigned.
        /// /*cef()*/
        /// </summary>
        /*5133*/


        // gen! bool HasAccelerator(int command_id)
        /*5134*/

        public bool HasAccelerator(int /*5135*/
        command_id
        )/*5136*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5137*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_HasAccelerator_43, out ret, ref v1);
            /*5138*/
            var ret_result = ret.I32 != 0;
            /*5139*/
            return ret_result;
            /*5140*/
        }
        /// <summary>
        /// Returns true if the specified |index| has a keyboard accelerator assigned.
        /// /*cef()*/
        /// </summary>
        /*5141*/


        // gen! bool HasAcceleratorAt(int index)
        /*5142*/

        public bool HasAcceleratorAt(int /*5143*/
        index
        )/*5144*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5145*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_HasAcceleratorAt_44, out ret, ref v1);
            /*5146*/
            var ret_result = ret.I32 != 0;
            /*5147*/
            return ret_result;
            /*5148*/
        }
        /// <summary>
        /// Set the keyboard accelerator for the specified |command_id|. |key_code| can
        /// be any virtual key or character value. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5149*/


        // gen! bool SetAccelerator(int command_id,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
        /*5150*/

        public bool SetAccelerator(int /*5151*/
        command_id
        , int /*5152*/
        key_code
        , bool /*5153*/
        shift_pressed
        , bool /*5154*/
        ctrl_pressed
        , bool /*5155*/
        alt_pressed
        )/*5156*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            /*5157*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_SetAccelerator_45, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*5158*/
            var ret_result = ret.I32 != 0;
            /*5159*/
            return ret_result;
            /*5160*/
        }
        /// <summary>
        /// Set the keyboard accelerator at the specified |index|. |key_code| can be
        /// any virtual key or character value. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5161*/


        // gen! bool SetAcceleratorAt(int index,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
        /*5162*/

        public bool SetAcceleratorAt(int /*5163*/
        index
        , int /*5164*/
        key_code
        , bool /*5165*/
        shift_pressed
        , bool /*5166*/
        ctrl_pressed
        , bool /*5167*/
        alt_pressed
        )/*5168*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            /*5169*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_SetAcceleratorAt_46, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*5170*/
            var ret_result = ret.I32 != 0;
            /*5171*/
            return ret_result;
            /*5172*/
        }
        /// <summary>
        /// Remove the keyboard accelerator for the specified |command_id|. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>
        /*5173*/


        // gen! bool RemoveAccelerator(int command_id)
        /*5174*/

        public bool RemoveAccelerator(int /*5175*/
        command_id
        )/*5176*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5177*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAccelerator_47, out ret, ref v1);
            /*5178*/
            var ret_result = ret.I32 != 0;
            /*5179*/
            return ret_result;
            /*5180*/
        }
        /// <summary>
        /// Remove the keyboard accelerator at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*5181*/


        // gen! bool RemoveAcceleratorAt(int index)
        /*5182*/

        public bool RemoveAcceleratorAt(int /*5183*/
        index
        )/*5184*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5185*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAcceleratorAt_48, out ret, ref v1);
            /*5186*/
            var ret_result = ret.I32 != 0;
            /*5187*/
            return ret_result;
            /*5188*/
        }
        /// <summary>
        /// Retrieves the keyboard accelerator for the specified |command_id|. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>
        /*5189*/


        // gen! bool GetAccelerator(int command_id,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
        /*5190*/

        public bool GetAccelerator(int /*5191*/
        command_id
        , ref int /*5192*/
        key_code
        , ref bool /*5193*/
        shift_pressed
        , ref bool /*5194*/
        ctrl_pressed
        , ref bool /*5195*/
        alt_pressed
        )/*5196*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            /*5197*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_GetAccelerator_49, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*5198*/
            var ret_result = ret.I32 != 0;
            key_code = (int)v2.I32;/*5199*/
            ;
            shift_pressed = v3.I32 != 0;/*5200*/
            ;
            ctrl_pressed = v4.I32 != 0;/*5201*/
            ;
            alt_pressed = v5.I32 != 0;/*5202*/
            ;
            /*5203*/
            return ret_result;
            /*5204*/
        }
        /// <summary>
        /// Retrieves the keyboard accelerator for the specified |index|. Returns true
        /// on success.
        /// /*cef()*/
        /// </summary>
        /*5205*/


        // gen! bool GetAcceleratorAt(int index,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
        /*5206*/

        public bool GetAcceleratorAt(int /*5207*/
        index
        , ref int /*5208*/
        key_code
        , ref bool /*5209*/
        shift_pressed
        , ref bool /*5210*/
        ctrl_pressed
        , ref bool /*5211*/
        alt_pressed
        )/*5212*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            /*5213*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_GetAcceleratorAt_50, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*5214*/
            var ret_result = ret.I32 != 0;
            key_code = (int)v2.I32;/*5215*/
            ;
            shift_pressed = v3.I32 != 0;/*5216*/
            ;
            ctrl_pressed = v4.I32 != 0;/*5217*/
            ;
            alt_pressed = v5.I32 != 0;/*5218*/
            ;
            /*5219*/
            return ret_result;
            /*5220*/
        }
        /// <summary>
        /// Set the explicit color for |command_id| and |color_type| to |color|.
        /// Specify a |color| value of 0 to remove the explicit color. If no explicit
        /// color or default color is set for |color_type| then the system color will
        /// be used. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5221*/


        // gen! bool SetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t color)
        /*5222*/

        public bool SetColor(int /*5223*/
        command_id
        , cef_menu_color_type_t /*5224*/
        color_type
        , IntPtr /*5225*/
        color
        )/*5226*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*5227*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_SetColor_51, out ret, ref v1, ref v2, ref v3);
            /*5228*/
            var ret_result = ret.I32 != 0;
            /*5229*/
            return ret_result;
            /*5230*/
        }
        /// <summary>
        /// Set the explicit color for |command_id| and |index| to |color|. Specify a
        /// |color| value of 0 to remove the explicit color. Specify an |index| value
        /// of -1 to set the default color for items that do not have an explicit
        /// color set. If no explicit color or default color is set for |color_type|
        /// then the system color will be used. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5231*/


        // gen! bool SetColorAt(int index,cef_menu_color_type_t color_type,cef_color_t color)
        /*5232*/

        public bool SetColorAt(int /*5233*/
        index
        , cef_menu_color_type_t /*5234*/
        color_type
        , IntPtr /*5235*/
        color
        )/*5236*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*5237*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_SetColorAt_52, out ret, ref v1, ref v2, ref v3);
            /*5238*/
            var ret_result = ret.I32 != 0;
            /*5239*/
            return ret_result;
            /*5240*/
        }
        /// <summary>
        /// Returns in |color| the color that was explicitly set for |command_id| and
        /// |color_type|. If a color was not set then 0 will be returned in |color|.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5241*/


        // gen! bool GetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t& color)
        /*5242*/

        public bool GetColor(int /*5243*/
        command_id
        , cef_menu_color_type_t /*5244*/
        color_type
        , cef_color_t /*5245*/
        color
        )/*5246*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*5247*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_GetColor_53, out ret, ref v1, ref v2, ref v3);
            /*5248*/
            var ret_result = ret.I32 != 0;
            /*5249*/
            return ret_result;
            /*5250*/
        }
        /// <summary>
        /// Returns in |color| the color that was explicitly set for |command_id| and
        /// |color_type|. Specify an |index| value of -1 to return the default color
        /// in |color|. If a color was not set then 0 will be returned in |color|.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5251*/


        // gen! bool GetColorAt(int index,cef_menu_color_type_t color_type,cef_color_t& color)
        /*5252*/

        public bool GetColorAt(int /*5253*/
        index
        , cef_menu_color_type_t /*5254*/
        color_type
        , cef_color_t /*5255*/
        color
        )/*5256*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*5257*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_GetColorAt_54, out ret, ref v1, ref v2, ref v3);
            /*5258*/
            var ret_result = ret.I32 != 0;
            /*5259*/
            return ret_result;
            /*5260*/
        }
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
        /*5261*/


        // gen! bool SetFontList(int command_id,const CefString& font_list)
        /*5262*/

        public bool SetFontList(int /*5263*/
        command_id
        , string /*5264*/
        font_list
        )/*5265*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(font_list);
            /*5266*/
            ;
            /*5267*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetFontList_55, out ret, ref v1, ref v2);
            /*5268*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*5269*/
            ;
            /*5270*/
            return ret_result;
            /*5271*/
        }
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
        /*5272*/


        // gen! bool SetFontListAt(int index,const CefString& font_list)
        /*5273*/

        public bool SetFontListAt(int /*5274*/
        index
        , string /*5275*/
        font_list
        )/*5276*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(font_list);
            /*5277*/
            ;
            /*5278*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetFontListAt_56, out ret, ref v1, ref v2);
            /*5279*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*5280*/
            ;
            /*5281*/
            return ret_result;
            /*5282*/
        }
        /*5283*/
    }


    // [virtual] class CefMenuModelDelegate
    /// <summary>
    /// Implement this interface to handle menu model events. The methods of this
    /// class will be called on the browser process UI thread unless otherwise
    /// indicated.
    /// /*(source=client)*/
    /// </summary>
    /*5292*/
    public struct CefMenuModelDelegate
    {
        /*5293*/
        const int _typeNAME = 18;
        /*5294*/
        const int CefMenuModelDelegate_Release_0 = (_typeNAME << 16) | 0;
        /*5295*/
        internal readonly IntPtr nativePtr;
        /*5296*/
        internal CefMenuModelDelegate(IntPtr nativePtr)
        {
            /*5297*/
            this.nativePtr = nativePtr;
            /*5298*/
        }
        /*5299*/
        public void Release()
        {
            /*5300*/
            JsValue ret;
            /*5301*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModelDelegate_Release_0, out ret);
            /*5302*/
        }
        /*5303*/
    }


    // [virtual] class CefNavigationEntry
    /// <summary>
    /// Class used to represent an entry in navigation history.
    /// /*(source=library)*/
    /// </summary>
    /*5362*/
    public struct CefNavigationEntry
    {
        /*5363*/
        const int _typeNAME = 19;
        /*5364*/
        const int CefNavigationEntry_Release_0 = (_typeNAME << 16) | 0;
        /*5365*/
        const int CefNavigationEntry_IsValid_1 = (_typeNAME << 16) | 1;
        /*5366*/
        const int CefNavigationEntry_GetURL_2 = (_typeNAME << 16) | 2;
        /*5367*/
        const int CefNavigationEntry_GetDisplayURL_3 = (_typeNAME << 16) | 3;
        /*5368*/
        const int CefNavigationEntry_GetOriginalURL_4 = (_typeNAME << 16) | 4;
        /*5369*/
        const int CefNavigationEntry_GetTitle_5 = (_typeNAME << 16) | 5;
        /*5370*/
        const int CefNavigationEntry_GetTransitionType_6 = (_typeNAME << 16) | 6;
        /*5371*/
        const int CefNavigationEntry_HasPostData_7 = (_typeNAME << 16) | 7;
        /*5372*/
        const int CefNavigationEntry_GetCompletionTime_8 = (_typeNAME << 16) | 8;
        /*5373*/
        const int CefNavigationEntry_GetHttpStatusCode_9 = (_typeNAME << 16) | 9;
        /*5374*/
        const int CefNavigationEntry_GetSSLStatus_10 = (_typeNAME << 16) | 10;
        /*5375*/
        internal readonly IntPtr nativePtr;
        /*5376*/
        internal CefNavigationEntry(IntPtr nativePtr)
        {
            /*5377*/
            this.nativePtr = nativePtr;
            /*5378*/
        }
        /*5379*/
        public void Release()
        {
            /*5380*/
            JsValue ret;
            /*5381*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_Release_0, out ret);
            /*5382*/
        }
        /// <summary>
        /// CefNavigationEntry methods.
        /// </summary>
        /*5383*/


        // gen! bool IsValid()
        /*5384*/

        public bool IsValid()/*5385*/
        {
            JsValue ret;
            /*5386*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_IsValid_1, out ret);
            /*5387*/
            var ret_result = ret.I32 != 0;
            /*5388*/
            return ret_result;
            /*5389*/
        }
        /// <summary>
        /// Returns the actual URL of the page. For some pages this may be data: URL or
        /// similar. Use GetDisplayURL() to return a display-friendly version.
        /// /*cef()*/
        /// </summary>
        /*5390*/


        // gen! CefString GetURL()
        /*5391*/

        public string GetURL()/*5392*/
        {
            JsValue ret;
            /*5393*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetURL_2, out ret);
            /*5394*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5395*/
            return ret_result;
            /*5396*/
        }
        /// <summary>
        /// Returns a display-friendly version of the URL.
        /// /*cef()*/
        /// </summary>
        /*5397*/


        // gen! CefString GetDisplayURL()
        /*5398*/

        public string GetDisplayURL()/*5399*/
        {
            JsValue ret;
            /*5400*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetDisplayURL_3, out ret);
            /*5401*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5402*/
            return ret_result;
            /*5403*/
        }
        /// <summary>
        /// Returns the original URL that was entered by the user before any redirects.
        /// /*cef()*/
        /// </summary>
        /*5404*/


        // gen! CefString GetOriginalURL()
        /*5405*/

        public string GetOriginalURL()/*5406*/
        {
            JsValue ret;
            /*5407*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetOriginalURL_4, out ret);
            /*5408*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5409*/
            return ret_result;
            /*5410*/
        }
        /// <summary>
        /// Returns the title set by the page. This value may be empty.
        /// /*cef()*/
        /// </summary>
        /*5411*/


        // gen! CefString GetTitle()
        /*5412*/

        public string GetTitle()/*5413*/
        {
            JsValue ret;
            /*5414*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetTitle_5, out ret);
            /*5415*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5416*/
            return ret_result;
            /*5417*/
        }
        /// <summary>
        /// Returns the transition type which indicates what the user did to move to
        /// this page from the previous page.
        /// /*cef(default_retval=TT_EXPLICIT)*/
        /// </summary>
        /*5418*/


        // gen! TransitionType GetTransitionType()
        /*5419*/

        public cef_transition_type_t GetTransitionType()/*5420*/
        {
            JsValue ret;
            /*5421*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetTransitionType_6, out ret);
            /*5422*/
            var ret_result = (cef_transition_type_t)ret.I32;

            /*5423*/
            return ret_result;
            /*5424*/
        }
        /// <summary>
        /// Returns true if this navigation includes post data.
        /// /*cef()*/
        /// </summary>
        /*5425*/


        // gen! bool HasPostData()
        /*5426*/

        public bool HasPostData()/*5427*/
        {
            JsValue ret;
            /*5428*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_HasPostData_7, out ret);
            /*5429*/
            var ret_result = ret.I32 != 0;
            /*5430*/
            return ret_result;
            /*5431*/
        }
        /// <summary>
        /// Returns the time for the last known successful navigation completion. A
        /// navigation may be completed more than once if the page is reloaded. May be
        /// 0 if the navigation has not yet completed.
        /// /*cef()*/
        /// </summary>
        /*5432*/


        // gen! CefTime GetCompletionTime()
        /*5433*/

        public CefTime GetCompletionTime()/*5434*/
        {
            JsValue ret;
            /*5435*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetCompletionTime_8, out ret);
            /*5436*/
            var ret_result = new CefTime(ret.Ptr);

            /*5437*/
            return ret_result;
            /*5438*/
        }
        /// <summary>
        /// Returns the HTTP status code for the last known successful navigation
        /// response. May be 0 if the response has not yet been received or if the
        /// navigation has not yet completed.
        /// /*cef()*/
        /// </summary>
        /*5439*/


        // gen! int GetHttpStatusCode()
        /*5440*/

        public int GetHttpStatusCode()/*5441*/
        {
            JsValue ret;
            /*5442*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetHttpStatusCode_9, out ret);
            /*5443*/
            var ret_result = ret.I32;
            /*5444*/
            return ret_result;
            /*5445*/
        }
        /// <summary>
        /// Returns the SSL information for this navigation entry.
        /// /*cef()*/
        /// </summary>
        /*5446*/


        // gen! CefRefPtr<CefSSLStatus> GetSSLStatus()
        /*5447*/

        public CefSSLStatus GetSSLStatus()/*5448*/
        {
            JsValue ret;
            /*5449*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetSSLStatus_10, out ret);
            /*5450*/
            var ret_result = new CefSSLStatus(ret.Ptr);
            /*5451*/
            return ret_result;
            /*5452*/
        }
        /*5453*/
    }


    // [virtual] class CefPrintSettings
    /// <summary>
    /// Class representing print settings.
    /// /*(source=library)*/
    /// </summary>
    /*5577*/
    public struct CefPrintSettings
    {
        /*5578*/
        const int _typeNAME = 20;
        /*5579*/
        const int CefPrintSettings_Release_0 = (_typeNAME << 16) | 0;
        /*5580*/
        const int CefPrintSettings_IsValid_1 = (_typeNAME << 16) | 1;
        /*5581*/
        const int CefPrintSettings_IsReadOnly_2 = (_typeNAME << 16) | 2;
        /*5582*/
        const int CefPrintSettings_Copy_3 = (_typeNAME << 16) | 3;
        /*5583*/
        const int CefPrintSettings_SetOrientation_4 = (_typeNAME << 16) | 4;
        /*5584*/
        const int CefPrintSettings_IsLandscape_5 = (_typeNAME << 16) | 5;
        /*5585*/
        const int CefPrintSettings_SetPrinterPrintableArea_6 = (_typeNAME << 16) | 6;
        /*5586*/
        const int CefPrintSettings_SetDeviceName_7 = (_typeNAME << 16) | 7;
        /*5587*/
        const int CefPrintSettings_GetDeviceName_8 = (_typeNAME << 16) | 8;
        /*5588*/
        const int CefPrintSettings_SetDPI_9 = (_typeNAME << 16) | 9;
        /*5589*/
        const int CefPrintSettings_GetDPI_10 = (_typeNAME << 16) | 10;
        /*5590*/
        const int CefPrintSettings_SetPageRanges_11 = (_typeNAME << 16) | 11;
        /*5591*/
        const int CefPrintSettings_GetPageRangesCount_12 = (_typeNAME << 16) | 12;
        /*5592*/
        const int CefPrintSettings_GetPageRanges_13 = (_typeNAME << 16) | 13;
        /*5593*/
        const int CefPrintSettings_SetSelectionOnly_14 = (_typeNAME << 16) | 14;
        /*5594*/
        const int CefPrintSettings_IsSelectionOnly_15 = (_typeNAME << 16) | 15;
        /*5595*/
        const int CefPrintSettings_SetCollate_16 = (_typeNAME << 16) | 16;
        /*5596*/
        const int CefPrintSettings_WillCollate_17 = (_typeNAME << 16) | 17;
        /*5597*/
        const int CefPrintSettings_SetColorModel_18 = (_typeNAME << 16) | 18;
        /*5598*/
        const int CefPrintSettings_GetColorModel_19 = (_typeNAME << 16) | 19;
        /*5599*/
        const int CefPrintSettings_SetCopies_20 = (_typeNAME << 16) | 20;
        /*5600*/
        const int CefPrintSettings_GetCopies_21 = (_typeNAME << 16) | 21;
        /*5601*/
        const int CefPrintSettings_SetDuplexMode_22 = (_typeNAME << 16) | 22;
        /*5602*/
        const int CefPrintSettings_GetDuplexMode_23 = (_typeNAME << 16) | 23;
        /*5603*/
        internal readonly IntPtr nativePtr;
        /*5604*/
        internal CefPrintSettings(IntPtr nativePtr)
        {
            /*5605*/
            this.nativePtr = nativePtr;
            /*5606*/
        }
        /*5607*/
        public void Release()
        {
            /*5608*/
            JsValue ret;
            /*5609*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_Release_0, out ret);
            /*5610*/
        }
        /// <summary>
        /// CefPrintSettings methods.
        /// </summary>
        /*5611*/


        // gen! bool IsValid()
        /*5612*/

        public bool IsValid()/*5613*/
        {
            JsValue ret;
            /*5614*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsValid_1, out ret);
            /*5615*/
            var ret_result = ret.I32 != 0;
            /*5616*/
            return ret_result;
            /*5617*/
        }
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*5618*/


        // gen! bool IsReadOnly()
        /*5619*/

        public bool IsReadOnly()/*5620*/
        {
            JsValue ret;
            /*5621*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsReadOnly_2, out ret);
            /*5622*/
            var ret_result = ret.I32 != 0;
            /*5623*/
            return ret_result;
            /*5624*/
        }
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>
        /*5625*/


        // gen! CefRefPtr<CefPrintSettings> Copy()
        /*5626*/

        public CefPrintSettings Copy()/*5627*/
        {
            JsValue ret;
            /*5628*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_Copy_3, out ret);
            /*5629*/
            var ret_result = new CefPrintSettings(ret.Ptr);
            /*5630*/
            return ret_result;
            /*5631*/
        }
        /// <summary>
        /// Set the page orientation.
        /// /*cef()*/
        /// </summary>
        /*5632*/


        // gen! void SetOrientation(bool landscape)
        /*5633*/

        public void SetOrientation(bool /*5634*/
        landscape
        )/*5635*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5636*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetOrientation_4, out ret, ref v1);
            /*5637*/

            /*5638*/
        }
        /// <summary>
        /// Returns true if the orientation is landscape.
        /// /*cef()*/
        /// </summary>
        /*5639*/


        // gen! bool IsLandscape()
        /*5640*/

        public bool IsLandscape()/*5641*/
        {
            JsValue ret;
            /*5642*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsLandscape_5, out ret);
            /*5643*/
            var ret_result = ret.I32 != 0;
            /*5644*/
            return ret_result;
            /*5645*/
        }
        /// <summary>
        /// Set the printer printable area in device units.
        /// Some platforms already provide flipped area. Set |landscape_needs_flip|
        /// to false on those platforms to avoid double flipping.
        /// /*cef()*/
        /// </summary>
        /*5646*/


        // gen! void SetPrinterPrintableArea(const CefSize& physical_size_device_units,const CefRect& printable_area_device_units,bool landscape_needs_flip)
        /*5647*/

        public void SetPrinterPrintableArea(CefSize /*5648*/
        physical_size_device_units
        , CefRect /*5649*/
        printable_area_device_units
        , bool /*5650*/
        landscape_needs_flip
        )/*5651*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*5652*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefPrintSettings_SetPrinterPrintableArea_6, out ret, ref v1, ref v2, ref v3);
            /*5653*/

            /*5654*/
        }
        /// <summary>
        /// Set the device name.
        /// /*cef(optional_param=name)*/
        /// </summary>
        /*5655*/


        // gen! void SetDeviceName(const CefString& name)
        /*5656*/

        public void SetDeviceName(string /*5657*/
        name
        )/*5658*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*5659*/
            ;
            /*5660*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDeviceName_7, out ret, ref v1);
            /*5661*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*5662*/
            ;
            /*5663*/
        }
        /// <summary>
        /// Get the device name.
        /// /*cef()*/
        /// </summary>
        /*5664*/


        // gen! CefString GetDeviceName()
        /*5665*/

        public string GetDeviceName()/*5666*/
        {
            JsValue ret;
            /*5667*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDeviceName_8, out ret);
            /*5668*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5669*/
            return ret_result;
            /*5670*/
        }
        /// <summary>
        /// Set the DPI (dots per inch).
        /// /*cef()*/
        /// </summary>
        /*5671*/


        // gen! void SetDPI(int dpi)
        /*5672*/

        public void SetDPI(int /*5673*/
        dpi
        )/*5674*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5675*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDPI_9, out ret, ref v1);
            /*5676*/

            /*5677*/
        }
        /// <summary>
        /// Get the DPI (dots per inch).
        /// /*cef()*/
        /// </summary>
        /*5678*/


        // gen! int GetDPI()
        /*5679*/

        public int GetDPI()/*5680*/
        {
            JsValue ret;
            /*5681*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDPI_10, out ret);
            /*5682*/
            var ret_result = ret.I32;
            /*5683*/
            return ret_result;
            /*5684*/
        }
        /// <summary>
        /// Set the page ranges.
        /// /*cef()*/
        /// </summary>
        /*5685*/


        // gen! void SetPageRanges(const PageRangeList& ranges)
        /*5686*/

        public void SetPageRanges(PageRangeList /*5687*/
        ranges
        )/*5688*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5689*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetPageRanges_11, out ret, ref v1);
            /*5690*/

            /*5691*/
        }
        /// <summary>
        /// Returns the number of page ranges that currently exist.
        /// /*cef()*/
        /// </summary>
        /*5692*/


        // gen! size_t GetPageRangesCount()
        /*5693*/

        public uint GetPageRangesCount()/*5694*/
        {
            JsValue ret;
            /*5695*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetPageRangesCount_12, out ret);
            /*5696*/
            var ret_result = (uint)ret.I32;
            /*5697*/
            return ret_result;
            /*5698*/
        }
        /// <summary>
        /// Retrieve the page ranges.
        /// /*cef(count_func=ranges:GetPageRangesCount)*/
        /// </summary>
        /*5699*/


        // gen! void GetPageRanges(PageRangeList& ranges)
        /*5700*/

        public void GetPageRanges(PageRangeList /*5701*/
        ranges
        )/*5702*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5703*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_GetPageRanges_13, out ret, ref v1);
            /*5704*/

            /*5705*/
        }
        /// <summary>
        /// Set whether only the selection will be printed.
        /// /*cef()*/
        /// </summary>
        /*5706*/


        // gen! void SetSelectionOnly(bool selection_only)
        /*5707*/

        public void SetSelectionOnly(bool /*5708*/
        selection_only
        )/*5709*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5710*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetSelectionOnly_14, out ret, ref v1);
            /*5711*/

            /*5712*/
        }
        /// <summary>
        /// Returns true if only the selection will be printed.
        /// /*cef()*/
        /// </summary>
        /*5713*/


        // gen! bool IsSelectionOnly()
        /*5714*/

        public bool IsSelectionOnly()/*5715*/
        {
            JsValue ret;
            /*5716*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsSelectionOnly_15, out ret);
            /*5717*/
            var ret_result = ret.I32 != 0;
            /*5718*/
            return ret_result;
            /*5719*/
        }
        /// <summary>
        /// Set whether pages will be collated.
        /// /*cef()*/
        /// </summary>
        /*5720*/


        // gen! void SetCollate(bool collate)
        /*5721*/

        public void SetCollate(bool /*5722*/
        collate
        )/*5723*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5724*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetCollate_16, out ret, ref v1);
            /*5725*/

            /*5726*/
        }
        /// <summary>
        /// Returns true if pages will be collated.
        /// /*cef()*/
        /// </summary>
        /*5727*/


        // gen! bool WillCollate()
        /*5728*/

        public bool WillCollate()/*5729*/
        {
            JsValue ret;
            /*5730*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_WillCollate_17, out ret);
            /*5731*/
            var ret_result = ret.I32 != 0;
            /*5732*/
            return ret_result;
            /*5733*/
        }
        /// <summary>
        /// Set the color model.
        /// /*cef()*/
        /// </summary>
        /*5734*/


        // gen! void SetColorModel(ColorModel model)
        /*5735*/

        public void SetColorModel(cef_color_model_t /*5736*/
        model
        )/*5737*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5738*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetColorModel_18, out ret, ref v1);
            /*5739*/

            /*5740*/
        }
        /// <summary>
        /// Get the color model.
        /// /*cef(default_retval=COLOR_MODEL_UNKNOWN)*/
        /// </summary>
        /*5741*/


        // gen! ColorModel GetColorModel()
        /*5742*/

        public cef_color_model_t GetColorModel()/*5743*/
        {
            JsValue ret;
            /*5744*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetColorModel_19, out ret);
            /*5745*/
            var ret_result = (cef_color_model_t)ret.I32;

            /*5746*/
            return ret_result;
            /*5747*/
        }
        /// <summary>
        /// Set the number of copies.
        /// /*cef()*/
        /// </summary>
        /*5748*/


        // gen! void SetCopies(int copies)
        /*5749*/

        public void SetCopies(int /*5750*/
        copies
        )/*5751*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5752*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetCopies_20, out ret, ref v1);
            /*5753*/

            /*5754*/
        }
        /// <summary>
        /// Get the number of copies.
        /// /*cef()*/
        /// </summary>
        /*5755*/


        // gen! int GetCopies()
        /*5756*/

        public int GetCopies()/*5757*/
        {
            JsValue ret;
            /*5758*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetCopies_21, out ret);
            /*5759*/
            var ret_result = ret.I32;
            /*5760*/
            return ret_result;
            /*5761*/
        }
        /// <summary>
        /// Set the duplex mode.
        /// /*cef()*/
        /// </summary>
        /*5762*/


        // gen! void SetDuplexMode(DuplexMode mode)
        /*5763*/

        public void SetDuplexMode(cef_duplex_mode_t /*5764*/
        mode
        )/*5765*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*5766*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDuplexMode_22, out ret, ref v1);
            /*5767*/

            /*5768*/
        }
        /// <summary>
        /// Get the duplex mode.
        /// /*cef(default_retval=DUPLEX_MODE_UNKNOWN)*/
        /// </summary>
        /*5769*/


        // gen! DuplexMode GetDuplexMode()
        /*5770*/

        public cef_duplex_mode_t GetDuplexMode()/*5771*/
        {
            JsValue ret;
            /*5772*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDuplexMode_23, out ret);
            /*5773*/
            var ret_result = (cef_duplex_mode_t)ret.I32;

            /*5774*/
            return ret_result;
            /*5775*/
        }
        /*5776*/
    }


    // [virtual] class CefProcessMessage
    /// <summary>
    /// Class representing a message. Can be used on any process and thread.
    /// /*cef(source=library)*/
    /// </summary>
    /*5810*/
    public struct CefProcessMessage
    {
        /*5811*/
        const int _typeNAME = 21;
        /*5812*/
        const int CefProcessMessage_Release_0 = (_typeNAME << 16) | 0;
        /*5813*/
        const int CefProcessMessage_IsValid_1 = (_typeNAME << 16) | 1;
        /*5814*/
        const int CefProcessMessage_IsReadOnly_2 = (_typeNAME << 16) | 2;
        /*5815*/
        const int CefProcessMessage_Copy_3 = (_typeNAME << 16) | 3;
        /*5816*/
        const int CefProcessMessage_GetName_4 = (_typeNAME << 16) | 4;
        /*5817*/
        const int CefProcessMessage_GetArgumentList_5 = (_typeNAME << 16) | 5;
        /*5818*/
        internal readonly IntPtr nativePtr;
        /*5819*/
        internal CefProcessMessage(IntPtr nativePtr)
        {
            /*5820*/
            this.nativePtr = nativePtr;
            /*5821*/
        }
        /*5822*/
        public void Release()
        {
            /*5823*/
            JsValue ret;
            /*5824*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_Release_0, out ret);
            /*5825*/
        }
        /// <summary>
        /// CefProcessMessage methods.
        /// </summary>
        /*5826*/


        // gen! bool IsValid()
        /*5827*/

        public bool IsValid()/*5828*/
        {
            JsValue ret;
            /*5829*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_IsValid_1, out ret);
            /*5830*/
            var ret_result = ret.I32 != 0;
            /*5831*/
            return ret_result;
            /*5832*/
        }
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*5833*/


        // gen! bool IsReadOnly()
        /*5834*/

        public bool IsReadOnly()/*5835*/
        {
            JsValue ret;
            /*5836*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_IsReadOnly_2, out ret);
            /*5837*/
            var ret_result = ret.I32 != 0;
            /*5838*/
            return ret_result;
            /*5839*/
        }
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>
        /*5840*/


        // gen! CefRefPtr<CefProcessMessage> Copy()
        /*5841*/

        public CefProcessMessage Copy()/*5842*/
        {
            JsValue ret;
            /*5843*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_Copy_3, out ret);
            /*5844*/
            var ret_result = new CefProcessMessage(ret.Ptr);
            /*5845*/
            return ret_result;
            /*5846*/
        }
        /// <summary>
        /// Returns the message name.
        /// /*cef()*/
        /// </summary>
        /*5847*/


        // gen! CefString GetName()
        /*5848*/

        public string GetName()/*5849*/
        {
            JsValue ret;
            /*5850*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_GetName_4, out ret);
            /*5851*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5852*/
            return ret_result;
            /*5853*/
        }
        /// <summary>
        /// Returns the list of arguments.
        /// /*cef()*/
        /// </summary>
        /*5854*/


        // gen! CefRefPtr<CefListValue> GetArgumentList()
        /*5855*/

        public CefListValue GetArgumentList()/*5856*/
        {
            JsValue ret;
            /*5857*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_GetArgumentList_5, out ret);
            /*5858*/
            var ret_result = new CefListValue(ret.Ptr);
            /*5859*/
            return ret_result;
            /*5860*/
        }
        /*5861*/
    }


    // [virtual] class CefRequest
    /// <summary>
    /// Class used to represent a web request. The methods of this class may be
    /// called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*5970*/
    public struct CefRequest
    {
        /*5971*/
        const int _typeNAME = 22;
        /*5972*/
        const int CefRequest_Release_0 = (_typeNAME << 16) | 0;
        /*5973*/
        const int CefRequest_IsReadOnly_1 = (_typeNAME << 16) | 1;
        /*5974*/
        const int CefRequest_GetURL_2 = (_typeNAME << 16) | 2;
        /*5975*/
        const int CefRequest_SetURL_3 = (_typeNAME << 16) | 3;
        /*5976*/
        const int CefRequest_GetMethod_4 = (_typeNAME << 16) | 4;
        /*5977*/
        const int CefRequest_SetMethod_5 = (_typeNAME << 16) | 5;
        /*5978*/
        const int CefRequest_SetReferrer_6 = (_typeNAME << 16) | 6;
        /*5979*/
        const int CefRequest_GetReferrerURL_7 = (_typeNAME << 16) | 7;
        /*5980*/
        const int CefRequest_GetReferrerPolicy_8 = (_typeNAME << 16) | 8;
        /*5981*/
        const int CefRequest_GetPostData_9 = (_typeNAME << 16) | 9;
        /*5982*/
        const int CefRequest_SetPostData_10 = (_typeNAME << 16) | 10;
        /*5983*/
        const int CefRequest_GetHeaderMap_11 = (_typeNAME << 16) | 11;
        /*5984*/
        const int CefRequest_SetHeaderMap_12 = (_typeNAME << 16) | 12;
        /*5985*/
        const int CefRequest_Set_13 = (_typeNAME << 16) | 13;
        /*5986*/
        const int CefRequest_GetFlags_14 = (_typeNAME << 16) | 14;
        /*5987*/
        const int CefRequest_SetFlags_15 = (_typeNAME << 16) | 15;
        /*5988*/
        const int CefRequest_GetFirstPartyForCookies_16 = (_typeNAME << 16) | 16;
        /*5989*/
        const int CefRequest_SetFirstPartyForCookies_17 = (_typeNAME << 16) | 17;
        /*5990*/
        const int CefRequest_GetResourceType_18 = (_typeNAME << 16) | 18;
        /*5991*/
        const int CefRequest_GetTransitionType_19 = (_typeNAME << 16) | 19;
        /*5992*/
        const int CefRequest_GetIdentifier_20 = (_typeNAME << 16) | 20;
        /*5993*/
        internal readonly IntPtr nativePtr;
        /*5994*/
        internal CefRequest(IntPtr nativePtr)
        {
            /*5995*/
            this.nativePtr = nativePtr;
            /*5996*/
        }
        /*5997*/
        public void Release()
        {
            /*5998*/
            JsValue ret;
            /*5999*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_Release_0, out ret);
            /*6000*/
        }
        /// <summary>
        /// CefRequest methods.
        /// </summary>
        /*6001*/


        // gen! bool IsReadOnly()
        /*6002*/

        public bool IsReadOnly()/*6003*/
        {
            JsValue ret;
            /*6004*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_IsReadOnly_1, out ret);
            /*6005*/
            var ret_result = ret.I32 != 0;
            /*6006*/
            return ret_result;
            /*6007*/
        }
        /// <summary>
        /// Get the fully qualified URL.
        /// /*cef()*/
        /// </summary>
        /*6008*/


        // gen! CefString GetURL()
        /*6009*/

        public string GetURL()/*6010*/
        {
            JsValue ret;
            /*6011*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetURL_2, out ret);
            /*6012*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6013*/
            return ret_result;
            /*6014*/
        }
        /// <summary>
        /// Set the fully qualified URL.
        /// /*cef()*/
        /// </summary>
        /*6015*/


        // gen! void SetURL(const CefString& url)
        /*6016*/

        public void SetURL(string /*6017*/
        url
        )/*6018*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*6019*/
            ;
            /*6020*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetURL_3, out ret, ref v1);
            /*6021*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6022*/
            ;
            /*6023*/
        }
        /// <summary>
        /// Get the request method type. The value will default to POST if post data
        /// is provided and GET otherwise.
        /// /*cef()*/
        /// </summary>
        /*6024*/


        // gen! CefString GetMethod()
        /*6025*/

        public string GetMethod()/*6026*/
        {
            JsValue ret;
            /*6027*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetMethod_4, out ret);
            /*6028*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6029*/
            return ret_result;
            /*6030*/
        }
        /// <summary>
        /// Set the request method type.
        /// /*cef()*/
        /// </summary>
        /*6031*/


        // gen! void SetMethod(const CefString& method)
        /*6032*/

        public void SetMethod(string /*6033*/
        method
        )/*6034*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(method);
            /*6035*/
            ;
            /*6036*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetMethod_5, out ret, ref v1);
            /*6037*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6038*/
            ;
            /*6039*/
        }
        /// <summary>
        /// Set the referrer URL and policy. If non-empty the referrer URL must be
        /// fully qualified with an HTTP or HTTPS scheme component. Any username,
        /// password or ref component will be removed.
        /// /*cef()*/
        /// </summary>
        /*6040*/


        // gen! void SetReferrer(const CefString& referrer_url,ReferrerPolicy policy)
        /*6041*/

        public void SetReferrer(string /*6042*/
        referrer_url
        , cef_referrer_policy_t /*6043*/
        policy
        )/*6044*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(referrer_url);
            /*6045*/
            ;
            /*6046*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequest_SetReferrer_6, out ret, ref v1, ref v2);
            /*6047*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6048*/
            ;
            /*6049*/
        }
        /// <summary>
        /// Get the referrer URL.
        /// /*cef()*/
        /// </summary>
        /*6050*/


        // gen! CefString GetReferrerURL()
        /*6051*/

        public string GetReferrerURL()/*6052*/
        {
            JsValue ret;
            /*6053*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetReferrerURL_7, out ret);
            /*6054*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6055*/
            return ret_result;
            /*6056*/
        }
        /// <summary>
        /// Get the referrer policy.
        /// /*cef(default_retval=REFERRER_POLICY_DEFAULT)*/
        /// </summary>
        /*6057*/


        // gen! ReferrerPolicy GetReferrerPolicy()
        /*6058*/

        public cef_referrer_policy_t GetReferrerPolicy()/*6059*/
        {
            JsValue ret;
            /*6060*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetReferrerPolicy_8, out ret);
            /*6061*/
            var ret_result = (cef_referrer_policy_t)ret.I32;

            /*6062*/
            return ret_result;
            /*6063*/
        }
        /// <summary>
        /// Get the post data.
        /// /*cef()*/
        /// </summary>
        /*6064*/


        // gen! CefRefPtr<CefPostData> GetPostData()
        /*6065*/

        public CefPostData GetPostData()/*6066*/
        {
            JsValue ret;
            /*6067*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetPostData_9, out ret);
            /*6068*/
            var ret_result = new CefPostData(ret.Ptr);
            /*6069*/
            return ret_result;
            /*6070*/
        }
        /// <summary>
        /// Set the post data.
        /// /*cef()*/
        /// </summary>
        /*6071*/


        // gen! void SetPostData(CefRefPtr<CefPostData> postData)
        /*6072*/

        public void SetPostData(CefPostData /*6073*/
        postData
        )/*6074*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6075*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetPostData_10, out ret, ref v1);
            /*6076*/

            /*6077*/
        }
        /// <summary>
        /// Get the header values. Will not include the Referer value if any.
        /// /*cef()*/
        /// </summary>
        /*6078*/


        // gen! void GetHeaderMap(HeaderMap& headerMap)
        /*6079*/

        public void GetHeaderMap(HeaderMap /*6080*/
        headerMap
        )/*6081*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6082*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_GetHeaderMap_11, out ret, ref v1);
            /*6083*/

            /*6084*/
        }
        /// <summary>
        /// Set the header values. If a Referer value exists in the header map it will
        /// be removed and ignored.
        /// /*cef()*/
        /// </summary>
        /*6085*/


        // gen! void SetHeaderMap(const HeaderMap& headerMap)
        /*6086*/

        public void SetHeaderMap(HeaderMap /*6087*/
        headerMap
        )/*6088*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6089*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetHeaderMap_12, out ret, ref v1);
            /*6090*/

            /*6091*/
        }
        /// <summary>
        /// Set all values at one time.
        /// /*cef(optional_param=postData)*/
        /// </summary>
        /*6092*/


        // gen! void Set(const CefString& url,const CefString& method,CefRefPtr<CefPostData> postData,const HeaderMap& headerMap)
        /*6093*/

        public void Set(string /*6094*/
        url
        , string /*6095*/
        method
        , CefPostData /*6096*/
        postData
        , HeaderMap /*6097*/
        headerMap
        )/*6098*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*6099*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(method);
            /*6100*/
            ;
            /*6101*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefRequest_Set_13, out ret, ref v1, ref v2, ref v3, ref v4);
            /*6102*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6103*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*6104*/
            ;
            /*6105*/
        }
        /// <summary>
        /// Get the flags used in combination with CefURLRequest. See
        /// cef_urlrequest_flags_t for supported values.
        /// /*cef(default_retval=UR_FLAG_NONE)*/
        /// </summary>
        /*6106*/


        // gen! int GetFlags()
        /*6107*/

        public int GetFlags()/*6108*/
        {
            JsValue ret;
            /*6109*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetFlags_14, out ret);
            /*6110*/
            var ret_result = ret.I32;
            /*6111*/
            return ret_result;
            /*6112*/
        }
        /// <summary>
        /// Set the flags used in combination with CefURLRequest.  See
        /// cef_urlrequest_flags_t for supported values.
        /// /*cef()*/
        /// </summary>
        /*6113*/


        // gen! void SetFlags(int flags)
        /*6114*/

        public void SetFlags(int /*6115*/
        flags
        )/*6116*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6117*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetFlags_15, out ret, ref v1);
            /*6118*/

            /*6119*/
        }
        /// <summary>
        /// Set the URL to the first party for cookies used in combination with
        /// CefURLRequest.
        /// /*cef()*/
        /// </summary>
        /*6120*/


        // gen! CefString GetFirstPartyForCookies()
        /*6121*/

        public string GetFirstPartyForCookies()/*6122*/
        {
            JsValue ret;
            /*6123*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetFirstPartyForCookies_16, out ret);
            /*6124*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6125*/
            return ret_result;
            /*6126*/
        }
        /// <summary>
        /// Get the URL to the first party for cookies used in combination with
        /// CefURLRequest.
        /// /*cef()*/
        /// </summary>
        /*6127*/


        // gen! void SetFirstPartyForCookies(const CefString& url)
        /*6128*/

        public void SetFirstPartyForCookies(string /*6129*/
        url
        )/*6130*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*6131*/
            ;
            /*6132*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetFirstPartyForCookies_17, out ret, ref v1);
            /*6133*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6134*/
            ;
            /*6135*/
        }
        /// <summary>
        /// Get the resource type for this request. Only available in the browser
        /// process.
        /// /*cef(default_retval=RT_SUB_RESOURCE)*/
        /// </summary>
        /*6136*/


        // gen! ResourceType GetResourceType()
        /*6137*/

        public cef_resource_type_t GetResourceType()/*6138*/
        {
            JsValue ret;
            /*6139*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetResourceType_18, out ret);
            /*6140*/
            var ret_result = (cef_resource_type_t)ret.I32;

            /*6141*/
            return ret_result;
            /*6142*/
        }
        /// <summary>
        /// Get the transition type for this request. Only available in the browser
        /// process and only applies to requests that represent a main frame or
        /// sub-frame navigation.
        /// /*cef(default_retval=TT_EXPLICIT)*/
        /// </summary>
        /*6143*/


        // gen! TransitionType GetTransitionType()
        /*6144*/

        public cef_transition_type_t GetTransitionType()/*6145*/
        {
            JsValue ret;
            /*6146*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetTransitionType_19, out ret);
            /*6147*/
            var ret_result = (cef_transition_type_t)ret.I32;

            /*6148*/
            return ret_result;
            /*6149*/
        }
        /// <summary>
        /// Returns the globally unique identifier for this request or 0 if not
        /// specified. Can be used by CefRequestHandler implementations in the browser
        /// process to track a single request across multiple callbacks.
        /// /*cef()*/
        /// </summary>
        /*6150*/


        // gen! uint64 GetIdentifier()
        /*6151*/

        public ulong GetIdentifier()/*6152*/
        {
            JsValue ret;
            /*6153*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetIdentifier_20, out ret);
            /*6154*/
            var ret_result = (ulong)ret.I64;
            /*6155*/
            return ret_result;
            /*6156*/
        }
        /*6157*/
    }


    // [virtual] class CefPostData
    /// <summary>
    /// Class used to represent post data for a web request. The methods of this
    /// class may be called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*6201*/
    public struct CefPostData
    {
        /*6202*/
        const int _typeNAME = 23;
        /*6203*/
        const int CefPostData_Release_0 = (_typeNAME << 16) | 0;
        /*6204*/
        const int CefPostData_IsReadOnly_1 = (_typeNAME << 16) | 1;
        /*6205*/
        const int CefPostData_HasExcludedElements_2 = (_typeNAME << 16) | 2;
        /*6206*/
        const int CefPostData_GetElementCount_3 = (_typeNAME << 16) | 3;
        /*6207*/
        const int CefPostData_GetElements_4 = (_typeNAME << 16) | 4;
        /*6208*/
        const int CefPostData_RemoveElement_5 = (_typeNAME << 16) | 5;
        /*6209*/
        const int CefPostData_AddElement_6 = (_typeNAME << 16) | 6;
        /*6210*/
        const int CefPostData_RemoveElements_7 = (_typeNAME << 16) | 7;
        /*6211*/
        internal readonly IntPtr nativePtr;
        /*6212*/
        internal CefPostData(IntPtr nativePtr)
        {
            /*6213*/
            this.nativePtr = nativePtr;
            /*6214*/
        }
        /*6215*/
        public void Release()
        {
            /*6216*/
            JsValue ret;
            /*6217*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_Release_0, out ret);
            /*6218*/
        }
        /// <summary>
        /// CefPostData methods.
        /// </summary>
        /*6219*/


        // gen! bool IsReadOnly()
        /*6220*/

        public bool IsReadOnly()/*6221*/
        {
            JsValue ret;
            /*6222*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_IsReadOnly_1, out ret);
            /*6223*/
            var ret_result = ret.I32 != 0;
            /*6224*/
            return ret_result;
            /*6225*/
        }
        /// <summary>
        /// Returns true if the underlying POST data includes elements that are not
        /// represented by this CefPostData object (for example, multi-part file upload
        /// data). Modifying CefPostData objects with excluded elements may result in
        /// the request failing.
        /// /*cef()*/
        /// </summary>
        /*6226*/


        // gen! bool HasExcludedElements()
        /*6227*/

        public bool HasExcludedElements()/*6228*/
        {
            JsValue ret;
            /*6229*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_HasExcludedElements_2, out ret);
            /*6230*/
            var ret_result = ret.I32 != 0;
            /*6231*/
            return ret_result;
            /*6232*/
        }
        /// <summary>
        /// Returns the number of existing post data elements.
        /// /*cef()*/
        /// </summary>
        /*6233*/


        // gen! size_t GetElementCount()
        /*6234*/

        public uint GetElementCount()/*6235*/
        {
            JsValue ret;
            /*6236*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_GetElementCount_3, out ret);
            /*6237*/
            var ret_result = (uint)ret.I32;
            /*6238*/
            return ret_result;
            /*6239*/
        }
        /// <summary>
        /// Retrieve the post data elements.
        /// /*cef(count_func=elements:GetElementCount)*/
        /// </summary>
        /*6240*/


        // gen! void GetElements(ElementVector& elements)
        /*6241*/

        public void GetElements(ElementVector /*6242*/
        elements
        )/*6243*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6244*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_GetElements_4, out ret, ref v1);
            /*6245*/

            /*6246*/
        }
        /// <summary>
        /// Remove the specified post data element.  Returns true if the removal
        /// succeeds.
        /// /*cef()*/
        /// </summary>
        /*6247*/


        // gen! bool RemoveElement(CefRefPtr<CefPostDataElement> element)
        /*6248*/

        public bool RemoveElement(CefPostDataElement /*6249*/
        element
        )/*6250*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6251*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_RemoveElement_5, out ret, ref v1);
            /*6252*/
            var ret_result = ret.I32 != 0;
            /*6253*/
            return ret_result;
            /*6254*/
        }
        /// <summary>
        /// Add the specified post data element.  Returns true if the add succeeds.
        /// /*cef()*/
        /// </summary>
        /*6255*/


        // gen! bool AddElement(CefRefPtr<CefPostDataElement> element)
        /*6256*/

        public bool AddElement(CefPostDataElement /*6257*/
        element
        )/*6258*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6259*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_AddElement_6, out ret, ref v1);
            /*6260*/
            var ret_result = ret.I32 != 0;
            /*6261*/
            return ret_result;
            /*6262*/
        }
        /// <summary>
        /// Remove all existing post data elements.
        /// /*cef()*/
        /// </summary>
        /*6263*/


        // gen! void RemoveElements()
        /*6264*/

        public void RemoveElements()/*6265*/
        {
            JsValue ret;
            /*6266*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_RemoveElements_7, out ret);
            /*6267*/

            /*6268*/
        }
        /*6269*/
    }


    // [virtual] class CefPostDataElement
    /// <summary>
    /// Class used to represent a single element in the request post data. The
    /// methods of this class may be called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*6318*/
    public struct CefPostDataElement
    {
        /*6319*/
        const int _typeNAME = 24;
        /*6320*/
        const int CefPostDataElement_Release_0 = (_typeNAME << 16) | 0;
        /*6321*/
        const int CefPostDataElement_IsReadOnly_1 = (_typeNAME << 16) | 1;
        /*6322*/
        const int CefPostDataElement_SetToEmpty_2 = (_typeNAME << 16) | 2;
        /*6323*/
        const int CefPostDataElement_SetToFile_3 = (_typeNAME << 16) | 3;
        /*6324*/
        const int CefPostDataElement_SetToBytes_4 = (_typeNAME << 16) | 4;
        /*6325*/
        const int CefPostDataElement_GetType_5 = (_typeNAME << 16) | 5;
        /*6326*/
        const int CefPostDataElement_GetFile_6 = (_typeNAME << 16) | 6;
        /*6327*/
        const int CefPostDataElement_GetBytesCount_7 = (_typeNAME << 16) | 7;
        /*6328*/
        const int CefPostDataElement_GetBytes_8 = (_typeNAME << 16) | 8;
        /*6329*/
        internal readonly IntPtr nativePtr;
        /*6330*/
        internal CefPostDataElement(IntPtr nativePtr)
        {
            /*6331*/
            this.nativePtr = nativePtr;
            /*6332*/
        }
        /*6333*/
        public void Release()
        {
            /*6334*/
            JsValue ret;
            /*6335*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_Release_0, out ret);
            /*6336*/
        }
        /// <summary>
        /// CefPostDataElement methods.
        /// </summary>
        /*6337*/


        // gen! bool IsReadOnly()
        /*6338*/

        public bool IsReadOnly()/*6339*/
        {
            JsValue ret;
            /*6340*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_IsReadOnly_1, out ret);
            /*6341*/
            var ret_result = ret.I32 != 0;
            /*6342*/
            return ret_result;
            /*6343*/
        }
        /// <summary>
        /// Remove all contents from the post data element.
        /// /*cef()*/
        /// </summary>
        /*6344*/


        // gen! void SetToEmpty()
        /*6345*/

        public void SetToEmpty()/*6346*/
        {
            JsValue ret;
            /*6347*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_SetToEmpty_2, out ret);
            /*6348*/

            /*6349*/
        }
        /// <summary>
        /// The post data element will represent a file.
        /// /*cef()*/
        /// </summary>
        /*6350*/


        // gen! void SetToFile(const CefString& fileName)
        /*6351*/

        public void SetToFile(string /*6352*/
        fileName
        )/*6353*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(fileName);
            /*6354*/
            ;
            /*6355*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostDataElement_SetToFile_3, out ret, ref v1);
            /*6356*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6357*/
            ;
            /*6358*/
        }
        /// <summary>
        /// The post data element will represent bytes.  The bytes passed
        /// in will be copied.
        /// /*cef()*/
        /// </summary>
        /*6359*/


        // gen! void SetToBytes(size_t size,const void* bytes)
        /*6360*/

        public void SetToBytes(uint /*6361*/
        size
        , IntPtr /*6362*/
        bytes
        )/*6363*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*6364*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefPostDataElement_SetToBytes_4, out ret, ref v1, ref v2);
            /*6365*/

            /*6366*/
        }
        /// <summary>
        /// Return the type of this post data element.
        /// /*cef(default_retval=PDE_TYPE_EMPTY)*/
        /// </summary>
        /*6367*/


        // gen! Type GetType()
        /*6368*/

        public cef_postdataelement_type_t _GetType()/*6369*/
        {
            JsValue ret;
            /*6370*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetType_5, out ret);
            /*6371*/
            var ret_result = (cef_postdataelement_type_t)ret.I32;

            /*6372*/
            return ret_result;
            /*6373*/
        }
        /// <summary>
        /// Return the file name.
        /// /*cef()*/
        /// </summary>
        /*6374*/


        // gen! CefString GetFile()
        /*6375*/

        public string GetFile()/*6376*/
        {
            JsValue ret;
            /*6377*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetFile_6, out ret);
            /*6378*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6379*/
            return ret_result;
            /*6380*/
        }
        /// <summary>
        /// Return the number of bytes.
        /// /*cef()*/
        /// </summary>
        /*6381*/


        // gen! size_t GetBytesCount()
        /*6382*/

        public uint GetBytesCount()/*6383*/
        {
            JsValue ret;
            /*6384*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetBytesCount_7, out ret);
            /*6385*/
            var ret_result = (uint)ret.I32;
            /*6386*/
            return ret_result;
            /*6387*/
        }
        /// <summary>
        /// Read up to |size| bytes into |bytes| and return the number of bytes
        /// actually read.
        /// /*cef()*/
        /// </summary>
        /*6388*/


        // gen! size_t GetBytes(size_t size,void* bytes)
        /*6389*/

        public uint GetBytes(uint /*6390*/
        size
        , IntPtr /*6391*/
        bytes
        )/*6392*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*6393*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefPostDataElement_GetBytes_8, out ret, ref v1, ref v2);
            /*6394*/
            var ret_result = (uint)ret.I32;
            /*6395*/
            return ret_result;
            /*6396*/
        }
        /*6397*/
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
    /*6496*/
    public struct CefRequestContext
    {
        /*6497*/
        const int _typeNAME = 25;
        /*6498*/
        const int CefRequestContext_Release_0 = (_typeNAME << 16) | 0;
        /*6499*/
        const int CefRequestContext_IsSame_1 = (_typeNAME << 16) | 1;
        /*6500*/
        const int CefRequestContext_IsSharingWith_2 = (_typeNAME << 16) | 2;
        /*6501*/
        const int CefRequestContext_IsGlobal_3 = (_typeNAME << 16) | 3;
        /*6502*/
        const int CefRequestContext_GetHandler_4 = (_typeNAME << 16) | 4;
        /*6503*/
        const int CefRequestContext_GetCachePath_5 = (_typeNAME << 16) | 5;
        /*6504*/
        const int CefRequestContext_GetDefaultCookieManager_6 = (_typeNAME << 16) | 6;
        /*6505*/
        const int CefRequestContext_RegisterSchemeHandlerFactory_7 = (_typeNAME << 16) | 7;
        /*6506*/
        const int CefRequestContext_ClearSchemeHandlerFactories_8 = (_typeNAME << 16) | 8;
        /*6507*/
        const int CefRequestContext_PurgePluginListCache_9 = (_typeNAME << 16) | 9;
        /*6508*/
        const int CefRequestContext_HasPreference_10 = (_typeNAME << 16) | 10;
        /*6509*/
        const int CefRequestContext_GetPreference_11 = (_typeNAME << 16) | 11;
        /*6510*/
        const int CefRequestContext_GetAllPreferences_12 = (_typeNAME << 16) | 12;
        /*6511*/
        const int CefRequestContext_CanSetPreference_13 = (_typeNAME << 16) | 13;
        /*6512*/
        const int CefRequestContext_SetPreference_14 = (_typeNAME << 16) | 14;
        /*6513*/
        const int CefRequestContext_ClearCertificateExceptions_15 = (_typeNAME << 16) | 15;
        /*6514*/
        const int CefRequestContext_CloseAllConnections_16 = (_typeNAME << 16) | 16;
        /*6515*/
        const int CefRequestContext_ResolveHost_17 = (_typeNAME << 16) | 17;
        /*6516*/
        const int CefRequestContext_ResolveHostCached_18 = (_typeNAME << 16) | 18;
        /*6517*/
        internal readonly IntPtr nativePtr;
        /*6518*/
        internal CefRequestContext(IntPtr nativePtr)
        {
            /*6519*/
            this.nativePtr = nativePtr;
            /*6520*/
        }
        /*6521*/
        public void Release()
        {
            /*6522*/
            JsValue ret;
            /*6523*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_Release_0, out ret);
            /*6524*/
        }
        /// <summary>
        /// CefRequestContext methods.
        /// </summary>
        /*6525*/


        // gen! bool IsSame(CefRefPtr<CefRequestContext> other)
        /*6526*/

        public bool IsSame(CefRequestContext /*6527*/
        other
        )/*6528*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6529*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_IsSame_1, out ret, ref v1);
            /*6530*/
            var ret_result = ret.I32 != 0;
            /*6531*/
            return ret_result;
            /*6532*/
        }
        /// <summary>
        /// Returns true if this object is sharing the same storage as |that| object.
        /// /*cef()*/
        /// </summary>
        /*6533*/


        // gen! bool IsSharingWith(CefRefPtr<CefRequestContext> other)
        /*6534*/

        public bool IsSharingWith(CefRequestContext /*6535*/
        other
        )/*6536*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6537*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_IsSharingWith_2, out ret, ref v1);
            /*6538*/
            var ret_result = ret.I32 != 0;
            /*6539*/
            return ret_result;
            /*6540*/
        }
        /// <summary>
        /// Returns true if this object is the global context. The global context is
        /// used by default when creating a browser or URL request with a NULL context
        /// argument.
        /// /*cef()*/
        /// </summary>
        /*6541*/


        // gen! bool IsGlobal()
        /*6542*/

        public bool IsGlobal()/*6543*/
        {
            JsValue ret;
            /*6544*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_IsGlobal_3, out ret);
            /*6545*/
            var ret_result = ret.I32 != 0;
            /*6546*/
            return ret_result;
            /*6547*/
        }
        /// <summary>
        /// Returns the handler for this context if any.
        /// /*cef()*/
        /// </summary>
        /*6548*/


        // gen! CefRefPtr<CefRequestContextHandler> GetHandler()
        /*6549*/

        public CefRequestContextHandler GetHandler()/*6550*/
        {
            JsValue ret;
            /*6551*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_GetHandler_4, out ret);
            /*6552*/
            var ret_result = new CefRequestContextHandler(ret.Ptr);
            /*6553*/
            return ret_result;
            /*6554*/
        }
        /// <summary>
        /// Returns the cache path for this object. If empty an "incognito mode"
        /// in-memory cache is being used.
        /// /*cef()*/
        /// </summary>
        /*6555*/


        // gen! CefString GetCachePath()
        /*6556*/

        public string GetCachePath()/*6557*/
        {
            JsValue ret;
            /*6558*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_GetCachePath_5, out ret);
            /*6559*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6560*/
            return ret_result;
            /*6561*/
        }
        /// <summary>
        /// Returns the default cookie manager for this object. This will be the global
        /// cookie manager if this object is the global request context. Otherwise,
        /// this will be the default cookie manager used when this request context does
        /// not receive a value via CefRequestContextHandler::GetCookieManager(). If
        /// |callback| is non-NULL it will be executed asnychronously on the IO thread
        /// after the manager's storage has been initialized.
        /// /*cef(optional_param=callback)*/
        /// </summary>
        /*6562*/


        // gen! CefRefPtr<CefCookieManager> GetDefaultCookieManager(CefRefPtr<CefCompletionCallback> callback)
        /*6563*/

        public CefCookieManager GetDefaultCookieManager(CefCompletionCallback /*6564*/
        callback
        )/*6565*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6566*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetDefaultCookieManager_6, out ret, ref v1);
            /*6567*/
            var ret_result = new CefCookieManager(ret.Ptr);
            /*6568*/
            return ret_result;
            /*6569*/
        }
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
        /*6570*/


        // gen! bool RegisterSchemeHandlerFactory(const CefString& scheme_name,const CefString& domain_name,CefRefPtr<CefSchemeHandlerFactory> factory)
        /*6571*/

        public bool RegisterSchemeHandlerFactory(string /*6572*/
        scheme_name
        , string /*6573*/
        domain_name
        , CefSchemeHandlerFactory /*6574*/
        factory
        )/*6575*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(scheme_name);
            /*6576*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(domain_name);
            /*6577*/
            ;
            /*6578*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefRequestContext_RegisterSchemeHandlerFactory_7, out ret, ref v1, ref v2, ref v3);
            /*6579*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6580*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*6581*/
            ;
            /*6582*/
            return ret_result;
            /*6583*/
        }
        /// <summary>
        /// Clear all registered scheme handler factories. Returns false on error. This
        /// function may be called on any thread in the browser process.
        /// /*cef()*/
        /// </summary>
        /*6584*/


        // gen! bool ClearSchemeHandlerFactories()
        /*6585*/

        public bool ClearSchemeHandlerFactories()/*6586*/
        {
            JsValue ret;
            /*6587*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_ClearSchemeHandlerFactories_8, out ret);
            /*6588*/
            var ret_result = ret.I32 != 0;
            /*6589*/
            return ret_result;
            /*6590*/
        }
        /// <summary>
        /// Tells all renderer processes associated with this context to throw away
        /// their plugin list cache. If |reload_pages| is true they will also reload
        /// all pages with plugins. CefRequestContextHandler::OnBeforePluginLoad may
        /// be called to rebuild the plugin list cache.
        /// /*cef()*/
        /// </summary>
        /*6591*/


        // gen! void PurgePluginListCache(bool reload_pages)
        /*6592*/

        public void PurgePluginListCache(bool /*6593*/
        reload_pages
        )/*6594*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6595*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_PurgePluginListCache_9, out ret, ref v1);
            /*6596*/

            /*6597*/
        }
        /// <summary>
        /// Returns true if a preference with the specified |name| exists. This method
        /// must be called on the browser process UI thread.
        /// /*cef()*/
        /// </summary>
        /*6598*/


        // gen! bool HasPreference(const CefString& name)
        /*6599*/

        public bool HasPreference(string /*6600*/
        name
        )/*6601*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6602*/
            ;
            /*6603*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_HasPreference_10, out ret, ref v1);
            /*6604*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6605*/
            ;
            /*6606*/
            return ret_result;
            /*6607*/
        }
        /// <summary>
        /// Returns the value for the preference with the specified |name|. Returns
        /// NULL if the preference does not exist. The returned object contains a copy
        /// of the underlying preference value and modifications to the returned object
        /// will not modify the underlying preference value. This method must be called
        /// on the browser process UI thread.
        /// /*cef()*/
        /// </summary>
        /*6608*/


        // gen! CefRefPtr<CefValue> GetPreference(const CefString& name)
        /*6609*/

        public CefValue GetPreference(string /*6610*/
        name
        )/*6611*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6612*/
            ;
            /*6613*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetPreference_11, out ret, ref v1);
            /*6614*/
            var ret_result = new CefValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6615*/
            ;
            /*6616*/
            return ret_result;
            /*6617*/
        }
        /// <summary>
        /// Returns all preferences as a dictionary. If |include_defaults| is true then
        /// preferences currently at their default value will be included. The returned
        /// object contains a copy of the underlying preference values and
        /// modifications to the returned object will not modify the underlying
        /// preference values. This method must be called on the browser process UI
        /// thread.
        /// /*cef()*/
        /// </summary>
        /*6618*/


        // gen! CefRefPtr<CefDictionaryValue> GetAllPreferences(bool include_defaults)
        /*6619*/

        public CefDictionaryValue GetAllPreferences(bool /*6620*/
        include_defaults
        )/*6621*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6622*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetAllPreferences_12, out ret, ref v1);
            /*6623*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            /*6624*/
            return ret_result;
            /*6625*/
        }
        /// <summary>
        /// Returns true if the preference with the specified |name| can be modified
        /// using SetPreference. As one example preferences set via the command-line
        /// usually cannot be modified. This method must be called on the browser
        /// process UI thread.
        /// /*cef()*/
        /// </summary>
        /*6626*/


        // gen! bool CanSetPreference(const CefString& name)
        /*6627*/

        public bool CanSetPreference(string /*6628*/
        name
        )/*6629*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6630*/
            ;
            /*6631*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_CanSetPreference_13, out ret, ref v1);
            /*6632*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6633*/
            ;
            /*6634*/
            return ret_result;
            /*6635*/
        }
        /// <summary>
        /// Set the |value| associated with preference |name|. Returns true if the
        /// value is set successfully and false otherwise. If |value| is NULL the
        /// preference will be restored to its default value. If setting the preference
        /// fails then |error| will be populated with a detailed description of the
        /// problem. This method must be called on the browser process UI thread.
        /// /*cef(optional_param=value)*/
        /// </summary>
        /*6636*/


        // gen! bool SetPreference(const CefString& name,CefRefPtr<CefValue> value,CefString& error)
        /*6637*/

        public bool SetPreference(string /*6638*/
        name
        , CefValue /*6639*/
        value
        , string /*6640*/
        error
        )/*6641*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6642*/
            ;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(error);
            /*6643*/
            ;
            /*6644*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefRequestContext_SetPreference_14, out ret, ref v1, ref v2, ref v3);
            /*6645*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6646*/
            ;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*6647*/
            ;
            /*6648*/
            return ret_result;
            /*6649*/
        }
        /// <summary>
        /// Clears all certificate exceptions that were added as part of handling
        /// CefRequestHandler::OnCertificateError(). If you call this it is
        /// recommended that you also call CloseAllConnections() or you risk not
        /// being prompted again for server certificates if you reconnect quickly.
        /// If |callback| is non-NULL it will be executed on the UI thread after
        /// completion.
        /// /*cef(optional_param=callback)*/
        /// </summary>
        /*6650*/


        // gen! void ClearCertificateExceptions(CefRefPtr<CefCompletionCallback> callback)
        /*6651*/

        public void ClearCertificateExceptions(CefCompletionCallback /*6652*/
        callback
        )/*6653*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6654*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_ClearCertificateExceptions_15, out ret, ref v1);
            /*6655*/

            /*6656*/
        }
        /// <summary>
        /// Clears all active and idle connections that Chromium currently has.
        /// This is only recommended if you have released all other CEF objects but
        /// don't yet want to call CefShutdown(). If |callback| is non-NULL it will be
        /// executed on the UI thread after completion.
        /// /*cef(optional_param=callback)*/
        /// </summary>
        /*6657*/


        // gen! void CloseAllConnections(CefRefPtr<CefCompletionCallback> callback)
        /*6658*/

        public void CloseAllConnections(CefCompletionCallback /*6659*/
        callback
        )/*6660*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6661*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_CloseAllConnections_16, out ret, ref v1);
            /*6662*/

            /*6663*/
        }
        /// <summary>
        /// Attempts to resolve |origin| to a list of associated IP addresses.
        /// |callback| will be executed on the UI thread after completion.
        /// /*cef()*/
        /// </summary>
        /*6664*/


        // gen! void ResolveHost(const CefString& origin,CefRefPtr<CefResolveCallback> callback)
        /*6665*/

        public void ResolveHost(string /*6666*/
        origin
        , CefResolveCallback /*6667*/
        callback
        )/*6668*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(origin);
            /*6669*/
            ;
            /*6670*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequestContext_ResolveHost_17, out ret, ref v1, ref v2);
            /*6671*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6672*/
            ;
            /*6673*/
        }
        /// <summary>
        /// Attempts to resolve |origin| to a list of associated IP addresses using
        /// cached data. |resolved_ips| will be populated with the list of resolved IP
        /// addresses or empty if no cached data is available. Returns ERR_NONE on
        /// success. This method must be called on the browser process IO thread.
        /// /*cef(default_retval=ERR_FAILED)*/
        /// </summary>
        /*6674*/


        // gen! cef_errorcode_t ResolveHostCached(const CefString& origin,std::vector<CefString>& resolved_ips)
        /*6675*/

        public cef_errorcode_t ResolveHostCached(string /*6676*/
        origin
        , List<string> /*6677*/
        resolved_ips
        )/*6678*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(origin);
            /*6679*/
            ;
            /*6680*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequestContext_ResolveHostCached_18, out ret, ref v1, ref v2);
            /*6681*/
            var ret_result = (cef_errorcode_t)ret.I32;

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6682*/
            ;
            /*6683*/
            return ret_result;
            /*6684*/
        }
        /*6685*/
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
    /*6709*/
    public struct CefResourceBundle
    {
        /*6710*/
        const int _typeNAME = 26;
        /*6711*/
        const int CefResourceBundle_Release_0 = (_typeNAME << 16) | 0;
        /*6712*/
        const int CefResourceBundle_GetLocalizedString_1 = (_typeNAME << 16) | 1;
        /*6713*/
        const int CefResourceBundle_GetDataResource_2 = (_typeNAME << 16) | 2;
        /*6714*/
        const int CefResourceBundle_GetDataResourceForScale_3 = (_typeNAME << 16) | 3;
        /*6715*/
        internal readonly IntPtr nativePtr;
        /*6716*/
        internal CefResourceBundle(IntPtr nativePtr)
        {
            /*6717*/
            this.nativePtr = nativePtr;
            /*6718*/
        }
        /*6719*/
        public void Release()
        {
            /*6720*/
            JsValue ret;
            /*6721*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResourceBundle_Release_0, out ret);
            /*6722*/
        }
        /// <summary>
        /// CefResourceBundle methods.
        /// </summary>
        /*6723*/


        // gen! CefString GetLocalizedString(int string_id)
        /*6724*/

        public string GetLocalizedString(int /*6725*/
        string_id
        )/*6726*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6727*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResourceBundle_GetLocalizedString_1, out ret, ref v1);
            /*6728*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6729*/
            return ret_result;
            /*6730*/
        }
        /// <summary>
        /// Retrieves the contents of the specified scale independent |resource_id|.
        /// If the value is found then |data| and |data_size| will be populated and
        /// this method will return true. If the value is not found then this method
        /// will return false. The returned |data| pointer will remain resident in
        /// memory and should not be freed. Include cef_pack_resources.h for a listing
        /// of valid resource ID values.
        /// /*cef()*/
        /// </summary>
        /*6731*/


        // gen! bool GetDataResource(int resource_id,void*& data,size_t& data_size)
        /*6732*/

        public bool GetDataResource(int /*6733*/
        resource_id
        , IntPtr /*6734*/
        data
        , ref uint /*6735*/
        data_size
        )/*6736*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*6737*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefResourceBundle_GetDataResource_2, out ret, ref v1, ref v2, ref v3);
            /*6738*/
            var ret_result = ret.I32 != 0;
            data = v2.Ptr;/*6739*/
            ;
            data_size = (uint)v3.I32;/*6740*/
            ;
            /*6741*/
            return ret_result;
            /*6742*/
        }
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
        /*6743*/


        // gen! bool GetDataResourceForScale(int resource_id,ScaleFactor scale_factor,void*& data,size_t& data_size)
        /*6744*/

        public bool GetDataResourceForScale(int /*6745*/
        resource_id
        , cef_scale_factor_t /*6746*/
        scale_factor
        , IntPtr /*6747*/
        data
        , ref uint /*6748*/
        data_size
        )/*6749*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            /*6750*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefResourceBundle_GetDataResourceForScale_3, out ret, ref v1, ref v2, ref v3, ref v4);
            /*6751*/
            var ret_result = ret.I32 != 0;
            data = v3.Ptr;/*6752*/
            ;
            data_size = (uint)v4.I32;/*6753*/
            ;
            /*6754*/
            return ret_result;
            /*6755*/
        }
        /*6756*/
    }


    // [virtual] class CefResponse
    /// <summary>
    /// Class used to represent a web response. The methods of this class may be
    /// called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*6825*/
    public struct CefResponse
    {
        /*6826*/
        const int _typeNAME = 27;
        /*6827*/
        const int CefResponse_Release_0 = (_typeNAME << 16) | 0;
        /*6828*/
        const int CefResponse_IsReadOnly_1 = (_typeNAME << 16) | 1;
        /*6829*/
        const int CefResponse_GetError_2 = (_typeNAME << 16) | 2;
        /*6830*/
        const int CefResponse_SetError_3 = (_typeNAME << 16) | 3;
        /*6831*/
        const int CefResponse_GetStatus_4 = (_typeNAME << 16) | 4;
        /*6832*/
        const int CefResponse_SetStatus_5 = (_typeNAME << 16) | 5;
        /*6833*/
        const int CefResponse_GetStatusText_6 = (_typeNAME << 16) | 6;
        /*6834*/
        const int CefResponse_SetStatusText_7 = (_typeNAME << 16) | 7;
        /*6835*/
        const int CefResponse_GetMimeType_8 = (_typeNAME << 16) | 8;
        /*6836*/
        const int CefResponse_SetMimeType_9 = (_typeNAME << 16) | 9;
        /*6837*/
        const int CefResponse_GetHeader_10 = (_typeNAME << 16) | 10;
        /*6838*/
        const int CefResponse_GetHeaderMap_11 = (_typeNAME << 16) | 11;
        /*6839*/
        const int CefResponse_SetHeaderMap_12 = (_typeNAME << 16) | 12;
        /*6840*/
        internal readonly IntPtr nativePtr;
        /*6841*/
        internal CefResponse(IntPtr nativePtr)
        {
            /*6842*/
            this.nativePtr = nativePtr;
            /*6843*/
        }
        /*6844*/
        public void Release()
        {
            /*6845*/
            JsValue ret;
            /*6846*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_Release_0, out ret);
            /*6847*/
        }
        /// <summary>
        /// CefResponse methods.
        /// </summary>
        /*6848*/


        // gen! bool IsReadOnly()
        /*6849*/

        public bool IsReadOnly()/*6850*/
        {
            JsValue ret;
            /*6851*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_IsReadOnly_1, out ret);
            /*6852*/
            var ret_result = ret.I32 != 0;
            /*6853*/
            return ret_result;
            /*6854*/
        }
        /// <summary>
        /// Get the response error code. Returns ERR_NONE if there was no error.
        /// /*cef(default_retval=ERR_NONE)*/
        /// </summary>
        /*6855*/


        // gen! cef_errorcode_t GetError()
        /*6856*/

        public cef_errorcode_t GetError()/*6857*/
        {
            JsValue ret;
            /*6858*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetError_2, out ret);
            /*6859*/
            var ret_result = (cef_errorcode_t)ret.I32;

            /*6860*/
            return ret_result;
            /*6861*/
        }
        /// <summary>
        /// Set the response error code. This can be used by custom scheme handlers
        /// to return errors during initial request processing.
        /// /*cef()*/
        /// </summary>
        /*6862*/


        // gen! void SetError(cef_errorcode_t error)
        /*6863*/

        public void SetError(cef_errorcode_t /*6864*/
        error
        )/*6865*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6866*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetError_3, out ret, ref v1);
            /*6867*/

            /*6868*/
        }
        /// <summary>
        /// Get the response status code.
        /// /*cef()*/
        /// </summary>
        /*6869*/


        // gen! int GetStatus()
        /*6870*/

        public int GetStatus()/*6871*/
        {
            JsValue ret;
            /*6872*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetStatus_4, out ret);
            /*6873*/
            var ret_result = ret.I32;
            /*6874*/
            return ret_result;
            /*6875*/
        }
        /// <summary>
        /// Set the response status code.
        /// /*cef()*/
        /// </summary>
        /*6876*/


        // gen! void SetStatus(int status)
        /*6877*/

        public void SetStatus(int /*6878*/
        status
        )/*6879*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6880*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetStatus_5, out ret, ref v1);
            /*6881*/

            /*6882*/
        }
        /// <summary>
        /// Get the response status text.
        /// /*cef()*/
        /// </summary>
        /*6883*/


        // gen! CefString GetStatusText()
        /*6884*/

        public string GetStatusText()/*6885*/
        {
            JsValue ret;
            /*6886*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetStatusText_6, out ret);
            /*6887*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6888*/
            return ret_result;
            /*6889*/
        }
        /// <summary>
        /// Set the response status text.
        /// /*cef()*/
        /// </summary>
        /*6890*/


        // gen! void SetStatusText(const CefString& statusText)
        /*6891*/

        public void SetStatusText(string /*6892*/
        statusText
        )/*6893*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(statusText);
            /*6894*/
            ;
            /*6895*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetStatusText_7, out ret, ref v1);
            /*6896*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6897*/
            ;
            /*6898*/
        }
        /// <summary>
        /// Get the response mime type.
        /// /*cef()*/
        /// </summary>
        /*6899*/


        // gen! CefString GetMimeType()
        /*6900*/

        public string GetMimeType()/*6901*/
        {
            JsValue ret;
            /*6902*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetMimeType_8, out ret);
            /*6903*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6904*/
            return ret_result;
            /*6905*/
        }
        /// <summary>
        /// Set the response mime type.
        /// /*cef()*/
        /// </summary>
        /*6906*/


        // gen! void SetMimeType(const CefString& mimeType)
        /*6907*/

        public void SetMimeType(string /*6908*/
        mimeType
        )/*6909*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(mimeType);
            /*6910*/
            ;
            /*6911*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetMimeType_9, out ret, ref v1);
            /*6912*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6913*/
            ;
            /*6914*/
        }
        /// <summary>
        /// Get the value for the specified response header field.
        /// /*cef()*/
        /// </summary>
        /*6915*/


        // gen! CefString GetHeader(const CefString& name)
        /*6916*/

        public string GetHeader(string /*6917*/
        name
        )/*6918*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6919*/
            ;
            /*6920*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_GetHeader_10, out ret, ref v1);
            /*6921*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6922*/
            ;
            /*6923*/
            return ret_result;
            /*6924*/
        }
        /// <summary>
        /// Get all response header fields.
        /// /*cef()*/
        /// </summary>
        /*6925*/


        // gen! void GetHeaderMap(HeaderMap& headerMap)
        /*6926*/

        public void GetHeaderMap(HeaderMap /*6927*/
        headerMap
        )/*6928*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6929*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_GetHeaderMap_11, out ret, ref v1);
            /*6930*/

            /*6931*/
        }
        /// <summary>
        /// Set all response header fields.
        /// /*cef()*/
        /// </summary>
        /*6932*/


        // gen! void SetHeaderMap(const HeaderMap& headerMap)
        /*6933*/

        public void SetHeaderMap(HeaderMap /*6934*/
        headerMap
        )/*6935*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*6936*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetHeaderMap_12, out ret, ref v1);
            /*6937*/

            /*6938*/
        }
        /*6939*/
    }


    // [virtual] class CefResponseFilter
    /// <summary>
    /// Implement this interface to filter resource response content. The methods of
    /// this class will be called on the browser process IO thread.
    /// /*(source=client)*/
    /// </summary>
    /*6948*/
    public struct CefResponseFilter
    {
        /*6949*/
        const int _typeNAME = 28;
        /*6950*/
        const int CefResponseFilter_Release_0 = (_typeNAME << 16) | 0;
        /*6951*/
        internal readonly IntPtr nativePtr;
        /*6952*/
        internal CefResponseFilter(IntPtr nativePtr)
        {
            /*6953*/
            this.nativePtr = nativePtr;
            /*6954*/
        }
        /*6955*/
        public void Release()
        {
            /*6956*/
            JsValue ret;
            /*6957*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponseFilter_Release_0, out ret);
            /*6958*/
        }
        /*6959*/
    }


    // [virtual] class CefSchemeHandlerFactory
    /// <summary>
    /// Class that creates CefResourceHandler instances for handling scheme requests.
    /// The methods of this class will always be called on the IO thread.
    /// /*(source=client)*/
    /// </summary>
    /*6968*/
    public struct CefSchemeHandlerFactory
    {
        /*6969*/
        const int _typeNAME = 29;
        /*6970*/
        const int CefSchemeHandlerFactory_Release_0 = (_typeNAME << 16) | 0;
        /*6971*/
        internal readonly IntPtr nativePtr;
        /*6972*/
        internal CefSchemeHandlerFactory(IntPtr nativePtr)
        {
            /*6973*/
            this.nativePtr = nativePtr;
            /*6974*/
        }
        /*6975*/
        public void Release()
        {
            /*6976*/
            JsValue ret;
            /*6977*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSchemeHandlerFactory_Release_0, out ret);
            /*6978*/
        }
        /*6979*/
    }


    // [virtual] class CefSSLInfo
    /// <summary>
    /// Class representing SSL information.
    /// /*(source=library)*/
    /// </summary>
    /*6998*/
    public struct CefSSLInfo
    {
        /*6999*/
        const int _typeNAME = 30;
        /*7000*/
        const int CefSSLInfo_Release_0 = (_typeNAME << 16) | 0;
        /*7001*/
        const int CefSSLInfo_GetCertStatus_1 = (_typeNAME << 16) | 1;
        /*7002*/
        const int CefSSLInfo_GetX509Certificate_2 = (_typeNAME << 16) | 2;
        /*7003*/
        internal readonly IntPtr nativePtr;
        /*7004*/
        internal CefSSLInfo(IntPtr nativePtr)
        {
            /*7005*/
            this.nativePtr = nativePtr;
            /*7006*/
        }
        /*7007*/
        public void Release()
        {
            /*7008*/
            JsValue ret;
            /*7009*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_Release_0, out ret);
            /*7010*/
        }
        /// <summary>
        /// CefSSLInfo methods.
        /// </summary>
        /*7011*/


        // gen! cef_cert_status_t GetCertStatus()
        /*7012*/

        public cef_cert_status_t GetCertStatus()/*7013*/
        {
            JsValue ret;
            /*7014*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_GetCertStatus_1, out ret);
            /*7015*/
            var ret_result = (cef_cert_status_t)ret.I32;

            /*7016*/
            return ret_result;
            /*7017*/
        }
        /// <summary>
        /// Returns the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*7018*/


        // gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
        /*7019*/

        public CefX509Certificate GetX509Certificate()/*7020*/
        {
            JsValue ret;
            /*7021*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_GetX509Certificate_2, out ret);
            /*7022*/
            var ret_result = new CefX509Certificate(ret.Ptr);
            /*7023*/
            return ret_result;
            /*7024*/
        }
        /*7025*/
    }


    // [virtual] class CefSSLStatus
    /// <summary>
    /// Class representing the SSL information for a navigation entry.
    /// /*(source=library)*/
    /// </summary>
    /*7059*/
    public struct CefSSLStatus
    {
        /*7060*/
        const int _typeNAME = 31;
        /*7061*/
        const int CefSSLStatus_Release_0 = (_typeNAME << 16) | 0;
        /*7062*/
        const int CefSSLStatus_IsSecureConnection_1 = (_typeNAME << 16) | 1;
        /*7063*/
        const int CefSSLStatus_GetCertStatus_2 = (_typeNAME << 16) | 2;
        /*7064*/
        const int CefSSLStatus_GetSSLVersion_3 = (_typeNAME << 16) | 3;
        /*7065*/
        const int CefSSLStatus_GetContentStatus_4 = (_typeNAME << 16) | 4;
        /*7066*/
        const int CefSSLStatus_GetX509Certificate_5 = (_typeNAME << 16) | 5;
        /*7067*/
        internal readonly IntPtr nativePtr;
        /*7068*/
        internal CefSSLStatus(IntPtr nativePtr)
        {
            /*7069*/
            this.nativePtr = nativePtr;
            /*7070*/
        }
        /*7071*/
        public void Release()
        {
            /*7072*/
            JsValue ret;
            /*7073*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_Release_0, out ret);
            /*7074*/
        }
        /// <summary>
        /// CefSSLStatus methods.
        /// </summary>
        /*7075*/


        // gen! bool IsSecureConnection()
        /*7076*/

        public bool IsSecureConnection()/*7077*/
        {
            JsValue ret;
            /*7078*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_IsSecureConnection_1, out ret);
            /*7079*/
            var ret_result = ret.I32 != 0;
            /*7080*/
            return ret_result;
            /*7081*/
        }
        /// <summary>
        /// Returns a bitmask containing any and all problems verifying the server
        /// certificate.
        /// /*cef(default_retval=CERT_STATUS_NONE)*/
        /// </summary>
        /*7082*/


        // gen! cef_cert_status_t GetCertStatus()
        /*7083*/

        public cef_cert_status_t GetCertStatus()/*7084*/
        {
            JsValue ret;
            /*7085*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetCertStatus_2, out ret);
            /*7086*/
            var ret_result = (cef_cert_status_t)ret.I32;

            /*7087*/
            return ret_result;
            /*7088*/
        }
        /// <summary>
        /// Returns the SSL version used for the SSL connection.
        /// /*cef(default_retval=SSL_CONNECTION_VERSION_UNKNOWN)*/
        /// </summary>
        /*7089*/


        // gen! cef_ssl_version_t GetSSLVersion()
        /*7090*/

        public cef_ssl_version_t GetSSLVersion()/*7091*/
        {
            JsValue ret;
            /*7092*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetSSLVersion_3, out ret);
            /*7093*/
            var ret_result = (cef_ssl_version_t)ret.I32;

            /*7094*/
            return ret_result;
            /*7095*/
        }
        /// <summary>
        /// Returns a bitmask containing the page security content status.
        /// /*cef(default_retval=SSL_CONTENT_NORMAL_CONTENT)*/
        /// </summary>
        /*7096*/


        // gen! cef_ssl_content_status_t GetContentStatus()
        /*7097*/

        public cef_ssl_content_status_t GetContentStatus()/*7098*/
        {
            JsValue ret;
            /*7099*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetContentStatus_4, out ret);
            /*7100*/
            var ret_result = (cef_ssl_content_status_t)ret.I32;

            /*7101*/
            return ret_result;
            /*7102*/
        }
        /// <summary>
        /// Returns the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*7103*/


        // gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
        /*7104*/

        public CefX509Certificate GetX509Certificate()/*7105*/
        {
            JsValue ret;
            /*7106*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetX509Certificate_5, out ret);
            /*7107*/
            var ret_result = new CefX509Certificate(ret.Ptr);
            /*7108*/
            return ret_result;
            /*7109*/
        }
        /*7110*/
    }


    // [virtual] class CefStreamReader
    /// <summary>
    /// Class used to read data from a stream. The methods of this class may be
    /// called on any thread.
    /// /*(source=library)*/
    /// </summary>
    /*7144*/
    public struct CefStreamReader
    {
        /*7145*/
        const int _typeNAME = 32;
        /*7146*/
        const int CefStreamReader_Release_0 = (_typeNAME << 16) | 0;
        /*7147*/
        const int CefStreamReader_Read_1 = (_typeNAME << 16) | 1;
        /*7148*/
        const int CefStreamReader_Seek_2 = (_typeNAME << 16) | 2;
        /*7149*/
        const int CefStreamReader_Tell_3 = (_typeNAME << 16) | 3;
        /*7150*/
        const int CefStreamReader_Eof_4 = (_typeNAME << 16) | 4;
        /*7151*/
        const int CefStreamReader_MayBlock_5 = (_typeNAME << 16) | 5;
        /*7152*/
        internal readonly IntPtr nativePtr;
        /*7153*/
        internal CefStreamReader(IntPtr nativePtr)
        {
            /*7154*/
            this.nativePtr = nativePtr;
            /*7155*/
        }
        /*7156*/
        public void Release()
        {
            /*7157*/
            JsValue ret;
            /*7158*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Release_0, out ret);
            /*7159*/
        }
        /// <summary>
        /// CefStreamReader methods.
        /// </summary>
        /*7160*/


        // gen! size_t Read(void* ptr,size_t size,size_t n)
        /*7161*/

        public uint Read(IntPtr /*7162*/
        ptr
        , uint /*7163*/
        size
        , uint /*7164*/
        n
        )/*7165*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*7166*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefStreamReader_Read_1, out ret, ref v1, ref v2, ref v3);
            /*7167*/
            var ret_result = (uint)ret.I32;
            /*7168*/
            return ret_result;
            /*7169*/
        }
        /// <summary>
        /// Seek to the specified offset position. |whence| may be any one of
        /// SEEK_CUR, SEEK_END or SEEK_SET. Returns zero on success and non-zero on
        /// failure.
        /// /*cef()*/
        /// </summary>
        /*7170*/


        // gen! int Seek(int64 offset,int whence)
        /*7171*/

        public int Seek(long /*7172*/
        offset
        , int /*7173*/
        whence
        )/*7174*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*7175*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefStreamReader_Seek_2, out ret, ref v1, ref v2);
            /*7176*/
            var ret_result = ret.I32;
            /*7177*/
            return ret_result;
            /*7178*/
        }
        /// <summary>
        /// Return the current offset position.
        /// /*cef()*/
        /// </summary>
        /*7179*/


        // gen! int64 Tell()
        /*7180*/

        public long Tell()/*7181*/
        {
            JsValue ret;
            /*7182*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Tell_3, out ret);
            /*7183*/
            var ret_result = ret.I64;
            /*7184*/
            return ret_result;
            /*7185*/
        }
        /// <summary>
        /// Return non-zero if at end of file.
        /// /*cef()*/
        /// </summary>
        /*7186*/


        // gen! int Eof()
        /*7187*/

        public int Eof()/*7188*/
        {
            JsValue ret;
            /*7189*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Eof_4, out ret);
            /*7190*/
            var ret_result = ret.I32;
            /*7191*/
            return ret_result;
            /*7192*/
        }
        /// <summary>
        /// Returns true if this reader performs work like accessing the file system
        /// which may block. Used as a hint for determining the thread to access the
        /// reader from.
        /// /*cef()*/
        /// </summary>
        /*7193*/


        // gen! bool MayBlock()
        /*7194*/

        public bool MayBlock()/*7195*/
        {
            JsValue ret;
            /*7196*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_MayBlock_5, out ret);
            /*7197*/
            var ret_result = ret.I32 != 0;
            /*7198*/
            return ret_result;
            /*7199*/
        }
        /*7200*/
    }


    // [virtual] class CefStreamWriter
    /// <summary>
    /// Class used to write data to a stream. The methods of this class may be called
    /// on any thread.
    /// /*(source=library)*/
    /// </summary>
    /*7234*/
    public struct CefStreamWriter
    {
        /*7235*/
        const int _typeNAME = 33;
        /*7236*/
        const int CefStreamWriter_Release_0 = (_typeNAME << 16) | 0;
        /*7237*/
        const int CefStreamWriter_Write_1 = (_typeNAME << 16) | 1;
        /*7238*/
        const int CefStreamWriter_Seek_2 = (_typeNAME << 16) | 2;
        /*7239*/
        const int CefStreamWriter_Tell_3 = (_typeNAME << 16) | 3;
        /*7240*/
        const int CefStreamWriter_Flush_4 = (_typeNAME << 16) | 4;
        /*7241*/
        const int CefStreamWriter_MayBlock_5 = (_typeNAME << 16) | 5;
        /*7242*/
        internal readonly IntPtr nativePtr;
        /*7243*/
        internal CefStreamWriter(IntPtr nativePtr)
        {
            /*7244*/
            this.nativePtr = nativePtr;
            /*7245*/
        }
        /*7246*/
        public void Release()
        {
            /*7247*/
            JsValue ret;
            /*7248*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Release_0, out ret);
            /*7249*/
        }
        /// <summary>
        /// CefStreamWriter methods.
        /// </summary>
        /*7250*/


        // gen! size_t Write(const void* ptr,size_t size,size_t n)
        /*7251*/

        public uint Write(IntPtr /*7252*/
        ptr
        , uint /*7253*/
        size
        , uint /*7254*/
        n
        )/*7255*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*7256*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefStreamWriter_Write_1, out ret, ref v1, ref v2, ref v3);
            /*7257*/
            var ret_result = (uint)ret.I32;
            /*7258*/
            return ret_result;
            /*7259*/
        }
        /// <summary>
        /// Seek to the specified offset position. |whence| may be any one of
        /// SEEK_CUR, SEEK_END or SEEK_SET. Returns zero on success and non-zero on
        /// failure.
        /// /*cef()*/
        /// </summary>
        /*7260*/


        // gen! int Seek(int64 offset,int whence)
        /*7261*/

        public int Seek(long /*7262*/
        offset
        , int /*7263*/
        whence
        )/*7264*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*7265*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefStreamWriter_Seek_2, out ret, ref v1, ref v2);
            /*7266*/
            var ret_result = ret.I32;
            /*7267*/
            return ret_result;
            /*7268*/
        }
        /// <summary>
        /// Return the current offset position.
        /// /*cef()*/
        /// </summary>
        /*7269*/


        // gen! int64 Tell()
        /*7270*/

        public long Tell()/*7271*/
        {
            JsValue ret;
            /*7272*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Tell_3, out ret);
            /*7273*/
            var ret_result = ret.I64;
            /*7274*/
            return ret_result;
            /*7275*/
        }
        /// <summary>
        /// Flush the stream.
        /// /*cef()*/
        /// </summary>
        /*7276*/


        // gen! int Flush()
        /*7277*/

        public int Flush()/*7278*/
        {
            JsValue ret;
            /*7279*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Flush_4, out ret);
            /*7280*/
            var ret_result = ret.I32;
            /*7281*/
            return ret_result;
            /*7282*/
        }
        /// <summary>
        /// Returns true if this writer performs work like accessing the file system
        /// which may block. Used as a hint for determining the thread to access the
        /// writer from.
        /// /*cef()*/
        /// </summary>
        /*7283*/


        // gen! bool MayBlock()
        /*7284*/

        public bool MayBlock()/*7285*/
        {
            JsValue ret;
            /*7286*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_MayBlock_5, out ret);
            /*7287*/
            var ret_result = ret.I32 != 0;
            /*7288*/
            return ret_result;
            /*7289*/
        }
        /*7290*/
    }


    // [virtual] class CefStringVisitor
    /// <summary>
    /// Implement this interface to receive string values asynchronously.
    /// /*(source=client)*/
    /// </summary>
    /*7299*/
    public struct CefStringVisitor
    {
        /*7300*/
        const int _typeNAME = 34;
        /*7301*/
        const int CefStringVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*7302*/
        internal readonly IntPtr nativePtr;
        /*7303*/
        internal CefStringVisitor(IntPtr nativePtr)
        {
            /*7304*/
            this.nativePtr = nativePtr;
            /*7305*/
        }
        /*7306*/
        public void Release()
        {
            /*7307*/
            JsValue ret;
            /*7308*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStringVisitor_Release_0, out ret);
            /*7309*/
        }
        /*7310*/
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
    /*7319*/
    public struct CefTask
    {
        /*7320*/
        const int _typeNAME = 35;
        /*7321*/
        const int CefTask_Release_0 = (_typeNAME << 16) | 0;
        /*7322*/
        internal readonly IntPtr nativePtr;
        /*7323*/
        internal CefTask(IntPtr nativePtr)
        {
            /*7324*/
            this.nativePtr = nativePtr;
            /*7325*/
        }
        /*7326*/
        public void Release()
        {
            /*7327*/
            JsValue ret;
            /*7328*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTask_Release_0, out ret);
            /*7329*/
        }
        /*7330*/
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
    /*7364*/
    public struct CefTaskRunner
    {
        /*7365*/
        const int _typeNAME = 36;
        /*7366*/
        const int CefTaskRunner_Release_0 = (_typeNAME << 16) | 0;
        /*7367*/
        const int CefTaskRunner_IsSame_1 = (_typeNAME << 16) | 1;
        /*7368*/
        const int CefTaskRunner_BelongsToCurrentThread_2 = (_typeNAME << 16) | 2;
        /*7369*/
        const int CefTaskRunner_BelongsToThread_3 = (_typeNAME << 16) | 3;
        /*7370*/
        const int CefTaskRunner_PostTask_4 = (_typeNAME << 16) | 4;
        /*7371*/
        const int CefTaskRunner_PostDelayedTask_5 = (_typeNAME << 16) | 5;
        /*7372*/
        internal readonly IntPtr nativePtr;
        /*7373*/
        internal CefTaskRunner(IntPtr nativePtr)
        {
            /*7374*/
            this.nativePtr = nativePtr;
            /*7375*/
        }
        /*7376*/
        public void Release()
        {
            /*7377*/
            JsValue ret;
            /*7378*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTaskRunner_Release_0, out ret);
            /*7379*/
        }
        /// <summary>
        /// CefTaskRunner methods.
        /// </summary>
        /*7380*/


        // gen! bool IsSame(CefRefPtr<CefTaskRunner> that)
        /*7381*/

        public bool IsSame(CefTaskRunner /*7382*/
        that
        )/*7383*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*7384*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_IsSame_1, out ret, ref v1);
            /*7385*/
            var ret_result = ret.I32 != 0;
            /*7386*/
            return ret_result;
            /*7387*/
        }
        /// <summary>
        /// Returns true if this task runner belongs to the current thread.
        /// /*cef()*/
        /// </summary>
        /*7388*/


        // gen! bool BelongsToCurrentThread()
        /*7389*/

        public bool BelongsToCurrentThread()/*7390*/
        {
            JsValue ret;
            /*7391*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTaskRunner_BelongsToCurrentThread_2, out ret);
            /*7392*/
            var ret_result = ret.I32 != 0;
            /*7393*/
            return ret_result;
            /*7394*/
        }
        /// <summary>
        /// Returns true if this task runner is for the specified CEF thread.
        /// /*cef()*/
        /// </summary>
        /*7395*/


        // gen! bool BelongsToThread(CefThreadId threadId)
        /*7396*/

        public bool BelongsToThread(cef_thread_id_t /*7397*/
        threadId
        )/*7398*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*7399*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_BelongsToThread_3, out ret, ref v1);
            /*7400*/
            var ret_result = ret.I32 != 0;
            /*7401*/
            return ret_result;
            /*7402*/
        }
        /// <summary>
        /// Post a task for execution on the thread associated with this task runner.
        /// Execution will occur asynchronously.
        /// /*cef()*/
        /// </summary>
        /*7403*/


        // gen! bool PostTask(CefRefPtr<CefTask> task)
        /*7404*/

        public bool PostTask(CefTask /*7405*/
        task
        )/*7406*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*7407*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_PostTask_4, out ret, ref v1);
            /*7408*/
            var ret_result = ret.I32 != 0;
            /*7409*/
            return ret_result;
            /*7410*/
        }
        /// <summary>
        /// Post a task for delayed execution on the thread associated with this task
        /// runner. Execution will occur asynchronously. Delayed tasks are not
        /// supported on V8 WebWorker threads and will be executed without the
        /// specified delay.
        /// /*cef()*/
        /// </summary>
        /*7411*/


        // gen! bool PostDelayedTask(CefRefPtr<CefTask> task,int64 delay_ms)
        /*7412*/

        public bool PostDelayedTask(CefTask /*7413*/
        task
        , long /*7414*/
        delay_ms
        )/*7415*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*7416*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefTaskRunner_PostDelayedTask_5, out ret, ref v1, ref v2);
            /*7417*/
            var ret_result = ret.I32 != 0;
            /*7418*/
            return ret_result;
            /*7419*/
        }
        /*7420*/
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
    /*7459*/
    public struct CefURLRequest
    {
        /*7460*/
        const int _typeNAME = 37;
        /*7461*/
        const int CefURLRequest_Release_0 = (_typeNAME << 16) | 0;
        /*7462*/
        const int CefURLRequest_GetRequest_1 = (_typeNAME << 16) | 1;
        /*7463*/
        const int CefURLRequest_GetClient_2 = (_typeNAME << 16) | 2;
        /*7464*/
        const int CefURLRequest_GetRequestStatus_3 = (_typeNAME << 16) | 3;
        /*7465*/
        const int CefURLRequest_GetRequestError_4 = (_typeNAME << 16) | 4;
        /*7466*/
        const int CefURLRequest_GetResponse_5 = (_typeNAME << 16) | 5;
        /*7467*/
        const int CefURLRequest_Cancel_6 = (_typeNAME << 16) | 6;
        /*7468*/
        internal readonly IntPtr nativePtr;
        /*7469*/
        internal CefURLRequest(IntPtr nativePtr)
        {
            /*7470*/
            this.nativePtr = nativePtr;
            /*7471*/
        }
        /*7472*/
        public void Release()
        {
            /*7473*/
            JsValue ret;
            /*7474*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_Release_0, out ret);
            /*7475*/
        }
        /// <summary>
        /// CefURLRequest methods.
        /// </summary>
        /*7476*/


        // gen! CefRefPtr<CefRequest> GetRequest()
        /*7477*/

        public CefRequest GetRequest()/*7478*/
        {
            JsValue ret;
            /*7479*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequest_1, out ret);
            /*7480*/
            var ret_result = new CefRequest(ret.Ptr);
            /*7481*/
            return ret_result;
            /*7482*/
        }
        /// <summary>
        /// Returns the client.
        /// /*cef()*/
        /// </summary>
        /*7483*/


        // gen! CefRefPtr<CefURLRequestClient> GetClient()
        /*7484*/

        public CefURLRequestClient GetClient()/*7485*/
        {
            JsValue ret;
            /*7486*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetClient_2, out ret);
            /*7487*/
            var ret_result = new CefURLRequestClient(ret.Ptr);
            /*7488*/
            return ret_result;
            /*7489*/
        }
        /// <summary>
        /// Returns the request status.
        /// /*cef(default_retval=UR_UNKNOWN)*/
        /// </summary>
        /*7490*/


        // gen! Status GetRequestStatus()
        /*7491*/

        public cef_urlrequest_status_t GetRequestStatus()/*7492*/
        {
            JsValue ret;
            /*7493*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequestStatus_3, out ret);
            /*7494*/
            var ret_result = (cef_urlrequest_status_t)ret.I32;

            /*7495*/
            return ret_result;
            /*7496*/
        }
        /// <summary>
        /// Returns the request error if status is UR_CANCELED or UR_FAILED, or 0
        /// otherwise.
        /// /*cef(default_retval=ERR_NONE)*/
        /// </summary>
        /*7497*/


        // gen! ErrorCode GetRequestError()
        /*7498*/

        public cef_errorcode_t GetRequestError()/*7499*/
        {
            JsValue ret;
            /*7500*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequestError_4, out ret);
            /*7501*/
            var ret_result = (cef_errorcode_t)ret.I32;

            /*7502*/
            return ret_result;
            /*7503*/
        }
        /// <summary>
        /// Returns the response, or NULL if no response information is available.
        /// Response information will only be available after the upload has completed.
        /// The returned object is read-only and should not be modified.
        /// /*cef()*/
        /// </summary>
        /*7504*/


        // gen! CefRefPtr<CefResponse> GetResponse()
        /*7505*/

        public CefResponse GetResponse()/*7506*/
        {
            JsValue ret;
            /*7507*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetResponse_5, out ret);
            /*7508*/
            var ret_result = new CefResponse(ret.Ptr);
            /*7509*/
            return ret_result;
            /*7510*/
        }
        /// <summary>
        /// Cancel the request.
        /// /*cef()*/
        /// </summary>
        /*7511*/


        // gen! void Cancel()
        /*7512*/

        public void Cancel()/*7513*/
        {
            JsValue ret;
            /*7514*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_Cancel_6, out ret);
            /*7515*/

            /*7516*/
        }
        /*7517*/
    }


    // [virtual] class CefURLRequestClient
    /// <summary>
    /// Interface that should be implemented by the CefURLRequest client. The
    /// methods of this class will be called on the same thread that created the
    /// request unless otherwise documented.
    /// /*(source=client)*/
    /// </summary>
    /*7526*/
    public struct CefURLRequestClient
    {
        /*7527*/
        const int _typeNAME = 38;
        /*7528*/
        const int CefURLRequestClient_Release_0 = (_typeNAME << 16) | 0;
        /*7529*/
        internal readonly IntPtr nativePtr;
        /*7530*/
        internal CefURLRequestClient(IntPtr nativePtr)
        {
            /*7531*/
            this.nativePtr = nativePtr;
            /*7532*/
        }
        /*7533*/
        public void Release()
        {
            /*7534*/
            JsValue ret;
            /*7535*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequestClient_Release_0, out ret);
            /*7536*/
        }
        /*7537*/
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
    /*7591*/
    public struct CefV8Context
    {
        /*7592*/
        const int _typeNAME = 39;
        /*7593*/
        const int CefV8Context_Release_0 = (_typeNAME << 16) | 0;
        /*7594*/
        const int CefV8Context_GetTaskRunner_1 = (_typeNAME << 16) | 1;
        /*7595*/
        const int CefV8Context_IsValid_2 = (_typeNAME << 16) | 2;
        /*7596*/
        const int CefV8Context_GetBrowser_3 = (_typeNAME << 16) | 3;
        /*7597*/
        const int CefV8Context_GetFrame_4 = (_typeNAME << 16) | 4;
        /*7598*/
        const int CefV8Context_GetGlobal_5 = (_typeNAME << 16) | 5;
        /*7599*/
        const int CefV8Context_Enter_6 = (_typeNAME << 16) | 6;
        /*7600*/
        const int CefV8Context_Exit_7 = (_typeNAME << 16) | 7;
        /*7601*/
        const int CefV8Context_IsSame_8 = (_typeNAME << 16) | 8;
        /*7602*/
        const int CefV8Context_Eval_9 = (_typeNAME << 16) | 9;
        /*7603*/
        internal readonly IntPtr nativePtr;
        /*7604*/
        internal CefV8Context(IntPtr nativePtr)
        {
            /*7605*/
            this.nativePtr = nativePtr;
            /*7606*/
        }
        /*7607*/
        public void Release()
        {
            /*7608*/
            JsValue ret;
            /*7609*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Release_0, out ret);
            /*7610*/
        }
        /// <summary>
        /// CefV8Context methods.
        /// </summary>
        /*7611*/


        // gen! CefRefPtr<CefTaskRunner> GetTaskRunner()
        /*7612*/

        public CefTaskRunner GetTaskRunner()/*7613*/
        {
            JsValue ret;
            /*7614*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetTaskRunner_1, out ret);
            /*7615*/
            var ret_result = new CefTaskRunner(ret.Ptr);
            /*7616*/
            return ret_result;
            /*7617*/
        }
        /// <summary>
        /// Returns true if the underlying handle is valid and it can be accessed on
        /// the current thread. Do not call any other methods if this method returns
        /// false.
        /// /*cef()*/
        /// </summary>
        /*7618*/


        // gen! bool IsValid()
        /*7619*/

        public bool IsValid()/*7620*/
        {
            JsValue ret;
            /*7621*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_IsValid_2, out ret);
            /*7622*/
            var ret_result = ret.I32 != 0;
            /*7623*/
            return ret_result;
            /*7624*/
        }
        /// <summary>
        /// Returns the browser for this context. This method will return an empty
        /// reference for WebWorker contexts.
        /// /*cef()*/
        /// </summary>
        /*7625*/


        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /*7626*/

        public CefBrowser GetBrowser()/*7627*/
        {
            JsValue ret;
            /*7628*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetBrowser_3, out ret);
            /*7629*/
            var ret_result = new CefBrowser(ret.Ptr);
            /*7630*/
            return ret_result;
            /*7631*/
        }
        /// <summary>
        /// Returns the frame for this context. This method will return an empty
        /// reference for WebWorker contexts.
        /// /*cef()*/
        /// </summary>
        /*7632*/


        // gen! CefRefPtr<CefFrame> GetFrame()
        /*7633*/

        public CefFrame GetFrame()/*7634*/
        {
            JsValue ret;
            /*7635*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetFrame_4, out ret);
            /*7636*/
            var ret_result = new CefFrame(ret.Ptr);
            /*7637*/
            return ret_result;
            /*7638*/
        }
        /// <summary>
        /// Returns the global object for this context. The context must be entered
        /// before calling this method.
        /// /*cef()*/
        /// </summary>
        /*7639*/


        // gen! CefRefPtr<CefV8Value> GetGlobal()
        /*7640*/

        public CefV8Value GetGlobal()/*7641*/
        {
            JsValue ret;
            /*7642*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetGlobal_5, out ret);
            /*7643*/
            var ret_result = new CefV8Value(ret.Ptr);
            /*7644*/
            return ret_result;
            /*7645*/
        }
        /// <summary>
        /// Enter this context. A context must be explicitly entered before creating a
        /// V8 Object, Array, Function or Date asynchronously. Exit() must be called
        /// the same number of times as Enter() before releasing this context. V8
        /// objects belong to the context in which they are created. Returns true if
        /// the scope was entered successfully.
        /// /*cef()*/
        /// </summary>
        /*7646*/


        // gen! bool Enter()
        /*7647*/

        public bool Enter()/*7648*/
        {
            JsValue ret;
            /*7649*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Enter_6, out ret);
            /*7650*/
            var ret_result = ret.I32 != 0;
            /*7651*/
            return ret_result;
            /*7652*/
        }
        /// <summary>
        /// Exit this context. Call this method only after calling Enter(). Returns
        /// true if the scope was exited successfully.
        /// /*cef()*/
        /// </summary>
        /*7653*/


        // gen! bool Exit()
        /*7654*/

        public bool Exit()/*7655*/
        {
            JsValue ret;
            /*7656*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Exit_7, out ret);
            /*7657*/
            var ret_result = ret.I32 != 0;
            /*7658*/
            return ret_result;
            /*7659*/
        }
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>
        /*7660*/


        // gen! bool IsSame(CefRefPtr<CefV8Context> that)
        /*7661*/

        public bool IsSame(CefV8Context /*7662*/
        that
        )/*7663*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*7664*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Context_IsSame_8, out ret, ref v1);
            /*7665*/
            var ret_result = ret.I32 != 0;
            /*7666*/
            return ret_result;
            /*7667*/
        }
        /// <summary>
        /// Execute a string of JavaScript code in this V8 context. The |script_url|
        /// parameter is the URL where the script in question can be found, if any.
        /// The |start_line| parameter is the base line number to use for error
        /// reporting. On success |retval| will be set to the return value, if any, and
        /// the function will return true. On failure |exception| will be set to the
        /// exception, if any, and the function will return false.
        /// /*cef(optional_param=script_url)*/
        /// </summary>
        /*7668*/


        // gen! bool Eval(const CefString& code,const CefString& script_url,int start_line,CefRefPtr<CefV8Value>& retval,CefRefPtr<CefV8Exception>& exception)
        /*7669*/

        public bool Eval(string /*7670*/
        code
        , string /*7671*/
        script_url
        , int /*7672*/
        start_line
        , IntPtr /*7673*/
        retval
        , IntPtr /*7674*/
        exception
        )/*7675*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(code);
            /*7676*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(script_url);
            /*7677*/
            ;
            /*7678*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefV8Context_Eval_9, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*7679*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*7680*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*7681*/
            ;
            retval = v4.Ptr;/*7682*/
            ;
            exception = v5.Ptr;/*7683*/
            ;
            /*7684*/
            return ret_result;
            /*7685*/
        }
        /*7686*/
    }


    // [virtual] class CefV8Accessor
    /// <summary>
    /// Interface that should be implemented to handle V8 accessor calls. Accessor
    /// identifiers are registered by calling CefV8Value::SetValue(). The methods
    /// of this class will be called on the thread associated with the V8 accessor.
    /// /*(source=client)*/
    /// </summary>
    /*7695*/
    public struct CefV8Accessor
    {
        /*7696*/
        const int _typeNAME = 40;
        /*7697*/
        const int CefV8Accessor_Release_0 = (_typeNAME << 16) | 0;
        /*7698*/
        internal readonly IntPtr nativePtr;
        /*7699*/
        internal CefV8Accessor(IntPtr nativePtr)
        {
            /*7700*/
            this.nativePtr = nativePtr;
            /*7701*/
        }
        /*7702*/
        public void Release()
        {
            /*7703*/
            JsValue ret;
            /*7704*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Accessor_Release_0, out ret);
            /*7705*/
        }
        /*7706*/
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
    /*7715*/
    public struct CefV8Interceptor
    {
        /*7716*/
        const int _typeNAME = 41;
        /*7717*/
        const int CefV8Interceptor_Release_0 = (_typeNAME << 16) | 0;
        /*7718*/
        internal readonly IntPtr nativePtr;
        /*7719*/
        internal CefV8Interceptor(IntPtr nativePtr)
        {
            /*7720*/
            this.nativePtr = nativePtr;
            /*7721*/
        }
        /*7722*/
        public void Release()
        {
            /*7723*/
            JsValue ret;
            /*7724*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Interceptor_Release_0, out ret);
            /*7725*/
        }
        /*7726*/
    }


    // [virtual] class CefV8Exception
    /// <summary>
    /// Class representing a V8 exception. The methods of this class may be called on
    /// any render process thread.
    /// /*(source=library)*/
    /// </summary>
    /*7775*/
    public struct CefV8Exception
    {
        /*7776*/
        const int _typeNAME = 42;
        /*7777*/
        const int CefV8Exception_Release_0 = (_typeNAME << 16) | 0;
        /*7778*/
        const int CefV8Exception_GetMessage_1 = (_typeNAME << 16) | 1;
        /*7779*/
        const int CefV8Exception_GetSourceLine_2 = (_typeNAME << 16) | 2;
        /*7780*/
        const int CefV8Exception_GetScriptResourceName_3 = (_typeNAME << 16) | 3;
        /*7781*/
        const int CefV8Exception_GetLineNumber_4 = (_typeNAME << 16) | 4;
        /*7782*/
        const int CefV8Exception_GetStartPosition_5 = (_typeNAME << 16) | 5;
        /*7783*/
        const int CefV8Exception_GetEndPosition_6 = (_typeNAME << 16) | 6;
        /*7784*/
        const int CefV8Exception_GetStartColumn_7 = (_typeNAME << 16) | 7;
        /*7785*/
        const int CefV8Exception_GetEndColumn_8 = (_typeNAME << 16) | 8;
        /*7786*/
        internal readonly IntPtr nativePtr;
        /*7787*/
        internal CefV8Exception(IntPtr nativePtr)
        {
            /*7788*/
            this.nativePtr = nativePtr;
            /*7789*/
        }
        /*7790*/
        public void Release()
        {
            /*7791*/
            JsValue ret;
            /*7792*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_Release_0, out ret);
            /*7793*/
        }
        /// <summary>
        /// CefV8Exception methods.
        /// </summary>
        /*7794*/


        // gen! CefString GetMessage()
        /*7795*/

        public string GetMessage()/*7796*/
        {
            JsValue ret;
            /*7797*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetMessage_1, out ret);
            /*7798*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*7799*/
            return ret_result;
            /*7800*/
        }
        /// <summary>
        /// Returns the line of source code that the exception occurred within.
        /// /*cef()*/
        /// </summary>
        /*7801*/


        // gen! CefString GetSourceLine()
        /*7802*/

        public string GetSourceLine()/*7803*/
        {
            JsValue ret;
            /*7804*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetSourceLine_2, out ret);
            /*7805*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*7806*/
            return ret_result;
            /*7807*/
        }
        /// <summary>
        /// Returns the resource name for the script from where the function causing
        /// the error originates.
        /// /*cef()*/
        /// </summary>
        /*7808*/


        // gen! CefString GetScriptResourceName()
        /*7809*/

        public string GetScriptResourceName()/*7810*/
        {
            JsValue ret;
            /*7811*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetScriptResourceName_3, out ret);
            /*7812*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*7813*/
            return ret_result;
            /*7814*/
        }
        /// <summary>
        /// Returns the 1-based number of the line where the error occurred or 0 if the
        /// line number is unknown.
        /// /*cef()*/
        /// </summary>
        /*7815*/


        // gen! int GetLineNumber()
        /*7816*/

        public int GetLineNumber()/*7817*/
        {
            JsValue ret;
            /*7818*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetLineNumber_4, out ret);
            /*7819*/
            var ret_result = ret.I32;
            /*7820*/
            return ret_result;
            /*7821*/
        }
        /// <summary>
        /// Returns the index within the script of the first character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>
        /*7822*/


        // gen! int GetStartPosition()
        /*7823*/

        public int GetStartPosition()/*7824*/
        {
            JsValue ret;
            /*7825*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetStartPosition_5, out ret);
            /*7826*/
            var ret_result = ret.I32;
            /*7827*/
            return ret_result;
            /*7828*/
        }
        /// <summary>
        /// Returns the index within the script of the last character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>
        /*7829*/


        // gen! int GetEndPosition()
        /*7830*/

        public int GetEndPosition()/*7831*/
        {
            JsValue ret;
            /*7832*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetEndPosition_6, out ret);
            /*7833*/
            var ret_result = ret.I32;
            /*7834*/
            return ret_result;
            /*7835*/
        }
        /// <summary>
        /// Returns the index within the line of the first character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>
        /*7836*/


        // gen! int GetStartColumn()
        /*7837*/

        public int GetStartColumn()/*7838*/
        {
            JsValue ret;
            /*7839*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetStartColumn_7, out ret);
            /*7840*/
            var ret_result = ret.I32;
            /*7841*/
            return ret_result;
            /*7842*/
        }
        /// <summary>
        /// Returns the index within the line of the last character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>
        /*7843*/


        // gen! int GetEndColumn()
        /*7844*/

        public int GetEndColumn()/*7845*/
        {
            JsValue ret;
            /*7846*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetEndColumn_8, out ret);
            /*7847*/
            var ret_result = ret.I32;
            /*7848*/
            return ret_result;
            /*7849*/
        }
        /*7850*/
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
    /*8079*/
    public struct CefV8Value
    {
        /*8080*/
        const int _typeNAME = 43;
        /*8081*/
        const int CefV8Value_Release_0 = (_typeNAME << 16) | 0;
        /*8082*/
        const int CefV8Value_IsValid_1 = (_typeNAME << 16) | 1;
        /*8083*/
        const int CefV8Value_IsUndefined_2 = (_typeNAME << 16) | 2;
        /*8084*/
        const int CefV8Value_IsNull_3 = (_typeNAME << 16) | 3;
        /*8085*/
        const int CefV8Value_IsBool_4 = (_typeNAME << 16) | 4;
        /*8086*/
        const int CefV8Value_IsInt_5 = (_typeNAME << 16) | 5;
        /*8087*/
        const int CefV8Value_IsUInt_6 = (_typeNAME << 16) | 6;
        /*8088*/
        const int CefV8Value_IsDouble_7 = (_typeNAME << 16) | 7;
        /*8089*/
        const int CefV8Value_IsDate_8 = (_typeNAME << 16) | 8;
        /*8090*/
        const int CefV8Value_IsString_9 = (_typeNAME << 16) | 9;
        /*8091*/
        const int CefV8Value_IsObject_10 = (_typeNAME << 16) | 10;
        /*8092*/
        const int CefV8Value_IsArray_11 = (_typeNAME << 16) | 11;
        /*8093*/
        const int CefV8Value_IsFunction_12 = (_typeNAME << 16) | 12;
        /*8094*/
        const int CefV8Value_IsSame_13 = (_typeNAME << 16) | 13;
        /*8095*/
        const int CefV8Value_GetBoolValue_14 = (_typeNAME << 16) | 14;
        /*8096*/
        const int CefV8Value_GetIntValue_15 = (_typeNAME << 16) | 15;
        /*8097*/
        const int CefV8Value_GetUIntValue_16 = (_typeNAME << 16) | 16;
        /*8098*/
        const int CefV8Value_GetDoubleValue_17 = (_typeNAME << 16) | 17;
        /*8099*/
        const int CefV8Value_GetDateValue_18 = (_typeNAME << 16) | 18;
        /*8100*/
        const int CefV8Value_GetStringValue_19 = (_typeNAME << 16) | 19;
        /*8101*/
        const int CefV8Value_IsUserCreated_20 = (_typeNAME << 16) | 20;
        /*8102*/
        const int CefV8Value_HasException_21 = (_typeNAME << 16) | 21;
        /*8103*/
        const int CefV8Value_GetException_22 = (_typeNAME << 16) | 22;
        /*8104*/
        const int CefV8Value_ClearException_23 = (_typeNAME << 16) | 23;
        /*8105*/
        const int CefV8Value_WillRethrowExceptions_24 = (_typeNAME << 16) | 24;
        /*8106*/
        const int CefV8Value_SetRethrowExceptions_25 = (_typeNAME << 16) | 25;
        /*8107*/
        const int CefV8Value_HasValue_26 = (_typeNAME << 16) | 26;
        /*8108*/
        const int CefV8Value_HasValue_27 = (_typeNAME << 16) | 27;
        /*8109*/
        const int CefV8Value_DeleteValue_28 = (_typeNAME << 16) | 28;
        /*8110*/
        const int CefV8Value_DeleteValue_29 = (_typeNAME << 16) | 29;
        /*8111*/
        const int CefV8Value_GetValue_30 = (_typeNAME << 16) | 30;
        /*8112*/
        const int CefV8Value_GetValue_31 = (_typeNAME << 16) | 31;
        /*8113*/
        const int CefV8Value_SetValue_32 = (_typeNAME << 16) | 32;
        /*8114*/
        const int CefV8Value_SetValue_33 = (_typeNAME << 16) | 33;
        /*8115*/
        const int CefV8Value_SetValue_34 = (_typeNAME << 16) | 34;
        /*8116*/
        const int CefV8Value_GetKeys_35 = (_typeNAME << 16) | 35;
        /*8117*/
        const int CefV8Value_SetUserData_36 = (_typeNAME << 16) | 36;
        /*8118*/
        const int CefV8Value_GetUserData_37 = (_typeNAME << 16) | 37;
        /*8119*/
        const int CefV8Value_GetExternallyAllocatedMemory_38 = (_typeNAME << 16) | 38;
        /*8120*/
        const int CefV8Value_AdjustExternallyAllocatedMemory_39 = (_typeNAME << 16) | 39;
        /*8121*/
        const int CefV8Value_GetArrayLength_40 = (_typeNAME << 16) | 40;
        /*8122*/
        const int CefV8Value_GetFunctionName_41 = (_typeNAME << 16) | 41;
        /*8123*/
        const int CefV8Value_GetFunctionHandler_42 = (_typeNAME << 16) | 42;
        /*8124*/
        const int CefV8Value_ExecuteFunction_43 = (_typeNAME << 16) | 43;
        /*8125*/
        const int CefV8Value_ExecuteFunctionWithContext_44 = (_typeNAME << 16) | 44;
        /*8126*/
        internal readonly IntPtr nativePtr;
        /*8127*/
        internal CefV8Value(IntPtr nativePtr)
        {
            /*8128*/
            this.nativePtr = nativePtr;
            /*8129*/
        }
        /*8130*/
        public void Release()
        {
            /*8131*/
            JsValue ret;
            /*8132*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_Release_0, out ret);
            /*8133*/
        }
        /// <summary>
        /// CefV8Value methods.
        /// </summary>
        /*8134*/


        // gen! bool IsValid()
        /*8135*/

        public bool IsValid()/*8136*/
        {
            JsValue ret;
            /*8137*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsValid_1, out ret);
            /*8138*/
            var ret_result = ret.I32 != 0;
            /*8139*/
            return ret_result;
            /*8140*/
        }
        /// <summary>
        /// True if the value type is undefined.
        /// /*cef()*/
        /// </summary>
        /*8141*/


        // gen! bool IsUndefined()
        /*8142*/

        public bool IsUndefined()/*8143*/
        {
            JsValue ret;
            /*8144*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUndefined_2, out ret);
            /*8145*/
            var ret_result = ret.I32 != 0;
            /*8146*/
            return ret_result;
            /*8147*/
        }
        /// <summary>
        /// True if the value type is null.
        /// /*cef()*/
        /// </summary>
        /*8148*/


        // gen! bool IsNull()
        /*8149*/

        public bool IsNull()/*8150*/
        {
            JsValue ret;
            /*8151*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsNull_3, out ret);
            /*8152*/
            var ret_result = ret.I32 != 0;
            /*8153*/
            return ret_result;
            /*8154*/
        }
        /// <summary>
        /// True if the value type is bool.
        /// /*cef()*/
        /// </summary>
        /*8155*/


        // gen! bool IsBool()
        /*8156*/

        public bool IsBool()/*8157*/
        {
            JsValue ret;
            /*8158*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsBool_4, out ret);
            /*8159*/
            var ret_result = ret.I32 != 0;
            /*8160*/
            return ret_result;
            /*8161*/
        }
        /// <summary>
        /// True if the value type is int.
        /// /*cef()*/
        /// </summary>
        /*8162*/


        // gen! bool IsInt()
        /*8163*/

        public bool IsInt()/*8164*/
        {
            JsValue ret;
            /*8165*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsInt_5, out ret);
            /*8166*/
            var ret_result = ret.I32 != 0;
            /*8167*/
            return ret_result;
            /*8168*/
        }
        /// <summary>
        /// True if the value type is unsigned int.
        /// /*cef()*/
        /// </summary>
        /*8169*/


        // gen! bool IsUInt()
        /*8170*/

        public bool IsUInt()/*8171*/
        {
            JsValue ret;
            /*8172*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUInt_6, out ret);
            /*8173*/
            var ret_result = ret.I32 != 0;
            /*8174*/
            return ret_result;
            /*8175*/
        }
        /// <summary>
        /// True if the value type is double.
        /// /*cef()*/
        /// </summary>
        /*8176*/


        // gen! bool IsDouble()
        /*8177*/

        public bool IsDouble()/*8178*/
        {
            JsValue ret;
            /*8179*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsDouble_7, out ret);
            /*8180*/
            var ret_result = ret.I32 != 0;
            /*8181*/
            return ret_result;
            /*8182*/
        }
        /// <summary>
        /// True if the value type is Date.
        /// /*cef()*/
        /// </summary>
        /*8183*/


        // gen! bool IsDate()
        /*8184*/

        public bool IsDate()/*8185*/
        {
            JsValue ret;
            /*8186*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsDate_8, out ret);
            /*8187*/
            var ret_result = ret.I32 != 0;
            /*8188*/
            return ret_result;
            /*8189*/
        }
        /// <summary>
        /// True if the value type is string.
        /// /*cef()*/
        /// </summary>
        /*8190*/


        // gen! bool IsString()
        /*8191*/

        public bool IsString()/*8192*/
        {
            JsValue ret;
            /*8193*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsString_9, out ret);
            /*8194*/
            var ret_result = ret.I32 != 0;
            /*8195*/
            return ret_result;
            /*8196*/
        }
        /// <summary>
        /// True if the value type is object.
        /// /*cef()*/
        /// </summary>
        /*8197*/


        // gen! bool IsObject()
        /*8198*/

        public bool IsObject()/*8199*/
        {
            JsValue ret;
            /*8200*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsObject_10, out ret);
            /*8201*/
            var ret_result = ret.I32 != 0;
            /*8202*/
            return ret_result;
            /*8203*/
        }
        /// <summary>
        /// True if the value type is array.
        /// /*cef()*/
        /// </summary>
        /*8204*/


        // gen! bool IsArray()
        /*8205*/

        public bool IsArray()/*8206*/
        {
            JsValue ret;
            /*8207*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsArray_11, out ret);
            /*8208*/
            var ret_result = ret.I32 != 0;
            /*8209*/
            return ret_result;
            /*8210*/
        }
        /// <summary>
        /// True if the value type is function.
        /// /*cef()*/
        /// </summary>
        /*8211*/


        // gen! bool IsFunction()
        /*8212*/

        public bool IsFunction()/*8213*/
        {
            JsValue ret;
            /*8214*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsFunction_12, out ret);
            /*8215*/
            var ret_result = ret.I32 != 0;
            /*8216*/
            return ret_result;
            /*8217*/
        }
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>
        /*8218*/


        // gen! bool IsSame(CefRefPtr<CefV8Value> that)
        /*8219*/

        public bool IsSame(CefV8Value /*8220*/
        that
        )/*8221*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8222*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_IsSame_13, out ret, ref v1);
            /*8223*/
            var ret_result = ret.I32 != 0;
            /*8224*/
            return ret_result;
            /*8225*/
        }
        /// <summary>
        /// Return a bool value.
        /// /*cef()*/
        /// </summary>
        /*8226*/


        // gen! bool GetBoolValue()
        /*8227*/

        public bool GetBoolValue()/*8228*/
        {
            JsValue ret;
            /*8229*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetBoolValue_14, out ret);
            /*8230*/
            var ret_result = ret.I32 != 0;
            /*8231*/
            return ret_result;
            /*8232*/
        }
        /// <summary>
        /// Return an int value.
        /// /*cef()*/
        /// </summary>
        /*8233*/


        // gen! int32 GetIntValue()
        /*8234*/

        public int GetIntValue()/*8235*/
        {
            JsValue ret;
            /*8236*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetIntValue_15, out ret);
            /*8237*/
            var ret_result = ret.I32;
            /*8238*/
            return ret_result;
            /*8239*/
        }
        /// <summary>
        /// Return an unsigned int value.
        /// /*cef()*/
        /// </summary>
        /*8240*/


        // gen! uint32 GetUIntValue()
        /*8241*/

        public uint GetUIntValue()/*8242*/
        {
            JsValue ret;
            /*8243*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetUIntValue_16, out ret);
            /*8244*/
            var ret_result = (uint)ret.I32;
            /*8245*/
            return ret_result;
            /*8246*/
        }
        /// <summary>
        /// Return a double value.
        /// /*cef()*/
        /// </summary>
        /*8247*/


        // gen! double GetDoubleValue()
        /*8248*/

        public double GetDoubleValue()/*8249*/
        {
            JsValue ret;
            /*8250*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetDoubleValue_17, out ret);
            /*8251*/
            var ret_result = ret.Num;
            /*8252*/
            return ret_result;
            /*8253*/
        }
        /// <summary>
        /// Return a Date value.
        /// /*cef()*/
        /// </summary>
        /*8254*/


        // gen! CefTime GetDateValue()
        /*8255*/

        public CefTime GetDateValue()/*8256*/
        {
            JsValue ret;
            /*8257*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetDateValue_18, out ret);
            /*8258*/
            var ret_result = new CefTime(ret.Ptr);

            /*8259*/
            return ret_result;
            /*8260*/
        }
        /// <summary>
        /// Return a string value.
        /// /*cef()*/
        /// </summary>
        /*8261*/


        // gen! CefString GetStringValue()
        /*8262*/

        public string GetStringValue()/*8263*/
        {
            JsValue ret;
            /*8264*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetStringValue_19, out ret);
            /*8265*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8266*/
            return ret_result;
            /*8267*/
        }
        /// <summary>
        /// OBJECT METHODS - These methods are only available on objects. Arrays and
        /// functions are also objects. String- and integer-based keys can be used
        /// interchangably with the framework converting between them as necessary.
        /// Returns true if this is a user created object.
        /// /*cef()*/
        /// </summary>
        /*8268*/


        // gen! bool IsUserCreated()
        /*8269*/

        public bool IsUserCreated()/*8270*/
        {
            JsValue ret;
            /*8271*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUserCreated_20, out ret);
            /*8272*/
            var ret_result = ret.I32 != 0;
            /*8273*/
            return ret_result;
            /*8274*/
        }
        /// <summary>
        /// Returns true if the last method call resulted in an exception. This
        /// attribute exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>
        /*8275*/


        // gen! bool HasException()
        /*8276*/

        public bool HasException()/*8277*/
        {
            JsValue ret;
            /*8278*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_HasException_21, out ret);
            /*8279*/
            var ret_result = ret.I32 != 0;
            /*8280*/
            return ret_result;
            /*8281*/
        }
        /// <summary>
        /// Returns the exception resulting from the last method call. This attribute
        /// exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>
        /*8282*/


        // gen! CefRefPtr<CefV8Exception> GetException()
        /*8283*/

        public CefV8Exception GetException()/*8284*/
        {
            JsValue ret;
            /*8285*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetException_22, out ret);
            /*8286*/
            var ret_result = new CefV8Exception(ret.Ptr);
            /*8287*/
            return ret_result;
            /*8288*/
        }
        /// <summary>
        /// Clears the last exception and returns true on success.
        /// /*cef()*/
        /// </summary>
        /*8289*/


        // gen! bool ClearException()
        /*8290*/

        public bool ClearException()/*8291*/
        {
            JsValue ret;
            /*8292*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_ClearException_23, out ret);
            /*8293*/
            var ret_result = ret.I32 != 0;
            /*8294*/
            return ret_result;
            /*8295*/
        }
        /// <summary>
        /// Returns true if this object will re-throw future exceptions. This attribute
        /// exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>
        /*8296*/


        // gen! bool WillRethrowExceptions()
        /*8297*/

        public bool WillRethrowExceptions()/*8298*/
        {
            JsValue ret;
            /*8299*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_WillRethrowExceptions_24, out ret);
            /*8300*/
            var ret_result = ret.I32 != 0;
            /*8301*/
            return ret_result;
            /*8302*/
        }
        /// <summary>
        /// Set whether this object will re-throw future exceptions. By default
        /// exceptions are not re-thrown. If a exception is re-thrown the current
        /// context should not be accessed again until after the exception has been
        /// caught and not re-thrown. Returns true on success. This attribute exists
        /// only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>
        /*8303*/


        // gen! bool SetRethrowExceptions(bool rethrow)
        /*8304*/

        public bool SetRethrowExceptions(bool /*8305*/
        rethrow
        )/*8306*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8307*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_SetRethrowExceptions_25, out ret, ref v1);
            /*8308*/
            var ret_result = ret.I32 != 0;
            /*8309*/
            return ret_result;
            /*8310*/
        }
        /*8311*/


        // gen! bool HasValue(const CefString& key)
        /*8312*/

        public bool HasValue(string /*8313*/
        key
        )/*8314*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8315*/
            ;
            /*8316*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_HasValue_26, out ret, ref v1);
            /*8317*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8318*/
            ;
            /*8319*/
            return ret_result;
            /*8320*/
        }
        /*8321*/


        // gen! bool HasValue(int index)
        /*8322*/

        public bool HasValue(int /*8323*/
        index
        )/*8324*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8325*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_HasValue_27, out ret, ref v1);
            /*8326*/
            var ret_result = ret.I32 != 0;
            /*8327*/
            return ret_result;
            /*8328*/
        }
        /*8329*/


        // gen! bool DeleteValue(const CefString& key)
        /*8330*/

        public bool DeleteValue(string /*8331*/
        key
        )/*8332*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8333*/
            ;
            /*8334*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_DeleteValue_28, out ret, ref v1);
            /*8335*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8336*/
            ;
            /*8337*/
            return ret_result;
            /*8338*/
        }
        /*8339*/


        // gen! bool DeleteValue(int index)
        /*8340*/

        public bool DeleteValue(int /*8341*/
        index
        )/*8342*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8343*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_DeleteValue_29, out ret, ref v1);
            /*8344*/
            var ret_result = ret.I32 != 0;
            /*8345*/
            return ret_result;
            /*8346*/
        }
        /*8347*/


        // gen! CefRefPtr<CefV8Value> GetValue(const CefString& key)
        /*8348*/

        public CefV8Value GetValue(string /*8349*/
        key
        )/*8350*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8351*/
            ;
            /*8352*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetValue_30, out ret, ref v1);
            /*8353*/
            var ret_result = new CefV8Value(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8354*/
            ;
            /*8355*/
            return ret_result;
            /*8356*/
        }
        /*8357*/


        // gen! CefRefPtr<CefV8Value> GetValue(int index)
        /*8358*/

        public CefV8Value GetValue(int /*8359*/
        index
        )/*8360*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8361*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetValue_31, out ret, ref v1);
            /*8362*/
            var ret_result = new CefV8Value(ret.Ptr);
            /*8363*/
            return ret_result;
            /*8364*/
        }
        /*8365*/


        // gen! bool SetValue(const CefString& key,CefRefPtr<CefV8Value> value,PropertyAttribute attribute)
        /*8366*/

        public bool SetValue(string /*8367*/
        key
        , CefV8Value /*8368*/
        value
        , cef_v8_propertyattribute_t /*8369*/
        attribute
        )/*8370*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8371*/
            ;
            /*8372*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_SetValue_32, out ret, ref v1, ref v2, ref v3);
            /*8373*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8374*/
            ;
            /*8375*/
            return ret_result;
            /*8376*/
        }
        /*8377*/


        // gen! bool SetValue(int index,CefRefPtr<CefV8Value> value)
        /*8378*/

        public bool SetValue(int /*8379*/
        index
        , CefV8Value /*8380*/
        value
        )/*8381*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*8382*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefV8Value_SetValue_33, out ret, ref v1, ref v2);
            /*8383*/
            var ret_result = ret.I32 != 0;
            /*8384*/
            return ret_result;
            /*8385*/
        }
        /*8386*/


        // gen! bool SetValue(const CefString& key,AccessControl settings,PropertyAttribute attribute)
        /*8387*/

        public bool SetValue(string /*8388*/
        key
        , cef_v8_accesscontrol_t /*8389*/
        settings
        , cef_v8_propertyattribute_t /*8390*/
        attribute
        )/*8391*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8392*/
            ;
            /*8393*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_SetValue_34, out ret, ref v1, ref v2, ref v3);
            /*8394*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8395*/
            ;
            /*8396*/
            return ret_result;
            /*8397*/
        }
        /// <summary>
        /// Read the keys for the object's values into the specified vector. Integer-
        /// based keys will also be returned as strings.
        /// /*cef()*/
        /// </summary>
        /*8398*/


        // gen! bool GetKeys(std::vector<CefString>& keys)
        /*8399*/

        public bool GetKeys(List<string> /*8400*/
        keys
        )/*8401*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8402*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetKeys_35, out ret, ref v1);
            /*8403*/
            var ret_result = ret.I32 != 0;
            /*8404*/
            return ret_result;
            /*8405*/
        }
        /// <summary>
        /// Sets the user data for this object and returns true on success. Returns
        /// false if this method is called incorrectly. This method can only be called
        /// on user created objects.
        /// /*cef(optional_param=user_data)*/
        /// </summary>
        /*8406*/


        // gen! bool SetUserData(CefRefPtr<CefBaseRefCounted> user_data)
        /*8407*/

        public bool SetUserData(CefBaseRefCounted /*8408*/
        user_data
        )/*8409*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8410*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_SetUserData_36, out ret, ref v1);
            /*8411*/
            var ret_result = ret.I32 != 0;
            /*8412*/
            return ret_result;
            /*8413*/
        }
        /// <summary>
        /// Returns the user data, if any, assigned to this object.
        /// /*cef()*/
        /// </summary>
        /*8414*/


        // gen! CefRefPtr<CefBaseRefCounted> GetUserData()
        /*8415*/

        public CefBaseRefCounted GetUserData()/*8416*/
        {
            JsValue ret;
            /*8417*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetUserData_37, out ret);
            /*8418*/
            var ret_result = new CefBaseRefCounted(ret.Ptr);
            /*8419*/
            return ret_result;
            /*8420*/
        }
        /// <summary>
        /// Returns the amount of externally allocated memory registered for the
        /// object.
        /// /*cef()*/
        /// </summary>
        /*8421*/


        // gen! int GetExternallyAllocatedMemory()
        /*8422*/

        public int GetExternallyAllocatedMemory()/*8423*/
        {
            JsValue ret;
            /*8424*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetExternallyAllocatedMemory_38, out ret);
            /*8425*/
            var ret_result = ret.I32;
            /*8426*/
            return ret_result;
            /*8427*/
        }
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
        /*8428*/


        // gen! int AdjustExternallyAllocatedMemory(int change_in_bytes)
        /*8429*/

        public int AdjustExternallyAllocatedMemory(int /*8430*/
        change_in_bytes
        )/*8431*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8432*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_AdjustExternallyAllocatedMemory_39, out ret, ref v1);
            /*8433*/
            var ret_result = ret.I32;
            /*8434*/
            return ret_result;
            /*8435*/
        }
        /// <summary>
        /// ARRAY METHODS - These methods are only available on arrays.
        /// Returns the number of elements in the array.
        /// /*cef()*/
        /// </summary>
        /*8436*/


        // gen! int GetArrayLength()
        /*8437*/

        public int GetArrayLength()/*8438*/
        {
            JsValue ret;
            /*8439*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetArrayLength_40, out ret);
            /*8440*/
            var ret_result = ret.I32;
            /*8441*/
            return ret_result;
            /*8442*/
        }
        /// <summary>
        /// FUNCTION METHODS - These methods are only available on functions.
        /// Returns the function name.
        /// /*cef()*/
        /// </summary>
        /*8443*/


        // gen! CefString GetFunctionName()
        /*8444*/

        public string GetFunctionName()/*8445*/
        {
            JsValue ret;
            /*8446*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetFunctionName_41, out ret);
            /*8447*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8448*/
            return ret_result;
            /*8449*/
        }
        /// <summary>
        /// Returns the function handler or NULL if not a CEF-created function.
        /// /*cef()*/
        /// </summary>
        /*8450*/


        // gen! CefRefPtr<CefV8Handler> GetFunctionHandler()
        /*8451*/

        public CefV8Handler GetFunctionHandler()/*8452*/
        {
            JsValue ret;
            /*8453*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetFunctionHandler_42, out ret);
            /*8454*/
            var ret_result = new CefV8Handler(ret.Ptr);
            /*8455*/
            return ret_result;
            /*8456*/
        }
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
        /*8457*/


        // gen! CefRefPtr<CefV8Value> ExecuteFunction(CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments)
        /*8458*/

        public CefV8Value ExecuteFunction(CefV8Value /*8459*/
        _object
        , CefV8ValueList /*8460*/
        arguments
        )/*8461*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*8462*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefV8Value_ExecuteFunction_43, out ret, ref v1, ref v2);
            /*8463*/
            var ret_result = new CefV8Value(ret.Ptr);
            /*8464*/
            return ret_result;
            /*8465*/
        }
        /// <summary>
        /// Execute the function using the specified V8 context. |object| is the
        /// receiver ('this' object) of the function. If |object| is empty the
        /// specified context's global object will be used. |arguments| is the list of
        /// arguments that will be passed to the function. Returns the function return
        /// value on success. Returns NULL if this method is called incorrectly or an
        /// exception is thrown.
        /// /*cef(optional_param=object)*/
        /// </summary>
        /*8466*/


        // gen! CefRefPtr<CefV8Value> ExecuteFunctionWithContext(CefRefPtr<CefV8Context> context,CefRefPtr<CefV8Value> object,const CefV8ValueList& arguments)
        /*8467*/

        public CefV8Value ExecuteFunctionWithContext(CefV8Context /*8468*/
        context
        , CefV8Value /*8469*/
        _object
        , CefV8ValueList /*8470*/
        arguments
        )/*8471*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*8472*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_ExecuteFunctionWithContext_44, out ret, ref v1, ref v2, ref v3);
            /*8473*/
            var ret_result = new CefV8Value(ret.Ptr);
            /*8474*/
            return ret_result;
            /*8475*/
        }
        /*8476*/
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
    /*8500*/
    public struct CefV8StackTrace
    {
        /*8501*/
        const int _typeNAME = 44;
        /*8502*/
        const int CefV8StackTrace_Release_0 = (_typeNAME << 16) | 0;
        /*8503*/
        const int CefV8StackTrace_IsValid_1 = (_typeNAME << 16) | 1;
        /*8504*/
        const int CefV8StackTrace_GetFrameCount_2 = (_typeNAME << 16) | 2;
        /*8505*/
        const int CefV8StackTrace_GetFrame_3 = (_typeNAME << 16) | 3;
        /*8506*/
        internal readonly IntPtr nativePtr;
        /*8507*/
        internal CefV8StackTrace(IntPtr nativePtr)
        {
            /*8508*/
            this.nativePtr = nativePtr;
            /*8509*/
        }
        /*8510*/
        public void Release()
        {
            /*8511*/
            JsValue ret;
            /*8512*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_Release_0, out ret);
            /*8513*/
        }
        /// <summary>
        /// CefV8StackTrace methods.
        /// </summary>
        /*8514*/


        // gen! bool IsValid()
        /*8515*/

        public bool IsValid()/*8516*/
        {
            JsValue ret;
            /*8517*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_IsValid_1, out ret);
            /*8518*/
            var ret_result = ret.I32 != 0;
            /*8519*/
            return ret_result;
            /*8520*/
        }
        /// <summary>
        /// Returns the number of stack frames.
        /// /*cef()*/
        /// </summary>
        /*8521*/


        // gen! int GetFrameCount()
        /*8522*/

        public int GetFrameCount()/*8523*/
        {
            JsValue ret;
            /*8524*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_GetFrameCount_2, out ret);
            /*8525*/
            var ret_result = ret.I32;
            /*8526*/
            return ret_result;
            /*8527*/
        }
        /// <summary>
        /// Returns the stack frame at the specified 0-based index.
        /// /*cef()*/
        /// </summary>
        /*8528*/


        // gen! CefRefPtr<CefV8StackFrame> GetFrame(int index)
        /*8529*/

        public CefV8StackFrame GetFrame(int /*8530*/
        index
        )/*8531*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8532*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8StackTrace_GetFrame_3, out ret, ref v1);
            /*8533*/
            var ret_result = new CefV8StackFrame(ret.Ptr);
            /*8534*/
            return ret_result;
            /*8535*/
        }
        /*8536*/
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
    /*8585*/
    public struct CefV8StackFrame
    {
        /*8586*/
        const int _typeNAME = 45;
        /*8587*/
        const int CefV8StackFrame_Release_0 = (_typeNAME << 16) | 0;
        /*8588*/
        const int CefV8StackFrame_IsValid_1 = (_typeNAME << 16) | 1;
        /*8589*/
        const int CefV8StackFrame_GetScriptName_2 = (_typeNAME << 16) | 2;
        /*8590*/
        const int CefV8StackFrame_GetScriptNameOrSourceURL_3 = (_typeNAME << 16) | 3;
        /*8591*/
        const int CefV8StackFrame_GetFunctionName_4 = (_typeNAME << 16) | 4;
        /*8592*/
        const int CefV8StackFrame_GetLineNumber_5 = (_typeNAME << 16) | 5;
        /*8593*/
        const int CefV8StackFrame_GetColumn_6 = (_typeNAME << 16) | 6;
        /*8594*/
        const int CefV8StackFrame_IsEval_7 = (_typeNAME << 16) | 7;
        /*8595*/
        const int CefV8StackFrame_IsConstructor_8 = (_typeNAME << 16) | 8;
        /*8596*/
        internal readonly IntPtr nativePtr;
        /*8597*/
        internal CefV8StackFrame(IntPtr nativePtr)
        {
            /*8598*/
            this.nativePtr = nativePtr;
            /*8599*/
        }
        /*8600*/
        public void Release()
        {
            /*8601*/
            JsValue ret;
            /*8602*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_Release_0, out ret);
            /*8603*/
        }
        /// <summary>
        /// CefV8StackFrame methods.
        /// </summary>
        /*8604*/


        // gen! bool IsValid()
        /*8605*/

        public bool IsValid()/*8606*/
        {
            JsValue ret;
            /*8607*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsValid_1, out ret);
            /*8608*/
            var ret_result = ret.I32 != 0;
            /*8609*/
            return ret_result;
            /*8610*/
        }
        /// <summary>
        /// Returns the name of the resource script that contains the function.
        /// /*cef()*/
        /// </summary>
        /*8611*/


        // gen! CefString GetScriptName()
        /*8612*/

        public string GetScriptName()/*8613*/
        {
            JsValue ret;
            /*8614*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetScriptName_2, out ret);
            /*8615*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8616*/
            return ret_result;
            /*8617*/
        }
        /// <summary>
        /// Returns the name of the resource script that contains the function or the
        /// sourceURL value if the script name is undefined and its source ends with
        /// a "//@ sourceURL=..." string.
        /// /*cef()*/
        /// </summary>
        /*8618*/


        // gen! CefString GetScriptNameOrSourceURL()
        /*8619*/

        public string GetScriptNameOrSourceURL()/*8620*/
        {
            JsValue ret;
            /*8621*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetScriptNameOrSourceURL_3, out ret);
            /*8622*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8623*/
            return ret_result;
            /*8624*/
        }
        /// <summary>
        /// Returns the name of the function.
        /// /*cef()*/
        /// </summary>
        /*8625*/


        // gen! CefString GetFunctionName()
        /*8626*/

        public string GetFunctionName()/*8627*/
        {
            JsValue ret;
            /*8628*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetFunctionName_4, out ret);
            /*8629*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8630*/
            return ret_result;
            /*8631*/
        }
        /// <summary>
        /// Returns the 1-based line number for the function call or 0 if unknown.
        /// /*cef()*/
        /// </summary>
        /*8632*/


        // gen! int GetLineNumber()
        /*8633*/

        public int GetLineNumber()/*8634*/
        {
            JsValue ret;
            /*8635*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetLineNumber_5, out ret);
            /*8636*/
            var ret_result = ret.I32;
            /*8637*/
            return ret_result;
            /*8638*/
        }
        /// <summary>
        /// Returns the 1-based column offset on the line for the function call or 0 if
        /// unknown.
        /// /*cef()*/
        /// </summary>
        /*8639*/


        // gen! int GetColumn()
        /*8640*/

        public int GetColumn()/*8641*/
        {
            JsValue ret;
            /*8642*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetColumn_6, out ret);
            /*8643*/
            var ret_result = ret.I32;
            /*8644*/
            return ret_result;
            /*8645*/
        }
        /// <summary>
        /// Returns true if the function was compiled using eval().
        /// /*cef()*/
        /// </summary>
        /*8646*/


        // gen! bool IsEval()
        /*8647*/

        public bool IsEval()/*8648*/
        {
            JsValue ret;
            /*8649*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsEval_7, out ret);
            /*8650*/
            var ret_result = ret.I32 != 0;
            /*8651*/
            return ret_result;
            /*8652*/
        }
        /// <summary>
        /// Returns true if the function was called as a constructor via "new".
        /// /*cef()*/
        /// </summary>
        /*8653*/


        // gen! bool IsConstructor()
        /*8654*/

        public bool IsConstructor()/*8655*/
        {
            JsValue ret;
            /*8656*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsConstructor_8, out ret);
            /*8657*/
            var ret_result = ret.I32 != 0;
            /*8658*/
            return ret_result;
            /*8659*/
        }
        /*8660*/
    }


    // [virtual] class CefValue
    /// <summary>
    /// Class that wraps other data value types. Complex types (binary, dictionary
    /// and list) will be referenced but not owned by this object. Can be used on any
    /// process and thread.
    /// /*cef(source=library)*/
    /// </summary>
    /*8779*/
    public struct CefValue
    {
        /*8780*/
        const int _typeNAME = 46;
        /*8781*/
        const int CefValue_Release_0 = (_typeNAME << 16) | 0;
        /*8782*/
        const int CefValue_IsValid_1 = (_typeNAME << 16) | 1;
        /*8783*/
        const int CefValue_IsOwned_2 = (_typeNAME << 16) | 2;
        /*8784*/
        const int CefValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        /*8785*/
        const int CefValue_IsSame_4 = (_typeNAME << 16) | 4;
        /*8786*/
        const int CefValue_IsEqual_5 = (_typeNAME << 16) | 5;
        /*8787*/
        const int CefValue_Copy_6 = (_typeNAME << 16) | 6;
        /*8788*/
        const int CefValue_GetType_7 = (_typeNAME << 16) | 7;
        /*8789*/
        const int CefValue_GetBool_8 = (_typeNAME << 16) | 8;
        /*8790*/
        const int CefValue_GetInt_9 = (_typeNAME << 16) | 9;
        /*8791*/
        const int CefValue_GetDouble_10 = (_typeNAME << 16) | 10;
        /*8792*/
        const int CefValue_GetString_11 = (_typeNAME << 16) | 11;
        /*8793*/
        const int CefValue_GetBinary_12 = (_typeNAME << 16) | 12;
        /*8794*/
        const int CefValue_GetDictionary_13 = (_typeNAME << 16) | 13;
        /*8795*/
        const int CefValue_GetList_14 = (_typeNAME << 16) | 14;
        /*8796*/
        const int CefValue_SetNull_15 = (_typeNAME << 16) | 15;
        /*8797*/
        const int CefValue_SetBool_16 = (_typeNAME << 16) | 16;
        /*8798*/
        const int CefValue_SetInt_17 = (_typeNAME << 16) | 17;
        /*8799*/
        const int CefValue_SetDouble_18 = (_typeNAME << 16) | 18;
        /*8800*/
        const int CefValue_SetString_19 = (_typeNAME << 16) | 19;
        /*8801*/
        const int CefValue_SetBinary_20 = (_typeNAME << 16) | 20;
        /*8802*/
        const int CefValue_SetDictionary_21 = (_typeNAME << 16) | 21;
        /*8803*/
        const int CefValue_SetList_22 = (_typeNAME << 16) | 22;
        /*8804*/
        internal readonly IntPtr nativePtr;
        /*8805*/
        internal CefValue(IntPtr nativePtr)
        {
            /*8806*/
            this.nativePtr = nativePtr;
            /*8807*/
        }
        /*8808*/
        public void Release()
        {
            /*8809*/
            JsValue ret;
            /*8810*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_Release_0, out ret);
            /*8811*/
        }
        /// <summary>
        /// CefValue methods.
        /// </summary>
        /*8812*/


        // gen! bool IsValid()
        /*8813*/

        public bool IsValid()/*8814*/
        {
            JsValue ret;
            /*8815*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsValid_1, out ret);
            /*8816*/
            var ret_result = ret.I32 != 0;
            /*8817*/
            return ret_result;
            /*8818*/
        }
        /// <summary>
        /// Returns true if the underlying data is owned by another object.
        /// /*cef()*/
        /// </summary>
        /*8819*/


        // gen! bool IsOwned()
        /*8820*/

        public bool IsOwned()/*8821*/
        {
            JsValue ret;
            /*8822*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsOwned_2, out ret);
            /*8823*/
            var ret_result = ret.I32 != 0;
            /*8824*/
            return ret_result;
            /*8825*/
        }
        /// <summary>
        /// Returns true if the underlying data is read-only. Some APIs may expose
        /// read-only objects.
        /// /*cef()*/
        /// </summary>
        /*8826*/


        // gen! bool IsReadOnly()
        /*8827*/

        public bool IsReadOnly()/*8828*/
        {
            JsValue ret;
            /*8829*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsReadOnly_3, out ret);
            /*8830*/
            var ret_result = ret.I32 != 0;
            /*8831*/
            return ret_result;
            /*8832*/
        }
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>
        /*8833*/


        // gen! bool IsSame(CefRefPtr<CefValue> that)
        /*8834*/

        public bool IsSame(CefValue /*8835*/
        that
        )/*8836*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8837*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_IsSame_4, out ret, ref v1);
            /*8838*/
            var ret_result = ret.I32 != 0;
            /*8839*/
            return ret_result;
            /*8840*/
        }
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>
        /*8841*/


        // gen! bool IsEqual(CefRefPtr<CefValue> that)
        /*8842*/

        public bool IsEqual(CefValue /*8843*/
        that
        )/*8844*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8845*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_IsEqual_5, out ret, ref v1);
            /*8846*/
            var ret_result = ret.I32 != 0;
            /*8847*/
            return ret_result;
            /*8848*/
        }
        /// <summary>
        /// Returns a copy of this object. The underlying data will also be copied.
        /// /*cef()*/
        /// </summary>
        /*8849*/


        // gen! CefRefPtr<CefValue> Copy()
        /*8850*/

        public CefValue Copy()/*8851*/
        {
            JsValue ret;
            /*8852*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_Copy_6, out ret);
            /*8853*/
            var ret_result = new CefValue(ret.Ptr);
            /*8854*/
            return ret_result;
            /*8855*/
        }
        /// <summary>
        /// Returns the underlying value type.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>
        /*8856*/


        // gen! CefValueType GetType()
        /*8857*/

        public cef_value_type_t _GetType()/*8858*/
        {
            JsValue ret;
            /*8859*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetType_7, out ret);
            /*8860*/
            var ret_result = (cef_value_type_t)ret.I32;

            /*8861*/
            return ret_result;
            /*8862*/
        }
        /// <summary>
        /// Returns the underlying value as type bool.
        /// /*cef()*/
        /// </summary>
        /*8863*/


        // gen! bool GetBool()
        /*8864*/

        public bool GetBool()/*8865*/
        {
            JsValue ret;
            /*8866*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetBool_8, out ret);
            /*8867*/
            var ret_result = ret.I32 != 0;
            /*8868*/
            return ret_result;
            /*8869*/
        }
        /// <summary>
        /// Returns the underlying value as type int.
        /// /*cef()*/
        /// </summary>
        /*8870*/


        // gen! int GetInt()
        /*8871*/

        public int GetInt()/*8872*/
        {
            JsValue ret;
            /*8873*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetInt_9, out ret);
            /*8874*/
            var ret_result = ret.I32;
            /*8875*/
            return ret_result;
            /*8876*/
        }
        /// <summary>
        /// Returns the underlying value as type double.
        /// /*cef()*/
        /// </summary>
        /*8877*/


        // gen! double GetDouble()
        /*8878*/

        public double GetDouble()/*8879*/
        {
            JsValue ret;
            /*8880*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetDouble_10, out ret);
            /*8881*/
            var ret_result = ret.Num;
            /*8882*/
            return ret_result;
            /*8883*/
        }
        /// <summary>
        /// Returns the underlying value as type string.
        /// /*cef()*/
        /// </summary>
        /*8884*/


        // gen! CefString GetString()
        /*8885*/

        public string GetString()/*8886*/
        {
            JsValue ret;
            /*8887*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetString_11, out ret);
            /*8888*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8889*/
            return ret_result;
            /*8890*/
        }
        /// <summary>
        /// Returns the underlying value as type binary. The returned reference may
        /// become invalid if the value is owned by another object or if ownership is
        /// transferred to another object in the future. To maintain a reference to
        /// the value after assigning ownership to a dictionary or list pass this
        /// object to the SetValue() method instead of passing the returned reference
        /// to SetBinary().
        /// /*cef()*/
        /// </summary>
        /*8891*/


        // gen! CefRefPtr<CefBinaryValue> GetBinary()
        /*8892*/

        public CefBinaryValue GetBinary()/*8893*/
        {
            JsValue ret;
            /*8894*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetBinary_12, out ret);
            /*8895*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*8896*/
            return ret_result;
            /*8897*/
        }
        /// <summary>
        /// Returns the underlying value as type dictionary. The returned reference may
        /// become invalid if the value is owned by another object or if ownership is
        /// transferred to another object in the future. To maintain a reference to
        /// the value after assigning ownership to a dictionary or list pass this
        /// object to the SetValue() method instead of passing the returned reference
        /// to SetDictionary().
        /// /*cef()*/
        /// </summary>
        /*8898*/


        // gen! CefRefPtr<CefDictionaryValue> GetDictionary()
        /*8899*/

        public CefDictionaryValue GetDictionary()/*8900*/
        {
            JsValue ret;
            /*8901*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetDictionary_13, out ret);
            /*8902*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            /*8903*/
            return ret_result;
            /*8904*/
        }
        /// <summary>
        /// Returns the underlying value as type list. The returned reference may
        /// become invalid if the value is owned by another object or if ownership is
        /// transferred to another object in the future. To maintain a reference to
        /// the value after assigning ownership to a dictionary or list pass this
        /// object to the SetValue() method instead of passing the returned reference
        /// to SetList().
        /// /*cef()*/
        /// </summary>
        /*8905*/


        // gen! CefRefPtr<CefListValue> GetList()
        /*8906*/

        public CefListValue GetList()/*8907*/
        {
            JsValue ret;
            /*8908*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetList_14, out ret);
            /*8909*/
            var ret_result = new CefListValue(ret.Ptr);
            /*8910*/
            return ret_result;
            /*8911*/
        }
        /// <summary>
        /// Sets the underlying value as type null. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>
        /*8912*/


        // gen! bool SetNull()
        /*8913*/

        public bool SetNull()/*8914*/
        {
            JsValue ret;
            /*8915*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_SetNull_15, out ret);
            /*8916*/
            var ret_result = ret.I32 != 0;
            /*8917*/
            return ret_result;
            /*8918*/
        }
        /// <summary>
        /// Sets the underlying value as type bool. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>
        /*8919*/


        // gen! bool SetBool(bool value)
        /*8920*/

        public bool SetBool(bool /*8921*/
        value
        )/*8922*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8923*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetBool_16, out ret, ref v1);
            /*8924*/
            var ret_result = ret.I32 != 0;
            /*8925*/
            return ret_result;
            /*8926*/
        }
        /// <summary>
        /// Sets the underlying value as type int. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>
        /*8927*/


        // gen! bool SetInt(int value)
        /*8928*/

        public bool SetInt(int /*8929*/
        value
        )/*8930*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8931*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetInt_17, out ret, ref v1);
            /*8932*/
            var ret_result = ret.I32 != 0;
            /*8933*/
            return ret_result;
            /*8934*/
        }
        /// <summary>
        /// Sets the underlying value as type double. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>
        /*8935*/


        // gen! bool SetDouble(double value)
        /*8936*/

        public bool SetDouble(double /*8937*/
        value
        )/*8938*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8939*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetDouble_18, out ret, ref v1);
            /*8940*/
            var ret_result = ret.I32 != 0;
            /*8941*/
            return ret_result;
            /*8942*/
        }
        /// <summary>
        /// Sets the underlying value as type string. Returns true if the value was set
        /// successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>
        /*8943*/


        // gen! bool SetString(const CefString& value)
        /*8944*/

        public bool SetString(string /*8945*/
        value
        )/*8946*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*8947*/
            ;
            /*8948*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetString_19, out ret, ref v1);
            /*8949*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8950*/
            ;
            /*8951*/
            return ret_result;
            /*8952*/
        }
        /// <summary>
        /// Sets the underlying value as type binary. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>
        /*8953*/


        // gen! bool SetBinary(CefRefPtr<CefBinaryValue> value)
        /*8954*/

        public bool SetBinary(CefBinaryValue /*8955*/
        value
        )/*8956*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8957*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetBinary_20, out ret, ref v1);
            /*8958*/
            var ret_result = ret.I32 != 0;
            /*8959*/
            return ret_result;
            /*8960*/
        }
        /// <summary>
        /// Sets the underlying value as type dict. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>
        /*8961*/


        // gen! bool SetDictionary(CefRefPtr<CefDictionaryValue> value)
        /*8962*/

        public bool SetDictionary(CefDictionaryValue /*8963*/
        value
        )/*8964*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8965*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetDictionary_21, out ret, ref v1);
            /*8966*/
            var ret_result = ret.I32 != 0;
            /*8967*/
            return ret_result;
            /*8968*/
        }
        /// <summary>
        /// Sets the underlying value as type list. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>
        /*8969*/


        // gen! bool SetList(CefRefPtr<CefListValue> value)
        /*8970*/

        public bool SetList(CefListValue /*8971*/
        value
        )/*8972*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*8973*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetList_22, out ret, ref v1);
            /*8974*/
            var ret_result = ret.I32 != 0;
            /*8975*/
            return ret_result;
            /*8976*/
        }
        /*8977*/
    }


    // [virtual] class CefBinaryValue
    /// <summary>
    /// Class representing a binary value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    /*9021*/
    public struct CefBinaryValue
    {
        /*9022*/
        const int _typeNAME = 47;
        /*9023*/
        const int CefBinaryValue_Release_0 = (_typeNAME << 16) | 0;
        /*9024*/
        const int CefBinaryValue_IsValid_1 = (_typeNAME << 16) | 1;
        /*9025*/
        const int CefBinaryValue_IsOwned_2 = (_typeNAME << 16) | 2;
        /*9026*/
        const int CefBinaryValue_IsSame_3 = (_typeNAME << 16) | 3;
        /*9027*/
        const int CefBinaryValue_IsEqual_4 = (_typeNAME << 16) | 4;
        /*9028*/
        const int CefBinaryValue_Copy_5 = (_typeNAME << 16) | 5;
        /*9029*/
        const int CefBinaryValue_GetSize_6 = (_typeNAME << 16) | 6;
        /*9030*/
        const int CefBinaryValue_GetData_7 = (_typeNAME << 16) | 7;
        /*9031*/
        internal readonly IntPtr nativePtr;
        /*9032*/
        internal CefBinaryValue(IntPtr nativePtr)
        {
            /*9033*/
            this.nativePtr = nativePtr;
            /*9034*/
        }
        /*9035*/
        public void Release()
        {
            /*9036*/
            JsValue ret;
            /*9037*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_Release_0, out ret);
            /*9038*/
        }
        /// <summary>
        /// CefBinaryValue methods.
        /// </summary>
        /*9039*/


        // gen! bool IsValid()
        /*9040*/

        public bool IsValid()/*9041*/
        {
            JsValue ret;
            /*9042*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_IsValid_1, out ret);
            /*9043*/
            var ret_result = ret.I32 != 0;
            /*9044*/
            return ret_result;
            /*9045*/
        }
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>
        /*9046*/


        // gen! bool IsOwned()
        /*9047*/

        public bool IsOwned()/*9048*/
        {
            JsValue ret;
            /*9049*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_IsOwned_2, out ret);
            /*9050*/
            var ret_result = ret.I32 != 0;
            /*9051*/
            return ret_result;
            /*9052*/
        }
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data.
        /// /*cef()*/
        /// </summary>
        /*9053*/


        // gen! bool IsSame(CefRefPtr<CefBinaryValue> that)
        /*9054*/

        public bool IsSame(CefBinaryValue /*9055*/
        that
        )/*9056*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9057*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBinaryValue_IsSame_3, out ret, ref v1);
            /*9058*/
            var ret_result = ret.I32 != 0;
            /*9059*/
            return ret_result;
            /*9060*/
        }
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>
        /*9061*/


        // gen! bool IsEqual(CefRefPtr<CefBinaryValue> that)
        /*9062*/

        public bool IsEqual(CefBinaryValue /*9063*/
        that
        )/*9064*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9065*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBinaryValue_IsEqual_4, out ret, ref v1);
            /*9066*/
            var ret_result = ret.I32 != 0;
            /*9067*/
            return ret_result;
            /*9068*/
        }
        /// <summary>
        /// Returns a copy of this object. The data in this object will also be copied.
        /// /*cef()*/
        /// </summary>
        /*9069*/


        // gen! CefRefPtr<CefBinaryValue> Copy()
        /*9070*/

        public CefBinaryValue Copy()/*9071*/
        {
            JsValue ret;
            /*9072*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_Copy_5, out ret);
            /*9073*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*9074*/
            return ret_result;
            /*9075*/
        }
        /// <summary>
        /// Returns the data size.
        /// /*cef()*/
        /// </summary>
        /*9076*/


        // gen! size_t GetSize()
        /*9077*/

        public uint GetSize()/*9078*/
        {
            JsValue ret;
            /*9079*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_GetSize_6, out ret);
            /*9080*/
            var ret_result = (uint)ret.I32;
            /*9081*/
            return ret_result;
            /*9082*/
        }
        /// <summary>
        /// Read up to |buffer_size| number of bytes into |buffer|. Reading begins at
        /// the specified byte |data_offset|. Returns the number of bytes read.
        /// /*cef()*/
        /// </summary>
        /*9083*/


        // gen! size_t GetData(void* buffer,size_t buffer_size,size_t data_offset)
        /*9084*/

        public uint GetData(IntPtr /*9085*/
        buffer
        , uint /*9086*/
        buffer_size
        , uint /*9087*/
        data_offset
        )/*9088*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            /*9089*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBinaryValue_GetData_7, out ret, ref v1, ref v2, ref v3);
            /*9090*/
            var ret_result = (uint)ret.I32;
            /*9091*/
            return ret_result;
            /*9092*/
        }
        /*9093*/
    }


    // [virtual] class CefDictionaryValue
    /// <summary>
    /// Class representing a dictionary value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    /*9247*/
    public struct CefDictionaryValue
    {
        /*9248*/
        const int _typeNAME = 48;
        /*9249*/
        const int CefDictionaryValue_Release_0 = (_typeNAME << 16) | 0;
        /*9250*/
        const int CefDictionaryValue_IsValid_1 = (_typeNAME << 16) | 1;
        /*9251*/
        const int CefDictionaryValue_IsOwned_2 = (_typeNAME << 16) | 2;
        /*9252*/
        const int CefDictionaryValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        /*9253*/
        const int CefDictionaryValue_IsSame_4 = (_typeNAME << 16) | 4;
        /*9254*/
        const int CefDictionaryValue_IsEqual_5 = (_typeNAME << 16) | 5;
        /*9255*/
        const int CefDictionaryValue_Copy_6 = (_typeNAME << 16) | 6;
        /*9256*/
        const int CefDictionaryValue_GetSize_7 = (_typeNAME << 16) | 7;
        /*9257*/
        const int CefDictionaryValue_Clear_8 = (_typeNAME << 16) | 8;
        /*9258*/
        const int CefDictionaryValue_HasKey_9 = (_typeNAME << 16) | 9;
        /*9259*/
        const int CefDictionaryValue_GetKeys_10 = (_typeNAME << 16) | 10;
        /*9260*/
        const int CefDictionaryValue_Remove_11 = (_typeNAME << 16) | 11;
        /*9261*/
        const int CefDictionaryValue_GetType_12 = (_typeNAME << 16) | 12;
        /*9262*/
        const int CefDictionaryValue_GetValue_13 = (_typeNAME << 16) | 13;
        /*9263*/
        const int CefDictionaryValue_GetBool_14 = (_typeNAME << 16) | 14;
        /*9264*/
        const int CefDictionaryValue_GetInt_15 = (_typeNAME << 16) | 15;
        /*9265*/
        const int CefDictionaryValue_GetDouble_16 = (_typeNAME << 16) | 16;
        /*9266*/
        const int CefDictionaryValue_GetString_17 = (_typeNAME << 16) | 17;
        /*9267*/
        const int CefDictionaryValue_GetBinary_18 = (_typeNAME << 16) | 18;
        /*9268*/
        const int CefDictionaryValue_GetDictionary_19 = (_typeNAME << 16) | 19;
        /*9269*/
        const int CefDictionaryValue_GetList_20 = (_typeNAME << 16) | 20;
        /*9270*/
        const int CefDictionaryValue_SetValue_21 = (_typeNAME << 16) | 21;
        /*9271*/
        const int CefDictionaryValue_SetNull_22 = (_typeNAME << 16) | 22;
        /*9272*/
        const int CefDictionaryValue_SetBool_23 = (_typeNAME << 16) | 23;
        /*9273*/
        const int CefDictionaryValue_SetInt_24 = (_typeNAME << 16) | 24;
        /*9274*/
        const int CefDictionaryValue_SetDouble_25 = (_typeNAME << 16) | 25;
        /*9275*/
        const int CefDictionaryValue_SetString_26 = (_typeNAME << 16) | 26;
        /*9276*/
        const int CefDictionaryValue_SetBinary_27 = (_typeNAME << 16) | 27;
        /*9277*/
        const int CefDictionaryValue_SetDictionary_28 = (_typeNAME << 16) | 28;
        /*9278*/
        const int CefDictionaryValue_SetList_29 = (_typeNAME << 16) | 29;
        /*9279*/
        internal readonly IntPtr nativePtr;
        /*9280*/
        internal CefDictionaryValue(IntPtr nativePtr)
        {
            /*9281*/
            this.nativePtr = nativePtr;
            /*9282*/
        }
        /*9283*/
        public void Release()
        {
            /*9284*/
            JsValue ret;
            /*9285*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_Release_0, out ret);
            /*9286*/
        }
        /// <summary>
        /// CefDictionaryValue methods.
        /// </summary>
        /*9287*/


        // gen! bool IsValid()
        /*9288*/

        public bool IsValid()/*9289*/
        {
            JsValue ret;
            /*9290*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsValid_1, out ret);
            /*9291*/
            var ret_result = ret.I32 != 0;
            /*9292*/
            return ret_result;
            /*9293*/
        }
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>
        /*9294*/


        // gen! bool IsOwned()
        /*9295*/

        public bool IsOwned()/*9296*/
        {
            JsValue ret;
            /*9297*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsOwned_2, out ret);
            /*9298*/
            var ret_result = ret.I32 != 0;
            /*9299*/
            return ret_result;
            /*9300*/
        }
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*9301*/


        // gen! bool IsReadOnly()
        /*9302*/

        public bool IsReadOnly()/*9303*/
        {
            JsValue ret;
            /*9304*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsReadOnly_3, out ret);
            /*9305*/
            var ret_result = ret.I32 != 0;
            /*9306*/
            return ret_result;
            /*9307*/
        }
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>
        /*9308*/


        // gen! bool IsSame(CefRefPtr<CefDictionaryValue> that)
        /*9309*/

        public bool IsSame(CefDictionaryValue /*9310*/
        that
        )/*9311*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9312*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_IsSame_4, out ret, ref v1);
            /*9313*/
            var ret_result = ret.I32 != 0;
            /*9314*/
            return ret_result;
            /*9315*/
        }
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>
        /*9316*/


        // gen! bool IsEqual(CefRefPtr<CefDictionaryValue> that)
        /*9317*/

        public bool IsEqual(CefDictionaryValue /*9318*/
        that
        )/*9319*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9320*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_IsEqual_5, out ret, ref v1);
            /*9321*/
            var ret_result = ret.I32 != 0;
            /*9322*/
            return ret_result;
            /*9323*/
        }
        /// <summary>
        /// Returns a writable copy of this object. If |exclude_empty_children| is true
        /// any empty dictionaries or lists will be excluded from the copy.
        /// /*cef()*/
        /// </summary>
        /*9324*/


        // gen! CefRefPtr<CefDictionaryValue> Copy(bool exclude_empty_children)
        /*9325*/

        public CefDictionaryValue Copy(bool /*9326*/
        exclude_empty_children
        )/*9327*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9328*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_Copy_6, out ret, ref v1);
            /*9329*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            /*9330*/
            return ret_result;
            /*9331*/
        }
        /// <summary>
        /// Returns the number of values.
        /// /*cef()*/
        /// </summary>
        /*9332*/


        // gen! size_t GetSize()
        /*9333*/

        public uint GetSize()/*9334*/
        {
            JsValue ret;
            /*9335*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_GetSize_7, out ret);
            /*9336*/
            var ret_result = (uint)ret.I32;
            /*9337*/
            return ret_result;
            /*9338*/
        }
        /// <summary>
        /// Removes all values. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*9339*/


        // gen! bool Clear()
        /*9340*/

        public bool Clear()/*9341*/
        {
            JsValue ret;
            /*9342*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_Clear_8, out ret);
            /*9343*/
            var ret_result = ret.I32 != 0;
            /*9344*/
            return ret_result;
            /*9345*/
        }
        /// <summary>
        /// Returns true if the current dictionary has a value for the given key.
        /// /*cef()*/
        /// </summary>
        /*9346*/


        // gen! bool HasKey(const CefString& key)
        /*9347*/

        public bool HasKey(string /*9348*/
        key
        )/*9349*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9350*/
            ;
            /*9351*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_HasKey_9, out ret, ref v1);
            /*9352*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9353*/
            ;
            /*9354*/
            return ret_result;
            /*9355*/
        }
        /// <summary>
        /// Reads all keys for this dictionary into the specified vector.
        /// /*cef()*/
        /// </summary>
        /*9356*/


        // gen! bool GetKeys(KeyList& keys)
        /*9357*/

        public bool GetKeys(KeyList /*9358*/
        keys
        )/*9359*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9360*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetKeys_10, out ret, ref v1);
            /*9361*/
            var ret_result = ret.I32 != 0;
            /*9362*/
            return ret_result;
            /*9363*/
        }
        /// <summary>
        /// Removes the value at the specified key. Returns true is the value was
        /// removed successfully.
        /// /*cef()*/
        /// </summary>
        /*9364*/


        // gen! bool Remove(const CefString& key)
        /*9365*/

        public bool Remove(string /*9366*/
        key
        )/*9367*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9368*/
            ;
            /*9369*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_Remove_11, out ret, ref v1);
            /*9370*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9371*/
            ;
            /*9372*/
            return ret_result;
            /*9373*/
        }
        /// <summary>
        /// Returns the value type for the specified key.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>
        /*9374*/


        // gen! CefValueType GetType(const CefString& key)
        /*9375*/

        public cef_value_type_t _GetType(string /*9376*/
        key
        )/*9377*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9378*/
            ;
            /*9379*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetType_12, out ret, ref v1);
            /*9380*/
            var ret_result = (cef_value_type_t)ret.I32;

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9381*/
            ;
            /*9382*/
            return ret_result;
            /*9383*/
        }
        /// <summary>
        /// Returns the value at the specified key. For simple types the returned
        /// value will copy existing data and modifications to the value will not
        /// modify this object. For complex types (binary, dictionary and list) the
        /// returned value will reference existing data and modifications to the value
        /// will modify this object.
        /// /*cef()*/
        /// </summary>
        /*9384*/


        // gen! CefRefPtr<CefValue> GetValue(const CefString& key)
        /*9385*/

        public CefValue GetValue(string /*9386*/
        key
        )/*9387*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9388*/
            ;
            /*9389*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetValue_13, out ret, ref v1);
            /*9390*/
            var ret_result = new CefValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9391*/
            ;
            /*9392*/
            return ret_result;
            /*9393*/
        }
        /// <summary>
        /// Returns the value at the specified key as type bool.
        /// /*cef()*/
        /// </summary>
        /*9394*/


        // gen! bool GetBool(const CefString& key)
        /*9395*/

        public bool GetBool(string /*9396*/
        key
        )/*9397*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9398*/
            ;
            /*9399*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetBool_14, out ret, ref v1);
            /*9400*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9401*/
            ;
            /*9402*/
            return ret_result;
            /*9403*/
        }
        /// <summary>
        /// Returns the value at the specified key as type int.
        /// /*cef()*/
        /// </summary>
        /*9404*/


        // gen! int GetInt(const CefString& key)
        /*9405*/

        public int GetInt(string /*9406*/
        key
        )/*9407*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9408*/
            ;
            /*9409*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetInt_15, out ret, ref v1);
            /*9410*/
            var ret_result = ret.I32;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9411*/
            ;
            /*9412*/
            return ret_result;
            /*9413*/
        }
        /// <summary>
        /// Returns the value at the specified key as type double.
        /// /*cef()*/
        /// </summary>
        /*9414*/


        // gen! double GetDouble(const CefString& key)
        /*9415*/

        public double GetDouble(string /*9416*/
        key
        )/*9417*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9418*/
            ;
            /*9419*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetDouble_16, out ret, ref v1);
            /*9420*/
            var ret_result = ret.Num;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9421*/
            ;
            /*9422*/
            return ret_result;
            /*9423*/
        }
        /// <summary>
        /// Returns the value at the specified key as type string.
        /// /*cef()*/
        /// </summary>
        /*9424*/


        // gen! CefString GetString(const CefString& key)
        /*9425*/

        public string GetString(string /*9426*/
        key
        )/*9427*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9428*/
            ;
            /*9429*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetString_17, out ret, ref v1);
            /*9430*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9431*/
            ;
            /*9432*/
            return ret_result;
            /*9433*/
        }
        /// <summary>
        /// Returns the value at the specified key as type binary. The returned
        /// value will reference existing data.
        /// /*cef()*/
        /// </summary>
        /*9434*/


        // gen! CefRefPtr<CefBinaryValue> GetBinary(const CefString& key)
        /*9435*/

        public CefBinaryValue GetBinary(string /*9436*/
        key
        )/*9437*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9438*/
            ;
            /*9439*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetBinary_18, out ret, ref v1);
            /*9440*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9441*/
            ;
            /*9442*/
            return ret_result;
            /*9443*/
        }
        /// <summary>
        /// Returns the value at the specified key as type dictionary. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>
        /*9444*/


        // gen! CefRefPtr<CefDictionaryValue> GetDictionary(const CefString& key)
        /*9445*/

        public CefDictionaryValue GetDictionary(string /*9446*/
        key
        )/*9447*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9448*/
            ;
            /*9449*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetDictionary_19, out ret, ref v1);
            /*9450*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9451*/
            ;
            /*9452*/
            return ret_result;
            /*9453*/
        }
        /// <summary>
        /// Returns the value at the specified key as type list. The returned value
        /// will reference existing data and modifications to the value will modify
        /// this object.
        /// /*cef()*/
        /// </summary>
        /*9454*/


        // gen! CefRefPtr<CefListValue> GetList(const CefString& key)
        /*9455*/

        public CefListValue GetList(string /*9456*/
        key
        )/*9457*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9458*/
            ;
            /*9459*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetList_20, out ret, ref v1);
            /*9460*/
            var ret_result = new CefListValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9461*/
            ;
            /*9462*/
            return ret_result;
            /*9463*/
        }
        /// <summary>
        /// Sets the value at the specified key. Returns true if the value was set
        /// successfully. If |value| represents simple data then the underlying data
        /// will be copied and modifications to |value| will not modify this object. If
        /// |value| represents complex data (binary, dictionary or list) then the
        /// underlying data will be referenced and modifications to |value| will modify
        /// this object.
        /// /*cef()*/
        /// </summary>
        /*9464*/


        // gen! bool SetValue(const CefString& key,CefRefPtr<CefValue> value)
        /*9465*/

        public bool SetValue(string /*9466*/
        key
        , CefValue /*9467*/
        value
        )/*9468*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9469*/
            ;
            /*9470*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetValue_21, out ret, ref v1, ref v2);
            /*9471*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9472*/
            ;
            /*9473*/
            return ret_result;
            /*9474*/
        }
        /// <summary>
        /// Sets the value at the specified key as type null. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9475*/


        // gen! bool SetNull(const CefString& key)
        /*9476*/

        public bool SetNull(string /*9477*/
        key
        )/*9478*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9479*/
            ;
            /*9480*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_SetNull_22, out ret, ref v1);
            /*9481*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9482*/
            ;
            /*9483*/
            return ret_result;
            /*9484*/
        }
        /// <summary>
        /// Sets the value at the specified key as type bool. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9485*/


        // gen! bool SetBool(const CefString& key,bool value)
        /*9486*/

        public bool SetBool(string /*9487*/
        key
        , bool /*9488*/
        value
        )/*9489*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9490*/
            ;
            /*9491*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetBool_23, out ret, ref v1, ref v2);
            /*9492*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9493*/
            ;
            /*9494*/
            return ret_result;
            /*9495*/
        }
        /// <summary>
        /// Sets the value at the specified key as type int. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9496*/


        // gen! bool SetInt(const CefString& key,int value)
        /*9497*/

        public bool SetInt(string /*9498*/
        key
        , int /*9499*/
        value
        )/*9500*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9501*/
            ;
            /*9502*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetInt_24, out ret, ref v1, ref v2);
            /*9503*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9504*/
            ;
            /*9505*/
            return ret_result;
            /*9506*/
        }
        /// <summary>
        /// Sets the value at the specified key as type double. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9507*/


        // gen! bool SetDouble(const CefString& key,double value)
        /*9508*/

        public bool SetDouble(string /*9509*/
        key
        , double /*9510*/
        value
        )/*9511*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9512*/
            ;
            /*9513*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetDouble_25, out ret, ref v1, ref v2);
            /*9514*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9515*/
            ;
            /*9516*/
            return ret_result;
            /*9517*/
        }
        /// <summary>
        /// Sets the value at the specified key as type string. Returns true if the
        /// value was set successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>
        /*9518*/


        // gen! bool SetString(const CefString& key,const CefString& value)
        /*9519*/

        public bool SetString(string /*9520*/
        key
        , string /*9521*/
        value
        )/*9522*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9523*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*9524*/
            ;
            /*9525*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetString_26, out ret, ref v1, ref v2);
            /*9526*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9527*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*9528*/
            ;
            /*9529*/
            return ret_result;
            /*9530*/
        }
        /// <summary>
        /// Sets the value at the specified key as type binary. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>
        /*9531*/


        // gen! bool SetBinary(const CefString& key,CefRefPtr<CefBinaryValue> value)
        /*9532*/

        public bool SetBinary(string /*9533*/
        key
        , CefBinaryValue /*9534*/
        value
        )/*9535*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9536*/
            ;
            /*9537*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetBinary_27, out ret, ref v1, ref v2);
            /*9538*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9539*/
            ;
            /*9540*/
            return ret_result;
            /*9541*/
        }
        /// <summary>
        /// Sets the value at the specified key as type dict. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>
        /*9542*/


        // gen! bool SetDictionary(const CefString& key,CefRefPtr<CefDictionaryValue> value)
        /*9543*/

        public bool SetDictionary(string /*9544*/
        key
        , CefDictionaryValue /*9545*/
        value
        )/*9546*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9547*/
            ;
            /*9548*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetDictionary_28, out ret, ref v1, ref v2);
            /*9549*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9550*/
            ;
            /*9551*/
            return ret_result;
            /*9552*/
        }
        /// <summary>
        /// Sets the value at the specified key as type list. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>
        /*9553*/


        // gen! bool SetList(const CefString& key,CefRefPtr<CefListValue> value)
        /*9554*/

        public bool SetList(string /*9555*/
        key
        , CefListValue /*9556*/
        value
        )/*9557*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9558*/
            ;
            /*9559*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetList_29, out ret, ref v1, ref v2);
            /*9560*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9561*/
            ;
            /*9562*/
            return ret_result;
            /*9563*/
        }
        /*9564*/
    }


    // [virtual] class CefListValue
    /// <summary>
    /// Class representing a list value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    /*9713*/
    public struct CefListValue
    {
        /*9714*/
        const int _typeNAME = 49;
        /*9715*/
        const int CefListValue_Release_0 = (_typeNAME << 16) | 0;
        /*9716*/
        const int CefListValue_IsValid_1 = (_typeNAME << 16) | 1;
        /*9717*/
        const int CefListValue_IsOwned_2 = (_typeNAME << 16) | 2;
        /*9718*/
        const int CefListValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        /*9719*/
        const int CefListValue_IsSame_4 = (_typeNAME << 16) | 4;
        /*9720*/
        const int CefListValue_IsEqual_5 = (_typeNAME << 16) | 5;
        /*9721*/
        const int CefListValue_Copy_6 = (_typeNAME << 16) | 6;
        /*9722*/
        const int CefListValue_SetSize_7 = (_typeNAME << 16) | 7;
        /*9723*/
        const int CefListValue_GetSize_8 = (_typeNAME << 16) | 8;
        /*9724*/
        const int CefListValue_Clear_9 = (_typeNAME << 16) | 9;
        /*9725*/
        const int CefListValue_Remove_10 = (_typeNAME << 16) | 10;
        /*9726*/
        const int CefListValue_GetType_11 = (_typeNAME << 16) | 11;
        /*9727*/
        const int CefListValue_GetValue_12 = (_typeNAME << 16) | 12;
        /*9728*/
        const int CefListValue_GetBool_13 = (_typeNAME << 16) | 13;
        /*9729*/
        const int CefListValue_GetInt_14 = (_typeNAME << 16) | 14;
        /*9730*/
        const int CefListValue_GetDouble_15 = (_typeNAME << 16) | 15;
        /*9731*/
        const int CefListValue_GetString_16 = (_typeNAME << 16) | 16;
        /*9732*/
        const int CefListValue_GetBinary_17 = (_typeNAME << 16) | 17;
        /*9733*/
        const int CefListValue_GetDictionary_18 = (_typeNAME << 16) | 18;
        /*9734*/
        const int CefListValue_GetList_19 = (_typeNAME << 16) | 19;
        /*9735*/
        const int CefListValue_SetValue_20 = (_typeNAME << 16) | 20;
        /*9736*/
        const int CefListValue_SetNull_21 = (_typeNAME << 16) | 21;
        /*9737*/
        const int CefListValue_SetBool_22 = (_typeNAME << 16) | 22;
        /*9738*/
        const int CefListValue_SetInt_23 = (_typeNAME << 16) | 23;
        /*9739*/
        const int CefListValue_SetDouble_24 = (_typeNAME << 16) | 24;
        /*9740*/
        const int CefListValue_SetString_25 = (_typeNAME << 16) | 25;
        /*9741*/
        const int CefListValue_SetBinary_26 = (_typeNAME << 16) | 26;
        /*9742*/
        const int CefListValue_SetDictionary_27 = (_typeNAME << 16) | 27;
        /*9743*/
        const int CefListValue_SetList_28 = (_typeNAME << 16) | 28;
        /*9744*/
        internal readonly IntPtr nativePtr;
        /*9745*/
        internal CefListValue(IntPtr nativePtr)
        {
            /*9746*/
            this.nativePtr = nativePtr;
            /*9747*/
        }
        /*9748*/
        public void Release()
        {
            /*9749*/
            JsValue ret;
            /*9750*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Release_0, out ret);
            /*9751*/
        }
        /// <summary>
        /// CefListValue methods.
        /// </summary>
        /*9752*/


        // gen! bool IsValid()
        /*9753*/

        public bool IsValid()/*9754*/
        {
            JsValue ret;
            /*9755*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsValid_1, out ret);
            /*9756*/
            var ret_result = ret.I32 != 0;
            /*9757*/
            return ret_result;
            /*9758*/
        }
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>
        /*9759*/


        // gen! bool IsOwned()
        /*9760*/

        public bool IsOwned()/*9761*/
        {
            JsValue ret;
            /*9762*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsOwned_2, out ret);
            /*9763*/
            var ret_result = ret.I32 != 0;
            /*9764*/
            return ret_result;
            /*9765*/
        }
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*9766*/


        // gen! bool IsReadOnly()
        /*9767*/

        public bool IsReadOnly()/*9768*/
        {
            JsValue ret;
            /*9769*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsReadOnly_3, out ret);
            /*9770*/
            var ret_result = ret.I32 != 0;
            /*9771*/
            return ret_result;
            /*9772*/
        }
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>
        /*9773*/


        // gen! bool IsSame(CefRefPtr<CefListValue> that)
        /*9774*/

        public bool IsSame(CefListValue /*9775*/
        that
        )/*9776*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9777*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_IsSame_4, out ret, ref v1);
            /*9778*/
            var ret_result = ret.I32 != 0;
            /*9779*/
            return ret_result;
            /*9780*/
        }
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>
        /*9781*/


        // gen! bool IsEqual(CefRefPtr<CefListValue> that)
        /*9782*/

        public bool IsEqual(CefListValue /*9783*/
        that
        )/*9784*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9785*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_IsEqual_5, out ret, ref v1);
            /*9786*/
            var ret_result = ret.I32 != 0;
            /*9787*/
            return ret_result;
            /*9788*/
        }
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>
        /*9789*/


        // gen! CefRefPtr<CefListValue> Copy()
        /*9790*/

        public CefListValue Copy()/*9791*/
        {
            JsValue ret;
            /*9792*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Copy_6, out ret);
            /*9793*/
            var ret_result = new CefListValue(ret.Ptr);
            /*9794*/
            return ret_result;
            /*9795*/
        }
        /// <summary>
        /// Sets the number of values. If the number of values is expanded all
        /// new value slots will default to type null. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*9796*/


        // gen! bool SetSize(size_t size)
        /*9797*/

        public bool SetSize(uint /*9798*/
        size
        )/*9799*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9800*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_SetSize_7, out ret, ref v1);
            /*9801*/
            var ret_result = ret.I32 != 0;
            /*9802*/
            return ret_result;
            /*9803*/
        }
        /// <summary>
        /// Returns the number of values.
        /// /*cef()*/
        /// </summary>
        /*9804*/


        // gen! size_t GetSize()
        /*9805*/

        public uint GetSize()/*9806*/
        {
            JsValue ret;
            /*9807*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_GetSize_8, out ret);
            /*9808*/
            var ret_result = (uint)ret.I32;
            /*9809*/
            return ret_result;
            /*9810*/
        }
        /// <summary>
        /// Removes all values. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*9811*/


        // gen! bool Clear()
        /*9812*/

        public bool Clear()/*9813*/
        {
            JsValue ret;
            /*9814*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Clear_9, out ret);
            /*9815*/
            var ret_result = ret.I32 != 0;
            /*9816*/
            return ret_result;
            /*9817*/
        }
        /// <summary>
        /// Removes the value at the specified index.
        /// /*cef()*/
        /// </summary>
        /*9818*/


        // gen! bool Remove(size_t index)
        /*9819*/

        public bool Remove(uint /*9820*/
        index
        )/*9821*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9822*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_Remove_10, out ret, ref v1);
            /*9823*/
            var ret_result = ret.I32 != 0;
            /*9824*/
            return ret_result;
            /*9825*/
        }
        /// <summary>
        /// Returns the value type at the specified index.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>
        /*9826*/


        // gen! CefValueType GetType(size_t index)
        /*9827*/

        public cef_value_type_t _GetType(uint /*9828*/
        index
        )/*9829*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9830*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetType_11, out ret, ref v1);
            /*9831*/
            var ret_result = (cef_value_type_t)ret.I32;

            /*9832*/
            return ret_result;
            /*9833*/
        }
        /// <summary>
        /// Returns the value at the specified index. For simple types the returned
        /// value will copy existing data and modifications to the value will not
        /// modify this object. For complex types (binary, dictionary and list) the
        /// returned value will reference existing data and modifications to the value
        /// will modify this object.
        /// /*cef()*/
        /// </summary>
        /*9834*/


        // gen! CefRefPtr<CefValue> GetValue(size_t index)
        /*9835*/

        public CefValue GetValue(uint /*9836*/
        index
        )/*9837*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9838*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetValue_12, out ret, ref v1);
            /*9839*/
            var ret_result = new CefValue(ret.Ptr);
            /*9840*/
            return ret_result;
            /*9841*/
        }
        /// <summary>
        /// Returns the value at the specified index as type bool.
        /// /*cef()*/
        /// </summary>
        /*9842*/


        // gen! bool GetBool(size_t index)
        /*9843*/

        public bool GetBool(uint /*9844*/
        index
        )/*9845*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9846*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetBool_13, out ret, ref v1);
            /*9847*/
            var ret_result = ret.I32 != 0;
            /*9848*/
            return ret_result;
            /*9849*/
        }
        /// <summary>
        /// Returns the value at the specified index as type int.
        /// /*cef()*/
        /// </summary>
        /*9850*/


        // gen! int GetInt(size_t index)
        /*9851*/

        public int GetInt(uint /*9852*/
        index
        )/*9853*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9854*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetInt_14, out ret, ref v1);
            /*9855*/
            var ret_result = ret.I32;
            /*9856*/
            return ret_result;
            /*9857*/
        }
        /// <summary>
        /// Returns the value at the specified index as type double.
        /// /*cef()*/
        /// </summary>
        /*9858*/


        // gen! double GetDouble(size_t index)
        /*9859*/

        public double GetDouble(uint /*9860*/
        index
        )/*9861*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9862*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetDouble_15, out ret, ref v1);
            /*9863*/
            var ret_result = ret.Num;
            /*9864*/
            return ret_result;
            /*9865*/
        }
        /// <summary>
        /// Returns the value at the specified index as type string.
        /// /*cef()*/
        /// </summary>
        /*9866*/


        // gen! CefString GetString(size_t index)
        /*9867*/

        public string GetString(uint /*9868*/
        index
        )/*9869*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9870*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetString_16, out ret, ref v1);
            /*9871*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9872*/
            return ret_result;
            /*9873*/
        }
        /// <summary>
        /// Returns the value at the specified index as type binary. The returned
        /// value will reference existing data.
        /// /*cef()*/
        /// </summary>
        /*9874*/


        // gen! CefRefPtr<CefBinaryValue> GetBinary(size_t index)
        /*9875*/

        public CefBinaryValue GetBinary(uint /*9876*/
        index
        )/*9877*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9878*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetBinary_17, out ret, ref v1);
            /*9879*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*9880*/
            return ret_result;
            /*9881*/
        }
        /// <summary>
        /// Returns the value at the specified index as type dictionary. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>
        /*9882*/


        // gen! CefRefPtr<CefDictionaryValue> GetDictionary(size_t index)
        /*9883*/

        public CefDictionaryValue GetDictionary(uint /*9884*/
        index
        )/*9885*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9886*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetDictionary_18, out ret, ref v1);
            /*9887*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            /*9888*/
            return ret_result;
            /*9889*/
        }
        /// <summary>
        /// Returns the value at the specified index as type list. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>
        /*9890*/


        // gen! CefRefPtr<CefListValue> GetList(size_t index)
        /*9891*/

        public CefListValue GetList(uint /*9892*/
        index
        )/*9893*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9894*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetList_19, out ret, ref v1);
            /*9895*/
            var ret_result = new CefListValue(ret.Ptr);
            /*9896*/
            return ret_result;
            /*9897*/
        }
        /// <summary>
        /// Sets the value at the specified index. Returns true if the value was set
        /// successfully. If |value| represents simple data then the underlying data
        /// will be copied and modifications to |value| will not modify this object. If
        /// |value| represents complex data (binary, dictionary or list) then the
        /// underlying data will be referenced and modifications to |value| will modify
        /// this object.
        /// /*cef()*/
        /// </summary>
        /*9898*/


        // gen! bool SetValue(size_t index,CefRefPtr<CefValue> value)
        /*9899*/

        public bool SetValue(uint /*9900*/
        index
        , CefValue /*9901*/
        value
        )/*9902*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*9903*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetValue_20, out ret, ref v1, ref v2);
            /*9904*/
            var ret_result = ret.I32 != 0;
            /*9905*/
            return ret_result;
            /*9906*/
        }
        /// <summary>
        /// Sets the value at the specified index as type null. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9907*/


        // gen! bool SetNull(size_t index)
        /*9908*/

        public bool SetNull(uint /*9909*/
        index
        )/*9910*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*9911*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_SetNull_21, out ret, ref v1);
            /*9912*/
            var ret_result = ret.I32 != 0;
            /*9913*/
            return ret_result;
            /*9914*/
        }
        /// <summary>
        /// Sets the value at the specified index as type bool. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9915*/


        // gen! bool SetBool(size_t index,bool value)
        /*9916*/

        public bool SetBool(uint /*9917*/
        index
        , bool /*9918*/
        value
        )/*9919*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*9920*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetBool_22, out ret, ref v1, ref v2);
            /*9921*/
            var ret_result = ret.I32 != 0;
            /*9922*/
            return ret_result;
            /*9923*/
        }
        /// <summary>
        /// Sets the value at the specified index as type int. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9924*/


        // gen! bool SetInt(size_t index,int value)
        /*9925*/

        public bool SetInt(uint /*9926*/
        index
        , int /*9927*/
        value
        )/*9928*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*9929*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetInt_23, out ret, ref v1, ref v2);
            /*9930*/
            var ret_result = ret.I32 != 0;
            /*9931*/
            return ret_result;
            /*9932*/
        }
        /// <summary>
        /// Sets the value at the specified index as type double. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9933*/


        // gen! bool SetDouble(size_t index,double value)
        /*9934*/

        public bool SetDouble(uint /*9935*/
        index
        , double /*9936*/
        value
        )/*9937*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*9938*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetDouble_24, out ret, ref v1, ref v2);
            /*9939*/
            var ret_result = ret.I32 != 0;
            /*9940*/
            return ret_result;
            /*9941*/
        }
        /// <summary>
        /// Sets the value at the specified index as type string. Returns true if the
        /// value was set successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>
        /*9942*/


        // gen! bool SetString(size_t index,const CefString& value)
        /*9943*/

        public bool SetString(uint /*9944*/
        index
        , string /*9945*/
        value
        )/*9946*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*9947*/
            ;
            /*9948*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetString_25, out ret, ref v1, ref v2);
            /*9949*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*9950*/
            ;
            /*9951*/
            return ret_result;
            /*9952*/
        }
        /// <summary>
        /// Sets the value at the specified index as type binary. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>
        /*9953*/


        // gen! bool SetBinary(size_t index,CefRefPtr<CefBinaryValue> value)
        /*9954*/

        public bool SetBinary(uint /*9955*/
        index
        , CefBinaryValue /*9956*/
        value
        )/*9957*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*9958*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetBinary_26, out ret, ref v1, ref v2);
            /*9959*/
            var ret_result = ret.I32 != 0;
            /*9960*/
            return ret_result;
            /*9961*/
        }
        /// <summary>
        /// Sets the value at the specified index as type dict. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>
        /*9962*/


        // gen! bool SetDictionary(size_t index,CefRefPtr<CefDictionaryValue> value)
        /*9963*/

        public bool SetDictionary(uint /*9964*/
        index
        , CefDictionaryValue /*9965*/
        value
        )/*9966*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*9967*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetDictionary_27, out ret, ref v1, ref v2);
            /*9968*/
            var ret_result = ret.I32 != 0;
            /*9969*/
            return ret_result;
            /*9970*/
        }
        /// <summary>
        /// Sets the value at the specified index as type list. Returns true if the
        /// value was set successfully. If |value| is currently owned by another object
        /// then the value will be copied and the |value| reference will not change.
        /// Otherwise, ownership will be transferred to this object and the |value|
        /// reference will be invalidated.
        /// /*cef()*/
        /// </summary>
        /*9971*/


        // gen! bool SetList(size_t index,CefRefPtr<CefListValue> value)
        /*9972*/

        public bool SetList(uint /*9973*/
        index
        , CefListValue /*9974*/
        value
        )/*9975*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*9976*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetList_28, out ret, ref v1, ref v2);
            /*9977*/
            var ret_result = ret.I32 != 0;
            /*9978*/
            return ret_result;
            /*9979*/
        }
        /*9980*/
    }


    // [virtual] class CefWebPluginInfo
    /// <summary>
    /// Information about a specific web plugin.
    /// /*(source=library)*/
    /// </summary>
    /*10009*/
    public struct CefWebPluginInfo
    {
        /*10010*/
        const int _typeNAME = 50;
        /*10011*/
        const int CefWebPluginInfo_Release_0 = (_typeNAME << 16) | 0;
        /*10012*/
        const int CefWebPluginInfo_GetName_1 = (_typeNAME << 16) | 1;
        /*10013*/
        const int CefWebPluginInfo_GetPath_2 = (_typeNAME << 16) | 2;
        /*10014*/
        const int CefWebPluginInfo_GetVersion_3 = (_typeNAME << 16) | 3;
        /*10015*/
        const int CefWebPluginInfo_GetDescription_4 = (_typeNAME << 16) | 4;
        /*10016*/
        internal readonly IntPtr nativePtr;
        /*10017*/
        internal CefWebPluginInfo(IntPtr nativePtr)
        {
            /*10018*/
            this.nativePtr = nativePtr;
            /*10019*/
        }
        /*10020*/
        public void Release()
        {
            /*10021*/
            JsValue ret;
            /*10022*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_Release_0, out ret);
            /*10023*/
        }
        /// <summary>
        /// CefWebPluginInfo methods.
        /// </summary>
        /*10024*/


        // gen! CefString GetName()
        /*10025*/

        public string GetName()/*10026*/
        {
            JsValue ret;
            /*10027*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetName_1, out ret);
            /*10028*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10029*/
            return ret_result;
            /*10030*/
        }
        /// <summary>
        /// Returns the plugin file path (DLL/bundle/library).
        /// /*cef()*/
        /// </summary>
        /*10031*/


        // gen! CefString GetPath()
        /*10032*/

        public string GetPath()/*10033*/
        {
            JsValue ret;
            /*10034*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetPath_2, out ret);
            /*10035*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10036*/
            return ret_result;
            /*10037*/
        }
        /// <summary>
        /// Returns the version of the plugin (may be OS-specific).
        /// /*cef()*/
        /// </summary>
        /*10038*/


        // gen! CefString GetVersion()
        /*10039*/

        public string GetVersion()/*10040*/
        {
            JsValue ret;
            /*10041*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetVersion_3, out ret);
            /*10042*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10043*/
            return ret_result;
            /*10044*/
        }
        /// <summary>
        /// Returns a description of the plugin from the version information.
        /// /*cef()*/
        /// </summary>
        /*10045*/


        // gen! CefString GetDescription()
        /*10046*/

        public string GetDescription()/*10047*/
        {
            JsValue ret;
            /*10048*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetDescription_4, out ret);
            /*10049*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10050*/
            return ret_result;
            /*10051*/
        }
        /*10052*/
    }


    // [virtual] class CefWebPluginInfoVisitor
    /// <summary>
    /// Interface to implement for visiting web plugin information. The methods of
    /// this class will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    /*10061*/
    public struct CefWebPluginInfoVisitor
    {
        /*10062*/
        const int _typeNAME = 51;
        /*10063*/
        const int CefWebPluginInfoVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*10064*/
        internal readonly IntPtr nativePtr;
        /*10065*/
        internal CefWebPluginInfoVisitor(IntPtr nativePtr)
        {
            /*10066*/
            this.nativePtr = nativePtr;
            /*10067*/
        }
        /*10068*/
        public void Release()
        {
            /*10069*/
            JsValue ret;
            /*10070*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfoVisitor_Release_0, out ret);
            /*10071*/
        }
        /*10072*/
    }


    // [virtual] class CefX509CertPrincipal
    /// <summary>
    /// Class representing the issuer or subject field of an X.509 certificate.
    /// /*(source=library)*/
    /// </summary>
    /*10126*/
    public struct CefX509CertPrincipal
    {
        /*10127*/
        const int _typeNAME = 52;
        /*10128*/
        const int CefX509CertPrincipal_Release_0 = (_typeNAME << 16) | 0;
        /*10129*/
        const int CefX509CertPrincipal_GetDisplayName_1 = (_typeNAME << 16) | 1;
        /*10130*/
        const int CefX509CertPrincipal_GetCommonName_2 = (_typeNAME << 16) | 2;
        /*10131*/
        const int CefX509CertPrincipal_GetLocalityName_3 = (_typeNAME << 16) | 3;
        /*10132*/
        const int CefX509CertPrincipal_GetStateOrProvinceName_4 = (_typeNAME << 16) | 4;
        /*10133*/
        const int CefX509CertPrincipal_GetCountryName_5 = (_typeNAME << 16) | 5;
        /*10134*/
        const int CefX509CertPrincipal_GetStreetAddresses_6 = (_typeNAME << 16) | 6;
        /*10135*/
        const int CefX509CertPrincipal_GetOrganizationNames_7 = (_typeNAME << 16) | 7;
        /*10136*/
        const int CefX509CertPrincipal_GetOrganizationUnitNames_8 = (_typeNAME << 16) | 8;
        /*10137*/
        const int CefX509CertPrincipal_GetDomainComponents_9 = (_typeNAME << 16) | 9;
        /*10138*/
        internal readonly IntPtr nativePtr;
        /*10139*/
        internal CefX509CertPrincipal(IntPtr nativePtr)
        {
            /*10140*/
            this.nativePtr = nativePtr;
            /*10141*/
        }
        /*10142*/
        public void Release()
        {
            /*10143*/
            JsValue ret;
            /*10144*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_Release_0, out ret);
            /*10145*/
        }
        /// <summary>
        /// CefX509CertPrincipal methods.
        /// </summary>
        /*10146*/


        // gen! CefString GetDisplayName()
        /*10147*/

        public string GetDisplayName()/*10148*/
        {
            JsValue ret;
            /*10149*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetDisplayName_1, out ret);
            /*10150*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10151*/
            return ret_result;
            /*10152*/
        }
        /// <summary>
        /// Returns the common name.
        /// /*cef()*/
        /// </summary>
        /*10153*/


        // gen! CefString GetCommonName()
        /*10154*/

        public string GetCommonName()/*10155*/
        {
            JsValue ret;
            /*10156*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetCommonName_2, out ret);
            /*10157*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10158*/
            return ret_result;
            /*10159*/
        }
        /// <summary>
        /// Returns the locality name.
        /// /*cef()*/
        /// </summary>
        /*10160*/


        // gen! CefString GetLocalityName()
        /*10161*/

        public string GetLocalityName()/*10162*/
        {
            JsValue ret;
            /*10163*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetLocalityName_3, out ret);
            /*10164*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10165*/
            return ret_result;
            /*10166*/
        }
        /// <summary>
        /// Returns the state or province name.
        /// /*cef()*/
        /// </summary>
        /*10167*/


        // gen! CefString GetStateOrProvinceName()
        /*10168*/

        public string GetStateOrProvinceName()/*10169*/
        {
            JsValue ret;
            /*10170*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetStateOrProvinceName_4, out ret);
            /*10171*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10172*/
            return ret_result;
            /*10173*/
        }
        /// <summary>
        /// Returns the country name.
        /// /*cef()*/
        /// </summary>
        /*10174*/


        // gen! CefString GetCountryName()
        /*10175*/

        public string GetCountryName()/*10176*/
        {
            JsValue ret;
            /*10177*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetCountryName_5, out ret);
            /*10178*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10179*/
            return ret_result;
            /*10180*/
        }
        /// <summary>
        /// Retrieve the list of street addresses.
        /// /*cef()*/
        /// </summary>
        /*10181*/


        // gen! void GetStreetAddresses(std::vector<CefString>& addresses)
        /*10182*/

        public void GetStreetAddresses(List<string> /*10183*/
        addresses
        )/*10184*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*10185*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetStreetAddresses_6, out ret, ref v1);
            /*10186*/

            /*10187*/
        }
        /// <summary>
        /// Retrieve the list of organization names.
        /// /*cef()*/
        /// </summary>
        /*10188*/


        // gen! void GetOrganizationNames(std::vector<CefString>& names)
        /*10189*/

        public void GetOrganizationNames(List<string> /*10190*/
        names
        )/*10191*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*10192*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetOrganizationNames_7, out ret, ref v1);
            /*10193*/

            /*10194*/
        }
        /// <summary>
        /// Retrieve the list of organization unit names.
        /// /*cef()*/
        /// </summary>
        /*10195*/


        // gen! void GetOrganizationUnitNames(std::vector<CefString>& names)
        /*10196*/

        public void GetOrganizationUnitNames(List<string> /*10197*/
        names
        )/*10198*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*10199*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetOrganizationUnitNames_8, out ret, ref v1);
            /*10200*/

            /*10201*/
        }
        /// <summary>
        /// Retrieve the list of domain components.
        /// /*cef()*/
        /// </summary>
        /*10202*/


        // gen! void GetDomainComponents(std::vector<CefString>& components)
        /*10203*/

        public void GetDomainComponents(List<string> /*10204*/
        components
        )/*10205*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*10206*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetDomainComponents_9, out ret, ref v1);
            /*10207*/

            /*10208*/
        }
        /*10209*/
    }


    // [virtual] class CefX509Certificate
    /// <summary>
    /// Class representing a X.509 certificate.
    /// /*(source=library)*/
    /// </summary>
    /*10268*/
    public struct CefX509Certificate
    {
        /*10269*/
        const int _typeNAME = 53;
        /*10270*/
        const int CefX509Certificate_Release_0 = (_typeNAME << 16) | 0;
        /*10271*/
        const int CefX509Certificate_GetSubject_1 = (_typeNAME << 16) | 1;
        /*10272*/
        const int CefX509Certificate_GetIssuer_2 = (_typeNAME << 16) | 2;
        /*10273*/
        const int CefX509Certificate_GetSerialNumber_3 = (_typeNAME << 16) | 3;
        /*10274*/
        const int CefX509Certificate_GetValidStart_4 = (_typeNAME << 16) | 4;
        /*10275*/
        const int CefX509Certificate_GetValidExpiry_5 = (_typeNAME << 16) | 5;
        /*10276*/
        const int CefX509Certificate_GetDEREncoded_6 = (_typeNAME << 16) | 6;
        /*10277*/
        const int CefX509Certificate_GetPEMEncoded_7 = (_typeNAME << 16) | 7;
        /*10278*/
        const int CefX509Certificate_GetIssuerChainSize_8 = (_typeNAME << 16) | 8;
        /*10279*/
        const int CefX509Certificate_GetDEREncodedIssuerChain_9 = (_typeNAME << 16) | 9;
        /*10280*/
        const int CefX509Certificate_GetPEMEncodedIssuerChain_10 = (_typeNAME << 16) | 10;
        /*10281*/
        internal readonly IntPtr nativePtr;
        /*10282*/
        internal CefX509Certificate(IntPtr nativePtr)
        {
            /*10283*/
            this.nativePtr = nativePtr;
            /*10284*/
        }
        /*10285*/
        public void Release()
        {
            /*10286*/
            JsValue ret;
            /*10287*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_Release_0, out ret);
            /*10288*/
        }
        /// <summary>
        /// CefX509Certificate methods.
        /// </summary>
        /*10289*/


        // gen! CefRefPtr<CefX509CertPrincipal> GetSubject()
        /*10290*/

        public CefX509CertPrincipal GetSubject()/*10291*/
        {
            JsValue ret;
            /*10292*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetSubject_1, out ret);
            /*10293*/
            var ret_result = new CefX509CertPrincipal(ret.Ptr);
            /*10294*/
            return ret_result;
            /*10295*/
        }
        /// <summary>
        /// Returns the issuer of the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*10296*/


        // gen! CefRefPtr<CefX509CertPrincipal> GetIssuer()
        /*10297*/

        public CefX509CertPrincipal GetIssuer()/*10298*/
        {
            JsValue ret;
            /*10299*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetIssuer_2, out ret);
            /*10300*/
            var ret_result = new CefX509CertPrincipal(ret.Ptr);
            /*10301*/
            return ret_result;
            /*10302*/
        }
        /// <summary>
        /// Returns the DER encoded serial number for the X.509 certificate. The value
        /// possibly includes a leading 00 byte.
        /// /*cef()*/
        /// </summary>
        /*10303*/


        // gen! CefRefPtr<CefBinaryValue> GetSerialNumber()
        /*10304*/

        public CefBinaryValue GetSerialNumber()/*10305*/
        {
            JsValue ret;
            /*10306*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetSerialNumber_3, out ret);
            /*10307*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*10308*/
            return ret_result;
            /*10309*/
        }
        /// <summary>
        /// Returns the date before which the X.509 certificate is invalid.
        /// CefTime.GetTimeT() will return 0 if no date was specified.
        /// /*cef()*/
        /// </summary>
        /*10310*/


        // gen! CefTime GetValidStart()
        /*10311*/

        public CefTime GetValidStart()/*10312*/
        {
            JsValue ret;
            /*10313*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetValidStart_4, out ret);
            /*10314*/
            var ret_result = new CefTime(ret.Ptr);

            /*10315*/
            return ret_result;
            /*10316*/
        }
        /// <summary>
        /// Returns the date after which the X.509 certificate is invalid.
        /// CefTime.GetTimeT() will return 0 if no date was specified.
        /// /*cef()*/
        /// </summary>
        /*10317*/


        // gen! CefTime GetValidExpiry()
        /*10318*/

        public CefTime GetValidExpiry()/*10319*/
        {
            JsValue ret;
            /*10320*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetValidExpiry_5, out ret);
            /*10321*/
            var ret_result = new CefTime(ret.Ptr);

            /*10322*/
            return ret_result;
            /*10323*/
        }
        /// <summary>
        /// Returns the DER encoded data for the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*10324*/


        // gen! CefRefPtr<CefBinaryValue> GetDEREncoded()
        /*10325*/

        public CefBinaryValue GetDEREncoded()/*10326*/
        {
            JsValue ret;
            /*10327*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetDEREncoded_6, out ret);
            /*10328*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*10329*/
            return ret_result;
            /*10330*/
        }
        /// <summary>
        /// Returns the PEM encoded data for the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*10331*/


        // gen! CefRefPtr<CefBinaryValue> GetPEMEncoded()
        /*10332*/

        public CefBinaryValue GetPEMEncoded()/*10333*/
        {
            JsValue ret;
            /*10334*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetPEMEncoded_7, out ret);
            /*10335*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*10336*/
            return ret_result;
            /*10337*/
        }
        /// <summary>
        /// Returns the number of certificates in the issuer chain.
        /// If 0, the certificate is self-signed.
        /// /*cef()*/
        /// </summary>
        /*10338*/


        // gen! size_t GetIssuerChainSize()
        /*10339*/

        public uint GetIssuerChainSize()/*10340*/
        {
            JsValue ret;
            /*10341*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetIssuerChainSize_8, out ret);
            /*10342*/
            var ret_result = (uint)ret.I32;
            /*10343*/
            return ret_result;
            /*10344*/
        }
        /// <summary>
        /// Returns the DER encoded data for the certificate issuer chain.
        /// If we failed to encode a certificate in the chain it is still
        /// present in the array but is an empty string.
        /// /*cef(count_func=chain:GetIssuerChainSize)*/
        /// </summary>
        /*10345*/


        // gen! void GetDEREncodedIssuerChain(IssuerChainBinaryList& chain)
        /*10346*/

        public void GetDEREncodedIssuerChain(IssuerChainBinaryList /*10347*/
        chain
        )/*10348*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*10349*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509Certificate_GetDEREncodedIssuerChain_9, out ret, ref v1);
            /*10350*/

            /*10351*/
        }
        /// <summary>
        /// Returns the PEM encoded data for the certificate issuer chain.
        /// If we failed to encode a certificate in the chain it is still
        /// present in the array but is an empty string.
        /// /*cef(count_func=chain:GetIssuerChainSize)*/
        /// </summary>
        /*10352*/


        // gen! void GetPEMEncodedIssuerChain(IssuerChainBinaryList& chain)
        /*10353*/

        public void GetPEMEncodedIssuerChain(IssuerChainBinaryList /*10354*/
        chain
        )/*10355*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*10356*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509Certificate_GetPEMEncodedIssuerChain_10, out ret, ref v1);
            /*10357*/

            /*10358*/
        }
        /*10359*/
    }


    // [virtual] class CefXmlReader
    /// <summary>
    /// Class that supports the reading of XML data via the libxml streaming API.
    /// The methods of this class should only be called on the thread that creates
    /// the object.
    /// /*(source=library)*/
    /// </summary>
    /*10513*/
    public struct CefXmlReader
    {
        /*10514*/
        const int _typeNAME = 54;
        /*10515*/
        const int CefXmlReader_Release_0 = (_typeNAME << 16) | 0;
        /*10516*/
        const int CefXmlReader_MoveToNextNode_1 = (_typeNAME << 16) | 1;
        /*10517*/
        const int CefXmlReader_Close_2 = (_typeNAME << 16) | 2;
        /*10518*/
        const int CefXmlReader_HasError_3 = (_typeNAME << 16) | 3;
        /*10519*/
        const int CefXmlReader_GetError_4 = (_typeNAME << 16) | 4;
        /*10520*/
        const int CefXmlReader_GetType_5 = (_typeNAME << 16) | 5;
        /*10521*/
        const int CefXmlReader_GetDepth_6 = (_typeNAME << 16) | 6;
        /*10522*/
        const int CefXmlReader_GetLocalName_7 = (_typeNAME << 16) | 7;
        /*10523*/
        const int CefXmlReader_GetPrefix_8 = (_typeNAME << 16) | 8;
        /*10524*/
        const int CefXmlReader_GetQualifiedName_9 = (_typeNAME << 16) | 9;
        /*10525*/
        const int CefXmlReader_GetNamespaceURI_10 = (_typeNAME << 16) | 10;
        /*10526*/
        const int CefXmlReader_GetBaseURI_11 = (_typeNAME << 16) | 11;
        /*10527*/
        const int CefXmlReader_GetXmlLang_12 = (_typeNAME << 16) | 12;
        /*10528*/
        const int CefXmlReader_IsEmptyElement_13 = (_typeNAME << 16) | 13;
        /*10529*/
        const int CefXmlReader_HasValue_14 = (_typeNAME << 16) | 14;
        /*10530*/
        const int CefXmlReader_GetValue_15 = (_typeNAME << 16) | 15;
        /*10531*/
        const int CefXmlReader_HasAttributes_16 = (_typeNAME << 16) | 16;
        /*10532*/
        const int CefXmlReader_GetAttributeCount_17 = (_typeNAME << 16) | 17;
        /*10533*/
        const int CefXmlReader_GetAttribute_18 = (_typeNAME << 16) | 18;
        /*10534*/
        const int CefXmlReader_GetAttribute_19 = (_typeNAME << 16) | 19;
        /*10535*/
        const int CefXmlReader_GetAttribute_20 = (_typeNAME << 16) | 20;
        /*10536*/
        const int CefXmlReader_GetInnerXml_21 = (_typeNAME << 16) | 21;
        /*10537*/
        const int CefXmlReader_GetOuterXml_22 = (_typeNAME << 16) | 22;
        /*10538*/
        const int CefXmlReader_GetLineNumber_23 = (_typeNAME << 16) | 23;
        /*10539*/
        const int CefXmlReader_MoveToAttribute_24 = (_typeNAME << 16) | 24;
        /*10540*/
        const int CefXmlReader_MoveToAttribute_25 = (_typeNAME << 16) | 25;
        /*10541*/
        const int CefXmlReader_MoveToAttribute_26 = (_typeNAME << 16) | 26;
        /*10542*/
        const int CefXmlReader_MoveToFirstAttribute_27 = (_typeNAME << 16) | 27;
        /*10543*/
        const int CefXmlReader_MoveToNextAttribute_28 = (_typeNAME << 16) | 28;
        /*10544*/
        const int CefXmlReader_MoveToCarryingElement_29 = (_typeNAME << 16) | 29;
        /*10545*/
        internal readonly IntPtr nativePtr;
        /*10546*/
        internal CefXmlReader(IntPtr nativePtr)
        {
            /*10547*/
            this.nativePtr = nativePtr;
            /*10548*/
        }
        /*10549*/
        public void Release()
        {
            /*10550*/
            JsValue ret;
            /*10551*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_Release_0, out ret);
            /*10552*/
        }
        /// <summary>
        /// CefXmlReader methods.
        /// </summary>
        /*10553*/


        // gen! bool MoveToNextNode()
        /*10554*/

        public bool MoveToNextNode()/*10555*/
        {
            JsValue ret;
            /*10556*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToNextNode_1, out ret);
            /*10557*/
            var ret_result = ret.I32 != 0;
            /*10558*/
            return ret_result;
            /*10559*/
        }
        /// <summary>
        /// Close the document. This should be called directly to ensure that cleanup
        /// occurs on the correct thread.
        /// /*cef()*/
        /// </summary>
        /*10560*/


        // gen! bool Close()
        /*10561*/

        public bool Close()/*10562*/
        {
            JsValue ret;
            /*10563*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_Close_2, out ret);
            /*10564*/
            var ret_result = ret.I32 != 0;
            /*10565*/
            return ret_result;
            /*10566*/
        }
        /// <summary>
        /// Returns true if an error has been reported by the XML parser.
        /// /*cef()*/
        /// </summary>
        /*10567*/


        // gen! bool HasError()
        /*10568*/

        public bool HasError()/*10569*/
        {
            JsValue ret;
            /*10570*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasError_3, out ret);
            /*10571*/
            var ret_result = ret.I32 != 0;
            /*10572*/
            return ret_result;
            /*10573*/
        }
        /// <summary>
        /// Returns the error string.
        /// /*cef()*/
        /// </summary>
        /*10574*/


        // gen! CefString GetError()
        /*10575*/

        public string GetError()/*10576*/
        {
            JsValue ret;
            /*10577*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetError_4, out ret);
            /*10578*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10579*/
            return ret_result;
            /*10580*/
        }
        /// <summary>
        /// The below methods retrieve data for the node at the current cursor
        /// position.
        /// Returns the node type.
        /// /*cef(default_retval=XML_NODE_UNSUPPORTED)*/
        /// </summary>
        /*10581*/


        // gen! NodeType GetType()
        /*10582*/

        public cef_xml_node_type_t _GetType()/*10583*/
        {
            JsValue ret;
            /*10584*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetType_5, out ret);
            /*10585*/
            var ret_result = (cef_xml_node_type_t)ret.I32;

            /*10586*/
            return ret_result;
            /*10587*/
        }
        /// <summary>
        /// Returns the node depth. Depth starts at 0 for the root node.
        /// /*cef()*/
        /// </summary>
        /*10588*/


        // gen! int GetDepth()
        /*10589*/

        public int GetDepth()/*10590*/
        {
            JsValue ret;
            /*10591*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetDepth_6, out ret);
            /*10592*/
            var ret_result = ret.I32;
            /*10593*/
            return ret_result;
            /*10594*/
        }
        /// <summary>
        /// Returns the local name. See
        /// http://www.w3.org/TR/REC-xml-names/#NT-LocalPart for additional details.
        /// /*cef()*/
        /// </summary>
        /*10595*/


        // gen! CefString GetLocalName()
        /*10596*/

        public string GetLocalName()/*10597*/
        {
            JsValue ret;
            /*10598*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetLocalName_7, out ret);
            /*10599*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10600*/
            return ret_result;
            /*10601*/
        }
        /// <summary>
        /// Returns the namespace prefix. See http://www.w3.org/TR/REC-xml-names/ for
        /// additional details.
        /// /*cef()*/
        /// </summary>
        /*10602*/


        // gen! CefString GetPrefix()
        /*10603*/

        public string GetPrefix()/*10604*/
        {
            JsValue ret;
            /*10605*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetPrefix_8, out ret);
            /*10606*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10607*/
            return ret_result;
            /*10608*/
        }
        /// <summary>
        /// Returns the qualified name, equal to (Prefix:)LocalName. See
        /// http://www.w3.org/TR/REC-xml-names/#ns-qualnames for additional details.
        /// /*cef()*/
        /// </summary>
        /*10609*/


        // gen! CefString GetQualifiedName()
        /*10610*/

        public string GetQualifiedName()/*10611*/
        {
            JsValue ret;
            /*10612*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetQualifiedName_9, out ret);
            /*10613*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10614*/
            return ret_result;
            /*10615*/
        }
        /// <summary>
        /// Returns the URI defining the namespace associated with the node. See
        /// http://www.w3.org/TR/REC-xml-names/ for additional details.
        /// /*cef()*/
        /// </summary>
        /*10616*/


        // gen! CefString GetNamespaceURI()
        /*10617*/

        public string GetNamespaceURI()/*10618*/
        {
            JsValue ret;
            /*10619*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetNamespaceURI_10, out ret);
            /*10620*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10621*/
            return ret_result;
            /*10622*/
        }
        /// <summary>
        /// Returns the base URI of the node. See http://www.w3.org/TR/xmlbase/ for
        /// additional details.
        /// /*cef()*/
        /// </summary>
        /*10623*/


        // gen! CefString GetBaseURI()
        /*10624*/

        public string GetBaseURI()/*10625*/
        {
            JsValue ret;
            /*10626*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetBaseURI_11, out ret);
            /*10627*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10628*/
            return ret_result;
            /*10629*/
        }
        /// <summary>
        /// Returns the xml:lang scope within which the node resides. See
        /// http://www.w3.org/TR/REC-xml/#sec-lang-tag for additional details.
        /// /*cef()*/
        /// </summary>
        /*10630*/


        // gen! CefString GetXmlLang()
        /*10631*/

        public string GetXmlLang()/*10632*/
        {
            JsValue ret;
            /*10633*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetXmlLang_12, out ret);
            /*10634*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10635*/
            return ret_result;
            /*10636*/
        }
        /// <summary>
        /// Returns true if the node represents an empty element. <a/> is considered
        /// empty but <a></a> is not.
        /// /*cef()*/
        /// </summary>
        /*10637*/


        // gen! bool IsEmptyElement()
        /*10638*/

        public bool IsEmptyElement()/*10639*/
        {
            JsValue ret;
            /*10640*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_IsEmptyElement_13, out ret);
            /*10641*/
            var ret_result = ret.I32 != 0;
            /*10642*/
            return ret_result;
            /*10643*/
        }
        /// <summary>
        /// Returns true if the node has a text value.
        /// /*cef()*/
        /// </summary>
        /*10644*/


        // gen! bool HasValue()
        /*10645*/

        public bool HasValue()/*10646*/
        {
            JsValue ret;
            /*10647*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasValue_14, out ret);
            /*10648*/
            var ret_result = ret.I32 != 0;
            /*10649*/
            return ret_result;
            /*10650*/
        }
        /// <summary>
        /// Returns the text value.
        /// /*cef()*/
        /// </summary>
        /*10651*/


        // gen! CefString GetValue()
        /*10652*/

        public string GetValue()/*10653*/
        {
            JsValue ret;
            /*10654*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetValue_15, out ret);
            /*10655*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10656*/
            return ret_result;
            /*10657*/
        }
        /// <summary>
        /// Returns true if the node has attributes.
        /// /*cef()*/
        /// </summary>
        /*10658*/


        // gen! bool HasAttributes()
        /*10659*/

        public bool HasAttributes()/*10660*/
        {
            JsValue ret;
            /*10661*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasAttributes_16, out ret);
            /*10662*/
            var ret_result = ret.I32 != 0;
            /*10663*/
            return ret_result;
            /*10664*/
        }
        /// <summary>
        /// Returns the number of attributes.
        /// /*cef()*/
        /// </summary>
        /*10665*/


        // gen! size_t GetAttributeCount()
        /*10666*/

        public uint GetAttributeCount()/*10667*/
        {
            JsValue ret;
            /*10668*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetAttributeCount_17, out ret);
            /*10669*/
            var ret_result = (uint)ret.I32;
            /*10670*/
            return ret_result;
            /*10671*/
        }
        /*10672*/


        // gen! CefString GetAttribute(int index)
        /*10673*/

        public string GetAttribute(int /*10674*/
        index
        )/*10675*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*10676*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_GetAttribute_18, out ret, ref v1);
            /*10677*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10678*/
            return ret_result;
            /*10679*/
        }
        /*10680*/


        // gen! CefString GetAttribute(const CefString& qualifiedName)
        /*10681*/

        public string GetAttribute(string /*10682*/
        qualifiedName
        )/*10683*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(qualifiedName);
            /*10684*/
            ;
            /*10685*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_GetAttribute_19, out ret, ref v1);
            /*10686*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10687*/
            ;
            /*10688*/
            return ret_result;
            /*10689*/
        }
        /*10690*/


        // gen! CefString GetAttribute(const CefString& localName,const CefString& namespaceURI)
        /*10691*/

        public string GetAttribute(string /*10692*/
        localName
        , string /*10693*/
        namespaceURI
        )/*10694*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(localName);
            /*10695*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(namespaceURI);
            /*10696*/
            ;
            /*10697*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefXmlReader_GetAttribute_20, out ret, ref v1, ref v2);
            /*10698*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10699*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*10700*/
            ;
            /*10701*/
            return ret_result;
            /*10702*/
        }
        /// <summary>
        /// Returns an XML representation of the current node's children.
        /// /*cef()*/
        /// </summary>
        /*10703*/


        // gen! CefString GetInnerXml()
        /*10704*/

        public string GetInnerXml()/*10705*/
        {
            JsValue ret;
            /*10706*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetInnerXml_21, out ret);
            /*10707*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10708*/
            return ret_result;
            /*10709*/
        }
        /// <summary>
        /// Returns an XML representation of the current node including its children.
        /// /*cef()*/
        /// </summary>
        /*10710*/


        // gen! CefString GetOuterXml()
        /*10711*/

        public string GetOuterXml()/*10712*/
        {
            JsValue ret;
            /*10713*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetOuterXml_22, out ret);
            /*10714*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10715*/
            return ret_result;
            /*10716*/
        }
        /// <summary>
        /// Returns the line number for the current node.
        /// /*cef()*/
        /// </summary>
        /*10717*/


        // gen! int GetLineNumber()
        /*10718*/

        public int GetLineNumber()/*10719*/
        {
            JsValue ret;
            /*10720*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetLineNumber_23, out ret);
            /*10721*/
            var ret_result = ret.I32;
            /*10722*/
            return ret_result;
            /*10723*/
        }
        /*10724*/


        // gen! bool MoveToAttribute(int index)
        /*10725*/

        public bool MoveToAttribute(int /*10726*/
        index
        )/*10727*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            /*10728*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_MoveToAttribute_24, out ret, ref v1);
            /*10729*/
            var ret_result = ret.I32 != 0;
            /*10730*/
            return ret_result;
            /*10731*/
        }
        /*10732*/


        // gen! bool MoveToAttribute(const CefString& qualifiedName)
        /*10733*/

        public bool MoveToAttribute(string /*10734*/
        qualifiedName
        )/*10735*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(qualifiedName);
            /*10736*/
            ;
            /*10737*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_MoveToAttribute_25, out ret, ref v1);
            /*10738*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10739*/
            ;
            /*10740*/
            return ret_result;
            /*10741*/
        }
        /*10742*/


        // gen! bool MoveToAttribute(const CefString& localName,const CefString& namespaceURI)
        /*10743*/

        public bool MoveToAttribute(string /*10744*/
        localName
        , string /*10745*/
        namespaceURI
        )/*10746*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(localName);
            /*10747*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(namespaceURI);
            /*10748*/
            ;
            /*10749*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefXmlReader_MoveToAttribute_26, out ret, ref v1, ref v2);
            /*10750*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10751*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*10752*/
            ;
            /*10753*/
            return ret_result;
            /*10754*/
        }
        /// <summary>
        /// Moves the cursor to the first attribute in the current element. Returns
        /// true if the cursor position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10755*/


        // gen! bool MoveToFirstAttribute()
        /*10756*/

        public bool MoveToFirstAttribute()/*10757*/
        {
            JsValue ret;
            /*10758*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToFirstAttribute_27, out ret);
            /*10759*/
            var ret_result = ret.I32 != 0;
            /*10760*/
            return ret_result;
            /*10761*/
        }
        /// <summary>
        /// Moves the cursor to the next attribute in the current element. Returns
        /// true if the cursor position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10762*/


        // gen! bool MoveToNextAttribute()
        /*10763*/

        public bool MoveToNextAttribute()/*10764*/
        {
            JsValue ret;
            /*10765*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToNextAttribute_28, out ret);
            /*10766*/
            var ret_result = ret.I32 != 0;
            /*10767*/
            return ret_result;
            /*10768*/
        }
        /// <summary>
        /// Moves the cursor back to the carrying element. Returns true if the cursor
        /// position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10769*/


        // gen! bool MoveToCarryingElement()
        /*10770*/

        public bool MoveToCarryingElement()/*10771*/
        {
            JsValue ret;
            /*10772*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToCarryingElement_29, out ret);
            /*10773*/
            var ret_result = ret.I32 != 0;
            /*10774*/
            return ret_result;
            /*10775*/
        }
        /*10776*/
    }


    // [virtual] class CefZipReader
    /// <summary>
    /// Class that supports the reading of zip archives via the zlib unzip API.
    /// The methods of this class should only be called on the thread that creates
    /// the object.
    /// /*(source=library)*/
    /// </summary>
    /*10845*/
    public struct CefZipReader
    {
        /*10846*/
        const int _typeNAME = 55;
        /*10847*/
        const int CefZipReader_Release_0 = (_typeNAME << 16) | 0;
        /*10848*/
        const int CefZipReader_MoveToFirstFile_1 = (_typeNAME << 16) | 1;
        /*10849*/
        const int CefZipReader_MoveToNextFile_2 = (_typeNAME << 16) | 2;
        /*10850*/
        const int CefZipReader_MoveToFile_3 = (_typeNAME << 16) | 3;
        /*10851*/
        const int CefZipReader_Close_4 = (_typeNAME << 16) | 4;
        /*10852*/
        const int CefZipReader_GetFileName_5 = (_typeNAME << 16) | 5;
        /*10853*/
        const int CefZipReader_GetFileSize_6 = (_typeNAME << 16) | 6;
        /*10854*/
        const int CefZipReader_GetFileLastModified_7 = (_typeNAME << 16) | 7;
        /*10855*/
        const int CefZipReader_OpenFile_8 = (_typeNAME << 16) | 8;
        /*10856*/
        const int CefZipReader_CloseFile_9 = (_typeNAME << 16) | 9;
        /*10857*/
        const int CefZipReader_ReadFile_10 = (_typeNAME << 16) | 10;
        /*10858*/
        const int CefZipReader_Tell_11 = (_typeNAME << 16) | 11;
        /*10859*/
        const int CefZipReader_Eof_12 = (_typeNAME << 16) | 12;
        /*10860*/
        internal readonly IntPtr nativePtr;
        /*10861*/
        internal CefZipReader(IntPtr nativePtr)
        {
            /*10862*/
            this.nativePtr = nativePtr;
            /*10863*/
        }
        /*10864*/
        public void Release()
        {
            /*10865*/
            JsValue ret;
            /*10866*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Release_0, out ret);
            /*10867*/
        }
        /// <summary>
        /// CefZipReader methods.
        /// </summary>
        /*10868*/


        // gen! bool MoveToFirstFile()
        /*10869*/

        public bool MoveToFirstFile()/*10870*/
        {
            JsValue ret;
            /*10871*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_MoveToFirstFile_1, out ret);
            /*10872*/
            var ret_result = ret.I32 != 0;
            /*10873*/
            return ret_result;
            /*10874*/
        }
        /// <summary>
        /// Moves the cursor to the next file in the archive. Returns true if the
        /// cursor position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10875*/


        // gen! bool MoveToNextFile()
        /*10876*/

        public bool MoveToNextFile()/*10877*/
        {
            JsValue ret;
            /*10878*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_MoveToNextFile_2, out ret);
            /*10879*/
            var ret_result = ret.I32 != 0;
            /*10880*/
            return ret_result;
            /*10881*/
        }
        /// <summary>
        /// Moves the cursor to the specified file in the archive. If |caseSensitive|
        /// is true then the search will be case sensitive. Returns true if the cursor
        /// position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10882*/


        // gen! bool MoveToFile(const CefString& fileName,bool caseSensitive)
        /*10883*/

        public bool MoveToFile(string /*10884*/
        fileName
        , bool /*10885*/
        caseSensitive
        )/*10886*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(fileName);
            /*10887*/
            ;
            /*10888*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefZipReader_MoveToFile_3, out ret, ref v1, ref v2);
            /*10889*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10890*/
            ;
            /*10891*/
            return ret_result;
            /*10892*/
        }
        /// <summary>
        /// Closes the archive. This should be called directly to ensure that cleanup
        /// occurs on the correct thread.
        /// /*cef()*/
        /// </summary>
        /*10893*/


        // gen! bool Close()
        /*10894*/

        public bool Close()/*10895*/
        {
            JsValue ret;
            /*10896*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Close_4, out ret);
            /*10897*/
            var ret_result = ret.I32 != 0;
            /*10898*/
            return ret_result;
            /*10899*/
        }
        /// <summary>
        /// The below methods act on the file at the current cursor position.
        /// Returns the name of the file.
        /// /*cef()*/
        /// </summary>
        /*10900*/


        // gen! CefString GetFileName()
        /*10901*/

        public string GetFileName()/*10902*/
        {
            JsValue ret;
            /*10903*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileName_5, out ret);
            /*10904*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10905*/
            return ret_result;
            /*10906*/
        }
        /// <summary>
        /// Returns the uncompressed size of the file.
        /// /*cef()*/
        /// </summary>
        /*10907*/


        // gen! int64 GetFileSize()
        /*10908*/

        public long GetFileSize()/*10909*/
        {
            JsValue ret;
            /*10910*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileSize_6, out ret);
            /*10911*/
            var ret_result = ret.I64;
            /*10912*/
            return ret_result;
            /*10913*/
        }
        /// <summary>
        /// Returns the last modified timestamp for the file.
        /// /*cef()*/
        /// </summary>
        /*10914*/


        // gen! CefTime GetFileLastModified()
        /*10915*/

        public CefTime GetFileLastModified()/*10916*/
        {
            JsValue ret;
            /*10917*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileLastModified_7, out ret);
            /*10918*/
            var ret_result = new CefTime(ret.Ptr);

            /*10919*/
            return ret_result;
            /*10920*/
        }
        /// <summary>
        /// Opens the file for reading of uncompressed data. A read password may
        /// optionally be specified.
        /// /*cef(optional_param=password)*/
        /// </summary>
        /*10921*/


        // gen! bool OpenFile(const CefString& password)
        /*10922*/

        public bool OpenFile(string /*10923*/
        password
        )/*10924*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(password);
            /*10925*/
            ;
            /*10926*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefZipReader_OpenFile_8, out ret, ref v1);
            /*10927*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10928*/
            ;
            /*10929*/
            return ret_result;
            /*10930*/
        }
        /// <summary>
        /// Closes the file.
        /// /*cef()*/
        /// </summary>
        /*10931*/


        // gen! bool CloseFile()
        /*10932*/

        public bool CloseFile()/*10933*/
        {
            JsValue ret;
            /*10934*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_CloseFile_9, out ret);
            /*10935*/
            var ret_result = ret.I32 != 0;
            /*10936*/
            return ret_result;
            /*10937*/
        }
        /// <summary>
        /// Read uncompressed file contents into the specified buffer. Returns < 0 if
        /// an error occurred, 0 if at the end of file, or the number of bytes read.
        /// /*cef()*/
        /// </summary>
        /*10938*/


        // gen! int ReadFile(void* buffer,size_t bufferSize)
        /*10939*/

        public int ReadFile(IntPtr /*10940*/
        buffer
        , uint /*10941*/
        bufferSize
        )/*10942*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            /*10943*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefZipReader_ReadFile_10, out ret, ref v1, ref v2);
            /*10944*/
            var ret_result = ret.I32;
            /*10945*/
            return ret_result;
            /*10946*/
        }
        /// <summary>
        /// Returns the current offset in the uncompressed file contents.
        /// /*cef()*/
        /// </summary>
        /*10947*/


        // gen! int64 Tell()
        /*10948*/

        public long Tell()/*10949*/
        {
            JsValue ret;
            /*10950*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Tell_11, out ret);
            /*10951*/
            var ret_result = ret.I64;
            /*10952*/
            return ret_result;
            /*10953*/
        }
        /// <summary>
        /// Returns true if at end of the file contents.
        /// /*cef()*/
        /// </summary>
        /*10954*/


        // gen! bool Eof()
        /*10955*/

        public bool Eof()/*10956*/
        {
            JsValue ret;
            /*10957*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Eof_12, out ret);
            /*10958*/
            var ret_result = ret.I32 != 0;
            /*10959*/
            return ret_result;
            /*10960*/
        }
        /*10961*/
    }

}
