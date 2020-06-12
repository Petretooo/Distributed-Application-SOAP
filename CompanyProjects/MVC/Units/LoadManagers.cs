using MVC.CompanyService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Units
{
    public class LoadManagers
    {
        public static SelectList LoadManagersData()
        {
            using (Service1Client service = new Service1Client())
            {
                return new SelectList(service.GetManagers(), "Id", "FirstName");
            }
        }
    }
}