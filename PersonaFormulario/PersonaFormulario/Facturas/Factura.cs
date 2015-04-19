using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonaFormulario.Facturas
{
    public class Factura
    {
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public Ciudad Ciudad { get; set; }
        public decimal Valor { get; set; }
        public string Producto { get; set; }
        public string NombreCliente { get; set; }
    }
}
