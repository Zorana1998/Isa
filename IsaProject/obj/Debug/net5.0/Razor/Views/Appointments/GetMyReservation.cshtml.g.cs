#pragma checksum "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\Appointments\GetMyReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf97cbd9f10b02714539f692236b0f1f25af8d55"
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
#line 1 "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\_ViewImports.cshtml"
using IsaProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\_ViewImports.cshtml"
using IsaProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf97cbd9f10b02714539f692236b0f1f25af8d55", @"/Views/Appointments/GetMyReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790487734dbc32ba39762cf2cc8c5b9e65bff25d", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointments_GetMyReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IsaProject.Models.Entities.Appointment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\Appointments\GetMyReservation.cshtml"
  
    ViewData["Title"] = "GetMyReservation";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Reservation</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayNameFor(model => model.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayNameFor(model => model.DurationDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayNameFor(model => model.MaxNumberOfPeople));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 28 "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\Appointments\GetMyReservation.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 31 "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayFor(modelItem => item.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 34 "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayFor(modelItem => item.DurationDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaxNumberOfPeople));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\Appointments\GetMyReservation.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <button");
            BeginWriteAttribute("[disabled]", " [disabled]=\"", 1152, "\"", 1188, 3);
            WriteAttributeValue("", 1165, "isDisabled(", 1165, 11, true);
#nullable restore
#line 43 "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\Appointments\GetMyReservation.cshtml"
WriteAttributeValue("", 1176, item.Start, 1176, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1187, ")", 1187, 1, true);
            EndWriteAttribute();
            WriteLiteral(" id = \"forExit\"> Cancel reservation </button>\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 47 "C:\Users\ZoranaStamenković\Desktop\Isa-main(4)\Isa-main\IsaProject\Views\Appointments\GetMyReservation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
</table>


<script >
    function isDisabled(startDate) {
        //Reference the Button.
        var btnSubmit = document.getElementById(""forExit"");

        const date1 = Date.now();
        const date2 = startDate;
        const diffTime = Math.abs(date2 - date1);
        const diffDays = Math.ceil(diffTime / (1000 * 60 * 60 * 24));
 
        //Verify the TextBox value.
        if (diffDays <= 3) {
            //Enable the TextBox when TextBox has value.
            btnSubmit.disabled = true;
        } else {
            //Disable the TextBox when TextBox is empty.
            btnSubmit.disabled = false;
        }
    };
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IsaProject.Models.Entities.Appointment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
