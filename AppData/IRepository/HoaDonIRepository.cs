using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepository
{
    public interface HoaDonIRepository
    {
        public ICollection<HoaDon> GetAll();

        public bool Add(HoaDon hd);
        public bool Update(HoaDon hd);
        public bool Delete(HoaDon hd);
    }
}
