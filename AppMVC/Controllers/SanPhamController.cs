using AppData.Models;
using AppData.Repository;
using Microsoft.AspNetCore.Mvc;

namespace AppMVC.Controllers
{
    public class SanPhamController : Controller
    {
        AllRepository<SanPham> repo;
        SD18301_NET104Context context;
        public SanPhamController()
        {
                context = new SD18301_NET104Context();

                repo = new AllRepository<SanPham>(context, context.sanPhams);
        }
        public IActionResult Index()
        {
            var data = repo.GetAll();
            return View(data);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(SanPham obj, IFormFile imageFile)
        {
            
            if (imageFile != null && imageFile.Length > 0)
            {
                var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "IMG");
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                var imagePath = Path.Combine(directoryPath, imageFile.FileName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imageFile.CopyTo(stream);
                }

                obj.Anh_SP = "/IMG/"+ imageFile.FileName;
            }
            obj.Id = Guid.NewGuid();
            repo.CreateObj(obj);
            TempData["Success"] = "Thêm thành công";
            return RedirectToAction("Index");

        }
        public IActionResult Update(Guid id)
        {
            var obj = repo.GetByID(id);
            return View(obj); // action này để mở form, trả về view Create để điền thông tin 
        }
        [HttpPost]
        public IActionResult Update(SanPham obj, IFormFile imageFile) // action này để xử lí data để thêm vào DB
        {
            if (imageFile != null && imageFile.Length > 0)
            {
                var directoryPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "IMG");
                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                var imagePath = Path.Combine(directoryPath, imageFile.FileName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imageFile.CopyTo(stream);
                }

                obj.Anh_SP = "/IMG/" + imageFile.FileName;
            }
            
            repo.UpdateObj(obj);
            TempData["Success"] = "Sửa thành công";
            return RedirectToAction("Index");
           
        }

        public IActionResult Detail(Guid id)
        {
            var obj = repo.GetByID(id);
            return View(obj);
        }
        public IActionResult Delete(Guid id) // action này để xử lí data để thêm vào DB
        {
            var obj = repo.GetByID(id);
            repo.DeleteObj(obj);
            TempData["Success"] = "Xóa thành công";
            return RedirectToAction("Index");
        }

    }
}
