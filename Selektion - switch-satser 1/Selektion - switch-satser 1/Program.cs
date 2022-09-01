//1.
//Skapa ett program som:
//Skriver ut en meny.
//Låter användaren mata in en siffra.
//Skriver ut användarens menyval (se exempel på nästa sida).

//------------------------------------------------
//Västberga Kapitalförvaltning
//------------------------------------------------
//Det bästa valet (förhoppningsvis) för dina sparade pengar
//************************************************
//======MENY======
//1. Affärsidé
//2. Om oss
//================
//>2
//-----Om oss-----
//Vårt kontor ligger i Västberga.

Console.WriteLine("------------------------------------------------");
Console.WriteLine("Västberga Kapitalförvaltning");
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Det bästa valet (förhoppningsvis) för dina sparade pengar");
Console.WriteLine("************************************************");
Console.WriteLine("======MENY======");
Console.WriteLine("1. Affärsidé");
Console.WriteLine("2. Om oss");
Console.WriteLine("================");
Console.Write("Menyval: ");
int x = int.Parse(Console.ReadLine());

switch (x)
{
	case 1:

		Console.Clear();
		Console.WriteLine("----Affärsidé----\nHit med pengarna!");
		break;

	case 2:
        Console.Clear();
        Console.WriteLine("-----Om oss-----<\nVårt kontor ligger i Västberga.");
        break;

	default:
        Console.Clear();
        Console.WriteLine("Något gick fel!");
		break;
}