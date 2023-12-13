using AutoMapper;
using AutoMapper_Dto.Data;
using AutoMapper_Dto.Dto;
using AutoMapper_Dto.Model;
using AutoMapper_Dto.Repository.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper_Dto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly DatabaseDBContext _dbContext;
        private readonly IMapper _mapper;
        public EmployeesController(DatabaseDBContext dbContext, IMapper mapper)
        {

            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var employee = _dbContext.Employees.ToList();

            var employeesDto = _mapper.Map<List<EmployeeDto>>(employee);

            return Ok(employeesDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {
            var employee = _dbContext.Employees.Find(id);

            var employeesDto = _mapper.Map<EmployeeDto>(employee);

            return Ok(employeesDto);
        }

        [HttpPost]
        public IActionResult Post(Employee emp)
        {
            var employee = _dbContext.Employees.Add(emp);
            _dbContext.SaveChanges();
            return Ok(employee);
        }



        [HttpPut("{id}")]
        public IActionResult Put(int id, Employee emp)
        {
            var existingEmployee = _dbContext.Employees.Find(id);
            if (existingEmployee == null)
            {
                return NotFound();
            }

            //Method 1 :-
            //By assigning all the properties one by one
            existingEmployee.Name = emp.Name;

            existingEmployee.Phone = emp.Phone;

            existingEmployee.Email = emp.Email;

            existingEmployee.Salary = emp.Salary;


            // Method 2 :-
            // Update all properties of the existing entity with values from the input 'emp'
            // _dbContext.Entry(existingEmployee).CurrentValues.SetValues(emp);

            _dbContext.SaveChanges();

            return Ok(existingEmployee);
        }

        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            var emp = _dbContext.Employees.Find(id);
            if (emp != null)
            {
                var employee = _dbContext.Employees.Remove(emp);
                _dbContext.SaveChanges();
                return Ok(employee);
            }

            return NotFound();

        }
    }
}

