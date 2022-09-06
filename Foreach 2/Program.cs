//Testa själv 2)
//Deklarera en array av datatypen string som du tilldelar tre boktitlar.
//Skriv ut boktitlarna med hjälp av en foreach-loop.


string[] books = { "Very good book nr 1", "Not so very good book nr 2,", "Hilarious book nr 3" };

foreach (var book in books)
{
    Console.WriteLine(book);
}