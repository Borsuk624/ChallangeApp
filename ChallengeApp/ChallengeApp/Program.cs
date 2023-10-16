string name = "Ewa";
int myAge = 30;
string sex = "kobieta";

if (name != "Ewa" && myAge < 30 && sex == "kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else
{
    Console.WriteLine("z poza badanej grupy");
}

if (name == "Ewa" && myAge == 30 && sex == "kobieta")
{
    Console.WriteLine("Ewa lat 30");
}
else
{
    Console.WriteLine("z poza badanej grupy");
}

if (name != "Ewa" && myAge < 18 && sex != "kobieta")
{
    Console.WriteLine("niepełnoletni mężczyna");
}
else
{
    Console.WriteLine("z poza badanej grupy");
}


// połączone

if (name == "Ewa" && myAge == 30 && sex == "kobieta")
{
    Console.WriteLine("Ewa, 30 lat");
}
else if (name != "Ewa" && myAge == 30 && sex == "kobieta")
{
    Console.WriteLine("kobieta, 30 lat");
}
else if (myAge < 30 && sex == "kobieta")
{
    Console.WriteLine("kobieta poniżej 30 lat");
}
else if (myAge < 30 && sex != "kobieta")
{
    if (myAge < 18 && sex != "kobieta")
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
