//4.
//Skapa ett program enligt följande instruktioner:
//Läs in två tal från användaren.
//Addera talen.
//Om summan är jämnt delbart med 2, skriv ut "Jämnt tal.", annars "Udda tal."

Console.Write("Skriv in ett heltal: ");
int firstNumber = int.Parse(Console.ReadLine());
Console.Write("Skriv in ett heltal till: ");
int secondNumber = int.Parse(Console.ReadLine());
int sum = firstNumber + secondNumber;
Console.WriteLine($"Summan är {sum}");
if (sum % 2 == 0)
{
    Console.WriteLine("Jämnt tal.");
}
else
{
    Console.WriteLine("Udda tal.");
}