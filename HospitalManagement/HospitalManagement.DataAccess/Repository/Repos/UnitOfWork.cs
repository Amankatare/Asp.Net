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
    public class UnitOfWork : IUnitOfWork
    {
        private readonly AppDbContext _context;
        public UnitOfWork(AppDbContext context) 
        {
            _context = context;
            Doctors = new DoctorRepository(_context);
            Patients = new PatientRepository(_context);
            Appointments = new AppointmentRepository(_context);

        }

        public IDoctorRepository Doctors { get; private set; }

        public IPatientRepository Patients { get; private set; }

        public IAppointmentRepository Appointments {  get;private set; }

        public void Dispose() { _context.Dispose(); }

        public int Save() { return _context.SaveChanges(); }
    }
}
