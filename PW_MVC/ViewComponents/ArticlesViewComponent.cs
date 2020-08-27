using Microsoft.AspNetCore.Mvc;
using PW_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PW_MVC.ViewComponents
{
    public class ArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Articles>
            {
                new Articles(1,"Machine Learning", "This is description about Machine Learning", "1.jpg"),
                new Articles(2,"Numerical Methods", "This is description about Numerical Methods", "2.jpg"),
                new Articles(3,"Numerical Analysis", "This is description about Numerical Analysis", "3.jpg"),
                new Articles(4,"Boundary Value Equations", "This is description about Boundary Value Equations", "4.jpg")
            };
            return View ("_Articles",articles);
        }
    }
}
