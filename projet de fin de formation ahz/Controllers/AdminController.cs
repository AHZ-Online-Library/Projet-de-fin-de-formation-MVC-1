using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using projet_de_fin_de_formation_ahz.Models;

namespace projet_de_fin_de_formation_ahz.Controllers
{

    public class AdminController : Controller
    {
        AHZ_Online_libraryEntities2 db1 = new AHZ_Online_libraryEntities2();
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public ActionResult Login_Admin()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login_Admin(Admin_Account AA)
        {
             var checklogin = db1.Admin_Account.Where(x => x.Email.Equals(AA.Email) && x.Password_.Equals(AA.Password_) && x.Admin_Name.Equals(AA.Admin_Name)).FirstOrDefault();
            if (checklogin != null)
            {

                Session["AdminIDs"] = AA.AdminID.ToString();
                Session["full_name"] = AA.Admin_Name.ToString();

                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Notification = "wrong  email or password or admin name";
            }
            return View();


        }
    }
}