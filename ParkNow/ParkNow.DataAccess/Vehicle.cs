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
    
    public abstract partial class Vehicle
    {
        public Vehicle()
        {
            this.Parkings = new HashSet<Parking>();
        }
    
        public string Plate { get; set; }
    
        public virtual ICollection<Parking> Parkings { get; set; }


        public abstract decimal HourPrice { get; }
        public abstract decimal HalfHourPrice { get; }
    }
}
