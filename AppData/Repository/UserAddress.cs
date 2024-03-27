using AppData.IRepository;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repository
{
    public class UserAddress : UserAddressIRepository
    {
        SD18301_NET104Context _context;
        public UserAddress()
        {
               _context = new SD18301_NET104Context();
        }
        public bool Add(Models.UserAddress userAddress)
        {
            try
            {
                _context.Add(userAddress);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Models.UserAddress userAddress)
        {
            try
            {
                var UserAddress = _context.userAddress.Find(userAddress.ID);
                _context.Remove(userAddress);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ICollection<Models.UserAddress> GetAll()
        {
            return _context.userAddress.ToList();
        }

        public bool Update(Models.UserAddress userAddress)
        {
            try
            {
                var userAddressUpdate = _context.userAddress.Find(userAddress.ID);
                userAddressUpdate.ID_User = userAddress.ID_User;
                userAddressUpdate.DiaChi = userAddress.DiaChi;
                userAddressUpdate.NgayTao = userAddress.NgayTao;
                userAddressUpdate.NgayUpdate = userAddress.NgayUpdate;
                userAddressUpdate.TrangThai = userAddress.TrangThai;
                _context.Update(userAddressUpdate);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
