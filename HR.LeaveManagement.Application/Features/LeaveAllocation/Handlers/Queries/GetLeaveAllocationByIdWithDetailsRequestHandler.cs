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
    public class GetLeaveAllocationByIdWithDetailsRequestHandler : IRequestHandler<GetLeaveAllocationByIdWithDetailsRequest, LeaveAllocationDTO>
    {
        private readonly ILeaveAllocationRepository leaveAllocationRepository;
        private readonly IMapper mapper;

        public GetLeaveAllocationByIdWithDetailsRequestHandler(ILeaveAllocationRepository leaveAllocationRepository, IMapper mapper)
        {
            this.leaveAllocationRepository = leaveAllocationRepository;
            this.mapper = mapper;
        }
        public async Task<LeaveAllocationDTO> Handle(GetLeaveAllocationByIdWithDetailsRequest request, CancellationToken cancellationToken)
        {
            var leaveAllocationWithDetail = await leaveAllocationRepository.GetLeaveAllocationByIdWithDetails(request.Id);
            return mapper.Map<LeaveAllocationDTO>(leaveAllocationWithDetail);
        }
    }
}
