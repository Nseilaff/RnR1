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
            return _conn.Query<Person>("Select * from Person");
        }
        public Person GetPerson(int id)
        {
            return _conn.QuerySingle<Person>("SELECT * From Person where IdPerson = @id, new {id = id}");
        }

    }
}
