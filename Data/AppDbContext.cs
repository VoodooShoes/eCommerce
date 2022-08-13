using eCommerce.Models;
using Microsoft.EntityFrameworkCore;


namespace eCommerce.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_MovieModel>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId

            });

            modelBuilder.Entity<Actor_MovieModel>().HasOne(m => m.Movies).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.MovieId);
            modelBuilder.Entity<Actor_MovieModel>().HasOne(m => m.Movies).WithMany(am => am.Actors_Movies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<ActorModel> Actors { get; set; }
        public DbSet<MovieModel> Movies { get; set; }
        public DbSet<Actor_MovieModel> Actors_Movies { get; set; }
        public DbSet<CinemaModel> Cinemas { get; set; }
        public DbSet<ProducerModel> Producers { get; set; }

    }
}
