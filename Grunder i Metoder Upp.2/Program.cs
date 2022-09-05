Console.WriteLine("Vilken kurs: ");
string course = Console.ReadLine();

Console.WriteLine("Meddelande till klassen: ");
string messageToCourse = Console.ReadLine();

StartHtmlPrint();
HeaderPrint(course);
MessagePrint(messageToCourse);
CoursesPrint();
EndHtmlPrint();

void StartHtmlPrint()
{
    Console.WriteLine("<!DOCTYPE html>\n<html>\n<body>");
}

void HeaderPrint(string course)
{
    Console.WriteLine($"<h1>Välkomna {course}!</h1>\n<main>");
}
void MessagePrint(string messageToCourse)
{
    Console.WriteLine($"<p><b>Meddelande:</b>{messageToCourse}</p>");
}
void CoursesPrint()
{
    Console.WriteLine("<p>Kurs om C#</p>\n<p>Kurs om Databaser</p>");
}

void EndHtmlPrint()
{
    Console.WriteLine("</main>\n</body>\n</html>");
}