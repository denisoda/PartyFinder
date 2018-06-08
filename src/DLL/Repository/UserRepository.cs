using DLL.Interfaces;
using System;
using DLL.Contextes;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using DLL.Models;
using System.Data;

namespace DLL.Repository
{
    public class UserRepository : IUserRepository, IDisposable
    {
        UserContex _userContex;
        UserRepository(UserContex UserContex)
        {
            this._userContex = UserContex;
        }

        public IEnumerable <User> GetAllUsers()
        {
            return _userContex.Users.ToList();
        }
        public User GetUserById(int id)
        {
            return _userContex.Users.Find(id);
        }
        public void InsertUser(User user)
        {
            _userContex.Users.Add(user);
        }
        public void UpdateUser(User user)
        {
            _userContex.Users.Update(user);
        }
        public void DeleteUser(User user)
        {
            _userContex.Users.Remove(user);
        }
        public void Save()
        {
            _userContex.SaveChanges();
        }

        public void Dispose()
        {
            _userContex.Dispose();
        }
    }
}