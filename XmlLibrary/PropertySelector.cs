using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlLibrary
{
    public class PropertySelector 
        : XPathSelector
    {
        public int PropertyDefId { get; set; }

        //public MFDataType PropertyDefType { get; set; }
    }
}
