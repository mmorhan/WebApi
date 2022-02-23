using EntityLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Abstact
{
    public interface IUserRepository:IGenericRepository<User> 
    {
        List<User> GetUsers(int count);
        List<User> GetActiveUser(int count);

    }
}
