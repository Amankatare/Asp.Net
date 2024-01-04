using SchoolManagement11.DataAccess.DataContext;
using SchoolManagement11.Domains.Entities;
using SchoolManagement11.Domains.Repository;

namespace SchoolManagement11.DataAccess.imp
{
    public class StudentRepository : GenericRepository<Student>, IStudentRepository
    {
        public StudentRepository(SchoolManagement11DbContext context) : base(context)
        {
        }

        public IEnumerable<Student> GetStudentWithTeacher()
        {
            throw new NotImplementedException();
        }

        /*
        public IEnumerable<Student> GetStudentWithTeacher()
        {
            var students = _context.Students;
            return students;
        }
        */
    }
}
