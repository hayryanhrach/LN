#pragma checksum "C:\Users\hrachik.hayryan\Desktop\LN\LN\Views\Products\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2266df2c442da1272beb6aec4d9bc96d3d498491"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_List), @"mvc.1.0.view", @"/Views/Products/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/List.cshtml", typeof(AspNetCore.Views_Products_List))]
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
#line 1 "C:\Users\hrachik.hayryan\Desktop\LN\LN\Views\_ViewImports.cshtml"
using LN.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2266df2c442da1272beb6aec4d9bc96d3d498491", @"/Views/Products/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfb51125dccac5e96f330bc6dd9bcca490508318", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 59, true);
            WriteLiteral("\r\n            <h1>Բոլոր Գործվածքները</h1>\r\n            <h2>");
            EndContext();
            BeginContext(60, 18, false);
#line 3 "C:\Users\hrachik.hayryan\Desktop\LN\LN\Views\Products\List.cshtml"
           Write(Model.currCategory);

#line default
#line hidden
            EndContext();
            BeginContext(78, 48, true);
            WriteLiteral("</h2>\r\n            <div class=\"row mt-5 mb-2\">\r\n");
            EndContext();
#line 5 "C:\Users\hrachik.hayryan\Desktop\LN\LN\Views\Products\List.cshtml"
          
            foreach(var product in Model.allProducts)
            {

#line default
#line hidden
            BeginContext(206, 66, true);
            WriteLiteral("<div class=\"col-lg-4\">\r\n                <img class=\"img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 272, "\"", 290, 1);
#line 8 "C:\Users\hrachik.hayryan\Desktop\LN\LN\Views\Products\List.cshtml"
WriteAttributeValue("", 278, product.Img, 278, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 291, "\"", 310, 1);
#line 8 "C:\Users\hrachik.hayryan\Desktop\LN\LN\Views\Products\List.cshtml"
WriteAttributeValue("", 297, product.Name, 297, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(311, 24, true);
            WriteLiteral("/>\r\n                <h2>");
            EndContext();
            BeginContext(336, 12, false);
#line 9 "C:\Users\hrachik.hayryan\Desktop\LN\LN\Views\Products\List.cshtml"
               Write(product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(348, 26, true);
            WriteLiteral("</h2>\r\n                <p>");
            EndContext();
            BeginContext(375, 12, false);
#line 10 "C:\Users\hrachik.hayryan\Desktop\LN\LN\Views\Products\List.cshtml"
              Write(product.Desc);

#line default
#line hidden
            EndContext();
            BeginContext(387, 30, true);
            WriteLiteral("</p>\r\n                <p>Գին: ");
            EndContext();
            BeginContext(418, 24, false);
#line 11 "C:\Users\hrachik.hayryan\Desktop\LN\LN\Views\Products\List.cshtml"
                   Write(product.Price.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(442, 107, true);
            WriteLiteral(" դրամ</p>\r\n                <p><a class=\"btn btn-warning\" href=#>Մանրամասն</a></p>\r\n                </div>\r\n");
            EndContext();
#line 14 "C:\Users\hrachik.hayryan\Desktop\LN\LN\Views\Products\List.cshtml"
            }
        

#line default
#line hidden
            BeginContext(575, 16, true);
            WriteLiteral("        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
