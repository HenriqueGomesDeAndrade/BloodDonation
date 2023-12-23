using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Interfaces;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.BloodStorages.GetAllBloodStorage
{
    public class GetAllBloodStorageQueryHandler : IRequestHandler<GetAllBloodStorageQuery, Result<List<BloodStorageViewModel>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllBloodStorageQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<List<BloodStorageViewModel>>> Handle(GetAllBloodStorageQuery request, CancellationToken cancellationToken)
        {
            var bloodStorageList = await _unitOfWork.BloodStorage.GetAllAsync(request.PageQuery.Top, request.PageQuery.Skip);
            return Result<List<BloodStorageViewModel>>.Success(bloodStorageList.Select(bs => (BloodStorageViewModel)bs).ToList());
        }
    }
}
