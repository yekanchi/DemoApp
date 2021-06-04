using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TalebiAPI.Domain;
using TalebiAPI.Services;

namespace TalebiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        private readonly DataService _dataService;
        public EmployeeController()
        {
            _dataService = new DataService();
        }

        [HttpPost]
        public int CreateUser(User user)
        {
            return _dataService.CreateUser(user);
        }

        [HttpPut]
        public bool Update(User user)
        {
            return _dataService.Update(user);
        }


        [HttpGet("/all")]
        public List<User> GetAll()
        {
            return _dataService.GetUsers();
        }

        [HttpDelete("/delete/{id}")]
        public bool Remove(long id)
        {
            return _dataService.Delete(id);
        }
    }
}
