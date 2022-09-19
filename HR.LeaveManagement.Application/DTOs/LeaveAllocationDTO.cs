﻿using HR.LeaveManagement.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace HR.LeaveManagement.Application.DTOs
{
    public class LeaveAllocationDTO:BaseDTO
    {
        public int NumberOfDays { get; set; }
        public int Period { get; set; }
        public LeaveTypeDTO LeaveType { get; set; }
        public int LeaveTypeId { get; set; }
    }
}
