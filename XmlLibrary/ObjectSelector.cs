using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlLibrary
{
    public class ObjectSelector
        : XPathSelector
    {
        public List<PropertySelector> PropertySelectors { get; set; } 
            = new List<PropertySelector>();
    }
}
