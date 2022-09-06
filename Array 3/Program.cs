//3.
//Deklarera en string array.
//Tilldela den fem filmtitlar.
//Använd Sort-metoden för att sortera titlarna i bokstavsordning.
//Skriv ut filmtitlarna med hjälp av en for-loop.

string[] movies = { "Top Gun", "Scarface", "Mamma Mu och Kråkan", "Den otroliga vandringen", "The Holiday" };

Array.Sort(movies);

for (int i = 0; i < movies.Length; i++)
{
    Console.WriteLine(movies[i]);
}
