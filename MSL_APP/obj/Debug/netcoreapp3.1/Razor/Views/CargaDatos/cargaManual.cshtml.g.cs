#pragma checksum "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\CargaDatos\cargaManual.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50913e5989094ef666370bb39c71256804a2dd97"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CargaDatos_cargaManual), @"mvc.1.0.view", @"/Views/CargaDatos/cargaManual.cshtml")]
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
#line 1 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\_ViewImports.cshtml"
using MSL_APP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\_ViewImports.cshtml"
using MSL_APP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\CargaDatos\cargaManual.cshtml"
using MSL_APP.Utils;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50913e5989094ef666370bb39c71256804a2dd97", @"/Views/CargaDatos/cargaManual.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"842adb9d297c0707ba45f97eb1939bb50567027c", @"/Views/_ViewImports.cshtml")]
    public class Views_CargaDatos_cargaManual : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("col s12"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\CargaDatos\cargaManual.cshtml"
  
    ViewData["Title"] = "Manual loader";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"header center orange-text\">");
#nullable restore
#line 6 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\CargaDatos\cargaManual.cshtml"
                                 Write(Storage.Instance.tipoCarga);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"row center\">\r\n    <h5 class=\"header col s12 light\">Ingrese las propiedades de los jugadores de la MLS</h5>\r\n\r\n</div>\r\n\r\n<div class=\"input-field col s12\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50913e5989094ef666370bb39c71256804a2dd974775", async() => {
                WriteLiteral(@"
        <div class=""row"">
            <div class=""row"">
                <div class=""input-field col s2"">
                    <input id=""club_"" type=""text"" name=""club"">
                    <label for=""club_"">Club</label>
                </div>
                <div class=""input-field col s5"">
                    <input id=""last_name"" type=""text"" name=""last_name"">
                    <label for=""last_name"">Apellido</label>
                </div>
                <div class=""input-field col s5"">
                    <input id=""first_name"" type=""text"" name=""first_name"">
                    <label for=""first_name"">Nombre</label>
                </div>
            </div>
            <div class=""row"">

                <div class=""input-field col s2"">
                    <input id=""position_"" type=""text"" name=""position"">
                    <label for=""position_"">Posicion</label>
                </div>
                <div class=""input-field col s5"">
                    <input id=""salary_"" type=""");
                WriteLiteral(@"text"" name=""salary"">
                    <label for=""salary_"">Salario</label>
                </div>
                <div class=""input-field col s5"">
                    <input id=""compensation_"" type=""text"" name=""compensation"">
                    <label for=""compensation_"">Compensacion</label>
                </div>
            </div>
        </div>
        <button class=""btn waves-effect waves-light center"" type=""submit"" name=""action"">
            Submit
            <i class=""material-icons right"">send</i>
        </button>
    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 13 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\CargaDatos\cargaManual.cshtml"
AddHtmlAttributeValue("", 331, Url.Action("DatosManuales", "CargaDatos"), 331, 42, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
