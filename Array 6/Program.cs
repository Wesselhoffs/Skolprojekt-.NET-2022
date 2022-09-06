//6
//Skapa ett nytt projekt av typen Console App.
//Deklarera en array med fem minnesplatser som du döper till contactDetails.
//Tilldela den förnamn, efternamn, adress, telefonnummer och e-postadress.
//Skriv ut informationen utan att använda dig av iteration.

string[] contactDetails = new string[5];
contactDetails[0] = "Ludwig";
contactDetails[1] = "van Beethoven";
contactDetails[2] = "Bonngasse 24-26, 53111 Bonn";
contactDetails[3] = "+49-(0)228-98175-25";
contactDetails[4] = "museum@beethoven.de";

Console.WriteLine($"Mina Kontaktuppgifter\n\n" +
    $"Förnamn:\t{contactDetails[0]}\n" +
    $"Efternamn:\t{contactDetails[1]}\n" +
    $"Adress:\t\t{contactDetails[2]} \n" +
    $"Telefon:\t{contactDetails[3]} \n" +
    $"E-post:\t\t{contactDetails[4]}");



//Testa att skriva ut contactDetails[5]. Varför går det inte?

//För att det är 5 minnesplatser och man räknar inklulsive "0". Dvs -> 0, 1, 2, 3, 4. "5" Finns inte.