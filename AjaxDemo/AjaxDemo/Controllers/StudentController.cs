using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxDemo.Models;
using Newtonsoft.Json;

namespace AjaxDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetStudent()
        {
            Student std = new Student()
            {
                StdID = 1001,
                StdName = "Shivaji",
                StdEmail = "ShivajiSul@gmail.com"
            };
            var _std = JsonConvert.SerializeObject(std);
            return Json(_std,JsonRequestBehavior.AllowGet);
        }
    }
}