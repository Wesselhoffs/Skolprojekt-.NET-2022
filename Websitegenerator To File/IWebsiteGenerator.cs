using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Website_To_File
{
    internal interface IWebsiteGenerator    
    {
        public void PrintWebsite();
        public void SaveWebsiteToFile();
    }
}
