using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class UserAddress
    {
        public Guid ID { get; set; }
        public Guid ID_User { get; set; }
        public string DiaChi { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayUpdate { get; set; }
        public int TrangThai { get; set; }   
        public virtual Users User { get; set; }
    }
}
