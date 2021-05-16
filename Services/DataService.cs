using System.Collections.Generic;
using TalebiAPI.DataAccess;
using TalebiAPI.Domain;

namespace TalebiAPI.Services
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

        public List<User> GetUsers()
        {
            return _employeeRepository.GetAll();
        }
    }
}
