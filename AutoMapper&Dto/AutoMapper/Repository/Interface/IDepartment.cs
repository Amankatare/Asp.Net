using AutoMapper_Dto.Model;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper_Dto.Repository.Interface
{
    public interface IDepartment
    {
        public List<Department> ReadAll();

        public Department Read(int id);

        public Department Create(Department dept);

        public Department Update(int id,Department dept) ;
        public Employee Delete(int id);
    }
}


