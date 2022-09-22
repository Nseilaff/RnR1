using System;

namespace RnR1.Models
{
    public class Event
    {
        public Event()
        {
        }
        public int EventID { get; set; }
        public DateTime ReservedDate { get; set; }
        public int NumOfPeople { get; set; }
        public int PersonID { get; set; }
    }
}

