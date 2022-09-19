using HR.LeaveManagement.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Requests.Queries
{
    public class GetLeaveAllocationByIdWithDetailsRequest:IRequest<LeaveAllocationDTO>
    {
        public int Id { get; set; }
    }
}
