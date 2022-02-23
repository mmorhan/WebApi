using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Abstact
{
    public interface IGenericRepository<T>where T:class
    {
        T GetById(int id);
        List<T> GetAll();
        void Add(T t);
        void AddRange(List<T> ts);

        void Remove(T t);

        void RemoveRange(List<T> ts);
        void Update(T t);

    }
}
