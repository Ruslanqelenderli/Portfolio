#pragma checksum "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65dc502b189cd3135b8c759ecd9221a2d6bba2d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Abouts_Index), @"mvc.1.0.view", @"/Areas/Manage/Views/Abouts/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65dc502b189cd3135b8c759ecd9221a2d6bba2d8", @"/Areas/Manage/Views/Abouts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57218c316b6921e2cd61027a2387edc31a2d9471", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Abouts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PortfolioApp.Models.About>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("100"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Manage/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Index</h2>\r\n");
#nullable restore
#line 9 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
 if (Model.Count() == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
#nullable restore
#line 12 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
   Write(Html.ActionLink("Create New", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 14 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>\r\n            ");
#nullable restore
#line 19 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 22 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 25 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 28 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 31 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 34 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Work));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 37 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 40 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Gmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 43 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.University));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 46 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.AboutHimself));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 49 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.HowItStarted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 52 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.RelatedToTheFuture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 55 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 58 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
       Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n        <th></th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 63 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 67 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 70 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 73 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 76 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 79 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 82 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Work));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 85 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 88 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Gmail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 91 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.University));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AboutHimself));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td>\r\n                ");
#nullable restore
#line 96 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.HowItStarted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            <td>\r\n                ");
#nullable restore
#line 98 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.RelatedToTheFuture));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 102 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n\r\n\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "65dc502b189cd3135b8c759ecd9221a2d6bba2d812638", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2927, "~/Uploads/AboutImg/", 2927, 19, true);
#nullable restore
#line 108 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
AddHtmlAttributeValue("", 2946, item.Photo, 2946, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
#nullable restore
#line 109 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
           Write(Html.ActionLink("Edit", "Update", new { id = item.Id }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 115 "D:\Core\PortfolioApp\PortfolioApp\Areas\Manage\Views\Abouts\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PortfolioApp.Models.About>> Html { get; private set; }
    }
}
#pragma warning restore 1591
