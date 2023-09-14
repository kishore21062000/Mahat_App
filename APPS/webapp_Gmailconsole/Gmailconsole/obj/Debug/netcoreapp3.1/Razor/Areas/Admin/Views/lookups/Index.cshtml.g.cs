#pragma checksum "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Admin\Views\lookups\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75e0a19b55e4cf268d86233be349929846ec3c68"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_lookups_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/lookups/Index.cshtml")]
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
#line 3 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Admin\Views\lookups\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75e0a19b55e4cf268d86233be349929846ec3c68", @"/Areas/Admin/Views/lookups/Index.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_lookups_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\t\t\t<!-- This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 09/12/2023 09:49:17 -->\r\n");
#nullable restore
#line 4 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Admin\Views\lookups\Index.cshtml"
  
ViewData["Title"] = "List of  Lookup  Data";
Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card\" style=\"margin-left:5px;padding:20px;\">\r\n<div class=\"card-body\" style=\"padding:20px;padding-top:0px;\">\r\n");
#nullable restore
#line 11 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Admin\Views\lookups\Index.cshtml"
 if(TempData["message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n<div class=\"col-sm-12 col-xs-12\">\r\n<div class=\"alert alert-success alert-dismissible fade show\">\r\n<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n<span aria-hidden=\"true\">x</span>\r\n</button>\r\nInfo :  ");
#nullable restore
#line 19 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Admin\Views\lookups\Index.cshtml"
   Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n</div>\r\n</div>\r\n");
#nullable restore
#line 23 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Admin\Views\lookups\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"	<div class=""row"" style=""margin-bottom:20px""><div class=""col-sm-12 col-xs-12"">
	<div class=""table-responsive"" style=""margin:0px;"">
		<table id=""lookups"" class=""table order-column hover responsive nowrap"" width=""100%"" style=""margin:0px; "">
			 <thead class=""thead-default"">
				<tr>
				<th>Entity Name</th>
				<th>Field Name</th>
				<th>Lookup Values</th>
				<th class=""all"">Action</th>

				</tr>
			</thead>
		<tbody></tbody>
			 
		</table>
	</div>

	</div></div>
	</div>
</div>

 
  
	<script type=""text/javascript"">
	$(document).ready(function () {
 
 
	var table=$(""#lookups"").DataTable({
	destroy:true,
	""bStateSave"": true,
""order"": [],
""aaSorting"": [],
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
	dom: ""Bfrtip"",
	   sDom: '<""dataTabl");
            WriteLiteral(@"es__top""lfB>rt<""dataTables__bottom""ip><""clear"">',
	buttons: [{
	extend: ""excelHtml5"",
	title: ""List Of Lookup Data""
	}, {
	extend: ""csvHtml5"",
	title: ""List Of Lookup Data""
	}, {
	extend: ""print"",
	title: ""List Of Lookup Data""
	}],
 initComplete: function(a, b) {
      $(this).closest("".dataTables_wrapper"").find("".dt-buttons"").hide();
       $(this).closest("".dataTables_wrapper"").find("".dataTables__top"").prepend(`
        <div class=""dataTables_buttons hidden-sm-down actions"">
          <i class=""actions__item mdi material-icons"" data-table-action=""fullscreen"">fullscreen</i>
          <div class=""dropdown actions__item"">
            <i data-toggle=""dropdown"" class=""material-icons"">share</i>
            <ul class=""dropdown-menu dropdown-menu-right"">
              <a href=""javascript: void 0"" class=""dropdown-item"" data-table-action=""excel"">Excel (.xlsx)</a>
              <a href=""javascript: void 0"" class=""dropdown-item"" data-table-action=""csv"">CSV (.csv)</a>
              <a href=""javascri");
            WriteLiteral(@"pt: void 0"" class=""dropdown-item"" data-table-action=""print"">Print</a>
            </ul>
          </div>`)

 

    },columns: [
{ data: 'entityname' },
{ data: 'fieldname' },
{ data: 'fielddesc' },
{
		""sName"": ""lookupid"",
		""bSearchable"": false,
		""bSortable"": false,
		data: 'lookupid', ""className"": ""dt-center"",
		mRender: function(data, type, row) {
var returnButton="""";
				var CreateURL = """);
#nullable restore
#line 105 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Admin\Views\lookups\Index.cshtml"
                            Write(Url.Action("Create", "lookups"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"?id="" + row[""lookupid""]
			 
			 returnButton=returnButton+ '<div class=""dropdown actions__item"">' +
'<i data-toggle=""dropdown"" class=""fa fa-ellipsis-v""></i>' +
'<div class=""dropdown-menu dropdown-menu-right"">';
returnButton=returnButton+'<a href=""' + CreateURL + '"" class=""dropdown-item"">Change</a>'
 

returnButton=returnButton+'</div></div>'
return returnButton
		}
		}

	 ],
	ajax: {
	url: """);
#nullable restore
#line 120 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Admin\Views\lookups\Index.cshtml"
     Write(Url.Action("get_lookups", "lookups"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
	type: 'GET',
	dataType: 'json',
	dataSrc: '',
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
#line 135 "C:\Users\lenovo\Downloads\webapp_Gmailconsole\Gmailconsole\Areas\Admin\Views\lookups\Index.cshtml"
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

   $('.ColVis_collection li').on('click', function(event) {
    event.stopPropagation();
  });

  $('.colvis_switch').on('change', function(e) {
    var column = dataTable.column($(this).attr('data-column'));
    column.visible(!column.visible());
  });

  $("".dataTables_filter input[type=search]"").focus(function() {
    $(this).closest("".dataTables_filter"").addClass(""dataTables_filter--toggled"")
  }), $("".dataTables_filter input[type=search]"").blur(function() {
    $(this).closest("".dataTables_filter"").removeClass(""dataTables_filter--toggled"")
  })

  $(""body"").on(""click"", ""[data-table-action]"", function(a) {
    a.preventDefault();
    var b = $(this).data(""table-action"");
    console.log('dataTables_wrapper', $(this).closest("".dataTables_wrapper"").find("".buttons-print""));
    if (");
            WriteLiteral(@"""excel"" === b && $(this).closest("".dataTables_wrapper"").find("".buttons-excel"").trigger(""click""), ""csv"" === b && $(this).closest("".dataTables_wrapper"").find("".buttons-csv"").trigger(""click""), ""print"" === b && $(this).closest("".dataTables_wrapper"").find("".buttons-print"").trigger(""click""), ""fullscreen"" === b) {
      var c = $(this).closest("".card"");
      c.hasClass(""card--fullscreen"") ? (c.removeClass(""card--fullscreen""), $(""body"").removeClass(""data-table-toggled"")) : (c.addClass(""card--fullscreen""), $(""body"").addClass(""data-table-toggled""))
    }
  });   
 
});
</script>




");
        }
        #pragma warning restore 1998
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
