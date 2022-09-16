using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using signupApi.Models;

namespace signupApi.Data
{
    public class signupApiContext : DbContext
    {
        public signupApiContext (DbContextOptions<signupApiContext> options)
            : base(options)
        {
        }

        public DbSet<signupApi.Models.userlist> userlist { get; set; } = default!;
    }
}
