#pragma checksum "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7f130951617cce41827298c62a597eba4254b05"
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
#line 1 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\_ViewImports.cshtml"
using IsaProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\_ViewImports.cshtml"
using IsaProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7f130951617cce41827298c62a597eba4254b05", @"/Views/Cottages/GetAvailableCottages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790487734dbc32ba39762cf2cc8c5b9e65bff25d", @"/Views/_ViewImports.cshtml")]
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
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
  
    ViewData["Title"] = "GetAvailableCottages";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Cottages</h1>\n<table class=\"table\" >\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 17 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 20 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 23 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 26 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 29 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.AverageScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 32 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.Rules));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 35 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 38 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 41 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 47 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 50 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 53 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 56 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 59 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n           \n            <td>\n                ");
#nullable restore
#line 63 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(modelItem => item.AverageScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 66 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rules));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n             <td>\n                ");
#nullable restore
#line 69 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(model => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 72 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(model => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 75 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(model => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 78 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(model => item.Tags));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f7f130951617cce41827298c62a597eba4254b0511464", async() => {
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
#line 81 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
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
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 84 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
           Write(Html.DisplayFor(model => item.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 87 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Cottages\GetAvailableCottages.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n\n");
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
