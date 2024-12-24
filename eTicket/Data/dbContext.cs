using eTicket.Models;
using Microsoft.EntityFrameworkCore;
using System.Data.Common;

namespace eTicket.Data
{
    public class dbContext : DbContext
    {
        public dbContext(DbContextOptions options): base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.movie).WithMany(am => am.actor_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.actor).WithMany(am => am.actor_movie).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }
            public DbSet<Actor> Actors {get;set;}
            public DbSet<Actor_Movie> Actors_Movie {get;set;}
            public DbSet<Cinema> Cinemas {get;set;}
            public DbSet<Movie> Movies {get;set;}
            public DbSet<Producer> Producers {get;set;}

    }
    
}
