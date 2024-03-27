using AppData.IRepository;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repository
{
    public class GioHangRepository : GioHangIRepository
    {
        SD18301_NET104Context _context;
        public GioHangRepository()
        {
               _context = new SD18301_NET104Context();
        }
        public bool Add(GIoHang gh)
        {
            try
            {
                _context.Add(gh);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(GIoHang gh)
        {
            try
            {
                var giohang = _context.gIoHangs.Find(gh.Id);
                _context.Remove(gh);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ICollection<GIoHang> GetAll()
        {
            return _context.gIoHangs.ToList();
        }

        public bool Update(GIoHang gh)
        {
            try
            {
                var ghUpdate = _context.gIoHangs.Find(gh.Id);
                ghUpdate.ID_Users = gh.ID_Users;
        
                _context.Update(ghUpdate);
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
