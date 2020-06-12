using ApplicationServices.DTOs;
using MVC.CompanyService;
using MVC.Units;
using MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class ProjectEmployeeController : Controller
    {
        // GET: ProjectEmployee
        [HttpGet]
        [Authorize]
        public async Task<ActionResult> Index(string name)
        {
            List<ProjectEmployeeViewModel> peVM = new List<ProjectEmployeeViewModel>();
            using (Service1Client service = new Service1Client())
            {
                foreach (var item in service.GetProjectEmployees())
                {
                    peVM.Add(new ProjectEmployeeViewModel(item));
                }
            }
            if (!String.IsNullOrEmpty(name))
            {
                peVM.Clear();
                using (Service1Client service = new Service1Client())
                {
                    foreach (var item in service.GetAllProjectEmployeeByName(name))
                    {
                        peVM.Add(new ProjectEmployeeViewModel(item));
                    }
                }
                return View(peVM);
            }
            return View(peVM);
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> Details(int id)
        {
            ProjectEmployeeViewModel peVM = new ProjectEmployeeViewModel();
            using (Service1Client service = new Service1Client())
            {
                var peDto = service.GetProjectEmployeeById(id);
                peVM = new ProjectEmployeeViewModel(peDto);
            }
            return View(peVM);
        }

        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            using (Service1Client service = new Service1Client())
            {
                ViewBag.Projects = new SelectList(service.GetProjects(), "Id", "Name");
                ViewBag.Employees = new SelectList(service.GetEmployees(), "Id", "FirstName");
            }
            return View();
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(ProjectEmployeeViewModel peVM)
        {
            try
            {
                using (Service1Client service = new Service1Client())
                {
                    ProjectEmployeeDto peDto = new ProjectEmployeeDto
                    {
                        id_project = peVM.projectID,
                        projectDto = new ProjectDto 
                        {   
                            Id = peVM.projectID
                        },
                        id_employee = peVM.employeeId,
                        employeeDto = new EmployeeDto
                        {
                            Id = peVM.employeeId
                        }
                    };
                    service.PostProjectEmployee(peDto);
                }
                ViewBag.Projects = LoadProjects.LoadProjectsData();
                ViewBag.Employees = LoadEmployees.LoadEmployeesData();
                return RedirectToAction("Index");
            }
            catch
            {
                ViewBag.Projects = LoadProjects.LoadProjectsData();
                ViewBag.Employees = LoadEmployees.LoadEmployeesData();
                return View();
            }
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult> Edit(int id)
        {
            ProjectEmployeeViewModel peVM = new ProjectEmployeeViewModel();
            using (Service1Client service = new Service1Client())
            {
                var peDto = service.GetProjectEmployeeById(id);
                peVM = new ProjectEmployeeViewModel(peDto);
            }
            ViewBag.Projects = LoadProjects.LoadProjectsData();
            ViewBag.Employees = LoadEmployees.LoadEmployeesData();
            return View(peVM);
        }

        [HttpPost]
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(ProjectEmployeeViewModel peVM)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (Service1Client service = new Service1Client())
                    {
                        ProjectEmployeeDto peDto = new ProjectEmployeeDto
                        {
                            Id = peVM.Id,
                            id_project = peVM.projectID,
                            projectDto = new ProjectDto
                            {
                                Id = peVM.projectID
                            },
                            id_employee = peVM.employeeId,
                            employeeDto = new EmployeeDto
                            {
                                Id = peVM.employeeId
                            }
                        };
                        service.PutProjectEmployee(peDto);
                    }
                    ViewBag.Projects = LoadProjects.LoadProjectsData();
                    ViewBag.Employees = LoadEmployees.LoadEmployeesData();
                    return RedirectToAction("Index");
                }
                ViewBag.Projects = LoadProjects.LoadProjectsData();
                ViewBag.Employees = LoadEmployees.LoadEmployeesData();
                return View();
            }
            catch
            {
                ViewBag.Projects = LoadProjects.LoadProjectsData();
                ViewBag.Employees = LoadEmployees.LoadEmployeesData();
                return View();
            }
        }
        [Authorize]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Delete(int id)
        {
            ProjectEmployeeViewModel peVM = new ProjectEmployeeViewModel();
            using (Service1Client service = new Service1Client())
            {
                service.DeleteProjectEmployee(id);
            }

            return RedirectToAction("Index");
        }
    }
}