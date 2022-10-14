//------------------------------------------------
// Array innehållande Book
//------------------------------------------------
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;

var books = new Book[] {
new Book("August Strindberg", "Röda Rummet"),
new Book("Paulo Coelho", "Alkemisten"),
new Book("August Strindberg", "Inferno"),
new Book("Paulo Coelho", "Valkyriorna"),
new Book("Selma Lagerlöf", "Gösta Berlings saga"),
new Book("Per Anders Fogelström", "Mina drömmars stad"),
new Book("Selma Lagerlöf", "Nils Holgerssons underbara resa genom Sverige"),
new Book("Hjalmar Söderberg", "Doktor Glas"),
new Book("Tove Folkesson", "Kalmars jägarinnor"),
new Book("Johannes Anyury", "En storm kom från paradiset")
};

//Uppgift - Lambda Expressions
//Använd klass och array från demo.
//Skriv en LINQ query som lägger till textsträngen "Från Stockholm: " innan författarnamn
//för Hjalmar Söderberg, August Strindberg och Per Anders Fogelström.
//Skriv ut resultatet.
//Output:
//Från Stockholm August Strindberg
//Från Stockholm August Strindberg
//Från Stockholm Per Anders Fogelström
//Från Stockholm Hjalmar Söderberg

var authorFromSthlm = books.Where(b => b.Author == "Hjalmar Söderberg" || b.Author == "August Strindberg" || b.Author == "Per Anders Fogelström")
                        .Select(b => b.Author = "Från Stockholm " + b.Author)
                        .ToList();
foreach (var author in authorFromSthlm)
{
    Console.WriteLine(author);
}

//------------------------------------------------
// Bok-klass
//------------------------------------------------
public class Book
{
    public string Author { get; set; }
    public string Title { get; set; }
    public Book(string author, string title)
    {
        Author = author;
        Title = title;
    }
}


