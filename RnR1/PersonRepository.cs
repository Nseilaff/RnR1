using Dapper;
using RnR1.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace RnR1
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IDbConnection _conn;
        public PersonRepository(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Person> GetAllPerson()
        {
            return _conn.Query<Person>("SELECT * FROM person");
        }
        public Person GetPerson(int id)
        {
            return (Person)_conn.QuerySingle<Person>("SELECT * FROM person WHERE PersonID = @id;", new { id = id });
        }


        public void UpdatePerson(Person person)
        {
            _conn.Execute("UPDATE person SET PersonID = @PersonID FName = @FName, LName = @LName, Email = @Email, PhoneNum = @PhoneNum ",
                new { PersonID = person.PersonID, FName = person.FName, LName = person.LName, Email = person.Email, PhoneNum = person.PhoneNum });

        }
        public void InsertPerson(Person personToInsert)
        {
            _conn.Execute("INSERT INTO person (FName, LName, PhoneNum, Email, ReserveDate, Time) VALUES (@FName, @LName, @PhoneNum, @Email, @ReserveDate, @Time);",
                new
                {
                    FName = personToInsert.FName,
                    LName = personToInsert.LName,
                    PhoneNum = personToInsert.PhoneNum,
                    Email = personToInsert.Email,
                    ReserveDate = personToInsert.ReserveDate,
                    Time = personToInsert.Time
                }); 
        }

        public void DeletePerson(Person person)
        {
            _conn.Execute("DELETE FROM person Where PersonID = @id", new { id = person.PersonID });
            
        }

        public Person GetTimeSlots(Person person)
        {
            var slots = _conn.Query<TimeSlot>("SELECT Time FROM person Where ReserveDate like @reserveDate;",
                 new { reserveDate = person.ReserveDate }).ToList();
            person.TimeSlots = person.TimeSlots.Where(item => !slots.Any(item2 => item2.Time == item)).ToList<string>();
            return person;
        }
    }
}
