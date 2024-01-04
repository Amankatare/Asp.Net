using SchoolManagement11.DataAccess.DataContext;
using SchoolManagement11.Domains.Repository;

namespace SchoolManagement11.DataAccess.imp
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly SchoolManagement11DbContext _context;
        public UnitOfWork(SchoolManagement11DbContext context)
        {
            _context = context;
            Student = new StudentRepository(_context);
            Teacher = new TeacherRepository(_context);
            StudentActivity = new StudentActivityRepository(_context);

        }

        public IStudentRepository Student { get; private set; }

        public ITeacherRepository Teacher { get; private set; }

        public IStudentActivityRepository StudentActivity { get; private set; }

        public int Save() { return _context.SaveChanges(); }
        public void Dispose() { _context.Dispose(); }

    }
}
