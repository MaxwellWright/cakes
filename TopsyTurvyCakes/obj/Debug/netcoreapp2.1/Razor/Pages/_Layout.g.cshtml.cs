#pragma checksum "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b1133d79dca86ad1eec21aec776ffaa403278fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TopsyTurvyCakes.Pages.Pages__Layout), @"mvc.1.0.view", @"/Pages/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/_Layout.cshtml", typeof(TopsyTurvyCakes.Pages.Pages__Layout))]
namespace TopsyTurvyCakes.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 2 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_ViewImports.cshtml"
using TopsyTurvyCakes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b1133d79dca86ad1eec21aec776ffaa403278fb", @"/Pages/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba8f809ddc3d35d6ecebb5ef446534fbcf0e5b4b", @"/Pages/_ViewImports.cshtml")]
    public class Pages__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(25, 124, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ce79f481578474484990095b9c57307", async() => {
                BeginContext(31, 50, true);
                WriteLiteral("\r\n    <title>Topsy Turvy Cake Design</title>\r\n    ");
                EndContext();
                BeginContext(81, 59, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a44b93a7871645d284c29216f95cc394", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(140, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(149, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(151, 1919, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a019ee2d99a941aabf372591e77ebca9", async() => {
                BeginContext(157, 674, true);
                WriteLiteral(@"
    <header class=""container site-header"">
        <div class=""row"">
            <h1 class=""main-logo""><a href=""/"">Topsy Turvy Cake Design</a></h1>
        </div>
        <div class=""row"">
            <nav class=""navbar"">
                <ul class=""nav nav-pills"">
                    <li><a href=""/About"">About</a></li>
                    <li><a href=""/Blog"">Blog</a></li>
                    <li><a class=""active"" href=""/"">Recipes</a></li>
                    <li><a href=""/Portfolio"">Portfolio</a></li>
                    <li><a href=""/Contact"">Contact</a></li>
                </ul>
                <ul class=""nav nav-pills"">
                    <li>
");
                EndContext();
#line 23 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                         if (!User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
                BeginContext(920, 64, true);
                WriteLiteral("                            <a href=\"/Account/Login\">Login</a>\r\n");
                EndContext();
#line 26 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(1068, 28, true);
                WriteLiteral("                            ");
                EndContext();
                BeginContext(1096, 333, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b585650bca444ba48f18a3a60b5162f4", async() => {
                    BeginContext(1116, 103, true);
                    WriteLiteral("\r\n                                <div class=\"input-group\">\r\n                                    <span>");
                    EndContext();
                    BeginContext(1220, 29, false);
#line 31 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                                     Write(User.Identity.IsAuthenticated);

#line default
#line hidden
                    EndContext();
                    BeginContext(1249, 173, true);
                    WriteLiteral("</span>\r\n                                    <button type=\"submit\" class=\"btn btn-link\">Logout</button>\r\n                                </div>\r\n                            ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1429, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 35 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                        }

#line default
#line hidden
                BeginContext(1458, 113, true);
                WriteLiteral("                    </li>\r\n                </ul>\r\n            </nav>\r\n        </div>\r\n        <div class=\"row\">\r\n");
                EndContext();
#line 41 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
             if (IsSectionDefined("Title"))
            {
                

#line default
#line hidden
                BeginContext(1648, 39, false);
#line 43 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
           Write(RenderSection("Title", required: false));

#line default
#line hidden
                EndContext();
#line 43 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                                                        
            }
            else
            {

#line default
#line hidden
                BeginContext(1737, 34, true);
                WriteLiteral("                <h2 class=\"title\">");
                EndContext();
                BeginContext(1772, 17, false);
#line 47 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                             Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(1789, 7, true);
                WriteLiteral("</h2>\r\n");
                EndContext();
#line 48 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
            }

#line default
#line hidden
                BeginContext(1811, 68, true);
                WriteLiteral("        </div>\r\n    </header>\r\n    <div class=\"container\">\r\n        ");
                EndContext();
                BeginContext(1880, 12, false);
#line 52 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1892, 117, true);
                WriteLiteral("\r\n\r\n    </div>\r\n    <footer>\r\n        <div class=\"text-center\">\r\n            <span class=\"text-muted\">Last Rendered: ");
                EndContext();
                BeginContext(2010, 12, false);
#line 57 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\_Layout.cshtml"
                                               Write(DateTime.Now);

#line default
#line hidden
                EndContext();
                BeginContext(2022, 41, true);
                WriteLiteral(" </span>\r\n        </div>\r\n    </footer>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2070, 9, true);
            WriteLiteral("\r\n</html>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IRecipesService RecipesService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
