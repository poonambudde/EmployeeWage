using System;

namespace EmployeeWage
{
    class Program
    {

        const int PRESENT = 0;
        const int PARTIAL_PRESENT = 1;
        const int WAGE_PER_HOUR = 20;
        static int ComputeEmpwage(int partTimeHr, int fullTimeWorkHr, int noOfWorkingDay, int totalWorkinhHr)
        {

            int FULL_TIME_WORKING_HOUR = fullTimeWorkHr;
            int PART_TIME_WORKING_HOUR = partTimeHr;
            int NO_OF_WORKING_DAY_IN_MONTH = noOfWorkingDay;
            int TOTAL_WORKING_HR = totalWorkinhHr;
            int day = 0;
            int totalwage = 0;
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
                        wage = FULL_TIME_WORKING_HOUR * WAGE_PER_HOUR;
                        totalWorkingHr += FULL_TIME_WORKING_HOUR;
                        Console.WriteLine($"WAGE:{wage}");
                        break;

                    case PARTIAL_PRESENT:
                        Console.WriteLine("Employee is partial present");
                        wage = PART_TIME_WORKING_HOUR * WAGE_PER_HOUR;
                        totalWorkingHr += PART_TIME_WORKING_HOUR;
                        Console.WriteLine($"WAGE:{wage}");
                        break;

                    default:
                        Console.WriteLine("Employee is absent");
                        Console.WriteLine($"WAGE:{wage}");
                        break;

                }
                day++;

                totalwage += wage;
            }

            return totalwage;
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Total wage: {ComputeEmpwage(4, 8, 20, 100)}");
            Console.WriteLine($"Total wage: {ComputeEmpwage(6, 12, 28, 120)}");
        }
    }
}
    
