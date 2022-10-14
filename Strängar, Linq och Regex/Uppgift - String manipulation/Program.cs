//Använd följande kod:
//string text = "Nyhet: Stadsdelen får en ny park";
//Skapa ett program som:
//Klipper ut och kopierar "Stadsdelen får en ny park" till en ny textsträng.
//Skriver ut huruvida texten är längre än ursprungstexten, kortare än ursprungstexten
//eller om den är oförändrad.


string text = "Nyhet: Stadsdelen får en ny park";

string substringText = text.Substring(7);

Console.WriteLine(text.Length < substringText.Length ? "Den nya texten är längre än ursprungstexten" : "Den nya texten är kortare än ursprungstexten");

    