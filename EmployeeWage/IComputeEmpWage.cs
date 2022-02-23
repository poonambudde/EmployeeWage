using System;
using System.Collections.Generic;
using System.Text;

namespace Employee_Wage
{
    interface IComputeEmpWage
    {
        public void addCompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth);
        public void computeEmpWage();
    }
}
