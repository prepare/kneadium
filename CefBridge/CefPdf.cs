//MIT, 2017, WinterDev 

namespace LayoutFarm.CefBridge
{
    enum cef_pdf_print_margin_type
    {
        ///
        // Default margins.
        ///
        PDF_PRINT_MARGIN_DEFAULT,

        ///
        // No margins.
        ///
        PDF_PRINT_MARGIN_NONE,

        ///
        // Minimum margins.
        ///
        PDF_PRINT_MARGIN_MINIMUM,

        ///
        // Custom margins using the |margin_*| values from cef_pdf_print_settings_t.
        ///
        PDF_PRINT_MARGIN_CUSTOM,
    }
}