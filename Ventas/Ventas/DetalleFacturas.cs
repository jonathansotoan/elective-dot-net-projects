//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Ventas
{
    using System;
    using System.Collections.Generic;
    
    public partial class DetalleFacturas
    {
        public int Id { get; set; }
        public int IdFactura { get; set; }
        public string NombreProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    
        public virtual Facturas Facturas { get; set; }
    }
}
