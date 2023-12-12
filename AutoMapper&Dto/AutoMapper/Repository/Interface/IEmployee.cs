using AutoMapper_Dto.Model;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper_Dto.Repository.Interface
{
    public interface IEmployee
    {
        public List<Employee> ReadAll();

        public Employee Read(int id);

        public Employee Create(Employee emp);
        public Employee Update(int id,Employee emp);
        public Employee Delete(int id);
    }
}
