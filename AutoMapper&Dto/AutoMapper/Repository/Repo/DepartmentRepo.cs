using AutoMapper_Dto.Data;
using AutoMapper_Dto.Model;
using AutoMapper_Dto.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AutoMapper_Dto.Repository.Repo
{
    public class DepartmentRepo:IDepartment
    {
        private readonly DatabaseDBContext _dbContext;
        public DepartmentRepo( DatabaseDBContext dbContext)
        {
            
            _dbContext = dbContext;
        }

        [HttpGet]
        public List<Department> ReadAll()
        {
            return _dbContext.Departments.ToList();
        }

        [HttpGet]
        public Department Read(int id)
        {
            return _dbContext.Departments.Find(id);
        }
        
        [HttpPost]
        public Department Create(Department dept)
        {
            _dbContext.Departments.Add(dept);
            _dbContext.SaveChanges();
            return dept;
        }
        
        [HttpPut]
        public Department Update(int id, Department dept)
        {
            var existingDept = _dbContext.Departments.Find(id);
            if (existingDept != null)
            {
                existingDept.Name = dept.Name;
                existingDept.Location = dept.Location;

                _dbContext.SaveChanges();
            }
            return existingDept;
        }
        
        [HttpDelete]
        public Employee Delete(int id)
        {
            var employeeToRemove = _dbContext.Employees.Find(id);

            if (employeeToRemove != null)
            {
                _dbContext.Employees.Remove(employeeToRemove);
                _dbContext.SaveChanges();
            }

            return employeeToRemove;
        }
    }
}
