using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND3_EmployeeWageProgram
{
    internal interface ComputeEmpWageInterface
    {
        public void AddCompanyEmpWage(string Company, int EmpWagePerHour, int WorkingDaysPerMonth, int TotalWorkingHours);
        public void ComputeEmpWage();
    }
}
