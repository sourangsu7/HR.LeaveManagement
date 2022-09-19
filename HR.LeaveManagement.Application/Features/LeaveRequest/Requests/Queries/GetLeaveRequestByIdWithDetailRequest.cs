using HR.LeaveManagement.Application.DTOs;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveRequest.Requests.Queries
{
    public class GetLeaveRequestByIdWithDetailRequest: IRequest<LeaveRequestDTO>
    {
        public int Id { get; set; }
    }
}
