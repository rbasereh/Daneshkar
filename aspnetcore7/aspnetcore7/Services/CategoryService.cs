using aspnetcore7.Data;
using aspnetcore7.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore7.Services
{
    public class CategoryService
    {
        private readonly AppDbContext context;

        public CategoryService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Category>> GetListAsync()
        {
            return await context.Category.ToListAsync();
        }
        public async Task<Category> Create(Category category)
        {
            context.Add(category);
            await context.SaveChangesAsync();
            return category;
        }

    }
}
