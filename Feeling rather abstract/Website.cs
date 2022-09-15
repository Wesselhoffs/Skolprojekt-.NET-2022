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
        public abstract void PrintWebsite();
        protected abstract void PrintStart();
        protected abstract void PrintHeader();
        protected abstract void PrintCourses();
        protected abstract void PrintEnd();

    }
}
