#pragma checksum "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff742a378a9641985c3a48f9600b079ca979d297"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BasicInformation_Add_Basic_Information), @"mvc.1.0.view", @"/Areas/Admin/Views/BasicInformation/Add_Basic_Information.cshtml")]
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
#line 3 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff742a378a9641985c3a48f9600b079ca979d297", @"/Areas/Admin/Views/BasicInformation/Add_Basic_Information.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_BasicInformation_Add_Basic_Information : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DineandDiscover.Models.BasicInformationModel>
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
            WriteLiteral("\r\n\t\t\t<!-- This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/15/2023 14:17:43 -->\r\n");
#nullable restore
#line 6 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
              
			ViewData["Title"] = "Add Basic Information";

			Layout = "~/Views/Shared/_Layout.cshtml";
			
			

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
             using(Html.BeginForm("Add_Basic_Information", "BasicInformation", FormMethod.Post, new { enctype="multipart/form-data", @id = "formId"}))
			{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""card card-block contCard""><!--Form_Main_Card-->
				<div class=""mobileHeader""><!--form_card_header-->
					<div class=""row"">
						<div class=""col-sm-12 col-xs-12"">
							<h4 class=""formHdr"">Add Basic Information</h4>
						</div>
					</div>
				</div><!--form_card_header-->
				<!--form_error_display-->
");
#nullable restore
#line 25 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
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
#line 33 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
                   Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 37 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t \r\n\t\t\t\t\r\n\t\t\t\t<!--form_error_display-->\r\n\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 1381, "\"", 1389, 0);
            EndWriteAttribute();
            WriteLiteral("><!--form_inner_card-->\r\n\t\t\t\t\t<div class=\"card-block\"><!--form_inner_card_block-->\r\n\t\t\t\t\t    ");
