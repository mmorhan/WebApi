using BusinessLayer.Abstract;
using DataAccessLayer.Repositories.Abstact;
using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class UserManager : IUserService
    {
        protected IUserRepository _userRepository;
        public UserManager(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public User GetById(int id)
        {
            return _userRepository.GetById(id);
        }

        public List<User> GetList()
        {
            return _userRepository.GetAll();
        }

        public void Add(User t)
        {
            _userRepository.Add(t);
        }

        public void Remove(int id)
        {
            _userRepository.Remove(GetById(id));
        }

        public void Update(User t)
        {
            _userRepository.Update(t);
        }
    }
}
