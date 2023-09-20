using Microsoft.EntityFrameworkCore;
using aspnetcore6.Data;
using aspnetcore6.Models;

namespace aspnetcore6.Services
{
    public class PersonService
    {
        private readonly AppDbContext _context;

        public PersonService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<List<Person>> GetAllAsync()
        {
            return await _context.Person.ToListAsync();
        }
        public List<Person> GetAll()
        {
            return _context.Person.ToList();
        }
    }
}
