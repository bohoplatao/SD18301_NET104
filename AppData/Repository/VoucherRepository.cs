using AppData.IRepository;
using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.Repository
{
    public class VoucherRepository : VoucherIRepository
    {
        SD18301_NET104Context _context;
        public VoucherRepository()
        {
                _context = new SD18301_NET104Context();
        }
        public bool Add(Voucher voucher)
        {
            try
            {
                _context.Add(voucher);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(Voucher voucher)
        {
            try
            {
                var Voucher = _context.vouchers.Find(voucher.Id);
                _context.Remove(voucher);
                _context.SaveChanges();
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ICollection<Voucher> GetAll()
        {
            return _context.vouchers.ToList();
        }

        public bool Update(Voucher voucher)
        {
            try
            {
                var voucherUpdate = _context.vouchers.Find(voucher.Id);
                voucherUpdate.Code = voucher.Code;
                voucherUpdate.GiaTriVoucher = voucher.GiaTriVoucher;
                voucherUpdate.TrangThai = voucher.TrangThai;
                voucherUpdate.NgayHetHan = voucher.NgayHetHan;
                
                _context.Update(voucherUpdate);
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
