using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasksManager.Web.Api.Models
{
    public class Category
    {
        public long CategoryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Link> Links { get; set; }
    }
}