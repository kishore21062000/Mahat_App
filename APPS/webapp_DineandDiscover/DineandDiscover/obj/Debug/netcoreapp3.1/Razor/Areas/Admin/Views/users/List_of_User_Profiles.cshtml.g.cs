#pragma checksum "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13f2e67c11ae4c2ca86345b3be464d8547b08d6d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_users_List_of_User_Profiles), @"mvc.1.0.view", @"/Areas/Admin/Views/users/List_of_User_Profiles.cshtml")]
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
#line 3 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13f2e67c11ae4c2ca86345b3be464d8547b08d6d", @"/Areas/Admin/Views/users/List_of_User_Profiles.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_users_List_of_User_Profiles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DineandDiscover.Models.usersModel>
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
            WriteLiteral("\r\n\t\t\t\t\t<!--This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 07/15/2023 13:37:36 -->\r\n");
#nullable restore
#line 6 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
                      
					ViewData["Title"] = "List of User Profiles";
					Layout = "~/Views/Shared/_Layout.cshtml";
					

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
					<div class=""card "" style=""padding:20px;"">
					<div class=""mobileHeader""><!--form_card_header-->
					<div class=""row"">
					<div class=""col-sm-12 col-xs-12"">
					<h3 class=""formHdr"">List of User Profiles</h3>
					</div>
					</div>
					</div><!--form_card_header-->
					<div class=""card-body"" style=""padding:1px;padding-top:0px;"">

