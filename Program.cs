int employeeRatePerHr = 20;
int employeeHrs = 0;
int employeeWagePerDay = 0;
int employeeWagePerMonth = 0;
int maxWorkingDaysInMonth = 20;
for (int i = 1; i <= maxWorkingDaysInMonth; i++)
{
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
    employeeWagePerDay = employeeHrs * employeeRatePerHr;
    Console.WriteLine("employeeWagePerDay : " + employeeWagePerDay);
    employeeWagePerMonth += employeeWagePerDay;
}
Console.WriteLine("employeeWagePerMonth : " + employeeWagePerMonth);
