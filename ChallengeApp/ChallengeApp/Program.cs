var name = "Ewa";
var myAge = 30;
var sex = "kobieta";


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
else if (myAge < 30 && sex == "mężczyzna")
{
    Console.WriteLine("niepełnoletni mężczyzna");
}
else if (myAge < 30 && sex == "mężczyzna")
{
    Console.WriteLine("niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("z poza badanej grupy");
}
