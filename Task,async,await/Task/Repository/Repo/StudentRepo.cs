using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task.Data;
using Task.Models.Domain;
using Task.Repository.Interface;

namespace Task.Repository.Repo
{
    /*
     whenever we don't want our program to get in a hault condition we use task async and await
     */
    public class StudentRepo : IStudent
    {
        private readonly DatabaseDBContext _student;

        public StudentRepo(DatabaseDBContext student)
        {

            _student = student;

        }
        public async Task<IActionResult> Create(Student s)
        {
            var entry = await _student.Students.AddAsync(s);
            await _student.SaveChangesAsync();
            return new OkObjectResult(entry);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var entry = await _student.Students.FindAsync(id);
            var removeEntry = _student.Students.Remove(entry);
            await _student.SaveChangesAsync();
            return new OkObjectResult(removeEntry);
        }

        public async Task<IActionResult> Read(int id)
        {
            var entry = await _student.Students.FindAsync(id);
            await _student.SaveChangesAsync();
            return new OkObjectResult(entry);
        }

        public async Task<IActionResult> ReadAll()
        {
            var entry = await _student.Students.ToListAsync();
            return new OkObjectResult(entry);
        }

        public async Task<IActionResult> Update(int id, Student s)
        {
            var entry = await _student.Students.FindAsync(id);
            var removeEntry = _student.Students.Update(entry);
            await _student.SaveChangesAsync();
            return new OkObjectResult(removeEntry);
        }
    }
}
