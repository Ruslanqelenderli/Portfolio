#pragma checksum "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e85203215e810ab27c97b4ea3c931e569506bfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Education_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Education/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e85203215e810ab27c97b4ea3c931e569506bfd", @"/Areas/Manage/Views/Education/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Education_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PortfolioApp.Models.Education>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Manage/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n    <p>\r\n        ");
#nullable restore
#line 11 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml"
   Write(Html.ActionLink("Create New", "Add"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 18 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.OrganizationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 21 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 24 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Startdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 27 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        \r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 33 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.OrganizationName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Info));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Startdate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EndDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n            <td>\r\n                ");
#nullable restore
#line 50 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n                ");
#nullable restore
#line 51 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml"
           Write(Html.ActionLink("Edit", "Update", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 54 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Education\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PortfolioApp.Models.Education>> Html { get; private set; }
    }
}
#pragma warning restore 1591