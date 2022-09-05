string doctype = "<!DOCTYPE html>";
string html = "<html>";
string body = "<body>";
string header = "<h1>Välkomna!</h1>";
string endBody = "</body>";
string endHtml = "</html>";

string[] techniques = {"   C#", "daTAbaser", "WebbuTVeKkling  ", "clean Code      "};

Console.WriteLine($"{doctype}\n{html}\n{body}\n{header}");

	foreach (var kurs in techniques)
	{		
		Console.WriteLine($"<p>Kurs i {kurs.Trim().ToUpper().Substring(0, 1) + kurs.Trim().Substring(1).ToLower().Replace("kk", "ck")}<p/>");
	}
Console.WriteLine($"{endBody}\n{endHtml}");