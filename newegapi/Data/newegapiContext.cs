using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SuperHeroAPI;

namespace newegapi.Data
{
    public class newegapiContext : DbContext
    {
        public newegapiContext (DbContextOptions<newegapiContext> options)
            : base(options)
        {
        }

        public DbSet<SuperHeroAPI.SuperHero> SuperHeroes { get; set; } = default!;
    }
}
