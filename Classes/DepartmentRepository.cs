using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class DepartmentRepository
    {
        private readonly UniversityDBContext dbContext;

        public DepartmentRepository(UniversityDBContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IQueryable<Department> GetAllDepartments()
        {
            return dbContext.Departments;
        }

        public Department GetDepartmentById(int departmentId)
        {
            return dbContext.Departments.FirstOrDefault(d => d.Id == departmentId);
        }

        public void AddDepartment(Department department)
        {
            dbContext.Departments.Add(department);
            dbContext.SaveChanges();
        }

        public void UpdateDepartment(Department updatedDepartment)
        {
            var existingDepartment = dbContext.Departments.FirstOrDefault(d => d.Id == updatedDepartment.Id);

            if (existingDepartment != null)
            {
                existingDepartment.Name = updatedDepartment.Name;
                existingDepartment.Description = updatedDepartment.Description;

                dbContext.SaveChanges();
            }
        }

        public void DeleteDepartment(int departmentId)
        {
            var departmentToDelete = dbContext.Departments.FirstOrDefault(d => d.Id == departmentId);

            if (departmentToDelete != null)
            {
                dbContext.Departments.Remove(departmentToDelete);
                dbContext.SaveChanges();
            }
        }
    }
}
