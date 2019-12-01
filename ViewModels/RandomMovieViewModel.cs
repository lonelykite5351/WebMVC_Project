using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using lonelykite.Models;

namespace lonelykite.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}