#pragma checksum "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d21e44f91c39451880ad24f2b0a8db7fd8aa852b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AlertTemplates_Update_Alert_Templates), @"mvc.1.0.view", @"/Views/AlertTemplates/Update_Alert_Templates.cshtml")]
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
#line 3 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d21e44f91c39451880ad24f2b0a8db7fd8aa852b", @"/Views/AlertTemplates/Update_Alert_Templates.cshtml")]
    #nullable restore
    public class Views_AlertTemplates_Update_Alert_Templates : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AIData.Models.AlertTemplatesModel>
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
            WriteLiteral("\r\n\t\t\t<!-- This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/26/2023 08:36:48 -->\r\n");
#nullable restore
#line 6 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
              
			ViewData["Title"] = "Update Alert Templates";

			Layout = "~/Views/Shared/_Layout.cshtml";
			
			

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
             using(Html.BeginForm("Update_Alert_Templates", "AlertTemplates", FormMethod.Post, new { enctype="multipart/form-data", @id = "formId"}))
			{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""card card-block contCard""><!--Form_Main_Card-->
				<div class=""mobileHeader""><!--form_card_header-->
					<div class=""row"">
						<div class=""col-sm-12 col-xs-12"">
							<h4 class=""formHdr"">Update Alert Templates</h4>
						</div>
					</div>
				</div><!--form_card_header-->
				<!--form_error_display-->
");
#nullable restore
#line 25 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
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
#line 33 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                   Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 37 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t \r\n\t\t\t\t\r\n\t\t\t\t<!--form_error_display-->\r\n\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 1371, "\"", 1379, 0);
            EndWriteAttribute();
            WriteLiteral("><!--form_inner_card-->\r\n\t\t\t\t\t<div class=\"card-block\"><!--form_inner_card_block-->\r\n\t\t\t\t\t    ");
#nullable restore
#line 45 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                   Write(Html.HiddenFor(m => m.AlertTemplatesid));

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
#line 56 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                           Write(Html.TextBoxFor(m => m.entityname, new {@type="text",@maxlength="128", @class = "form-control form-control-lg required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 58 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                            Write(Html.ValidationMessageFor(model => model.entityname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-3 col-xs-12 p-2 entityaction_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>Entity Action</label>\r\n                                ");
#nullable restore
#line 66 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                           Write(Html.TextBoxFor(m => m.entityaction, new {@type="text",@maxlength="128", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 68 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                            Write(Html.ValidationMessageFor(model => model.entityaction));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
					</div>
<div class=""col-sm-3 col-xs-12 p-4 sendasbatch_craftmyapp_container"">
							<div>

							<label>Send as Batch?</label><br>
							<div class=""form-group"">
                                                        <div>
                                                          <label class=""switch"">
                                                          ");
#nullable restore
#line 79 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                                                     Write(Html.CheckBoxFor(m => m.sendasbatch,new {@class = "" }));

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
<div class=""col-sm-3 col-xs-12 p-2 alerttype_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Alert Type</label>
										<select name=""alerttype"" id=""alerttype"" class=""form-control  ""></select>

									</div>
									");
#nullable restore
#line 95 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                               Write(Html.ValidationMessageFor(model => model.alerttype));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""alerttype-error"" class=""help-block"" style=""display: none"" for=""alerttype""></label>
								</div>
							</div>
<div class=""col-sm-3 col-xs-12 p-2 alertsubject_craftmyapp_container"">
						<div>
							<div class=""form-group"" > 
								<label>Alert Subject</label>
                                ");
#nullable restore
#line 103 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                           Write(Html.TextBoxFor(m => m.alertsubject, new {@type="text",@maxlength="256", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 105 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                            Write(Html.ValidationMessageFor(model => model.alertsubject));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-3 col-xs-12 p-2 alertcopyto_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>Alert Copy To</label>\r\n                                ");
#nullable restore
#line 113 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                           Write(Html.TextBoxFor(m => m.alertcopyto, new {@type="email",@maxlength="50", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 115 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                            Write(Html.ValidationMessageFor(model => model.alertcopyto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-3 col-xs-12 p-2 alertcarboncopyto_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>Alert Carbon Copy To </label>\r\n                                ");
#nullable restore
#line 123 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                           Write(Html.TextBoxFor(m => m.alertcarboncopyto, new {@type="email",@maxlength="50", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 125 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                            Write(Html.ValidationMessageFor(model => model.alertcarboncopyto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-12 col-xs-12 p-2 alertcontent_craftmyapp_container\">\r\n\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group form-group--float-above my-3\" > \r\n\t\t\t\t\t\t\t\t\t\t<label>Alert Content</label>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 133 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                                                       Write(Html.TextAreaFor(m => m.alertcontent, new {@class = "form-control wysiwyg-editor " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"form-group__bar\" ></i>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 137 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                               Write(Html.ValidationMessageFor(model => model.alertcontent));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""alertcontent-error"" class=""help-block"" style=""display: none"" for=""alertcontent""></label>
								</div>
							</div>


							<!--fieldsEndsHere-->	
						</div><!--field_container_row-->


						<div class=""card-block""><!--form_button_card_block-->
							<button type=""button"" onclick=""window.history.back()""  class=""btn btn-secondary cma_cancel_button waves-effect"">Cancel</button>
							<button type=""button"" id=""btnSubmit"" class=""btn cma_primary_button  waves-effect pull-right"">Update Alert Templates</button>
						</div><!--form_button_card_block-->


					</div><!--form_inner_card_block-->
				</div><!--form_inner_card-->
			</div><!--Form_Main_Card-->
");
#nullable restore
#line 156 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--EndFORM-->\r\n\r\n\r\n\t\t\t\r\n\t\t\t \r\n\t\t\t <script type=\"text/javascript\">\r\n\t\t\t\t$(document).ready(function () {\r\n\r\n\r\n\t\t\t\tvar Actions=getAutho(\"AlertTemplates\",\"edit\")\r\n\t\t\t\tif(Actions == undefined){\r\n\t\t\t\twindow.location = \"");
#nullable restore
#line 168 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
                              Write(Url.Action("RoleAuthorizationFailed", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n\t\t\t\t}\r\n\r\n\r\n\t\t\t\t});\r\n\t\t\t\t</script>\r\n\t\t\t\r\n\t\t\t<script>\nvar stralerttype;\n</script>\n");
