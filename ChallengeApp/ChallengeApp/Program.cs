using System.Windows.Markup;

string pięść = "Kamień";
string palce = "Nożyce";
string dłoń = "Papier";

var gracz1 = pięść;
var gracz2 = pięść;

Console.WriteLine(gracz1 + " vs " + gracz2);

if  (gracz1 == pięść && gracz2 == palce)
{
    Console.WriteLine("Wygrywa gracza 1");
}
else if (gracz1 == pięść && gracz2 == dłoń)
{
    Console.WriteLine("Wygrywa gracza 2");
}
else if (gracz1 == palce && gracz2 == dłoń)
{
    Console.WriteLine("Wygrywa gracza 1");
}
else if (gracz1 == palce && gracz2 == pięść)
{
    Console.WriteLine("Wygrywa gracza 2");
}
else if (gracz1 == dłoń && gracz2 == palce)
{
    Console.WriteLine("Wygrywa gracza 2");
}
else if (gracz1 == dłoń && gracz2 == pięść)
{
    Console.WriteLine("Wygrywa gracza 1");
}
else
{
    Console.WriteLine("Remis");
}



