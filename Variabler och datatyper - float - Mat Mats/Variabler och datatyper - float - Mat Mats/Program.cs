Console.WriteLine($"Ange pris exklusive moms: ");
decimal exMoms = 0m;
exMoms = decimal.Parse(Console.ReadLine());
PrisPlusMoms(exMoms);

static void PrisPlusMoms(decimal exMoms)
{
    Console.WriteLine($"Beräknat pris inklusive moms: {Decimal.Round(exMoms * 1.06m, 2)}");
}