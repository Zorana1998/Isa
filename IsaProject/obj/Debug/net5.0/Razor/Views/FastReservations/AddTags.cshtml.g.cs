#pragma checksum "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\AddTags.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "595a182c7333ea8b1583e8fd1af7c4a4b2cbdf04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FastReservations_AddTags), @"mvc.1.0.view", @"/Views/FastReservations/AddTags.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"595a182c7333ea8b1583e8fd1af7c4a4b2cbdf04", @"/Views/FastReservations/AddTags.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6635b82fd1a99e807e6407a136d85c2294a33dd1", @"/Views/_ViewImports.cshtml")]
    public class Views_FastReservations_AddTags : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IsaProject.Models.Entities.Tag>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\AddTags.cshtml"
  
    ViewData["Title"] = "AddTags";

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
<h1>Add tags</h1>
</div>

<table id=""table"" class=""table-striped"" 
           data-toggle=""table""
           data-search=""true""
           data-filter-control=""true"">
    <thead>
        <tr>
            <th class=""th-sm"" data-field=""name"" data-filter-control=""input"" data-sortable=""true"">
                ");
#nullable restore
#line 32 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\AddTags.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th-sm\" data-field=\"price\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                ");
#nullable restore
#line 35 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\AddTags.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
#nullable restore
#line 37 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\AddTags.cshtml"
             if (Model.Count()!=0){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th></th>\r\n");
#nullable restore
#line 39 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\AddTags.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 43 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\AddTags.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                \r\n                ");
#nullable restore
#line 47 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\AddTags.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\AddTags.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <button type=\"submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2578, "\"", 2607, 3);
            WriteAttributeValue("", 2588, "something(", 2588, 10, true);
#nullable restore
#line 53 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\AddTags.cshtml"
WriteAttributeValue("", 2598, item.Id, 2598, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2606, ")", 2606, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Submit</button>\r\n                \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 57 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\AddTags.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>


</table>
<script>
    function something(id) {
        var id = id;
        var url = window.location.pathname;
        var appointmentId = url.substring(url.lastIndexOf('/') + 1);
        $.ajax({
        // do the rest of work here
        type: ""POST"",
        data: {id: id, appointmentId: appointmentId},
        url: '");
#nullable restore
#line 71 "C:\Users\Zorana Stamenković\Desktop\isaa\Isa\IsaProject\Views\FastReservations\AddTags.cshtml"
         Write(Url.Action("AddTags", "Appointments"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n        async: true,\r\n        success: function(){\r\n                    location.reload();\r\n                }\r\n    });\r\n\r\n    \r\n}\r\n    \r\n\r\n    \r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IsaProject.Models.Entities.Tag>> Html { get; private set; }
    }
}
#pragma warning restore 1591
