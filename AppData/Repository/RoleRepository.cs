using AppData.IRepository;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repository
{
    internal class RoleRepository : RoleIRepository
    {
        SD18301_NET104Context _context;
        public RoleRepository()
        {
                _context = new SD18301_NET104Context();
        }
        public bool Add(Role role)
        {
            try
            {
                _context.Add(role);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Role role)
        {
            try
            {
                var roles = _context.roles.Find(role.Id);
                _context.Remove(role);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ICollection<Role> GetAll()
        {
            return _context.roles.ToList();
        }

        public bool Update(Role role)
        {
            try
            {
                var roleUpdate = _context.roles.Find(role.Id);
                roleUpdate.TenRole = role.TenRole;
              
                _context.Update(roleUpdate);
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
