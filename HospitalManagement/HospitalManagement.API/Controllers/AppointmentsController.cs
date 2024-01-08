using HospitalManagement.DataAccess.Repository.Interfaces;
using HospitalManagement.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppointmentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public AppointmentsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAllAction()
        {
            _unitOfWork.Doctors.getAll();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdAction(int id)
        {
            _unitOfWork.Appointments.Get(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateAction(Appointment doctor)
        {
            _unitOfWork.Appointments.addEntity(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok();
        }

        [HttpPost("Multiple")]
        public IActionResult CreateMultipleAction(List<Appointment> doctor)
        {
           List<Appointment> doc= _unitOfWork.Appointments.addMultipleEntities(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok(doc);
        }

        [HttpPut]
        public IActionResult UpdateAction(Appointment doctor)
        {
            _unitOfWork.Appointments.updateEntity(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok(doctor);
        }

        [HttpPut("Multiple")]
        public IActionResult UpdateMultipleAction(List<Appointment> doctor)
        {
            List<Appointment> doc = _unitOfWork.Appointments.updateMultipleEntities(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok(doc);
        }

        [HttpDelete]
        public IActionResult DeleteAction(int doctor)
        {
            _unitOfWork.Appointments.deleteEntity(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok();
        }

        [HttpDelete("Multiple")]
        public IActionResult DeleteMultipleAction(List<Appointment> doctor)
        {
            List<Appointment> doc = _unitOfWork.Appointments.deleteMultipleEntities(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok(doc);
        }
    }
}
