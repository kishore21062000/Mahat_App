#pragma checksum "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "661e10b37079d89f62be90e2a72550e73a1560db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_users_Update_Profile), @"mvc.1.0.view", @"/Areas/Client/Views/users/Update_Profile.cshtml")]
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
#line 3 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"661e10b37079d89f62be90e2a72550e73a1560db", @"/Areas/Client/Views/users/Update_Profile.cshtml")]
    #nullable restore
    public class Areas_Client_Views_users_Update_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Gmailconsole.Models.usersModel>
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
            WriteLiteral("\r\n\t\t\t<!-- This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 09/12/2023 09:49:24 -->\r\n");
#nullable restore
#line 6 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
              
			ViewData["Title"] = "Update Profile";

			Layout = "~/Views/Shared/_Layout.cshtml";
			
			

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
             using(Html.BeginForm("Update_Profile", "users", FormMethod.Post, new { enctype="multipart/form-data", @id = "formId"}))
			{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""card card-block contCard""><!--Form_Main_Card-->
				<div class=""mobileHeader""><!--form_card_header-->
					<div class=""row"">
						<div class=""col-sm-12 col-xs-12"">
							<h4 class=""formHdr"">Update Profile</h4>
						</div>
					</div>
				</div><!--form_card_header-->
				<!--form_error_display-->
");
#nullable restore
#line 25 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
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
#line 33 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                   Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 37 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t \r\n\t\t\t\t\r\n\t\t\t\t<!--form_error_display-->\r\n\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 1335, "\"", 1343, 0);
            EndWriteAttribute();
            WriteLiteral("><!--form_inner_card-->\r\n\t\t\t\t\t<div class=\"card-block\"><!--form_inner_card_block-->\r\n\t\t\t\t\t    ");
#nullable restore
#line 45 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                   Write(Html.HiddenFor(m => m.usersid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t \r\n\r\n\t\t\t\t\t\t");
#nullable restore
#line 48 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                   Write(Html.HiddenFor(m => m.tenantid));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
						<div class=""row""><!--field_container_row-->
							<!--fieldsStartsHere-->
								
								<div class=""col-sm-6 col-xs-12 p-2 firstname_craftmyapp_container"">
						<div>
							<div class=""form-group"" > 
								<label>First Name <b class=""iconRed"">*</b></label>
                                ");
#nullable restore
#line 56 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                           Write(Html.TextBoxFor(m => m.firstname, new {@type="text",@maxlength="50", @class = "form-control form-control-lg required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 58 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                            Write(Html.ValidationMessageFor(model => model.firstname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-6 col-xs-12 p-2 lastname_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>Last Name</label>\r\n                                ");
#nullable restore
#line 66 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                           Write(Html.TextBoxFor(m => m.lastname, new {@type="text",@maxlength="50", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 68 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                            Write(Html.ValidationMessageFor(model => model.lastname));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
					</div>
<div class=""col-sm-6 col-xs-12 p-2 profilepicture_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Profile Picture</label>
										<br><input type=""file"" accept=""image/*""  id=""profilepicture"" name=""profilepicture"">

										<div id=""profilepictureDisp""");
            BeginWriteAttribute("href", " href=\"", 2796, "\"", 2803, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"form-group__bar\" ></i>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 81 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                               Write(Html.ValidationMessageFor(model => model.profilepicture));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""profilepicture-error"" class=""help-block"" style=""display: none"" for=""profilepicture""></label>
								</div>
							</div>
<div class=""col-sm-6 col-xs-12 p-2 username_craftmyapp_container"">
						<div>
							<div class=""form-group"" > 
								<label>UserName <b class=""iconRed"">*</b></label>
                                ");
#nullable restore
#line 89 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                           Write(Html.TextBoxFor(m => m.username, new {@type="text",@maxlength="150", @class = "form-control form-control-lg required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 91 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                            Write(Html.ValidationMessageFor(model => model.username));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-6 col-xs-12 p-2 emailid_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>Email ID <b class=\"iconRed\">*</b></label>\r\n                                ");
#nullable restore
#line 99 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                           Write(Html.TextBoxFor(m => m.emailid, new {@type="email",@maxlength="128", @class = "form-control form-control-lg required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 101 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                            Write(Html.ValidationMessageFor(model => model.emailid));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
					</div>
<div class=""col-sm-6 col-xs-12 p-2 mobilenumber_craftmyapp_container"">
						<div>
							<div class=""form-group"" > 
								<label>Mobile Number <b class=""iconRed"">*</b></label>
                                ");
#nullable restore
#line 109 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                           Write(Html.TextBoxFor(m => m.mobilenumber, new {@type="text",@maxlength="20", @class = "form-control form-control-lg required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 111 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                            Write(Html.ValidationMessageFor(model => model.mobilenumber));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
					</div>
<div class=""col-sm-6 col-xs-12 p-2 userrole_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>User Role <b class=""iconRed"">*</b></label>
										<select name=""userrole"" id=""userrole""  class=""form-control select2 select2-list  required""></select>

									</div>
									");
#nullable restore
#line 122 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                               Write(Html.ValidationMessageFor(model => model.userrole));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""userrole-error"" class=""help-block"" style=""display: none"" for=""userrole""></label>
								</div>
							</div>
 <div class=""col-sm-12 col-xs-12 mt-3""><div class=""card card card-blue cma_dependent_band""><!--Dependent Allowed Devices Containder Block-->
                        <div class=""card-head"">
                            <header>
                                 Allowed Devices
                            </header>
                            <header>
                                <button type=""button"" class=""btn cma_secondary_button btn-add-alloweddevices pull-left""><span class=""fa fa-plus""></span> Add Allowed Devices</button>
                            </header>

                        </div>
                        <div class=""card-body p-0 form-elements-group-container fluent-card-body"">
                            <div id=""alloweddevicesContainer"" class=""alloweddevicesContainer"">
							</div>

            
                        </div>
                   ");
            WriteLiteral(@" </div></div><!--Dependent Allowed Devices Containder Block-->
			 


							<!--fieldsEndsHere-->	
						</div><!--field_container_row-->


						<div class=""card-block""><!--form_button_card_block-->
							<button type=""button"" onclick=""window.history.back()""  class=""btn btn-secondary cma_cancel_button waves-effect"">Cancel</button>
							<button type=""button"" id=""btnSubmit"" class=""btn cma_primary_button  waves-effect pull-right"">Update Profile</button>
						</div><!--form_button_card_block-->


					</div><!--form_inner_card_block-->
				</div><!--form_inner_card-->
			</div><!--Form_Main_Card-->
");
#nullable restore
#line 159 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--EndFORM-->\r\n\r\n\r\n\t\t\t\r\n\t\t\t \r\n\t\t\t \r\n\t\t\t\r\n\t\t\t<script>\nvar strprofilepicture;\n</script>\n");
#nullable restore
#line 170 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
 if (Model != null)
{
if(Model.profilepicture != null && Model.profilepicture.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nvar uploaded_profilepicture = \"");
#nullable restore
#line 175 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                          Write(Model.profilepicture);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""".split('|');
                                            var iterate = 0;
                                            for (var i = 0; i < uploaded_profilepicture.length; i++) {


	                                            if (uploaded_profilepicture[i] != """") {
		                                            iterate = iterate + 1;
		                                            if (iterate == 1)
			                                            $('#profilepictureDisp').append('<a href=' + uploaded_profilepicture[i] + ' class=""imgprofilepicture auto_clr_photo""><img  src=' + uploaded_profilepicture[i] + ' width=""100px"" /></a>')
		                                            else

			                                            $('#profilepictureDisp').append('<div style=""display:none""> <a href=' + uploaded_profilepicture[i] + ' class=""imgprofilepicture auto_clr_photo""><img  src=' + uploaded_profilepicture[i] + ' width=""100px"" /></a></div>')
		 
	                                            }


        ");
            WriteLiteral(@"                                    }
$('body').on('click', 'a.imgprofilepicture', function (e) {
                            e.preventDefault();
                            $('.imgprofilepicture').colorbox({ rel: '.imgprofilepicture', width: ""90%"", height: ""80%"" });
                            $.colorbox({ open: true });
                            });
</script>
");
#nullable restore
#line 198 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
}
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "661e10b37079d89f62be90e2a72550e73a1560db18445", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "661e10b37079d89f62be90e2a72550e73a1560db19576", async() => {
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
            WriteLiteral(" \n<script>\nvar struserrole;\n</script>\n");
#nullable restore
#line 205 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
 if (Model != null)
{
if(Model.userrole != null && Model.userrole.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nstruserrole=\"");
#nullable restore
#line 210 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
        Write(Model.userrole);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n</script>\n");
#nullable restore
#line 212 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
}
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\r\n\t\t\t<script>\r\nfunction fill_userrole()\r\n{\r\n$.ajax({\r\nurl: \'");
#nullable restore
#line 220 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
 Write(Url.Action("get_roles","users"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
dataType: 'json',
success: function(data) {

       var ddltarget_userrole=""#userrole""
	    $(ddltarget_userrole).empty();
		$(ddltarget_userrole).append(""<option value=''>Choose</option>"")

		$.each(data, function(index, optionDataInner) {

				
									if(struserrole== optionDataInner.rolename)
									   $(ddltarget_userrole).append('<option selected value=""' + optionDataInner.rolename + '"">' + optionDataInner.rolename+ '</option>')
									else
									   $(ddltarget_userrole).append('<option  value=""' + optionDataInner.rolename + '"">' + optionDataInner.rolename+ '</option>')
								
							  		$(""#userrole"").trigger(""change"")
							  



		});

		
		$(""#userrole option[value='Client Users']"").remove();


},
error: function(jqXHR, textStatus, errorThrown) {
if (JSON.stringify(jqXHR.responseText) == ""\""API Authorization failed\"""")
{
swal({
title: 'Failed!',
text: jqXHR.responseText,
type: 'error',
buttonsStyling: false,
confirmButtonClass: 'btn btn-primary',
all");
            WriteLiteral("owOutsideClick: false\r\n}).then(function() {\r\nwindow.location = \"");
#nullable restore
#line 259 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
              Write(Url.Action("AuthorizationFailed", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n}) \r\n}\r\nelse\r\n{\r\nswal({\r\ntitle: \'Contact Administrator !\',\r\ntext: jqXHR.responseText,\r\ntype: \'error\',\r\nbuttonsStyling: false,\r\nconfirmButtonClass: \'btn btn-primary\'\r\n}) \r\n}\r\n}\r\n})\r\n\t\t  }\r\n</script>\n\r\n\t\t\t<script>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\tvar str_tenantid=\"");
#nullable restore
#line 278 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                                                                     Write(Context.Session.GetString("Gmailconsolechoosedtenantid"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t\t$(\"#tenantid\").val(\"");
#nullable restore
#line 279 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                                                                       Write(Context.Session.GetString("Gmailconsolechoosedtenantid"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""")
													</script>
			<script>
				$(document).ready(function () {
				  //fillalloweddevices()
				$("".btn-add-alloweddevices"").click(function () {


				var index = Math.floor(Math.random() * (100000 - 1 + 1) + 57);
			 $("".alloweddevices"").removeClass('showthelables');
               $("".btn-remove-row-alloweddevices"").removeClass('btn-remove-row');
				$(""#alloweddevicesContainer"").prepend(
				'<div class=""row m-t-10 alloweddevices dependentContainerBorder showthelables"" id=""alloweddevices' + index + '"">' +

				'<div class=""col-sm-2 col-xs-12 p-2 devicename_craftmyapp_container"">'+
						'<div>'+
							'<div class=""form-group"" >'+ 
								'<label>Device Name</label>'+
                                    '<input  name=""devicename' + index + '"" id=""devicename' + index + '""  type=""text""  maxlength=""1024"" class=""devicename form-control--active form-control form-control-lg "" />' +

							'</div>'+
							
						'</div>'+
					'</div>'+
'<div class=""col-sm-2 col-xs-12 p-2 devic");
            WriteLiteral(@"eid_craftmyapp_container"">'+
						'<div>'+
							'<div class=""form-group"" >'+ 
								'<label>Device ID</label>'+
                                    '<input  name=""deviceid' + index + '"" id=""deviceid' + index + '""  type=""text""  maxlength=""1024"" class=""deviceid form-control--active form-control form-control-lg "" />' +

							'</div>'+
							
						'</div>'+
					'</div>'+
'<div class=""col-sm-2 col-xs-12 p-2 notificationid_craftmyapp_container"">'+
						'<div>'+
							'<div class=""form-group"" >'+ 
								'<label>Notification ID</label>'+
                                    '<input  name=""notificationid' + index + '"" id=""notificationid' + index + '""  type=""text""  maxlength=""1024"" class=""notificationid form-control--active form-control form-control-lg "" />' +

							'</div>'+
							
						'</div>'+
					'</div>'+
 

				' <div class=""col-sm-1""><button type=""button"" class=""btn removebtn' + index + ' btn-danger btn-remove-row btn-remove-row-alloweddevices""><span class=""fa fa-times""></spa");
            WriteLiteral(@"n></button></div>' +
				'</div>'
				);

				 

				});
				$('body').on('click', '.btn-remove-row-alloweddevices', function (e) {
				    $(this).parent().parent().remove(); 
                    $("".alloweddevices"").removeClass('showthelables');
                    $("".btn-remove-row-alloweddevices"").removeClass('btn-remove-row');
                    var cmafirstcontainer=$('.alloweddevicesContainer :first-child').attr(""id"")
                    $('#'+cmafirstcontainer).addClass('showthelables');
                    $('.removebtn'+cmafirstcontainer.replace('alloweddevices','')).addClass('btn-remove-row');
				});
				})
				</script>
			 
<script>
$(document).ready(function () {
$.ajax({
url: '");
#nullable restore
#line 346 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
 Write(Url.Action("getById_alloweddevices"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\ndataType: \'json\',\r\ndata:{\"usersid\":\"");
#nullable restore
#line 348 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
            Write(Model.usersid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""},
success: function(data) {
 
var resultSet = data;
$.each(resultSet, function(key, obj) {


 			var index = Math.floor(Math.random() * (100000 - 1 + 1) + 57);
			 $("".alloweddevices"").removeClass('showthelables');
               $("".btn-remove-row-alloweddevices"").removeClass('btn-remove-row');
				$(""#alloweddevicesContainer"").prepend(
				'<div class=""row m-t-10 alloweddevices dependentContainerBorder showthelables"" id=""alloweddevices' + index + '"">' +

				'<div class=""col-sm-2 col-xs-12 p-2 devicename_craftmyapp_container"">'+
						'<div>'+
							'<div class=""form-group"" >'+ 
								'<label>Device Name</label>'+
                                    '<input value=""'+(obj.devicename?obj.devicename:'')+'"" name=""devicename' + index + '"" id=""devicename' + index + '""  type=""text""  maxlength=""1024"" class=""devicename form-control--active form-control form-control-lg "" />' +

							'</div>'+
							
						'</div>'+
					'</div>'+
'<div class=""col-sm-2 col-xs-12 p-2 deviceid_craftmyapp_con");
            WriteLiteral(@"tainer"">'+
						'<div>'+
							'<div class=""form-group"" >'+ 
								'<label>Device ID</label>'+
                                    '<input value=""'+(obj.deviceid?obj.deviceid:'')+'"" name=""deviceid' + index + '"" id=""deviceid' + index + '""  type=""text""  maxlength=""1024"" class=""deviceid form-control--active form-control form-control-lg "" />' +

							'</div>'+
							
						'</div>'+
					'</div>'+
'<div class=""col-sm-2 col-xs-12 p-2 notificationid_craftmyapp_container"">'+
						'<div>'+
							'<div class=""form-group"" >'+ 
								'<label>Notification ID</label>'+
                                    '<input value=""'+(obj.notificationid?obj.notificationid:'')+'"" name=""notificationid' + index + '"" id=""notificationid' + index + '""  type=""text""  maxlength=""1024"" class=""notificationid form-control--active form-control form-control-lg "" />' +

							'</div>'+
							
						'</div>'+
					'</div>'+
 

				' <div class=""col-sm-1""><button type=""button"" class=""btn btn-danger btn-remove-row btn-rem");
            WriteLiteral(@"ove-row-alloweddevices""><span class=""fa fa-times""></span></button></div>' +
				'</div>'
				);

				 
				
				

				





});
},
	error: function(jqXHR, textStatus, errorThrown) {
	if (JSON.stringify(jqXHR.responseText) == ""\""API Authorization failed\"""")
	{
	swal({
	title: 'Failed!',
	text: jqXHR.responseText,
	type: 'error',
	buttonsStyling: false,
	confirmButtonClass: 'btn btn-primary',
	allowOutsideClick: false
	}).then(function() {
	window.location = """);
#nullable restore
#line 420 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
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
			  function getalloweddevices() {
		 
				 	$(""#alloweddevices"").val("""");
					var alloweddevicesModel = [];

				
					
					
					var el = $('.alloweddevicesContainer .alloweddevices');
					
					el.each(function (cnt) {
					
							alloweddevicesAttributes = {}
							
							 alloweddevicesAttributes['devicename']=($(this).find('.devicename').val() ? $(this).find('.devicename').val().toString() :'')
alloweddevicesAttributes['deviceid']=($(this).find('.deviceid').val() ? $(this).find('.deviceid').val().toString() :'')
alloweddevicesAttributes['notificationid']=($(this).find('.notificationid').val() ? $(this).find('.notificationid').val().toString() :'')
alloweddevicesAttributes['craftmyapp_actionmethodname']='Update_Profile'
alloweddevicesAttributes['cma_client_row_i");
            WriteLiteral(@"d']=$(this).attr(""id"").replace(""alloweddevices"","""")

							
							alloweddevicesModel.push(alloweddevicesAttributes);
					
					
					
					});
					
				
					//var jsonalloweddevices = JSON.stringify(alloweddevicesModel);
					//$(""#alloweddevices"").val(jsonalloweddevices);
					return alloweddevicesModel
				
				
				}

			 
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
        ");
            WriteLiteral(@"                                $(element).closest('.form-group').removeClass('has-error');
                                        $(element).closest('.form-group').addClass('has-success');
                                        $(element).addClass('form-control-success');
                                        $(element).removeClass('form-control-error');
                                        },
                                        errorElement: 'span',
                                        errorClass: 'help-block'
                                        });
 	 
var validator = $(""#formId"").validate({ /* settings */ });
 
