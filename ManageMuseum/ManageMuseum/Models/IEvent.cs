using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;

namespace ManageMuseum.Models
{
    public abstract class IEvent
    {
        public DateTime StratDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }
        public string EventType { get; set; }

        //o decorator era os Iusers?
        public IList<Decorator> DecorateList { get; set; }

        //ligação entre os eventos e os espaços
        public IList<ISpace> Spaces { get; set; }

        public abstract void Attach(IUser user);
        public abstract void Detach(IUser user);
        public abstract void Notify();

    }
}