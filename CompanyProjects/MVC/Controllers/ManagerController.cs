using ApplicationServices.DTOs;
using MVC.CompanyService;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ManagerController : Controller
    {
        // GET: Manager
        [Authorize]
        [HttpGet]
        public ActionResult Index(string name)
        {
            List<ManagerViewModel> managerVM = new List<ManagerViewModel>();
            using (Service1Client service = new Service1Client())
            {
                foreach (var item in service.GetManagers())
                {
                    managerVM.Add(new ManagerViewModel(item));
                }
            }
            if (!String.IsNullOrEmpty(name))
            {
                managerVM.Clear();
                using (Service1Client service = new Service1Client())
                {
                    foreach(var item in service.GetAllManagersByName(name))
                    {
                        managerVM.Add(new ManagerViewModel(item));
                    }
                }
                return View(managerVM);
            }

            return View(managerVM);
        }

        [Authorize]
        [HttpGet]
        public ActionResult Details(int id)
        {
            ManagerViewModel managerVM = new ManagerViewModel();
            using (Service1Client service = new Service1Client())
            {
                var managerDto = service.GetManagerById(id);
                managerVM = new ManagerViewModel(managerDto);
            }

            return View(managerVM);
        }
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }
        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(ManagerViewModel managerVM)
        {
            using (Service1Client service = new Service1Client())
            {
                ManagerDto managerDto = new ManagerDto
                {
                    FirstName = managerVM.FirstName,
                    LastName = managerVM.LastName,
                    PhoneNumber = managerVM.PhoneNumber,
                    Email = managerVM.Email,
                    BirthDate = managerVM.BirthDate,
                    Nationality = managerVM.Nationality,
                    Salary = managerVM.Salary
                };
                service.PostManager(managerDto);
            }


            return RedirectToAction("Index");
        }
        [Authorize]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ManagerViewModel managerVM = new ManagerViewModel();
            using (Service1Client service = new Service1Client())
            {
                var managerDto = service.GetManagerById(id);
                managerVM = new ManagerViewModel(managerDto);
            }

            return View(managerVM);
        }
        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(ManagerViewModel managerVM)
        {
            if (ModelState.IsValid)
            {
                using (Service1Client service = new Service1Client())
                {
                    ManagerDto managerDto = new ManagerDto
                    {
                        Id = managerVM.Id,
                        FirstName = managerVM.FirstName,
                        LastName = managerVM.LastName,
                        PhoneNumber = managerVM.PhoneNumber,
                        Email = managerVM.Email,
                        BirthDate = managerVM.BirthDate,
                        Nationality = managerVM.Nationality,
                        Salary = managerVM.Salary
                    };
                    service.PutManager(managerDto);
                }
            }

            return RedirectToAction("Index");
        }

        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            ManagerViewModel managerVM = new ManagerViewModel();
            using (Service1Client service = new Service1Client())
            {
                service.DeleteManager(id);
            }
            return RedirectToAction("Index");
        }
    }
}