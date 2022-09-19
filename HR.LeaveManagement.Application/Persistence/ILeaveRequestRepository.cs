using HR.LeaveManagement.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HR.LeaveManagement.Application.Persistence
{
    public interface ILeaveRequestRepository:IGenericRepsoitory<LeaveRequest>
    {
        Task<LeaveRequest> GetLeaveRequestByIdWithDetails(int Id);
        Task<List<LeaveRequest>> GetLeaveRequestListWithDetails();
    }
}
