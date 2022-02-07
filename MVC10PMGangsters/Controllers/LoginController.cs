using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC10PMGangsters.Models;
using System.Web.Security;

namespace MVC10PMGangsters.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login

        LoginEntities db = new LoginEntities();
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(UserDetail userLogin)
        {
            UserDetail user = db.UserDetails.Where(s => s.UserName == userLogin.UserName && s.Password == userLogin.Password).SingleOrDefault();

            if (user != null)
            {
                FormsAuthentication.SetAuthCookie(userLogin.UserName, false);
                return Redirect("~/Login/DashBoard");
            }
            else
            {
                return View();
            }
        }

        [Authorize(Roles = "Admin,Manager")]//prema
        public ActionResult DashBoard()
        {
            return View();
        }


        [Authorize(Roles ="Admin")]//prema
        public ActionResult ContactUS()
        {
            return View();
        }



        [Authorize(Roles="Manager")]//nitish
        public ActionResult AboutUs()
        {
            return View();
        }



        public ActionResult SignOut()
        {
            FormsAuthentication.SignOut();
            return Redirect("~/Login/Login");
        }
    }
}