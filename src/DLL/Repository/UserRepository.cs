using DLL.Interfaces;
using System;
using DLL.Contextes;

namespace DLL.Repository
{
    public class UserRepository : IUserRepository, IDisposable
    {
        UserContex _userContex;
        UserRepository(UserContex UserContex)
        {
            this._userContex = UserContex;
        }

        public IEnumerable GetAllUsers()
        {
        
        }
        public User GetUserById(int id)
        {

        }
        public void InsertUser(User user)
        {

        }
        public void UpdateUser(User user)
        {

        }
        public void DeleteUser(User user)
        {
            
        }
        public void Save()
        {

        }

        public void Dispose()
        {

        }
    }
}