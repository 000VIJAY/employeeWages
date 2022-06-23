int employeeRatePerHr = 20;
int employeeHrs = 0;
int employeeWagePerDay = 0;
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