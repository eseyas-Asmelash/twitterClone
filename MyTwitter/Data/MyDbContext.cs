using Microsoft.EntityFrameworkCore;
using MyTwitter.Models;

namespace MyTwitter.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<PostMessage> Message { get; set; }
    }
}
