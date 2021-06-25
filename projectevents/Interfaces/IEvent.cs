using projectevents.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projectevents.Interfaces
{
    public interface IEvent
    {
        IEnumerable<Event> GetAllEvents();
    }
}
