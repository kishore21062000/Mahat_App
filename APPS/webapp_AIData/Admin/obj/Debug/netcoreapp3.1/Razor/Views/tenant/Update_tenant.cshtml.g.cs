#pragma checksum "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59e880785c34ff7c420cd220993c0706a2c50c24"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_tenant_Update_tenant), @"mvc.1.0.view", @"/Views/tenant/Update_tenant.cshtml")]
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
#line 3 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59e880785c34ff7c420cd220993c0706a2c50c24", @"/Views/tenant/Update_tenant.cshtml")]
    #nullable restore
    public class Views_tenant_Update_tenant : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AIData.Models.tenantModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/jquery-colorbox/colorbox.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/jquery-colorbox/jquery.colorbox.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\t\t\t<!-- This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/26/2023 08:36:47 -->\r\n");
#nullable restore
#line 6 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
              
			ViewData["Title"] = "Update Users";

			Layout = "~/Views/Shared/_Layout.cshtml";
			
			

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
             using(Html.BeginForm("Update_tenant", "tenant", FormMethod.Post, new { enctype="multipart/form-data", @id = "formId"}))
			{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""card card-block contCard""><!--Form_Main_Card-->
				<div class=""mobileHeader""><!--form_card_header-->
					<div class=""row"">
						<div class=""col-sm-12 col-xs-12"">
							<h4 class=""formHdr"">Update Users</h4>
						</div>
					</div>
				</div><!--form_card_header-->
				<!--form_error_display-->
");
#nullable restore
#line 25 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
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
#line 33 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                   Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 37 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t \r\n\t\t\t\t\r\n\t\t\t\t<!--form_error_display-->\r\n\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 1326, "\"", 1334, 0);
            EndWriteAttribute();
            WriteLiteral("><!--form_inner_card-->\r\n\t\t\t\t\t<div class=\"card-block\"><!--form_inner_card_block-->\r\n\t\t\t\t\t    ");
#nullable restore
#line 45 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                   Write(Html.HiddenFor(m => m.tenantid));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
						 

						
						<div class=""row""><!--field_container_row-->
							<!--fieldsStartsHere-->
								
								<div class=""col-sm-4 col-xs-12 p-2 businessname_craftmyapp_container"">
						<div>
							<div class=""form-group"" > 
								<label>Business  Name <b class=""iconRed"">*</b></label>
                                ");
#nullable restore
#line 56 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                           Write(Html.TextBoxFor(m => m.businessname, new {@type="text",@maxlength="50", @class = "form-control form-control-lg required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 58 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                            Write(Html.ValidationMessageFor(model => model.businessname));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
					</div>
<div class=""col-sm-4 col-xs-12 p-2 businessemail_craftmyapp_container"">
						<div>
							<div class=""form-group"" > 
								<label>Business  Email <b class=""iconRed"">*</b></label>
                                ");
#nullable restore
#line 66 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                           Write(Html.TextBoxFor(m => m.businessemail, new {@type="email",@maxlength="128", @class = "form-control form-control-lg required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 68 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                            Write(Html.ValidationMessageFor(model => model.businessemail));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
					</div>
<div class=""col-sm-4 col-xs-12 p-2 businessphone_craftmyapp_container"">
						<div>
							<div class=""form-group"" > 
								<label>Business  Phone <b class=""iconRed"">*</b></label>
                                ");
#nullable restore
#line 76 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                           Write(Html.TextBoxFor(m => m.businessphone, new {@type="text",@maxlength="20", @class = "form-control form-control-lg required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 78 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                            Write(Html.ValidationMessageFor(model => model.businessphone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-4 col-xs-12 p-2 businesswebsite_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>Business  Website</label>\r\n                                ");
#nullable restore
#line 86 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                           Write(Html.TextBoxFor(m => m.businesswebsite, new {@type="url",@maxlength="256", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 88 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                            Write(Html.ValidationMessageFor(model => model.businesswebsite));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
					</div>
<div class=""col-sm-4 col-xs-12 p-2 organizationlogo_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Organization  Logo</label>
										<br><input type=""file"" multiple accept=""image/*""  id=""organizationlogo"" name=""organizationlogo"">

										<div id=""organizationlogoDisp""");
            BeginWriteAttribute("href", " href=\"", 3734, "\"", 3741, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"form-group__bar\" ></i>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 101 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                               Write(Html.ValidationMessageFor(model => model.organizationlogo));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""organizationlogo-error"" class=""help-block"" style=""display: none"" for=""organizationlogo""></label>
								</div>
							</div>
<div class=""col-sm-4 col-xs-12 p-2 numberofemployees_craftmyapp_container"">
						<div>
							<div class=""form-group"" > 
								<label>Number of  Employees</label>
                                ");
#nullable restore
#line 109 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                           Write(Html.TextBoxFor(m => m.numberofemployees, new {@type="text",@min="0",@max="99999999", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 111 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                            Write(Html.ValidationMessageFor(model => model.numberofemployees));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
					</div>
 
				<div class=""col-sm-12 col-xs-12 mt-3""><!--form_group_div_block-->
					<div class=""card card-blue card-section cma_section_band"">
							<div class=""card-head"">
								<header>Address</header>
							</div>
							<div class=""card-body card-container-Padding-NoShadow"">
								<div class=""row"">
										<div class=""col-sm-4 col-xs-12 p-2 addressline1_craftmyapp_container"">
						<div>
							<div class=""form-group"" > 
								<label>Address Line1</label>
                                ");
#nullable restore
#line 127 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                           Write(Html.TextBoxFor(m => m.addressline1, new {@type="text",@maxlength="256", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 129 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                            Write(Html.ValidationMessageFor(model => model.addressline1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-4 col-xs-12 p-2 addressline2_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>Address Line2</label>\r\n                                ");
#nullable restore
#line 137 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                           Write(Html.TextBoxFor(m => m.addressline2, new {@type="text",@maxlength="256", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 139 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                            Write(Html.ValidationMessageFor(model => model.addressline2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-4 col-xs-12 p-2 city_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>City</label>\r\n                                ");
#nullable restore
#line 147 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                           Write(Html.TextBoxFor(m => m.city, new {@type="text",@maxlength="256", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 149 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                            Write(Html.ValidationMessageFor(model => model.city));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-4 col-xs-12 p-2 state_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>State</label>\r\n                                ");
#nullable restore
#line 157 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                           Write(Html.TextBoxFor(m => m.state, new {@type="text",@maxlength="256", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 159 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                            Write(Html.ValidationMessageFor(model => model.state));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-4 col-xs-12 p-2 zip_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>Zip</label>\r\n                                ");
#nullable restore
#line 167 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                           Write(Html.TextBoxFor(m => m.zip, new {@type="text",@maxlength="256", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 169 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                            Write(Html.ValidationMessageFor(model => model.zip));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
					</div>
<div class=""col-sm-4 col-xs-12 p-2 country_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Country</label>
										<select name=""country"" id=""country"" class=""form-control  ""></select>

									</div>
									");
#nullable restore
#line 180 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                               Write(Html.ValidationMessageFor(model => model.country));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""country-error"" class=""help-block"" style=""display: none"" for=""country""></label>
								</div>
							</div>


								</div>
							</div>
					</div>
				</div><!--form_group_div_block-->
			 


							<!--fieldsEndsHere-->	
						</div><!--field_container_row-->


						<div class=""card-block""><!--form_button_card_block-->
							<button type=""button"" onclick=""window.history.back()""  class=""btn btn-secondary cma_cancel_button waves-effect"">Cancel</button>
							<button type=""button"" id=""btnSubmit"" class=""btn cma_primary_button  waves-effect pull-right"">Update Users</button>
						</div><!--form_button_card_block-->


					</div><!--form_inner_card_block-->
				</div><!--form_inner_card-->
			</div><!--Form_Main_Card-->
");
#nullable restore
#line 206 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--EndFORM-->\r\n\r\n\r\n\t\t\t\r\n\t\t\t \r\n\t\t\t <script type=\"text/javascript\">\r\n\t\t\t\t$(document).ready(function () {\r\n\r\n\r\n\t\t\t\tvar Actions=getAutho(\"tenant\",\"edit\")\r\n\t\t\t\tif(Actions == undefined){\r\n\t\t\t\twindow.location = \"");
#nullable restore
#line 218 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                              Write(Url.Action("RoleAuthorizationFailed", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n\t\t\t\t}\r\n\r\n\r\n\t\t\t\t});\r\n\t\t\t\t</script>\r\n\t\t\t\r\n\t\t\t<script>\nvar strorganizationlogo;\n</script>\n");
#nullable restore
#line 228 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
 if (Model != null)
{
if(Model.organizationlogo != null && Model.organizationlogo.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nvar uploaded_organizationlogo = \"");
#nullable restore
#line 233 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
                            Write(Model.organizationlogo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""".split('|');
                                            var iterate = 0;
                                            for (var i = 0; i < uploaded_organizationlogo.length; i++) {


	                                            if (uploaded_organizationlogo[i] != """") {
		                                            iterate = iterate + 1;
		                                            if (iterate == 1)
			                                            $('#organizationlogoDisp').append('<a href=' + uploaded_organizationlogo[i] + ' class=""imgorganizationlogo auto_clr_photo""><img  src=' + uploaded_organizationlogo[i] + ' width=""100px"" /></a>')
		                                            else

			                                            $('#organizationlogoDisp').append('<div style=""display:none""> <a href=' + uploaded_organizationlogo[i] + ' class=""imgorganizationlogo auto_clr_photo""><img  src=' + uploaded_organizationlogo[i] + ' width=""100px"" /></a></div>')
		 
	                                       ");
            WriteLiteral(@"     }


                                            }
$('body').on('click', 'a.imgorganizationlogo', function (e) {
                            e.preventDefault();
                            $('.imgorganizationlogo').colorbox({ rel: '.imgorganizationlogo', width: ""90%"", height: ""80%"" });
                            $.colorbox({ open: true });
                            });
</script>
");
#nullable restore
#line 256 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
}
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "59e880785c34ff7c420cd220993c0706a2c50c2422034", async() => {
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
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "59e880785c34ff7c420cd220993c0706a2c50c2423165", async() => {
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
            WriteLiteral(" \n<script>\n$(document).ready(function () {\n$(\"#numberofemployees\").autoNumeric(\'init\',{aSep: \'\',vMin: \'0\',vMax: \'99999999\'})\n})\n</script>\n<script>\nvar strcountry;\n</script>\n");
#nullable restore
#line 268 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
 if (Model != null)
{
if(Model.country != null && Model.country.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nstrcountry=\"");
#nullable restore
#line 273 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
       Write(Model.country);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n</script>\n");
#nullable restore
#line 275 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
}
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<script>\r\n$(document).ready(function () {\r\n\r\n$.ajax({\r\nurl: \'");
#nullable restore
#line 282 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
 Write(Url.Action("get_lookups_by_entity","lookups"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
dataType: 'json',
data:{id: 'tenant' },
success: function(data) {



		$.each(data, function(index, optionDataInner) {

				
											if(optionDataInner.fieldname==""country""){
												var ddltarget_country = ""#country""
												$(ddltarget_country).empty();
												$(ddltarget_country).append(""<option value=''>Choose</option>"")
												var options_country = optionDataInner.fielddesc.split(',');
												options_country.forEach(function(option_country){
													if(strcountry== option_country)
													$(ddltarget_country).append('<option selected value=""' + option_country + '"">' + option_country+ '</option>')
													else
													$(ddltarget_country).append('<option  value=""' + option_country + '"">' + option_country+ '</option>')
												
												})  

											}



		});


},
error: function(jqXHR, textStatus, errorThrown) {
if (JSON.stringify(jqXHR.responseText) == ""\""API Authorization failed\"""")
{
swal({
title: 'Failed!',");
            WriteLiteral("\ntext: jqXHR.responseText,\r\ntype: \'error\',\r\nbuttonsStyling: false,\r\nconfirmButtonClass: \'btn btn-primary\',\r\nallowOutsideClick: false\r\n}).then(function() {\r\nwindow.location = \"");
#nullable restore
#line 324 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\tenant\Update_tenant.cshtml"
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

			
			
            

			
			
<script>
					$(document).ready(function () {
						 
						$(""#tenantid"").change(function(){
								 
						})
					

					});
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AIData.Models.tenantModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
