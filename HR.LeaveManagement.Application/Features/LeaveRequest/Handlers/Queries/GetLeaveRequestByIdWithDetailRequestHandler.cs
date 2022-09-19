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
    public class GetLeaveRequestByIdWithDetailRequestHandler : IRequestHandler<GetLeaveRequestByIdWithDetailRequest, LeaveRequestDTO>
    {
        private readonly ILeaveRequestRepository leaveRequestRepository;
        private readonly IMapper mapper;

        public GetLeaveRequestByIdWithDetailRequestHandler(ILeaveRequestRepository leaveRequestRepository,IMapper mapper)
        {
            this.leaveRequestRepository = leaveRequestRepository;
            this.mapper = mapper;
        }
        public async Task<LeaveRequestDTO> Handle(GetLeaveRequestByIdWithDetailRequest request, CancellationToken cancellationToken)
        {
            var leaveRequestDetail = await leaveRequestRepository.GetLeaveRequestByIdWithDetails(request.Id);
            return mapper.Map<LeaveRequestDTO>(leaveRequestDetail);
        }
    }
}
