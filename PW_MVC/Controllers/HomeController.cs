using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.Operations;
using PW_MVC.Models;

namespace PW_MVC.Controllers
{
    public class HomeController : Controller
    {

        private readonly List<Service> services= new List<Service>
            {
            new Service(1,"طلایی"),
            new Service(2,"نقره ای"),
            new Service(3,"پلاتین"),
            new Service(4,"الماس")
    };
        public IActionResult Index()
        {
            return View(); 
        }
        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact()
            {
                Services = new SelectList(services, "ID", "Title")
            };
            return View(model);
        }
        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            model.Services = new SelectList(services, "ID", "Title");
            //return Json(form.Name);
            if (!ModelState.IsValid)
            {
                ViewBag.error = "اطلاعات ثبت نگردید. لطفاً مجدداً تلاش نمائید.";
                return View(model);
            }
                
            ViewBag.success = "اطلاعات با موفقیت ثبت گردید. با تشکر.";
            ModelState.Clear();
            model = new Contact
            {
                Services = new SelectList(services, "ID", "Title")
            };
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
