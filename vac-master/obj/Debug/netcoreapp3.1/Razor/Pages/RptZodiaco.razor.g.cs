#pragma checksum "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c212792b356d563a83bca71e3f59dc71062bf6a"
// <auto-generated/>
#pragma warning disable 1591
namespace vac_master.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using vac_master;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using vac_master.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using ChartJs.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using ChartJs.Blazor.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using ChartJs.Blazor.Common.Axes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using ChartJs.Blazor.Common.Axes.Ticks;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using ChartJs.Blazor.Common.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using ChartJs.Blazor.Common.Handlers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using ChartJs.Blazor.Common.Time;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using ChartJs.Blazor.Util;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\_Imports.razor"
using ChartJs.Blazor.Interop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
using vac_master.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
using vac_master.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/RptZodiaco")]
    public partial class RptZodiaco : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3><b>Reporte de Signos del Zodiaco</b></h3>\r\n<br>\r\n");
            __builder.OpenElement(1, "table");
            __builder.AddAttribute(2, "class", "table table-dark table-bordered");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<thead>\r\n        <tr>\r\n            <th>Signo</th>\r\n            <th>Cantidad</th>\r\n        </tr>\r\n    </thead>\r\n    ");
            __builder.OpenElement(5, "tbody");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenElement(7, "tr");
            __builder.AddMarkupContent(8, "\r\n            ");
            __builder.OpenElement(9, "td");
            __builder.AddContent(10, 
#nullable restore
#line 17 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 signo[0]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 18 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 capri

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "tr");
            __builder.AddMarkupContent(17, "\r\n            ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, 
#nullable restore
#line 21 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 signo[1]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenElement(21, "td");
            __builder.AddContent(22, 
#nullable restore
#line 22 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 acua

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n        ");
            __builder.OpenElement(25, "tr");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 25 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 signo[2]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n            ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 26 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 pis

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n        ");
            __builder.OpenElement(34, "tr");
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.OpenElement(36, "td");
            __builder.AddContent(37, 
#nullable restore
#line 29 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 signo[3]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.OpenElement(39, "td");
            __builder.AddContent(40, 
#nullable restore
#line 30 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 ari

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.OpenElement(43, "tr");
            __builder.AddMarkupContent(44, "\r\n            ");
            __builder.OpenElement(45, "td");
            __builder.AddContent(46, 
#nullable restore
#line 33 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 signo[4]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(47, "\r\n            ");
            __builder.OpenElement(48, "td");
            __builder.AddContent(49, 
#nullable restore
#line 34 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 tau

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.OpenElement(52, "tr");
            __builder.AddMarkupContent(53, "\r\n            ");
            __builder.OpenElement(54, "td");
            __builder.AddContent(55, 
#nullable restore
#line 37 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 signo[5]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n            ");
            __builder.OpenElement(57, "td");
            __builder.AddContent(58, 
#nullable restore
#line 38 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 gem

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "tr");
            __builder.AddMarkupContent(62, "\r\n            ");
            __builder.OpenElement(63, "td");
            __builder.AddContent(64, 
#nullable restore
#line 41 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 signo[6]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n            ");
            __builder.OpenElement(66, "td");
            __builder.AddContent(67, 
#nullable restore
#line 42 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 can

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(68, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.OpenElement(70, "tr");
            __builder.AddMarkupContent(71, "\r\n            ");
            __builder.OpenElement(72, "td");
            __builder.AddContent(73, 
#nullable restore
#line 45 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 signo[7]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n            ");
            __builder.OpenElement(75, "td");
            __builder.AddContent(76, 
#nullable restore
#line 46 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 leo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(78, "\r\n        ");
            __builder.OpenElement(79, "tr");
            __builder.AddMarkupContent(80, "\r\n            ");
            __builder.OpenElement(81, "td");
            __builder.AddContent(82, 
#nullable restore
#line 49 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 signo[8]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n            ");
            __builder.OpenElement(84, "td");
            __builder.AddContent(85, 
#nullable restore
#line 50 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 vir

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(86, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(87, "\r\n        ");
            __builder.OpenElement(88, "tr");
            __builder.AddMarkupContent(89, "\r\n            ");
            __builder.OpenElement(90, "td");
            __builder.AddContent(91, 
#nullable restore
#line 53 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 signo[9]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n            ");
            __builder.OpenElement(93, "td");
            __builder.AddContent(94, 
#nullable restore
#line 54 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 lib

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(95, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n        ");
            __builder.OpenElement(97, "tr");
            __builder.AddMarkupContent(98, "\r\n            ");
            __builder.OpenElement(99, "td");
            __builder.AddContent(100, 
#nullable restore
#line 57 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 signo[10]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(101, "\r\n            ");
            __builder.OpenElement(102, "td");
            __builder.AddContent(103, 
#nullable restore
#line 58 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 esc

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(105, "\r\n        ");
            __builder.OpenElement(106, "tr");
            __builder.AddMarkupContent(107, "\r\n            ");
            __builder.OpenElement(108, "td");
            __builder.AddContent(109, 
#nullable restore
#line 61 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 signo[11]

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n            ");
            __builder.OpenElement(111, "td");
            __builder.AddContent(112, 
#nullable restore
#line 62 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
                 sag

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(113, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(114, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 67 "C:\Users\gt\Desktop\Vac-sys\vaccination-system\vac-master\Pages\RptZodiaco.razor"
       
    covid19Context db = new covid19Context();
    List<Persona> personas = new List<Persona>();
    DateTime fecha = new DateTime();
    string zodiaco;
    int capri, acua, pis, ari, tau, gem, can, leo, vir, lib, esc, sag;
    List<string> signo = new List<string>() { "Capricornio", "Acuario", "Piscis", "Aries", "Tauro", "Geminis", "Cancer", "Leo", "Virgo", "Libra", "Escorpio", "Sagitario" };
    List<int> fechas = new List<int>() { 20, 19, 20, 20, 21, 21, 22, 22, 22, 22, 22, 21 };

    protected override void OnInitialized()
    {
        personas = db.Persona.ToList();

        foreach (var i in personas)
        {
            fecha = Convert.ToDateTime(i.FechaNac);

            int dia = fecha.Day;
            int mes = fecha.Month;
            int year = fecha.Year;

            mes = mes - 1;
            if (dia > fechas[mes])
            {
                mes = mes + 1;
            }
            zodiaco = signo[mes];

            if (zodiaco == "Capricornio")
            {
                capri++;
            }
            else if (zodiaco == "Acuario")
            {
                acua++;
            }
            else if (zodiaco == "Piscis")
            {
                pis++;
            }
            else if (zodiaco == "Aries")
            {
                ari++;
            }
            else if (zodiaco == "Tauro")
            {
                tau++;
            }
            else if (zodiaco == "Geminis")
            {
                gem++;
            }
            else if (zodiaco == "Cancer")
            {
                can++;
            }
            else if (zodiaco == "Leo")
            {
                leo++;
            }
            else if (zodiaco == "Virgo")
            {
                vir++;
            }
            else if (zodiaco == "Libra")
            {
                lib++;
            }
            else if (zodiaco == "Escorpio")
            {
                esc++;
            }
            else if (zodiaco == "Sagitario")
            {
                sag++;
            }
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591