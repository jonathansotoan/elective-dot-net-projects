using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonaFormulario.Universidades;

namespace PersonaFormulario.Facturas
{
    public class Ciudad : Municipio
    {
        public override string ToString()
        {
            return Nombre;
        }
    }
}
