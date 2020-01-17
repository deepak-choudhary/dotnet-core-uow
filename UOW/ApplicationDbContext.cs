using Microsoft.EntityFrameworkCore;
using unitofwork.Models;

namespace unitofwork.UOW
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> User { get; set; }
        public DbSet<Product> Product { get; set; }

    }
}