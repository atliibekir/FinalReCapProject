using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.Password).NotEmpty();
            RuleFor(u => u.Password).Length(5, 17);            
            RuleFor(u => u.Password).Must(IsPasswordValid);

        }

        private bool IsPasswordValid(string arg)
        {
            Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            return regex.IsMatch(arg);
        }
    }
}
