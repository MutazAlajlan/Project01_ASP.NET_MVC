#pragma checksum "C:\Users\rooke\Desktop\Project01.NET\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03f14bac44a8d01acaad089ee6906643c3840a61"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
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
#line 1 "C:\Users\rooke\Desktop\Project01.NET\Views\_ViewImports.cshtml"
using Project01.NET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\rooke\Desktop\Project01.NET\Views\_ViewImports.cshtml"
using Project01.NET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03f14bac44a8d01acaad089ee6906643c3840a61", @"/Views/Books/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f226c104a43be13f6c842ed69289218fac38fda7", @"/Views/_ViewImports.cshtml")]
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\rooke\Desktop\Project01.NET\Views\Books\Details.cshtml"
  
    var Book = (BookModel)ViewData["Book"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>\r\n    ");
#nullable restore
#line 9 "C:\Users\rooke\Desktop\Project01.NET\Views\Books\Details.cshtml"
Write(Book.bookName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h1>\r\n<img");
            BeginWriteAttribute("src", " src=\"", 214, "\"", 231, 1);
#nullable restore
#line 11 "C:\Users\rooke\Desktop\Project01.NET\Views\Books\Details.cshtml"
WriteAttributeValue("", 220, Book.image, 220, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<h2>\r\n    By: ");
#nullable restore
#line 13 "C:\Users\rooke\Desktop\Project01.NET\Views\Books\Details.cshtml"
   Write(Book.authorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h2>\r\n<h3>\r\n    Published by: ");
#nullable restore
#line 16 "C:\Users\rooke\Desktop\Project01.NET\Views\Books\Details.cshtml"
             Write(Book.publisher);

#line default
#line hidden
#nullable disable
            WriteLiteral(" in the year of ");
#nullable restore
#line 16 "C:\Users\rooke\Desktop\Project01.NET\Views\Books\Details.cshtml"
                                            Write(Book.releaseYear);

#line default
#line hidden
#nullable disable
            WriteLiteral(". The book price is $");
#nullable restore
#line 16 "C:\Users\rooke\Desktop\Project01.NET\Views\Books\Details.cshtml"
                                                                                  Write(Book.price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</h3>\r\n");
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
