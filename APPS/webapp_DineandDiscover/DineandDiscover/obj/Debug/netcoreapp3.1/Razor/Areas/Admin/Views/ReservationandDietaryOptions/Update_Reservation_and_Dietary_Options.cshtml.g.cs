#pragma checksum "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60fd03d5bb94ad86358b860d15a2408c775864a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ReservationandDietaryOptions_Update_Reservation_and_Dietary_Options), @"mvc.1.0.view", @"/Areas/Admin/Views/ReservationandDietaryOptions/Update_Reservation_and_Dietary_Options.cshtml")]
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
#line 3 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60fd03d5bb94ad86358b860d15a2408c775864a3", @"/Areas/Admin/Views/ReservationandDietaryOptions/Update_Reservation_and_Dietary_Options.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ReservationandDietaryOptions_Update_Reservation_and_Dietary_Options : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DineandDiscover.Models.ReservationandDietaryOptionsModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\t\t\t<!-- This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/16/2023 13:52:10 -->\r\n");
#nullable restore
#line 6 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
              
			ViewData["Title"] = "Update Reservation and Dietary Options";

			Layout = "~/Views/Shared/_Layout.cshtml";
			
			

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
             using(Html.BeginForm("Update_Reservation_and_Dietary_Options", "ReservationandDietaryOptions", FormMethod.Post, new { enctype="multipart/form-data", @id = "formId"}))
			{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""card card-block contCard""><!--Form_Main_Card-->
				<div class=""mobileHeader""><!--form_card_header-->
					<div class=""row"">
						<div class=""col-sm-12 col-xs-12"">
							<h4 class=""formHdr"">Update Reservation and Dietary Options</h4>
						</div>
					</div>
				</div><!--form_card_header-->
				<!--form_error_display-->
");
#nullable restore
#line 25 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
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
#line 33 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
                   Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 37 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t \r\n\t\t\t\t\r\n\t\t\t\t<!--form_error_display-->\r\n\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 1456, "\"", 1464, 0);
            EndWriteAttribute();
            WriteLiteral("><!--form_inner_card-->\r\n\t\t\t\t\t<div class=\"card-block\"><!--form_inner_card_block-->\r\n\t\t\t\t\t    ");
#nullable restore
#line 45 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
                   Write(Html.HiddenFor(m => m.ReservationandDietaryOptionsid));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
						 

						
						<div class=""row""><!--field_container_row-->
							<!--fieldsStartsHere-->
								
								<div class=""col-sm-3 col-xs-12 p-2 reservationanddietaryoptions_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Reservation and Dietary Options :</label>
										<select name=""reservationanddietaryoptions"" id=""reservationanddietaryoptions"" class=""form-control  ""></select>

									</div>
									");
#nullable restore
#line 59 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
                               Write(Html.ValidationMessageFor(model => model.reservationanddietaryoptions));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""reservationanddietaryoptions-error"" class=""help-block"" style=""display: none"" for=""reservationanddietaryoptions""></label>
								</div>
							</div>
<div class=""col-sm-3 col-xs-12 p-4 reservationsavailable_craftmyapp_container"">
							<div>

							<label>Reservations Available :</label><br>
							<div class=""form-group"">
                                                        <div>
                                                          <label class=""switch"">
                                                          ");
#nullable restore
#line 70 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
                                                     Write(Html.CheckBoxFor(m => m.reservationsavailable,new {@class = "" }));

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
 
				<div class=""col-sm-12 col-xs-12 mt-3""><!--form_group_div_block-->
					<div class=""card card-blue card-section cma_section_band"">
							<div class=""card-head"">
								<header>Dietary Options :</header>
							</div>
							<div class=""card-body card-container-Padding-NoShadow"">
								<div class=""row"">
										<div class=""col-sm-3 col-xs-12 my-5 vegetarian_craftmyapp_container"">
							<div>
													<div class=""checkbox checkbox-styled"">
