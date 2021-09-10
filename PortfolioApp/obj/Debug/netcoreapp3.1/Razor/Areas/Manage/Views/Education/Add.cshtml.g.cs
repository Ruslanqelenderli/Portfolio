#pragma checksum "D:\asp.net core\PortfolioApp\Areas\Manage\Views\Education\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d5d43bea51c0921b69c3c43f24827ce4bb2f8fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Education_Add), @"mvc.1.0.view", @"/Areas/Manage/Views/Education/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d5d43bea51c0921b69c3c43f24827ce4bb2f8fe", @"/Areas/Manage/Views/Education/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Education_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PortfolioApp.Models.Education>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\asp.net core\PortfolioApp\Areas\Manage\Views\Education\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Areas/Manage/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Add</h1>

<h4>Education</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-controller=""Education"" area=""null"" asp-action=""Add"" method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""OrganizationName"" class=""control-label"">Organization Name</label>
                <input name=""OrganizationName"" asp-for=""OrganizationName"" class=""form-control"" />
                <span asp-validation-for=""OrganizationName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Info"" class=""control-label"">Info</label>
                <input name=""Info"" asp-for=""Info"" class=""form-control"" />
                <span asp-validation-for=""Info"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Startdate"" class=""control-label"">Startdate</label>
              ");
            WriteLiteral(@"  <input type=""date"" name=""Startdate"" asp-for=""Startdate"" class=""form-control"" />
                <span asp-validation-for=""Startdate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""EndDate"" class=""control-label"">EndDate</label>
                <input type=""date"" name=""EndDate"" asp-for=""EndDate"" class=""form-control"" />
                <span asp-validation-for=""EndDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PortfolioApp.Models.Education> Html { get; private set; }
    }
}
#pragma warning restore 1591
