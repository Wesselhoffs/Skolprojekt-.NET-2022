//5.
//Skapa ett program enligt följande instruktioner:
//Skriv ut en meny:
//Välkommen till Restaurang Liljeholmskajen!
//======MENY======
//1. Dagens lunch
//2. Avsluta
//================
//Läs in ett menyval från användaren.
//Om användaren matar in en etta, skriv ut namnet på en maträtt.
//Om användaren matar in en tvåa, avsluta programmet.
//Environment.Exit(0);


Console.WriteLine("Välkommen till Restaurang Liljeholmskajen!");
Console.WriteLine("======MENY======");
Console.WriteLine("1. Dagens lunch");
Console.WriteLine("2. Avsluta");
Console.WriteLine("================");
Console.Write("Skriv in menyval: ");
int menuChoice = int.Parse(Console.ReadLine());
if (menuChoice == 1)
{
    Console.WriteLine("Dagens lunch är: Hel Special, med extra räksallad.");
}
else if (menuChoice == 2)
{
    Environment.Exit(0);
}