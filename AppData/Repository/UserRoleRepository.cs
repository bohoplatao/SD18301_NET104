using AppData.IRepository;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repository
{
    public class UserRoleRepository : UserRoleIRepository
    {
        SD18301_NET104Context   _context;
        public UserRoleRepository()
        {
                _context    = new SD18301_NET104Context();
        }
        public bool Add(UserRole userRole)
        {
            try
            {
                _context.Add(userRole);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(UserRole userRole)
        {
            try
            {
                var GioHang = _context.gioHangCTs.Find(userRole.ID);
                _context.Remove(userRole);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ICollection<UserRole> GetAll()
        {
            return _context.userRoles.ToList();
        }

        public bool Update(UserRole userRolej)
        {
            try
            {
                var userRolejUpdate = _context.userRoles.Find(userRolej.ID);
                userRolejUpdate.ID_Role = userRolej.ID_Role;
                userRolejUpdate.ID_Users = userRolej.ID_Users;
              
                _context.Update(userRolej);
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
