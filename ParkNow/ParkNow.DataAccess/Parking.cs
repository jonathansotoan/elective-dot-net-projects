//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ParkNow.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class Parking
    {
        public int Id { get; set; }
        public System.DateTime InDate { get; set; }
        public System.DateTime OutDate { get; set; }
        public int UserNationalId { get; set; }
        public string VehiclePlate { get; set; }
    
        public virtual User User { get; set; }
        public virtual Vehicle Vehicle { get; set; }
    }
}
