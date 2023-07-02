using FluentValidation;

namespace AZMigrationPortal.Models.Validators
{
    public class LoginRequestValidator : AbstractValidator<Models.LoginRequest>
    {
        public LoginRequestValidator() 
        { 
         RuleFor(x=> x.UserName).NotEmpty();
         RuleFor(x=> x.Password).NotEmpty();
        }
    }
}
