Console.Write("Vilken kurs: ");
string course = Console.ReadLine();

Console.WriteLine("Hur många meddelanden vill du skriva?");
int messages = Convert.ToInt32(Console.ReadLine());
string[] messageToCourse = new string[messages];
for (int i = 0; i < messages; i++)
{
    Console.Write($"Meddelande {i+1}: ");
    messageToCourse[i] = Console.ReadLine();
}


StartHtmlPrint();
HeaderPrint(course);
MessagePrint(messageToCourse);
CoursesPrint();
EndHtmlPrint();

void StartHtmlPrint()
{
    Console.Clear();
    Console.WriteLine("<!DOCTYPE html>\n<html>\n<body>");
}

void HeaderPrint(string course)
{
    Console.WriteLine($"<h1>Välkomna till {course}!</h1>\n<main>");
}
void MessagePrint(params string[] strings)
{
    foreach (var item in strings)
    {
        Console.WriteLine($"<p><b>Meddelande:</b>{item}</p>");
    }

}
void CoursesPrint()
{
    Console.WriteLine("<p>Kurs om C#</p>\n<p>Kurs om Databaser</p>");
}

void EndHtmlPrint()
{
    Console.WriteLine("</main>\n</body>\n</html>");
}
