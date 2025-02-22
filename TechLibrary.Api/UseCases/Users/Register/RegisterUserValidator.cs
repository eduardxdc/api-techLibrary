using FluentValidation;
using TechLibrary.Communication.Requests;

namespace TechLibrary.Api.UseCases.Users.Register
{
    public class RegisterUserValidator : AbstractValidator<RequestUserJson>

    {
        public RegisterUserValidator()
        {
            RuleFor(request => request.Name).NotEmpty().WithMessage("The name is mandatory!");
            RuleFor(request => request.Email).EmailAddress().WithMessage("This email is not valid!");
            RuleFor(request => request.Password).NotEmpty().WithMessage("Password is mandatory!");
            When(request => string.IsNullOrEmpty(request.Password) == false, () =>
            {
                RuleFor(request => request.Password.Length).GreaterThanOrEqualTo(6).WithMessage("The password must contain more than 6 characters!");
            });

        }
    }
}
