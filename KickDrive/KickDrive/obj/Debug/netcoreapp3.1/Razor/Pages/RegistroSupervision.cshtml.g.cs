#pragma checksum "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\RegistroSupervision.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37d58cb23c45294284a99fe1e99cfcd369b3d14b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(KickDrive.Pages.Pages_RegistroSupervision), @"mvc.1.0.razor-page", @"/Pages/RegistroSupervision.cshtml")]
namespace KickDrive.Pages
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37d58cb23c45294284a99fe1e99cfcd369b3d14b", @"/Pages/RegistroSupervision.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04d0b880106d236aaf18ac66f1360772515c0885", @"/Pages/_ViewImports.cshtml")]
    public class Pages_RegistroSupervision : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link text-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\saile\Documents\Aplicaciones WEB\GitHub\KickDrive\KickDrive\Pages\RegistroSupervision.cshtml"
  
    ViewData["Title"] = "RegistroSupervision";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Registro Supervisión</h1>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37d58cb23c45294284a99fe1e99cfcd369b3d14b4321", async() => {
                WriteLiteral("\r\n    <div style=\"float:right\">");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "37d58cb23c45294284a99fe1e99cfcd369b3d14b4610", async() => {
                    WriteLiteral("Atras");
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
                WriteLiteral(@"</div>
    <div>
        <div>Llene el siguiente formulario (Si tiene * no se puede omitir)</div>
        <div>
            <label>Ingrese el Nombre del Supervisor*</label>
            <input type=""text"" class=""form-control"" aria-label=""Small"" aria-describedb nombresup=""nombresup"" id=""nombresup"" placeholder=""Ingrese el Nombre"" />
        </div>
        <div>
            <label>Ingrese el ID del supervisor*</label>
            <input type=""text"" class=""form-control"" aria-label=""Small"" aria-describedb Numsupervisor=""numsupervisor"" id=""numsupervisor"" placeholder=""Ingrese el ID"" />
        </div>
        <div>
            <label>Ingrese la ruta que supervisa*</label>
            <input type=""text"" class=""form-control"" aria-label=""Small"" aria-describedb Ruta=""ruta"" id=""ruta"" placeholder=""Ingrese la ruta"" />
        </div>
        <div>
            <label>Ingrese el ID del conductor*</label>
            <input type=""text"" class=""form-control"" aria-label=""Small"" aria-describedb Numsupervisor=""numsup");
                WriteLiteral(@"ervisor"" id=""numsupervisor"" placeholder=""Ingrese el ID"" />
        </div>
        <div>
            <label>Ingrese el nombre del conductor*</label>
            <input type=""text"" class=""form-control"" aria-label=""Small"" aria-describedb Nombrecond=""Nombrecond"" id=""nombrecond"" placeholder=""Ingrese el nombre"" />
        </div>
        <div>
            <label>Ingrese si hubo algun incidente</label>
            <input type=""text"" class=""form-control"" aria-label=""Small"" aria-describedb placas=""placas"" id=""placas"" placeholder=""Incidentes"" />
        </div>
    </div>
    <btn type=""submit"" class=""btn btn-primary"" value=""Registrar"">Registrar</btn>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KickDrive.Pages.RegistroSupervisionModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KickDrive.Pages.RegistroSupervisionModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<KickDrive.Pages.RegistroSupervisionModel>)PageContext?.ViewData;
        public KickDrive.Pages.RegistroSupervisionModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591