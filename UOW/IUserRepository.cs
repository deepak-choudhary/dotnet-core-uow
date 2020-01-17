using System.Collections.Generic;
using unitofwork.Models;
namespace unitofwork.UOW
{
    public interface IUserRepository
    {
        void AddUser(User user);
        IEnumerable<User> GetUsers();
        bool DeleteUser(long userId);
        User GetUser(long Id);
    }
}