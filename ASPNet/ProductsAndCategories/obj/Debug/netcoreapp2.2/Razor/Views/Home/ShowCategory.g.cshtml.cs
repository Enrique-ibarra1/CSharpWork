#pragma checksum "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\ProductsAndCategories\Views\Home\ShowCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34e12d850841acd027dc907256beb81da3d0ca25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ShowCategory), @"mvc.1.0.view", @"/Views/Home/ShowCategory.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/ShowCategory.cshtml", typeof(AspNetCore.Views_Home_ShowCategory))]
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
#line 1 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\ProductsAndCategories\Views\_ViewImports.cshtml"
using ProductsAndCategories;

#line default
#line hidden
#line 2 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\ProductsAndCategories\Views\_ViewImports.cshtml"
using ProductsAndCategories.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34e12d850841acd027dc907256beb81da3d0ca25", @"/Views/Home/ShowCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3772dd1aab0a113eef9daa4fd8f7fdb8a407ef7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ShowCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Association>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ProdToCategory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(20, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(27, 21, false);
#line 3 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\ProductsAndCategories\Views\Home\ShowCategory.cshtml"
Write(ViewBag.Category.Name);

#line default
#line hidden
            EndContext();
            BeginContext(48, 58, true);
            WriteLiteral("</h1>\r\n<div class=\"\">\r\n    <h1>Products: </h1>\r\n    <ul>\r\n");
            EndContext();
#line 7 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\ProductsAndCategories\Views\Home\ShowCategory.cshtml"
     foreach (var p in ViewBag.Products)
        {

#line default
#line hidden
            BeginContext(159, 16, true);
            WriteLiteral("            <li>");
            EndContext();
            BeginContext(176, 14, false);
#line 9 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\ProductsAndCategories\Views\Home\ShowCategory.cshtml"
           Write(p.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(190, 7, true);
            WriteLiteral("</li>\r\n");
            EndContext();
#line 10 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\ProductsAndCategories\Views\Home\ShowCategory.cshtml"
        }

#line default
#line hidden
            BeginContext(208, 65, true);
            WriteLiteral("    </ul>\r\n</div>\r\n<div class=\"\">\r\n    <h3>Add Product</h3>\r\n    ");
            EndContext();
            BeginContext(273, 408, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34e12d850841acd027dc907256beb81da3d0ca255743", async() => {
                BeginContext(391, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(401, 190, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34e12d850841acd027dc907256beb81da3d0ca256134", async() => {
                    BeginContext(429, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 18 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\ProductsAndCategories\Views\Home\ShowCategory.cshtml"
             foreach (var p in ViewBag.NotOnCat)
            {

#line default
#line hidden
                    BeginContext(496, 16, true);
                    WriteLiteral("                ");
                    EndContext();
                    BeginContext(512, 45, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "34e12d850841acd027dc907256beb81da3d0ca256888", async() => {
                        BeginContext(542, 6, false);
#line 20 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\ProductsAndCategories\Views\Home\ShowCategory.cshtml"
                                        Write(p.Name);

#line default
#line hidden
                        EndContext();
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                    BeginWriteTagHelperAttribute();
#line 20 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\ProductsAndCategories\Views\Home\ShowCategory.cshtml"
                   WriteLiteral(p.ProductId);

#line default
#line hidden
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(557, 2, true);
                    WriteLiteral("\r\n");
                    EndContext();
#line 21 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\ProductsAndCategories\Views\Home\ShowCategory.cshtml"
            }

#line default
#line hidden
                    BeginContext(574, 8, true);
                    WriteLiteral("        ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
#line 17 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\ProductsAndCategories\Views\Home\ShowCategory.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductId);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(591, 83, true);
                WriteLiteral("\r\n        <button type=\"submit\" class=\"btn btn-dark\">Add to Category</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-categoryId", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 16 "C:\Users\rique\projects\codingdojo\c_sharp\ASPNet\ProductsAndCategories\Views\Home\ShowCategory.cshtml"
                  WriteLiteral(ViewBag.Category.CategoryId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["categoryId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-categoryId", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["categoryId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(681, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Association> Html { get; private set; }
    }
}
#pragma warning restore 1591