#pragma checksum "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\users\detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36087d87c9273dfe0096faadb8c5b7e473595cbb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_users_detail), @"mvc.1.0.view", @"/Views/users/detail.cshtml")]
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
#line 3 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\users\detail.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36087d87c9273dfe0096faadb8c5b7e473595cbb", @"/Views/users/detail.cshtml")]
    #nullable restore
    public class Views_users_detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AIData.Models.usersModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/jquery-colorbox/colorbox.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/jquery-colorbox/jquery.colorbox.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/GallaryContent/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/starrr/starrr.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\t\t\t\t\t<!--This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/26/2023 08:36:46 -->\r\n");
#nullable restore
#line 6 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\users\detail.cshtml"
                      
					ViewData["Title"] = "users";
					Layout = "~/Views/Shared/_Layout.cshtml";
					

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 438, "\"", 446, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t     \r\n\t\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 471, "\"", 479, 0);
            EndWriteAttribute();
            WriteLiteral(@">

					      <div id=""cma_printableArea"">
	
                            <div class=""row printablerow""> 
                             
                            <div class=""col-sm-4 col-xs-12 p-2 firstname_craftmyapp_viewcontainer"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>First Name</label><br>
										<span class=""auto_cls_firstname""></span>
										<i class=""form-group__bar"" ></i>
									</div>
								</div>
							</div>
<div class=""col-sm-4 col-xs-12 p-2 lastname_craftmyapp_viewcontainer"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Last Name</label><br>
										<span class=""auto_cls_lastname""></span>
										<i class=""form-group__bar"" ></i>
									</div>
								</div>
							</div>
<div class=""col-sm-4 col-xs-12 p-2 profilepicture_craftmyapp_viewcontainer"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Profil");
            WriteLiteral(@"e Picture</label><br>
										<span class=""auto_cls_profilepicture""></span>
										<i class=""form-group__bar"" ></i>
									</div>
								</div>
							</div>
<div class=""col-sm-4 col-xs-12 p-2 username_craftmyapp_viewcontainer"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>UserName</label><br>
										<span class=""auto_cls_username""></span>
										<i class=""form-group__bar"" ></i>
									</div>
								</div>
							</div>
<div class=""col-sm-4 col-xs-12 p-2 emailid_craftmyapp_viewcontainer"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Email ID</label><br>
										<span class=""auto_cls_emailid""></span>
										<i class=""form-group__bar"" ></i>
									</div>
								</div>
							</div>
<div class=""col-sm-4 col-xs-12 p-2 mobilenumber_craftmyapp_viewcontainer"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Mobile Number");
            WriteLiteral(@"</label><br>
										<span class=""auto_cls_mobilenumber""></span>
										<i class=""form-group__bar"" ></i>
									</div>
								</div>
							</div>
<div class=""col-sm-4 col-xs-12 p-2 userrole_craftmyapp_viewcontainer"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>User Role</label><br>
										<span class=""auto_cls_userrole""></span>
										<i class=""form-group__bar"" ></i>
									</div>
								</div>
							</div>

			 <div class=""col-sm-12 col-xs-12 mt-3""><!--Dependent Allowed Devices Containder Block-->
					<div class=""card card card-blue cma_dependent_band"">
					<div class=""card-head"">
                            <header>
                                 Allowed Devices
                            </header>
                           
                        </div>
<div class=""card-body fluent-card-body"">
						 <div class=""col-12"">
							<div class=""table-responsive-lg"">
							<table id=""alloweddevicesContainer"" c");
            WriteLiteral(@"lass=""table table-bordered mb-0 alloweddevicesContainer"">
							<thead id=""alloweddevicesContainerHead"">
								<th>Device Name</th>
<th>Device ID</th>
<th>Notification ID</th>


							</thead>
							
							<tbody id=""alloweddevicesContainerBody""> 
							</tbody>
							
							</table>
							</div>
								</div>
						</div>
					  </div>
				  </div><!--Dependent Allowed Devices Containder Block-->
			 
            

											 
											 
                            </div>
                         </div>
						 <div class=""row"">
					            <div class=""col-sm-12 col-xs-12"">
					                <input type=""button"" class=""btn cma_primary_button  waves-effect pull-right"" onclick=""printDiv('cma_printableArea')"" value=""Print"" />

                                    <button type=""button"" id=""btnSubmit"" onclick=""window.history.back()"" class=""btn btn-secondary cma_cancel_button waves-effect"">Back</button>            

					            </div>
					        </div>					
 ");
            WriteLiteral(" \r\n                    </div>\r\n\t\t\t\t\t\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36087d87c9273dfe0096faadb8c5b7e473595cbb9886", async() => {
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36087d87c9273dfe0096faadb8c5b7e473595cbb11020", async() => {
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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36087d87c9273dfe0096faadb8c5b7e473595cbb12080", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "36087d87c9273dfe0096faadb8c5b7e473595cbb13215", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
					 
					<script type=""text/javascript"">
                     function printDiv(divName) {
                        var printContents = document.getElementById(divName).innerHTML;
                        var originalContents = document.body.innerHTML;

                        document.body.innerHTML = printContents;

                        window.print();

                        document.body.innerHTML = originalContents;
                    }
                    function fill_users_view_data(){

                       var  usersid = getUrlVars()[""id""];
                                            $(""#viewDetails_Auto"").show()
											$("".auto_checker_action"").hide()
                                                $.ajax({
												url: '");
#nullable restore
#line 152 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\users\detail.cshtml"
                                                 Write(Url.Action("getById_sp_all_users"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
												dataType: 'json',
												data:{usersid: usersid },
												success: function(data) {

												var obj=data.Table[0]
													for (var key in obj) {
													
															$("".auto_cls_""+key).html(obj[key]);
														 	
															if(key=='profilepicture'){
																			$('.auto_cls_profilepicture').empty()
                                                                            if(obj[key] !=null)  {            
                                                                          
                                                                            var uploaded_profilepicture = obj[key].split('|');
                                                                            var iterate = 0;
                                                                            for (var i = 0; i < uploaded_profilepicture.length; i++) {


	                                                                            if (uploaded_profilepict");
            WriteLiteral(@"ure[i] != """") {
		                                                                            iterate = iterate + 1;
		                                                                            if (iterate == 1)
			                                                                            $('.auto_cls_profilepicture').append('<a href=' + uploaded_profilepicture[i] + ' class=""imgprofilepicture auto_clr_profilepicture""><img  src=' + uploaded_profilepicture[i] + ' width=""100px"" /></a>')
		                                                                            else

			                                                                            $('.auto_cls_profilepicture').append('<div style=""display:none""> <a href=' + uploaded_profilepicture[i] + ' class=""imgprofilepicture auto_clr_profilepicture""><img  src=' + uploaded_profilepicture[i] + ' width=""100px"" /></a></div>')
		 
	                                                                            }


                                          ");
            WriteLiteral(@"                                  }

                                                                            $('body').on('click', 'a.imgprofilepicture', function (e) {
                                                                            e.preventDefault();
                                                                            $('.imgprofilepicture').colorbox({ rel: '.imgprofilepicture', width: ""90%"", height: ""80%"" });
                                                                            $.colorbox({ open: true });
                                                                            });




                                                                                    }


																	}
if(key=='automaton_users_alloweddevices'){
																			$('#alloweddevicesContainerBody').empty()
                                                                            if(obj[key]!=null && obj[key] !="""")
																			   $('#alloweddevicesContainerBody').a");
            WriteLiteral(@"ppend(get_dependent_table(obj[key]))
																	}


													}
												}

												})

                   }
                   

					$(document).ready(function () {


					fill_users_view_data()


					var Actions=getAutho(""users"",""list"")
					if(Actions == undefined){
					window.location = """);
#nullable restore
#line 220 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\users\detail.cshtml"
                                  Write(Url.Action("RoleAuthorizationFailed", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n\t\t\t\t\t}\r\n\r\n\r\n\r\n\r\n\t\t\t\t\t});\r\n\t\t\t\t\t \r\n\t\t\t\t\t</script>\r\n\t\t\t\t\t \r\n\t\t\t\t\t\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AIData.Models.usersModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
