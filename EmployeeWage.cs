using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
   public class EmployeeWage
    {
        public void Wage()
        {
            int employeeRatePerHr = 20;
            int maxWorkingDaysInMonth = 20;
            int maxWorkingHrsInMonth = 100;
            int totalEmployeeHrs = 0;
            int totalWorkingDays = 0;
            int employeeHrs = 0;
            int employeeWagePerDay = 0;
            int employeeWagePerMonth = 0;
            while (totalEmployeeHrs <= maxWorkingHrsInMonth && totalWorkingDays < maxWorkingDaysInMonth)
            {
                totalWorkingDays++;
                Random rnd = new Random();
                int num = rnd.Next(0, 3);
                switch (num)
                {
                    case 0:
                        employeeHrs = 8;
                        break;
                    case 1:
                        employeeHrs = 4;
                        break;
                    default:
                        employeeHrs = 0;
                        break;
                }
                totalEmployeeHrs += employeeHrs;
                Console.WriteLine("employeeHours : " + totalEmployeeHrs);
                Console.WriteLine("Day : " + totalWorkingDays);
                employeeWagePerDay = employeeHrs * employeeRatePerHr;
                Console.WriteLine("employeeWagePerDay : " + employeeWagePerDay);
                employeeWagePerMonth += employeeWagePerDay;

            }
            Console.WriteLine("employeeWagePerMonth : " + employeeWagePerMonth);
        }
    }
}
