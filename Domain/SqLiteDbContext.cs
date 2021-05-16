using Microsoft.EntityFrameworkCore;

namespace TalebiAPI.Domain
{
    public class SqLiteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => 
            options.UseSqlite("Data Source=.\\sqlitedemo.db");
    }
}