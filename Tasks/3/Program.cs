using OOP;


/* SORU 1 */
Console.WriteLine("SORU 1");
Manager manager = new Manager { Id = 1, Name = "Barış", Salary = 30000, Department = "IT", TeamSize = 10 };
Developer developer = new Developer { Id = 2, Name = "Mehmet", Salary = 40000, Department = "Software", About = "Backend Developer" };

Console.WriteLine($"Bonus: {manager.CalculateBonus()}");
Console.WriteLine("-------------------------");
Console.WriteLine($"Bonus: {developer.CalculateBonus()}");

Console.WriteLine("*************************");


/* SORU 2 */
Console.WriteLine("SORU 2");
SavingsAccount savings = new SavingsAccount("Barış Yılmaz", 10000);
CheckingAccount checking = new CheckingAccount("Mehmet Kaya", 5000);

savings.CalculateInterest();
Console.WriteLine("------------------------");
checking.CalculateInterest();