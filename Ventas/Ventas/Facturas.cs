//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ventas
{
    using System;
    using System.Collections.Generic;
    
    public partial class Facturas
    {
        public Facturas()
        {
            this.DetalleFacturas = new HashSet<DetalleFacturas>();
        }
    
        public int Id { get; set; }
        public System.DateTime Fecha { get; set; }
        public decimal ValorTotal { get; set; }
        public string Ciudad { get; set; }
    
        public virtual ICollection<DetalleFacturas> DetalleFacturas { get; set; }
    }
}
