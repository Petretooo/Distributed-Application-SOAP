using ApplicationServices.DTOs;
using MVC.CompanyService;
using MVC.Units;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        [Authorize]
        [HttpGet]
        public ActionResult Index(string name)
        {
            List<ProjectViewModel> projectVM = new List<ProjectViewModel>();
            using (Service1Client service = new Service1Client())
            {
                foreach(var item in service.GetProjects())
                {
                    projectVM.Add(new ProjectViewModel(item));
                }
            }
            if (!String.IsNullOrEmpty(name))
            {
                projectVM.Clear();
                using (Service1Client service = new Service1Client())
                {
                    foreach (var item in service.GetAllProjectsByName(name))
                    {
                        projectVM.Add(new ProjectViewModel(item));
                    }
                }
                return View(projectVM);
            }

            return View(projectVM);
        }
        [Authorize]
        [HttpGet]
        public ActionResult Details(int id)
        {
            ProjectViewModel projectVM = new ProjectViewModel();
            using (Service1Client service = new Service1Client())
            {
                var projectDto = service.GetProjectById(id);
                projectVM = new ProjectViewModel(projectDto);
            }
            return View(projectVM);
        }
        [Authorize]
        [HttpGet]
        public ActionResult Create()
        {
            using (Service1Client service = new Service1Client())
            {
                ViewBag.Managers = new SelectList(service.GetManagers(), "Id", "FirstName");
            }
                return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProjectViewModel projectVM)
        {
            try
            {
                using (Service1Client service = new Service1Client())
                {
                    ProjectDto projectDto = new ProjectDto
                    {
                        Name = projectVM.Name,
                        Description = projectVM.Description,
                        Created = projectVM.Created,
                        Client = projectVM.Client,
                        Price = projectVM.Price,
                        managerId = projectVM.managerId,
                        managerDto = new ManagerDto
                        {
                            Id = projectVM.managerId,
                        }
                    };
                    service.PostProject(projectDto);
                }
                ViewBag.Managers = LoadManagers.LoadManagersData();
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Managers = LoadManagers.LoadManagersData();
                return View();
            }
        }
        [Authorize]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            ProjectViewModel projctVM = new ProjectViewModel();
            using (Service1Client service = new Service1Client())
            {
                var projectDto = service.GetProjectById(id);
                projctVM = new ProjectViewModel(projectDto);
            }

            ViewBag.Managers = LoadManagers.LoadManagersData();
            return View(projctVM);
        }
        [Authorize]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Edit(ProjectViewModel projectVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Service1Client service = new Service1Client())
                    {
                        ProjectDto projectDto = new ProjectDto
                        {
                            Id = projectVM.Id,
                            Name = projectVM.Name,
                            Description = projectVM.Description,
                            Created = projectVM.Created,
                            Client = projectVM.Client,
                            Price = projectVM.Price,
                            managerId = projectVM.managerId,
                            managerDto = new ManagerDto
                            {
                                Id = projectVM.managerId,
                            }
                           
                        };
                        service.PutProject(projectDto);
                    }
                    ViewBag.Managers = LoadManagers.LoadManagersData();
                    return RedirectToAction("Index");
                }
                ViewBag.Managers = LoadManagers.LoadManagersData();
                return View();
            }
            catch
            {
                ViewBag.Managers = LoadManagers.LoadManagersData();
                return View();
            }
        }
        [Authorize]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            ProjectViewModel projectVM = new ProjectViewModel();
            using (Service1Client service = new Service1Client())
            {
                service.DeleteProject(id);
            }
            return RedirectToAction("Index");
        }

    }
}