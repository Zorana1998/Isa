#pragma checksum "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a9f37f71335026bcf5586c7eea9eb1896cd788d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointments_GetMyHistoryReservationAdventures), @"mvc.1.0.view", @"/Views/Appointments/GetMyHistoryReservationAdventures.cshtml")]
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
#line 1 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\_ViewImports.cshtml"
using IsaProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\_ViewImports.cshtml"
using IsaProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a9f37f71335026bcf5586c7eea9eb1896cd788d", @"/Views/Appointments/GetMyHistoryReservationAdventures.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6635b82fd1a99e807e6407a136d85c2294a33dd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointments_GetMyHistoryReservationAdventures : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IsaProject.Models.ScheduledAppointment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
  
    ViewData["Title"] = "GetMyHistoryReservationAdventures";

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

");
#nullable restore
#line 21 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div  style=\"text-align: center\">\r\n    <h3>No reservation history for adventures</h3>\r\n    </div>\r\n");
#nullable restore
#line 26 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div  style=\"text-align: center\">\r\n    <h1>Reservation history</h1>\r\n    </div>\r\n");
            WriteLiteral(@"    <table id=""table"" class=""table-striped"" 
           data-toggle=""table""
           data-search=""true""
           data-filter-control=""true"">
        <thead>
            <tr>
                <th class=""th-sm"" data-field=""start"" data-filter-control=""input"" data-sortable=""true"">
                    ");
#nullable restore
#line 41 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
               Write(Html.DisplayNameFor(model => model.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"th-sm\" data-field=\"numberOfPeople\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                    ");
#nullable restore
#line 44 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
               Write(Html.DisplayNameFor(model => model.NumberOfPeople));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"th-sm\" data-field=\"entityID\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
               Write(Html.DisplayNameFor(model => model.EntityID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"th-sm\" data-field=\"Price\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                    ");
#nullable restore
#line 50 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th class=\"th-sm\" data-field=\"duration\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                    ");
#nullable restore
#line 53 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
               Write(Html.DisplayNameFor(model => model.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 59 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
     foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 62 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
               Write(Html.DisplayFor(modelItem => item.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 65 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumberOfPeople));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 68 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
               Write(Html.DisplayFor(modelItem => item.EntityID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 71 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
               Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 74 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
               Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n           \r\n\r\n            </tr>\r\n");
#nullable restore
#line 79 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 82 "C:\Users\Zorana Stamenković\Desktop\isaaa\Isa\IsaProject\Views\Appointments\GetMyHistoryReservationAdventures.cshtml"
}

#line default
#line hidden
#nullable disable
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
