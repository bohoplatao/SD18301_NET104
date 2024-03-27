using AppData.Repository;
using AppData.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppMVC.Controllers
{
    public class UserController : Controller
    {
        AllRepository <Users> repo;
        SD18301_NET104Context context;
        public UserController()
        {// khởi tạo DBContext 
            context = new SD18301_NET104Context();
            // khởi taoh 1 repo với 2 tham số bao gồm : contexxt và DBSet<Users> để khi dùng thì
            // DBSet đc trỏ đến có thể thao tác trên bảng Users
            repo = new AllRepository<Users>(context, context.Users);
        }
        //1. Lấy ra data
        public IActionResult Index()
        {
            var data = repo.GetAll(); // lấy tất cả danh sách của Users
            return View(data);
        }
        //3. Tạo mới 
        public IActionResult Create()
        {
            return View(); // action này để mở form, trả về view Create để điền thông tin 
        }
        [HttpPost]
        public IActionResult CreateUser(Users users) // action này để xử lí data để thêm vào DB
        {
            bool isUsernameExists = repo.GetAll().Any(u => u.UserName == users.UserName);
            if (isUsernameExists)
            {
                TempData["Check"] = "Username đã tồn tại. Vui lòng chọn username khác.";
                return RedirectToAction("Index");
            }
            else
            {
                users.ID = Guid.NewGuid();
                repo.CreateObj(users);
                TempData["Success"] = "Thêm thành công";
                return RedirectToAction("Index");
            }

            //users.ID = Guid.NewGuid();
            //repo.CreateObj(users);
            //TempData["Success"] = "Thêm thành công";
            //return RedirectToAction("Index");
        }

        public IActionResult Update(Guid id)
        {
            var user = repo.GetByID(id);
            return View(user); // action này để mở form, trả về view Create để điền thông tin 
        }
        [HttpPost]
        public IActionResult UpDate(Users users) // action này để xử lí data để thêm vào DB
        {
            
            repo.UpdateObj(users);
            TempData["Success"] = "Sửa thành công";
            return RedirectToAction("Index");
        }

        public IActionResult Delete(Guid id) // action này để xử lí data để thêm vào DB
        {
            var user = repo.GetByID(id);
            repo.DeleteObj(user);
            TempData["Success"] = "Xóa thành công";
            return RedirectToAction("Index");
        }


        public IActionResult Detail(Guid id)
        {
            var user = repo.GetByID(id);
            return View(user);  
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login( string username, string password)
        {
            // Lấy ra User có thông tin trùng với user name và passwword được nhập vào 
            var user = repo.GetAll().FirstOrDefault( p=>p.UserName == username && p.Password == password);
            if(user != null)
            {
                TempData["Username"] = username;
                return RedirectToAction("Index","User"); //("Index","Home")
            }
            else
            {
                TempData["Error"] = "Đăng nhập thất bại. Vui lòng kiểm tra lại username và password.";
                return Content(" Dang nhap that bai");
            }
        }

     


    }
}
