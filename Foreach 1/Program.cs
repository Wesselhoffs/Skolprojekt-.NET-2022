//Testa själv 1)
//Deklarera en array av datatypen int som du tilldelar tre tal.
//Deklarera en variabel av typen int som du döper till sum.
//Skapa en foreach-loop.
//Addera varje tal till sum.
//Skriv ut sum.
//Kör programmet och använd debug-läget för att lösa eventuella buggar

int[] intArray = { 5, 12, 27 };
int sum = 0;

foreach (var number in intArray)
{
    sum += number;
}

Console.WriteLine(sum);