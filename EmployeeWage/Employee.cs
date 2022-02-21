using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeWage
{
    public class Employee
    {
        const int PRESENT = 0;
        const int PARTIAL_PRESENT = 1;

        string CompanyName;
        int FULL_TIME_WORKING_HOUR;
        int PART_TIME_WORKING_HOUR;
        int NO_OF_WORKING_DAY_IN_MONTH;
        int TOTAL_WORKING_HR;
        int wagePerHr;
        int totalWage = 0;

        public Employee(string companyName, int fULL_TIME_WORKING_HOUR, int pART_TIME_WORKING_HOUR, int nO_OF_WORKING_DAY_IN_MONTH, int tOTAL_WORKING_HR, int wagePerHr)
        {
            CompanyName = companyName;
            FULL_TIME_WORKING_HOUR = fULL_TIME_WORKING_HOUR;
            PART_TIME_WORKING_HOUR = pART_TIME_WORKING_HOUR;
            NO_OF_WORKING_DAY_IN_MONTH = nO_OF_WORKING_DAY_IN_MONTH;
            TOTAL_WORKING_HR = tOTAL_WORKING_HR;
            this.wagePerHr = wagePerHr;
        }
        public int ComputeEmpwage()
        {

            int day = 0;
            
            int totalWorkingHr = 0;

            while (day != 20 && totalWorkingHr <= TOTAL_WORKING_HR)
            {
                int wage = 0;
                Random random = new Random();
                int empCheck = random.Next(0, 3);

                switch (empCheck)
                {
                    case PRESENT:
                        Console.WriteLine("Employee is present");
                        wage = FULL_TIME_WORKING_HOUR * wagePerHr;
                        totalWorkingHr += FULL_TIME_WORKING_HOUR;
                        Console.WriteLine($"WAGE:{wage}");
                        break;

                    case PARTIAL_PRESENT:
                        Console.WriteLine("Employee is partial present");
                        wage = PART_TIME_WORKING_HOUR * wagePerHr;
                        totalWorkingHr += PART_TIME_WORKING_HOUR;
                        Console.WriteLine($"WAGE:{wage}");
                        break;

                    default:
                        Console.WriteLine("Employee is absent");
                        Console.WriteLine($"WAGE:{wage}");
                        break;

                }
                day++;

                totalWage += wage;
            }

            return totalWage;
        }
        public string ToString()
        {
            return $"Total Employee wage for company {CompanyName} is {totalWage}";
        }
    }
}
    

