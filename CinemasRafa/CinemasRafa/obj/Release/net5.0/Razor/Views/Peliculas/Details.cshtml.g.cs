#pragma checksum "D:\TFG_FINAL\CinemasRafa\CinemasRafa\Views\Peliculas\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "350eb84ca0bd05cf4c70354ca10cb381a07bd313"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Peliculas_Details), @"mvc.1.0.view", @"/Views/Peliculas/Details.cshtml")]
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
#line 1 "D:\TFG_FINAL\CinemasRafa\CinemasRafa\Views\_ViewImports.cshtml"
using CinemasRafa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\TFG_FINAL\CinemasRafa\CinemasRafa\Views\_ViewImports.cshtml"
using CinemasRafa.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"350eb84ca0bd05cf4c70354ca10cb381a07bd313", @"/Views/Peliculas/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c394bf98eafe1856376ce63c05b2e51431f9ee02", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Peliculas_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CinemasRafa.Models.Peliculas>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div>\r\n    <hr />\r\n     <div class=\"card container pt-4\">\r\n            <div class=\"card-header bg-primary text-light ml-0  row \">\r\n                <div class=\"col-12 col-md-6\">\r\n                    <h1 class=\"text-white-50\">");
#nullable restore
#line 8 "D:\TFG_FINAL\CinemasRafa\CinemasRafa\Views\Peliculas\Details.cshtml"
                                         Write(Model.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                    <p class=\"text-warning\">by ");
#nullable restore
#line 9 "D:\TFG_FINAL\CinemasRafa\CinemasRafa\Views\Peliculas\Details.cshtml"
                                          Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n                <div class=\"col-12 col-md-6 text-end pt-4\">\r\n                    <span class=\"badge bg-danger pt-2\" style=\"height:30px;\">");
#nullable restore
#line 12 "D:\TFG_FINAL\CinemasRafa\CinemasRafa\Views\Peliculas\Details.cshtml"
                                                                       Write(Model.Pegi.EdadMin);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    <span class=\"badge bg-warning pt-2\" style=\"height:30px;\">");
#nullable restore
#line 13 "D:\TFG_FINAL\CinemasRafa\CinemasRafa\Views\Peliculas\Details.cshtml"
                                                                        Write(Model.Categoria.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                </div>
            </div>
            <div class=""card-body row container"">
                <div class=""container rounded p-2"">
                    <div class=""row"">
                        <div class=""col-8 col-lg-8"">

                            <div class=""row pl-2"">
                                <h5 class=""text-muted"">Duracion : ");
#nullable restore
#line 22 "D:\TFG_FINAL\CinemasRafa\CinemasRafa\Views\Peliculas\Details.cshtml"
                                                             Write(Model.Duracion);

#line default
#line hidden
#nullable disable
            WriteLiteral(" min</h5>\r\n                            </div>\r\n                            <div class=\"row pl-2\">\r\n                                <h5 class=\"text-muted\">Año de Estreno : ");
#nullable restore
#line 25 "D:\TFG_FINAL\CinemasRafa\CinemasRafa\Views\Peliculas\Details.cshtml"
                                                                   Write(Model.FechaEstreno.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            </div>\r\n\r\n                            <div class=\"row mt-3 mb-3 pl-2\">\r\n                                <p>");
#nullable restore
#line 29 "D:\TFG_FINAL\CinemasRafa\CinemasRafa\Views\Peliculas\Details.cshtml"
                              Write(Model.Descripcion);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            </div>\r\n                            <p class=\"text-warning\">\r\n                                Valoracion: ");
#nullable restore
#line 32 "D:\TFG_FINAL\CinemasRafa\CinemasRafa\Views\Peliculas\Details.cshtml"
                                       Write(Model.Valoracion);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi text-warning bi-star-fill"" viewBox=""0 0 16 16"">
                                    <path d=""M3.612 15.443c-.386.198-.824-.149-.746-.592l.83-4.73L.173 6.765c-.329-.314-.158-.888.283-.95l4.898-.696L7.538.792c.197-.39.73-.39.927 0l2.184 4.327 4.898.696c.441.062.612.636.282.95l-3.522 3.356.83 4.73c.078.443-.36.79-.746.592L8 13.187l-4.389 2.256z"" />
                                </svg>
                            </p>
                            <a class=""btn btn-success""");
            BeginWriteAttribute("href", " href=\"", 2107, "\"", 2132, 1);
#nullable restore
#line 36 "D:\TFG_FINAL\CinemasRafa\CinemasRafa\Views\Peliculas\Details.cshtml"
WriteAttributeValue("", 2114, Model.UrlDescarga, 2114, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                                Descargar <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-download"" viewBox=""0 0 16 16"">
                                    <path d=""M.5 9.9a.5.5 0 0 1 .5.5v2.5a1 1 0 0 0 1 1h12a1 1 0 0 0 1-1v-2.5a.5.5 0 0 1 1 0v2.5a2 2 0 0 1-2 2H2a2 2 0 0 1-2-2v-2.5a.5.5 0 0 1 .5-.5z"" />
                                    <path d=""M7.646 11.854a.5.5 0 0 0 .708 0l3-3a.5.5 0 0 0-.708-.708L8.5 10.293V1.5a.5.5 0 0 0-1 0v8.793L5.354 8.146a.5.5 0 1 0-.708.708l3 3z"" />
                                </svg>
                            </a>
                        </div>
                        <div class=""col-12 col-lg-3 offset-lg-1 text-center"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 2889, "\"", 2910, 1);
#nullable restore
#line 44 "D:\TFG_FINAL\CinemasRafa\CinemasRafa\Views\Peliculas\Details.cshtml"
WriteAttributeValue("", 2895, Model.ImageUrl, 2895, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"90%\" height=\"auto\" class=\"rounded\" />\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            <div class=\"card-footer\">\r\n                <div class=\"row\">\r\n\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "350eb84ca0bd05cf4c70354ca10cb381a07bd3139631", async() => {
                WriteLiteral("Volver");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CinemasRafa.Models.Peliculas> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
