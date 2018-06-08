using Microsoft.EntityFrameworkCore;
using DLL.Models;
using MySql.Data.EntityFrameworkCore;

namespace DLL.Contextes
{
    public class UserContex : DbContext
    {
        public UserContex()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL("server=localhost;database=PartyFinder;user=root;password=Bb6167419");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.FName);
                entity.Property(e => e.SName);
                entity.HasMany(e => e.Rewiew);
            });
        }

        public DbSet<User> Users{get; set;}
    }
}