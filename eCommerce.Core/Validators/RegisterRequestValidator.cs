﻿using eCommerce.Core.DTO;
using FluentValidation;

namespace eCommerce.Core.Validators;
    public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
    {
    public RegisterRequestValidator()
    {
        RuleFor(temp => temp.Email)
            .NotEmpty().WithMessage("Email is required")
            .EmailAddress().WithMessage("Invalid email adress format");
        RuleFor(temp => temp.Password)
            .NotEmpty().WithMessage("Password is required");
        RuleFor(temp => temp.UserName)
            .NotEmpty().WithMessage("Username is required")
            .Length(1, 50).WithMessage("Username should be 1 to 50 characters long");
        RuleFor(temp => temp.Gender)
            .IsInEnum().WithMessage("Invalid gender option");
    }
}
