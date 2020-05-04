using System;
using System.Collections.Generic;

namespace FoodOrderingWebApp.Models
{
    public partial class HoaDon
    {
        public HoaDon()
        {
            ChiTietHoaDon = new HashSet<ChiTietHoaDon>();
        }

        public int HoaDonId { get; set; }
        public DateTime? NgayTao { get; set; }
        public string PhuongThucThanhToan { get; set; }
        public DateTime? NgayGiao { get; set; }
        public string SoNha { get; set; }
        public string Quan { get; set; }
        public int PhiShipId { get; set; }
        public float? TongTienThanhToan { get; set; }
        public string TinNhan { get; set; }
        public string TrangThai { get; set; }
        public int NhanVienId { get; set; }
        public int? KhachHangId { get; set; }

        public virtual KhachHang KhachHang { get; set; }
        public virtual NhanVien NhanVien { get; set; }
        public virtual PhiShip PhiShip { get; set; }
        public virtual ICollection<ChiTietHoaDon> ChiTietHoaDon { get; set; }
    }
}
