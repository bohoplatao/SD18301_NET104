using AppData.IRepository;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repository
{
    public class GioHangCTRepository : GioHangCTIRepository
    {
        SD18301_NET104Context _context;
        public GioHangCTRepository()
        {
                _context = new SD18301_NET104Context();
        }
        public bool Add(GioHangCT ghct)
        {
            try
            {
                _context.Add(ghct);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(GioHangCT ghct)
        {
            try
            {
                var GioHang = _context.gioHangCTs.Find(ghct.Id);
                _context.Remove(ghct);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        

        public ICollection<GioHangCT> GetAll()
        {
            return _context.gioHangCTs.ToList();
        }

        public bool Update(GioHangCT ghct)
        {
            try
            {
                var ghctUpdate = _context.gioHangCTs.Find(ghct.Id);
                ghctUpdate.ID_SPCT = ghct.ID_SPCT;
                ghctUpdate.ID_GioHang = ghct.ID_GioHang;
                ghctUpdate.SoLuong_GHCT = ghct.SoLuong_GHCT;
                ghctUpdate.TrangThai = ghct.TrangThai;
                _context.Update(ghctUpdate);
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
