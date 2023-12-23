using BloodDonation.Application.Commands.Donors.CreateDonor;
using BloodDonation.Domain.ValueObjects;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Application.Validations.Donor
{
    public class CreateDonorAddressValidator : AbstractValidator<Address>
    {
        public CreateDonorAddressValidator()
        {
            RuleFor(x => x.PublicArea)
                .NotNull();

            RuleFor(x => x.City)
                .NotNull();

            RuleFor(x => x.State)
                .NotNull();

            RuleFor(x => x.ZipCode)
                .NotNull();
        }
    }
}
