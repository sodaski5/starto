using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using starto.Models;

namespace starto.Data
{
    public class startoContext : DbContext
    {
        public startoContext (DbContextOptions<startoContext> options)
            : base(options)
        {
        }

        public DbSet<starto.Models.Movie> Movie { get; set; } = default!;
    }
}
