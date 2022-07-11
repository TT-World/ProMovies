using ProMovies.Models;
using ProMovies.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;

namespace ProMovies.Controllers
{
    public class MoviesController : Controller
    {
        // this will be called when we go here  GET: Movies/Random
        public ActionResult Random()
        {
            //create intance of our movie model
            var movie = new Movie() { Name = "Shrek! TT" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };
            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            //ViewData["RandomMovie"] = movie; do not use this approach
            //ViewBag.Movie = movie;
            //var viewResult = new ViewResult();
            //viewResult.ViewData.Model = movie;
            return View(viewModel);
        }
















































        /*
        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }


        
        //Movies
        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content(string.Format("pageIndex={0}&sortBy={1}", pageIndex, sortBy));
        }



        /*
        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + " / " + month);
        }*/

    }
}