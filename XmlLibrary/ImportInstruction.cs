using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlLibrary
{
    public class ImportInstruction
    {
        public List<string> PathsToSearch 
            = new List<string>();

        public string SearchPattern { get; set; } 
            = "*.xml";
    }
}
