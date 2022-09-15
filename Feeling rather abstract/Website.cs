using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feeling_rather_abstract
{
    abstract class Website
    {
        protected string start;
        protected string end;
        protected string[] techniques, messageToClass;
        protected string className;
        public abstract void PrintWebsite();
        protected abstract void PrintStart();
        protected abstract void PrintHeader();
        protected abstract void PrintCourses();
        protected abstract void PrintEnd();

    }
}
