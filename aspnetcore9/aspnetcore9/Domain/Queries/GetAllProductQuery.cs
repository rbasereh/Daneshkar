using aspnetcore9.Data;
using aspnetcore9.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;

namespace aspnetcore9.Domain.Queries
{
    public class GetAllProductQuery : IRequest<List<LaptopProduct>>
    {
    }
    public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<LaptopProduct>>
    {
        public GetAllProductQueryHandler(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }

        public AppDbContext AppDbContext { get; }

        public async Task<List<LaptopProduct>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await AppDbContext.LaptopProduct.ToListAsync();
        }
    }

    public class GetAllProductQueryHandler2 : IRequestHandler<GetAllProductQuery, List<LaptopProduct>>
    {
        public GetAllProductQueryHandler2(AppDbContext appDbContext)
        {
            AppDbContext = appDbContext;
        }

        public AppDbContext AppDbContext { get; }

        public async Task<List<LaptopProduct>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            return await AppDbContext.LaptopProduct.ToListAsync();
        }
    }
}
