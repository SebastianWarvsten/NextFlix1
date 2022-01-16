using System;
using Nextflix.Entities;
using Microsoft.EntityFrameworkCore;

namespace Nextflix.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Director> Director { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Review { get; set; }

    }
}