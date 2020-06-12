using ApplicationServices.DTOs;
using Microsoft.Ajax.Utilities;
using MVC.CompanyService;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.WebPages;

namespace MVC.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee

        [Authorize]
        [HttpGet]
        public async Task<ActionResult> Index(string name)
        {
            List<EmployeeViewModel> employeeVM = new List<EmployeeViewModel>();
            using (Service1Client service = new Service1Client())
            {
                foreach (var item in service.GetEmployees())
                {
                    employeeVM.Add(new EmployeeViewModel(item));
                }
            }

            if (!String.IsNullOrEmpty(name))
            {
                employeeVM.Clear();
                using (Service1Client service = new Service1Client())
                {
                    foreach (var item in service.GetAllEmployeesByName(name))
                    {
                        employeeVM.Add(new EmployeeViewModel(item));
                    }
                }
                return View(employeeVM);
            }


            return View(employeeVM);
            
            //return View(employeeVM);
        }
        [Authorize]
        [HttpGet]
        public async Task<ActionResult> Details(int id)
        {
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            using (Service1Client service = new Service1Client())
            {
                var employeeDto = service.GetEmployeeById(id);
                employeeVM = new EmployeeViewModel(employeeDto);
            }
            return View(employeeVM);
        }
        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<ActionResult> Create(EmployeeViewModel employeeVM)
        {
            using (Service1Client service = new Service1Client())
            {
                EmployeeDto employeeDto = new EmployeeDto
                {
                    FirstName = employeeVM.FirstName,
                    LastName = employeeVM.LastName,
                    PhoneNumber = employeeVM.PhoneNumber,
                    Email = employeeVM.Email,
                    BirthDate = (DateTime)employeeVM.BirthDate,
                    Position = employeeVM.Position,
                    Salary = employeeVM.Salary
                };
                service.PostEmployee(employeeDto);
            }

            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public async Task<ActionResult> Edit(int id)
        {
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            using (Service1Client service = new Service1Client())
            {
                var employeeDto = service.GetEmployeeById(id);
                employeeVM = new EmployeeViewModel(employeeDto);
            }

                return View(employeeVM);
        }

        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<ActionResult> Edit(EmployeeViewModel employeeVM)
        {
            if (ModelState.IsValid)
            {
                using (Service1Client service = new Service1Client())
                {
                    EmployeeDto employeeDto = new EmployeeDto
                    {
                        Id = employeeVM.Id,
                        FirstName = employeeVM.FirstName,
                        LastName = employeeVM.LastName,
                        PhoneNumber = employeeVM.PhoneNumber,
                        Email = employeeVM.Email,
                        BirthDate = (DateTime)employeeVM.BirthDate,
                        Position = employeeVM.Position,
                        Salary = employeeVM.Salary
                    };
                    service.PutEmployee(employeeDto);
                }
            }

            return RedirectToAction("Index");
        }

        [Authorize]
        public async Task<ActionResult> Delete(int id)
        {
            EmployeeViewModel employeeVM = new EmployeeViewModel();
            using (Service1Client service = new Service1Client())
            {
                service.DeleteEmployee(id);
            }

            return RedirectToAction("Index");
        }

    }
}