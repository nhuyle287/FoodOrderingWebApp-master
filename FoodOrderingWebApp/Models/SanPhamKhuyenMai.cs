using System;
using System.Collections.Generic;

namespace FoodOrderingWebApp.Models
{
    public partial class SanPhamKhuyenMai
    {
        public int SanPhamId { get; set; }
        public int KhuyenMaiId { get; set; }
        public float? PhanTramGiam { get; set; }

        public virtual KhuyenMai KhuyenMai { get; set; }
        public virtual SanPham SanPham { get; set; }
    }
}
