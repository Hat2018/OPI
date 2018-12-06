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
    public partial class Form2 : Form
    {
        static Color CurrentColor = Color.Black;
        Graphics g;
        int x = -1;
        int y = -1;
        bool moving = false;
        Pen pen;
        int size = 5;
        public Form2()
        {
            InitializeComponent();
            g = pBoxCircl.CreateGraphics();
            pen = new Pen(CurrentColor, 5);
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            pen.StartCap = pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
        }
        private void touch(MouseEventArgs e)
        {
            pen.StartCap = LineCap.RoundAnchor;
            pen.EndCap = LineCap.RoundAnchor;
            g.DrawLine(pen, new Point(x, y), e.Location);
            x = e.X;
            y = e.Y;
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            Rectangle rect = new Rectangle(100, 0, 400, 400);
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(rect);
            Region region = new Region(path);
            pBoxCircl.Region = region;
        }

        private void круглыйХолстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Form2 = new Form2();
            Form2.Show();
        }

        private void прямокутнийХолстToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 Form1 = new Form1();
            Form1.Show();
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

        private void pBoxCircl_MouseMove(object sender, MouseEventArgs e)
        {
            if (moving && x != -1 && y != -1)
            {
                touch(e);
            }
        }

        private void pBoxCircl_MouseDown(object sender, MouseEventArgs e)
        {
            moving = true;
            SolidBrush solidBrush = new SolidBrush(CurrentColor);
            g.FillEllipse(solidBrush, e.X, e.Y, 5, 5);
            x = e.X;
            y = e.Y;
        }

        private void pBoxCircl_MouseUp(object sender, MouseEventArgs e)
        {
            moving = false;
            x = e.X;
            y = e.Y;
        }

        private void очиститьПолеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pBoxCircl.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int size = Convert.ToInt32(textBox1.Text);
            pen = new Pen(CurrentColor, size);
        }

        private void pBoxCircl_Click(object sender, EventArgs e)
        {

        }
    }
}
