using ETicketsApplication.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace ETicketsApplication.Data
{
    // 6 creating Db context for connection management and installed Ef core package and go to Program.cs file
    public class AppDbcontext : DbContext 
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options):base(options)
        {
        }

        //15 For many to many relationship need to ddd some indication in AppDb context file in OnModelCreating AntiforgeryServiceCollectionExtensions  will override ThreadStaticAttribute with onModelCreating method

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId,
            }); // 16 haskey (Primary Key)
            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Movie).WithMany(am =>
            am.Actors_Movies).HasForeignKey(m => m.MovieId);

            modelBuilder.Entity<Actor_Movie>().HasOne(m => m.Actor).WithMany(am =>
            am.Actors_Movies).HasForeignKey(m => m.ActorId);

            base.OnModelCreating(modelBuilder);
        }
        /* instead of adding AppDbContextFactory.cs file we can try to add below in it. 
          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer("Server=localhost;Database=ETicketsDB;User Id=sa;Password=yourpassword;");
        }
    }
         
         */


        // 17 define table name for each model after onmodelcreating  , Net cofiguring SQL Server
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Actor_Movie> Actors_Movies { get; set; }

        public DbSet<Cinema> Cinemas { get; set; }

        public DbSet<Producer> Producers { get; set; }


      
       
    }

}
