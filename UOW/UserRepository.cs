using System.Collections.Generic;
using System.Linq;
using unitofwork.Models;

namespace unitofwork.UOW
{
   public class UserRepository : IUserRepository
    {
        private readonly AppDbContext context;
        public UserRepository(AppDbContext dbContext)
        {
            this.context = dbContext;
        }
        public void AddUser(User user)
        {
            context.User.Add(user);
        }
        public bool DeleteUser(long userId)
        {
            var removed = false;
            User user = GetUser(userId);
            if (user != null)
            {
                removed = true;
                context.User.Remove(user);
            }
            return removed;
        }
        public User GetUser(long Id)
        {
            return context.User.Where(u => u.UserId == Id).FirstOrDefault();
        }
        public IEnumerable<User> GetUsers()
        {
            return context.User;
        }
    }
}