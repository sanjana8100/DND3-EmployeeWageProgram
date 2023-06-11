namespace DND3_EmployeeWageProgram
{
    internal class EmployeeWageBuilder : ComputeEmpWageInterface
    {
        public const int IS_FULL_TIME = 1;
        public const int IS_PART_TIME = 2;

        private LinkedList<CompanyEmpWage> companyEmpWageList;
        private Dictionary<string, CompanyEmpWage> companyToEmpWageMap;

        public EmployeeWageBuilder()
        {
            this.companyEmpWageList = new LinkedList<CompanyEmpWage>();
            this.companyToEmpWageMap = new Dictionary<string, CompanyEmpWage>();
        }

        public void AddCompanyEmpWage(string Company, int EmpWagePerHour, int WorkingDaysPerMonth, int TotalWorkingHours)
        {
            CompanyEmpWage companyEmpWage = new CompanyEmpWage(Company, EmpWagePerHour, WorkingDaysPerMonth, TotalWorkingHours);
            this.companyEmpWageList.AddLast(companyEmpWage);
            this.companyToEmpWageMap.Add(Company, companyEmpWage);
        }

        public void ComputeEmpWage()
        {
            foreach(CompanyEmpWage companyEmpWage in this.companyEmpWageList)
            {
                companyEmpWage.SetTotalEmpWage(this.ComputeEmpWage(companyEmpWage));
                Console.WriteLine(companyEmpWage.ToString());
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

        public int getTotalWage(string Company)
        {
            return this.companyToEmpWageMap[Company].totalEmpWage;
        }
    }
}