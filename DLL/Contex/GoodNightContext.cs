using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GoodNight.Models;

namespace GoodNight.Models
{
    public class GoodNightContext : DbContext
    {
        public GoodNightContext (DbContextOptions<GoodNightContext> options)
            : base(options)
        {
        }

        public DbSet<GoodNight.Models.User> User { get; set; }
    }
}
