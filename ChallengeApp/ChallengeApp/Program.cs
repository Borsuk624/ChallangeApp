﻿using ChallengeApp;

var employee = new Employee("Adam", "Maeve");
employee.AddGrade("20");
employee.AddGrade(4.5f);
employee.AddGrade(2.66d);
employee.AddGrade(6);
var statistics = employee.GetStatistics();

Console.WriteLine($"Average: {statistics.Average:N2}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");

SetSth(out statistics);

void SetSth(out Statistics statistics)
{
    statistics = new Statistics();
}