using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceStation_Forms
{
    public partial class Form1 : Form
    {
        string StationName = "";
        string YourName = "";
        string YourMember = "";
        string Pod = "";
        string YourDepart = "";

        List<string> Departments = new List<string>() { "Отдел Снабжения", "Сервисный Отдел", "Научный Отдел", "Медицинский Отдел", "Инженерный Отдел", "Отдел Службы Безопасности","Отдел Командования"};

        public Form1()
        {
            InitializeComponent();
        }

        private void StartMake() 
        {
            StationName = textBox2.Text;
            YourName = textBox3.Text;
            YourMember = textBox4.Text;
            Pod = textBox5.Text;
            YourDepart = comboBox4.Text;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            comboBox4.Enabled = false;
        }

        private void CloseStart(object sender, MouseEventArgs e)
        {
            StartMake();
        }

        private void Open(object sender, MouseEventArgs e)
        {
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            comboBox4.Enabled = true;
        }

        private void SSForm1() 
        {
            string str = "";
            str = str +  "                   Заявление в бюро доносов NanoTrasen" +
                "\r\n--------------------------------------------------------------------------\r\n";
            str += $"Номер станции: {StationName}\r\n";
            if (checkBox1.Checked)
            {
                str += $"Заявитель: {YourName}\r\n";
                str += $"Должность: {YourMember}\r\n\r\n";
            }
            else 
            {
                str += $"Заявитель: {textBox7.Text}\r\n";
                str += $"Должность: {textBox8.Text}\r\n\r\n";
            }
            str += $"Субъект правонарушения: {textBox9.Text}\r\n";
            str += $"Должность: {textBox10.Text}\r\n\r\n";
            str += $"Нарушения по КЗ: {textBox11.Text}\r\n";
            str += $"Нарушения по СРП: {textBox12.Text}\r\n";
            str += $"Нарушения по ОЧП: {textBox13.Text}\r\n\r\n";
            str += $"Свидетели нарушений: {textBox14.Text}\r\n";
            str += $"--------------------------------------------------------------------------\r\n";
            str += $"Описание: {textBox15.Text}\r\n";
            str += $"Жалоба была составлена мною в пребывании адекватного состояния. Все, расписанное в данной жалобе, готов подтвердить повторно, при необходимости.\r\n\r\n";
            str += $"Запрос: {textBox16.Text}\r\n\r\n";
            str += $"Подпись: {Pod}       Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n";
            str += $"Печать:\r\n";
            textBox1.Text = str;
        }

        private void SSForm2()
        {
            string str = "";
            str = str + "       Заявление в отдел ускоренного найма NanoTrasen\r\n" +
                "--------------------------------------------------------------------------\r\n";
            str += $"Главе персонала станции {StationName}\r\n\r\n";
            if (checkBox2.Checked)
            {
                str += $"Я, {YourName}, желаю пройти процедуру ускоренного найма на космической станции NanoTrasen.Ознакомившись с условиями и положениями ускоренного трудоустройства, желаю получить специальность {textBox19.Text} в отделе '{comboBox1.Text}'.\r\n\r\n";
            }
            else
            {
                str += $"Я, {textBox18.Text}, желаю пройти процедуру ускоренного найма на космической станции NanoTrasen.Ознакомившись с условиями и положениями ускоренного трудоустройства, желаю получить специальность {textBox19.Text} в отделе '{comboBox1.Text}'.\r\n\r\n";
            }
            str += $"{textBox22.Text}\r\n";
            str += $"--------------------------------------------------------------------------\r\n" +
                $"Со стандартными рабочими процедурами, правилами и политикой NanoTrasen ознакомлен. Ответственность, возлагаемую на себя, осознаю.\r\n\r\n";
            if (checkBox2.Checked)
            {
                str += $"Подпись: {Pod}       Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n";
            }
            else 
            {
                str += $"Подпись: ***       Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n";
            }
            str += $"Глава Отдела: {textBox21.Text}\r\n";
            str += $"Печать:\r\n";
            textBox1.Text = str;
        }

        private void SSForm3()
        {
            string str = "";
            str = str + "             Заявление в кадровый отдел NanoTrasen\r\n" +
    "--------------------------------------------------------------------------\r\n";
            str += $"Главе персонала станции {StationName}\r\n\r\n";
            if (checkBox3.Checked)
            {
                str += $"Я, {YourName}, прошу уволить меня с должности '{YourMember}' по собственному желанию.\r\n\r\n";
            }
            else
            {
                str += $"Я, {textBox23.Text}, прошу уволить меня с должности '{textBox24.Text}' по собственному желанию.\r\n\r\n";
            }
            str += $"Причина: {textBox25.Text}\r\n";
            str += $"--------------------------------------------------------------------------\r\n" +
                $"Документ составлен в адекватном состоянии, со всеми последствиями ознакомлен.\r\n\r\n";
            if (checkBox3.Checked)
            {
                str += $"Подпись: {Pod}       Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n";
            }
            else
            {
                str += $"Подпись: ***       Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n";
            }
            str += $"Печать:\r\n";
            textBox1.Text = str;
        }

        private void SSForm4()
        {
            string str = "";
            str = str + "             Заявление в кадровый отдел NanoTrasen\r\n" +
"--------------------------------------------------------------------------\r\n";
            str += $"Главе персонала станции {StationName}\r\n\r\n";
            if (checkBox4.Checked)
            {
                str += $"Я, {YourMember} {YourName}, прошу перевести меня в отдел '{comboBox3.Text}' на должность '{textBox29.Text}'.\r\n\r\n";
            }
            else
            {
                str += $"Я, {textBox27.Text} {textBox26.Text}, прошу перевести меня в отдел '{comboBox3.Text}' на должность '{textBox29.Text}'.\r\n\r\n";
            }
            str += $"Причина: {textBox30.Text}\r\n";
            str += $"--------------------------------------------------------------------------\r\n" +
    $"Документ составлен в адекватном состоянии, со всеми последствиями ознакомлен.\r\n\r\n";
            if (checkBox4.Checked)
            {
                str += $"Подпись: {Pod}       Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n";
            }
            else
            {
                str += $"Подпись: ***       Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n";
            }
            str += $"Печать:\r\n";
            textBox1.Text = str;
        }

        private void SSForm5()
        {
            string str = "";
            str = str + "             Заявление в кадровый отдел NanoTrasen\r\n" +
"--------------------------------------------------------------------------\r\n";
            str += $"Главе персонала станции {StationName}\r\n\r\n";
            if (checkBox5.Checked)
            {
                str += $"Я, {YourName}, в должности {YourMember} прошу повысить меня до должности {textBox34.Text} в отделе '{comboBox5.Text}'.\r\n\r\n";
            }
            else
            {
                str += $"Я, {textBox31.Text}, в должности {textBox32.Text} прошу повысить меня до должности {textBox34.Text} в отделе '{comboBox5.Text}'.\r\n\r\n";
            }
            str += $"Причина: {textBox35.Text}\r\n";
            str += $"--------------------------------------------------------------------------\r\n" +
    $"Я убежден, что повышение позволит мне сделать значительный вклад в работу отдела и обязуюсь с особой старательностью выполнять свои обязанности.\r\n\r\n" +
    $"Со стандартными рабочими процедурами, правилами и политикой NanoTrasen ознакомлен. Ответственность, возлагаемую на себя, осознаю.\r\n\r\n";
            if (checkBox5.Checked)
            {
                str += $"Подпись: {Pod}       Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n";
            }
            else
            {
                str += $"Подпись: ***       Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n";
            }
            str += $"Печать:\r\n";
            textBox1.Text = str;
        }


        private void SSForm6()
        {
            string str = "";
            string[] Dp = {"SUP","SRV","RND","MED","ENG","SEC","CMD"};
            int i1 = comboBox4.SelectedIndex;
            int i2 = comboBox2.SelectedIndex;
            if (i1 == -1 || i2 == -1) 
            {
                i1 = 6;
                i2 = 6;
            }
            str += $"Форма {StationName}-{Dp[i1]}-{Dp[i2]}-REP\r\n";
            str += $"Отчет от главы отдела '{YourDepart}', {YourName}\r\n";
            str += $"Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n\r\n";
            str += $"Я, {YourName}, как {YourMember}, сообщаю:\r\n";
            str += $"{textBox38.Text}\r\n\r\n";
            str += $"Печать:\r\n";
            textBox1.Text = str;
        }

        private void SSForm7()
        {
            string str = "";
            str = str + "             Приказ в кадровый отдел NanoTrasen\r\n" +
"--------------------------------------------------------------------------\r\n";
            str += $"Главе персонала станции {StationName}\r\n\r\n";
            str += $"Я, {YourName}, в должности главы отдела '{YourDepart}' приказываю понизить сотрудника {textBox37.Text} {textBox36.Text} до должности {textBox39.Text}.\r\n\r\n";
            str += $"Причина: {textBox40.Text}\r\n";
            str += $"--------------------------------------------------------------------------\r\n" +
    $"Обязуюсь восполнить отсутствие персонала и поддерживать эффективность отдела на высшем уровне.\r\n\r\n" +
    $"Приказ ввести в исполнение немедленно во избежание необратимого ущерба. \r\n\r\n";
            str += $"Подпись: {Pod}       Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n";
            str += $"Печать:\r\n";
            textBox1.Text = str;
        }

        private void SSForm8()
        {
            string str = "";
            str = str + "             Приказ в кадровый отдел NanoTrasen\r\n" +
"--------------------------------------------------------------------------\r\n";
            str += $"Главе персонала станции {StationName}\r\n\r\n";
            str += $"Я, {YourName}, в должности главы отдела '{YourDepart}' приказываю немедленно уволить сотрудника {textBox43.Text} с должности {textBox42.Text}.\r\n\r\n";
            str += $"Причина: {textBox6.Text}\r\n\r\n";
            str += $"Сотрудник обязан(-а) немедленно покинуть рабочее место и сдать все выданное снаряжение и имущество отдела. В случае нарушения данного приказа, будут приняты дополнительные меры в соответствии с настоящим законодательством.\r\n";
            str += $"--------------------------------------------------------------------------\r\n" +
    $"Обязуюсь восполнить отсутствие персонала и поддерживать эффективность отдела на высшем уровне.\r\n\r\n" +
    $"Приказ ввести в исполнение немедленно во избежание необратимого ущерба. \r\n\r\n";
            str += $"Подпись: {Pod}       Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n";
            str += $"Печать:\r\n";
            textBox1.Text = str;
        }

        private void SSForm9()
        {
            string str = "";
            str = str + "             Приказ в кадровый отдел NanoTrasen\r\n" +
"--------------------------------------------------------------------------\r\n";
            str += $"Главе персонала станции {StationName}\r\n\r\n";
            str += $"Я, {YourName}, в должности главы отдела '{YourDepart}' приказываю изменить должность {textBox28.Text} внутри отдела на должность {textBox20.Text} с указанными далее обязанностями.\r\n\r\n";
            str += $"Причина и обязанности: {textBox17.Text}\r\n\r\n";
            str += $"Сотрудник обязан(-а) строго выполнять свои обязанности и выполнять инструкции главы отдела.\r\n";
            str += $"--------------------------------------------------------------------------\r\n" +
    $"Обязуюсь наблюдать за деятельностью своего персонала и поддерживать эффективность отдела на высшем уровне.\r\n\r\n" +
    $"Приказ ввести в исполнение немедленно во избежание необратимого ущерба. \r\n\r\n";
            str += $"Подпись: {Pod}       Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n";
            str += $"Печать:\r\n";
            textBox1.Text = str;
        }

        private void SSForm10()
        {
            string str = "";
            string[] Dp = { "SUP", "SRV", "RND", "MED", "ENG", "SEC", "CMD" };
            int i1 = comboBox4.SelectedIndex;
            int i2 = comboBox6.SelectedIndex;
            if (i1 == -1 || i2 == -1)
            {
                i1 = 6;
                i2 = 6;
            }
            str += $"Форма {StationName}-{Dp[i1]}-{Dp[i2]}-ACC\r\n";
            str += $"Запрос на изменения доступа\r\n";
            str += $"Я, {YourName}, как {YourMember}, запрашиваю доступ в следующие отделы:\r\n";
            str += $"{textBox33.Text}\r\n\r\n";
            str += $"Причина:\r\n";
            str += $"{textBox41.Text}\r\n\r\n";
            str += $"Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n\r\n";
            str += $"Печать:\r\n";
            textBox1.Text = str;
        }

        private void SSForm11()
        {
            string str = "";
            string[] Dp = { "SUP", "SRV", "RND", "MED", "ENG", "SEC", "CMD" };
            int i1 = comboBox4.SelectedIndex;
            if (i1 == -1)
            {
                i1 = 6;
            }
            str += $"Форма {StationName}-{Dp[i1]}-SUP-ORD\r\n";
            str += $"Заказ\r\n";
            str += $"Заявитель: {YourName}\r\n";
            str += $"Должность: {YourMember}\r\n";
            str += $"Товар: {textBox44.Text}\r\n";
            str += $"Причина: {textBox45.Text}\r\n";
            str += $"Место доставки: {textBox46.Text}\r\n";
            str += $"Дата: {DateTime.Now.Day}.{DateTime.Now.Month}.2562\r\n\r\n";
            str += $"Печать:\r\n";
            textBox1.Text = str;
        }


        private void ClickForm1(object sender, MouseEventArgs e)
        {
            SSForm1();
        }

        private void ClickForm2(object sender, MouseEventArgs e)
        {
            SSForm2();
        }

        private void ClickForm3(object sender, MouseEventArgs e)
        {
            SSForm3();
        }

        private void ClickForm4(object sender, MouseEventArgs e)
        {
            SSForm4();
        }

        private void ClickForm5(object sender, MouseEventArgs e)
        {
            SSForm5();
        }

        private void ClickForm7(object sender, MouseEventArgs e)
        {
            SSForm7();
        }

        private void ClickForm8(object sender, MouseEventArgs e)
        {
            SSForm8();
        }

        private void ClickForm6(object sender, MouseEventArgs e)
        {
            SSForm6();
        }

        private void ClickForm9(object sender, MouseEventArgs e)
        {
            SSForm9();
        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
            SSForm10();
        }

        private void button13_MouseClick(object sender, MouseEventArgs e)
        {
            SSForm11();
        }
    }
}
