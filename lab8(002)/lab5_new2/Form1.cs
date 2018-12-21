using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace lab5_new2
{
    public partial class Form1 : Form
    {
        Point lastPoint = Point.Empty;
        bool isMouseDown = new Boolean();

        Point lastPoint1 = Point.Empty;
        bool isMouseDown1 = new Boolean();

        static Color CurrentColor = Color.Black;
        //Point CurrentPoint, CurrentPoint1; 
        ///Point PrevPoint, PrevPoint1; 
        //bool isPressed, isPressed1;

        Graphics g, g1;
        Pen p,p1;
        int count = 1;
        int count1 = 1;
        iFigure klon = new CopyCircle();
        iFigure klon1 = new CopyRectangle();
        ///
        public PictureBox pb1 = new PictureBox();//холст1
        public PictureBox pb2 = new PictureBox();
        public NumericUpDown nm1 = new NumericUpDown(); //размер кисти 
        public NumericUpDown nm2 = new NumericUpDown();
        
        public Form1()
        {  ///
            //circle 
            pb1.Left = 5;
            pb1.Top = 5;
            pb1.Width = 438;
            pb1.Height = 415;
            pb1.BackColor = Color.White;
            this.Controls.Add(pb1);     
            //rectangle
            pb2.Left = 490;
            pb2.Top = 3;
            pb2.Width = 459;
            pb2.Height = 415;
            pb2.BackColor = Color.White;
            this.Controls.Add(pb2);
            //numericupdown1 for bruch
            nm1.Left = 995;
            nm1.Top = 133;
            nm1.Value = 0;//значение по умолчанию 
            this.Controls.Add(nm1);
            //numericupdown2
            nm2.Left = 995;
            nm2.Top = 195;
            nm2.Value = 0;
            this.Controls.Add(nm2);

            Form1 f = this;
            this.pb1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb1_MouseDown);
            this.pb1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb1_MouseMove);
            this.pb1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb1_MouseUp);
            this.pb2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb2_MouseDown);
            this.pb2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pb2_MouseMove);
            this.pb2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb2_MouseUp);

            Client first = new Client(new CircleFactory());
            first.Canvas(f);
            first.Pen(f);
             
            Client second = new Client(new RectangleFactory());
            second.Canvas(f);
            second.Pen(f);

            InitializeComponent();

            klon.pbox1 = pb1;
            klon1.pbox2 = pb2;
        }

        public void Rect_canv()
        {
            g = pb2.CreateGraphics();         
        }

        public void Circle_canv()
        {           
            this.Load += new EventHandler(Form1_Load);
        }

        void Form1_Load(object sender, EventArgs e)
        {           
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, 400, 400);
            Region rgn = new Region(path);
            pb1.Region = rgn;          
        }

        public void Circle_pen()
        {
            p = new Pen(CurrentColor, float.Parse(nm1.Text));
            p.StartCap = LineCap.RoundAnchor;
            p.EndCap = LineCap.RoundAnchor;
        }  

        public void Rect_pen()
        {
            p1 = new Pen(CurrentColor, float.Parse(nm2.Text));
            p1.StartCap = LineCap.SquareAnchor;
            p1.EndCap = LineCap.SquareAnchor;
            
        }
        private void button2_Click(object sender, EventArgs e)//очистка холста 
        {
           // pb1.Refresh();
            //pb2.Refresh();

             if (pb1.Image != null || pb2.Image != null)
             {
                 pb1.Image = null;
                 pb2.Image = null;
                 count = 1;
                 count1 = 1;
                 Invalidate();
             }
        }

        private void button1_Click(object sender, EventArgs e)//выбор цвета кисти 
        {
            DialogResult D = colorDialog1.ShowDialog();
            if (D == DialogResult.OK)
                CurrentColor = colorDialog1.Color;
        }
                       
        private void pb1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = e.Location;
            isMouseDown = true;
        }

        private void pb1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown == true)
            {
                if (lastPoint != null)
                {
                    if (pb1.Image == null)
                    {                       
                        Bitmap bmp = new Bitmap(pb1.Width, pb1.Height);                        
                        pb1.Image = bmp;
                        
                    }
                    
                    using (g = Graphics.FromImage(pb1.Image))
                    {
                      
                        p = new Pen(CurrentColor, float.Parse(nm1.Text));
                        p.StartCap = LineCap.RoundAnchor;
                        p.EndCap = LineCap.RoundAnchor;
                        
                        if (count == 1)
                        {
                            g.Clear(Color.White);
                            count--;
                        }  
                        g.DrawLine(p, lastPoint, e.Location);
                        g.SmoothingMode = SmoothingMode.AntiAlias;
                    }
                    pb1.Invalidate();
                    lastPoint = e.Location;
                }
            }
        }

        private void pb1_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown = false;
            lastPoint = Point.Empty;
        }

        private void pb2_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint1 = e.Location;
            isMouseDown1 = true;
        }

        private void pb2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown1 == true)
            {
                if (lastPoint1 != null)
                {
                    if (pb2.Image == null)
                    {
                        Bitmap bmp1 = new Bitmap(pb2.Width, pb2.Height);
                        pb2.Image = bmp1;
                    }

                    using (g1 = Graphics.FromImage(pb2.Image))
                    {
                        p1 = new Pen(CurrentColor, float.Parse(nm2.Text));
                        p1.StartCap = LineCap.SquareAnchor;
                        p1.EndCap = LineCap.SquareAnchor;
                        if (count1 == 1)
                        {
                            g1.Clear(Color.White);
                            count1--;
                        }
                        g1.DrawLine(p1, lastPoint1, e.Location);
                        g1.SmoothingMode = SmoothingMode.AntiAlias;
                    }
                    pb2.Invalidate();
                    lastPoint1 = e.Location;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pb2_MouseUp(object sender, MouseEventArgs e)
        {
            isMouseDown1 = false;
            lastPoint1 = Point.Empty;
        }

        
        private void button3_Click(object sender, EventArgs e)//копировать с круглого холста
        {
            klon.Clone(klon);
        }

        private void button5_Click(object sender, EventArgs e)//вставить в круглый холст
        {
            klon.Paste(klon);
        }
               
        private void button4_Click(object sender, EventArgs e)//копировать с прямоугольного холста
        {
            klon1.Clone(klon1);
        }

        
        private void button6_Click(object sender, EventArgs e)//вставить в прямокутний холст
        {
            klon1.Paste(klon1);
        }
        
    }
}
