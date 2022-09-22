using RnR1.Models;
using System.Collections.Generic;

namespace RnR1
{
    public interface IPersonRepository
    {
        public IEnumerable<Person> GetAllPerson();
        public Person GetPerson(int id);
    }
}
