using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Heladeria
{
    public class IceCream
    {
        public string Name { get; set; }
        public decimal Price
        {
            get
            {
                return Name == "Super Delicioso arcoiris" ? 4000 : 2500;
            }
        }
    }
}
