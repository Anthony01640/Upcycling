using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UpCycling.Data.Entity;

namespace UpCycling.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<User> Utilisateur { get; set; }

        public DbSet<Event> Events { get; set; }

        public DbSet<LiaisonUserEvent> Liaisons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().ToTable(nameof(User));

            modelBuilder.Entity<Event>().ToTable(nameof(Event));

            modelBuilder.Entity<LiaisonUserEvent>().ToTable(nameof(LiaisonUserEvent));
            modelBuilder.Entity<LiaisonUserEvent>().HasOne(w => w.Event).WithMany(w => w.Users).HasForeignKey(m => m.EventId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<LiaisonUserEvent>().HasOne(w => w.User).WithMany(w => w.Events).HasForeignKey(m => m.UserId).OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "1", Name = "Utilisateur", NormalizedName = "UTILISATEUR", ConcurrencyStamp = "b1ad5b97-999b-48c1-bb2c-c971792aaa6b" }
                );

            modelBuilder.Entity<IdentityRole>().HasData(
    new IdentityRole() { Id = "2", Name = "Admin", NormalizedName = "ADMIN", ConcurrencyStamp = "b1ad5b97-999b-48c1-bb2c-c971792aaa7f" }
    );
        }
    }
}
