using E_CommerceAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_CommerceAPI.Application.Validators.Products
{
    public class CreateProductValidator:AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please input product name . ")
                .MaximumLength(150)
                .MinimumLength(5)
                    .WithMessage("Please input product name in 5 avarage 150");

            RuleFor(p => p.Stock)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please input Stock information ")
                .Must(s=>s>=0)
                    .WithMessage("Please Input different stock information");

            RuleFor(p => p.Price)
                .NotEmpty()
                .NotNull()
                    .WithMessage("Please input price information ")
                .Must(s => s >= 0)
                    .WithMessage("Please Input different price information");



        }

    }
}
