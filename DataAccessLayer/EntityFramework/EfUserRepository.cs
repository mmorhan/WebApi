using DataAccessLayer.Repositories.Abstact;
using DataAccessLayer.Repositories.Generic;
using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Concrete
{
    public class EfUserRepository : GenericRepository<User>, IUserRepository
    {
        public List<User> GetActiveUser(int count)
        {
            throw new NotImplementedException();
        }

        public List<User> GetUsers(int count)
        {
            throw new NotImplementedException();
        }
    }

}
