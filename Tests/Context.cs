using System.Data.Entity;
using Tests.Entities;

namespace Tests
{
    public class Context : DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet Comments { get; set; }
    }
}
