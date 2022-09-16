using System;

//1
//Skapa en metod som:
//Har en indataparameter av datatypen string som du döper till name.
//Skriver ut ett meddelande som inkluderar variabeln name

 void PrintName(string name)
{
    Console.WriteLine($"Välkommen {name}!");
}


//2
//Fortsätt med uppgift 1:
//Lägg till två inparametrar. Döp den ena till xp och den andra till level.
//Lägg till lite text till meddelandet.
//Inkludera xp och level.

void PrintNameV2(string name, int xp, int level)
{
    Console.WriteLine($"-----MEDELTIDA TURKU-----");
    Console.WriteLine($"Välkommen {name}!");
    Console.WriteLine($"XP:\t{xp}\nLevel:\t{level}");
}

//3
//Skapa en metod som:
//Läser in två tal, multiplicerar dem och returnerar resultatet.

int MultiplyTwo(int x, int y)
{
    return x * y;
}

//4
//Skapa en metod som:
//Läser in bruttolön och returnerar löneökning med 5 %.

int SalaryIncreaseFivePercent(int salary)
{
    return (int)Math.Round(salary * 1.05);
}

//5
//Skapa en metod som:
//Läser in en array av datatypen string och returnerar en string (d. v. s. konkatinerar
//all data).

string ArrayToString(string[] strings)
{
    return strings.ToString();
}