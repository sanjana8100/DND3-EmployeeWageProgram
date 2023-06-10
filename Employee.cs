namespace DND3_EmployeeWageProgram
{
    internal class Employee
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;
        public const int EMP_WAGE_PER_HOUR = 20;
        public const int WORKING_DAYS_PER_MONTH = 20;
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program On Master Branch");

            int empHrs, empWagePerDay, empWagePerMonth = 0;
            for (int day = 0; day <= WORKING_DAYS_PER_MONTH; day++)
            {
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
                empWagePerDay = empHrs * EMP_WAGE_PER_HOUR;
                empWagePerMonth += empWagePerDay;
                Console.WriteLine("Employee Hours: " + empHrs);
                Console.WriteLine("Employee Wage per Day: " + empWagePerDay);
            }
            Console.WriteLine("Emp Wage Per Month : " + empWagePerMonth);
        }
    }
}