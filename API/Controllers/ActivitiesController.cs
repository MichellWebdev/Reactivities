using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace API.Controllers
{
  public class ActivitiesController : BaseApiController
  {
    private readonly DataContext _context;
    public ActivitiesController(DataContext context)
    {
      _context = context;
    }

    [HttpGet]
    // ActionResult is what's gonna get returned and it's gonna return a list of activities - GetActivities is the name of it 
    public async Task<ActionResult<List<Activity>>> GetActivities()
    {
      return await _context.Activities.ToListAsync();
    }

    // An httpget method to Allow user to select an individual activity and we pass in a root parameter (what's inside the {})
    [HttpGet("{id}")] // User will go to activites endpoint and pass in the ID ( whatever id of the activity they chose)
    public async Task<ActionResult<Activity>> GetActivity(Guid id)
    {
      return await _context.Activities.FindAsync(id);
    }
  }
}