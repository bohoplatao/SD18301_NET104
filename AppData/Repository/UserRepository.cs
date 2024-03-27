using AppData.IRepository;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repository
{
    public class UserRepository : UserIRepository
    {
        SD18301_NET104Context _context;
        public UserRepository()
        {
                _context    = new SD18301_NET104Context();
        }
        public bool Add(Users users)
        {
            try
            {
                _context.Add(users);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Users users)
        {
            try
            {
                var User = _context.Users.Find(users.ID);
                _context.Remove(users);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ICollection<Users> GetAll()
        {
            return _context.Users.ToList();
        }

        public bool Update(Users users)
        {
            try
            {
                var usersUpdate = _context.Users.Find(users.ID);
                usersUpdate.Name = users.Name;
                usersUpdate.Email = users.Email;
                usersUpdate.Password = users.Password;
                usersUpdate.UserName = users.UserName;
                usersUpdate.SDT = users.SDT;
                usersUpdate.Dob = users.Dob;
                usersUpdate.NgayTao = users.NgayTao;
                usersUpdate.NgayUpdate = users.NgayUpdate;
                usersUpdate.TrangThai = users.TrangThai;
                _context.Update(usersUpdate);
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
