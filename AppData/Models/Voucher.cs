using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Voucher
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string GiaTriVoucher {  get; set; }
        public int TrangThai { get; set; }
        public DateTime NgayHetHan  { get; set; } 
        public virtual ICollection<HoaDonCT> HoaDonCTs { get; set; }
    }
}
