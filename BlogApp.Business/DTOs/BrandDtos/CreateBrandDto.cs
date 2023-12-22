using BlogApp.Core.Entities;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Business.DTOs.BrandDtos
{
    public record CreateBrandDto
    {
        public string? Name { get; set; }
        public IFormFile? Logo { get; set; }
    }

    public class CreateBrandDtoValidation :AbstractValidator<CreateBrandDto>
    {
        public CreateBrandDtoValidation()
        {
            RuleFor(b => b.Name)
                .NotNull()
                .NotEmpty()
                .WithMessage("Bos ola bilmez")
                .MaximumLength(55);
            RuleFor(b => b.Logo)
                .NotNull()
                .WithMessage("Sekil bos ola bilmez");
        }
    }

}
