//7.
//Skapa ett program enligt följande instruktioner:
//Spara ett slumptal.
//Skriv ut en instruktion till användaren:
//Gissa talet:
//Läs in ett tal från användaren.
//Om talet är samma som slumptalet, skriv ut "Du gissade rätt".
//Om talet är mindre än slumptalet, skriv ut "För lågt".
//Om talet är större än slumptalet, skriv ut "För högt".


Random rnd = new Random();
int num = rnd.Next(0, 101);
int guess = 0;

Console.WriteLine("Gissa på ett tal mellan 0 och 100");
do
{
    guess = int.Parse(Console.ReadLine());
    if (guess < num)
    {
            Console.WriteLine("Du gissade för lågt, gissa igen!");
    }
    else if (guess > num)
    {
            Console.WriteLine("Du gissade för högt, gissa igen!");
    }
    else if (guess == num)
    {
        Console.WriteLine("Du gissade rätt!");
       
    }
} while (guess != num);



