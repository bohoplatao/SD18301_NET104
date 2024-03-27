using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepository
{
    public interface UserIRepository
    {
        public ICollection<Users> GetAll();

        public bool Add(Users users);
        public bool Update(Users users);
        public bool Delete(Users users);
    }
}
