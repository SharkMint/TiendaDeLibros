#pragma checksum "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002EFMVC\Views\Tienda\buscar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7dc96d6e37b8e9994eb71864c89a271ac7e86d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tienda_buscar), @"mvc.1.0.view", @"/Views/Tienda/buscar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tienda/buscar.cshtml", typeof(AspNetCore.Views_Tienda_buscar))]
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
#line 1 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002EFMVC\Views\_ViewImports.cshtml"
using Tarea002MVC;

#line default
#line hidden
#line 2 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002EFMVC\Views\_ViewImports.cshtml"
using Tarea002MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7dc96d6e37b8e9994eb71864c89a271ac7e86d3", @"/Views/Tienda/buscar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5a30f9d9a4835a10a0960f8e9db25c31e0977ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Tienda_buscar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002EFMVC\Views\Tienda\buscar.cshtml"
  
    ViewData["Title"] = "Buscador de libros";

#line default
#line hidden
            BeginContext(54, 230, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Tienda Buscador de libro</h1>\r\n</div>\r\n<div>\r\n    <h1 class=\"display-4\">Escriba el nombre del libro que busca</h1>\r\n    <!--<form id=\"\" method=\"GET\" action=\"probarGet\">-->\r\n    ");
            EndContext();
            BeginContext(284, 256, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "224e826a7387432287a320cd1fdef111", async() => {
                BeginContext(330, 75, true);
                WriteLiteral("\r\n        <input type=\"text\" class=\"form-control mr-sm-2\" name=\"searchterm\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 405, "\"", 436, 1);
#line 11 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002EFMVC\Views\Tienda\buscar.cshtml"
WriteAttributeValue("", 413, ViewData["SearchTerm"], 413, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(437, 96, true);
                WriteLiteral(" />\r\n        <button class=\"btn btn-primary\" type=\"submit\" name=\"btn_send\">buscar</button>\r\n    ");
                EndContext();
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
            EndContext();
            BeginContext(540, 394, true);
            WriteLiteral(@"
    <h2>Resultados de la busqueda</h2>
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
            EndContext();
#line 28 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002EFMVC\Views\Tienda\buscar.cshtml"
             foreach (var oneTitle in @Model)
             {

#line default
#line hidden
            BeginContext(997, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1044, 16, false);
#line 31 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002EFMVC\Views\Tienda\buscar.cshtml"
                   Write(oneTitle.Titleid);

#line default
#line hidden
            EndContext();
            BeginContext(1060, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1092, 13, false);
#line 32 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002EFMVC\Views\Tienda\buscar.cshtml"
                   Write(oneTitle.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1105, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1137, 13, false);
#line 33 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002EFMVC\Views\Tienda\buscar.cshtml"
                   Write(oneTitle.Type);

#line default
#line hidden
            EndContext();
            BeginContext(1150, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1182, 14, false);
#line 34 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002EFMVC\Views\Tienda\buscar.cshtml"
                   Write(oneTitle.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1196, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1228, 14, false);
#line 35 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002EFMVC\Views\Tienda\buscar.cshtml"
                   Write(oneTitle.Notas);

#line default
#line hidden
            EndContext();
            BeginContext(1242, 57, true);
            WriteLiteral("</td>\r\n                    <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1299, "\"", 1336, 2);
            WriteAttributeValue("", 1306, "Modificar?id=", 1306, 13, true);
#line 36 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002EFMVC\Views\Tienda\buscar.cshtml"
WriteAttributeValue("", 1319, oneTitle.Titleid, 1319, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1337, 71, true);
            WriteLiteral(">Modificar</a></td>\r\n                    <td><a class=\"btn btn-primary\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1408, "\"", 1443, 2);
            WriteAttributeValue("", 1415, "Comprar?id=", 1415, 11, true);
#line 37 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002EFMVC\Views\Tienda\buscar.cshtml"
WriteAttributeValue("", 1426, oneTitle.Titleid, 1426, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1444, 42, true);
            WriteLiteral(">Comprar</a></td>\r\n                </tr>\r\n");
            EndContext();
#line 39 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002EFMVC\Views\Tienda\buscar.cshtml"
             }

#line default
#line hidden
            BeginContext(1502, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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