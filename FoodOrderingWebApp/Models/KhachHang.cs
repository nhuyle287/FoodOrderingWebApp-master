using System;
using System.Collections.Generic;

namespace FoodOrderingWebApp.Models
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            BinhLuan = new HashSet<BinhLuan>();
            HoaDon = new HashSet<HoaDon>();
        }

        public int KhachHangId { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public int TaiKhoanId { get; set; }
        public int LoaiKhachHangId { get; set; }

        public virtual LoaiKhachHang LoaiKhachHang { get; set; }
        public virtual TaiKhoan TaiKhoan { get; set; }
        public virtual ICollection<BinhLuan> BinhLuan { get; set; }
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
