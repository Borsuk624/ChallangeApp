using ChallengeApp;

var employee = new Employee("Adam", "Maeve");
employee.AddGrade(1);
employee.AddGrade(1);
employee.AddGrade(22);

var statistics1 = employee.GetStatisticsWithForEach();
Console.WriteLine("GetStatisticsWithForEach"); 
Console.WriteLine($"Average: {statistics1.Average:N2}");
Console.WriteLine($"Min: {statistics1.Min}");
Console.WriteLine($"Max: {statistics1.Max}");

var statistics2 = employee.GetStatisticsWithFor();
Console.WriteLine("GetStatisticsWithFor");
Console.WriteLine($"Average: {statistics2.Average:N2}");
Console.WriteLine($"Min: {statistics2.Min}");
Console.WriteLine($"Max: {statistics2.Max}");

var statistics3 = employee.GetStatisticsWithDoWhile();
Console.WriteLine("GetStatisticsWithDoWhile");
Console.WriteLine($"Average: {statistics3.Average:N2}");
Console.WriteLine($"Min: {statistics3.Min}");
Console.WriteLine($"Max: {statistics3.Max}");

var statistics4 = employee.GetStatisticsWithWhile();
Console.WriteLine("GetStatisticsWithWhile");
Console.WriteLine($"Average: {statistics4.Average:N2}");
Console.WriteLine($"Min: {statistics4.Min}");
Console.WriteLine($"Max: {statistics4.Max}");
