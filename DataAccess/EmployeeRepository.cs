using System.Collections.Generic;
using System.Linq;
using TalebiAPI.Domain;

namespace TalebiAPI.DataAccess
{
    public class EmployeeRepository
    {
        public int CreateUser(User user)
        {
            using var db = new SqLiteDbContext();
            db.Users.Add(user);
            var result = db.SaveChanges();

            return result;
        }

        public List<User> GetAll()
        {
            using var db = new SqLiteDbContext();
            var users = db.Users.ToList();
            return users;
        }
    }
}
