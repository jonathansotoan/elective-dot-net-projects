using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonaFormulario
{
    class Marca
    {
        public int Codigo { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
