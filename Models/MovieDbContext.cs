using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiltonFilmCollection2.Models
{
    public class MovieDbContext : DbContext
    {
        // Constructor
        public MovieDbContext(DbContextOptions<MovieDbContext> options) : base (options)
        {

        }

        // Property
        public DbSet<Movie> Movies { get; set; }
    }
}
