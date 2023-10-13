using Microsoft.EntityFrameworkCore;
using Rugking.Models;

namespace Rugking.Data
{
    public class RugkingContext : DbContext
    {
        public RugkingContext(DbContextOptions<RugkingContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; }
    }
}