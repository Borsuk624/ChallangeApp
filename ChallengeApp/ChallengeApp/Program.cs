using ChallengeApp;

Employee employee1 = new Employee("Adam ", "Tarko", 22);
Employee employee2 = new Employee("Ada ", "Maze", 23);
Employee employee3 = new Employee("Adaś ", "Logan", 24);

employee1.AddScore(1);
employee1.AddScore(2);
employee1.AddScore(5);
employee1.AddScore(2);
employee1.AddScore(2);

employee2.AddScore(5);
employee2.AddScore(3);
employee2.AddScore(5);
employee2.AddScore(6);
employee2.AddScore(7);

employee3.AddScore(8);
employee3.AddScore(2);
employee3.AddScore(5);
employee3.AddScore(3);
employee3.AddScore(9);

int result1 = employee1.Result;
int result2 = employee2.Result;
int result3 = employee3.Result;

List<Employee> Employees = new List<Employee>()
        {
        employee1, employee2, employee3
        };

int maxResult = -1;
Employee employeeWithMaxResult = null;

foreach (var employee in Employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWithMaxResult = employee;
    }
}

Console.WriteLine("Najwyższy wynik - " + employeeWithMaxResult.Result + " punktów - zdobył " + employeeWithMaxResult.Name + employeeWithMaxResult.Surname + " lat " + employeeWithMaxResult.Age);
