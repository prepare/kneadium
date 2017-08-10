using System;
using System.Collections.Generic;
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
            v1.Ptr = that.nativePtr/*1002*/
            ;
            /*1003*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_IsSame_11, out ret, ref v1);
            /*1004*/
            var ret_result = ret.I32 != 0;
            /*1005*/
            return ret_result;
            /*1006*/
        }

        // gen! bool IsPopup()
        /// <summary>
        /// Returns true if the window is a popup window.
        /// /*cef()*/
        /// </summary>
        /*1007*/

        public bool IsPopup()/*1008*/
        {
            JsValue ret;
            /*1009*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_IsPopup_12, out ret);
            /*1010*/
            var ret_result = ret.I32 != 0;
            /*1011*/
            return ret_result;
            /*1012*/
        }

        // gen! bool HasDocument()
        /// <summary>
        /// Returns true if a document has been loaded in the browser.
        /// /*cef()*/
        /// </summary>
        /*1013*/

        public bool HasDocument()/*1014*/
        {
            JsValue ret;
            /*1015*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_HasDocument_13, out ret);
            /*1016*/
            var ret_result = ret.I32 != 0;
            /*1017*/
            return ret_result;
            /*1018*/
        }

        // gen! CefRefPtr<CefFrame> GetMainFrame()
        /// <summary>
        /// Returns the main (top-level) frame for the browser window.
        /// /*cef()*/
        /// </summary>
        /*1019*/

        public CefFrame GetMainFrame()/*1020*/
        {
            JsValue ret;
            /*1021*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetMainFrame_14, out ret);
            /*1022*/
            var ret_result = new CefFrame(ret.Ptr);
            /*1023*/
            return ret_result;
            /*1024*/
        }

        // gen! CefRefPtr<CefFrame> GetFocusedFrame()
        /// <summary>
        /// Returns the focused frame for the browser window.
        /// /*cef()*/
        /// </summary>
        /*1025*/

        public CefFrame GetFocusedFrame()/*1026*/
        {
            JsValue ret;
            /*1027*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetFocusedFrame_15, out ret);
            /*1028*/
            var ret_result = new CefFrame(ret.Ptr);
            /*1029*/
            return ret_result;
            /*1030*/
        }

        // gen! CefRefPtr<CefFrame> GetFrame(int64 identifier)
        /*1031*/

        public CefFrame GetFrame(long /*1032*/
        identifier
        )/*1033*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I64 = identifier/*1034*/
            ;
            /*1035*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrame_16, out ret, ref v1);
            /*1036*/
            var ret_result = new CefFrame(ret.Ptr);
            /*1037*/
            return ret_result;
            /*1038*/
        }

        // gen! CefRefPtr<CefFrame> GetFrame(const CefString& name)
        /*1039*/

        public CefFrame GetFrame(string /*1040*/
        name
        )/*1041*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*1042*/
            ;
            /*1043*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrame_17, out ret, ref v1);
            /*1044*/
            var ret_result = new CefFrame(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1045*/
            ;
            /*1046*/
            return ret_result;
            /*1047*/
        }

        // gen! size_t GetFrameCount()
        /// <summary>
        /// Returns the number of frames that currently exist.
        /// /*cef()*/
        /// </summary>
        /*1048*/

        public uint GetFrameCount()/*1049*/
        {
            JsValue ret;
            /*1050*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowser_GetFrameCount_18, out ret);
            /*1051*/
            var ret_result = (uint)ret.I32;
            /*1052*/
            return ret_result;
            /*1053*/
        }

        // gen! void GetFrameIdentifiers(std::vector<int64>& identifiers)
        /// <summary>
        /// Returns the identifiers of all existing frames.
        /// /*cef(count_func=identifiers:GetFrameCount)*/
        /// </summary>
        /*1054*/

        public void GetFrameIdentifiers(List<long> /*1055*/
        identifiers
        )/*1056*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(1)/*1057*/
            ;
            /*1058*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrameIdentifiers_19, out ret, ref v1);
            /*1059*/

            Cef3Binder.CopyStdInt64ListAndDestroyNativeSide(v1.Ptr, identifiers)/*1060*/
            ;
            /*1061*/
        }

        // gen! void GetFrameNames(std::vector<CefString>& names)
        /// <summary>
        /// Returns the names of all existing frames.
        /// /*cef()*/
        /// </summary>
        /*1062*/

        public void GetFrameNames(List<string> /*1063*/
        names
        )/*1064*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2)/*1065*/
            ;
            /*1066*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowser_GetFrameNames_20, out ret, ref v1);
            /*1067*/

            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, names)/*1068*/
            ;
            /*1069*/
        }

        // gen! bool SendProcessMessage(CefProcessId target_process,CefRefPtr<CefProcessMessage> message)
        /// <summary>
        /// Send a message to the specified |target_process|. Returns true if the
        /// message was sent successfully.
        /// /*cef()*/
        /// </summary>
        /*1070*/

        public bool SendProcessMessage(cef_process_id_t /*1071*/
        target_process
        , CefProcessMessage /*1072*/
        message
        )/*1073*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)target_process/*1074*/
            ;
            v2.Ptr = message.nativePtr/*1075*/
            ;
            /*1076*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowser_SendProcessMessage_21, out ret, ref v1, ref v2);
            /*1077*/
            var ret_result = ret.I32 != 0;
            /*1078*/
            return ret_result;
            /*1079*/
        }
        /*1080*/
    }


    // [virtual] class CefNavigationEntryVisitor
    /// <summary>
    /// Callback interface for CefBrowserHost::GetNavigationEntries. The methods of
    /// this class will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    /*1089*/
    public struct CefNavigationEntryVisitor
    {
        /*1090*/
        const int _typeNAME = 3;
        /*1091*/
        const int CefNavigationEntryVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*1092*/
        internal readonly IntPtr nativePtr;
        /*1093*/
        internal CefNavigationEntryVisitor(IntPtr nativePtr)
        {
            /*1094*/
            this.nativePtr = nativePtr;
            /*1095*/
        }
        /*1096*/
        public void Release()
        {
            /*1097*/
            JsValue ret;
            /*1098*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntryVisitor_Release_0, out ret);
            /*1099*/
        }
        /*1100*/
    }


    // [virtual] class CefBrowserHost
    /// <summary>
    /// Class used to represent the browser process aspects of a browser window. The
    /// methods of this class can only be called in the browser process. They may be
    /// called on any thread in that process unless otherwise indicated in the
    /// comments.
    /// /*(source=library)*/
    /// </summary>
    /*1369*/
    public struct CefBrowserHost
    {
        /*1370*/
        const int _typeNAME = 4;
        /*1371*/
        const int CefBrowserHost_Release_0 = (_typeNAME << 16) | 0;
        /*1372*/
        const int CefBrowserHost_GetBrowser_1 = (_typeNAME << 16) | 1;
        /*1373*/
        const int CefBrowserHost_CloseBrowser_2 = (_typeNAME << 16) | 2;
        /*1374*/
        const int CefBrowserHost_TryCloseBrowser_3 = (_typeNAME << 16) | 3;
        /*1375*/
        const int CefBrowserHost_SetFocus_4 = (_typeNAME << 16) | 4;
        /*1376*/
        const int CefBrowserHost_GetWindowHandle_5 = (_typeNAME << 16) | 5;
        /*1377*/
        const int CefBrowserHost_GetOpenerWindowHandle_6 = (_typeNAME << 16) | 6;
        /*1378*/
        const int CefBrowserHost_HasView_7 = (_typeNAME << 16) | 7;
        /*1379*/
        const int CefBrowserHost_GetClient_8 = (_typeNAME << 16) | 8;
        /*1380*/
        const int CefBrowserHost_GetRequestContext_9 = (_typeNAME << 16) | 9;
        /*1381*/
        const int CefBrowserHost_GetZoomLevel_10 = (_typeNAME << 16) | 10;
        /*1382*/
        const int CefBrowserHost_SetZoomLevel_11 = (_typeNAME << 16) | 11;
        /*1383*/
        const int CefBrowserHost_RunFileDialog_12 = (_typeNAME << 16) | 12;
        /*1384*/
        const int CefBrowserHost_StartDownload_13 = (_typeNAME << 16) | 13;
        /*1385*/
        const int CefBrowserHost_DownloadImage_14 = (_typeNAME << 16) | 14;
        /*1386*/
        const int CefBrowserHost_Print_15 = (_typeNAME << 16) | 15;
        /*1387*/
        const int CefBrowserHost_PrintToPDF_16 = (_typeNAME << 16) | 16;
        /*1388*/
        const int CefBrowserHost_Find_17 = (_typeNAME << 16) | 17;
        /*1389*/
        const int CefBrowserHost_StopFinding_18 = (_typeNAME << 16) | 18;
        /*1390*/
        const int CefBrowserHost_ShowDevTools_19 = (_typeNAME << 16) | 19;
        /*1391*/
        const int CefBrowserHost_CloseDevTools_20 = (_typeNAME << 16) | 20;
        /*1392*/
        const int CefBrowserHost_HasDevTools_21 = (_typeNAME << 16) | 21;
        /*1393*/
        const int CefBrowserHost_GetNavigationEntries_22 = (_typeNAME << 16) | 22;
        /*1394*/
        const int CefBrowserHost_SetMouseCursorChangeDisabled_23 = (_typeNAME << 16) | 23;
        /*1395*/
        const int CefBrowserHost_IsMouseCursorChangeDisabled_24 = (_typeNAME << 16) | 24;
        /*1396*/
        const int CefBrowserHost_ReplaceMisspelling_25 = (_typeNAME << 16) | 25;
        /*1397*/
        const int CefBrowserHost_AddWordToDictionary_26 = (_typeNAME << 16) | 26;
        /*1398*/
        const int CefBrowserHost_IsWindowRenderingDisabled_27 = (_typeNAME << 16) | 27;
        /*1399*/
        const int CefBrowserHost_WasResized_28 = (_typeNAME << 16) | 28;
        /*1400*/
        const int CefBrowserHost_WasHidden_29 = (_typeNAME << 16) | 29;
        /*1401*/
        const int CefBrowserHost_NotifyScreenInfoChanged_30 = (_typeNAME << 16) | 30;
        /*1402*/
        const int CefBrowserHost_Invalidate_31 = (_typeNAME << 16) | 31;
        /*1403*/
        const int CefBrowserHost_SendKeyEvent_32 = (_typeNAME << 16) | 32;
        /*1404*/
        const int CefBrowserHost_SendMouseClickEvent_33 = (_typeNAME << 16) | 33;
        /*1405*/
        const int CefBrowserHost_SendMouseMoveEvent_34 = (_typeNAME << 16) | 34;
        /*1406*/
        const int CefBrowserHost_SendMouseWheelEvent_35 = (_typeNAME << 16) | 35;
        /*1407*/
        const int CefBrowserHost_SendFocusEvent_36 = (_typeNAME << 16) | 36;
        /*1408*/
        const int CefBrowserHost_SendCaptureLostEvent_37 = (_typeNAME << 16) | 37;
        /*1409*/
        const int CefBrowserHost_NotifyMoveOrResizeStarted_38 = (_typeNAME << 16) | 38;
        /*1410*/
        const int CefBrowserHost_GetWindowlessFrameRate_39 = (_typeNAME << 16) | 39;
        /*1411*/
        const int CefBrowserHost_SetWindowlessFrameRate_40 = (_typeNAME << 16) | 40;
        /*1412*/
        const int CefBrowserHost_ImeSetComposition_41 = (_typeNAME << 16) | 41;
        /*1413*/
        const int CefBrowserHost_ImeCommitText_42 = (_typeNAME << 16) | 42;
        /*1414*/
        const int CefBrowserHost_ImeFinishComposingText_43 = (_typeNAME << 16) | 43;
        /*1415*/
        const int CefBrowserHost_ImeCancelComposition_44 = (_typeNAME << 16) | 44;
        /*1416*/
        const int CefBrowserHost_DragTargetDragEnter_45 = (_typeNAME << 16) | 45;
        /*1417*/
        const int CefBrowserHost_DragTargetDragOver_46 = (_typeNAME << 16) | 46;
        /*1418*/
        const int CefBrowserHost_DragTargetDragLeave_47 = (_typeNAME << 16) | 47;
        /*1419*/
        const int CefBrowserHost_DragTargetDrop_48 = (_typeNAME << 16) | 48;
        /*1420*/
        const int CefBrowserHost_DragSourceEndedAt_49 = (_typeNAME << 16) | 49;
        /*1421*/
        const int CefBrowserHost_DragSourceSystemDragEnded_50 = (_typeNAME << 16) | 50;
        /*1422*/
        const int CefBrowserHost_GetVisibleNavigationEntry_51 = (_typeNAME << 16) | 51;
        /*1423*/
        const int CefBrowserHost_SetAccessibilityState_52 = (_typeNAME << 16) | 52;
        /*1424*/
        internal readonly IntPtr nativePtr;
        /*1425*/
        internal CefBrowserHost(IntPtr nativePtr)
        {
            /*1426*/
            this.nativePtr = nativePtr;
            /*1427*/
        }
        /*1428*/
        public void Release()
        {
            /*1429*/
            JsValue ret;
            /*1430*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_Release_0, out ret);
            /*1431*/
        }

        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /// <summary>
        /// CefBrowserHost methods.
        /// </summary>
        /*1432*/

        public CefBrowser GetBrowser()/*1433*/
        {
            JsValue ret;
            /*1434*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetBrowser_1, out ret);
            /*1435*/
            var ret_result = new CefBrowser(ret.Ptr);
            /*1436*/
            return ret_result;
            /*1437*/
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
        /*1438*/

        public void CloseBrowser(bool /*1439*/
        force_close
        )/*1440*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = force_close ? 1 : 0/*1441*/
            ;
            /*1442*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_CloseBrowser_2, out ret, ref v1);
            /*1443*/

            /*1444*/
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
        /*1445*/

        public bool TryCloseBrowser()/*1446*/
        {
            JsValue ret;
            /*1447*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_TryCloseBrowser_3, out ret);
            /*1448*/
            var ret_result = ret.I32 != 0;
            /*1449*/
            return ret_result;
            /*1450*/
        }

        // gen! void SetFocus(bool focus)
        /// <summary>
        /// Set whether the browser is focused.
        /// /*cef()*/
        /// </summary>
        /*1451*/

        public void SetFocus(bool /*1452*/
        focus
        )/*1453*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = focus ? 1 : 0/*1454*/
            ;
            /*1455*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetFocus_4, out ret, ref v1);
            /*1456*/

            /*1457*/
        }

        // gen! CefWindowHandle GetWindowHandle()
        /// <summary>
        /// Retrieve the window handle for this browser. If this browser is wrapped in
        /// a CefBrowserView this method should be called on the browser process UI
        /// thread and it will return the handle for the top-level native window.
        /// /*cef()*/
        /// </summary>
        /*1458*/

        public IntPtr GetWindowHandle()/*1459*/
        {
            JsValue ret;
            /*1460*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetWindowHandle_5, out ret);
            /*1461*/
            IntPtr ret_result = ret.Ptr;
            /*1462*/
            return ret_result;
            /*1463*/
        }

        // gen! CefWindowHandle GetOpenerWindowHandle()
        /// <summary>
        /// Retrieve the window handle of the browser that opened this browser. Will
        /// return NULL for non-popup windows or if this browser is wrapped in a
        /// CefBrowserView. This method can be used in combination with custom handling
        /// of modal windows.
        /// /*cef()*/
        /// </summary>
        /*1464*/

        public IntPtr GetOpenerWindowHandle()/*1465*/
        {
            JsValue ret;
            /*1466*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetOpenerWindowHandle_6, out ret);
            /*1467*/
            IntPtr ret_result = ret.Ptr;
            /*1468*/
            return ret_result;
            /*1469*/
        }

        // gen! bool HasView()
        /// <summary>
        /// Returns true if this browser is wrapped in a CefBrowserView.
        /// /*cef()*/
        /// </summary>
        /*1470*/

        public bool HasView()/*1471*/
        {
            JsValue ret;
            /*1472*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_HasView_7, out ret);
            /*1473*/
            var ret_result = ret.I32 != 0;
            /*1474*/
            return ret_result;
            /*1475*/
        }

        // gen! CefRefPtr<CefClient> GetClient()
        /// <summary>
        /// Returns the client for this browser.
        /// /*cef()*/
        /// </summary>
        /*1476*/

        public CefClient GetClient()/*1477*/
        {
            JsValue ret;
            /*1478*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetClient_8, out ret);
            /*1479*/
            var ret_result = new CefClient(ret.Ptr);
            /*1480*/
            return ret_result;
            /*1481*/
        }

        // gen! CefRefPtr<CefRequestContext> GetRequestContext()
        /// <summary>
        /// Returns the request context for this browser.
        /// /*cef()*/
        /// </summary>
        /*1482*/

        public CefRequestContext GetRequestContext()/*1483*/
        {
            JsValue ret;
            /*1484*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetRequestContext_9, out ret);
            /*1485*/
            var ret_result = new CefRequestContext(ret.Ptr);
            /*1486*/
            return ret_result;
            /*1487*/
        }

        // gen! double GetZoomLevel()
        /// <summary>
        /// Get the current zoom level. The default zoom level is 0.0. This method can
        /// only be called on the UI thread.
        /// /*cef()*/
        /// </summary>
        /*1488*/

        public double GetZoomLevel()/*1489*/
        {
            JsValue ret;
            /*1490*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetZoomLevel_10, out ret);
            /*1491*/
            var ret_result = ret.Num;
            /*1492*/
            return ret_result;
            /*1493*/
        }

        // gen! void SetZoomLevel(double zoomLevel)
        /// <summary>
        /// Change the zoom level to the specified value. Specify 0.0 to reset the
        /// zoom level. If called on the UI thread the change will be applied
        /// immediately. Otherwise, the change will be applied asynchronously on the
        /// UI thread.
        /// /*cef()*/
        /// </summary>
        /*1494*/

        public void SetZoomLevel(double /*1495*/
        zoomLevel
        )/*1496*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Num = zoomLevel/*1497*/
            ;
            /*1498*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetZoomLevel_11, out ret, ref v1);
            /*1499*/

            /*1500*/
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
        /*1501*/

        public void RunFileDialog(cef_file_dialog_mode_t /*1502*/
        mode
        , string /*1503*/
        title
        , string /*1504*/
        default_file_path
        , List<string> /*1505*/
        accept_filters
        , int /*1506*/
        selected_accept_filter
        , CefRunFileDialogCallback /*1507*/
        callback
        )/*1508*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue v6 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(title);
            /*1509*/
            ;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(default_file_path);
            /*1510*/
            ;
            v1.I32 = (int)mode/*1511*/
            ;
            v4.Ptr = Cef3Binder.CreateStdList(2)/*1512*/
            ;
            v5.I32 = (int)selected_accept_filter/*1513*/
            ;
            v6.Ptr = callback.nativePtr/*1514*/
            ;
            /*1515*/

            Cef3Binder.MyCefMet_Call6(this.nativePtr, CefBrowserHost_RunFileDialog_12, out ret, ref v1, ref v2, ref v3, ref v4, ref v5, ref v6);
            /*1516*/

            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*1517*/
            ;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*1518*/
            ;
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v4.Ptr, accept_filters)/*1519*/
            ;
            /*1520*/
        }

        // gen! void StartDownload(const CefString& url)
        /// <summary>
        /// Download the file at |url| using CefDownloadHandler.
        /// /*cef()*/
        /// </summary>
        /*1521*/

        public void StartDownload(string /*1522*/
        url
        )/*1523*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*1524*/
            ;
            /*1525*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_StartDownload_13, out ret, ref v1);
            /*1526*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1527*/
            ;
            /*1528*/
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
        /*1529*/

        public void DownloadImage(string /*1530*/
        image_url
        , bool /*1531*/
        is_favicon
        , uint /*1532*/
        max_image_size
        , bool /*1533*/
        bypass_cache
        , CefDownloadImageCallback /*1534*/
        callback
        )/*1535*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(image_url);
            /*1536*/
            ;
            v2.I32 = is_favicon ? 1 : 0/*1537*/
            ;
            v3.I32 = (int)max_image_size/*1538*/
            ;
            v4.I32 = bypass_cache ? 1 : 0/*1539*/
            ;
            v5.Ptr = callback.nativePtr/*1540*/
            ;
            /*1541*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefBrowserHost_DownloadImage_14, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*1542*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1543*/
            ;
            /*1544*/
        }

        // gen! void Print()
        /// <summary>
        /// Print the current browser contents.
        /// /*cef()*/
        /// </summary>
        /*1545*/

        public void Print()/*1546*/
        {
            JsValue ret;
            /*1547*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_Print_15, out ret);
            /*1548*/

            /*1549*/
        }

        // gen! void PrintToPDF(const CefString& path,const CefPdfPrintSettings& settings,CefRefPtr<CefPdfPrintCallback> callback)
        /// <summary>
        /// Print the current browser contents to the PDF file specified by |path| and
        /// execute |callback| on completion. The caller is responsible for deleting
        /// |path| when done. For PDF printing to work on Linux you must implement the
        /// CefPrintHandler::GetPdfPaperSize method.
        /// /*cef(optional_param=callback)*/
        /// </summary>
        /*1550*/

        public void PrintToPDF(string /*1551*/
        path
        , CefPdfPrintSettings /*1552*/
        settings
        , CefPdfPrintCallback /*1553*/
        callback
        )/*1554*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(path);
            /*1555*/
            ;
            v2.Ptr = settings.nativePtr/*1556*/
            ;
            v3.Ptr = callback.nativePtr/*1557*/
            ;
            /*1558*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_PrintToPDF_16, out ret, ref v1, ref v2, ref v3);
            /*1559*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1560*/
            ;
            /*1561*/
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
        /*1562*/

        public void Find(int /*1563*/
        identifier
        , string /*1564*/
        searchText
        , bool /*1565*/
        forward
        , bool /*1566*/
        matchCase
        , bool /*1567*/
        findNext
        )/*1568*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(searchText);
            /*1569*/
            ;
            v1.I32 = (int)identifier/*1570*/
            ;
            v3.I32 = forward ? 1 : 0/*1571*/
            ;
            v4.I32 = matchCase ? 1 : 0/*1572*/
            ;
            v5.I32 = findNext ? 1 : 0/*1573*/
            ;
            /*1574*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefBrowserHost_Find_17, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*1575*/

            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*1576*/
            ;
            /*1577*/
        }

        // gen! void StopFinding(bool clearSelection)
        /// <summary>
        /// Cancel all searches that are currently going on.
        /// /*cef()*/
        /// </summary>
        /*1578*/

        public void StopFinding(bool /*1579*/
        clearSelection
        )/*1580*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = clearSelection ? 1 : 0/*1581*/
            ;
            /*1582*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_StopFinding_18, out ret, ref v1);
            /*1583*/

            /*1584*/
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
        /*1585*/

        public void ShowDevTools(CefWindowInfo /*1586*/
        windowInfo
        , CefClient /*1587*/
        client
        , CefBrowserSettings /*1588*/
        settings
        , CefPoint /*1589*/
        inspect_element_at
        )/*1590*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = windowInfo.nativePtr/*1591*/
            ;
            v2.Ptr = client.nativePtr/*1592*/
            ;
            v3.Ptr = settings.nativePtr/*1593*/
            ;
            v4.Ptr = inspect_element_at.nativePtr/*1594*/
            ;
            /*1595*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_ShowDevTools_19, out ret, ref v1, ref v2, ref v3, ref v4);
            /*1596*/

            /*1597*/
        }

        // gen! void CloseDevTools()
        /// <summary>
        /// Explicitly close the associated DevTools browser, if any.
        /// /*cef()*/
        /// </summary>
        /*1598*/

        public void CloseDevTools()/*1599*/
        {
            JsValue ret;
            /*1600*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_CloseDevTools_20, out ret);
            /*1601*/

            /*1602*/
        }

        // gen! bool HasDevTools()
        /// <summary>
        /// Returns true if this browser currently has an associated DevTools browser.
        /// Must be called on the browser process UI thread.
        /// /*cef()*/
        /// </summary>
        /*1603*/

        public bool HasDevTools()/*1604*/
        {
            JsValue ret;
            /*1605*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_HasDevTools_21, out ret);
            /*1606*/
            var ret_result = ret.I32 != 0;
            /*1607*/
            return ret_result;
            /*1608*/
        }

        // gen! void GetNavigationEntries(CefRefPtr<CefNavigationEntryVisitor> visitor,bool current_only)
        /// <summary>
        /// Retrieve a snapshot of current navigation entries as values sent to the
        /// specified visitor. If |current_only| is true only the current navigation
        /// entry will be sent, otherwise all navigation entries will be sent.
        /// /*cef()*/
        /// </summary>
        /*1609*/

        public void GetNavigationEntries(CefNavigationEntryVisitor /*1610*/
        visitor
        , bool /*1611*/
        current_only
        )/*1612*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr/*1613*/
            ;
            v2.I32 = current_only ? 1 : 0/*1614*/
            ;
            /*1615*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_GetNavigationEntries_22, out ret, ref v1, ref v2);
            /*1616*/

            /*1617*/
        }

        // gen! void SetMouseCursorChangeDisabled(bool disabled)
        /// <summary>
        /// Set whether mouse cursor change is disabled.
        /// /*cef()*/
        /// </summary>
        /*1618*/

        public void SetMouseCursorChangeDisabled(bool /*1619*/
        disabled
        )/*1620*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = disabled ? 1 : 0/*1621*/
            ;
            /*1622*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetMouseCursorChangeDisabled_23, out ret, ref v1);
            /*1623*/

            /*1624*/
        }

        // gen! bool IsMouseCursorChangeDisabled()
        /// <summary>
        /// Returns true if mouse cursor change is disabled.
        /// /*cef()*/
        /// </summary>
        /*1625*/

        public bool IsMouseCursorChangeDisabled()/*1626*/
        {
            JsValue ret;
            /*1627*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_IsMouseCursorChangeDisabled_24, out ret);
            /*1628*/
            var ret_result = ret.I32 != 0;
            /*1629*/
            return ret_result;
            /*1630*/
        }

        // gen! void ReplaceMisspelling(const CefString& word)
        /// <summary>
        /// If a misspelled word is currently selected in an editable node calling
        /// this method will replace it with the specified |word|.
        /// /*cef()*/
        /// </summary>
        /*1631*/

        public void ReplaceMisspelling(string /*1632*/
        word
        )/*1633*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(word);
            /*1634*/
            ;
            /*1635*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_ReplaceMisspelling_25, out ret, ref v1);
            /*1636*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1637*/
            ;
            /*1638*/
        }

        // gen! void AddWordToDictionary(const CefString& word)
        /// <summary>
        /// Add the specified |word| to the spelling dictionary.
        /// /*cef()*/
        /// </summary>
        /*1639*/

        public void AddWordToDictionary(string /*1640*/
        word
        )/*1641*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(word);
            /*1642*/
            ;
            /*1643*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_AddWordToDictionary_26, out ret, ref v1);
            /*1644*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1645*/
            ;
            /*1646*/
        }

        // gen! bool IsWindowRenderingDisabled()
        /// <summary>
        /// Returns true if window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1647*/

        public bool IsWindowRenderingDisabled()/*1648*/
        {
            JsValue ret;
            /*1649*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_IsWindowRenderingDisabled_27, out ret);
            /*1650*/
            var ret_result = ret.I32 != 0;
            /*1651*/
            return ret_result;
            /*1652*/
        }

        // gen! void WasResized()
        /// <summary>
        /// Notify the browser that the widget has been resized. The browser will first
        /// call CefRenderHandler::GetViewRect to get the new size and then call
        /// CefRenderHandler::OnPaint asynchronously with the updated regions. This
        /// method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1653*/

        public void WasResized()/*1654*/
        {
            JsValue ret;
            /*1655*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_WasResized_28, out ret);
            /*1656*/

            /*1657*/
        }

        // gen! void WasHidden(bool hidden)
        /// <summary>
        /// Notify the browser that it has been hidden or shown. Layouting and
        /// CefRenderHandler::OnPaint notification will stop when the browser is
        /// hidden. This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1658*/

        public void WasHidden(bool /*1659*/
        hidden
        )/*1660*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = hidden ? 1 : 0/*1661*/
            ;
            /*1662*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_WasHidden_29, out ret, ref v1);
            /*1663*/

            /*1664*/
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
        /*1665*/

        public void NotifyScreenInfoChanged()/*1666*/
        {
            JsValue ret;
            /*1667*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_NotifyScreenInfoChanged_30, out ret);
            /*1668*/

            /*1669*/
        }

        // gen! void Invalidate(PaintElementType type)
        /// <summary>
        /// Invalidate the view. The browser will call CefRenderHandler::OnPaint
        /// asynchronously. This method is only used when window rendering is
        /// disabled.
        /// /*cef()*/
        /// </summary>
        /*1670*/

        public void Invalidate(cef_paint_element_type_t /*1671*/
        type
        )/*1672*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)type/*1673*/
            ;
            /*1674*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_Invalidate_31, out ret, ref v1);
            /*1675*/

            /*1676*/
        }

        // gen! void SendKeyEvent(const CefKeyEvent& event)
        /// <summary>
        /// Send a key event to the browser.
        /// /*cef()*/
        /// </summary>
        /*1677*/

        public void SendKeyEvent(CefKeyEvent /*1678*/
        _event
        )/*1679*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr/*1680*/
            ;
            /*1681*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SendKeyEvent_32, out ret, ref v1);
            /*1682*/

            /*1683*/
        }

        // gen! void SendMouseClickEvent(const CefMouseEvent& event,MouseButtonType type,bool mouseUp,int clickCount)
        /// <summary>
        /// Send a mouse click event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view.
        /// /*cef()*/
        /// </summary>
        /*1684*/

        public void SendMouseClickEvent(CefMouseEvent /*1685*/
        _event
        , cef_mouse_button_type_t /*1686*/
        type
        , bool /*1687*/
        mouseUp
        , int /*1688*/
        clickCount
        )/*1689*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr/*1690*/
            ;
            v2.I32 = (int)type/*1691*/
            ;
            v3.I32 = mouseUp ? 1 : 0/*1692*/
            ;
            v4.I32 = (int)clickCount/*1693*/
            ;
            /*1694*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_SendMouseClickEvent_33, out ret, ref v1, ref v2, ref v3, ref v4);
            /*1695*/

            /*1696*/
        }

        // gen! void SendMouseMoveEvent(const CefMouseEvent& event,bool mouseLeave)
        /// <summary>
        /// Send a mouse move event to the browser. The |x| and |y| coordinates are
        /// relative to the upper-left corner of the view.
        /// /*cef()*/
        /// </summary>
        /*1697*/

        public void SendMouseMoveEvent(CefMouseEvent /*1698*/
        _event
        , bool /*1699*/
        mouseLeave
        )/*1700*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr/*1701*/
            ;
            v2.I32 = mouseLeave ? 1 : 0/*1702*/
            ;
            /*1703*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_SendMouseMoveEvent_34, out ret, ref v1, ref v2);
            /*1704*/

            /*1705*/
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
        /*1706*/

        public void SendMouseWheelEvent(CefMouseEvent /*1707*/
        _event
        , int /*1708*/
        deltaX
        , int /*1709*/
        deltaY
        )/*1710*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr/*1711*/
            ;
            v2.I32 = (int)deltaX/*1712*/
            ;
            v3.I32 = (int)deltaY/*1713*/
            ;
            /*1714*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_SendMouseWheelEvent_35, out ret, ref v1, ref v2, ref v3);
            /*1715*/

            /*1716*/
        }

        // gen! void SendFocusEvent(bool setFocus)
        /// <summary>
        /// Send a focus event to the browser.
        /// /*cef()*/
        /// </summary>
        /*1717*/

        public void SendFocusEvent(bool /*1718*/
        setFocus
        )/*1719*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = setFocus ? 1 : 0/*1720*/
            ;
            /*1721*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SendFocusEvent_36, out ret, ref v1);
            /*1722*/

            /*1723*/
        }

        // gen! void SendCaptureLostEvent()
        /// <summary>
        /// Send a capture lost event to the browser.
        /// /*cef()*/
        /// </summary>
        /*1724*/

        public void SendCaptureLostEvent()/*1725*/
        {
            JsValue ret;
            /*1726*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_SendCaptureLostEvent_37, out ret);
            /*1727*/

            /*1728*/
        }

        // gen! void NotifyMoveOrResizeStarted()
        /// <summary>
        /// Notify the browser that the window hosting it is about to be moved or
        /// resized. This method is only used on Windows and Linux.
        /// /*cef()*/
        /// </summary>
        /*1729*/

        public void NotifyMoveOrResizeStarted()/*1730*/
        {
            JsValue ret;
            /*1731*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_NotifyMoveOrResizeStarted_38, out ret);
            /*1732*/

            /*1733*/
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
        /*1734*/

        public int GetWindowlessFrameRate()/*1735*/
        {
            JsValue ret;
            /*1736*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetWindowlessFrameRate_39, out ret);
            /*1737*/
            var ret_result = ret.I32;
            /*1738*/
            return ret_result;
            /*1739*/
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
        /*1740*/

        public void SetWindowlessFrameRate(int /*1741*/
        frame_rate
        )/*1742*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)frame_rate/*1743*/
            ;
            /*1744*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetWindowlessFrameRate_40, out ret, ref v1);
            /*1745*/

            /*1746*/
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
        /*1747*/

        public void ImeSetComposition(string /*1748*/
        text
        , List<CefCompositionUnderline> /*1749*/
        underlines
        , CefRange /*1750*/
        replacement_range
        , CefRange /*1751*/
        selection_range
        )/*1752*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(text);
            /*1753*/
            ;
            v2.Ptr = Cef3Binder.CreateStdList(3)/*1754*/
            ;
            v3.Ptr = replacement_range.nativePtr/*1755*/
            ;
            v4.Ptr = selection_range.nativePtr/*1756*/
            ;
            /*1757*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefBrowserHost_ImeSetComposition_41, out ret, ref v1, ref v2, ref v3, ref v4);
            /*1758*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1759*/
            ;
            /*1760*/
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
        /*1761*/

        public void ImeCommitText(string /*1762*/
        text
        , CefRange /*1763*/
        replacement_range
        , int /*1764*/
        relative_cursor_pos
        )/*1765*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(text);
            /*1766*/
            ;
            v2.Ptr = replacement_range.nativePtr/*1767*/
            ;
            v3.I32 = (int)relative_cursor_pos/*1768*/
            ;
            /*1769*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_ImeCommitText_42, out ret, ref v1, ref v2, ref v3);
            /*1770*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*1771*/
            ;
            /*1772*/
        }

        // gen! void ImeFinishComposingText(bool keep_selection)
        /// <summary>
        /// Completes the existing composition by applying the current composition node
        /// contents. If |keep_selection| is false the current selection, if any, will
        /// be discarded. See comments on ImeSetComposition for usage.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1773*/

        public void ImeFinishComposingText(bool /*1774*/
        keep_selection
        )/*1775*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = keep_selection ? 1 : 0/*1776*/
            ;
            /*1777*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_ImeFinishComposingText_43, out ret, ref v1);
            /*1778*/

            /*1779*/
        }

        // gen! void ImeCancelComposition()
        /// <summary>
        /// Cancels the existing composition and discards the composition node
        /// contents without applying them. See comments on ImeSetComposition for
        /// usage.
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1780*/

        public void ImeCancelComposition()/*1781*/
        {
            JsValue ret;
            /*1782*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_ImeCancelComposition_44, out ret);
            /*1783*/

            /*1784*/
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
        /*1785*/

        public void DragTargetDragEnter(CefDragData /*1786*/
        drag_data
        , CefMouseEvent /*1787*/
        _event
        , cef_drag_operations_mask_t /*1788*/
        allowed_ops
        )/*1789*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = drag_data.nativePtr/*1790*/
            ;
            v2.Ptr = _event.nativePtr/*1791*/
            ;
            v3.I32 = (int)allowed_ops/*1792*/
            ;
            /*1793*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_DragTargetDragEnter_45, out ret, ref v1, ref v2, ref v3);
            /*1794*/

            /*1795*/
        }

        // gen! void DragTargetDragOver(const CefMouseEvent& event,DragOperationsMask allowed_ops)
        /// <summary>
        /// Call this method each time the mouse is moved across the web view during
        /// a drag operation (after calling DragTargetDragEnter and before calling
        /// DragTargetDragLeave/DragTargetDrop).
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1796*/

        public void DragTargetDragOver(CefMouseEvent /*1797*/
        _event
        , cef_drag_operations_mask_t /*1798*/
        allowed_ops
        )/*1799*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr/*1800*/
            ;
            v2.I32 = (int)allowed_ops/*1801*/
            ;
            /*1802*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefBrowserHost_DragTargetDragOver_46, out ret, ref v1, ref v2);
            /*1803*/

            /*1804*/
        }

        // gen! void DragTargetDragLeave()
        /// <summary>
        /// Call this method when the user drags the mouse out of the web view (after
        /// calling DragTargetDragEnter).
        /// This method is only used when window rendering is disabled.
        /// /*cef()*/
        /// </summary>
        /*1805*/

        public void DragTargetDragLeave()/*1806*/
        {
            JsValue ret;
            /*1807*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_DragTargetDragLeave_47, out ret);
            /*1808*/

            /*1809*/
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
        /*1810*/

        public void DragTargetDrop(CefMouseEvent /*1811*/
        _event
        )/*1812*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = _event.nativePtr/*1813*/
            ;
            /*1814*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_DragTargetDrop_48, out ret, ref v1);
            /*1815*/

            /*1816*/
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
        /*1817*/

        public void DragSourceEndedAt(int /*1818*/
        x
        , int /*1819*/
        y
        , cef_drag_operations_mask_t /*1820*/
        op
        )/*1821*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)x/*1822*/
            ;
            v2.I32 = (int)y/*1823*/
            ;
            v3.I32 = (int)op/*1824*/
            ;
            /*1825*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBrowserHost_DragSourceEndedAt_49, out ret, ref v1, ref v2, ref v3);
            /*1826*/

            /*1827*/
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
        /*1828*/

        public void DragSourceSystemDragEnded()/*1829*/
        {
            JsValue ret;
            /*1830*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_DragSourceSystemDragEnded_50, out ret);
            /*1831*/

            /*1832*/
        }

        // gen! CefRefPtr<CefNavigationEntry> GetVisibleNavigationEntry()
        /// <summary>
        /// Returns the current visible navigation entry for this browser. This method
        /// can only be called on the UI thread.
        /// /*cef()*/
        /// </summary>
        /*1833*/

        public CefNavigationEntry GetVisibleNavigationEntry()/*1834*/
        {
            JsValue ret;
            /*1835*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBrowserHost_GetVisibleNavigationEntry_51, out ret);
            /*1836*/
            var ret_result = new CefNavigationEntry(ret.Ptr);
            /*1837*/
            return ret_result;
            /*1838*/
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
        /*1839*/

        public void SetAccessibilityState(cef_state_t /*1840*/
        accessibility_state
        )/*1841*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)accessibility_state/*1842*/
            ;
            /*1843*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBrowserHost_SetAccessibilityState_52, out ret, ref v1);
            /*1844*/

            /*1845*/
        }
        /*1846*/
    }


    // [virtual] class CefClient
    /// <summary>
    /// Implement this interface to provide handler implementations.
    /// /*(source=client,no_debugct_check)*/
    /// </summary>
    /*1855*/
    public struct CefClient
    {
        /*1856*/
        const int _typeNAME = 5;
        /*1857*/
        const int CefClient_Release_0 = (_typeNAME << 16) | 0;
        /*1858*/
        internal readonly IntPtr nativePtr;
        /*1859*/
        internal CefClient(IntPtr nativePtr)
        {
            /*1860*/
            this.nativePtr = nativePtr;
            /*1861*/
        }
        /*1862*/
        public void Release()
        {
            /*1863*/
            JsValue ret;
            /*1864*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefClient_Release_0, out ret);
            /*1865*/
        }
        /*1866*/
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
    /*1975*/
    public struct CefCommandLine
    {
        /*1976*/
        const int _typeNAME = 6;
        /*1977*/
        const int CefCommandLine_Release_0 = (_typeNAME << 16) | 0;
        /*1978*/
        const int CefCommandLine_IsValid_1 = (_typeNAME << 16) | 1;
        /*1979*/
        const int CefCommandLine_IsReadOnly_2 = (_typeNAME << 16) | 2;
        /*1980*/
        const int CefCommandLine_Copy_3 = (_typeNAME << 16) | 3;
        /*1981*/
        const int CefCommandLine_InitFromArgv_4 = (_typeNAME << 16) | 4;
        /*1982*/
        const int CefCommandLine_InitFromString_5 = (_typeNAME << 16) | 5;
        /*1983*/
        const int CefCommandLine_Reset_6 = (_typeNAME << 16) | 6;
        /*1984*/
        const int CefCommandLine_GetArgv_7 = (_typeNAME << 16) | 7;
        /*1985*/
        const int CefCommandLine_GetCommandLineString_8 = (_typeNAME << 16) | 8;
        /*1986*/
        const int CefCommandLine_GetProgram_9 = (_typeNAME << 16) | 9;
        /*1987*/
        const int CefCommandLine_SetProgram_10 = (_typeNAME << 16) | 10;
        /*1988*/
        const int CefCommandLine_HasSwitches_11 = (_typeNAME << 16) | 11;
        /*1989*/
        const int CefCommandLine_HasSwitch_12 = (_typeNAME << 16) | 12;
        /*1990*/
        const int CefCommandLine_GetSwitchValue_13 = (_typeNAME << 16) | 13;
        /*1991*/
        const int CefCommandLine_GetSwitches_14 = (_typeNAME << 16) | 14;
        /*1992*/
        const int CefCommandLine_AppendSwitch_15 = (_typeNAME << 16) | 15;
        /*1993*/
        const int CefCommandLine_AppendSwitchWithValue_16 = (_typeNAME << 16) | 16;
        /*1994*/
        const int CefCommandLine_HasArguments_17 = (_typeNAME << 16) | 17;
        /*1995*/
        const int CefCommandLine_GetArguments_18 = (_typeNAME << 16) | 18;
        /*1996*/
        const int CefCommandLine_AppendArgument_19 = (_typeNAME << 16) | 19;
        /*1997*/
        const int CefCommandLine_PrependWrapper_20 = (_typeNAME << 16) | 20;
        /*1998*/
        internal readonly IntPtr nativePtr;
        /*1999*/
        internal CefCommandLine(IntPtr nativePtr)
        {
            /*2000*/
            this.nativePtr = nativePtr;
            /*2001*/
        }
        /*2002*/
        public void Release()
        {
            /*2003*/
            JsValue ret;
            /*2004*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Release_0, out ret);
            /*2005*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefCommandLine methods.
        /// </summary>
        /*2006*/

        public bool IsValid()/*2007*/
        {
            JsValue ret;
            /*2008*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_IsValid_1, out ret);
            /*2009*/
            var ret_result = ret.I32 != 0;
            /*2010*/
            return ret_result;
            /*2011*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*2012*/

        public bool IsReadOnly()/*2013*/
        {
            JsValue ret;
            /*2014*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_IsReadOnly_2, out ret);
            /*2015*/
            var ret_result = ret.I32 != 0;
            /*2016*/
            return ret_result;
            /*2017*/
        }

        // gen! CefRefPtr<CefCommandLine> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>
        /*2018*/

        public CefCommandLine Copy()/*2019*/
        {
            JsValue ret;
            /*2020*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Copy_3, out ret);
            /*2021*/
            var ret_result = new CefCommandLine(ret.Ptr);
            /*2022*/
            return ret_result;
            /*2023*/
        }

        // gen! void InitFromArgv(int argc,const char* const* argv)
        /// <summary>
        /// Initialize the command line with the specified |argc| and |argv| values.
        /// The first argument must be the name of the program. This method is only
        /// supported on non-Windows platforms.
        /// /*cef()*/
        /// </summary>
        /*2024*/

        public void InitFromArgv(int /*2025*/
        argc
        , IntPtr /*2026*/
        argv
        )/*2027*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)argc/*2028*/
            ;
            v2.Ptr = argv/*2029*/
            ;
            /*2030*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCommandLine_InitFromArgv_4, out ret, ref v1, ref v2);
            /*2031*/

            /*2032*/
        }

        // gen! void InitFromString(const CefString& command_line)
        /// <summary>
        /// Initialize the command line with the string returned by calling
        /// GetCommandLineW(). This method is only supported on Windows.
        /// /*cef()*/
        /// </summary>
        /*2033*/

        public void InitFromString(string /*2034*/
        command_line
        )/*2035*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(command_line);
            /*2036*/
            ;
            /*2037*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_InitFromString_5, out ret, ref v1);
            /*2038*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2039*/
            ;
            /*2040*/
        }

        // gen! void Reset()
        /// <summary>
        /// Reset the command-line switches and arguments but leave the program
        /// component unchanged.
        /// /*cef()*/
        /// </summary>
        /*2041*/

        public void Reset()/*2042*/
        {
            JsValue ret;
            /*2043*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_Reset_6, out ret);
            /*2044*/

            /*2045*/
        }

        // gen! void GetArgv(std::vector<CefString>& argv)
        /// <summary>
        /// Retrieve the original command line string as a vector of strings.
        /// The argv array: { program, [(--|-|/)switch[=value]]*, [--], [argument]* }
        /// /*cef()*/
        /// </summary>
        /*2046*/

        public void GetArgv(List<string> /*2047*/
        argv
        )/*2048*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2)/*2049*/
            ;
            /*2050*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetArgv_7, out ret, ref v1);
            /*2051*/

            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, argv)/*2052*/
            ;
            /*2053*/
        }

        // gen! CefString GetCommandLineString()
        /// <summary>
        /// Constructs and returns the represented command line string. Use this method
        /// cautiously because quoting behavior is unclear.
        /// /*cef()*/
        /// </summary>
        /*2054*/

        public string GetCommandLineString()/*2055*/
        {
            JsValue ret;
            /*2056*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_GetCommandLineString_8, out ret);
            /*2057*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2058*/
            return ret_result;
            /*2059*/
        }

        // gen! CefString GetProgram()
        /// <summary>
        /// Get the program part of the command line string (the first item).
        /// /*cef()*/
        /// </summary>
        /*2060*/

        public string GetProgram()/*2061*/
        {
            JsValue ret;
            /*2062*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_GetProgram_9, out ret);
            /*2063*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2064*/
            return ret_result;
            /*2065*/
        }

        // gen! void SetProgram(const CefString& program)
        /// <summary>
        /// Set the program part of the command line string (the first item).
        /// /*cef()*/
        /// </summary>
        /*2066*/

        public void SetProgram(string /*2067*/
        program
        )/*2068*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(program);
            /*2069*/
            ;
            /*2070*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_SetProgram_10, out ret, ref v1);
            /*2071*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2072*/
            ;
            /*2073*/
        }

        // gen! bool HasSwitches()
        /// <summary>
        /// Returns true if the command line has switches.
        /// /*cef()*/
        /// </summary>
        /*2074*/

        public bool HasSwitches()/*2075*/
        {
            JsValue ret;
            /*2076*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_HasSwitches_11, out ret);
            /*2077*/
            var ret_result = ret.I32 != 0;
            /*2078*/
            return ret_result;
            /*2079*/
        }

        // gen! bool HasSwitch(const CefString& name)
        /// <summary>
        /// Returns true if the command line contains the given switch.
        /// /*cef()*/
        /// </summary>
        /*2080*/

        public bool HasSwitch(string /*2081*/
        name
        )/*2082*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*2083*/
            ;
            /*2084*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_HasSwitch_12, out ret, ref v1);
            /*2085*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2086*/
            ;
            /*2087*/
            return ret_result;
            /*2088*/
        }

        // gen! CefString GetSwitchValue(const CefString& name)
        /// <summary>
        /// Returns the value associated with the given switch. If the switch has no
        /// value or isn't present this method returns the empty string.
        /// /*cef()*/
        /// </summary>
        /*2089*/

        public string GetSwitchValue(string /*2090*/
        name
        )/*2091*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*2092*/
            ;
            /*2093*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetSwitchValue_13, out ret, ref v1);
            /*2094*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2095*/
            ;
            /*2096*/
            return ret_result;
            /*2097*/
        }

        // gen! void GetSwitches(SwitchMap& switches)
        /// <summary>
        /// Returns the map of switch names and values. If a switch has no value an
        /// empty string is returned.
        /// /*cef()*/
        /// </summary>
        /*2098*/

        public void GetSwitches(SwitchMap /*2099*/
        switches
        )/*2100*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = switches.nativePtr/*2101*/
            ;
            /*2102*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetSwitches_14, out ret, ref v1);
            /*2103*/

            /*2104*/
        }

        // gen! void AppendSwitch(const CefString& name)
        /// <summary>
        /// Add a switch to the end of the command line. If the switch has no value
        /// pass an empty value string.
        /// /*cef()*/
        /// </summary>
        /*2105*/

        public void AppendSwitch(string /*2106*/
        name
        )/*2107*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*2108*/
            ;
            /*2109*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_AppendSwitch_15, out ret, ref v1);
            /*2110*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2111*/
            ;
            /*2112*/
        }

        // gen! void AppendSwitchWithValue(const CefString& name,const CefString& value)
        /// <summary>
        /// Add a switch with the specified value to the end of the command line.
        /// /*cef()*/
        /// </summary>
        /*2113*/

        public void AppendSwitchWithValue(string /*2114*/
        name
        , string /*2115*/
        value
        )/*2116*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*2117*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*2118*/
            ;
            /*2119*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCommandLine_AppendSwitchWithValue_16, out ret, ref v1, ref v2);
            /*2120*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2121*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*2122*/
            ;
            /*2123*/
        }

        // gen! bool HasArguments()
        /// <summary>
        /// True if there are remaining command line arguments.
        /// /*cef()*/
        /// </summary>
        /*2124*/

        public bool HasArguments()/*2125*/
        {
            JsValue ret;
            /*2126*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCommandLine_HasArguments_17, out ret);
            /*2127*/
            var ret_result = ret.I32 != 0;
            /*2128*/
            return ret_result;
            /*2129*/
        }

        // gen! void GetArguments(ArgumentList& arguments)
        /// <summary>
        /// Get the remaining command line arguments.
        /// /*cef()*/
        /// </summary>
        /*2130*/

        public void GetArguments(ArgumentList /*2131*/
        arguments
        )/*2132*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = arguments.nativePtr/*2133*/
            ;
            /*2134*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_GetArguments_18, out ret, ref v1);
            /*2135*/

            /*2136*/
        }

        // gen! void AppendArgument(const CefString& argument)
        /// <summary>
        /// Add an argument to the end of the command line.
        /// /*cef()*/
        /// </summary>
        /*2137*/

        public void AppendArgument(string /*2138*/
        argument
        )/*2139*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(argument);
            /*2140*/
            ;
            /*2141*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_AppendArgument_19, out ret, ref v1);
            /*2142*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2143*/
            ;
            /*2144*/
        }

        // gen! void PrependWrapper(const CefString& wrapper)
        /// <summary>
        /// Insert a command before the current command.
        /// Common for debuggers, like "valgrind" or "gdb --args".
        /// /*cef()*/
        /// </summary>
        /*2145*/

        public void PrependWrapper(string /*2146*/
        wrapper
        )/*2147*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(wrapper);
            /*2148*/
            ;
            /*2149*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCommandLine_PrependWrapper_20, out ret, ref v1);
            /*2150*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2151*/
            ;
            /*2152*/
        }
        /*2153*/
    }


    // [virtual] class CefContextMenuParams
    /// <summary>
    /// Provides information about the context menu state. The ethods of this class
    /// can only be accessed on browser process the UI thread.
    /// /*(source=library)*/
    /// </summary>
    /*2267*/
    public struct CefContextMenuParams
    {
        /*2268*/
        const int _typeNAME = 7;
        /*2269*/
        const int CefContextMenuParams_Release_0 = (_typeNAME << 16) | 0;
        /*2270*/
        const int CefContextMenuParams_GetXCoord_1 = (_typeNAME << 16) | 1;
        /*2271*/
        const int CefContextMenuParams_GetYCoord_2 = (_typeNAME << 16) | 2;
        /*2272*/
        const int CefContextMenuParams_GetTypeFlags_3 = (_typeNAME << 16) | 3;
        /*2273*/
        const int CefContextMenuParams_GetLinkUrl_4 = (_typeNAME << 16) | 4;
        /*2274*/
        const int CefContextMenuParams_GetUnfilteredLinkUrl_5 = (_typeNAME << 16) | 5;
        /*2275*/
        const int CefContextMenuParams_GetSourceUrl_6 = (_typeNAME << 16) | 6;
        /*2276*/
        const int CefContextMenuParams_HasImageContents_7 = (_typeNAME << 16) | 7;
        /*2277*/
        const int CefContextMenuParams_GetTitleText_8 = (_typeNAME << 16) | 8;
        /*2278*/
        const int CefContextMenuParams_GetPageUrl_9 = (_typeNAME << 16) | 9;
        /*2279*/
        const int CefContextMenuParams_GetFrameUrl_10 = (_typeNAME << 16) | 10;
        /*2280*/
        const int CefContextMenuParams_GetFrameCharset_11 = (_typeNAME << 16) | 11;
        /*2281*/
        const int CefContextMenuParams_GetMediaType_12 = (_typeNAME << 16) | 12;
        /*2282*/
        const int CefContextMenuParams_GetMediaStateFlags_13 = (_typeNAME << 16) | 13;
        /*2283*/
        const int CefContextMenuParams_GetSelectionText_14 = (_typeNAME << 16) | 14;
        /*2284*/
        const int CefContextMenuParams_GetMisspelledWord_15 = (_typeNAME << 16) | 15;
        /*2285*/
        const int CefContextMenuParams_GetDictionarySuggestions_16 = (_typeNAME << 16) | 16;
        /*2286*/
        const int CefContextMenuParams_IsEditable_17 = (_typeNAME << 16) | 17;
        /*2287*/
        const int CefContextMenuParams_IsSpellCheckEnabled_18 = (_typeNAME << 16) | 18;
        /*2288*/
        const int CefContextMenuParams_GetEditStateFlags_19 = (_typeNAME << 16) | 19;
        /*2289*/
        const int CefContextMenuParams_IsCustomMenu_20 = (_typeNAME << 16) | 20;
        /*2290*/
        const int CefContextMenuParams_IsPepperMenu_21 = (_typeNAME << 16) | 21;
        /*2291*/
        internal readonly IntPtr nativePtr;
        /*2292*/
        internal CefContextMenuParams(IntPtr nativePtr)
        {
            /*2293*/
            this.nativePtr = nativePtr;
            /*2294*/
        }
        /*2295*/
        public void Release()
        {
            /*2296*/
            JsValue ret;
            /*2297*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_Release_0, out ret);
            /*2298*/
        }

        // gen! int GetXCoord()
        /// <summary>
        /// CefContextMenuParams methods.
        /// </summary>
        /*2299*/

        public int GetXCoord()/*2300*/
        {
            JsValue ret;
            /*2301*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetXCoord_1, out ret);
            /*2302*/
            var ret_result = ret.I32;
            /*2303*/
            return ret_result;
            /*2304*/
        }

        // gen! int GetYCoord()
        /// <summary>
        /// Returns the Y coordinate of the mouse where the context menu was invoked.
        /// Coords are relative to the associated RenderView's origin.
        /// /*cef()*/
        /// </summary>
        /*2305*/

        public int GetYCoord()/*2306*/
        {
            JsValue ret;
            /*2307*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetYCoord_2, out ret);
            /*2308*/
            var ret_result = ret.I32;
            /*2309*/
            return ret_result;
            /*2310*/
        }

        // gen! TypeFlags GetTypeFlags()
        /// <summary>
        /// Returns flags representing the type of node that the context menu was
        /// invoked on.
        /// /*cef(default_retval=CM_TYPEFLAG_NONE)*/
        /// </summary>
        /*2311*/

        public cef_context_menu_type_flags_t GetTypeFlags()/*2312*/
        {
            JsValue ret;
            /*2313*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetTypeFlags_3, out ret);
            /*2314*/
            var ret_result = (cef_context_menu_type_flags_t)ret.I32;

            /*2315*/
            return ret_result;
            /*2316*/
        }

        // gen! CefString GetLinkUrl()
        /// <summary>
        /// Returns the URL of the link, if any, that encloses the node that the
        /// context menu was invoked on.
        /// /*cef()*/
        /// </summary>
        /*2317*/

        public string GetLinkUrl()/*2318*/
        {
            JsValue ret;
            /*2319*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetLinkUrl_4, out ret);
            /*2320*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2321*/
            return ret_result;
            /*2322*/
        }

        // gen! CefString GetUnfilteredLinkUrl()
        /// <summary>
        /// Returns the link URL, if any, to be used ONLY for "copy link address". We
        /// don't validate this field in the frontend process.
        /// /*cef()*/
        /// </summary>
        /*2323*/

        public string GetUnfilteredLinkUrl()/*2324*/
        {
            JsValue ret;
            /*2325*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetUnfilteredLinkUrl_5, out ret);
            /*2326*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2327*/
            return ret_result;
            /*2328*/
        }

        // gen! CefString GetSourceUrl()
        /// <summary>
        /// Returns the source URL, if any, for the element that the context menu was
        /// invoked on. Example of elements with source URLs are img, audio, and video.
        /// /*cef()*/
        /// </summary>
        /*2329*/

        public string GetSourceUrl()/*2330*/
        {
            JsValue ret;
            /*2331*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetSourceUrl_6, out ret);
            /*2332*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2333*/
            return ret_result;
            /*2334*/
        }

        // gen! bool HasImageContents()
        /// <summary>
        /// Returns true if the context menu was invoked on an image which has
        /// non-empty contents.
        /// /*cef()*/
        /// </summary>
        /*2335*/

        public bool HasImageContents()/*2336*/
        {
            JsValue ret;
            /*2337*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_HasImageContents_7, out ret);
            /*2338*/
            var ret_result = ret.I32 != 0;
            /*2339*/
            return ret_result;
            /*2340*/
        }

        // gen! CefString GetTitleText()
        /// <summary>
        /// Returns the title text or the alt text if the context menu was invoked on
        /// an image.
        /// /*cef()*/
        /// </summary>
        /*2341*/

        public string GetTitleText()/*2342*/
        {
            JsValue ret;
            /*2343*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetTitleText_8, out ret);
            /*2344*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2345*/
            return ret_result;
            /*2346*/
        }

        // gen! CefString GetPageUrl()
        /// <summary>
        /// Returns the URL of the top level page that the context menu was invoked on.
        /// /*cef()*/
        /// </summary>
        /*2347*/

        public string GetPageUrl()/*2348*/
        {
            JsValue ret;
            /*2349*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetPageUrl_9, out ret);
            /*2350*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2351*/
            return ret_result;
            /*2352*/
        }

        // gen! CefString GetFrameUrl()
        /// <summary>
        /// Returns the URL of the subframe that the context menu was invoked on.
        /// /*cef()*/
        /// </summary>
        /*2353*/

        public string GetFrameUrl()/*2354*/
        {
            JsValue ret;
            /*2355*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetFrameUrl_10, out ret);
            /*2356*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2357*/
            return ret_result;
            /*2358*/
        }

        // gen! CefString GetFrameCharset()
        /// <summary>
        /// Returns the character encoding of the subframe that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>
        /*2359*/

        public string GetFrameCharset()/*2360*/
        {
            JsValue ret;
            /*2361*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetFrameCharset_11, out ret);
            /*2362*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2363*/
            return ret_result;
            /*2364*/
        }

        // gen! MediaType GetMediaType()
        /// <summary>
        /// Returns the type of context node that the context menu was invoked on.
        /// /*cef(default_retval=CM_MEDIATYPE_NONE)*/
        /// </summary>
        /*2365*/

        public cef_context_menu_media_type_t GetMediaType()/*2366*/
        {
            JsValue ret;
            /*2367*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMediaType_12, out ret);
            /*2368*/
            var ret_result = (cef_context_menu_media_type_t)ret.I32;

            /*2369*/
            return ret_result;
            /*2370*/
        }

        // gen! MediaStateFlags GetMediaStateFlags()
        /// <summary>
        /// Returns flags representing the actions supported by the media element, if
        /// any, that the context menu was invoked on.
        /// /*cef(default_retval=CM_MEDIAFLAG_NONE)*/
        /// </summary>
        /*2371*/

        public cef_context_menu_media_state_flags_t GetMediaStateFlags()/*2372*/
        {
            JsValue ret;
            /*2373*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMediaStateFlags_13, out ret);
            /*2374*/
            var ret_result = (cef_context_menu_media_state_flags_t)ret.I32;

            /*2375*/
            return ret_result;
            /*2376*/
        }

        // gen! CefString GetSelectionText()
        /// <summary>
        /// Returns the text of the selection, if any, that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>
        /*2377*/

        public string GetSelectionText()/*2378*/
        {
            JsValue ret;
            /*2379*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetSelectionText_14, out ret);
            /*2380*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2381*/
            return ret_result;
            /*2382*/
        }

        // gen! CefString GetMisspelledWord()
        /// <summary>
        /// Returns the text of the misspelled word, if any, that the context menu was
        /// invoked on.
        /// /*cef()*/
        /// </summary>
        /*2383*/

        public string GetMisspelledWord()/*2384*/
        {
            JsValue ret;
            /*2385*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetMisspelledWord_15, out ret);
            /*2386*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2387*/
            return ret_result;
            /*2388*/
        }

        // gen! bool GetDictionarySuggestions(std::vector<CefString>& suggestions)
        /// <summary>
        /// Returns true if suggestions exist, false otherwise. Fills in |suggestions|
        /// from the spell check service for the misspelled word if there is one.
        /// /*cef()*/
        /// </summary>
        /*2389*/

        public bool GetDictionarySuggestions(List<string> /*2390*/
        suggestions
        )/*2391*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2)/*2392*/
            ;
            /*2393*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefContextMenuParams_GetDictionarySuggestions_16, out ret, ref v1);
            /*2394*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, suggestions)/*2395*/
            ;
            /*2396*/
            return ret_result;
            /*2397*/
        }

        // gen! bool IsEditable()
        /// <summary>
        /// Returns true if the context menu was invoked on an editable node.
        /// /*cef()*/
        /// </summary>
        /*2398*/

        public bool IsEditable()/*2399*/
        {
            JsValue ret;
            /*2400*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsEditable_17, out ret);
            /*2401*/
            var ret_result = ret.I32 != 0;
            /*2402*/
            return ret_result;
            /*2403*/
        }

        // gen! bool IsSpellCheckEnabled()
        /// <summary>
        /// Returns true if the context menu was invoked on an editable node where
        /// spell-check is enabled.
        /// /*cef()*/
        /// </summary>
        /*2404*/

        public bool IsSpellCheckEnabled()/*2405*/
        {
            JsValue ret;
            /*2406*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsSpellCheckEnabled_18, out ret);
            /*2407*/
            var ret_result = ret.I32 != 0;
            /*2408*/
            return ret_result;
            /*2409*/
        }

        // gen! EditStateFlags GetEditStateFlags()
        /// <summary>
        /// Returns flags representing the actions supported by the editable node, if
        /// any, that the context menu was invoked on.
        /// /*cef(default_retval=CM_EDITFLAG_NONE)*/
        /// </summary>
        /*2410*/

        public cef_context_menu_edit_state_flags_t GetEditStateFlags()/*2411*/
        {
            JsValue ret;
            /*2412*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_GetEditStateFlags_19, out ret);
            /*2413*/
            var ret_result = (cef_context_menu_edit_state_flags_t)ret.I32;

            /*2414*/
            return ret_result;
            /*2415*/
        }

        // gen! bool IsCustomMenu()
        /// <summary>
        /// Returns true if the context menu contains items specified by the renderer
        /// process (for example, plugin placeholder or pepper plugin menu items).
        /// /*cef()*/
        /// </summary>
        /*2416*/

        public bool IsCustomMenu()/*2417*/
        {
            JsValue ret;
            /*2418*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsCustomMenu_20, out ret);
            /*2419*/
            var ret_result = ret.I32 != 0;
            /*2420*/
            return ret_result;
            /*2421*/
        }

        // gen! bool IsPepperMenu()
        /// <summary>
        /// Returns true if the context menu was invoked from a pepper plugin.
        /// /*cef()*/
        /// </summary>
        /*2422*/

        public bool IsPepperMenu()/*2423*/
        {
            JsValue ret;
            /*2424*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefContextMenuParams_IsPepperMenu_21, out ret);
            /*2425*/
            var ret_result = ret.I32 != 0;
            /*2426*/
            return ret_result;
            /*2427*/
        }
        /*2428*/
    }


    // [virtual] class CefCookieManager
    /// <summary>
    /// Class used for managing cookies. The methods of this class may be called on
    /// any thread unless otherwise indicated.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*2472*/
    public struct CefCookieManager
    {
        /*2473*/
        const int _typeNAME = 8;
        /*2474*/
        const int CefCookieManager_Release_0 = (_typeNAME << 16) | 0;
        /*2475*/
        const int CefCookieManager_SetSupportedSchemes_1 = (_typeNAME << 16) | 1;
        /*2476*/
        const int CefCookieManager_VisitAllCookies_2 = (_typeNAME << 16) | 2;
        /*2477*/
        const int CefCookieManager_VisitUrlCookies_3 = (_typeNAME << 16) | 3;
        /*2478*/
        const int CefCookieManager_SetCookie_4 = (_typeNAME << 16) | 4;
        /*2479*/
        const int CefCookieManager_DeleteCookies_5 = (_typeNAME << 16) | 5;
        /*2480*/
        const int CefCookieManager_SetStoragePath_6 = (_typeNAME << 16) | 6;
        /*2481*/
        const int CefCookieManager_FlushStore_7 = (_typeNAME << 16) | 7;
        /*2482*/
        internal readonly IntPtr nativePtr;
        /*2483*/
        internal CefCookieManager(IntPtr nativePtr)
        {
            /*2484*/
            this.nativePtr = nativePtr;
            /*2485*/
        }
        /*2486*/
        public void Release()
        {
            /*2487*/
            JsValue ret;
            /*2488*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCookieManager_Release_0, out ret);
            /*2489*/
        }

        // gen! void SetSupportedSchemes(const std::vector<CefString>& schemes,CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// CefCookieManager methods.
        /// </summary>
        /*2490*/

        public void SetSupportedSchemes(List<string> /*2491*/
        schemes
        , CefCompletionCallback /*2492*/
        callback
        )/*2493*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2)/*2494*/
            ;
            v2.Ptr = callback.nativePtr/*2495*/
            ;
            /*2496*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefCookieManager_SetSupportedSchemes_1, out ret, ref v1, ref v2);
            /*2497*/

            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, schemes)/*2498*/
            ;
            /*2499*/
        }

        // gen! bool VisitAllCookies(CefRefPtr<CefCookieVisitor> visitor)
        /// <summary>
        /// Visit all cookies on the IO thread. The returned cookies are ordered by
        /// longest path, then by earliest creation date. Returns false if cookies
        /// cannot be accessed.
        /// /*cef()*/
        /// </summary>
        /*2500*/

        public bool VisitAllCookies(CefCookieVisitor /*2501*/
        visitor
        )/*2502*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr/*2503*/
            ;
            /*2504*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCookieManager_VisitAllCookies_2, out ret, ref v1);
            /*2505*/
            var ret_result = ret.I32 != 0;
            /*2506*/
            return ret_result;
            /*2507*/
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
        /*2508*/

        public bool VisitUrlCookies(string /*2509*/
        url
        , bool /*2510*/
        includeHttpOnly
        , CefCookieVisitor /*2511*/
        visitor
        )/*2512*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*2513*/
            ;
            v2.I32 = includeHttpOnly ? 1 : 0/*2514*/
            ;
            v3.Ptr = visitor.nativePtr/*2515*/
            ;
            /*2516*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_VisitUrlCookies_3, out ret, ref v1, ref v2, ref v3);
            /*2517*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2518*/
            ;
            /*2519*/
            return ret_result;
            /*2520*/
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
        /*2521*/

        public bool SetCookie(string /*2522*/
        url
        , CefCookie /*2523*/
        cookie
        , CefSetCookieCallback /*2524*/
        callback
        )/*2525*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*2526*/
            ;
            v2.Ptr = cookie.nativePtr/*2527*/
            ;
            v3.Ptr = callback.nativePtr/*2528*/
            ;
            /*2529*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_SetCookie_4, out ret, ref v1, ref v2, ref v3);
            /*2530*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2531*/
            ;
            /*2532*/
            return ret_result;
            /*2533*/
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
        /*2534*/

        public bool DeleteCookies(string /*2535*/
        url
        , string /*2536*/
        cookie_name
        , CefDeleteCookiesCallback /*2537*/
        callback
        )/*2538*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*2539*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(cookie_name);
            /*2540*/
            ;
            v3.Ptr = callback.nativePtr/*2541*/
            ;
            /*2542*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_DeleteCookies_5, out ret, ref v1, ref v2, ref v3);
            /*2543*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2544*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*2545*/
            ;
            /*2546*/
            return ret_result;
            /*2547*/
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
        /*2548*/

        public bool SetStoragePath(string /*2549*/
        path
        , bool /*2550*/
        persist_session_cookies
        , CefCompletionCallback /*2551*/
        callback
        )/*2552*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(path);
            /*2553*/
            ;
            v2.I32 = persist_session_cookies ? 1 : 0/*2554*/
            ;
            v3.Ptr = callback.nativePtr/*2555*/
            ;
            /*2556*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefCookieManager_SetStoragePath_6, out ret, ref v1, ref v2, ref v3);
            /*2557*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2558*/
            ;
            /*2559*/
            return ret_result;
            /*2560*/
        }

        // gen! bool FlushStore(CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Flush the backing store (if any) to disk. If |callback| is non-NULL it will
        /// be executed asnychronously on the IO thread after the flush is complete.
        /// Returns false if cookies cannot be accessed.
        /// /*cef(optional_param=callback)*/
        /// </summary>
        /*2561*/

        public bool FlushStore(CefCompletionCallback /*2562*/
        callback
        )/*2563*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = callback.nativePtr/*2564*/
            ;
            /*2565*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefCookieManager_FlushStore_7, out ret, ref v1);
            /*2566*/
            var ret_result = ret.I32 != 0;
            /*2567*/
            return ret_result;
            /*2568*/
        }
        /*2569*/
    }


    // [virtual] class CefCookieVisitor
    /// <summary>
    /// Interface to implement for visiting cookie values. The methods of this class
    /// will always be called on the IO thread.
    /// /*(source=client)*/
    /// </summary>
    /*2578*/
    public struct CefCookieVisitor
    {
        /*2579*/
        const int _typeNAME = 9;
        /*2580*/
        const int CefCookieVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*2581*/
        internal readonly IntPtr nativePtr;
        /*2582*/
        internal CefCookieVisitor(IntPtr nativePtr)
        {
            /*2583*/
            this.nativePtr = nativePtr;
            /*2584*/
        }
        /*2585*/
        public void Release()
        {
            /*2586*/
            JsValue ret;
            /*2587*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefCookieVisitor_Release_0, out ret);
            /*2588*/
        }
        /*2589*/
    }


    // [virtual] class CefDOMVisitor
    /// <summary>
    /// Interface to implement for visiting the DOM. The methods of this class will
    /// be called on the render process main thread.
    /// /*(source=client)*/
    /// </summary>
    /*2598*/
    public struct CefDOMVisitor
    {
        /*2599*/
        const int _typeNAME = 10;
        /*2600*/
        const int CefDOMVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*2601*/
        internal readonly IntPtr nativePtr;
        /*2602*/
        internal CefDOMVisitor(IntPtr nativePtr)
        {
            /*2603*/
            this.nativePtr = nativePtr;
            /*2604*/
        }
        /*2605*/
        public void Release()
        {
            /*2606*/
            JsValue ret;
            /*2607*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMVisitor_Release_0, out ret);
            /*2608*/
        }
        /*2609*/
    }


    // [virtual] class CefDOMDocument
    /// <summary>
    /// Class used to represent a DOM document. The methods of this class should only
    /// be called on the render process main thread thread.
    /// /*(source=library)*/
    /// </summary>
    /*2688*/
    public struct CefDOMDocument
    {
        /*2689*/
        const int _typeNAME = 11;
        /*2690*/
        const int CefDOMDocument_Release_0 = (_typeNAME << 16) | 0;
        /*2691*/
        const int CefDOMDocument_GetType_1 = (_typeNAME << 16) | 1;
        /*2692*/
        const int CefDOMDocument_GetDocument_2 = (_typeNAME << 16) | 2;
        /*2693*/
        const int CefDOMDocument_GetBody_3 = (_typeNAME << 16) | 3;
        /*2694*/
        const int CefDOMDocument_GetHead_4 = (_typeNAME << 16) | 4;
        /*2695*/
        const int CefDOMDocument_GetTitle_5 = (_typeNAME << 16) | 5;
        /*2696*/
        const int CefDOMDocument_GetElementById_6 = (_typeNAME << 16) | 6;
        /*2697*/
        const int CefDOMDocument_GetFocusedNode_7 = (_typeNAME << 16) | 7;
        /*2698*/
        const int CefDOMDocument_HasSelection_8 = (_typeNAME << 16) | 8;
        /*2699*/
        const int CefDOMDocument_GetSelectionStartOffset_9 = (_typeNAME << 16) | 9;
        /*2700*/
        const int CefDOMDocument_GetSelectionEndOffset_10 = (_typeNAME << 16) | 10;
        /*2701*/
        const int CefDOMDocument_GetSelectionAsMarkup_11 = (_typeNAME << 16) | 11;
        /*2702*/
        const int CefDOMDocument_GetSelectionAsText_12 = (_typeNAME << 16) | 12;
        /*2703*/
        const int CefDOMDocument_GetBaseURL_13 = (_typeNAME << 16) | 13;
        /*2704*/
        const int CefDOMDocument_GetCompleteURL_14 = (_typeNAME << 16) | 14;
        /*2705*/
        internal readonly IntPtr nativePtr;
        /*2706*/
        internal CefDOMDocument(IntPtr nativePtr)
        {
            /*2707*/
            this.nativePtr = nativePtr;
            /*2708*/
        }
        /*2709*/
        public void Release()
        {
            /*2710*/
            JsValue ret;
            /*2711*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_Release_0, out ret);
            /*2712*/
        }

        // gen! Type GetType()
        /// <summary>
        /// CefDOMDocument methods.
        /// </summary>
        /*2713*/

        public cef_dom_document_type_t _GetType()/*2714*/
        {
            JsValue ret;
            /*2715*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetType_1, out ret);
            /*2716*/
            var ret_result = (cef_dom_document_type_t)ret.I32;

            /*2717*/
            return ret_result;
            /*2718*/
        }

        // gen! CefRefPtr<CefDOMNode> GetDocument()
        /// <summary>
        /// Returns the root document node.
        /// /*cef()*/
        /// </summary>
        /*2719*/

        public CefDOMNode GetDocument()/*2720*/
        {
            JsValue ret;
            /*2721*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetDocument_2, out ret);
            /*2722*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2723*/
            return ret_result;
            /*2724*/
        }

        // gen! CefRefPtr<CefDOMNode> GetBody()
        /// <summary>
        /// Returns the BODY node of an HTML document.
        /// /*cef()*/
        /// </summary>
        /*2725*/

        public CefDOMNode GetBody()/*2726*/
        {
            JsValue ret;
            /*2727*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetBody_3, out ret);
            /*2728*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2729*/
            return ret_result;
            /*2730*/
        }

        // gen! CefRefPtr<CefDOMNode> GetHead()
        /// <summary>
        /// Returns the HEAD node of an HTML document.
        /// /*cef()*/
        /// </summary>
        /*2731*/

        public CefDOMNode GetHead()/*2732*/
        {
            JsValue ret;
            /*2733*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetHead_4, out ret);
            /*2734*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2735*/
            return ret_result;
            /*2736*/
        }

        // gen! CefString GetTitle()
        /// <summary>
        /// Returns the title of an HTML document.
        /// /*cef()*/
        /// </summary>
        /*2737*/

        public string GetTitle()/*2738*/
        {
            JsValue ret;
            /*2739*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetTitle_5, out ret);
            /*2740*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2741*/
            return ret_result;
            /*2742*/
        }

        // gen! CefRefPtr<CefDOMNode> GetElementById(const CefString& id)
        /// <summary>
        /// Returns the document element with the specified ID value.
        /// /*cef()*/
        /// </summary>
        /*2743*/

        public CefDOMNode GetElementById(string /*2744*/
        id
        )/*2745*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(id);
            /*2746*/
            ;
            /*2747*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMDocument_GetElementById_6, out ret, ref v1);
            /*2748*/
            var ret_result = new CefDOMNode(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2749*/
            ;
            /*2750*/
            return ret_result;
            /*2751*/
        }

        // gen! CefRefPtr<CefDOMNode> GetFocusedNode()
        /// <summary>
        /// Returns the node that currently has keyboard focus.
        /// /*cef()*/
        /// </summary>
        /*2752*/

        public CefDOMNode GetFocusedNode()/*2753*/
        {
            JsValue ret;
            /*2754*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetFocusedNode_7, out ret);
            /*2755*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*2756*/
            return ret_result;
            /*2757*/
        }

        // gen! bool HasSelection()
        /// <summary>
        /// Returns true if a portion of the document is selected.
        /// /*cef()*/
        /// </summary>
        /*2758*/

        public bool HasSelection()/*2759*/
        {
            JsValue ret;
            /*2760*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_HasSelection_8, out ret);
            /*2761*/
            var ret_result = ret.I32 != 0;
            /*2762*/
            return ret_result;
            /*2763*/
        }

        // gen! int GetSelectionStartOffset()
        /// <summary>
        /// Returns the selection offset within the start node.
        /// /*cef()*/
        /// </summary>
        /*2764*/

        public int GetSelectionStartOffset()/*2765*/
        {
            JsValue ret;
            /*2766*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionStartOffset_9, out ret);
            /*2767*/
            var ret_result = ret.I32;
            /*2768*/
            return ret_result;
            /*2769*/
        }

        // gen! int GetSelectionEndOffset()
        /// <summary>
        /// Returns the selection offset within the end node.
        /// /*cef()*/
        /// </summary>
        /*2770*/

        public int GetSelectionEndOffset()/*2771*/
        {
            JsValue ret;
            /*2772*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionEndOffset_10, out ret);
            /*2773*/
            var ret_result = ret.I32;
            /*2774*/
            return ret_result;
            /*2775*/
        }

        // gen! CefString GetSelectionAsMarkup()
        /// <summary>
        /// Returns the contents of this selection as markup.
        /// /*cef()*/
        /// </summary>
        /*2776*/

        public string GetSelectionAsMarkup()/*2777*/
        {
            JsValue ret;
            /*2778*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionAsMarkup_11, out ret);
            /*2779*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2780*/
            return ret_result;
            /*2781*/
        }

        // gen! CefString GetSelectionAsText()
        /// <summary>
        /// Returns the contents of this selection as text.
        /// /*cef()*/
        /// </summary>
        /*2782*/

        public string GetSelectionAsText()/*2783*/
        {
            JsValue ret;
            /*2784*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetSelectionAsText_12, out ret);
            /*2785*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2786*/
            return ret_result;
            /*2787*/
        }

        // gen! CefString GetBaseURL()
        /// <summary>
        /// Returns the base URL for the document.
        /// /*cef()*/
        /// </summary>
        /*2788*/

        public string GetBaseURL()/*2789*/
        {
            JsValue ret;
            /*2790*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMDocument_GetBaseURL_13, out ret);
            /*2791*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*2792*/
            return ret_result;
            /*2793*/
        }

        // gen! CefString GetCompleteURL(const CefString& partialURL)
        /// <summary>
        /// Returns a complete URL based on the document base URL and the specified
        /// partial URL.
        /// /*cef()*/
        /// </summary>
        /*2794*/

        public string GetCompleteURL(string /*2795*/
        partialURL
        )/*2796*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(partialURL);
            /*2797*/
            ;
            /*2798*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMDocument_GetCompleteURL_14, out ret, ref v1);
            /*2799*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*2800*/
            ;
            /*2801*/
            return ret_result;
            /*2802*/
        }
        /*2803*/
    }


    // [virtual] class CefDOMNode
    /// <summary>
    /// Class used to represent a DOM node. The methods of this class should only be
    /// called on the render process main thread.
    /// /*(source=library)*/
    /// </summary>
    /*2942*/
    public struct CefDOMNode
    {
        /*2943*/
        const int _typeNAME = 12;
        /*2944*/
        const int CefDOMNode_Release_0 = (_typeNAME << 16) | 0;
        /*2945*/
        const int CefDOMNode_GetType_1 = (_typeNAME << 16) | 1;
        /*2946*/
        const int CefDOMNode_IsText_2 = (_typeNAME << 16) | 2;
        /*2947*/
        const int CefDOMNode_IsElement_3 = (_typeNAME << 16) | 3;
        /*2948*/
        const int CefDOMNode_IsEditable_4 = (_typeNAME << 16) | 4;
        /*2949*/
        const int CefDOMNode_IsFormControlElement_5 = (_typeNAME << 16) | 5;
        /*2950*/
        const int CefDOMNode_GetFormControlElementType_6 = (_typeNAME << 16) | 6;
        /*2951*/
        const int CefDOMNode_IsSame_7 = (_typeNAME << 16) | 7;
        /*2952*/
        const int CefDOMNode_GetName_8 = (_typeNAME << 16) | 8;
        /*2953*/
        const int CefDOMNode_GetValue_9 = (_typeNAME << 16) | 9;
        /*2954*/
        const int CefDOMNode_SetValue_10 = (_typeNAME << 16) | 10;
        /*2955*/
        const int CefDOMNode_GetAsMarkup_11 = (_typeNAME << 16) | 11;
        /*2956*/
        const int CefDOMNode_GetDocument_12 = (_typeNAME << 16) | 12;
        /*2957*/
        const int CefDOMNode_GetParent_13 = (_typeNAME << 16) | 13;
        /*2958*/
        const int CefDOMNode_GetPreviousSibling_14 = (_typeNAME << 16) | 14;
        /*2959*/
        const int CefDOMNode_GetNextSibling_15 = (_typeNAME << 16) | 15;
        /*2960*/
        const int CefDOMNode_HasChildren_16 = (_typeNAME << 16) | 16;
        /*2961*/
        const int CefDOMNode_GetFirstChild_17 = (_typeNAME << 16) | 17;
        /*2962*/
        const int CefDOMNode_GetLastChild_18 = (_typeNAME << 16) | 18;
        /*2963*/
        const int CefDOMNode_GetElementTagName_19 = (_typeNAME << 16) | 19;
        /*2964*/
        const int CefDOMNode_HasElementAttributes_20 = (_typeNAME << 16) | 20;
        /*2965*/
        const int CefDOMNode_HasElementAttribute_21 = (_typeNAME << 16) | 21;
        /*2966*/
        const int CefDOMNode_GetElementAttribute_22 = (_typeNAME << 16) | 22;
        /*2967*/
        const int CefDOMNode_GetElementAttributes_23 = (_typeNAME << 16) | 23;
        /*2968*/
        const int CefDOMNode_SetElementAttribute_24 = (_typeNAME << 16) | 24;
        /*2969*/
        const int CefDOMNode_GetElementInnerText_25 = (_typeNAME << 16) | 25;
        /*2970*/
        const int CefDOMNode_GetElementBounds_26 = (_typeNAME << 16) | 26;
        /*2971*/
        internal readonly IntPtr nativePtr;
        /*2972*/
        internal CefDOMNode(IntPtr nativePtr)
        {
            /*2973*/
            this.nativePtr = nativePtr;
            /*2974*/
        }
        /*2975*/
        public void Release()
        {
            /*2976*/
            JsValue ret;
            /*2977*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_Release_0, out ret);
            /*2978*/
        }

        // gen! Type GetType()
        /// <summary>
        /// CefDOMNode methods.
        /// </summary>
        /*2979*/

        public cef_dom_node_type_t _GetType()/*2980*/
        {
            JsValue ret;
            /*2981*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetType_1, out ret);
            /*2982*/
            var ret_result = (cef_dom_node_type_t)ret.I32;

            /*2983*/
            return ret_result;
            /*2984*/
        }

        // gen! bool IsText()
        /// <summary>
        /// Returns true if this is a text node.
        /// /*cef()*/
        /// </summary>
        /*2985*/

        public bool IsText()/*2986*/
        {
            JsValue ret;
            /*2987*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsText_2, out ret);
            /*2988*/
            var ret_result = ret.I32 != 0;
            /*2989*/
            return ret_result;
            /*2990*/
        }

        // gen! bool IsElement()
        /// <summary>
        /// Returns true if this is an element node.
        /// /*cef()*/
        /// </summary>
        /*2991*/

        public bool IsElement()/*2992*/
        {
            JsValue ret;
            /*2993*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsElement_3, out ret);
            /*2994*/
            var ret_result = ret.I32 != 0;
            /*2995*/
            return ret_result;
            /*2996*/
        }

        // gen! bool IsEditable()
        /// <summary>
        /// Returns true if this is an editable node.
        /// /*cef()*/
        /// </summary>
        /*2997*/

        public bool IsEditable()/*2998*/
        {
            JsValue ret;
            /*2999*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsEditable_4, out ret);
            /*3000*/
            var ret_result = ret.I32 != 0;
            /*3001*/
            return ret_result;
            /*3002*/
        }

        // gen! bool IsFormControlElement()
        /// <summary>
        /// Returns true if this is a form control element node.
        /// /*cef()*/
        /// </summary>
        /*3003*/

        public bool IsFormControlElement()/*3004*/
        {
            JsValue ret;
            /*3005*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_IsFormControlElement_5, out ret);
            /*3006*/
            var ret_result = ret.I32 != 0;
            /*3007*/
            return ret_result;
            /*3008*/
        }

        // gen! CefString GetFormControlElementType()
        /// <summary>
        /// Returns the type of this form control element node.
        /// /*cef()*/
        /// </summary>
        /*3009*/

        public string GetFormControlElementType()/*3010*/
        {
            JsValue ret;
            /*3011*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetFormControlElementType_6, out ret);
            /*3012*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3013*/
            return ret_result;
            /*3014*/
        }

        // gen! bool IsSame(CefRefPtr<CefDOMNode> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>
        /*3015*/

        public bool IsSame(CefDOMNode /*3016*/
        that
        )/*3017*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr/*3018*/
            ;
            /*3019*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_IsSame_7, out ret, ref v1);
            /*3020*/
            var ret_result = ret.I32 != 0;
            /*3021*/
            return ret_result;
            /*3022*/
        }

        // gen! CefString GetName()
        /// <summary>
        /// Returns the name of this node.
        /// /*cef()*/
        /// </summary>
        /*3023*/

        public string GetName()/*3024*/
        {
            JsValue ret;
            /*3025*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetName_8, out ret);
            /*3026*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3027*/
            return ret_result;
            /*3028*/
        }

        // gen! CefString GetValue()
        /// <summary>
        /// Returns the value of this node.
        /// /*cef()*/
        /// </summary>
        /*3029*/

        public string GetValue()/*3030*/
        {
            JsValue ret;
            /*3031*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetValue_9, out ret);
            /*3032*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3033*/
            return ret_result;
            /*3034*/
        }

        // gen! bool SetValue(const CefString& value)
        /// <summary>
        /// Set the value of this node. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*3035*/

        public bool SetValue(string /*3036*/
        value
        )/*3037*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*3038*/
            ;
            /*3039*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_SetValue_10, out ret, ref v1);
            /*3040*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3041*/
            ;
            /*3042*/
            return ret_result;
            /*3043*/
        }

        // gen! CefString GetAsMarkup()
        /// <summary>
        /// Returns the contents of this node as markup.
        /// /*cef()*/
        /// </summary>
        /*3044*/

        public string GetAsMarkup()/*3045*/
        {
            JsValue ret;
            /*3046*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetAsMarkup_11, out ret);
            /*3047*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3048*/
            return ret_result;
            /*3049*/
        }

        // gen! CefRefPtr<CefDOMDocument> GetDocument()
        /// <summary>
        /// Returns the document associated with this node.
        /// /*cef()*/
        /// </summary>
        /*3050*/

        public CefDOMDocument GetDocument()/*3051*/
        {
            JsValue ret;
            /*3052*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetDocument_12, out ret);
            /*3053*/
            var ret_result = new CefDOMDocument(ret.Ptr);
            /*3054*/
            return ret_result;
            /*3055*/
        }

        // gen! CefRefPtr<CefDOMNode> GetParent()
        /// <summary>
        /// Returns the parent node.
        /// /*cef()*/
        /// </summary>
        /*3056*/

        public CefDOMNode GetParent()/*3057*/
        {
            JsValue ret;
            /*3058*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetParent_13, out ret);
            /*3059*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*3060*/
            return ret_result;
            /*3061*/
        }

        // gen! CefRefPtr<CefDOMNode> GetPreviousSibling()
        /// <summary>
        /// Returns the previous sibling node.
        /// /*cef()*/
        /// </summary>
        /*3062*/

        public CefDOMNode GetPreviousSibling()/*3063*/
        {
            JsValue ret;
            /*3064*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetPreviousSibling_14, out ret);
            /*3065*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*3066*/
            return ret_result;
            /*3067*/
        }

        // gen! CefRefPtr<CefDOMNode> GetNextSibling()
        /// <summary>
        /// Returns the next sibling node.
        /// /*cef()*/
        /// </summary>
        /*3068*/

        public CefDOMNode GetNextSibling()/*3069*/
        {
            JsValue ret;
            /*3070*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetNextSibling_15, out ret);
            /*3071*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*3072*/
            return ret_result;
            /*3073*/
        }

        // gen! bool HasChildren()
        /// <summary>
        /// Returns true if this node has child nodes.
        /// /*cef()*/
        /// </summary>
        /*3074*/

        public bool HasChildren()/*3075*/
        {
            JsValue ret;
            /*3076*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_HasChildren_16, out ret);
            /*3077*/
            var ret_result = ret.I32 != 0;
            /*3078*/
            return ret_result;
            /*3079*/
        }

        // gen! CefRefPtr<CefDOMNode> GetFirstChild()
        /// <summary>
        /// Return the first child node.
        /// /*cef()*/
        /// </summary>
        /*3080*/

        public CefDOMNode GetFirstChild()/*3081*/
        {
            JsValue ret;
            /*3082*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetFirstChild_17, out ret);
            /*3083*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*3084*/
            return ret_result;
            /*3085*/
        }

        // gen! CefRefPtr<CefDOMNode> GetLastChild()
        /// <summary>
        /// Returns the last child node.
        /// /*cef()*/
        /// </summary>
        /*3086*/

        public CefDOMNode GetLastChild()/*3087*/
        {
            JsValue ret;
            /*3088*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetLastChild_18, out ret);
            /*3089*/
            var ret_result = new CefDOMNode(ret.Ptr);
            /*3090*/
            return ret_result;
            /*3091*/
        }

        // gen! CefString GetElementTagName()
        /// <summary>
        /// The following methods are valid only for element nodes.
        /// Returns the tag name of this element.
        /// /*cef()*/
        /// </summary>
        /*3092*/

        public string GetElementTagName()/*3093*/
        {
            JsValue ret;
            /*3094*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementTagName_19, out ret);
            /*3095*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3096*/
            return ret_result;
            /*3097*/
        }

        // gen! bool HasElementAttributes()
        /// <summary>
        /// Returns true if this element has attributes.
        /// /*cef()*/
        /// </summary>
        /*3098*/

        public bool HasElementAttributes()/*3099*/
        {
            JsValue ret;
            /*3100*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_HasElementAttributes_20, out ret);
            /*3101*/
            var ret_result = ret.I32 != 0;
            /*3102*/
            return ret_result;
            /*3103*/
        }

        // gen! bool HasElementAttribute(const CefString& attrName)
        /// <summary>
        /// Returns true if this element has an attribute named |attrName|.
        /// /*cef()*/
        /// </summary>
        /*3104*/

        public bool HasElementAttribute(string /*3105*/
        attrName
        )/*3106*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(attrName);
            /*3107*/
            ;
            /*3108*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_HasElementAttribute_21, out ret, ref v1);
            /*3109*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3110*/
            ;
            /*3111*/
            return ret_result;
            /*3112*/
        }

        // gen! CefString GetElementAttribute(const CefString& attrName)
        /// <summary>
        /// Returns the element attribute named |attrName|.
        /// /*cef()*/
        /// </summary>
        /*3113*/

        public string GetElementAttribute(string /*3114*/
        attrName
        )/*3115*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(attrName);
            /*3116*/
            ;
            /*3117*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_GetElementAttribute_22, out ret, ref v1);
            /*3118*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3119*/
            ;
            /*3120*/
            return ret_result;
            /*3121*/
        }

        // gen! void GetElementAttributes(AttributeMap& attrMap)
        /// <summary>
        /// Returns a map of all element attributes.
        /// /*cef()*/
        /// </summary>
        /*3122*/

        public void GetElementAttributes(AttributeMap /*3123*/
        attrMap
        )/*3124*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = attrMap.nativePtr/*3125*/
            ;
            /*3126*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDOMNode_GetElementAttributes_23, out ret, ref v1);
            /*3127*/

            /*3128*/
        }

        // gen! bool SetElementAttribute(const CefString& attrName,const CefString& value)
        /// <summary>
        /// Set the value for the element attribute named |attrName|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*3129*/

        public bool SetElementAttribute(string /*3130*/
        attrName
        , string /*3131*/
        value
        )/*3132*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(attrName);
            /*3133*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*3134*/
            ;
            /*3135*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDOMNode_SetElementAttribute_24, out ret, ref v1, ref v2);
            /*3136*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3137*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*3138*/
            ;
            /*3139*/
            return ret_result;
            /*3140*/
        }

        // gen! CefString GetElementInnerText()
        /// <summary>
        /// Returns the inner text of the element.
        /// /*cef()*/
        /// </summary>
        /*3141*/

        public string GetElementInnerText()/*3142*/
        {
            JsValue ret;
            /*3143*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementInnerText_25, out ret);
            /*3144*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3145*/
            return ret_result;
            /*3146*/
        }

        // gen! CefRect GetElementBounds()
        /// <summary>
        /// Returns the bounds of the element.
        /// /*cef()*/
        /// </summary>
        /*3147*/

        public CefRect GetElementBounds()/*3148*/
        {
            JsValue ret;
            /*3149*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDOMNode_GetElementBounds_26, out ret);
            /*3150*/
            var ret_result = new CefRect(ret.Ptr);

            /*3151*/
            return ret_result;
            /*3152*/
        }
        /*3153*/
    }


    // [virtual] class CefDownloadItem
    /// <summary>
    /// Class used to represent a download item.
    /// /*(source=library)*/
    /// </summary>
    /*3247*/
    public struct CefDownloadItem
    {
        /*3248*/
        const int _typeNAME = 13;
        /*3249*/
        const int CefDownloadItem_Release_0 = (_typeNAME << 16) | 0;
        /*3250*/
        const int CefDownloadItem_IsValid_1 = (_typeNAME << 16) | 1;
        /*3251*/
        const int CefDownloadItem_IsInProgress_2 = (_typeNAME << 16) | 2;
        /*3252*/
        const int CefDownloadItem_IsComplete_3 = (_typeNAME << 16) | 3;
        /*3253*/
        const int CefDownloadItem_IsCanceled_4 = (_typeNAME << 16) | 4;
        /*3254*/
        const int CefDownloadItem_GetCurrentSpeed_5 = (_typeNAME << 16) | 5;
        /*3255*/
        const int CefDownloadItem_GetPercentComplete_6 = (_typeNAME << 16) | 6;
        /*3256*/
        const int CefDownloadItem_GetTotalBytes_7 = (_typeNAME << 16) | 7;
        /*3257*/
        const int CefDownloadItem_GetReceivedBytes_8 = (_typeNAME << 16) | 8;
        /*3258*/
        const int CefDownloadItem_GetStartTime_9 = (_typeNAME << 16) | 9;
        /*3259*/
        const int CefDownloadItem_GetEndTime_10 = (_typeNAME << 16) | 10;
        /*3260*/
        const int CefDownloadItem_GetFullPath_11 = (_typeNAME << 16) | 11;
        /*3261*/
        const int CefDownloadItem_GetId_12 = (_typeNAME << 16) | 12;
        /*3262*/
        const int CefDownloadItem_GetURL_13 = (_typeNAME << 16) | 13;
        /*3263*/
        const int CefDownloadItem_GetOriginalUrl_14 = (_typeNAME << 16) | 14;
        /*3264*/
        const int CefDownloadItem_GetSuggestedFileName_15 = (_typeNAME << 16) | 15;
        /*3265*/
        const int CefDownloadItem_GetContentDisposition_16 = (_typeNAME << 16) | 16;
        /*3266*/
        const int CefDownloadItem_GetMimeType_17 = (_typeNAME << 16) | 17;
        /*3267*/
        internal readonly IntPtr nativePtr;
        /*3268*/
        internal CefDownloadItem(IntPtr nativePtr)
        {
            /*3269*/
            this.nativePtr = nativePtr;
            /*3270*/
        }
        /*3271*/
        public void Release()
        {
            /*3272*/
            JsValue ret;
            /*3273*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_Release_0, out ret);
            /*3274*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefDownloadItem methods.
        /// </summary>
        /*3275*/

        public bool IsValid()/*3276*/
        {
            JsValue ret;
            /*3277*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsValid_1, out ret);
            /*3278*/
            var ret_result = ret.I32 != 0;
            /*3279*/
            return ret_result;
            /*3280*/
        }

        // gen! bool IsInProgress()
        /// <summary>
        /// Returns true if the download is in progress.
        /// /*cef()*/
        /// </summary>
        /*3281*/

        public bool IsInProgress()/*3282*/
        {
            JsValue ret;
            /*3283*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsInProgress_2, out ret);
            /*3284*/
            var ret_result = ret.I32 != 0;
            /*3285*/
            return ret_result;
            /*3286*/
        }

        // gen! bool IsComplete()
        /// <summary>
        /// Returns true if the download is complete.
        /// /*cef()*/
        /// </summary>
        /*3287*/

        public bool IsComplete()/*3288*/
        {
            JsValue ret;
            /*3289*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsComplete_3, out ret);
            /*3290*/
            var ret_result = ret.I32 != 0;
            /*3291*/
            return ret_result;
            /*3292*/
        }

        // gen! bool IsCanceled()
        /// <summary>
        /// Returns true if the download has been canceled or interrupted.
        /// /*cef()*/
        /// </summary>
        /*3293*/

        public bool IsCanceled()/*3294*/
        {
            JsValue ret;
            /*3295*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_IsCanceled_4, out ret);
            /*3296*/
            var ret_result = ret.I32 != 0;
            /*3297*/
            return ret_result;
            /*3298*/
        }

        // gen! int64 GetCurrentSpeed()
        /// <summary>
        /// Returns a simple speed estimate in bytes/s.
        /// /*cef()*/
        /// </summary>
        /*3299*/

        public long GetCurrentSpeed()/*3300*/
        {
            JsValue ret;
            /*3301*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetCurrentSpeed_5, out ret);
            /*3302*/
            var ret_result = ret.I64;
            /*3303*/
            return ret_result;
            /*3304*/
        }

        // gen! int GetPercentComplete()
        /// <summary>
        /// Returns the rough percent complete or -1 if the receive total size is
        /// unknown.
        /// /*cef()*/
        /// </summary>
        /*3305*/

        public int GetPercentComplete()/*3306*/
        {
            JsValue ret;
            /*3307*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetPercentComplete_6, out ret);
            /*3308*/
            var ret_result = ret.I32;
            /*3309*/
            return ret_result;
            /*3310*/
        }

        // gen! int64 GetTotalBytes()
        /// <summary>
        /// Returns the total number of bytes.
        /// /*cef()*/
        /// </summary>
        /*3311*/

        public long GetTotalBytes()/*3312*/
        {
            JsValue ret;
            /*3313*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetTotalBytes_7, out ret);
            /*3314*/
            var ret_result = ret.I64;
            /*3315*/
            return ret_result;
            /*3316*/
        }

        // gen! int64 GetReceivedBytes()
        /// <summary>
        /// Returns the number of received bytes.
        /// /*cef()*/
        /// </summary>
        /*3317*/

        public long GetReceivedBytes()/*3318*/
        {
            JsValue ret;
            /*3319*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetReceivedBytes_8, out ret);
            /*3320*/
            var ret_result = ret.I64;
            /*3321*/
            return ret_result;
            /*3322*/
        }

        // gen! CefTime GetStartTime()
        /// <summary>
        /// Returns the time that the download started.
        /// /*cef()*/
        /// </summary>
        /*3323*/

        public CefTime GetStartTime()/*3324*/
        {
            JsValue ret;
            /*3325*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetStartTime_9, out ret);
            /*3326*/
            var ret_result = new CefTime(ret.Ptr);

            /*3327*/
            return ret_result;
            /*3328*/
        }

        // gen! CefTime GetEndTime()
        /// <summary>
        /// Returns the time that the download ended.
        /// /*cef()*/
        /// </summary>
        /*3329*/

        public CefTime GetEndTime()/*3330*/
        {
            JsValue ret;
            /*3331*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetEndTime_10, out ret);
            /*3332*/
            var ret_result = new CefTime(ret.Ptr);

            /*3333*/
            return ret_result;
            /*3334*/
        }

        // gen! CefString GetFullPath()
        /// <summary>
        /// Returns the full path to the downloaded or downloading file.
        /// /*cef()*/
        /// </summary>
        /*3335*/

        public string GetFullPath()/*3336*/
        {
            JsValue ret;
            /*3337*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetFullPath_11, out ret);
            /*3338*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3339*/
            return ret_result;
            /*3340*/
        }

        // gen! uint32 GetId()
        /// <summary>
        /// Returns the unique identifier for this download.
        /// /*cef()*/
        /// </summary>
        /*3341*/

        public uint GetId()/*3342*/
        {
            JsValue ret;
            /*3343*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetId_12, out ret);
            /*3344*/
            var ret_result = (uint)ret.I32;
            /*3345*/
            return ret_result;
            /*3346*/
        }

        // gen! CefString GetURL()
        /// <summary>
        /// Returns the URL.
        /// /*cef()*/
        /// </summary>
        /*3347*/

        public string GetURL()/*3348*/
        {
            JsValue ret;
            /*3349*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetURL_13, out ret);
            /*3350*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3351*/
            return ret_result;
            /*3352*/
        }

        // gen! CefString GetOriginalUrl()
        /// <summary>
        /// Returns the original URL before any redirections.
        /// /*cef()*/
        /// </summary>
        /*3353*/

        public string GetOriginalUrl()/*3354*/
        {
            JsValue ret;
            /*3355*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetOriginalUrl_14, out ret);
            /*3356*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3357*/
            return ret_result;
            /*3358*/
        }

        // gen! CefString GetSuggestedFileName()
        /// <summary>
        /// Returns the suggested file name.
        /// /*cef()*/
        /// </summary>
        /*3359*/

        public string GetSuggestedFileName()/*3360*/
        {
            JsValue ret;
            /*3361*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetSuggestedFileName_15, out ret);
            /*3362*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3363*/
            return ret_result;
            /*3364*/
        }

        // gen! CefString GetContentDisposition()
        /// <summary>
        /// Returns the content disposition.
        /// /*cef()*/
        /// </summary>
        /*3365*/

        public string GetContentDisposition()/*3366*/
        {
            JsValue ret;
            /*3367*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetContentDisposition_16, out ret);
            /*3368*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3369*/
            return ret_result;
            /*3370*/
        }

        // gen! CefString GetMimeType()
        /// <summary>
        /// Returns the mime type.
        /// /*cef()*/
        /// </summary>
        /*3371*/

        public string GetMimeType()/*3372*/
        {
            JsValue ret;
            /*3373*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDownloadItem_GetMimeType_17, out ret);
            /*3374*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3375*/
            return ret_result;
            /*3376*/
        }
        /*3377*/
    }


    // [virtual] class CefDragData
    /// <summary>
    /// Class used to represent drag data. The methods of this class may be called
    /// on any thread.
    /// /*(source=library)*/
    /// </summary>
    /*3511*/
    public struct CefDragData
    {
        /*3512*/
        const int _typeNAME = 14;
        /*3513*/
        const int CefDragData_Release_0 = (_typeNAME << 16) | 0;
        /*3514*/
        const int CefDragData_Clone_1 = (_typeNAME << 16) | 1;
        /*3515*/
        const int CefDragData_IsReadOnly_2 = (_typeNAME << 16) | 2;
        /*3516*/
        const int CefDragData_IsLink_3 = (_typeNAME << 16) | 3;
        /*3517*/
        const int CefDragData_IsFragment_4 = (_typeNAME << 16) | 4;
        /*3518*/
        const int CefDragData_IsFile_5 = (_typeNAME << 16) | 5;
        /*3519*/
        const int CefDragData_GetLinkURL_6 = (_typeNAME << 16) | 6;
        /*3520*/
        const int CefDragData_GetLinkTitle_7 = (_typeNAME << 16) | 7;
        /*3521*/
        const int CefDragData_GetLinkMetadata_8 = (_typeNAME << 16) | 8;
        /*3522*/
        const int CefDragData_GetFragmentText_9 = (_typeNAME << 16) | 9;
        /*3523*/
        const int CefDragData_GetFragmentHtml_10 = (_typeNAME << 16) | 10;
        /*3524*/
        const int CefDragData_GetFragmentBaseURL_11 = (_typeNAME << 16) | 11;
        /*3525*/
        const int CefDragData_GetFileName_12 = (_typeNAME << 16) | 12;
        /*3526*/
        const int CefDragData_GetFileContents_13 = (_typeNAME << 16) | 13;
        /*3527*/
        const int CefDragData_GetFileNames_14 = (_typeNAME << 16) | 14;
        /*3528*/
        const int CefDragData_SetLinkURL_15 = (_typeNAME << 16) | 15;
        /*3529*/
        const int CefDragData_SetLinkTitle_16 = (_typeNAME << 16) | 16;
        /*3530*/
        const int CefDragData_SetLinkMetadata_17 = (_typeNAME << 16) | 17;
        /*3531*/
        const int CefDragData_SetFragmentText_18 = (_typeNAME << 16) | 18;
        /*3532*/
        const int CefDragData_SetFragmentHtml_19 = (_typeNAME << 16) | 19;
        /*3533*/
        const int CefDragData_SetFragmentBaseURL_20 = (_typeNAME << 16) | 20;
        /*3534*/
        const int CefDragData_ResetFileContents_21 = (_typeNAME << 16) | 21;
        /*3535*/
        const int CefDragData_AddFile_22 = (_typeNAME << 16) | 22;
        /*3536*/
        const int CefDragData_GetImage_23 = (_typeNAME << 16) | 23;
        /*3537*/
        const int CefDragData_GetImageHotspot_24 = (_typeNAME << 16) | 24;
        /*3538*/
        const int CefDragData_HasImage_25 = (_typeNAME << 16) | 25;
        /*3539*/
        internal readonly IntPtr nativePtr;
        /*3540*/
        internal CefDragData(IntPtr nativePtr)
        {
            /*3541*/
            this.nativePtr = nativePtr;
            /*3542*/
        }
        /*3543*/
        public void Release()
        {
            /*3544*/
            JsValue ret;
            /*3545*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_Release_0, out ret);
            /*3546*/
        }

        // gen! CefRefPtr<CefDragData> Clone()
        /// <summary>
        /// CefDragData methods.
        /// </summary>
        /*3547*/

        public CefDragData Clone()/*3548*/
        {
            JsValue ret;
            /*3549*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_Clone_1, out ret);
            /*3550*/
            var ret_result = new CefDragData(ret.Ptr);
            /*3551*/
            return ret_result;
            /*3552*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if this object is read-only.
        /// /*cef()*/
        /// </summary>
        /*3553*/

        public bool IsReadOnly()/*3554*/
        {
            JsValue ret;
            /*3555*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsReadOnly_2, out ret);
            /*3556*/
            var ret_result = ret.I32 != 0;
            /*3557*/
            return ret_result;
            /*3558*/
        }

        // gen! bool IsLink()
        /// <summary>
        /// Returns true if the drag data is a link.
        /// /*cef()*/
        /// </summary>
        /*3559*/

        public bool IsLink()/*3560*/
        {
            JsValue ret;
            /*3561*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsLink_3, out ret);
            /*3562*/
            var ret_result = ret.I32 != 0;
            /*3563*/
            return ret_result;
            /*3564*/
        }

        // gen! bool IsFragment()
        /// <summary>
        /// Returns true if the drag data is a text or html fragment.
        /// /*cef()*/
        /// </summary>
        /*3565*/

        public bool IsFragment()/*3566*/
        {
            JsValue ret;
            /*3567*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsFragment_4, out ret);
            /*3568*/
            var ret_result = ret.I32 != 0;
            /*3569*/
            return ret_result;
            /*3570*/
        }

        // gen! bool IsFile()
        /// <summary>
        /// Returns true if the drag data is a file.
        /// /*cef()*/
        /// </summary>
        /*3571*/

        public bool IsFile()/*3572*/
        {
            JsValue ret;
            /*3573*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_IsFile_5, out ret);
            /*3574*/
            var ret_result = ret.I32 != 0;
            /*3575*/
            return ret_result;
            /*3576*/
        }

        // gen! CefString GetLinkURL()
        /// <summary>
        /// Return the link URL that is being dragged.
        /// /*cef()*/
        /// </summary>
        /*3577*/

        public string GetLinkURL()/*3578*/
        {
            JsValue ret;
            /*3579*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkURL_6, out ret);
            /*3580*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3581*/
            return ret_result;
            /*3582*/
        }

        // gen! CefString GetLinkTitle()
        /// <summary>
        /// Return the title associated with the link being dragged.
        /// /*cef()*/
        /// </summary>
        /*3583*/

        public string GetLinkTitle()/*3584*/
        {
            JsValue ret;
            /*3585*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkTitle_7, out ret);
            /*3586*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3587*/
            return ret_result;
            /*3588*/
        }

        // gen! CefString GetLinkMetadata()
        /// <summary>
        /// Return the metadata, if any, associated with the link being dragged.
        /// /*cef()*/
        /// </summary>
        /*3589*/

        public string GetLinkMetadata()/*3590*/
        {
            JsValue ret;
            /*3591*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetLinkMetadata_8, out ret);
            /*3592*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3593*/
            return ret_result;
            /*3594*/
        }

        // gen! CefString GetFragmentText()
        /// <summary>
        /// Return the plain text fragment that is being dragged.
        /// /*cef()*/
        /// </summary>
        /*3595*/

        public string GetFragmentText()/*3596*/
        {
            JsValue ret;
            /*3597*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentText_9, out ret);
            /*3598*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3599*/
            return ret_result;
            /*3600*/
        }

        // gen! CefString GetFragmentHtml()
        /// <summary>
        /// Return the text/html fragment that is being dragged.
        /// /*cef()*/
        /// </summary>
        /*3601*/

        public string GetFragmentHtml()/*3602*/
        {
            JsValue ret;
            /*3603*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentHtml_10, out ret);
            /*3604*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3605*/
            return ret_result;
            /*3606*/
        }

        // gen! CefString GetFragmentBaseURL()
        /// <summary>
        /// Return the base URL that the fragment came from. This value is used for
        /// resolving relative URLs and may be empty.
        /// /*cef()*/
        /// </summary>
        /*3607*/

        public string GetFragmentBaseURL()/*3608*/
        {
            JsValue ret;
            /*3609*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFragmentBaseURL_11, out ret);
            /*3610*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3611*/
            return ret_result;
            /*3612*/
        }

        // gen! CefString GetFileName()
        /// <summary>
        /// Return the name of the file being dragged out of the browser window.
        /// /*cef()*/
        /// </summary>
        /*3613*/

        public string GetFileName()/*3614*/
        {
            JsValue ret;
            /*3615*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetFileName_12, out ret);
            /*3616*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3617*/
            return ret_result;
            /*3618*/
        }

        // gen! size_t GetFileContents(CefRefPtr<CefStreamWriter> writer)
        /// <summary>
        /// Write the contents of the file being dragged out of the web view into
        /// |writer|. Returns the number of bytes sent to |writer|. If |writer| is
        /// NULL this method will return the size of the file contents in bytes.
        /// Call GetFileName() to get a suggested name for the file.
        /// /*cef(optional_param=writer)*/
        /// </summary>
        /*3619*/

        public uint GetFileContents(CefStreamWriter /*3620*/
        writer
        )/*3621*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = writer.nativePtr/*3622*/
            ;
            /*3623*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_GetFileContents_13, out ret, ref v1);
            /*3624*/
            var ret_result = (uint)ret.I32;
            /*3625*/
            return ret_result;
            /*3626*/
        }

        // gen! bool GetFileNames(std::vector<CefString>& names)
        /// <summary>
        /// Retrieve the list of file names that are being dragged into the browser
        /// window.
        /// /*cef()*/
        /// </summary>
        /*3627*/

        public bool GetFileNames(List<string> /*3628*/
        names
        )/*3629*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2)/*3630*/
            ;
            /*3631*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_GetFileNames_14, out ret, ref v1);
            /*3632*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, names)/*3633*/
            ;
            /*3634*/
            return ret_result;
            /*3635*/
        }

        // gen! void SetLinkURL(const CefString& url)
        /// <summary>
        /// Set the link URL that is being dragged.
        /// /*cef(optional_param=url)*/
        /// </summary>
        /*3636*/

        public void SetLinkURL(string /*3637*/
        url
        )/*3638*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*3639*/
            ;
            /*3640*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkURL_15, out ret, ref v1);
            /*3641*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3642*/
            ;
            /*3643*/
        }

        // gen! void SetLinkTitle(const CefString& title)
        /// <summary>
        /// Set the title associated with the link being dragged.
        /// /*cef(optional_param=title)*/
        /// </summary>
        /*3644*/

        public void SetLinkTitle(string /*3645*/
        title
        )/*3646*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(title);
            /*3647*/
            ;
            /*3648*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkTitle_16, out ret, ref v1);
            /*3649*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3650*/
            ;
            /*3651*/
        }

        // gen! void SetLinkMetadata(const CefString& data)
        /// <summary>
        /// Set the metadata associated with the link being dragged.
        /// /*cef(optional_param=data)*/
        /// </summary>
        /*3652*/

        public void SetLinkMetadata(string /*3653*/
        data
        )/*3654*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(data);
            /*3655*/
            ;
            /*3656*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetLinkMetadata_17, out ret, ref v1);
            /*3657*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3658*/
            ;
            /*3659*/
        }

        // gen! void SetFragmentText(const CefString& text)
        /// <summary>
        /// Set the plain text fragment that is being dragged.
        /// /*cef(optional_param=text)*/
        /// </summary>
        /*3660*/

        public void SetFragmentText(string /*3661*/
        text
        )/*3662*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(text);
            /*3663*/
            ;
            /*3664*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentText_18, out ret, ref v1);
            /*3665*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3666*/
            ;
            /*3667*/
        }

        // gen! void SetFragmentHtml(const CefString& html)
        /// <summary>
        /// Set the text/html fragment that is being dragged.
        /// /*cef(optional_param=html)*/
        /// </summary>
        /*3668*/

        public void SetFragmentHtml(string /*3669*/
        html
        )/*3670*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(html);
            /*3671*/
            ;
            /*3672*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentHtml_19, out ret, ref v1);
            /*3673*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3674*/
            ;
            /*3675*/
        }

        // gen! void SetFragmentBaseURL(const CefString& base_url)
        /// <summary>
        /// Set the base URL that the fragment came from.
        /// /*cef(optional_param=base_url)*/
        /// </summary>
        /*3676*/

        public void SetFragmentBaseURL(string /*3677*/
        base_url
        )/*3678*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(base_url);
            /*3679*/
            ;
            /*3680*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDragData_SetFragmentBaseURL_20, out ret, ref v1);
            /*3681*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3682*/
            ;
            /*3683*/
        }

        // gen! void ResetFileContents()
        /// <summary>
        /// Reset the file contents. You should do this before calling
        /// CefBrowserHost::DragTargetDragEnter as the web view does not allow us to
        /// drag in this kind of data.
        /// /*cef()*/
        /// </summary>
        /*3684*/

        public void ResetFileContents()/*3685*/
        {
            JsValue ret;
            /*3686*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_ResetFileContents_21, out ret);
            /*3687*/

            /*3688*/
        }

        // gen! void AddFile(const CefString& path,const CefString& display_name)
        /// <summary>
        /// Add a file that is being dragged into the webview.
        /// /*cef(optional_param=display_name)*/
        /// </summary>
        /*3689*/

        public void AddFile(string /*3690*/
        path
        , string /*3691*/
        display_name
        )/*3692*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(path);
            /*3693*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(display_name);
            /*3694*/
            ;
            /*3695*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDragData_AddFile_22, out ret, ref v1, ref v2);
            /*3696*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3697*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*3698*/
            ;
            /*3699*/
        }

        // gen! CefRefPtr<CefImage> GetImage()
        /// <summary>
        /// Get the image representation of drag data. May return NULL if no image
        /// representation is available.
        /// /*cef()*/
        /// </summary>
        /*3700*/

        public CefImage GetImage()/*3701*/
        {
            JsValue ret;
            /*3702*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetImage_23, out ret);
            /*3703*/
            var ret_result = new CefImage(ret.Ptr);
            /*3704*/
            return ret_result;
            /*3705*/
        }

        // gen! CefPoint GetImageHotspot()
        /// <summary>
        /// Get the image hotspot (drag start location relative to image dimensions).
        /// /*cef()*/
        /// </summary>
        /*3706*/

        public CefPoint GetImageHotspot()/*3707*/
        {
            JsValue ret;
            /*3708*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_GetImageHotspot_24, out ret);
            /*3709*/
            var ret_result = new CefPoint(ret.Ptr);

            /*3710*/
            return ret_result;
            /*3711*/
        }

        // gen! bool HasImage()
        /// <summary>
        /// Returns true if an image representation of drag data is available.
        /// /*cef()*/
        /// </summary>
        /*3712*/

        public bool HasImage()/*3713*/
        {
            JsValue ret;
            /*3714*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDragData_HasImage_25, out ret);
            /*3715*/
            var ret_result = ret.I32 != 0;
            /*3716*/
            return ret_result;
            /*3717*/
        }
        /*3718*/
    }


    // [virtual] class CefFrame
    /// <summary>
    /// Class used to represent a frame in the browser window. When used in the
    /// browser process the methods of this class may be called on any thread unless
    /// otherwise indicated in the comments. When used in the render process the
    /// methods of this class may only be called on the main thread.
    /// /*(source=library)*/
    /// </summary>
    /*3847*/
    public struct CefFrame
    {
        /*3848*/
        const int _typeNAME = 15;
        /*3849*/
        const int CefFrame_Release_0 = (_typeNAME << 16) | 0;
        /*3850*/
        const int CefFrame_IsValid_1 = (_typeNAME << 16) | 1;
        /*3851*/
        const int CefFrame_Undo_2 = (_typeNAME << 16) | 2;
        /*3852*/
        const int CefFrame_Redo_3 = (_typeNAME << 16) | 3;
        /*3853*/
        const int CefFrame_Cut_4 = (_typeNAME << 16) | 4;
        /*3854*/
        const int CefFrame_Copy_5 = (_typeNAME << 16) | 5;
        /*3855*/
        const int CefFrame_Paste_6 = (_typeNAME << 16) | 6;
        /*3856*/
        const int CefFrame_Delete_7 = (_typeNAME << 16) | 7;
        /*3857*/
        const int CefFrame_SelectAll_8 = (_typeNAME << 16) | 8;
        /*3858*/
        const int CefFrame_ViewSource_9 = (_typeNAME << 16) | 9;
        /*3859*/
        const int CefFrame_GetSource_10 = (_typeNAME << 16) | 10;
        /*3860*/
        const int CefFrame_GetText_11 = (_typeNAME << 16) | 11;
        /*3861*/
        const int CefFrame_LoadRequest_12 = (_typeNAME << 16) | 12;
        /*3862*/
        const int CefFrame_LoadURL_13 = (_typeNAME << 16) | 13;
        /*3863*/
        const int CefFrame_LoadString_14 = (_typeNAME << 16) | 14;
        /*3864*/
        const int CefFrame_ExecuteJavaScript_15 = (_typeNAME << 16) | 15;
        /*3865*/
        const int CefFrame_IsMain_16 = (_typeNAME << 16) | 16;
        /*3866*/
        const int CefFrame_IsFocused_17 = (_typeNAME << 16) | 17;
        /*3867*/
        const int CefFrame_GetName_18 = (_typeNAME << 16) | 18;
        /*3868*/
        const int CefFrame_GetIdentifier_19 = (_typeNAME << 16) | 19;
        /*3869*/
        const int CefFrame_GetParent_20 = (_typeNAME << 16) | 20;
        /*3870*/
        const int CefFrame_GetURL_21 = (_typeNAME << 16) | 21;
        /*3871*/
        const int CefFrame_GetBrowser_22 = (_typeNAME << 16) | 22;
        /*3872*/
        const int CefFrame_GetV8Context_23 = (_typeNAME << 16) | 23;
        /*3873*/
        const int CefFrame_VisitDOM_24 = (_typeNAME << 16) | 24;
        /*3874*/
        internal readonly IntPtr nativePtr;
        /*3875*/
        internal CefFrame(IntPtr nativePtr)
        {
            /*3876*/
            this.nativePtr = nativePtr;
            /*3877*/
        }
        /*3878*/
        public void Release()
        {
            /*3879*/
            JsValue ret;
            /*3880*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Release_0, out ret);
            /*3881*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefFrame methods.
        /// </summary>
        /*3882*/

        public bool IsValid()/*3883*/
        {
            JsValue ret;
            /*3884*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsValid_1, out ret);
            /*3885*/
            var ret_result = ret.I32 != 0;
            /*3886*/
            return ret_result;
            /*3887*/
        }

        // gen! void Undo()
        /// <summary>
        /// Execute undo in this frame.
        /// /*cef()*/
        /// </summary>
        /*3888*/

        public void Undo()/*3889*/
        {
            JsValue ret;
            /*3890*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Undo_2, out ret);
            /*3891*/

            /*3892*/
        }

        // gen! void Redo()
        /// <summary>
        /// Execute redo in this frame.
        /// /*cef()*/
        /// </summary>
        /*3893*/

        public void Redo()/*3894*/
        {
            JsValue ret;
            /*3895*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Redo_3, out ret);
            /*3896*/

            /*3897*/
        }

        // gen! void Cut()
        /// <summary>
        /// Execute cut in this frame.
        /// /*cef()*/
        /// </summary>
        /*3898*/

        public void Cut()/*3899*/
        {
            JsValue ret;
            /*3900*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Cut_4, out ret);
            /*3901*/

            /*3902*/
        }

        // gen! void Copy()
        /// <summary>
        /// Execute copy in this frame.
        /// /*cef()*/
        /// </summary>
        /*3903*/

        public void Copy()/*3904*/
        {
            JsValue ret;
            /*3905*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Copy_5, out ret);
            /*3906*/

            /*3907*/
        }

        // gen! void Paste()
        /// <summary>
        /// Execute paste in this frame.
        /// /*cef()*/
        /// </summary>
        /*3908*/

        public void Paste()/*3909*/
        {
            JsValue ret;
            /*3910*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Paste_6, out ret);
            /*3911*/

            /*3912*/
        }

        // gen! void Delete()
        /// <summary>
        /// Execute delete in this frame.
        /// /*cef(capi_name=del)*/
        /// </summary>
        /*3913*/

        public void Delete()/*3914*/
        {
            JsValue ret;
            /*3915*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_Delete_7, out ret);
            /*3916*/

            /*3917*/
        }

        // gen! void SelectAll()
        /// <summary>
        /// Execute select all in this frame.
        /// /*cef()*/
        /// </summary>
        /*3918*/

        public void SelectAll()/*3919*/
        {
            JsValue ret;
            /*3920*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_SelectAll_8, out ret);
            /*3921*/

            /*3922*/
        }

        // gen! void ViewSource()
        /// <summary>
        /// Save this frame's HTML source to a temporary file and open it in the
        /// default text viewing application. This method can only be called from the
        /// browser process.
        /// /*cef()*/
        /// </summary>
        /*3923*/

        public void ViewSource()/*3924*/
        {
            JsValue ret;
            /*3925*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_ViewSource_9, out ret);
            /*3926*/

            /*3927*/
        }

        // gen! void GetSource(CefRefPtr<CefStringVisitor> visitor)
        /// <summary>
        /// Retrieve this frame's HTML source as a string sent to the specified
        /// visitor.
        /// /*cef()*/
        /// </summary>
        /*3928*/

        public void GetSource(CefStringVisitor /*3929*/
        visitor
        )/*3930*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr/*3931*/
            ;
            /*3932*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_GetSource_10, out ret, ref v1);
            /*3933*/

            /*3934*/
        }

        // gen! void GetText(CefRefPtr<CefStringVisitor> visitor)
        /// <summary>
        /// Retrieve this frame's display text as a string sent to the specified
        /// visitor.
        /// /*cef()*/
        /// </summary>
        /*3935*/

        public void GetText(CefStringVisitor /*3936*/
        visitor
        )/*3937*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr/*3938*/
            ;
            /*3939*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_GetText_11, out ret, ref v1);
            /*3940*/

            /*3941*/
        }

        // gen! void LoadRequest(CefRefPtr<CefRequest> request)
        /// <summary>
        /// Load the request represented by the |request| object.
        /// /*cef()*/
        /// </summary>
        /*3942*/

        public void LoadRequest(CefRequest /*3943*/
        request
        )/*3944*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = request.nativePtr/*3945*/
            ;
            /*3946*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_LoadRequest_12, out ret, ref v1);
            /*3947*/

            /*3948*/
        }

        // gen! void LoadURL(const CefString& url)
        /// <summary>
        /// Load the specified |url|.
        /// /*cef()*/
        /// </summary>
        /*3949*/

        public void LoadURL(string /*3950*/
        url
        )/*3951*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*3952*/
            ;
            /*3953*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_LoadURL_13, out ret, ref v1);
            /*3954*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3955*/
            ;
            /*3956*/
        }

        // gen! void LoadString(const CefString& string_val,const CefString& url)
        /// <summary>
        /// Load the contents of |string_val| with the specified dummy |url|. |url|
        /// should have a standard scheme (for example, http scheme) or behaviors like
        /// link clicks and web security restrictions may not behave as expected.
        /// /*cef()*/
        /// </summary>
        /*3957*/

        public void LoadString(string /*3958*/
        string_val
        , string /*3959*/
        url
        )/*3960*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(string_val);
            /*3961*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*3962*/
            ;
            /*3963*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefFrame_LoadString_14, out ret, ref v1, ref v2);
            /*3964*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3965*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*3966*/
            ;
            /*3967*/
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
        /*3968*/

        public void ExecuteJavaScript(string /*3969*/
        code
        , string /*3970*/
        script_url
        , int /*3971*/
        start_line
        )/*3972*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(code);
            /*3973*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(script_url);
            /*3974*/
            ;
            v3.I32 = (int)start_line/*3975*/
            ;
            /*3976*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefFrame_ExecuteJavaScript_15, out ret, ref v1, ref v2, ref v3);
            /*3977*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*3978*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*3979*/
            ;
            /*3980*/
        }

        // gen! bool IsMain()
        /// <summary>
        /// Returns true if this is the main (top-level) frame.
        /// /*cef()*/
        /// </summary>
        /*3981*/

        public bool IsMain()/*3982*/
        {
            JsValue ret;
            /*3983*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsMain_16, out ret);
            /*3984*/
            var ret_result = ret.I32 != 0;
            /*3985*/
            return ret_result;
            /*3986*/
        }

        // gen! bool IsFocused()
        /// <summary>
        /// Returns true if this is the focused frame.
        /// /*cef()*/
        /// </summary>
        /*3987*/

        public bool IsFocused()/*3988*/
        {
            JsValue ret;
            /*3989*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_IsFocused_17, out ret);
            /*3990*/
            var ret_result = ret.I32 != 0;
            /*3991*/
            return ret_result;
            /*3992*/
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
        /*3993*/

        public string GetName()/*3994*/
        {
            JsValue ret;
            /*3995*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetName_18, out ret);
            /*3996*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*3997*/
            return ret_result;
            /*3998*/
        }

        // gen! int64 GetIdentifier()
        /// <summary>
        /// Returns the globally unique identifier for this frame or < 0 if the
        /// underlying frame does not yet exist.
        /// /*cef()*/
        /// </summary>
        /*3999*/

        public long GetIdentifier()/*4000*/
        {
            JsValue ret;
            /*4001*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetIdentifier_19, out ret);
            /*4002*/
            var ret_result = ret.I64;
            /*4003*/
            return ret_result;
            /*4004*/
        }

        // gen! CefRefPtr<CefFrame> GetParent()
        /// <summary>
        /// Returns the parent of this frame or NULL if this is the main (top-level)
        /// frame.
        /// /*cef()*/
        /// </summary>
        /*4005*/

        public CefFrame GetParent()/*4006*/
        {
            JsValue ret;
            /*4007*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetParent_20, out ret);
            /*4008*/
            var ret_result = new CefFrame(ret.Ptr);
            /*4009*/
            return ret_result;
            /*4010*/
        }

        // gen! CefString GetURL()
        /// <summary>
        /// Returns the URL currently loaded in this frame.
        /// /*cef()*/
        /// </summary>
        /*4011*/

        public string GetURL()/*4012*/
        {
            JsValue ret;
            /*4013*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetURL_21, out ret);
            /*4014*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*4015*/
            return ret_result;
            /*4016*/
        }

        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /// <summary>
        /// Returns the browser that this frame belongs to.
        /// /*cef()*/
        /// </summary>
        /*4017*/

        public CefBrowser GetBrowser()/*4018*/
        {
            JsValue ret;
            /*4019*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetBrowser_22, out ret);
            /*4020*/
            var ret_result = new CefBrowser(ret.Ptr);
            /*4021*/
            return ret_result;
            /*4022*/
        }

        // gen! CefRefPtr<CefV8Context> GetV8Context()
        /// <summary>
        /// Get the V8 context associated with the frame. This method can only be
        /// called from the render process.
        /// /*cef()*/
        /// </summary>
        /*4023*/

        public CefV8Context GetV8Context()/*4024*/
        {
            JsValue ret;
            /*4025*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefFrame_GetV8Context_23, out ret);
            /*4026*/
            var ret_result = new CefV8Context(ret.Ptr);
            /*4027*/
            return ret_result;
            /*4028*/
        }

        // gen! void VisitDOM(CefRefPtr<CefDOMVisitor> visitor)
        /// <summary>
        /// Visit the DOM document. This method can only be called from the render
        /// process.
        /// /*cef()*/
        /// </summary>
        /*4029*/

        public void VisitDOM(CefDOMVisitor /*4030*/
        visitor
        )/*4031*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = visitor.nativePtr/*4032*/
            ;
            /*4033*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefFrame_VisitDOM_24, out ret, ref v1);
            /*4034*/

            /*4035*/
        }
        /*4036*/
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
    /*4110*/
    public struct CefImage
    {
        /*4111*/
        const int _typeNAME = 16;
        /*4112*/
        const int CefImage_Release_0 = (_typeNAME << 16) | 0;
        /*4113*/
        const int CefImage_IsEmpty_1 = (_typeNAME << 16) | 1;
        /*4114*/
        const int CefImage_IsSame_2 = (_typeNAME << 16) | 2;
        /*4115*/
        const int CefImage_AddBitmap_3 = (_typeNAME << 16) | 3;
        /*4116*/
        const int CefImage_AddPNG_4 = (_typeNAME << 16) | 4;
        /*4117*/
        const int CefImage_AddJPEG_5 = (_typeNAME << 16) | 5;
        /*4118*/
        const int CefImage_GetWidth_6 = (_typeNAME << 16) | 6;
        /*4119*/
        const int CefImage_GetHeight_7 = (_typeNAME << 16) | 7;
        /*4120*/
        const int CefImage_HasRepresentation_8 = (_typeNAME << 16) | 8;
        /*4121*/
        const int CefImage_RemoveRepresentation_9 = (_typeNAME << 16) | 9;
        /*4122*/
        const int CefImage_GetRepresentationInfo_10 = (_typeNAME << 16) | 10;
        /*4123*/
        const int CefImage_GetAsBitmap_11 = (_typeNAME << 16) | 11;
        /*4124*/
        const int CefImage_GetAsPNG_12 = (_typeNAME << 16) | 12;
        /*4125*/
        const int CefImage_GetAsJPEG_13 = (_typeNAME << 16) | 13;
        /*4126*/
        internal readonly IntPtr nativePtr;
        /*4127*/
        internal CefImage(IntPtr nativePtr)
        {
            /*4128*/
            this.nativePtr = nativePtr;
            /*4129*/
        }
        /*4130*/
        public void Release()
        {
            /*4131*/
            JsValue ret;
            /*4132*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_Release_0, out ret);
            /*4133*/
        }

        // gen! bool IsEmpty()
        /// <summary>
        /// CefImage methods.
        /// </summary>
        /*4134*/

        public bool IsEmpty()/*4135*/
        {
            JsValue ret;
            /*4136*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_IsEmpty_1, out ret);
            /*4137*/
            var ret_result = ret.I32 != 0;
            /*4138*/
            return ret_result;
            /*4139*/
        }

        // gen! bool IsSame(CefRefPtr<CefImage> that)
        /// <summary>
        /// Returns true if this Image and |that| Image share the same underlying
        /// storage. Will also return true if both images are empty.
        /// /*cef()*/
        /// </summary>
        /*4140*/

        public bool IsSame(CefImage /*4141*/
        that
        )/*4142*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr/*4143*/
            ;
            /*4144*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_IsSame_2, out ret, ref v1);
            /*4145*/
            var ret_result = ret.I32 != 0;
            /*4146*/
            return ret_result;
            /*4147*/
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
        /*4148*/

        public bool AddBitmap(float /*4149*/
        scale_factor
        , int /*4150*/
        pixel_width
        , int /*4151*/
        pixel_height
        , cef_color_type_t /*4152*/
        color_type
        , cef_alpha_type_t /*4153*/
        alpha_type
        , IntPtr /*4154*/
        pixel_data
        , uint /*4155*/
        pixel_data_size
        )/*4156*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue v6 = new JsValue();
            JsValue v7 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor/*4157*/
            ;
            v2.I32 = (int)pixel_width/*4158*/
            ;
            v3.I32 = (int)pixel_height/*4159*/
            ;
            v4.I32 = (int)color_type/*4160*/
            ;
            v5.I32 = (int)alpha_type/*4161*/
            ;
            v6.Ptr = pixel_data/*4162*/
            ;
            v7.I32 = (int)pixel_data_size/*4163*/
            ;
            /*4164*/

            Cef3Binder.MyCefMet_Call7(this.nativePtr, CefImage_AddBitmap_3, out ret, ref v1, ref v2, ref v3, ref v4, ref v5, ref v6, ref v7);
            /*4165*/
            var ret_result = ret.I32 != 0;
            /*4166*/
            return ret_result;
            /*4167*/
        }

        // gen! bool AddPNG(float scale_factor,const void* png_data,size_t png_data_size)
        /// <summary>
        /// Add a PNG image representation for |scale_factor|. |png_data| is the image
        /// data of size |png_data_size|. Any alpha transparency in the PNG data will
        /// be maintained.
        /// /*cef()*/
        /// </summary>
        /*4168*/

        public bool AddPNG(float /*4169*/
        scale_factor
        , IntPtr /*4170*/
        png_data
        , uint /*4171*/
        png_data_size
        )/*4172*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor/*4173*/
            ;
            v2.Ptr = png_data/*4174*/
            ;
            v3.I32 = (int)png_data_size/*4175*/
            ;
            /*4176*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefImage_AddPNG_4, out ret, ref v1, ref v2, ref v3);
            /*4177*/
            var ret_result = ret.I32 != 0;
            /*4178*/
            return ret_result;
            /*4179*/
        }

        // gen! bool AddJPEG(float scale_factor,const void* jpeg_data,size_t jpeg_data_size)
        /// <summary>
        /// Create a JPEG image representation for |scale_factor|. |jpeg_data| is the
        /// image data of size |jpeg_data_size|. The JPEG format does not support
        /// transparency so the alpha byte will be set to 0xFF for all pixels.
        /// /*cef()*/
        /// </summary>
        /*4180*/

        public bool AddJPEG(float /*4181*/
        scale_factor
        , IntPtr /*4182*/
        jpeg_data
        , uint /*4183*/
        jpeg_data_size
        )/*4184*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor/*4185*/
            ;
            v2.Ptr = jpeg_data/*4186*/
            ;
            v3.I32 = (int)jpeg_data_size/*4187*/
            ;
            /*4188*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefImage_AddJPEG_5, out ret, ref v1, ref v2, ref v3);
            /*4189*/
            var ret_result = ret.I32 != 0;
            /*4190*/
            return ret_result;
            /*4191*/
        }

        // gen! size_t GetWidth()
        /// <summary>
        /// Returns the image width in density independent pixel (DIP) units.
        /// /*cef()*/
        /// </summary>
        /*4192*/

        public uint GetWidth()/*4193*/
        {
            JsValue ret;
            /*4194*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_GetWidth_6, out ret);
            /*4195*/
            var ret_result = (uint)ret.I32;
            /*4196*/
            return ret_result;
            /*4197*/
        }

        // gen! size_t GetHeight()
        /// <summary>
        /// Returns the image height in density independent pixel (DIP) units.
        /// /*cef()*/
        /// </summary>
        /*4198*/

        public uint GetHeight()/*4199*/
        {
            JsValue ret;
            /*4200*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefImage_GetHeight_7, out ret);
            /*4201*/
            var ret_result = (uint)ret.I32;
            /*4202*/
            return ret_result;
            /*4203*/
        }

        // gen! bool HasRepresentation(float scale_factor)
        /// <summary>
        /// Returns true if this image contains a representation for |scale_factor|.
        /// /*cef()*/
        /// </summary>
        /*4204*/

        public bool HasRepresentation(float /*4205*/
        scale_factor
        )/*4206*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor/*4207*/
            ;
            /*4208*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_HasRepresentation_8, out ret, ref v1);
            /*4209*/
            var ret_result = ret.I32 != 0;
            /*4210*/
            return ret_result;
            /*4211*/
        }

        // gen! bool RemoveRepresentation(float scale_factor)
        /// <summary>
        /// Removes the representation for |scale_factor|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4212*/

        public bool RemoveRepresentation(float /*4213*/
        scale_factor
        )/*4214*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor/*4215*/
            ;
            /*4216*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefImage_RemoveRepresentation_9, out ret, ref v1);
            /*4217*/
            var ret_result = ret.I32 != 0;
            /*4218*/
            return ret_result;
            /*4219*/
        }

        // gen! bool GetRepresentationInfo(float scale_factor,float& actual_scale_factor,int& pixel_width,int& pixel_height)
        /// <summary>
        /// Returns information for the representation that most closely matches
        /// |scale_factor|. |actual_scale_factor| is the actual scale factor for the
        /// representation. |pixel_width| and |pixel_height| are the representation
        /// size in pixel coordinates. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4220*/

        public bool GetRepresentationInfo(float /*4221*/
        scale_factor
        , ref float /*4222*/
        actual_scale_factor
        , ref int /*4223*/
        pixel_width
        , ref int /*4224*/
        pixel_height
        )/*4225*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor/*4226*/
            ;
            v2.Num = actual_scale_factor/*4227*/
            ;
            v3.I32 = pixel_width/*4228*/
            ;
            v4.I32 = pixel_height/*4229*/
            ;
            /*4230*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetRepresentationInfo_10, out ret, ref v1, ref v2, ref v3, ref v4);
            /*4231*/
            var ret_result = ret.I32 != 0;
            actual_scale_factor = (float)v2.Num;/*4232*/
            ;
            pixel_width = (int)v3.I32;/*4233*/
            ;
            pixel_height = (int)v4.I32;/*4234*/
            ;
            /*4235*/
            return ret_result;
            /*4236*/
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
        /*4237*/

        public CefBinaryValue GetAsBitmap(float /*4238*/
        scale_factor
        , cef_color_type_t /*4239*/
        color_type
        , cef_alpha_type_t /*4240*/
        alpha_type
        , ref int /*4241*/
        pixel_width
        , ref int /*4242*/
        pixel_height
        )/*4243*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor/*4244*/
            ;
            v2.I32 = (int)color_type/*4245*/
            ;
            v3.I32 = (int)alpha_type/*4246*/
            ;
            v4.I32 = pixel_width/*4247*/
            ;
            v5.I32 = pixel_height/*4248*/
            ;
            /*4249*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefImage_GetAsBitmap_11, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*4250*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            pixel_width = (int)v4.I32;/*4251*/
            ;
            pixel_height = (int)v5.I32;/*4252*/
            ;
            /*4253*/
            return ret_result;
            /*4254*/
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
        /*4255*/

        public CefBinaryValue GetAsPNG(float /*4256*/
        scale_factor
        , bool /*4257*/
        with_transparency
        , ref int /*4258*/
        pixel_width
        , ref int /*4259*/
        pixel_height
        )/*4260*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor/*4261*/
            ;
            v2.I32 = with_transparency ? 1 : 0/*4262*/
            ;
            v3.I32 = pixel_width/*4263*/
            ;
            v4.I32 = pixel_height/*4264*/
            ;
            /*4265*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetAsPNG_12, out ret, ref v1, ref v2, ref v3, ref v4);
            /*4266*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            pixel_width = (int)v3.I32;/*4267*/
            ;
            pixel_height = (int)v4.I32;/*4268*/
            ;
            /*4269*/
            return ret_result;
            /*4270*/
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
        /*4271*/

        public CefBinaryValue GetAsJPEG(float /*4272*/
        scale_factor
        , int /*4273*/
        quality
        , ref int /*4274*/
        pixel_width
        , ref int /*4275*/
        pixel_height
        )/*4276*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Num = scale_factor/*4277*/
            ;
            v2.I32 = (int)quality/*4278*/
            ;
            v3.I32 = pixel_width/*4279*/
            ;
            v4.I32 = pixel_height/*4280*/
            ;
            /*4281*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefImage_GetAsJPEG_13, out ret, ref v1, ref v2, ref v3, ref v4);
            /*4282*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            pixel_width = (int)v3.I32;/*4283*/
            ;
            pixel_height = (int)v4.I32;/*4284*/
            ;
            /*4285*/
            return ret_result;
            /*4286*/
        }
        /*4287*/
    }


    // [virtual] class CefMenuModel
    /// <summary>
    /// Supports creation and modification of menus. See cef_menu_id_t for the
    /// command ids that have default implementations. All user-defined command ids
    /// should be between MENU_ID_USER_FIRST and MENU_ID_USER_LAST. The methods of
    /// this class can only be accessed on the browser process the UI thread.
    /// /*(source=library)*/
    /// </summary>
    /*4576*/
    public struct CefMenuModel
    {
        /*4577*/
        const int _typeNAME = 17;
        /*4578*/
        const int CefMenuModel_Release_0 = (_typeNAME << 16) | 0;
        /*4579*/
        const int CefMenuModel_IsSubMenu_1 = (_typeNAME << 16) | 1;
        /*4580*/
        const int CefMenuModel_Clear_2 = (_typeNAME << 16) | 2;
        /*4581*/
        const int CefMenuModel_GetCount_3 = (_typeNAME << 16) | 3;
        /*4582*/
        const int CefMenuModel_AddSeparator_4 = (_typeNAME << 16) | 4;
        /*4583*/
        const int CefMenuModel_AddItem_5 = (_typeNAME << 16) | 5;
        /*4584*/
        const int CefMenuModel_AddCheckItem_6 = (_typeNAME << 16) | 6;
        /*4585*/
        const int CefMenuModel_AddRadioItem_7 = (_typeNAME << 16) | 7;
        /*4586*/
        const int CefMenuModel_AddSubMenu_8 = (_typeNAME << 16) | 8;
        /*4587*/
        const int CefMenuModel_InsertSeparatorAt_9 = (_typeNAME << 16) | 9;
        /*4588*/
        const int CefMenuModel_InsertItemAt_10 = (_typeNAME << 16) | 10;
        /*4589*/
        const int CefMenuModel_InsertCheckItemAt_11 = (_typeNAME << 16) | 11;
        /*4590*/
        const int CefMenuModel_InsertRadioItemAt_12 = (_typeNAME << 16) | 12;
        /*4591*/
        const int CefMenuModel_InsertSubMenuAt_13 = (_typeNAME << 16) | 13;
        /*4592*/
        const int CefMenuModel_Remove_14 = (_typeNAME << 16) | 14;
        /*4593*/
        const int CefMenuModel_RemoveAt_15 = (_typeNAME << 16) | 15;
        /*4594*/
        const int CefMenuModel_GetIndexOf_16 = (_typeNAME << 16) | 16;
        /*4595*/
        const int CefMenuModel_GetCommandIdAt_17 = (_typeNAME << 16) | 17;
        /*4596*/
        const int CefMenuModel_SetCommandIdAt_18 = (_typeNAME << 16) | 18;
        /*4597*/
        const int CefMenuModel_GetLabel_19 = (_typeNAME << 16) | 19;
        /*4598*/
        const int CefMenuModel_GetLabelAt_20 = (_typeNAME << 16) | 20;
        /*4599*/
        const int CefMenuModel_SetLabel_21 = (_typeNAME << 16) | 21;
        /*4600*/
        const int CefMenuModel_SetLabelAt_22 = (_typeNAME << 16) | 22;
        /*4601*/
        const int CefMenuModel_GetType_23 = (_typeNAME << 16) | 23;
        /*4602*/
        const int CefMenuModel_GetTypeAt_24 = (_typeNAME << 16) | 24;
        /*4603*/
        const int CefMenuModel_GetGroupId_25 = (_typeNAME << 16) | 25;
        /*4604*/
        const int CefMenuModel_GetGroupIdAt_26 = (_typeNAME << 16) | 26;
        /*4605*/
        const int CefMenuModel_SetGroupId_27 = (_typeNAME << 16) | 27;
        /*4606*/
        const int CefMenuModel_SetGroupIdAt_28 = (_typeNAME << 16) | 28;
        /*4607*/
        const int CefMenuModel_GetSubMenu_29 = (_typeNAME << 16) | 29;
        /*4608*/
        const int CefMenuModel_GetSubMenuAt_30 = (_typeNAME << 16) | 30;
        /*4609*/
        const int CefMenuModel_IsVisible_31 = (_typeNAME << 16) | 31;
        /*4610*/
        const int CefMenuModel_IsVisibleAt_32 = (_typeNAME << 16) | 32;
        /*4611*/
        const int CefMenuModel_SetVisible_33 = (_typeNAME << 16) | 33;
        /*4612*/
        const int CefMenuModel_SetVisibleAt_34 = (_typeNAME << 16) | 34;
        /*4613*/
        const int CefMenuModel_IsEnabled_35 = (_typeNAME << 16) | 35;
        /*4614*/
        const int CefMenuModel_IsEnabledAt_36 = (_typeNAME << 16) | 36;
        /*4615*/
        const int CefMenuModel_SetEnabled_37 = (_typeNAME << 16) | 37;
        /*4616*/
        const int CefMenuModel_SetEnabledAt_38 = (_typeNAME << 16) | 38;
        /*4617*/
        const int CefMenuModel_IsChecked_39 = (_typeNAME << 16) | 39;
        /*4618*/
        const int CefMenuModel_IsCheckedAt_40 = (_typeNAME << 16) | 40;
        /*4619*/
        const int CefMenuModel_SetChecked_41 = (_typeNAME << 16) | 41;
        /*4620*/
        const int CefMenuModel_SetCheckedAt_42 = (_typeNAME << 16) | 42;
        /*4621*/
        const int CefMenuModel_HasAccelerator_43 = (_typeNAME << 16) | 43;
        /*4622*/
        const int CefMenuModel_HasAcceleratorAt_44 = (_typeNAME << 16) | 44;
        /*4623*/
        const int CefMenuModel_SetAccelerator_45 = (_typeNAME << 16) | 45;
        /*4624*/
        const int CefMenuModel_SetAcceleratorAt_46 = (_typeNAME << 16) | 46;
        /*4625*/
        const int CefMenuModel_RemoveAccelerator_47 = (_typeNAME << 16) | 47;
        /*4626*/
        const int CefMenuModel_RemoveAcceleratorAt_48 = (_typeNAME << 16) | 48;
        /*4627*/
        const int CefMenuModel_GetAccelerator_49 = (_typeNAME << 16) | 49;
        /*4628*/
        const int CefMenuModel_GetAcceleratorAt_50 = (_typeNAME << 16) | 50;
        /*4629*/
        const int CefMenuModel_SetColor_51 = (_typeNAME << 16) | 51;
        /*4630*/
        const int CefMenuModel_SetColorAt_52 = (_typeNAME << 16) | 52;
        /*4631*/
        const int CefMenuModel_GetColor_53 = (_typeNAME << 16) | 53;
        /*4632*/
        const int CefMenuModel_GetColorAt_54 = (_typeNAME << 16) | 54;
        /*4633*/
        const int CefMenuModel_SetFontList_55 = (_typeNAME << 16) | 55;
        /*4634*/
        const int CefMenuModel_SetFontListAt_56 = (_typeNAME << 16) | 56;
        /*4635*/
        internal readonly IntPtr nativePtr;
        /*4636*/
        internal CefMenuModel(IntPtr nativePtr)
        {
            /*4637*/
            this.nativePtr = nativePtr;
            /*4638*/
        }
        /*4639*/
        public void Release()
        {
            /*4640*/
            JsValue ret;
            /*4641*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_Release_0, out ret);
            /*4642*/
        }

        // gen! bool IsSubMenu()
        /// <summary>
        /// CefMenuModel methods.
        /// </summary>
        /*4643*/

        public bool IsSubMenu()/*4644*/
        {
            JsValue ret;
            /*4645*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_IsSubMenu_1, out ret);
            /*4646*/
            var ret_result = ret.I32 != 0;
            /*4647*/
            return ret_result;
            /*4648*/
        }

        // gen! bool Clear()
        /// <summary>
        /// Clears the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4649*/

        public bool Clear()/*4650*/
        {
            JsValue ret;
            /*4651*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_Clear_2, out ret);
            /*4652*/
            var ret_result = ret.I32 != 0;
            /*4653*/
            return ret_result;
            /*4654*/
        }

        // gen! int GetCount()
        /// <summary>
        /// Returns the number of items in this menu.
        /// /*cef()*/
        /// </summary>
        /*4655*/

        public int GetCount()/*4656*/
        {
            JsValue ret;
            /*4657*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_GetCount_3, out ret);
            /*4658*/
            var ret_result = ret.I32;
            /*4659*/
            return ret_result;
            /*4660*/
        }

        // gen! bool AddSeparator()
        /// <summary>
        /// Add a separator to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4661*/

        public bool AddSeparator()/*4662*/
        {
            JsValue ret;
            /*4663*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModel_AddSeparator_4, out ret);
            /*4664*/
            var ret_result = ret.I32 != 0;
            /*4665*/
            return ret_result;
            /*4666*/
        }

        // gen! bool AddItem(int command_id,const CefString& label)
        /// <summary>
        /// Add an item to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4667*/

        public bool AddItem(int /*4668*/
        command_id
        , string /*4669*/
        label
        )/*4670*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4671*/
            ;
            v1.I32 = (int)command_id/*4672*/
            ;
            /*4673*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddItem_5, out ret, ref v1, ref v2);
            /*4674*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4675*/
            ;
            /*4676*/
            return ret_result;
            /*4677*/
        }

        // gen! bool AddCheckItem(int command_id,const CefString& label)
        /// <summary>
        /// Add a check item to the menu. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4678*/

        public bool AddCheckItem(int /*4679*/
        command_id
        , string /*4680*/
        label
        )/*4681*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4682*/
            ;
            v1.I32 = (int)command_id/*4683*/
            ;
            /*4684*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddCheckItem_6, out ret, ref v1, ref v2);
            /*4685*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4686*/
            ;
            /*4687*/
            return ret_result;
            /*4688*/
        }

        // gen! bool AddRadioItem(int command_id,const CefString& label,int group_id)
        /// <summary>
        /// Add a radio item to the menu. Only a single item with the specified
        /// |group_id| can be checked at a time. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4689*/

        public bool AddRadioItem(int /*4690*/
        command_id
        , string /*4691*/
        label
        , int /*4692*/
        group_id
        )/*4693*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4694*/
            ;
            v1.I32 = (int)command_id/*4695*/
            ;
            v3.I32 = (int)group_id/*4696*/
            ;
            /*4697*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_AddRadioItem_7, out ret, ref v1, ref v2, ref v3);
            /*4698*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4699*/
            ;
            /*4700*/
            return ret_result;
            /*4701*/
        }

        // gen! CefRefPtr<CefMenuModel> AddSubMenu(int command_id,const CefString& label)
        /// <summary>
        /// Add a sub-menu to the menu. The new sub-menu is returned.
        /// /*cef()*/
        /// </summary>
        /*4702*/

        public CefMenuModel AddSubMenu(int /*4703*/
        command_id
        , string /*4704*/
        label
        )/*4705*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4706*/
            ;
            v1.I32 = (int)command_id/*4707*/
            ;
            /*4708*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_AddSubMenu_8, out ret, ref v1, ref v2);
            /*4709*/
            var ret_result = new CefMenuModel(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4710*/
            ;
            /*4711*/
            return ret_result;
            /*4712*/
        }

        // gen! bool InsertSeparatorAt(int index)
        /// <summary>
        /// Insert a separator in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4713*/

        public bool InsertSeparatorAt(int /*4714*/
        index
        )/*4715*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*4716*/
            ;
            /*4717*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_InsertSeparatorAt_9, out ret, ref v1);
            /*4718*/
            var ret_result = ret.I32 != 0;
            /*4719*/
            return ret_result;
            /*4720*/
        }

        // gen! bool InsertItemAt(int index,int command_id,const CefString& label)
        /// <summary>
        /// Insert an item in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4721*/

        public bool InsertItemAt(int /*4722*/
        index
        , int /*4723*/
        command_id
        , string /*4724*/
        label
        )/*4725*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4726*/
            ;
            v1.I32 = (int)index/*4727*/
            ;
            v2.I32 = (int)command_id/*4728*/
            ;
            /*4729*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertItemAt_10, out ret, ref v1, ref v2, ref v3);
            /*4730*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*4731*/
            ;
            /*4732*/
            return ret_result;
            /*4733*/
        }

        // gen! bool InsertCheckItemAt(int index,int command_id,const CefString& label)
        /// <summary>
        /// Insert a check item in the menu at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4734*/

        public bool InsertCheckItemAt(int /*4735*/
        index
        , int /*4736*/
        command_id
        , string /*4737*/
        label
        )/*4738*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4739*/
            ;
            v1.I32 = (int)index/*4740*/
            ;
            v2.I32 = (int)command_id/*4741*/
            ;
            /*4742*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertCheckItemAt_11, out ret, ref v1, ref v2, ref v3);
            /*4743*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*4744*/
            ;
            /*4745*/
            return ret_result;
            /*4746*/
        }

        // gen! bool InsertRadioItemAt(int index,int command_id,const CefString& label,int group_id)
        /// <summary>
        /// Insert a radio item in the menu at the specified |index|. Only a single
        /// item with the specified |group_id| can be checked at a time. Returns true
        /// on success.
        /// /*cef()*/
        /// </summary>
        /*4747*/

        public bool InsertRadioItemAt(int /*4748*/
        index
        , int /*4749*/
        command_id
        , string /*4750*/
        label
        , int /*4751*/
        group_id
        )/*4752*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4753*/
            ;
            v1.I32 = (int)index/*4754*/
            ;
            v2.I32 = (int)command_id/*4755*/
            ;
            v4.I32 = (int)group_id/*4756*/
            ;
            /*4757*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefMenuModel_InsertRadioItemAt_12, out ret, ref v1, ref v2, ref v3, ref v4);
            /*4758*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*4759*/
            ;
            /*4760*/
            return ret_result;
            /*4761*/
        }

        // gen! CefRefPtr<CefMenuModel> InsertSubMenuAt(int index,int command_id,const CefString& label)
        /// <summary>
        /// Insert a sub-menu in the menu at the specified |index|. The new sub-menu
        /// is returned.
        /// /*cef()*/
        /// </summary>
        /*4762*/

        public CefMenuModel InsertSubMenuAt(int /*4763*/
        index
        , int /*4764*/
        command_id
        , string /*4765*/
        label
        )/*4766*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4767*/
            ;
            v1.I32 = (int)index/*4768*/
            ;
            v2.I32 = (int)command_id/*4769*/
            ;
            /*4770*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_InsertSubMenuAt_13, out ret, ref v1, ref v2, ref v3);
            /*4771*/
            var ret_result = new CefMenuModel(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*4772*/
            ;
            /*4773*/
            return ret_result;
            /*4774*/
        }

        // gen! bool Remove(int command_id)
        /// <summary>
        /// Removes the item with the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4775*/

        public bool Remove(int /*4776*/
        command_id
        )/*4777*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*4778*/
            ;
            /*4779*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_Remove_14, out ret, ref v1);
            /*4780*/
            var ret_result = ret.I32 != 0;
            /*4781*/
            return ret_result;
            /*4782*/
        }

        // gen! bool RemoveAt(int index)
        /// <summary>
        /// Removes the item at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4783*/

        public bool RemoveAt(int /*4784*/
        index
        )/*4785*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*4786*/
            ;
            /*4787*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAt_15, out ret, ref v1);
            /*4788*/
            var ret_result = ret.I32 != 0;
            /*4789*/
            return ret_result;
            /*4790*/
        }

        // gen! int GetIndexOf(int command_id)
        /// <summary>
        /// Returns the index associated with the specified |command_id| or -1 if not
        /// found due to the command id not existing in the menu.
        /// /*cef()*/
        /// </summary>
        /*4791*/

        public int GetIndexOf(int /*4792*/
        command_id
        )/*4793*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*4794*/
            ;
            /*4795*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetIndexOf_16, out ret, ref v1);
            /*4796*/
            var ret_result = ret.I32;
            /*4797*/
            return ret_result;
            /*4798*/
        }

        // gen! int GetCommandIdAt(int index)
        /// <summary>
        /// Returns the command id at the specified |index| or -1 if not found due to
        /// invalid range or the index being a separator.
        /// /*cef()*/
        /// </summary>
        /*4799*/

        public int GetCommandIdAt(int /*4800*/
        index
        )/*4801*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*4802*/
            ;
            /*4803*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetCommandIdAt_17, out ret, ref v1);
            /*4804*/
            var ret_result = ret.I32;
            /*4805*/
            return ret_result;
            /*4806*/
        }

        // gen! bool SetCommandIdAt(int index,int command_id)
        /// <summary>
        /// Sets the command id at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4807*/

        public bool SetCommandIdAt(int /*4808*/
        index
        , int /*4809*/
        command_id
        )/*4810*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*4811*/
            ;
            v2.I32 = (int)command_id/*4812*/
            ;
            /*4813*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetCommandIdAt_18, out ret, ref v1, ref v2);
            /*4814*/
            var ret_result = ret.I32 != 0;
            /*4815*/
            return ret_result;
            /*4816*/
        }

        // gen! CefString GetLabel(int command_id)
        /// <summary>
        /// Returns the label for the specified |command_id| or empty if not found.
        /// /*cef()*/
        /// </summary>
        /*4817*/

        public string GetLabel(int /*4818*/
        command_id
        )/*4819*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*4820*/
            ;
            /*4821*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetLabel_19, out ret, ref v1);
            /*4822*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*4823*/
            return ret_result;
            /*4824*/
        }

        // gen! CefString GetLabelAt(int index)
        /// <summary>
        /// Returns the label at the specified |index| or empty if not found due to
        /// invalid range or the index being a separator.
        /// /*cef()*/
        /// </summary>
        /*4825*/

        public string GetLabelAt(int /*4826*/
        index
        )/*4827*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*4828*/
            ;
            /*4829*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetLabelAt_20, out ret, ref v1);
            /*4830*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*4831*/
            return ret_result;
            /*4832*/
        }

        // gen! bool SetLabel(int command_id,const CefString& label)
        /// <summary>
        /// Sets the label for the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4833*/

        public bool SetLabel(int /*4834*/
        command_id
        , string /*4835*/
        label
        )/*4836*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4837*/
            ;
            v1.I32 = (int)command_id/*4838*/
            ;
            /*4839*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetLabel_21, out ret, ref v1, ref v2);
            /*4840*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4841*/
            ;
            /*4842*/
            return ret_result;
            /*4843*/
        }

        // gen! bool SetLabelAt(int index,const CefString& label)
        /// <summary>
        /// Set the label at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4844*/

        public bool SetLabelAt(int /*4845*/
        index
        , string /*4846*/
        label
        )/*4847*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(label);
            /*4848*/
            ;
            v1.I32 = (int)index/*4849*/
            ;
            /*4850*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetLabelAt_22, out ret, ref v1, ref v2);
            /*4851*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*4852*/
            ;
            /*4853*/
            return ret_result;
            /*4854*/
        }

        // gen! MenuItemType GetType(int command_id)
        /// <summary>
        /// Returns the item type for the specified |command_id|.
        /// /*cef(default_retval=MENUITEMTYPE_NONE)*/
        /// </summary>
        /*4855*/

        public cef_menu_item_type_t _GetType(int /*4856*/
        command_id
        )/*4857*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*4858*/
            ;
            /*4859*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetType_23, out ret, ref v1);
            /*4860*/
            var ret_result = (cef_menu_item_type_t)ret.I32;

            /*4861*/
            return ret_result;
            /*4862*/
        }

        // gen! MenuItemType GetTypeAt(int index)
        /// <summary>
        /// Returns the item type at the specified |index|.
        /// /*cef(default_retval=MENUITEMTYPE_NONE)*/
        /// </summary>
        /*4863*/

        public cef_menu_item_type_t GetTypeAt(int /*4864*/
        index
        )/*4865*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*4866*/
            ;
            /*4867*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetTypeAt_24, out ret, ref v1);
            /*4868*/
            var ret_result = (cef_menu_item_type_t)ret.I32;

            /*4869*/
            return ret_result;
            /*4870*/
        }

        // gen! int GetGroupId(int command_id)
        /// <summary>
        /// Returns the group id for the specified |command_id| or -1 if invalid.
        /// /*cef()*/
        /// </summary>
        /*4871*/

        public int GetGroupId(int /*4872*/
        command_id
        )/*4873*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*4874*/
            ;
            /*4875*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetGroupId_25, out ret, ref v1);
            /*4876*/
            var ret_result = ret.I32;
            /*4877*/
            return ret_result;
            /*4878*/
        }

        // gen! int GetGroupIdAt(int index)
        /// <summary>
        /// Returns the group id at the specified |index| or -1 if invalid.
        /// /*cef()*/
        /// </summary>
        /*4879*/

        public int GetGroupIdAt(int /*4880*/
        index
        )/*4881*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*4882*/
            ;
            /*4883*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetGroupIdAt_26, out ret, ref v1);
            /*4884*/
            var ret_result = ret.I32;
            /*4885*/
            return ret_result;
            /*4886*/
        }

        // gen! bool SetGroupId(int command_id,int group_id)
        /// <summary>
        /// Sets the group id for the specified |command_id|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4887*/

        public bool SetGroupId(int /*4888*/
        command_id
        , int /*4889*/
        group_id
        )/*4890*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*4891*/
            ;
            v2.I32 = (int)group_id/*4892*/
            ;
            /*4893*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetGroupId_27, out ret, ref v1, ref v2);
            /*4894*/
            var ret_result = ret.I32 != 0;
            /*4895*/
            return ret_result;
            /*4896*/
        }

        // gen! bool SetGroupIdAt(int index,int group_id)
        /// <summary>
        /// Sets the group id at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4897*/

        public bool SetGroupIdAt(int /*4898*/
        index
        , int /*4899*/
        group_id
        )/*4900*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*4901*/
            ;
            v2.I32 = (int)group_id/*4902*/
            ;
            /*4903*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetGroupIdAt_28, out ret, ref v1, ref v2);
            /*4904*/
            var ret_result = ret.I32 != 0;
            /*4905*/
            return ret_result;
            /*4906*/
        }

        // gen! CefRefPtr<CefMenuModel> GetSubMenu(int command_id)
        /// <summary>
        /// Returns the submenu for the specified |command_id| or empty if invalid.
        /// /*cef()*/
        /// </summary>
        /*4907*/

        public CefMenuModel GetSubMenu(int /*4908*/
        command_id
        )/*4909*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*4910*/
            ;
            /*4911*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetSubMenu_29, out ret, ref v1);
            /*4912*/
            var ret_result = new CefMenuModel(ret.Ptr);
            /*4913*/
            return ret_result;
            /*4914*/
        }

        // gen! CefRefPtr<CefMenuModel> GetSubMenuAt(int index)
        /// <summary>
        /// Returns the submenu at the specified |index| or empty if invalid.
        /// /*cef()*/
        /// </summary>
        /*4915*/

        public CefMenuModel GetSubMenuAt(int /*4916*/
        index
        )/*4917*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*4918*/
            ;
            /*4919*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_GetSubMenuAt_30, out ret, ref v1);
            /*4920*/
            var ret_result = new CefMenuModel(ret.Ptr);
            /*4921*/
            return ret_result;
            /*4922*/
        }

        // gen! bool IsVisible(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| is visible.
        /// /*cef()*/
        /// </summary>
        /*4923*/

        public bool IsVisible(int /*4924*/
        command_id
        )/*4925*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*4926*/
            ;
            /*4927*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsVisible_31, out ret, ref v1);
            /*4928*/
            var ret_result = ret.I32 != 0;
            /*4929*/
            return ret_result;
            /*4930*/
        }

        // gen! bool IsVisibleAt(int index)
        /// <summary>
        /// Returns true if the specified |index| is visible.
        /// /*cef()*/
        /// </summary>
        /*4931*/

        public bool IsVisibleAt(int /*4932*/
        index
        )/*4933*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*4934*/
            ;
            /*4935*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsVisibleAt_32, out ret, ref v1);
            /*4936*/
            var ret_result = ret.I32 != 0;
            /*4937*/
            return ret_result;
            /*4938*/
        }

        // gen! bool SetVisible(int command_id,bool visible)
        /// <summary>
        /// Change the visibility of the specified |command_id|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4939*/

        public bool SetVisible(int /*4940*/
        command_id
        , bool /*4941*/
        visible
        )/*4942*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*4943*/
            ;
            v2.I32 = visible ? 1 : 0/*4944*/
            ;
            /*4945*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetVisible_33, out ret, ref v1, ref v2);
            /*4946*/
            var ret_result = ret.I32 != 0;
            /*4947*/
            return ret_result;
            /*4948*/
        }

        // gen! bool SetVisibleAt(int index,bool visible)
        /// <summary>
        /// Change the visibility at the specified |index|. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*4949*/

        public bool SetVisibleAt(int /*4950*/
        index
        , bool /*4951*/
        visible
        )/*4952*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*4953*/
            ;
            v2.I32 = visible ? 1 : 0/*4954*/
            ;
            /*4955*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetVisibleAt_34, out ret, ref v1, ref v2);
            /*4956*/
            var ret_result = ret.I32 != 0;
            /*4957*/
            return ret_result;
            /*4958*/
        }

        // gen! bool IsEnabled(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| is enabled.
        /// /*cef()*/
        /// </summary>
        /*4959*/

        public bool IsEnabled(int /*4960*/
        command_id
        )/*4961*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*4962*/
            ;
            /*4963*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsEnabled_35, out ret, ref v1);
            /*4964*/
            var ret_result = ret.I32 != 0;
            /*4965*/
            return ret_result;
            /*4966*/
        }

        // gen! bool IsEnabledAt(int index)
        /// <summary>
        /// Returns true if the specified |index| is enabled.
        /// /*cef()*/
        /// </summary>
        /*4967*/

        public bool IsEnabledAt(int /*4968*/
        index
        )/*4969*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*4970*/
            ;
            /*4971*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsEnabledAt_36, out ret, ref v1);
            /*4972*/
            var ret_result = ret.I32 != 0;
            /*4973*/
            return ret_result;
            /*4974*/
        }

        // gen! bool SetEnabled(int command_id,bool enabled)
        /// <summary>
        /// Change the enabled status of the specified |command_id|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4975*/

        public bool SetEnabled(int /*4976*/
        command_id
        , bool /*4977*/
        enabled
        )/*4978*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*4979*/
            ;
            v2.I32 = enabled ? 1 : 0/*4980*/
            ;
            /*4981*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetEnabled_37, out ret, ref v1, ref v2);
            /*4982*/
            var ret_result = ret.I32 != 0;
            /*4983*/
            return ret_result;
            /*4984*/
        }

        // gen! bool SetEnabledAt(int index,bool enabled)
        /// <summary>
        /// Change the enabled status at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*4985*/

        public bool SetEnabledAt(int /*4986*/
        index
        , bool /*4987*/
        enabled
        )/*4988*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*4989*/
            ;
            v2.I32 = enabled ? 1 : 0/*4990*/
            ;
            /*4991*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetEnabledAt_38, out ret, ref v1, ref v2);
            /*4992*/
            var ret_result = ret.I32 != 0;
            /*4993*/
            return ret_result;
            /*4994*/
        }

        // gen! bool IsChecked(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| is checked. Only applies to
        /// check and radio items.
        /// /*cef()*/
        /// </summary>
        /*4995*/

        public bool IsChecked(int /*4996*/
        command_id
        )/*4997*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*4998*/
            ;
            /*4999*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsChecked_39, out ret, ref v1);
            /*5000*/
            var ret_result = ret.I32 != 0;
            /*5001*/
            return ret_result;
            /*5002*/
        }

        // gen! bool IsCheckedAt(int index)
        /// <summary>
        /// Returns true if the specified |index| is checked. Only applies to check
        /// and radio items.
        /// /*cef()*/
        /// </summary>
        /*5003*/

        public bool IsCheckedAt(int /*5004*/
        index
        )/*5005*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*5006*/
            ;
            /*5007*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_IsCheckedAt_40, out ret, ref v1);
            /*5008*/
            var ret_result = ret.I32 != 0;
            /*5009*/
            return ret_result;
            /*5010*/
        }

        // gen! bool SetChecked(int command_id,bool checked)
        /// <summary>
        /// Check the specified |command_id|. Only applies to check and radio items.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5011*/

        public bool SetChecked(int /*5012*/
        command_id
        , bool /*5013*/
        _checked
        )/*5014*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*5015*/
            ;
            v2.I32 = _checked ? 1 : 0/*5016*/
            ;
            /*5017*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetChecked_41, out ret, ref v1, ref v2);
            /*5018*/
            var ret_result = ret.I32 != 0;
            /*5019*/
            return ret_result;
            /*5020*/
        }

        // gen! bool SetCheckedAt(int index,bool checked)
        /// <summary>
        /// Check the specified |index|. Only applies to check and radio items. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>
        /*5021*/

        public bool SetCheckedAt(int /*5022*/
        index
        , bool /*5023*/
        _checked
        )/*5024*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*5025*/
            ;
            v2.I32 = _checked ? 1 : 0/*5026*/
            ;
            /*5027*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetCheckedAt_42, out ret, ref v1, ref v2);
            /*5028*/
            var ret_result = ret.I32 != 0;
            /*5029*/
            return ret_result;
            /*5030*/
        }

        // gen! bool HasAccelerator(int command_id)
        /// <summary>
        /// Returns true if the specified |command_id| has a keyboard accelerator
        /// assigned.
        /// /*cef()*/
        /// </summary>
        /*5031*/

        public bool HasAccelerator(int /*5032*/
        command_id
        )/*5033*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*5034*/
            ;
            /*5035*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_HasAccelerator_43, out ret, ref v1);
            /*5036*/
            var ret_result = ret.I32 != 0;
            /*5037*/
            return ret_result;
            /*5038*/
        }

        // gen! bool HasAcceleratorAt(int index)
        /// <summary>
        /// Returns true if the specified |index| has a keyboard accelerator assigned.
        /// /*cef()*/
        /// </summary>
        /*5039*/

        public bool HasAcceleratorAt(int /*5040*/
        index
        )/*5041*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*5042*/
            ;
            /*5043*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_HasAcceleratorAt_44, out ret, ref v1);
            /*5044*/
            var ret_result = ret.I32 != 0;
            /*5045*/
            return ret_result;
            /*5046*/
        }

        // gen! bool SetAccelerator(int command_id,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
        /// <summary>
        /// Set the keyboard accelerator for the specified |command_id|. |key_code| can
        /// be any virtual key or character value. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5047*/

        public bool SetAccelerator(int /*5048*/
        command_id
        , int /*5049*/
        key_code
        , bool /*5050*/
        shift_pressed
        , bool /*5051*/
        ctrl_pressed
        , bool /*5052*/
        alt_pressed
        )/*5053*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*5054*/
            ;
            v2.I32 = (int)key_code/*5055*/
            ;
            v3.I32 = shift_pressed ? 1 : 0/*5056*/
            ;
            v4.I32 = ctrl_pressed ? 1 : 0/*5057*/
            ;
            v5.I32 = alt_pressed ? 1 : 0/*5058*/
            ;
            /*5059*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_SetAccelerator_45, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*5060*/
            var ret_result = ret.I32 != 0;
            /*5061*/
            return ret_result;
            /*5062*/
        }

        // gen! bool SetAcceleratorAt(int index,int key_code,bool shift_pressed,bool ctrl_pressed,bool alt_pressed)
        /// <summary>
        /// Set the keyboard accelerator at the specified |index|. |key_code| can be
        /// any virtual key or character value. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5063*/

        public bool SetAcceleratorAt(int /*5064*/
        index
        , int /*5065*/
        key_code
        , bool /*5066*/
        shift_pressed
        , bool /*5067*/
        ctrl_pressed
        , bool /*5068*/
        alt_pressed
        )/*5069*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*5070*/
            ;
            v2.I32 = (int)key_code/*5071*/
            ;
            v3.I32 = shift_pressed ? 1 : 0/*5072*/
            ;
            v4.I32 = ctrl_pressed ? 1 : 0/*5073*/
            ;
            v5.I32 = alt_pressed ? 1 : 0/*5074*/
            ;
            /*5075*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_SetAcceleratorAt_46, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*5076*/
            var ret_result = ret.I32 != 0;
            /*5077*/
            return ret_result;
            /*5078*/
        }

        // gen! bool RemoveAccelerator(int command_id)
        /// <summary>
        /// Remove the keyboard accelerator for the specified |command_id|. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>
        /*5079*/

        public bool RemoveAccelerator(int /*5080*/
        command_id
        )/*5081*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*5082*/
            ;
            /*5083*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAccelerator_47, out ret, ref v1);
            /*5084*/
            var ret_result = ret.I32 != 0;
            /*5085*/
            return ret_result;
            /*5086*/
        }

        // gen! bool RemoveAcceleratorAt(int index)
        /// <summary>
        /// Remove the keyboard accelerator at the specified |index|. Returns true on
        /// success.
        /// /*cef()*/
        /// </summary>
        /*5087*/

        public bool RemoveAcceleratorAt(int /*5088*/
        index
        )/*5089*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*5090*/
            ;
            /*5091*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefMenuModel_RemoveAcceleratorAt_48, out ret, ref v1);
            /*5092*/
            var ret_result = ret.I32 != 0;
            /*5093*/
            return ret_result;
            /*5094*/
        }

        // gen! bool GetAccelerator(int command_id,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
        /// <summary>
        /// Retrieves the keyboard accelerator for the specified |command_id|. Returns
        /// true on success.
        /// /*cef()*/
        /// </summary>
        /*5095*/

        public bool GetAccelerator(int /*5096*/
        command_id
        , ref int /*5097*/
        key_code
        , ref bool /*5098*/
        shift_pressed
        , ref bool /*5099*/
        ctrl_pressed
        , ref bool /*5100*/
        alt_pressed
        )/*5101*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*5102*/
            ;
            v2.I32 = key_code/*5103*/
            ;
            v3.I32 = (shift_pressed ? 1 : 0)/*5104*/
            ;
            v4.I32 = (ctrl_pressed ? 1 : 0)/*5105*/
            ;
            v5.I32 = (alt_pressed ? 1 : 0)/*5106*/
            ;
            /*5107*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_GetAccelerator_49, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*5108*/
            var ret_result = ret.I32 != 0;
            key_code = (int)v2.I32;/*5109*/
            ;
            shift_pressed = v3.I32 != 0;/*5110*/
            ;
            ctrl_pressed = v4.I32 != 0;/*5111*/
            ;
            alt_pressed = v5.I32 != 0;/*5112*/
            ;
            /*5113*/
            return ret_result;
            /*5114*/
        }

        // gen! bool GetAcceleratorAt(int index,int& key_code,bool& shift_pressed,bool& ctrl_pressed,bool& alt_pressed)
        /// <summary>
        /// Retrieves the keyboard accelerator for the specified |index|. Returns true
        /// on success.
        /// /*cef()*/
        /// </summary>
        /*5115*/

        public bool GetAcceleratorAt(int /*5116*/
        index
        , ref int /*5117*/
        key_code
        , ref bool /*5118*/
        shift_pressed
        , ref bool /*5119*/
        ctrl_pressed
        , ref bool /*5120*/
        alt_pressed
        )/*5121*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*5122*/
            ;
            v2.I32 = key_code/*5123*/
            ;
            v3.I32 = (shift_pressed ? 1 : 0)/*5124*/
            ;
            v4.I32 = (ctrl_pressed ? 1 : 0)/*5125*/
            ;
            v5.I32 = (alt_pressed ? 1 : 0)/*5126*/
            ;
            /*5127*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefMenuModel_GetAcceleratorAt_50, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*5128*/
            var ret_result = ret.I32 != 0;
            key_code = (int)v2.I32;/*5129*/
            ;
            shift_pressed = v3.I32 != 0;/*5130*/
            ;
            ctrl_pressed = v4.I32 != 0;/*5131*/
            ;
            alt_pressed = v5.I32 != 0;/*5132*/
            ;
            /*5133*/
            return ret_result;
            /*5134*/
        }

        // gen! bool SetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t color)
        /// <summary>
        /// Set the explicit color for |command_id| and |color_type| to |color|.
        /// Specify a |color| value of 0 to remove the explicit color. If no explicit
        /// color or default color is set for |color_type| then the system color will
        /// be used. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5135*/

        public bool SetColor(int /*5136*/
        command_id
        , cef_menu_color_type_t /*5137*/
        color_type
        , IntPtr /*5138*/
        color
        )/*5139*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*5140*/
            ;
            v2.I32 = (int)color_type/*5141*/
            ;
            v3.I32 = (int)color/*5142*/
            ;
            /*5143*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_SetColor_51, out ret, ref v1, ref v2, ref v3);
            /*5144*/
            var ret_result = ret.I32 != 0;
            /*5145*/
            return ret_result;
            /*5146*/
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
        /*5147*/

        public bool SetColorAt(int /*5148*/
        index
        , cef_menu_color_type_t /*5149*/
        color_type
        , IntPtr /*5150*/
        color
        )/*5151*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*5152*/
            ;
            v2.I32 = (int)color_type/*5153*/
            ;
            v3.I32 = (int)color/*5154*/
            ;
            /*5155*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_SetColorAt_52, out ret, ref v1, ref v2, ref v3);
            /*5156*/
            var ret_result = ret.I32 != 0;
            /*5157*/
            return ret_result;
            /*5158*/
        }

        // gen! bool GetColor(int command_id,cef_menu_color_type_t color_type,cef_color_t& color)
        /// <summary>
        /// Returns in |color| the color that was explicitly set for |command_id| and
        /// |color_type|. If a color was not set then 0 will be returned in |color|.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5159*/

        public bool GetColor(int /*5160*/
        command_id
        , cef_menu_color_type_t /*5161*/
        color_type
        , cef_color_t /*5162*/
        color
        )/*5163*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)command_id/*5164*/
            ;
            v2.I32 = (int)color_type/*5165*/
            ;
            v3.Ptr = color.nativePtr/*5166*/
            ;
            /*5167*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_GetColor_53, out ret, ref v1, ref v2, ref v3);
            /*5168*/
            var ret_result = ret.I32 != 0;
            /*5169*/
            return ret_result;
            /*5170*/
        }

        // gen! bool GetColorAt(int index,cef_menu_color_type_t color_type,cef_color_t& color)
        /// <summary>
        /// Returns in |color| the color that was explicitly set for |command_id| and
        /// |color_type|. Specify an |index| value of -1 to return the default color
        /// in |color|. If a color was not set then 0 will be returned in |color|.
        /// Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*5171*/

        public bool GetColorAt(int /*5172*/
        index
        , cef_menu_color_type_t /*5173*/
        color_type
        , cef_color_t /*5174*/
        color
        )/*5175*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*5176*/
            ;
            v2.I32 = (int)color_type/*5177*/
            ;
            v3.Ptr = color.nativePtr/*5178*/
            ;
            /*5179*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefMenuModel_GetColorAt_54, out ret, ref v1, ref v2, ref v3);
            /*5180*/
            var ret_result = ret.I32 != 0;
            /*5181*/
            return ret_result;
            /*5182*/
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
        /*5183*/

        public bool SetFontList(int /*5184*/
        command_id
        , string /*5185*/
        font_list
        )/*5186*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(font_list);
            /*5187*/
            ;
            v1.I32 = (int)command_id/*5188*/
            ;
            /*5189*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetFontList_55, out ret, ref v1, ref v2);
            /*5190*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*5191*/
            ;
            /*5192*/
            return ret_result;
            /*5193*/
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
        /*5194*/

        public bool SetFontListAt(int /*5195*/
        index
        , string /*5196*/
        font_list
        )/*5197*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(font_list);
            /*5198*/
            ;
            v1.I32 = (int)index/*5199*/
            ;
            /*5200*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefMenuModel_SetFontListAt_56, out ret, ref v1, ref v2);
            /*5201*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*5202*/
            ;
            /*5203*/
            return ret_result;
            /*5204*/
        }
        /*5205*/
    }


    // [virtual] class CefMenuModelDelegate
    /// <summary>
    /// Implement this interface to handle menu model events. The methods of this
    /// class will be called on the browser process UI thread unless otherwise
    /// indicated.
    /// /*(source=client)*/
    /// </summary>
    /*5214*/
    public struct CefMenuModelDelegate
    {
        /*5215*/
        const int _typeNAME = 18;
        /*5216*/
        const int CefMenuModelDelegate_Release_0 = (_typeNAME << 16) | 0;
        /*5217*/
        internal readonly IntPtr nativePtr;
        /*5218*/
        internal CefMenuModelDelegate(IntPtr nativePtr)
        {
            /*5219*/
            this.nativePtr = nativePtr;
            /*5220*/
        }
        /*5221*/
        public void Release()
        {
            /*5222*/
            JsValue ret;
            /*5223*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefMenuModelDelegate_Release_0, out ret);
            /*5224*/
        }
        /*5225*/
    }


    // [virtual] class CefNavigationEntry
    /// <summary>
    /// Class used to represent an entry in navigation history.
    /// /*(source=library)*/
    /// </summary>
    /*5284*/
    public struct CefNavigationEntry
    {
        /*5285*/
        const int _typeNAME = 19;
        /*5286*/
        const int CefNavigationEntry_Release_0 = (_typeNAME << 16) | 0;
        /*5287*/
        const int CefNavigationEntry_IsValid_1 = (_typeNAME << 16) | 1;
        /*5288*/
        const int CefNavigationEntry_GetURL_2 = (_typeNAME << 16) | 2;
        /*5289*/
        const int CefNavigationEntry_GetDisplayURL_3 = (_typeNAME << 16) | 3;
        /*5290*/
        const int CefNavigationEntry_GetOriginalURL_4 = (_typeNAME << 16) | 4;
        /*5291*/
        const int CefNavigationEntry_GetTitle_5 = (_typeNAME << 16) | 5;
        /*5292*/
        const int CefNavigationEntry_GetTransitionType_6 = (_typeNAME << 16) | 6;
        /*5293*/
        const int CefNavigationEntry_HasPostData_7 = (_typeNAME << 16) | 7;
        /*5294*/
        const int CefNavigationEntry_GetCompletionTime_8 = (_typeNAME << 16) | 8;
        /*5295*/
        const int CefNavigationEntry_GetHttpStatusCode_9 = (_typeNAME << 16) | 9;
        /*5296*/
        const int CefNavigationEntry_GetSSLStatus_10 = (_typeNAME << 16) | 10;
        /*5297*/
        internal readonly IntPtr nativePtr;
        /*5298*/
        internal CefNavigationEntry(IntPtr nativePtr)
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
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_Release_0, out ret);
            /*5304*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefNavigationEntry methods.
        /// </summary>
        /*5305*/

        public bool IsValid()/*5306*/
        {
            JsValue ret;
            /*5307*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_IsValid_1, out ret);
            /*5308*/
            var ret_result = ret.I32 != 0;
            /*5309*/
            return ret_result;
            /*5310*/
        }

        // gen! CefString GetURL()
        /// <summary>
        /// Returns the actual URL of the page. For some pages this may be data: URL or
        /// similar. Use GetDisplayURL() to return a display-friendly version.
        /// /*cef()*/
        /// </summary>
        /*5311*/

        public string GetURL()/*5312*/
        {
            JsValue ret;
            /*5313*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetURL_2, out ret);
            /*5314*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5315*/
            return ret_result;
            /*5316*/
        }

        // gen! CefString GetDisplayURL()
        /// <summary>
        /// Returns a display-friendly version of the URL.
        /// /*cef()*/
        /// </summary>
        /*5317*/

        public string GetDisplayURL()/*5318*/
        {
            JsValue ret;
            /*5319*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetDisplayURL_3, out ret);
            /*5320*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5321*/
            return ret_result;
            /*5322*/
        }

        // gen! CefString GetOriginalURL()
        /// <summary>
        /// Returns the original URL that was entered by the user before any redirects.
        /// /*cef()*/
        /// </summary>
        /*5323*/

        public string GetOriginalURL()/*5324*/
        {
            JsValue ret;
            /*5325*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetOriginalURL_4, out ret);
            /*5326*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5327*/
            return ret_result;
            /*5328*/
        }

        // gen! CefString GetTitle()
        /// <summary>
        /// Returns the title set by the page. This value may be empty.
        /// /*cef()*/
        /// </summary>
        /*5329*/

        public string GetTitle()/*5330*/
        {
            JsValue ret;
            /*5331*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetTitle_5, out ret);
            /*5332*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5333*/
            return ret_result;
            /*5334*/
        }

        // gen! TransitionType GetTransitionType()
        /// <summary>
        /// Returns the transition type which indicates what the user did to move to
        /// this page from the previous page.
        /// /*cef(default_retval=TT_EXPLICIT)*/
        /// </summary>
        /*5335*/

        public cef_transition_type_t GetTransitionType()/*5336*/
        {
            JsValue ret;
            /*5337*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetTransitionType_6, out ret);
            /*5338*/
            var ret_result = (cef_transition_type_t)ret.I32;

            /*5339*/
            return ret_result;
            /*5340*/
        }

        // gen! bool HasPostData()
        /// <summary>
        /// Returns true if this navigation includes post data.
        /// /*cef()*/
        /// </summary>
        /*5341*/

        public bool HasPostData()/*5342*/
        {
            JsValue ret;
            /*5343*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_HasPostData_7, out ret);
            /*5344*/
            var ret_result = ret.I32 != 0;
            /*5345*/
            return ret_result;
            /*5346*/
        }

        // gen! CefTime GetCompletionTime()
        /// <summary>
        /// Returns the time for the last known successful navigation completion. A
        /// navigation may be completed more than once if the page is reloaded. May be
        /// 0 if the navigation has not yet completed.
        /// /*cef()*/
        /// </summary>
        /*5347*/

        public CefTime GetCompletionTime()/*5348*/
        {
            JsValue ret;
            /*5349*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetCompletionTime_8, out ret);
            /*5350*/
            var ret_result = new CefTime(ret.Ptr);

            /*5351*/
            return ret_result;
            /*5352*/
        }

        // gen! int GetHttpStatusCode()
        /// <summary>
        /// Returns the HTTP status code for the last known successful navigation
        /// response. May be 0 if the response has not yet been received or if the
        /// navigation has not yet completed.
        /// /*cef()*/
        /// </summary>
        /*5353*/

        public int GetHttpStatusCode()/*5354*/
        {
            JsValue ret;
            /*5355*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetHttpStatusCode_9, out ret);
            /*5356*/
            var ret_result = ret.I32;
            /*5357*/
            return ret_result;
            /*5358*/
        }

        // gen! CefRefPtr<CefSSLStatus> GetSSLStatus()
        /// <summary>
        /// Returns the SSL information for this navigation entry.
        /// /*cef()*/
        /// </summary>
        /*5359*/

        public CefSSLStatus GetSSLStatus()/*5360*/
        {
            JsValue ret;
            /*5361*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefNavigationEntry_GetSSLStatus_10, out ret);
            /*5362*/
            var ret_result = new CefSSLStatus(ret.Ptr);
            /*5363*/
            return ret_result;
            /*5364*/
        }
        /*5365*/
    }


    // [virtual] class CefPrintSettings
    /// <summary>
    /// Class representing print settings.
    /// /*(source=library)*/
    /// </summary>
    /*5489*/
    public struct CefPrintSettings
    {
        /*5490*/
        const int _typeNAME = 20;
        /*5491*/
        const int CefPrintSettings_Release_0 = (_typeNAME << 16) | 0;
        /*5492*/
        const int CefPrintSettings_IsValid_1 = (_typeNAME << 16) | 1;
        /*5493*/
        const int CefPrintSettings_IsReadOnly_2 = (_typeNAME << 16) | 2;
        /*5494*/
        const int CefPrintSettings_Copy_3 = (_typeNAME << 16) | 3;
        /*5495*/
        const int CefPrintSettings_SetOrientation_4 = (_typeNAME << 16) | 4;
        /*5496*/
        const int CefPrintSettings_IsLandscape_5 = (_typeNAME << 16) | 5;
        /*5497*/
        const int CefPrintSettings_SetPrinterPrintableArea_6 = (_typeNAME << 16) | 6;
        /*5498*/
        const int CefPrintSettings_SetDeviceName_7 = (_typeNAME << 16) | 7;
        /*5499*/
        const int CefPrintSettings_GetDeviceName_8 = (_typeNAME << 16) | 8;
        /*5500*/
        const int CefPrintSettings_SetDPI_9 = (_typeNAME << 16) | 9;
        /*5501*/
        const int CefPrintSettings_GetDPI_10 = (_typeNAME << 16) | 10;
        /*5502*/
        const int CefPrintSettings_SetPageRanges_11 = (_typeNAME << 16) | 11;
        /*5503*/
        const int CefPrintSettings_GetPageRangesCount_12 = (_typeNAME << 16) | 12;
        /*5504*/
        const int CefPrintSettings_GetPageRanges_13 = (_typeNAME << 16) | 13;
        /*5505*/
        const int CefPrintSettings_SetSelectionOnly_14 = (_typeNAME << 16) | 14;
        /*5506*/
        const int CefPrintSettings_IsSelectionOnly_15 = (_typeNAME << 16) | 15;
        /*5507*/
        const int CefPrintSettings_SetCollate_16 = (_typeNAME << 16) | 16;
        /*5508*/
        const int CefPrintSettings_WillCollate_17 = (_typeNAME << 16) | 17;
        /*5509*/
        const int CefPrintSettings_SetColorModel_18 = (_typeNAME << 16) | 18;
        /*5510*/
        const int CefPrintSettings_GetColorModel_19 = (_typeNAME << 16) | 19;
        /*5511*/
        const int CefPrintSettings_SetCopies_20 = (_typeNAME << 16) | 20;
        /*5512*/
        const int CefPrintSettings_GetCopies_21 = (_typeNAME << 16) | 21;
        /*5513*/
        const int CefPrintSettings_SetDuplexMode_22 = (_typeNAME << 16) | 22;
        /*5514*/
        const int CefPrintSettings_GetDuplexMode_23 = (_typeNAME << 16) | 23;
        /*5515*/
        internal readonly IntPtr nativePtr;
        /*5516*/
        internal CefPrintSettings(IntPtr nativePtr)
        {
            /*5517*/
            this.nativePtr = nativePtr;
            /*5518*/
        }
        /*5519*/
        public void Release()
        {
            /*5520*/
            JsValue ret;
            /*5521*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_Release_0, out ret);
            /*5522*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefPrintSettings methods.
        /// </summary>
        /*5523*/

        public bool IsValid()/*5524*/
        {
            JsValue ret;
            /*5525*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsValid_1, out ret);
            /*5526*/
            var ret_result = ret.I32 != 0;
            /*5527*/
            return ret_result;
            /*5528*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*5529*/

        public bool IsReadOnly()/*5530*/
        {
            JsValue ret;
            /*5531*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsReadOnly_2, out ret);
            /*5532*/
            var ret_result = ret.I32 != 0;
            /*5533*/
            return ret_result;
            /*5534*/
        }

        // gen! CefRefPtr<CefPrintSettings> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>
        /*5535*/

        public CefPrintSettings Copy()/*5536*/
        {
            JsValue ret;
            /*5537*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_Copy_3, out ret);
            /*5538*/
            var ret_result = new CefPrintSettings(ret.Ptr);
            /*5539*/
            return ret_result;
            /*5540*/
        }

        // gen! void SetOrientation(bool landscape)
        /// <summary>
        /// Set the page orientation.
        /// /*cef()*/
        /// </summary>
        /*5541*/

        public void SetOrientation(bool /*5542*/
        landscape
        )/*5543*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = landscape ? 1 : 0/*5544*/
            ;
            /*5545*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetOrientation_4, out ret, ref v1);
            /*5546*/

            /*5547*/
        }

        // gen! bool IsLandscape()
        /// <summary>
        /// Returns true if the orientation is landscape.
        /// /*cef()*/
        /// </summary>
        /*5548*/

        public bool IsLandscape()/*5549*/
        {
            JsValue ret;
            /*5550*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsLandscape_5, out ret);
            /*5551*/
            var ret_result = ret.I32 != 0;
            /*5552*/
            return ret_result;
            /*5553*/
        }

        // gen! void SetPrinterPrintableArea(const CefSize& physical_size_device_units,const CefRect& printable_area_device_units,bool landscape_needs_flip)
        /// <summary>
        /// Set the printer printable area in device units.
        /// Some platforms already provide flipped area. Set |landscape_needs_flip|
        /// to false on those platforms to avoid double flipping.
        /// /*cef()*/
        /// </summary>
        /*5554*/

        public void SetPrinterPrintableArea(CefSize /*5555*/
        physical_size_device_units
        , CefRect /*5556*/
        printable_area_device_units
        , bool /*5557*/
        landscape_needs_flip
        )/*5558*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = physical_size_device_units.nativePtr/*5559*/
            ;
            v2.Ptr = printable_area_device_units.nativePtr/*5560*/
            ;
            v3.I32 = landscape_needs_flip ? 1 : 0/*5561*/
            ;
            /*5562*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefPrintSettings_SetPrinterPrintableArea_6, out ret, ref v1, ref v2, ref v3);
            /*5563*/

            /*5564*/
        }

        // gen! void SetDeviceName(const CefString& name)
        /// <summary>
        /// Set the device name.
        /// /*cef(optional_param=name)*/
        /// </summary>
        /*5565*/

        public void SetDeviceName(string /*5566*/
        name
        )/*5567*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*5568*/
            ;
            /*5569*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDeviceName_7, out ret, ref v1);
            /*5570*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*5571*/
            ;
            /*5572*/
        }

        // gen! CefString GetDeviceName()
        /// <summary>
        /// Get the device name.
        /// /*cef()*/
        /// </summary>
        /*5573*/

        public string GetDeviceName()/*5574*/
        {
            JsValue ret;
            /*5575*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDeviceName_8, out ret);
            /*5576*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5577*/
            return ret_result;
            /*5578*/
        }

        // gen! void SetDPI(int dpi)
        /// <summary>
        /// Set the DPI (dots per inch).
        /// /*cef()*/
        /// </summary>
        /*5579*/

        public void SetDPI(int /*5580*/
        dpi
        )/*5581*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)dpi/*5582*/
            ;
            /*5583*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDPI_9, out ret, ref v1);
            /*5584*/

            /*5585*/
        }

        // gen! int GetDPI()
        /// <summary>
        /// Get the DPI (dots per inch).
        /// /*cef()*/
        /// </summary>
        /*5586*/

        public int GetDPI()/*5587*/
        {
            JsValue ret;
            /*5588*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDPI_10, out ret);
            /*5589*/
            var ret_result = ret.I32;
            /*5590*/
            return ret_result;
            /*5591*/
        }

        // gen! void SetPageRanges(const PageRangeList& ranges)
        /// <summary>
        /// Set the page ranges.
        /// /*cef()*/
        /// </summary>
        /*5592*/

        public void SetPageRanges(PageRangeList /*5593*/
        ranges
        )/*5594*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = ranges.nativePtr/*5595*/
            ;
            /*5596*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetPageRanges_11, out ret, ref v1);
            /*5597*/

            /*5598*/
        }

        // gen! size_t GetPageRangesCount()
        /// <summary>
        /// Returns the number of page ranges that currently exist.
        /// /*cef()*/
        /// </summary>
        /*5599*/

        public uint GetPageRangesCount()/*5600*/
        {
            JsValue ret;
            /*5601*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetPageRangesCount_12, out ret);
            /*5602*/
            var ret_result = (uint)ret.I32;
            /*5603*/
            return ret_result;
            /*5604*/
        }

        // gen! void GetPageRanges(PageRangeList& ranges)
        /// <summary>
        /// Retrieve the page ranges.
        /// /*cef(count_func=ranges:GetPageRangesCount)*/
        /// </summary>
        /*5605*/

        public void GetPageRanges(PageRangeList /*5606*/
        ranges
        )/*5607*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = ranges.nativePtr/*5608*/
            ;
            /*5609*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_GetPageRanges_13, out ret, ref v1);
            /*5610*/

            /*5611*/
        }

        // gen! void SetSelectionOnly(bool selection_only)
        /// <summary>
        /// Set whether only the selection will be printed.
        /// /*cef()*/
        /// </summary>
        /*5612*/

        public void SetSelectionOnly(bool /*5613*/
        selection_only
        )/*5614*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = selection_only ? 1 : 0/*5615*/
            ;
            /*5616*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetSelectionOnly_14, out ret, ref v1);
            /*5617*/

            /*5618*/
        }

        // gen! bool IsSelectionOnly()
        /// <summary>
        /// Returns true if only the selection will be printed.
        /// /*cef()*/
        /// </summary>
        /*5619*/

        public bool IsSelectionOnly()/*5620*/
        {
            JsValue ret;
            /*5621*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_IsSelectionOnly_15, out ret);
            /*5622*/
            var ret_result = ret.I32 != 0;
            /*5623*/
            return ret_result;
            /*5624*/
        }

        // gen! void SetCollate(bool collate)
        /// <summary>
        /// Set whether pages will be collated.
        /// /*cef()*/
        /// </summary>
        /*5625*/

        public void SetCollate(bool /*5626*/
        collate
        )/*5627*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = collate ? 1 : 0/*5628*/
            ;
            /*5629*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetCollate_16, out ret, ref v1);
            /*5630*/

            /*5631*/
        }

        // gen! bool WillCollate()
        /// <summary>
        /// Returns true if pages will be collated.
        /// /*cef()*/
        /// </summary>
        /*5632*/

        public bool WillCollate()/*5633*/
        {
            JsValue ret;
            /*5634*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_WillCollate_17, out ret);
            /*5635*/
            var ret_result = ret.I32 != 0;
            /*5636*/
            return ret_result;
            /*5637*/
        }

        // gen! void SetColorModel(ColorModel model)
        /// <summary>
        /// Set the color model.
        /// /*cef()*/
        /// </summary>
        /*5638*/

        public void SetColorModel(cef_color_model_t /*5639*/
        model
        )/*5640*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)model/*5641*/
            ;
            /*5642*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetColorModel_18, out ret, ref v1);
            /*5643*/

            /*5644*/
        }

        // gen! ColorModel GetColorModel()
        /// <summary>
        /// Get the color model.
        /// /*cef(default_retval=COLOR_MODEL_UNKNOWN)*/
        /// </summary>
        /*5645*/

        public cef_color_model_t GetColorModel()/*5646*/
        {
            JsValue ret;
            /*5647*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetColorModel_19, out ret);
            /*5648*/
            var ret_result = (cef_color_model_t)ret.I32;

            /*5649*/
            return ret_result;
            /*5650*/
        }

        // gen! void SetCopies(int copies)
        /// <summary>
        /// Set the number of copies.
        /// /*cef()*/
        /// </summary>
        /*5651*/

        public void SetCopies(int /*5652*/
        copies
        )/*5653*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)copies/*5654*/
            ;
            /*5655*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetCopies_20, out ret, ref v1);
            /*5656*/

            /*5657*/
        }

        // gen! int GetCopies()
        /// <summary>
        /// Get the number of copies.
        /// /*cef()*/
        /// </summary>
        /*5658*/

        public int GetCopies()/*5659*/
        {
            JsValue ret;
            /*5660*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetCopies_21, out ret);
            /*5661*/
            var ret_result = ret.I32;
            /*5662*/
            return ret_result;
            /*5663*/
        }

        // gen! void SetDuplexMode(DuplexMode mode)
        /// <summary>
        /// Set the duplex mode.
        /// /*cef()*/
        /// </summary>
        /*5664*/

        public void SetDuplexMode(cef_duplex_mode_t /*5665*/
        mode
        )/*5666*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)mode/*5667*/
            ;
            /*5668*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPrintSettings_SetDuplexMode_22, out ret, ref v1);
            /*5669*/

            /*5670*/
        }

        // gen! DuplexMode GetDuplexMode()
        /// <summary>
        /// Get the duplex mode.
        /// /*cef(default_retval=DUPLEX_MODE_UNKNOWN)*/
        /// </summary>
        /*5671*/

        public cef_duplex_mode_t GetDuplexMode()/*5672*/
        {
            JsValue ret;
            /*5673*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPrintSettings_GetDuplexMode_23, out ret);
            /*5674*/
            var ret_result = (cef_duplex_mode_t)ret.I32;

            /*5675*/
            return ret_result;
            /*5676*/
        }
        /*5677*/
    }


    // [virtual] class CefProcessMessage
    /// <summary>
    /// Class representing a message. Can be used on any process and thread.
    /// /*cef(source=library)*/
    /// </summary>
    /*5711*/
    public struct CefProcessMessage
    {
        /*5712*/
        const int _typeNAME = 21;
        /*5713*/
        const int CefProcessMessage_Release_0 = (_typeNAME << 16) | 0;
        /*5714*/
        const int CefProcessMessage_IsValid_1 = (_typeNAME << 16) | 1;
        /*5715*/
        const int CefProcessMessage_IsReadOnly_2 = (_typeNAME << 16) | 2;
        /*5716*/
        const int CefProcessMessage_Copy_3 = (_typeNAME << 16) | 3;
        /*5717*/
        const int CefProcessMessage_GetName_4 = (_typeNAME << 16) | 4;
        /*5718*/
        const int CefProcessMessage_GetArgumentList_5 = (_typeNAME << 16) | 5;
        /*5719*/
        internal readonly IntPtr nativePtr;
        /*5720*/
        internal CefProcessMessage(IntPtr nativePtr)
        {
            /*5721*/
            this.nativePtr = nativePtr;
            /*5722*/
        }
        /*5723*/
        public void Release()
        {
            /*5724*/
            JsValue ret;
            /*5725*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_Release_0, out ret);
            /*5726*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefProcessMessage methods.
        /// </summary>
        /*5727*/

        public bool IsValid()/*5728*/
        {
            JsValue ret;
            /*5729*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_IsValid_1, out ret);
            /*5730*/
            var ret_result = ret.I32 != 0;
            /*5731*/
            return ret_result;
            /*5732*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*5733*/

        public bool IsReadOnly()/*5734*/
        {
            JsValue ret;
            /*5735*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_IsReadOnly_2, out ret);
            /*5736*/
            var ret_result = ret.I32 != 0;
            /*5737*/
            return ret_result;
            /*5738*/
        }

        // gen! CefRefPtr<CefProcessMessage> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>
        /*5739*/

        public CefProcessMessage Copy()/*5740*/
        {
            JsValue ret;
            /*5741*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_Copy_3, out ret);
            /*5742*/
            var ret_result = new CefProcessMessage(ret.Ptr);
            /*5743*/
            return ret_result;
            /*5744*/
        }

        // gen! CefString GetName()
        /// <summary>
        /// Returns the message name.
        /// /*cef()*/
        /// </summary>
        /*5745*/

        public string GetName()/*5746*/
        {
            JsValue ret;
            /*5747*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_GetName_4, out ret);
            /*5748*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5749*/
            return ret_result;
            /*5750*/
        }

        // gen! CefRefPtr<CefListValue> GetArgumentList()
        /// <summary>
        /// Returns the list of arguments.
        /// /*cef()*/
        /// </summary>
        /*5751*/

        public CefListValue GetArgumentList()/*5752*/
        {
            JsValue ret;
            /*5753*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefProcessMessage_GetArgumentList_5, out ret);
            /*5754*/
            var ret_result = new CefListValue(ret.Ptr);
            /*5755*/
            return ret_result;
            /*5756*/
        }
        /*5757*/
    }


    // [virtual] class CefRequest
    /// <summary>
    /// Class used to represent a web request. The methods of this class may be
    /// called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*5866*/
    public struct CefRequest
    {
        /*5867*/
        const int _typeNAME = 22;
        /*5868*/
        const int CefRequest_Release_0 = (_typeNAME << 16) | 0;
        /*5869*/
        const int CefRequest_IsReadOnly_1 = (_typeNAME << 16) | 1;
        /*5870*/
        const int CefRequest_GetURL_2 = (_typeNAME << 16) | 2;
        /*5871*/
        const int CefRequest_SetURL_3 = (_typeNAME << 16) | 3;
        /*5872*/
        const int CefRequest_GetMethod_4 = (_typeNAME << 16) | 4;
        /*5873*/
        const int CefRequest_SetMethod_5 = (_typeNAME << 16) | 5;
        /*5874*/
        const int CefRequest_SetReferrer_6 = (_typeNAME << 16) | 6;
        /*5875*/
        const int CefRequest_GetReferrerURL_7 = (_typeNAME << 16) | 7;
        /*5876*/
        const int CefRequest_GetReferrerPolicy_8 = (_typeNAME << 16) | 8;
        /*5877*/
        const int CefRequest_GetPostData_9 = (_typeNAME << 16) | 9;
        /*5878*/
        const int CefRequest_SetPostData_10 = (_typeNAME << 16) | 10;
        /*5879*/
        const int CefRequest_GetHeaderMap_11 = (_typeNAME << 16) | 11;
        /*5880*/
        const int CefRequest_SetHeaderMap_12 = (_typeNAME << 16) | 12;
        /*5881*/
        const int CefRequest_Set_13 = (_typeNAME << 16) | 13;
        /*5882*/
        const int CefRequest_GetFlags_14 = (_typeNAME << 16) | 14;
        /*5883*/
        const int CefRequest_SetFlags_15 = (_typeNAME << 16) | 15;
        /*5884*/
        const int CefRequest_GetFirstPartyForCookies_16 = (_typeNAME << 16) | 16;
        /*5885*/
        const int CefRequest_SetFirstPartyForCookies_17 = (_typeNAME << 16) | 17;
        /*5886*/
        const int CefRequest_GetResourceType_18 = (_typeNAME << 16) | 18;
        /*5887*/
        const int CefRequest_GetTransitionType_19 = (_typeNAME << 16) | 19;
        /*5888*/
        const int CefRequest_GetIdentifier_20 = (_typeNAME << 16) | 20;
        /*5889*/
        internal readonly IntPtr nativePtr;
        /*5890*/
        internal CefRequest(IntPtr nativePtr)
        {
            /*5891*/
            this.nativePtr = nativePtr;
            /*5892*/
        }
        /*5893*/
        public void Release()
        {
            /*5894*/
            JsValue ret;
            /*5895*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_Release_0, out ret);
            /*5896*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefRequest methods.
        /// </summary>
        /*5897*/

        public bool IsReadOnly()/*5898*/
        {
            JsValue ret;
            /*5899*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_IsReadOnly_1, out ret);
            /*5900*/
            var ret_result = ret.I32 != 0;
            /*5901*/
            return ret_result;
            /*5902*/
        }

        // gen! CefString GetURL()
        /// <summary>
        /// Get the fully qualified URL.
        /// /*cef()*/
        /// </summary>
        /*5903*/

        public string GetURL()/*5904*/
        {
            JsValue ret;
            /*5905*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetURL_2, out ret);
            /*5906*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5907*/
            return ret_result;
            /*5908*/
        }

        // gen! void SetURL(const CefString& url)
        /// <summary>
        /// Set the fully qualified URL.
        /// /*cef()*/
        /// </summary>
        /*5909*/

        public void SetURL(string /*5910*/
        url
        )/*5911*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*5912*/
            ;
            /*5913*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetURL_3, out ret, ref v1);
            /*5914*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*5915*/
            ;
            /*5916*/
        }

        // gen! CefString GetMethod()
        /// <summary>
        /// Get the request method type. The value will default to POST if post data
        /// is provided and GET otherwise.
        /// /*cef()*/
        /// </summary>
        /*5917*/

        public string GetMethod()/*5918*/
        {
            JsValue ret;
            /*5919*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetMethod_4, out ret);
            /*5920*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5921*/
            return ret_result;
            /*5922*/
        }

        // gen! void SetMethod(const CefString& method)
        /// <summary>
        /// Set the request method type.
        /// /*cef()*/
        /// </summary>
        /*5923*/

        public void SetMethod(string /*5924*/
        method
        )/*5925*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(method);
            /*5926*/
            ;
            /*5927*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetMethod_5, out ret, ref v1);
            /*5928*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*5929*/
            ;
            /*5930*/
        }

        // gen! void SetReferrer(const CefString& referrer_url,ReferrerPolicy policy)
        /// <summary>
        /// Set the referrer URL and policy. If non-empty the referrer URL must be
        /// fully qualified with an HTTP or HTTPS scheme component. Any username,
        /// password or ref component will be removed.
        /// /*cef()*/
        /// </summary>
        /*5931*/

        public void SetReferrer(string /*5932*/
        referrer_url
        , cef_referrer_policy_t /*5933*/
        policy
        )/*5934*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(referrer_url);
            /*5935*/
            ;
            v2.I32 = (int)policy/*5936*/
            ;
            /*5937*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequest_SetReferrer_6, out ret, ref v1, ref v2);
            /*5938*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*5939*/
            ;
            /*5940*/
        }

        // gen! CefString GetReferrerURL()
        /// <summary>
        /// Get the referrer URL.
        /// /*cef()*/
        /// </summary>
        /*5941*/

        public string GetReferrerURL()/*5942*/
        {
            JsValue ret;
            /*5943*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetReferrerURL_7, out ret);
            /*5944*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*5945*/
            return ret_result;
            /*5946*/
        }

        // gen! ReferrerPolicy GetReferrerPolicy()
        /// <summary>
        /// Get the referrer policy.
        /// /*cef(default_retval=REFERRER_POLICY_DEFAULT)*/
        /// </summary>
        /*5947*/

        public cef_referrer_policy_t GetReferrerPolicy()/*5948*/
        {
            JsValue ret;
            /*5949*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetReferrerPolicy_8, out ret);
            /*5950*/
            var ret_result = (cef_referrer_policy_t)ret.I32;

            /*5951*/
            return ret_result;
            /*5952*/
        }

        // gen! CefRefPtr<CefPostData> GetPostData()
        /// <summary>
        /// Get the post data.
        /// /*cef()*/
        /// </summary>
        /*5953*/

        public CefPostData GetPostData()/*5954*/
        {
            JsValue ret;
            /*5955*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetPostData_9, out ret);
            /*5956*/
            var ret_result = new CefPostData(ret.Ptr);
            /*5957*/
            return ret_result;
            /*5958*/
        }

        // gen! void SetPostData(CefRefPtr<CefPostData> postData)
        /// <summary>
        /// Set the post data.
        /// /*cef()*/
        /// </summary>
        /*5959*/

        public void SetPostData(CefPostData /*5960*/
        postData
        )/*5961*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = postData.nativePtr/*5962*/
            ;
            /*5963*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetPostData_10, out ret, ref v1);
            /*5964*/

            /*5965*/
        }

        // gen! void GetHeaderMap(HeaderMap& headerMap)
        /// <summary>
        /// Get the header values. Will not include the Referer value if any.
        /// /*cef()*/
        /// </summary>
        /*5966*/

        public void GetHeaderMap(HeaderMap /*5967*/
        headerMap
        )/*5968*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = headerMap.nativePtr/*5969*/
            ;
            /*5970*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_GetHeaderMap_11, out ret, ref v1);
            /*5971*/

            /*5972*/
        }

        // gen! void SetHeaderMap(const HeaderMap& headerMap)
        /// <summary>
        /// Set the header values. If a Referer value exists in the header map it will
        /// be removed and ignored.
        /// /*cef()*/
        /// </summary>
        /*5973*/

        public void SetHeaderMap(HeaderMap /*5974*/
        headerMap
        )/*5975*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = headerMap.nativePtr/*5976*/
            ;
            /*5977*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetHeaderMap_12, out ret, ref v1);
            /*5978*/

            /*5979*/
        }

        // gen! void Set(const CefString& url,const CefString& method,CefRefPtr<CefPostData> postData,const HeaderMap& headerMap)
        /// <summary>
        /// Set all values at one time.
        /// /*cef(optional_param=postData)*/
        /// </summary>
        /*5980*/

        public void Set(string /*5981*/
        url
        , string /*5982*/
        method
        , CefPostData /*5983*/
        postData
        , HeaderMap /*5984*/
        headerMap
        )/*5985*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*5986*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(method);
            /*5987*/
            ;
            v3.Ptr = postData.nativePtr/*5988*/
            ;
            v4.Ptr = headerMap.nativePtr/*5989*/
            ;
            /*5990*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefRequest_Set_13, out ret, ref v1, ref v2, ref v3, ref v4);
            /*5991*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*5992*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*5993*/
            ;
            /*5994*/
        }

        // gen! int GetFlags()
        /// <summary>
        /// Get the flags used in combination with CefURLRequest. See
        /// cef_urlrequest_flags_t for supported values.
        /// /*cef(default_retval=UR_FLAG_NONE)*/
        /// </summary>
        /*5995*/

        public int GetFlags()/*5996*/
        {
            JsValue ret;
            /*5997*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetFlags_14, out ret);
            /*5998*/
            var ret_result = ret.I32;
            /*5999*/
            return ret_result;
            /*6000*/
        }

        // gen! void SetFlags(int flags)
        /// <summary>
        /// Set the flags used in combination with CefURLRequest.  See
        /// cef_urlrequest_flags_t for supported values.
        /// /*cef()*/
        /// </summary>
        /*6001*/

        public void SetFlags(int /*6002*/
        flags
        )/*6003*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)flags/*6004*/
            ;
            /*6005*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetFlags_15, out ret, ref v1);
            /*6006*/

            /*6007*/
        }

        // gen! CefString GetFirstPartyForCookies()
        /// <summary>
        /// Set the URL to the first party for cookies used in combination with
        /// CefURLRequest.
        /// /*cef()*/
        /// </summary>
        /*6008*/

        public string GetFirstPartyForCookies()/*6009*/
        {
            JsValue ret;
            /*6010*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetFirstPartyForCookies_16, out ret);
            /*6011*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6012*/
            return ret_result;
            /*6013*/
        }

        // gen! void SetFirstPartyForCookies(const CefString& url)
        /// <summary>
        /// Get the URL to the first party for cookies used in combination with
        /// CefURLRequest.
        /// /*cef()*/
        /// </summary>
        /*6014*/

        public void SetFirstPartyForCookies(string /*6015*/
        url
        )/*6016*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(url);
            /*6017*/
            ;
            /*6018*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequest_SetFirstPartyForCookies_17, out ret, ref v1);
            /*6019*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6020*/
            ;
            /*6021*/
        }

        // gen! ResourceType GetResourceType()
        /// <summary>
        /// Get the resource type for this request. Only available in the browser
        /// process.
        /// /*cef(default_retval=RT_SUB_RESOURCE)*/
        /// </summary>
        /*6022*/

        public cef_resource_type_t GetResourceType()/*6023*/
        {
            JsValue ret;
            /*6024*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetResourceType_18, out ret);
            /*6025*/
            var ret_result = (cef_resource_type_t)ret.I32;

            /*6026*/
            return ret_result;
            /*6027*/
        }

        // gen! TransitionType GetTransitionType()
        /// <summary>
        /// Get the transition type for this request. Only available in the browser
        /// process and only applies to requests that represent a main frame or
        /// sub-frame navigation.
        /// /*cef(default_retval=TT_EXPLICIT)*/
        /// </summary>
        /*6028*/

        public cef_transition_type_t GetTransitionType()/*6029*/
        {
            JsValue ret;
            /*6030*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetTransitionType_19, out ret);
            /*6031*/
            var ret_result = (cef_transition_type_t)ret.I32;

            /*6032*/
            return ret_result;
            /*6033*/
        }

        // gen! uint64 GetIdentifier()
        /// <summary>
        /// Returns the globally unique identifier for this request or 0 if not
        /// specified. Can be used by CefRequestHandler implementations in the browser
        /// process to track a single request across multiple callbacks.
        /// /*cef()*/
        /// </summary>
        /*6034*/

        public ulong GetIdentifier()/*6035*/
        {
            JsValue ret;
            /*6036*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequest_GetIdentifier_20, out ret);
            /*6037*/
            var ret_result = (ulong)ret.I64;
            /*6038*/
            return ret_result;
            /*6039*/
        }
        /*6040*/
    }


    // [virtual] class CefPostData
    /// <summary>
    /// Class used to represent post data for a web request. The methods of this
    /// class may be called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*6084*/
    public struct CefPostData
    {
        /*6085*/
        const int _typeNAME = 23;
        /*6086*/
        const int CefPostData_Release_0 = (_typeNAME << 16) | 0;
        /*6087*/
        const int CefPostData_IsReadOnly_1 = (_typeNAME << 16) | 1;
        /*6088*/
        const int CefPostData_HasExcludedElements_2 = (_typeNAME << 16) | 2;
        /*6089*/
        const int CefPostData_GetElementCount_3 = (_typeNAME << 16) | 3;
        /*6090*/
        const int CefPostData_GetElements_4 = (_typeNAME << 16) | 4;
        /*6091*/
        const int CefPostData_RemoveElement_5 = (_typeNAME << 16) | 5;
        /*6092*/
        const int CefPostData_AddElement_6 = (_typeNAME << 16) | 6;
        /*6093*/
        const int CefPostData_RemoveElements_7 = (_typeNAME << 16) | 7;
        /*6094*/
        internal readonly IntPtr nativePtr;
        /*6095*/
        internal CefPostData(IntPtr nativePtr)
        {
            /*6096*/
            this.nativePtr = nativePtr;
            /*6097*/
        }
        /*6098*/
        public void Release()
        {
            /*6099*/
            JsValue ret;
            /*6100*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_Release_0, out ret);
            /*6101*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefPostData methods.
        /// </summary>
        /*6102*/

        public bool IsReadOnly()/*6103*/
        {
            JsValue ret;
            /*6104*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_IsReadOnly_1, out ret);
            /*6105*/
            var ret_result = ret.I32 != 0;
            /*6106*/
            return ret_result;
            /*6107*/
        }

        // gen! bool HasExcludedElements()
        /// <summary>
        /// Returns true if the underlying POST data includes elements that are not
        /// represented by this CefPostData object (for example, multi-part file upload
        /// data). Modifying CefPostData objects with excluded elements may result in
        /// the request failing.
        /// /*cef()*/
        /// </summary>
        /*6108*/

        public bool HasExcludedElements()/*6109*/
        {
            JsValue ret;
            /*6110*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_HasExcludedElements_2, out ret);
            /*6111*/
            var ret_result = ret.I32 != 0;
            /*6112*/
            return ret_result;
            /*6113*/
        }

        // gen! size_t GetElementCount()
        /// <summary>
        /// Returns the number of existing post data elements.
        /// /*cef()*/
        /// </summary>
        /*6114*/

        public uint GetElementCount()/*6115*/
        {
            JsValue ret;
            /*6116*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_GetElementCount_3, out ret);
            /*6117*/
            var ret_result = (uint)ret.I32;
            /*6118*/
            return ret_result;
            /*6119*/
        }

        // gen! void GetElements(ElementVector& elements)
        /// <summary>
        /// Retrieve the post data elements.
        /// /*cef(count_func=elements:GetElementCount)*/
        /// </summary>
        /*6120*/

        public void GetElements(ElementVector /*6121*/
        elements
        )/*6122*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = elements.nativePtr/*6123*/
            ;
            /*6124*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_GetElements_4, out ret, ref v1);
            /*6125*/

            /*6126*/
        }

        // gen! bool RemoveElement(CefRefPtr<CefPostDataElement> element)
        /// <summary>
        /// Remove the specified post data element.  Returns true if the removal
        /// succeeds.
        /// /*cef()*/
        /// </summary>
        /*6127*/

        public bool RemoveElement(CefPostDataElement /*6128*/
        element
        )/*6129*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = element.nativePtr/*6130*/
            ;
            /*6131*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_RemoveElement_5, out ret, ref v1);
            /*6132*/
            var ret_result = ret.I32 != 0;
            /*6133*/
            return ret_result;
            /*6134*/
        }

        // gen! bool AddElement(CefRefPtr<CefPostDataElement> element)
        /// <summary>
        /// Add the specified post data element.  Returns true if the add succeeds.
        /// /*cef()*/
        /// </summary>
        /*6135*/

        public bool AddElement(CefPostDataElement /*6136*/
        element
        )/*6137*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = element.nativePtr/*6138*/
            ;
            /*6139*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostData_AddElement_6, out ret, ref v1);
            /*6140*/
            var ret_result = ret.I32 != 0;
            /*6141*/
            return ret_result;
            /*6142*/
        }

        // gen! void RemoveElements()
        /// <summary>
        /// Remove all existing post data elements.
        /// /*cef()*/
        /// </summary>
        /*6143*/

        public void RemoveElements()/*6144*/
        {
            JsValue ret;
            /*6145*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostData_RemoveElements_7, out ret);
            /*6146*/

            /*6147*/
        }
        /*6148*/
    }


    // [virtual] class CefPostDataElement
    /// <summary>
    /// Class used to represent a single element in the request post data. The
    /// methods of this class may be called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*6197*/
    public struct CefPostDataElement
    {
        /*6198*/
        const int _typeNAME = 24;
        /*6199*/
        const int CefPostDataElement_Release_0 = (_typeNAME << 16) | 0;
        /*6200*/
        const int CefPostDataElement_IsReadOnly_1 = (_typeNAME << 16) | 1;
        /*6201*/
        const int CefPostDataElement_SetToEmpty_2 = (_typeNAME << 16) | 2;
        /*6202*/
        const int CefPostDataElement_SetToFile_3 = (_typeNAME << 16) | 3;
        /*6203*/
        const int CefPostDataElement_SetToBytes_4 = (_typeNAME << 16) | 4;
        /*6204*/
        const int CefPostDataElement_GetType_5 = (_typeNAME << 16) | 5;
        /*6205*/
        const int CefPostDataElement_GetFile_6 = (_typeNAME << 16) | 6;
        /*6206*/
        const int CefPostDataElement_GetBytesCount_7 = (_typeNAME << 16) | 7;
        /*6207*/
        const int CefPostDataElement_GetBytes_8 = (_typeNAME << 16) | 8;
        /*6208*/
        internal readonly IntPtr nativePtr;
        /*6209*/
        internal CefPostDataElement(IntPtr nativePtr)
        {
            /*6210*/
            this.nativePtr = nativePtr;
            /*6211*/
        }
        /*6212*/
        public void Release()
        {
            /*6213*/
            JsValue ret;
            /*6214*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_Release_0, out ret);
            /*6215*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefPostDataElement methods.
        /// </summary>
        /*6216*/

        public bool IsReadOnly()/*6217*/
        {
            JsValue ret;
            /*6218*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_IsReadOnly_1, out ret);
            /*6219*/
            var ret_result = ret.I32 != 0;
            /*6220*/
            return ret_result;
            /*6221*/
        }

        // gen! void SetToEmpty()
        /// <summary>
        /// Remove all contents from the post data element.
        /// /*cef()*/
        /// </summary>
        /*6222*/

        public void SetToEmpty()/*6223*/
        {
            JsValue ret;
            /*6224*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_SetToEmpty_2, out ret);
            /*6225*/

            /*6226*/
        }

        // gen! void SetToFile(const CefString& fileName)
        /// <summary>
        /// The post data element will represent a file.
        /// /*cef()*/
        /// </summary>
        /*6227*/

        public void SetToFile(string /*6228*/
        fileName
        )/*6229*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(fileName);
            /*6230*/
            ;
            /*6231*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefPostDataElement_SetToFile_3, out ret, ref v1);
            /*6232*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6233*/
            ;
            /*6234*/
        }

        // gen! void SetToBytes(size_t size,const void* bytes)
        /// <summary>
        /// The post data element will represent bytes.  The bytes passed
        /// in will be copied.
        /// /*cef()*/
        /// </summary>
        /*6235*/

        public void SetToBytes(uint /*6236*/
        size
        , IntPtr /*6237*/
        bytes
        )/*6238*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)size/*6239*/
            ;
            v2.Ptr = bytes/*6240*/
            ;
            /*6241*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefPostDataElement_SetToBytes_4, out ret, ref v1, ref v2);
            /*6242*/

            /*6243*/
        }

        // gen! Type GetType()
        /// <summary>
        /// Return the type of this post data element.
        /// /*cef(default_retval=PDE_TYPE_EMPTY)*/
        /// </summary>
        /*6244*/

        public cef_postdataelement_type_t _GetType()/*6245*/
        {
            JsValue ret;
            /*6246*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetType_5, out ret);
            /*6247*/
            var ret_result = (cef_postdataelement_type_t)ret.I32;

            /*6248*/
            return ret_result;
            /*6249*/
        }

        // gen! CefString GetFile()
        /// <summary>
        /// Return the file name.
        /// /*cef()*/
        /// </summary>
        /*6250*/

        public string GetFile()/*6251*/
        {
            JsValue ret;
            /*6252*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetFile_6, out ret);
            /*6253*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6254*/
            return ret_result;
            /*6255*/
        }

        // gen! size_t GetBytesCount()
        /// <summary>
        /// Return the number of bytes.
        /// /*cef()*/
        /// </summary>
        /*6256*/

        public uint GetBytesCount()/*6257*/
        {
            JsValue ret;
            /*6258*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefPostDataElement_GetBytesCount_7, out ret);
            /*6259*/
            var ret_result = (uint)ret.I32;
            /*6260*/
            return ret_result;
            /*6261*/
        }

        // gen! size_t GetBytes(size_t size,void* bytes)
        /// <summary>
        /// Read up to |size| bytes into |bytes| and return the number of bytes
        /// actually read.
        /// /*cef()*/
        /// </summary>
        /*6262*/

        public uint GetBytes(uint /*6263*/
        size
        , IntPtr /*6264*/
        bytes
        )/*6265*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)size/*6266*/
            ;
            v2.Ptr = bytes/*6267*/
            ;
            /*6268*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefPostDataElement_GetBytes_8, out ret, ref v1, ref v2);
            /*6269*/
            var ret_result = (uint)ret.I32;
            /*6270*/
            return ret_result;
            /*6271*/
        }
        /*6272*/
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
    /*6371*/
    public struct CefRequestContext
    {
        /*6372*/
        const int _typeNAME = 25;
        /*6373*/
        const int CefRequestContext_Release_0 = (_typeNAME << 16) | 0;
        /*6374*/
        const int CefRequestContext_IsSame_1 = (_typeNAME << 16) | 1;
        /*6375*/
        const int CefRequestContext_IsSharingWith_2 = (_typeNAME << 16) | 2;
        /*6376*/
        const int CefRequestContext_IsGlobal_3 = (_typeNAME << 16) | 3;
        /*6377*/
        const int CefRequestContext_GetHandler_4 = (_typeNAME << 16) | 4;
        /*6378*/
        const int CefRequestContext_GetCachePath_5 = (_typeNAME << 16) | 5;
        /*6379*/
        const int CefRequestContext_GetDefaultCookieManager_6 = (_typeNAME << 16) | 6;
        /*6380*/
        const int CefRequestContext_RegisterSchemeHandlerFactory_7 = (_typeNAME << 16) | 7;
        /*6381*/
        const int CefRequestContext_ClearSchemeHandlerFactories_8 = (_typeNAME << 16) | 8;
        /*6382*/
        const int CefRequestContext_PurgePluginListCache_9 = (_typeNAME << 16) | 9;
        /*6383*/
        const int CefRequestContext_HasPreference_10 = (_typeNAME << 16) | 10;
        /*6384*/
        const int CefRequestContext_GetPreference_11 = (_typeNAME << 16) | 11;
        /*6385*/
        const int CefRequestContext_GetAllPreferences_12 = (_typeNAME << 16) | 12;
        /*6386*/
        const int CefRequestContext_CanSetPreference_13 = (_typeNAME << 16) | 13;
        /*6387*/
        const int CefRequestContext_SetPreference_14 = (_typeNAME << 16) | 14;
        /*6388*/
        const int CefRequestContext_ClearCertificateExceptions_15 = (_typeNAME << 16) | 15;
        /*6389*/
        const int CefRequestContext_CloseAllConnections_16 = (_typeNAME << 16) | 16;
        /*6390*/
        const int CefRequestContext_ResolveHost_17 = (_typeNAME << 16) | 17;
        /*6391*/
        const int CefRequestContext_ResolveHostCached_18 = (_typeNAME << 16) | 18;
        /*6392*/
        internal readonly IntPtr nativePtr;
        /*6393*/
        internal CefRequestContext(IntPtr nativePtr)
        {
            /*6394*/
            this.nativePtr = nativePtr;
            /*6395*/
        }
        /*6396*/
        public void Release()
        {
            /*6397*/
            JsValue ret;
            /*6398*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_Release_0, out ret);
            /*6399*/
        }

        // gen! bool IsSame(CefRefPtr<CefRequestContext> other)
        /// <summary>
        /// CefRequestContext methods.
        /// </summary>
        /*6400*/

        public bool IsSame(CefRequestContext /*6401*/
        other
        )/*6402*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = other.nativePtr/*6403*/
            ;
            /*6404*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_IsSame_1, out ret, ref v1);
            /*6405*/
            var ret_result = ret.I32 != 0;
            /*6406*/
            return ret_result;
            /*6407*/
        }

        // gen! bool IsSharingWith(CefRefPtr<CefRequestContext> other)
        /// <summary>
        /// Returns true if this object is sharing the same storage as |that| object.
        /// /*cef()*/
        /// </summary>
        /*6408*/

        public bool IsSharingWith(CefRequestContext /*6409*/
        other
        )/*6410*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = other.nativePtr/*6411*/
            ;
            /*6412*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_IsSharingWith_2, out ret, ref v1);
            /*6413*/
            var ret_result = ret.I32 != 0;
            /*6414*/
            return ret_result;
            /*6415*/
        }

        // gen! bool IsGlobal()
        /// <summary>
        /// Returns true if this object is the global context. The global context is
        /// used by default when creating a browser or URL request with a NULL context
        /// argument.
        /// /*cef()*/
        /// </summary>
        /*6416*/

        public bool IsGlobal()/*6417*/
        {
            JsValue ret;
            /*6418*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_IsGlobal_3, out ret);
            /*6419*/
            var ret_result = ret.I32 != 0;
            /*6420*/
            return ret_result;
            /*6421*/
        }

        // gen! CefRefPtr<CefRequestContextHandler> GetHandler()
        /// <summary>
        /// Returns the handler for this context if any.
        /// /*cef()*/
        /// </summary>
        /*6422*/

        public CefRequestContextHandler GetHandler()/*6423*/
        {
            JsValue ret;
            /*6424*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_GetHandler_4, out ret);
            /*6425*/
            var ret_result = new CefRequestContextHandler(ret.Ptr);
            /*6426*/
            return ret_result;
            /*6427*/
        }

        // gen! CefString GetCachePath()
        /// <summary>
        /// Returns the cache path for this object. If empty an "incognito mode"
        /// in-memory cache is being used.
        /// /*cef()*/
        /// </summary>
        /*6428*/

        public string GetCachePath()/*6429*/
        {
            JsValue ret;
            /*6430*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_GetCachePath_5, out ret);
            /*6431*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6432*/
            return ret_result;
            /*6433*/
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
        /*6434*/

        public CefCookieManager GetDefaultCookieManager(CefCompletionCallback /*6435*/
        callback
        )/*6436*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = callback.nativePtr/*6437*/
            ;
            /*6438*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetDefaultCookieManager_6, out ret, ref v1);
            /*6439*/
            var ret_result = new CefCookieManager(ret.Ptr);
            /*6440*/
            return ret_result;
            /*6441*/
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
        /*6442*/

        public bool RegisterSchemeHandlerFactory(string /*6443*/
        scheme_name
        , string /*6444*/
        domain_name
        , CefSchemeHandlerFactory /*6445*/
        factory
        )/*6446*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(scheme_name);
            /*6447*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(domain_name);
            /*6448*/
            ;
            v3.Ptr = factory.nativePtr/*6449*/
            ;
            /*6450*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefRequestContext_RegisterSchemeHandlerFactory_7, out ret, ref v1, ref v2, ref v3);
            /*6451*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6452*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*6453*/
            ;
            /*6454*/
            return ret_result;
            /*6455*/
        }

        // gen! bool ClearSchemeHandlerFactories()
        /// <summary>
        /// Clear all registered scheme handler factories. Returns false on error. This
        /// function may be called on any thread in the browser process.
        /// /*cef()*/
        /// </summary>
        /*6456*/

        public bool ClearSchemeHandlerFactories()/*6457*/
        {
            JsValue ret;
            /*6458*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefRequestContext_ClearSchemeHandlerFactories_8, out ret);
            /*6459*/
            var ret_result = ret.I32 != 0;
            /*6460*/
            return ret_result;
            /*6461*/
        }

        // gen! void PurgePluginListCache(bool reload_pages)
        /// <summary>
        /// Tells all renderer processes associated with this context to throw away
        /// their plugin list cache. If |reload_pages| is true they will also reload
        /// all pages with plugins. CefRequestContextHandler::OnBeforePluginLoad may
        /// be called to rebuild the plugin list cache.
        /// /*cef()*/
        /// </summary>
        /*6462*/

        public void PurgePluginListCache(bool /*6463*/
        reload_pages
        )/*6464*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = reload_pages ? 1 : 0/*6465*/
            ;
            /*6466*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_PurgePluginListCache_9, out ret, ref v1);
            /*6467*/

            /*6468*/
        }

        // gen! bool HasPreference(const CefString& name)
        /// <summary>
        /// Returns true if a preference with the specified |name| exists. This method
        /// must be called on the browser process UI thread.
        /// /*cef()*/
        /// </summary>
        /*6469*/

        public bool HasPreference(string /*6470*/
        name
        )/*6471*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6472*/
            ;
            /*6473*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_HasPreference_10, out ret, ref v1);
            /*6474*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6475*/
            ;
            /*6476*/
            return ret_result;
            /*6477*/
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
        /*6478*/

        public CefValue GetPreference(string /*6479*/
        name
        )/*6480*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6481*/
            ;
            /*6482*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetPreference_11, out ret, ref v1);
            /*6483*/
            var ret_result = new CefValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6484*/
            ;
            /*6485*/
            return ret_result;
            /*6486*/
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
        /*6487*/

        public CefDictionaryValue GetAllPreferences(bool /*6488*/
        include_defaults
        )/*6489*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = include_defaults ? 1 : 0/*6490*/
            ;
            /*6491*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_GetAllPreferences_12, out ret, ref v1);
            /*6492*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            /*6493*/
            return ret_result;
            /*6494*/
        }

        // gen! bool CanSetPreference(const CefString& name)
        /// <summary>
        /// Returns true if the preference with the specified |name| can be modified
        /// using SetPreference. As one example preferences set via the command-line
        /// usually cannot be modified. This method must be called on the browser
        /// process UI thread.
        /// /*cef()*/
        /// </summary>
        /*6495*/

        public bool CanSetPreference(string /*6496*/
        name
        )/*6497*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6498*/
            ;
            /*6499*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_CanSetPreference_13, out ret, ref v1);
            /*6500*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6501*/
            ;
            /*6502*/
            return ret_result;
            /*6503*/
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
        /*6504*/

        public bool SetPreference(string /*6505*/
        name
        , CefValue /*6506*/
        value
        , string /*6507*/
        error
        )/*6508*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6509*/
            ;
            v3.Ptr = Cef3Binder.MyCefCreateCefString(error);
            /*6510*/
            ;
            v2.Ptr = value.nativePtr/*6511*/
            ;
            /*6512*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefRequestContext_SetPreference_14, out ret, ref v1, ref v2, ref v3);
            /*6513*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6514*/
            ;
            Cef3Binder.MyCefDeletePtr(v3.Ptr);/*6515*/
            ;
            /*6516*/
            return ret_result;
            /*6517*/
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
        /*6518*/

        public void ClearCertificateExceptions(CefCompletionCallback /*6519*/
        callback
        )/*6520*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = callback.nativePtr/*6521*/
            ;
            /*6522*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_ClearCertificateExceptions_15, out ret, ref v1);
            /*6523*/

            /*6524*/
        }

        // gen! void CloseAllConnections(CefRefPtr<CefCompletionCallback> callback)
        /// <summary>
        /// Clears all active and idle connections that Chromium currently has.
        /// This is only recommended if you have released all other CEF objects but
        /// don't yet want to call CefShutdown(). If |callback| is non-NULL it will be
        /// executed on the UI thread after completion.
        /// /*cef(optional_param=callback)*/
        /// </summary>
        /*6525*/

        public void CloseAllConnections(CefCompletionCallback /*6526*/
        callback
        )/*6527*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = callback.nativePtr/*6528*/
            ;
            /*6529*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefRequestContext_CloseAllConnections_16, out ret, ref v1);
            /*6530*/

            /*6531*/
        }

        // gen! void ResolveHost(const CefString& origin,CefRefPtr<CefResolveCallback> callback)
        /// <summary>
        /// Attempts to resolve |origin| to a list of associated IP addresses.
        /// |callback| will be executed on the UI thread after completion.
        /// /*cef()*/
        /// </summary>
        /*6532*/

        public void ResolveHost(string /*6533*/
        origin
        , CefResolveCallback /*6534*/
        callback
        )/*6535*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(origin);
            /*6536*/
            ;
            v2.Ptr = callback.nativePtr/*6537*/
            ;
            /*6538*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequestContext_ResolveHost_17, out ret, ref v1, ref v2);
            /*6539*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6540*/
            ;
            /*6541*/
        }

        // gen! cef_errorcode_t ResolveHostCached(const CefString& origin,std::vector<CefString>& resolved_ips)
        /// <summary>
        /// Attempts to resolve |origin| to a list of associated IP addresses using
        /// cached data. |resolved_ips| will be populated with the list of resolved IP
        /// addresses or empty if no cached data is available. Returns ERR_NONE on
        /// success. This method must be called on the browser process IO thread.
        /// /*cef(default_retval=ERR_FAILED)*/
        /// </summary>
        /*6542*/

        public cef_errorcode_t ResolveHostCached(string /*6543*/
        origin
        , List<string> /*6544*/
        resolved_ips
        )/*6545*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(origin);
            /*6546*/
            ;
            v2.Ptr = Cef3Binder.CreateStdList(2)/*6547*/
            ;
            /*6548*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefRequestContext_ResolveHostCached_18, out ret, ref v1, ref v2);
            /*6549*/
            var ret_result = (cef_errorcode_t)ret.I32;

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6550*/
            ;
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v2.Ptr, resolved_ips)/*6551*/
            ;
            /*6552*/
            return ret_result;
            /*6553*/
        }
        /*6554*/
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
    /*6578*/
    public struct CefResourceBundle
    {
        /*6579*/
        const int _typeNAME = 26;
        /*6580*/
        const int CefResourceBundle_Release_0 = (_typeNAME << 16) | 0;
        /*6581*/
        const int CefResourceBundle_GetLocalizedString_1 = (_typeNAME << 16) | 1;
        /*6582*/
        const int CefResourceBundle_GetDataResource_2 = (_typeNAME << 16) | 2;
        /*6583*/
        const int CefResourceBundle_GetDataResourceForScale_3 = (_typeNAME << 16) | 3;
        /*6584*/
        internal readonly IntPtr nativePtr;
        /*6585*/
        internal CefResourceBundle(IntPtr nativePtr)
        {
            /*6586*/
            this.nativePtr = nativePtr;
            /*6587*/
        }
        /*6588*/
        public void Release()
        {
            /*6589*/
            JsValue ret;
            /*6590*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResourceBundle_Release_0, out ret);
            /*6591*/
        }

        // gen! CefString GetLocalizedString(int string_id)
        /// <summary>
        /// CefResourceBundle methods.
        /// </summary>
        /*6592*/

        public string GetLocalizedString(int /*6593*/
        string_id
        )/*6594*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)string_id/*6595*/
            ;
            /*6596*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResourceBundle_GetLocalizedString_1, out ret, ref v1);
            /*6597*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6598*/
            return ret_result;
            /*6599*/
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
        /*6600*/

        public bool GetDataResource(int /*6601*/
        resource_id
        , IntPtr /*6602*/
        data
        , ref uint /*6603*/
        data_size
        )/*6604*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.I32 = (int)resource_id/*6605*/
            ;
            v2.Ptr = data/*6606*/
            ;
            v3.I32 = (int)data_size/*6607*/
            ;
            /*6608*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefResourceBundle_GetDataResource_2, out ret, ref v1, ref v2, ref v3);
            /*6609*/
            var ret_result = ret.I32 != 0;
            data = v2.Ptr;/*6610*/
            ;
            data_size = (uint)v3.I32;/*6611*/
            ;
            /*6612*/
            return ret_result;
            /*6613*/
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
        /*6614*/

        public bool GetDataResourceForScale(int /*6615*/
        resource_id
        , cef_scale_factor_t /*6616*/
        scale_factor
        , IntPtr /*6617*/
        data
        , ref uint /*6618*/
        data_size
        )/*6619*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue ret;
            v1.I32 = (int)resource_id/*6620*/
            ;
            v2.I32 = (int)scale_factor/*6621*/
            ;
            v3.Ptr = data/*6622*/
            ;
            v4.I32 = (int)data_size/*6623*/
            ;
            /*6624*/

            Cef3Binder.MyCefMet_Call4(this.nativePtr, CefResourceBundle_GetDataResourceForScale_3, out ret, ref v1, ref v2, ref v3, ref v4);
            /*6625*/
            var ret_result = ret.I32 != 0;
            data = v3.Ptr;/*6626*/
            ;
            data_size = (uint)v4.I32;/*6627*/
            ;
            /*6628*/
            return ret_result;
            /*6629*/
        }
        /*6630*/
    }


    // [virtual] class CefResponse
    /// <summary>
    /// Class used to represent a web response. The methods of this class may be
    /// called on any thread.
    /// /*(source=library,no_debugct_check)*/
    /// </summary>
    /*6699*/
    public struct CefResponse
    {
        /*6700*/
        const int _typeNAME = 27;
        /*6701*/
        const int CefResponse_Release_0 = (_typeNAME << 16) | 0;
        /*6702*/
        const int CefResponse_IsReadOnly_1 = (_typeNAME << 16) | 1;
        /*6703*/
        const int CefResponse_GetError_2 = (_typeNAME << 16) | 2;
        /*6704*/
        const int CefResponse_SetError_3 = (_typeNAME << 16) | 3;
        /*6705*/
        const int CefResponse_GetStatus_4 = (_typeNAME << 16) | 4;
        /*6706*/
        const int CefResponse_SetStatus_5 = (_typeNAME << 16) | 5;
        /*6707*/
        const int CefResponse_GetStatusText_6 = (_typeNAME << 16) | 6;
        /*6708*/
        const int CefResponse_SetStatusText_7 = (_typeNAME << 16) | 7;
        /*6709*/
        const int CefResponse_GetMimeType_8 = (_typeNAME << 16) | 8;
        /*6710*/
        const int CefResponse_SetMimeType_9 = (_typeNAME << 16) | 9;
        /*6711*/
        const int CefResponse_GetHeader_10 = (_typeNAME << 16) | 10;
        /*6712*/
        const int CefResponse_GetHeaderMap_11 = (_typeNAME << 16) | 11;
        /*6713*/
        const int CefResponse_SetHeaderMap_12 = (_typeNAME << 16) | 12;
        /*6714*/
        internal readonly IntPtr nativePtr;
        /*6715*/
        internal CefResponse(IntPtr nativePtr)
        {
            /*6716*/
            this.nativePtr = nativePtr;
            /*6717*/
        }
        /*6718*/
        public void Release()
        {
            /*6719*/
            JsValue ret;
            /*6720*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_Release_0, out ret);
            /*6721*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// CefResponse methods.
        /// </summary>
        /*6722*/

        public bool IsReadOnly()/*6723*/
        {
            JsValue ret;
            /*6724*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_IsReadOnly_1, out ret);
            /*6725*/
            var ret_result = ret.I32 != 0;
            /*6726*/
            return ret_result;
            /*6727*/
        }

        // gen! cef_errorcode_t GetError()
        /// <summary>
        /// Get the response error code. Returns ERR_NONE if there was no error.
        /// /*cef(default_retval=ERR_NONE)*/
        /// </summary>
        /*6728*/

        public cef_errorcode_t GetError()/*6729*/
        {
            JsValue ret;
            /*6730*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetError_2, out ret);
            /*6731*/
            var ret_result = (cef_errorcode_t)ret.I32;

            /*6732*/
            return ret_result;
            /*6733*/
        }

        // gen! void SetError(cef_errorcode_t error)
        /// <summary>
        /// Set the response error code. This can be used by custom scheme handlers
        /// to return errors during initial request processing.
        /// /*cef()*/
        /// </summary>
        /*6734*/

        public void SetError(cef_errorcode_t /*6735*/
        error
        )/*6736*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)error/*6737*/
            ;
            /*6738*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetError_3, out ret, ref v1);
            /*6739*/

            /*6740*/
        }

        // gen! int GetStatus()
        /// <summary>
        /// Get the response status code.
        /// /*cef()*/
        /// </summary>
        /*6741*/

        public int GetStatus()/*6742*/
        {
            JsValue ret;
            /*6743*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetStatus_4, out ret);
            /*6744*/
            var ret_result = ret.I32;
            /*6745*/
            return ret_result;
            /*6746*/
        }

        // gen! void SetStatus(int status)
        /// <summary>
        /// Set the response status code.
        /// /*cef()*/
        /// </summary>
        /*6747*/

        public void SetStatus(int /*6748*/
        status
        )/*6749*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)status/*6750*/
            ;
            /*6751*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetStatus_5, out ret, ref v1);
            /*6752*/

            /*6753*/
        }

        // gen! CefString GetStatusText()
        /// <summary>
        /// Get the response status text.
        /// /*cef()*/
        /// </summary>
        /*6754*/

        public string GetStatusText()/*6755*/
        {
            JsValue ret;
            /*6756*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetStatusText_6, out ret);
            /*6757*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6758*/
            return ret_result;
            /*6759*/
        }

        // gen! void SetStatusText(const CefString& statusText)
        /// <summary>
        /// Set the response status text.
        /// /*cef()*/
        /// </summary>
        /*6760*/

        public void SetStatusText(string /*6761*/
        statusText
        )/*6762*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(statusText);
            /*6763*/
            ;
            /*6764*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetStatusText_7, out ret, ref v1);
            /*6765*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6766*/
            ;
            /*6767*/
        }

        // gen! CefString GetMimeType()
        /// <summary>
        /// Get the response mime type.
        /// /*cef()*/
        /// </summary>
        /*6768*/

        public string GetMimeType()/*6769*/
        {
            JsValue ret;
            /*6770*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponse_GetMimeType_8, out ret);
            /*6771*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*6772*/
            return ret_result;
            /*6773*/
        }

        // gen! void SetMimeType(const CefString& mimeType)
        /// <summary>
        /// Set the response mime type.
        /// /*cef()*/
        /// </summary>
        /*6774*/

        public void SetMimeType(string /*6775*/
        mimeType
        )/*6776*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(mimeType);
            /*6777*/
            ;
            /*6778*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetMimeType_9, out ret, ref v1);
            /*6779*/

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6780*/
            ;
            /*6781*/
        }

        // gen! CefString GetHeader(const CefString& name)
        /// <summary>
        /// Get the value for the specified response header field.
        /// /*cef()*/
        /// </summary>
        /*6782*/

        public string GetHeader(string /*6783*/
        name
        )/*6784*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(name);
            /*6785*/
            ;
            /*6786*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_GetHeader_10, out ret, ref v1);
            /*6787*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*6788*/
            ;
            /*6789*/
            return ret_result;
            /*6790*/
        }

        // gen! void GetHeaderMap(HeaderMap& headerMap)
        /// <summary>
        /// Get all response header fields.
        /// /*cef()*/
        /// </summary>
        /*6791*/

        public void GetHeaderMap(HeaderMap /*6792*/
        headerMap
        )/*6793*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = headerMap.nativePtr/*6794*/
            ;
            /*6795*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_GetHeaderMap_11, out ret, ref v1);
            /*6796*/

            /*6797*/
        }

        // gen! void SetHeaderMap(const HeaderMap& headerMap)
        /// <summary>
        /// Set all response header fields.
        /// /*cef()*/
        /// </summary>
        /*6798*/

        public void SetHeaderMap(HeaderMap /*6799*/
        headerMap
        )/*6800*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = headerMap.nativePtr/*6801*/
            ;
            /*6802*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefResponse_SetHeaderMap_12, out ret, ref v1);
            /*6803*/

            /*6804*/
        }
        /*6805*/
    }


    // [virtual] class CefResponseFilter
    /// <summary>
    /// Implement this interface to filter resource response content. The methods of
    /// this class will be called on the browser process IO thread.
    /// /*(source=client)*/
    /// </summary>
    /*6814*/
    public struct CefResponseFilter
    {
        /*6815*/
        const int _typeNAME = 28;
        /*6816*/
        const int CefResponseFilter_Release_0 = (_typeNAME << 16) | 0;
        /*6817*/
        internal readonly IntPtr nativePtr;
        /*6818*/
        internal CefResponseFilter(IntPtr nativePtr)
        {
            /*6819*/
            this.nativePtr = nativePtr;
            /*6820*/
        }
        /*6821*/
        public void Release()
        {
            /*6822*/
            JsValue ret;
            /*6823*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefResponseFilter_Release_0, out ret);
            /*6824*/
        }
        /*6825*/
    }


    // [virtual] class CefSchemeHandlerFactory
    /// <summary>
    /// Class that creates CefResourceHandler instances for handling scheme requests.
    /// The methods of this class will always be called on the IO thread.
    /// /*(source=client)*/
    /// </summary>
    /*6834*/
    public struct CefSchemeHandlerFactory
    {
        /*6835*/
        const int _typeNAME = 29;
        /*6836*/
        const int CefSchemeHandlerFactory_Release_0 = (_typeNAME << 16) | 0;
        /*6837*/
        internal readonly IntPtr nativePtr;
        /*6838*/
        internal CefSchemeHandlerFactory(IntPtr nativePtr)
        {
            /*6839*/
            this.nativePtr = nativePtr;
            /*6840*/
        }
        /*6841*/
        public void Release()
        {
            /*6842*/
            JsValue ret;
            /*6843*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSchemeHandlerFactory_Release_0, out ret);
            /*6844*/
        }
        /*6845*/
    }


    // [virtual] class CefSSLInfo
    /// <summary>
    /// Class representing SSL information.
    /// /*(source=library)*/
    /// </summary>
    /*6864*/
    public struct CefSSLInfo
    {
        /*6865*/
        const int _typeNAME = 30;
        /*6866*/
        const int CefSSLInfo_Release_0 = (_typeNAME << 16) | 0;
        /*6867*/
        const int CefSSLInfo_GetCertStatus_1 = (_typeNAME << 16) | 1;
        /*6868*/
        const int CefSSLInfo_GetX509Certificate_2 = (_typeNAME << 16) | 2;
        /*6869*/
        internal readonly IntPtr nativePtr;
        /*6870*/
        internal CefSSLInfo(IntPtr nativePtr)
        {
            /*6871*/
            this.nativePtr = nativePtr;
            /*6872*/
        }
        /*6873*/
        public void Release()
        {
            /*6874*/
            JsValue ret;
            /*6875*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_Release_0, out ret);
            /*6876*/
        }

        // gen! cef_cert_status_t GetCertStatus()
        /// <summary>
        /// CefSSLInfo methods.
        /// </summary>
        /*6877*/

        public cef_cert_status_t GetCertStatus()/*6878*/
        {
            JsValue ret;
            /*6879*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_GetCertStatus_1, out ret);
            /*6880*/
            var ret_result = (cef_cert_status_t)ret.I32;

            /*6881*/
            return ret_result;
            /*6882*/
        }

        // gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
        /// <summary>
        /// Returns the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*6883*/

        public CefX509Certificate GetX509Certificate()/*6884*/
        {
            JsValue ret;
            /*6885*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLInfo_GetX509Certificate_2, out ret);
            /*6886*/
            var ret_result = new CefX509Certificate(ret.Ptr);
            /*6887*/
            return ret_result;
            /*6888*/
        }
        /*6889*/
    }


    // [virtual] class CefSSLStatus
    /// <summary>
    /// Class representing the SSL information for a navigation entry.
    /// /*(source=library)*/
    /// </summary>
    /*6923*/
    public struct CefSSLStatus
    {
        /*6924*/
        const int _typeNAME = 31;
        /*6925*/
        const int CefSSLStatus_Release_0 = (_typeNAME << 16) | 0;
        /*6926*/
        const int CefSSLStatus_IsSecureConnection_1 = (_typeNAME << 16) | 1;
        /*6927*/
        const int CefSSLStatus_GetCertStatus_2 = (_typeNAME << 16) | 2;
        /*6928*/
        const int CefSSLStatus_GetSSLVersion_3 = (_typeNAME << 16) | 3;
        /*6929*/
        const int CefSSLStatus_GetContentStatus_4 = (_typeNAME << 16) | 4;
        /*6930*/
        const int CefSSLStatus_GetX509Certificate_5 = (_typeNAME << 16) | 5;
        /*6931*/
        internal readonly IntPtr nativePtr;
        /*6932*/
        internal CefSSLStatus(IntPtr nativePtr)
        {
            /*6933*/
            this.nativePtr = nativePtr;
            /*6934*/
        }
        /*6935*/
        public void Release()
        {
            /*6936*/
            JsValue ret;
            /*6937*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_Release_0, out ret);
            /*6938*/
        }

        // gen! bool IsSecureConnection()
        /// <summary>
        /// CefSSLStatus methods.
        /// </summary>
        /*6939*/

        public bool IsSecureConnection()/*6940*/
        {
            JsValue ret;
            /*6941*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_IsSecureConnection_1, out ret);
            /*6942*/
            var ret_result = ret.I32 != 0;
            /*6943*/
            return ret_result;
            /*6944*/
        }

        // gen! cef_cert_status_t GetCertStatus()
        /// <summary>
        /// Returns a bitmask containing any and all problems verifying the server
        /// certificate.
        /// /*cef(default_retval=CERT_STATUS_NONE)*/
        /// </summary>
        /*6945*/

        public cef_cert_status_t GetCertStatus()/*6946*/
        {
            JsValue ret;
            /*6947*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetCertStatus_2, out ret);
            /*6948*/
            var ret_result = (cef_cert_status_t)ret.I32;

            /*6949*/
            return ret_result;
            /*6950*/
        }

        // gen! cef_ssl_version_t GetSSLVersion()
        /// <summary>
        /// Returns the SSL version used for the SSL connection.
        /// /*cef(default_retval=SSL_CONNECTION_VERSION_UNKNOWN)*/
        /// </summary>
        /*6951*/

        public cef_ssl_version_t GetSSLVersion()/*6952*/
        {
            JsValue ret;
            /*6953*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetSSLVersion_3, out ret);
            /*6954*/
            var ret_result = (cef_ssl_version_t)ret.I32;

            /*6955*/
            return ret_result;
            /*6956*/
        }

        // gen! cef_ssl_content_status_t GetContentStatus()
        /// <summary>
        /// Returns a bitmask containing the page security content status.
        /// /*cef(default_retval=SSL_CONTENT_NORMAL_CONTENT)*/
        /// </summary>
        /*6957*/

        public cef_ssl_content_status_t GetContentStatus()/*6958*/
        {
            JsValue ret;
            /*6959*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetContentStatus_4, out ret);
            /*6960*/
            var ret_result = (cef_ssl_content_status_t)ret.I32;

            /*6961*/
            return ret_result;
            /*6962*/
        }

        // gen! CefRefPtr<CefX509Certificate> GetX509Certificate()
        /// <summary>
        /// Returns the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*6963*/

        public CefX509Certificate GetX509Certificate()/*6964*/
        {
            JsValue ret;
            /*6965*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefSSLStatus_GetX509Certificate_5, out ret);
            /*6966*/
            var ret_result = new CefX509Certificate(ret.Ptr);
            /*6967*/
            return ret_result;
            /*6968*/
        }
        /*6969*/
    }


    // [virtual] class CefStreamReader
    /// <summary>
    /// Class used to read data from a stream. The methods of this class may be
    /// called on any thread.
    /// /*(source=library)*/
    /// </summary>
    /*7003*/
    public struct CefStreamReader
    {
        /*7004*/
        const int _typeNAME = 32;
        /*7005*/
        const int CefStreamReader_Release_0 = (_typeNAME << 16) | 0;
        /*7006*/
        const int CefStreamReader_Read_1 = (_typeNAME << 16) | 1;
        /*7007*/
        const int CefStreamReader_Seek_2 = (_typeNAME << 16) | 2;
        /*7008*/
        const int CefStreamReader_Tell_3 = (_typeNAME << 16) | 3;
        /*7009*/
        const int CefStreamReader_Eof_4 = (_typeNAME << 16) | 4;
        /*7010*/
        const int CefStreamReader_MayBlock_5 = (_typeNAME << 16) | 5;
        /*7011*/
        internal readonly IntPtr nativePtr;
        /*7012*/
        internal CefStreamReader(IntPtr nativePtr)
        {
            /*7013*/
            this.nativePtr = nativePtr;
            /*7014*/
        }
        /*7015*/
        public void Release()
        {
            /*7016*/
            JsValue ret;
            /*7017*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Release_0, out ret);
            /*7018*/
        }

        // gen! size_t Read(void* ptr,size_t size,size_t n)
        /// <summary>
        /// CefStreamReader methods.
        /// </summary>
        /*7019*/

        public uint Read(IntPtr /*7020*/
        ptr
        , uint /*7021*/
        size
        , uint /*7022*/
        n
        )/*7023*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = ptr/*7024*/
            ;
            v2.I32 = (int)size/*7025*/
            ;
            v3.I32 = (int)n/*7026*/
            ;
            /*7027*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefStreamReader_Read_1, out ret, ref v1, ref v2, ref v3);
            /*7028*/
            var ret_result = (uint)ret.I32;
            /*7029*/
            return ret_result;
            /*7030*/
        }

        // gen! int Seek(int64 offset,int whence)
        /// <summary>
        /// Seek to the specified offset position. |whence| may be any one of
        /// SEEK_CUR, SEEK_END or SEEK_SET. Returns zero on success and non-zero on
        /// failure.
        /// /*cef()*/
        /// </summary>
        /*7031*/

        public int Seek(long /*7032*/
        offset
        , int /*7033*/
        whence
        )/*7034*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I64 = offset/*7035*/
            ;
            v2.I32 = (int)whence/*7036*/
            ;
            /*7037*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefStreamReader_Seek_2, out ret, ref v1, ref v2);
            /*7038*/
            var ret_result = ret.I32;
            /*7039*/
            return ret_result;
            /*7040*/
        }

        // gen! int64 Tell()
        /// <summary>
        /// Return the current offset position.
        /// /*cef()*/
        /// </summary>
        /*7041*/

        public long Tell()/*7042*/
        {
            JsValue ret;
            /*7043*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Tell_3, out ret);
            /*7044*/
            var ret_result = ret.I64;
            /*7045*/
            return ret_result;
            /*7046*/
        }

        // gen! int Eof()
        /// <summary>
        /// Return non-zero if at end of file.
        /// /*cef()*/
        /// </summary>
        /*7047*/

        public int Eof()/*7048*/
        {
            JsValue ret;
            /*7049*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_Eof_4, out ret);
            /*7050*/
            var ret_result = ret.I32;
            /*7051*/
            return ret_result;
            /*7052*/
        }

        // gen! bool MayBlock()
        /// <summary>
        /// Returns true if this reader performs work like accessing the file system
        /// which may block. Used as a hint for determining the thread to access the
        /// reader from.
        /// /*cef()*/
        /// </summary>
        /*7053*/

        public bool MayBlock()/*7054*/
        {
            JsValue ret;
            /*7055*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamReader_MayBlock_5, out ret);
            /*7056*/
            var ret_result = ret.I32 != 0;
            /*7057*/
            return ret_result;
            /*7058*/
        }
        /*7059*/
    }


    // [virtual] class CefStreamWriter
    /// <summary>
    /// Class used to write data to a stream. The methods of this class may be called
    /// on any thread.
    /// /*(source=library)*/
    /// </summary>
    /*7093*/
    public struct CefStreamWriter
    {
        /*7094*/
        const int _typeNAME = 33;
        /*7095*/
        const int CefStreamWriter_Release_0 = (_typeNAME << 16) | 0;
        /*7096*/
        const int CefStreamWriter_Write_1 = (_typeNAME << 16) | 1;
        /*7097*/
        const int CefStreamWriter_Seek_2 = (_typeNAME << 16) | 2;
        /*7098*/
        const int CefStreamWriter_Tell_3 = (_typeNAME << 16) | 3;
        /*7099*/
        const int CefStreamWriter_Flush_4 = (_typeNAME << 16) | 4;
        /*7100*/
        const int CefStreamWriter_MayBlock_5 = (_typeNAME << 16) | 5;
        /*7101*/
        internal readonly IntPtr nativePtr;
        /*7102*/
        internal CefStreamWriter(IntPtr nativePtr)
        {
            /*7103*/
            this.nativePtr = nativePtr;
            /*7104*/
        }
        /*7105*/
        public void Release()
        {
            /*7106*/
            JsValue ret;
            /*7107*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Release_0, out ret);
            /*7108*/
        }

        // gen! size_t Write(const void* ptr,size_t size,size_t n)
        /// <summary>
        /// CefStreamWriter methods.
        /// </summary>
        /*7109*/

        public uint Write(IntPtr /*7110*/
        ptr
        , uint /*7111*/
        size
        , uint /*7112*/
        n
        )/*7113*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = ptr/*7114*/
            ;
            v2.I32 = (int)size/*7115*/
            ;
            v3.I32 = (int)n/*7116*/
            ;
            /*7117*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefStreamWriter_Write_1, out ret, ref v1, ref v2, ref v3);
            /*7118*/
            var ret_result = (uint)ret.I32;
            /*7119*/
            return ret_result;
            /*7120*/
        }

        // gen! int Seek(int64 offset,int whence)
        /// <summary>
        /// Seek to the specified offset position. |whence| may be any one of
        /// SEEK_CUR, SEEK_END or SEEK_SET. Returns zero on success and non-zero on
        /// failure.
        /// /*cef()*/
        /// </summary>
        /*7121*/

        public int Seek(long /*7122*/
        offset
        , int /*7123*/
        whence
        )/*7124*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I64 = offset/*7125*/
            ;
            v2.I32 = (int)whence/*7126*/
            ;
            /*7127*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefStreamWriter_Seek_2, out ret, ref v1, ref v2);
            /*7128*/
            var ret_result = ret.I32;
            /*7129*/
            return ret_result;
            /*7130*/
        }

        // gen! int64 Tell()
        /// <summary>
        /// Return the current offset position.
        /// /*cef()*/
        /// </summary>
        /*7131*/

        public long Tell()/*7132*/
        {
            JsValue ret;
            /*7133*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Tell_3, out ret);
            /*7134*/
            var ret_result = ret.I64;
            /*7135*/
            return ret_result;
            /*7136*/
        }

        // gen! int Flush()
        /// <summary>
        /// Flush the stream.
        /// /*cef()*/
        /// </summary>
        /*7137*/

        public int Flush()/*7138*/
        {
            JsValue ret;
            /*7139*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_Flush_4, out ret);
            /*7140*/
            var ret_result = ret.I32;
            /*7141*/
            return ret_result;
            /*7142*/
        }

        // gen! bool MayBlock()
        /// <summary>
        /// Returns true if this writer performs work like accessing the file system
        /// which may block. Used as a hint for determining the thread to access the
        /// writer from.
        /// /*cef()*/
        /// </summary>
        /*7143*/

        public bool MayBlock()/*7144*/
        {
            JsValue ret;
            /*7145*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStreamWriter_MayBlock_5, out ret);
            /*7146*/
            var ret_result = ret.I32 != 0;
            /*7147*/
            return ret_result;
            /*7148*/
        }
        /*7149*/
    }


    // [virtual] class CefStringVisitor
    /// <summary>
    /// Implement this interface to receive string values asynchronously.
    /// /*(source=client)*/
    /// </summary>
    /*7158*/
    public struct CefStringVisitor
    {
        /*7159*/
        const int _typeNAME = 34;
        /*7160*/
        const int CefStringVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*7161*/
        internal readonly IntPtr nativePtr;
        /*7162*/
        internal CefStringVisitor(IntPtr nativePtr)
        {
            /*7163*/
            this.nativePtr = nativePtr;
            /*7164*/
        }
        /*7165*/
        public void Release()
        {
            /*7166*/
            JsValue ret;
            /*7167*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefStringVisitor_Release_0, out ret);
            /*7168*/
        }
        /*7169*/
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
    /*7178*/
    public struct CefTask
    {
        /*7179*/
        const int _typeNAME = 35;
        /*7180*/
        const int CefTask_Release_0 = (_typeNAME << 16) | 0;
        /*7181*/
        internal readonly IntPtr nativePtr;
        /*7182*/
        internal CefTask(IntPtr nativePtr)
        {
            /*7183*/
            this.nativePtr = nativePtr;
            /*7184*/
        }
        /*7185*/
        public void Release()
        {
            /*7186*/
            JsValue ret;
            /*7187*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTask_Release_0, out ret);
            /*7188*/
        }
        /*7189*/
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
    /*7223*/
    public struct CefTaskRunner
    {
        /*7224*/
        const int _typeNAME = 36;
        /*7225*/
        const int CefTaskRunner_Release_0 = (_typeNAME << 16) | 0;
        /*7226*/
        const int CefTaskRunner_IsSame_1 = (_typeNAME << 16) | 1;
        /*7227*/
        const int CefTaskRunner_BelongsToCurrentThread_2 = (_typeNAME << 16) | 2;
        /*7228*/
        const int CefTaskRunner_BelongsToThread_3 = (_typeNAME << 16) | 3;
        /*7229*/
        const int CefTaskRunner_PostTask_4 = (_typeNAME << 16) | 4;
        /*7230*/
        const int CefTaskRunner_PostDelayedTask_5 = (_typeNAME << 16) | 5;
        /*7231*/
        internal readonly IntPtr nativePtr;
        /*7232*/
        internal CefTaskRunner(IntPtr nativePtr)
        {
            /*7233*/
            this.nativePtr = nativePtr;
            /*7234*/
        }
        /*7235*/
        public void Release()
        {
            /*7236*/
            JsValue ret;
            /*7237*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTaskRunner_Release_0, out ret);
            /*7238*/
        }

        // gen! bool IsSame(CefRefPtr<CefTaskRunner> that)
        /// <summary>
        /// CefTaskRunner methods.
        /// </summary>
        /*7239*/

        public bool IsSame(CefTaskRunner /*7240*/
        that
        )/*7241*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr/*7242*/
            ;
            /*7243*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_IsSame_1, out ret, ref v1);
            /*7244*/
            var ret_result = ret.I32 != 0;
            /*7245*/
            return ret_result;
            /*7246*/
        }

        // gen! bool BelongsToCurrentThread()
        /// <summary>
        /// Returns true if this task runner belongs to the current thread.
        /// /*cef()*/
        /// </summary>
        /*7247*/

        public bool BelongsToCurrentThread()/*7248*/
        {
            JsValue ret;
            /*7249*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefTaskRunner_BelongsToCurrentThread_2, out ret);
            /*7250*/
            var ret_result = ret.I32 != 0;
            /*7251*/
            return ret_result;
            /*7252*/
        }

        // gen! bool BelongsToThread(CefThreadId threadId)
        /// <summary>
        /// Returns true if this task runner is for the specified CEF thread.
        /// /*cef()*/
        /// </summary>
        /*7253*/

        public bool BelongsToThread(cef_thread_id_t /*7254*/
        threadId
        )/*7255*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)threadId/*7256*/
            ;
            /*7257*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_BelongsToThread_3, out ret, ref v1);
            /*7258*/
            var ret_result = ret.I32 != 0;
            /*7259*/
            return ret_result;
            /*7260*/
        }

        // gen! bool PostTask(CefRefPtr<CefTask> task)
        /// <summary>
        /// Post a task for execution on the thread associated with this task runner.
        /// Execution will occur asynchronously.
        /// /*cef()*/
        /// </summary>
        /*7261*/

        public bool PostTask(CefTask /*7262*/
        task
        )/*7263*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = task.nativePtr/*7264*/
            ;
            /*7265*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefTaskRunner_PostTask_4, out ret, ref v1);
            /*7266*/
            var ret_result = ret.I32 != 0;
            /*7267*/
            return ret_result;
            /*7268*/
        }

        // gen! bool PostDelayedTask(CefRefPtr<CefTask> task,int64 delay_ms)
        /// <summary>
        /// Post a task for delayed execution on the thread associated with this task
        /// runner. Execution will occur asynchronously. Delayed tasks are not
        /// supported on V8 WebWorker threads and will be executed without the
        /// specified delay.
        /// /*cef()*/
        /// </summary>
        /*7269*/

        public bool PostDelayedTask(CefTask /*7270*/
        task
        , long /*7271*/
        delay_ms
        )/*7272*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = task.nativePtr/*7273*/
            ;
            v2.I64 = delay_ms/*7274*/
            ;
            /*7275*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefTaskRunner_PostDelayedTask_5, out ret, ref v1, ref v2);
            /*7276*/
            var ret_result = ret.I32 != 0;
            /*7277*/
            return ret_result;
            /*7278*/
        }
        /*7279*/
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
    /*7318*/
    public struct CefURLRequest
    {
        /*7319*/
        const int _typeNAME = 37;
        /*7320*/
        const int CefURLRequest_Release_0 = (_typeNAME << 16) | 0;
        /*7321*/
        const int CefURLRequest_GetRequest_1 = (_typeNAME << 16) | 1;
        /*7322*/
        const int CefURLRequest_GetClient_2 = (_typeNAME << 16) | 2;
        /*7323*/
        const int CefURLRequest_GetRequestStatus_3 = (_typeNAME << 16) | 3;
        /*7324*/
        const int CefURLRequest_GetRequestError_4 = (_typeNAME << 16) | 4;
        /*7325*/
        const int CefURLRequest_GetResponse_5 = (_typeNAME << 16) | 5;
        /*7326*/
        const int CefURLRequest_Cancel_6 = (_typeNAME << 16) | 6;
        /*7327*/
        internal readonly IntPtr nativePtr;
        /*7328*/
        internal CefURLRequest(IntPtr nativePtr)
        {
            /*7329*/
            this.nativePtr = nativePtr;
            /*7330*/
        }
        /*7331*/
        public void Release()
        {
            /*7332*/
            JsValue ret;
            /*7333*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_Release_0, out ret);
            /*7334*/
        }

        // gen! CefRefPtr<CefRequest> GetRequest()
        /// <summary>
        /// CefURLRequest methods.
        /// </summary>
        /*7335*/

        public CefRequest GetRequest()/*7336*/
        {
            JsValue ret;
            /*7337*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequest_1, out ret);
            /*7338*/
            var ret_result = new CefRequest(ret.Ptr);
            /*7339*/
            return ret_result;
            /*7340*/
        }

        // gen! CefRefPtr<CefURLRequestClient> GetClient()
        /// <summary>
        /// Returns the client.
        /// /*cef()*/
        /// </summary>
        /*7341*/

        public CefURLRequestClient GetClient()/*7342*/
        {
            JsValue ret;
            /*7343*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetClient_2, out ret);
            /*7344*/
            var ret_result = new CefURLRequestClient(ret.Ptr);
            /*7345*/
            return ret_result;
            /*7346*/
        }

        // gen! Status GetRequestStatus()
        /// <summary>
        /// Returns the request status.
        /// /*cef(default_retval=UR_UNKNOWN)*/
        /// </summary>
        /*7347*/

        public cef_urlrequest_status_t GetRequestStatus()/*7348*/
        {
            JsValue ret;
            /*7349*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequestStatus_3, out ret);
            /*7350*/
            var ret_result = (cef_urlrequest_status_t)ret.I32;

            /*7351*/
            return ret_result;
            /*7352*/
        }

        // gen! ErrorCode GetRequestError()
        /// <summary>
        /// Returns the request error if status is UR_CANCELED or UR_FAILED, or 0
        /// otherwise.
        /// /*cef(default_retval=ERR_NONE)*/
        /// </summary>
        /*7353*/

        public cef_errorcode_t GetRequestError()/*7354*/
        {
            JsValue ret;
            /*7355*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetRequestError_4, out ret);
            /*7356*/
            var ret_result = (cef_errorcode_t)ret.I32;

            /*7357*/
            return ret_result;
            /*7358*/
        }

        // gen! CefRefPtr<CefResponse> GetResponse()
        /// <summary>
        /// Returns the response, or NULL if no response information is available.
        /// Response information will only be available after the upload has completed.
        /// The returned object is read-only and should not be modified.
        /// /*cef()*/
        /// </summary>
        /*7359*/

        public CefResponse GetResponse()/*7360*/
        {
            JsValue ret;
            /*7361*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_GetResponse_5, out ret);
            /*7362*/
            var ret_result = new CefResponse(ret.Ptr);
            /*7363*/
            return ret_result;
            /*7364*/
        }

        // gen! void Cancel()
        /// <summary>
        /// Cancel the request.
        /// /*cef()*/
        /// </summary>
        /*7365*/

        public void Cancel()/*7366*/
        {
            JsValue ret;
            /*7367*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequest_Cancel_6, out ret);
            /*7368*/

            /*7369*/
        }
        /*7370*/
    }


    // [virtual] class CefURLRequestClient
    /// <summary>
    /// Interface that should be implemented by the CefURLRequest client. The
    /// methods of this class will be called on the same thread that created the
    /// request unless otherwise documented.
    /// /*(source=client)*/
    /// </summary>
    /*7379*/
    public struct CefURLRequestClient
    {
        /*7380*/
        const int _typeNAME = 38;
        /*7381*/
        const int CefURLRequestClient_Release_0 = (_typeNAME << 16) | 0;
        /*7382*/
        internal readonly IntPtr nativePtr;
        /*7383*/
        internal CefURLRequestClient(IntPtr nativePtr)
        {
            /*7384*/
            this.nativePtr = nativePtr;
            /*7385*/
        }
        /*7386*/
        public void Release()
        {
            /*7387*/
            JsValue ret;
            /*7388*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefURLRequestClient_Release_0, out ret);
            /*7389*/
        }
        /*7390*/
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
    /*7444*/
    public struct CefV8Context
    {
        /*7445*/
        const int _typeNAME = 39;
        /*7446*/
        const int CefV8Context_Release_0 = (_typeNAME << 16) | 0;
        /*7447*/
        const int CefV8Context_GetTaskRunner_1 = (_typeNAME << 16) | 1;
        /*7448*/
        const int CefV8Context_IsValid_2 = (_typeNAME << 16) | 2;
        /*7449*/
        const int CefV8Context_GetBrowser_3 = (_typeNAME << 16) | 3;
        /*7450*/
        const int CefV8Context_GetFrame_4 = (_typeNAME << 16) | 4;
        /*7451*/
        const int CefV8Context_GetGlobal_5 = (_typeNAME << 16) | 5;
        /*7452*/
        const int CefV8Context_Enter_6 = (_typeNAME << 16) | 6;
        /*7453*/
        const int CefV8Context_Exit_7 = (_typeNAME << 16) | 7;
        /*7454*/
        const int CefV8Context_IsSame_8 = (_typeNAME << 16) | 8;
        /*7455*/
        const int CefV8Context_Eval_9 = (_typeNAME << 16) | 9;
        /*7456*/
        internal readonly IntPtr nativePtr;
        /*7457*/
        internal CefV8Context(IntPtr nativePtr)
        {
            /*7458*/
            this.nativePtr = nativePtr;
            /*7459*/
        }
        /*7460*/
        public void Release()
        {
            /*7461*/
            JsValue ret;
            /*7462*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Release_0, out ret);
            /*7463*/
        }

        // gen! CefRefPtr<CefTaskRunner> GetTaskRunner()
        /// <summary>
        /// CefV8Context methods.
        /// </summary>
        /*7464*/

        public CefTaskRunner GetTaskRunner()/*7465*/
        {
            JsValue ret;
            /*7466*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetTaskRunner_1, out ret);
            /*7467*/
            var ret_result = new CefTaskRunner(ret.Ptr);
            /*7468*/
            return ret_result;
            /*7469*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// Returns true if the underlying handle is valid and it can be accessed on
        /// the current thread. Do not call any other methods if this method returns
        /// false.
        /// /*cef()*/
        /// </summary>
        /*7470*/

        public bool IsValid()/*7471*/
        {
            JsValue ret;
            /*7472*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_IsValid_2, out ret);
            /*7473*/
            var ret_result = ret.I32 != 0;
            /*7474*/
            return ret_result;
            /*7475*/
        }

        // gen! CefRefPtr<CefBrowser> GetBrowser()
        /// <summary>
        /// Returns the browser for this context. This method will return an empty
        /// reference for WebWorker contexts.
        /// /*cef()*/
        /// </summary>
        /*7476*/

        public CefBrowser GetBrowser()/*7477*/
        {
            JsValue ret;
            /*7478*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetBrowser_3, out ret);
            /*7479*/
            var ret_result = new CefBrowser(ret.Ptr);
            /*7480*/
            return ret_result;
            /*7481*/
        }

        // gen! CefRefPtr<CefFrame> GetFrame()
        /// <summary>
        /// Returns the frame for this context. This method will return an empty
        /// reference for WebWorker contexts.
        /// /*cef()*/
        /// </summary>
        /*7482*/

        public CefFrame GetFrame()/*7483*/
        {
            JsValue ret;
            /*7484*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetFrame_4, out ret);
            /*7485*/
            var ret_result = new CefFrame(ret.Ptr);
            /*7486*/
            return ret_result;
            /*7487*/
        }

        // gen! CefRefPtr<CefV8Value> GetGlobal()
        /// <summary>
        /// Returns the global object for this context. The context must be entered
        /// before calling this method.
        /// /*cef()*/
        /// </summary>
        /*7488*/

        public CefV8Value GetGlobal()/*7489*/
        {
            JsValue ret;
            /*7490*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_GetGlobal_5, out ret);
            /*7491*/
            var ret_result = new CefV8Value(ret.Ptr);
            /*7492*/
            return ret_result;
            /*7493*/
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
        /*7494*/

        public bool Enter()/*7495*/
        {
            JsValue ret;
            /*7496*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Enter_6, out ret);
            /*7497*/
            var ret_result = ret.I32 != 0;
            /*7498*/
            return ret_result;
            /*7499*/
        }

        // gen! bool Exit()
        /// <summary>
        /// Exit this context. Call this method only after calling Enter(). Returns
        /// true if the scope was exited successfully.
        /// /*cef()*/
        /// </summary>
        /*7500*/

        public bool Exit()/*7501*/
        {
            JsValue ret;
            /*7502*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Context_Exit_7, out ret);
            /*7503*/
            var ret_result = ret.I32 != 0;
            /*7504*/
            return ret_result;
            /*7505*/
        }

        // gen! bool IsSame(CefRefPtr<CefV8Context> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>
        /*7506*/

        public bool IsSame(CefV8Context /*7507*/
        that
        )/*7508*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr/*7509*/
            ;
            /*7510*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Context_IsSame_8, out ret, ref v1);
            /*7511*/
            var ret_result = ret.I32 != 0;
            /*7512*/
            return ret_result;
            /*7513*/
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
        /*7514*/

        public bool Eval(string /*7515*/
        code
        , string /*7516*/
        script_url
        , int /*7517*/
        start_line
        , IntPtr /*7518*/
        retval
        , IntPtr /*7519*/
        exception
        )/*7520*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue v4 = new JsValue();
            JsValue v5 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(code);
            /*7521*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(script_url);
            /*7522*/
            ;
            v3.I32 = (int)start_line/*7523*/
            ;
            v4.Ptr = retval/*7524*/
            ;
            v5.Ptr = exception/*7525*/
            ;
            /*7526*/

            Cef3Binder.MyCefMet_Call5(this.nativePtr, CefV8Context_Eval_9, out ret, ref v1, ref v2, ref v3, ref v4, ref v5);
            /*7527*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*7528*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*7529*/
            ;
            retval = v4.Ptr;/*7530*/
            ;
            exception = v5.Ptr;/*7531*/
            ;
            /*7532*/
            return ret_result;
            /*7533*/
        }
        /*7534*/
    }


    // [virtual] class CefV8Accessor
    /// <summary>
    /// Interface that should be implemented to handle V8 accessor calls. Accessor
    /// identifiers are registered by calling CefV8Value::SetValue(). The methods
    /// of this class will be called on the thread associated with the V8 accessor.
    /// /*(source=client)*/
    /// </summary>
    /*7543*/
    public struct CefV8Accessor
    {
        /*7544*/
        const int _typeNAME = 40;
        /*7545*/
        const int CefV8Accessor_Release_0 = (_typeNAME << 16) | 0;
        /*7546*/
        internal readonly IntPtr nativePtr;
        /*7547*/
        internal CefV8Accessor(IntPtr nativePtr)
        {
            /*7548*/
            this.nativePtr = nativePtr;
            /*7549*/
        }
        /*7550*/
        public void Release()
        {
            /*7551*/
            JsValue ret;
            /*7552*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Accessor_Release_0, out ret);
            /*7553*/
        }
        /*7554*/
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
    /*7563*/
    public struct CefV8Interceptor
    {
        /*7564*/
        const int _typeNAME = 41;
        /*7565*/
        const int CefV8Interceptor_Release_0 = (_typeNAME << 16) | 0;
        /*7566*/
        internal readonly IntPtr nativePtr;
        /*7567*/
        internal CefV8Interceptor(IntPtr nativePtr)
        {
            /*7568*/
            this.nativePtr = nativePtr;
            /*7569*/
        }
        /*7570*/
        public void Release()
        {
            /*7571*/
            JsValue ret;
            /*7572*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Interceptor_Release_0, out ret);
            /*7573*/
        }
        /*7574*/
    }


    // [virtual] class CefV8Exception
    /// <summary>
    /// Class representing a V8 exception. The methods of this class may be called on
    /// any render process thread.
    /// /*(source=library)*/
    /// </summary>
    /*7623*/
    public struct CefV8Exception
    {
        /*7624*/
        const int _typeNAME = 42;
        /*7625*/
        const int CefV8Exception_Release_0 = (_typeNAME << 16) | 0;
        /*7626*/
        const int CefV8Exception_GetMessage_1 = (_typeNAME << 16) | 1;
        /*7627*/
        const int CefV8Exception_GetSourceLine_2 = (_typeNAME << 16) | 2;
        /*7628*/
        const int CefV8Exception_GetScriptResourceName_3 = (_typeNAME << 16) | 3;
        /*7629*/
        const int CefV8Exception_GetLineNumber_4 = (_typeNAME << 16) | 4;
        /*7630*/
        const int CefV8Exception_GetStartPosition_5 = (_typeNAME << 16) | 5;
        /*7631*/
        const int CefV8Exception_GetEndPosition_6 = (_typeNAME << 16) | 6;
        /*7632*/
        const int CefV8Exception_GetStartColumn_7 = (_typeNAME << 16) | 7;
        /*7633*/
        const int CefV8Exception_GetEndColumn_8 = (_typeNAME << 16) | 8;
        /*7634*/
        internal readonly IntPtr nativePtr;
        /*7635*/
        internal CefV8Exception(IntPtr nativePtr)
        {
            /*7636*/
            this.nativePtr = nativePtr;
            /*7637*/
        }
        /*7638*/
        public void Release()
        {
            /*7639*/
            JsValue ret;
            /*7640*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_Release_0, out ret);
            /*7641*/
        }

        // gen! CefString GetMessage()
        /// <summary>
        /// CefV8Exception methods.
        /// </summary>
        /*7642*/

        public string GetMessage()/*7643*/
        {
            JsValue ret;
            /*7644*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetMessage_1, out ret);
            /*7645*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*7646*/
            return ret_result;
            /*7647*/
        }

        // gen! CefString GetSourceLine()
        /// <summary>
        /// Returns the line of source code that the exception occurred within.
        /// /*cef()*/
        /// </summary>
        /*7648*/

        public string GetSourceLine()/*7649*/
        {
            JsValue ret;
            /*7650*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetSourceLine_2, out ret);
            /*7651*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*7652*/
            return ret_result;
            /*7653*/
        }

        // gen! CefString GetScriptResourceName()
        /// <summary>
        /// Returns the resource name for the script from where the function causing
        /// the error originates.
        /// /*cef()*/
        /// </summary>
        /*7654*/

        public string GetScriptResourceName()/*7655*/
        {
            JsValue ret;
            /*7656*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetScriptResourceName_3, out ret);
            /*7657*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*7658*/
            return ret_result;
            /*7659*/
        }

        // gen! int GetLineNumber()
        /// <summary>
        /// Returns the 1-based number of the line where the error occurred or 0 if the
        /// line number is unknown.
        /// /*cef()*/
        /// </summary>
        /*7660*/

        public int GetLineNumber()/*7661*/
        {
            JsValue ret;
            /*7662*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetLineNumber_4, out ret);
            /*7663*/
            var ret_result = ret.I32;
            /*7664*/
            return ret_result;
            /*7665*/
        }

        // gen! int GetStartPosition()
        /// <summary>
        /// Returns the index within the script of the first character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>
        /*7666*/

        public int GetStartPosition()/*7667*/
        {
            JsValue ret;
            /*7668*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetStartPosition_5, out ret);
            /*7669*/
            var ret_result = ret.I32;
            /*7670*/
            return ret_result;
            /*7671*/
        }

        // gen! int GetEndPosition()
        /// <summary>
        /// Returns the index within the script of the last character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>
        /*7672*/

        public int GetEndPosition()/*7673*/
        {
            JsValue ret;
            /*7674*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetEndPosition_6, out ret);
            /*7675*/
            var ret_result = ret.I32;
            /*7676*/
            return ret_result;
            /*7677*/
        }

        // gen! int GetStartColumn()
        /// <summary>
        /// Returns the index within the line of the first character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>
        /*7678*/

        public int GetStartColumn()/*7679*/
        {
            JsValue ret;
            /*7680*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetStartColumn_7, out ret);
            /*7681*/
            var ret_result = ret.I32;
            /*7682*/
            return ret_result;
            /*7683*/
        }

        // gen! int GetEndColumn()
        /// <summary>
        /// Returns the index within the line of the last character where the error
        /// occurred.
        /// /*cef()*/
        /// </summary>
        /*7684*/

        public int GetEndColumn()/*7685*/
        {
            JsValue ret;
            /*7686*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Exception_GetEndColumn_8, out ret);
            /*7687*/
            var ret_result = ret.I32;
            /*7688*/
            return ret_result;
            /*7689*/
        }
        /*7690*/
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
    /*7919*/
    public struct CefV8Value
    {
        /*7920*/
        const int _typeNAME = 43;
        /*7921*/
        const int CefV8Value_Release_0 = (_typeNAME << 16) | 0;
        /*7922*/
        const int CefV8Value_IsValid_1 = (_typeNAME << 16) | 1;
        /*7923*/
        const int CefV8Value_IsUndefined_2 = (_typeNAME << 16) | 2;
        /*7924*/
        const int CefV8Value_IsNull_3 = (_typeNAME << 16) | 3;
        /*7925*/
        const int CefV8Value_IsBool_4 = (_typeNAME << 16) | 4;
        /*7926*/
        const int CefV8Value_IsInt_5 = (_typeNAME << 16) | 5;
        /*7927*/
        const int CefV8Value_IsUInt_6 = (_typeNAME << 16) | 6;
        /*7928*/
        const int CefV8Value_IsDouble_7 = (_typeNAME << 16) | 7;
        /*7929*/
        const int CefV8Value_IsDate_8 = (_typeNAME << 16) | 8;
        /*7930*/
        const int CefV8Value_IsString_9 = (_typeNAME << 16) | 9;
        /*7931*/
        const int CefV8Value_IsObject_10 = (_typeNAME << 16) | 10;
        /*7932*/
        const int CefV8Value_IsArray_11 = (_typeNAME << 16) | 11;
        /*7933*/
        const int CefV8Value_IsFunction_12 = (_typeNAME << 16) | 12;
        /*7934*/
        const int CefV8Value_IsSame_13 = (_typeNAME << 16) | 13;
        /*7935*/
        const int CefV8Value_GetBoolValue_14 = (_typeNAME << 16) | 14;
        /*7936*/
        const int CefV8Value_GetIntValue_15 = (_typeNAME << 16) | 15;
        /*7937*/
        const int CefV8Value_GetUIntValue_16 = (_typeNAME << 16) | 16;
        /*7938*/
        const int CefV8Value_GetDoubleValue_17 = (_typeNAME << 16) | 17;
        /*7939*/
        const int CefV8Value_GetDateValue_18 = (_typeNAME << 16) | 18;
        /*7940*/
        const int CefV8Value_GetStringValue_19 = (_typeNAME << 16) | 19;
        /*7941*/
        const int CefV8Value_IsUserCreated_20 = (_typeNAME << 16) | 20;
        /*7942*/
        const int CefV8Value_HasException_21 = (_typeNAME << 16) | 21;
        /*7943*/
        const int CefV8Value_GetException_22 = (_typeNAME << 16) | 22;
        /*7944*/
        const int CefV8Value_ClearException_23 = (_typeNAME << 16) | 23;
        /*7945*/
        const int CefV8Value_WillRethrowExceptions_24 = (_typeNAME << 16) | 24;
        /*7946*/
        const int CefV8Value_SetRethrowExceptions_25 = (_typeNAME << 16) | 25;
        /*7947*/
        const int CefV8Value_HasValue_26 = (_typeNAME << 16) | 26;
        /*7948*/
        const int CefV8Value_HasValue_27 = (_typeNAME << 16) | 27;
        /*7949*/
        const int CefV8Value_DeleteValue_28 = (_typeNAME << 16) | 28;
        /*7950*/
        const int CefV8Value_DeleteValue_29 = (_typeNAME << 16) | 29;
        /*7951*/
        const int CefV8Value_GetValue_30 = (_typeNAME << 16) | 30;
        /*7952*/
        const int CefV8Value_GetValue_31 = (_typeNAME << 16) | 31;
        /*7953*/
        const int CefV8Value_SetValue_32 = (_typeNAME << 16) | 32;
        /*7954*/
        const int CefV8Value_SetValue_33 = (_typeNAME << 16) | 33;
        /*7955*/
        const int CefV8Value_SetValue_34 = (_typeNAME << 16) | 34;
        /*7956*/
        const int CefV8Value_GetKeys_35 = (_typeNAME << 16) | 35;
        /*7957*/
        const int CefV8Value_SetUserData_36 = (_typeNAME << 16) | 36;
        /*7958*/
        const int CefV8Value_GetUserData_37 = (_typeNAME << 16) | 37;
        /*7959*/
        const int CefV8Value_GetExternallyAllocatedMemory_38 = (_typeNAME << 16) | 38;
        /*7960*/
        const int CefV8Value_AdjustExternallyAllocatedMemory_39 = (_typeNAME << 16) | 39;
        /*7961*/
        const int CefV8Value_GetArrayLength_40 = (_typeNAME << 16) | 40;
        /*7962*/
        const int CefV8Value_GetFunctionName_41 = (_typeNAME << 16) | 41;
        /*7963*/
        const int CefV8Value_GetFunctionHandler_42 = (_typeNAME << 16) | 42;
        /*7964*/
        const int CefV8Value_ExecuteFunction_43 = (_typeNAME << 16) | 43;
        /*7965*/
        const int CefV8Value_ExecuteFunctionWithContext_44 = (_typeNAME << 16) | 44;
        /*7966*/
        internal readonly IntPtr nativePtr;
        /*7967*/
        internal CefV8Value(IntPtr nativePtr)
        {
            /*7968*/
            this.nativePtr = nativePtr;
            /*7969*/
        }
        /*7970*/
        public void Release()
        {
            /*7971*/
            JsValue ret;
            /*7972*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_Release_0, out ret);
            /*7973*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefV8Value methods.
        /// </summary>
        /*7974*/

        public bool IsValid()/*7975*/
        {
            JsValue ret;
            /*7976*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsValid_1, out ret);
            /*7977*/
            var ret_result = ret.I32 != 0;
            /*7978*/
            return ret_result;
            /*7979*/
        }

        // gen! bool IsUndefined()
        /// <summary>
        /// True if the value type is undefined.
        /// /*cef()*/
        /// </summary>
        /*7980*/

        public bool IsUndefined()/*7981*/
        {
            JsValue ret;
            /*7982*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUndefined_2, out ret);
            /*7983*/
            var ret_result = ret.I32 != 0;
            /*7984*/
            return ret_result;
            /*7985*/
        }

        // gen! bool IsNull()
        /// <summary>
        /// True if the value type is null.
        /// /*cef()*/
        /// </summary>
        /*7986*/

        public bool IsNull()/*7987*/
        {
            JsValue ret;
            /*7988*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsNull_3, out ret);
            /*7989*/
            var ret_result = ret.I32 != 0;
            /*7990*/
            return ret_result;
            /*7991*/
        }

        // gen! bool IsBool()
        /// <summary>
        /// True if the value type is bool.
        /// /*cef()*/
        /// </summary>
        /*7992*/

        public bool IsBool()/*7993*/
        {
            JsValue ret;
            /*7994*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsBool_4, out ret);
            /*7995*/
            var ret_result = ret.I32 != 0;
            /*7996*/
            return ret_result;
            /*7997*/
        }

        // gen! bool IsInt()
        /// <summary>
        /// True if the value type is int.
        /// /*cef()*/
        /// </summary>
        /*7998*/

        public bool IsInt()/*7999*/
        {
            JsValue ret;
            /*8000*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsInt_5, out ret);
            /*8001*/
            var ret_result = ret.I32 != 0;
            /*8002*/
            return ret_result;
            /*8003*/
        }

        // gen! bool IsUInt()
        /// <summary>
        /// True if the value type is unsigned int.
        /// /*cef()*/
        /// </summary>
        /*8004*/

        public bool IsUInt()/*8005*/
        {
            JsValue ret;
            /*8006*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUInt_6, out ret);
            /*8007*/
            var ret_result = ret.I32 != 0;
            /*8008*/
            return ret_result;
            /*8009*/
        }

        // gen! bool IsDouble()
        /// <summary>
        /// True if the value type is double.
        /// /*cef()*/
        /// </summary>
        /*8010*/

        public bool IsDouble()/*8011*/
        {
            JsValue ret;
            /*8012*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsDouble_7, out ret);
            /*8013*/
            var ret_result = ret.I32 != 0;
            /*8014*/
            return ret_result;
            /*8015*/
        }

        // gen! bool IsDate()
        /// <summary>
        /// True if the value type is Date.
        /// /*cef()*/
        /// </summary>
        /*8016*/

        public bool IsDate()/*8017*/
        {
            JsValue ret;
            /*8018*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsDate_8, out ret);
            /*8019*/
            var ret_result = ret.I32 != 0;
            /*8020*/
            return ret_result;
            /*8021*/
        }

        // gen! bool IsString()
        /// <summary>
        /// True if the value type is string.
        /// /*cef()*/
        /// </summary>
        /*8022*/

        public bool IsString()/*8023*/
        {
            JsValue ret;
            /*8024*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsString_9, out ret);
            /*8025*/
            var ret_result = ret.I32 != 0;
            /*8026*/
            return ret_result;
            /*8027*/
        }

        // gen! bool IsObject()
        /// <summary>
        /// True if the value type is object.
        /// /*cef()*/
        /// </summary>
        /*8028*/

        public bool IsObject()/*8029*/
        {
            JsValue ret;
            /*8030*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsObject_10, out ret);
            /*8031*/
            var ret_result = ret.I32 != 0;
            /*8032*/
            return ret_result;
            /*8033*/
        }

        // gen! bool IsArray()
        /// <summary>
        /// True if the value type is array.
        /// /*cef()*/
        /// </summary>
        /*8034*/

        public bool IsArray()/*8035*/
        {
            JsValue ret;
            /*8036*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsArray_11, out ret);
            /*8037*/
            var ret_result = ret.I32 != 0;
            /*8038*/
            return ret_result;
            /*8039*/
        }

        // gen! bool IsFunction()
        /// <summary>
        /// True if the value type is function.
        /// /*cef()*/
        /// </summary>
        /*8040*/

        public bool IsFunction()/*8041*/
        {
            JsValue ret;
            /*8042*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsFunction_12, out ret);
            /*8043*/
            var ret_result = ret.I32 != 0;
            /*8044*/
            return ret_result;
            /*8045*/
        }

        // gen! bool IsSame(CefRefPtr<CefV8Value> that)
        /// <summary>
        /// Returns true if this object is pointing to the same handle as |that|
        /// object.
        /// /*cef()*/
        /// </summary>
        /*8046*/

        public bool IsSame(CefV8Value /*8047*/
        that
        )/*8048*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr/*8049*/
            ;
            /*8050*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_IsSame_13, out ret, ref v1);
            /*8051*/
            var ret_result = ret.I32 != 0;
            /*8052*/
            return ret_result;
            /*8053*/
        }

        // gen! bool GetBoolValue()
        /// <summary>
        /// Return a bool value.
        /// /*cef()*/
        /// </summary>
        /*8054*/

        public bool GetBoolValue()/*8055*/
        {
            JsValue ret;
            /*8056*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetBoolValue_14, out ret);
            /*8057*/
            var ret_result = ret.I32 != 0;
            /*8058*/
            return ret_result;
            /*8059*/
        }

        // gen! int32 GetIntValue()
        /// <summary>
        /// Return an int value.
        /// /*cef()*/
        /// </summary>
        /*8060*/

        public int GetIntValue()/*8061*/
        {
            JsValue ret;
            /*8062*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetIntValue_15, out ret);
            /*8063*/
            var ret_result = ret.I32;
            /*8064*/
            return ret_result;
            /*8065*/
        }

        // gen! uint32 GetUIntValue()
        /// <summary>
        /// Return an unsigned int value.
        /// /*cef()*/
        /// </summary>
        /*8066*/

        public uint GetUIntValue()/*8067*/
        {
            JsValue ret;
            /*8068*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetUIntValue_16, out ret);
            /*8069*/
            var ret_result = (uint)ret.I32;
            /*8070*/
            return ret_result;
            /*8071*/
        }

        // gen! double GetDoubleValue()
        /// <summary>
        /// Return a double value.
        /// /*cef()*/
        /// </summary>
        /*8072*/

        public double GetDoubleValue()/*8073*/
        {
            JsValue ret;
            /*8074*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetDoubleValue_17, out ret);
            /*8075*/
            var ret_result = ret.Num;
            /*8076*/
            return ret_result;
            /*8077*/
        }

        // gen! CefTime GetDateValue()
        /// <summary>
        /// Return a Date value.
        /// /*cef()*/
        /// </summary>
        /*8078*/

        public CefTime GetDateValue()/*8079*/
        {
            JsValue ret;
            /*8080*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetDateValue_18, out ret);
            /*8081*/
            var ret_result = new CefTime(ret.Ptr);

            /*8082*/
            return ret_result;
            /*8083*/
        }

        // gen! CefString GetStringValue()
        /// <summary>
        /// Return a string value.
        /// /*cef()*/
        /// </summary>
        /*8084*/

        public string GetStringValue()/*8085*/
        {
            JsValue ret;
            /*8086*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetStringValue_19, out ret);
            /*8087*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8088*/
            return ret_result;
            /*8089*/
        }

        // gen! bool IsUserCreated()
        /// <summary>
        /// OBJECT METHODS - These methods are only available on objects. Arrays and
        /// functions are also objects. String- and integer-based keys can be used
        /// interchangably with the framework converting between them as necessary.
        /// Returns true if this is a user created object.
        /// /*cef()*/
        /// </summary>
        /*8090*/

        public bool IsUserCreated()/*8091*/
        {
            JsValue ret;
            /*8092*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_IsUserCreated_20, out ret);
            /*8093*/
            var ret_result = ret.I32 != 0;
            /*8094*/
            return ret_result;
            /*8095*/
        }

        // gen! bool HasException()
        /// <summary>
        /// Returns true if the last method call resulted in an exception. This
        /// attribute exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>
        /*8096*/

        public bool HasException()/*8097*/
        {
            JsValue ret;
            /*8098*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_HasException_21, out ret);
            /*8099*/
            var ret_result = ret.I32 != 0;
            /*8100*/
            return ret_result;
            /*8101*/
        }

        // gen! CefRefPtr<CefV8Exception> GetException()
        /// <summary>
        /// Returns the exception resulting from the last method call. This attribute
        /// exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>
        /*8102*/

        public CefV8Exception GetException()/*8103*/
        {
            JsValue ret;
            /*8104*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetException_22, out ret);
            /*8105*/
            var ret_result = new CefV8Exception(ret.Ptr);
            /*8106*/
            return ret_result;
            /*8107*/
        }

        // gen! bool ClearException()
        /// <summary>
        /// Clears the last exception and returns true on success.
        /// /*cef()*/
        /// </summary>
        /*8108*/

        public bool ClearException()/*8109*/
        {
            JsValue ret;
            /*8110*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_ClearException_23, out ret);
            /*8111*/
            var ret_result = ret.I32 != 0;
            /*8112*/
            return ret_result;
            /*8113*/
        }

        // gen! bool WillRethrowExceptions()
        /// <summary>
        /// Returns true if this object will re-throw future exceptions. This attribute
        /// exists only in the scope of the current CEF value object.
        /// /*cef()*/
        /// </summary>
        /*8114*/

        public bool WillRethrowExceptions()/*8115*/
        {
            JsValue ret;
            /*8116*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_WillRethrowExceptions_24, out ret);
            /*8117*/
            var ret_result = ret.I32 != 0;
            /*8118*/
            return ret_result;
            /*8119*/
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
        /*8120*/

        public bool SetRethrowExceptions(bool /*8121*/
        rethrow
        )/*8122*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = rethrow ? 1 : 0/*8123*/
            ;
            /*8124*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_SetRethrowExceptions_25, out ret, ref v1);
            /*8125*/
            var ret_result = ret.I32 != 0;
            /*8126*/
            return ret_result;
            /*8127*/
        }

        // gen! bool HasValue(const CefString& key)
        /*8128*/

        public bool HasValue(string /*8129*/
        key
        )/*8130*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8131*/
            ;
            /*8132*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_HasValue_26, out ret, ref v1);
            /*8133*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8134*/
            ;
            /*8135*/
            return ret_result;
            /*8136*/
        }

        // gen! bool HasValue(int index)
        /*8137*/

        public bool HasValue(int /*8138*/
        index
        )/*8139*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*8140*/
            ;
            /*8141*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_HasValue_27, out ret, ref v1);
            /*8142*/
            var ret_result = ret.I32 != 0;
            /*8143*/
            return ret_result;
            /*8144*/
        }

        // gen! bool DeleteValue(const CefString& key)
        /*8145*/

        public bool DeleteValue(string /*8146*/
        key
        )/*8147*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8148*/
            ;
            /*8149*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_DeleteValue_28, out ret, ref v1);
            /*8150*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8151*/
            ;
            /*8152*/
            return ret_result;
            /*8153*/
        }

        // gen! bool DeleteValue(int index)
        /*8154*/

        public bool DeleteValue(int /*8155*/
        index
        )/*8156*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*8157*/
            ;
            /*8158*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_DeleteValue_29, out ret, ref v1);
            /*8159*/
            var ret_result = ret.I32 != 0;
            /*8160*/
            return ret_result;
            /*8161*/
        }

        // gen! CefRefPtr<CefV8Value> GetValue(const CefString& key)
        /*8162*/

        public CefV8Value GetValue(string /*8163*/
        key
        )/*8164*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8165*/
            ;
            /*8166*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetValue_30, out ret, ref v1);
            /*8167*/
            var ret_result = new CefV8Value(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8168*/
            ;
            /*8169*/
            return ret_result;
            /*8170*/
        }

        // gen! CefRefPtr<CefV8Value> GetValue(int index)
        /*8171*/

        public CefV8Value GetValue(int /*8172*/
        index
        )/*8173*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*8174*/
            ;
            /*8175*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetValue_31, out ret, ref v1);
            /*8176*/
            var ret_result = new CefV8Value(ret.Ptr);
            /*8177*/
            return ret_result;
            /*8178*/
        }

        // gen! bool SetValue(const CefString& key,CefRefPtr<CefV8Value> value,PropertyAttribute attribute)
        /*8179*/

        public bool SetValue(string /*8180*/
        key
        , CefV8Value /*8181*/
        value
        , cef_v8_propertyattribute_t /*8182*/
        attribute
        )/*8183*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8184*/
            ;
            v2.Ptr = value.nativePtr/*8185*/
            ;
            v3.I32 = (int)attribute/*8186*/
            ;
            /*8187*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_SetValue_32, out ret, ref v1, ref v2, ref v3);
            /*8188*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8189*/
            ;
            /*8190*/
            return ret_result;
            /*8191*/
        }

        // gen! bool SetValue(int index,CefRefPtr<CefV8Value> value)
        /*8192*/

        public bool SetValue(int /*8193*/
        index
        , CefV8Value /*8194*/
        value
        )/*8195*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*8196*/
            ;
            v2.Ptr = value.nativePtr/*8197*/
            ;
            /*8198*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefV8Value_SetValue_33, out ret, ref v1, ref v2);
            /*8199*/
            var ret_result = ret.I32 != 0;
            /*8200*/
            return ret_result;
            /*8201*/
        }

        // gen! bool SetValue(const CefString& key,AccessControl settings,PropertyAttribute attribute)
        /*8202*/

        public bool SetValue(string /*8203*/
        key
        , cef_v8_accesscontrol_t /*8204*/
        settings
        , cef_v8_propertyattribute_t /*8205*/
        attribute
        )/*8206*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*8207*/
            ;
            v2.I32 = (int)settings/*8208*/
            ;
            v3.I32 = (int)attribute/*8209*/
            ;
            /*8210*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_SetValue_34, out ret, ref v1, ref v2, ref v3);
            /*8211*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8212*/
            ;
            /*8213*/
            return ret_result;
            /*8214*/
        }

        // gen! bool GetKeys(std::vector<CefString>& keys)
        /// <summary>
        /// Read the keys for the object's values into the specified vector. Integer-
        /// based keys will also be returned as strings.
        /// /*cef()*/
        /// </summary>
        /*8215*/

        public bool GetKeys(List<string> /*8216*/
        keys
        )/*8217*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2)/*8218*/
            ;
            /*8219*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_GetKeys_35, out ret, ref v1);
            /*8220*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, keys)/*8221*/
            ;
            /*8222*/
            return ret_result;
            /*8223*/
        }

        // gen! bool SetUserData(CefRefPtr<CefBaseRefCounted> user_data)
        /// <summary>
        /// Sets the user data for this object and returns true on success. Returns
        /// false if this method is called incorrectly. This method can only be called
        /// on user created objects.
        /// /*cef(optional_param=user_data)*/
        /// </summary>
        /*8224*/

        public bool SetUserData(CefBaseRefCounted /*8225*/
        user_data
        )/*8226*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            //v1.Ptr = user_data/*8227*/
            ;
            /*8228*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_SetUserData_36, out ret, ref v1);
            /*8229*/
            var ret_result = ret.I32 != 0;
            /*8230*/
            return ret_result;
            /*8231*/
        }

        // gen! CefRefPtr<CefBaseRefCounted> GetUserData()
        /// <summary>
        /// Returns the user data, if any, assigned to this object.
        /// /*cef()*/
        /// </summary>
        /*8232*/

        public CefBaseRefCounted GetUserData()/*8233*/
        {
            JsValue ret;
            /*8234*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetUserData_37, out ret);
            /*8235*/
            var ret_result = new CefBaseRefCounted(ret.Ptr);
            /*8236*/
            return ret_result;
            /*8237*/
        }

        // gen! int GetExternallyAllocatedMemory()
        /// <summary>
        /// Returns the amount of externally allocated memory registered for the
        /// object.
        /// /*cef()*/
        /// </summary>
        /*8238*/

        public int GetExternallyAllocatedMemory()/*8239*/
        {
            JsValue ret;
            /*8240*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetExternallyAllocatedMemory_38, out ret);
            /*8241*/
            var ret_result = ret.I32;
            /*8242*/
            return ret_result;
            /*8243*/
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
        /*8244*/

        public int AdjustExternallyAllocatedMemory(int /*8245*/
        change_in_bytes
        )/*8246*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)change_in_bytes/*8247*/
            ;
            /*8248*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8Value_AdjustExternallyAllocatedMemory_39, out ret, ref v1);
            /*8249*/
            var ret_result = ret.I32;
            /*8250*/
            return ret_result;
            /*8251*/
        }

        // gen! int GetArrayLength()
        /// <summary>
        /// ARRAY METHODS - These methods are only available on arrays.
        /// Returns the number of elements in the array.
        /// /*cef()*/
        /// </summary>
        /*8252*/

        public int GetArrayLength()/*8253*/
        {
            JsValue ret;
            /*8254*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetArrayLength_40, out ret);
            /*8255*/
            var ret_result = ret.I32;
            /*8256*/
            return ret_result;
            /*8257*/
        }

        // gen! CefString GetFunctionName()
        /// <summary>
        /// FUNCTION METHODS - These methods are only available on functions.
        /// Returns the function name.
        /// /*cef()*/
        /// </summary>
        /*8258*/

        public string GetFunctionName()/*8259*/
        {
            JsValue ret;
            /*8260*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetFunctionName_41, out ret);
            /*8261*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8262*/
            return ret_result;
            /*8263*/
        }

        // gen! CefRefPtr<CefV8Handler> GetFunctionHandler()
        /// <summary>
        /// Returns the function handler or NULL if not a CEF-created function.
        /// /*cef()*/
        /// </summary>
        /*8264*/

        public CefV8Handler GetFunctionHandler()/*8265*/
        {
            JsValue ret;
            /*8266*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8Value_GetFunctionHandler_42, out ret);
            /*8267*/
            var ret_result = new CefV8Handler(ret.Ptr);
            /*8268*/
            return ret_result;
            /*8269*/
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
        /*8270*/

        public CefV8Value ExecuteFunction(CefV8Value /*8271*/
        _object
        , CefV8ValueList /*8272*/
        arguments
        )/*8273*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = _object.nativePtr/*8274*/
            ;
            v2.Ptr = arguments.nativePtr/*8275*/
            ;
            /*8276*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefV8Value_ExecuteFunction_43, out ret, ref v1, ref v2);
            /*8277*/
            var ret_result = new CefV8Value(ret.Ptr);
            /*8278*/
            return ret_result;
            /*8279*/
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
        /*8280*/

        public CefV8Value ExecuteFunctionWithContext(CefV8Context /*8281*/
        context
        , CefV8Value /*8282*/
        _object
        , CefV8ValueList /*8283*/
        arguments
        )/*8284*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = context.nativePtr/*8285*/
            ;
            v2.Ptr = _object.nativePtr/*8286*/
            ;
            v3.Ptr = arguments.nativePtr/*8287*/
            ;
            /*8288*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefV8Value_ExecuteFunctionWithContext_44, out ret, ref v1, ref v2, ref v3);
            /*8289*/
            var ret_result = new CefV8Value(ret.Ptr);
            /*8290*/
            return ret_result;
            /*8291*/
        }
        /*8292*/
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
    /*8316*/
    public struct CefV8StackTrace
    {
        /*8317*/
        const int _typeNAME = 44;
        /*8318*/
        const int CefV8StackTrace_Release_0 = (_typeNAME << 16) | 0;
        /*8319*/
        const int CefV8StackTrace_IsValid_1 = (_typeNAME << 16) | 1;
        /*8320*/
        const int CefV8StackTrace_GetFrameCount_2 = (_typeNAME << 16) | 2;
        /*8321*/
        const int CefV8StackTrace_GetFrame_3 = (_typeNAME << 16) | 3;
        /*8322*/
        internal readonly IntPtr nativePtr;
        /*8323*/
        internal CefV8StackTrace(IntPtr nativePtr)
        {
            /*8324*/
            this.nativePtr = nativePtr;
            /*8325*/
        }
        /*8326*/
        public void Release()
        {
            /*8327*/
            JsValue ret;
            /*8328*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_Release_0, out ret);
            /*8329*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefV8StackTrace methods.
        /// </summary>
        /*8330*/

        public bool IsValid()/*8331*/
        {
            JsValue ret;
            /*8332*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_IsValid_1, out ret);
            /*8333*/
            var ret_result = ret.I32 != 0;
            /*8334*/
            return ret_result;
            /*8335*/
        }

        // gen! int GetFrameCount()
        /// <summary>
        /// Returns the number of stack frames.
        /// /*cef()*/
        /// </summary>
        /*8336*/

        public int GetFrameCount()/*8337*/
        {
            JsValue ret;
            /*8338*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackTrace_GetFrameCount_2, out ret);
            /*8339*/
            var ret_result = ret.I32;
            /*8340*/
            return ret_result;
            /*8341*/
        }

        // gen! CefRefPtr<CefV8StackFrame> GetFrame(int index)
        /// <summary>
        /// Returns the stack frame at the specified 0-based index.
        /// /*cef()*/
        /// </summary>
        /*8342*/

        public CefV8StackFrame GetFrame(int /*8343*/
        index
        )/*8344*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*8345*/
            ;
            /*8346*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefV8StackTrace_GetFrame_3, out ret, ref v1);
            /*8347*/
            var ret_result = new CefV8StackFrame(ret.Ptr);
            /*8348*/
            return ret_result;
            /*8349*/
        }
        /*8350*/
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
    /*8399*/
    public struct CefV8StackFrame
    {
        /*8400*/
        const int _typeNAME = 45;
        /*8401*/
        const int CefV8StackFrame_Release_0 = (_typeNAME << 16) | 0;
        /*8402*/
        const int CefV8StackFrame_IsValid_1 = (_typeNAME << 16) | 1;
        /*8403*/
        const int CefV8StackFrame_GetScriptName_2 = (_typeNAME << 16) | 2;
        /*8404*/
        const int CefV8StackFrame_GetScriptNameOrSourceURL_3 = (_typeNAME << 16) | 3;
        /*8405*/
        const int CefV8StackFrame_GetFunctionName_4 = (_typeNAME << 16) | 4;
        /*8406*/
        const int CefV8StackFrame_GetLineNumber_5 = (_typeNAME << 16) | 5;
        /*8407*/
        const int CefV8StackFrame_GetColumn_6 = (_typeNAME << 16) | 6;
        /*8408*/
        const int CefV8StackFrame_IsEval_7 = (_typeNAME << 16) | 7;
        /*8409*/
        const int CefV8StackFrame_IsConstructor_8 = (_typeNAME << 16) | 8;
        /*8410*/
        internal readonly IntPtr nativePtr;
        /*8411*/
        internal CefV8StackFrame(IntPtr nativePtr)
        {
            /*8412*/
            this.nativePtr = nativePtr;
            /*8413*/
        }
        /*8414*/
        public void Release()
        {
            /*8415*/
            JsValue ret;
            /*8416*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_Release_0, out ret);
            /*8417*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefV8StackFrame methods.
        /// </summary>
        /*8418*/

        public bool IsValid()/*8419*/
        {
            JsValue ret;
            /*8420*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsValid_1, out ret);
            /*8421*/
            var ret_result = ret.I32 != 0;
            /*8422*/
            return ret_result;
            /*8423*/
        }

        // gen! CefString GetScriptName()
        /// <summary>
        /// Returns the name of the resource script that contains the function.
        /// /*cef()*/
        /// </summary>
        /*8424*/

        public string GetScriptName()/*8425*/
        {
            JsValue ret;
            /*8426*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetScriptName_2, out ret);
            /*8427*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8428*/
            return ret_result;
            /*8429*/
        }

        // gen! CefString GetScriptNameOrSourceURL()
        /// <summary>
        /// Returns the name of the resource script that contains the function or the
        /// sourceURL value if the script name is undefined and its source ends with
        /// a "//@ sourceURL=..." string.
        /// /*cef()*/
        /// </summary>
        /*8430*/

        public string GetScriptNameOrSourceURL()/*8431*/
        {
            JsValue ret;
            /*8432*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetScriptNameOrSourceURL_3, out ret);
            /*8433*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8434*/
            return ret_result;
            /*8435*/
        }

        // gen! CefString GetFunctionName()
        /// <summary>
        /// Returns the name of the function.
        /// /*cef()*/
        /// </summary>
        /*8436*/

        public string GetFunctionName()/*8437*/
        {
            JsValue ret;
            /*8438*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetFunctionName_4, out ret);
            /*8439*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8440*/
            return ret_result;
            /*8441*/
        }

        // gen! int GetLineNumber()
        /// <summary>
        /// Returns the 1-based line number for the function call or 0 if unknown.
        /// /*cef()*/
        /// </summary>
        /*8442*/

        public int GetLineNumber()/*8443*/
        {
            JsValue ret;
            /*8444*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetLineNumber_5, out ret);
            /*8445*/
            var ret_result = ret.I32;
            /*8446*/
            return ret_result;
            /*8447*/
        }

        // gen! int GetColumn()
        /// <summary>
        /// Returns the 1-based column offset on the line for the function call or 0 if
        /// unknown.
        /// /*cef()*/
        /// </summary>
        /*8448*/

        public int GetColumn()/*8449*/
        {
            JsValue ret;
            /*8450*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_GetColumn_6, out ret);
            /*8451*/
            var ret_result = ret.I32;
            /*8452*/
            return ret_result;
            /*8453*/
        }

        // gen! bool IsEval()
        /// <summary>
        /// Returns true if the function was compiled using eval().
        /// /*cef()*/
        /// </summary>
        /*8454*/

        public bool IsEval()/*8455*/
        {
            JsValue ret;
            /*8456*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsEval_7, out ret);
            /*8457*/
            var ret_result = ret.I32 != 0;
            /*8458*/
            return ret_result;
            /*8459*/
        }

        // gen! bool IsConstructor()
        /// <summary>
        /// Returns true if the function was called as a constructor via "new".
        /// /*cef()*/
        /// </summary>
        /*8460*/

        public bool IsConstructor()/*8461*/
        {
            JsValue ret;
            /*8462*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefV8StackFrame_IsConstructor_8, out ret);
            /*8463*/
            var ret_result = ret.I32 != 0;
            /*8464*/
            return ret_result;
            /*8465*/
        }
        /*8466*/
    }


    // [virtual] class CefValue
    /// <summary>
    /// Class that wraps other data value types. Complex types (binary, dictionary
    /// and list) will be referenced but not owned by this object. Can be used on any
    /// process and thread.
    /// /*cef(source=library)*/
    /// </summary>
    /*8585*/
    public struct CefValue
    {
        /*8586*/
        const int _typeNAME = 46;
        /*8587*/
        const int CefValue_Release_0 = (_typeNAME << 16) | 0;
        /*8588*/
        const int CefValue_IsValid_1 = (_typeNAME << 16) | 1;
        /*8589*/
        const int CefValue_IsOwned_2 = (_typeNAME << 16) | 2;
        /*8590*/
        const int CefValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        /*8591*/
        const int CefValue_IsSame_4 = (_typeNAME << 16) | 4;
        /*8592*/
        const int CefValue_IsEqual_5 = (_typeNAME << 16) | 5;
        /*8593*/
        const int CefValue_Copy_6 = (_typeNAME << 16) | 6;
        /*8594*/
        const int CefValue_GetType_7 = (_typeNAME << 16) | 7;
        /*8595*/
        const int CefValue_GetBool_8 = (_typeNAME << 16) | 8;
        /*8596*/
        const int CefValue_GetInt_9 = (_typeNAME << 16) | 9;
        /*8597*/
        const int CefValue_GetDouble_10 = (_typeNAME << 16) | 10;
        /*8598*/
        const int CefValue_GetString_11 = (_typeNAME << 16) | 11;
        /*8599*/
        const int CefValue_GetBinary_12 = (_typeNAME << 16) | 12;
        /*8600*/
        const int CefValue_GetDictionary_13 = (_typeNAME << 16) | 13;
        /*8601*/
        const int CefValue_GetList_14 = (_typeNAME << 16) | 14;
        /*8602*/
        const int CefValue_SetNull_15 = (_typeNAME << 16) | 15;
        /*8603*/
        const int CefValue_SetBool_16 = (_typeNAME << 16) | 16;
        /*8604*/
        const int CefValue_SetInt_17 = (_typeNAME << 16) | 17;
        /*8605*/
        const int CefValue_SetDouble_18 = (_typeNAME << 16) | 18;
        /*8606*/
        const int CefValue_SetString_19 = (_typeNAME << 16) | 19;
        /*8607*/
        const int CefValue_SetBinary_20 = (_typeNAME << 16) | 20;
        /*8608*/
        const int CefValue_SetDictionary_21 = (_typeNAME << 16) | 21;
        /*8609*/
        const int CefValue_SetList_22 = (_typeNAME << 16) | 22;
        /*8610*/
        internal readonly IntPtr nativePtr;
        /*8611*/
        internal CefValue(IntPtr nativePtr)
        {
            /*8612*/
            this.nativePtr = nativePtr;
            /*8613*/
        }
        /*8614*/
        public void Release()
        {
            /*8615*/
            JsValue ret;
            /*8616*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_Release_0, out ret);
            /*8617*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefValue methods.
        /// </summary>
        /*8618*/

        public bool IsValid()/*8619*/
        {
            JsValue ret;
            /*8620*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsValid_1, out ret);
            /*8621*/
            var ret_result = ret.I32 != 0;
            /*8622*/
            return ret_result;
            /*8623*/
        }

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if the underlying data is owned by another object.
        /// /*cef()*/
        /// </summary>
        /*8624*/

        public bool IsOwned()/*8625*/
        {
            JsValue ret;
            /*8626*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsOwned_2, out ret);
            /*8627*/
            var ret_result = ret.I32 != 0;
            /*8628*/
            return ret_result;
            /*8629*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the underlying data is read-only. Some APIs may expose
        /// read-only objects.
        /// /*cef()*/
        /// </summary>
        /*8630*/

        public bool IsReadOnly()/*8631*/
        {
            JsValue ret;
            /*8632*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_IsReadOnly_3, out ret);
            /*8633*/
            var ret_result = ret.I32 != 0;
            /*8634*/
            return ret_result;
            /*8635*/
        }

        // gen! bool IsSame(CefRefPtr<CefValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>
        /*8636*/

        public bool IsSame(CefValue /*8637*/
        that
        )/*8638*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr/*8639*/
            ;
            /*8640*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_IsSame_4, out ret, ref v1);
            /*8641*/
            var ret_result = ret.I32 != 0;
            /*8642*/
            return ret_result;
            /*8643*/
        }

        // gen! bool IsEqual(CefRefPtr<CefValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>
        /*8644*/

        public bool IsEqual(CefValue /*8645*/
        that
        )/*8646*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr/*8647*/
            ;
            /*8648*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_IsEqual_5, out ret, ref v1);
            /*8649*/
            var ret_result = ret.I32 != 0;
            /*8650*/
            return ret_result;
            /*8651*/
        }

        // gen! CefRefPtr<CefValue> Copy()
        /// <summary>
        /// Returns a copy of this object. The underlying data will also be copied.
        /// /*cef()*/
        /// </summary>
        /*8652*/

        public CefValue Copy()/*8653*/
        {
            JsValue ret;
            /*8654*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_Copy_6, out ret);
            /*8655*/
            var ret_result = new CefValue(ret.Ptr);
            /*8656*/
            return ret_result;
            /*8657*/
        }

        // gen! CefValueType GetType()
        /// <summary>
        /// Returns the underlying value type.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>
        /*8658*/

        public cef_value_type_t _GetType()/*8659*/
        {
            JsValue ret;
            /*8660*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetType_7, out ret);
            /*8661*/
            var ret_result = (cef_value_type_t)ret.I32;

            /*8662*/
            return ret_result;
            /*8663*/
        }

        // gen! bool GetBool()
        /// <summary>
        /// Returns the underlying value as type bool.
        /// /*cef()*/
        /// </summary>
        /*8664*/

        public bool GetBool()/*8665*/
        {
            JsValue ret;
            /*8666*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetBool_8, out ret);
            /*8667*/
            var ret_result = ret.I32 != 0;
            /*8668*/
            return ret_result;
            /*8669*/
        }

        // gen! int GetInt()
        /// <summary>
        /// Returns the underlying value as type int.
        /// /*cef()*/
        /// </summary>
        /*8670*/

        public int GetInt()/*8671*/
        {
            JsValue ret;
            /*8672*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetInt_9, out ret);
            /*8673*/
            var ret_result = ret.I32;
            /*8674*/
            return ret_result;
            /*8675*/
        }

        // gen! double GetDouble()
        /// <summary>
        /// Returns the underlying value as type double.
        /// /*cef()*/
        /// </summary>
        /*8676*/

        public double GetDouble()/*8677*/
        {
            JsValue ret;
            /*8678*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetDouble_10, out ret);
            /*8679*/
            var ret_result = ret.Num;
            /*8680*/
            return ret_result;
            /*8681*/
        }

        // gen! CefString GetString()
        /// <summary>
        /// Returns the underlying value as type string.
        /// /*cef()*/
        /// </summary>
        /*8682*/

        public string GetString()/*8683*/
        {
            JsValue ret;
            /*8684*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetString_11, out ret);
            /*8685*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*8686*/
            return ret_result;
            /*8687*/
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
        /*8688*/

        public CefBinaryValue GetBinary()/*8689*/
        {
            JsValue ret;
            /*8690*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetBinary_12, out ret);
            /*8691*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*8692*/
            return ret_result;
            /*8693*/
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
        /*8694*/

        public CefDictionaryValue GetDictionary()/*8695*/
        {
            JsValue ret;
            /*8696*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetDictionary_13, out ret);
            /*8697*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            /*8698*/
            return ret_result;
            /*8699*/
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
        /*8700*/

        public CefListValue GetList()/*8701*/
        {
            JsValue ret;
            /*8702*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_GetList_14, out ret);
            /*8703*/
            var ret_result = new CefListValue(ret.Ptr);
            /*8704*/
            return ret_result;
            /*8705*/
        }

        // gen! bool SetNull()
        /// <summary>
        /// Sets the underlying value as type null. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>
        /*8706*/

        public bool SetNull()/*8707*/
        {
            JsValue ret;
            /*8708*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefValue_SetNull_15, out ret);
            /*8709*/
            var ret_result = ret.I32 != 0;
            /*8710*/
            return ret_result;
            /*8711*/
        }

        // gen! bool SetBool(bool value)
        /// <summary>
        /// Sets the underlying value as type bool. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>
        /*8712*/

        public bool SetBool(bool /*8713*/
        value
        )/*8714*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = value ? 1 : 0/*8715*/
            ;
            /*8716*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetBool_16, out ret, ref v1);
            /*8717*/
            var ret_result = ret.I32 != 0;
            /*8718*/
            return ret_result;
            /*8719*/
        }

        // gen! bool SetInt(int value)
        /// <summary>
        /// Sets the underlying value as type int. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>
        /*8720*/

        public bool SetInt(int /*8721*/
        value
        )/*8722*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)value/*8723*/
            ;
            /*8724*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetInt_17, out ret, ref v1);
            /*8725*/
            var ret_result = ret.I32 != 0;
            /*8726*/
            return ret_result;
            /*8727*/
        }

        // gen! bool SetDouble(double value)
        /// <summary>
        /// Sets the underlying value as type double. Returns true if the value was set
        /// successfully.
        /// /*cef()*/
        /// </summary>
        /*8728*/

        public bool SetDouble(double /*8729*/
        value
        )/*8730*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Num = value/*8731*/
            ;
            /*8732*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetDouble_18, out ret, ref v1);
            /*8733*/
            var ret_result = ret.I32 != 0;
            /*8734*/
            return ret_result;
            /*8735*/
        }

        // gen! bool SetString(const CefString& value)
        /// <summary>
        /// Sets the underlying value as type string. Returns true if the value was set
        /// successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>
        /*8736*/

        public bool SetString(string /*8737*/
        value
        )/*8738*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*8739*/
            ;
            /*8740*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetString_19, out ret, ref v1);
            /*8741*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*8742*/
            ;
            /*8743*/
            return ret_result;
            /*8744*/
        }

        // gen! bool SetBinary(CefRefPtr<CefBinaryValue> value)
        /// <summary>
        /// Sets the underlying value as type binary. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>
        /*8745*/

        public bool SetBinary(CefBinaryValue /*8746*/
        value
        )/*8747*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = value.nativePtr/*8748*/
            ;
            /*8749*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetBinary_20, out ret, ref v1);
            /*8750*/
            var ret_result = ret.I32 != 0;
            /*8751*/
            return ret_result;
            /*8752*/
        }

        // gen! bool SetDictionary(CefRefPtr<CefDictionaryValue> value)
        /// <summary>
        /// Sets the underlying value as type dict. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>
        /*8753*/

        public bool SetDictionary(CefDictionaryValue /*8754*/
        value
        )/*8755*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = value.nativePtr/*8756*/
            ;
            /*8757*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetDictionary_21, out ret, ref v1);
            /*8758*/
            var ret_result = ret.I32 != 0;
            /*8759*/
            return ret_result;
            /*8760*/
        }

        // gen! bool SetList(CefRefPtr<CefListValue> value)
        /// <summary>
        /// Sets the underlying value as type list. Returns true if the value was set
        /// successfully. This object keeps a reference to |value| and ownership of the
        /// underlying data remains unchanged.
        /// /*cef()*/
        /// </summary>
        /*8761*/

        public bool SetList(CefListValue /*8762*/
        value
        )/*8763*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = value.nativePtr/*8764*/
            ;
            /*8765*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefValue_SetList_22, out ret, ref v1);
            /*8766*/
            var ret_result = ret.I32 != 0;
            /*8767*/
            return ret_result;
            /*8768*/
        }
        /*8769*/
    }


    // [virtual] class CefBinaryValue
    /// <summary>
    /// Class representing a binary value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    /*8813*/
    public struct CefBinaryValue
    {
        /*8814*/
        const int _typeNAME = 47;
        /*8815*/
        const int CefBinaryValue_Release_0 = (_typeNAME << 16) | 0;
        /*8816*/
        const int CefBinaryValue_IsValid_1 = (_typeNAME << 16) | 1;
        /*8817*/
        const int CefBinaryValue_IsOwned_2 = (_typeNAME << 16) | 2;
        /*8818*/
        const int CefBinaryValue_IsSame_3 = (_typeNAME << 16) | 3;
        /*8819*/
        const int CefBinaryValue_IsEqual_4 = (_typeNAME << 16) | 4;
        /*8820*/
        const int CefBinaryValue_Copy_5 = (_typeNAME << 16) | 5;
        /*8821*/
        const int CefBinaryValue_GetSize_6 = (_typeNAME << 16) | 6;
        /*8822*/
        const int CefBinaryValue_GetData_7 = (_typeNAME << 16) | 7;
        /*8823*/
        internal readonly IntPtr nativePtr;
        /*8824*/
        internal CefBinaryValue(IntPtr nativePtr)
        {
            /*8825*/
            this.nativePtr = nativePtr;
            /*8826*/
        }
        /*8827*/
        public void Release()
        {
            /*8828*/
            JsValue ret;
            /*8829*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_Release_0, out ret);
            /*8830*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefBinaryValue methods.
        /// </summary>
        /*8831*/

        public bool IsValid()/*8832*/
        {
            JsValue ret;
            /*8833*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_IsValid_1, out ret);
            /*8834*/
            var ret_result = ret.I32 != 0;
            /*8835*/
            return ret_result;
            /*8836*/
        }

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>
        /*8837*/

        public bool IsOwned()/*8838*/
        {
            JsValue ret;
            /*8839*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_IsOwned_2, out ret);
            /*8840*/
            var ret_result = ret.I32 != 0;
            /*8841*/
            return ret_result;
            /*8842*/
        }

        // gen! bool IsSame(CefRefPtr<CefBinaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data.
        /// /*cef()*/
        /// </summary>
        /*8843*/

        public bool IsSame(CefBinaryValue /*8844*/
        that
        )/*8845*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr/*8846*/
            ;
            /*8847*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBinaryValue_IsSame_3, out ret, ref v1);
            /*8848*/
            var ret_result = ret.I32 != 0;
            /*8849*/
            return ret_result;
            /*8850*/
        }

        // gen! bool IsEqual(CefRefPtr<CefBinaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>
        /*8851*/

        public bool IsEqual(CefBinaryValue /*8852*/
        that
        )/*8853*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr/*8854*/
            ;
            /*8855*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefBinaryValue_IsEqual_4, out ret, ref v1);
            /*8856*/
            var ret_result = ret.I32 != 0;
            /*8857*/
            return ret_result;
            /*8858*/
        }

        // gen! CefRefPtr<CefBinaryValue> Copy()
        /// <summary>
        /// Returns a copy of this object. The data in this object will also be copied.
        /// /*cef()*/
        /// </summary>
        /*8859*/

        public CefBinaryValue Copy()/*8860*/
        {
            JsValue ret;
            /*8861*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_Copy_5, out ret);
            /*8862*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*8863*/
            return ret_result;
            /*8864*/
        }

        // gen! size_t GetSize()
        /// <summary>
        /// Returns the data size.
        /// /*cef()*/
        /// </summary>
        /*8865*/

        public uint GetSize()/*8866*/
        {
            JsValue ret;
            /*8867*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefBinaryValue_GetSize_6, out ret);
            /*8868*/
            var ret_result = (uint)ret.I32;
            /*8869*/
            return ret_result;
            /*8870*/
        }

        // gen! size_t GetData(void* buffer,size_t buffer_size,size_t data_offset)
        /// <summary>
        /// Read up to |buffer_size| number of bytes into |buffer|. Reading begins at
        /// the specified byte |data_offset|. Returns the number of bytes read.
        /// /*cef()*/
        /// </summary>
        /*8871*/

        public uint GetData(IntPtr /*8872*/
        buffer
        , uint /*8873*/
        buffer_size
        , uint /*8874*/
        data_offset
        )/*8875*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue v3 = new JsValue();
            JsValue ret;
            v1.Ptr = buffer/*8876*/
            ;
            v2.I32 = (int)buffer_size/*8877*/
            ;
            v3.I32 = (int)data_offset/*8878*/
            ;
            /*8879*/

            Cef3Binder.MyCefMet_Call3(this.nativePtr, CefBinaryValue_GetData_7, out ret, ref v1, ref v2, ref v3);
            /*8880*/
            var ret_result = (uint)ret.I32;
            /*8881*/
            return ret_result;
            /*8882*/
        }
        /*8883*/
    }


    // [virtual] class CefDictionaryValue
    /// <summary>
    /// Class representing a dictionary value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    /*9037*/
    public struct CefDictionaryValue
    {
        /*9038*/
        const int _typeNAME = 48;
        /*9039*/
        const int CefDictionaryValue_Release_0 = (_typeNAME << 16) | 0;
        /*9040*/
        const int CefDictionaryValue_IsValid_1 = (_typeNAME << 16) | 1;
        /*9041*/
        const int CefDictionaryValue_IsOwned_2 = (_typeNAME << 16) | 2;
        /*9042*/
        const int CefDictionaryValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        /*9043*/
        const int CefDictionaryValue_IsSame_4 = (_typeNAME << 16) | 4;
        /*9044*/
        const int CefDictionaryValue_IsEqual_5 = (_typeNAME << 16) | 5;
        /*9045*/
        const int CefDictionaryValue_Copy_6 = (_typeNAME << 16) | 6;
        /*9046*/
        const int CefDictionaryValue_GetSize_7 = (_typeNAME << 16) | 7;
        /*9047*/
        const int CefDictionaryValue_Clear_8 = (_typeNAME << 16) | 8;
        /*9048*/
        const int CefDictionaryValue_HasKey_9 = (_typeNAME << 16) | 9;
        /*9049*/
        const int CefDictionaryValue_GetKeys_10 = (_typeNAME << 16) | 10;
        /*9050*/
        const int CefDictionaryValue_Remove_11 = (_typeNAME << 16) | 11;
        /*9051*/
        const int CefDictionaryValue_GetType_12 = (_typeNAME << 16) | 12;
        /*9052*/
        const int CefDictionaryValue_GetValue_13 = (_typeNAME << 16) | 13;
        /*9053*/
        const int CefDictionaryValue_GetBool_14 = (_typeNAME << 16) | 14;
        /*9054*/
        const int CefDictionaryValue_GetInt_15 = (_typeNAME << 16) | 15;
        /*9055*/
        const int CefDictionaryValue_GetDouble_16 = (_typeNAME << 16) | 16;
        /*9056*/
        const int CefDictionaryValue_GetString_17 = (_typeNAME << 16) | 17;
        /*9057*/
        const int CefDictionaryValue_GetBinary_18 = (_typeNAME << 16) | 18;
        /*9058*/
        const int CefDictionaryValue_GetDictionary_19 = (_typeNAME << 16) | 19;
        /*9059*/
        const int CefDictionaryValue_GetList_20 = (_typeNAME << 16) | 20;
        /*9060*/
        const int CefDictionaryValue_SetValue_21 = (_typeNAME << 16) | 21;
        /*9061*/
        const int CefDictionaryValue_SetNull_22 = (_typeNAME << 16) | 22;
        /*9062*/
        const int CefDictionaryValue_SetBool_23 = (_typeNAME << 16) | 23;
        /*9063*/
        const int CefDictionaryValue_SetInt_24 = (_typeNAME << 16) | 24;
        /*9064*/
        const int CefDictionaryValue_SetDouble_25 = (_typeNAME << 16) | 25;
        /*9065*/
        const int CefDictionaryValue_SetString_26 = (_typeNAME << 16) | 26;
        /*9066*/
        const int CefDictionaryValue_SetBinary_27 = (_typeNAME << 16) | 27;
        /*9067*/
        const int CefDictionaryValue_SetDictionary_28 = (_typeNAME << 16) | 28;
        /*9068*/
        const int CefDictionaryValue_SetList_29 = (_typeNAME << 16) | 29;
        /*9069*/
        internal readonly IntPtr nativePtr;
        /*9070*/
        internal CefDictionaryValue(IntPtr nativePtr)
        {
            /*9071*/
            this.nativePtr = nativePtr;
            /*9072*/
        }
        /*9073*/
        public void Release()
        {
            /*9074*/
            JsValue ret;
            /*9075*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_Release_0, out ret);
            /*9076*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefDictionaryValue methods.
        /// </summary>
        /*9077*/

        public bool IsValid()/*9078*/
        {
            JsValue ret;
            /*9079*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsValid_1, out ret);
            /*9080*/
            var ret_result = ret.I32 != 0;
            /*9081*/
            return ret_result;
            /*9082*/
        }

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>
        /*9083*/

        public bool IsOwned()/*9084*/
        {
            JsValue ret;
            /*9085*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsOwned_2, out ret);
            /*9086*/
            var ret_result = ret.I32 != 0;
            /*9087*/
            return ret_result;
            /*9088*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*9089*/

        public bool IsReadOnly()/*9090*/
        {
            JsValue ret;
            /*9091*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_IsReadOnly_3, out ret);
            /*9092*/
            var ret_result = ret.I32 != 0;
            /*9093*/
            return ret_result;
            /*9094*/
        }

        // gen! bool IsSame(CefRefPtr<CefDictionaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>
        /*9095*/

        public bool IsSame(CefDictionaryValue /*9096*/
        that
        )/*9097*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr/*9098*/
            ;
            /*9099*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_IsSame_4, out ret, ref v1);
            /*9100*/
            var ret_result = ret.I32 != 0;
            /*9101*/
            return ret_result;
            /*9102*/
        }

        // gen! bool IsEqual(CefRefPtr<CefDictionaryValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>
        /*9103*/

        public bool IsEqual(CefDictionaryValue /*9104*/
        that
        )/*9105*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr/*9106*/
            ;
            /*9107*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_IsEqual_5, out ret, ref v1);
            /*9108*/
            var ret_result = ret.I32 != 0;
            /*9109*/
            return ret_result;
            /*9110*/
        }

        // gen! CefRefPtr<CefDictionaryValue> Copy(bool exclude_empty_children)
        /// <summary>
        /// Returns a writable copy of this object. If |exclude_empty_children| is true
        /// any empty dictionaries or lists will be excluded from the copy.
        /// /*cef()*/
        /// </summary>
        /*9111*/

        public CefDictionaryValue Copy(bool /*9112*/
        exclude_empty_children
        )/*9113*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = exclude_empty_children ? 1 : 0/*9114*/
            ;
            /*9115*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_Copy_6, out ret, ref v1);
            /*9116*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            /*9117*/
            return ret_result;
            /*9118*/
        }

        // gen! size_t GetSize()
        /// <summary>
        /// Returns the number of values.
        /// /*cef()*/
        /// </summary>
        /*9119*/

        public uint GetSize()/*9120*/
        {
            JsValue ret;
            /*9121*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_GetSize_7, out ret);
            /*9122*/
            var ret_result = (uint)ret.I32;
            /*9123*/
            return ret_result;
            /*9124*/
        }

        // gen! bool Clear()
        /// <summary>
        /// Removes all values. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*9125*/

        public bool Clear()/*9126*/
        {
            JsValue ret;
            /*9127*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefDictionaryValue_Clear_8, out ret);
            /*9128*/
            var ret_result = ret.I32 != 0;
            /*9129*/
            return ret_result;
            /*9130*/
        }

        // gen! bool HasKey(const CefString& key)
        /// <summary>
        /// Returns true if the current dictionary has a value for the given key.
        /// /*cef()*/
        /// </summary>
        /*9131*/

        public bool HasKey(string /*9132*/
        key
        )/*9133*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9134*/
            ;
            /*9135*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_HasKey_9, out ret, ref v1);
            /*9136*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9137*/
            ;
            /*9138*/
            return ret_result;
            /*9139*/
        }

        // gen! bool GetKeys(KeyList& keys)
        /// <summary>
        /// Reads all keys for this dictionary into the specified vector.
        /// /*cef()*/
        /// </summary>
        /*9140*/

        public bool GetKeys(KeyList /*9141*/
        keys
        )/*9142*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = keys.nativePtr/*9143*/
            ;
            /*9144*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetKeys_10, out ret, ref v1);
            /*9145*/
            var ret_result = ret.I32 != 0;
            /*9146*/
            return ret_result;
            /*9147*/
        }

        // gen! bool Remove(const CefString& key)
        /// <summary>
        /// Removes the value at the specified key. Returns true is the value was
        /// removed successfully.
        /// /*cef()*/
        /// </summary>
        /*9148*/

        public bool Remove(string /*9149*/
        key
        )/*9150*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9151*/
            ;
            /*9152*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_Remove_11, out ret, ref v1);
            /*9153*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9154*/
            ;
            /*9155*/
            return ret_result;
            /*9156*/
        }

        // gen! CefValueType GetType(const CefString& key)
        /// <summary>
        /// Returns the value type for the specified key.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>
        /*9157*/

        public cef_value_type_t _GetType(string /*9158*/
        key
        )/*9159*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9160*/
            ;
            /*9161*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetType_12, out ret, ref v1);
            /*9162*/
            var ret_result = (cef_value_type_t)ret.I32;

            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9163*/
            ;
            /*9164*/
            return ret_result;
            /*9165*/
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
        /*9166*/

        public CefValue GetValue(string /*9167*/
        key
        )/*9168*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9169*/
            ;
            /*9170*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetValue_13, out ret, ref v1);
            /*9171*/
            var ret_result = new CefValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9172*/
            ;
            /*9173*/
            return ret_result;
            /*9174*/
        }

        // gen! bool GetBool(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type bool.
        /// /*cef()*/
        /// </summary>
        /*9175*/

        public bool GetBool(string /*9176*/
        key
        )/*9177*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9178*/
            ;
            /*9179*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetBool_14, out ret, ref v1);
            /*9180*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9181*/
            ;
            /*9182*/
            return ret_result;
            /*9183*/
        }

        // gen! int GetInt(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type int.
        /// /*cef()*/
        /// </summary>
        /*9184*/

        public int GetInt(string /*9185*/
        key
        )/*9186*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9187*/
            ;
            /*9188*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetInt_15, out ret, ref v1);
            /*9189*/
            var ret_result = ret.I32;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9190*/
            ;
            /*9191*/
            return ret_result;
            /*9192*/
        }

        // gen! double GetDouble(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type double.
        /// /*cef()*/
        /// </summary>
        /*9193*/

        public double GetDouble(string /*9194*/
        key
        )/*9195*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9196*/
            ;
            /*9197*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetDouble_16, out ret, ref v1);
            /*9198*/
            var ret_result = ret.Num;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9199*/
            ;
            /*9200*/
            return ret_result;
            /*9201*/
        }

        // gen! CefString GetString(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type string.
        /// /*cef()*/
        /// </summary>
        /*9202*/

        public string GetString(string /*9203*/
        key
        )/*9204*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9205*/
            ;
            /*9206*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetString_17, out ret, ref v1);
            /*9207*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9208*/
            ;
            /*9209*/
            return ret_result;
            /*9210*/
        }

        // gen! CefRefPtr<CefBinaryValue> GetBinary(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type binary. The returned
        /// value will reference existing data.
        /// /*cef()*/
        /// </summary>
        /*9211*/

        public CefBinaryValue GetBinary(string /*9212*/
        key
        )/*9213*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9214*/
            ;
            /*9215*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetBinary_18, out ret, ref v1);
            /*9216*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9217*/
            ;
            /*9218*/
            return ret_result;
            /*9219*/
        }

        // gen! CefRefPtr<CefDictionaryValue> GetDictionary(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type dictionary. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>
        /*9220*/

        public CefDictionaryValue GetDictionary(string /*9221*/
        key
        )/*9222*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9223*/
            ;
            /*9224*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetDictionary_19, out ret, ref v1);
            /*9225*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9226*/
            ;
            /*9227*/
            return ret_result;
            /*9228*/
        }

        // gen! CefRefPtr<CefListValue> GetList(const CefString& key)
        /// <summary>
        /// Returns the value at the specified key as type list. The returned value
        /// will reference existing data and modifications to the value will modify
        /// this object.
        /// /*cef()*/
        /// </summary>
        /*9229*/

        public CefListValue GetList(string /*9230*/
        key
        )/*9231*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9232*/
            ;
            /*9233*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_GetList_20, out ret, ref v1);
            /*9234*/
            var ret_result = new CefListValue(ret.Ptr);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9235*/
            ;
            /*9236*/
            return ret_result;
            /*9237*/
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
        /*9238*/

        public bool SetValue(string /*9239*/
        key
        , CefValue /*9240*/
        value
        )/*9241*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9242*/
            ;
            v2.Ptr = value.nativePtr/*9243*/
            ;
            /*9244*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetValue_21, out ret, ref v1, ref v2);
            /*9245*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9246*/
            ;
            /*9247*/
            return ret_result;
            /*9248*/
        }

        // gen! bool SetNull(const CefString& key)
        /// <summary>
        /// Sets the value at the specified key as type null. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9249*/

        public bool SetNull(string /*9250*/
        key
        )/*9251*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9252*/
            ;
            /*9253*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefDictionaryValue_SetNull_22, out ret, ref v1);
            /*9254*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9255*/
            ;
            /*9256*/
            return ret_result;
            /*9257*/
        }

        // gen! bool SetBool(const CefString& key,bool value)
        /// <summary>
        /// Sets the value at the specified key as type bool. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9258*/

        public bool SetBool(string /*9259*/
        key
        , bool /*9260*/
        value
        )/*9261*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9262*/
            ;
            v2.I32 = value ? 1 : 0/*9263*/
            ;
            /*9264*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetBool_23, out ret, ref v1, ref v2);
            /*9265*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9266*/
            ;
            /*9267*/
            return ret_result;
            /*9268*/
        }

        // gen! bool SetInt(const CefString& key,int value)
        /// <summary>
        /// Sets the value at the specified key as type int. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9269*/

        public bool SetInt(string /*9270*/
        key
        , int /*9271*/
        value
        )/*9272*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9273*/
            ;
            v2.I32 = (int)value/*9274*/
            ;
            /*9275*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetInt_24, out ret, ref v1, ref v2);
            /*9276*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9277*/
            ;
            /*9278*/
            return ret_result;
            /*9279*/
        }

        // gen! bool SetDouble(const CefString& key,double value)
        /// <summary>
        /// Sets the value at the specified key as type double. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9280*/

        public bool SetDouble(string /*9281*/
        key
        , double /*9282*/
        value
        )/*9283*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9284*/
            ;
            v2.Num = value/*9285*/
            ;
            /*9286*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetDouble_25, out ret, ref v1, ref v2);
            /*9287*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9288*/
            ;
            /*9289*/
            return ret_result;
            /*9290*/
        }

        // gen! bool SetString(const CefString& key,const CefString& value)
        /// <summary>
        /// Sets the value at the specified key as type string. Returns true if the
        /// value was set successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>
        /*9291*/

        public bool SetString(string /*9292*/
        key
        , string /*9293*/
        value
        )/*9294*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9295*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*9296*/
            ;
            /*9297*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetString_26, out ret, ref v1, ref v2);
            /*9298*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9299*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*9300*/
            ;
            /*9301*/
            return ret_result;
            /*9302*/
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
        /*9303*/

        public bool SetBinary(string /*9304*/
        key
        , CefBinaryValue /*9305*/
        value
        )/*9306*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9307*/
            ;
            v2.Ptr = value.nativePtr/*9308*/
            ;
            /*9309*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetBinary_27, out ret, ref v1, ref v2);
            /*9310*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9311*/
            ;
            /*9312*/
            return ret_result;
            /*9313*/
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
        /*9314*/

        public bool SetDictionary(string /*9315*/
        key
        , CefDictionaryValue /*9316*/
        value
        )/*9317*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9318*/
            ;
            v2.Ptr = value.nativePtr/*9319*/
            ;
            /*9320*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetDictionary_28, out ret, ref v1, ref v2);
            /*9321*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9322*/
            ;
            /*9323*/
            return ret_result;
            /*9324*/
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
        /*9325*/

        public bool SetList(string /*9326*/
        key
        , CefListValue /*9327*/
        value
        )/*9328*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(key);
            /*9329*/
            ;
            v2.Ptr = value.nativePtr/*9330*/
            ;
            /*9331*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefDictionaryValue_SetList_29, out ret, ref v1, ref v2);
            /*9332*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*9333*/
            ;
            /*9334*/
            return ret_result;
            /*9335*/
        }
        /*9336*/
    }


    // [virtual] class CefListValue
    /// <summary>
    /// Class representing a list value. Can be used on any process and thread.
    /// /*(source=library)*/
    /// </summary>
    /*9485*/
    public struct CefListValue
    {
        /*9486*/
        const int _typeNAME = 49;
        /*9487*/
        const int CefListValue_Release_0 = (_typeNAME << 16) | 0;
        /*9488*/
        const int CefListValue_IsValid_1 = (_typeNAME << 16) | 1;
        /*9489*/
        const int CefListValue_IsOwned_2 = (_typeNAME << 16) | 2;
        /*9490*/
        const int CefListValue_IsReadOnly_3 = (_typeNAME << 16) | 3;
        /*9491*/
        const int CefListValue_IsSame_4 = (_typeNAME << 16) | 4;
        /*9492*/
        const int CefListValue_IsEqual_5 = (_typeNAME << 16) | 5;
        /*9493*/
        const int CefListValue_Copy_6 = (_typeNAME << 16) | 6;
        /*9494*/
        const int CefListValue_SetSize_7 = (_typeNAME << 16) | 7;
        /*9495*/
        const int CefListValue_GetSize_8 = (_typeNAME << 16) | 8;
        /*9496*/
        const int CefListValue_Clear_9 = (_typeNAME << 16) | 9;
        /*9497*/
        const int CefListValue_Remove_10 = (_typeNAME << 16) | 10;
        /*9498*/
        const int CefListValue_GetType_11 = (_typeNAME << 16) | 11;
        /*9499*/
        const int CefListValue_GetValue_12 = (_typeNAME << 16) | 12;
        /*9500*/
        const int CefListValue_GetBool_13 = (_typeNAME << 16) | 13;
        /*9501*/
        const int CefListValue_GetInt_14 = (_typeNAME << 16) | 14;
        /*9502*/
        const int CefListValue_GetDouble_15 = (_typeNAME << 16) | 15;
        /*9503*/
        const int CefListValue_GetString_16 = (_typeNAME << 16) | 16;
        /*9504*/
        const int CefListValue_GetBinary_17 = (_typeNAME << 16) | 17;
        /*9505*/
        const int CefListValue_GetDictionary_18 = (_typeNAME << 16) | 18;
        /*9506*/
        const int CefListValue_GetList_19 = (_typeNAME << 16) | 19;
        /*9507*/
        const int CefListValue_SetValue_20 = (_typeNAME << 16) | 20;
        /*9508*/
        const int CefListValue_SetNull_21 = (_typeNAME << 16) | 21;
        /*9509*/
        const int CefListValue_SetBool_22 = (_typeNAME << 16) | 22;
        /*9510*/
        const int CefListValue_SetInt_23 = (_typeNAME << 16) | 23;
        /*9511*/
        const int CefListValue_SetDouble_24 = (_typeNAME << 16) | 24;
        /*9512*/
        const int CefListValue_SetString_25 = (_typeNAME << 16) | 25;
        /*9513*/
        const int CefListValue_SetBinary_26 = (_typeNAME << 16) | 26;
        /*9514*/
        const int CefListValue_SetDictionary_27 = (_typeNAME << 16) | 27;
        /*9515*/
        const int CefListValue_SetList_28 = (_typeNAME << 16) | 28;
        /*9516*/
        internal readonly IntPtr nativePtr;
        /*9517*/
        internal CefListValue(IntPtr nativePtr)
        {
            /*9518*/
            this.nativePtr = nativePtr;
            /*9519*/
        }
        /*9520*/
        public void Release()
        {
            /*9521*/
            JsValue ret;
            /*9522*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Release_0, out ret);
            /*9523*/
        }

        // gen! bool IsValid()
        /// <summary>
        /// CefListValue methods.
        /// </summary>
        /*9524*/

        public bool IsValid()/*9525*/
        {
            JsValue ret;
            /*9526*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsValid_1, out ret);
            /*9527*/
            var ret_result = ret.I32 != 0;
            /*9528*/
            return ret_result;
            /*9529*/
        }

        // gen! bool IsOwned()
        /// <summary>
        /// Returns true if this object is currently owned by another object.
        /// /*cef()*/
        /// </summary>
        /*9530*/

        public bool IsOwned()/*9531*/
        {
            JsValue ret;
            /*9532*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsOwned_2, out ret);
            /*9533*/
            var ret_result = ret.I32 != 0;
            /*9534*/
            return ret_result;
            /*9535*/
        }

        // gen! bool IsReadOnly()
        /// <summary>
        /// Returns true if the values of this object are read-only. Some APIs may
        /// expose read-only objects.
        /// /*cef()*/
        /// </summary>
        /*9536*/

        public bool IsReadOnly()/*9537*/
        {
            JsValue ret;
            /*9538*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_IsReadOnly_3, out ret);
            /*9539*/
            var ret_result = ret.I32 != 0;
            /*9540*/
            return ret_result;
            /*9541*/
        }

        // gen! bool IsSame(CefRefPtr<CefListValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have the same underlying
        /// data. If true modifications to this object will also affect |that| object
        /// and vice-versa.
        /// /*cef()*/
        /// </summary>
        /*9542*/

        public bool IsSame(CefListValue /*9543*/
        that
        )/*9544*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr/*9545*/
            ;
            /*9546*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_IsSame_4, out ret, ref v1);
            /*9547*/
            var ret_result = ret.I32 != 0;
            /*9548*/
            return ret_result;
            /*9549*/
        }

        // gen! bool IsEqual(CefRefPtr<CefListValue> that)
        /// <summary>
        /// Returns true if this object and |that| object have an equivalent underlying
        /// value but are not necessarily the same object.
        /// /*cef()*/
        /// </summary>
        /*9550*/

        public bool IsEqual(CefListValue /*9551*/
        that
        )/*9552*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = that.nativePtr/*9553*/
            ;
            /*9554*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_IsEqual_5, out ret, ref v1);
            /*9555*/
            var ret_result = ret.I32 != 0;
            /*9556*/
            return ret_result;
            /*9557*/
        }

        // gen! CefRefPtr<CefListValue> Copy()
        /// <summary>
        /// Returns a writable copy of this object.
        /// /*cef()*/
        /// </summary>
        /*9558*/

        public CefListValue Copy()/*9559*/
        {
            JsValue ret;
            /*9560*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Copy_6, out ret);
            /*9561*/
            var ret_result = new CefListValue(ret.Ptr);
            /*9562*/
            return ret_result;
            /*9563*/
        }

        // gen! bool SetSize(size_t size)
        /// <summary>
        /// Sets the number of values. If the number of values is expanded all
        /// new value slots will default to type null. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*9564*/

        public bool SetSize(uint /*9565*/
        size
        )/*9566*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)size/*9567*/
            ;
            /*9568*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_SetSize_7, out ret, ref v1);
            /*9569*/
            var ret_result = ret.I32 != 0;
            /*9570*/
            return ret_result;
            /*9571*/
        }

        // gen! size_t GetSize()
        /// <summary>
        /// Returns the number of values.
        /// /*cef()*/
        /// </summary>
        /*9572*/

        public uint GetSize()/*9573*/
        {
            JsValue ret;
            /*9574*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_GetSize_8, out ret);
            /*9575*/
            var ret_result = (uint)ret.I32;
            /*9576*/
            return ret_result;
            /*9577*/
        }

        // gen! bool Clear()
        /// <summary>
        /// Removes all values. Returns true on success.
        /// /*cef()*/
        /// </summary>
        /*9578*/

        public bool Clear()/*9579*/
        {
            JsValue ret;
            /*9580*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefListValue_Clear_9, out ret);
            /*9581*/
            var ret_result = ret.I32 != 0;
            /*9582*/
            return ret_result;
            /*9583*/
        }

        // gen! bool Remove(size_t index)
        /// <summary>
        /// Removes the value at the specified index.
        /// /*cef()*/
        /// </summary>
        /*9584*/

        public bool Remove(uint /*9585*/
        index
        )/*9586*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9587*/
            ;
            /*9588*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_Remove_10, out ret, ref v1);
            /*9589*/
            var ret_result = ret.I32 != 0;
            /*9590*/
            return ret_result;
            /*9591*/
        }

        // gen! CefValueType GetType(size_t index)
        /// <summary>
        /// Returns the value type at the specified index.
        /// /*cef(default_retval=VTYPE_INVALID)*/
        /// </summary>
        /*9592*/

        public cef_value_type_t _GetType(uint /*9593*/
        index
        )/*9594*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9595*/
            ;
            /*9596*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetType_11, out ret, ref v1);
            /*9597*/
            var ret_result = (cef_value_type_t)ret.I32;

            /*9598*/
            return ret_result;
            /*9599*/
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
        /*9600*/

        public CefValue GetValue(uint /*9601*/
        index
        )/*9602*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9603*/
            ;
            /*9604*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetValue_12, out ret, ref v1);
            /*9605*/
            var ret_result = new CefValue(ret.Ptr);
            /*9606*/
            return ret_result;
            /*9607*/
        }

        // gen! bool GetBool(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type bool.
        /// /*cef()*/
        /// </summary>
        /*9608*/

        public bool GetBool(uint /*9609*/
        index
        )/*9610*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9611*/
            ;
            /*9612*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetBool_13, out ret, ref v1);
            /*9613*/
            var ret_result = ret.I32 != 0;
            /*9614*/
            return ret_result;
            /*9615*/
        }

        // gen! int GetInt(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type int.
        /// /*cef()*/
        /// </summary>
        /*9616*/

        public int GetInt(uint /*9617*/
        index
        )/*9618*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9619*/
            ;
            /*9620*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetInt_14, out ret, ref v1);
            /*9621*/
            var ret_result = ret.I32;
            /*9622*/
            return ret_result;
            /*9623*/
        }

        // gen! double GetDouble(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type double.
        /// /*cef()*/
        /// </summary>
        /*9624*/

        public double GetDouble(uint /*9625*/
        index
        )/*9626*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9627*/
            ;
            /*9628*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetDouble_15, out ret, ref v1);
            /*9629*/
            var ret_result = ret.Num;
            /*9630*/
            return ret_result;
            /*9631*/
        }

        // gen! CefString GetString(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type string.
        /// /*cef()*/
        /// </summary>
        /*9632*/

        public string GetString(uint /*9633*/
        index
        )/*9634*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9635*/
            ;
            /*9636*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetString_16, out ret, ref v1);
            /*9637*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9638*/
            return ret_result;
            /*9639*/
        }

        // gen! CefRefPtr<CefBinaryValue> GetBinary(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type binary. The returned
        /// value will reference existing data.
        /// /*cef()*/
        /// </summary>
        /*9640*/

        public CefBinaryValue GetBinary(uint /*9641*/
        index
        )/*9642*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9643*/
            ;
            /*9644*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetBinary_17, out ret, ref v1);
            /*9645*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*9646*/
            return ret_result;
            /*9647*/
        }

        // gen! CefRefPtr<CefDictionaryValue> GetDictionary(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type dictionary. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>
        /*9648*/

        public CefDictionaryValue GetDictionary(uint /*9649*/
        index
        )/*9650*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9651*/
            ;
            /*9652*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetDictionary_18, out ret, ref v1);
            /*9653*/
            var ret_result = new CefDictionaryValue(ret.Ptr);
            /*9654*/
            return ret_result;
            /*9655*/
        }

        // gen! CefRefPtr<CefListValue> GetList(size_t index)
        /// <summary>
        /// Returns the value at the specified index as type list. The returned
        /// value will reference existing data and modifications to the value will
        /// modify this object.
        /// /*cef()*/
        /// </summary>
        /*9656*/

        public CefListValue GetList(uint /*9657*/
        index
        )/*9658*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9659*/
            ;
            /*9660*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_GetList_19, out ret, ref v1);
            /*9661*/
            var ret_result = new CefListValue(ret.Ptr);
            /*9662*/
            return ret_result;
            /*9663*/
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
        /*9664*/

        public bool SetValue(uint /*9665*/
        index
        , CefValue /*9666*/
        value
        )/*9667*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9668*/
            ;
            v2.Ptr = value.nativePtr/*9669*/
            ;
            /*9670*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetValue_20, out ret, ref v1, ref v2);
            /*9671*/
            var ret_result = ret.I32 != 0;
            /*9672*/
            return ret_result;
            /*9673*/
        }

        // gen! bool SetNull(size_t index)
        /// <summary>
        /// Sets the value at the specified index as type null. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9674*/

        public bool SetNull(uint /*9675*/
        index
        )/*9676*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9677*/
            ;
            /*9678*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefListValue_SetNull_21, out ret, ref v1);
            /*9679*/
            var ret_result = ret.I32 != 0;
            /*9680*/
            return ret_result;
            /*9681*/
        }

        // gen! bool SetBool(size_t index,bool value)
        /// <summary>
        /// Sets the value at the specified index as type bool. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9682*/

        public bool SetBool(uint /*9683*/
        index
        , bool /*9684*/
        value
        )/*9685*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9686*/
            ;
            v2.I32 = value ? 1 : 0/*9687*/
            ;
            /*9688*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetBool_22, out ret, ref v1, ref v2);
            /*9689*/
            var ret_result = ret.I32 != 0;
            /*9690*/
            return ret_result;
            /*9691*/
        }

        // gen! bool SetInt(size_t index,int value)
        /// <summary>
        /// Sets the value at the specified index as type int. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9692*/

        public bool SetInt(uint /*9693*/
        index
        , int /*9694*/
        value
        )/*9695*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9696*/
            ;
            v2.I32 = (int)value/*9697*/
            ;
            /*9698*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetInt_23, out ret, ref v1, ref v2);
            /*9699*/
            var ret_result = ret.I32 != 0;
            /*9700*/
            return ret_result;
            /*9701*/
        }

        // gen! bool SetDouble(size_t index,double value)
        /// <summary>
        /// Sets the value at the specified index as type double. Returns true if the
        /// value was set successfully.
        /// /*cef()*/
        /// </summary>
        /*9702*/

        public bool SetDouble(uint /*9703*/
        index
        , double /*9704*/
        value
        )/*9705*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9706*/
            ;
            v2.Num = value/*9707*/
            ;
            /*9708*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetDouble_24, out ret, ref v1, ref v2);
            /*9709*/
            var ret_result = ret.I32 != 0;
            /*9710*/
            return ret_result;
            /*9711*/
        }

        // gen! bool SetString(size_t index,const CefString& value)
        /// <summary>
        /// Sets the value at the specified index as type string. Returns true if the
        /// value was set successfully.
        /// /*cef(optional_param=value)*/
        /// </summary>
        /*9712*/

        public bool SetString(uint /*9713*/
        index
        , string /*9714*/
        value
        )/*9715*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(value);
            /*9716*/
            ;
            v1.I32 = (int)index/*9717*/
            ;
            /*9718*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetString_25, out ret, ref v1, ref v2);
            /*9719*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*9720*/
            ;
            /*9721*/
            return ret_result;
            /*9722*/
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
        /*9723*/

        public bool SetBinary(uint /*9724*/
        index
        , CefBinaryValue /*9725*/
        value
        )/*9726*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9727*/
            ;
            v2.Ptr = value.nativePtr/*9728*/
            ;
            /*9729*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetBinary_26, out ret, ref v1, ref v2);
            /*9730*/
            var ret_result = ret.I32 != 0;
            /*9731*/
            return ret_result;
            /*9732*/
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
        /*9733*/

        public bool SetDictionary(uint /*9734*/
        index
        , CefDictionaryValue /*9735*/
        value
        )/*9736*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9737*/
            ;
            v2.Ptr = value.nativePtr/*9738*/
            ;
            /*9739*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetDictionary_27, out ret, ref v1, ref v2);
            /*9740*/
            var ret_result = ret.I32 != 0;
            /*9741*/
            return ret_result;
            /*9742*/
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
        /*9743*/

        public bool SetList(uint /*9744*/
        index
        , CefListValue /*9745*/
        value
        )/*9746*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*9747*/
            ;
            v2.Ptr = value.nativePtr/*9748*/
            ;
            /*9749*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefListValue_SetList_28, out ret, ref v1, ref v2);
            /*9750*/
            var ret_result = ret.I32 != 0;
            /*9751*/
            return ret_result;
            /*9752*/
        }
        /*9753*/
    }


    // [virtual] class CefWebPluginInfo
    /// <summary>
    /// Information about a specific web plugin.
    /// /*(source=library)*/
    /// </summary>
    /*9782*/
    public struct CefWebPluginInfo
    {
        /*9783*/
        const int _typeNAME = 50;
        /*9784*/
        const int CefWebPluginInfo_Release_0 = (_typeNAME << 16) | 0;
        /*9785*/
        const int CefWebPluginInfo_GetName_1 = (_typeNAME << 16) | 1;
        /*9786*/
        const int CefWebPluginInfo_GetPath_2 = (_typeNAME << 16) | 2;
        /*9787*/
        const int CefWebPluginInfo_GetVersion_3 = (_typeNAME << 16) | 3;
        /*9788*/
        const int CefWebPluginInfo_GetDescription_4 = (_typeNAME << 16) | 4;
        /*9789*/
        internal readonly IntPtr nativePtr;
        /*9790*/
        internal CefWebPluginInfo(IntPtr nativePtr)
        {
            /*9791*/
            this.nativePtr = nativePtr;
            /*9792*/
        }
        /*9793*/
        public void Release()
        {
            /*9794*/
            JsValue ret;
            /*9795*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_Release_0, out ret);
            /*9796*/
        }

        // gen! CefString GetName()
        /// <summary>
        /// CefWebPluginInfo methods.
        /// </summary>
        /*9797*/

        public string GetName()/*9798*/
        {
            JsValue ret;
            /*9799*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetName_1, out ret);
            /*9800*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9801*/
            return ret_result;
            /*9802*/
        }

        // gen! CefString GetPath()
        /// <summary>
        /// Returns the plugin file path (DLL/bundle/library).
        /// /*cef()*/
        /// </summary>
        /*9803*/

        public string GetPath()/*9804*/
        {
            JsValue ret;
            /*9805*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetPath_2, out ret);
            /*9806*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9807*/
            return ret_result;
            /*9808*/
        }

        // gen! CefString GetVersion()
        /// <summary>
        /// Returns the version of the plugin (may be OS-specific).
        /// /*cef()*/
        /// </summary>
        /*9809*/

        public string GetVersion()/*9810*/
        {
            JsValue ret;
            /*9811*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetVersion_3, out ret);
            /*9812*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9813*/
            return ret_result;
            /*9814*/
        }

        // gen! CefString GetDescription()
        /// <summary>
        /// Returns a description of the plugin from the version information.
        /// /*cef()*/
        /// </summary>
        /*9815*/

        public string GetDescription()/*9816*/
        {
            JsValue ret;
            /*9817*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfo_GetDescription_4, out ret);
            /*9818*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9819*/
            return ret_result;
            /*9820*/
        }
        /*9821*/
    }


    // [virtual] class CefWebPluginInfoVisitor
    /// <summary>
    /// Interface to implement for visiting web plugin information. The methods of
    /// this class will be called on the browser process UI thread.
    /// /*(source=client)*/
    /// </summary>
    /*9830*/
    public struct CefWebPluginInfoVisitor
    {
        /*9831*/
        const int _typeNAME = 51;
        /*9832*/
        const int CefWebPluginInfoVisitor_Release_0 = (_typeNAME << 16) | 0;
        /*9833*/
        internal readonly IntPtr nativePtr;
        /*9834*/
        internal CefWebPluginInfoVisitor(IntPtr nativePtr)
        {
            /*9835*/
            this.nativePtr = nativePtr;
            /*9836*/
        }
        /*9837*/
        public void Release()
        {
            /*9838*/
            JsValue ret;
            /*9839*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefWebPluginInfoVisitor_Release_0, out ret);
            /*9840*/
        }
        /*9841*/
    }


    // [virtual] class CefX509CertPrincipal
    /// <summary>
    /// Class representing the issuer or subject field of an X.509 certificate.
    /// /*(source=library)*/
    /// </summary>
    /*9895*/
    public struct CefX509CertPrincipal
    {
        /*9896*/
        const int _typeNAME = 52;
        /*9897*/
        const int CefX509CertPrincipal_Release_0 = (_typeNAME << 16) | 0;
        /*9898*/
        const int CefX509CertPrincipal_GetDisplayName_1 = (_typeNAME << 16) | 1;
        /*9899*/
        const int CefX509CertPrincipal_GetCommonName_2 = (_typeNAME << 16) | 2;
        /*9900*/
        const int CefX509CertPrincipal_GetLocalityName_3 = (_typeNAME << 16) | 3;
        /*9901*/
        const int CefX509CertPrincipal_GetStateOrProvinceName_4 = (_typeNAME << 16) | 4;
        /*9902*/
        const int CefX509CertPrincipal_GetCountryName_5 = (_typeNAME << 16) | 5;
        /*9903*/
        const int CefX509CertPrincipal_GetStreetAddresses_6 = (_typeNAME << 16) | 6;
        /*9904*/
        const int CefX509CertPrincipal_GetOrganizationNames_7 = (_typeNAME << 16) | 7;
        /*9905*/
        const int CefX509CertPrincipal_GetOrganizationUnitNames_8 = (_typeNAME << 16) | 8;
        /*9906*/
        const int CefX509CertPrincipal_GetDomainComponents_9 = (_typeNAME << 16) | 9;
        /*9907*/
        internal readonly IntPtr nativePtr;
        /*9908*/
        internal CefX509CertPrincipal(IntPtr nativePtr)
        {
            /*9909*/
            this.nativePtr = nativePtr;
            /*9910*/
        }
        /*9911*/
        public void Release()
        {
            /*9912*/
            JsValue ret;
            /*9913*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_Release_0, out ret);
            /*9914*/
        }

        // gen! CefString GetDisplayName()
        /// <summary>
        /// CefX509CertPrincipal methods.
        /// </summary>
        /*9915*/

        public string GetDisplayName()/*9916*/
        {
            JsValue ret;
            /*9917*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetDisplayName_1, out ret);
            /*9918*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9919*/
            return ret_result;
            /*9920*/
        }

        // gen! CefString GetCommonName()
        /// <summary>
        /// Returns the common name.
        /// /*cef()*/
        /// </summary>
        /*9921*/

        public string GetCommonName()/*9922*/
        {
            JsValue ret;
            /*9923*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetCommonName_2, out ret);
            /*9924*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9925*/
            return ret_result;
            /*9926*/
        }

        // gen! CefString GetLocalityName()
        /// <summary>
        /// Returns the locality name.
        /// /*cef()*/
        /// </summary>
        /*9927*/

        public string GetLocalityName()/*9928*/
        {
            JsValue ret;
            /*9929*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetLocalityName_3, out ret);
            /*9930*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9931*/
            return ret_result;
            /*9932*/
        }

        // gen! CefString GetStateOrProvinceName()
        /// <summary>
        /// Returns the state or province name.
        /// /*cef()*/
        /// </summary>
        /*9933*/

        public string GetStateOrProvinceName()/*9934*/
        {
            JsValue ret;
            /*9935*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetStateOrProvinceName_4, out ret);
            /*9936*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9937*/
            return ret_result;
            /*9938*/
        }

        // gen! CefString GetCountryName()
        /// <summary>
        /// Returns the country name.
        /// /*cef()*/
        /// </summary>
        /*9939*/

        public string GetCountryName()/*9940*/
        {
            JsValue ret;
            /*9941*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509CertPrincipal_GetCountryName_5, out ret);
            /*9942*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*9943*/
            return ret_result;
            /*9944*/
        }

        // gen! void GetStreetAddresses(std::vector<CefString>& addresses)
        /// <summary>
        /// Retrieve the list of street addresses.
        /// /*cef()*/
        /// </summary>
        /*9945*/

        public void GetStreetAddresses(List<string> /*9946*/
        addresses
        )/*9947*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2)/*9948*/
            ;
            /*9949*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetStreetAddresses_6, out ret, ref v1);
            /*9950*/

            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, addresses)/*9951*/
            ;
            /*9952*/
        }

        // gen! void GetOrganizationNames(std::vector<CefString>& names)
        /// <summary>
        /// Retrieve the list of organization names.
        /// /*cef()*/
        /// </summary>
        /*9953*/

        public void GetOrganizationNames(List<string> /*9954*/
        names
        )/*9955*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2)/*9956*/
            ;
            /*9957*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetOrganizationNames_7, out ret, ref v1);
            /*9958*/

            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, names)/*9959*/
            ;
            /*9960*/
        }

        // gen! void GetOrganizationUnitNames(std::vector<CefString>& names)
        /// <summary>
        /// Retrieve the list of organization unit names.
        /// /*cef()*/
        /// </summary>
        /*9961*/

        public void GetOrganizationUnitNames(List<string> /*9962*/
        names
        )/*9963*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2)/*9964*/
            ;
            /*9965*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetOrganizationUnitNames_8, out ret, ref v1);
            /*9966*/

            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, names)/*9967*/
            ;
            /*9968*/
        }

        // gen! void GetDomainComponents(std::vector<CefString>& components)
        /// <summary>
        /// Retrieve the list of domain components.
        /// /*cef()*/
        /// </summary>
        /*9969*/

        public void GetDomainComponents(List<string> /*9970*/
        components
        )/*9971*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.CreateStdList(2)/*9972*/
            ;
            /*9973*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509CertPrincipal_GetDomainComponents_9, out ret, ref v1);
            /*9974*/

            Cef3Binder.CopyStdStringListAndDestroyNativeSide(v1.Ptr, components)/*9975*/
            ;
            /*9976*/
        }
        /*9977*/
    }


    // [virtual] class CefX509Certificate
    /// <summary>
    /// Class representing a X.509 certificate.
    /// /*(source=library)*/
    /// </summary>
    /*10036*/
    public struct CefX509Certificate
    {
        /*10037*/
        const int _typeNAME = 53;
        /*10038*/
        const int CefX509Certificate_Release_0 = (_typeNAME << 16) | 0;
        /*10039*/
        const int CefX509Certificate_GetSubject_1 = (_typeNAME << 16) | 1;
        /*10040*/
        const int CefX509Certificate_GetIssuer_2 = (_typeNAME << 16) | 2;
        /*10041*/
        const int CefX509Certificate_GetSerialNumber_3 = (_typeNAME << 16) | 3;
        /*10042*/
        const int CefX509Certificate_GetValidStart_4 = (_typeNAME << 16) | 4;
        /*10043*/
        const int CefX509Certificate_GetValidExpiry_5 = (_typeNAME << 16) | 5;
        /*10044*/
        const int CefX509Certificate_GetDEREncoded_6 = (_typeNAME << 16) | 6;
        /*10045*/
        const int CefX509Certificate_GetPEMEncoded_7 = (_typeNAME << 16) | 7;
        /*10046*/
        const int CefX509Certificate_GetIssuerChainSize_8 = (_typeNAME << 16) | 8;
        /*10047*/
        const int CefX509Certificate_GetDEREncodedIssuerChain_9 = (_typeNAME << 16) | 9;
        /*10048*/
        const int CefX509Certificate_GetPEMEncodedIssuerChain_10 = (_typeNAME << 16) | 10;
        /*10049*/
        internal readonly IntPtr nativePtr;
        /*10050*/
        internal CefX509Certificate(IntPtr nativePtr)
        {
            /*10051*/
            this.nativePtr = nativePtr;
            /*10052*/
        }
        /*10053*/
        public void Release()
        {
            /*10054*/
            JsValue ret;
            /*10055*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_Release_0, out ret);
            /*10056*/
        }

        // gen! CefRefPtr<CefX509CertPrincipal> GetSubject()
        /// <summary>
        /// CefX509Certificate methods.
        /// </summary>
        /*10057*/

        public CefX509CertPrincipal GetSubject()/*10058*/
        {
            JsValue ret;
            /*10059*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetSubject_1, out ret);
            /*10060*/
            var ret_result = new CefX509CertPrincipal(ret.Ptr);
            /*10061*/
            return ret_result;
            /*10062*/
        }

        // gen! CefRefPtr<CefX509CertPrincipal> GetIssuer()
        /// <summary>
        /// Returns the issuer of the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*10063*/

        public CefX509CertPrincipal GetIssuer()/*10064*/
        {
            JsValue ret;
            /*10065*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetIssuer_2, out ret);
            /*10066*/
            var ret_result = new CefX509CertPrincipal(ret.Ptr);
            /*10067*/
            return ret_result;
            /*10068*/
        }

        // gen! CefRefPtr<CefBinaryValue> GetSerialNumber()
        /// <summary>
        /// Returns the DER encoded serial number for the X.509 certificate. The value
        /// possibly includes a leading 00 byte.
        /// /*cef()*/
        /// </summary>
        /*10069*/

        public CefBinaryValue GetSerialNumber()/*10070*/
        {
            JsValue ret;
            /*10071*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetSerialNumber_3, out ret);
            /*10072*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*10073*/
            return ret_result;
            /*10074*/
        }

        // gen! CefTime GetValidStart()
        /// <summary>
        /// Returns the date before which the X.509 certificate is invalid.
        /// CefTime.GetTimeT() will return 0 if no date was specified.
        /// /*cef()*/
        /// </summary>
        /*10075*/

        public CefTime GetValidStart()/*10076*/
        {
            JsValue ret;
            /*10077*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetValidStart_4, out ret);
            /*10078*/
            var ret_result = new CefTime(ret.Ptr);

            /*10079*/
            return ret_result;
            /*10080*/
        }

        // gen! CefTime GetValidExpiry()
        /// <summary>
        /// Returns the date after which the X.509 certificate is invalid.
        /// CefTime.GetTimeT() will return 0 if no date was specified.
        /// /*cef()*/
        /// </summary>
        /*10081*/

        public CefTime GetValidExpiry()/*10082*/
        {
            JsValue ret;
            /*10083*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetValidExpiry_5, out ret);
            /*10084*/
            var ret_result = new CefTime(ret.Ptr);

            /*10085*/
            return ret_result;
            /*10086*/
        }

        // gen! CefRefPtr<CefBinaryValue> GetDEREncoded()
        /// <summary>
        /// Returns the DER encoded data for the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*10087*/

        public CefBinaryValue GetDEREncoded()/*10088*/
        {
            JsValue ret;
            /*10089*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetDEREncoded_6, out ret);
            /*10090*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*10091*/
            return ret_result;
            /*10092*/
        }

        // gen! CefRefPtr<CefBinaryValue> GetPEMEncoded()
        /// <summary>
        /// Returns the PEM encoded data for the X.509 certificate.
        /// /*cef()*/
        /// </summary>
        /*10093*/

        public CefBinaryValue GetPEMEncoded()/*10094*/
        {
            JsValue ret;
            /*10095*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetPEMEncoded_7, out ret);
            /*10096*/
            var ret_result = new CefBinaryValue(ret.Ptr);
            /*10097*/
            return ret_result;
            /*10098*/
        }

        // gen! size_t GetIssuerChainSize()
        /// <summary>
        /// Returns the number of certificates in the issuer chain.
        /// If 0, the certificate is self-signed.
        /// /*cef()*/
        /// </summary>
        /*10099*/

        public uint GetIssuerChainSize()/*10100*/
        {
            JsValue ret;
            /*10101*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefX509Certificate_GetIssuerChainSize_8, out ret);
            /*10102*/
            var ret_result = (uint)ret.I32;
            /*10103*/
            return ret_result;
            /*10104*/
        }

        // gen! void GetDEREncodedIssuerChain(IssuerChainBinaryList& chain)
        /// <summary>
        /// Returns the DER encoded data for the certificate issuer chain.
        /// If we failed to encode a certificate in the chain it is still
        /// present in the array but is an empty string.
        /// /*cef(count_func=chain:GetIssuerChainSize)*/
        /// </summary>
        /*10105*/

        public void GetDEREncodedIssuerChain(IssuerChainBinaryList /*10106*/
        chain
        )/*10107*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = chain.nativePtr/*10108*/
            ;
            /*10109*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509Certificate_GetDEREncodedIssuerChain_9, out ret, ref v1);
            /*10110*/

            /*10111*/
        }

        // gen! void GetPEMEncodedIssuerChain(IssuerChainBinaryList& chain)
        /// <summary>
        /// Returns the PEM encoded data for the certificate issuer chain.
        /// If we failed to encode a certificate in the chain it is still
        /// present in the array but is an empty string.
        /// /*cef(count_func=chain:GetIssuerChainSize)*/
        /// </summary>
        /*10112*/

        public void GetPEMEncodedIssuerChain(IssuerChainBinaryList /*10113*/
        chain
        )/*10114*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = chain.nativePtr/*10115*/
            ;
            /*10116*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefX509Certificate_GetPEMEncodedIssuerChain_10, out ret, ref v1);
            /*10117*/

            /*10118*/
        }
        /*10119*/
    }


    // [virtual] class CefXmlReader
    /// <summary>
    /// Class that supports the reading of XML data via the libxml streaming API.
    /// The methods of this class should only be called on the thread that creates
    /// the object.
    /// /*(source=library)*/
    /// </summary>
    /*10273*/
    public struct CefXmlReader
    {
        /*10274*/
        const int _typeNAME = 54;
        /*10275*/
        const int CefXmlReader_Release_0 = (_typeNAME << 16) | 0;
        /*10276*/
        const int CefXmlReader_MoveToNextNode_1 = (_typeNAME << 16) | 1;
        /*10277*/
        const int CefXmlReader_Close_2 = (_typeNAME << 16) | 2;
        /*10278*/
        const int CefXmlReader_HasError_3 = (_typeNAME << 16) | 3;
        /*10279*/
        const int CefXmlReader_GetError_4 = (_typeNAME << 16) | 4;
        /*10280*/
        const int CefXmlReader_GetType_5 = (_typeNAME << 16) | 5;
        /*10281*/
        const int CefXmlReader_GetDepth_6 = (_typeNAME << 16) | 6;
        /*10282*/
        const int CefXmlReader_GetLocalName_7 = (_typeNAME << 16) | 7;
        /*10283*/
        const int CefXmlReader_GetPrefix_8 = (_typeNAME << 16) | 8;
        /*10284*/
        const int CefXmlReader_GetQualifiedName_9 = (_typeNAME << 16) | 9;
        /*10285*/
        const int CefXmlReader_GetNamespaceURI_10 = (_typeNAME << 16) | 10;
        /*10286*/
        const int CefXmlReader_GetBaseURI_11 = (_typeNAME << 16) | 11;
        /*10287*/
        const int CefXmlReader_GetXmlLang_12 = (_typeNAME << 16) | 12;
        /*10288*/
        const int CefXmlReader_IsEmptyElement_13 = (_typeNAME << 16) | 13;
        /*10289*/
        const int CefXmlReader_HasValue_14 = (_typeNAME << 16) | 14;
        /*10290*/
        const int CefXmlReader_GetValue_15 = (_typeNAME << 16) | 15;
        /*10291*/
        const int CefXmlReader_HasAttributes_16 = (_typeNAME << 16) | 16;
        /*10292*/
        const int CefXmlReader_GetAttributeCount_17 = (_typeNAME << 16) | 17;
        /*10293*/
        const int CefXmlReader_GetAttribute_18 = (_typeNAME << 16) | 18;
        /*10294*/
        const int CefXmlReader_GetAttribute_19 = (_typeNAME << 16) | 19;
        /*10295*/
        const int CefXmlReader_GetAttribute_20 = (_typeNAME << 16) | 20;
        /*10296*/
        const int CefXmlReader_GetInnerXml_21 = (_typeNAME << 16) | 21;
        /*10297*/
        const int CefXmlReader_GetOuterXml_22 = (_typeNAME << 16) | 22;
        /*10298*/
        const int CefXmlReader_GetLineNumber_23 = (_typeNAME << 16) | 23;
        /*10299*/
        const int CefXmlReader_MoveToAttribute_24 = (_typeNAME << 16) | 24;
        /*10300*/
        const int CefXmlReader_MoveToAttribute_25 = (_typeNAME << 16) | 25;
        /*10301*/
        const int CefXmlReader_MoveToAttribute_26 = (_typeNAME << 16) | 26;
        /*10302*/
        const int CefXmlReader_MoveToFirstAttribute_27 = (_typeNAME << 16) | 27;
        /*10303*/
        const int CefXmlReader_MoveToNextAttribute_28 = (_typeNAME << 16) | 28;
        /*10304*/
        const int CefXmlReader_MoveToCarryingElement_29 = (_typeNAME << 16) | 29;
        /*10305*/
        internal readonly IntPtr nativePtr;
        /*10306*/
        internal CefXmlReader(IntPtr nativePtr)
        {
            /*10307*/
            this.nativePtr = nativePtr;
            /*10308*/
        }
        /*10309*/
        public void Release()
        {
            /*10310*/
            JsValue ret;
            /*10311*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_Release_0, out ret);
            /*10312*/
        }

        // gen! bool MoveToNextNode()
        /// <summary>
        /// CefXmlReader methods.
        /// </summary>
        /*10313*/

        public bool MoveToNextNode()/*10314*/
        {
            JsValue ret;
            /*10315*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToNextNode_1, out ret);
            /*10316*/
            var ret_result = ret.I32 != 0;
            /*10317*/
            return ret_result;
            /*10318*/
        }

        // gen! bool Close()
        /// <summary>
        /// Close the document. This should be called directly to ensure that cleanup
        /// occurs on the correct thread.
        /// /*cef()*/
        /// </summary>
        /*10319*/

        public bool Close()/*10320*/
        {
            JsValue ret;
            /*10321*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_Close_2, out ret);
            /*10322*/
            var ret_result = ret.I32 != 0;
            /*10323*/
            return ret_result;
            /*10324*/
        }

        // gen! bool HasError()
        /// <summary>
        /// Returns true if an error has been reported by the XML parser.
        /// /*cef()*/
        /// </summary>
        /*10325*/

        public bool HasError()/*10326*/
        {
            JsValue ret;
            /*10327*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasError_3, out ret);
            /*10328*/
            var ret_result = ret.I32 != 0;
            /*10329*/
            return ret_result;
            /*10330*/
        }

        // gen! CefString GetError()
        /// <summary>
        /// Returns the error string.
        /// /*cef()*/
        /// </summary>
        /*10331*/

        public string GetError()/*10332*/
        {
            JsValue ret;
            /*10333*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetError_4, out ret);
            /*10334*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10335*/
            return ret_result;
            /*10336*/
        }

        // gen! NodeType GetType()
        /// <summary>
        /// The below methods retrieve data for the node at the current cursor
        /// position.
        /// Returns the node type.
        /// /*cef(default_retval=XML_NODE_UNSUPPORTED)*/
        /// </summary>
        /*10337*/

        public cef_xml_node_type_t _GetType()/*10338*/
        {
            JsValue ret;
            /*10339*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetType_5, out ret);
            /*10340*/
            var ret_result = (cef_xml_node_type_t)ret.I32;

            /*10341*/
            return ret_result;
            /*10342*/
        }

        // gen! int GetDepth()
        /// <summary>
        /// Returns the node depth. Depth starts at 0 for the root node.
        /// /*cef()*/
        /// </summary>
        /*10343*/

        public int GetDepth()/*10344*/
        {
            JsValue ret;
            /*10345*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetDepth_6, out ret);
            /*10346*/
            var ret_result = ret.I32;
            /*10347*/
            return ret_result;
            /*10348*/
        }

        // gen! CefString GetLocalName()
        /// <summary>
        /// Returns the local name. See
        /// http://www.w3.org/TR/REC-xml-names/#NT-LocalPart for additional details.
        /// /*cef()*/
        /// </summary>
        /*10349*/

        public string GetLocalName()/*10350*/
        {
            JsValue ret;
            /*10351*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetLocalName_7, out ret);
            /*10352*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10353*/
            return ret_result;
            /*10354*/
        }

        // gen! CefString GetPrefix()
        /// <summary>
        /// Returns the namespace prefix. See http://www.w3.org/TR/REC-xml-names/ for
        /// additional details.
        /// /*cef()*/
        /// </summary>
        /*10355*/

        public string GetPrefix()/*10356*/
        {
            JsValue ret;
            /*10357*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetPrefix_8, out ret);
            /*10358*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10359*/
            return ret_result;
            /*10360*/
        }

        // gen! CefString GetQualifiedName()
        /// <summary>
        /// Returns the qualified name, equal to (Prefix:)LocalName. See
        /// http://www.w3.org/TR/REC-xml-names/#ns-qualnames for additional details.
        /// /*cef()*/
        /// </summary>
        /*10361*/

        public string GetQualifiedName()/*10362*/
        {
            JsValue ret;
            /*10363*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetQualifiedName_9, out ret);
            /*10364*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10365*/
            return ret_result;
            /*10366*/
        }

        // gen! CefString GetNamespaceURI()
        /// <summary>
        /// Returns the URI defining the namespace associated with the node. See
        /// http://www.w3.org/TR/REC-xml-names/ for additional details.
        /// /*cef()*/
        /// </summary>
        /*10367*/

        public string GetNamespaceURI()/*10368*/
        {
            JsValue ret;
            /*10369*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetNamespaceURI_10, out ret);
            /*10370*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10371*/
            return ret_result;
            /*10372*/
        }

        // gen! CefString GetBaseURI()
        /// <summary>
        /// Returns the base URI of the node. See http://www.w3.org/TR/xmlbase/ for
        /// additional details.
        /// /*cef()*/
        /// </summary>
        /*10373*/

        public string GetBaseURI()/*10374*/
        {
            JsValue ret;
            /*10375*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetBaseURI_11, out ret);
            /*10376*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10377*/
            return ret_result;
            /*10378*/
        }

        // gen! CefString GetXmlLang()
        /// <summary>
        /// Returns the xml:lang scope within which the node resides. See
        /// http://www.w3.org/TR/REC-xml/#sec-lang-tag for additional details.
        /// /*cef()*/
        /// </summary>
        /*10379*/

        public string GetXmlLang()/*10380*/
        {
            JsValue ret;
            /*10381*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetXmlLang_12, out ret);
            /*10382*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10383*/
            return ret_result;
            /*10384*/
        }

        // gen! bool IsEmptyElement()
        /// <summary>
        /// Returns true if the node represents an empty element. <a/> is considered
        /// empty but <a></a> is not.
        /// /*cef()*/
        /// </summary>
        /*10385*/

        public bool IsEmptyElement()/*10386*/
        {
            JsValue ret;
            /*10387*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_IsEmptyElement_13, out ret);
            /*10388*/
            var ret_result = ret.I32 != 0;
            /*10389*/
            return ret_result;
            /*10390*/
        }

        // gen! bool HasValue()
        /// <summary>
        /// Returns true if the node has a text value.
        /// /*cef()*/
        /// </summary>
        /*10391*/

        public bool HasValue()/*10392*/
        {
            JsValue ret;
            /*10393*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasValue_14, out ret);
            /*10394*/
            var ret_result = ret.I32 != 0;
            /*10395*/
            return ret_result;
            /*10396*/
        }

        // gen! CefString GetValue()
        /// <summary>
        /// Returns the text value.
        /// /*cef()*/
        /// </summary>
        /*10397*/

        public string GetValue()/*10398*/
        {
            JsValue ret;
            /*10399*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetValue_15, out ret);
            /*10400*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10401*/
            return ret_result;
            /*10402*/
        }

        // gen! bool HasAttributes()
        /// <summary>
        /// Returns true if the node has attributes.
        /// /*cef()*/
        /// </summary>
        /*10403*/

        public bool HasAttributes()/*10404*/
        {
            JsValue ret;
            /*10405*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_HasAttributes_16, out ret);
            /*10406*/
            var ret_result = ret.I32 != 0;
            /*10407*/
            return ret_result;
            /*10408*/
        }

        // gen! size_t GetAttributeCount()
        /// <summary>
        /// Returns the number of attributes.
        /// /*cef()*/
        /// </summary>
        /*10409*/

        public uint GetAttributeCount()/*10410*/
        {
            JsValue ret;
            /*10411*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetAttributeCount_17, out ret);
            /*10412*/
            var ret_result = (uint)ret.I32;
            /*10413*/
            return ret_result;
            /*10414*/
        }

        // gen! CefString GetAttribute(int index)
        /*10415*/

        public string GetAttribute(int /*10416*/
        index
        )/*10417*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*10418*/
            ;
            /*10419*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_GetAttribute_18, out ret, ref v1);
            /*10420*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10421*/
            return ret_result;
            /*10422*/
        }

        // gen! CefString GetAttribute(const CefString& qualifiedName)
        /*10423*/

        public string GetAttribute(string /*10424*/
        qualifiedName
        )/*10425*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(qualifiedName);
            /*10426*/
            ;
            /*10427*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_GetAttribute_19, out ret, ref v1);
            /*10428*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10429*/
            ;
            /*10430*/
            return ret_result;
            /*10431*/
        }

        // gen! CefString GetAttribute(const CefString& localName,const CefString& namespaceURI)
        /*10432*/

        public string GetAttribute(string /*10433*/
        localName
        , string /*10434*/
        namespaceURI
        )/*10435*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(localName);
            /*10436*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(namespaceURI);
            /*10437*/
            ;
            /*10438*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefXmlReader_GetAttribute_20, out ret, ref v1, ref v2);
            /*10439*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10440*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*10441*/
            ;
            /*10442*/
            return ret_result;
            /*10443*/
        }

        // gen! CefString GetInnerXml()
        /// <summary>
        /// Returns an XML representation of the current node's children.
        /// /*cef()*/
        /// </summary>
        /*10444*/

        public string GetInnerXml()/*10445*/
        {
            JsValue ret;
            /*10446*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetInnerXml_21, out ret);
            /*10447*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10448*/
            return ret_result;
            /*10449*/
        }

        // gen! CefString GetOuterXml()
        /// <summary>
        /// Returns an XML representation of the current node including its children.
        /// /*cef()*/
        /// </summary>
        /*10450*/

        public string GetOuterXml()/*10451*/
        {
            JsValue ret;
            /*10452*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetOuterXml_22, out ret);
            /*10453*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10454*/
            return ret_result;
            /*10455*/
        }

        // gen! int GetLineNumber()
        /// <summary>
        /// Returns the line number for the current node.
        /// /*cef()*/
        /// </summary>
        /*10456*/

        public int GetLineNumber()/*10457*/
        {
            JsValue ret;
            /*10458*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_GetLineNumber_23, out ret);
            /*10459*/
            var ret_result = ret.I32;
            /*10460*/
            return ret_result;
            /*10461*/
        }

        // gen! bool MoveToAttribute(int index)
        /*10462*/

        public bool MoveToAttribute(int /*10463*/
        index
        )/*10464*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.I32 = (int)index/*10465*/
            ;
            /*10466*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_MoveToAttribute_24, out ret, ref v1);
            /*10467*/
            var ret_result = ret.I32 != 0;
            /*10468*/
            return ret_result;
            /*10469*/
        }

        // gen! bool MoveToAttribute(const CefString& qualifiedName)
        /*10470*/

        public bool MoveToAttribute(string /*10471*/
        qualifiedName
        )/*10472*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(qualifiedName);
            /*10473*/
            ;
            /*10474*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefXmlReader_MoveToAttribute_25, out ret, ref v1);
            /*10475*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10476*/
            ;
            /*10477*/
            return ret_result;
            /*10478*/
        }

        // gen! bool MoveToAttribute(const CefString& localName,const CefString& namespaceURI)
        /*10479*/

        public bool MoveToAttribute(string /*10480*/
        localName
        , string /*10481*/
        namespaceURI
        )/*10482*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(localName);
            /*10483*/
            ;
            v2.Ptr = Cef3Binder.MyCefCreateCefString(namespaceURI);
            /*10484*/
            ;
            /*10485*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefXmlReader_MoveToAttribute_26, out ret, ref v1, ref v2);
            /*10486*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10487*/
            ;
            Cef3Binder.MyCefDeletePtr(v2.Ptr);/*10488*/
            ;
            /*10489*/
            return ret_result;
            /*10490*/
        }

        // gen! bool MoveToFirstAttribute()
        /// <summary>
        /// Moves the cursor to the first attribute in the current element. Returns
        /// true if the cursor position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10491*/

        public bool MoveToFirstAttribute()/*10492*/
        {
            JsValue ret;
            /*10493*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToFirstAttribute_27, out ret);
            /*10494*/
            var ret_result = ret.I32 != 0;
            /*10495*/
            return ret_result;
            /*10496*/
        }

        // gen! bool MoveToNextAttribute()
        /// <summary>
        /// Moves the cursor to the next attribute in the current element. Returns
        /// true if the cursor position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10497*/

        public bool MoveToNextAttribute()/*10498*/
        {
            JsValue ret;
            /*10499*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToNextAttribute_28, out ret);
            /*10500*/
            var ret_result = ret.I32 != 0;
            /*10501*/
            return ret_result;
            /*10502*/
        }

        // gen! bool MoveToCarryingElement()
        /// <summary>
        /// Moves the cursor back to the carrying element. Returns true if the cursor
        /// position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10503*/

        public bool MoveToCarryingElement()/*10504*/
        {
            JsValue ret;
            /*10505*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefXmlReader_MoveToCarryingElement_29, out ret);
            /*10506*/
            var ret_result = ret.I32 != 0;
            /*10507*/
            return ret_result;
            /*10508*/
        }
        /*10509*/
    }


    // [virtual] class CefZipReader
    /// <summary>
    /// Class that supports the reading of zip archives via the zlib unzip API.
    /// The methods of this class should only be called on the thread that creates
    /// the object.
    /// /*(source=library)*/
    /// </summary>
    /*10578*/
    public struct CefZipReader
    {
        /*10579*/
        const int _typeNAME = 55;
        /*10580*/
        const int CefZipReader_Release_0 = (_typeNAME << 16) | 0;
        /*10581*/
        const int CefZipReader_MoveToFirstFile_1 = (_typeNAME << 16) | 1;
        /*10582*/
        const int CefZipReader_MoveToNextFile_2 = (_typeNAME << 16) | 2;
        /*10583*/
        const int CefZipReader_MoveToFile_3 = (_typeNAME << 16) | 3;
        /*10584*/
        const int CefZipReader_Close_4 = (_typeNAME << 16) | 4;
        /*10585*/
        const int CefZipReader_GetFileName_5 = (_typeNAME << 16) | 5;
        /*10586*/
        const int CefZipReader_GetFileSize_6 = (_typeNAME << 16) | 6;
        /*10587*/
        const int CefZipReader_GetFileLastModified_7 = (_typeNAME << 16) | 7;
        /*10588*/
        const int CefZipReader_OpenFile_8 = (_typeNAME << 16) | 8;
        /*10589*/
        const int CefZipReader_CloseFile_9 = (_typeNAME << 16) | 9;
        /*10590*/
        const int CefZipReader_ReadFile_10 = (_typeNAME << 16) | 10;
        /*10591*/
        const int CefZipReader_Tell_11 = (_typeNAME << 16) | 11;
        /*10592*/
        const int CefZipReader_Eof_12 = (_typeNAME << 16) | 12;
        /*10593*/
        internal readonly IntPtr nativePtr;
        /*10594*/
        internal CefZipReader(IntPtr nativePtr)
        {
            /*10595*/
            this.nativePtr = nativePtr;
            /*10596*/
        }
        /*10597*/
        public void Release()
        {
            /*10598*/
            JsValue ret;
            /*10599*/
            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Release_0, out ret);
            /*10600*/
        }

        // gen! bool MoveToFirstFile()
        /// <summary>
        /// CefZipReader methods.
        /// </summary>
        /*10601*/

        public bool MoveToFirstFile()/*10602*/
        {
            JsValue ret;
            /*10603*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_MoveToFirstFile_1, out ret);
            /*10604*/
            var ret_result = ret.I32 != 0;
            /*10605*/
            return ret_result;
            /*10606*/
        }

        // gen! bool MoveToNextFile()
        /// <summary>
        /// Moves the cursor to the next file in the archive. Returns true if the
        /// cursor position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10607*/

        public bool MoveToNextFile()/*10608*/
        {
            JsValue ret;
            /*10609*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_MoveToNextFile_2, out ret);
            /*10610*/
            var ret_result = ret.I32 != 0;
            /*10611*/
            return ret_result;
            /*10612*/
        }

        // gen! bool MoveToFile(const CefString& fileName,bool caseSensitive)
        /// <summary>
        /// Moves the cursor to the specified file in the archive. If |caseSensitive|
        /// is true then the search will be case sensitive. Returns true if the cursor
        /// position was set successfully.
        /// /*cef()*/
        /// </summary>
        /*10613*/

        public bool MoveToFile(string /*10614*/
        fileName
        , bool /*10615*/
        caseSensitive
        )/*10616*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(fileName);
            /*10617*/
            ;
            v2.I32 = caseSensitive ? 1 : 0/*10618*/
            ;
            /*10619*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefZipReader_MoveToFile_3, out ret, ref v1, ref v2);
            /*10620*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10621*/
            ;
            /*10622*/
            return ret_result;
            /*10623*/
        }

        // gen! bool Close()
        /// <summary>
        /// Closes the archive. This should be called directly to ensure that cleanup
        /// occurs on the correct thread.
        /// /*cef()*/
        /// </summary>
        /*10624*/

        public bool Close()/*10625*/
        {
            JsValue ret;
            /*10626*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Close_4, out ret);
            /*10627*/
            var ret_result = ret.I32 != 0;
            /*10628*/
            return ret_result;
            /*10629*/
        }

        // gen! CefString GetFileName()
        /// <summary>
        /// The below methods act on the file at the current cursor position.
        /// Returns the name of the file.
        /// /*cef()*/
        /// </summary>
        /*10630*/

        public string GetFileName()/*10631*/
        {
            JsValue ret;
            /*10632*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileName_5, out ret);
            /*10633*/
            var ret_result = Cef3Binder.CopyStringAndDestroyNativeSide(ref ret);
            /*10634*/
            return ret_result;
            /*10635*/
        }

        // gen! int64 GetFileSize()
        /// <summary>
        /// Returns the uncompressed size of the file.
        /// /*cef()*/
        /// </summary>
        /*10636*/

        public long GetFileSize()/*10637*/
        {
            JsValue ret;
            /*10638*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileSize_6, out ret);
            /*10639*/
            var ret_result = ret.I64;
            /*10640*/
            return ret_result;
            /*10641*/
        }

        // gen! CefTime GetFileLastModified()
        /// <summary>
        /// Returns the last modified timestamp for the file.
        /// /*cef()*/
        /// </summary>
        /*10642*/

        public CefTime GetFileLastModified()/*10643*/
        {
            JsValue ret;
            /*10644*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_GetFileLastModified_7, out ret);
            /*10645*/
            var ret_result = new CefTime(ret.Ptr);

            /*10646*/
            return ret_result;
            /*10647*/
        }

        // gen! bool OpenFile(const CefString& password)
        /// <summary>
        /// Opens the file for reading of uncompressed data. A read password may
        /// optionally be specified.
        /// /*cef(optional_param=password)*/
        /// </summary>
        /*10648*/

        public bool OpenFile(string /*10649*/
        password
        )/*10650*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            v1.Ptr = Cef3Binder.MyCefCreateCefString(password);
            /*10651*/
            ;
            /*10652*/

            Cef3Binder.MyCefMet_Call1(this.nativePtr, CefZipReader_OpenFile_8, out ret, ref v1);
            /*10653*/
            var ret_result = ret.I32 != 0;
            Cef3Binder.MyCefDeletePtr(v1.Ptr);/*10654*/
            ;
            /*10655*/
            return ret_result;
            /*10656*/
        }

        // gen! bool CloseFile()
        /// <summary>
        /// Closes the file.
        /// /*cef()*/
        /// </summary>
        /*10657*/

        public bool CloseFile()/*10658*/
        {
            JsValue ret;
            /*10659*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_CloseFile_9, out ret);
            /*10660*/
            var ret_result = ret.I32 != 0;
            /*10661*/
            return ret_result;
            /*10662*/
        }

        // gen! int ReadFile(void* buffer,size_t bufferSize)
        /// <summary>
        /// Read uncompressed file contents into the specified buffer. Returns < 0 if
        /// an error occurred, 0 if at the end of file, or the number of bytes read.
        /// /*cef()*/
        /// </summary>
        /*10663*/

        public int ReadFile(IntPtr /*10664*/
        buffer
        , uint /*10665*/
        bufferSize
        )/*10666*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            v1.Ptr = buffer/*10667*/
            ;
            v2.I32 = (int)bufferSize/*10668*/
            ;
            /*10669*/

            Cef3Binder.MyCefMet_Call2(this.nativePtr, CefZipReader_ReadFile_10, out ret, ref v1, ref v2);
            /*10670*/
            var ret_result = ret.I32;
            /*10671*/
            return ret_result;
            /*10672*/
        }

        // gen! int64 Tell()
        /// <summary>
        /// Returns the current offset in the uncompressed file contents.
        /// /*cef()*/
        /// </summary>
        /*10673*/

        public long Tell()/*10674*/
        {
            JsValue ret;
            /*10675*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Tell_11, out ret);
            /*10676*/
            var ret_result = ret.I64;
            /*10677*/
            return ret_result;
            /*10678*/
        }

        // gen! bool Eof()
        /// <summary>
        /// Returns true if at end of the file contents.
        /// /*cef()*/
        /// </summary>
        /*10679*/

        public bool Eof()/*10680*/
        {
            JsValue ret;
            /*10681*/

            Cef3Binder.MyCefMet_Call0(this.nativePtr, CefZipReader_Eof_12, out ret);
            /*10682*/
            var ret_result = ret.I32 != 0;
            /*10683*/
            return ret_result;
            /*10684*/
        }
        /*10685*/
    }

}
