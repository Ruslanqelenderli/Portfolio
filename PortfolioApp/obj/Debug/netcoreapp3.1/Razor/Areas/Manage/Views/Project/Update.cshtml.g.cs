#pragma checksum "D:\asp.net core\PortfolioApp\Areas\Manage\Views\Project\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a11208c7e90eabcdc535be659b15fc501b541d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Project_Update), @"mvc.1.0.view", @"/Areas/Manage/Views/Project/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a11208c7e90eabcdc535be659b15fc501b541d1", @"/Areas/Manage/Views/Project/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Project_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PortfolioApp.Models.ViewModels.ProjectUpdateViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\asp.net core\PortfolioApp\Areas\Manage\Views\Project\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Areas/Manage/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Update</h1>

<h4>Project</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form enctype=""multipart/form-data"" asp-controller=""Project"" asp-action=""Update"" method=""post"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label"">Name</label>
                <input");
            BeginWriteAttribute("value", " value=\"", 579, "\"", 607, 1);
#nullable restore
#line 18 "D:\asp.net core\PortfolioApp\Areas\Manage\Views\Project\Update.cshtml"
WriteAttributeValue("", 587, Model.Projects.Name, 587, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Name"" asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Photo"" class=""control-label"">Photo</label>
                <input");
            BeginWriteAttribute("value", " value=\"", 894, "\"", 927, 1);
#nullable restore
#line 23 "D:\asp.net core\PortfolioApp\Areas\Manage\Views\Project\Update.cshtml"
WriteAttributeValue("", 902, Model.Projects.PhotoName, 902, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""file"" accept=""image/*"" name=""Photo"" asp-for=""Photo"" class=""form-control"" />
                <span asp-validation-for=""Photo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Info"" class=""control-label"">Info</label>
                <input");
            BeginWriteAttribute("value", " value=\"", 1244, "\"", 1272, 1);
#nullable restore
#line 28 "D:\asp.net core\PortfolioApp\Areas\Manage\Views\Project\Update.cshtml"
WriteAttributeValue("", 1252, Model.Projects.Info, 1252, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Info"" asp-for=""Info"" class=""form-control"" />
                <span asp-validation-for=""Info"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreateDate"" class=""control-label"">CreateDate</label>
                <input");
            BeginWriteAttribute("value", " value=\"", 1569, "\"", 1603, 1);
#nullable restore
#line 33 "D:\asp.net core\PortfolioApp\Areas\Manage\Views\Project\Update.cshtml"
WriteAttributeValue("", 1577, Model.Projects.CreateDate, 1577, 26, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" type=""date"" name=""CreateDate"" asp-for=""CreateDate"" class=""form-control"" />
                <span asp-validation-for=""CreateDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Url"" class=""control-label"">Url</label>
                <input");
            BeginWriteAttribute("value", " value=\"", 1916, "\"", 1943, 1);
#nullable restore
#line 38 "D:\asp.net core\PortfolioApp\Areas\Manage\Views\Project\Update.cshtml"
WriteAttributeValue("", 1924, Model.Projects.Url, 1924, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Url"" asp-for=""Url"" class=""form-control"" />
                <span asp-validation-for=""Url"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Client"" class=""control-label"">Client</label>
                <input");
            BeginWriteAttribute("value", " value=\"", 2229, "\"", 2259, 1);
#nullable restore
#line 43 "D:\asp.net core\PortfolioApp\Areas\Manage\Views\Project\Update.cshtml"
WriteAttributeValue("", 2237, Model.Projects.Client, 2237, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" name=""Client"" asp-for=""Client"" class=""form-control"" />
                <span asp-validation-for=""Client"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Category"" class=""control-label"">Category</label>
                <select  name=""ProjectCategoryId"" asp-for=""ProjectCategoryId"" class=""form-control"">
                    <option>Please select one</option>
");
#nullable restore
#line 50 "D:\asp.net core\PortfolioApp\Areas\Manage\Views\Project\Update.cshtml"
                     foreach (var item in Model.ProjectCategories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <option");
            BeginWriteAttribute("value", " value=\"", 2815, "\"", 2831, 1);
#nullable restore
#line 52 "D:\asp.net core\PortfolioApp\Areas\Manage\Views\Project\Update.cshtml"
WriteAttributeValue("", 2823, item.Id, 2823, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 52 "D:\asp.net core\PortfolioApp\Areas\Manage\Views\Project\Update.cshtml"
                                            Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 53 "D:\asp.net core\PortfolioApp\Areas\Manage\Views\Project\Update.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </select>


                <span asp-validation-for=""ProjectCategoryId"" class=""text-danger""></span>
            </div>
            <input type=""hidden"" asp-for=""Id"" />

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PortfolioApp.Models.ViewModels.ProjectUpdateViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
