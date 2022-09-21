using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using static Utilities;

Console.WriteLine(HasValue("Does this have value?"));
Console.WriteLine(HasValue("   ")); // How about this?

Console.WriteLine(WordCount("bla bla bla"));

ToLineArray("Rad 1\r\nRad2\r\nRad3\r\nRad4\r\nRad5");

Console.WriteLine("4 is even?" + IsEven(4));
Console.WriteLine("5 is even?" + IsEven(5));

string userName = "MittUserName", lastLogin = "MittSenasteLogin";

string message = "Welcome {0} (Last login: {1})".FormatString(userName, lastLogin);
Console.WriteLine(message);


static class Utilities
{
    //Övning 1
    //Skriv en tilläggsmetod, HasValue, till typen string. Den skall returnera true om strängen innehåller något tecken annat än blanksteg
    public static bool HasValue(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    //Övning 2
    //Skriv en tilläggsmetod, WordCount, till typen string. Den skall returnera hur många ord som finns i strängen.
    public static int WordCount(string text)
    {
        string[] temp = text.Split(" ").ToArray();
        int count = temp.Length;
        return count;
    }

    //Övning 3
    //Skriv en tilläggsmetod, ToLineArray, till typen string. Den skall returnera en lista av strängar där varje rad i strängen är ett index i listan.

    public static List<string> ToLineArray(string text)
    {
        List<string> stringList = new List<string>(text.Split(Environment.NewLine).ToList());
        return stringList;
    }

    //Övning 4
    //Skriv en tilläggsmetod, IsEven, till typen int. Den skall returnera true om talet är jämnt.

    public static bool IsEven(int x)
    {
        if (x % 2 == 0)
            return true;
        else
            return false;
    }

    //Övning 5
    //Skriv en tilläggsmetod, IsNumeric, till typen string. Den skall returnera true om strängen kan göras om till ett heltal.

    public static bool IsNumeric(string text)
    {
        if (int.TryParse(text, out int result)) return true;

        else return false;
    }

    //Övning 6
    //Denna är lite klurig.Vi vill kunna skriva på följande sätt "string message = "Welcome { 0}
    //(Last login: {1})".FormatString(userName, lastLogin);" Det kräver en tilläggsmetod.Skriv den (obs tänk på att formatsträngen kan ta flera parametrar)

    public static string FormatString(this string text, string userName, string lastLogin)
    {
        text = text.Replace("{0}", userName).Replace("{1}", lastLogin);
        return text;
    }

}
