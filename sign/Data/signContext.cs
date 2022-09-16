using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using sign;

namespace sign.Data
{
    public class signContext : DbContext
    {
        public signContext (DbContextOptions<signContext> options)
            : base(options)
        {
        }

        public DbSet<sign.User> Users { get; set; } = default!;
    }
}
