using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class HoaDon
    {
        public Guid ID { get; set; }   
        public Guid ID_Users { get; set; }
        public decimal TongTien_HD {  get; set; }

        public DateTime Ngaytao {   get; set; } 

        public DateTime NgayUpdate { get; set; }
        public int TrangThai { get; set; }
        public virtual ICollection<HoaDonCT>   HoaDonCTs {   get; set;  }
        public virtual Users   Users { get; set; }

        
        
    }
}
