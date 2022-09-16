using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeling_rather_abstract
{
    abstract class Website
    {
        protected string start = "<!DOCTYPE HTML>\n<html>\n<body>\n<main>\n";
        protected string end = "</main>\n</body>\n</html>\n";
        protected string[] techniques, messageToClass;
        protected string className;

        public Website()
        {
            this.className = FakeApiGetClassName();
            this.messageToClass = FakeApiGetMessage();
            string[] techniquesFromApi = FakeApiGetTechniques();
            this.techniques = FixArray(techniquesFromApi);
        }
        private string FakeApiGetClassName()
        {
            return ".NET Distans 2022";
        }
        private string[] FakeApiGetMessage()
        {
            string[] messages = { "Glöm inte att övning ger färdighet!", "Öppna boken på sida 257." };
            return messages;
        }
        private string[] FakeApiGetTechniques()
        {
            string[] techniques = { "   C#", "daTAbaser", "WebbuTVeCkling ", "clean Code   " };
            return techniques;
        }
        public abstract void PrintWebsite();
        protected abstract void PrintStart();
        protected abstract void PrintHeader();
        protected abstract void PrintCourses();
        protected abstract void PrintEnd();

        protected string[] FixArray(string[] techniques)
        {
            string[] temp = new string[techniques.Length];
            for (int i = 0; i < techniques.Length; i++)
            {
                temp[i] = "<p>Kurs i " + techniques[i].Trim().ToUpper().Substring(0, 1) + techniques[i].Trim().Substring(1).ToLower() + "<p/>";
            }
            return temp;
        }

    }
}
