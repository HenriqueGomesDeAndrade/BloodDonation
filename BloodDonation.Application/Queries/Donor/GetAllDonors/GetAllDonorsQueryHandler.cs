using BloodDonation.Application.ViewModels;
using BloodDonation.Domain.Interfaces;
using BloodDonation.Domain.Result;
using MediatR;

namespace BloodDonation.Application.Queries.Donor.GetAllDonors
{
    public class GetAllDonorsQueryHandler : IRequestHandler<GetAllDonorsQuery, Result<List<DonorViewModel>>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllDonorsQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<Result<List<DonorViewModel>>> Handle(GetAllDonorsQuery request, CancellationToken cancellationToken)
        {
            var donorList = await _unitOfWork.Donor.GetAllDonorsAsync(request.PageQuery.Top, request.PageQuery.Skip);
            return Result<List<DonorViewModel>>.Success(donorList.Select(d => (DonorViewModel)d).ToList());
        }
    }
}
