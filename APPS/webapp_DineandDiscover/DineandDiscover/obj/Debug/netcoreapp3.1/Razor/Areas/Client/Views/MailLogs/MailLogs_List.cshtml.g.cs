#pragma checksum "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e020383200a20a0f73c4eb110a4e64cb1f7f675"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Client_Views_MailLogs_MailLogs_List), @"mvc.1.0.view", @"/Areas/Client/Views/MailLogs/MailLogs_List.cshtml")]
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
#line 3 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e020383200a20a0f73c4eb110a4e64cb1f7f675", @"/Areas/Client/Views/MailLogs/MailLogs_List.cshtml")]
    #nullable restore
    public class Areas_Client_Views_MailLogs_MailLogs_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DineandDiscover.Models.MailLogsModel>
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
            WriteLiteral("\r\n\t\t\t\t\t<!--This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/15/2023 13:37:39 -->\r\n");
#nullable restore
#line 6 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
                      
					ViewData["Title"] = "MailLogs List";
					Layout = "~/Views/Shared/_Layout.cshtml";
					

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
					<div class=""card "" style=""padding:20px;"">
					<div class=""mobileHeader""><!--form_card_header-->
					<div class=""row"">
					<div class=""col-sm-12 col-xs-12"">
					<h3 class=""formHdr"">MailLogs List</h3>
					</div>
					</div>
					</div><!--form_card_header-->
					<div class=""card-body"" style=""padding:1px;padding-top:0px;"">

