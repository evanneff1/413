//This is the controller for the Movie Context. This uses the DbContext package to bring in the options to allow the movies table to be created

using Microsoft.EntityFrameworkCore;

namespace FilmWebApp_Evan_Neff.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base (options) 
        {
        }

        public DbSet<Movies> movies { get; set; }
    }
}
