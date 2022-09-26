//Övning 2
//Skapa ett program där du tillåts att mata in tal tills dess att du matar in 0 då avslutas programmet. 
//Efter varje inmatat tal skall du skriva ut medelvärdet av alla tal som matats in.

List<double> inputs = new List<double>();
CollectInputsUntilZero();


void CollectInputsUntilZero()
{
    bool inputIsZero = false;

    Console.WriteLine("Mata in värden, mata in en nolla för att avsluta inmatningen");
    while (inputIsZero == false)
    {
        if (double.TryParse(Console.ReadLine(), out double input) && input != 0)
        {
            inputs.Add(input);
            Console.WriteLine($"Medelvärde: {CalculateAverageOfList()}");
        }
        else if (input == 0)
        {
            inputIsZero = true;
            Console.WriteLine("Tack o hej!");
        }
    }
}

double CalculateAverageOfList()
{
    double average = (inputs.Sum() / inputs.Count);
    return Math.Round(average);
}


