// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
