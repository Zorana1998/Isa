#pragma checksum "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24a65fae817ebfcecb2c7771d97054ccafb7196a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Adventures_GetAvailableAdventure), @"mvc.1.0.view", @"/Views/Adventures/GetAvailableAdventure.cshtml")]
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
#line 1 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\_ViewImports.cshtml"
using IsaProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\_ViewImports.cshtml"
using IsaProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
using IsaProject.Models.Entities.Users;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24a65fae817ebfcecb2c7771d97054ccafb7196a", @"/Views/Adventures/GetAvailableAdventure.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790487734dbc32ba39762cf2cc8c5b9e65bff25d", @"/Views/_ViewImports.cshtml")]
    public class Views_Adventures_GetAvailableAdventure : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IsaProject.Models.DTO.AppointmentDTO>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TakeAppointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 8 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
  
    ViewData["Title"] = "GetAvailableAdventure";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Ships</h1>\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 18 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 21 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 24 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 27 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 30 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayNameFor(model => model.AverageScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 33 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayNameFor(model => model.Rules));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 36 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 39 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 42 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayNameFor(model => model.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 48 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 51 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 54 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 57 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 60 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n           \n            <td>\n                ");
#nullable restore
#line 64 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayFor(modelItem => item.AverageScore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 67 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayFor(modelItem => item.Rules));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n             <td>\n                ");
#nullable restore
#line 70 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayFor(model => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 73 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayFor(model => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 76 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
           Write(Html.DisplayFor(model => item.StartDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24a65fae817ebfcecb2c7771d97054ccafb7196a11214", async() => {
                WriteLiteral("Schedule");
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
#line 79 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
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
            WriteLiteral("\n            </td>\n        </tr>\n");
#nullable restore
#line 82 "C:\Users\ZoranaStamenković\Desktop\New folder\Isa-main\IsaProject\Views\Adventures\GetAvailableAdventure.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
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