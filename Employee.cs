namespace DND3_EmployeeWageProgram
{
    internal class Employee
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        private string Company;
        private int EmpWagePerHour, WorkingDaysPerMonth, TotalWorkingHours, totalWage;

        public Employee(string Company, int EmpWagePerHour, int WorkingDaysPerMonth, int TotalWorkingHours)
        {
            this.Company = Company;
            this.EmpWagePerHour = EmpWagePerHour;
            this.WorkingDaysPerMonth = WorkingDaysPerMonth;
            this.TotalWorkingHours = TotalWorkingHours;
        }

        public void ComputeWage()
        {
            int empHrs = 0, empWagePerDay, empWagePerMonth = 0, totalWorkingDays = 0, totalEmpHours = 0;
            while (totalEmpHours <= this.TotalWorkingHours && totalWorkingDays < this.WorkingDaysPerMonth)
            {
                totalWorkingDays++;
                Random random = new Random();
                double empCheck = random.Next(3);
                switch ((int)empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHours += empHrs;
                empWagePerDay = empHrs * EmpWagePerHour;
                empWagePerMonth += empWagePerDay;
                Console.WriteLine("Employee Wage per Day: " + empWagePerDay);
            }
            Console.WriteLine("**********************************************");
            Console.WriteLine("Emp Wage Per Month : " + empWagePerMonth);
            totalWage = empWagePerMonth * 12;
            Console.Write("Total Wage of the Employee Per Year: " + totalWage);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program On Master Branch");
            Console.WriteLine("---------------------------------------------------------------");
            Employee employee = new Employee("TCS",300,20,100);
            employee.ComputeWage();
        }
    }
}