using ChallengeApp;

var employee = new Employee("Adam", "Maeve");
employee.AddGrade(1);
employee.AddGrade(1);
employee.AddGrade(22);

var statistics = employee.GetStatistics();
Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
