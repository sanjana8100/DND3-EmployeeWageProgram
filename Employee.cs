namespace DND3_EmployeeWageProgram
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program On Master Branch");
            Console.WriteLine("Checking whether Employee is present or absent...");
            int IsFullTime = 1;
            int IsPartTime = 2;
            int EmpWagePerHour = 20;
            int empHrs, empWage;
            Random random = new Random();
            double empCheck = random.Next(3);
            if (empCheck == IsFullTime)
            {
                Console.WriteLine("Employee is working Full Time.");
                empHrs = 8;
            }
            else if (empCheck == IsPartTime)
            {
                Console.WriteLine("Employee is working Part Time.");
                empHrs = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
                empHrs = 0;
            }
            empWage = empHrs * EmpWagePerHour;
            Console.WriteLine("Employee Hours: " + empHrs);
            Console.WriteLine("Employee Wage: " + empWage);
        }
    }
}