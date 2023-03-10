using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperProga
{
    internal class AppContextTheory : DbContext
    {
        public DbSet<Theory> Questions => Set<Theory>();

        public AppContextTheory() => Database.EnsureCreated();

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=theory.db");
        }
    }
}
