#pragma checksum "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\DojoSurvey\Views\Home\Success.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d0dca64bf5e792b5665d7c6f59c40eb91b41c25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Success), @"mvc.1.0.view", @"/Views/Home/Success.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Success.cshtml", typeof(AspNetCore.Views_Home_Success))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d0dca64bf5e792b5665d7c6f59c40eb91b41c25", @"/Views/Home/Success.cshtml")]
    public class Views_Home_Success : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 32, true);
            WriteLiteral("<h1>Dojo Surver Results: </h1>\r\n");
            EndContext();
#line 2 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\DojoSurvey\Views\Home\Success.cshtml"
 if(@ViewBag.Name[0] == 'A')
{

#line default
#line hidden
            BeginContext(65, 39, true);
            WriteLiteral("    <p>Name: <span style=\"color: red;\">");
            EndContext();
            BeginContext(105, 12, false);
#line 4 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\DojoSurvey\Views\Home\Success.cshtml"
                                  Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(117, 13, true);
            WriteLiteral("</span></p>\r\n");
            EndContext();
#line 5 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\DojoSurvey\Views\Home\Success.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(142, 13, true);
            WriteLiteral("    <p>Name: ");
            EndContext();
            BeginContext(156, 12, false);
#line 8 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\DojoSurvey\Views\Home\Success.cshtml"
        Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(168, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
#line 9 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\DojoSurvey\Views\Home\Success.cshtml"
}

#line default
#line hidden
            BeginContext(178, 15, true);
            WriteLiteral("\r\n<p>Location: ");
            EndContext();
            BeginContext(194, 16, false);
#line 11 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\DojoSurvey\Views\Home\Success.cshtml"
        Write(ViewBag.Location);

#line default
#line hidden
            EndContext();
            BeginContext(210, 28, true);
            WriteLiteral("</p>\r\n<p>Favorite Language: ");
            EndContext();
            BeginContext(239, 16, false);
#line 12 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\DojoSurvey\Views\Home\Success.cshtml"
                 Write(ViewBag.Language);

#line default
#line hidden
            EndContext();
            BeginContext(255, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 13 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\DojoSurvey\Views\Home\Success.cshtml"
 if(ViewBag.Comments != null)
{

#line default
#line hidden
            BeginContext(295, 31, true);
            WriteLiteral("    <h1>Comments:</h1>\r\n    <p>");
            EndContext();
            BeginContext(327, 16, false);
#line 16 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\DojoSurvey\Views\Home\Success.cshtml"
  Write(ViewBag.Comments);

#line default
#line hidden
            EndContext();
            BeginContext(343, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 17 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\DojoSurvey\Views\Home\Success.cshtml"
    
}
else
{

#line default
#line hidden
            BeginContext(367, 7, true);
            WriteLiteral("    <p>");
            EndContext();
            BeginContext(375, 12, false);
#line 21 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\DojoSurvey\Views\Home\Success.cshtml"
  Write(ViewBag.Name);

#line default
#line hidden
            EndContext();
            BeginContext(387, 26, true);
            WriteLiteral(" has nothing to say.</p>\r\n");
            EndContext();
#line 22 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\DojoSurvey\Views\Home\Success.cshtml"
}

#line default
#line hidden
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