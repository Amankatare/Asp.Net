using AutoMapper;
using AutoMapper_Dto.Data;
using AutoMapper_Dto.Dto;
using AutoMapper_Dto.Model;
using AutoMapper_Dto.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapper_Dto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {

        private readonly DatabaseDBContext _dbContext;
        private readonly IMapper _mapper;
        public DepartmentsController(DatabaseDBContext dbContext,IMapper mapper)
        {
          
            _dbContext = dbContext;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var department = _dbContext.Departments.ToList();

            var departmentsDto = _mapper.Map<List<DepartmentDto>>(department);
            
                return Ok(departmentsDto);
        }

        [HttpGet("{id}")]
        public IActionResult GetbyId(int id)
        {
            var department = _dbContext.Departments.Find(id);

            var departmentsDto = _mapper.Map<DepartmentDto>(department);

            return Ok(departmentsDto);
        }
        
        [HttpPost]
        public IActionResult Post(Department dept)
        {
            var department = _dbContext.Departments.Add(dept);
            _dbContext.SaveChanges();
            return Ok(department);
        }

        

        [HttpPut("{id}")]
        public IActionResult Put(int id,Department dept)
        {
            var existingDepartment = _dbContext.Departments.Find(id);
            if(existingDepartment == null)
            {
                return NotFound();  
            }

            //Method 1 :-
            //By assigning all the properties one by one
            existingDepartment .Name = dept.Name;
            existingDepartment.Location = dept.Location ;

            // Method 2 :-
            // Update all properties of the existing entity with values from the input 'dept'
            // _dbContext.Entry(existingDepartment).CurrentValues.SetValues(dept);
            
            _dbContext.SaveChanges();

            return Ok(existingDepartment);
        }
        
        [HttpDelete("{id}")]
        public IActionResult delete(int id)
        {
            var dept = _dbContext.Departments.Find(id);
            if (dept != null) {
                var department = _dbContext.Departments.Remove(dept);
                _dbContext.SaveChanges();
                return Ok(department);
            }

            return NotFound();

            }
        }
}
