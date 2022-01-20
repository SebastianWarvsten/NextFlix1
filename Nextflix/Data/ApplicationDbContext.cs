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

        public DbSet<Director> Directors { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Review> Review { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<User>()
                .HasMany(u => u.Reviews)
                .WithOne(r => r.User)
                .HasForeignKey(r => r.UserID);

            modelBuilder
                .Entity<Review>()
                .HasOne(r => r.Movie)
                .WithMany(m => m.Reviews)
                .HasForeignKey(r => r.MovieID).IsRequired();

            modelBuilder
                .Entity<Director>()
                .HasMany(d => d.Movie)
                .WithOne(m => m.Director)
                .HasForeignKey(m => m.DirectorID).IsRequired();


        }

    }
}