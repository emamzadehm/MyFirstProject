using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PW_MVC.Models
{
    public class Service
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public Service(int id, string title)
        {
            ID = id;
            Title = title;
        }
    }

}
