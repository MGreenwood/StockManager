#pragma checksum "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aedbf78e27384adcc475f176f22abf79b862b362"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserView), @"mvc.1.0.view", @"/Views/Home/UserView.cshtml")]
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
#line 1 "C:\Users\Matt\source\repos\StockManager\Views\_ViewImports.cshtml"
using StockManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Matt\source\repos\StockManager\Views\_ViewImports.cshtml"
using StockManager.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
using StockManager.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aedbf78e27384adcc475f176f22abf79b862b362", @"/Views/Home/UserView.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"894bc754e9db06170366b6fd6fc0e8a437ebbb57", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserView : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HomeController.Security>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            DefineSection("Styles", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "aedbf78e27384adcc475f176f22abf79b862b3624029", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
  
    ViewData["Title"] = "";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n\r\n");
            WriteLiteral("\r\n    <h2>\r\n        User information for ");
#nullable restore
#line 16 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
                        Write(ViewBag.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </h2>\r\n    <table>\r\n        <tr>\r\n            <th>Symbol</th>\r\n            <th>Shares</th>\r\n            <th>Purchase Price</th>\r\n            <th>Current Price</th>\r\n            <th>Profit</th>\r\n        </tr>\r\n");
#nullable restore
#line 26 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
      
        decimal net = 0.0M;
        foreach (HomeController.Security security in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 618, "\"", 676, 2);
            WriteAttributeValue("", 625, "http://www.finance.yahoo.com/quote/", 625, 35, true);
#nullable restore
#line 31 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
WriteAttributeValue("", 660, security.ticker, 660, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\"> ");
#nullable restore
#line 31 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
                                                                                              Write(security.ticker);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a></td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
               Write(security.numShares);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>$");
#nullable restore
#line 33 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
                Write(string.Format("{0:0.00}",security.purchasePrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>$");
#nullable restore
#line 34 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
                Write(string.Format("{0:0.00}",security.currentPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 35 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
                   
                    decimal val = (security.currentPrice - security.purchasePrice) * security.numShares;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>$");
#nullable restore
#line 38 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
                Write(string.Format("{0:0.00}",val));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 39 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
                  
                    net += val;
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tr>\r\n");
#nullable restore
#line 43 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
        }


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td></td>\r\n            <td></td>\r\n            <td></td>\r\n            <td>NET</td>\r\n            <td>$");
#nullable restore
#line 50 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
            Write(string.Format("{0:0.00}",net));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
            WriteLiteral("    </table>\r\n\r\n    <!-- If db empty -->\r\n");
#nullable restore
#line 57 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
     if (Model.Count() == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Nothing to show</p>\r\n");
#nullable restore
#line 60 "C:\Users\Matt\source\repos\StockManager\Views\Home\UserView.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HomeController.Security>> Html { get; private set; }
    }
}
#pragma warning restore 1591
