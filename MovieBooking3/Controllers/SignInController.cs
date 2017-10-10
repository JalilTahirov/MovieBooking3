using MovieBooking3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieBooking3.Controllers
{
    public class SignInController : Controller
    {
   
        [HttpPost]
        public ActionResult SignInPost(Role role)
        {
            Session["XYZ"] = role.RoleName;
            return RedirectToAction("CheckSession");
        }

        public ActionResult SignIn()
        {
            return View();
        }

        public ActionResult CheckSession()
        {
            return View();
        }
    }
}
