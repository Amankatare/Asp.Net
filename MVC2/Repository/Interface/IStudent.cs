using Microsoft.AspNetCore.Mvc.ModelBinding;
using MVC2.Models;

namespace MVC2.Repository.Interface
{
    public interface IStudent
    {
        Task<Student> CreateStudent(Student s, ModelStateDictionary ModelState);
        Task<List<Student>> GetStudent();

        Task<Student> deleteStudent(int? id);

        Task<Student> UpdateStudents(Student s, ModelStateDictionary ModelState);
        object FindStudent(int rollNo);
    }
}
