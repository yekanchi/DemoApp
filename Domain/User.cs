using System;
using System.Collections.Generic;


namespace TalebiAPI.Domain
{
    public class User
    {
        public Guid Guid { get; set; }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthTime { get; set; }
        public int Age { get; set; }
    }
}
