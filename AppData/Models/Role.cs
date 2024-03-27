using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class Role
    {
        public Guid Id { get; set; }
        public string TenRole { get; set; }
        public virtual ICollection<UserRole> UserRoles { get; set; }
    }
}
