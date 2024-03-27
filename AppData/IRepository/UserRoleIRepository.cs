using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepository
{
    public interface UserRoleIRepository
    {
        public ICollection<UserRole> GetAll();

        public bool Add(UserRole userRole);
        public bool Update(UserRole userRolej);
        public bool Delete(UserRole userRole);
    }
}
