using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            List<Employee> emp = new List<Employee>()
            {
                new Employee
                {
                ID = 101,
                Name="Shivaji",
                Age="26"
                }
            };
            TempData["EmployeeDetails"]= emp;
            return View();
        }
    }
}
