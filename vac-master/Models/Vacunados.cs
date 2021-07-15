using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace vac_master.Models
{
    public partial class Vacunados
    {
        public int Id { get; set; }
        public int IdPersona { get; set; }
        public int IdVacuna { get; set; }
        public int IdProvincia { get; set; }
        public DateTime Fecha { get; set; }

        public virtual Persona IdPersonaNavigation { get; set; }
        public virtual Provincias IdProvinciaNavigation { get; set; }
        public virtual Vacuna IdVacunaNavigation { get; set; }
    }
}
