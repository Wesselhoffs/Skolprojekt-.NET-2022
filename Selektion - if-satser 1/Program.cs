//1.
//Skapa ett program enligt följande instruktioner:
//Läs in ett tal från användaren.
//Om talet är större än 1, skriv ut "Större än 1.".

Console.Write($"Skriv in ett heltal: ");
int number = int.Parse(Console.ReadLine());

if (number > 1)
{
    Console.WriteLine($"{number} är större än 1");
}