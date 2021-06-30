using System;
using System.Collections.Generic;
using System.Linq;
using Bidar.WebAPI.Domain;

namespace Bidar.WebAPI.DataAccess
{
    public class EmployeeRepository
    {
        public DemoDbContext DbContext { get; set; }

        public EmployeeRepository()
        {
            DbContext = new MysqlDbContext();
        }

        public int CreateUser(User user)
        {
            user.Guid = Guid.NewGuid();
            DbContext.Users.Add(user);
            var result = DbContext.SaveChanges();
            return result;
        }

        public User GetById(long id)
        {
            var user = DbContext.Users.SingleOrDefault(u => u.Id == id);
            return user;
        }

        public List<User> GetAll()
        {
            var users = DbContext.Users.ToList();
            return users;
        }

        public bool Remove(User user)
        {
            DbContext.Users.Attach(user);
            DbContext.Users.Remove(user);
            return DbContext.SaveChanges() > 0;
        }

        public bool Update(User user)
        {
            var userToUpdate = DbContext.Users.FirstOrDefault(u => u.Id == user.Id);
            if (userToUpdate is not null)
            {
                userToUpdate.FirstName = user.FirstName;
                userToUpdate.LastName = user.LastName;
                userToUpdate.Age = user.Age;
                userToUpdate.BirthTime = user.BirthTime;
                return DbContext.SaveChanges() > 0;
            }

            return false;
        }
    }
}