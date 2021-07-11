#pragma checksum "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Project\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c7259d3c3b38c0b393feecb7cbeb3057f764161"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Project_Add), @"mvc.1.0.view", @"/Areas/Manage/Views/Project/Add.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c7259d3c3b38c0b393feecb7cbeb3057f764161", @"/Areas/Manage/Views/Project/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Project_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PortfolioApp.Models.ProjectCategory>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Project\Add.cshtml"
  
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
        <form enctype=""multipart/form-data"" asp-controller=""Project"" asp-action=""Add"" method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label"">Name</label>
                <input name=""Name"" asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Photo"" class=""control-label"">Photo </label>
                <input type=""file"" accept=""image/*"" name=""Photo"" asp-for=""Photo"" class=""form-control"" />
                <span asp-validation-for=""Photo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Url"" class=""control-label"">Url</label>
                <input name=""Url"" as");
            WriteLiteral(@"p-for=""Url"" class=""form-control"" />
                <span asp-validation-for=""Url"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Client"" class=""control-label"">Client</label>
                <input name=""Client"" asp-for=""Client"" class=""form-control"" />
                <span asp-validation-for=""Client"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Info"" class=""control-label"">Info</label>
                <input name=""Info"" asp-for=""Info"" class=""form-control"" />
                <span asp-validation-for=""Info"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Category"" class=""control-label"">Category</label>
                <select name=""ProjectCategoryId"" asp-for=""ProjectCategoryId"" class=""form-control"">
                    <option>Please select one</option>
");
#nullable restore
#line 45 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Project\Add.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 2273, "\"", 2289, 1);
#nullable restore
#line 47 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Project\Add.cshtml"
WriteAttributeValue("", 2281, item.Id, 2281, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 47 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Project\Add.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 48 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Project\Add.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </select>


                <span asp-validation-for=""ProjectCategoryId"" class=""text-danger""></span>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PortfolioApp.Models.ProjectCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
