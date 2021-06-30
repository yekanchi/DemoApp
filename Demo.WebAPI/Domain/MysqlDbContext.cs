using Microsoft.EntityFrameworkCore;

namespace Bidar.WebAPI.Domain
{
    public class MysqlDbContext : DemoDbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options) =>
            options.UseMySQL("Server=85.10.205.173;port=3306;Database=talebidb;Uid=adminsadmins;Pwd=adminsadmins;",
                // options.UseMySQL("Server=sql11.freemysqlhosting.net	;port=3306;Database=sql11422274;Uid=sql11422274;Pwd=IUkmht5TIG;",
                opts => opts.CommandTimeout(500));
    }
}