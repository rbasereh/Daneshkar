using aspnetcore9.Data;
using aspnetcore9.Models;
using FluentValidation;
using MediatR;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace aspnetcore9.Domain.Commands
{

    //Mediator
    //MediatR

    public class CreateLaptopCommand : IRequest<bool>
    {
        public LaptopProduct LaptopProduct { get; set; }
    }
    public class CreateLaptopCommandHandler : IRequestHandler<CreateLaptopCommand, bool>
    {
        private readonly AppDbContext appDbContext;

        public CreateLaptopCommandHandler(AppDbContext appDbContext, IValidator<Product> validator)
        {
            this.appDbContext = appDbContext;
            Validator = validator;
        }

        public IValidator<Product> Validator { get; }

        public async Task<bool> Handle(CreateLaptopCommand command, CancellationToken cancellationToken)
        {
            var result = Validator.Validate(command.LaptopProduct);
            if (result.IsValid)
            {
                appDbContext.Add(command.LaptopProduct);
                appDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
