using Microsoft.EntityFrameworkCore;
using QuestionProject.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuestionProject.DataAccessLayer.Concrete
{
    public class DataContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=G™KSEL\\SQLEXPRESS;initial catalog=QuesDB;integrated security=true;TrustServerCertificate=Yes");
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}
