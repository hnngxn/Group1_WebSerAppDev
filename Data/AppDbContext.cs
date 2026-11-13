using Group1_WebSerAppDev.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;

namespace Group1_WebSerAppDev.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Photo> Photos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Photo>().HasData(
                new Photo { Id = 1, Title = "[title]", Location = "[place]", Camera = "[camera]", DateTaken = new DateTime(2026, 5, 10) },
                new Photo { Id = 2, Title = "[title]", Location = "[place]", Camera = "[camera]", DateTaken = new DateTime(2026, 7, 2) },
                new Photo { Id = 3, Title = "[title]", Location = "[place]", Camera = "[camera]", DateTaken = new DateTime(2026, 9, 18) }
            );
        }
    }
}