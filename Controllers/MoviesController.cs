using ProMovies.Models;
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
            return View(movie);
        }
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

        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + " / " + month);
        }

    }
}