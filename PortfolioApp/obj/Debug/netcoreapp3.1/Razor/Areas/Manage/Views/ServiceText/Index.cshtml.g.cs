#pragma checksum "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\ServiceText\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eabecb7138930d2a87a795e83a9935f24b23a300"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_ServiceText_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/ServiceText/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eabecb7138930d2a87a795e83a9935f24b23a300", @"/Areas/Manage/Views/ServiceText/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_ServiceText_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PortfolioApp.Models.ServiceText>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\ServiceText\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Manage/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n");
#nullable restore
#line 9 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\ServiceText\Index.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 12 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\ServiceText\Index.cshtml"
   Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 14 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\ServiceText\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 19 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\ServiceText\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n\r\n        <th></th>\r\n    </tr>\r\n\r\n\r\n    <tr>\r\n        <td>\r\n            ");
#nullable restore
#line 28 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\ServiceText\Index.cshtml"
       Write(Html.DisplayFor(model => model.Text));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n\r\n        <td>\r\n            ");
#nullable restore
#line 32 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\ServiceText\Index.cshtml"
       Write(Html.ActionLink("Edit", "Update", new { id = Model.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n        </td>\r\n    </tr>\r\n\r\n\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PortfolioApp.Models.ServiceText> Html { get; private set; }
    }
}
#pragma warning restore 1591
