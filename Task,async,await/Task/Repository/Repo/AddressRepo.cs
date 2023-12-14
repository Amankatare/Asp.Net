using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Task.Data;
using Task.Models.Domain;
using Task.Repository.Interface;

namespace Task.Repository.Repo
{
    public class AddressRepo : IAddress
    {
        private readonly DatabaseDBContext _address;

        public AddressRepo(DatabaseDBContext address)
        {

            _address = address;

        }
        public async Task<IActionResult> Create(Address s)
        {
            var entry = await _address.Addresses.AddAsync(s);
            await _address.SaveChangesAsync();
            return new OkObjectResult(entry);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var entry = await _address.Addresses.FindAsync(id);
            var removeEntry = _address.Addresses.Remove(entry);
            await _address.SaveChangesAsync();
            return new OkObjectResult(removeEntry);
        }

        public async Task<IActionResult> Read(int id)
        {
            var entry = await _address.Addresses.FindAsync(id);
            await _address.SaveChangesAsync();
            return new OkObjectResult(entry);
        }

        public async Task<IActionResult> ReadAll()
        {
            var entry = await _address.Addresses.ToListAsync();
            return new OkObjectResult(entry);
        }

        public async Task<IActionResult> Update(int id, Address s)
        {
            var entry = await _address.Addresses.FindAsync(id);
            var removeEntry = _address.Addresses.Update(entry);
            await _address.SaveChangesAsync();
            return new OkObjectResult(removeEntry);
        }
    }
}
