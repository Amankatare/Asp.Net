using AutoMapper;
using AutoMapper_Dto.Dto;
using AutoMapper_Dto.Model;
using AutoMapper_Dto.Repository.Interface;
using AutoMapper_Dto.Repository.Repo;

namespace AutoMapper_Dto.AutoMapper
{
    //using AutoMapper by extending Profile
    public class Mapper:Profile
    {
        public Mapper()
        {
            //for mapping:- 

            // Interface -> Repo
            CreateMap<IEmployee, EmployeeRepo>();
            CreateMap<IDepartment,DepartmentRepo>();

            // Model->Dto
            CreateMap<Employee, EmployeeDto>().ReverseMap();
            CreateMap<Department, DepartmentDto>().ReverseMap();


        }

     
    }
}
