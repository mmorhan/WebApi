using BusinessLayer.Concrete;
using DataAccessLayer.Repositories.Concrete;
using EntityLayer;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.FakeData;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class UserController : Controller
    {
        private List<User>_users=FakeUser.GetUsers(100);
        private UserManager manager = new UserManager(new EfUserRepository());

        
        [HttpGet]
        public List<User> Get()
        {
            return _users;
        }
        [HttpGet("{id}")]
        public User Get(int id)
        {
            return manager.GetById(id);
        }
        [HttpPost]
        public void Add([FromBody] User user)
        {
            manager.Add(user);
        }
        [HttpPut]
        public void Update([FromBody] User user)
        {
            manager.Update(user);
        }
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            manager.Remove(id);
        }
        [HttpGet("RandomAdd")]
        public User RandomAdd(int id)
        {
            return manager.GetById(id);
        }



     }
}
