using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SportsApp.Models;

namespace SportsApp.Models
{
    public class SportsAppContext : DbContext
    {
        public SportsAppContext (DbContextOptions<SportsAppContext> options)
            : base(options)
        {
        }

        public DbSet<SportsApp.Models.Test> Test { get; set; }

        public DbSet<SportsApp.Models.TestDetails> TestDetails { get; set; }
    }
}
