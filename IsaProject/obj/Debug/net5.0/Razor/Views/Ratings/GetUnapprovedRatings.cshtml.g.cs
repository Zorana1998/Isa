#pragma checksum "C:\Users\ZoranaStamenković\Desktop\New folder (5)\Isa-main\IsaProject\Views\Ratings\GetUnapprovedRatings.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26adf3d0b3ebd44ac96250e690eb3e257f81a4ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ratings_GetUnapprovedRatings), @"mvc.1.0.view", @"/Views/Ratings/GetUnapprovedRatings.cshtml")]
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
#line 1 "C:\Users\ZoranaStamenković\Desktop\New folder (5)\Isa-main\IsaProject\Views\_ViewImports.cshtml"
using IsaProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ZoranaStamenković\Desktop\New folder (5)\Isa-main\IsaProject\Views\_ViewImports.cshtml"
using IsaProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26adf3d0b3ebd44ac96250e690eb3e257f81a4ff", @"/Views/Ratings/GetUnapprovedRatings.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790487734dbc32ba39762cf2cc8c5b9e65bff25d", @"/Views/_ViewImports.cshtml")]
    public class Views_Ratings_GetUnapprovedRatings : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Isa.Models.Rating>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Approved", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\ZoranaStamenković\Desktop\New folder (5)\Isa-main\IsaProject\Views\Ratings\GetUnapprovedRatings.cshtml"
  
    ViewData["Title"] = "GetUnapprovedRatings";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Index</h1>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 13 "C:\Users\ZoranaStamenković\Desktop\New folder (5)\Isa-main\IsaProject\Views\Ratings\GetUnapprovedRatings.cshtml"
           Write(Html.DisplayNameFor(model => model.EntityID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 16 "C:\Users\ZoranaStamenković\Desktop\New folder (5)\Isa-main\IsaProject\Views\Ratings\GetUnapprovedRatings.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "C:\Users\ZoranaStamenković\Desktop\New folder (5)\Isa-main\IsaProject\Views\Ratings\GetUnapprovedRatings.cshtml"
           Write(Html.DisplayNameFor(model => model.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 25 "C:\Users\ZoranaStamenković\Desktop\New folder (5)\Isa-main\IsaProject\Views\Ratings\GetUnapprovedRatings.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 28 "C:\Users\ZoranaStamenković\Desktop\New folder (5)\Isa-main\IsaProject\Views\Ratings\GetUnapprovedRatings.cshtml"
           Write(Html.DisplayFor(modelItem => item.EntityID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 31 "C:\Users\ZoranaStamenković\Desktop\New folder (5)\Isa-main\IsaProject\Views\Ratings\GetUnapprovedRatings.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 34 "C:\Users\ZoranaStamenković\Desktop\New folder (5)\Isa-main\IsaProject\Views\Ratings\GetUnapprovedRatings.cshtml"
           Write(Html.DisplayFor(modelItem => item.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26adf3d0b3ebd44ac96250e690eb3e257f81a4ff6296", async() => {
                WriteLiteral("Approved");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\ZoranaStamenković\Desktop\New folder (5)\Isa-main\IsaProject\Views\Ratings\GetUnapprovedRatings.cshtml"
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
            WriteLiteral(" \n            </td>\n        </tr>\n");
#nullable restore
#line 40 "C:\Users\ZoranaStamenković\Desktop\New folder (5)\Isa-main\IsaProject\Views\Ratings\GetUnapprovedRatings.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Isa.Models.Rating>> Html { get; private set; }
    }
}
#pragma warning restore 1591
