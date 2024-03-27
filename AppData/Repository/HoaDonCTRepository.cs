using AppData.IRepository;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repository
{
    public class HoaDonCTRepository : HoaDonCtIRepository
    {
        SD18301_NET104Context _context;
        public HoaDonCTRepository()
        {
                _context = new SD18301_NET104Context();
        }
        public bool Add(HoaDonCT hdct)
        {
            try
            {
                _context.Add(hdct);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(HoaDonCT hdct)
        {
            try
            {
                var HdCT = _context.hoaDonCTs.Find(hdct.ID);
                _context.Remove(hdct);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ICollection<HoaDonCT> GetAll()
        {
            return _context.hoaDonCTs.ToList();
        }

        public bool Update(HoaDonCT hdct)
        {
            try
            {
                var hdctUpdate = _context.hoaDonCTs.Find(hdct.ID);
                hdctUpdate.ID_HD = hdct.ID_HD;
                hdctUpdate.ID_SPCT = hdct.ID_SPCT;
                hdctUpdate.SoLuong_HDCT = hdct.SoLuong_HDCT;
                hdctUpdate.Gia_HDCT = hdct.Gia_HDCT;
                hdctUpdate.TongTien = hdct.TongTien;
                hdctUpdate.ID_Voucher = hdct.ID_Voucher;
                _context.Update(hdctUpdate);
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
