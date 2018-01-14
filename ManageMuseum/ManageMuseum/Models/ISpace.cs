using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ManageMuseum.Models
{
    public abstract class ISpace
    {
        public double Area { get; set; }
        public string Local { get; set; }

        //relação entre os espaços e os eventos
        public IList<IEvent> Events { get; set; }
    }
}