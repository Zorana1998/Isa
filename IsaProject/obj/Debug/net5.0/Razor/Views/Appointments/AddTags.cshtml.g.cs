#pragma checksum "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\AddTags.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6e2bbd5d9a04d2717220e3a1b72b2aee7192cf6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6e2bbd5d9a04d2717220e3a1b72b2aee7192cf6", @"/Views/Appointments/AddTags.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"790487734dbc32ba39762cf2cc8c5b9e65bff25d", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointments_AddTags : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IsaProject.Models.Entities.Tag>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Tags", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
  
    ViewData["Title"] = "AddTags";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Add tags</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6e2bbd5d9a04d2717220e3a1b72b2aee7192cf64066", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 22 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <input type=\"checkbox\"");
            BeginWriteAttribute("id", "  id=\"", 509, "\"", 523, 1);
#nullable restore
#line 25 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
WriteAttributeValue("", 515, item.Id, 515, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                ");
#nullable restore
#line 26 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <button type=\"submit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 659, "\"", 688, 3);
            WriteAttributeValue("", 669, "something(", 669, 10, true);
#nullable restore
#line 29 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
WriteAttributeValue("", 679, item.Id, 679, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 687, ")", 687, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Submit</button>\r\n                \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 33 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
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
#line 49 "C:\Users\Zorana Stamenković\Desktop\IsaSolution\Isa\IsaProject\Views\Appointments\AddTags.cshtml"
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
