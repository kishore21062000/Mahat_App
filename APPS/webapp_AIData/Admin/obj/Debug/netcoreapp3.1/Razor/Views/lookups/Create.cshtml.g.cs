#pragma checksum "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c45a08ab61de5b5f1f64fdb007d72f80ea106068"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_lookups_Create), @"mvc.1.0.view", @"/Views/lookups/Create.cshtml")]
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
#line 3 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c45a08ab61de5b5f1f64fdb007d72f80ea106068", @"/Views/lookups/Create.cshtml")]
    #nullable restore
    public class Views_lookups_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AIData.Models.lookupsModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/jquery/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/jquery/additional-methods.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/Selectize/dist/css/selectize.default.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/Selectize/dist/js/standalone/selectize.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/components/Selectize/basic/js/index.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\t\t\t<!-- This code generated from Deliveries Powered by Mahat, Source Machine : 15.206.208.9 , Build Number : Build 14092021 #2021-09-014(Updated on 29102021 12:49) on 08/26/2023 08:36:39 -->\r\n");
#nullable restore
#line 5 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
  
ViewData["Title"] = "Update  Lookup  Data";
Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
 using(Html.BeginForm("Create", "lookups", FormMethod.Post, new { enctype="multipart/form-data", @id = "formId"}))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div");
            BeginWriteAttribute("class", " class=\"", 486, "\"", 494, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left:5px;\">\r\n");
#nullable restore
#line 13 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
 if(ViewData["message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"row\">\r\n<div class=\"col-sm-12 col-xs-12\">\r\n<div class=\"alert alert-danger alert-dismissible\">\r\n<button type=\"button\" class=\"close\" data-dismiss=\"alert\" aria-label=\"Close\">\r\n<span aria-hidden=\"true\">x</span>\r\n</button>\r\nInfo :  ");
#nullable restore
#line 21 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
   Write(ViewData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n</div>\r\n</div>\r\n");
#nullable restore
#line 25 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card card-container-Padding\">\r\n<div class=\"card-block\">\r\n\t\t\t\t\t");
#nullable restore
#line 28 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
               Write(Html.HiddenFor(m => m.lookupid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t");
#nullable restore
#line 29 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
               Write(Html.HiddenFor(m => m.attributetype));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\r\n\t\t<div class=\"row\">\r\n\t\t<div class=\"col-sm-4 p-2\">\r\n\t\t\t<div>\r\n\t\t\t   <label>Entity Name</label>\r\n\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t");
#nullable restore
#line 36 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
               Write(Html.TextBoxFor(m => m.entityname, new {@readonly="readonly",@maxlength="256", @class = "form-control form-control-lg required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t<i class=\"form-group__bar\" ></i>\r\n\t\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t\t");
#nullable restore
#line 40 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.entityname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<label id=\"entityname-error\" class=\"help-block\" style=\"display: none\" for=\"entityname\"></label>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-4 p-2\">\r\n\t\t\t<div>\r\n\t\t\t   <label>Field Name</label>\r\n\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t");
#nullable restore
#line 48 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
               Write(Html.TextBoxFor(m => m.fieldname, new {@readonly="readonly",@maxlength="256", @class = "form-control form-control-lg required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t<i class=\"form-group__bar\" ></i>\r\n\t\t\t\t\t\r\n\t\t\t\t</div>\r\n\t\t\t\t");
#nullable restore
#line 52 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.fieldname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<label id=\"fieldname-error\" class=\"help-block\" style=\"display: none\" for=\"fieldname\"></label>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t\t<div class=\"col-sm-12 col-xs-12 p-2\">\r\n\t\t\t<div>\r\n\t\t\t\t<label>Lookup Values</label>\r\n\t\t\t\t<div class=\"form-group\" > \r\n\t\t\t\t\t");
#nullable restore
#line 60 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
               Write(Html.TextBoxFor(m => m.fielddesc, new {@type="text",@maxlength="1084", @class = "required" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t<i class=\"form-group__bar\" ></i>\r\n\t\t\t\t\t\r\n\t\t\t\t\t<label id=\"fielddesc-error\" class=\"help-block\" style=\"display: block\" for=\"fielddesc\"></label>\r\n\t\t\t\t</div>\r\n\t\t\t\t");
#nullable restore
#line 65 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.fielddesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t<label id=\"fielddesc-success\" class=\"help-block\" style=\"display:block\" for=\"fielddesc\">Type to Add More Items..</label>\r\n\t\t\t\t\r\n\t\t\t</div>\r\n\t\t</div> \r\n\r\n\t\t</div>\r\n\t\t<div class=\"card-block\">\r\n\t\t\t\t<a");
            BeginWriteAttribute("href", " href= \"", 2622, "\"", 2660, 1);
#nullable restore
#line 73 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
WriteAttributeValue("", 2630, Url.Action("Index","lookups"), 2630, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-secondary waves-effect cma_cancel_button\">Cancel</a>\r\n\t\t\t\t<button type=\"submit\" id=\"btnSubmit\" class=\"btn btn-blue  waves-effect pull-right cma_primary_button\">Submit</button>\r\n\t\t</div>\r\n</div>\r\n</div>\r\n</div>\r\n");
#nullable restore
#line 79 "C:\Users\lenovo\Downloads\webapp_AIData\Admin\Views\lookups\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c45a08ab61de5b5f1f64fdb007d72f80ea10606811530", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c45a08ab61de5b5f1f64fdb007d72f80ea10606812570", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c45a08ab61de5b5f1f64fdb007d72f80ea10606813614", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c45a08ab61de5b5f1f64fdb007d72f80ea10606814730", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c45a08ab61de5b5f1f64fdb007d72f80ea10606815770", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script>
$(document).ready(function () {

  $(""#fielddesc"").selectize({
                persist: true,
                createOnBlur: true,
                create: true
                });
				
		$('#formId').validate({
		ignore: ':hidden:not([class~=selectized]),:hidden > .selectized, .selectize-control .selectize-input input',
		highlight: function(element) {
		$(element).closest('.form-group').addClass('has-danger');
		$(element).closest('.form-group').removeClass('has-success');
		$(element).addClass('form-control-danger');
		$(element).removeClass('form-control-success');
		},
		unhighlight: function(element) {
		$(element).closest('.form-group').removeClass('has-danger');
		$(element).closest('.form-group').addClass('has-success');
		$(element).addClass('form-control-success');
		$(element).removeClass('form-control-danger');
		},
		errorElement: 'label',
		errorClass: 'help-block'
		});
})
var str = """";
</script>







<script>
$(document).ready(function () {
v");
            WriteLiteral(@"ar validator = $(""#formId"").validate({ /* settings */ });
$(""#btnSubmit"").click(function(){
if ($(""#formId"").valid()){
$("".page-loader"").show()
$(""#formId"").submit();
}else{
validator.focusInvalid();
swal({
title: 'Validation !',
text: ""Please fill Empty Fields"",
type: 'error',
buttonsStyling: false,
confirmButtonClass: 'btn btn-primary'
 })
}
})
})
$('form:first *:input[type!=hidden]:first').focus();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AIData.Models.lookupsModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
