//Övning 4
//Bygg vidare på Övning 3 men använd en Dictionary istället. 
//Som nyckel använder du "k5" etc eftersom dessa är unika i en kortlek på 52 kort. 
//Som värde lagrar du int, Ess = 1, Kung = 13, etc. 
//Dra nu två kort åt gången utan att "minska" kortleken och skriv ut "PAR" de gånger du drar två lika kort, dvs att värdet är lika. 
//För att lösa detta måste du slumpvis kunna välja en nyckel i Dictionary vilket du kan genom att gå på Keys i Dictionary som i sig är en lista. 
//Försök till sist beräkna hur många gånger det blir "PAR" om du gör 1000 dragningar.

Dictionary<string, int> deckOfCards = new();
Random random = new Random();
int pairCounter = 0;

FillDictionaryWithCards();
bool parseSuccessfull = false;
while (parseSuccessfull == false)
{

    Console.WriteLine("Hur många dragningar vill du göra?");
    if (parseSuccessfull = int.TryParse(Console.ReadLine(), out int amountOfDraws) && amountOfDraws > 0)
    {
        for (int i = 0; i < amountOfDraws; i++)
        {
            DrawAPairAndCompare();
        }
        Console.WriteLine($"Du fick: {pairCounter} par på {amountOfDraws} dragningar!");
    }
    else
    {
        Console.WriteLine("Du kan bara mata in positiva heltal. Försök igen\n");
    }
}



void FillDictionaryWithCards()
{
    for (int i = 0; i < 4; i++)
    {
        if (i == 0) AddCardsOfThisSuite("h");
        else if (i == 1) AddCardsOfThisSuite("s");
        else if (i == 2) AddCardsOfThisSuite("r");
        else if (i == 3) AddCardsOfThisSuite("k");

    }
}

void AddCardsOfThisSuite(string suite)
{
    for (int x = 1; x <= 13; x++)
    {
        string card = ($"{suite}{x}".Replace("11", "Kn")
                                    .Replace("12", "D")
                                    .Replace("13", "Ku")
                                    .Replace("1", "E")
                                    .Replace("E0", "10"));
        deckOfCards.Add(card, x);
    }
}

void DrawAPairAndCompare()
{
    int firstRandom = random.Next(0, 52);
    int secondRandom = random.Next(0, 52);
    while (secondRandom == firstRandom)
    {
        secondRandom = random.Next(0, 52);
    }

    if (deckOfCards.ElementAt(firstRandom).Value == deckOfCards.ElementAt(secondRandom).Value)
    {
        Console.WriteLine($"Du fick ett par! {deckOfCards.ElementAt(firstRandom).Key} + {deckOfCards.ElementAt(secondRandom).Key}");
        pairCounter++;
    }

}