//Skapa en dictionary med int som nyckel och int som värde

//Bytte till en SortedList
SortedList<int, int> resultat = new SortedList<int, int>();

//skapa ett Random objekt för att slumpa
Random random = new Random();

//Gör tusen upprepnigar
for (int i = 0; i < 1000; i++)
{
    //Slumpa tal mellan 1 och 6
    int tal = random.Next(1, 7);

    //Lägg nyckel om denna inte redan finns
    if (!resultat.ContainsKey(tal))
        resultat.Add(tal, 0);

    //Öka förekomsten av tal
    resultat[tal]++;
}

//Visa resultatet

//Voila, utskriften är sorterad i stigande storlek, På Key-värdet
foreach (KeyValuePair<int, int> kvp in resultat)
{
    Console.WriteLine("Nyckel: {0} Värde: {1}", kvp.Key, kvp.Value);
}
