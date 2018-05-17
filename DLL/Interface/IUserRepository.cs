using System.Collections;
using GoodNight.Models;

namespace DLL.Interface
{
    public interface IUserRepository
    {
        IEnumerable GetAllUsersAsync();
        User GetUserById(int id);
        void AddUser(User user);
        void DeleteUser(User user);
        void EditUser(int id, User editeduser);
    }
}