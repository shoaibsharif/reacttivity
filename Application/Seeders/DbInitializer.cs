using Application.Context;

namespace Application.Seeders;

public class DbInitializer
{
    public static async Task SeedData(AppDbContext context)
    {
        if (context.Activities.Any()) return;

        var activities = new List<Activity>()
        {
            new()
            {
                Title = "Past Activity 1",
                Date = DateTime.Now.AddMonths(-2),
                Description = "Activity 2 months ago",
                Category = "culture"
            },
            new()
            {
                Title = "Past Activity 2",
                Date = DateTime.Now.AddMonths(-1),
                Description = "Activity 1 month ago",
                Category = "music"
            },
            new()
            {
                Title = "Future Activity 1",
                Date = DateTime.Now.AddMonths(1),
                Description = "Activity 1 month in future",
                Category = "food"
            },
            new()
            {
                Title = "Future Activity 2",
                Date = DateTime.Now.AddMonths(2),
                Description = "Activity 2 months in future",
                Category = "travel"
            }
        };
        context.Activities.AddRange(activities);
        await context.SaveChangesAsync();
    }
}