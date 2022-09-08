WebsiteGenerator myWebsite = new WebsiteGenerator();

myWebsite.PrintStart();
myWebsite.PrintHeader(".NET Distans 2022");
myWebsite.PrintCourses();
myWebsite.PrintEnd();


class WebsiteGenerator
{
    public string start = "<html>\n<body>\n<main>\n";
    public string end = "</main>\n</body>\n</html>\n";
    public string[] courses = { "C#", "Databaser", "Webutveckling", "Clean Code" };

    public void PrintHeader(string className)
    {
        Console.WriteLine($"<h1>Välkomna {className}</h1>");
    }

    public void PrintCourses()
    {
        foreach (var course in courses)
        {
            Console.WriteLine($"<p>Kurs i: {course}</p>");
        }
    }

    public void PrintStart()
    {
        Console.Write(start);
    }

    public void PrintEnd()
    {
        Console.Write(end);
    }

}