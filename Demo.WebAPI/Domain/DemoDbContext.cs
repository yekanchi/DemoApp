using Microsoft.EntityFrameworkCore;

namespace Bidar.WebAPI.Domain
{
    public class DemoDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
    }
}