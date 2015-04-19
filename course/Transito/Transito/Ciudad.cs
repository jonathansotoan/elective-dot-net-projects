using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Transito
{
    public class Ciudad
    {
        public string Codigo { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return string.Format("Código: {0}, Nombre: {1}", Codigo, Nombre);
        }

        public override bool Equals(object obj)
        {
            if (this.GetType() == obj.GetType())
            {
                var other = (Ciudad) obj;
                return this.Codigo == other.Codigo && this.Nombre == other.Nombre;
            }

            return false;
        }
    }
}
