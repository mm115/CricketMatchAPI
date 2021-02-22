using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CricketMatchAPI.Models;

namespace CricketMatchAPI.Data
{
    public class CricketMatchAPIContext : DbContext
    {
        public CricketMatchAPIContext (DbContextOptions<CricketMatchAPIContext> options)
            : base(options)
        {
        }

        public DbSet<CricketMatchAPI.Models.Player> Player { get; set; }
    }
}
