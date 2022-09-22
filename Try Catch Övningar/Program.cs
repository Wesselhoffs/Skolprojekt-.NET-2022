//Exempel 1
//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.Write("Ange din inkomst: ");
//        int inkomst = int.Parse(Console.ReadLine());
//        Console.Write("Ange antal timmar: ");
//        int timmar = int.Parse(Console.ReadLine());

//        Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");

//        Console.ReadKey();
//    }
//}

//#########################################################################################################################


//Övning 1
//Skriv om exempel 1 i artikeln till att hantera fel genom att fånga undantag.


//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            Console.Write("Ange din inkomst: ");
//            int inkomst = int.Parse(Console.ReadLine());
//            Console.Write("Ange antal timmar: ");
//            int timmar = int.Parse(Console.ReadLine());

//            Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");
//        }
//        catch (Exception e)
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine($"Error!!");
//            Console.ForegroundColor = ConsoleColor.Gray;
//            Console.WriteLine(e.Message);
//        }
//        Console.ReadKey();
//    }
//}

//#########################################################################################################################


//Övning 2
//I exempel 1 ovan så finns det fortfarande en möjlighet att krascha programmet.

//Vad är det som kan gå fel?
//Användaren kan mata in något som inte går att Parse'a till en integer. T.ex. en text eller ett decimaltal.

//Hur löser vi bäst problemet?
//Skriv om programmet för att se ifall inmatningarna går att konvertera, med exmpelvis TryParse istället för parse.

//class Program
//{
//    static void Main(string[] args)
//    {
//        try
//        {
//            bool didThisParse = false;
//            int inkomst = 0;
//            int timmar = 0;
//            while (didThisParse == false)
//            {
//                Console.Write("Ange din inkomst: ");
//                didThisParse = int.TryParse(Console.ReadLine(), out inkomst);
//                if (inkomst <= 0) didThisParse = false ;
//                if (didThisParse == false) Console.WriteLine("Bara positiva heltal accepteras här!");
//            }
//            didThisParse = false;
//            while (didThisParse == false)
//            {
//                Console.Write("Ange antal timmar: ");
//                didThisParse = int.TryParse(Console.ReadLine(), out timmar);
//                if (inkomst <= 0) didThisParse = false;
//                if (didThisParse == false) Console.WriteLine("Bara positiva heltal accepteras här!");
//            }

//            Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");
//        }
//        catch (Exception e)   // Lycka till att hitta några fel att fånga här!
//        {
//            Console.ForegroundColor = ConsoleColor.Red;
//            Console.WriteLine($"Error!!");
//            Console.ForegroundColor = ConsoleColor.Gray;
//            Console.WriteLine(e.Message);
//        }
//    }
//}

//#########################################################################################################################

//Övning 3
//Vilka exceptions kan du få vid en vanlig Console.WriteLine()?

//Kolla i hjälpen med F1 och läs dig till svaret.

//3 st, enligt - https://learn.microsoft.com/en-us/dotnet/api/system.console.writeline?view=net-7.0

//IOException
//An I/O error occurred.                          - Input / Output, läsa eller skriva filer/mappar osv.

//ArgumentNullException
//format is null.                                 - Formatet är null, dvs inget

//FormatException
//The format specification in format is invalid.  - Fel Format


//#########################################################################################################################


//Övning 4
//När kan finally vara riktigt användbar? Googla och se om du hittar ett bra exempel.

// Om man t.ex har en öppen anslutning till en fil/databas, så kan man spara/stänga den i ett finally block. 
// Eftersom koden i ett finally alltid körs, oavsett om man får errors eller inte.



//#########################################################################################################################


//Övning 5
//Skriv ett program som endast slänger ett undantag där du själv har skrivit felmeddelandet.
//Alltså undersök hur man skriver för att kasta ett undantag av valfri sort.


//try
//{
//Console.Write("Skriv in bokstaven A: ");
//string? a = Console.ReadLine();

//    if (a != "A")
//    {
//        throw new StringIsNotEqualToAException("Det där var inget stort A va? Skärpning");
//    }
//    else
//    {
//        Console.WriteLine($"Du skrev in bokstaven {a}");
//    }
//}
//catch (Exception e)
//{

//    Console.WriteLine(e);
//}
//finally
//{
//    Console.WriteLine("\n\nNu är vi i finally-blocket och skriver ut lite text, hej hej!");
//}


//public class StringIsNotEqualToAException : Exception
//{
//    public StringIsNotEqualToAException()
//    {
//    }

//    public StringIsNotEqualToAException(string message)
//        : base(message)
//    {
//    }

//    public StringIsNotEqualToAException(string message, Exception inner)
//        : base(message, inner)
//    {
//    }
//}


//#########################################################################################################################




//Övning 6
//I artikeln nämns att en metod skulle kunna införas i exemplet "Felhantering TryParse". Skriv denna metod och för in i lösningen.

//class Program
//{
//    static void Main(string[] args)
//    {
//        int inkomst = 0;
//        int timmar = 0;

//        Console.Write("Ange din inkomst: ");
//        inkomst = GetNonNegativeIntFromUser();

//        Console.Write("Ange antal timmar: ");
//        timmar = GetNonNegativeIntFromUser();

//        Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");
//    }

//    private static int GetNonNegativeIntFromUser()
//    {
//        int result = 0;
//        bool isItACorrectInt = false;
//        while (isItACorrectInt == false)
//        {
//            isItACorrectInt = int.TryParse(Console.ReadLine(), out result) && result > 0;
//            if (isItACorrectInt == false) Console.WriteLine("Bara positiva heltal i lagom storlek tack !\nInget annat");
//        }
//        return result;
//    }
//}


//#########################################################################################################################



//Övning 7
//Konstruera ett program som ber om inmatning för "start", "stop" och "steg". 
//Programmet skall sedan baserat på inmatningen göra en for-loop och skriva ut de tal som styr for-loop'en enligt bild nedan.
//https://csharpskolan.se/image.php?id=379
//Programmet ska vara tåligt mot fel och klara felaktiga inmatningar.


bool allValuesAreFine = false;

while (allValuesAreFine == false)
{
    int start = 0;
    int stop = 0;
    int steg = 0;
    Console.Write("Mata in startvärde för loopen: ");
    start = GetLoopValue();
    Console.Write("Mata in värde där loopen ska stanna: ");
    stop = GetLoopValue();
    Console.Write("Mata in värde för hur stora steg loopen ska ta: ");
    steg = GetLoopValue();

    if (start < stop && (stop - start) > steg)
    {
        allValuesAreFine = true;
        for (int i = start; i <= stop; i += steg)
        {
            Console.Write($"{i} ");
        }
    }
    else Console.WriteLine("\nNågon inmatning gick snett, försök igen!\n" +
                           "Slutvärdet måste vara större än startvärdet.\n" +
                           "Och stegvärdet måste vara mindre än differansen mellan stop- och startvärdet\n");
}


static int GetLoopValue()
{
    int result = 0;
    bool isItACorrectInt = false;
    while (isItACorrectInt == false)
    {
        isItACorrectInt = int.TryParse(Console.ReadLine(), out result) && result > 0;
        if (isItACorrectInt == false) Console.WriteLine("Bara positiva heltal i lagom storlek tack!");
    }
    return result;
}