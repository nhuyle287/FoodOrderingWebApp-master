using System;
using System.Collections.Generic;

namespace FoodOrderingWebApp.Models
{
    public partial class HinhAnh
    {
        public int HinhAnhId { get; set; }
        public string TenFile { get; set; }
        public int? SanPhamId { get; set; }

        public virtual SanPham SanPham { get; set; }
    }
}
