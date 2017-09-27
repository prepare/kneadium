//MIT, 2017, WinterDev
//AUTOGEN CONTENT
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge.Auto
{

    //CefCStructTx::GenerateCsCode, 1
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_settings_t
    {
        //CefCStructTx::GenerateCsCode-Field, 2
        /// <summary>
        /// Size of this structure.
        /// </summary>
        public int size;
        //CefCStructTx::GenerateCsCode-Field, 3
        /// <summary>
        /// Set to true (1) to use a single process for the browser and renderer. This
        /// run mode is not officially supported by Chromium and is less stable than
        /// the multi-process default. Also configurable using the "single-process"
        /// command-line switch.
        /// </summary>
        public int single_process;
        //CefCStructTx::GenerateCsCode-Field, 4
        /// <summary>
        /// Set to true (1) to disable the sandbox for sub-processes. See
        /// cef_sandbox_win.h for requirements to enable the sandbox on Windows. Also
        /// configurable using the "no-sandbox" command-line switch.
        /// </summary>
        public int no_sandbox;
        //CefCStructTx::GenerateCsCode-Field, 5
        /// <summary>
        /// The path to a separate executable that will be launched for sub-processes.
        /// If this value is empty on Windows or Linux then the main process executable
        /// will be used. If this value is empty on macOS then a helper executable must
        /// exist at "Contents/Frameworks/<app> Helper.app/Contents/MacOS/<app> Helper"
        /// in the top-level app bundle. See the comments on CefExecuteProcess() for
        /// details. Also configurable using the "browser-subprocess-path" command-line
        /// switch.
        /// </summary>
        public _cef_string_utf16_t browser_subprocess_path;
        //CefCStructTx::GenerateCsCode-Field, 6
        /// <summary>
        /// The path to the CEF framework directory on macOS. If this value is empty
        /// then the framework must exist at "Contents/Frameworks/Chromium Embedded
        /// Framework.framework" in the top-level app bundle. Also configurable using
        /// the "framework-dir-path" command-line switch.
        /// </summary>
        public _cef_string_utf16_t framework_dir_path;
        //CefCStructTx::GenerateCsCode-Field, 7
        /// <summary>
        /// Set to true (1) to have the browser process message loop run in a separate
        /// thread. If false (0) than the CefDoMessageLoopWork() function must be
        /// called from your application message loop. This option is only supported on
        /// Windows.
        /// </summary>
        public int multi_threaded_message_loop;
        //CefCStructTx::GenerateCsCode-Field, 8
        /// <summary>
        /// Set to true (1) to control browser process main (UI) thread message pump
        /// scheduling via the CefBrowserProcessHandler::OnScheduleMessagePumpWork()
        /// callback. This option is recommended for use in combination with the
        /// CefDoMessageLoopWork() function in cases where the CEF message loop must be
        /// integrated into an existing application message loop (see additional
        /// comments and warnings on CefDoMessageLoopWork). Enabling this option is not
        /// recommended for most users; leave this option disabled and use either the
        /// CefRunMessageLoop() function or multi_threaded_message_loop if possible.
        /// </summary>
        public int external_message_pump;
        //CefCStructTx::GenerateCsCode-Field, 9
        /// <summary>
        /// Set to true (1) to enable windowless (off-screen) rendering support. Do not
        /// enable this value if the application does not use windowless rendering as
        /// it may reduce rendering performance on some systems.
        /// </summary>
        public int windowless_rendering_enabled;
        //CefCStructTx::GenerateCsCode-Field, 10
        /// <summary>
        /// Set to true (1) to disable configuration of browser process features using
        /// standard CEF and Chromium command-line arguments. Configuration can still
        /// be specified using CEF data structures or via the
        /// CefApp::OnBeforeCommandLineProcessing() method.
        /// </summary>
        public int command_line_args_disabled;
        //CefCStructTx::GenerateCsCode-Field, 11
        /// <summary>
        /// The location where cache data will be stored on disk. If empty then
        /// browsers will be created in "incognito mode" where in-memory caches are
        /// used for storage and no data is persisted to disk. HTML5 databases such as
        /// localStorage will only persist across sessions if a cache path is
        /// specified. Can be overridden for individual CefRequestContext instances via
        /// the CefRequestContextSettings.cache_path value.
        /// </summary>
        public _cef_string_utf16_t cache_path;
        //CefCStructTx::GenerateCsCode-Field, 12
        /// <summary>
        /// The location where user data such as spell checking dictionary files will
        /// be stored on disk. If empty then the default platform-specific user data
        /// directory will be used ("~/.cef_user_data" directory on Linux,
        /// "~/Library/Application Support/CEF/User Data" directory on Mac OS X,
        /// "Local Settings\Application Data\CEF\User Data" directory under the user
        /// profile directory on Windows).
        /// </summary>
        public _cef_string_utf16_t user_data_path;
        //CefCStructTx::GenerateCsCode-Field, 13
        /// <summary>
        /// To persist session cookies (cookies without an expiry date or validity
        /// interval) by default when using the global cookie manager set this value to
        /// true (1). Session cookies are generally intended to be transient and most
        /// Web browsers do not persist them. A |cache_path| value must also be
        /// specified to enable this feature. Also configurable using the
        /// "persist-session-cookies" command-line switch. Can be overridden for
        /// individual CefRequestContext instances via the
        /// CefRequestContextSettings.persist_session_cookies value.
        /// </summary>
        public int persist_session_cookies;
        //CefCStructTx::GenerateCsCode-Field, 14
        /// <summary>
        /// To persist user preferences as a JSON file in the cache path directory set
        /// this value to true (1). A |cache_path| value must also be specified
        /// to enable this feature. Also configurable using the
        /// "persist-user-preferences" command-line switch. Can be overridden for
        /// individual CefRequestContext instances via the
        /// CefRequestContextSettings.persist_user_preferences value.
        /// </summary>
        public int persist_user_preferences;
        //CefCStructTx::GenerateCsCode-Field, 15
        /// <summary>
        /// Value that will be returned as the User-Agent HTTP header. If empty the
        /// default User-Agent string will be used. Also configurable using the
        /// "user-agent" command-line switch.
        /// </summary>
        public _cef_string_utf16_t user_agent;
        //CefCStructTx::GenerateCsCode-Field, 16
        /// <summary>
        /// Value that will be inserted as the product portion of the default
        /// User-Agent string. If empty the Chromium product version will be used. If
        /// |userAgent| is specified this value will be ignored. Also configurable
        /// using the "product-version" command-line switch.
        /// </summary>
        public _cef_string_utf16_t product_version;
        //CefCStructTx::GenerateCsCode-Field, 17
        /// <summary>
        /// The locale string that will be passed to WebKit. If empty the default
        /// locale of "en-US" will be used. This value is ignored on Linux where locale
        /// is determined using environment variable parsing with the precedence order:
        /// LANGUAGE, LC_ALL, LC_MESSAGES and LANG. Also configurable using the "lang"
        /// command-line switch.
        /// </summary>
        public _cef_string_utf16_t locale;
        //CefCStructTx::GenerateCsCode-Field, 18
        /// <summary>
        /// The directory and file name to use for the debug log. If empty a default
        /// log file name and location will be used. On Windows and Linux a "debug.log"
        /// file will be written in the main executable directory. On Mac OS X a
        /// "~/Library/Logs/<app name>_debug.log" file will be written where <app name>
        /// is the name of the main app executable. Also configurable using the
        /// "log-file" command-line switch.
        /// </summary>
        public _cef_string_utf16_t log_file;
        //CefCStructTx::GenerateCsCode-Field, 19
        /// <summary>
        /// The log severity. Only messages of this severity level or higher will be
        /// logged. Also configurable using the "log-severity" command-line switch with
        /// a value of "verbose", "info", "warning", "error", "error-report" or
        /// "disable".
        /// </summary>
        public cef_log_severity_t log_severity;
        //CefCStructTx::GenerateCsCode-Field, 20
        /// <summary>
        /// Custom flags that will be used when initializing the V8 JavaScript engine.
        /// The consequences of using custom flags may not be well tested. Also
        /// configurable using the "js-flags" command-line switch.
        /// </summary>
        public _cef_string_utf16_t javascript_flags;
        //CefCStructTx::GenerateCsCode-Field, 21
        /// <summary>
        /// The fully qualified path for the resources directory. If this value is
        /// empty the cef.pak and/or devtools_resources.pak files must be located in
        /// the module directory on Windows/Linux or the app bundle Resources directory
        /// on Mac OS X. Also configurable using the "resources-dir-path" command-line
        /// switch.
        /// </summary>
        public _cef_string_utf16_t resources_dir_path;
        //CefCStructTx::GenerateCsCode-Field, 22
        /// <summary>
        /// The fully qualified path for the locales directory. If this value is empty
        /// the locales directory must be located in the module directory. This value
        /// is ignored on Mac OS X where pack files are always loaded from the app
        /// bundle Resources directory. Also configurable using the "locales-dir-path"
        /// command-line switch.
        /// </summary>
        public _cef_string_utf16_t locales_dir_path;
        //CefCStructTx::GenerateCsCode-Field, 23
        /// <summary>
        /// Set to true (1) to disable loading of pack files for resources and locales.
        /// A resource bundle handler must be provided for the browser and render
        /// processes via CefApp::GetResourceBundleHandler() if loading of pack files
        /// is disabled. Also configurable using the "disable-pack-loading" command-
        /// line switch.
        /// </summary>
        public int pack_loading_disabled;
        //CefCStructTx::GenerateCsCode-Field, 24
        /// <summary>
        /// Set to a value between 1024 and 65535 to enable remote debugging on the
        /// specified port. For example, if 8080 is specified the remote debugging URL
        /// will be http://localhost:8080. CEF can be remotely debugged from any CEF or
        /// Chrome browser window. Also configurable using the "remote-debugging-port"
        /// command-line switch.
        /// </summary>
        public int remote_debugging_port;
        //CefCStructTx::GenerateCsCode-Field, 25
        /// <summary>
        /// The number of stack trace frames to capture for uncaught exceptions.
        /// Specify a positive value to enable the CefRenderProcessHandler::
        /// OnUncaughtException() callback. Specify 0 (default value) and
        /// OnUncaughtException() will not be called. Also configurable using the
        /// "uncaught-exception-stack-size" command-line switch.
        /// </summary>
        public int uncaught_exception_stack_size;
        //CefCStructTx::GenerateCsCode-Field, 26
        /// <summary>
        /// Set to true (1) to ignore errors related to invalid SSL certificates.
        /// Enabling this setting can lead to potential security vulnerabilities like
        /// "man in the middle" attacks. Applications that load content from the
        /// internet should not enable this setting. Also configurable using the
        /// "ignore-certificate-errors" command-line switch. Can be overridden for
        /// individual CefRequestContext instances via the
        /// CefRequestContextSettings.ignore_certificate_errors value.
        /// </summary>
        public int ignore_certificate_errors;
        //CefCStructTx::GenerateCsCode-Field, 27
        /// <summary>
        /// Set to true (1) to enable date-based expiration of built in network
        /// security information (i.e. certificate transparency logs, HSTS preloading
        /// and pinning information). Enabling this option improves network security
        /// but may cause HTTPS load failures when using CEF binaries built more than
        /// 10 weeks in the past. See https://www.certificate-transparency.org/ and
        /// https://www.chromium.org/hsts for details. Also configurable using the
        /// "enable-net-security-expiration" command-line switch. Can be overridden for
        /// individual CefRequestContext instances via the
        /// CefRequestContextSettings.enable_net_security_expiration value.
        /// </summary>
        public int enable_net_security_expiration;
        //CefCStructTx::GenerateCsCode-Field, 28
        /// <summary>
        /// Background color used for the browser before a document is loaded and when
        /// no document color is specified. The alpha component must be either fully
        /// opaque (0xFF) or fully transparent (0x00). If the alpha component is fully
        /// opaque then the RGB components will be used as the background color. If the
        /// alpha component is fully transparent for a windowed browser then the
        /// default value of opaque white be used. If the alpha component is fully
        /// transparent for a windowless (off-screen) browser then transparent painting
        /// will be enabled.
        /// </summary>
        public cef_color_t background_color;
        //CefCStructTx::GenerateCsCode-Field, 29
        /// <summary>
        /// Comma delimited ordered list of language codes without any whitespace that
        /// will be used in the "Accept-Language" HTTP header. May be overridden on a
        /// per-browser basis using the CefBrowserSettings.accept_language_list value.
        /// If both values are empty then "en-US,en" will be used. Can be overridden
        /// for individual CefRequestContext instances via the
        /// CefRequestContextSettings.accept_language_list value.
        /// </summary>
        public _cef_string_utf16_t accept_language_list;
    }
    //CefCStructTx::GenerateCsCode, 30
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_request_context_settings_t
    {
        //CefCStructTx::GenerateCsCode-Field, 31
        /// <summary>
        /// Size of this structure.
        /// </summary>
        public int size;
        //CefCStructTx::GenerateCsCode-Field, 32
        /// <summary>
        /// The location where cache data will be stored on disk. If empty then
        /// browsers will be created in "incognito mode" where in-memory caches are
        /// used for storage and no data is persisted to disk. HTML5 databases such as
        /// localStorage will only persist across sessions if a cache path is
        /// specified. To share the global browser cache and related configuration set
        /// this value to match the CefSettings.cache_path value.
        /// </summary>
        public _cef_string_utf16_t cache_path;
        //CefCStructTx::GenerateCsCode-Field, 33
        /// <summary>
        /// To persist session cookies (cookies without an expiry date or validity
        /// interval) by default when using the global cookie manager set this value to
        /// true (1). Session cookies are generally intended to be transient and most
        /// Web browsers do not persist them. Can be set globally using the
        /// CefSettings.persist_session_cookies value. This value will be ignored if
        /// |cache_path| is empty or if it matches the CefSettings.cache_path value.
        /// </summary>
        public int persist_session_cookies;
        //CefCStructTx::GenerateCsCode-Field, 34
        /// <summary>
        /// To persist user preferences as a JSON file in the cache path directory set
        /// this value to true (1). Can be set globally using the
        /// CefSettings.persist_user_preferences value. This value will be ignored if
        /// |cache_path| is empty or if it matches the CefSettings.cache_path value.
        /// </summary>
        public int persist_user_preferences;
        //CefCStructTx::GenerateCsCode-Field, 35
        /// <summary>
        /// Set to true (1) to ignore errors related to invalid SSL certificates.
        /// Enabling this setting can lead to potential security vulnerabilities like
        /// "man in the middle" attacks. Applications that load content from the
        /// internet should not enable this setting. Can be set globally using the
        /// CefSettings.ignore_certificate_errors value. This value will be ignored if
        /// |cache_path| matches the CefSettings.cache_path value.
        /// </summary>
        public int ignore_certificate_errors;
        //CefCStructTx::GenerateCsCode-Field, 36
        /// <summary>
        /// Set to true (1) to enable date-based expiration of built in network
        /// security information (i.e. certificate transparency logs, HSTS preloading
        /// and pinning information). Enabling this option improves network security
        /// but may cause HTTPS load failures when using CEF binaries built more than
        /// 10 weeks in the past. See https://www.certificate-transparency.org/ and
        /// https://www.chromium.org/hsts for details. Can be set globally using the
        /// CefSettings.enable_net_security_expiration value.
        /// </summary>
        public int enable_net_security_expiration;
        //CefCStructTx::GenerateCsCode-Field, 37
        /// <summary>
        /// Comma delimited ordered list of language codes without any whitespace that
        /// will be used in the "Accept-Language" HTTP header. Can be set globally
        /// using the CefSettings.accept_language_list value or overridden on a per-
        /// browser basis using the CefBrowserSettings.accept_language_list value. If
        /// all values are empty then "en-US,en" will be used. This value will be
        /// ignored if |cache_path| matches the CefSettings.cache_path value.
        /// </summary>
        public _cef_string_utf16_t accept_language_list;
    }
    //CefCStructTx::GenerateCsCode, 38
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_browser_settings_t
    {
        //CefCStructTx::GenerateCsCode-Field, 39
        /// <summary>
        /// Size of this structure.
        /// </summary>
        public int size;
        //CefCStructTx::GenerateCsCode-Field, 40
        /// <summary>
        /// The maximum rate in frames per second (fps) that CefRenderHandler::OnPaint
        /// will be called for a windowless browser. The actual fps may be lower if
        /// the browser cannot generate frames at the requested rate. The minimum
        /// value is 1 and the maximum value is 60 (default 30). This value can also be
        /// changed dynamically via CefBrowserHost::SetWindowlessFrameRate.
        /// </summary>
        public int windowless_frame_rate;
        //CefCStructTx::GenerateCsCode-Field, 41
        /// <summary>
        /// The below values map to WebPreferences settings.
        /// Font settings.
        /// </summary>
        public _cef_string_utf16_t standard_font_family;
        //CefCStructTx::GenerateCsCode-Field, 42
        public _cef_string_utf16_t fixed_font_family;
        //CefCStructTx::GenerateCsCode-Field, 43
        public _cef_string_utf16_t serif_font_family;
        //CefCStructTx::GenerateCsCode-Field, 44
        public _cef_string_utf16_t sans_serif_font_family;
        //CefCStructTx::GenerateCsCode-Field, 45
        public _cef_string_utf16_t cursive_font_family;
        //CefCStructTx::GenerateCsCode-Field, 46
        public _cef_string_utf16_t fantasy_font_family;
        //CefCStructTx::GenerateCsCode-Field, 47
        public int default_font_size;
        //CefCStructTx::GenerateCsCode-Field, 48
        public int default_fixed_font_size;
        //CefCStructTx::GenerateCsCode-Field, 49
        public int minimum_font_size;
        //CefCStructTx::GenerateCsCode-Field, 50
        public int minimum_logical_font_size;
        //CefCStructTx::GenerateCsCode-Field, 51
        /// <summary>
        /// Default encoding for Web content. If empty "ISO-8859-1" will be used. Also
        /// configurable using the "default-encoding" command-line switch.
        /// </summary>
        public _cef_string_utf16_t default_encoding;
        //CefCStructTx::GenerateCsCode-Field, 52
        /// <summary>
        /// Controls the loading of fonts from remote sources. Also configurable using
        /// the "disable-remote-fonts" command-line switch.
        /// </summary>
        public cef_state_t remote_fonts;
        //CefCStructTx::GenerateCsCode-Field, 53
        /// <summary>
        /// Controls whether JavaScript can be executed. Also configurable using the
        /// "disable-javascript" command-line switch.
        /// </summary>
        public cef_state_t javascript;
        //CefCStructTx::GenerateCsCode-Field, 54
        /// <summary>
        /// Controls whether JavaScript can be used for opening windows. Also
        /// configurable using the "disable-javascript-open-windows" command-line
        /// switch.
        /// </summary>
        public cef_state_t javascript_open_windows;
        //CefCStructTx::GenerateCsCode-Field, 55
        /// <summary>
        /// Controls whether JavaScript can be used to close windows that were not
        /// opened via JavaScript. JavaScript can still be used to close windows that
        /// were opened via JavaScript or that have no back/forward history. Also
        /// configurable using the "disable-javascript-close-windows" command-line
        /// switch.
        /// </summary>
        public cef_state_t javascript_close_windows;
        //CefCStructTx::GenerateCsCode-Field, 56
        /// <summary>
        /// Controls whether JavaScript can access the clipboard. Also configurable
        /// using the "disable-javascript-access-clipboard" command-line switch.
        /// </summary>
        public cef_state_t javascript_access_clipboard;
        //CefCStructTx::GenerateCsCode-Field, 57
        /// <summary>
        /// Controls whether DOM pasting is supported in the editor via
        /// execCommand("paste"). The |javascript_access_clipboard| setting must also
        /// be enabled. Also configurable using the "disable-javascript-dom-paste"
        /// command-line switch.
        /// </summary>
        public cef_state_t javascript_dom_paste;
        //CefCStructTx::GenerateCsCode-Field, 58
        /// <summary>
        /// Controls whether any plugins will be loaded. Also configurable using the
        /// "disable-plugins" command-line switch.
        /// </summary>
        public cef_state_t plugins;
        //CefCStructTx::GenerateCsCode-Field, 59
        /// <summary>
        /// Controls whether file URLs will have access to all URLs. Also configurable
        /// using the "allow-universal-access-from-files" command-line switch.
        /// </summary>
        public cef_state_t universal_access_from_file_urls;
        //CefCStructTx::GenerateCsCode-Field, 60
        /// <summary>
        /// Controls whether file URLs will have access to other file URLs. Also
        /// configurable using the "allow-access-from-files" command-line switch.
        /// </summary>
        public cef_state_t file_access_from_file_urls;
        //CefCStructTx::GenerateCsCode-Field, 61
        /// <summary>
        /// Controls whether web security restrictions (same-origin policy) will be
        /// enforced. Disabling this setting is not recommend as it will allow risky
        /// security behavior such as cross-site scripting (XSS). Also configurable
        /// using the "disable-web-security" command-line switch.
        /// </summary>
        public cef_state_t web_security;
        //CefCStructTx::GenerateCsCode-Field, 62
        /// <summary>
        /// Controls whether image URLs will be loaded from the network. A cached image
        /// will still be rendered if requested. Also configurable using the
        /// "disable-image-loading" command-line switch.
        /// </summary>
        public cef_state_t image_loading;
        //CefCStructTx::GenerateCsCode-Field, 63
        /// <summary>
        /// Controls whether standalone images will be shrunk to fit the page. Also
        /// configurable using the "image-shrink-standalone-to-fit" command-line
        /// switch.
        /// </summary>
        public cef_state_t image_shrink_standalone_to_fit;
        //CefCStructTx::GenerateCsCode-Field, 64
        /// <summary>
        /// Controls whether text areas can be resized. Also configurable using the
        /// "disable-text-area-resize" command-line switch.
        /// </summary>
        public cef_state_t text_area_resize;
        //CefCStructTx::GenerateCsCode-Field, 65
        /// <summary>
        /// Controls whether the tab key can advance focus to links. Also configurable
        /// using the "disable-tab-to-links" command-line switch.
        /// </summary>
        public cef_state_t tab_to_links;
        //CefCStructTx::GenerateCsCode-Field, 66
        /// <summary>
        /// Controls whether local storage can be used. Also configurable using the
        /// "disable-local-storage" command-line switch.
        /// </summary>
        public cef_state_t local_storage;
        //CefCStructTx::GenerateCsCode-Field, 67
        /// <summary>
        /// Controls whether databases can be used. Also configurable using the
        /// "disable-databases" command-line switch.
        /// </summary>
        public cef_state_t databases;
        //CefCStructTx::GenerateCsCode-Field, 68
        /// <summary>
        /// Controls whether the application cache can be used. Also configurable using
        /// the "disable-application-cache" command-line switch.
        /// </summary>
        public cef_state_t application_cache;
        //CefCStructTx::GenerateCsCode-Field, 69
        /// <summary>
        /// Controls whether WebGL can be used. Note that WebGL requires hardware
        /// support and may not work on all systems even when enabled. Also
        /// configurable using the "disable-webgl" command-line switch.
        /// </summary>
        public cef_state_t webgl;
        //CefCStructTx::GenerateCsCode-Field, 70
        /// <summary>
        /// Background color used for the browser before a document is loaded and when
        /// no document color is specified. The alpha component must be either fully
        /// opaque (0xFF) or fully transparent (0x00). If the alpha component is fully
        /// opaque then the RGB components will be used as the background color. If the
        /// alpha component is fully transparent for a windowed browser then the
        /// CefSettings.background_color value will be used. If the alpha component is
        /// fully transparent for a windowless (off-screen) browser then transparent
        /// painting will be enabled.
        /// </summary>
        public cef_color_t background_color;
        //CefCStructTx::GenerateCsCode-Field, 71
        /// <summary>
        /// Comma delimited ordered list of language codes without any whitespace that
        /// will be used in the "Accept-Language" HTTP header. May be set globally
        /// using the CefBrowserSettings.accept_language_list value. If both values are
        /// empty then "en-US,en" will be used.
        /// </summary>
        public _cef_string_utf16_t accept_language_list;
    }
    //CefCStructTx::GenerateCsCode, 72
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_urlparts_t
    {
        //CefCStructTx::GenerateCsCode-Field, 73
        /// <summary>
        /// The complete URL specification.
        /// </summary>
        public _cef_string_utf16_t spec;
        //CefCStructTx::GenerateCsCode-Field, 74
        /// <summary>
        /// Scheme component not including the colon (e.g., "http").
        /// </summary>
        public _cef_string_utf16_t scheme;
        //CefCStructTx::GenerateCsCode-Field, 75
        /// <summary>
        /// User name component.
        /// </summary>
        public _cef_string_utf16_t username;
        //CefCStructTx::GenerateCsCode-Field, 76
        /// <summary>
        /// Password component.
        /// </summary>
        public _cef_string_utf16_t password;
        //CefCStructTx::GenerateCsCode-Field, 77
        /// <summary>
        /// Host component. This may be a hostname, an IPv4 address or an IPv6 literal
        /// surrounded by square brackets (e.g., "[2001:db8::1]").
        /// </summary>
        public _cef_string_utf16_t host;
        //CefCStructTx::GenerateCsCode-Field, 78
        /// <summary>
        /// Port number component.
        /// </summary>
        public _cef_string_utf16_t port;
        //CefCStructTx::GenerateCsCode-Field, 79
        /// <summary>
        /// Origin contains just the scheme, host, and port from a URL. Equivalent to
        /// clearing any username and password, replacing the path with a slash, and
        /// clearing everything after that. This value will be empty for non-standard
        /// URLs.
        /// </summary>
        public _cef_string_utf16_t origin;
        //CefCStructTx::GenerateCsCode-Field, 80
        /// <summary>
        /// Path component including the first slash following the host.
        /// </summary>
        public _cef_string_utf16_t path;
        //CefCStructTx::GenerateCsCode-Field, 81
        /// <summary>
        /// Query string component (i.e., everything following the '?').
        /// </summary>
        public _cef_string_utf16_t query;
    }
    //CefCStructTx::GenerateCsCode, 82
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_cookie_t
    {
        //CefCStructTx::GenerateCsCode-Field, 83
        /// <summary>
        /// The cookie name.
        /// </summary>
        public _cef_string_utf16_t name;
        //CefCStructTx::GenerateCsCode-Field, 84
        /// <summary>
        /// The cookie value.
        /// </summary>
        public _cef_string_utf16_t value;
        //CefCStructTx::GenerateCsCode-Field, 85
        /// <summary>
        /// If |domain| is empty a host cookie will be created instead of a domain
        /// cookie. Domain cookies are stored with a leading "." and are visible to
        /// sub-domains whereas host cookies are not.
        /// </summary>
        public _cef_string_utf16_t domain;
        //CefCStructTx::GenerateCsCode-Field, 86
        /// <summary>
        /// If |path| is non-empty only URLs at or below the path will get the cookie
        /// value.
        /// </summary>
        public _cef_string_utf16_t path;
        //CefCStructTx::GenerateCsCode-Field, 87
        /// <summary>
        /// If |secure| is true the cookie will only be sent for HTTPS requests.
        /// </summary>
        public int secure;
        //CefCStructTx::GenerateCsCode-Field, 88
        /// <summary>
        /// If |httponly| is true the cookie will only be sent for HTTP requests.
        /// </summary>
        public int httponly;
        //CefCStructTx::GenerateCsCode-Field, 89
        /// <summary>
        /// The cookie creation date. This is automatically populated by the system on
        /// cookie creation.
        /// </summary>
        public cef_time_t creation;
        //CefCStructTx::GenerateCsCode-Field, 90
        /// <summary>
        /// The cookie last access date. This is automatically populated by the system
        /// on access.
        /// </summary>
        public cef_time_t last_access;
        //CefCStructTx::GenerateCsCode-Field, 91
        /// <summary>
        /// The cookie expiration date is only valid if |has_expires| is true.
        /// </summary>
        public int has_expires;
        //CefCStructTx::GenerateCsCode-Field, 92
        public cef_time_t expires;
    }
    //CefCStructTx::GenerateCsCode, 93
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_point_t
    {
        //CefCStructTx::GenerateCsCode-Field, 94
        public int x;
        //CefCStructTx::GenerateCsCode-Field, 95
        public int y;
    }
    //CefCStructTx::GenerateCsCode, 96
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_rect_t
    {
        //CefCStructTx::GenerateCsCode-Field, 97
        public int x;
        //CefCStructTx::GenerateCsCode-Field, 98
        public int y;
        //CefCStructTx::GenerateCsCode-Field, 99
        public int width;
        //CefCStructTx::GenerateCsCode-Field, 100
        public int height;
    }
    //CefCStructTx::GenerateCsCode, 101
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_size_t
    {
        //CefCStructTx::GenerateCsCode-Field, 102
        public int width;
        //CefCStructTx::GenerateCsCode-Field, 103
        public int height;
    }
    //CefCStructTx::GenerateCsCode, 104
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_range_t
    {
        //CefCStructTx::GenerateCsCode-Field, 105
        public int from;
        //CefCStructTx::GenerateCsCode-Field, 106
        public int to;
    }
    //CefCStructTx::GenerateCsCode, 107
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_insets_t
    {
        //CefCStructTx::GenerateCsCode-Field, 108
        public int top;
        //CefCStructTx::GenerateCsCode-Field, 109
        public int left;
        //CefCStructTx::GenerateCsCode-Field, 110
        public int bottom;
        //CefCStructTx::GenerateCsCode-Field, 111
        public int right;
    }
    //CefCStructTx::GenerateCsCode, 112
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_draggable_region_t
    {
        //CefCStructTx::GenerateCsCode-Field, 113
        /// <summary>
        /// Bounds of the region.
        /// </summary>
        public cef_rect_t bounds;
        //CefCStructTx::GenerateCsCode-Field, 114
        /// <summary>
        /// True (1) this this region is draggable and false (0) otherwise.
        /// </summary>
        public int draggable;
    }
    //CefCStructTx::GenerateCsCode, 115
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_screen_info_t
    {
        //CefCStructTx::GenerateCsCode-Field, 116
        /// <summary>
        /// Device scale factor. Specifies the ratio between physical and logical
        /// pixels.
        /// </summary>
        public float device_scale_factor;
        //CefCStructTx::GenerateCsCode-Field, 117
        /// <summary>
        /// The screen depth in bits per pixel.
        /// </summary>
        public int depth;
        //CefCStructTx::GenerateCsCode-Field, 118
        /// <summary>
        /// The bits per color component. This assumes that the colors are balanced
        /// equally.
        /// </summary>
        public int depth_per_component;
        //CefCStructTx::GenerateCsCode-Field, 119
        /// <summary>
        /// This can be true for black and white printers.
        /// </summary>
        public int is_monochrome;
        //CefCStructTx::GenerateCsCode-Field, 120
        /// <summary>
        /// This is set from the rcMonitor member of MONITORINFOEX, to whit:
        ///   "A RECT structure that specifies the display monitor rectangle,
        ///   expressed in virtual-screen coordinates. Note that if the monitor
        ///   is not the primary display monitor, some of the rectangle's
        ///   coordinates may be negative values."
        ///
        /// The |rect| and |available_rect| properties are used to determine the
        /// available surface for rendering popup views.
        /// </summary>
        public cef_rect_t rect;
        //CefCStructTx::GenerateCsCode-Field, 121
        /// <summary>
        /// This is set from the rcWork member of MONITORINFOEX, to whit:
        ///   "A RECT structure that specifies the work area rectangle of the
        ///   display monitor that can be used by applications, expressed in
        ///   virtual-screen coordinates. Windows uses this rectangle to
        ///   maximize an application on the monitor. The rest of the area in
        ///   rcMonitor contains system windows such as the task bar and side
        ///   bars. Note that if the monitor is not the primary display monitor,
        ///   some of the rectangle's coordinates may be negative values".
        ///
        /// The |rect| and |available_rect| properties are used to determine the
        /// available surface for rendering popup views.
        /// </summary>
        public cef_rect_t available_rect;
    }
    //CefCStructTx::GenerateCsCode, 122
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_mouse_event_t
    {
        //CefCStructTx::GenerateCsCode-Field, 123
        /// <summary>
        /// X coordinate relative to the left side of the view.
        /// </summary>
        public int x;
        //CefCStructTx::GenerateCsCode-Field, 124
        /// <summary>
        /// Y coordinate relative to the top side of the view.
        /// </summary>
        public int y;
        //CefCStructTx::GenerateCsCode-Field, 125
        /// <summary>
        /// Bit flags describing any pressed modifier keys. See
        /// cef_event_flags_t for values.
        /// </summary>
        public uint modifiers;
    }
    //CefCStructTx::GenerateCsCode, 126
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_key_event_t
    {
        //CefCStructTx::GenerateCsCode-Field, 127
        /// <summary>
        /// The type of keyboard event.
        /// </summary>
        public cef_key_event_type_t type;
        //CefCStructTx::GenerateCsCode-Field, 128
        /// <summary>
        /// Bit flags describing any pressed modifier keys. See
        /// cef_event_flags_t for values.
        /// </summary>
        public uint modifiers;
        //CefCStructTx::GenerateCsCode-Field, 129
        /// <summary>
        /// The Windows key code for the key event. This value is used by the DOM
        /// specification. Sometimes it comes directly from the event (i.e. on
        /// Windows) and sometimes it's determined using a mapping function. See
        /// WebCore/platform/chromium/KeyboardCodes.h for the list of values.
        /// </summary>
        public int windows_key_code;
        //CefCStructTx::GenerateCsCode-Field, 130
        /// <summary>
        /// The actual key code genenerated by the platform.
        /// </summary>
        public int native_key_code;
        //CefCStructTx::GenerateCsCode-Field, 131
        /// <summary>
        /// Indicates whether the event is considered a "system key" event (see
        /// http://msdn.microsoft.com/en-us/library/ms646286(VS.85).aspx for details).
        /// This value will always be false on non-Windows platforms.
        /// </summary>
        public int is_system_key;
        //CefCStructTx::GenerateCsCode-Field, 132
        /// <summary>
        /// The character generated by the keystroke.
        /// </summary>
        public char character;
        //CefCStructTx::GenerateCsCode-Field, 133
        /// <summary>
        /// Same as |character| but unmodified by any concurrently-held modifiers
        /// (except shift). This is useful for working out shortcut keys.
        /// </summary>
        public char unmodified_character;
        //CefCStructTx::GenerateCsCode-Field, 134
        /// <summary>
        /// True if the focus is currently on an editable field on the page. This is
        /// useful for determining if standard key events should be intercepted.
        /// </summary>
        public int focus_on_editable_field;
    }
    //CefCStructTx::GenerateCsCode, 135
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_popup_features_t
    {
        //CefCStructTx::GenerateCsCode-Field, 136
        public int x;
        //CefCStructTx::GenerateCsCode-Field, 137
        public int xSet;
        //CefCStructTx::GenerateCsCode-Field, 138
        public int y;
        //CefCStructTx::GenerateCsCode-Field, 139
        public int ySet;
        //CefCStructTx::GenerateCsCode-Field, 140
        public int width;
        //CefCStructTx::GenerateCsCode-Field, 141
        public int widthSet;
        //CefCStructTx::GenerateCsCode-Field, 142
        public int height;
        //CefCStructTx::GenerateCsCode-Field, 143
        public int heightSet;
        //CefCStructTx::GenerateCsCode-Field, 144
        public int menuBarVisible;
        //CefCStructTx::GenerateCsCode-Field, 145
        public int statusBarVisible;
        //CefCStructTx::GenerateCsCode-Field, 146
        public int toolBarVisible;
        //CefCStructTx::GenerateCsCode-Field, 147
        public int locationBarVisible;
        //CefCStructTx::GenerateCsCode-Field, 148
        public int scrollbarsVisible;
        //CefCStructTx::GenerateCsCode-Field, 149
        public int resizable;
        //CefCStructTx::GenerateCsCode-Field, 150
        public int fullscreen;
        //CefCStructTx::GenerateCsCode-Field, 151
        public int dialog;
    }
    //CefCStructTx::GenerateCsCode, 152
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_geoposition_t
    {
        //CefCStructTx::GenerateCsCode-Field, 153
        /// <summary>
        /// Latitude in decimal degrees north (WGS84 coordinate frame).
        /// </summary>
        public double latitude;
        //CefCStructTx::GenerateCsCode-Field, 154
        /// <summary>
        /// Longitude in decimal degrees west (WGS84 coordinate frame).
        /// </summary>
        public double longitude;
        //CefCStructTx::GenerateCsCode-Field, 155
        /// <summary>
        /// Altitude in meters (above WGS84 datum).
        /// </summary>
        public double altitude;
        //CefCStructTx::GenerateCsCode-Field, 156
        /// <summary>
        /// Accuracy of horizontal position in meters.
        /// </summary>
        public double accuracy;
        //CefCStructTx::GenerateCsCode-Field, 157
        /// <summary>
        /// Accuracy of altitude in meters.
        /// </summary>
        public double altitude_accuracy;
        //CefCStructTx::GenerateCsCode-Field, 158
        /// <summary>
        /// Heading in decimal degrees clockwise from true north.
        /// </summary>
        public double heading;
        //CefCStructTx::GenerateCsCode-Field, 159
        /// <summary>
        /// Horizontal component of device velocity in meters per second.
        /// </summary>
        public double speed;
        //CefCStructTx::GenerateCsCode-Field, 160
        /// <summary>
        /// Time of position measurement in milliseconds since Epoch in UTC time. This
        /// is taken from the host computer's system clock.
        /// </summary>
        public cef_time_t timestamp;
        //CefCStructTx::GenerateCsCode-Field, 161
        /// <summary>
        /// Error code, see enum above.
        /// </summary>
        public cef_geoposition_error_code_t error_code;
        //CefCStructTx::GenerateCsCode-Field, 162
        /// <summary>
        /// Human-readable error message.
        /// </summary>
        public _cef_string_utf16_t error_message;
    }
    //CefCStructTx::GenerateCsCode, 163
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_cursor_info_t
    {
        //CefCStructTx::GenerateCsCode-Field, 164
        public cef_point_t hotspot;
        //CefCStructTx::GenerateCsCode-Field, 165
        public float image_scale_factor;
        //CefCStructTx::GenerateCsCode-Field, 166
        public IntPtr buffer;
        //CefCStructTx::GenerateCsCode-Field, 167
        public cef_size_t size;
    }
    //CefCStructTx::GenerateCsCode, 168
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_pdf_print_settings_t
    {
        //CefCStructTx::GenerateCsCode-Field, 169
        /// <summary>
        /// Page title to display in the header. Only used if |header_footer_enabled|
        /// is set to true (1).
        /// </summary>
        public _cef_string_utf16_t header_footer_title;
        //CefCStructTx::GenerateCsCode-Field, 170
        /// <summary>
        /// URL to display in the footer. Only used if |header_footer_enabled| is set
        /// to true (1).
        /// </summary>
        public _cef_string_utf16_t header_footer_url;
        //CefCStructTx::GenerateCsCode-Field, 171
        /// <summary>
        /// Output page size in microns. If either of these values is less than or
        /// equal to zero then the default paper size (A4) will be used.
        /// </summary>
        public int page_width;
        //CefCStructTx::GenerateCsCode-Field, 172
        public int page_height;
        //CefCStructTx::GenerateCsCode-Field, 173
        /// <summary>
        /// The percentage to scale the PDF by before printing (e.g. 50 is 50%).
        /// If this value is less than or equal to zero the default value of 100
        /// will be used.
        /// </summary>
        public int scale_factor;
        //CefCStructTx::GenerateCsCode-Field, 174
        /// <summary>
        /// Margins in millimeters. Only used if |margin_type| is set to
        /// PDF_PRINT_MARGIN_CUSTOM.
        /// </summary>
        public double margin_top;
        //CefCStructTx::GenerateCsCode-Field, 175
        public double margin_right;
        //CefCStructTx::GenerateCsCode-Field, 176
        public double margin_bottom;
        //CefCStructTx::GenerateCsCode-Field, 177
        public double margin_left;
        //CefCStructTx::GenerateCsCode-Field, 178
        /// <summary>
        /// Margin type.
        /// </summary>
        public cef_pdf_print_margin_type_t margin_type;
        //CefCStructTx::GenerateCsCode-Field, 179
        /// <summary>
        /// Set to true (1) to print headers and footers or false (0) to not print
        /// headers and footers.
        /// </summary>
        public int header_footer_enabled;
        //CefCStructTx::GenerateCsCode-Field, 180
        /// <summary>
        /// Set to true (1) to print the selection only or false (0) to print all.
        /// </summary>
        public int selection_only;
        //CefCStructTx::GenerateCsCode-Field, 181
        /// <summary>
        /// Set to true (1) for landscape mode or false (0) for portrait mode.
        /// </summary>
        public int landscape;
        //CefCStructTx::GenerateCsCode-Field, 182
        /// <summary>
        /// Set to true (1) to print background graphics or false (0) to not print
        /// background graphics.
        /// </summary>
        public int backgrounds_enabled;
    }
    //CefCStructTx::GenerateCsCode, 183
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_box_layout_settings_t
    {
        //CefCStructTx::GenerateCsCode-Field, 184
        /// <summary>
        /// If true (1) the layout will be horizontal, otherwise the layout will be
        /// vertical.
        /// </summary>
        public int horizontal;
        //CefCStructTx::GenerateCsCode-Field, 185
        /// <summary>
        /// Adds additional horizontal space between the child view area and the host
        /// view border.
        /// </summary>
        public int inside_border_horizontal_spacing;
        //CefCStructTx::GenerateCsCode-Field, 186
        /// <summary>
        /// Adds additional vertical space between the child view area and the host
        /// view border.
        /// </summary>
        public int inside_border_vertical_spacing;
        //CefCStructTx::GenerateCsCode-Field, 187
        /// <summary>
        /// Adds additional space around the child view area.
        /// </summary>
        public cef_insets_t inside_border_insets;
        //CefCStructTx::GenerateCsCode-Field, 188
        /// <summary>
        /// Adds additional space between child views.
        /// </summary>
        public int between_child_spacing;
        //CefCStructTx::GenerateCsCode-Field, 189
        /// <summary>
        /// Specifies where along the main axis the child views should be laid out.
        /// </summary>
        public cef_main_axis_alignment_t main_axis_alignment;
        //CefCStructTx::GenerateCsCode-Field, 190
        /// <summary>
        /// Specifies where along the cross axis the child views should be laid out.
        /// </summary>
        public cef_cross_axis_alignment_t cross_axis_alignment;
        //CefCStructTx::GenerateCsCode-Field, 191
        /// <summary>
        /// Minimum cross axis size.
        /// </summary>
        public int minimum_cross_axis_size;
        //CefCStructTx::GenerateCsCode-Field, 192
        /// <summary>
        /// Default flex for views when none is specified via CefBoxLayout methods.
        /// Using the preferred size as the basis, free space along the main axis is
        /// distributed to views in the ratio of their flex weights. Similarly, if the
        /// views will overflow the parent, space is subtracted in these ratios. A flex
        /// of 0 means this view is not resized. Flex values must not be negative.
        /// </summary>
        public int default_flex;
    }
    //CefCStructTx::GenerateCsCode, 193
    [StructLayout(LayoutKind.Sequential)]
    struct _cef_composition_underline_t
    {
        //CefCStructTx::GenerateCsCode-Field, 194
        /// <summary>
        /// Underline character range.
        /// </summary>
        public cef_range_t range;
        //CefCStructTx::GenerateCsCode-Field, 195
        /// <summary>
        /// Text color.
        /// </summary>
        public cef_color_t color;
        //CefCStructTx::GenerateCsCode-Field, 196
        /// <summary>
        /// Background color.
        /// </summary>
        public cef_color_t background_color;
        //CefCStructTx::GenerateCsCode-Field, 197
        /// <summary>
        /// Set to true (1) for thick underline.
        /// </summary>
        public int thick;
    }
}