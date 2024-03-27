using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepository
{
    public interface GioHangIRepository
    {
        public ICollection<GIoHang> GetAll();

        public bool Add(GIoHang gh);
        public bool Update(GIoHang gh);
        public bool Delete(GIoHang gh);
    }
}
