using BloodDonation.Application.Commands.Donor.CreateDonor;
using BloodDonation.Application.Errors;
using FluentValidation;

namespace BloodDonation.Application.Validations.Donor
{
    public class CreateDonorCommandValidator : AbstractValidator<CreateDonorCommand>
    {
        public CreateDonorCommandValidator()
        {
            RuleFor(x => x.FullName)
            .NotEmpty()
            .NotNull();

            RuleFor(x => x.Email)
            .NotEmpty()
            .NotNull()
            .EmailAddress();

            RuleFor(x => x.DateOfBirth)
            .NotNull()
            .LessThan(DateTime.Today);

            RuleFor(x => x.Gender)
            .NotNull()
            .IsInEnum();

            RuleFor(x => x.Weight)
            .NotNull()
            .GreaterThanOrEqualTo(50).WithMessage(DonorError.WeightTooLigth.Description);

            RuleFor(x => x.BloodType)
            .NotNull()
            .IsInEnum();

            RuleFor(x => x.RhFactor)
            .NotNull()
            .IsInEnum();
        }
        
    }
}
