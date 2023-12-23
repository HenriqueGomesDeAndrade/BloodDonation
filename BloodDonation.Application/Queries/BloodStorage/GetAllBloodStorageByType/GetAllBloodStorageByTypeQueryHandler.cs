using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Interfaces;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.BloodStorages.GetAllBloodStorageByType
{
    public class GetAllBloodStorageByTypeQueryHandler : IRequestHandler<GetAllBloodStorageByTypeQuery, Result<List<BloodStorageViewModel>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllBloodStorageByTypeQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<List<BloodStorageViewModel>>> Handle(GetAllBloodStorageByTypeQuery request, CancellationToken cancellationToken)
        {
            var bloodStorageList = await _unitOfWork.BloodStorage.GetAllByTypeAsync(request.PageQuery.Top, request.PageQuery.Skip, request.Type);
            return Result<List<BloodStorageViewModel>>.Success(bloodStorageList.Select(bs => (BloodStorageViewModel)bs).ToList());
        }
    }
}
