using Dapper;
using RnR1.Models;
using System.Collections.Generic;
using System.Data;

namespace RnR1
{
    public class EventRepo : IEventRepo
    {
        private readonly IDbConnection _conn;
        public EventRepo(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Event> GetAllEvents()
        {
            return _conn.Query<Event>("SELECT * FROM event");
        }
    }
}
