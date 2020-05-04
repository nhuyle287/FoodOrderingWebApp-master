using System;
using System.Collections.Generic;

namespace FoodOrderingWebApp.Models
{
    public partial class SanPham
    {
        public SanPham()
        {
            BinhLuan = new HashSet<BinhLuan>();
            ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
            HinhAnh = new HashSet<HinhAnh>();
            SanPhamKhuyenMai = new HashSet<SanPhamKhuyenMai>();
        }

        public int SanPhamId { get; set; }
        public string TenSanPham { get; set; }
        public float? GiaGoc { get; set; }
        public float? GiaBanLe { get; set; }
        public float? Kho { get; set; }
        public int? TrangThai { get; set; }
        public int PhanLoaiId { get; set; }

        public virtual PhanLoai PhanLoai { get; set; }
        public virtual ICollection<BinhLuan> BinhLuan { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
        public virtual ICollection<HinhAnh> HinhAnh { get; set; }
        public virtual ICollection<SanPhamKhuyenMai> SanPhamKhuyenMai { get; set; }
    }
}
