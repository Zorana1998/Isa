#pragma checksum "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTags.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ac491c604f074d44b09d3ab3d6654791465a321"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointments_AddTags), @"mvc.1.0.view", @"/Views/Appointments/AddTags.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ac491c604f074d44b09d3ab3d6654791465a321", @"/Views/Appointments/AddTags.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790487734dbc32ba39762cf2cc8c5b9e65bff25d", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointments_AddTags : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IsaProject.Models.Entities.Tag>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
  
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
<script src=""http://cdnjs.cloudflare.com/ajax/libs/bootstrap-table/1.9.1/bootstrap-ta");
            WriteLiteral(@"ble.min.js""></script>
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
#line 32 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th class=\"th-sm\" data-field=\"price\" data-filter-control=\"input\" data-sortable=\"true\">\n                ");
#nullable restore
#line 35 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n");
#nullable restore
#line 37 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
             if (Model.Count()!=0){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th></th>\n");
#nullable restore
#line 39 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 43 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                \n                ");
#nullable restore
#line 47 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 50 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                <button type=\"submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2526, "\"", 2555, 3);
            WriteAttributeValue("", 2536, "something(", 2536, 10, true);
#nullable restore
#line 53 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
WriteAttributeValue("", 2546, item.Id, 2546, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2554, ")", 2554, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Submit</button>\n                \n            </td>\n        </tr>\n");
#nullable restore
#line 57 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
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
#line 71 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
         Write(Url.Action("AddTags", "Appointments"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n        async: true,\n        success: function(){\n                    location.reload();\n                }\n    });\n\n    \n}\n    \n\n    \n</script>");
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
