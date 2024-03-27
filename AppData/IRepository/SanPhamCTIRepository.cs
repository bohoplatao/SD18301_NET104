using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepository
{
    public interface SanPhamCTIRepository
    {
        public ICollection<SanPhamCT> GetAll();

        public bool Add(SanPhamCT spct);
        public bool Update(SanPhamCT spct);
        public bool Delete(SanPhamCT spct);
    }
}
