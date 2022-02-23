using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage
{
    class EmpWageBuilder
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWages;

        public EmpWageBuilder(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            int empHrs = 0;
            int totalWorkingDays = 0;
            int totalEmployeeHour = 0;
            while (empHrs <= maxHoursPerMonth && totalWorkingDays <= numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmployeeHour += empHrs;
                Console.WriteLine("Day:" + totalWorkingDays + " Emp Hrs : " + empHrs);
            }
            int totalEmpWages = totalEmployeeHour * this.empRatePerHour;
            Console.WriteLine("Total employee wage for company:" + company + " is " + totalEmpWages);
        }
        public string toString()
        {
            return "Total employee wage for company:" + this.company + " is " + this.totalEmpWages;
        }
    }
}