$(""#btnSubmit"").click(function(){
 
 
 var alloweddevicesModel=getalloweddevices()

 
 

if ($(""#formId"").valid()){
 $("".page-loader"").show()
 
 var form = $('#formId')[0];
 var formdata = new FormData(form);

 for (var i = 0; i < alloweddevicesModel.length; i++) {
formdata.append(""alloweddevices["" + i + ""].devicename"", alloweddevicesModel[i].devicename)
fo");
            WriteLiteral(@"rmdata.append(""alloweddevices["" + i + ""].cma_client_row_id"", alloweddevicesModel[i].cma_client_row_id)
formdata.append(""alloweddevices["" + i + ""].deviceid"", alloweddevicesModel[i].deviceid)
formdata.append(""alloweddevices["" + i + ""].cma_client_row_id"", alloweddevicesModel[i].cma_client_row_id)
formdata.append(""alloweddevices["" + i + ""].notificationid"", alloweddevicesModel[i].notificationid)
formdata.append(""alloweddevices["" + i + ""].cma_client_row_id"", alloweddevicesModel[i].cma_client_row_id)

formdata.append(""alloweddevices["" + i + ""].craftmyapp_actionmethodname"", 'Update_Profile')
}


 
 
 
$.ajax({
url: '");
#nullable restore
#line 529 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
 Write(Url.Action("Update_Profile"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
type:'POST',
enctype: 'multipart/form-data',
processData: false,   
contentType: false,
cache: false,
data: formdata,
success: function(data) {
  
  $("".page-loader"").hide();
 if(data==""Success""){
 $("".page-loader"").hide();
 	var Actions_=getAutho(""users"",""list"")
	if(Actions_ !=  undefined)
	{
		var list_URL = """);
#nullable restore
#line 544 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                   Write(Url.Action("entry.viewname", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
		                                                                list_URL = list_URL.replace(""entry.viewname"", Actions_.actionmethodname);
		                                                                window.location=list_URL;
	 
	}
   
 }
    else {
                                $("".page-loader"").hide();
                                swal({
                                    title: ""Error !!"",
                                    text: data,

                                    type: ""error"",
                                    showCancelButton: false,
                                    confirmButtonText: ""OK"",
                                })


                            }

 
},
	error: function(jqXHR, textStatus, errorThrown) {
	if (JSON.stringify(jqXHR.responseText) == ""\""API Authorization failed\"""")
	{
	swal({
	title: 'Failed!',
	text: jqXHR.responseText,
	type: 'error',
	buttonsStyling: false,
	confirmButtonClass: 'btn btn-primary',
	allowOutsideClick: fals");
            WriteLiteral("e\r\n\t}).then(function() {\r\n\twindow.location = \"");
#nullable restore
#line 578 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
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




}else{
validator.focusInvalid();
swal({
title: 'Validation Failed !',
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
				fill_userrole()

				$(""#tenantid"").change(function(){
						
						fill_userrole()

				})
			

			});
			</script>
			
            <script>
														$(document).ready(function(){

                                                            if(""");
#nullable restore
#line 630 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                                                           Write(Context.Session.GetString("GmailconsoleloginUserID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\".toLowerCase()==\"");
#nullable restore
#line 630 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Client\Views\users\Update_Profile.cshtml"
                                                                                                                                  Write(Model.usersid);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""".toLowerCase())
														   $("".userrole_craftmyapp_container"").hide()

														})

														</script>

			
			
<script>
					$(document).ready(function () {
						 
						$(""#tenantid"").change(function(){
								 
						})
					

					});
					</script><script>
														$(document).ready(function(){
														$(""#username"").prop(""readonly"", true);

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Gmailconsole.Models.usersModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
