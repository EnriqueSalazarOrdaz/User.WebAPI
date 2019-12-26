using Microsoft.EntityFrameworkCore;
using Project.Schema;
using System;

namespace Project.EF
{
    public class ProjectDBContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Address> Address { get; set; }
        public DbSet<AddressRelationShip> AddressRelationShip { get; set; }


        //este de abajo prodria ir en un partial class
        public ProjectDBContext(DbContextOptions<ProjectDBContext> dbContextOptions) : base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<IDBColumns>()
                .HasKey(s => new { s.ID, s.InstanceID, s.CompanyID });
        }

        
    }
}
