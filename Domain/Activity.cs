using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain
{
  public class Activity
  {
    // All these properties will be forming columns inside a table named activities (so this is basically and instance of an activity in the database or a skeleton of what will be added)
    // Primary key when we call it Id - entity framework recognizes it as the key
    public Guid Id { get; set; }
    public string Title { get; set; }
    public DateTime Date { get; set; }
    public string Description { get; set; }
    public string Category { get; set; }
    public string City { get; set; }
    public string Venue { get; set; }
  }
}