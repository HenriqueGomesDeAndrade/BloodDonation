using BloodDonation.Application.Commands.Donor.CreateDonor;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Application.Validations.Donor
{
    public class CreateDonorAddressCommandValidator : AbstractValidator<CreateDonorAddressCommand>
    {
        public CreateDonorAddressCommandValidator()
        {
            RuleFor(x => x.PublicArea)
                .NotNull();

            RuleFor(x => x.City)
                .NotNull();

            RuleFor(x => x.State)
                .NotNull();

            RuleFor(x => x.ZipCode)
                .NotNull();

            RuleFor(x => x.DonorId)
                .NotNull();
        }
    }
}
