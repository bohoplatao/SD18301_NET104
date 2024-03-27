using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepository
{
    public interface SanPhamIRepository
    {
        public ICollection<SanPham> GetAll();

        public bool Add(SanPham sp);
        public bool Update(SanPham sp);
        public bool Delete(SanPham sp);
    }
}
