using static Website_With_Config.WebsiteConfig;
namespace Website_With_Config
{
    class StyledWebsiteGenerator : WebsiteGenerator
    {
        private string color;

        public StyledWebsiteGenerator(WebsiteConfig config ) : base(config)
        {
            this.color = config.GetColorFromConfig();
        }
        public override void UpdateValues(WebsiteConfig config)
        {
            this.className = config.GetClassNameFromConfig();
            this.messageToClass = config.GetMessagesFromConfig();
            this.courses = FixArray(config.GetCoursesFromConfig());
            this.color = config.GetColorFromConfig();
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
            if (string.IsNullOrWhiteSpace(this.color))
            {
                base.PrintStart();
            }
            else
            {
            Console.Write(this.start.Insert(23, $"<head>\n<style>\np{{ color: {this.color}; }}\n</style>\n</head>\n"));
            }
        }

        override public void SaveWebsiteToFile()
        {
            try
            {
                FileInfo fi = new(@"StyledWebsite.html");
                FileStream fs = fi.Open(FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
                StreamWriter sw = new(fs);
                TextWriter tmp = Console.Out;
                Console.SetOut(sw);
                PrintWebsite();
                Console.SetOut(tmp);
                sw.Close();
                fs.Close();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
