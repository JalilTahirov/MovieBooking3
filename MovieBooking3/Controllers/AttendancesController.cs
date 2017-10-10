using MovieBooking3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MovieBooking3.Controllers
{
    public class AttendancesController : ApiController
    {
        private testEntities _context;
        public AttendancesController()
        {
            _context = new testEntities();
        }


        public IHttpActionResult Attend(int? movieId)
        {

            //var rowtoUpdate = _context.UserMovie.Find(movieId);

            // testEntities instructor = _context.UserMovie.Include(i=>).Where(i => i.MovieId == movieId).Single();

            UserMovie userMovie = _context.UserMovie.Where(x => x.MovieId == movieId).FirstOrDefault();
            userMovie.PurchaseCount--;
            _context.SaveChanges();

            return null;
        }
    }

}