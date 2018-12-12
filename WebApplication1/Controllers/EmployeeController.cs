﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ViewModel;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            EmployeeListViewModel empListModel = new EmployeeListViewModel();
            //实例化员工信息业务层
            EmployeeBusinessLayer empBai = new EmployeeBusinessLayer();

            var listEmp = empBai.GetEmployeeList();

            var listEmpVm = new List<EmployeeViewModel>();
            foreach (Employee emp in listEmp)
            {
                EmployeeViewModel empViewModel = new EmployeeViewModel();
                empViewModel.EmployeeName = emp.Name;
                empViewModel.EmployeeSalary = emp.Salary.ToString("C");
                if (emp.Salary > 10000)
                {
                    empViewModel.EmployeeGrade = "土豪";
                }
                else
                {
                    empViewModel.EmployeeGrade = "屌丝";
                }
                listEmpVm.Add(empViewModel);
              
            }
            return View(empListModel);
        }
    }
}