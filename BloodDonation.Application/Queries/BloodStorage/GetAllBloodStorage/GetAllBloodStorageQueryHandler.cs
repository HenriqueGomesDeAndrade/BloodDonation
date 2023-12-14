using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.BloodStorage.GetAllBloodStorage
{
    public class GetAllBloodStorageQueryHandler : IRequestHandler<GetAllBloodStorageQuery, Result<List<BloodStorageViewModel>>>
    {
        public Task<Result<List<BloodStorageViewModel>>> Handle(GetAllBloodStorageQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
