using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyProject.Models;
using VidlyProject.ViewModel;

namespace VidlyProject.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Random()
        {
            using (VidlyEntities _contex = new VidlyEntities())
            {                
                Movie movie = _contex.Movies.SingleOrDefault(x => x.Id == 1);
                List<Customer> customers = _contex.Customers.ToList();

                var randomMovieCustomer = new RandomMovieViewModel()
                {
                    Movie = movie,
                    Customers = customers
                };
            return View(randomMovieCustomer);

            }
        }

        
    }
}