using Microsoft.EntityFrameworkCore;
using Try3.Models;

namespace Try3
{
    public class AppDbContextt : DbContext
    {
        public AppDbContextt(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> users { get; set; }
        public DbSet<Role> roles { get; set; }

        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<Reaction> reactions { get; set; }
    }
}
