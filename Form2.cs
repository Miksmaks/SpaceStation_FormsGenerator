using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace SpaceStation_Forms
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<Control> ControlList = new List<Control>();
        GameFile CurrentFile;
        BaseInfo Info;
        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (CurrentFile != null)
            {
                int k = 0;
                List<string> Keys = new List<string>();
                List<string> Values = new List<string>();
                for (int i = 0; i < ControlList.Count; i++) 
                {
                    if (ControlList[i].Name == "TextBox" || ControlList[i].Name == "ComboBox") 
                    {
                        if (i + 1 != ControlList.Count)
                        {
                            if (ControlList[i + 1].Name == "CheckBox") 
                            {
                                if (((CheckBox)(ControlList[i + 1])).Checked) 
                                {
                                    Keys.Add($"{CurrentFile.Elements[k].Attr}Alt");
                                    Values.Add(ControlList[i].Text);
                                    k++;
                                    continue;
                                }
                            }
                        }
                        Keys.Add(CurrentFile.Elements[k].Attr);
                        Values.Add(ControlList[i].Text);
                        k++;
                    }
                }
                textBox1.Text = FileReader.Write(Info,CurrentFile.Text,Keys,Values);
            }
            else 
            {
                MessageBox.Show("Не выбрана форма","Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (treeView1.SelectedNode != null) 
            {
                if (treeView1.SelectedNode.Level == 1) 
                {
                    foreach (Control k in ControlList)
                    {
                        k.Dispose();
                    }
                    ControlList.Clear();
                    GameFile file = FileReader.Read($"Документы\\{treeView1.SelectedNode.FullPath}.xml");
                    CurrentFile = file;
                    int s = 0;
                    foreach (WriteElement obj in file.Elements)
                    {
                        if (obj.Type == "SmallTextBox")
                        {
                            Label l = new Label();
                            l.Text = obj.Name;
                            l.Location = new Point(280, 12 + s);
                            l.Width = 140;
                            TextBox t = new TextBox();
                            t.Location = new Point(420, 12 + s);
                            t.Height = 10;
                            t.Width = 480;
                            t.Name = "TextBox";
                            t.Font = new Font("Times New Roman", 12, FontStyle.Regular);
                            Controls.Add(l);
                            Controls.Add(t);
                            ControlList.Add(l);
                            ControlList.Add(t);
                            s += 30;
                        }
                        else if (obj.Type == "SmallTextBoxAlt")
                        {
                            Label l = new Label();
                            l.Text = obj.Name;
                            l.Location = new Point(280, 12 + s);
                            l.Width = 140;
                            TextBox t = new TextBox();
                            t.Location = new Point(420, 12 + s);
                            t.Height = 10;
                            t.Width = 480;
                            t.Name = "TextBox";
                            t.Font = new Font("Times New Roman", 12, FontStyle.Regular);
                            CheckBox c = new CheckBox();
                            c.Location = new Point(910, 12 + s);
                            c.Name = "CheckBox";
                            Controls.Add(l);
                            Controls.Add(t);
                            Controls.Add(c);
                            ControlList.Add(l);
                            ControlList.Add(t);
                            ControlList.Add(c);
                            s += 30;
                        }
                        else if (obj.Type == "BigTextBox")
                        {
                            Label l = new Label();
                            l.Text = obj.Name;
                            l.Location = new Point(280, 12 + s);
                            l.Width = 140;
                            TextBox t = new TextBox();
                            t.Location = new Point(420, 12 + s);
                            t.Multiline = true;
                            t.Height = 65;
                            t.Width = 480;
                            t.Name = "TextBox";
                            t.Font = new Font("Times New Roman", 12, FontStyle.Regular);
                            Controls.Add(l);
                            Controls.Add(t);
                            ControlList.Add(l);
                            ControlList.Add(t);
                            s += 70;
                        }
                        else if (obj.Type == "DepartComboBox")
                        {
                            // string[] Dp = { "SUP", "SRV", "RND", "MED", "ENG", "SEC", "CMD" };
                            string[] Departments = { "Отдел Снабжения", "Сервисный Отдел", "Научный Отдел", "Медицинский Отдел", "Инженерный Отдел", "Отдел Службы Безопасности", "Отдел Командования", "Юридический отдел" };
                            Label l = new Label();
                            l.Text = obj.Name;
                            l.Location = new Point(280, 12 + s);
                            l.Width = 140;
                            ComboBox t = new ComboBox();
                            t.DropDownStyle = ComboBoxStyle.DropDownList;
                            t.Items.AddRange(Departments);
                            t.Location = new Point(420, 12 + s);
                            t.Height = 65;
                            t.Width = 480;
                            t.Name = "ComboBox";
                            t.Font = new Font("Times New Roman", 12, FontStyle.Regular);
                            Controls.Add(l);
                            Controls.Add(t);
                            ControlList.Add(l);
                            ControlList.Add(t);
                            s += 70;
                        }
                        else if (obj.Type == "DepartComboBoxAlt")
                        {
                            // string[] Dp = { "SUP", "SRV", "RND", "MED", "ENG", "SEC", "CMD" };
                            string[] Departments = { "Отдел Снабжения", "Сервисный Отдел", "Научный Отдел", "Медицинский Отдел", "Инженерный Отдел", "Отдел Службы Безопасности", "Отдел Командования" , "Юридический отдел"};
                            Label l = new Label();
                            l.Text = obj.Name;
                            l.Location = new Point(280, 12 + s);
                            l.Width = 140;
                            ComboBox t = new ComboBox();
                            t.DropDownStyle = ComboBoxStyle.DropDownList;
                            t.Items.AddRange(Departments);
                            t.Location = new Point(420, 12 + s);
                            t.Height = 65;
                            t.Width = 480;
                            t.Name = "ComboBox";
                            t.Font = new Font("Times New Roman", 12, FontStyle.Regular);
                            CheckBox c = new CheckBox();
                            c.Location = new Point(910, 12 + s);
                            t.Name = "CheckBox";
                            Controls.Add(l);
                            Controls.Add(t);
                            Controls.Add(c);
                            ControlList.Add(l);
                            ControlList.Add(t);
                            ControlList.Add(c);
                            s += 70;
                        }
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (!Directory.Exists("Документы"))
            {
                Directory.CreateDirectory("Документы");
                Directory.CreateDirectory("Документы\\Научный отдел");
                Directory.CreateDirectory("Документы\\Инженерный отдел");
                Directory.CreateDirectory("Документы\\Медицинский отдел");
                Directory.CreateDirectory("Документы\\Отдел Командования");
                Directory.CreateDirectory("Документы\\Отдел Службы Безопасности");
                Directory.CreateDirectory("Документы\\Отдел Снабжения");
                Directory.CreateDirectory("Документы\\Сервисный отдел");
                Directory.CreateDirectory("Документы\\Юридический отдел");
                Directory.CreateDirectory("Документы\\Иные документы");
            }
            else 
            {
                if (!Directory.Exists("Документы\\Научный отдел"))
                {
                    Directory.CreateDirectory("Документы\\Научный отдел");
                }
                if (!Directory.Exists("Документы\\Инженерный отдел"))
                {
                    Directory.CreateDirectory("Документы\\Инженерный отдел");
                }
                if (!Directory.Exists("Документы\\Медицинский отдел"))
                {
                    Directory.CreateDirectory("Документы\\Медицинский отдел");
                }
                if (!Directory.Exists("Документы\\Отдел Командования"))
                {
                    Directory.CreateDirectory("Документы\\Отдел Командования");
                }
                if (!Directory.Exists("Документы\\Отдел Службы Безопасности"))
                {
                    Directory.CreateDirectory("Документы\\Отдел Службы Безопасности");
                }
                if (!Directory.Exists("Документы\\Отдел Снабжения"))
                {
                    Directory.CreateDirectory("Документы\\Отдел Снабжения");
                }
                if (!Directory.Exists("Документы\\Сервисный отдел"))
                {
                    Directory.CreateDirectory("Документы\\Сервисный отдел");
                }
                if (!Directory.Exists("Документы\\Юридический отдел"))
                {
                    Directory.CreateDirectory("Документы\\Юридический отдел");
                }
                if (!Directory.Exists("Документы\\Иные документы"))
                {
                    Directory.CreateDirectory("Документы\\Иные документы");
                }
            }
            string[] mas = Directory.GetDirectories($"Документы");

            for (int j = 0; j < mas.Length; j++)
            {
                treeView1.Nodes.Add(mas[j].Replace(mas[j].Remove(mas[j].LastIndexOf('\\') + 1), ""));
                foreach (string obj in Directory.GetFiles(mas[j]))
                {
                    treeView1.Nodes[j].Nodes.Add(obj.Replace($"Документы\\{treeView1.Nodes[j].Text}\\", "").Replace(".xml", ""));
                }
            }
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            comboBox4.Enabled = false;
            Info = new BaseInfo(textBox2.Text, textBox3.Text, textBox4.Text, comboBox4.Text, textBox5.Text);
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            comboBox4.Enabled = true;
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            //new Form1().Show();
        }

        // Добавить рефрешер иерархии
    }
}
