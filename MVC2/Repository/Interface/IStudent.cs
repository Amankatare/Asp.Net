using MVC2.Models;

namespace MVC2.Repository.Interface
{
    public interface IStudent
    {
        Task<Student> CreateStudent(Student s);
        Task<List<Student>> GetStudent();

        Task<Student> deleteStudent(int? id);
    }
}
