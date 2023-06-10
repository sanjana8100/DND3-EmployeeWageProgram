namespace DND3_EmployeeWageProgram
{
    internal class Employee
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 20;
        public const int WORKING_DAYS_PER_MONTH = 20;
        public const int TOTAL_WORKING_HOURS = 100;

        public int ComputeWage()
        {
            int empHrs, empWagePerDay, empWagePerMonth = 0, totalWorkingDays = 0, totalEmpHours = 0;
            while (totalEmpHours <= TOTAL_WORKING_HOURS && totalWorkingDays < WORKING_DAYS_PER_MONTH)
            {
                totalWorkingDays++;
                Random random = new Random();
                double empCheck = random.Next(3);
                switch ((int)empCheck)
                {
                    case IS_FULL_TIME:
                        Console.WriteLine("Employee is Doing Full Time:");
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        Console.WriteLine("Employee is Doing Part Time:");
                        empHrs = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent:");
                        empHrs = 0;
                        break;
                }
                totalEmpHours += empHrs;
                empWagePerDay = empHrs * EMP_WAGE_PER_HOUR;
                empWagePerMonth += empWagePerDay;
                Console.WriteLine("Employee Wage per Day: " + empWagePerDay);
            }
            return empWagePerMonth;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program On Master Branch");
            Employee employee = new Employee();
            int MonthlyWage = employee.ComputeWage();
            Console.WriteLine("**********************************************");
            Console.WriteLine("Emp Wage Per Month : " + MonthlyWage);
        }
    }
}