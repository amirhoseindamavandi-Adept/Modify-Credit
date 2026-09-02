using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Modify_Credit.Models
{
 public class Branch
{
    public int BranchId { get; set; }

    public string BranchName { get; set; }

    public ICollection<Employee> employees { get; set; }
}
}