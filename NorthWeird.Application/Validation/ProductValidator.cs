﻿using FluentValidation;
using NorthWeird.Application.Models;

namespace NorthWeird.Application.Validation
{
    public class ProductValidator : AbstractValidator<ProductDto>
    {
        public ProductValidator()
        {
            RuleFor(p => p.ProductName).MaximumLength(40).NotEmpty();
            RuleFor(p => p.QuantityPerUnit).MaximumLength(30).NotEmpty();
            RuleFor(p => p.UnitPrice).GreaterThanOrEqualTo(0);
            RuleFor(p => p.UnitsInStock).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.UnitsOnOrder).GreaterThanOrEqualTo((short)0);
            RuleFor(p => p.ReorderLevel).GreaterThanOrEqualTo((short)0);
        }
    }
}
