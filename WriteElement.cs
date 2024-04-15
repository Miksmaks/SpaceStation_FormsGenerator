using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation_Forms
{
    public class WriteElement
    {
        public string Name;
        public string Type;
        public string Attr;
        public WriteElement(string name, string type,string attr) 
        {
            Name = name;
            Type = type;
            Attr = attr;
        }
    }
}
