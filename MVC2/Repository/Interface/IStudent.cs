using MVC2.Models;

namespace MVC2.Repository.Interface
{
    public interface IStudent
    {
        Task<Student> CreateStudent(Student s);
        Task<List<Student>> GetStudent();

        Task<Student> deleteStudent(int? id);

        Task<Student> UpdateStudents(Student s);
        object FindStudent(int rollNo);
    }
}
