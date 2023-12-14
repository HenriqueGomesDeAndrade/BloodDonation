using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.BloodStorage.GetAllBloodStorage
{
    public class GetAllBloodStorageQuery : IRequest<Result<List<BloodStorageViewModel>>>
    {
    }
}
