#pragma checksum "D:\asp.net core\PortfolioApp\Areas\Manage\Views\ProjectCategory\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "872eca14090ec1fd7244fee6b1ef709a4bc9dd70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_ProjectCategory_Update), @"mvc.1.0.view", @"/Areas/Manage/Views/ProjectCategory/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"872eca14090ec1fd7244fee6b1ef709a4bc9dd70", @"/Areas/Manage/Views/ProjectCategory/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_ProjectCategory_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PortfolioApp.Models.ProjectCategory>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\asp.net core\PortfolioApp\Areas\Manage\Views\ProjectCategory\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Areas/Manage/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Update</h1>

<h4>ProjectCategory</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-controller=""ProjectCategory""  asp-action=""Update"" method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label"">Name</label>
                <input name=""Name""");
            BeginWriteAttribute("value", " value=\"", 610, "\"", 629, 1);
#nullable restore
#line 19 "D:\asp.net core\PortfolioApp\Areas\Manage\Views\ProjectCategory\Update.cshtml"
WriteAttributeValue("", 618, Model.Name, 618, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>


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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PortfolioApp.Models.ProjectCategory> Html { get; private set; }
    }
}
#pragma warning restore 1591
