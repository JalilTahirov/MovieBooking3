using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MovieBooking3.Models;

namespace MovieBooking3.Controllers
{
    public class OtherController : Controller
    {
        private testEntities msContext;
        
        public OtherController()
        {
            msContext = new testEntities();
        }
        [Authorize]
        public ActionResult listGridAction()
        {
            var userMovies = msContext.UserMovie;
            //// make argument like JSON and pass json parameter from Jquery post
            return View(userMovies);

        }

        
        [HttpPost]
        public ActionResult deleteResult(int usrmovieId)
        { 
            UserMovie toDeleteEntry = msContext.UserMovie.Where(x => x.UserMovieId == usrmovieId).FirstOrDefault();
            msContext.Entry(toDeleteEntry).State = System.Data.Entity.EntityState.Deleted;   
            msContext.SaveChanges();

            string test = "hiii";
            return Json(test);
        }
    







        [HttpPost]
        public ActionResult editResult(forTicketSave ff)
        {           
            int usrmovieId = ff.id;            

            UserMovie userMovie = msContext.UserMovie.Where(x => x.UserMovieId == usrmovieId).FirstOrDefault();
            userMovie.PhoneNumber = ff.key1;
            userMovie.MovieTime = ff.key2;
            userMovie.PurchaseCount = ff.key3;
            msContext.SaveChanges();

            string test = "hiii";
            return Json(test);
        }


        [HttpPost]
        public ActionResult editAllResult(List<forTicketSave> all_obj)
        {
            foreach (var item in all_obj)
            {
                NormalMethod(item);
            }
            string test = "hiii";
            return Json(test);

        }

        public void NormalMethod(forTicketSave ff)
        {
            int usrmovieId = ff.id;

            UserMovie userMovie = msContext.UserMovie.Where(x => x.UserMovieId == usrmovieId).FirstOrDefault();
            userMovie.PhoneNumber = ff.key1;
            userMovie.MovieTime = ff.key2;
            userMovie.PurchaseCount = ff.key3;
            msContext.SaveChanges();

            
            
        }
    }





    public class forTicketSave
    {
        public int id { get; set; }
        public string key1 { get; set; }
        public int key2 { get; set; }
        public int key3 { get; set; }

    }
}





