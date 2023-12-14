using BloodDonation.Domain.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Application.Errors
{
    public class DonorError
    {
        public static ResultError EmailAlreadyExists => new ResultError("email_already_exists", "This Email already exists on the database");
        public static ResultError WeightTooLigth => new ResultError("weight_too_light", "The minimum weight to be a donor is 50kg");
    }
}
