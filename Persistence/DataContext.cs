using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
  // Derive from DbContext from entityframework 
  public class DataContext : DbContext
  {
    // Use DbContextOptions and then parse in the options and then we use the base which is the Constructor inside the DbContext class we're deriving from and the parse options to that class
    public DataContext(DbContextOptions options) : base(options)
    {
    }

    // Name of database table - which contains columns of the properties from activity class
    // Represents table
    public DbSet<Activity> Activities { get; set; }
  }
}