#pragma checksum "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88e1610a1589ba605af716b87ebc908d03c8a760"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointments_GetMyReservation), @"mvc.1.0.view", @"/Views/Appointments/GetMyReservation.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88e1610a1589ba605af716b87ebc908d03c8a760", @"/Views/Appointments/GetMyReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790487734dbc32ba39762cf2cc8c5b9e65bff25d", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointments_GetMyReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IsaProject.Models.ScheduledAppointment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
  
    ViewData["Title"] = "GetMyReservation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Reservation</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayNameFor(model => model.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberOfPeople));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayNameFor(model => model.EntityID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 31 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayFor(modelItem => item.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumberOfPeople));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayFor(modelItem => item.EntityID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n");
#nullable restore
#line 49 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
                 if ((item.Start - DateTime.Now).Days > 3)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <button type=\"submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1434, "\"", 1460, 3);
            WriteAttributeValue("", 1444, "cancel(", 1444, 7, true);
#nullable restore
#line 51 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
WriteAttributeValue("", 1451, item.Id, 1451, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1459, ")", 1459, 1, true);
            EndWriteAttribute();
            WriteLiteral("> Cancel reservation </button>\r\n");
#nullable restore
#line 52 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n<script >\r\n    function cancel(id) {\r\n        $.ajax({\r\n        // do the rest of work here\r\n        type: \"POST\",\r\n        data: {id: id},\r\n        url: \'");
#nullable restore
#line 67 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\GetMyReservation.cshtml"
         Write(Url.Action("CancelReservation", "Appointments"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n        async: true\r\n    });\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IsaProject.Models.ScheduledAppointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
