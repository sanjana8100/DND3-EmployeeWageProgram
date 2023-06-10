namespace DND3_EmployeeWageProgram
{
    internal class Employee
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program On Master Branch");
            Console.WriteLine("Checking whether Employee is present or absent...");
            int empPresent = 1;
            Random random = new Random();
            double empCheck = random.Next(0, 3);
            if (empCheck == empPresent)
            {
                Console.WriteLine("Employee is Present");
            }
            else
                Console.WriteLine("Employee is Absent");
        }
    }
}