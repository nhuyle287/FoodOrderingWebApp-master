using System;
using System.Collections.Generic;

namespace FoodOrderingWebApp.Models
{
    public partial class KhuyenMai
    {
        public KhuyenMai()
        {
            LoaiKhachHangKhuyenMai = new HashSet<LoaiKhachHangKhuyenMai>();
            SanPhamKhuyenMai = new HashSet<SanPhamKhuyenMai>();
        }

        public int KhuyenMaiId { get; set; }
        public string TenKhuyenMai { get; set; }
        public string Hinhanh { get; set; }
        public string MoTa { get; set; }
        public DateTime? NgayBatDau { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public int? TrangThai { get; set; }

        public virtual ICollection<LoaiKhachHangKhuyenMai> LoaiKhachHangKhuyenMai { get; set; }
        public virtual ICollection<SanPhamKhuyenMai> SanPhamKhuyenMai { get; set; }
    }
}
