#pragma checksum "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "42a57dd45e9e95ff23e3059ac2cd85bb8510beca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_users_Login), @"mvc.1.0.view", @"/Areas/Admin/Views/users/Login.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a57dd45e9e95ff23e3059ac2cd85bb8510beca", @"/Areas/Admin/Views/users/Login.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_users_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DineandDiscover.Models.userloginModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/jquery/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/jquery/additional-methods.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\t\t\t\t<!-- This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/15/2023 13:37:36-->\r\n");
#nullable restore
#line 4 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
                  
				ViewData["Title"] = "Login";
				Layout = "~/Views/Shared/_LoginLayout.cshtml";
				

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<div class=\"login\">\r\n");
#nullable restore
#line 10 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
                 using(Html.BeginForm("Login", "users", FormMethod.Post, new { enctype="multipart/form-data", @id = "formId"}))
				{

                

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
           Write(Html.HiddenFor(m => m.clientipaddress));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
           Write(Html.HiddenFor(m => m.devicename));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
           Write(Html.HiddenFor(m => m.latlan));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
           Write(Html.HiddenFor(m => m.browsername));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
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
#line 28 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
                   Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 32 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
                 if(TempData["message"] != null)
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
#line 41 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
                   Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 45 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
				}

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
                 if(TempData["successmessage"] != null)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"				<div class=""row"">
				<div class=""col-sm-12 col-xs-12"">
				<div class=""alert alert-success alert-dismissible "">
				<button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
				<span aria-hidden=""true"">x</span>
				</button>
				Info :  ");
#nullable restore
#line 54 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
                   Write(TempData["successmessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 58 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t  \t<div class=\"col-sm-12 col-xs-12\">\r\n                  <div class=\"form-group\">\r\n                    <label for=\"username\">Username</label>\r\n                    <div class=\"input-group\">\r\n                       ");
#nullable restore
#line 63 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
                  Write(Html.TextBoxFor(m => m.username, new {@type="search",@autocomplete="off",@maxlength="128", @class = "form-control   required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
					 
                      <span class=""input-group-addon"">
                        <i class=""md md-person""></i>
                     </span>
                    </div>
                  </div>
                </div>
				<div class=""col-sm-12 col-xs-12"">
                  <div class=""form-group"">
                    <label for=""userpassword"">Password</label>
                    <div class=""input-group"">
                       ");
#nullable restore
#line 75 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
                  Write(Html.TextBoxFor(m => m.userpassword, new {@type="password",@autocomplete="off",@maxlength="50", @class = "form-control required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                      <span class=\"input-group-addon\">\r\n                        <i class=\"md md-remove-red-eye\"></i>\r\n                    </span>\r\n                    </div>\r\n                  </div>\r\n                </div>\r\n");
            WriteLiteral(@"                         <!--end .col -->
	                    <div class=""col-sm-12 col-xs-12 text-center"">
		                    <button class=""btn cma_primary_button"" type=""submit"">Sign In</button>
	                    </div>
	                    <!--end .col -->
                        <!--end .col -->
");
            WriteLiteral("                        <div class=\"col-sm-12 col-xs-12 text-center\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 3499, "\"", 3543, 1);
#nullable restore
#line 93 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
WriteAttributeValue("", 3506, Url.Action("forgotpassword","users"), 3506, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("  class=\"btn cma_secondary_button\">Forgot Password ?</a>\r\n\t                    </div>\r\n\t                    <!--end .col -->\r\n");
#nullable restore
#line 96 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\Login.cshtml"
                     
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t</div>\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42a57dd45e9e95ff23e3059ac2cd85bb8510beca11552", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "42a57dd45e9e95ff23e3059ac2cd85bb8510beca12600", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
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
                                        $(element).addClass('form-control-success');
                                        $(element).removeClass('form-control-error');
  ");
            WriteLiteral(@"                                      },
                                        errorElement: 'span',
                                        errorClass: 'help-block'
                                        });
										
										
										 $(""#btnSubmit"").click(function(){
                                                if ($(""#formId"").valid()){
                                                        $("".page-loader"").show()

														
                                                        $(""#formId"").submit();
                                                }else{
                                                    validator.focusInvalid();
                                                    swal({
                                                        title: 'Validation Failed!',
                                                        text: ""Please check your entry"",
                                                        type: 'error',
                                       ");
            WriteLiteral(@"                 buttonsStyling: false,
                                                        confirmButtonClass: 'btn btn-primary'
                                                    })
                                                }
                                            })
				})
				var str = """";
				</script>
				<script>
				$('form:first *:input[type!=hidden]:first').focus();
                    if (navigator.geolocation) {
                    navigator.geolocation.getCurrentPosition(showPosition);
                    }

 
                    $(""#devicename"").val(navigator.platform)

                    function showPosition(position) {
                    $(""#latlan"").val(""Latitude: "" + position.coords.latitude + "";Longitude: "" + position.coords.longitude)
                    }

                    $.getJSON(""https://api.ipify.org?format=json"",
                    function (data) {

                    // Setting text of element P with id gfg 
	                    $(""");
            WriteLiteral("#clientipaddress\").val(data.ip);\r\n                    })\r\n\r\n\r\n\t\t\t\t</script>\r\n\t\t\t\t\n");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DineandDiscover.Models.userloginModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
