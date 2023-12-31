﻿using BloodDonation.Application.Commands.Donations.CreateDonation;
using BloodDonation.Application.Errors;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Application.Validations.Donation
{
    public class CreateDonationCommandValidator : AbstractValidator<CreateDonationCommand>
    {
        public CreateDonationCommandValidator()
        {
            RuleFor(x => x.DonorId)
                .NotEmpty();

            RuleFor(x => x.DonationDate) 
                .NotEmpty()
                .LessThanOrEqualTo(DateTime.Now);

            RuleFor(x => x.QuantityInMililiters) 
                .NotEmpty()
                .InclusiveBetween(420, 470).WithMessage(DonationError.InvalidQuantityOfMililitersRange.Description);
        }
    }
}
