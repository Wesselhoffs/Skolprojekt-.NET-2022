
//1.
//Använd följande kod:
string text1 = "Ylvas%Kaffelager%KB%erbjuder%fri%frakt.";
//Bearbeta textsträngen så att output blir:
//Ylvas Kaffelager KB erbjuder fri frakt.
//Skriv ut resultatet med WriteLine-metoden.
Console.WriteLine(text1.Replace("%", " "));



//2.
//Använd följande kod:
string text2 = "?Nyhet: Mat-Mats störst i länet. Kantades av motgångar.";
//Bearbeta textsträngen(observera frågetecknet) så att output blir:
//Nyhet: Mat - Mats störst i länet. Kantades av motgångar.
Console.WriteLine(text2.Substring(1));



//3.
//Använd följande kod.
string text3 = "?Nyhet: Mat-Mats störst i länet.?Kantades av motgångar.?";
//Bearbeta textsträngen(observera frågetecknen) så att output blir:
//Nyhet: Mat - Mats störst i länet. Kantades av motgångar.
Console.WriteLine(text3.Replace("?", " ").Trim());



//4.
//Använd följande kod.
string text4 = "http://mat-mats.se/vi-soker-personal";
//Bearbeta textsträngen så att output blir:
//Mat - Mats
//Vi söker personal
Console.WriteLine(text4.Substring(7, 8).Replace("-", " - ").Replace("m", "M"));
Console.WriteLine(text4.Substring(19).First().ToString().ToUpper() + text4.Substring(20).Replace("-", " ").Replace("soker", "söker"));



//5.
//Använd följande kod.
string text5 = "Pop, Rock, Jazz, Soul, Hip Hop, Metal, Heavy Metal";
//Bearbeta textsträngen så att output blir:
//Pop
//Rock
//Jazz
//Soul
//Hip Hop
//Metal
//Heavy Metal
text5.Split(",").ToList().ForEach(x => Console.WriteLine(x.ToString().Trim()));



//6.
//Använd Compare-metoden för att undersöka på vilken plats i sorteringsordningen
//respektive katt hamnar.
//Använd följande kod:
string cat1 = "Alva";
string cat2 = "Frej";
//Skriv en if-sats som skriver ut vilken katt som hamnar före vilken.
//Output:
//Alva hamnar före Frej
if (String.Compare(cat1, cat2) < 0)
{
    Console.WriteLine($"{cat1} kommer före {cat2}. String.Compare");
}
else if (String.Compare(cat1, cat2) > 0)
{
    Console.WriteLine($"{cat2} kommer före {cat1}. String.Compare");
}
else
{
    Console.WriteLine($"{cat1} och {cat2} är likadana. String.Compare");
}



//7.
//Använd CompareTo-metoden för att undersöka på vilken plats i sorteringsordningen
//respektive katt hamnar.
//Kopiera koden du skrivit för övning 6.
//Istället för att använda String.Compare , anropa CompareTo-metoden.
//Tips:
//Du kommer att behöva använda en annan syntax.
if (cat1.CompareTo(cat2) < 0)
{
    Console.WriteLine($"{cat1} kommer före {cat2}. CompareTo");
}
else if (cat1.CompareTo(cat2) > 0)
{
    Console.WriteLine($"{cat2} kommer före {cat1}. CompareTo");
}
else
{
    Console.WriteLine($"{cat1} och {cat2} är likadana. CompareTo");
}



//8.
//Använd Equal-metoden för att undersöka om värdena är lika.
//Använd följande kod:
string genre1 = "Jazz";
string genre2 = "Pop";
//Skriv en if-sats som skriver ut om textsträngarna är lika eller inte.