");
#nullable restore
#line 21 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
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
#line 29 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
                       Write(TempData["errMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 33 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
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
#line 43 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
                       Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n");
#nullable restore
#line 47 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
					<input type=""hidden"" id=""usersid"" name=""usersid""/>
					<div class=""row"">
								<div class=""col-sm-2 col-xs-12 p-2"">
								<div>
								<div class=""form-group form-group--float-above my-3"" > 
								<label class=""tenant_display"">customer</label>
								<select name=""tenantid"" id=""tenantid"" class=""form-control"">
								</select>
								<i class=""form-group__bar""></i>
								</div>

								<label id=""tenantid-error"" class=""help-block"" style=""display: none"" for=""tenantid""></label>
								</div>
								</div>
								
								</div>

					<div class=""row""><div class=""col-sm-12 col-xs-12"">
					<div class=""table-responsive"" style=""margin:0px;"">
					<table id=""tblusers"" class=""table order-column hover responsive nowrap"" width=""100%"" style=""margin:0px; "">
					<thead class=""thead-default"">
					<tr>
					<th>First Name</th>
<th>Last Name</th>
<th>Profile Picture</th>
<th>UserName</th>
<th>Email ID</th>
<th>Mobile Number</th>
<th>User Role</th>
<th>Allowed Devices</th>
<th>c");
            WriteLiteral("ustomer</th>\n\r\n\t\t\t\t\t<th class=\"all\">Action</th>\r\n\t\t\t\t\t\r\n\r\n\t\t\t\t\t</tr>\r\n\t\t\t\t\t</thead>\r\n\t\t\t\t\t<tbody></tbody>\r\n\t\t\t\t\t\r\n\t\t\t\t\t</table>\r\n\t\t\t\t\t</div>\r\n\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t\r\n\t\t\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t\t\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13f2e67c11ae4c2ca86345b3be464d8547b08d6d9613", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "13f2e67c11ae4c2ca86345b3be464d8547b08d6d10747", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13f2e67c11ae4c2ca86345b3be464d8547b08d6d11807", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "13f2e67c11ae4c2ca86345b3be464d8547b08d6d12942", async() => {
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

                 

					function fill_users()
					{
						

					var sendFilterData = {
								""tenantid"":$(""#tenantid"").val(),
								
								}

					


					var table=$(""#tblusers"").DataTable({
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
	title: ""List Of users Data""
	}, {
	extend: ""csvHtml5"",
	title: ""List Of users Data""
	}, {
	extend: ""print"",
	title: ""List Of users Data""
	}],
 initComplete: function(a, b) {



      $(this");
            WriteLiteral(@").closest("".dataTables_wrapper"").find("".dt-buttons"").hide();
      
if ($('#btnFilter').length) {
     $(this).closest("".dataTables_wrapper"").find("".dataTables_length"").prepend(`
        <i class=""automatonShowFilter actions__item mdi material-icons"">filter_alt</i>
      `);
 }
var Actions=getAutho(""users"",""create"")
		if(Actions != undefined){
			var create_URL = """);
#nullable restore
#line 162 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
                         Write(Url.Action("entry.viewname", "users"));

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
                                                                <label><span class=""material-icons"">drag_indicator</span>First Name
 <input type=""checkbox"" class=""colvis_switch"" data-column=""0"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Last Name
 <input type=""checkbox"" class=""colvis_switch"" data-column=""1"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""materi");
            WriteLiteral(@"al-icons"">drag_indicator</span>Profile Picture
 <input type=""checkbox"" class=""colvis_switch"" data-column=""2"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>UserName
 <input type=""checkbox"" class=""colvis_switch"" data-column=""3"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Email ID
 <input type=""checkbox"" class=""colvis_switch"" data-column=""4"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Mobile Number
 <input type=""checkbox"" class=""colvis_switch"" data-column=""5"" checked /></label>
                                ");
            WriteLiteral(@"                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>User Role
 <input type=""checkbox"" class=""colvis_switch"" data-column=""6"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Allowed Devices
 <input type=""checkbox"" class=""colvis_switch"" data-column=""7"" checked /></label>
                                                              </li>
   
                                    </ul>
                                    </div>

         <a href=""create_URL"" class=""btn btn-rounded add-row-btn cma_add_button"">Add <span class=""material-icons"">add</span></a>
        </div>
      `.replace(""create_URL"", create_URL))
if ($(this).hasClass('make-active')) {
        $('tbody', $(this)).children('tr').first().addClass('active-row');
        ");
            WriteLiteral(@"setTimeout(() => {
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
              <a href=""javascript: void 0"" class=""dropdown-item"" data-table-action=""excel"">Excel (.x");
            WriteLiteral(@"lsx)</a>
              <a href=""javascript: void 0"" class=""dropdown-item"" data-table-action=""csv"">CSV (.csv)</a>
              <a href=""javascript: void 0"" class=""dropdown-item"" data-table-action=""print"">Print</a>
            </ul>
          </div>
         <div class=""dropdown actions__item cma_top_icon"">
                                    <i data-toggle=""dropdown"" class=""material-icons"">settings</i>
                                    <ul class=""dropdown-menu dropdown-menu-right ColVis_collection"">
                                    <li>
                                                                <label><span class=""material-icons"">drag_indicator</span>First Name
 <input type=""checkbox"" class=""colvis_switch"" data-column=""0"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Last Name
 <input type=""checkbox"" class=""colvis_switch"" da");
            WriteLiteral(@"ta-column=""1"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Profile Picture
 <input type=""checkbox"" class=""colvis_switch"" data-column=""2"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>UserName
 <input type=""checkbox"" class=""colvis_switch"" data-column=""3"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Email ID
 <input type=""checkbox"" class=""colvis_switch"" data-column=""4"" checked /></label>
                                                              </li>
<li>
                                                   ");
            WriteLiteral(@"             <label><span class=""material-icons"">drag_indicator</span>Mobile Number
 <input type=""checkbox"" class=""colvis_switch"" data-column=""5"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>User Role
 <input type=""checkbox"" class=""colvis_switch"" data-column=""6"" checked /></label>
                                                              </li>
<li>
                                                                <label><span class=""material-icons"">drag_indicator</span>Allowed Devices
 <input type=""checkbox"" class=""colvis_switch"" data-column=""7"" checked /></label>
                                                              </li>
   
                                    </ul>
                                    </div>
        </div>
      `)
if ($(this).hasClass('make-active')) {
        $('tbody', $(this)).children('tr').first().a");
            WriteLiteral(@"ddClass('active-row');
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
		{data: 'firstname'},
{data: 'lastname'},
{data: 'profilepicture',mRender: function (data, type, row) {if(row[""profilepicture""]==null) {
 return '-' 
}else {
 
var uploaded_profilepicture = row[""profilepicture""].split('|');
var iterate = 1;
                                            var collect_files="""";
                                            var random_num=Math.floor(Math.random() * (100000 - 1 + 1) + 57);
                                            for (var i = 0; i < uploaded_profilepicture.length; i++) {
        

	                                            if (uploaded_profilepicture[i] != """") {
if(iterate==1)
collect_files+='<a class=""img'+random_num+'"" href");
            WriteLiteral(@"=' + uploaded_profilepicture[i] + '><img  class=""disp_image '+random_num+'"" style=""width: 75px; height: 75px"" src=' + uploaded_profilepicture[i] + '></a>'
else
collect_files+='<a class=""img'+random_num+'"" href=' + uploaded_profilepicture[i] + '><img class=""disp_image '+random_num+'"" style=""display:none;width: 75px; height: 75px"" src=' + uploaded_profilepicture[i] + '></a>'
iterate = iterate + 1;
	                                            }

                                              
                                            }
$('body').on('click', 'a.img' + random_num + '', function(e) {
e.preventDefault();
$('.img' + random_num + '').colorbox({rel: $(this).attr('href'), width: ""90%"", height: ""80%"" });
$.colorbox({open: true });
});
return collect_files;  }}},
{data: 'username'},
{data: 'emailid',mRender: function (data, type, row) {if(row[""emailid""]==null) {
 return '-' 
}else {
 return '<a  href=""mailto:' + row[""emailid""]+ '"">'+ row[""emailid""]+ '</a>' 
}
}},
{data: 'mobilenumber',mRender: functi");
            WriteLiteral(@"on (data, type, row) {if(row[""mobilenumber""]==null) {
 return '-' 
}else {
 return '<a  href=""tel:' + row[""mobilenumber""]+ '"">'+ row[""mobilenumber""]+ '</a>' 
}
}},
{data: 'userrole'},
{
                                    data: 'automaton_users_alloweddevices',
                                    mRender: function(data, type, row) {
                                        if (row['automaton_users_alloweddevices'] == null)
                                        {
                                            return '-'
                                        }
                                        else
                                        {
                                            return get_dependent_li(row['automaton_users_alloweddevices']);

                                        }
                                    }
                                },
{data: '_tenantname'},

		{
                    ""sName"": ""usersid"",
                    ""bSearchable"": false,
                    """);
            WriteLiteral("bSortable\": false,\r\n                    data: \'usersid\', \"className\": \"dt-center\",\r\n                    mRender: function(data, type, row) {\r\n                    var Actions=getAuthoController(\"users\")\r\n                     var DETAIL_URL = \"");
#nullable restore
#line 371 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
                                  Write(Url.Action("detail", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?id="" + row[""usersid""]
		var appendMessage='<a href=""' + DETAIL_URL + '"" class=""dropdown-item"">View</a>';
                    if(Actions !=undefined)
                    {
                    for (var index = 0; index < Actions.length; ++index) {
                    var entry = Actions[index];
			 
                    if(entry.viewname !=""list"" && entry.viewname !=""list_verify_approved"" && entry.viewname !=""list_verify"" && entry.viewname !=""create"" && entry.viewname !=""post"" && entry.viewname !=""getall"" && entry.viewname !=""get"" && entry.viewname !=""check_user"" && entry.viewname !=""change_password""){
                    var URL = """);
#nullable restore
#line 379 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
                          Write(Url.Action("entry.viewname", "users"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?usersid="" + row[""usersid""]
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
								
                    if(appendMessage ==""""|| row[""userrole""]=='Platform Admin')
                    {
                    return '-'

                    }
                    else
                    {
                    return '<div class=""dropdown actions__item"">' +
                    '<i data-toggle=""dropdown"" class=""fa fa-ellipsis");
            WriteLiteral(@"-h""></i>' +
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
#line 431 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
     Write(Url.Action("get_List_of_User_Profiles", "users"));

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
#line 447 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
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


					


					var Actions=getAutho(""users"",""list"")
					if(Actions == undefined){
					window.location = """);
#nullable restore
#line 496 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
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
            WriteLiteral(@"				
								<script>
								$(document).ready(function () {
								$(""#tenantid"").change(function(){
								fill_users();
								})

								$(""#btnFilter"").click(function(){
								fill_users();
								})
								});
								</script><script>
var str_tenantid;
</script>

<script>
str_tenantid = """);
#nullable restore
#line 534 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
           Write(Context.Session.GetString("DineandDiscoverchoosedtenantid_"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n</script>\r\n\r\n<script>\r\n\r\nif(\"");
#nullable restore
#line 539 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
Write(Context.Session.GetString("DineandDiscovertoken"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\" !=\"\")\r\n {\r\n$.ajax({\r\nurl: \'");
#nullable restore
#line 542 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
 Write(Url.Action("get_project_tenant","tenant"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
dataType: 'json',

success: function(data) {
var ddltarget = ""#tenantid""
$(ddltarget).empty();
if(data.length ==0)
                    {
                    var Actions_=getAutho(""tenant"",""create"")
                    if(Actions_ !=  undefined)
                    {
                    var tenant_create_URL = """);
#nullable restore
#line 553 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
                                        Write(Url.Action("entry.viewname", "tenant"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"""
                    tenant_create_URL = tenant_create_URL.replace(""entry.viewname"", Actions_.actionmethodname);

                    window.location=tenant_create_URL;
	 
                    }
	 

                    }
$.each(data, function(index, optionDataInner) {
if(str_tenantid == optionDataInner.tenantid)
{
$(ddltarget).append(""<option selected value='"" + optionDataInner.tenantid + ""'>"" + optionDataInner.businessname + ""</option>"")
}else{
$(ddltarget).append(""<option value='"" + optionDataInner.tenantid + ""'>"" + optionDataInner.businessname + ""</option>"")
};
});
fill_users()
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
#line 583 "C:\Users\lenovo\Downloads\webapp_DineandDiscover\DineandDiscover\Areas\Admin\Views\users\List_of_User_Profiles.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DineandDiscover.Models.usersModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
