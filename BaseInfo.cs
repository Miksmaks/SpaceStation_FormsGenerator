using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpaceStation_Forms
{
    public class BaseInfo
    {
        public string StationNum = "";
        public string Name = "";
        public string Member = "";
        public string Department = "";
        public string Sign = "";
        public BaseInfo(string sn, string n, string m, string d, string s) 
        {
            StationNum = sn;
            Name = n;
            Member = m;
            Department = d;
            Sign = s;
        }
    }
}
