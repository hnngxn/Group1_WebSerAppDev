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
    new Photo { Id = 1, Title = "Sunset Drive", Location = "Bel Air, MD", Description = "Driving under the sunset with my best friend", DateTaken = new DateTime(2025, 1, 11), ImageFile = "Nguyen_Han_SunsetDrive.jpg" },
    new Photo { Id = 2, Title = "Tulips", Location = "Vietnam", Description = "He bought me flowers ", DateTaken = new DateTime(2026, 3, 28), ImageFile = "Nguyen_Han_Tulips.jpg" },
    new Photo { Id = 3, Title = "Owl", Location = "Hershey Park", Description = "Sleepy owl", DateTaken = new DateTime(2025, 5, 20), ImageFile = "Nguyen_Han_Owl.jpg" },
    new Photo { Id = 4, Title = "Fall Season in Cincy", Location = "UC", Description = "First fall at UC", DateTaken = new DateTime(2025, 10, 3), ImageFile = "Nguyen_Han_Fall.jpg" },
    new Photo { Id = 5, Title = "Two little cuties", Location = "Home", Description = "My two good boys back home", DateTaken = new DateTime(2026, 6, 27), ImageFile = "Nguyen_Han_Dogs.jpg" },
    new Photo { Id = 6, Title = "Love Birds", Location = "Cincinnati Zoo", Description = "Lovebirds - they said", DateTaken = new DateTime(2026, 5, 1), ImageFile = "Nguyen_Han_Birds.jpg" },
    new Photo { Id = 7, Title = "Him", Location = "Cincinnati, OH", Description = "The summer he came", DateTaken = new DateTime(2026, 5, 1), ImageFile = "Nguyen_Han_BlurrySummer.jpg" },
    new Photo { Id = 8, Title = "Child", Location = "Hershey Park", Description = "A kid lost in the blue light at the museum", DateTaken = new DateTime(2025, 5, 20), ImageFile = "Nguyen_Han_Child.jpg" },
    new Photo { Id = 9, Title = "UC", Location = "Cincinnati, OH", Description = "UC through my lens", DateTaken = new DateTime(2025, 10, 3), ImageFile = "Nguyen_Han_UC.jpg" },
    new Photo { Id = 10, Title = "Zoo", Location = "Cincinnati Zoo", Description = "First time at this zoo with my boyfriend", DateTaken = new DateTime(2026, 5, 1), ImageFile = "Nguyen_Han_Zoo.jpg" },
    new Photo { Id = 11, Title = "Motorbike", Location = "Vung Tau, Vietnam", Description = "Vacation that I grew up with", DateTaken = new DateTime(2026, 7, 19), ImageFile = "Nguyen_Han_Motorbike.jpg" },
    new Photo { Id = 12, Title = "McDonald's Through the Frame", Location = "Washington, DC", Description = "Trip to DC with mom and dad", DateTaken = new DateTime(2025, 1, 27), ImageFile = "Nguyen_Han_McDonalds.jpg" }
    );      
        }
    }
}