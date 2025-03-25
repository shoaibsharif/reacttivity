using Application.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Application.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ActivitiesController(AppDbContext context) : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Activity>>> GetActivities()
    {
        return await context.Activities.ToListAsync();
    }
    
    [HttpGet("{id}")]
    public async Task<ActionResult<Activity>> GetActivity(string id)
    {
        var activity = await context.Activities.FindAsync(id);
        if (activity == null) return NotFound();
        return activity;
    }
}
