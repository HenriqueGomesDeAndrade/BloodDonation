using BloodDonation.Domain.Result;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Application.Errors
{
    public class DonationError
    {
        public static ResultError UnderagedDonor => new ResultError("uneraged_donor", "You cannot donate being underaged");
        public static ResultError InvalidLastDonationDaysRangeMan => new ResultError("invalid_last_donation_days_range_man", "Men can only donate in a range of 90 days");
        public static ResultError InvalidLastDonationDaysRangeWoman => new ResultError("invalid_last_donation_days_range_woman", "Women can only donate in a range of 60 days");
        public static ResultError InvalidQuantityOfMililitersRange => new ResultError("invalid_quantity_of_mililiters_range", "The valid quantity of mililiters range to a donation is between 420ml and 470ml");
    }
}
