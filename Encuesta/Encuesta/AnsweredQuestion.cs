using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Encuesta
{
    public class AnsweredQuestion
    {
        public string Question { get; set; }
        public string Answer { get; set; }

        public override string ToString()
        {
            return "[Pregunta: " + Question + ", Respuesta: " + Answer + "]";
        }
    }
}
