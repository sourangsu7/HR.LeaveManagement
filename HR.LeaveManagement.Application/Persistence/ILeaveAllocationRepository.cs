using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Persistence
{
    public interface ILeaveAllocationRepository:IGenericRepsoitory<LeaveAllocation>
    {
        Task<List<LeaveAllocation>> GetLeaveAllocationWithDetails();
        Task<LeaveAllocation> GetLeaveAllocationByIdWithDetails(int Id);
    }
}
