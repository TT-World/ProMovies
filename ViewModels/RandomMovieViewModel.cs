using ProMovies.Models;
using System.Collections.Generic;

namespace ProMovies.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}