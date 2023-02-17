using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rulers.Models;

namespace Rulers.Data
{
    public class RulersContext : DbContext
    {
        public RulersContext (DbContextOptions<RulersContext> options)
            : base(options)
        {
        }

        public DbSet<Rulers.Models.Ruler> Ruler { get; set; }
    }
}
