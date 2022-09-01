//6.
//Skapa ett program enligt följande instruktioner:
//Skriv ut en instruktion till användaren:
//Ange antal grader:
//Läs in ett tal från användaren.
//Om antal grader är högre eller lika med 20, skriv ut "Sommarkläder".
//Annars om antal grader är mindre eller lika med 10, skriv ut "Höstkläder".
//Annars om antal grader är mindre eller lika med 0, skriv ut "Vinterkläder".


//Console.WriteLine("Hur varmt är det ute idag?");
//double degrees = double.Parse(Console.ReadLine());
//if (degrees >= 20)
//{
//    Console.WriteLine("Sommarkläder");
//}
//else if (degrees <= 10)
//{
//    Console.WriteLine("Höstkläder");
//}
//else if (degrees <= 0)
//{
//    Console.WriteLine("Vinterkläder");
//}


//Någon på kontoret har testat programmet. Det fungerar inte som det ska.
//Lös följande problem:
//Vad händer om användaren matar in 17?
//Vad händer om användaren matar in -3? Höstkläder?


Console.WriteLine("Hur varmt är det ute idag?");
double degrees = double.Parse(Console.ReadLine());
if (degrees >= 20)
{
    Console.WriteLine("Sommarkläder");
}
else if (degrees >= 10) 
{
    Console.WriteLine("Höstkläder");
}
else if (degrees < 10) 
{
    Console.WriteLine("Vinterkläder");
}