using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeling_rather_abstract
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
            PrintStyledStart();
            PrintHeader();
            PrintCourses();
            PrintEnd();
        }

        private void PrintStyledStart()
        {
            Console.Write(this.start.Insert(23, $"<head>\n<style>\np {{ color: {this.color}; }}\n</style>\n</head>\n"));
        }
    }
}
