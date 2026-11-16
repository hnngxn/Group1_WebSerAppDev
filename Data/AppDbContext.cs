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
        public DbSet<CardioActivity> CardioActivities { get; set; }
        public DbSet<ActivityPace> ActivityPaces { get; set; }

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

            modelBuilder.Entity<CardioActivity>().HasData(
                new CardioActivity { Id = 1, Name = "Rollerblading", JointImpact = ImpactLevel.Low, MusclesWorked = "Glutes, quads, hip abductors, core", Equipment = "Skates, helmet, pads" },
                new CardioActivity { Id = 2, Name = "Running", JointImpact = ImpactLevel.High, MusclesWorked = "Quads, hamstrings, calves", Equipment = "Running shoes" },
                new CardioActivity { Id = 3, Name = "Cycling", JointImpact = ImpactLevel.Low, MusclesWorked = "Quads, glutes, calves", Equipment = "Bike, helmet" },
                new CardioActivity { Id = 4, Name = "Walking", JointImpact = ImpactLevel.Low, MusclesWorked = "Calves, hamstrings, glutes", Equipment = "Walking shoes" },
                new CardioActivity { Id = 5, Name = "Swimming", JointImpact = ImpactLevel.Low, MusclesWorked = "Shoulders, back, core, legs", Equipment = "Pool access, goggles" },
                new CardioActivity { Id = 6, Name = "Rowing machine", JointImpact = ImpactLevel.Low, MusclesWorked = "Back, legs, arms, core", Equipment = "Rowing machine" },
                new CardioActivity { Id = 7, Name = "Elliptical", JointImpact = ImpactLevel.Low, MusclesWorked = "Quads, glutes, hamstrings", Equipment = "Elliptical trainer" },
                new CardioActivity { Id = 8, Name = "Jump rope", JointImpact = ImpactLevel.High, MusclesWorked = "Calves, shoulders, core", Equipment = "Jump rope" }
            );

            // MET values are from the 2011 Compendium of Physical Activities.
            modelBuilder.Entity<ActivityPace>().HasData(
                new ActivityPace { Id = 1, CardioActivityId = 1, Description = "9 mph, recreational", Met = 7.5 },
                new ActivityPace { Id = 2, CardioActivityId = 1, Description = "11 mph, moderate", Met = 9.8 },
                new ActivityPace { Id = 3, CardioActivityId = 2, Description = "5 mph (12 min/mile)", Met = 8.3 },
                new ActivityPace { Id = 4, CardioActivityId = 2, Description = "6 mph (10 min/mile)", Met = 9.8 },
                new ActivityPace { Id = 5, CardioActivityId = 3, Description = "12-13.9 mph, moderate", Met = 8.0 },
                new ActivityPace { Id = 6, CardioActivityId = 4, Description = "3.5 mph, brisk", Met = 4.3 },
                new ActivityPace { Id = 7, CardioActivityId = 5, Description = "Freestyle laps, light to moderate", Met = 5.8 },
                new ActivityPace { Id = 8, CardioActivityId = 6, Description = "100 watts, moderate", Met = 7.0 },
                new ActivityPace { Id = 9, CardioActivityId = 7, Description = "Moderate effort", Met = 5.0 },
                new ActivityPace { Id = 10, CardioActivityId = 8, Description = "100-120 skips/min", Met = 11.8 }
            );
        }
    }
}