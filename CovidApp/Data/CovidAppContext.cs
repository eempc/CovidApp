using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CovidApp.Models;

namespace CovidApp.Data
{
    public class CovidAppContext : DbContext
    {
        public CovidAppContext (DbContextOptions<CovidAppContext> options)
            : base(options)
        {
        }

        public DbSet<CovidApp.Models.AccessionRecord> AccessionRecord { get; set; }
    }
}
