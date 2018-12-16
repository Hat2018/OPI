using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using опи_2.Builder;
using опи_2.Director;
using опи_2.ProductClass;

namespace опи_2
{
    public partial class Form1 : Form
    {
        private static Form1 instance;
        private static int maxWindows = 5;
        public static int countWindows = 0;
        public Form1()
        {
            InitializeComponent();
        }
        public static Form1 getInstance()
        {
            if (countWindows < maxWindows)
            {
                instance = new Form1();
                countWindows++;
            }
            return instance;
        }

        string Rusgl = "аоиёеэыуюяАОИЁЕЭЫУЮЯ",
               Russog = "цкнгшщзхфвпрлджчсмтбйЦКНГШЩЗХФВПРЛДЖЧСМТБЙ",
               Enggl = "aeiouAEIOU",
               Engsog = "qwrtypsdfghjklzxcvbnmQWRTYPSDFGHJKLZXCVBNM",
               Numbers = "1234567890",
               Specialsymb = "/“”[](){}‘’@#$%^&*-+|=~_",
               Punctuation = ".,:;!?—",
               RusA = "аоиёеэыуюяцкнгшщзхфвпрлджчсмтбйЦКНГШЩЗХФВПРЛДЖЧСМТБЙАОИЁЕЭЫУЮЯ",
               EngA = "aeiouqwrtypsdfghjklzxcvbnmQWRTYPSDFGHJKLZXCVBNMAEIOU";

      

        private int CountAbz(string myText) // Размер 
        {
            Regex regex = new Regex(@"\n");
            string[] TempText = regex.Split(myText);
            int counterAbz = TempText.Length;
            return counterAbz;
        }
               // ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++//
         private void button5_Click(object sender, EventArgs e)//rtf file
         {
             using (OpenFileDialog opf = new OpenFileDialog()
             { Filter = "Rich Text Format|*.rtf", ValidateNames = true, Multiselect = false })
             {
                 HtmlConverter hConverter = new HtmlConverter(); // строители html converter builder
                 PlainTextConverter pConverter = new PlainTextConverter();//builder plaintextconverter
                 if (opf.ShowDialog() == DialogResult.OK)
                 {
                     hConverter.Reset();
                     pConverter.Reset();
                     RtfReader director = new RtfReader(hConverter); // иниц. директора rtfreader

                     string text = System.IO.File.ReadAllText(opf.FileName);
                     richTextBox1.Rtf = text;
                     text = richTextBox1.Rtf; // переопределение rtf текста 
                     director.BuildText(text);
                     Product htmlText = hConverter.GetProduct();//
                     richTextBox2.Text = htmlText.readyText;

                     director = new RtfReader(pConverter); // обращение к другому строителю
                     director.BuildText(text);
                     Product plainText = pConverter.GetProduct();
                     richTextBox1.Text = plainText.readyText;
                 }
             }
         }

        private int CountNullStr(string myText)//пустые строки
        {
            int counter = 0;
            Regex regex = new Regex(@"\n");
            string[] TempText = regex.Split(myText);
            Regex regex1 = new Regex(@"^\s*$");
            foreach (string s in TempText)
            {
                if (regex1.IsMatch(s))
                {
                    counter++;
                }
            }
            return counter;
        }
        private int CountChar(string myText, string str)
        {
            int CountSynbols = myText.Length;
            char[] textFile = myText.ToCharArray();
            int b = str.Length;
            char[] alf = str.ToCharArray();
            int count = 0;

            for (int i = 0; i < CountSynbols; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    if (textFile[i] == alf[j])
                    {
                        count++;
                    }
                }
            }

            return count;
        }

