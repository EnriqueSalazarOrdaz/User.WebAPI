using Microsoft.EntityFrameworkCore;
using Project.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.EF
{
    public class UserContext : DbContext
    {
        public DbSet<User> User { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "server=.\\INSTANCESQLESO2;" +
                "DataBase=Project.DB;" +
                "Persist Security Info=True;" +
                "User ID=AdminEnrique; " +
                "Password=password;" +
                "Persist Security Info=True;" +
                "Pooling=False;MultipleActiveResultSets=False;" +
                "Connect Timeout=60;Encrypt=False;TrustServerCertificate=False");
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
