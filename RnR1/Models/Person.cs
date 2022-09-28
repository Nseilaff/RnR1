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
        public int NumOfPeople { get; set; }
        public string ReserveDate { get; set; }

        public List<string> Date { get; set; } = new List<string> {"10/1", "10/2", "10/3", "10/4", "10/5", "10/6", "10/7", "10/8", "10/9", "10/10", "10/11", "10/12", "10/13", "10/14", "10/15", "10/16", "10/17", "10/18", "10/19", "10/20"};
        public string Time { get; set; }

        public List<string> TimeSlots { get; set; } = new List<string>{"8:00 am", "9:00 am", "10:00 am", "11:00 am", "1:00 pm", "2:00 pm", "3:00 pm", "4:00 pm", "5:00 pm" };

        //public string DateParse()
        //{
        //    return ReserveDate.ToString().Substring(0, 10);
        //}
       
    }
}

