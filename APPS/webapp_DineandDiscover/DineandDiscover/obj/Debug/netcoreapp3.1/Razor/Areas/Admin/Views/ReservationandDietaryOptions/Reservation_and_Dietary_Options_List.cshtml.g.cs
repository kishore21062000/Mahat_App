#pragma checksum "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46902c178bfb32773b3c742c1c8cb2e47510107c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ReservationandDietaryOptions_Reservation_and_Dietary_Options_List), @"mvc.1.0.view", @"/Areas/Admin/Views/ReservationandDietaryOptions/Reservation_and_Dietary_Options_List.cshtml")]
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
#line 3 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46902c178bfb32773b3c742c1c8cb2e47510107c", @"/Areas/Admin/Views/ReservationandDietaryOptions/Reservation_and_Dietary_Options_List.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ReservationandDietaryOptions_Reservation_and_Dietary_Options_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DineandDiscover.Models.ReservationandDietaryOptionsModel>
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
            WriteLiteral("\r\n\t\t\t\t\t<!--This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/16/2023 13:52:10 -->\r\n");
#nullable restore
#line 6 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
                      
					ViewData["Title"] = "Reservation and Dietary Options List";
					Layout = "~/Views/Shared/_Layout.cshtml";
					

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
					<div class=""card "" style=""padding:20px;"">
					<div class=""mobileHeader""><!--form_card_header-->
					<div class=""row"">
					<div class=""col-sm-12 col-xs-12"">
					<h3 class=""formHdr"">Reservation and Dietary Options List</h3>
					</div>
					</div>
					</div><!--form_card_header-->
					<div class=""card-body"" style=""padding:1px;padding-top:0px;"">

");
#nullable restore
#line 21 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
                     if(TempData["errMessage"] != null)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"					<div class=""row"">
					<div class=""col-sm-12 col-xs-12"">
					<div class=""alert alert-danger alert-dismissible "">
					<button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
					<span aria-hidden=""true"">x</span>
					</button>
					Info :  ");
