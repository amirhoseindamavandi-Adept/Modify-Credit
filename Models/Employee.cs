using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace Modify_Credit.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string  Name { get; set; }
        public string Family { get; set; }
        public int  NationalCode { get; set; }
        public string PhoneNumber { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
        public int BranchId { get; set; }
        public Branch Branch { get; set; }
        public int LeaveRequestId { get; set; }
        public ICollection<LeaveRequestForm> LeaveRequestForm { get; set; }
        
    }
}