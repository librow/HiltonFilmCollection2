using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiltonFilmCollection2.Models
{
    public class EFMovieRepository : IMovieRepository
    {
        // creating a property "context" of type "MovieDbContext"
        private MovieDbContext _context;

        // Constructor
        public EFMovieRepository(MovieDbContext context)
        {
            _context = context;
        }

        public IQueryable<Movie> Movies => _context.Movies;
    }
}
