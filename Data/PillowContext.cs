using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PillowFactory.Models;



namespace PillowFactory.Data
{
    public class PillowContext : DbContext
    {
        public PillowContext(DbContextOptions<PillowContext> options)
          : base(options)
        {
        }

        public DbSet<Pillow>Pillow { get; set; }
    }
}


