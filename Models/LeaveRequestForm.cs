using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modify_Credit.Models
{
    public class LeaveRequestForm
    {
        public int EmployeeId   { get; set; }
        public Employee Employee { get; set; }
        public DateTime LeaveDate   { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime StartHour { get; set; }
        public DateTime EndHour { get; set; }
        public string Description { get; set; }

    }
}