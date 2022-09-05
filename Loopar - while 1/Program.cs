//1
//Skapa ett program som:
//Skriver ut en meny så länge som variabeln run har värdet true.
//Om användaren matar in en tvåa bryts loopen.
//Annars, skrivs menyn ut med instruktion till användaren om att mata in en etta eller
//en tvåa (se exempel på nästa sida).

//------------------------------------------------
//Västberga Kapitalförvaltning
//------------------------------------------------
//Det bästa valet (förhoppningsvis) för dina sparade pengar
//************************************************
//======MENY======
//1. Logga in
//2. Avsluta
//================
//>3
//- Ogiltigt val: 1 för att logga in eller 2 för att avsluta
//======MENY======
//1. Logga in
//2. Avsluta
//================
//>


Console.WriteLine("------------------------------------------------");
Console.WriteLine("Västberga Kapitalförvaltning");
Console.WriteLine("------------------------------------------------");
Console.WriteLine("Det bästa valet (förhoppningsvis) för dina sparade pengar");
Console.WriteLine("************************************************");

bool run = true;
while (run == true)
{
    Console.WriteLine("======MENY======");
    Console.WriteLine("1. Logga in");
    Console.WriteLine("2. Avsluta");
    Console.WriteLine("================");
    Console.Write("Menyval: ");
    int menyChoice = int.Parse(Console.ReadLine());

    switch (menyChoice)
    {
        case 1:
            Console.WriteLine("Du är inloggad");        
            continue;
        case 2:
            Console.WriteLine("Avslutar programmet");
            run = false;
            continue;

        default:
            Console.WriteLine("- Ogiltigt val: 1 för att logga in eller 2 för att avsluta");
            continue;      
    }
}