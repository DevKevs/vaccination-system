using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace vac_master.Models
{
    public partial class Persona
    {
        public Persona()
        {
            Vacunados = new HashSet<Vacunados>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Cedula { get; set; }
        public string FechaNac { get; set; }

        public virtual ICollection<Vacunados> Vacunados { get; set; }
    }
}
