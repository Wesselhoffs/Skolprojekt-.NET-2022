//2.
//Använd följande kod:
//int[] numbers = { 12, 50, 72 };
//Addera talen med hjälp av en for-loop.
//Skriv ut summan.

int[] numbers = { 12, 50, 72 };
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine(sum);