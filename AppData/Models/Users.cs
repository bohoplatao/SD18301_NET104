using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Users
    {   
        public Guid ID { get; set; }    
        public string Name { get; set; }
        public string? Email { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string SDT { get; set; }
        public DateTime Dob { get; set; } // ngày sinh 
        public DateTime NgayTao { get; set; }
        public DateTime NgayUpdate { get; set; }
        public int TrangThai { get; set; }

        //public virtual ICollection<GIoHang>GIoHangs { get; set; }
        public virtual ICollection<UserRole>UserRoles { get; set; }
        public virtual ICollection<UserAddress> UserAddresses { get; set; }
        public virtual ICollection<HoaDon>  HoaDons { get; set; }
        public virtual GIoHang GIoHang { get; set; }
      
    }
}
