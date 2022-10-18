using System.Diagnostics.Metrics;
using System.Net.Http.Json;
using System.Net.Mail;
using System.Text.RegularExpressions;

var catHotel = new List<Room>() { new Room(new Cat("Pelle Svanslös", 2), 1), new Room(new Cat("Skorpan", 1), 2), new Room(new Cat("Sir MjausAlot", 5), 3) };

var query = catHotel.SelectMany(room => room.Cats.Where(cat => cat.Age > 5).Select(cat => cat.Name += " finns i rum " + room.Number + " och är " + cat.Age + " år gammal"));

foreach (var cat in query)
{
    Console.WriteLine(cat);
}






//Uppgift - Aggregate functions
//Använd array med heltal från demo.
//Skriv en LINQ query som väljer alla tal som är större än 30.
//Skriv ut medelvärde, antal tal större än 30, summan av alla tal större än 30, det minsta
//talet och det största talet.
// ------------------------------------------------
// Array innehållande heltal
// ------------------------------------------------
var numbers = new int[] { 43, 42, 57, 23, 24, 25, 65, 64, 34, 12, 13, 14, 1, 3, 2, };


var numbersQuery = numbers.Where(n => n > 30).ToList();

Console.WriteLine($"Numbers above 30: {numbersQuery.Count}\nMax number: {numbersQuery.Max()}\nMin number: {numbersQuery.Min()}\nSum of all numbers above 30: {numbersQuery.Sum()}");
Console.WriteLine(numbersQuery.Aggregate(0,(sum, next) => sum += next));



//Uppgift - Reguljära uttryck(IsMatch)
//Använd IsMatch-metoden för att validera följande:
//Mobilnummer inkusive +46 (t.ex. +46XXXXXXXXX).
//E - postadressen info @matmats.se.
//Webbadressen www.matmats.se.
//Skriv ut resultatet med hjälp av WriteLine-metoden.
//Exempel (output):
//Mobilnummer: True
//E-postadress: True
//Webbadress: True
string testNumber = "+46123456789";
string testEmail = "info@matmats.se";
string testWebsite = "www.matmats.se";

Regex validNumber = new Regex(@"\+46\d+");
Regex validEmail = new Regex(@"^[a-zA-Z]\w*@\w+\.[a-zA-Z]{2,}$");
Regex validWebsite = new Regex(@"www.\w+.se");

Console.WriteLine(validNumber.IsMatch(testNumber));
Console.WriteLine(validEmail.IsMatch(testEmail));
Console.WriteLine(validWebsite.IsMatch(testWebsite));




//Uppgift - Reguljära uttryck(Replace och Match)
//Använd följande kod:
string text = "Idag är det      onsdag!";
//Skriv reguljära uttryck som:
//Tar bort extra mellanslag.
//Söker efter ordet "onsdag".
//Skriv ut resultatet.

string removeWhitespaces = Regex.Replace(text, @"\s+", " ");
var whereIsWednesday = Regex.Match(removeWhitespaces, @"onsdag");
Console.WriteLine(text);
Console.WriteLine(removeWhitespaces);
Console.WriteLine($"Onsdag börjar på index: {whereIsWednesday.Index}");









class Room
{
    public int Number { get; set; }
    public List<Cat> Cats { get; set; }
    public Room(Cat cat, int number)
    {
        Cats = new List<Cat>()
        {
            new Cat("Smulan", 12),
            new Cat("Kattskrälle", 7),
            new Cat("Gräddnos", 5),
            new Cat("Sulan", 3)
        };
        Cats.Add(cat);
        Number = number;
    }
}

class Cat
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Cat(string name, int age)
    {
        Name = name;
        Age = age;
    }
}