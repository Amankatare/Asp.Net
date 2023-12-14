using Microsoft.AspNetCore.Mvc;
using Task.Models.Domain;

namespace Task.Repository.Interface
{
    public interface IStudent
    {
        public Task<IActionResult> ReadAll();

        public Task<IActionResult> Read(int id);

        public Task<IActionResult> Create(Student s);

        public Task<IActionResult> Update(int id, Student s);

        public Task<IActionResult> Delete(int id);
    }
}
