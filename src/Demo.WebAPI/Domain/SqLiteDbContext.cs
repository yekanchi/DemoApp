using Microsoft.EntityFrameworkCore;
using TalebiAPI.Domain;

namespace Bidar.WebAPI.Domain
{
    public class SqLiteDbContext : DemoDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
             options.UseSqlite("Data Source=.\\sqlitedemo.db");
    }
}