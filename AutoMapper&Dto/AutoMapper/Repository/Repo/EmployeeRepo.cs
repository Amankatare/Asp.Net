    using AutoMapper_Dto.Data;
    using AutoMapper_Dto.Model;
    using AutoMapper_Dto.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

public class EmployeeRepo : IEmployee
    {
        private readonly DatabaseDBContext _dbContext;

        public EmployeeRepo(DatabaseDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public List<Employee> ReadAll()
        {
            return _dbContext.Employees.ToList();
        }

        [HttpGet]
        public Employee Read(int id)
        {
            return _dbContext.Employees.Find(id);
        }

        [HttpPost]
        public Employee Create(Employee emp)
        {
            _dbContext.Employees.Add(emp);
            _dbContext.SaveChanges();
            return emp;
        }

        [HttpPut]
        public Employee Update(int id, Employee emp)
        {
            var existingEmp = _dbContext.Employees.Find(id);
            if (existingEmp != null)
            {
                existingEmp.Name = emp.Name;
                existingEmp.Phone = emp.Phone;
                existingEmp.Email = emp.Email;
                existingEmp.Salary = emp.Salary;

                _dbContext.SaveChanges();
            }
            return existingEmp;
        }
        [HttpDelete]
        public Employee Delete(int id)
        {
            var empToRemove = _dbContext.Employees.Find(id);
            if (empToRemove != null)
            {
                _dbContext.Employees.Remove(empToRemove);
                _dbContext.SaveChanges();
            }
            return empToRemove;
        }

    
}
