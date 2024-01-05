using BookStore.Domain.Entities;
using BookStore.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        /*
         Here we have to inject IUnitOfWork and use it instead of the DbContext Class
         */

        private readonly IUnitOfWork _unitOfWork;

        public CustomersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public IActionResult GetAction()
        {
            _unitOfWork.Customer.GetAll();
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            _unitOfWork.Customer.Get(id);
            return Ok(id);
        }

        [HttpPost]
        public IActionResult Create([FromBody]Customer entity)
        {
            _unitOfWork.Customer.Add(entity);
            return Ok(entity);
        }

        [HttpPut]
        public IActionResult Put(Customer entity)
        {
            _unitOfWork.Customer.Update(entity);
            
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _unitOfWork.Customer.Delete(id);

            return Ok(id);
        }
    }
}
