using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BL.Models;

namespace BL.DATA
{
    public class NewshoreContext : DbContext
    {
        public NewshoreContext (DbContextOptions<NewshoreContext> options) : base(options)
        {
        }

        public DbSet<Flight> Flights { get; set; }
        public DbSet<Transport> Transports { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Flight>().ToTable("flights");
            modelBuilder.Entity<Transport>().ToTable("transports");
        }
    }
}
