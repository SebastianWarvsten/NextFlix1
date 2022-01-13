using Microsoft.EntityFrameworkCore;
using Nextflix.Entities;

namespace Nextflix.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options)
        {

        }
        public DbSet<Movie> Movie { get; set; }
    }
}
