using Microsoft.EntityFrameworkCore;

namespace Application.Context;

public class AppDbContext(DbContextOptions options): DbContext(options)
{
    public required DbSet<Activity> Activities { get; set; } 
}