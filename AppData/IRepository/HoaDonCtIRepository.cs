using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepository
{
    public interface HoaDonCtIRepository
    {
        public ICollection<HoaDonCT> GetAll();

        public bool Add(HoaDonCT hdct);
        public bool Update(HoaDonCT hdct);
        public bool Delete(HoaDonCT hdct);
    }
}
