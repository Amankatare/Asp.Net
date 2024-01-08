using AutoMapper;
using HospitalManagement.DataAccess.Repository.Interfaces;
using HospitalManagement.DataAccess.Repository.Repos;

namespace HospitalManagement.API.Mapping
{
    public class Mapper:Profile
    {
        public Mapper()
        {
            CreateMap<IDoctorRepository,DoctorRepository>().ReverseMap();
            CreateMap<IPatientRepository, PatientRepository>().ReverseMap();
            CreateMap<IAppointmentRepository,AppointmentRepository>().ReverseMap();

        }
    }
}
