using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class SanPham
    {
        public Guid Id { get; set; }
        public string TenSP { get; set; }
        public string Mota { get; set; }
        public string Anh_SP { get; set; }
        //public Guid ID_DanhMuc { get; set; }
        public DateTime NgayCapnhat { get; set; }
        public int TrangThai { get; set; } 
       // public virtual DanhMuc DanhMuc { get; set;}
        public virtual ICollection<SanPhamCT> SanPhamCTs { get; set; }
    }
}
