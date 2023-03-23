using Microsoft.EntityFrameworkCore;
using App04_web.Models;

namespace App04_web.Data
{
    public class AppDB : DbContext
    {
        public AppDB(DbContextOptions<AppDB> options) : base(options)
        {

        }
        public DbSet<App04_web.Models.Newsfeed> Newsfeed { get; set; } = default!;
    }
}
