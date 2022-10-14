//Skapa ett nytt projekt av typen ConsoleApp i Visual Studio.
//Använd följande kod:
var numbers = new int[] { 99, 33, 22, 51, 71, 81, 32, 52, 62 };
//Skriv en LINQ query som väljer alla tal som är större än 50.
//Skriv ut talen med hjälp av en Foreach-loop.
//Ledtråd:
//Jämförelseoperator

numbers.Where(n => n > 50).ToList().ForEach(n => Console.WriteLine(n));