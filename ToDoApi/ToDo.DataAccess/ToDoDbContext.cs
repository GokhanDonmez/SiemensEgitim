using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ToDo.Entities;

namespace ToDo.DataAccess
{
    public class ToDoDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Server=.;Database=ToDoDB;User Id=sa;Password=123;TrustServerCertificate=true;");
        }
        public DbSet<ToDoProgram> ToDoSet { get; set; }
    }
}
