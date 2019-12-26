using Microsoft.EntityFrameworkCore;
using Project.Schema;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.EF
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.\\maininstance;Persist Security Info=True;User ID=AdminEnrique; password=password ;Pooling=False;MultipleActiveResultSets=False;Connect Timeout=60;Encrypt=False;TrustServerCertificate=True;Integrated Security=True;ApplicationIntent=ReadWrite");
        }
    }
}
