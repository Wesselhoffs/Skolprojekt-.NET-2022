//3
//Skapa ett program enligt följande instruktioner:
//Läs in ett tal från användaren.
//Skriv ut alla tal mellan 1 och det nummer som användaren har matat in.
//Om talet är mindre eller lika med 0, skriv ut ett felmeddelande.

Console.Write("Mata in ett heltal: ");
int tal = int.Parse(Console.ReadLine());
if (tal <= 0)
{
    Console.WriteLine("FEL! Talet måste vara större än 0.");
}
else
{
    for (int i = 1; i <= tal; i++)
    {
        Console.WriteLine(i);
    }
}
