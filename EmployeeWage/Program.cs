using System;

namespace Employee_Wage
{
    class Program
    {
        static void Main(string[] args)
        {
            EmpWageBuilder dMart = new EmpWageBuilder("DMart", 20, 2, 10);
            EmpWageBuilder reliance = new EmpWageBuilder("Reliance", 10, 4, 20);
            dMart.computeEmpWage();
            Console.WriteLine(dMart.toString());
            reliance.computeEmpWage();
            Console.WriteLine(reliance.toString());
        }
    }
}