using aspnetcore9.Models;
using FluentValidation;

namespace aspnetcore9.Validations
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            
            RuleFor(e=>e.Name).NotEmpty()
                .Length(3,50).WithMessage("نام باید بیشتر از 3 کاراکتر باشد.");

            RuleFor(e => e.Description).NotEmpty();

            RuleFor(e => e.Price).NotEmpty()
                .NotNull()
                .GreaterThan(0);

        }
    }
}
