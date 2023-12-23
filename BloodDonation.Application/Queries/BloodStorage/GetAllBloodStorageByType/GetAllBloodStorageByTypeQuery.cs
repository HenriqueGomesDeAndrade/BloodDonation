using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Enum;
using BloodDonation.Domain.Helpers;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.BloodStorages.GetAllBloodStorageByType
{
    public class GetAllBloodStorageByTypeQuery : IRequest<Result<List<BloodStorageViewModel>>>
    {
        public GetAllBloodStorageByTypeQuery(BloodTypeEnum type, PageQuery pageQuery)
        {
            Type = type;
            PageQuery = pageQuery;
        }

        public BloodTypeEnum Type { get; set; }
        public PageQuery PageQuery { get; set; }

    }
}
