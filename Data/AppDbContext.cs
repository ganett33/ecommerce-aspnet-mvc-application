using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);


            modelBuilder.Entity<Producer_Movie>().HasKey(pm => new
            {
                pm.ProducerId,
                pm.MovieId
            });
            modelBuilder.Entity<Producer_Movie>().HasOne(m => m.Movie).WithMany(pm => pm.Producer_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Producer_Movie>().HasOne(m => m.Producer).WithMany(pm => pm.Producers_Movies).HasForeignKey(m => m.ProducerId);


            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Producer> Producers { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }
        public DbSet<Producer_Movie> Producers_Movies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }


    }
}
