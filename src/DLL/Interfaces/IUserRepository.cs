using System.Collections;
using DLL.Models;
using System.Collections.Generic;

namespace DLL.Interfaces
{
    public interface IUserRepository
    {
         IEnumerable<User> GetAllUsers();
         User GetUserById(int id);
         void InsertUser(User user);
         void UpdateUser(User user);
         void DeleteUser(User user);
         void Save();
    }
}