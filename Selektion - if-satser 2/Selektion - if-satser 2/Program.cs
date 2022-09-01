//2.
//Skapa ett program enligt följande instruktioner:
//Läs in ett tal från användaren.
//Om talet är större eller lika med 1, skriv ut "Större än 1.".
//Annars, skriv ut " - Fel: Endast tal som är större eller lika med 1".


Console.Write("Skriv in ett tal: ");
int number = int.Parse(Console.ReadLine());
if (number >= 1)
{
    Console.WriteLine("Större än 1.");
}
else
{
    Console.WriteLine(" - Fel: Endast tal som är större eller lika med 1");
}