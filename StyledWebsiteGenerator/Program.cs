string[] techniques = { "   C#", "daTAbaser", "WebbuTVeCkling ", "clean Code   " };                 //
string[] messagesToClass = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };   // Kanske har vi fått dessa värden ifrån en API
string className = ".NET Distans 2022";                                                             //
string color = "red";                                                                               //
//////////////////////////////////////////////////////////////////////////////////////////////////////


WebsiteGenerator myWebsite = new WebsiteGenerator(className, messagesToClass, techniques);

StyledWebsiteGenerator styledWebsite = new StyledWebsiteGenerator(className, messagesToClass, techniques, color);

myWebsite.PrintWebsite();
Console.WriteLine("------------------------------------");
styledWebsite.PrintWebsite();


class WebsiteGenerator
{
    protected string start = "<!DOCTYPE HTML>\n<html>\n<body>\n<main>\n";
    protected string end = "</main>\n</body>\n</html>\n";
    protected string[] techniques, messageToClass;
    protected string className;

    public WebsiteGenerator(string className, string[] messageToClass, string[] techniques)
    {
        this.className = className;
        this.messageToClass = messageToClass;
        this.techniques = FixArray(techniques);
    }

    virtual public void PrintWebsite()
    {
        PrintStart();
        PrintHeader();
        PrintCourses();
        PrintEnd();
    }

    protected void PrintHeader()
    {
        Console.WriteLine($"<h1>Välkomna {this.className}</h1>");
        foreach (string msg in this.messageToClass)
        {
            Console.WriteLine($"<p><b>Meddelande: </b>{msg}</p>");
        }
    }

    protected void PrintCourses()
    {
        foreach (var course in this.techniques)
        {
            Console.WriteLine(course);
        }
    }

    virtual protected void PrintStart()
    {
        Console.Write(this.start);
    }

    protected void PrintEnd()
    {
        Console.Write(this.end);
    }

    protected string[] FixArray(string[] techniques)
    {
        string[] temp = new string[techniques.Length];
        for (int i = 0; i < techniques.Length; i++)
        {
            temp[i] = "<p>Kurs i " + techniques[i].Trim().ToUpper().Substring(0, 1) + techniques[i].Trim().Substring(1).ToLower() + "<p/>";
        }
        return temp;
    }
}

class StyledWebsiteGenerator : WebsiteGenerator
{
    private string color;

    public StyledWebsiteGenerator(string className, string[] messageToClass, string[] techniques, string color) : base(className, messageToClass, techniques)
    {    
        this.color = color;
    }
    override public void PrintWebsite()
    {
        PrintStart();
        PrintHeader();
        PrintCourses();
        PrintEnd();
    }

    override protected void PrintStart()
    {
        // Console.Write($"<!DOCTYPE HTML>\n<html>\n<head>\n<style>\n" +
        //               $"p {{ color: {this.color}; }}\n</style>\n</head>\n<body>\n<main>\n");
        
        Console.Write(this.start.Insert(23, $"<head>\n<style>\np {{ color: {this.color}; }}\n</style>\n</head>\n"));
    }
}