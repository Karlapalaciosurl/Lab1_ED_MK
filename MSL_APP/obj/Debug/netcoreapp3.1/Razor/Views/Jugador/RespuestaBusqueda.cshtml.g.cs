#pragma checksum "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e909cec9d57e42bb82bbc48105f95b3c0b3d4906"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Jugador_RespuestaBusqueda), @"mvc.1.0.view", @"/Views/Jugador/RespuestaBusqueda.cshtml")]
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
#line 1 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
using MSL_APP.Utils;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
using LstDoblementeEnlazada;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e909cec9d57e42bb82bbc48105f95b3c0b3d4906", @"/Views/Jugador/RespuestaBusqueda.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"842adb9d297c0707ba45f97eb1939bb50567027c", @"/Views/_ViewImports.cshtml")]
    public class Views_Jugador_RespuestaBusqueda : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Nodo<string>>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
  
    ViewData["Title"] = "Response Search";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"header center orange-text\">Resultado Busqueda</h1>\r\n<div class=\"row center\">\r\n    <h5 class=\"header col s12 light\">Contenido del resultado de la busqueda</h5>\r\n\r\n</div>\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 16 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
     foreach (Nodo<string> item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <ul class=\"collection with-header col s3\">\r\n            <li class=\"collection-header\"><h4>");
#nullable restore
#line 19 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
                                         Write(item.first_name);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 19 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
                                                          Write(item.last_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4></li>\r\n            <li class=\"collection-item\">Club: ");
#nullable restore
#line 20 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
                                         Write(item.club);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"collection-item\">Posicion: ");
#nullable restore
#line 21 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
                                             Write(item.position);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"collection-item\">Salario: ");
#nullable restore
#line 22 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
                                            Write(item.base_salary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"collection-item\">Compensacion: ");
#nullable restore
#line 23 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
                                                 Write(item.guaranteed_compensation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n            <li class=\"collection-item center-align\"><a");
            BeginWriteAttribute("href", " href=\"", 883, "\"", 955, 4);
            WriteAttributeValue("", 890, "/Jugador/eliminarJugador?jugador=", 890, 33, true);
#nullable restore
#line 24 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
WriteAttributeValue("", 923, item.first_name, 923, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 939, ",", 939, 1, true);
#nullable restore
#line 24 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
WriteAttributeValue("", 940, item.last_name, 940, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"small material-icons red-text\">delete</i></a> <a");
            BeginWriteAttribute("href", " href=\"", 1015, "\"", 1085, 4);
            WriteAttributeValue("", 1022, "/Jugador/editarJugador?jugador=", 1022, 31, true);
#nullable restore
#line 24 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
WriteAttributeValue("", 1053, item.first_name, 1053, 16, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1069, ",", 1069, 1, true);
#nullable restore
#line 24 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
WriteAttributeValue("", 1070, item.last_name, 1070, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"small material-icons blue-text\">edit</i></a></li>\r\n        </ul>\r\n");
#nullable restore
#line 26 "C:\Users\Juan-Gtsk\Desktop\Lab1_ED_MK\MSL_APP\Views\Jugador\RespuestaBusqueda.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Nodo<string>>> Html { get; private set; }
    }
}
#pragma warning restore 1591
