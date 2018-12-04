using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppnew
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox1.Text);
            string[] arr = new string[100];
            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    arr[i] = Convert.ToString(i);
                }
                
                textBox2.Text = String.Join(" ", arr);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox3.Text);
            if (num % 2 == 0)
            {
                label4.Text = "число четное";
                if (num % 4 == 0)
                {
                    label5.Text = "число делится на 4";
                }
                else
                {
                    label5.Text = "число не делится на 4";
                }
            }
            else
            {
                label4.Text = "число нечетное";
                label5.Text = "число не делится на 4";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int num = Convert.ToInt32(textBox3.Text);
            int numm = Convert.ToInt32(textBox4.Text);
            if (num % numm == 0)
            {
                label7.Text = "Число " + num.ToString("n") + " делится на число " + numm.ToString("n");
            }

            else

            if ((num % numm != 0) && (numm % num != 0))
            {
                label8.Text = "Числа не делятся друг на друга";
                textBox4.Focus();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int kol = Convert.ToInt32(textBox5.Text);
            string abc = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM_0123456789";
            string result = "";
            Random rnd = new Random();
            
            if (kol > 20)
            {
                textBox6.Text = "пароль слишком длинный";
            }
            else
            {
                int lng = abc.Length;
                for (int i = 0; i < kol; i++)
                {
                    result += abc[rnd.Next(lng)];
                }
                textBox6.Text = result;
            }
           
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            string name = textBox7.Text;
            int year = DateTime.Now.Year;
            int enteryear = Convert.ToInt32(textBox8.Text);
            int sub = 100 - enteryear;
            int res = year + sub;
            label15.Text = name + ", " + " Вам будет 100 лет в " + res.ToString("n") + " году";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int enteryear = Convert.ToInt32(textBox8.Text);
            string name = textBox7.Text;
            int year = DateTime.Now.Year;
            int sub = 100 - enteryear;
            int res = year + sub;
            int n = Convert.ToInt32(textBox9.Text);
            string[] arr = new string[n];
            if ((n <= 10) && (n > 0))
            {
                for (int i = 0; i < n; i++)
                {
                    arr[i] = name + "," + "Вам будет 100 лет в " + res.ToString("n") + " году";
                }
                label16.Text = string.Join("\n", arr);

            }
        }
    }
}
