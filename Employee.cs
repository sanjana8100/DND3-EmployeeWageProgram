namespace DND3_EmployeeWageProgram
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program On Master Branch");
            Console.WriteLine("Checking whether Employee is present or absent...");
            int IsPresent = 1;
            int EmpWagePerHour = 20;
            int empHrs, empWage;
            Random random = new Random();
            double empCheck = random.Next(0, 3);
            if (empCheck == IsPresent)
            {
                Console.WriteLine("Employee is Present");
                empHrs = 8;
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