using Data.Context;
using Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementations
{
    public class CompanyRepo : IDisposable
    {
        // Context and tables
        private CompanyDbContext2 context = new CompanyDbContext2();
        private GenericRepository<Employee> employeeRepository;
        private GenericRepository<Manager> managerRepository;
        private GenericRepository<Project> projectRepository;
        private GenericRepository<ProjectEmployee> projectEmployeeRepository;

        public GenericRepository<Employee> EmployeeRepository
        {
            get
            {

                if (this.employeeRepository == null)
                {
                    this.employeeRepository = new GenericRepository<Employee>(context);
                }
                return employeeRepository;
            }
        }

        public GenericRepository<Manager> ManagerRepository
        {
            get
            {

                if (this.managerRepository == null)
                {
                    this.managerRepository = new GenericRepository<Manager>(context);
                }
                return managerRepository;
            }
        }

        public GenericRepository<Project> ProjectRepository
        {
            get
            {

                if (this.projectRepository == null)
                {
                    this.projectRepository = new GenericRepository<Project>(context);
                }
                return projectRepository;
            }
        }

        public GenericRepository<ProjectEmployee> ProjectEmployeeRepository
        {
            get
            {

                if (this.projectEmployeeRepository == null)
                {
                    this.projectEmployeeRepository = new GenericRepository<ProjectEmployee>(context);
                }
                return projectEmployeeRepository;
            }
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
