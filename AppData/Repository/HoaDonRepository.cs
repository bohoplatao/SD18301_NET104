using AppData.IRepository;
using AppData.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repository
{
    public class HoaDonRepository : HoaDonIRepository
    {
        SD18301_NET104Context _context;
        public HoaDonRepository()
        {
                _context    = new SD18301_NET104Context();
        }
        public bool Add(HoaDon hd)
        {
            try
            {
                _context.Add(hd);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(HoaDon hd)
        {
            try
            {
                var HD = _context.gioHangCTs.Find(hd.ID);
                _context.Remove(hd);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ICollection<HoaDon> GetAll()
        {
            return _context.hoaDons.ToList();
        }

        public bool Update(HoaDon hd)
        {
            try
            {
                var hdUpdate = _context.hoaDons.Find(hd.ID);
                hdUpdate.ID_Users = hd.ID_Users;
                hdUpdate.TongTien_HD = hd.TongTien_HD;
                hdUpdate.NgayUpdate = hd.NgayUpdate;
                hdUpdate.Ngaytao = hd.Ngaytao;
                hdUpdate.TrangThai = hd.TrangThai;
                _context.Update(hdUpdate);
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
