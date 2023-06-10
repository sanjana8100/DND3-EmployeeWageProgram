namespace DND3_EmployeeWageProgram
{
    internal class EmployeeWageBuilder
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private int numberOfCompany = 0;
        private CompanyEmpWage[] companyEmpWageArray;

        public EmployeeWageBuilder()
        {
            this.companyEmpWageArray = new CompanyEmpWage[5];
        }

        public void AddCompanyEmpWage(string Company, int EmpWagePerHour, int WorkingDaysPerMonth, int TotalWorkingHours)
        {
            companyEmpWageArray[this.numberOfCompany] = new CompanyEmpWage(Company, EmpWagePerHour, WorkingDaysPerMonth, TotalWorkingHours);
            numberOfCompany++;
        }

        public void ComputeEmpWage()
        {
            for(int i = 0; i < numberOfCompany; i++)
            {
                companyEmpWageArray[i].SetTotalEmpWage(this.ComputeEmpWage(this.companyEmpWageArray[i]));
                Console.WriteLine(this.companyEmpWageArray[i].ToString());
            }
        }

        public int ComputeEmpWage(CompanyEmpWage companyEmpWage)
        {
            int empHrs = 0, totalWorkingDays = 0, totalEmpHours = 0;
            while (totalEmpHours <= companyEmpWage.TotalWorkingHours && totalWorkingDays < companyEmpWage.WorkingDaysPerMonth)
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
                Console.WriteLine("Day " + totalWorkingDays + "- Employee Hours: " + empHrs);
            }
            return totalEmpHours * companyEmpWage.EmpWagePerHour;
        }
    }
}