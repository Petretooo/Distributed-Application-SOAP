using MVC.CompanyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Units
{
    public class LoadEmployees
    {
        public static SelectList LoadEmployeesData()
        {
            using (Service1Client service = new Service1Client())
            {
                return new SelectList(service.GetEmployees(), "Id", "FirstName");
            }
        }
    }
}