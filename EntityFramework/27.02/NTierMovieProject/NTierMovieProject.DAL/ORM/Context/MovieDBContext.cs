using NTierMovieProject.DAL.ORM.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NTierMovieProject.DAL.ORM.Context
{
    public class MovieDBContext:DbContext
    {
        public MovieDBContext()
        {
            Database.Connection.ConnectionString = "server=.;database=MovieDB;uid=sa;pwd=123";
        }

        //Many Tables
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Actor> Actors { get; set; }

        //Many To Many Tables
        public DbSet<MovieCategory> MovieCategories { get; set; }
        public DbSet<MovieActor> MovieActors { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<MovieCategory>().HasKey(x => new { x.MovieId, x.CategoryId });
            modelBuilder.Entity<MovieActor>().HasKey(x => new { x.MovieId, x.ActorId });
            base.OnModelCreating(modelBuilder);
        }
    }
}
