using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.BloodStorage.GetAllBloodStorageByType
{
    public class GetAllBloodStorageByTypeQueryHandler : IRequestHandler<GetAllBloodStorageByTypeQuery, Result<List<BloodStorageViewModel>>>
    {
        public Task<Result<List<BloodStorageViewModel>>> Handle(GetAllBloodStorageByTypeQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
