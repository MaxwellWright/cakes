#pragma checksum "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b95dfb184ef42fd1e97d7da5727143afd8a02bcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TopsyTurvyCakes.Pages.Pages_Recipe), @"mvc.1.0.razor-page", @"/Pages/Recipe.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Recipe.cshtml", typeof(TopsyTurvyCakes.Pages.Pages_Recipe), @"{id}")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b95dfb184ef42fd1e97d7da5727143afd8a02bcc", @"/Pages/Recipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba8f809ddc3d35d6ecebb5ef446534fbcf0e5b4b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Recipe : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(14, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
  
    var id = long.Parse((string)RouteData.Values["id"]);
    var recipe = await RecipesService.FindAsync(id);
    ViewData["Title"] = recipe.Name;

#line default
#line hidden
            DefineSection("Title", async() => {
                BeginContext(188, 57, true);
                WriteLiteral("\r\n    <h2 class=\"modal-title\">My Favorite Recipies</h2>\r\n");
                EndContext();
            }
            );
            BeginContext(332, 145, true);
            WriteLiteral("\r\n<div class=\"row recipe\">\r\n    <div class=\"col-md-8\">\r\n        <div class=\"col-md-12\">\r\n            <span class=\"description\">\r\n                ");
            EndContext();
            BeginContext(478, 18, false);
#line 17 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
           Write(recipe.Description);

#line default
#line hidden
            EndContext();
            BeginContext(496, 155, true);
            WriteLiteral("\r\n            </span>\r\n            <hr />\r\n        </div>\r\n        <div class=\"ingredients col-md-4\">\r\n            <h4>Ingredients</h4>\r\n            <ul>\r\n");
            EndContext();
#line 24 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
                 foreach (var ingredient in recipe.IngredientsList)
                {

#line default
#line hidden
            BeginContext(739, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(764, 10, false);
#line 26 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
                   Write(ingredient);

#line default
#line hidden
            EndContext();
            BeginContext(774, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 27 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
                }

#line default
#line hidden
            BeginContext(800, 129, true);
            WriteLiteral("            </ul>\r\n        </div>\r\n        <div class=\"directions col-md-8\">\r\n            <h4>Directions</h4>\r\n            <ol>\r\n");
            EndContext();
#line 33 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
                 foreach (var step in recipe.DirectionsList)
                {

#line default
#line hidden
            BeginContext(1010, 24, true);
            WriteLiteral("                    <li>");
            EndContext();
            BeginContext(1035, 4, false);
#line 35 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
                   Write(step);

#line default
#line hidden
            EndContext();
            BeginContext(1039, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 36 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
                }

#line default
#line hidden
            BeginContext(1065, 124, true);
            WriteLiteral("            </ol>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-4 text-right\">\r\n        <img class=\"img img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1189, "\"", 1222, 1);
#line 41 "C:\Users\Maxwell Wright\source\repos\TopsyTurvyCakes\TopsyTurvyCakes\Pages\Recipe.cshtml"
WriteAttributeValue("", 1195, recipe.GetInlineImageSrc(), 1195, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1223, 23, true);
            WriteLiteral(" />\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_Recipe> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Recipe> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_Recipe>)PageContext?.ViewData;
        public Pages_Recipe Model => ViewData.Model;
    }
}
#pragma warning restore 1591
