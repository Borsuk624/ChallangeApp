using static System.Runtime.InteropServices.JavaScript.JSType;

int number = 9159;
string numberAsString = number.ToString();
char[] digits = numberAsString.ToArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;


foreach (char digit in digits)
{
    if (digit == '0')
    {
        counter0++;
    }
    else if (digit == '1') 
    {
        counter1++;
    }
     else if (digit == '2') 
    {
        counter2++;
    }
     else if (digit == '3') 
    {
        counter3++;
    }
     else if (digit == '4') 
    {
        counter4++;
    }
     else if (digit == '5') 
    {
        counter5++;
    }
     else if (digit == '6') 
    {
        counter6++;
    }
     else if (digit == '7') 
    {
        counter7++;
    }
     else if (digit == '8') 
    {
        counter8++;
    }
    else
    {
        counter9++;
    }
}

Console.WriteLine("liczba cyfr 0 w liczbie " + number + " to " + counter0);
Console.WriteLine("liczba cyfr 1 w liczbie " + number + " to " + counter1);
Console.WriteLine("liczba cyfr 2 w liczbie " + number + " to " + counter2);
Console.WriteLine("liczba cyfr 3 w liczbie " + number + " to " + counter3);
Console.WriteLine("liczba cyfr 4 w liczbie " + number + " to " + counter4);
Console.WriteLine("liczba cyfr 5 w liczbie " + number + " to " + counter5);
Console.WriteLine("liczba cyfr 6 w liczbie " + number + " to " + counter6);
Console.WriteLine("liczba cyfr 7 w liczbie " + number + " to " + counter7);
Console.WriteLine("liczba cyfr 8 w liczbie " + number + " to " + counter8);
Console.WriteLine("liczba cyfr 9 w liczbie " + number + " to " + counter9);


