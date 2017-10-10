using MovieBooking3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MovieBooking3.Controllers
{
    public class LoginController : Controller
    {

        // GET: Login
        public ActionResult Loginuser()
        {
            return View();
        }

        // Post: Login
        public ActionResult Authenticate(User userData)
        {
            using (testEntities msContext = new testEntities())
            {

                if (msContext.User.Any(o => o.Password == userData.Password && o.UserName == userData.UserName))
                {
                    return RedirectToAction("DashBoard", "Home");
                }
                else
                {
                    return RedirectToAction("ErrorPage");
                }                  
            }
        }

        //Get: ErrorPage
        public ActionResult ErrorPage()
        {
            return View();
        }


        // Get: Register

        public ActionResult Register()
        {
            return View();
        }
        /// <summary>
        ///   Session controller
        /// </summary>
        /// <returns></returns>
        


        public ActionResult SignOut()
        {
            return View();
        }



        // Post: Register
        public ActionResult PostRegiter(User userData)
        {
            using (testEntities msContext = new testEntities())
            {
                msContext.User.Add(userData);
                msContext.SaveChanges();
            }
            return RedirectToAction("Loginuser");
        }







        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        // GET: Login/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Login/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Login/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Login/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Login/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Login/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
