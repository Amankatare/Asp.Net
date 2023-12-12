using System.ComponentModel.DataAnnotations.Schema;

namespace AutoMapper_Dto.Dto
{
    public class EmployeeDto
    {
        public string Name { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

       
        public string Salary { get; set; } = string.Empty;
    }
}
