using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class SanPhamCT
    {
        public Guid ID { get; set; }
        public Guid ID_SP { get; set; }
        public decimal Size { get; set; }
        public string HangSP { get; set; }
        public string ChatLieu { get; set; }
        public decimal SoLuong_SPCT { get; set; }
        public decimal Gia_SPCT { get; set; }
        public decimal Gia_NiemYet { get; set; }
        
        public byte TrangThai { get; set; }

        public virtual ICollection<HoaDonCT> HoaDonCTs {get; set;} 
        public virtual ICollection<GioHangCT> GioHangCTs { get; set; }
        public virtual SanPham  SanPham { get; set; }
    }
}
