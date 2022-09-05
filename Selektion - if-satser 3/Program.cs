//3.
//Skapa ett program enligt följande instruktioner:
//Läs in ett tal från användaren.
//Om talet adderat med 5 är större eller lika med 10, skriv ut "Korrekt inmatning".
//Annars om talet adderat med 4 är större eller lika med 10, skriv ut "Korrekt
//inmatning".
//Annars, skriv ut " - Fel: Mata in ett värde som är större eller lika med 5 eller 6".

Console.Write("Skriv in ett heltal: ");
int number = int.Parse(Console.ReadLine());
if (number + 5 >= 10)
{
    Console.WriteLine("Korrekt inmatning");
}

else if (number + 4 >= 10)
{
    Console.WriteLine("Korrekt inmatning");
}

else
{
    Console.WriteLine(" - Fel: Mata in ett värde som är större eller lika med 5 eller 6");
}