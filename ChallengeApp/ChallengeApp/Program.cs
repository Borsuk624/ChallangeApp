string name = "Ewa";
int age = 30;
string sex = "kobieta";

// połączone

if (name == "Ewa" && age == 30 && sex == "kobieta")
{
    Console.WriteLine("Ewa, 30 lat");
}
else if (age == 30 && sex == "kobieta")
{
    Console.WriteLine("kobieta, 30 lat");
}
else if (age < 30 && sex == "kobieta")
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else if (age < 30 && sex != "kobieta")
{
    if (age < 18)
    {
        Console.WriteLine("niepełnoletni mężczyzna");
    }
    else
    {
        Console.WriteLine("pełnoletni mężczyzna");
    }
}
else
{
    Console.WriteLine("z poza badanej grupy");
}
