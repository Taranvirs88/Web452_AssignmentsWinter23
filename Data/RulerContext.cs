using Microsoft.EntityFrameworkCore;
using Rulers.Models;

namespace Rulers.Data
{
    public class RulerContext : DbContext
    {
        public RulerContext(DbContextOptions<RulerContext> options)
            : base(options)
        {
        }

        public DbSet<Ruler> Ruler { get; set; }
    }
}