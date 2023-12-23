using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodDonation.Domain.ValueObjects
{
    public record Address(
        string PublicArea,
        string City,
        string State,
        string ZipCode);
}
