using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalApp
{
    class Hospital
    {
        public string Nombre {get; set;}
        public string Direccion { get; set; }
        public string Nit { get; set; }
        public List<Especialidad> Especialidades { get; set; }

        public Hospital()
        {
            Especialidades = new List<Especialidad>();
        }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, Dirección: {1}, Nit: {2}, Especialidades: {3}",
                Nombre, Direccion, Nit, Especialidades);
        }
    }
}
