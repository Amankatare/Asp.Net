using Microsoft.AspNetCore.Mvc;
using System.Net;
using Task.Models.Domain;

namespace Task.Repository.Interface
{
    public interface IAddress
    {
        public Task<IActionResult> Create(Address s);

        public Task<IActionResult> Delete(int id);

        public Task<IActionResult> Read(int id);
        public Task<IActionResult> ReadAll();

        public Task<IActionResult> Update(int id, Address s);
    }
}
