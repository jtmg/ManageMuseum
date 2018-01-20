using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageMuseum.Models
{
    public class EventViewModel
    {
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EnDate { get; set; }

        
        public int RoomId { get; set; }
        public int SpaceId { get; set; }
        public string EventType { get; set; }
        public string Description { get; set; }

    }
}