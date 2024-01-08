using HospitalManagement.DataAccess.Data;
using HospitalManagement.DataAccess.Repository.Interfaces;
using HospitalManagement.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.DataAccess.Repository.Repos
{
    public class PatientRepository : GenericRepository<Patient>, IPatientRepository
    {
        public PatientRepository(AppDbContext options) : base(options) { }
    
    }
}
