#pragma checksum "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d960e51b995923b94c8e39addcd2dc6da38beaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Multilingual_Update_Multilingual), @"mvc.1.0.view", @"/Views/Multilingual/Update_Multilingual.cshtml")]
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
#line 3 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d960e51b995923b94c8e39addcd2dc6da38beaa", @"/Views/Multilingual/Update_Multilingual.cshtml")]
    #nullable restore
    public class Views_Multilingual_Update_Multilingual : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Multilingual.Models.MultilingualModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\t\t\t<!-- This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/08/2023 10:39:49 -->\r\n");
#nullable restore
#line 6 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
              
			ViewData["Title"] = "Update Multilingual";

			Layout = "~/Views/Shared/_Layout.cshtml";
			
			

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
             using(Html.BeginForm("Update_Multilingual", "Multilingual", FormMethod.Post, new { enctype="multipart/form-data", @id = "formId"}))
			{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""card card-block contCard""><!--Form_Main_Card-->
				<div class=""mobileHeader""><!--form_card_header-->
					<div class=""row"">
						<div class=""col-sm-12 col-xs-12"">
							<h4 class=""formHdr"">Update Multilingual</h4>
						</div>
					</div>
				</div><!--form_card_header-->
				<!--form_error_display-->
");
#nullable restore
#line 25 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
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
#line 33 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
                   Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 37 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t \r\n\t\t\t\t\r\n\t\t\t\t<!--form_error_display-->\r\n\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 1364, "\"", 1372, 0);
            EndWriteAttribute();
            WriteLiteral("><!--form_inner_card-->\r\n\t\t\t\t\t<div class=\"card-block\"><!--form_inner_card_block-->\r\n\t\t\t\t\t    ");
#nullable restore
#line 45 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
                   Write(Html.HiddenFor(m => m.Multilingualid));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
						 

						<div class=""row tenantSection"">
						<div class=""col-sm-2 p-2"">
						<div>
						<div class=""form-group form-group--float-above my-3"" > 
						<label class=""tenant_display"">Language </label>
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
								
								<div class=""col-sm-3 col-xs-12 p-2 name_craftmyapp_container"">
						<div>
							<div class=""form-group"" > 
								<label>Name</label>
                                ");
#nullable restore
#line 69 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
                           Write(Html.TextBoxFor(m => m.name, new {@type="text",@maxlength="128", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 71 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
                            Write(Html.ValidationMessageFor(model => model.name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-3 col-xs-12 p-2 requestorname_craftmyapp_container\">\r\n\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t\t\t\t<label>Requestor name </label>\r\n                                ");
#nullable restore
#line 79 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
                           Write(Html.TextBoxFor(m => m.requestorname, new {@type="text",@maxlength="128", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 81 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
                            Write(Html.ValidationMessageFor(model => model.requestorname));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
					</div>
<div class=""col-sm-3 col-xs-12 p-2 lang_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Language</label>
										<select name=""lang"" id=""lang"" class=""form-control  ""></select>

									</div>
									");
#nullable restore
#line 92 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
                               Write(Html.ValidationMessageFor(model => model.lang));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""lang-error"" class=""help-block"" style=""display: none"" for=""lang""></label>
								</div>
							</div>


							<!--fieldsEndsHere-->	
						</div><!--field_container_row-->


						<div class=""card-block""><!--form_button_card_block-->
							<button type=""button"" onclick=""window.history.back()""  class=""btn btn-secondary cma_cancel_button waves-effect"">Cancel</button>
							<button type=""button"" id=""btnSubmit"" class=""btn cma_primary_button  waves-effect pull-right"">Update Multilingual</button>
						</div><!--form_button_card_block-->


					</div><!--form_inner_card_block-->
				</div><!--form_inner_card-->
			</div><!--Form_Main_Card-->
");
#nullable restore
#line 111 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--EndFORM-->\r\n\r\n\r\n\t\t\t\r\n\t\t\t \r\n\t\t\t <script type=\"text/javascript\">\r\n\t\t\t\t$(document).ready(function () {\r\n\r\n\r\n\t\t\t\tvar Actions=getAutho(\"Multilingual\",\"edit\")\r\n\t\t\t\tif(Actions == undefined){\r\n\t\t\t\twindow.location = \"");
#nullable restore
#line 123 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
                              Write(Url.Action("RoleAuthorizationFailed", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n\t\t\t\t}\r\n\r\n\r\n\t\t\t\t});\r\n\t\t\t\t</script>\r\n\t\t\t\r\n\t\t\t<script>\nvar strlang;\n</script>\n");
#nullable restore
#line 133 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
 if (Model != null)
{
if(Model.lang != null && Model.lang.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nstrlang=\"");
#nullable restore
#line 138 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
    Write(Model.lang);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n</script>\n");
#nullable restore
#line 140 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
}
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<script>\r\n$(document).ready(function () {\r\n\r\n$.ajax({\r\nurl: \'");
#nullable restore
#line 147 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
 Write(Url.Action("get_lookups_by_entity","lookups"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
dataType: 'json',
data:{id: 'Multilingual' },
success: function(data) {



		$.each(data, function(index, optionDataInner) {

				
											if(optionDataInner.fieldname==""lang""){
												var ddltarget_lang = ""#lang""
												$(ddltarget_lang).empty();
												$(ddltarget_lang).append(""<option value=''>Choose</option>"")
												var options_lang = optionDataInner.fielddesc.split(',');
												options_lang.forEach(function(option_lang){
													if(strlang== option_lang)
													$(ddltarget_lang).append('<option selected value=""' + option_lang + '"">' + option_lang+ '</option>')
													else
													$(ddltarget_lang).append('<option  value=""' + option_lang + '"">' + option_lang+ '</option>')
												
												})  

											}



		});


},
error: function(jqXHR, textStatus, errorThrown) {
if (JSON.stringify(jqXHR.responseText) == ""\""API Authorization failed\"""")
{
swal({
title: 'Failed!',
text: jqXHR.responseText,
type: 'error',");
            WriteLiteral("\r\nbuttonsStyling: false,\r\nconfirmButtonClass: \'btn btn-primary\',\r\nallowOutsideClick: false\r\n}).then(function() {\r\nwindow.location = \"");
#nullable restore
#line 189 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
              Write(Url.Action("AuthorizationFailed", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n}) \r\n}\r\nelse\r\n{\r\nswal({\r\ntitle: \'Contact Administrator !\',\r\ntext: jqXHR.responseText,\r\ntype: \'error\',\r\nbuttonsStyling: false,\r\nconfirmButtonClass: \'btn btn-primary\'\r\n}) \r\n}\r\n}\r\n})\r\n})\r\n</script>\r\n\t\t\t\r\n\t\t\t<script>\r\nvar str_tenantid;\r\n</script>\r\n");
#nullable restore
#line 210 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\nstr_tenantid = \"");
#nullable restore
#line 213 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
           Write(Model.tenantid);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n</script>\r\n");
#nullable restore
#line 215 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
}else{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\nstr_tenantid = \"\"\r\n</script>\r\n");
#nullable restore
#line 219 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n\r\nif(\"");
#nullable restore
#line 222 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
Write(Context.Session.GetString("Multilingualtoken"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" !=\"\")\r\n {\r\n$.ajax({\r\nurl: \'");
#nullable restore
#line 225 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
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
#line 253 "C:\Users\lenovo\Downloads\webapp_Multilingual\Admin\Views\Multilingual\Update_Multilingual.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Multilingual.Models.MultilingualModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
