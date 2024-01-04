using SchoolManagement11.DataAccess.DataContext;
using SchoolManagement11.Domains.Entities;
using SchoolManagement11.Domains.Repository;

namespace SchoolManagement11.DataAccess.imp
{
    public class TeacherRepository : GenericRepository<Teacher>, ITeacherRepository
    {
        public TeacherRepository(SchoolManagement11DbContext context) : base(context)
        {
        }
    }
}
