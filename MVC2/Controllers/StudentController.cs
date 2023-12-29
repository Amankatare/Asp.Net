using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using MVC2.Models;
using MVC2.Repository.Interface;

namespace MVC2.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudent _ist;

        public StudentController(IStudent ist)
        {
            _ist = ist;
        }

        public IActionResult Index()
        {
            List<Student> students= _ist.GetStudent().Result;

            return View(students);
        }

        
        public IActionResult Create(Student s, ModelStateDictionary ModelState)
        {
           _ist.CreateStudent(s,ModelState);

            return View();
        }

        public IActionResult Delete(int id)
        {
            _ist.deleteStudent(id);

            return View();
        }

        public IActionResult RedirectPage()
        {
            return View("Index");
        }

        public IActionResult Edit(int id)
        {
            Student student = (Student)_ist.FindStudent(id);
            
            return View(student);
        }

        public IActionResult Update(Student s, ModelStateDictionary ModelState)
        {
            _ist.UpdateStudents(s,ModelState);
            return RedirectToAction("Index");
        }

    }
}
