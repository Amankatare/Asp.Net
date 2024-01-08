using HospitalManagement.DataAccess.Repository.Interfaces;
using HospitalManagement.Entities.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HospitalManagement.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public PatientsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public IActionResult GetAllAction()
        {
            _unitOfWork.Patients.getAll();
            
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult GetByIdAction(int id)
        {
            _unitOfWork.Patients.Get(id);
            return Ok();
        }

        [HttpPost]
        public IActionResult CreateAction(Patient doctor)
        {
            _unitOfWork.Patients.addEntity(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok();
        }

        [HttpPost("Multiple")]
        public IActionResult CreateMultipleAction(List<Patient> doctor)
        {
           List<Patient> doc= _unitOfWork.Patients.addMultipleEntities(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok(doc);
        }

        [HttpPut]
        public IActionResult UpdateAction(Patient doctor)
        {
            _unitOfWork.Patients.updateEntity(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok(doctor);
        }

        [HttpPut("Multiple")]
        public IActionResult UpdateMultipleAction(List<Patient> doctor)
        {
            List<Patient> doc = _unitOfWork.Patients.updateMultipleEntities(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok(doc);
        }

        [HttpDelete]
        public IActionResult DeleteAction(int doctor)
        {
            _unitOfWork.Patients.deleteEntity(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok();
        }

        [HttpDelete("Multiple")]
        public IActionResult DeleteMultipleAction(List<Patient> doctor)
        {
            List<Patient> doc = _unitOfWork.Patients.deleteMultipleEntities(doctor);
            _unitOfWork.Save();
            _unitOfWork.Dispose();
            return Ok(doc);
        }
    }
}
