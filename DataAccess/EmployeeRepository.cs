using System;
using System.Collections.Generic;
using System.Linq;
using Bidar.WebAPI.Domain;
using TalebiAPI.Domain;

namespace Bidar.WebAPI.DataAccess
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
            var user = db.Users.SingleOrDefault(u => u.Id == id);
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
            if (userToUpdate is not null)
            {
                userToUpdate.FirstName = user.FirstName;
                userToUpdate.LastName = user.LastName;
                userToUpdate.Age = user.Age;
                userToUpdate.BirthTime = user.BirthTime;
                return db.SaveChanges() > 0;
            }

            return false;

        }
    }
}
