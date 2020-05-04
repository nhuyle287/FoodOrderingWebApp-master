using System;
using System.Collections.Generic;

namespace FoodOrderingWebApp.Models
{
    public partial class PhiShip
    {
        public PhiShip()
        {
            HoaDon = new HashSet<HoaDon>();
        }

        public int PhiShipId { get; set; }
        public int? Quan { get; set; }
        public int? ChiPhi { get; set; }

        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
