#pragma checksum "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcbb334822b56fcf79553787009a704ce388e56f"
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
#line 1 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\_Imports.razor"
using vac_master;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\_Imports.razor"
using vac_master.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor"
using vac_master.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor"
using vac_master.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor"
using System.Linq;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Config")]
    public partial class Config : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Configuracion de registros</h3>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card text-white bg-dark mb-3 p-4");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<h4>Vacunas Management</h4>\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "form-group");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<label><b>Inserte el ID (solo para actualizar)</b></label>\r\n        <br>\r\n        ");
            __builder.OpenElement(9, "input");
            __builder.AddAttribute(10, "class", "form-control");
            __builder.AddAttribute(11, "placeholder", "Id vacuna");
            __builder.AddAttribute(12, "type", "number");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 12 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor"
                      idV

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => idV = __value, idV, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "form-group");
            __builder.AddMarkupContent(19, "\r\n        ");
            __builder.AddMarkupContent(20, "<label><b>Inserte el nombre de la Vacuna</b></label>\r\n        <br>\r\n        ");
            __builder.OpenElement(21, "input");
            __builder.AddAttribute(22, "class", "form-control");
            __builder.AddAttribute(23, "placeholder", "Marca vacuna");
            __builder.AddAttribute(24, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 17 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor"
                      datoV

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => datoV = __value, datoV));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n    <br>\r\n    ");
            __builder.OpenElement(28, "center");
            __builder.AddMarkupContent(29, "\r\n        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "form-group");
            __builder.AddMarkupContent(32, "\r\n            ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor"
                              AgregarVacuna

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "class", "btn btn-success");
            __builder.AddContent(36, "Agregar vacuna");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n            ");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor"
                              EditarVacuna

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "class", "btn btn-primary");
            __builder.AddContent(41, "Editar vacuna");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n    ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "alert alert-success d-flex align-items-center");
            __builder.AddAttribute(47, "role", "alert");
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.OpenElement(49, "div");
            __builder.AddMarkupContent(50, "\r\n            ");
            __builder.OpenElement(51, "b");
            __builder.AddContent(52, 
#nullable restore
#line 28 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor"
                message

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n<br>\r\n");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "card text-white bg-dark mb-3 p-4");
            __builder.AddMarkupContent(59, "\r\n    ");
            __builder.AddMarkupContent(60, "<h4>Provincias Management</h4>\r\n    ");
            __builder.OpenElement(61, "div");
            __builder.AddAttribute(62, "class", "form-group");
            __builder.AddMarkupContent(63, "\r\n        ");
            __builder.AddMarkupContent(64, "<label><b>Inserte el ID (solo para actualizar)</b></label>\r\n        <br>\r\n        ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "class", "form-control");
            __builder.AddAttribute(67, "placeholder", "Id Provincia");
            __builder.AddAttribute(68, "type", "number");
            __builder.AddAttribute(69, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 38 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor"
                      idP

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(70, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => idP = __value, idP, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.OpenElement(73, "div");
            __builder.AddAttribute(74, "class", "form-group");
            __builder.AddMarkupContent(75, "\r\n        ");
            __builder.AddMarkupContent(76, "<label><b>Inserte el nombre de la Provincia</b></label>\r\n        <br>\r\n        ");
            __builder.OpenElement(77, "input");
            __builder.AddAttribute(78, "class", "form-control");
            __builder.AddAttribute(79, "placeholder", "Nombre provincia");
            __builder.AddAttribute(80, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 43 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor"
                      datoP

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(81, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => datoP = __value, datoP));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n    <br>\r\n    ");
            __builder.OpenElement(84, "center");
            __builder.AddMarkupContent(85, "\r\n        ");
            __builder.OpenElement(86, "div");
            __builder.AddAttribute(87, "class", "form-group");
            __builder.AddMarkupContent(88, "\r\n            ");
            __builder.OpenElement(89, "button");
            __builder.AddAttribute(90, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 48 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor"
                              AgregarProvincia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(91, "class", "btn btn-success");
            __builder.AddContent(92, "Agregar provincia");
            __builder.CloseElement();
            __builder.AddMarkupContent(93, "\r\n            ");
            __builder.OpenElement(94, "button");
            __builder.AddAttribute(95, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 49 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor"
                              ActualizarProvincia

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(96, "class", "btn btn-primary");
            __builder.AddContent(97, "Editar provincia");
            __builder.CloseElement();
            __builder.AddMarkupContent(98, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(99, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n    ");
            __builder.OpenElement(101, "div");
            __builder.AddAttribute(102, "class", "alert alert-success d-flex align-items-center");
            __builder.AddAttribute(103, "role", "alert");
            __builder.AddMarkupContent(104, "\r\n        ");
            __builder.OpenElement(105, "div");
            __builder.AddMarkupContent(106, "\r\n            ");
            __builder.OpenElement(107, "b");
            __builder.AddContent(108, 
#nullable restore
#line 54 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor"
                message2

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(110, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(111, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 59 "C:\Users\Huascar\Desktop\5toC\Prog1\vaccine-sys\vaccination-system\vac-master\Pages\Config.razor"
       
    //variables y operadores de las consultas 
    int idV;
    string datoV;

    int idP;
    string datoP;

    string message;
    string message2;
    Vacuna vac = new Vacuna();
    Provincias pro = new Provincias();
    Dataprocess data = new Dataprocess();

    //funcion para agregar un tipo de vacuna 
    public void AgregarVacuna()
    {
        try
        {
            vac.NombreVacuna = datoV;
            data.AddVacuna(vac);
            message = "Vacuna agregada!";
        }
        catch (Exception)
        {

            message = "No se pudo agregar la vacuna";
        }

    }
    //funcion para modificar un tipo de vacuna 
    public void EditarVacuna()
    {
        try
        {
            vac.Id = idV;
            vac.NombreVacuna = datoV;
            data.UpdateVacuna(vac);
            message = "Vacuna Actualizada!";
        }
        catch (Exception)
        {

            message = "No se pudo editar la vacuna";
        }

    }
    //funcion para agregar una provincia 
    public void AgregarProvincia()
    {
        try
        {
            pro.Provincia = datoP;
            data.AddProvincia(pro);
            message2 = "Provincia Agregada!";
        }
        catch (Exception)
        {

            message2 = "no se pudo agregar la provincia";
        }
    }
    //funcion para modificar una provincia 
    public void ActualizarProvincia()
    {
        try
        {
            pro.Id = idP;
            pro.Provincia = datoP;
            data.UpdateProvincia(pro);
            message2 = "Provincia Actualizada!";
        }
        catch (Exception)
        {

            message2 = "No se pudo actualizar la provincia";
        }
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