            private void button2_Click(object sender, EventArgs e)//пробелы 
            {
            string myText = richTextBox1.Text;
            Regex reg1 = new Regex(@"\s+");
            Regex reg3 = new Regex(@"^\s*$");
            Regex reg4 = new Regex(@"\n");
            Regex reg5 = new Regex(@"[a-z]{4}\s\.\s[a-z]{1}\s[a-z]{1}\s[a-z]{1}\.\s[a-z]{1}\s[a-z]{1}");
            Regex reg6 = new Regex(@"\.\s+");
            string[] TempText = reg4.Split(myText);
            string[] TextChange = new String[TempText.Length];
            int counter = 0;

            foreach (string s in TempText)
            {
                if (counter != 0)
                {
                    TextChange[counter] = "\r\n";
                }

                if (reg3.IsMatch(s))
                {
                    continue;
                }

                if (reg1.IsMatch(s))
                {
                    TextChange[counter] += reg1.Replace(s, " "); //пробелы на 1
                }

                if (reg5.IsMatch(s))
                {
                    TextChange[counter] = reg5.Replace(TextChange[counter], "prom.net.ua");
                }

                if (reg6.IsMatch(TextChange[counter]))
                {
                    TextChange[counter] = reg6.Replace(TextChange[counter], ".");
                }

                counter++;

            }

            foreach (string s in TextChange)
            {
                richTextBox2.Text += s;
            }

        }
         private void Button3_Click(object sender, EventArgs e)
        {
            string myText = richTextBox1.Text;
            long sizebytes = richTextBox1.TextLength * sizeof(char) / 1024;
            double countAuthorsPage = richTextBox1.TextLength / 1800;// авторские страницы
            MessageBox.Show("Статистика по тексту:" + "\n" +
                            "Размер: " + sizebytes + " " + "\n" +
                            "Символы:  " + richTextBox1.TextLength + "\n" +
                            "Абзацы:  " + CountAbz(myText) + "\n" +
                            "Пустые строки:  " + CountNullStr(myText) + "\n" +
                            "Авторские страницы:  " + Math.Round(countAuthorsPage, 1) + "\n" +
                            "Русские гласные:  " + CountChar(myText, Rusgl) + "\n" +
                            "Русские согласные:  " + CountChar(myText, Russog) + "\n" +
                            "Английские гласные:  " + CountChar(myText, Enggl) + "\n" +
                            "Английские согласные:  " + CountChar(myText, Engsog) + "\n" +
                            "Цифры:  " + CountChar(myText, Numbers) + "\n" +
                            "Спецсимволы:  " + CountChar(myText, Specialsymb) + "\n" +
                            "Знаки пунктуации:  " + CountChar(myText, Punctuation) + "\n" +
                            "Кириллические буквы:  " + CountChar(myText, RusA) + "\n" +
                            "Латинские буквы:  " + CountChar(myText, EngA) + "\n");

        }
        private void button1_Click(object sender, EventArgs e)// сохранить отредактированиый текст в файл 
        {
            string myText = richTextBox1.Text;
            richTextBox1.Text = richTextBox2.Text;
            richTextBox1.Text = myText;
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
                File.WriteAllText(sfd.FileName, richTextBox2.Text); //запись в новый файл

        }
        private string FunckRegex(string s)
        {
            string myText = richTextBox1.Text;
            string s1 = Convert.ToString(Regex.Match(myText, s));
            return s1;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string reg1 = @"[А-Я]{1}[а-я]{1,14} [А-Я]{1}[а-я]{1,14}";
            string reg2 = @"[А-Я][а-я]+\s[А-Я]\.[А-Я]\.";
            string reg3 = @"return|if|convert|string|int|Char";
            string reg4 = @"[а-я]{2}\.[А-Я]{1}[а-я]{1,15}\,\s[а-я]{1}\.[0-9]{1,4}\,\s[а-я]{2}\.[0-9]{1,4}\,\s[а-я]{1}\.[А-Я]{1}[а-я]{2,15}\,\s[0-9]{5}";
            string reg5 = @"[a-z]{3,15}\.edu.ua|[a-z]{3,15}\.net.ua|[a-z]{3,15}\.com.ua|[a-z]{3,15}\.in.ua|[a-z]{3,15}\.org.ua";
            string reg6 = @"\‘[0-9]{1,9}\’|\“[0-9]{1,9}\”";
            string reg7 = @"\’[0-9]{1,9}\.[0-9]{1,9}\’|\”[0-9]{1,9}\.[0-9]{1,9}\”";
            string reg8 = @"\‘[0-9]{1,9}\+[a-z]{1}\’|\”[0-9]{1,9}\-[0-9]{1,9}\*[a-z]{1}\”";
            string reg9 = @"([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
         @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
         @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)";
            string s1 = FunckRegex(reg1);
            string s2 = FunckRegex(reg2);
            string s3 = FunckRegex(reg3);
            string s4 = FunckRegex(reg4);
            string s5 = FunckRegex(reg5);
            string s6 = FunckRegex(reg6);
            string s7 = FunckRegex(reg7);
            string s8 = FunckRegex(reg8);
            string s9 = FunckRegex(reg9);
            MessageBox.Show(s1 + "\n" + s2 + "\n" + s3 + "\n" + s4 + "\n" + s5 + "\n" + s6 + "\n" + s7 + "\n" + s8 + "\n" + s9);

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
