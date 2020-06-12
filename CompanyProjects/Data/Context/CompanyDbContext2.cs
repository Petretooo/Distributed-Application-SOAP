using Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class CompanyDbContext2 : DbContext
    {
        public DbSet<Employee> employees { get; set; }
        public DbSet<Manager> managers { get; set; }
        public DbSet<Project> projects { get; set; }
        public DbSet<ProjectEmployee> ProjectEmployees { get; set; }



        /*        public CompanyDbContext()
                   : base("Server=DESKTOP-0GFNG5S;Database=CompanyDB;Trusted_Connection=True;")
                {
                    employees = this.Set<Employee>();
                    managers = this.Set<Manager>();
                    projects = this.Set<Project>();
                    ProjectEmployees = this.Set<ProjectEmployee>();
                }

                protected override void OnModelCreating(DbModelBuilder modelBuilder)
                {
                    modelBuilder.Entity<ProjectEmployee>().HasKey(pe => new { pe.id_project, pe.id_employee });
                }
        */
    }
}
