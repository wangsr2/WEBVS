using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TxtController : Controller
    {
        // GET: Txt
        public ActionResult GetView()
        {
            Employee emp = new Employee();
            emp.Name = "威廉. 莎士比亚";
            ViewBag.empKey = emp;
            return View(emp);

        }
        
    }
}