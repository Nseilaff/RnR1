using Dapper;
using RnR1.Models;
using System.Collections.Generic;
using System.Data;

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
            return (Person)_conn.QuerySingle<Person>("SELECT * FROM person WHERE PersonID = @id;", new {id = id});
        }


        public void UpdatePerson(Person person)
        {
            _conn.Execute("UPDATE person SET PersonID = @PersonID FName = @FName, LName = @LName, Email = @Email, PhoneNum = @PhoneNum " ,
                new {PersonID = person.PersonID, FName = person.FName, LName = person.LName, Email = person.Email, PhoneNum = person.PhoneNum });

        }
        public void InsertPerson(Person personToInsert)
        {
            _conn.Execute("INSERT INTO person (FName, LName, PhoneNum, Email, ReserveDate) VALUES (@FName, @LName, @PhoneNum, @Email, @ReserveDate);",
                new {FName = personToInsert.FName, LName = personToInsert.LName, PhoneNum = personToInsert.PhoneNum, Email = personToInsert.Email,
                    ReserveDate = personToInsert.ReserveDate});
        }

        public void DeletePerson(Person person)
        {
            _conn.Execute("DELETE FROM person Where PersonID = @id", new { id = person.PersonID });
            _conn.Execute("DELETE FROM events Where PersonID = @id", new { id = person.PersonID });
        }
    }
}
