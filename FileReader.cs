using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

namespace SpaceStation_Forms
{
    public static class FileReader
    {
        public static GameFile Read(string path) 
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load(path);
            XmlElement root = xDoc.DocumentElement;
            XmlNodeList WriteList = root.ChildNodes[0].ChildNodes;
            string MainText = root.ChildNodes[1].InnerText;
            List<WriteElement> L = new List<WriteElement>();
            foreach (XmlNode node in WriteList) 
            {
                XmlNodeList list = node.ChildNodes;
                L.Add(new WriteElement(list[0].InnerText, list[1].InnerText, list[2].InnerText));
            }
            //System.Windows.Forms.MessageBox.Show(MainText);
            return new GameFile(L,MainText);
        }

        public static string Write(BaseInfo B,string MainText, List<string> key, List<string> value) 
        {
            if (B == null) { return MainText; }
            string str = MainText;
            string h;
            for (int i = 0; i < key.Count; i++) 
            {
                h = SpecialAttr(B, key[i]);
                if (h != "")
                {
                    str = str.Replace($"[{key[i].Replace("Alt", "")}]", h);
                }
                else if (key[i] == "DpTo") 
                {
                    str = str.Replace($"[{key[i]}]", DepartToDp(value[i]));
                }
                else
                {
                    str = str.Replace($"[{key[i]}]", value[i]);
                }
            }
            MessageBox.Show("0");
            str = str.Replace("[Station]", B.StationNum);
            str = str.Replace("[Name]", B.Name);
            str = str.Replace("[Member]", B.Member);
            str = str.Replace("[Department]", B.Department);
            str = str.Replace("[DpFrom]", DepartToDp(B.Department));
            str = str.Replace("[Time]", $"{DateTime.Now.Day}.{DateTime.Now.Month}.{DateTime.Now.Year + 1200}");
            str = str.Replace("[Clock]", $"{DateTime.Now.Hour}:{DateTime.Now.Minute}:{DateTime.Now.Second}") ;
            str = str.Replace("[Year]", $"{DateTime.Now.Year + 1200}");
            str = str.Replace("[Signature]", B.Sign);
            return str;
        }

        public static string DepartToDp(string department) 
        {
            List<string> Departments = new List<string>(){ 
                "Отдел Снабжения",  
                "Сервисный Отдел", 
                "Научный Отдел", 
                "Медицинский Отдел", 
                "Инженерный Отдел", 
                "Отдел Службы Безопасности", 
                "Отдел Командования" 
            };
            List<string> Dp = new List<string>() { "SUP", "SRV", "RND", "MED", "ENG", "SEC", "CMD" };
            for (int i = 0; i < Departments.Count; i++) 
            {
                if (Departments[i] == department) 
                {
                    return Dp[i];
                }
            }
            return Dp[6];
        }

        public static string SpecialAttr(BaseInfo f,string k) 
        {
            if (k == "UserAlt")
            {
                return f.Name;
            }
            else if (k == "JobAlt")
            {
                return f.Member;
            }
            else if (k == "SignAlt")
            {
                return f.Sign;
            }
            else if (k == "DepartAlt")
            {
                return f.Department;
            }
            else 
            {
                return "";
            }
        }
    }
}
