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
    public class SanPhamRepository : SanPhamIRepository
    {
        SD18301_NET104Context _context;
        public SanPhamRepository()
        {
                _context = new SD18301_NET104Context();
        }
        public bool Add(SanPham sp)
        {
            try
            {
                _context.Add(sp);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(SanPham sp)
        {
            try
            {
                var GioHang = _context.sanPhams.Find(sp.Id);
                _context.Remove(sp);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ICollection<SanPham> GetAll()
        {
            return _context.sanPhams.ToList();
        }

        public bool Update(SanPham sp)
        {
            try
            {
                var spUpdate = _context.sanPhams.Find(sp.Id);
                spUpdate.TenSP = sp.TenSP;
                spUpdate.Mota = sp.Mota;
                spUpdate.Anh_SP = sp.Anh_SP;
                //spUpdate.ID_DanhMuc = sp.ID_DanhMuc;
                spUpdate.NgayCapnhat = sp.NgayCapnhat;
                spUpdate.TrangThai = sp.TrangThai;
                _context.Update(spUpdate);
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
