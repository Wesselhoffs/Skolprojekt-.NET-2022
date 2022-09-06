//5
//Skapa ett nytt projekt av typen Console App.
//Deklarera en array med fem minnesplatser som du döper till animals.
//Tilldela den namnen på fem djurarter.
//Skriv ut namnen på djurarterna med hjälp av en foreach-loop.

string[] animals = new string[5];
animals[0] = "Krokodil";
animals[1] = "Häst";
animals[2] = "Bananfluga";
animals[3] = "Katt";
animals[4] = "Hund";

foreach (string animal in animals)
{
    Console.WriteLine(animal);
}
