#pragma checksum "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "df66a28c7e6bd6c2968a771b700bea1df42e8919"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_IndustyTypes_Update_IndustyTypes), @"mvc.1.0.view", @"/Views/IndustyTypes/Update_IndustyTypes.cshtml")]
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
#line 3 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df66a28c7e6bd6c2968a771b700bea1df42e8919", @"/Views/IndustyTypes/Update_IndustyTypes.cshtml")]
    #nullable restore
    public class Views_IndustyTypes_Update_IndustyTypes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AIData.Models.IndustyTypesModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\t\t\t<!-- This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/26/2023 08:42:42 -->\r\n");
#nullable restore
#line 6 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
              
			ViewData["Title"] = "Update IndustyTypes";

			Layout = "~/Views/Shared/_Layout.cshtml";
			
			

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
             using(Html.BeginForm("Update_IndustyTypes", "IndustyTypes", FormMethod.Post, new { enctype="multipart/form-data", @id = "formId"}))
			{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""card card-block contCard""><!--Form_Main_Card-->
				<div class=""mobileHeader""><!--form_card_header-->
					<div class=""row"">
						<div class=""col-sm-12 col-xs-12"">
							<h4 class=""formHdr"">Update IndustyTypes</h4>
						</div>
					</div>
				</div><!--form_card_header-->
				<!--form_error_display-->
");
#nullable restore
#line 25 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
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
#line 33 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
                   Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 37 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t \r\n\t\t\t\t\r\n\t\t\t\t<!--form_error_display-->\r\n\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 1358, "\"", 1366, 0);
            EndWriteAttribute();
            WriteLiteral("><!--form_inner_card-->\r\n\t\t\t\t\t<div class=\"card-block\"><!--form_inner_card_block-->\r\n\t\t\t\t\t    ");
#nullable restore
#line 45 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
                   Write(Html.HiddenFor(m => m.IndustyTypesid));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
						 

						
						<div class=""row""><!--field_container_row-->
							<!--fieldsStartsHere-->
								
								<div class=""col-sm-3 col-xs-12 p-2 industryname_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Industry Name</label>
										<select name=""industryname"" id=""industryname"" class=""form-control  ""></select>

									</div>
									");
#nullable restore
#line 59 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
                               Write(Html.ValidationMessageFor(model => model.industryname));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""industryname-error"" class=""help-block"" style=""display: none"" for=""industryname""></label>
								</div>
							</div>
<div class=""col-sm-3 col-xs-12 p-2 industrytypename_craftmyapp_container"">
						<div>
							<div class=""form-group"" > 
								<label>IndustryType Name</label>
                                ");
#nullable restore
#line 67 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
                           Write(Html.TextBoxFor(m => m.industrytypename, new {@type="text",@maxlength="128", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 69 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
                            Write(Html.ValidationMessageFor(model => model.industrytypename));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\n<div class=\"col-sm-12 col-xs-12 p-2 description_craftmyapp_container\">\r\n\t\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t<div class=\"form-group form-group--float-above my-3\" > \r\n\t\t\t\t\t\t\t\t\t\t<label>Description</label>\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 77 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
                                   Write(Html.TextAreaFor(m => m.description, new {@minlength="0",@maxlength="256", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"form-group__bar\" ></i>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 81 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
                               Write(Html.ValidationMessageFor(model => model.description));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""description-error"" class=""help-block"" style=""display: none"" for=""description""></label>
								</div>
							</div>


							<!--fieldsEndsHere-->	
						</div><!--field_container_row-->


						<div class=""card-block""><!--form_button_card_block-->
							<button type=""button"" onclick=""window.history.back()""  class=""btn btn-secondary cma_cancel_button waves-effect"">Cancel</button>
							<button type=""button"" id=""btnSubmit"" class=""btn cma_primary_button  waves-effect pull-right"">Update IndustyTypes</button>
						</div><!--form_button_card_block-->


					</div><!--form_inner_card_block-->
				</div><!--form_inner_card-->
			</div><!--Form_Main_Card-->
");
#nullable restore
#line 100 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--EndFORM-->\r\n\r\n\r\n\t\t\t\r\n\t\t\t \r\n\t\t\t <script type=\"text/javascript\">\r\n\t\t\t\t$(document).ready(function () {\r\n\r\n\r\n\t\t\t\tvar Actions=getAutho(\"IndustyTypes\",\"edit\")\r\n\t\t\t\tif(Actions == undefined){\r\n\t\t\t\twindow.location = \"");
#nullable restore
#line 112 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
                              Write(Url.Action("RoleAuthorizationFailed", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n\t\t\t\t}\r\n\r\n\r\n\t\t\t\t});\r\n\t\t\t\t</script>\r\n\t\t\t\r\n\t\t\t<script>\nvar strindustryname;\n</script>\n");
#nullable restore
#line 122 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
 if (Model != null)
{
if(Model.industryname != null && Model.industryname.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nstrindustryname=\"");
#nullable restore
#line 127 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
            Write(Model.industryname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n</script>\n");
#nullable restore
#line 129 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
}
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
			
			
			
			
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
                                        $(element).addClass('form-control-success');
                                  ");
            WriteLiteral(@"      $(element).removeClass('form-control-error');
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
                                                        text: ""Pleas");
            WriteLiteral(@"e check your entry"",
                                                        type: 'error',
                                                        buttonsStyling: false,
                                                        confirmButtonClass: 'btn btn-primary'
                                                    })
                                                }
                                            })


                                        })

	 
	</script>

			
			
            

			
			<script>
function lookup_IndustyTypes_industryname() {

var sendFilterData = {
	
}

$.ajax({
url: '");
#nullable restore
#line 198 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
 Write(Url.Action("lookup_IndustyTypes_industryname"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
dataType: 'json',

success: function(data) {

       var ddltarget_industryname=""#industryname""
	    $(ddltarget_industryname).empty();
		
		$(ddltarget_industryname).append(""<option value=''>Choose</option>"");


		

		$.each(data, function(index, optionDataInner) {

				    if(strindustryname== optionDataInner.Industriesid)
					$(ddltarget_industryname).append('<option selected value=' + optionDataInner.Industriesid + '>' + optionDataInner.industryname+ '</option>')
					else
					$(ddltarget_industryname).append('<option  value=' + optionDataInner.Industriesid+ '>' + optionDataInner.industryname+ '</option>')
								


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
#line 237 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\IndustyTypes\Update_IndustyTypes.cshtml"
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

}
</script>
<script>
						$(document).ready(function(){

							lookup_IndustyTypes_industryname()
							


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AIData.Models.IndustyTypesModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
