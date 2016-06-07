//2016, MIT, WinterDev

using System;
using System.Text;
using System.Collections.Generic;
using System.IO;

namespace BridgeBuilder
{

    class ManualPatcher
    {

        public ManualPatcher(string rootdir)
        {
            this.RootDir = rootdir;
        }
        public string RootDir
        {
            get;
            set;
        }
        public void DoChanged()
        {

            Do_ClientApp_h();
            Do_ClientRenderer_cc();
            Do_PerformanceTest_cc();
            Do_BrowserWindow_cc();
            Do_BrowserWindow_h();
            Do_Client_Handler_cc();
            Do_Client_Handler_h();
            Do_MainContext_h();
            Do_TestRunnner_cc();
            Do_TestRunner_h();
            Do_CMake_txt();

        }
        PatchFile CreatePathFile(string filename)
        {
            return new PatchFile(RootDir + "\\" + filename);
        }

        public void Do_CMake_txt()
        {

            var patch = new PatchFile(RootDir + "\\" + "CMakeLists.txt");

            patch.NewTask("# Source files.")
                .Append(@"set(CEFCLIENT_MYCEF_MYCEF_SRCS
  myext/dll_init.cpp
  myext/dll_init.h
  myext/ExportFuncs.cpp
  myext/ExportFuncs.h
  myext/mycef.cc
  myext/mycef.h
  myext/mycef_msg_const.h
  )
source_group(cefclient\\\\myext FILES ${CEFCLIENT_MYCEF_MYCEF_SRCS})
set(CEFCLIENT_MYCEF_SRCS
  ${CEFCLIENT_MYCEF_MYCEF_SRCS}
  )");

            patch.NewTask("# Windows configuration.")
                .FindNext("if(OS_WINDOWS)")
                .FindNext("set(CEFCLIENT_SRCS")
                .Append("${CEFCLIENT_MYCEF_MYCEF_SRCS}");

            patch.PatchContent();
        }
        void Do_ClientApp_h()
        {

            var patch = CreatePathFile("common/client_app.h");
            patch.NewTask("#include \"include/cef_app.h\"")
                      .Append("#include \"cefclient/myext/mycef.h\"");

            patch.NewTask("static ProcessType GetProcessType(")
                      .Append("managed_callback myMxCallback_ = NULL;//myextension");

            patch.PatchContent();
        }
        void Do_ClientRenderer_cc()
        {

            var patch = CreatePathFile("renderer/client_renderer.cc");
            patch.NewTask("// Create the renderer-side router for query handling.")
                .Append("//show msgbox if we want to break a debugger in render process")
                .Append("//MessageBox(NULL, L\"OnWebKitInitialized\", L\"OnWebKitInitialized\", 0);");
            patch.PatchContent();
        }
        void Do_PerformanceTest_cc()
        {
            var patch = CreatePathFile("renderer/performance_test.cc");
            patch.NewTask("CefRefPtr<CefV8Context> context) OVERRIDE {")
                .Append(
                @"if (app->myMxCallback_)
					{
						//expose all to managed side
						//browser,frame and context ?  
						MethodArgs* metArgs = new MethodArgs();
						metArgs->SetArgAsNativeObject(0, app.get());
						metArgs->SetArgAsNativeObject(1, browser.get());
						metArgs->SetArgAsNativeObject(2, context.get());
						app->myMxCallback_(202, metArgs);
					}
					else {

						//MessageBox(0, L""context-created:mx callback is not set"", L""context-created:mx callback is not set"", 0);
						//single handler for 3 external methods

						CefRefPtr<CefV8Value> object = context->GetGlobal();
						CefRefPtr<CefV8Handler> handler = new V8Handler();

						// Bind test functions.
						object->SetValue(kGetPerfTests,
							CefV8Value::CreateFunction(kGetPerfTests, handler),
							V8_PROPERTY_ATTRIBUTE_READONLY);
						object->SetValue(kRunPerfTest,
							CefV8Value::CreateFunction(kRunPerfTest, handler),
							V8_PROPERTY_ATTRIBUTE_READONLY);
						object->SetValue(kPerfTestReturnValue,
							CefV8Value::CreateFunction(kPerfTestReturnValue, handler),
							V8_PROPERTY_ATTRIBUTE_READONLY);
					}")
                      .SkipUntilAndAccept("}");
            //--------------------------------------------------------
            patch.PatchContent();
        }
        void Do_BrowserWindow_cc()
        {

            var patchFile = CreatePathFile("browser/browser_window.cc");
            patchFile.NewTask("  delegate_->OnSetDraggableRegions(regions);")
                .FollowBy("}")
                .Append(@"//my extension
                        client::ClientHandler* BrowserWindow::GetClientHandler() {
	                        return this->client_handler_;
                        }");
            patchFile.PatchContent();
        }
        void Do_BrowserWindow_h()
        {
            var patchFile = CreatePathFile("browser/browser_window.h");
            patchFile.NewTask(" // Returns true if the browser is closing.")
                      .FollowBy("bool IsClosing() const;")
                      .Append(@"  //my extension 
#ifdef MYCEF_DEBUG//my extension 
  int dbug_id;
#endif  
  //my extension 
  ClientHandler* GetClientHandler();//my extension ");

            patchFile.PatchContent();
        }

        void Do_Client_Handler_cc()
        {
            var patchFile = CreatePathFile("browser/client_handler.cc");
            patchFile.NewTask(" if ((params->GetTypeFlags() & (CM_TYPEFLAG_PAGE | CM_TYPEFLAG_FRAME)) != 0) {")
                .Append(@"if (this->mcallback_)
		{
			//send menu model to managed side
			this->mcallback_(109, NULL);
		}
		else if ((params->GetTypeFlags() & (CM_TYPEFLAG_PAGE | CM_TYPEFLAG_FRAME)) != 0) {
			// Add a separator if the menu already has items.
			if (model->GetCount() > 0)
				model->AddSeparator();

			// Add DevTools items to all context menus.
			model->AddItem(CLIENT_ID_SHOW_DEVTOOLS, ""&Show DevTools"");
			model->AddItem(CLIENT_ID_CLOSE_DEVTOOLS, ""Close DevTools"");
			model->AddSeparator();
			model->AddItem(CLIENT_ID_INSPECT_ELEMENT, ""Inspect Element"");

			// Test context menu features.
			BuildTestMenu(model);
		}");
            //--------------------------------------------------------
            patchFile.NewTask("bool ClientHandler::OnContextMenuCommand(")
                .FindNext("CEF_REQUIRE_UI_THREAD")
                .Append(
                @"
		if (this->mcallback_) {
			return true;
		}
		else {
			switch (command_id) {
			case CLIENT_ID_SHOW_DEVTOOLS:
				ShowDevTools(browser, CefPoint());
				return true;
			case CLIENT_ID_CLOSE_DEVTOOLS:
				CloseDevTools(browser);
				return true;
			case CLIENT_ID_INSPECT_ELEMENT:
				ShowDevTools(browser, CefPoint(params->GetXCoord(), params->GetYCoord()));
				return true;
			default:  // Allow default handling, if any.
				return ExecuteTestMenu(command_id);
			}
		}").SkipUntilPass("}");
            //--------------------------------------------------------
            patchFile.NewTask("bool ClientHandler::OnConsoleMessage(CefRefPtr<CefBrowser> browser,")
                .FindNext("CEF_REQUIRE_UI_THREAD")
                .Append(@"if (this->mcallback_) {

			//get managed stream object
			MethodArgs* args = new MethodArgs();
			// memset(&args,0,sizeof(MethodArgs));	  
			//send info to managed side

			auto str16 = message.ToString16();
			auto cstr = str16.c_str();
			args->SetArgAsString(0, cstr); 
			auto str16_1 = message.ToString16();
			auto cstr_1 = str16_1.c_str();
			args->SetArgAsString(1, cstr_1); 
			auto str16_2 = std::to_wstring((long long)line);
			auto cstr_2 = str16_2.c_str();
			args->SetArgAsString(2, cstr_2); 
			this->mcallback_(106, args); 

		}
		else {
			FILE* file = fopen(console_log_file_.c_str(), ""a"");
			if (file) {
				std::stringstream ss;
				ss << ""Message: "" << message.ToString() << NEWLINE <<
					""Source: "" << source.ToString() << NEWLINE <<
					""Line: "" << line << NEWLINE <<
					""-----------------------"" << NEWLINE;
				fputs(ss.str().c_str(), file);
				fclose(file);

				if (first_console_message_) {
					test_runner::Alert(
						browser, ""Console messages written to "" + console_log_file_ );
					first_console_message_ = false;
				}
			}
		}")
         .SkipUntilAndAccept("return false;");


            //-------------------------------------------------
            patchFile.NewTask(" // Allow geolocation access from all websites.")
                .Append("callback->Continue(false);")
                .SkipUntilAndAccept("return true;");


            //-------------------------------------------------
            patchFile.NewTask("bool ClientHandler::OnBeforePopup(")
                .FindNext("CEF_REQUIRE_IO_THREAD")
                .Append(@"
		if (this->mcallback_) {
			//create popup window
			//with specific url
			//*** on managed side  : please invoke on main process of app ***

			//call across process, so create on heap 
			//don't forget to release it
			MethodArgs* metArgs = new MethodArgs();
			auto str16 = target_url.ToString16();
			auto cstr = str16.c_str();

			metArgs->SetArgAsString(0, cstr);
			this->mcallback_(104, metArgs);


			return true;
		}
		else {

			// Return true to cancel the popup window.
			return !CreatePopupWindow(browser, false, popupFeatures, windowInfo, client,
				settings);
		}")
          .SkipUntilAndAccept("}");
            //-------------------------------------------------
            patchFile.NewTask("void ClientHandler::OnAfterCreated(CefRefPtr<CefBrowser> browser)")
                .FindNext(" message_router_ = CefMessageRouterBrowserSide::Create(config);")
                .Append(@"// Register handlers with the router.
			if (this->mcallback_)
			{
				//1. msg handler
				MyCefJsHandler* myCefJsHandler = new MyCefJsHandler();
				message_handler_set_.insert(myCefJsHandler);
				myCefJsHandler->mcallback_ = this->mcallback_;

				MessageHandlerSet::const_iterator it = message_handler_set_.begin();
				for (; it != message_handler_set_.end(); ++it)
					message_router_->AddHandler(*(it), false);
			}
			else
			{
				test_runner::CreateMessageHandlers(message_handler_set_);
				MessageHandlerSet::const_iterator it = message_handler_set_.begin();
				for (; it != message_handler_set_.end(); ++it)
					message_router_->AddHandler(*(it), false);

			}").SkipUntilAndAccept("}");
            //--------------------------------------------------------
            patchFile.NewTask("void ClientHandler::ShowDevTools(CefRefPtr<CefBrowser> browser,")
                .FindNext(" CefBrowserSettings settings;")
                .Append(@"if (this->mcallback_)
		{
			//TODO: send cmd to managed side
			//create dev window
			//send cef client 
			this->mcallback_(107, NULL);

		}
		else {
			if (CreatePopupWindow(browser, true, CefPopupFeatures(), windowInfo, client,
				settings)) {
				browser->GetHost()->ShowDevTools(windowInfo, client, settings,
					inspect_element_at);
			}
		  }").SkipUntilPass("}");
            //-------------------------------------------------
            patchFile.NewTask("void ClientHandler::CloseDevTools(CefRefPtr<CefBrowser> browser) {")
                .Append(@"if (this->mcallback_) {
			//TODO: send command
			this->mcallback_(108, NULL);
		}
		else {
			browser->GetHost()->CloseDevTools();
		}").SkipUntilAndAccept("}");
            //-------------------------------------------------
            patchFile.NewTask("void ClientHandler::NotifyBrowserCreated(CefRefPtr<CefBrowser> ")
                .FindNext(" MAIN_POST_CLOSURE(")
                .FindNext("}")
                .Append(@"if (this->mcallback_) {
			            this->mcallback_(101, NULL);
		         }");

            //-------------------------------------------------
            patchFile.NewTask("void ClientHandler::NotifyBrowserClosed(CefRefPtr<CefBrowser>")
                .FindNext("delegate_->OnBrowserClosed(browser);")
                .Append(@"if (this->mcallback_) {
			this->mcallback_(100, NULL);
		        }");
            //-------------------------------------------------
            patchFile.NewTask("bool ClientHandler::ExecuteTestMenu(int command_id) {")
                .FindNext("	// Allow default handling to proceed.")
                .FindNext("return false;")
                .FindNext("}")
                .Append(@"//my extension ***
	void ClientHandler::MyCefSetManagedCallBack(managed_callback m) {

		this->mcallback_ = m;
		//add resource mx handler

		MethodArgs args;
		memset(&args, 0, sizeof(MethodArgs));

		//get filter function ptr from managed side
		args.SetArgAsNativeObject(0, resource_manager_);
		
		m(140, &args);

		//1. add url filter
		//2. add resource provider
		client::test_runner::SetupResourceManager2(resource_manager_, m); 
	}");



            //==============================================================================
            patchFile.PatchContent();

        }

        void Do_Client_Handler_h()
        {

            var patchFile = CreatePathFile("browser/client_handler.h");
            patchFile.NewTask("#include \"cefclient/browser/client_types.h\"")
                .Append("//my extension")
                .Append("#include \"cefclient/myext/mycef.h\"");
            patchFile.NewTask("bool is_osr() const { return is_osr_; }")
                .Append(@"//my extension
		void MyCefSetManagedCallBack(managed_callback m);");

            patchFile.NewTask("// Set of Handlers registered with the message router.")
                    .FollowBy("MessageHandlerSet message_handler_set_;")
                    .Append(@"	//my extension
                		managed_callback mcallback_;//my extension
                     ")
                     .Append(
                            @"std::string RequestUrlFilter(const std::string& url);//my extension")
                     .FindNext("};")
                     .Append(@"
//----------

	// Handle messages in the browser process.
	// via cefQuery
	class MyCefJsHandler : public CefMessageRouterBrowserSide::Handler {
	public:

		managed_callback mcallback_;//my extension
		MyCefJsHandler() {}

		virtual bool OnQuery(CefRefPtr<CefBrowser> browser,
			CefRefPtr<CefFrame> frame,
			int64 query_id,
			const CefString& request,
			bool persistent,
			CefRefPtr<Callback> callback) OVERRIDE {
			CEF_REQUIRE_UI_THREAD(); 

			//const std::string& request_str = request;
			if (this->mcallback_)
			{

				QueryRequestArgs queryReq;
				memset(&queryReq, 0, sizeof(QueryRequestArgs));
				queryReq.browser = browser.get();
				queryReq.frame = frame.get();

				queryReq.query_id = query_id;
				
			 
				//queryReq.request = &request;
				MyCefStringHolder mystr;
				mystr.value = request;
				queryReq.request = &mystr;
				queryReq.persistent = persistent;
				queryReq.callback = callback.get();

				MethodArgs args;
				memset(&args, 0, sizeof(MethodArgs));
				args.SetArgAsNativeObject(0, &queryReq); 
				this->mcallback_(205, &args); 


				return true;
			}

			return false;
		}//OnQuery
	}; //class MyCefJsHandler");


            //===================================
            patchFile.PatchContent();
        }
        void Do_MainContext_h()
        {
            var patchFile = CreatePathFile("browser/main_context.h");
            patchFile.NewTask("#include \"cefclient/browser/osr_renderer.h\"")
                .Append("#include \"cefclient/myext/mycef.h\" //my extension");

            patchFile.NewTask("virtual RootWindowManager* GetRootWindowManager() = 0;")
                .Append(@"  //my extension --for callback to managed side
                managed_callback myMxCallback_;");

            //===================================
            patchFile.PatchContent();
        }
        void Do_TestRunnner_cc()
        {
            var patchFile = CreatePathFile("browser/test_runner.cc");
            patchFile.NewTask("#include \"cefclient/browser/window_test.h\"")
                .Append("#include \"include/wrapper/cef_byte_read_handler.h\"");

            patchFile.NewTask("namespace test_runner {")
                .Append("managed_callback mcallback_ = NULL;");

            patchFile.NewTask("class RequestDumpResourceProvider ")
                .FindNext("DISALLOW_COPY_AND_ASSIGN(RequestDumpResourceProvider);")
                .FindNext("};")
                .Append(@"	std::string RequestUrlFilter2(const std::string& url) {

				if (client::test_runner::mcallback_)
				{
					MethodArgs metArgs;
					memset(&metArgs, 0, sizeof(MethodArgs));

					//-----------------------------------------
					CefString cef_str(url);
					metArgs.SetArgAsString(0, cef_str.c_str());

					client::test_runner::mcallback_(142, &metArgs);

					if (metArgs.result0.value.i32 == 0) {
						//no change
						return url;
					}
					else {
						//changed
						//
						std::string s1("""");
						s1.append((const char*)metArgs.result1.value.ptr, metArgs.result1.length);
						return s1;
					}

				}
				return url; 
			}");





            patchFile.NewTask("void SetupResourceManager(CefRefPtr<CefResourceManager> resource_manager) {")
                .FindNext("#endif")
                .FindNext("}")
                .Append(@"void SetupResourceManager2(CefRefPtr<CefResourceManager> resource_manager, managed_callback mcallback) {

			// Provider of binary resources.
			class BinaryResourceProvider : public CefResourceManager::Provider {
			public:

				managed_callback mcallback = NULL;
				explicit BinaryResourceProvider(const std::string& url_path)
					: url_path_(url_path) {
					DCHECK(!url_path.empty());
				}

				bool OnRequest(scoped_refptr<CefResourceManager::Request> request) OVERRIDE {
					CEF_REQUIRE_IO_THREAD();

					if (mcallback)
					{
						MethodArgs metArgs;
						memset(&metArgs, 0, sizeof(MethodArgs));

						const std::string& url = request->url();
						CefString cefStr(url);
						metArgs.SetArgAsString(0, cefStr.c_str());
						metArgs.SetArgAsNativeObject(1, request);

						//get data from managed side
						mcallback(145, &metArgs); //get resource 

						if (metArgs.result0.value.i32 == 0) {
							return false; //not handle by this handler
						}

						//has resource in managed buffer form
						//so we need to copy to unmanaged form
						CefRefPtr<CefStreamReader> stream = CefStreamReader::CreateForHandler(
							new CefByteReadHandler((const unsigned char*)metArgs.result1.value.byteBuffer, (size_t)metArgs.result1.length, NULL));

						CefString cefStr2(metArgs.ReadOutputAsString(2));
						CefRefPtr<CefResourceHandler> handler = new CefStreamResourceHandler(
							cefStr2,
							stream);

						request->Continue(handler);

						return true;
					}
					else
					{
						const std::string& url = request->url();
						if (url.find(url_path_) != 0L) {
							// Not handled by this provider.
							return false;
						}

						CefRefPtr<CefResourceHandler> handler;
						//get str after url
						const std::string& relative_path = url.substr(url_path_.length());
						if (!relative_path.empty()) {
							CefRefPtr<CefStreamReader> stream =
								GetBinaryResourceReader(relative_path.data());
							if (stream.get()) {
								handler = new CefStreamResourceHandler(
									request->mime_type_resolver().Run(url),
									stream);
							}
						}

						request->Continue(handler);
						return true;
					}
				}

			private:
				std::string url_path_;

				//DISALLOW_COPY_AND_ASSIGN(BinaryResourceProvider);
			};

			const std::string& test_origin = kTestOrigin;

			mcallback_ = mcallback;
			// Add the URL filter.
			resource_manager->SetUrlFilter(base::Bind(RequestUrlFilter2));

			auto binResProvider = new BinaryResourceProvider(test_origin);
			binResProvider->mcallback = mcallback;
			resource_manager->AddProvider(binResProvider, 100, std::string());


			//// Add provider for resource dumps.
			//resource_manager->AddProvider(
			//	new RequestDumpResourceProvider(test_origin + ""request.html""),
			//	0, std::string());

			// Add provider for bundled resource files.
#if defined(OS_WIN)
			/*	resource_manager->AddProvider(CreateBinaryResourceProvider(test_origin),
			100, std::string());*/
#elif defined(OS_POSIX)
			// Read resources from a directory on disk.
			std::string resource_dir;
			if (GetResourceDir(resource_dir)) {
				resource_manager->AddDirectoryProvider(test_origin, resource_dir,
					100, std::string());
			}
#endif
		}");


            //===================================
            patchFile.PatchContent();
        }

        void Do_TestRunner_h()
        {
            var patchFile = CreatePathFile("browser/test_runner.h");

            patchFile.NewTask("#include \"include/wrapper/cef_resource_manager.h\"")
                .Append("#include \"cefclient/myext/mycef.h\"");
            patchFile.NewTask("void SetupResourceManager(CefRefPtr<CefResourceManager> resource_manager);")
                .Append("void SetupResourceManager2(CefRefPtr<CefResourceManager> resource_manager, managed_callback mcallback);");

            //===================================
            patchFile.PatchContent();
        }

        public void CopyExtensionSources()
        {


            string extensionSourceDir = @"..\..\Patcher_ExtCode\myext";
            string extensionTargetDir = this.RootDir + "\\myext";

            if (extensionSourceDir == extensionTargetDir)
            {
                throw new NotSupportedException("not copy to the same dir");
            }


            //check extension source dir
            if (!Directory.Exists(extensionSourceDir))
            {
                throw new NotSupportedException("no extension src dir");
            }
            if (Directory.Exists(extensionTargetDir))
            {
                throw new NotSupportedException("target dir already exists");
            }
            //-------------------------------------------------------------
            //create ext dir
            Directory.CreateDirectory(extensionTargetDir);
            //copy 
            string[] files = Directory.GetFiles(extensionSourceDir);
            for (int i = files.Length - 1; i >= 0; --i)
            {
                File.Copy(files[i],
                    extensionTargetDir + "\\" + Path.GetFileName(files[i]));
            }
            //------------------------------------------------------------- 
        }
        
    }
}