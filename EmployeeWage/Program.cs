using System;

namespace EmployeeWage
{
    class Program
    {

      
        const int WAGE_PER_HOUR = 20;
  
      
        
        static void Main(string[] args)
        {
            Employee employwage = new Employee("Dmart", 12, 6, 20, 90, 20);
            employwage.ComputeEmpwage();

            Console.WriteLine(employwage.ToString());
        }
    }
}
    
