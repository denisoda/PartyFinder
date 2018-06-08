using Microsoft.EntityFrameworkCore;
using DLL.Models;

namespace DLL.Contextes
{
    public class UserContex : DbContext
    {
        public UserContex()
        {

        }

        public DbSet<User> Users{get; set;}
    }
}