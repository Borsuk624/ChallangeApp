using ChallengeApp;

Console.WriteLine("Witamy w naszym programie do oceny pracowników");
Console.WriteLine("==============================================");
Console.WriteLine("Aby zobaczyć wyniki wprowadź q");
Console.WriteLine();

var supervisor = new Supervisor("adam", "sandler", "Facet");

while (true)
{
    Console.WriteLine("Podaj kolejną ocenę pracownika:");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }

    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception catched: {e.Message}");
    }
}

var statistics = supervisor.GetStatistics();
Console.WriteLine($"Average: {statistics.Average}");
Console.WriteLine($"Min: {statistics.Min}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Grade: {statistics.AverageLetter}");
