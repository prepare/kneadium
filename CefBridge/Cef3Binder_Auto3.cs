//MIT, 2015-2017, WinterDev

using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
namespace LayoutFarm.CefBridge.Auto
{

    public struct CefBrowser
    {
        /*345*/
        const int _GetHost_1 = 1;
        /*346*/
        const int _CanGoBack_2 = 2;
        /*347*/
        const int _GoBack_3 = 3;
        /*348*/
        const int _CanGoForward_4 = 4;
        /*349*/
        const int _GoForward_5 = 5;
        /*350*/
        const int _IsLoading_6 = 6;
        /*351*/
        const int _Reload_7 = 7;
        /*352*/
        const int _ReloadIgnoreCache_8 = 8;
        /*353*/
        const int _StopLoad_9 = 9;
        /*354*/
        const int _GetIdentifier_10 = 10;
        /*355*/
        const int _IsSame_11 = 11;
        /*356*/
        const int _IsPopup_12 = 12;
        /*357*/
        const int _HasDocument_13 = 13;
        /*358*/
        const int _GetMainFrame_14 = 14;
        /*359*/
        const int _GetFocusedFrame_15 = 15;
        /*360*/
        const int _GetFrame_16 = 16;
        /*361*/
        const int _GetFrame_17 = 17;
        /*362*/
        const int _GetFrameCount_18 = 18;
        /*363*/
        const int _GetFrameIdentifiers_19 = 19;
        /*364*/
        const int _GetFrameNames_20 = 20;
        /*365*/
        const int _SendProcessMessage_21 = 21;
        /*366*/
        IntPtr nativePtr;
        /*367*/
        internal CefBrowser(IntPtr nativePtr)
        {
            /*368*/
            this.nativePtr = nativePtr;
            /*369*/
        }
        /*370*/
        [DllImport(Cef3Binder.CEF_CLIENT_DLL, CallingConvention = CallingConvention.Cdecl)]
        /*371*/
        static extern void MyCefMet_CefBrowser(IntPtr me, int metName, out JsValue ret, ref JsValue v1, ref JsValue v2, ref JsValue v3, ref JsValue v4, ref JsValue v5, ref JsValue v6);

        /*372*/
        static void MyCefMet_CefBrowser(IntPtr me, int metName, out JsValue ret
        /*373*/
        )
        {
            /*374*/
            JsValue v1 = new JsValue();
            /*375*/
            JsValue v2 = new JsValue();
            /*376*/
            JsValue v3 = new JsValue();
            /*377*/
            JsValue v4 = new JsValue();
            /*378*/
            JsValue v5 = new JsValue();
            /*379*/
            JsValue v6 = new JsValue();
            /*380*/
            MyCefMet_CefBrowser(
            /*381*/
            me, metName, out ret
            , ref v1, ref v2, ref v3, ref v4, ref v5, ref v6/*382*/
            );
            /*383*/
        }
        /*384*/
        static void MyCefMet_CefBrowser(IntPtr me, int metName, out JsValue ret
        , ref JsValue v1/*385*/
        )
        {
            /*386*/
            JsValue v2 = new JsValue();
            /*387*/
            JsValue v3 = new JsValue();
            /*388*/
            JsValue v4 = new JsValue();
            /*389*/
            JsValue v5 = new JsValue();
            /*390*/
            JsValue v6 = new JsValue();
            /*391*/
            MyCefMet_CefBrowser(
            /*392*/
            me, metName, out ret
            , ref v1, ref v2, ref v3, ref v4, ref v5, ref v6/*393*/
            );
            /*394*/
        }
        /*395*/
        static void MyCefMet_CefBrowser(IntPtr me, int metName, out JsValue ret
        , ref JsValue v1, ref JsValue v2/*396*/
        )
        {
            /*397*/
            JsValue v3 = new JsValue();
            /*398*/
            JsValue v4 = new JsValue();
            /*399*/
            JsValue v5 = new JsValue();
            /*400*/
            JsValue v6 = new JsValue();
            /*401*/
            MyCefMet_CefBrowser(
            /*402*/
            me, metName, out ret
            , ref v1, ref v2, ref v3, ref v4, ref v5, ref v6/*403*/
            );
            /*404*/
        }
        /*405*/
        static void MyCefMet_CefBrowser(IntPtr me, int metName, out JsValue ret
        , ref JsValue v1, ref JsValue v2, ref JsValue v3/*406*/
        )
        {
            /*407*/
            JsValue v4 = new JsValue();
            /*408*/
            JsValue v5 = new JsValue();
            /*409*/
            JsValue v6 = new JsValue();
            /*410*/
            MyCefMet_CefBrowser(
            /*411*/
            me, metName, out ret
            , ref v1, ref v2, ref v3, ref v4, ref v5, ref v6/*412*/
            );
            /*413*/
        }
        /*414*/
        static void MyCefMet_CefBrowser(IntPtr me, int metName, out JsValue ret
        , ref JsValue v1, ref JsValue v2, ref JsValue v3, ref JsValue v4/*415*/
        )
        {
            /*416*/
            JsValue v5 = new JsValue();
            /*417*/
            JsValue v6 = new JsValue();
            /*418*/
            MyCefMet_CefBrowser(
            /*419*/
            me, metName, out ret
            , ref v1, ref v2, ref v3, ref v4, ref v5, ref v6/*420*/
            );
            /*421*/
        }
        /*422*/
        static void MyCefMet_CefBrowser(IntPtr me, int metName, out JsValue ret
        , ref JsValue v1, ref JsValue v2, ref JsValue v3, ref JsValue v4, ref JsValue v5/*423*/
        )
        {
            /*424*/
            JsValue v6 = new JsValue();
            /*425*/
            MyCefMet_CefBrowser(
            /*426*/
            me, metName, out ret
            , ref v1, ref v2, ref v3, ref v4, ref v5, ref v6/*427*/
            );
            /*428*/
        }
        /*429*/
      

