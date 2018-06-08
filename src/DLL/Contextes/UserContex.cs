using Microsoft.EntityFrameworkCore;
using DLL.Models;

namespace DLL.Contextes
{
    public class UserContex : DbContext
    {
        public UserContex()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }

        public DbSet<User> Users{get; set;}
    }
}