using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManageMuseum.Models
{
    public class Event
    {
        [Key]
        public int Id { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EnDate { get; set; }
        public string Name { get; set; }
        public  string EventType { get; set; }
    }
}