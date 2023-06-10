namespace DND3_EmployeeWageProgram
{
    internal class Employee
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        public void ComputeWage(string Company, int EmpWagePerHour, int WorkingDaysPerMonth, int TotalWorkingHours)
        {
            int empHrs, empWagePerDay, empWagePerMonth = 0, totalWorkingDays = 0, totalEmpHours = 0;
            while (totalEmpHours <= TotalWorkingHours && totalWorkingDays < WorkingDaysPerMonth)
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
                empWagePerDay = empHrs * EmpWagePerHour;
                empWagePerMonth += empWagePerDay;
                Console.WriteLine("Employee Wage per Day: " + empWagePerDay);
            }
            Console.WriteLine("**********************************************");
            Console.WriteLine("Emp Wage Per Month : " + empWagePerMonth);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program On Master Branch");
            Console.WriteLine("---------------------------------------------------------------");
            Console.WriteLine("Enter the Company Name: \n1.TCS\n2.Cognizant\n3.Infosys");
            int company = Convert.ToInt32(Console.ReadLine());
            Employee employee = new Employee();
            switch (company)
            {
                case 1:
                    employee.ComputeWage("TCS",300, 20, 100);
                    break;
                case 2:
                    employee.ComputeWage("Cognizant",500, 23, 120);
                    break;
                case 3:
                    employee.ComputeWage("Infosys",200, 25, 150);
                    break;
                default:
                    Console.WriteLine("Please choose a valid company.");
                    break;
            }

        }
    }
}