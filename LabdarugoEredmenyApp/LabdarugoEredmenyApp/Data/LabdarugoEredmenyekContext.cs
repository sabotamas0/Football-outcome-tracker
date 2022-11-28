using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LabdarugoEredmenyApp.Models;

namespace LabdarugoEredmenyApp.Data
{
    public class LabdarugoEredmenyekContext : DbContext
    {
        public LabdarugoEredmenyekContext (DbContextOptions<LabdarugoEredmenyekContext> options)
            : base(options)
        {

        }

        public DbSet<Bajnoksag> Bajnoksagok { get; set; }
        public DbSet<Csapat> Csapatok { get; set; }
        public DbSet<Merkozes> Merkozesek { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            modelBuilder.Entity<Bajnoksag>().HasData(InitDb.SeedBajnoksagok());
            modelBuilder.Entity<Csapat>().HasData(InitDb.SeedCsapatok());
        }

    }
}
