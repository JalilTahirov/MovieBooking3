using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MovieBooking3.Models;

namespace MovieBooking3.Controllers
{
    public class HomeController : Controller
    {
        private testEntities msContext;
        

        public HomeController()
        {
            msContext = new testEntities();
        }


        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";
            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page...";

            return View();
        }


        public ActionResult DashBoard()
        {
            //var all_movies = msContext.Movie;
            return View();
        }



        

        public ActionResult CallPartial()
        {
            var all_movies = msContext.Movie;
            return View("../Partialviews/_Grid", all_movies);
        }
        /*
                public ActionResult DashBoard(string selectedMovie)
                {
                    ViewBag.Message = selectedMovie;
                    return RedirectToAction("ErrorPage");
                }
        */


        [HttpPost]
        public ActionResult passMovieData(string movieName, int? mId)
        {
            ViewBag.Name = "Jalil555";

            var data = Json(new
            {
                statusCode = mId,
                statusMessage = movieName,
                personHtml = View("../Partialviews/_ticketSubmit")
        });
            return data;


            //return Json(test);
        }



        /// <summary>
        /// it supposed to have parameters int id, string name
        /// </summary>
        /// <returns></returns>
     
        public ActionResult selectedMovie()
        {
            ViewBag.Name = "dsdsd";
            //go to db take id get back the no of tickets avaialbe and the totl no of ticekets.
            ViewBag.id = 1;

            
            return View("../Partialviews/_ticketSubmit");
        }

        [HttpPost]
        public ActionResult selectedMovie(string movieName, int? mId)
        {
            ViewBag.Name = "Jaloaooa";
            
            //go to db take id get back the no of tickets avaialbe and the totl no of ticekets.
            ViewBag.id = 1;


            return View("../Partialviews/_ticketSubmit");
        }





        [HttpPost]
        public ActionResult Attend(int? movieId, int? count, string phone, int? time)
        {

            //// make argument like JSON and pass json parameter from Jquery post
            string test = "false";

            using (testEntities _context = new testEntities())
            {

                UserMovie userMovie = new UserMovie();
                userMovie.MovieId = movieId;
                userMovie.PurchaseCount = count;
                userMovie.PhoneNumber = phone;
                userMovie.MovieTime = time;

                _context.UserMovie.Add(userMovie);


                Movie Movie = _context.Movie.Where(x => x.MovieId == movieId).FirstOrDefault();
                int? value = 0;
                value = Movie.Available - count;
                //value--;
                test = value.ToString();
                Movie.Available  = value;
                _context.SaveChanges();
            }
            //Json data
            return Json(test);
            // return null;
        }
    }
}