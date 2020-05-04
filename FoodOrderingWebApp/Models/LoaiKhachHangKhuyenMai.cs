using System;
using System.Collections.Generic;

namespace FoodOrderingWebApp.Models
{
    public partial class LoaiKhachHangKhuyenMai
    {
        public int LoaiKhachHangId { get; set; }
        public int KhuyenMaiId { get; set; }
        public float? PhanTramGiam { get; set; }

        public virtual KhuyenMai KhuyenMai { get; set; }
        public virtual LoaiKhachHang LoaiKhachHang { get; set; }
    }
}
