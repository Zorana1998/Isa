#pragma checksum "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f701c354fbabf29f0fa92a69f45fd2b62582d1d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Appointments_GetMyAppointmentOwner), @"mvc.1.0.view", @"/Views/Appointments/GetMyAppointmentOwner.cshtml")]
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
#line 1 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\_ViewImports.cshtml"
using IsaProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\_ViewImports.cshtml"
using IsaProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f701c354fbabf29f0fa92a69f45fd2b62582d1d", @"/Views/Appointments/GetMyAppointmentOwner.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6635b82fd1a99e807e6407a136d85c2294a33dd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Appointments_GetMyAppointmentOwner : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IsaProject.Models.Entities.Appointment>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddTags", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
  
    ViewData["Title"] = "GetMyAppointmentOwner";

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
<h1>My appointments</h1>
</div>

<table id=""table"" class=""table-striped"" 
           data-toggle=""table""
           data-search=""true""
           data-filter-control=""true"">
    <thead>
        <tr>
            <th class=""th-sm"" data-field=""ownerId"" data-filter-control=""input"" data-sortable=""true"">
                ");
#nullable restore
#line 33 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
           Write(Html.DisplayNameFor(model => model.OwnerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th-sm\" data-field=\"start\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                ");
#nullable restore
#line 36 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
           Write(Html.DisplayNameFor(model => model.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th-sm\" data-field=\"durationDays\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                ");
#nullable restore
#line 39 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
           Write(Html.DisplayNameFor(model => model.DurationDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th-sm\" data-field=\"maxNumberOfPeople\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                ");
#nullable restore
#line 42 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
           Write(Html.DisplayNameFor(model => model.MaxNumberOfPeople));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th class=\"th-sm\" data-field=\"price\" data-filter-control=\"input\" data-sortable=\"true\">\r\n                ");
#nullable restore
#line 45 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n");
#nullable restore
#line 47 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
             if (Model.Count()!=0){

#line default
#line hidden
#nullable disable
            WriteLiteral("            <th></th>\r\n");
#nullable restore
#line 49 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 53 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
           Write(Html.DisplayFor(modelItem => item.OwnerID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
           Write(Html.DisplayFor(modelItem => item.Start));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
           Write(Html.DisplayFor(modelItem => item.DurationDays));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
           Write(Html.DisplayFor(modelItem => item.MaxNumberOfPeople));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f701c354fbabf29f0fa92a69f45fd2b62582d1d10982", async() => {
                WriteLiteral("Add Tags");
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
#line 71 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
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
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 75 "C:\Users\ZoranaStamenković\Source\Repos\Isa\IsaProject\Views\Appointments\GetMyAppointmentOwner.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f701c354fbabf29f0fa92a69f45fd2b62582d1d13452", async() => {
                WriteLiteral("Create new appointment");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
