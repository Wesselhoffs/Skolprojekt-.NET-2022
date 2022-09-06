//6
//Skapa ett nytt projekt av typen Console App.
//Deklarera en array med fem minnesplatser som du döper till contactDetails.
//Tilldela den förnamn, efternamn, adress, telefonnummer och e-postadress.
//Skriv ut informationen utan att använda dig av iteration.

string[] contactDetails = new string[5];
contactDetails[0] = "Förnamn: Ludwig";
contactDetails[1] = "Efternamn: van Beethoven";
contactDetails[2] = "Adress: Bonngasse 24-26, 53111 Bonn";
contactDetails[3] = "Telefon: +49-(0)228-98175-25";
contactDetails[4] = "E-post museum@beethoven.de";

PrintArray(contactDetails.Length, 0);

void PrintArray(int i, int x)
{
    if (i > 0)
    {
        Console.WriteLine(contactDetails[x]);
        PrintArray(i - 1, x + 1);
    }
}



//Testa att skriva ut contactDetails[5]. Varför går det inte?

//För att det är 5 minnesplatser och man räknar inklulsive "0". Dvs -> 0, 1, 2, 3, 4. "5" Finns inte.