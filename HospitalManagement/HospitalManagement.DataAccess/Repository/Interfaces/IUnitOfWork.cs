using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagement.DataAccess.Repository.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IDoctorRepository Doctors {  get; }

        IPatientRepository Patients { get; }

        IAppointmentRepository Appointments { get; }

        public void Dispose();

        public int Save();
    }
}
