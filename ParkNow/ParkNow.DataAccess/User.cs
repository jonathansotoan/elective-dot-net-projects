//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel;

namespace ParkNow.DataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class User
    {
        public User()
        {
            this.Parkings = new HashSet<Parking>();
        }
    
        public int NationalId { get; set; }
        public string Username { get; set; }

        [Browsable(false)]
        public string Password { get; set; }
        public Role Role { get; set; }
    
        [Browsable(false)]
        public virtual ICollection<Parking> Parkings { get; set; }


        public override string ToString()
        {
            return string.Format("{{ National id: {0}, Username: {1}, Role: {2} }}", NationalId, Username, Role.ToString());
        }
    }
}
