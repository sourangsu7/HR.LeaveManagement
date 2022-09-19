using AutoMapper;
using HR.LeaveManagement.Application.DTOs;
using HR.LeaveManagement.Application.Persistence;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.Features.LeaveAllocation.Requests.Queries
{
   
    public class GetLeaveAllocationWithDetailsRequest:IRequest<List<LeaveAllocationDTO>>
    {
       
    }
}
