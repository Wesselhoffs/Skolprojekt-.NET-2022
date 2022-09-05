StartHtmlPrint();
HeaderPrint();
CoursesPrint();
EndHtmlPrint();

void StartHtmlPrint()
{
    Console.WriteLine("<!DOCTYPE html>\n<html>\n<body>");
}

void HeaderPrint()
{
    Console.WriteLine("<h1>Välkomna!</h1>\n<main>");
}

void CoursesPrint()
{
    Console.WriteLine("<p>Kurs om C#</p>\n<p>Kurs om Databaser</p>");
}

void EndHtmlPrint()
{
    Console.WriteLine("</main>\n</body>\n</html>");
}