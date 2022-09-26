using RnR1.Models;
using System.Collections.Generic;

namespace RnR1
{
    public interface IPersonRepository
    {
        public IEnumerable<Person> GetAllPerson();
        public Person GetPerson(int id);
        public void UpdatePerson(Person person);
        public void InsertPerson(Person personToInsert);
        public void DeletePerson(Person person);
        public Person GetTimeSlots(Person person);
        
    }
}
