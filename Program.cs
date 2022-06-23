int isFullTime = 1;
int employeeRatePerHr = 20;
int employeeHrs = 0;
int employeeWagePerDay = 0;
Random rnd = new Random();
int num = rnd.Next(0, 2);
if (num == isFullTime)
{
    employeeHrs = 8;
    Console.WriteLine("Present");
}
else
{
    employeeHrs = 0;
    Console.WriteLine("Absent");
}
employeeWagePerDay = employeeHrs * employeeRatePerHr;
Console.WriteLine("employeeWagePerDay : " + employeeWagePerDay);