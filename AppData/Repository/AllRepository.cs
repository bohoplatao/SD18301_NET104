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
    public class AllRepository<T> : iAllRepository<T> where T : class
    {
        // khai báo DBContext
        SD18301_NET104Context _context;
        // TẠo ra 1 DbSet riêng, khi nào cần dùng chính thức thì mình lại gán 
        DbSet<T> _dbSet;
        public AllRepository() // Không tham số 
        {
                _context = new SD18301_NET104Context();

        }
        public AllRepository(SD18301_NET104Context context , DbSet<T> dbSet) // có tham số
        {
                    _context = context;
                    _dbSet = dbSet;
        }
        // thay vì trỏ trực tiếp đến 1 DBSet để thực hiện CRUD thì chúng ta tạo ra 1 DBSet
        // đế viết các phương thức sau đó khi chúng ta cần dùng Repos thì chúng ta sẽ
        // gán DBSet cần dùng vào Contructor
        public bool CreateObj(T obj)
        {
            try
            {
                _dbSet.Add(obj);
                _context.SaveChanges();
                
                return true;
            }catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteObj(T obj)
        {
            try
            {
                _dbSet.Remove(obj);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public ICollection<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetByID(dynamic id)
        {
            return _dbSet.Find(id); // phương thức Find mà truyền trực tiếp tham số chỉ dùng với PK
        }

        public bool UpdateObj(T obj)
        {
            try
            {
                _dbSet.Update(obj);
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