#nullable restore
#line 45 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
                   Write(Html.HiddenFor(m => m.BasicInformationid));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
						 

						<div class=""row tenantSection"">
						<div class=""col-sm-2 p-2"">
						<div>
						<div class=""form-group form-group--float-above my-3"" > 
						<label class=""tenant_display"">customer</label>
						<select name=""tenantid"" id=""tenantid"" class=""form-control tenant_display"">
						</select>
						<i class=""form-group__bar""></i>
						</div>
						
						<label id=""tenantid-error"" class=""help-block"" style=""display: none"" for=""tenantid""></label>
						</div>
						</div>
						</div>
						<div class=""row""><!--field_container_row-->
							<!--fieldsStartsHere-->
								
								<div class=""col-sm-3 col-xs-12 p-2 restaurantimage_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Restaurant Image :</label>
										<br><input type=""file"" multiple accept=""image/*""  id=""restaurantimage"" name=""restaurantimage"">

										<div id=""restaurantimageDisp""");
            BeginWriteAttribute("href", " href=\"", 2490, "\"", 2497, 0);
            EndWriteAttribute();
            WriteLiteral("></div>\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"form-group__bar\" ></i>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 74 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
                               Write(Html.ValidationMessageFor(model => model.restaurantimage));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""restaurantimage-error"" class=""help-block"" style=""display: none"" for=""restaurantimage""></label>
								</div>
							</div>
<div class=""col-sm-3 col-xs-12 p-2 nameoftherestaurant_craftmyapp_container"">
						<div>
							<div class=""form-group"" > 
								<label>Name of the Restaurant :</label>
                                ");
#nullable restore
#line 82 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
                           Write(Html.TextBoxFor(m => m.nameoftherestaurant, new {@type="text",@maxlength="128", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 84 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
                            Write(Html.ValidationMessageFor(model => model.nameoftherestaurant));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-3 col-xs-12 p-2 restaurantlocation_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>Restaurant Location :</label>\r\n                                ");
#nullable restore
#line 92 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
                           Write(Html.TextBoxFor(m => m.restaurantlocation, new {@type="url",@maxlength="256", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 94 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
                            Write(Html.ValidationMessageFor(model => model.restaurantlocation));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
					</div>
<div class=""col-sm-3 col-xs-12 p-2 cuisinetype_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Cuisine Type :</label>
										<select name=""cuisinetype"" id=""cuisinetype"" class=""form-control  ""></select>

									</div>
									");
#nullable restore
#line 105 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
                               Write(Html.ValidationMessageFor(model => model.cuisinetype));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""cuisinetype-error"" class=""help-block"" style=""display: none"" for=""cuisinetype""></label>
								</div>
							</div>


							<!--fieldsEndsHere-->	
						</div><!--field_container_row-->


						<div class=""card-block""><!--form_button_card_block-->
							<button type=""button"" onclick=""window.history.back()""  class=""btn btn-secondary cma_cancel_button waves-effect"">Cancel</button>
							<button type=""button"" id=""btnSubmit"" class=""btn cma_primary_button  waves-effect pull-right"">Add Basic Information</button>
						</div><!--form_button_card_block-->


					</div><!--form_inner_card_block-->
				</div><!--form_inner_card-->
			</div><!--Form_Main_Card-->
");
#nullable restore
#line 124 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--EndFORM-->\r\n\r\n\r\n\t\t\t\r\n\t\t\t \r\n\t\t\t <script type=\"text/javascript\">\r\n\t\t\t\t$(document).ready(function () {\r\n\r\n\r\n\t\t\t\tvar Actions=getAutho(\"BasicInformation\",\"create\")\r\n\t\t\t\tif(Actions == undefined){\r\n\t\t\t\twindow.location = \"");
#nullable restore
#line 136 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
                              Write(Url.Action("RoleAuthorizationFailed", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n\t\t\t\t}\r\n\r\n\r\n\t\t\t\t});\r\n\t\t\t\t</script>\r\n\t\t\t\r\n\t\t\t<script>\nvar strrestaurantimage;\n</script>\n");
#nullable restore
#line 146 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
 if (Model != null)
{
if(Model.restaurantimage != null && Model.restaurantimage.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nvar uploaded_restaurantimage = \"");
#nullable restore
#line 151 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
                           Write(Model.restaurantimage);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""".split('|');
                                            var iterate = 0;
                                            for (var i = 0; i < uploaded_restaurantimage.length; i++) {


	                                            if (uploaded_restaurantimage[i] != """") {
		                                            iterate = iterate + 1;
		                                            if (iterate == 1)
			                                            $('#restaurantimageDisp').append('<a href=' + uploaded_restaurantimage[i] + ' class=""imgrestaurantimage auto_clr_photo""><img  src=' + uploaded_restaurantimage[i] + ' width=""100px"" /></a>')
		                                            else

			                                            $('#restaurantimageDisp').append('<div style=""display:none""> <a href=' + uploaded_restaurantimage[i] + ' class=""imgrestaurantimage auto_clr_photo""><img  src=' + uploaded_restaurantimage[i] + ' width=""100px"" /></a></div>')
		 
	                                            }

");
            WriteLiteral(@"
                                            }
$('body').on('click', 'a.imgrestaurantimage', function (e) {
                            e.preventDefault();
                            $('.imgrestaurantimage').colorbox({ rel: '.imgrestaurantimage', width: ""90%"", height: ""80%"" });
                            $.colorbox({ open: true });
                            });
</script>
");
#nullable restore
#line 174 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
}
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ff742a378a9641985c3a48f9600b079ca979d29715911", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ff742a378a9641985c3a48f9600b079ca979d29717042", async() => {
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
            WriteLiteral(" \n<script>\nvar strcuisinetype;\n</script>\n");
#nullable restore
#line 181 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
 if (Model != null)
{
if(Model.cuisinetype != null && Model.cuisinetype.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nstrcuisinetype=\"");
#nullable restore
#line 186 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
           Write(Model.cuisinetype);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n</script>\n");
#nullable restore
#line 188 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
}
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<script>\r\n$(document).ready(function () {\r\n\r\n$.ajax({\r\nurl: \'");
#nullable restore
#line 195 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
 Write(Url.Action("get_lookups_by_entity","lookups"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
dataType: 'json',
data:{id: 'BasicInformation' },
success: function(data) {



		$.each(data, function(index, optionDataInner) {

				
											if(optionDataInner.fieldname==""cuisinetype""){
												var ddltarget_cuisinetype = ""#cuisinetype""
												$(ddltarget_cuisinetype).empty();
												$(ddltarget_cuisinetype).append(""<option value=''>Choose</option>"")
												var options_cuisinetype = optionDataInner.fielddesc.split(',');
												options_cuisinetype.forEach(function(option_cuisinetype){
													if(strcuisinetype== option_cuisinetype)
													$(ddltarget_cuisinetype).append('<option selected value=""' + option_cuisinetype + '"">' + option_cuisinetype+ '</option>')
													else
													$(ddltarget_cuisinetype).append('<option  value=""' + option_cuisinetype + '"">' + option_cuisinetype+ '</option>')
												
												})  

											}



		});


},
error: function(jqXHR, textStatus, errorThrown) {
if (JSON.stringify(jqXHR.respo");
            WriteLiteral("nseText) == \"\\\"API Authorization failed\\\"\")\r\n{\r\nswal({\r\ntitle: \'Failed!\',\r\ntext: jqXHR.responseText,\r\ntype: \'error\',\r\nbuttonsStyling: false,\r\nconfirmButtonClass: \'btn btn-primary\',\r\nallowOutsideClick: false\r\n}).then(function() {\r\nwindow.location = \"");
#nullable restore
#line 237 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
              Write(Url.Action("AuthorizationFailed", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n}) \r\n}\r\nelse\r\n{\r\nswal({\r\ntitle: \'Contact Administrator !\',\r\ntext: jqXHR.responseText,\r\ntype: \'error\',\r\nbuttonsStyling: false,\r\nconfirmButtonClass: \'btn btn-primary\'\r\n}) \r\n}\r\n}\r\n})\r\n})\r\n</script>\r\n\t\t\t\r\n\t\t\t<script>\r\nvar str_tenantid;\r\n</script>\r\n");
#nullable restore
#line 258 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\nstr_tenantid = \"");
#nullable restore
#line 261 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
           Write(Model.tenantid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n</script>\r\n");
#nullable restore
#line 263 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
}else{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\nstr_tenantid = \"\"\r\n</script>\r\n");
#nullable restore
#line 267 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n\r\nif(\"");
#nullable restore
#line 270 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
Write(Context.Session.GetString("DineandDiscovertoken"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" !=\"\")\r\n {\r\n$.ajax({\r\nurl: \'");
#nullable restore
#line 273 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
 Write(Url.Action("get_project_tenant","tenant"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
dataType: 'json',

success: function(data) {
var ddltarget = ""#tenantid""
$(ddltarget).empty();
$(ddltarget).append(""<option value=''>Choose</option>"")
$.each(data, function(index, optionDataInner) {
if(str_tenantid == optionDataInner.tenantid)
{
$(ddltarget).append(""<option selected value='"" + optionDataInner.tenantid + ""'>"" + optionDataInner.businessname + ""</option>"")
}else{
$(ddltarget).append(""<option value='"" + optionDataInner.tenantid + ""'>"" + optionDataInner.businessname + ""</option>"")
};
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
#line 301 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\BasicInformation\Add_Basic_Information.cshtml"
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
}else
{

	$("".tenant_display"").hide()
}
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
                                        $(element).closest('.form-group').removeClass('has-error')");
            WriteLiteral(@";
                                        $(element).closest('.form-group').addClass('has-success');
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
                                                    validator.focusInv");
            WriteLiteral(@"alid();
                                                    swal({
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DineandDiscover.Models.BasicInformationModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
