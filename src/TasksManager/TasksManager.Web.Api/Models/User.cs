using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TasksManager.Web.Api.Models
{
    class User
    {
        public Guid UserId { get; set; }
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public List<Link> Links { get; set; }
    }
}
