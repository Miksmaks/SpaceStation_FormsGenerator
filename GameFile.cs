using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation_Forms
{
    public class GameFile
    {
        public List<WriteElement> Elements;
        public string Text;
        public GameFile(List<WriteElement> el, string text) 
        {
            Elements = el;
            Text = text;
        }
    }
}
