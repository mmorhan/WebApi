using DataAccessLayer.Repositories.Abstact;
using DataAccessLayer.Repositories.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Generic
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        Context c = new Context();
        public void Add(T t)
        {
            c.Set<T>().Add(t);
            c.SaveChanges();

        }

        public void AddRange(List<T> ts)
        {
            c.Set<T>().AddRange(ts);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            return c.Set<T>().ToList();
        }

        public T GetById(int id)
        {
            return c.Set<T>().Find(id);
        }

        public void Remove(T t)
        {
            c.Set<T>().Remove(t);
            c.SaveChanges();
        }


        public void RemoveRange(List<T> ts)
        {
            c.Set<T>().RemoveRange(ts);
            c.SaveChanges();
        }

        public void Update(T t)
        {
            c.Set<T>().Update(t); 
        }
    }
}
