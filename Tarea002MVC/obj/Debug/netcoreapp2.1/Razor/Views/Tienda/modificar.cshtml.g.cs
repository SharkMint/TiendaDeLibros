#pragma checksum "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b083abd4d6714494ab300596ab168aa97d8914b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tienda_modificar), @"mvc.1.0.view", @"/Views/Tienda/modificar.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tienda/modificar.cshtml", typeof(AspNetCore.Views_Tienda_modificar))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b083abd4d6714494ab300596ab168aa97d8914b", @"/Views/Tienda/modificar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5a30f9d9a4835a10a0960f8e9db25c31e0977ff", @"/Views/_ViewImports.cshtml")]
    public class Views_Tienda_modificar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline mr-ms-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("Modificar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
  
    ViewData["Title"] = "Creación de Libros";

#line default
#line hidden
            BeginContext(54, 85, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Modificando los datos del libro:");
            EndContext();
            BeginContext(140, 22, false);
#line 5 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
                                                     Write(ViewData["SearchTerm"]);

#line default
#line hidden
            EndContext();
            BeginContext(162, 22, true);
            WriteLiteral("</h1>\r\n</div>\r\n<div>\r\n");
            EndContext();
#line 8 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
      var clsalert = "alert-fail";

#line default
#line hidden
            BeginContext(219, 7, true);
            WriteLiteral(";\r\n    ");
            EndContext();
            BeginContext(226, 3007, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1f6fa308f51f4861818d76d2bb63bc83", async() => {
                BeginContext(299, 36, true);
                WriteLiteral("\r\n        <label>ID:</label><strong>");
                EndContext();
                BeginContext(336, 23, false);
#line 10 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
                             Write(Model.DataModel.Titleid);

#line default
#line hidden
                EndContext();
                BeginContext(359, 81, true);
                WriteLiteral("</strong><br />\r\n        <input class=\"form-control\" type=\"hidden\" name=\"Titleid\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 440, "\"", 472, 1);
#line 11 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
WriteAttributeValue("", 448, Model.DataModel.Titleid, 448, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(473, 99, true);
                WriteLiteral(" />\r\n        <label>Name:</label><br /><input class=\"form-control\" type=\"text\" required name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", "\r\n                                   value=\"", 572, "\"", 637, 1);
#line 13 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
WriteAttributeValue("", 616, Model.DataModel.Name, 616, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(638, 121, true);
                WriteLiteral(" maxlength=\"40\" size=\"40\" /><br />\r\n        <label>Genero:</label><br /><select class=\"form-control\" name=\"type\" required");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 759, "\"", 788, 1);
#line 14 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
WriteAttributeValue("", 767, Model.DataModel.Type, 767, 21, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(789, 15, true);
                WriteLiteral(">\r\n            ");
                EndContext();
                BeginContext(804, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9d26baf54a4dc8b13520688684c604", async() => {
                    BeginContext(821, 9, true);
                    WriteLiteral("(Ninguna)");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(839, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 16 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
             foreach (var oneType in Model.Types)
            {
                var selitem = "";
                

#line default
#line hidden
#line 19 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
                 if (@oneType == @Model.DataModel.Type)
                {
                    selitem = "selected";
                }

#line default
#line hidden
                BeginContext(1080, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1096, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93ba03de25514083b1f1f7b14c138c50", async() => {
                    BeginContext(1142, 7, false);
#line 23 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
                                                        Write(oneType);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 23 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
                   WriteLiteral(oneType);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 23 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
AddHtmlAttributeValue("", 1131, selitem, 1131, 8, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1158, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 24 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
            }

#line default
#line hidden
                BeginContext(1175, 113, true);
                WriteLiteral("        </select><br />\r\n        <label>Editora:</label><br /><select class=\"form-control\" name=\"pub_id\" required");
                EndContext();
                BeginWriteAttribute("value", "\r\n                                       value=\"", 1288, "\"", 1361, 1);
#line 27 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
WriteAttributeValue("", 1336, Model.DataModel.EditorID, 1336, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1362, 15, true);
                WriteLiteral(">\r\n            ");
                EndContext();
                BeginContext(1377, 35, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "20b43a76ba8f4a5688cab66938aadc76", async() => {
                    BeginContext(1394, 9, true);
                    WriteLiteral("(Ninguna)");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1412, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 29 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
             foreach (var onePub in Model.Editors)
            {
                var selitem = "";
                

#line default
#line hidden
#line 32 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
                 if (@onePub.Pubid == @Model.DataModel.EditorID)
                {
                    selitem = "selected";
                }

#line default
#line hidden
                BeginContext(1663, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(1679, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fd5211e55c30459ab1c2904a7d952a67", async() => {
                    BeginContext(1730, 11, false);
#line 36 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
                                                             Write(onePub.Name);

#line default
#line hidden
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#line 36 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
                   WriteLiteral(onePub.Pubid);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "selected", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 36 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
AddHtmlAttributeValue("", 1719, selitem, 1719, 8, false);

#line default
#line hidden
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1750, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 37 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
            }

#line default
#line hidden
                BeginContext(1767, 124, true);
                WriteLiteral("        </select><br />\r\n\r\n        <label>Precio:</label><br /><input class=\"form-control\" type=\"text\" name=\"price\" required");
                EndContext();
                BeginWriteAttribute("value", "\r\n                                     value=\"", 1891, "\"", 1959, 1);
#line 41 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
WriteAttributeValue("", 1937, Model.DataModel.Price, 1937, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1960, 109, true);
                WriteLiteral(" /><br />\r\n        <label>Avance:</label><br /><input class=\"form-control\" type=\"text\" name=\"avance\" required");
                EndContext();
                BeginWriteAttribute("value", "\r\n                                     value=\"", 2069, "\"", 2138, 1);
#line 43 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
WriteAttributeValue("", 2115, Model.DataModel.Avance, 2115, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2139, 109, true);
                WriteLiteral(" /><br />\r\n        <label>Royalty:</label><br /><input class=\"form-control\" type=\"text\" name=\"royal\" required");
                EndContext();
                BeginWriteAttribute("value", "\r\n                                      value=\"", 2248, "\"", 2317, 1);
#line 45 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
WriteAttributeValue("", 2295, Model.DataModel.Royal, 2295, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2318, 116, true);
                WriteLiteral(" /><br />\r\n        <label>Ventas Año:</label><br /><input class=\"form-control\" type=\"text\" name=\"yearsales\" required");
                EndContext();
                BeginWriteAttribute("value", "\r\n                                         value=\"", 2434, "\"", 2510, 1);
#line 47 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
WriteAttributeValue("", 2484, Model.DataModel.YearSales, 2484, 26, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2511, 162, true);
                WriteLiteral(" /><br />\r\n        <label>Resumen:</label><br /><textarea class=\"form-control\" name=\"notes\" required cols=\"60\"\r\n                                         rows=\"3\">");
                EndContext();
                BeginContext(2674, 21, false);
#line 49 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
                                             Write(Model.DataModel.Notas);

#line default
#line hidden
                EndContext();
                BeginContext(2695, 125, true);
                WriteLiteral("</textarea><br />\r\n        <label>Fecha de Pub.:</label><br /><input class=\"form-control\" type=\"date\" name=\"pubdate\" required");
                EndContext();
                BeginWriteAttribute("value", "\r\n                                            value=\"", 2820, "\"", 2904, 1);
#line 51 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
WriteAttributeValue("", 2873, Model.DataModel.FechaPublicado, 2873, 31, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2905, 27, true);
                WriteLiteral(" placeholder=\"mm-dd-yyyy\"/>");
                EndContext();
                BeginContext(2933, 30, false);
#line 51 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
                                                                                                         Write(Model.DataModel.FechaPublicado);

#line default
#line hidden
                EndContext();
                BeginContext(2963, 24, true);
                WriteLiteral("<br />\r\n\r\n<br /><br />\r\n");
                EndContext();
#line 54 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
  var disableaction = "";

#line default
#line hidden
#line 55 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
 if (@ViewData["isPostProcess"].Equals("1"))
{
    disableaction = "disabled";
    clsalert = "alert-ok";
}

#line default
#line hidden
                BeginContext(3128, 79, true);
                WriteLiteral("<input class=\"btn btn-primary\" type=\"submit\" name=\"btn_send\" value=\"Modificar\" ");
                EndContext();
                BeginContext(3208, 13, false);
#line 60 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
                                                                          Write(disableaction);

#line default
#line hidden
                EndContext();
                BeginContext(3221, 5, true);
                WriteLiteral(" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3233, 5, true);
            WriteLiteral("\r\n<h2");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 3238, "\"", 3255, 1);
#line 62 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
WriteAttributeValue("", 3246, clsalert, 3246, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3256, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(3258, 23, false);
#line 62 "C:\Users\THE_N\source\repos\Tarea02AppWeb\Tarea002MVC\Views\Tienda\modificar.cshtml"
                 Write(ViewData["MessageText"]);

#line default
#line hidden
            EndContext();
            BeginContext(3281, 13, true);
            WriteLiteral("</h2>\r\n</div>");
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