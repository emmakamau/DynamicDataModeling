using DynamicDataModeling.Models;
using Microsoft.EntityFrameworkCore;

namespace DynamicDataModeling
{
    public class DataModelingContext : DbContext
    {
        public DataModelingContext(DbContextOptions<DataModelingContext> options) : base(options)
        {
        }

        public DbSet<Education> Educations { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<PersonalInfo> PersonalInfos { get; set; }
        
        public DbSet<GlobalType> GlobalTypes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }

    }

}


public static class modelbuilderextensions
{
    public static void Seed(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<GlobalType>().HasData(
            new GlobalType { Id = 1, Name = "PhoneNumber", TableName="Contacts", Type="Text Field"},
            new GlobalType { Id = 2, Name = "Fax", TableName="Contacts", Type="TextField"},
            new GlobalType { Id = 3, Name = "Email", TableName="Contacts", Type="TextField"}
        );

        modelBuilder.Entity<User>().HasData(
            new User { Id = 1, Name = "User1" },
            new User { Id = 2, Name = "User2" },
            new User { Id = 3, Name = "User3" }
        );

        modelBuilder.Entity<Contact>().HasData(
            new Contact { Id = 1, UserId = 1, GlobalTypeId = 1 },
            new Contact { Id = 2, UserId = 1, GlobalTypeId = 1 }
        );

        modelBuilder.Entity<Education>().HasData(
            new Education { Id = 1, UserId = 1},
            new Education { Id = 2, UserId = 2}
        );
    }
}