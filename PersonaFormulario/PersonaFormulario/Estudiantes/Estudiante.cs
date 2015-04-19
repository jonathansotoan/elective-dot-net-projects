using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PersonaFormulario.Universidades;

namespace PersonaFormulario.Estudiantes
{
    public class Estudiante
    {
        public Universidad Universidad { get; set; }
        public string Nombre { get; set; }
        public int Identificacion { get; set; }
        public int ValorMatricula { get; set; }
        public DateTime FechaMatricula { get; set; }
    }
}
