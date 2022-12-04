using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.DomianModels;
using Microsoft.EntityFrameworkCore;

namespace _1_DAL.Context
{
    internal class DaoTaoContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-CFK23F4\SQLEXPRESS;Initial Catalog=ASM_Code_First;Integrated Security=True");
            }
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
