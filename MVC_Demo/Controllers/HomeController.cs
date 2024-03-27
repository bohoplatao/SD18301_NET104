using Microsoft.AspNetCore.Mvc;
using MVC_Demo.Models;
using System.Diagnostics;

namespace MVC_Demo.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult AboutUs()
        {
            return View(); // trỏ đến views cùng  tên với action 
            //return nocontent();
            //return badrequest();
        }

        public IActionResult GotoHome()
        {
            //hành động gì đó trước khi về trang chủ 
            //redirect - điều hướng về action để về trang chủ
            return RedirectToAction("Index");
            //return RedirectToPage("Index");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
