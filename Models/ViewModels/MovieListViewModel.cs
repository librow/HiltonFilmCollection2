﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HiltonFilmCollection2.Models.ViewModels
{
    public class MovieListViewModel
    {
        public IEnumerable<Movie> Movies { get; set; }
    }
}
