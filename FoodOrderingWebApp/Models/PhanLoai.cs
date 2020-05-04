using System;
using System.Collections.Generic;

namespace FoodOrderingWebApp.Models
{
    public partial class PhanLoai
    {
        public PhanLoai()
        {
            SanPham = new HashSet<SanPham>();
        }

        public int PhanLoaiId { get; set; }
        public string Loai { get; set; }
        public string MoTa { get; set; }

        public virtual ICollection<SanPham> SanPham { get; set; }
    }
}
