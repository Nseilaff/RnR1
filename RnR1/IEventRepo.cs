using RnR1.Models;
using System.Collections;
using System.Collections.Generic;

namespace RnR1
{
    public interface IEventRepo
    {
        public IEnumerable<Event> GetAllEvents();
    }
}
