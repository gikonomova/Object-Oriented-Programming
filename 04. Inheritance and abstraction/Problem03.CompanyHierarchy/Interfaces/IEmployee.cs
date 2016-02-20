using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03.CompanyHierarchy.Interfaces
{
    public interface IEmployee
    {
        decimal Salary { get; set; }
        Departments Departments { get; set; }
    }

}
