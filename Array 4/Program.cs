//4.
//Skapa en tvådimensionell array (googla) innehållande boktitel och pris för tre
//böcker.
//Skriv ut informationen till användaren med hjälp av en for-loop.

string[,] books = new string[,] { { "Varje dag är en fest", "169" }, { "Musse och Helium, Jakten på guldosten", "119" }, { "Pannkakstårtan", "139" } };

for (int i = 0; i < books.Length / 2; i++)
{
    Console.WriteLine($"Boken \"{books[i, 0]}\" kostar: {books[i, 1]}kr.");
}