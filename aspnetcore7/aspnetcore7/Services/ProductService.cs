using aspnetcore7.Data;
using aspnetcore7.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace aspnetcore7.Services
{
    public class ProductService
    {
        private readonly AppDbContext context;

        public ProductService(AppDbContext context)
        {
            this.context = context;
        }

        public async Task<List<Product>> GetListAsync()
        {
            return await context.Product.Include(e => e.Category).ToListAsync();
        }
        public async Task<Product> Create(Product Product)
        {
            context.Add(Product);
            await context.SaveChangesAsync();
            return Product;
        }

    }
}
