using AutoMapper;
using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.Features.LeaveAllocation.Requests.Queries;
using HR.LeaveManagement.Application.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Handlers.Queries
{
    public class GetLeaveAllocationWithDetailsRequestHandler : IRequestHandler<GetLeaveAllocationWithDetailsRequest, List<LeaveAllocationDTO>>
    {
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly IMapper mapper;

        public GetLeaveAllocationWithDetailsRequestHandler(ILeaveAllocationRepository leaveAllocationRepository,IMapper mapper)
        {
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.mapper = mapper;
        }
        public async Task<List<LeaveAllocationDTO>> Handle(GetLeaveAllocationWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocationWithDetails = await leaveAllocationRepository.GetLeaveAllocationWithDetails();
            return mapper.Map<List<LeaveAllocationDTO>>(leaveAllocationWithDetails);
        }
    }
}