#nullable restore
#line 178 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
 if (Model != null)
{
if(Model.alerttype != null && Model.alerttype.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nstralerttype=\"");
#nullable restore
#line 183 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
         Write(Model.alerttype);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n</script>\n");
#nullable restore
#line 185 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
}
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d21e44f91c39451880ad24f2b0a8db7fd8aa852b17313", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d21e44f91c39451880ad24f2b0a8db7fd8aa852b18426", async() => {
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
            WriteLiteral("\n<script>$(\'#alertcontent\').trumbowyg();</script>\n\r\n\t\t\t<script>\r\n$(document).ready(function () {\r\n\r\n$.ajax({\r\nurl: \'");
#nullable restore
#line 195 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
 Write(Url.Action("get_lookups_by_entity","lookups"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
dataType: 'json',
data:{id: 'AlertTemplates' },
success: function(data) {



		$.each(data, function(index, optionDataInner) {

				
											if(optionDataInner.fieldname==""alerttype""){
												var ddltarget_alerttype = ""#alerttype""
												$(ddltarget_alerttype).empty();
												$(ddltarget_alerttype).append(""<option value=''>Choose</option>"")
												var options_alerttype = optionDataInner.fielddesc.split(',');
												options_alerttype.forEach(function(option_alerttype){
													if(stralerttype== option_alerttype)
													$(ddltarget_alerttype).append('<option selected value=""' + option_alerttype + '"">' + option_alerttype+ '</option>')
													else
													$(ddltarget_alerttype).append('<option  value=""' + option_alerttype + '"">' + option_alerttype+ '</option>')
												
												})  

											}



		});


},
error: function(jqXHR, textStatus, errorThrown) {
if (JSON.stringify(jqXHR.responseText) == ""\""API Authorization f");
            WriteLiteral("ailed\\\"\")\r\n{\r\nswal({\r\ntitle: \'Failed!\',\r\ntext: jqXHR.responseText,\r\ntype: \'error\',\r\nbuttonsStyling: false,\r\nconfirmButtonClass: \'btn btn-primary\',\r\nallowOutsideClick: false\r\n}).then(function() {\r\nwindow.location = \"");
#nullable restore
#line 237 "C:\Users\lenovo\Downloads\webapp_AIData\Client\Views\AlertTemplates\Update_Alert_Templates.cshtml"
              Write(Url.Action("AuthorizationFailed", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
}) 
}
else
{
swal({
title: 'Contact Administrator !',
text: jqXHR.responseText,
type: 'error',
buttonsStyling: false,
confirmButtonClass: 'btn btn-primary'
}) 
}
}
})
})
</script>
			
			
			
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
                            ");
            WriteLiteral(@"            $(element).closest('.form-group').addClass('has-success');
                                        $(element).addClass('form-control-success');
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
                      ");
            WriteLiteral(@"                              swal({
                                                        title: 'Validation Failed!',
                                                        text: ""Please check your entry"",
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AIData.Models.AlertTemplatesModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
