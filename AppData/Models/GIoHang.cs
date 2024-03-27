using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class GIoHang
    {
        public Guid Id { get; set; }
        public Guid ID_Users { get; set; }
        public virtual ICollection<GioHangCT>  GioHangCTs { get; set; }
        //public virtual ICollection<Users> Users { get; set; }
        public virtual Users Users { get; set; }
    }
}
