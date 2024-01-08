using HospitalManagement.DataAccess.Repository.Interfaces;
using HospitalManagement.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public DoctorsController(IUnitOfWork unitOfWork)
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
            _unitOfWork.Doctors.Get(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateAction(Doctor doctor)
        {
            _unitOfWork.Doctors.addEntity(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok();
        }

        [HttpPost("Multiple")]
        public IActionResult CreateMultipleAction(List<Doctor> doctor)
        {
           List<Doctor> doc= _unitOfWork.Doctors.addMultipleEntities(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok(doc);
        }

        [HttpPut]
        public IActionResult UpdateAction(Doctor doctor)
        {
            _unitOfWork.Doctors.updateEntity(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok(doctor);
        }

        [HttpPut("Multiple")]
        public IActionResult UpdateMultipleAction(List<Doctor> doctor)
        {
            List<Doctor> doc = _unitOfWork.Doctors.updateMultipleEntities(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok(doc);
        }

        [HttpDelete]
        public IActionResult DeleteAction(int doctor)
        {
            _unitOfWork.Doctors.deleteEntity(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok();
        }

        [HttpDelete("Multiple")]
        public IActionResult DeleteMultipleAction(List<Doctor> doctor)
        {
            List<Doctor> doc = _unitOfWork.Doctors.deleteMultipleEntities(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();

            return Ok(doc);
        }
    }
}
