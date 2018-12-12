using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employee> GetEmployeeList()
        {
            var list = new List<Employee>();
            //List<Employees> employees = new List<Employee>();
            Employee emp = new Employee();
            emp.Name = "张三";
            emp.Salary = 14000;
            list.Add(emp);

            emp = new Employee();
            emp.Name = "李四";
            emp.Salary = 1000;
            list.Add(emp);

            emp = new Employee();
            emp.Name = "王五";
            emp.Salary = 2000;
            list.Add(emp);
            return list;
        }
    }
}