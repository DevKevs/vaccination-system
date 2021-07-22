using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Newtonsoft.Json.Converters;
using vac_master.Models;

namespace vac_master.Data
{
    public class Dataprocess
    {
        covid19Context db = new covid19Context();
        //Area de proceso de configuraciones 

        //configuracion de vacunas 
        public void AddVacuna(Vacuna obj)
        {
            db.Vacuna.Add(obj);
            db.SaveChanges();
        }
        public void UpdateVacuna(Vacuna obj)
        {
            var query = from Vacuna in db.Vacuna
                        where Vacuna.Id == obj.Id
                        select Vacuna;
            Vacuna registro = query.First();
            registro.NombreVacuna = obj.NombreVacuna;
            db.SaveChanges();
        }

        //configuracion de provincias 

        public void AddProvincia(Provincias obj)
        {
            db.Provincias.Add(obj);
            db.SaveChanges();
        }
        public void UpdateProvincia(Provincias obj)
        {
            var query = from Provincias in db.Provincias
                        where Provincias.Id == obj.Id
                        select Provincias;
            Provincias registro = query.First();
            registro.Provincia = obj.Provincia;
            db.SaveChanges(); 
        }

        //agregacion de persona 
        public void AddPersona(Persona obj)
        {
            db.Persona.Add(obj);
            db.SaveChanges();
        }
        //Agregar vacunados 
        public void AddVacunado(Vacunados obj)
        {
            db.Vacunados.Add(obj);
            db.SaveChanges();
        }

        public void RemoveDosis(Vacunados obj)
        {
            db.Vacunados.Remove(obj);
            db.SaveChanges();
        }
    }
}
