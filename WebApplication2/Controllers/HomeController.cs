using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string id)
        {
            TempData["value"] = id;
            TempData.Keep("value");
            return View();
        }
        public ActionResult Display()
        {
            return View();
        }
        public ActionResult EmpDeptt()
        {
            EmpDept ed = new EmpDept {DepartmentName="Computer Science",Firstname="Shivam" };
            
            return View(ed);
        }
    }
}