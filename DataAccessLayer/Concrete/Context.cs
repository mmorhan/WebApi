using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           optionsBuilder.UseNpgsql("User ID=orhan;Password=12345;Server=localhost;Port=5432;Database=webproject;Integrated Security=true;Pooling=true;");
        }

        public DbSet<User> Users { get; set; }
    }
}
