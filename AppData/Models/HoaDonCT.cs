using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class HoaDonCT
    {
        public Guid ID { get; set; }
        public Guid ID_HD { get; set; }
        public Guid ID_SPCT { get; set; }

        public string SoLuong_HDCT { get; set; }
        public decimal Gia_HDCT {  get; set; }
        public decimal TongTien { get; set; }

        public Guid ID_Voucher { get; set; }

        public virtual HoaDon HoaDon { get; set; }
        public virtual SanPhamCT SanPhamCT { get; set; }
        public virtual Voucher Voucher { get; set; }
    }
}