<label>");
#nullable restore
#line 90 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
  Write(Html.CheckBoxFor(m => m.vegetarian,new {@class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n\t\t\t\t\t<span>Vegetarian</span>\n\t\t\t\t\t</div>\n\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\n<div class=\"col-sm-3 col-xs-12 my-5 nonvegetarian_craftmyapp_container\">\r\n\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"checkbox checkbox-styled\">\n<label>");
#nullable restore
#line 100 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
  Write(Html.CheckBoxFor(m => m.nonvegetarian,new {@class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n\t\t\t\t\t<span>Non - Vegetarian</span>\n\t\t\t\t\t</div>\n\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\n<div class=\"col-sm-3 col-xs-12 my-5 diaryfree_craftmyapp_container\">\r\n\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"checkbox checkbox-styled\">\n<label>");
#nullable restore
#line 110 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
  Write(Html.CheckBoxFor(m => m.diaryfree,new {@class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n\t\t\t\t\t<span>Diary - Free</span>\n\t\t\t\t\t</div>\n\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\n<div class=\"col-sm-3 col-xs-12 my-5 nutfree_craftmyapp_container\">\r\n\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"checkbox checkbox-styled\">\n<label>");
#nullable restore
#line 120 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
  Write(Html.CheckBoxFor(m => m.nutfree,new {@class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n\t\t\t\t\t<span>Nut - Free </span>\n\t\t\t\t\t</div>\n\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\n<div class=\"col-sm-3 col-xs-12 my-5 seafood_craftmyapp_container\">\r\n\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"checkbox checkbox-styled\">\n<label>");
#nullable restore
#line 130 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
  Write(Html.CheckBoxFor(m => m.seafood,new {@class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\n\t\t\t\t\t<span>Seafood </span>\n\t\t\t\t\t</div>\n\r\n\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\n<div class=\"col-sm-3 col-xs-12 my-5 lowsodium_craftmyapp_container\">\r\n\t\t\t\t\t\t\t<div>\r\n\t\t\t\t\t\t\t\t\t\t\t\t\t<div class=\"checkbox checkbox-styled\">\n<label>");
#nullable restore
#line 140 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
  Write(Html.CheckBoxFor(m => m.lowsodium,new {@class = "" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</label>
					<span>Low - Sodium </span>
					</div>

							
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
							<button type=""button"" id=""btnSubmit"" class=""btn cma_primary_button  waves-effect pull-right"">Update Reservation and Dietary Options</button>
						</div><!--form_button_card_block-->


					</div><!--form_inner_card_block-->
				</div><!--form_inner_card-->
			</div><!--Form_Main_Card-->
");
#nullable restore
#line 169 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--EndFORM-->\r\n\r\n\r\n\t\t\t\r\n\t\t\t \r\n\t\t\t <script type=\"text/javascript\">\r\n\t\t\t\t$(document).ready(function () {\r\n\r\n\r\n\t\t\t\tvar Actions=getAutho(\"ReservationandDietaryOptions\",\"edit\")\r\n\t\t\t\tif(Actions == undefined){\r\n\t\t\t\twindow.location = \"");
#nullable restore
#line 181 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
                              Write(Url.Action("RoleAuthorizationFailed", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n\t\t\t\t}\r\n\r\n\r\n\t\t\t\t});\r\n\t\t\t\t</script>\r\n\t\t\t\r\n\t\t\t<script>\nvar strreservationanddietaryoptions;\n</script>\n");
#nullable restore
#line 191 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
 if (Model != null)
{
if(Model.reservationanddietaryoptions != null && Model.reservationanddietaryoptions.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nstrreservationanddietaryoptions=\"");
#nullable restore
#line 196 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
                            Write(Model.reservationanddietaryoptions);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n</script>\n");
#nullable restore
#line 198 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
}
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 200 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
 if (Model != null)
{
if(Model.vegetarian != null && Model.vegetarian.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nif(\"");
#nullable restore
#line 205 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
Write(Model.vegetarian);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"==\"True\")\n{\n$(\"#vegetarianparent\").addClass(\"active\")\n}\n</script>\n");
#nullable restore
#line 210 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
}
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 212 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
 if (Model != null)
{
if(Model.nonvegetarian != null && Model.nonvegetarian.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nif(\"");
#nullable restore
#line 217 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
Write(Model.nonvegetarian);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"==\"True\")\n{\n$(\"#nonvegetarianparent\").addClass(\"active\")\n}\n</script>\n");
#nullable restore
#line 222 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
}
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 224 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
 if (Model != null)
{
if(Model.diaryfree != null && Model.diaryfree.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nif(\"");
#nullable restore
#line 229 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
Write(Model.diaryfree);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"==\"True\")\n{\n$(\"#diaryfreeparent\").addClass(\"active\")\n}\n</script>\n");
#nullable restore
#line 234 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
}
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 236 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
 if (Model != null)
{
if(Model.nutfree != null && Model.nutfree.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nif(\"");
#nullable restore
#line 241 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
Write(Model.nutfree);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"==\"True\")\n{\n$(\"#nutfreeparent\").addClass(\"active\")\n}\n</script>\n");
#nullable restore
#line 246 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
}
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 248 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
 if (Model != null)
{
if(Model.seafood != null && Model.seafood.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nif(\"");
#nullable restore
#line 253 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
Write(Model.seafood);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"==\"True\")\n{\n$(\"#seafoodparent\").addClass(\"active\")\n}\n</script>\n");
#nullable restore
#line 258 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
}
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 260 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
 if (Model != null)
{
if(Model.lowsodium != null && Model.lowsodium.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nif(\"");
#nullable restore
#line 265 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
Write(Model.lowsodium);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"==\"True\")\n{\n$(\"#lowsodiumparent\").addClass(\"active\")\n}\n</script>\n");
#nullable restore
#line 270 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
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
function lookup_ReservationandDietaryOptions_reservationanddietaryoptions() {

var sendFilterData = {
	
}

$.ajax({
url: '");
#nullable restore
#line 339 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
 Write(Url.Action("lookup_ReservationandDietaryOptions_reservationanddietaryoptions"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
dataType: 'json',

success: function(data) {

       var ddltarget_reservationanddietaryoptions=""#reservationanddietaryoptions""
	    $(ddltarget_reservationanddietaryoptions).empty();
		
		$(ddltarget_reservationanddietaryoptions).append(""<option value=''>Choose</option>"");


		

		$.each(data, function(index, optionDataInner) {

				    if(strreservationanddietaryoptions== optionDataInner.BasicInformationid)
					$(ddltarget_reservationanddietaryoptions).append('<option selected value=' + optionDataInner.BasicInformationid + '>' + optionDataInner.nameoftherestaurant+ '</option>')
					else
					$(ddltarget_reservationanddietaryoptions).append('<option  value=' + optionDataInner.BasicInformationid+ '>' + optionDataInner.nameoftherestaurant+ '</option>')
								


		});

		

	
},
error: function(jqXHR, textStatus, errorThrown) {
if (JSON.stringify(jqXHR.responseText) == ""\""API Authorization failed\"""")
{
swal({
title: 'Failed!',
text: jqXHR.responseText,
type: 'error',
but");
            WriteLiteral("tonsStyling: false,\r\nconfirmButtonClass: \'btn btn-primary\',\r\nallowOutsideClick: false\r\n}).then(function() {\r\nwindow.location = \"");
#nullable restore
#line 378 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Update_Reservation_and_Dietary_Options.cshtml"
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

							lookup_ReservationandDietaryOptions_reservationanddietaryoptions()
							


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DineandDiscover.Models.ReservationandDietaryOptionsModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
