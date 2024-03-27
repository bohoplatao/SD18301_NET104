using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepository
{
    public interface UserAddressIRepository
    {
        public ICollection<UserAddress> GetAll();

        public bool Add(UserAddress userAddress);
        public bool Update(UserAddress userAddress);
        public bool Delete(UserAddress userAddress);
    }
}
