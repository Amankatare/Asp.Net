using System.ComponentModel.DataAnnotations.Schema;

namespace AutoMapper_Dto.Model
{
    public class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty;

        public decimal Salary { get; set; }

        public int DepartmentId { get; set; }

        public Department Department { get; set; }


    }
}
