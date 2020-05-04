using System;
using System.Collections.Generic;

namespace FoodOrderingWebApp.Models
{
    public partial class Reply
    {
        public int ReplyId { get; set; }
        public int? NoiDung { get; set; }
        public DateTime? ThoiGian { get; set; }
        public int BinhLuanId { get; set; }

        public virtual BinhLuan BinhLuan { get; set; }
    }
}
