using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class GioHangCT
    {
        public Guid Id { get; set; }
        public Guid ID_SPCT { get; set; }
        public Guid ID_GioHang { get; set; }
        public decimal SoLuong_GHCT { get; set; }
        public int TrangThai {  get; set; }

        public virtual SanPhamCT  SanPhamCT {  get; set; }
        public virtual GIoHang GIoHang { get; set; }
    }
}
