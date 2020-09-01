using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using PW_MVC.Models;

namespace PW_MVC.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index()
        {
            return View(); 
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact();
            return View(model);
        }
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            //return Json(form.Name);
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات ثبت نگردید. لطفاً مجدداً تلاش نمائید.";
                return View(model);
            }
            ViewBag.success = "اطلاعات با موفقیت ثبت گردید. با تشکر.";
            ModelState.Clear();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
