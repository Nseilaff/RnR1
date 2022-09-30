using System;

namespace RnR1.Models
{
    public class Event
    {
        public Event()
        {
        }
        public int EventID { get; set; }
        public string ReservedDate { get; set; }
        public string Time { get; set; }
        public int NumOfPeople { get; set; }
        public int PersonID { get; set; }
    }
}

