using MovieBooking3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace MovieBooking3.Controllers
{
    public class SignOutController : Controller
    {
      
        public ActionResult Index()
        {
            if (Session["XYZ"]!=null)
            {
                ViewBag.Name = Session["XYZ"].ToString();
            }
            return View();
        }
    }
}
