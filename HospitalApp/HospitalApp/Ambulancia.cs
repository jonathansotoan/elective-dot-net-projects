using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalApp
{
    class Ambulancia
    {
        public string Matricula { get; set; }
        public bool estaOcupada { get; set; }
        public string DescripcionDotacion { get; set; }
        public DateTime FechaUltimoMantenimiento { get; set; }

        public override string ToString()
        {
            return string.Format("Matricula: {0}, ¿está ocupado?: {1}, descripción de la dotación: {2}, fecha último mantenimiento: {3}",
                Matricula, estaOcupada ? "Sí" : "No", DescripcionDotacion, FechaUltimoMantenimiento);
        }
    }
}
