#pragma checksum "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa491644f4f2190b130dd577dd955bf95db78536"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tienda_listar), @"mvc.1.0.view", @"/Views/Tienda/listar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tienda/listar.cshtml", typeof(AspNetCore.Views_Tienda_listar))]
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
#line 1 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\_ViewImports.cshtml"
using Tarea002MVC;

#line default
#line hidden
#line 2 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\_ViewImports.cshtml"
using Tarea002MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa491644f4f2190b130dd577dd955bf95db78536", @"/Views/Tienda/listar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5a30f9d9a4835a10a0960f8e9db25c31e0977ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Tienda_listar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
  
    ViewData["Title"] = "Ventas por libro de un periodo";

#line default
#line hidden
            BeginContext(66, 109, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Ventas por libro de un periodo</h1>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(175, 624, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8916e38262b34a3ba5082d307cffb599", async() => {
                BeginContext(201, 80, true);
                WriteLiteral("\r\n        <label>Desde:</label><br /><input type=\"date\" name=\"dtedesde\" required");
                EndContext();
                BeginWriteAttribute("value", "\r\n                                          value=\"", 281, "\"", 353, 1);
#line 10 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
WriteAttributeValue("", 332, ViewData["dtedesde"], 332, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(354, 89, true);
                WriteLiteral(" /><br />\r\n        <label>Hasta:</label><br /><input type=\"date\" name=\"dtehasta\" required");
                EndContext();
                BeginWriteAttribute("value", "\r\n                                          value=\"", 443, "\"", 515, 1);
#line 12 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
WriteAttributeValue("", 494, ViewData["dtehasta"], 494, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(516, 150, true);
                WriteLiteral(" /><br />\r\n        <label>Termino de busqueda(opcional):</label> <br /><input type=\"text\"\r\n                                          name=\"searchterm\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 666, "\"", 697, 1);
#line 14 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
WriteAttributeValue("", 674, ViewData["searchterm"], 674, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(698, 94, true);
                WriteLiteral(" />\r\n        <br /><br />\r\n        <button type=\"submit\" name=\"btn_send\">Buscar</button>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(799, 29, true);
            WriteLiteral("\r\n    <h2 style=\"color:red;\">");
            EndContext();
            BeginContext(829, 23, false);
#line 18 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                      Write(ViewData["MessageText"]);

#line default
#line hidden
            EndContext();
            BeginContext(852, 497, true);
            WriteLiteral(@"</h2>
</div>
<div>
    <table border=""1"" class=""table table-striped table-bordered table-hover table-light"">
        <thead>
            <tr>
                <th>ID</th>
                <th>Name</th>
                <th>Tipo</th>
                <th>Autor</th>
                <th>Orden No</th>
                <th>Orden Date</th>
                <th>Precio</th>
                <th>Cantidad</th>
                <th>Total</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 36 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
              var subtotal = 0; var granttotal = 0; var prevtitleid = ""; var subqty = 0; var grantqty = 0;

#line default
#line hidden
            BeginContext(1459, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 37 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
             foreach (var oneTitle in @Model)
            {
                

#line default
#line hidden
#line 39 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                 if (prevtitleid == "") { prevtitleid = oneTitle.Titleid; }

#line default
#line hidden
#line 40 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                 if (prevtitleid != oneTitle.Titleid)
                {

#line default
#line hidden
            BeginContext(1672, 157, true);
            WriteLiteral("                    <tr class=\"row-sub-total\">\r\n                        <td colspan=\"7\">\r\n                            Sub Total\r\n                            ");
            EndContext();
            BeginContext(1830, 11, false);
#line 45 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                       Write(prevtitleid);

#line default
#line hidden
            EndContext();
            BeginContext(1841, 62, true);
            WriteLiteral(":\r\n                        </td>\r\n                        <td>");
            EndContext();
            BeginContext(1904, 24, false);
#line 47 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                       Write(subqty.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(1928, 65, true);
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(1994, 29, false);
#line 49 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                       Write(subtotal.ToString("#,##0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(2023, 60, true);
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 52 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                    {
                        granttotal += @subtotal; subtotal = 0; prevtitleid =
                      oneTitle.Titleid; grantqty += subqty; subqty = 0;
                    }
                }

#line default
#line hidden
            BeginContext(2299, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(2346, 16, false);
#line 58 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                   Write(oneTitle.Titleid);

#line default
#line hidden
            EndContext();
            BeginContext(2362, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2394, 14, false);
#line 59 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                   Write(oneTitle.Title);

#line default
#line hidden
            EndContext();
            BeginContext(2408, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2440, 13, false);
#line 60 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                   Write(oneTitle.Type);

#line default
#line hidden
            EndContext();
            BeginContext(2453, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2485, 14, false);
#line 61 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                   Write(oneTitle.Autor);

#line default
#line hidden
            EndContext();
            BeginContext(2499, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2531, 16, false);
#line 62 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                   Write(oneTitle.OrderNO);

#line default
#line hidden
            EndContext();
            BeginContext(2547, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(2579, 18, false);
#line 63 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                   Write(oneTitle.OrderDate);

#line default
#line hidden
            EndContext();
            BeginContext(2597, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"cell-number\">");
            EndContext();
            BeginContext(2649, 35, false);
#line 64 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                                       Write(oneTitle.Price.ToString("#,##0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(2684, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"cell-number\">");
            EndContext();
            BeginContext(2736, 35, false);
#line 65 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                                       Write(oneTitle.Quantity.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(2771, 51, true);
            WriteLiteral("</td>\r\n                    <td class=\"cell-number\">");
            EndContext();
            BeginContext(2823, 35, false);
#line 66 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                                       Write(oneTitle.Total.ToString("#,##0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(2858, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 68 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
                {
                    subtotal += oneTitle.Total; subqty += oneTitle.Quantity;
                }
            }

#line default
#line hidden
            BeginContext(3019, 12, true);
            WriteLiteral("            ");
            EndContext();
#line 72 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
              granttotal += subtotal; grantqty += subqty;
            

#line default
#line hidden
            BeginContext(3093, 131, true);
            WriteLiteral("            <tr class=\"row-sub-total\">\r\n                <td colspan=\"7\">\r\n                    Sub Total Libro\r\n                    ");
            EndContext();
            BeginContext(3225, 11, false);
#line 77 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
               Write(prevtitleid);

#line default
#line hidden
            EndContext();
            BeginContext(3236, 46, true);
            WriteLiteral(":\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(3283, 24, false);
#line 79 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
               Write(subqty.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(3307, 49, true);
            WriteLiteral("</td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(3357, 29, false);
#line 81 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
               Write(subtotal.ToString("#,##0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(3386, 199, true);
            WriteLiteral("</td>\r\n            </tr>\r\n            <tr class=\"row-grant-total\">\r\n                <td colspan=\"7\">\r\n                    Gran\r\n                    Total:\r\n                </td>\r\n                <td>");
            EndContext();
            BeginContext(3586, 26, false);
#line 88 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
               Write(grantqty.ToString("#,##0"));

#line default
#line hidden
            EndContext();
            BeginContext(3612, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(3640, 31, false);
#line 89 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\listar.cshtml"
               Write(granttotal.ToString("#,##0.00"));

#line default
#line hidden
            EndContext();
            BeginContext(3671, 68, true);
            WriteLiteral("</td><\r\n                /tr>\r\n        </tbody>\r\n    </table>\r\n</div>");
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
