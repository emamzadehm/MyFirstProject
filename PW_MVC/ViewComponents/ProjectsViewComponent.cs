using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Formatters;
using PW_MVC.Models;
using System.Collections.Generic;

namespace PW_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>
            {
                new Project(1,"First Project","This is my first project description", "Personal Website Company","1.jpg" ),
                new Project(2,"Second Project","This is my second project description", "NAFTA Website Company","2.jpg" ),
                new Project(3,"Third Project","This is my third project description", "PPDM","3.jpg" ),
                new Project(4,"Forth Project","This is my forth project description", "Procurement Company","4.jpg" )
            };
            return View("_Projects", projects);
        }
    }
}
