using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageMuseum.Models
{   //isto não é o raio do decorator?
    public class IUser
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}