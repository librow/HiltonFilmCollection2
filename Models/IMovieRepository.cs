using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiltonFilmCollection2.Models
{
    // interface template, not a class
    public interface IMovieRepository
    {
        IQueryable<Movie> Movies { get; }
    }
}