");
#nullable restore
#line 21 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
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
#line 29 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
                       Write(TempData["errMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 33 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
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
#line 43 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
                       Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 47 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
					<input type=""hidden"" id=""MailLogsid"" name=""MailLogsid""/>
					<div class=""row"">
					<div class=""col-sm-2 col-xs-12 p-2 entityname_craftmyapp_container"">
						<div>
							<div class=""form-group"" > 
								<label>Entity Name</label>
                                ");
#nullable restore
#line 55 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
                           Write(Html.TextBoxFor(m => m.entityname, new {@type="text",@maxlength="128", @class = "form-control form-control-lg " }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\r\n\t\t\t\t\t\t\t     ");
#nullable restore
#line 57 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
                            Write(Html.ValidationMessageFor(model => model.entityname));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
							</div>
						</div>
					</div>
<div class=""col-sm-2 p-2"">

												<button id=""btnFilter"" class=""btn btn-secondary btn--icon-text mt-5""><i class=""fa fa-filter""></i> Filter</button>

												</div>

					</div>

					<div class=""row""><div class=""col-sm-12 col-xs-12"">
					<div class=""table-responsive"" style=""margin:0px;"">
					<table id=""tblMailLogs"" class=""table order-column hover responsive nowrap"" width=""100%"" style=""margin:0px; "">
					<thead class=""thead-default"">
					<tr>
					<th>Entity Name</th>
<th>Entity ID</th>
<th>Mail For</th>
<th>Mail To</th>
<th>Mail Subject</th>
<th>Mail Body</th>
<th>Is Sent ?</th>

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e020383200a20a0f73c4eb110a4e64cb1f7f67510006", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8e020383200a20a0f73c4eb110a4e64cb1f7f67511141", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e020383200a20a0f73c4eb110a4e64cb1f7f67512201", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "8e020383200a20a0f73c4eb110a4e64cb1f7f67513336", async() => {
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

                 

					function fill_MailLogs()
					{
						

					var sendFilterData = {
							  		""entityname"":$(""#entityname"").val(),

								}

					


					var table=$(""#tblMailLogs"").DataTable({
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
	title: ""List Of MailLogs Data""
	}, {
	extend: ""csvHtml5"",
	title: ""List Of MailLogs Data""
	}, {
	extend: ""print"",
	title: ""List Of MailLogs Data""
	}],
 initComplete: function(a, b) {


");
            WriteLiteral(@"
      $(this).closest("".dataTables_wrapper"").find("".dt-buttons"").hide();
      
if ($('#btnFilter').length) {
     $(this).closest("".dataTables_wrapper"").find("".dataTables_length"").prepend(`
        <i class=""automatonShowFilter actions__item mdi material-icons"">filter_alt</i>
      `);
 }
var Actions=getAutho(""MailLogs"",""create"")
		if(Actions != undefined){
			var create_URL = """);
#nullable restore
#line 163 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
                         Write(Url.Action("entry.viewname", "MailLogs"));

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
                                                                <label><span class=""material-icons"">drag_indicator</span>Entity Name
 <input type=""checkbox"" class=""colvis_switch"" data-column=""0"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Entity ID
 <input type=""checkbox"" class=""colvis_switch"" data-column=""1"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""mater");
            WriteLiteral(@"ial-icons"">drag_indicator</span>Mail For
 <input type=""checkbox"" class=""colvis_switch"" data-column=""2"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Mail To
 <input type=""checkbox"" class=""colvis_switch"" data-column=""3"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Mail Subject
 <input type=""checkbox"" class=""colvis_switch"" data-column=""4"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Mail Body
 <input type=""checkbox"" class=""colvis_switch"" data-column=""5"" checked /></label>
                                       ");
            WriteLiteral(@"                       </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Is Sent ?
 <input type=""checkbox"" class=""colvis_switch"" data-column=""6"" checked /></label>
                                                              </li>
   
                                    </ul>
                                    </div>

         <a href=""create_URL"" class=""btn btn-rounded add-row-btn cma_add_button"">Add <span class=""material-icons"">add</span></a>
        </div>
      `.replace(""create_URL"", create_URL))
if ($(this).hasClass('make-active')) {
        $('tbody', $(this)).children('tr').first().addClass('active-row');
        setTimeout(() => {
          $('.active-row td:visible:last').addClass('last-active-td');
        }, 200);
      }
      $(this).closest("".dataTables_wrapper"").find("".dt-global-search"").on('keyup', function() {
        table.search(this.value).draw();
      });

        }
            else{");
            WriteLiteral(@"
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
              <a href=""javascript: void 0"" class=""dropdown-item"" data-table-action=""print"">Print</a>
            </ul>
          </div>
         <div class=""dropdown actions__item cm");
            WriteLiteral(@"a_top_icon"">
                                    <i data-toggle=""dropdown"" class=""material-icons"">settings</i>
                                    <ul class=""dropdown-menu dropdown-menu-right ColVis_collection"">
                                    <li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Entity Name
 <input type=""checkbox"" class=""colvis_switch"" data-column=""0"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Entity ID
 <input type=""checkbox"" class=""colvis_switch"" data-column=""1"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Mail For
 <input type=""checkbox"" class=""colvis_switch"" data-column=""2""");
            WriteLiteral(@" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Mail To
 <input type=""checkbox"" class=""colvis_switch"" data-column=""3"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Mail Subject
 <input type=""checkbox"" class=""colvis_switch"" data-column=""4"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Mail Body
 <input type=""checkbox"" class=""colvis_switch"" data-column=""5"" checked /></label>
                                                              </li>
<li>
                                                                <la");
            WriteLiteral(@"bel><span class=""material-icons"">drag_indicator</span>Is Sent ?
 <input type=""checkbox"" class=""colvis_switch"" data-column=""6"" checked /></label>
                                                              </li>
   
                                    </ul>
                                    </div>
        </div>
      `)
if ($(this).hasClass('make-active')) {
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
		{data: 'entityname'},
{data: 'entityid'},
{data: 'mailfor'},
{data: 'mailsubject'},
{data: 'mailto'},
{data: 'mailbody'},
{data: 'issent'},

		{
                    ""sName"": ""maillogsid"",
                    ""bSearchable"": false,
                    ""bSort");
            WriteLiteral("able\": false,\r\n                    data: \'maillogsid\', \"className\": \"dt-center\",\r\n                    mRender: function(data, type, row) {\r\n                    var Actions=getAuthoController(\"MailLogs\")\r\n                     var DETAIL_URL = \"");
#nullable restore
#line 313 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
                                  Write(Url.Action("detail", "MailLogs"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?id="" + row[""maillogsid""]
		var appendMessage='<a href=""' + DETAIL_URL + '"" class=""dropdown-item"">View</a>';
                    if(Actions !=undefined)
                    {
                    for (var index = 0; index < Actions.length; ++index) {
                    var entry = Actions[index];
			 
                    if(entry.viewname !=""list"" && entry.viewname !=""list_verify_approved"" && entry.viewname !=""list_verify"" && entry.viewname !=""create"" && entry.viewname !=""post"" && entry.viewname !=""getall"" && entry.viewname !=""get"" && entry.viewname !=""check_user"" && entry.viewname !=""change_password""){
                    var URL = """);
#nullable restore
#line 321 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
                          Write(Url.Action("entry.viewname", "MailLogs"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?MailLogsid="" + row[""maillogsid""]
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
                    '<i data-toggle=""dropdown"" class=""fa fa-ellipsis-h""></i>' +
                 ");
            WriteLiteral(@"   '<div class=""dropdown-menu dropdown-menu-right"">' + appendMessage +
		 

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
#line 373 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
     Write(Url.Action("get_MailLogs_List", "MailLogs"));

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
#line 389 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
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


					fill_MailLogs()


					var Actions=getAutho(""MailLogs"",""list"")
					if(Actions == undefined){
					window.location = """);
#nullable restore
#line 438 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Client\Views\MailLogs\MailLogs_List.cshtml"
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
            WriteLiteral("\t\t\t\t\r\n\t\t\t\t\t\t\t\t<script>\r\n\t\t\t\t\t\t\t\t$(document).ready(function () {\r\n\t\t\t\t\t\t\t \r\n\r\n\t\t\t\t\t\t\t\t$(\"#btnFilter\").click(function(){\r\n\t\t\t\t\t\t\t\tfill_MailLogs();\r\n\t\t\t\t\t\t\t\t})\r\n\t\t\t\t\t\t\t\t});\r\n\t\t\t\t\t\t\t\t</script>\r\n\r\n\r\n\t\t\t\t\t\r\n                    \r\n\t\t\t\t\t\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DineandDiscover.Models.MailLogsModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
