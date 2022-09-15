

//Already using class since starting

using EmpWage;

Console.WriteLine("Welcome to employee wage computation program");
Emp emp1 = new Emp();
emp1.Wage("TCS", 20, 20, 100);
Emp emp2 = new Emp();
emp2.Wage("Zoho", 30, 20, 100);
Console.WriteLine($"Total wage for an employee of TCS is {emp1.totalWage}");
Console.WriteLine($"Total wage for an employee of Zoho is {emp2.totalWage}");