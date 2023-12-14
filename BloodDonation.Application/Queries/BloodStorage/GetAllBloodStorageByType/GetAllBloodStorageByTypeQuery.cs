using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Enum;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.BloodStorage.GetAllBloodStorageByType
{
    public class GetAllBloodStorageByTypeQuery : IRequest<Result<List<BloodStorageViewModel>>>
    {
        public GetAllBloodStorageByTypeQuery(BloodTypeEnum type)
        {
            Type = type;
        }

        public BloodTypeEnum Type { get; set; }
    }
}
