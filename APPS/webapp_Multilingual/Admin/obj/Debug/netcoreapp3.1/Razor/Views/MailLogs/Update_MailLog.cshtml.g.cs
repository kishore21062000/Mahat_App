#pragma checksum "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2dc803b1ccddac6f410efcb6027321a3d8dcb85b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MailLogs_Update_MailLog), @"mvc.1.0.view", @"/Views/MailLogs/Update_MailLog.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 3 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2dc803b1ccddac6f410efcb6027321a3d8dcb85b", @"/Views/MailLogs/Update_MailLog.cshtml")]
    #nullable restore
    public class Views_MailLogs_Update_MailLog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Multilingual.Models.MailLogsModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/trumbowyg/dist/ui/trumbowyg.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/trumbowyg/dist/trumbowyg.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\t\t\t<!-- This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/08/2023 10:19:58 -->\r\n");
#nullable restore
#line 6 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
              
			ViewData["Title"] = "Update MailLog";

			Layout = "~/Views/Shared/_Layout.cshtml";
			
			

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
             using(Html.BeginForm("Update_MailLog", "MailLogs", FormMethod.Post, new { enctype="multipart/form-data", @id = "formId"}))
			{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""card card-block contCard""><!--Form_Main_Card-->
				<div class=""mobileHeader""><!--form_card_header-->
					<div class=""row"">
						<div class=""col-sm-12 col-xs-12"">
							<h4 class=""formHdr"">Update MailLog</h4>
						</div>
					</div>
				</div><!--form_card_header-->
				<!--form_error_display-->
");
#nullable restore
#line 25 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                 if(ViewData["message"] != null)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"				<div class=""row"">
				<div class=""col-sm-12 col-xs-12"">
				<div class=""alert alert-danger alert-dismissible "">
				<button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
				<span aria-hidden=""true"">x</span>
				</button>
				Info :  ");
#nullable restore
#line 33 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                   Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 37 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t \r\n\t\t\t\t\r\n\t\t\t\t<!--form_error_display-->\r\n\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 1341, "\"", 1349, 0);
            EndWriteAttribute();
            WriteLiteral("><!--form_inner_card-->\r\n\t\t\t\t\t<div class=\"card-block\"><!--form_inner_card_block-->\r\n\t\t\t\t\t    ");
#nullable restore
#line 45 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                   Write(Html.HiddenFor(m => m.MailLogsid));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
						 

						
						<div class=""row""><!--field_container_row-->
							<!--fieldsStartsHere-->
								
								<div class=""col-sm-3 col-xs-12 p-2 entityname_craftmyapp_container"">
						<div>
							<div class=""form-group"" > 
								<label>Entity Name <b class=""iconRed"">*</b></label>
                                ");
#nullable restore
#line 56 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                           Write(Html.TextBoxFor(m => m.entityname, new {@type="text",@maxlength="128", @class = "form-control form-control-lg required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 58 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                            Write(Html.ValidationMessageFor(model => model.entityname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-3 col-xs-12 p-2 entityid_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>Entity ID</label>\r\n                                ");
#nullable restore
#line 66 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                           Write(Html.TextBoxFor(m => m.entityid, new {@type="text",@maxlength="128", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 68 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                            Write(Html.ValidationMessageFor(model => model.entityid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-3 col-xs-12 p-2 mailfor_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>Mail For</label>\r\n                                ");
#nullable restore
#line 76 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                           Write(Html.TextBoxFor(m => m.mailfor, new {@type="text",@maxlength="256", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 78 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                            Write(Html.ValidationMessageFor(model => model.mailfor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-3 col-xs-12 p-2 mailsubject_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>Mail To</label>\r\n                                ");
#nullable restore
#line 86 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                           Write(Html.TextBoxFor(m => m.mailsubject, new {@type="text",@maxlength="256", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 88 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                            Write(Html.ValidationMessageFor(model => model.mailsubject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-3 col-xs-12 p-2 mailto_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>Mail Subject</label>\r\n                                ");
#nullable restore
#line 96 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                           Write(Html.TextBoxFor(m => m.mailto, new {@type="text",@maxlength="50", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 98 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                            Write(Html.ValidationMessageFor(model => model.mailto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-12 col-xs-12 p-2 mailbody_craftmyapp_container\">\r\n\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group form-group--float-above my-3\" > \r\n\t\t\t\t\t\t\t\t\t\t<label>Mail Body</label>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 106 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                                                       Write(Html.TextAreaFor(m => m.mailbody, new {@class = "form-control wysiwyg-editor " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"form-group__bar\" ></i>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 110 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                               Write(Html.ValidationMessageFor(model => model.mailbody));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""mailbody-error"" class=""help-block"" style=""display: none"" for=""mailbody""></label>
								</div>
							</div>
<div class=""col-sm-3 col-xs-12 p-4 issent_craftmyapp_container"">
							<div>

							<label>Is Sent ?</label><br>
							<div class=""form-group"">
                                                        <div>
                                                          <label class=""switch"">
                                                          ");
#nullable restore
#line 121 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                                                     Write(Html.CheckBoxFor(m => m.issent,new {@class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                           
                                                          <span class=""slider round""></span>
                                                        </label>
                                                        </div>
                                                      </div>

							</div>
							</div>


							<!--fieldsEndsHere-->	
						</div><!--field_container_row-->


						<div class=""card-block""><!--form_button_card_block-->
							<button type=""button"" onclick=""window.history.back()""  class=""btn btn-secondary cma_cancel_button waves-effect"">Cancel</button>
							<button type=""button"" id=""btnSubmit"" class=""btn cma_primary_button  waves-effect pull-right"">Update MailLog</button>
						</div><!--form_button_card_block-->


					</div><!--form_inner_card_block-->
				</div><!--form_inner_card-->
			</div><!--Form_Main_Card-->
");
#nullable restore
#line 145 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--EndFORM-->\r\n\r\n\r\n\t\t\t\r\n\t\t\t \r\n\t\t\t <script type=\"text/javascript\">\r\n\t\t\t\t$(document).ready(function () {\r\n\r\n\r\n\t\t\t\tvar Actions=getAutho(\"MailLogs\",\"edit\")\r\n\t\t\t\tif(Actions == undefined){\r\n\t\t\t\twindow.location = \"");
#nullable restore
#line 157 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\MailLogs\Update_MailLog.cshtml"
                              Write(Url.Action("RoleAuthorizationFailed", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n\t\t\t\t}\r\n\r\n\r\n\t\t\t\t});\r\n\t\t\t\t</script>\r\n\t\t\t\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2dc803b1ccddac6f410efcb6027321a3d8dcb85b15361", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2dc803b1ccddac6f410efcb6027321a3d8dcb85b16474", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>$('#mailbody').trumbowyg();</script>

			
			
			
			
			<script>
			
			 
			</script>
			<script>
	$(document).ready(function () {
		
			$('#formId').validate({
                                        highlight: function(element) {
                                        $(element).closest('.form-group').addClass('has-error');
                                        $(element).closest('.form-group').removeClass('has-success');
                                        $(element).addClass('form-control-error');
                                        $(element).removeClass('form-control-success');
                                        },
                                        unhighlight: function(element) {
                                        $(element).closest('.form-group').removeClass('has-error');
                                        $(element).closest('.form-group').addClass('has-success');
                                        $(element).addClass('form-control-");
            WriteLiteral(@"success');
                                        $(element).removeClass('form-control-error');
                                        },
                                        errorElement: 'span',
                                        errorClass: 'help-block'
                                        });

			    var validator = $(""#formId"").validate({ /* settings */ });
                                            $(""#btnSubmit"").click(function(){
                                                if ($(""#formId"").valid()){
                                                        $("".page-loader"").show()

														
                                                        $(""#formId"").submit();
                                                }else{
                                                    validator.focusInvalid();
                                                    swal({
                                                        title: 'Validation Failed!',
                      ");
            WriteLiteral(@"                                  text: ""Please check your entry"",
                                                        type: 'error',
                                                        buttonsStyling: false,
                                                        confirmButtonClass: 'btn btn-primary'
                                                    })
                                                }
                                            })


                                        })

	 
	</script>

			
			
            

			
			




");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IHttpContextAccessor HttpContextAccessor { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Multilingual.Models.MailLogsModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
