using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Enum;
using BloodDonation.Domain.Helpers;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.BloodStorages.GetAllBloodStorage
{
    public class GetAllBloodStorageQuery : IRequest<Result<List<BloodStorageViewModel>>>
    {
        public GetAllBloodStorageQuery(PageQuery pageQuery)
        {
            PageQuery = pageQuery;
        }

        public PageQuery PageQuery { get; set; }
    }
}
