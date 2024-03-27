using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Models
{
    public class UserRole
    {
        public Guid ID { get; set; }
        public Guid ID_Role { get; set; }
        public Guid ID_Users { get; set; }

        public virtual Role Role { get; set; }
        public virtual Users Users { get; set; }
    }
}
