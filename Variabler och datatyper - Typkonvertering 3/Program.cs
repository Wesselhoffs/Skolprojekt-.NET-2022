string firstInput, secondInput;
int firstNumber, secondNumber = 0, sum = 0;
bool isFirstNumberInt, isSecondNumberInt;

do
{
    Console.Write($"Skriv in heltal nr 1: ");
    firstInput = Console.ReadLine();
    isFirstNumberInt = int.TryParse(firstInput, out firstNumber);
    if (isFirstNumberInt)
    {
        do
        {
            Console.Write($"Skriv in heltal nr 2: ");
            secondInput = Console.ReadLine();
            isSecondNumberInt = int.TryParse(secondInput, out secondNumber);
            if (isSecondNumberInt)
            {
                sum = firstNumber + secondNumber;
            }
            else
            {
                Console.WriteLine($"Talet du har angett är inte ett heltal.\nFörsök igen");
            }
        } while (isSecondNumberInt == false);

    }
    else
    {
        Console.WriteLine($"Talet du har angett är inte ett heltal.\nFörsök igen");
    }
} while (isFirstNumberInt == false);


Console.WriteLine($"Summan av talen {firstNumber} och {secondNumber} är: {sum}");