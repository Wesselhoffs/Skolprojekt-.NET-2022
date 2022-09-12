string[] techniques = { "   C#", "daTAbaser", "WebbuTVeCkling ", "clean Code   " };
string[] messagesToClass = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };
string className = ".NET Distans 2022";

WebsiteGenerator myWebsite = new WebsiteGenerator(className, messagesToClass, techniques);

myWebsite.PrintWebsite();

class WebsiteGenerator
{
    public string start = "<!DOCTYPE HTML>\n<html>\n<body>\n<main>\n";
    public string end = "</main>\n</body>\n</html>\n";
    public string[] techniques, messageToClass;
    public string className;

    public WebsiteGenerator(string className, string[] messageToClass, string[] techniques)
    {
        this.className = className;
        this.messageToClass = messageToClass;
        this.techniques = FixArray(techniques);
    }

    public void PrintWebsite()
    {
        PrintStart();
        PrintHeader();
        PrintCourses();
        PrintEnd();
    }

    public void PrintHeader()
    {
        Console.WriteLine($"<h1>Välkomna {this.className}</h1>");
        foreach (string msg in this.messageToClass)
        {
            Console.WriteLine($"<p><b>Meddelande: </b>{msg}</p>");
        }
    }

    public void PrintCourses()
    {
        foreach (var course in this.techniques)
        {
            Console.WriteLine(course);
        }
    }

    public void PrintStart()
    {
        Console.Write(this.start);
    }

    public void PrintEnd()
    {
        Console.Write(this.end);
    }

    public string[] FixArray(string[] techniques)
    {
        string[] temp = new string[techniques.Length];
        for (int i = 0; i < techniques.Length; i++)
        {
            temp[i] = "<p>Kurs i " + techniques[i].Trim().ToUpper().Substring(0, 1) + techniques[i].Trim().Substring(1).ToLower() + "<p/>";
        }
        return temp;
    }
}