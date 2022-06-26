using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWages
{
   public class EmployeeWage
   {
        string companyName;
        int employeeRatePerHr;
        int maxWorkingDaysINMonth;
        int MaxWorkingHrsInMonth;
       int employeeWagePerMonth;
        public EmployeeWage(string companyName, int employeeRatePerHr, int maxWorkingDaysInMonth, int maxWorkingHrsInMonth)
        {
            this.companyName = companyName;
            this.employeeRatePerHr = employeeRatePerHr;
            this.maxWorkingDaysINMonth = maxWorkingDaysInMonth;
            this.MaxWorkingHrsInMonth = maxWorkingHrsInMonth;
        }
      
        public void Wage()
        {
            int totalEmployeeHrs = 0;
            int totalWorkingDays = 0;
            int employeeHrs = 0;
            int employeeWagePerDay = 0;
            while (totalEmployeeHrs <= this.MaxWorkingHrsInMonth && totalWorkingDays < this.maxWorkingDaysINMonth)
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
                employeeWagePerDay = employeeHrs * this.employeeRatePerHr;
                Console.WriteLine("employeeWagePerDay : " + employeeWagePerDay);
                employeeWagePerMonth += employeeWagePerDay;
            }
            Console.WriteLine("Company Name : " +companyName);
            Console.WriteLine("employee Wage Per Month for a company : " + employeeWagePerMonth);
        }
        public string Show()
        {
            return "Name of Company : " +this.companyName + " is : " + this.employeeWagePerMonth;
        }
   }
}
