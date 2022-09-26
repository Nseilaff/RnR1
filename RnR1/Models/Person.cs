using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace RnR1.Models
{
    public class Person
    {
        public Person()
        {
        }
        public int PersonID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string Email { get; set; }
        public int PhoneNum { get; set; }
        public DateTime ReserveDate { get; set; }
        public string Time { get; set; }

        public List<string> TimeSlots { get; set; } = new List<string>{ "1:00 pm", "2:00 pm", "3:00 pm", "4:00 pm", "5:00 pm" };

        public string DateParse()
        {
            return ReserveDate.ToString().Substring(0, 10);
        }
       
    }
}

