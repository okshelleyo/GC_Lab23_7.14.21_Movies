#pragma checksum "C:\Users\ocono\source\repos\GC_Lab23_7.14.21\GC_Lab23_7.14.21\Views\Movie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "15281b3ecd375f236b02ef6ab0588d847755e787"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movie_Index), @"mvc.1.0.view", @"/Views/Movie/Index.cshtml")]
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
#line 1 "C:\Users\ocono\source\repos\GC_Lab23_7.14.21\GC_Lab23_7.14.21\Views\_ViewImports.cshtml"
using GC_Lab23_7._14._21;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ocono\source\repos\GC_Lab23_7.14.21\GC_Lab23_7.14.21\Views\_ViewImports.cshtml"
using GC_Lab23_7._14._21.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"15281b3ecd375f236b02ef6ab0588d847755e787", @"/Views/Movie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"220db7d3292579c6b73eef996bcc0827618f5820", @"/Views/_ViewImports.cshtml")]
    public class Views_Movie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br /> \r\n<h3>Shelley\'s Random Movie Library</h3>\r\n<br />\r\n\r\n <table class=\"table table-bordered\">\r\n     <tr>\r\n         <th>Title</th>\r\n         <th>Genre</th>\r\n         <th>Runtime</th>\r\n         <th colspan=\"2\">Actions</th>\r\n     </tr>\r\n\r\n");
#nullable restore
#line 15 "C:\Users\ocono\source\repos\GC_Lab23_7.14.21\GC_Lab23_7.14.21\Views\Movie\Index.cshtml"
      foreach (var movie in Model)
     {

#line default
#line hidden
#nullable disable
            WriteLiteral("     <tr>\r\n         <td>");
#nullable restore
#line 18 "C:\Users\ocono\source\repos\GC_Lab23_7.14.21\GC_Lab23_7.14.21\Views\Movie\Index.cshtml"
        Write(movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 19 "C:\Users\ocono\source\repos\GC_Lab23_7.14.21\GC_Lab23_7.14.21\Views\Movie\Index.cshtml"
        Write(movie.Genre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td>");
#nullable restore
#line 20 "C:\Users\ocono\source\repos\GC_Lab23_7.14.21\GC_Lab23_7.14.21\Views\Movie\Index.cshtml"
        Write(movie.Runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n         <td><a");
            BeginWriteAttribute("href", " href=\"", 430, "\"", 467, 2);
            WriteAttributeValue("", 437, "Movie/DeleteMovie?id=", 437, 21, true);
#nullable restore
#line 21 "C:\Users\ocono\source\repos\GC_Lab23_7.14.21\GC_Lab23_7.14.21\Views\Movie\Index.cshtml"
WriteAttributeValue("", 458, movie.Id, 458, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\">Remove</a></td>\r\n         <td> <a");
            BeginWriteAttribute("href", " href=\"", 531, "\"", 566, 2);
            WriteAttributeValue("", 538, "Movie/MovieForm?id=", 538, 19, true);
#nullable restore
#line 22 "C:\Users\ocono\source\repos\GC_Lab23_7.14.21\GC_Lab23_7.14.21\Views\Movie\Index.cshtml"
WriteAttributeValue("", 557, movie.Id, 557, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\">Edit</a> </td>\r\n\r\n     </tr>\r\n");
#nullable restore
#line 25 "C:\Users\ocono\source\repos\GC_Lab23_7.14.21\GC_Lab23_7.14.21\Views\Movie\Index.cshtml"
         }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n </table>\r\n\r\n<br />\r\n<a href=\"Movie/MovieForm\" class=\"btn btn-dark\">Add a Movie to the Library</a>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
