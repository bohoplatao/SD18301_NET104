using AppData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepository
{
    public interface GioHangCTIRepository
    {
        public ICollection<GioHangCT> GetAll();

        public bool Add(GioHangCT ghct);
        public bool Update(GioHangCT ghct);
        public bool Delete(GioHangCT ghct);
    }
}
