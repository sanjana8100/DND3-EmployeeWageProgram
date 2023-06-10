using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND3_EmployeeWageProgram
{
    internal class CompanyEmpWage
    {
        public string Company;
        public int EmpWagePerHour, WorkingDaysPerMonth, TotalWorkingHours, totalEmpWage;

        public CompanyEmpWage(string Company, int EmpWagePerHour, int WorkingDaysPerMonth, int TotalWorkingHours)
        {
            this.Company = Company;
            this.EmpWagePerHour = EmpWagePerHour;
            this.WorkingDaysPerMonth = WorkingDaysPerMonth;
            this.TotalWorkingHours = TotalWorkingHours;
        }

        public void SetTotalEmpWage(int totalEmpWage)
        {
            this.totalEmpWage = totalEmpWage;
        }

        public string ToString()
        {
            return "Total Employee Wage in " + this.Company + " Company is: " + this.totalEmpWage;
        }
    }
}
