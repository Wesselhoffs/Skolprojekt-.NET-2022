Console.Write("Vilken kurs: ");
string course = Console.ReadLine();

Console.Write("Hur många meddelanden vill du skriva: ");
int messages = Convert.ToInt32(Console.ReadLine());
string[] messageToCourse = new string[messages];


FillArray(messages, 0);
StartHtmlPrint();
HeaderPrint(course);
MessagePrint(messageToCourse);
CoursesPrint();
EndHtmlPrint();

void FillArray(int i, int x)
{
    if (i > 0)
    {
        Console.Write($"Meddelande {x + 1}: ");
        messageToCourse[x] = Console.ReadLine();
        FillArray(i - 1, x + 1);
    }
}

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
