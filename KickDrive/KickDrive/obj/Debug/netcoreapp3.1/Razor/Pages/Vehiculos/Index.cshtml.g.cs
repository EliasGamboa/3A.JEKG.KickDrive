#pragma checksum "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02f11bf245551822e17bda0feabea3a7be2ec9b2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KickDrive.Pages.Vehiculos.Pages_Vehiculos_Index), @"mvc.1.0.razor-page", @"/Pages/Vehiculos/Index.cshtml")]
namespace KickDrive.Pages.Vehiculos
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
#line 1 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\_ViewImports.cshtml"
using KickDrive;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02f11bf245551822e17bda0feabea3a7be2ec9b2", @"/Pages/Vehiculos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dd0f46595bb662d961256a542e4795f3a7d71572", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Vehiculos_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/RegistroVehiculos", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Vehiculos Registrados</h1>\r\n");
#nullable restore
#line 8 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
 if(Model.Vehiculos.Any())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\" table table-info table-striped\">\r\n        <!--Head-->\r\n        <thead class=\"thead-dark\">\r\n            <tr>\r\n                <th scope=\"col\">");
#nullable restore
#line 14 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
                           Write(Html.DisplayNameFor(x => x.Vehiculos.FirstOrDefault().NumeroCamion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 15 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
                           Write(Html.DisplayNameFor(x => x.Vehiculos.FirstOrDefault().NombreProp));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 16 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
                           Write(Html.DisplayNameFor(x => x.Vehiculos.FirstOrDefault().Automovil));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 17 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
                           Write(Html.DisplayNameFor(x => x.Vehiculos.FirstOrDefault().Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 18 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
                           Write(Html.DisplayNameFor(x => x.Vehiculos.FirstOrDefault().NumeroMotor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 19 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
                           Write(Html.DisplayNameFor(x => x.Vehiculos.FirstOrDefault().Largo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 20 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
                           Write(Html.DisplayNameFor(x => x.Vehiculos.FirstOrDefault().Ancho));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 21 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
                           Write(Html.DisplayNameFor(x => x.Vehiculos.FirstOrDefault().Alto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 22 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
                           Write(Html.DisplayNameFor(x => x.Vehiculos.FirstOrDefault().Uso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 23 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
                           Write(Html.DisplayNameFor(x => x.Vehiculos.FirstOrDefault().Placas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                <th scope=\"col\">");
#nullable restore
#line 24 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
                           Write(Html.DisplayNameFor(x => x.Vehiculos.FirstOrDefault().VehiculoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n            </tr>\r\n        </thead>\r\n        <!--Body-->\r\n        <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
             foreach (var item in Model.Vehiculos)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td scope=\"row\">");
#nullable restore
#line 32 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
                           Write(Html.DisplayFor(m => item.NumeroCamion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
               Write(Html.DisplayFor(m => item.NombreProp));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 34 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
               Write(Html.DisplayFor(m => item.Automovil));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 35 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
               Write(Html.DisplayFor(m => item.Modelo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 36 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
               Write(Html.DisplayFor(m => item.NumeroMotor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 37 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
               Write(Html.DisplayFor(m => item.Largo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 38 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
               Write(Html.DisplayFor(m => item.Alto));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 39 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
               Write(Html.DisplayFor(m => item.Ancho));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 40 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
               Write(Html.DisplayFor(m => item.Uso));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 41 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
               Write(Html.DisplayFor(m => item.Placas));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 42 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
               Write(Html.DisplayFor(m => item.VehiculoId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 44 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table> \r\n");
#nullable restore
#line 47 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"mx-auto text-center\">\r\n        <span class=\"text-danger\">No se encontraron Vehículos</span>\r\n    </div>\r\n");
#nullable restore
#line 53 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\Vehiculos\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02f11bf245551822e17bda0feabea3a7be2ec9b213070", async() => {
                WriteLiteral("\r\n    <div>\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "02f11bf245551822e17bda0feabea3a7be2ec9b213350", async() => {
                    WriteLiteral("Registrar Vehiculos");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KickDrive.Pages.Vehiculos.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KickDrive.Pages.Vehiculos.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KickDrive.Pages.Vehiculos.IndexModel>)PageContext?.ViewData;
        public KickDrive.Pages.Vehiculos.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
