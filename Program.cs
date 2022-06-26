using EmployeeWages;
EmployeeWage BridgeLabz = new EmployeeWage("BridgeLabz", 50, 20, 200);
EmployeeWage mittal = new EmployeeWage("mittal", 30, 20, 200);
BridgeLabz.Wage();
Console.WriteLine(BridgeLabz.Show());
Console.WriteLine("---------------------");
mittal.Wage();
Console.WriteLine(mittal.Show());