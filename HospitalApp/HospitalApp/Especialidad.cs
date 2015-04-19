using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalApp
{
    class Especialidad
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public byte Piso { get; set; }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, Descripción: {1}, Piso: {2}",
                Nombre, Descripcion, Piso);
        }
    }
}
