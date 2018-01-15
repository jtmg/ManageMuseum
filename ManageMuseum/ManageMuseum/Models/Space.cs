using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ManageMuseum.Models
{
    public class Space
    {
        [Key]
        public int Id { get; set; }
        public double Area { get; set; }
        public string Local { get; set; }
        public virtual ICollection<Event> Events { get; set; }

    }
}