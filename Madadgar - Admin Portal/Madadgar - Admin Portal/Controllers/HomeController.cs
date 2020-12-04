using Madadgar___Admin_Portal.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Madadgar___Admin_Portal.Controllers
{
    public class HomeController : Controller
    {

        [Authorize]
        public ActionResult Index()
        {
            return View();
        }

        //public ActionResult Login()
        //{
        //    ViewBag.Message = "Admin Login Page.";

        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Login(Admin model, string returnUrl)
        //{
        //    Entities db = new Entities();
        //    //var dataItem = db.Admins.Where()
        //    var dataItem = db.Admins.Where(x => x.username == model.username && x.password_2 == model.password_2).First();
        //    if (dataItem != null)
        //    {
        //        FormsAuthentication.SetAuthCookie(dataItem.username, false);
        //        if (Url.IsLocalUrl(returnUrl) && returnUrl.Length > 1 && returnUrl.StartsWith("/")
        //                 && !returnUrl.StartsWith("//") && !returnUrl.StartsWith("/\\"))
        //        {
        //            return Redirect(returnUrl);
        //        }
        //        else
        //        {
        //            return RedirectToAction("Index");
        //        }
        //    }
        //    else
        //    {
        //        ModelState.AddModelError("", "Invalid user/pass");
        //        return View();
        //    }
        //}
    }
}