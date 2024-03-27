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
    internal class SanPhamCTRepository : SanPhamCTIRepository
    {
        SD18301_NET104Context _context;
        public SanPhamCTRepository()
        {
                _context = new SD18301_NET104Context();
        }
        public bool Add(SanPhamCT spct)
        {
            try
            {
                _context.Add(spct);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(SanPhamCT spct)
        {
            try
            {
                var SPCT = _context.sanPhamCTs.Find(spct.ID);
                _context.Remove(spct);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ICollection<SanPhamCT> GetAll()
        {
            return _context.sanPhamCTs.ToList();
        }

        public bool Update(SanPhamCT spct)
        {
            try
            {
                var spctUpdate = _context.sanPhamCTs.Find(spct.ID);
                spctUpdate.ID_SP = spct.ID_SP;
                spctUpdate.Size = spct.Size;
                spctUpdate.HangSP = spct.HangSP;
                spctUpdate.ChatLieu = spct.ChatLieu;
                spctUpdate.SoLuong_SPCT = spct.SoLuong_SPCT;
                spctUpdate.Gia_NiemYet = spct.Gia_NiemYet;
                spctUpdate.TrangThai = spct.TrangThai;
                _context.Update(spctUpdate);
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
