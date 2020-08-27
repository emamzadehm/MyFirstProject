using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PW_MVC.Models
{
    public class Articles
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Img { get; set; }
        public Articles(int id, string title, string description, string img)
        {
            Id = id;
            Title = title;
            Description = description;
            Img = img;
        }
    }
}
