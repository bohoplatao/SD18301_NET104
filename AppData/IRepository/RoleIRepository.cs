using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepository
{
    public interface RoleIRepository
    {
        public ICollection<Role> GetAll();

        public bool Add(Role role);
        public bool Update(Role role);
        public bool Delete(Role role);


    }
}
