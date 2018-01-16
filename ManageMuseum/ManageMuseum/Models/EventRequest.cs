using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManageMuseum.Models
{
    public class EventRequest
    {
        [Key]
        public int Id { get; set; }
        public UserAccount UserAccount { get; set; }
        public Event Event { get; set; }

    }
}