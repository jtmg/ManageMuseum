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
        public  EventType IdEventType { get; set; }

        public ICollection<EventRequest> EventRequests { get; set; }
        public ICollection<RoomMuseum> RoomMuseums { get; set; }
        public ICollection<OutSideSpace> OutSideSpaces { get; set; }

    }
}