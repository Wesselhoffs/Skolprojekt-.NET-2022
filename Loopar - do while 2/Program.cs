//2
//Skapa ett program som:
//Låter användaren gissa på ett tal mellan 1 och 10.
//Om talet är rätt, skriv ut "Grattis! Du gissade rätt.".
//Annars, skriv ut "Fel! Försök igen.".

Random random = new Random();
int number = random.Next(0, 11);
int guess;

Console.WriteLine("Gissa på ett tal mellan 1 och 10");
do
{
    guess = int.Parse(Console.ReadLine());
    if (guess == number)
    {
        Console.WriteLine("Grattis! Du gissade rätt.");
        break;
    }
    Console.WriteLine("Fel! Försök igen.");
} while (guess != number);

