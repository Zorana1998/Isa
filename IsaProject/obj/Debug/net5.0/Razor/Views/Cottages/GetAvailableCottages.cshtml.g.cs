#pragma checksum "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bd3e7f2ea635cb858adfae25d1f8ffddb1a87693"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cottages_GetAvailableCottages), @"mvc.1.0.view", @"/Views/Cottages/GetAvailableCottages.cshtml")]
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
#line 1 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\_ViewImports.cshtml"
using IsaProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\_ViewImports.cshtml"
using IsaProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bd3e7f2ea635cb858adfae25d1f8ffddb1a87693", @"/Views/Cottages/GetAvailableCottages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6635b82fd1a99e807e6407a136d85c2294a33dd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Cottages_GetAvailableCottages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IsaProject.Models.DTO.AppointmentDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Appointments", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTagsUser", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 7 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
  
    ViewData["Title"] = "GetAvailableCottages";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<link href=""https://unpkg.com/bootstrap-table@1.18.3/dist/bootstrap-table.min.css"" rel=""stylesheet"">
<link rel=""stylesheet"" href=""http://cdnjs.cloudflare.com/ajax/libs/bootstrap-table/1.9.1/bootstrap-table.min.css"">
<link rel=""stylesheet"" type=""text/css"" href=""http://bootstrap-table.wenzhixin.net.cn/assets/bootstrap/css/bootstrap.min.css"">
<script src=""https://code.jquery.com/jquery-3.6.0.js""></script>
<script src=""https://unpkg.com/bootstrap-table@1.18.3/dist/bootstrap-table.min.js""></script>
<script src=""https://unpkg.com/bootstrap-table@1.18.3/dist/extensions/filter-control/bootstrap-table-filter-control.min.js""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootstrap-table/1.18.3/extensions/filter-control/utils.min.js""></script>
<script src=""http://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js""></script>
<script src=""http://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/js/bootstrap.min.js""></script>
<script src=""http://cdnjs.cloudflare.com/ajax/libs/bootstrap-table/1.9.1/bo");
            WriteLiteral(@"otstrap-table.min.js""></script>
<script src=""http://cdnjs.cloudflare.com/ajax/libs/bootstrap-table/1.9.1/locale/bootstrap-table-pl-PL.min.js""></script>
<script src=""http://cdnjs.cloudflare.com/ajax/libs/bootstrap-table/1.9.1/extensions/filter/bootstrap-table-filter.min.js""></script>
<script src=""http://cdnjs.cloudflare.com/ajax/libs/bootstrap-table/1.9.1/extensions/filter-control/bootstrap-table-filter-control.min.js""></script>

        

<div  style=""text-align: center"">
<h1>Cottages</h1>
</div>

<table id=""table"" class=""table-striped"" 
           data-toggle=""table""
           data-search=""true""
           data-filter-control=""true"">
    <thead >
        <tr>
            <th class=""th-sm"" data-field=""name"" data-filter-control=""input"" data-sortable=""true"">
                ");
#nullable restore
#line 39 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th class=\"th-sm\" data-field=\"address\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                ");
#nullable restore
#line 43 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th class=\"th-sm\" data-field=\"country\" data-filter-control=\"input\" data-sortable=\"true\"> \r\n                ");
#nullable restore
#line 47 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th >\r\n\r\n            <th class=\"th-sm\" data-field=\"city\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                ");
#nullable restore
#line 51 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th class=\"th-sm\" data-field=\"averageScore\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                ");
#nullable restore
#line 55 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.AverageScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th-sm\" data-field=\"rules\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                ");
#nullable restore
#line 58 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.Rules));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th-sm\" data-field=\"price\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                ");
#nullable restore
#line 61 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th-sm\" data-field=\"duration\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                ");
#nullable restore
#line 64 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th-sm\" data-field=\"startDate\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                ");
#nullable restore
#line 67 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 74 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n           \r\n            <td>\r\n                ");
#nullable restore
#line 90 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(modelItem => item.AverageScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 93 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rules));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n             <td>\r\n                ");
#nullable restore
#line 96 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(model => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 99 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(model => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 102 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(model => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 105 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(model => item.Tags));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bd3e7f2ea635cb858adfae25d1f8ffddb1a8769313977", async() => {
                WriteLiteral("Add Tags");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 108 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 111 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IsaProject.Models.DTO.AppointmentDTO>> Html { get; private set; }
    }
}
#pragma warning restore 1591
