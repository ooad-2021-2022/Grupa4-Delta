using eOrdinacija.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace eOrdinacija.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { 
        }
            

            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Osoba>().ToTable("Osoba");
                modelBuilder.Entity<Dijagnoza>().ToTable("Dijagnoza");
                modelBuilder.Entity<Karton>().ToTable("Karton");
                modelBuilder.Entity<KartonUposlenik>().ToTable("KartonUposlenik");
                modelBuilder.Entity<Nalaz>().ToTable("Nalaz");
                
                modelBuilder.Entity<Pacijent>().ToTable("Pacijent");
                modelBuilder.Entity<UposlenikUsluga>().ToTable("UposlenikUsluga");
                modelBuilder.Entity<Usluga>().ToTable("Usluga");

            base.OnModelCreating(modelBuilder);
            }

    }
}
