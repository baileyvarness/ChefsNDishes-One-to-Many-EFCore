#pragma checksum "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/ChefsNDishes/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77edd39e197e03dedbd5d22406426e565ea03779"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
#line 1 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes;

#line default
#line hidden
#line 2 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/ChefsNDishes/Views/_ViewImports.cshtml"
using ChefsNDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77edd39e197e03dedbd5d22406426e565ea03779", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3683dbd783bea45b88d0b0d3ee52e8ec1e5d61", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 567, true);
            WriteLiteral(@"
<div class=""container"" style=""margin-bottom: 50px;"">
  <div class=""row"">
    <div class=""col"">
    </div>
    <div class=""col-5"">
      <h2><a href=""/"">Chefs</a> | Dishes</h2>
    </div>
    <div class=""col"">
      <a href=""/dishes/new"">Add a Dish</a>
    </div>
  </div>
</div>

<h3>Yum, take a look at our tasty dishes!</h3>
<hr>

<table class=""table table-striped"">
  <thead class=""thead-dark"">
    <tr>
      <th scope=""col"">Name</th>
      <th scope=""col"">Chef</th>
      <th scope=""col"">Tastiness</th>
      <th scope=""col"">Calories</th>
    </tr>
  </thead>

");
            EndContext();
#line 29 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/ChefsNDishes/Views/Home/Dishes.cshtml"
   foreach(var dish in Model){

#line default
#line hidden
            BeginContext(616, 29, true);
            WriteLiteral("  <tbody>\n    <tr>\n      <td>");
            EndContext();
            BeginContext(646, 9, false);
#line 32 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/ChefsNDishes/Views/Home/Dishes.cshtml"
     Write(dish.Name);

#line default
#line hidden
            EndContext();
            BeginContext(655, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(672, 22, false);
#line 33 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/ChefsNDishes/Views/Home/Dishes.cshtml"
     Write(dish.Creator.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(694, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(696, 21, false);
#line 33 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/ChefsNDishes/Views/Home/Dishes.cshtml"
                             Write(dish.Creator.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(717, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(734, 14, false);
#line 34 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/ChefsNDishes/Views/Home/Dishes.cshtml"
     Write(dish.Tastiness);

#line default
#line hidden
            EndContext();
            BeginContext(748, 16, true);
            WriteLiteral("</td>\n      <td>");
            EndContext();
            BeginContext(765, 13, false);
#line 35 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/ChefsNDishes/Views/Home/Dishes.cshtml"
     Write(dish.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(778, 27, true);
            WriteLiteral("</td>\n    </tr>\n  </tbody>\n");
            EndContext();
#line 38 "/Users/Bailey/Documents/Bootcamp/c_sharp_stack/ChefsNDishes/Views/Home/Dishes.cshtml"
  }

#line default
#line hidden
            BeginContext(809, 10, true);
            WriteLiteral("</table>\n\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
