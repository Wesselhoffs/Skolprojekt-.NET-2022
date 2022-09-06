//1.
//Använd följande kod:
//string[] cars = { "Ford", "Cadillac", "Audi" };
//Använd Sort-metoden (googla) för att sortera bilmärkena i bokstavsordning.
//Skriv ut bilmärkena utan att använda dig av iteration.

string[] cars = { "Ford", "Cadillac", "Audi" };

Array.Sort(cars);

foreach (var car in cars)
{
    Console.WriteLine(car);
}