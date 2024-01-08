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
    public class AppointmentRepository : GenericRepository<Appointment>,IAppointmentRepository
    {
        public AppointmentRepository(AppDbContext options) : base(options) { }
        
    }
}
