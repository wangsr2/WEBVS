using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public ActionResult Index()
        {
            return View();
        }

        public string GetString()
        {
            return "测试测试！";
        }
        public Customer getCustomer()
        {
            Customer ct = new Customer();
            ct.CustomerName = "bbb";
            ct.Adddress = "anaa";
            return ct;
        }
        public ActionResult GetView()
        {
            string greeting;
            //获取当前时间
            DateTime dt = DateTime.Now;

            //获取当前小时数
            int hour = dt.Hour;
            //根据小时数判断需要返回哪个视图
            if (hour < 12)
            {
              greeting="早上好";
            }
            else
            {
              greeting ="下午好";
            }
            ViewData["greeting"] = greeting;
            Employee emp = new Employee();
            emp.Name = "混蛋";
            emp.Salary = 20002;
            ViewBag.EmpKey = emp;
            return View("MyView",emp);

        }
    }
}