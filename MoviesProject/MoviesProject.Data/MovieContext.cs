using Microsoft.EntityFrameworkCore;
using MoviesProject.Data.Entities;

namespace MoviesProject.Data
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) {}
        public DbSet<Movie> Movies { get; set; }
    }
}
