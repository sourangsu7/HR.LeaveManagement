using AutoMapper;
using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.Features.LeaveRequest.Requests.Queries;
using HR.LeaveManagement.Application.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Handlers.Queries
{
    public class GetLeaveRequestWithDetailsRequestHandler : IRequestHandler<GetLeaveRequestWithDetailsRequest, List<LeaveRequestListDTO>>
    {
        private readonly ILeaveRequestRepository leaveRequestRepository;
        private readonly IMapper mapper;

        public GetLeaveRequestWithDetailsRequestHandler(ILeaveRequestRepository leaveRequestRepository, IMapper mapper)
        {
            this.leaveRequestRepository = leaveRequestRepository;
            this.mapper = mapper;
        }

        public async Task<List<LeaveRequestListDTO>> Handle(GetLeaveRequestWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var leaveRequestDetails = await leaveRequestRepository.GetLeaveRequestListWithDetails();
            return mapper.Map<List<LeaveRequestListDTO>>(leaveRequestDetails);
        }
    }
}
