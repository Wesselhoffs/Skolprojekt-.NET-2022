//1.
//Skapa ett nytt projekt av typen ConsoleApp i Visual Studio.
//Använd följande kod:
using System.ComponentModel.Design;

var numbers = new int[] { 10, 30, 64, 54, 67, 87, 43, 53, 23, 13, 67, 27 };
//Skriv en LINQ query som väljer alla tal som är mindre än 30.
//Skriv ut talen med hjälp av en Foreach-loop.
//Ledtråd:
//Jämförelseoperator
numbers.Where(number => number < 30).ToList().ForEach(number => Console.WriteLine(number));

Console.WriteLine("\n-------------\n");



//2.
//Skapa ett nytt projekt av typen ConsoleApp i Visual Studio.
//Använd följande kod:
var numbers_2 = new int[] { 10, 30, 64, 54, 67, 87, 43, 50, 23, 13, 67, 27 };
//Skriv en LINQ query som väljer alla tal som är mindre eller lika med 50.
//Dessutom:
//Omvandla resultatet till en array.
//Summera resultatet.
//Skriv ut summan.
//Tips:
//ToArray
//Sum-metoden
Console.WriteLine(numbers_2.Where(number => number <= 50).ToArray().Sum());


Console.WriteLine("\n-------------\n");


//3.
//Använd följande kod:
var customers = new Customer[] {
new Customer("Fredrik", "Stockholm"),
new Customer("Anna", "Helsinki"),
new Customer("Otto", "Helsinki"),
new Customer("Maria", "Amsterdam"),
new Customer("Julia", "Oslo"),
new Customer("August", "Oslo"),
new Customer("Laurits", "Copenhagen"),
new Customer("Karl", "Copenhagen"),
new Customer("Erik", "Stockholm"),
new Customer("Johan", "Stockholm"),
};

//Skriv en LINQ query som väljer alla kunder där City är lika med Helsinki.
//Skriv ut kundinformationen med hjälp av en Foreach-loop.
customers.Where(customer => customer.City == "Helsinki").Select(customer => customer).ToList().ForEach(customer => Console.WriteLine($"{customer.FirstName} lives in {customer.City}"));

Console.WriteLine("\n-------------\n");



//4.
//Använd koden från övningsuppgift 3.
//Skriv en LINQ query som sorterar alla kunder på FirstName i alfabetisk ordning.
//Tips:
//orderby
//Skriv ut kundinformationen med hjälp av en Foreach-loop.
customers.OrderBy(customer => customer.FirstName).ToList().ForEach(customer => Console.WriteLine(customer.FirstName + "\t" + customer.City));

Console.WriteLine("\n-------------\n");

//5.
//Använd koden från övningsuppgift 3.
//Skriv en LINQ query som grupperar alla kunder efter City .
//Ledtråd:
//group by
//Tips:
//Läs: https://learn.microsoft.com/en-us/dotnet/csharp/programmingguide/concepts/linq/basic-linq-query-operations
var cityGrouped = from customer in customers
                  group customer by customer.City;
foreach (var groupOfCustomer in cityGrouped)
{
    foreach (var customer in groupOfCustomer)
    {
        Console.WriteLine(customer.FirstName + "\t" + customer.City);
    }
}

Console.WriteLine("\n-------------\n");



//6.
//Använd koden från övningsuppgift 3.
//Skriv en LINQ query med lambda-uttryck som lägger till "Förnamn: " innan FirstName .
//Tips:
//Select    

//customers.Select(customer => customer.FirstName = "Förnamn: " + customer.FirstName).ToList().ForEach(customer => Console.WriteLine(customer));

Console.WriteLine("\n-------------\n");



//7.
//Använd koden från övningsuppgift 3.
//Skriv en LINQ query med lambda-uttryck som genererar en textsträng innehållande alla
//förnamn separerade med kommatecken.
//Tips:
//Konvertera char array till string
//Trim
//Ledtrådar:
//SelectMany
//ToArray
//Output:
//Fredrik, Anna, Otto, Maria, Julia, August, Laurits, Karl, Erik, Johan

var allNames = customers.Select(customer => customer.FirstName).Aggregate("", (result, next) => result += next + ", ");
Console.WriteLine(allNames.Substring(0, (allNames.Length - 2)));

public class Customer
{
    public string FirstName { get; set; }
    public string City { get; set; }
    public Customer(string firstName, string city)
    {
        FirstName = firstName;
        City = city;
    }
}