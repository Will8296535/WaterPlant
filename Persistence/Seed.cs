using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;

namespace Persistence
{
    public class Seed
    {
        public static async Task SeedData(DataContext context)
        {
            if (context.Activities.Any()) return;
            
            var activities = new List<Activity>
            {
                new Activity
                {
                    Date = DateTime.Now,
                    PlantNumber = 1,
                },
                new Activity
                {
                   Date = DateTime.Now,
                   PlantNumber = 2,
                },
                new Activity
                {
                    Date = DateTime.Now,
                    PlantNumber = 3,
                },
                new Activity
                {
                    Date = DateTime.Now,
                    PlantNumber = 4,
                },
                 new Activity
                {
                    Date = DateTime.Now,
                    PlantNumber = 5,
                },
            };

            await context.Activities.AddRangeAsync(activities);
            await context.SaveChangesAsync();
        }
    }
}