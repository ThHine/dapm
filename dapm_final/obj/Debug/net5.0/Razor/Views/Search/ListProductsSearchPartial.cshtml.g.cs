#pragma checksum "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Search\ListProductsSearchPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c90f54b2f7d8537cdb6345a679335ea108735898"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_ListProductsSearchPartial), @"mvc.1.0.view", @"/Views/Search/ListProductsSearchPartial.cshtml")]
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
#line 1 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\_ViewImports.cshtml"
using dapm_final;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\_ViewImports.cshtml"
using dapm_final.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c90f54b2f7d8537cdb6345a679335ea108735898", @"/Views/Search/ListProductsSearchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"de7bca1180a586702ce5be81b08789727cd7be9f", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_ListProductsSearchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Search\ListProductsSearchPartial.cshtml"
 if (Model != null)
{
    foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\n\n    <td>\n        ");
#nullable restore
#line 9 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Search\ListProductsSearchPartial.cshtml"
   Write(item.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n    <td>\n        ");
#nullable restore
#line 12 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Search\ListProductsSearchPartial.cshtml"
   Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </td>\n\n    <td>");
#nullable restore
#line 15 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Search\ListProductsSearchPartial.cshtml"
   Write(item.Price.Value.ToString("#,##0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ</td>\n\n\n</tr>");
#nullable restore
#line 18 "C:\Users\DELL-AMD\Desktop\dapm_final_2\dapm_final\Views\Search\ListProductsSearchPartial.cshtml"
     }
            }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
