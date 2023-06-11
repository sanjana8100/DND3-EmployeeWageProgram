using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DND3_EmployeeWageProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program On Master Branch");
            Console.WriteLine("---------------------------------------------------------------");
            EmployeeWageBuilder employeeWageBuilder = new EmployeeWageBuilder();
            employeeWageBuilder.AddCompanyEmpWage("DMart", 400, 20, 100);
            employeeWageBuilder.AddCompanyEmpWage("Reliance", 100, 40, 200);
            employeeWageBuilder.ComputeEmpWage();
            Console.WriteLine("Total Wage in DMart Company is: " + employeeWageBuilder.getTotalWage("DMart"));
        }
    }
}