#nullable restore
#line 29 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
                       Write(TempData["errMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 33 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
                     if(TempData["message"] != null)
					{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"					<div class=""row"">
					<div class=""col-sm-12 col-xs-12"">
					<div class=""alert alert-success alert-dismissible "">
					<button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
					<span aria-hidden=""true"">x</span>
					</button>
					Info :  ");
#nullable restore
#line 43 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
                       Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 47 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
					<input type=""hidden"" id=""ReservationandDietaryOptionsid"" name=""ReservationandDietaryOptionsid""/>
					<div class=""row"">
					

					</div>

					<div class=""row""><div class=""col-sm-12 col-xs-12"">
					<div class=""table-responsive"" style=""margin:0px;"">
					<table id=""tblReservationandDietaryOptions"" class=""table order-column hover responsive nowrap"" width=""100%"" style=""margin:0px; "">
					<thead class=""thead-default"">
					<tr>
					<th>Reservation and Dietary Options :</th>
<th>Reservations Available :</th>
<th>Vegetarian</th>
<th>Non - Vegetarian</th>
<th>Diary - Free</th>
<th>Nut - Free </th>
<th>Seafood </th>
<th>Low - Sodium </th>

					<th class=""all"">Action</th>
					

					</tr>
					</thead>
					<tbody></tbody>
					
					</table>
					</div>

					</div>
					
					
					</div>
					
					</div>
					</div>
					
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46902c178bfb32773b3c742c1c8cb2e47510107c9613", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46902c178bfb32773b3c742c1c8cb2e47510107c10747", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46902c178bfb32773b3c742c1c8cb2e47510107c11807", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46902c178bfb32773b3c742c1c8cb2e47510107c12942", async() => {
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

                 

					function fill_ReservationandDietaryOptions()
					{
						

					var sendFilterData = {
							  		
								}

					


					var table=$(""#tblReservationandDietaryOptions"").DataTable({
columnDefs: [{ 
     targets: -1,
     title: '<i class=""fa fa-pencil fa-lg""></i>'
  }],
		destroy:true,
	""order"": [],""aaSorting"": [],
 	autoWidth: !1,
	responsive:!0,
	lengthMenu: [
	[15, 30, 45, -1],
	[""15 Rows"", ""30 Rows"", ""45 Rows"", ""Everything""]
	],
	language: {
	searchPlaceholder: ""Search for records...""
	},
	 language: { search: '<i class=""fa fa-search""></i>', searchPlaceholder: ""Search for records..."" },
	dom: ""Bfrtip"", sDom: '<""dataTables__top""lfB>rt<""dataTables__bottom""ip><""clear"">',
  
	buttons: [{
	extend: ""excelHtml5"",
	title: ""List Of ReservationandDietaryOptions Data""
	}, {
	extend: ""csvHtml5"",
	title: ""List Of ReservationandDietaryOptions Data""
	}, {
	extend: ""print"",
	title: ""List Of ReservationandDie");
            WriteLiteral(@"taryOptions Data""
	}],
 initComplete: function(a, b) {



      $(this).closest("".dataTables_wrapper"").find("".dt-buttons"").hide();
      
if ($('#btnFilter').length) {
     $(this).closest("".dataTables_wrapper"").find("".dataTables_length"").prepend(`
        <i class=""automatonShowFilter actions__item mdi material-icons"">filter_alt</i>
      `);
 }
var Actions=getAutho(""ReservationandDietaryOptions"",""create"")
		if(Actions != undefined){
			var create_URL = """);
#nullable restore
#line 149 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
                         Write(Url.Action("entry.viewname", "ReservationandDietaryOptions"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
		    create_URL = create_URL.replace(""entry.viewname"", Actions.actionmethodname);
            
            $(this).closest("".dataTables_wrapper"").find("".dataTables__top"").prepend(`
        <div class=""dataTables_buttons actions"">
           <div class=""input-group prefix"">
                <span class=""input-group-addon"">
                <i class=""material-icons"">search</i>
                </span>
                <input type=""text"" class=""form-control dt-global-search"" placeholder=""Search..."" />
            </div>
          <div class=""dropdown actions__item cma_top_icon"">
            <i data-toggle=""dropdown"" class=""material-icons"">share</i>
            <ul class=""dropdown-menu dropdown-menu-right"">
              <a href=""javascript: void 0"" class=""dropdown-item"" data-table-action=""excel"">Excel (.xlsx)</a>
              <a href=""javascript: void 0"" class=""dropdown-item"" data-table-action=""csv"">CSV (.csv)</a>
              <a href=""javascript: void 0"" class=""dropdown-item"" data-table-action=");
            WriteLiteral(@"""print"">Print</a>
            </ul>
          </div>
         <div class=""dropdown actions__item cma_top_icon"">
                                    <i data-toggle=""dropdown"" class=""material-icons"">settings</i>
                                    <ul class=""dropdown-menu dropdown-menu-right ColVis_collection"">
                                    <li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Reservation and Dietary Options :
 <input type=""checkbox"" class=""colvis_switch"" data-column=""0"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Reservations Available :
 <input type=""checkbox"" class=""colvis_switch"" data-column=""1"" checked /></label>
                                                              </li>
<li>
                                                    ");
            WriteLiteral(@"            <label><span class=""material-icons"">drag_indicator</span>Vegetarian
 <input type=""checkbox"" class=""colvis_switch"" data-column=""2"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Non - Vegetarian
 <input type=""checkbox"" class=""colvis_switch"" data-column=""3"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Diary - Free
 <input type=""checkbox"" class=""colvis_switch"" data-column=""4"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Nut - Free 
 <input type=""checkbox"" class=""colvis_switch"" data-column=""5"" checked /");
            WriteLiteral(@"></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Seafood 
 <input type=""checkbox"" class=""colvis_switch"" data-column=""6"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Low - Sodium 
 <input type=""checkbox"" class=""colvis_switch"" data-column=""7"" checked /></label>
                                                              </li>
   
                                    </ul>
                                    </div>

         <a href=""create_URL"" class=""btn btn-rounded add-row-btn cma_add_button"">Add <span class=""material-icons"">add</span></a>
        </div>
      `.replace(""create_URL"", create_URL))
if ($(this).hasClass('make-active')) {
        $('tbody', $(this)).children('tr').f");
            WriteLiteral(@"irst().addClass('active-row');
        setTimeout(() => {
          $('.active-row td:visible:last').addClass('last-active-td');
        }, 200);
      }
      $(this).closest("".dataTables_wrapper"").find("".dt-global-search"").on('keyup', function() {
        table.search(this.value).draw();
      });

        }
            else{
            $(this).closest("".dataTables_wrapper"").find("".dataTables__top"").prepend(`
        <div class=""dataTables_buttons actions"">
         <div class=""input-group prefix"">
                <span class=""input-group-addon"">
                <i class=""material-icons"">search</i>
                </span>
                <input type=""text"" class=""form-control dt-global-search"" placeholder=""Search..."" />
            </div>
          <div class=""dropdown actions__item cma_top_icon"">
            <i data-toggle=""dropdown"" class=""material-icons"">share</i>
            <ul class=""dropdown-menu dropdown-menu-right"">
              <a href=""javascript: void 0"" class=""dropdown-i");
            WriteLiteral(@"tem"" data-table-action=""excel"">Excel (.xlsx)</a>
              <a href=""javascript: void 0"" class=""dropdown-item"" data-table-action=""csv"">CSV (.csv)</a>
              <a href=""javascript: void 0"" class=""dropdown-item"" data-table-action=""print"">Print</a>
            </ul>
          </div>
         <div class=""dropdown actions__item cma_top_icon"">
                                    <i data-toggle=""dropdown"" class=""material-icons"">settings</i>
                                    <ul class=""dropdown-menu dropdown-menu-right ColVis_collection"">
                                    <li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Reservation and Dietary Options :
 <input type=""checkbox"" class=""colvis_switch"" data-column=""0"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</");
            WriteLiteral(@"span>Reservations Available :
 <input type=""checkbox"" class=""colvis_switch"" data-column=""1"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Vegetarian
 <input type=""checkbox"" class=""colvis_switch"" data-column=""2"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Non - Vegetarian
 <input type=""checkbox"" class=""colvis_switch"" data-column=""3"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Diary - Free
 <input type=""checkbox"" class=""colvis_switch"" data-column=""4"" checked /></label>
                                        ");
            WriteLiteral(@"                      </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Nut - Free 
 <input type=""checkbox"" class=""colvis_switch"" data-column=""5"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Seafood 
 <input type=""checkbox"" class=""colvis_switch"" data-column=""6"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Low - Sodium 
 <input type=""checkbox"" class=""colvis_switch"" data-column=""7"" checked /></label>
                                                              </li>
   
                                    </ul>
                                    </div>
        </div>
      `)
if ($(this).");
            WriteLiteral(@"hasClass('make-active')) {
        $('tbody', $(this)).children('tr').first().addClass('active-row');
        setTimeout(() => {
          $('.active-row td:visible:last').addClass('last-active-td');
        }, 200);
      }
      $(this).closest("".dataTables_wrapper"").find("".dt-global-search"").on('keyup', function() {
        table.search(this.value).draw();
      });

        }

    }
	 ,columns: [
		{data: 'reservationanddietaryoptions_master',
mRender: function (data, type, row) {
var Actions_=getAutho('BasicInformation','list')
 if(row[""reservationanddietaryoptions_master""]==null) {
 return '-' 
}else {
 
if(Actions_ !=  undefined)
{
var DETAIL_URL = """);
#nullable restore
#line 301 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
             Write(Url.Action("detail", "BasicInformation"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?id="" + row['reservationanddietaryoptions']
return '<a  href=""' + DETAIL_URL  + '"">'+ row[""reservationanddietaryoptions_master""]+ '</a>' 
}else {
 
return row['reservationanddietaryoptions_master'] 
}
}
}},
{data: 'reservationsavailable'},
{data: 'vegetarian'},
{data: 'nonvegetarian'},
{data: 'diaryfree'},
{data: 'nutfree'},
{data: 'seafood'},
{data: 'lowsodium'},

		{
                    ""sName"": ""reservationanddietaryoptionsid"",
                    ""bSearchable"": false,
                    ""bSortable"": false,
                    data: 'reservationanddietaryoptionsid', ""className"": ""dt-center"",
                    mRender: function(data, type, row) {
                    var Actions=getAuthoController(""ReservationandDietaryOptions"")
                     var DETAIL_URL = """);
#nullable restore
#line 324 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
                                  Write(Url.Action("detail", "ReservationandDietaryOptions"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?id="" + row[""reservationanddietaryoptionsid""]
		var appendMessage='<a href=""' + DETAIL_URL + '"" class=""dropdown-item"">View</a>';
                    if(Actions !=undefined)
                    {
                    for (var index = 0; index < Actions.length; ++index) {
                    var entry = Actions[index];
			 
                    if(entry.viewname !=""list"" && entry.viewname !=""list_verify_approved"" && entry.viewname !=""list_verify"" && entry.viewname !=""create"" && entry.viewname !=""post"" && entry.viewname !=""getall"" && entry.viewname !=""get"" && entry.viewname !=""check_user"" && entry.viewname !=""change_password""){
                    var URL = """);
#nullable restore
#line 332 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
                          Write(Url.Action("entry.viewname", "ReservationandDietaryOptions"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?ReservationandDietaryOptionsid="" + row[""reservationanddietaryoptionsid""]
                    URL = URL.replace(""entry.viewname"", entry.actionmethodname);
			 
                    if(entry.viewname==""delete"")
                    {
	                    
	                    appendMessage+='<a href=""' + URL + '"" class=""dropdown-item deleteRecordFromTable"">'+entry.actiondisplayname+'</a>' 	
				   
				
                    }
                    else
                    {
                     
	                    appendMessage+='<a href=""' + URL + '"" class=""dropdown-item"">'+entry.actiondisplayname+'</a>' 
                    }
			 
                    }					 
						 
                    }
								
                    if(appendMessage =="""")
                    {
                    return '-'

                    }
                    else
                    {
                    return '<div class=""dropdown actions__item"">' +
                    '<i data-toggle=""dropdown"" class=""fa f");
            WriteLiteral(@"a-ellipsis-h""></i>' +
                    '<div class=""dropdown-menu dropdown-menu-right"">' + appendMessage +
		 

                    '</div>' +
                    '</div>'
                    }



                    }
                    else
                    {
                    return '-'

                    }


                    }
                    }
	

	 ],
	ajax: {
	url: """);
#nullable restore
#line 384 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
     Write(Url.Action("get_Reservation_and_Dietary_Options_List", "ReservationandDietaryOptions"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
	type: 'GET',
	dataType: 'json',
	dataSrc: '',
	data: sendFilterData,
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
#line 400 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
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
	}
	})
     
	  
 $('body').on('click', '.ColVis_collection li', function(a) {
    event.stopPropagation();
  });
 
 $('body').on('change', '.colvis_switch', function(a) {
    var column = table.column($(this).attr('data-column'));
    column.visible(!column.visible());
  });


 

   
	 


	


							
					}
                    	

					$(document).ready(function () {


					fill_ReservationandDietaryOptions()


					var Actions=getAutho(""ReservationandDietaryOptions"",""list"")
					if(Actions == undefined){
					window.location = """);
#nullable restore
#line 449 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\ReservationandDietaryOptions\Reservation_and_Dietary_Options_List.cshtml"
                                  Write(Url.Action("RoleAuthorizationFailed", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
					}




					});
					

                    $(""body"").on(""click"", ""[data-table-action]"", function(a) {
                    a.preventDefault();
                    var b = $(this).data(""table-action"");
                    console.log('dataTables_wrapper', $(this).closest("".dataTables_wrapper"").find("".buttons-print""));
                    if (""excel"" === b && $(this).closest("".dataTables_wrapper"").find("".buttons-excel"").trigger(""click""), ""csv"" === b && $(this).closest("".dataTables_wrapper"").find("".buttons-csv"").trigger(""click""), ""print"" === b && $(this).closest("".dataTables_wrapper"").find("".buttons-print"").trigger(""click""), ""fullscreen"" === b) {
                    var c = $(this).closest("".card"");
                    c.hasClass(""card--fullscreen"") ? (c.removeClass(""card--fullscreen""), $(""body"").removeClass(""data-table-toggled"")) : (c.addClass(""card--fullscreen""), $(""body"").addClass(""data-table-toggled""))
                    }
                    });
					</script>
					
					
					
	");
            WriteLiteral("\t\t\t\t\r\n\t\t\t\t\t\t\t\t<script>\r\n\t\t\t\t\t\t\t\t$(document).ready(function () {\r\n\t\t\t\t\t\t\t \r\n\r\n\t\t\t\t\t\t\t\t$(\"#btnFilter\").click(function(){\r\n\t\t\t\t\t\t\t\tfill_ReservationandDietaryOptions();\r\n\t\t\t\t\t\t\t\t})\r\n\t\t\t\t\t\t\t\t});\r\n\t\t\t\t\t\t\t\t</script>\r\n\r\n\r\n\t\t\t\t\t\r\n                    \r\n\t\t\t\t\t\n");
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
