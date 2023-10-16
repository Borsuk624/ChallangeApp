string name = "Ewa";
int age = 3;
string sex = "kobiedta";

if (sex != "kobieta")
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
else if (age > 30)
{
    Console.WriteLine("kobieta powyżej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, 30 lat");
}
else if (age == 30)
{
    Console.WriteLine("kobieta, 30 lat");
}
else if (age < 30)
{
    if (age < 18)
    {
        Console.WriteLine("niepełnoletnia kobieta");
    }
    else
    {
        Console.WriteLine("kobieta poniżej 30 lat");
    }
}
