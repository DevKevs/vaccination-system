using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace vac_master.Models
{
    public partial class Provincias
    {
        public Provincias()
        {
            Vacunados = new HashSet<Vacunados>();
        }

        public int Id { get; set; }
        public string Provincia { get; set; }

        public virtual ICollection<Vacunados> Vacunados { get; set; }
    }
}
