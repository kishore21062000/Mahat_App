#pragma checksum "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62ab34db09f7bc352f2adb52a8ecd6ee92ad78ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ReviewsandRatings_Update_Reviews_and_Ratings), @"mvc.1.0.view", @"/Areas/Admin/Views/ReviewsandRatings/Update_Reviews_and_Ratings.cshtml")]
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
#line 3 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62ab34db09f7bc352f2adb52a8ecd6ee92ad78ee", @"/Areas/Admin/Views/ReviewsandRatings/Update_Reviews_and_Ratings.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ReviewsandRatings_Update_Reviews_and_Ratings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DineandDiscover.Models.ReviewsandRatingsModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/jquery-bar-rating/jquery.barrating.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/jquery-bar-rating/themes/fontawesome-stars.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\t\t\t<!-- This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/15/2023 15:50:43 -->\r\n");
#nullable restore
#line 6 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
              
			ViewData["Title"] = "Update Reviews and Ratings";

			Layout = "~/Views/Shared/_Layout.cshtml";
			
			

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 13 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
             using(Html.BeginForm("Update_Reviews_and_Ratings", "ReviewsandRatings", FormMethod.Post, new { enctype="multipart/form-data", @id = "formId"}))
			{


#line default
#line hidden
#nullable disable
            WriteLiteral(@"			<div class=""card card-block contCard""><!--Form_Main_Card-->
				<div class=""mobileHeader""><!--form_card_header-->
					<div class=""row"">
						<div class=""col-sm-12 col-xs-12"">
							<h4 class=""formHdr"">Update Reviews and Ratings</h4>
						</div>
					</div>
				</div><!--form_card_header-->
				<!--form_error_display-->
");
#nullable restore
#line 25 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
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
#line 33 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
                   Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 37 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\r\n\t\t\t\t\r\n\t\t\t\t \r\n\t\t\t\t\r\n\t\t\t\t<!--form_error_display-->\r\n\t\t\t\t<div");
            BeginWriteAttribute("class", " class=\"", 1398, "\"", 1406, 0);
            EndWriteAttribute();
            WriteLiteral("><!--form_inner_card-->\r\n\t\t\t\t\t<div class=\"card-block\"><!--form_inner_card_block-->\r\n\t\t\t\t\t    ");
#nullable restore
#line 45 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
                   Write(Html.HiddenFor(m => m.ReviewsandRatingsid));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
						 

						
						<div class=""row""><!--field_container_row-->
							<!--fieldsStartsHere-->
								
								<div class=""col-sm-3 col-xs-12 p-2 reviewsandratings_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Reviews and Ratings</label>
										<select name=""reviewsandratings"" id=""reviewsandratings"" class=""form-control  ""></select>

									</div>
									");
#nullable restore
#line 59 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
                               Write(Html.ValidationMessageFor(model => model.reviewsandratings));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""reviewsandratings-error"" class=""help-block"" style=""display: none"" for=""reviewsandratings""></label>
								</div>
							</div>
 
				<div class=""col-sm-12 col-xs-12 mt-3""><!--form_group_div_block-->
					<div class=""card card-blue card-section cma_section_band"">
							<div class=""card-head"">
								<header>Food Rating :</header>
							</div>
							<div class=""card-body card-container-Padding-NoShadow"">
								<div class=""row"">
										<div class=""col-sm-3 col-xs-12 p-2 givemark1_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>give mark1</label>
															<select name=""givemark1"" id=""givemark1"" class=""form-control  "">
					</select>

									</div>
									");
#nullable restore
#line 79 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
                               Write(Html.ValidationMessageFor(model => model.givemark1));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""givemark1-error"" class=""help-block"" style=""display: none"" for=""givemark1""></label>
								</div>
							</div>
<div class=""col-sm-12 col-xs-12 p-2 comments1_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Comments1</label>
										");
#nullable restore
#line 87 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
                                   Write(Html.TextAreaFor(m => m.comments1, new {@minlength="0",@maxlength="256", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"form-group__bar\" ></i>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 91 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
                               Write(Html.ValidationMessageFor(model => model.comments1));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""comments1-error"" class=""help-block"" style=""display: none"" for=""comments1""></label>
								</div>
							</div>


								</div>
							</div>
					</div>
				</div><!--form_group_div_block-->
			 
 
				<div class=""col-sm-12 col-xs-12 mt-3""><!--form_group_div_block-->
					<div class=""card card-blue card-section cma_section_band"">
							<div class=""card-head"">
								<header>Service Rating :</header>
							</div>
							<div class=""card-body card-container-Padding-NoShadow"">
								<div class=""row"">
										<div class=""col-sm-3 col-xs-12 p-2 givemark2_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>give mark2</label>
															<select name=""givemark2"" id=""givemark2"" class=""form-control  "">
					</select>

									</div>
									");
#nullable restore
#line 118 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
                               Write(Html.ValidationMessageFor(model => model.givemark2));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""givemark2-error"" class=""help-block"" style=""display: none"" for=""givemark2""></label>
								</div>
							</div>
<div class=""col-sm-12 col-xs-12 p-2 comments2_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Comments2</label>
										");
#nullable restore
#line 126 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
                                   Write(Html.TextAreaFor(m => m.comments2, new {@minlength="0",@maxlength="256", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"form-group__bar\" ></i>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 130 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
                               Write(Html.ValidationMessageFor(model => model.comments2));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""comments2-error"" class=""help-block"" style=""display: none"" for=""comments2""></label>
								</div>
							</div>


								</div>
							</div>
					</div>
				</div><!--form_group_div_block-->
			 
 
				<div class=""col-sm-12 col-xs-12 mt-3""><!--form_group_div_block-->
					<div class=""card card-blue card-section cma_section_band"">
							<div class=""card-head"">
								<header>Overall Experience :</header>
							</div>
							<div class=""card-body card-container-Padding-NoShadow"">
								<div class=""row"">
										<div class=""col-sm-3 col-xs-12 p-2 givemark3_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>give mark3</label>
															<select name=""givemark3"" id=""givemark3"" class=""form-control  "">
					</select>

									</div>
									");
#nullable restore
#line 157 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
                               Write(Html.ValidationMessageFor(model => model.givemark3));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""givemark3-error"" class=""help-block"" style=""display: none"" for=""givemark3""></label>
								</div>
							</div>
<div class=""col-sm-12 col-xs-12 p-2 comments3_craftmyapp_container"">
								<div>
									<div class=""form-group form-group--float-above my-3"" > 
										<label>Comments3</label>
										");
#nullable restore
#line 165 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
                                   Write(Html.TextAreaFor(m => m.comments3, new {@minlength="0",@maxlength="256", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t\t\t\t<i class=\"form-group__bar\" ></i>\r\n\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 169 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
                               Write(Html.ValidationMessageFor(model => model.comments3));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
									<label id=""comments3-error"" class=""help-block"" style=""display: none"" for=""comments3""></label>
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
							<button type=""button"" id=""btnSubmit"" class=""btn cma_primary_button  waves-effect pull-right"">Update Reviews and Ratings</button>
						</div><!--form_button_card_block-->


					</div><!--form_inner_card_block-->
				</div><!--form_inner_card-->
			</div><!--Form_Main_Card-->
");
#nullable restore
#line 195 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!--EndFORM-->\r\n\r\n\r\n\t\t\t\r\n\t\t\t \r\n\t\t\t <script type=\"text/javascript\">\r\n\t\t\t\t$(document).ready(function () {\r\n\r\n\r\n\t\t\t\tvar Actions=getAutho(\"ReviewsandRatings\",\"edit\")\r\n\t\t\t\tif(Actions == undefined){\r\n\t\t\t\twindow.location = \"");
#nullable restore
#line 207 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
                              Write(Url.Action("RoleAuthorizationFailed", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n\t\t\t\t}\r\n\r\n\r\n\t\t\t\t});\r\n\t\t\t\t</script>\r\n\t\t\t\r\n\t\t\t<script>\nvar strreviewsandratings;\n</script>\n");
#nullable restore
#line 217 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
 if (Model != null)
{
if(Model.reviewsandratings != null && Model.reviewsandratings.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nstrreviewsandratings=\"");
#nullable restore
#line 222 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
                 Write(Model.reviewsandratings);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n</script>\n");
#nullable restore
#line 224 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
}
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62ab34db09f7bc352f2adb52a8ecd6ee92ad78ee18247", async() => {
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
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "62ab34db09f7bc352f2adb52a8ecd6ee92ad78ee19285", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n<script>\nvar strgivemark1;\n</script>\n");
#nullable restore
#line 231 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
 if (Model != null)
{
if(Model.givemark1 != null && Model.givemark1.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nstrgivemark1=\"");
#nullable restore
#line 236 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
         Write(Model.givemark1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n</script>\n");
#nullable restore
#line 238 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
}
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nvar strgivemark2;\n</script>\n");
#nullable restore
#line 243 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
 if (Model != null)
{
if(Model.givemark2 != null && Model.givemark2.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nstrgivemark2=\"");
#nullable restore
#line 248 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
         Write(Model.givemark2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n</script>\n");
#nullable restore
#line 250 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
}
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nvar strgivemark3;\n</script>\n");
#nullable restore
#line 255 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
 if (Model != null)
{
if(Model.givemark3 != null && Model.givemark3.ToString() != "")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\nstrgivemark3=\"");
#nullable restore
#line 260 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
         Write(Model.givemark3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\n</script>\n");
#nullable restore
#line 262 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
}
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t<script>\r\n$(document).ready(function () {\r\n\r\n$.ajax({\r\nurl: \'");
#nullable restore
#line 269 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
 Write(Url.Action("get_lookups_by_entity","lookups"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
dataType: 'json',
data:{id: 'ReviewsandRatings' },
success: function(data) {



		$.each(data, function(index, optionDataInner) {

				
						 	if(optionDataInner.fieldname==""givemark1""){
								var ddltarget_givemark1 = ""#givemark1""
								$(ddltarget_givemark1).empty();
								$(ddltarget_givemark1).append('<option  value=""""></option>')
								var options_givemark1 = optionDataInner.fielddesc.split(',');
								options_givemark1.forEach(function(option_givemark1){
									if(strgivemark1== option_givemark1)
									 $(ddltarget_givemark1).append('<option selected value=""' + option_givemark1 + '"">' + option_givemark1+ '</option>')
									else
									  $(ddltarget_givemark1).append('<option  value=""' + option_givemark1 + '"">' + option_givemark1+ '</option>')

									$(""#givemark1"").trigger(""change"")
								}) 


								$(ddltarget_givemark1).barrating({
												theme: 'fontawesome-stars'
								 })



							}

						 	if(optionDataInner.fieldname==""givem");
            WriteLiteral(@"ark2""){
								var ddltarget_givemark2 = ""#givemark2""
								$(ddltarget_givemark2).empty();
								$(ddltarget_givemark2).append('<option  value=""""></option>')
								var options_givemark2 = optionDataInner.fielddesc.split(',');
								options_givemark2.forEach(function(option_givemark2){
									if(strgivemark2== option_givemark2)
									 $(ddltarget_givemark2).append('<option selected value=""' + option_givemark2 + '"">' + option_givemark2+ '</option>')
									else
									  $(ddltarget_givemark2).append('<option  value=""' + option_givemark2 + '"">' + option_givemark2+ '</option>')

									$(""#givemark2"").trigger(""change"")
								}) 


								$(ddltarget_givemark2).barrating({
												theme: 'fontawesome-stars'
								 })



							}

						 	if(optionDataInner.fieldname==""givemark3""){
								var ddltarget_givemark3 = ""#givemark3""
								$(ddltarget_givemark3).empty();
								$(ddltarget_givemark3).append('<option  value=""""></option>')
								var options_givem");
            WriteLiteral(@"ark3 = optionDataInner.fielddesc.split(',');
								options_givemark3.forEach(function(option_givemark3){
									if(strgivemark3== option_givemark3)
									 $(ddltarget_givemark3).append('<option selected value=""' + option_givemark3 + '"">' + option_givemark3+ '</option>')
									else
									  $(ddltarget_givemark3).append('<option  value=""' + option_givemark3 + '"">' + option_givemark3+ '</option>')

									$(""#givemark3"").trigger(""change"")
								}) 


								$(ddltarget_givemark3).barrating({
												theme: 'fontawesome-stars'
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
type: 'error',
buttonsStyling: false,
confirmButtonClass: 'btn btn-primary',
allowOutsideClick: false
}).then(function() {
window.location = """);
#nullable restore
#line 365 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
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
function lookup_ReviewsandRatings_reviewsandratings() {

var sendFilterData = {
	
}

$.ajax({
url: '");
#nullable restore
#line 447 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
 Write(Url.Action("lookup_ReviewsandRatings_reviewsandratings"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
dataType: 'json',

success: function(data) {

       var ddltarget_reviewsandratings=""#reviewsandratings""
	    $(ddltarget_reviewsandratings).empty();
		
		$(ddltarget_reviewsandratings).append(""<option value=''>Choose</option>"");


		

		$.each(data, function(index, optionDataInner) {

				    if(strreviewsandratings== optionDataInner.BasicInformationid)
					$(ddltarget_reviewsandratings).append('<option selected value=' + optionDataInner.BasicInformationid + '>' + optionDataInner.nameoftherestaurant+ '</option>')
					else
					$(ddltarget_reviewsandratings).append('<option  value=' + optionDataInner.BasicInformationid+ '>' + optionDataInner.nameoftherestaurant+ '</option>')
								


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
allowOutsideClic");
            WriteLiteral("k: false\r\n}).then(function() {\r\nwindow.location = \"");
#nullable restore
#line 486 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReviewsandRatings\Update_Reviews_and_Ratings.cshtml"
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

							lookup_ReviewsandRatings_reviewsandratings()
							


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DineandDiscover.Models.ReviewsandRatingsModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591