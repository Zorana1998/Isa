#pragma checksum "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTagsUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "142508803158a5ae33cd6dd04951612c7d00d23e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointments_AddTagsUser), @"mvc.1.0.view", @"/Views/Appointments/AddTagsUser.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"142508803158a5ae33cd6dd04951612c7d00d23e", @"/Views/Appointments/AddTagsUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790487734dbc32ba39762cf2cc8c5b9e65bff25d", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointments_AddTagsUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IsaProject.Models.Entities.Tag>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTagsUser.cshtml"
  
    ViewData["Title"] = "AddTagsUser";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Add tags user</h1>\n\n<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 13 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTagsUser.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n");
#nullable restore
#line 19 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTagsUser.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                <input type=\"checkbox\"");
            BeginWriteAttribute("id", "  id=\"", 421, "\"", 435, 1);
#nullable restore
#line 22 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTagsUser.cshtml"
WriteAttributeValue("", 427, item.Id, 427, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\n                ");
#nullable restore
#line 23 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTagsUser.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                <button type=\"submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 567, "\"", 596, 3);
            WriteAttributeValue("", 577, "something(", 577, 10, true);
#nullable restore
#line 26 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTagsUser.cshtml"
WriteAttributeValue("", 587, item.Id, 587, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 595, ")", 595, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Submit</button>\n                \n            </td>\n        </tr>\n");
#nullable restore
#line 30 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTagsUser.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </tbody>
   
<button type=""Schedule"" onclick=""schedule()"">Submit</button>

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
#line 45 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTagsUser.cshtml"
         Write(Url.Action("AddTagsUser", "Appointments"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
        async: true,
        success: function(){
                    location.reload();
                }
    });

    }

    function schedule() {
        var id = id;
        var url = window.location.pathname;
        var id = url.substring(url.lastIndexOf('/') + 1);
        $.ajax({
        // do the rest of work here
        type: ""POST"",
        data: {id: id},
        url: '");
#nullable restore
#line 62 "C:\Users\Zorana Stamenković\Desktop\New folder\Isa\IsaProject\Views\Appointments\AddTagsUser.cshtml"
         Write(Url.Action("TakeAppointment", "Appointments"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\n        async: true\n    });\n\n}\n    \n\n    \n</script>");
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
