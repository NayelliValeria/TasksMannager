using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasksManager.Web.Api.Models
{
    public class Status
    {
        public long StatusId { get; set; }
        public string Name { get; set; }
        public int Ordinal { get; set; }
        public List<Link> Links { get; set; }
    }
}