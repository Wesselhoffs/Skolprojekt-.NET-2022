namespace Website_With_Config
{
    class WebsiteGenerator : IWebsiteGenerator
    {
        protected string start = "<!DOCTYPE HTML>\n<html>\n<body>\n<main>\n";
        protected string end = "</main>\n</body>\n</html>\n";
        protected string[] courses, messageToClass;
        protected string className;


        public WebsiteGenerator(WebsiteConfig config)
        {
            this.className = config.GetClassName();
            this.messageToClass = config.GetMessages();
            this.courses = FixArray(config.GetCourses());
        }
        public virtual void UpdateValues(WebsiteConfig config)
        {
            this.className = config.GetClassName();
            this.messageToClass = config.GetMessages();
            this.courses = FixArray(config.GetCourses());

        }
        public virtual void PrintWebsite()
        {
            PrintStart();
            PrintHeader();
            PrintCourses();
            PrintEnd();
        }

        protected void PrintHeader()
        {
            if (string.IsNullOrWhiteSpace(this.className))
            {
                Console.WriteLine($"<h1>Välkomna</h1>");
            }
            else
            {
                Console.WriteLine($"<h1>Välkomna till {this.className}</h1>");
            }
            if (messageToClass != null && messageToClass.Any())
            {
                int counter = 0;
                foreach (string msg in this.messageToClass)
                {
                    if (!string.IsNullOrWhiteSpace(msg))
                    {
                        Console.WriteLine($"<p><b>Meddelande {++counter}: </b>{msg}</p>");
                    }
                }
            }
        }

        protected void PrintCourses()
        {
            if (courses != null && courses.Any())
            {
                foreach (string course in this.courses)
                {
                    if (!string.IsNullOrWhiteSpace(course))
                    {
                        Console.WriteLine(course);
                    }
                }
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

        protected string[] FixArray(string[] courses)
        {
            string[] fixedCourses = new string[courses.Length];
            for (int i = 0; i < courses.Length; i++)
            {
                fixedCourses[i] = "<p>Kurs i " + courses[i].Trim().ToUpper().Substring(0, 1) + courses[i].Trim().Substring(1).ToLower() + "<p/>";
            }
            return fixedCourses;
        }

        virtual public void SaveWebsiteToFile()
        {
            try
            {
                FileInfo fi = new(@"Website.html");
                FileStream fs = fi.Open(FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
                StreamWriter sw = new(fs);
                TextWriter tmp = Console.Out;
                Console.SetOut(sw);
                PrintWebsite();
                Console.SetOut(tmp);
                sw.Close();
                fs.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
