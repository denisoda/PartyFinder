using System.Collections;
using DLL.Interface;
using GoodNight.Models;

namespace DLL.Repository
{
    public class UserRepository:IUserRepository
    {
        public IEnumerable GetAllUsersAsync()
        {
            throw new System.NotImplementedException();
        }

        public User GetUserById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void AddUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteUser(User user)
        {
            throw new System.NotImplementedException();
        }

        public void EditUser(int id, User editeduser)
        {
            throw new System.NotImplementedException();
        }
    }
}