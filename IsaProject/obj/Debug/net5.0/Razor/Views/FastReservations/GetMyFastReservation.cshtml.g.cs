#pragma checksum "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8ea7e4bc081d10a19bbe94585482099c437aae3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FastReservations_GetMyFastReservation), @"mvc.1.0.view", @"/Views/FastReservations/GetMyFastReservation.cshtml")]
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
#line 1 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\_ViewImports.cshtml"
using IsaProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\_ViewImports.cshtml"
using IsaProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8ea7e4bc081d10a19bbe94585482099c437aae3", @"/Views/FastReservations/GetMyFastReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6635b82fd1a99e807e6407a136d85c2294a33dd1", @"/Views/_ViewImports.cshtml")]
    public class Views_FastReservations_GetMyFastReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IsaProject.Models.Entities.FastReservation>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml"
  
    ViewData["Title"] = "GetMyFastReservation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Reservation</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml"
           Write(Html.DisplayNameFor(model => model.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml"
           Write(Html.DisplayNameFor(model => model.DurationDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml"
           Write(Html.DisplayNameFor(model => model.MaxNumberOfPeople));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml"
           Write(Html.DisplayFor(modelItem => item.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml"
           Write(Html.DisplayFor(modelItem => item.DurationDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaxNumberOfPeople));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 43 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml"
                 if ((item.Start - DateTime.Now).Days > 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button");
            BeginWriteAttribute("id", " id = \"", 1243, "\"", 1258, 1);
#nullable restore
#line 45 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml"
WriteAttributeValue("", 1250, item.Id, 1250, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Cancel reservation </button>\r\n");
#nullable restore
#line 46 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                \r\n            </td>\r\n           \r\n\r\n        </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\GetMyFastReservation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IsaProject.Models.Entities.FastReservation>> Html { get; private set; }
    }
}
#pragma warning restore 1591
