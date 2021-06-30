using System;
using Microsoft.EntityFrameworkCore;

namespace Bidar.WebAPI.Domain
{
    public class PostgresDbContext : DemoDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseNpgsql("Host=localhost;Username=M.Talebi;Database=postgres");
    }
}