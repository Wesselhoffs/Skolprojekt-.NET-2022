using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website_To_File
{
    class StyledWebsiteGenerator : WebsiteGenerator
    {
        private string color;

        public StyledWebsiteGenerator()
        {
            this.color = FakeApiGetColor();
        }

        private string FakeApiGetColor()
        {
            return "red";
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
            Console.Write(this.start.Insert(23, $"<head>\n<style>\np {{ color: {this.color}; }}\n</style>\n</head>\n"));
        }

        override public void SaveWebsiteToFile()
        {
            try
            {
                FileInfo fi = new(@"StyledWebsite.html");
                FileStream fs = fi.Open(FileMode.Create, FileAccess.ReadWrite, FileShare.Read);
                StreamWriter sw = new(fs);
                Console.SetOut(sw);
                PrintWebsite();
                Console.SetOut(Console.Out);
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
