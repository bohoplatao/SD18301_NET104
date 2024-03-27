using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepository
{
    public interface VoucherIRepository
    {
        public ICollection<Voucher> GetAll();

        public bool Add(Voucher voucher);
        public bool Update(Voucher voucher);
        public bool Delete(Voucher voucher);
    }
}
