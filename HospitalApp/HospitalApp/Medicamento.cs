using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalApp
{
    class Medicamento
    {
        public string Nombre { get; set; }
        public string Uso { get; set; }
        public string Contraindicaciones { get; set; }
        public int MiligramosMaximos { get; set; }

        public override string ToString()
        {
            return string.Format("Nombre: {0}, Uso: {1}, Contraindicaciones: {2}, Miligramos máximos: {3}",
                Nombre, Uso, Contraindicaciones, MiligramosMaximos);
        }
    }
}
