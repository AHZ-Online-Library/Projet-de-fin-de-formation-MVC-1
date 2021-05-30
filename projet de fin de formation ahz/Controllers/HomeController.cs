using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projet_de_fin_de_formation_ahz.Models;
namespace projet_de_fin_de_formation_ahz.Controllers
{
    public class HomeController : Controller
    {
        AHZ_Online_libraryEntities1 db = new AHZ_Online_libraryEntities1();
        // GET: Home
        
        public ActionResult Index()
        {
            return View(db.User_Account.ToList()); 
        }
        public ActionResult SignUp()
        {
            return View();

        }

        [HttpPost]
        public ActionResult SignUp(User_Account mstb)
        {
            if (db.User_Account.Any(x=>x.Email==mstb.Email))
            {
                ViewBag.Notification = "this account has already exsisted";

                return View();

            }
            else
            {
                db.User_Account.Add(mstb);
                db.SaveChanges();
              //  Session["Member_idss"] = mstb.Member_id.ToString();
               // Session["full_name"] = mstb.full_name.ToString();
                return RedirectToAction("LogIn", "Home");
            }
           
        }
        public ActionResult logout()
        {

            Session.Clear();
            return RedirectToAction("Index", "Home");
        }
        public ActionResult LogIn()
        {
            return View();
        
        
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
            public ActionResult LogIn(User_Account mstb)
        {

            var checklogin = db.User_Account.Where(x => x.Email.Equals(mstb.Email)&& x.Password_.Equals(mstb.Password_) && x.UserName.Equals(mstb.UserName)).FirstOrDefault();
            if (checklogin != null)
            {

              Session["Member_idss"] = mstb.UserID.ToString();
                Session["full_name"] = mstb.UserName.ToString();

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Notification = "wrong  email or password or user name";
            }
            return View();
         }
        public ActionResult HomePage()
        {
            return View();

        }
        public ActionResult AboutUs()
        {
            return View();

        }

    }
}