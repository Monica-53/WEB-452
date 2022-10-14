using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PillowFactory.Models;

namespace PillowFactory.Data
{
    public class PillowFactoryContext : DbContext
    {
        public PillowFactoryContext (DbContextOptions<PillowFactoryContext> options)
            : base(options)
        {
        }

        public DbSet<PillowFactory.Models.Pillow> Pillow { get; set; }
    }
}
