#pragma checksum "D:\downloads\acad\project1\FlixSsa\Views\Flixssa\Remove.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1c11ae8f6bfcbbc3d0bd20950644f335a5ab763"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Flixssa_Remove), @"mvc.1.0.view", @"/Views/Flixssa/Remove.cshtml")]
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
#line 1 "D:\downloads\acad\project1\FlixSsa\Views\_ViewImports.cshtml"
using Filmes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\downloads\acad\project1\FlixSsa\Views\_ViewImports.cshtml"
using Filmes.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1c11ae8f6bfcbbc3d0bd20950644f335a5ab763", @"/Views/Flixssa/Remove.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8a190c67c531022c499b44db76b37b5c89f3879", @"/Views/_ViewImports.cshtml")]
    public class Views_Flixssa_Remove : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Filmes.Models.Filme>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 3 "D:\downloads\acad\project1\FlixSsa\Views\Flixssa\Remove.cshtml"
Write(ViewBag.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f1c11ae8f6bfcbbc3d0bd20950644f335a5ab7633687", async() => {
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 7 "D:\downloads\acad\project1\FlixSsa\Views\Flixssa\Remove.cshtml"
     foreach (var Filme in ViewBag.Filmes)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"custom-control custom-checkbox\">\r\n            <input type=\"checkbox\"  name=\"FilmeIds\"");
                BeginWriteAttribute("id", " id=\"", 237, "\"", 256, 1);
#nullable restore
#line 10 "D:\downloads\acad\project1\FlixSsa\Views\Flixssa\Remove.cshtml"
WriteAttributeValue("", 242, Filme.FilmeId, 242, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 257, "\"", 279, 1);
#nullable restore
#line 10 "D:\downloads\acad\project1\FlixSsa\Views\Flixssa\Remove.cshtml"
WriteAttributeValue("", 265, Filme.FilmeId, 265, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> \r\n            <label");
                BeginWriteAttribute("for", " for=\"", 304, "\"", 324, 1);
#nullable restore
#line 11 "D:\downloads\acad\project1\FlixSsa\Views\Flixssa\Remove.cshtml"
WriteAttributeValue("", 310, Filme.FilmeId, 310, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 11 "D:\downloads\acad\project1\FlixSsa\Views\Flixssa\Remove.cshtml"
                                   Write(Filme.Titulo);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n        </div>\r\n");
#nullable restore
#line 13 "D:\downloads\acad\project1\FlixSsa\Views\Flixssa\Remove.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <br>\r\n    <input type=\"submit\" value=\"Remover Filme(s) Selecionados\"  class=\"btn btn-danger\"/>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Filmes.Models.Filme> Html { get; private set; }
    }
}
#pragma warning restore 1591
