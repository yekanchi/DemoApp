using Microsoft.EntityFrameworkCore;
using TalebiAPI.Domain;

namespace Bidar.WebAPI.Domain
{
    public class SqLiteDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options) => 
            // options.UseSqlite("Data Source=.\\sqlitedemo.db");
            options.UseNpgsql("Host=localhost;Username=M.Talebi;Database=postgres");
    }
}