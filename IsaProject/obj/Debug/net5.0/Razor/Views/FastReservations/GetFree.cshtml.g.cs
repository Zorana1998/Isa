#pragma checksum "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a84afc7e6f8938cddd0264d4a7d279a1efaefcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FastReservations_GetFree), @"mvc.1.0.view", @"/Views/FastReservations/GetFree.cshtml")]
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
#line 1 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\_ViewImports.cshtml"
using IsaProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\_ViewImports.cshtml"
using IsaProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
using IsaProject.Models.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a84afc7e6f8938cddd0264d4a7d279a1efaefcc", @"/Views/FastReservations/GetFree.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790487734dbc32ba39762cf2cc8c5b9e65bff25d", @"/Views/_ViewImports.cshtml")]
    public class Views_FastReservations_GetFree : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IsaProject.Models.Entities.FastReservation>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "TakeAppointment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 10 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
  
    ViewData["Title"] = "GetFree";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Free fast reservation</h1>\n\n");
#nullable restore
#line 16 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
 if (SignInManager.IsSignedIn(User))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
     if (((await AuthorizationService.AuthorizeAsync(User, null, "CottageOwnerPolicy")).Succeeded) || (await AuthorizationService.AuthorizeAsync(User, null, "ShipOwnerPolicy")).Succeeded || (await AuthorizationService.AuthorizeAsync(User, null, "FishingInstructorPolicy")).Succeeded)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a84afc7e6f8938cddd0264d4a7d279a1efaefcc5537", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </p>\n");
#nullable restore
#line 23 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
     

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 31 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
           Write(Html.DisplayNameFor(model => model.NewPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 34 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
           Write(Html.DisplayNameFor(model => model.OwnerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 37 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
           Write(Html.DisplayNameFor(model => model.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 40 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
           Write(Html.DisplayNameFor(model => model.DurationDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 43 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
           Write(Html.DisplayNameFor(model => model.MaxNumberOfPeople));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 46 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 52 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 55 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
           Write(Html.DisplayFor(modelItem => item.NewPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 58 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
           Write(Html.DisplayFor(modelItem => item.OwnerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 61 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
           Write(Html.DisplayFor(modelItem => item.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 64 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
           Write(Html.DisplayFor(modelItem => item.DurationDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 67 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaxNumberOfPeople));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 70 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8a84afc7e6f8938cddd0264d4a7d279a1efaefcc11517", async() => {
                WriteLiteral("Schedule");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
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
#line 76 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\FastReservations\GetFree.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<AppUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<AppUser> SignInManager { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IsaProject.Models.Entities.FastReservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
