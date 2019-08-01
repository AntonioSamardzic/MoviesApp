using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projekt.Extensions;
using Projekt.Models;

namespace Projekt
{
    public class ProjektContext : DbContext
    {
        public ProjektContext(DbContextOptions<ProjektContext> options) : base(options)
        {
            //constructor
        }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Bought> Boughts { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<Engagement> Engagements { get; set; }
        public DbSet<MovieType> MovieTypes { get; set; }
        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();

            modelBuilder.Entity<Bought>()
                    .HasOne<Movie>(sc => sc.Movie)
                    .WithMany(s => s.Boughts)
                    .HasForeignKey(sc => sc.MovieId);

            modelBuilder.Entity<Bought>()
                    .HasOne<User>(sc => sc.User)
                    .WithMany(s => s.Boughts)
                    .HasForeignKey(sc => sc.UserId);

            modelBuilder.Entity<Engagement>()
                    .HasOne(sc => sc.Actor)
                    .WithMany(s => s.Engagements)
                    .HasForeignKey(sc => sc.ActorId);

            modelBuilder.Entity<Engagement>()
                    .HasOne(sc => sc.Movie)
                    .WithMany(s => s.Engagements)
                    .HasForeignKey(sc => sc.MovieId);

        }
        
    }
    }


