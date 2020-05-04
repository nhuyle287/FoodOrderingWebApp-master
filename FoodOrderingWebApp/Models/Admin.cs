using System;
using System.Collections.Generic;

namespace FoodOrderingWebApp.Models
{
    public partial class Admin
    {
        public int Adminid { get; set; }
        public string Ho { get; set; }
        public string Ten { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string Email { get; set; }
        public string Sdt { get; set; }
        public string DiaChi { get; set; }
        public int TaiKhoanId { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }
    }
}
