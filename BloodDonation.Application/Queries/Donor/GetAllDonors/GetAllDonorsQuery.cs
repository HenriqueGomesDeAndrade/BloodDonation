using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Helpers;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.Donor.GetAllDonors
{
    public class GetAllDonorsQuery : IRequest<Result<List<DonorViewModel>>>
    {
        public GetAllDonorsQuery(PageQuery pageQuery)
        {
            PageQuery = pageQuery;
        }

        public PageQuery PageQuery { get; set; }
    }
}
