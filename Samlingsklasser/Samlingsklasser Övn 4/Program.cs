//Övning 4
//Bygg vidare på Övning 3 men använd en Dictionary istället. 
//Som nyckel använder du "k5" etc eftersom dessa är unika i en kortlek på 52 kort. 
//Som värde lagrar du int, Ess = 1, Kung = 13, etc. 
//Dra nu två kort åt gången utan att "minska" kortleken och skriv ut "PAR" de gånger du drar två lika kort, dvs att värdet är lika. 
//För att lösa detta måste du slumpvis kunna välja en nyckel i Dictionary vilket du kan genom att gå på Keys i Dictionary som i sig är en lista. 
//Försök till sist beräkna hur många gånger det blir "PAR" om du gör 1000 dragningar.

Dictionary<string, int> deckOfCards = new();

FillDictionaryWithCards();

void FillDictionaryWithCards()
{
    for (int i = 0; i < 4; i++)
    {
        if (i == 0) AddCards("h");
        else if (i == 1) AddCards("s");
        else if (i == 2) AddCards("r");
        else if (i == 3) AddCards("k");

    }
}

void AddCards(string suite)
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