//Övning 3
//Använd en lista av strängar för att symbolisera en kortlek. 
//T.ex. "k5" betyder klöver 5, "hKn" hjärter knekt, "sE" spader Ess, "rD" ruter dam, etc. 
//Var effektiv när du fyller listan och använd loop'ar. 
//Skriv sedan ett program som slumpvis drar kort från korleken tills dess att alla 52 kort är dragna. 
//Skriv ut varje kort du "drar".



List<string> deckOfCards = new();
Random random = new Random();

FillTheListWithCards();

for (int i = deckOfCards.Count; i > 0; i--)
{
    int row = random.Next(0, i);
    Console.WriteLine($"Drog kortet:\t{deckOfCards[row]}");
    deckOfCards.RemoveAt(row);
}
Console.WriteLine("adsasd");
void FillTheListWithCards()
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
        deckOfCards.Add(card);
    }
}