        // gen! CefRefPtr<CefBrowserHost> GetHost()
        /*430*/

        public CefBrowserHost GetHost()/*431*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _GetHost_1, out ret/*432*/
            );
            /*433*/
            CefBrowserHost ret_result = new CefBrowserHost(ret.nativePtr);
            /*434*/
            return ret_result;
            /*435*/
        }
        /*436*/


        // gen! bool CanGoBack()
        /*437*/

        public bool CanGoBack()/*438*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _CanGoBack_2, out ret/*439*/
            );
            /*440*/
            MyCefSetBool(ret, ret_result);
            /*441*/
            return ret_result;
            /*442*/
        }
        /*443*/


        // gen! void GoBack()
        /*444*/

        public void GoBack()/*445*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _GoBack_3, out ret/*446*/
            );
            /*447*/

            /*448*/
        }
        /*449*/


        // gen! bool CanGoForward()
        /*450*/

        public bool CanGoForward()/*451*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _CanGoForward_4, out ret/*452*/
            );
            /*453*/
            MyCefSetBool(ret, ret_result);
            /*454*/
            return ret_result;
            /*455*/
        }
        /*456*/


        // gen! void GoForward()
        /*457*/

        public void GoForward()/*458*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _GoForward_5, out ret/*459*/
            );
            /*460*/

            /*461*/
        }
        /*462*/


        // gen! bool IsLoading()
        /*463*/

        public bool IsLoading()/*464*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _IsLoading_6, out ret/*465*/
            );
            /*466*/
            MyCefSetBool(ret, ret_result);
            /*467*/
            return ret_result;
            /*468*/
        }
        /*469*/


        // gen! void Reload()
        /*470*/

        public void Reload()/*471*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _Reload_7, out ret/*472*/
            );
            /*473*/

            /*474*/
        }
        /*475*/


        // gen! void ReloadIgnoreCache()
        /*476*/

        public void ReloadIgnoreCache()/*477*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _ReloadIgnoreCache_8, out ret/*478*/
            );
            /*479*/

            /*480*/
        }
        /*481*/


        // gen! void StopLoad()
        /*482*/

        public void StopLoad()/*483*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _StopLoad_9, out ret/*484*/
            );
            /*485*/

            /*486*/
        }
        /*487*/


        // gen! int GetIdentifier()
        /*488*/

        public int GetIdentifier()/*489*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _GetIdentifier_10, out ret/*490*/
            );
            /*491*/
            MyCefSetInt64(ret, ret_result);
            /*492*/
            return ret_result;
            /*493*/
        }
        /*494*/


        // gen! bool IsSame(CefRefPtr<CefBrowser> that)
        /*495*/

        public bool IsSame(CefBrowser /*496*/
        that
        )/*497*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _IsSame_11, out ret, ref v1/*498*/
            );
            /*499*/
            MyCefSetBool(ret, ret_result);
            /*500*/
            return ret_result;
            /*501*/
        }
        /*502*/


        // gen! bool IsPopup()
        /*503*/

        public bool IsPopup()/*504*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _IsPopup_12, out ret/*505*/
            );
            /*506*/
            MyCefSetBool(ret, ret_result);
            /*507*/
            return ret_result;
            /*508*/
        }
        /*509*/


        // gen! bool HasDocument()
        /*510*/

        public bool HasDocument()/*511*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _HasDocument_13, out ret/*512*/
            );
            /*513*/
            MyCefSetBool(ret, ret_result);
            /*514*/
            return ret_result;
            /*515*/
        }
        /*516*/


        // gen! CefRefPtr<CefFrame> GetMainFrame()
        /*517*/

        public CefFrame GetMainFrame()/*518*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _GetMainFrame_14, out ret/*519*/
            );
            /*520*/
            CefFrame ret_result = new CefFrame(ret.nativePtr);
            /*521*/
            return ret_result;
            /*522*/
        }
        /*523*/


        // gen! CefRefPtr<CefFrame> GetFocusedFrame()
        /*524*/

        public CefFrame GetFocusedFrame()/*525*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _GetFocusedFrame_15, out ret/*526*/
            );
            /*527*/
            CefFrame ret_result = new CefFrame(ret.nativePtr);
            /*528*/
            return ret_result;
            /*529*/
        }
        /*530*/


        // gen! CefRefPtr<CefFrame> GetFrame(int64 identifier)
        /*531*/

        public CefFrame GetFrame(long /*532*/
        identifier
        )/*533*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _GetFrame_16, out ret, ref v1/*534*/
            );
            /*535*/
            CefFrame ret_result = new CefFrame(ret.nativePtr);
            /*536*/
            return ret_result;
            /*537*/
        }
        /*538*/


        // gen! CefRefPtr<CefFrame> GetFrame(const CefString& name)
        /*539*/

        public CefFrame GetFrame(string /*540*/
        name
        )/*541*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _GetFrame_17, out ret, ref v1/*542*/
            );
            /*543*/
            CefFrame ret_result = new CefFrame(ret.nativePtr);
            /*544*/
            return ret_result;
            /*545*/
        }
        /*546*/


        // gen! size_t GetFrameCount()
        /*547*/

        public uint32 GetFrameCount()/*548*/
        {
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _GetFrameCount_18, out ret/*549*/
            );
            /*550*/
            MyCefSetInt32(ret, (int32_t)ret_result);
            /*551*/
            return ret_result;
            /*552*/
        }
        /*553*/


        // gen! void GetFrameIdentifiers(std::vector<int64>& identifiers)
        /*554*/

        public void GetFrameIdentifiers(List<long> /*555*/
        identifiers
        )/*556*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _GetFrameIdentifiers_19, out ret, ref v1/*557*/
            );
            /*558*/

            /*559*/
        }
        /*560*/


        // gen! void GetFrameNames(std::vector<CefString>& names)
        /*561*/

        public void GetFrameNames(List<string> /*562*/
        names
        )/*563*/
        {
            JsValue v1 = new JsValue();
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _GetFrameNames_20, out ret, ref v1/*564*/
            );
            /*565*/

            /*566*/
        }
        /*567*/


        // gen! bool SendProcessMessage(CefProcessId target_process,CefRefPtr<CefProcessMessage> message)
        /*568*/

        public bool SendProcessMessage(cef_process_id_t /*569*/
        target_process
        , CefProcessMessage /*570*/
        message
        )/*571*/
        {
            JsValue v1 = new JsValue();
            JsValue v2 = new JsValue();
            JsValue ret;
            MyCefMet_CefBrowser(this.nativePtr, _SendProcessMessage_21, out ret, ref v1, ref v2/*572*/
            );
            /*573*/
            MyCefSetBool(ret, ret_result);
            /*574*/
            return ret_result;
            /*575*/
        }
        /*576*/
    }
}

