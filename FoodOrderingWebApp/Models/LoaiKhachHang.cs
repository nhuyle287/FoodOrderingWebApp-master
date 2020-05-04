using System;
using System.Collections.Generic;

namespace FoodOrderingWebApp.Models
{
    public partial class LoaiKhachHang
    {
        public LoaiKhachHang()
        {
            KhachHang = new HashSet<KhachHang>();
            LoaiKhachHangKhuyenMai = new HashSet<LoaiKhachHangKhuyenMai>();
        }

        public int LoaiKhachHangId { get; set; }
        public string TenLoai { get; set; }
        public float? MucDoanhSo { get; set; }

        public virtual ICollection<KhachHang> KhachHang { get; set; }
        public virtual ICollection<LoaiKhachHangKhuyenMai> LoaiKhachHangKhuyenMai { get; set; }
    }
}
