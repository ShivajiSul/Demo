using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using RestSharp;

namespace StateManageDemo.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Log()
        {
            //Session.Remove("User");
            HttpContext.Application.Remove("User");
            return View("Index");
        }
        [HttpPost]
        public ActionResult Index(FormCollection form)
        {
            string UserText = form["UserText"].ToString();
            string UserPass = form["UserPass"].ToString();
            if (UserText == "Shivaji" && UserPass == "12345")
            {
                //By Default cookie is non persistance means once we close browser cookie will vanished.
                //HttpCookie kt = new HttpCookie("User", UserText);
                //By Default cookie is persistance means permenent cookie will store on hard disk.
                //kt.Expires = DateTime.Now.AddSeconds(30);
                // Response.Cookies.Add(kt);

                //Session["User"] = UserText;
                HttpContext.Application["User"] = UserText;
                return RedirectToAction("Index", "Welcome");
            }

            else 
            { 
                return View(); 
            }
            
        }
    }
}

// cookie are created on client machine only store small amount of data (only 4kb data can store)
// while session are created on server machine will be used for storing big data and also confidential information.