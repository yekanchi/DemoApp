using System;
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
            user.Guid = Guid.NewGuid();
            db.Users.Add(user);
            var result = db.SaveChanges();

            return result;
        }

        public User GetById(long id) 
        {
            using var db = new SqLiteDbContext();
            var user = db.Users.SingleOrDefault(u=> u.Id == id);
            return user;
        }
        
        public List<User> GetAll()
        {
            using var db = new SqLiteDbContext();
            var users = db.Users.ToList();
            return users;
        }

        public bool Remove(User user)
        {
            using var db = new SqLiteDbContext();
            db.Users.Attach(user);
            db.Users.Remove(user);
            return db.SaveChanges() > 0;
        }

        public bool Update(User user)
        {
            using var db = new SqLiteDbContext();
            var userToUpdate = db.Users.FirstOrDefault(u => u.Id == user.Id);
            userToUpdate = user;
            return db.SaveChanges() > 0;
        }
    }
}
