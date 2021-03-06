﻿using System;
using System.Collections.Generic;

namespace FoodOrderingWebApp.Models
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            HoaDon = new HashSet<HoaDon>();
        }

        public int NhanVienId { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public int TaiKhoanId { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
        public virtual ICollection<HoaDon> HoaDon { get; set; }
    }
}
