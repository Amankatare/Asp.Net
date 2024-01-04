using SchoolManagement11.Domains.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagement11.Domains.Repository
{
    public interface IStudentRepository : IGenericRepository<Student>
    {

        public IEnumerable<Student> GetStudentWithTeacher();
    }
}
