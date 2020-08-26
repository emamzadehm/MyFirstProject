using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PW_MVC.Models
{
    public class Projects
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Client { get; set; }
        public string Img { get; set; }
    }
}
