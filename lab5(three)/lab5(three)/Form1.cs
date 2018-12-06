using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_three_
{
    public partial class Form1 : Form
    {
        static Color CurrentColor = Color.Black;// цвет пера 
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        int size = 5; 
        public Form1()
        {
            InitializeComponent();
            g = pBoxRec1.CreateGraphics();
            pen = new Pen(CurrentColor, 5);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        Circle circle = new Circle();
        private void круглыйХолстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            circle.newForm = new Form2();
            circle.newForm.Show();
        }
        Rectan rectan = new Rectan();
        private void прямокутнийХолстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rectan.newForm = new Form1();
            rectan.newForm.Show();
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(0, 0, 597, 411);
            GraphicsPath path = new GraphicsPath();
            path.AddRectangle(rect);
            Region region = new Region(path);
            pBoxRec1.Region = region;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char str = e.KeyChar;
            if (!Char.IsDigit(str) && str != '\b' && str != ' ') 
            {
                e.Handled = true;
            }
        }

        private void pBoxRec1_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                touch(e);
            }
        }

        private void pBoxRec1_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            SolidBrush solidBrush = new SolidBrush(CurrentColor);
            g.FillEllipse(solidBrush, e.X, e.Y, 5, 5);
            x = e.X;
            y = e.Y;
        }

        private void pBoxRec1_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = e.X;
            y = e.Y;
        }

        private void выбратьЦветПераToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == System.Windows.Forms.DialogResult.OK)
            {
                CurrentColor = colorDialog1.Color;
            }
            pen = new Pen(CurrentColor, 5);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(textBox1.Text);
            pen = new Pen(CurrentColor, size);
        }
        private void touch(MouseEventArgs e)
        {
            g.DrawRectangle(pen, e.X, e.Y, size, size);
            x = e.X;
            y = e.Y;
        }

        private void очиститьПолеToolStripMenuItem_Click(object sender, EventArgs e)
        {
           pBoxRec1.Refresh();
        }
        
    }

    
}
