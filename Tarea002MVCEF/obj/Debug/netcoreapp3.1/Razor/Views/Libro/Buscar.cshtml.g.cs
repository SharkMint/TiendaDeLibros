#pragma checksum "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVCEF\Views\Libro\Buscar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "69cb9a835aa884b281ebb99a840694796a894067"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Libro_Buscar), @"mvc.1.0.view", @"/Views/Libro/Buscar.cshtml")]
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
#line 1 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVCEF\Views\_ViewImports.cshtml"
using Tarea002MVCEF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVCEF\Views\_ViewImports.cshtml"
using Tarea002MVCEF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"69cb9a835aa884b281ebb99a840694796a894067", @"/Views/Libro/Buscar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"223022e926b9b503d5f0f0f52cf9dfc48c81a0b3", @"/Views/_ViewImports.cshtml")]
    public class Views_Libro_Buscar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 1 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVCEF\Views\Libro\Buscar.cshtml"
  
    ViewData["Title"] = "Buscador de libros";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">ETF- Buscador de libro</h1>\r\n</div>\r\n<div>\r\n    <h1 class=\"display-4\">Datos generales del Libro</h1>\r\n    <!--<form id=\"\" method=\"GET\" action=\"probarGet\">-->\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69cb9a835aa884b281ebb99a840694796a8940674665", async() => {
                WriteLiteral("\r\n        <input type=\"text\" class=\"form-control mr-sm-2\" name=\"searchterm\"");
                BeginWriteAttribute("value", " value=\"", 391, "\"", 422, 1);
#nullable restore
#line 11 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVCEF\Views\Libro\Buscar.cshtml"
WriteAttributeValue("", 399, ViewData["SearchTerm"], 399, 23, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n        <button class=\"btn btn-primary\" type=\"submit\" name=\"btn_send\">buscar</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    <h2>error textsss</h2>
</div>
<div>
    <table border=""1"" class=""table table-striped table-bordered table-hover table-light"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Tipo</th>
                <th>Precio</th>
                <th>Notas</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 28 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVCEF\Views\Libro\Buscar.cshtml"
             foreach (var oneTitle in @Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVCEF\Views\Libro\Buscar.cshtml"
                   Write(oneTitle.TitleId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 32 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVCEF\Views\Libro\Buscar.cshtml"
                   Write(oneTitle.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 33 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVCEF\Views\Libro\Buscar.cshtml"
                   Write(oneTitle.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 34 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVCEF\Views\Libro\Buscar.cshtml"
                   Write(oneTitle.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 35 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVCEF\Views\Libro\Buscar.cshtml"
                   Write(oneTitle.Notes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1272, "\"", 1304, 2);
            WriteAttributeValue("", 1279, "Edit?id=", 1279, 8, true);
#nullable restore
#line 36 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVCEF\Views\Libro\Buscar.cshtml"
WriteAttributeValue("", 1287, oneTitle.TitleId, 1287, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Modificar</a></td>\r\n                    <td><a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1376, "\"", 1411, 2);
            WriteAttributeValue("", 1383, "Comprar?id=", 1383, 11, true);
#nullable restore
#line 37 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVCEF\Views\Libro\Buscar.cshtml"
WriteAttributeValue("", 1394, oneTitle.TitleId, 1394, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Comprar</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 39 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVCEF\Views\Libro\Buscar.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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