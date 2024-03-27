using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppData.IRepository
{
    internal interface iAllRepository<T> where T : class// Generic nhưng giới hạn class 
    {

        // Get- lấy - (Read)
        public ICollection<T> GetAll(); // lấy tất

        public T GetByID( dynamic id); // lấy theo id

        // Create - Tạo mới 
        public bool CreateObj(T obj); // tạo mới đối tượng trong CSDL truyền vào đối tượng 
        // Update - Sửa đối tượng trong DB
        public bool UpdateObj(T obj);
        // Delete - Xóa đối tượng trong DB
        public bool DeleteObj(T obj);

    }
}
