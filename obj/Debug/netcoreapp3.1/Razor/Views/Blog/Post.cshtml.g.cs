#pragma checksum "/Users/alexandersteele/Projects/ExploreLeeds/ExploreLeeds/Views/Blog/Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4093280b21dea8a71f515bd6dcab33727eb2cee1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Post), @"mvc.1.0.view", @"/Views/Blog/Post.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4093280b21dea8a71f515bd6dcab33727eb2cee1", @"/Views/Blog/Post.cshtml")]
    public class Views_Blog_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ExploreLeeds.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "/Users/alexandersteele/Projects/ExploreLeeds/ExploreLeeds/Views/Blog/Post.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<article class=\"blog-post\">\n    <h1>");
#nullable restore
#line 7 "/Users/alexandersteele/Projects/ExploreLeeds/ExploreLeeds/Views/Blog/Post.cshtml"
   Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\n    <div class=\"details\">\n        Posted <span>");
#nullable restore
#line 9 "/Users/alexandersteele/Projects/ExploreLeeds/ExploreLeeds/Views/Blog/Post.cshtml"
                Write(Model.Posted);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span> by <span>");
#nullable restore
#line 9 "/Users/alexandersteele/Projects/ExploreLeeds/ExploreLeeds/Views/Blog/Post.cshtml"
                                              Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n    </div>\n    <div class=\"content\">\n        ");
#nullable restore
#line 12 "/Users/alexandersteele/Projects/ExploreLeeds/ExploreLeeds/Views/Blog/Post.cshtml"
   Write(Model.Body);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</article>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ExploreLeeds.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
