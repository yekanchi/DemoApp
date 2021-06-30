using System.Collections.Generic;
using Bidar.WebAPI.DataAccess;
using Bidar.WebAPI.Domain;
using TalebiAPI.Domain;

namespace Bidar.WebAPI.Services
{
    public class DataService
    {
        private readonly EmployeeRepository _employeeRepository;

        public DataService()
        {
            _employeeRepository = new EmployeeRepository();
        }

        public int CreateUser(User user)
        {
            return _employeeRepository.CreateUser(user);
        }

        public User GetUserById(long id)
        {
            return _employeeRepository.GetById(id);
        }

        public List<User> GetUsers()
        {
            return _employeeRepository.GetAll();
        }

        public bool Delete(long id)
        {
            var user = _employeeRepository.GetById(id);
            return _employeeRepository.Remove(user);
        }

        public bool Update(User user)
        {
            return _employeeRepository.Update(user);
        }
    }
}
