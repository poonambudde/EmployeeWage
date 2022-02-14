using System;

namespace EmployeeWage
{
    class Program
    {
        static void Main(string[] args)
        {
            const int PRESENT = 0;
            const int PARTIAL_PRESENT = 1;
            const int WAGE_PER_HOUR = 20;
            const int FULL_TIME_WORKING_HOUR = 8;
            int PART_TIME_WORKING_HOUR = 4;
            int wage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            //if (empCheck == PRESENT)
            //{
            //    Console.WriteLine("Employee is present");
            //    wage = FULL_TIME_WORKING_HOUR * WAGE_PER_HOUR;
            //    Console.WriteLine($"WAGE:{wage}");
            //}
            //else if (empCheck == PARTIAL_PRESENT)
            //{
            //    Console.WriteLine("Employee is partial present");
            //    wage = PART_TIME_WORKING_HOUR * WAGE_PER_HOUR;
            //    Console.WriteLine($"WAGE:{wage}");

            //}
            //else
            //{
            //    Console.WriteLine("Employee is absent");
            //}
            switch (empCheck)
            {
                case PRESENT:
                    Console.WriteLine("Employee is present");
                    wage = FULL_TIME_WORKING_HOUR * WAGE_PER_HOUR;
                    Console.WriteLine($"WAGE:{wage}");
                    break;

                case PARTIAL_PRESENT:
                    Console.WriteLine("Employee is partial present");
                    wage = PART_TIME_WORKING_HOUR * WAGE_PER_HOUR;
                    Console.WriteLine($"WAGE:{wage}");
                    break;

                default:
                    Console.WriteLine("Employee is absent");
                    Console.WriteLine($"WAGE:{wage}");
                    break;

            }
        }
    }
}
