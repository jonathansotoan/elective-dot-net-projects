using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonaFormulario.Universidades
{
    public class Universidad
    {
        public int Nit { get; set; }
        public string Nombre { get; set; }
        public Municipio Municipio { get; set; }
        public string Direccion { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
