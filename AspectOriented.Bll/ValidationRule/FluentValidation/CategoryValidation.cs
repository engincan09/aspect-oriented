using AspectOriented.Entity.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AspectOriented.Bll.ValidationRule.FluentValidation
{
    public class CategoryValidation : AbstractValidator<Category>
    {
        public CategoryValidation()
        {
            RuleFor(p => p.CategoryName).NotEmpty().WithMessage("Lütfen kategori adını boş geçmeyiniz.");
        }
    }
}
