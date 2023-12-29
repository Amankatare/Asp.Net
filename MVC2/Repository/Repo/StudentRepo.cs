using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using MVC2.Data;
using MVC2.Models;
using MVC2.Repository.Interface;
using System.Text.RegularExpressions;

namespace MVC2.Repository.Repo
{
    public class StudentRepo : IStudent
    {
        public readonly DataContext _db;
        private Student student1;

        public StudentRepo(DataContext db)
        {
            _db = db;
        }

        public async Task<List<Student>> GetStudent()
        {
            List<Student> students = _db.Students.ToList();
            return students;
        }

        [HttpPost]
        public async Task<Student> CreateStudent([FromBody] Student S, ModelStateDictionary ModelState)
        {

                if (S.Email == null)
                {
                    // Handle the case where Email is null
                    throw new ArgumentNullException(nameof(S.Email), "Email cannot be null");
                }
                else if (!S.Email.Contains("@"))
                {
                    throw new ArgumentException(nameof(S.Email), "Email doesn't contains @");
                }
                else if (Regex.IsMatch(S.Name, "@/d"))
                {
                    throw new ArgumentException(nameof(S.Name), "Name cannot Contain Numerical Values");
                }
                else if (ModelState.IsValid)
                {
                    var obj = await _db.Students.AddAsync(S);
                    _db.SaveChanges();
                }

           
            return S;
 
    
}

        [HttpDelete]
        public async  Task<Student> deleteStudent(int? id)
        {
            if (id == null) 
            {
                return null;
            } 
            Student entry = _db.Students.Find(id);
            _db.Students.Remove(entry);
            await _db.SaveChangesAsync();
            return entry;
        }

        [HttpGet("{RollNo}")]
        object IStudent.FindStudent(int rollNo)
        {
            var student = _db.Students.Find(rollNo);
            if (student != null)
            {
                student1 = student;
            }
            return student1;
        }

        [HttpPut]
        public async Task<Student> UpdateStudents(Student s,ModelStateDictionary ModelState)
        {
            if (ModelState.IsValid)
            {
                _db.Students.Update(s);
                await _db.SaveChangesAsync();
            }
            
            return s ;

        }

   
        
    }
}

